using System;

namespace FileInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************Welcome to FileIO Program***********************");
            int count = 1;
            while(count!=2)
            {
                Console.WriteLine();
                Console.WriteLine("1.ReadData 2.WriteData 3.StreamReader 4.StreamWriter 5.Exit");
                Console.Write("Enter The Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        IOReadWrite.ReadData();
                        break;
                    case 2:
                        IOReadWrite.WriteData("\nCollections,Json,Nlog,Reflections,Anotations,FileIO,etc...");
                        break;
                    case 3:
                        IOReadWrite.StreamReadData();
                        break;
                    case 4:
                        string data = "\n In Data-Structures : Linked-List,Array-List,Hash-set,Hash-Map,BST,Dictionries,Stack,Queue,etc....";
                        IOReadWrite.StreamWriteData(data);
                        break;
                    default:
                        Console.WriteLine("Worng Input :)");
                        count++;
                        break;
                }
            }           
        }
    }
}
