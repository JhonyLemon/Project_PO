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
        public DataWriter(IElement element) : base(element)
        {

        }



        public DataWriter(string element, ElementType elementType) : base(element,elementType)
        {

        }



        public List<IElement> EditElement()
        {
            throw new NotImplementedException();
        }

        public List<IElement> DeleteElement()
        {
            throw new NotImplementedException();
        }
        public IElement AddElement()
        {
            if (File.Exists(defaultlocation + @"\data.csv"))
            {
                try
                {
                    TextWriter textWriter;
                    var numberOfLines = File.ReadAllLines(defaultlocation + @"\data.csv").Length;
                    textWriter = new StreamWriter(defaultlocation + @"\data.csv", true);
                    textWriter.WriteLine(StringBuilder.ToString());
                    textWriter.Dispose();
                }
                catch (Exception ex)
                {
                    throw new Exception("Bd odczytu:" + ex.Message);
                }
                
            }
            return Element;
        }

    }
}
