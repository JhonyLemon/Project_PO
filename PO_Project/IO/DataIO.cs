using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PO_Project
{
    class DataIO : DataParser, IDataReader, IDataWriter
    {
            private DataIO() { }

            private static DataIO _instance;

            // We now have a lock object that will be used to synchronize threads
            // during first access to the Singleton.
            private static readonly object _lock = new object();
            private static readonly object _operationLock = new object();

            public static DataIO GetInstance()
            {
                // This conditional is needed to prevent threads stumbling over the
                // lock once the instance is ready.
                if (_instance == null)
                {
                    // Now, imagine that the program has just been launched. Since
                    // there's no Singleton instance yet, multiple threads can
                    // simultaneously pass the previous conditional and reach this
                    // point almost at the same time. The first of them will acquire
                    // lock and will proceed further, while the rest will wait here.
                    lock (_lock)
                    {
                        // The first thread to acquire the lock, reaches this
                        // conditional, goes inside and creates the Singleton
                        // instance. Once it leaves the lock block, a thread that
                        // might have been waiting for the lock release may then
                        // enter this section. But since the Singleton field is
                        // already initialized, the thread won't create a new
                        // object.
                        if (_instance == null)
                        {
                            _instance = new DataIO();
                        }
                    }
                }
                return _instance;
            }


        public List<Element> ReadElements()
        {
            if (!File.Exists(defaultlocation + @"\data.csv"))//jesli plik nie istnieje
            {
                Directory.CreateDirectory(defaultlocation);//stworz nowy folder jesli nie istnieje
                FileStream fs = File.Create(defaultlocation + @"\data.csv");//stworz plik
                fs.Dispose();//zwolnij pamiec
            }
            List<Element> elements = new List<Element>();//inicjalizacja listy elementow
                try
                {
                    TextReader textReader = null;//stworzenie zmiennej typu TextReader
                    string line = "";//stworzenie pustego stringa
                    textReader = new StreamReader(defaultlocation + @"\data.csv");//inicjalizacja textReader
                    while (!string.IsNullOrEmpty(line = textReader.ReadLine()))//czytanie linijka po linijce dopoki zczytana wartosc nie jest pusta
                    {
                        elements.Add(FromStringToElement(line));//dodanie do listy elementow
                    }
                    textReader.Dispose();//zwolnienie pamieci
                }
                catch (Exception ex)
                {
                    throw new Exception("Bd odczytu:" + ex.Message);
                }

                return elements;//zwrocenie listy elementow
        }


        public bool Update(List<Element> elements)
        {
                try
                {
                    FileStream fs = File.Create(defaultlocation + @"\data.csv");//usuniecie zawartosci pliku
                    fs.Dispose();//zwolnienie pamieci
                    TextWriter textWriter;//zmienna typu TextWritter
                    textWriter = new StreamWriter(defaultlocation + @"\data.csv");//inicjalizacja textWriter
                    foreach (Element element in elements)//dla kazdego elementu
                    {
                        textWriter.WriteLine(FromElementToString(element));//zamien na string i wpisz do pliku
                    }
                    textWriter.Dispose();//zwolnienie pamieci
                }
                catch (Exception ex)
                {
                    throw new Exception("Bd odczytu:" + ex.Message);
                }
            return true;
        }

        public Element AddElement(Element element)
        {
            if (File.Exists(defaultlocation + @"\data.csv"))//jesli plik istnieje
            {
                try
                {
                    TextWriter textWriter;//zmienna typu TextWritter
                    textWriter = new StreamWriter(defaultlocation + @"\data.csv", true);//inicjalizacja textWriter
                    textWriter.WriteLine(FromElementToString(element));//zamien na string i wpisz do pliku
                    textWriter.Dispose();//zwolnienie pamieci
                }
                catch (Exception ex)
                {
                    throw new Exception("Bd odczytu:" + ex.Message);
                }

            }
            return element;
        }
        public void Open(string path)
        {
            if(File.Exists(path))
                System.Diagnostics.Process.Start(path);//otwarcie pliku domyslna aplikacja
            else
                MessageBox.Show("Podana lokalizacja pliku jest bledna", "Blędna lokacja", MessageBoxButtons.OK);
        }

    }
}
