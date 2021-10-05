using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FileInputOutput
{    
    class IOReadWrite
    {
        internal const string ReadFilePath = @"D:\VS .net\FileInputOutput\FileInputOutput\ReadFileData.txt";
        internal const string WriteFilePath = @"D:\VS .net\FileInputOutput\FileInputOutput\WriteFileData.txt";

        public static void ReadData()
        {
            Console.WriteLine("++++++++++++++++++++++++++++Read-File+++++++++++++++++++++++++++++++++");
            Console.WriteLine( File.ReadAllText(ReadFilePath));
            Console.WriteLine("**********************************************************************");
        }
        public static void WriteData(string inputdata)
        {
            Console.WriteLine("++++++++++++++++++++++++++++Write-File+++++++++++++++++++++++++++++++++");
            File.AppendAllText(WriteFilePath, inputdata);
            Console.WriteLine("String is Added");          
            Console.WriteLine("**********************************************************************");
        }

        public static void StreamReadData()
        {
            //Without "using" keyword
            Console.WriteLine("+++++++++++++++++++++++++StreamReader-File++++++++++++++++++++++++++++++");
            Console.WriteLine("Without 'using' keyword : ");
            StreamReader streamReader = new StreamReader(ReadFilePath);
            Console.WriteLine(streamReader.ReadToEnd());           
            Console.WriteLine("**********************************************************************");
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
