using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace PracaInzLibrary.Classes
{
    public class ChangeConnStatIcon
    {
        public delegate void ChangeConnInfo(object sender, EventArgs e);

        public void ChangeStatus(Label label, IconPictureBox pic, UserControl uControl, UserControl uControlStas)
        {
            if (label.Text == "Niepołączony")
            {
                label.Text = "Połączony";
                pic.ForeColor = Color.GreenYellow;
                uControl.Enabled = true;
                uControlStas.Enabled = true;
            }
            else
            {
                label.Text = "Niepołączony";
                pic.ForeColor = Color.Red;
                uControl.Enabled = false;
                uControlStas.Enabled = false;
            }

        }
    }
}
