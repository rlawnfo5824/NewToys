using Jamesnet.Wpf.Controls;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NewToys.Core.AutoWire
{
    public class AutoWireManager
    {
        private FrameworkElement _view;

        public void InitializeAutoWire(FrameworkElement view)
        {
            _view = view;
            ViewModelLocationProvider.AutoWireViewModelChanged(view, AutoWireViewModelChanged);
        }

        public virtual void AutoWireViewModelChanged(object view, object dataContext)
        {
            _view.DataContext = dataContext;
            (dataContext as IViewInitializable)?.OnViewWired(view as IViewable);
            FrameworkElement frameworkElement = default(FrameworkElement);
            int num;
            if (dataContext is IViewLoadable)
            {
                frameworkElement = view as FrameworkElement;
                num = ((frameworkElement != null) ? 1 : 0);
            }
            else
            {
                num = 0;
            }

            if (num != 0)
            {
                frameworkElement.Loaded += JamesContent_Loaded;
            }
        }

        private void JamesContent_Loaded(object sender, RoutedEventArgs e)
        {
            FrameworkElement frameworkElement = sender as FrameworkElement;
            IViewLoadable viewLoadable = default(IViewLoadable);
            int num;
            if (frameworkElement != null)
            {
                viewLoadable = frameworkElement.DataContext as IViewLoadable;
                num = ((viewLoadable != null) ? 1 : 0);
            }
            else
            {
                num = 0;
            }

            if (num != 0)
            {
                frameworkElement.Loaded -= JamesContent_Loaded;
                viewLoadable.OnLoaded(frameworkElement as IViewable);
            }
        }

        public FrameworkElement GetView()
        {
            return _view;
        }

        public INotifyPropertyChanged GetDataContext()
        {
            INotifyPropertyChanged notifyPropertyChanged = _view.DataContext as INotifyPropertyChanged;
            return (notifyPropertyChanged != null) ? notifyPropertyChanged : null;
        }
    }
}
