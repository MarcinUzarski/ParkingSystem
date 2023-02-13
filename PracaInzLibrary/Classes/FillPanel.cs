using System.Windows.Forms;

namespace PracaInzLibrary.Classes
{
    public class FillPanel
    {
        public void InsertUserControlToPanel(object userControl, Panel mainPanel, Label mainLabel)
        {
            if (mainPanel.Controls.Count > 0)
                mainPanel.Controls.RemoveAt(0);
            var uControl = userControl as UserControl;
            uControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uControl);
            mainPanel.Tag = uControl;
            mainLabel.Text = uControl.Text;
            uControl.Show();

        }
    }
}
