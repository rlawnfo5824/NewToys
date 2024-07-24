using Jamesnet.Wpf.Global.Location;
using NewToys.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewToys.Initialize
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        /// <summary>
        /// View <-> ViewModel을 연결
        /// </summary>
        /// <param name="items"></param>
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<MainView, MainViewModel>();
        }
    }
}
