﻿using NewToys.Initialize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewToys
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            new App()
                .AddInversionModule<ViewModules>()
                .AddWireDataContext<WireDataContext>()
                .Run();
        }
    }
}
