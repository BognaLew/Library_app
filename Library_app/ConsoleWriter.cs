﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Library_app
{
    public class ConsoleWriter
    {
        /// <summary>
        /// Displays info about calculated penalty.
        /// </summary>
        /// <param name="penalty">Penalty to display.</param>
        public void WriteOnConsole(int penalty)
        {
            if(penalty == 0)
            {
                Console.WriteLine("Borrower has no fee to pay.");
            }
            else
            {
                Console.WriteLine($"Borrower penalty fee is {penalty} PLN.");
            }
        }
    }
}
