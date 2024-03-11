using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Protect_yourself.script.cursor
{
    internal class change_cursor
    {
        public static Cursor C1 = new Cursor(Application.GetResourceStream(new System.Uri("/cur/normal.cur", System.UriKind.Relative)).Stream);
        public static Cursor C2 = new Cursor(Application.GetResourceStream(new System.Uri("/cur/normalRedBlack.cur", System.UriKind.Relative)).Stream);
        public static Cursor C3= new Cursor(Application.GetResourceStream(new System.Uri("/cur/blackWedge.cur", System.UriKind.Relative)).Stream);
    }
}
