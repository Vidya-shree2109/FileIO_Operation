using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Operation
{
    public class Operation
    {
        string filePath = @"E:\PracticeProblems\FileInputOutputOperation\FileIO_Operation\FileIO_Operation\ExampleFile.txt";
        string copyFilePath = @"E:\PracticeProblems\FileInputOutputOperation\FileIO_Operation\FileIO_Operation\ExampleFile.txt";
        public void FileExists()
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File exists");
                return;
            }
            File.Create(filePath);
        }
        public void ReadAllLines()
        {
            string[] arr = File.ReadAllLines(filePath);
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
        public void ReadAllText()
        {
            string lines = File.ReadAllText(filePath);
            Console.WriteLine(lines);
        }
        public void CopyFile()
        {
            File.Copy(filePath, copyFilePath);
        }
        public void DeleteFilePath()
        {
            File.Delete(copyFilePath);
        }
        public void UsingStreamReader()
        {
            if (File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);
                try
                {
                    string s = "";
                    while ((s = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    reader.Close();
                }
            }
        }
    }
}
