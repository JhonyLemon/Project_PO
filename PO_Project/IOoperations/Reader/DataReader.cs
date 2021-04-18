using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace PO_Project
{
    class DataReader : DataParser,IDataReader
    {
        List<IElement> elements = new List<IElement>();

        public DataReader()
        {
            if (File.Exists(defaultlocation + @"\data.csv"))
            {

            }
            else
            {
                Directory.CreateDirectory(defaultlocation);
                File.Create(defaultlocation + @"\data.csv");
            }
        }

        public List<IElement> ReadElements()
        {
            try
            {
                TextReader textReader = null;
                string line = "";
                textReader = new StreamReader(defaultlocation + @"\data.csv");
                while (!string.IsNullOrEmpty(line = textReader.ReadLine()))
                {
                    string[] s = line.Split(',');
                    switch (s[0])
                    {
                        case "Book":
                            {
                                break;
                            }
                        case "Film":
                            {
                                DateTime dateTime;
                                DateTime.TryParse(s[7], out dateTime);
                                TimeSpan timeSpan;
                                TimeSpan.TryParse(s[4], out timeSpan);
                                elements.Add(new Film(s[1], (Category)Enum.Parse(typeof(Category), s[2]), s[3], timeSpan, s[5], s[6], dateTime));
                                break;
                            }
                        case "Music":
                            {
                                break;
                            }
                        case "Game":
                            {
                                break;
                            }
                    }

                }
                textReader.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Bd odczytu:" + ex.Message);
            }
            return elements;
        }
    }
}
