using NewToys.Core.Alert;
using NewToys.Core.Define.Names;
using NewToys.Core.DialogWindows;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NewToys.Initialize
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider) { }

        /// <summary>
        /// Content View Singleton 등록
        /// </summary>
        /// <param name="containerRegistry"></param>
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ////Menus
            //containerRegistry.RegisterSingleton<IViewable, HomeView>(ContentNameManager.Home);
            //containerRegistry.RegisterSingleton<IViewable, SolutionAndCompanyView>(ContentNameManager.SolutionAndCompany);
            //containerRegistry.RegisterSingleton<IViewable, FileManagementView>(ContentNameManager.FileManagement);
            //containerRegistry.RegisterSingleton<IViewable, FileGroupManagementView>(ContentNameManager.FileGroupManagement);
            //containerRegistry.RegisterSingleton<IViewable, FileUploadView>(ContentNameManager.FileUpload);

            //containerRegistry.RegisterSingleton<IViewable, SolutionContent>(ContentNameManager.SolutionContent);
            //containerRegistry.RegisterSingleton<IViewable, CompanyContent>(ContentNameManager.CompanyContent);
            //containerRegistry.RegisterSingleton<IViewable, SolutionAndCompanySelectContent>(ContentNameManager.SolutionAndCompanySelect);

            //containerRegistry.RegisterSingleton<IViewable, FileInfoContent>(ContentNameManager.FileInfoContent);
            //containerRegistry.RegisterSingleton<IViewable, FileMultiAddContent>(ContentNameManager.FileMultiAddContent);

            //containerRegistry.RegisterSingleton<IViewable, FileGroupContent>(ContentNameManager.FileGroupContent);

            //containerRegistry.RegisterSingleton<IViewable, UploadContent>(ContentNameManager.UploadContent);
            //containerRegistry.RegisterSingleton<IViewable, HistoryContent>(ContentNameManager.HistoryContent);

            ////Repository Container
            //containerRegistry.RegisterSingleton<RepositoryContainer>();


            ////Dialog Window
            //containerRegistry.RegisterDialogWindow<MyDialogWindow>(DialogNameManager.CommonDialog);
            containerRegistry.RegisterDialogWindow<AlertDialogWindow>(DialogNameManager.AlertDialog);





            ////Dialog content
            containerRegistry.RegisterDialog<AlertDialogView, AlertDialogViewModel>(ContentNameManager.AlertDialog);
            //containerRegistry.RegisterDialog<LoginView, LoginViewModel>(ContentNameManager.Login);
            //containerRegistry.RegisterDialog<UserAddUpdateDialogView, UserAddUpdateDialogViewModel>(ContentNameManager.UserAddUpdate);
            //containerRegistry.RegisterDialog<UserGroupDialogView, UserGroupDialogViewModel>(ContentNameManager.UserGroup);
            //containerRegistry.RegisterDialog<ExceptionPathDialogView, ExceptionPathDialogViewModel>(ContentNameManager.ExceptionPath);
            //containerRegistry.RegisterDialog<UpdateGroupDialogView, UpdateGroupDialogViewModel>(ContentNameManager.UpdateGroup);
            //containerRegistry.RegisterDialog<UserMemoDialogView, UserMemoDialogViewModel>(ContentNameManager.UserMemo);
            //containerRegistry.RegisterDialog<EssentialGroupDialogView, EssentialGroupDialogViewModel>(ContentNameManager.EssentialGroup);

            //containerRegistry.RegisterDialog<FileAddUpdateDialogView, FileAddUpdateDialogViewModel>(ContentNameManager.FileAddUpdate);

            //containerRegistry.RegisterDialog<SendMessageDialogView, SendMessageDialogViewModel>(ContentNameManager.SendMessageDialog);
            //containerRegistry.RegisterDialog<SendMessageReceiverDialogView, SendMessageReceiverDialogViewModel>(ContentNameManager.SendMessageReceiver);
            //containerRegistry.RegisterDialog<SendMessageTemplateDialogView, SendMessageTemplateViewModel>(ContentNameManager.SendMessageTemplate);
            //containerRegistry.RegisterDialog<ReceiverGroupView, ReceiverGroupViewModel>(ContentNameManager.ReceiverGroup);

            //containerRegistry.RegisterDialog<FileCheckDialogView, FileCheckDialogViewModel>(ContentNameManager.FileCheckDialog);
            //containerRegistry.RegisterDialog<FileGroupAddUpdateDialogView, FileGroupAddUpdateDialogViewModel>(ContentNameManager.FileGroupAddUpdate);
            //containerRegistry.RegisterDialog<FileCommentEditDialogView, FileCommentEditDialogViewModel>(ContentNameManager.FileCommentEdit);

            //containerRegistry.RegisterDialog<EditUpdateTextFileDialogView, EditUpdateTextFileDialogViewModel>(ContentNameManager.EditUpdateTextFile);

            //containerRegistry.RegisterDialog<RollbackDialogView, RollbackDialogViewModel>(ContentNameManager.Rollback);
            //containerRegistry.RegisterDialog<FtpTransportDialogView, FtpTransportDialogViewModel>(ContentNameManager.FtpTransport);

            //containerRegistry.RegisterDialog<OpenFolderDialogView, OpenFolderDialogViewModel>(ContentNameManager.OpenFolder);

            ////containerRegistry.RegisterDialog<TestDialogContent, TestDialogContentModel>("TestDialog");




        }
    }
}
