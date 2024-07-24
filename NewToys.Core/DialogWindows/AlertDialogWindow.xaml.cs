using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
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

namespace NewToys.Core.DialogWindows
{
    /// <summary>
    /// AlertDialogWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AlertDialogWindow : Window, IDialogWindow
    {
        public IDialogResult Result { get; set; }

        public AlertDialogWindow()
        {
            InitializeComponent();
        }

        private void Grid_title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton != MouseButtonState.Pressed)
            {
                return;
            }
            this.DragMove();
        }
    }
}
