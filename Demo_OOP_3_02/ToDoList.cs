using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_OOP_3_02
{
    internal class ToDoList
    {
        private string[] _tasks;

        public ToDoList(int Capacity)
        {
            _tasks = new string[Capacity];
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= _tasks.Length)
                {
                    Console.WriteLine("Index is out of range.");
                }
                return _tasks[index];
            }
            set
            {
                if (index < 0 || index >= _tasks.Length)
                {
                    Console.WriteLine("Index is out of range.");
                }
                _tasks[index] = value;
            }
        }
    }
}
