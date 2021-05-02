using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrado
{
    class Functions
    {

        public void ClearTxtBoxes(Control.ControlCollection ctrl)
        {
            foreach (Control ctr2 in ctrl)
            {
                if (ctr2 is TextBoxBase || ctr2 is DateTimePicker || ctr2 is ComboBox)
                {
                    ctr2.Text = "";

                }
                else
                {
                    ClearTxtBoxes(ctr2.Controls);
                }
            }

        }

        public bool CheckEmptyTxtBox(Control.ControlCollection ctrl)
        {
            bool check = true;
            foreach (Control ctr2 in ctrl)
            {
                if (ctr2 is TextBoxBase)
                {
                    if (!string.IsNullOrEmpty(ctr2.Text))
                    {
                        check = true;


                    }
                    else
                    {
                        check = false;
                        
                        break;
                    }
                }

            }
            return check;
        }



    }
}
