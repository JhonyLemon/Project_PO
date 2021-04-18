using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PO_Project
{
    class DataWriter : DataParser,IDataWriter 
    {


        public IElement AddElement(IElement element)
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

        public bool Update(List<IElement> elements)
        {
            if (File.Exists(defaultlocation + @"\data.csv"))
            {
                try
                {
                    File.Delete(defaultlocation + @"\data.csv");
                    FileStream fs = File.Create(defaultlocation + @"\data.csv");
                    fs.Dispose();
                    TextWriter textWriter;
                    textWriter = new StreamWriter(defaultlocation + @"\data.csv");
                    foreach(IElement element in elements)
                    {
                        textWriter.WriteLine(FromElementToString(element));
                    }
                    textWriter.Dispose();
                }
                catch (Exception ex)
                {
                    throw new Exception("Bd odczytu:" + ex.Message);
                }
            }
            return true;
        }
    }
}
