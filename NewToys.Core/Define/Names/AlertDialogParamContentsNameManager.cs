using NewToys.Core.Define.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewToys.Core.Define.Names
{
    public class AlertDialogParamContentsNameManager
    {
        public static string MainMessage => nameof(AlertDialogParamContents.MainMessage);
        public static string SubMessage => nameof(AlertDialogParamContents.SubMessage);
        public static string AlertType => nameof(AlertDialogParamContents.AlertType);
    }
}
