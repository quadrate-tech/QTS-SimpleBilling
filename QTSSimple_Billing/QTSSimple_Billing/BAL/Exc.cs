using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTSSimple_Billing.BAL
{
    public static class Exc
    {
        public static void ErMessage(Exception ex)
        {
            MessageBox.Show(ex.Message + ex.InnerException);
        }
    }
}
