﻿using System.Diagnostics;
namespace CornerShop.DependencyInjection
{
    public class ConsoleWriter : IConsoleWriter
    {
        public void Write()
        {
            Debug.WriteLine("Testing Dependency Injection...");
        }
    }
}

