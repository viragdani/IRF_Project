using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Projekt_XK5TER.Entities
{
    public class CustomButton : Button
    {
        public CustomButton()
        {
            Text = "Alaphelyzet";
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = Color.FromArgb(119, 182, 234);
            Dock = DockStyle.Bottom;

            BackColor = Color.FromArgb(199, 211, 221);
            
        }

    }
}
