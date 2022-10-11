using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StockMyG
{
    public class Validador
    {
        public static bool VeficarForm(Form frm)
        {
            bool flag = true;
            StringBuilder str = new StringBuilder();
            str.Append("Error al ingresar los siguientes campos: " + Environment.NewLine + Environment.NewLine);
            foreach (Control item in frm.Controls)
            {
                if (item.GetType() == typeof(UserControls.TextBox))
                {
                   UserControls.TextBox val = (UserControls.TextBox)item;
                   if (val.EsCorrecto().Length>0)
                    {
                        flag = false;
                        str.Append(val.EsCorrecto());
                    }
                }
                else if(item.GetType() == typeof(GroupBox))
                {
                    foreach (Control item2 in item.Controls)
                    {
                        if (item2.GetType() == typeof(UserControls.TextBox))
                        {
                            UserControls.TextBox val = (UserControls.TextBox)item2;
                            if (val.EsCorrecto().Length > 0)
                            {
                                flag = false;
                                str.Append(val.EsCorrecto());
                            }
                        }                        
                    }
                }
            }
            if(!flag)
            {
                MessageBox.Show(str.ToString(),"Error");
            }
            return flag;
        }
    }
}
