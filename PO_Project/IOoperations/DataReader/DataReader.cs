using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace PO_Project
{
    /// <summary>
    /// Derived class from base class DataParser
    /// Contains methods that can be used to read from data file
    /// </summary>
    /// <remarks>
    /// This class load .csv files into program
    /// </remarks>
    class DataReader : DataParser,IDataReader
    {

        /// <summary>
        /// DataReader constructor
        /// </summary>
        /// <remarks>
        /// Checks if data file is in default location, if not creates new one
        /// </remarks>
        public DataReader()
        {
            if (!File.Exists(defaultlocation + @"\data.csv"))
            { 
                Directory.CreateDirectory(defaultlocation);
                FileStream fs = File.Create(defaultlocation + @"\data.csv");
                fs.Dispose();
            }
            if (!File.Exists(defaultlocation + @"\photodata.csv"))
            {
                Directory.CreateDirectory(defaultlocation);
                FileStream fs = File.Create(defaultlocation + @"\photodata.csv");
                fs.Dispose();
            }
        }

        /// <summary>
        /// Method that reads .csv file line by line
        /// </summary>
        /// <returns>
        /// Returns a List of IElement type
        /// </returns>
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
        /// <summary>
        /// Method that reads .csv file line by line
        /// </summary>
        /// <returns>
        /// Returns a List of PhotoData type
        /// </returns>
        public List<PhotoData> ReadPhotoData()
        {
            List<PhotoData> photodata = new List<PhotoData>();
            try
            {
                TextReader textReader = null;
                string line = "";
                textReader = new StreamReader(defaultlocation + @"\photodata.csv");
                while (!string.IsNullOrEmpty(line = textReader.ReadLine()))
                {
                    photodata.Add(FromStringToPhotoData(line));
                }
                textReader.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Bd odczytu:" + ex.Message);
            }
            return photodata;
        }

    }
}
