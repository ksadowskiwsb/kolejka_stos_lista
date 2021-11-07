﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    /// <summary>
    /// Tests the linked lists
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests the linked lists
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            //TestUnsortedLinkedList.RunTestCases();
            //TestSortedLinkedList.RunTestCases();

            UnsortedLinkedList<int> lista = new UnsortedLinkedList<int>();

            Console.WriteLine("ADD");
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);

            lista.LinkedListPrint();

            Console.WriteLine("REMOVE");
            lista.Remove(3);

            lista.LinkedListPrint();

            Console.ReadKey();
        }
    }
}
