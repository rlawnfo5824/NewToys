using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;
using NewToys.Core.Define.Names;
using Prism.Ioc;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewToys.Core.Alert
{
    public partial class AlertDialogViewModel : ObservableBase, IDialogAware
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;
        private readonly IDialogService _dialogService;

        private string title;
        public string Title { get => title; set => SetProperty(ref title, value); }

        public event Action<IDialogResult> RequestClose;

        public AlertDialogModel Model { get; set; } = new();

        public AlertDialogViewModel(IRegionManager regionManager, IContainerProvider containerProvider, IDialogService dialogService)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
            _dialogService = dialogService;            
        }

        public virtual void RaiseRequestClose(IDialogResult dialogResult)
        {
            RequestClose?.Invoke(dialogResult);
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Model.MainMessage = parameters.GetValue<string>(AlertDialogParamContentsNameManager.MainMessage);
            Model.SubMessage = parameters.GetValue<string>(AlertDialogParamContentsNameManager.SubMessage);
            Model.AlertType = parameters.GetValue<string>(AlertDialogParamContentsNameManager.AlertType);
        }

        [RelayCommand]
        private void Cancel()
        {
            //DialogParameters dialogParam = new DialogParameters();
            //dialogParam.Add("message", "취소 파라미터");
            RaiseRequestClose(new DialogResult(ButtonResult.Cancel));
        }

        [RelayCommand]
        private void Yes()
        {
            //DialogParameters dialogParam = new DialogParameters();
            //dialogParam.Add("message", "확인 파라미터");
            RaiseRequestClose(new DialogResult(ButtonResult.OK));
        }

    }
}
