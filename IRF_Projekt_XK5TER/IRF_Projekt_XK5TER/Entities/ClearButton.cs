using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Projekt_XK5TER.Entities
{
    public class ClearButton : Button
    {
        public ClearButton()
        {
            Text = "Alaphelyzet";
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = Color.Red;
            Dock = DockStyle.Bottom;
            BackColor = Color.WhiteSmoke;
            
        }

    }
}
