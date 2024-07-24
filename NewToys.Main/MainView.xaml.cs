using Jamesnet.Wpf.Controls;
using NewToys.Core.AutoWire;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NewToys.Main
{
    /// <summary>
    /// MainView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainView : Window, IViewable
    {
        private readonly AutoWireManager _autoWireManager;

        public FrameworkElement View => _autoWireManager.GetView();

        public INotifyPropertyChanged ViewModel => _autoWireManager.GetDataContext();

        public MainView()
        {
            _autoWireManager = new AutoWireManager();
            _autoWireManager.InitializeAutoWire(this);
            InitializeComponent();            
        }
    }
}
