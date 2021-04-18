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

        public DataReader()
        {
            if (!File.Exists(defaultlocation + @"\data.csv"))
            { 
                Directory.CreateDirectory(defaultlocation);
                FileStream fs = File.Create(defaultlocation + @"\data.csv");
                fs.Dispose();
            }
        }

        public List<IElement> ReadElements()
        {
            List<IElement> elements = new List<IElement>();
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
    }
}
