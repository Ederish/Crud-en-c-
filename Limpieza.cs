using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo6_proyectoFinal
{
    class Limpieza
    {
        public void Limpiar(Control c, GroupBox gb )
        {      
                foreach(var grp in gb.Controls)
                {
                    if (grp is TextBox)
                    {
                        ((TextBox)grp).Clear();
                    }
                   if (grp is TextBox)
                {
                    ((TextBox)grp).Clear();
                }
                else if (grp is ComboBox)
                {
                    ((ComboBox)grp).Text="Seleccione...";
                }
                else if (grp is NumericUpDown)
                {
                    ((NumericUpDown)grp).Value = 0;
                }
                      if (grp is MaskedTextBox)
                {
                    ((MaskedTextBox)grp).Clear();
                } 
                   
                }
            }

    

        }

    }

