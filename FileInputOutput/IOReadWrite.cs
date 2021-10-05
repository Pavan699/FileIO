using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FileInputOutput
{    
    /// <summary>
    /// Class to do the File read,write and streamreder and streamwriter operations
    /// </summary>
    class IOReadWrite
    {
        /// <summary>
        /// ReadFilePath to read the Data and WriteFilePath to write the data in file
        /// </summary>
        internal const string ReadFilePath = @"D:\VS .net\FileInputOutput\FileInputOutput\ReadFileData.txt";
        internal const string WriteFilePath = @"D:\VS .net\FileInputOutput\FileInputOutput\WriteFileData.txt";
        /// <summary>
        /// This method Read all the data in the File if it is exits
        /// </summary>
        public static void ReadData()
        {
            Console.WriteLine("++++++++++++++++++++++++++++Read-File+++++++++++++++++++++++++++++++++");
            if (File.Exists(ReadFilePath))
            {
                Console.WriteLine(File.ReadAllText(ReadFilePath));
            }
            else { Console.WriteLine("File Done Not Exists :)"); }
            Console.WriteLine("**********************************************************************");
        }
        /// <summary>
        /// WirteData method to wirte the data in the file
        /// </summary>
        /// <param name="inputdata"></param>
        public static void WriteData(string inputdata)
        {
            Console.WriteLine("++++++++++++++++++++++++++++Write-File+++++++++++++++++++++++++++++++++");
            File.AppendAllText(WriteFilePath, inputdata);
            Console.WriteLine("String is Added");          
            Console.WriteLine("**********************************************************************");
        }
        /// <summary>
        /// StreamReader used to read the data from the file
        /// </summary>
        public static void StreamReadData()
        {
            //Without "using" keyword
            Console.WriteLine("+++++++++++++++++++++++++StreamReader-File++++++++++++++++++++++++++++++");
            Console.WriteLine("Without 'using' keyword : ");
            StreamReader streamReader = new StreamReader(ReadFilePath);
            Console.WriteLine(streamReader.ReadToEnd());           
            Console.WriteLine("**********************************************************************");
            //With "using" keyword 
            Console.WriteLine("With 'using' Keyword");
            using (StreamReader streamReaderusing = new StreamReader(ReadFilePath))
            {
                while (!streamReaderusing.EndOfStream)
                {
                    Console.WriteLine(streamReaderusing.ReadLine());
                }
            }
            streamReader.Close();
        }
        /// <summary>
        /// StreamWriter to write the data in the file
        /// </summary>
        /// <param name="data"></param>
        public static void StreamWriteData(string data)
        {
            Console.WriteLine("++++++++++++++++++++++++StreamWriter-File++++++++++++++++++++++++++++++");           
            StreamWriter streamWriter = new StreamWriter(WriteFilePath,true);
            streamWriter.WriteLine(data);
            Console.WriteLine("Data is Added");
            streamWriter.Close();
            Console.WriteLine("**********************************************************************");
        }
    }
}
