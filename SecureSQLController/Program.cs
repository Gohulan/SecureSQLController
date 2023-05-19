using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Create a new process
        Process process = new Process();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        Console.WriteLine("=========================================================  ");
        Console.WriteLine("     SECURE SQL CONTROLLER V 2.0.2.4 ");
        Console.WriteLine("=========================================================  ");
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=========================================================  ");
        Console.WriteLine("# DEVELOPER :- GOHULAN SOMANATHAN ");
        Console.WriteLine("=========================================================  ");
        Console.WriteLine("# COMPNAY   :- HOSPITALITY TECHNOLOGY");
        Console.WriteLine("=========================================================  ");
        Console.WriteLine("# SQL VER   :- Microsoft SQL Server 2012 (SP4)");
        Console.WriteLine("=========================================================  ");
        Console.WriteLine("# APP VER   :- 2.0.2.4");
        Console.WriteLine("=========================================================  ");
        Console.WriteLine("# RELEASE   :- 15 MAR 2020");
        Console.WriteLine("=========================================================  ");
        Console.WriteLine("");

        Console.WriteLine("Analyzing Login Data");

        // Configure the process
        process.StartInfo.FileName = "cmd.exe";
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardInput = true;

        // Start the process
        process.Start();

        // Send the command to the process standard input
        process.StandardInput.WriteLine("net stop MSSQL$SQLEXPRESS");
        process.StandardInput.WriteLine("net start MSSQL$SQLEXPRESS /m");
        process.StandardInput.WriteLine("sqlcmd -S localhost\\SQLEXPRESS");
        process.StandardInput.WriteLine("alter login sa enable");
        process.StandardInput.WriteLine("alter login datastoredb enable");
        process.StandardInput.WriteLine("go");
        process.StandardInput.WriteLine("exit");
        process.StandardInput.WriteLine("net stop MSSQL$SQLEXPRESS");
        process.StandardInput.WriteLine("net start MSSQL$SQLEXPRESS");
        process.StandardInput.WriteLine("notepad.exe");

        
        process.StandardInput.Close();

        // Wait for the process to exit
        process.WaitForExit();

        Console.WriteLine("Succesfully Completed !");
    }
}
