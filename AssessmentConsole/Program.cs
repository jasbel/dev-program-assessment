﻿using System;

namespace AssessmentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            App app = new App();
            while (!exit) {
                Console.WriteLine("****************************************");
                Console.WriteLine(@"
                List paginator tool commands
                1. Paginate
                0. Exit
                "
                );
                Console.Write(">> ");
                string option = Console.ReadLine();
                exit = app.ProcessOption(option);
            }
        }
    }
}
