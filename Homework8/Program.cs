﻿using Homework8.Task1;
using Homework8.Task2;

namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MassiveElement.ShowMassiveElement();
            var exceptionGenerator = new ExceptionGenerator();
            exceptionGenerator.GenerateException();
        }
    }
}