using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (!File.Exists(defaultlocation + @"\data.csv"))
            {
                Directory.CreateDirectory(defaultlocation);
                FileStream fs = File.Create(defaultlocation + @"\data.csv");
                fs.Dispose();
            }
            List<Element> elements = new List<Element>();
                try
                {
                    TextReader textReader = null;
                    string line = "";
                    textReader = new StreamReader(defaultlocation + @"\data.csv");
                    while (!string.IsNullOrEmpty(line = textReader.ReadLine()))
                    {
                        elements.Add(FromStringToElement(line));
                    }
                    textReader.Dispose();
                }
                catch (Exception ex)
                {
                    throw new Exception("Bd odczytu:" + ex.Message);
                }

                return elements;
        }


        public bool Update(List<Element> elements)
        {
                try
                {
                    FileStream fs = File.Create(defaultlocation + @"\data.csv");
                    fs.Dispose();
                    TextWriter textWriter;
                    textWriter = new StreamWriter(defaultlocation + @"\data.csv");
                    foreach (Element element in elements)
                    {
                        textWriter.WriteLine(FromElementToString(element));
                    }
                    textWriter.Dispose();
                }
                catch (Exception ex)
                {
                    throw new Exception("Bd odczytu:" + ex.Message);
                }
            return true;
        }

        public Element AddElement(Element element)
        {
            if (File.Exists(defaultlocation + @"\data.csv"))
            {
                try
                {
                    TextWriter textWriter;
                    textWriter = new StreamWriter(defaultlocation + @"\data.csv", true);
                    textWriter.WriteLine(FromElementToString(element));
                    textWriter.Dispose();
                }
                catch (Exception ex)
                {
                    throw new Exception("Bd odczytu:" + ex.Message);
                }

            }
            return element;
        }

    }
}
