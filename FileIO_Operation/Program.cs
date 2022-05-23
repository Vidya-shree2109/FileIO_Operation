using System;
using FileIO_Operation;
class program
{
    public static void Main(string[] args)
    {
        Operation operation = new Operation();
        operation.FileExists();
        operation.ReadAllLines();
        operation.ReadAllText();
        operation.CopyFile();
        operation.DeleteFilePath();
        operation.UsingStreamReader();
    }
}