using Microsoft.VisualBasic;
using NewToys.Core.Define.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewToys.Core.Define.Names
{
    public class AlertTypesNameManager
    {
        public static string OK => nameof(AlertTypes.OK);
        public static string WARNING => nameof(AlertTypes.WARNING);
        public static string ERROR => nameof(AlertTypes.ERROR);
        public static string QUESTION => nameof(AlertTypes.QUESTION);
        public static string INFORMATION => nameof(AlertTypes.INFORMATION);
        
    }
}
