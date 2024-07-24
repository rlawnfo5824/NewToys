using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using NewToys.Core.Define.Enums;
using NewToys.Core.Define.Names;
using Prism.Ioc;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewToys.Main
{
    public partial class MainViewModel : ObservableBase, IViewLoadable
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;        
        private readonly IDialogService _dialogService;


        public MainViewModel(IRegionManager regionManager, IContainerProvider containerProvider, IDialogService dialogService)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
            _dialogService = dialogService;
        }

        public void OnLoaded(IViewable view)
        {
            
        }


        [RelayCommand]
        private void Test()
        {
            DialogParameters parameters = new DialogParameters
            {
                { AlertDialogParamContentsNameManager.MainMessage, "알림창 내용입니다." },
                { AlertDialogParamContentsNameManager.SubMessage, "알림창 참고 내용입니다." },
                { AlertDialogParamContentsNameManager.AlertType,  AlertTypesNameManager.ERROR },
            };

            _dialogService.ShowDialog(ContentNameManager.AlertDialog, parameters, r =>
            {
                if (r.Result == ButtonResult.Cancel)
                {
                    
                }
                else if (r.Result == ButtonResult.OK)
                {
                    
                }
            }, DialogNameManager.AlertDialog);
        }
    }
}
