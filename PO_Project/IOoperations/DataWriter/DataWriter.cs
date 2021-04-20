using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PO_Project
{
    /// <summary>
    /// Derived class from base class DataParser
    /// Contains methods that can be used to load data to file
    /// </summary>
    /// <remarks>
    /// This class writes data into .csv files
    /// </remarks>
    class DataWriter : DataParser,IDataWriter 
    {

        /// <summary>
        /// Method adds new element at the end of .csv file
        /// </summary>
        /// <returns>
        /// Returns a variable of IElement type
        /// </returns>
        /// <param name="element">IElement</param>
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

        /// <summary>
        /// Method adds new element at the end of .csv file
        /// </summary>
        /// <returns>
        /// Returns a variable of IElement type
        /// </returns>
        /// <param name="photoData">PhotoData</param>
        public PhotoData AddPhoto(PhotoData photoData)
        {
            if (File.Exists(defaultlocation + @"\photodata.csv"))
            {
                try
                {
                    TextWriter textWriter;
                    textWriter = new StreamWriter(defaultlocation + @"\photodata.csv", true);
                    textWriter.WriteLine(FromPhotoDataToString(photoData));
                    textWriter.Dispose();   
                }
                catch (Exception ex)
                {
                    throw new Exception("Bd odczytu:" + ex.Message);
                }

            }
            return photoData;
        }

        /// <summary>
        /// Method updates .scv file, loading new data into it
        /// </summary>
        /// <returns>
        /// Returns a bool value,true if updated successfully
        /// </returns>
        /// <param name="elements">List of IElement</param>
        public bool Update(List<IElement> elements)
        {
            if (File.Exists(defaultlocation + @"\data.csv"))
            {
                try
                {
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

        /// <summary>
        /// Method updates .scv file, loading new data into it
        /// </summary>
        /// <returns>
        /// Returns a bool value,true if updated successfully
        /// </returns>
        /// <param name="photoData">List of PhotoData</param>
        public bool Update(List<PhotoData> photoData)
        {
            if (File.Exists(defaultlocation + @"\data.csv"))
            {
                try
                {
                    FileStream fs = File.Create(defaultlocation + @"\photodata.csv");
                    fs.Dispose();
                    TextWriter textWriter;
                    textWriter = new StreamWriter(defaultlocation + @"\photodata.csv");
                    foreach (PhotoData photo in photoData)
                    {
                        textWriter.WriteLine(FromPhotoDataToString(photo));
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
