using CommunityToolkit.Mvvm.ComponentModel;
using NewToys.Core.Define.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewToys.Core.Alert
{
    public partial class AlertDialogModel: ObservableObject
    {
        [ObservableProperty] string mainMessage = string.Empty;

        [ObservableProperty] string subMessage = string.Empty;

        [ObservableProperty] string alertType = "OK";
    }
}
