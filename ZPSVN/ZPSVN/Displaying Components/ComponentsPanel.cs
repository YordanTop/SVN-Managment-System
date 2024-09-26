using DataBaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPSVN.Displaying_Components
{
    /// <summary>
    /// Prefixed panel for the Lines/Computers
    /// </summary>
    public class ComponentsPanel:Panel
    {
        public Panel ComponentPanel { get; set; }
        public Color ComponentColor { get; set; }
        public bool ComponentStatus { get; set; }
        public ComponentsPanel()
        {
            ComponentColor = Color.FromArgb(170, 179, 150);
            ComponentPanel = new Panel();

            ComponentPanel.Dock = DockStyle.Top;
            ComponentPanel.Margin = new Padding(13, 13, 0, 3);
            ComponentPanel.Location = new Point(13, 13);
            ComponentPanel.BorderStyle = BorderStyle.FixedSingle;
            ComponentPanel.Size = new Size(170, 59);

            ComponentPanel.Visible = true;
            ComponentPanel.Enabled = true;

            ComponentPanel.Focus();

            ComponentPanel.BackColor = ComponentColor;

            ComponentPanel.TabIndex = 0;
        }

        public void AttachTo(Control basePanel)
        {
            basePanel.Controls.Add(ComponentPanel);
        }

        public void AttachIn(Control entity)
        {
            base.Controls.Add(entity);
        }

        public void DisplayStatus()
        {
            Label projectStatus = new Label();
            projectStatus.Location = new Point(120, 20);
            projectStatus.Size = new Size(31, 20);
            projectStatus.Font = new Font("Microsoft Sans Serif", 12);
            projectStatus.AutoSize = true;

            if (ComponentStatus)
            {
                projectStatus.Text = "OK";
                ComponentPanel.BackColor = Color.FromArgb(170, 179, 150);
            }
            else
            {
                projectStatus.Text = "NOK";
                ComponentPanel.BackColor = Color.Red;
            }

            ComponentPanel.Controls.Add(projectStatus);

        }

        public void AddTitle(string title)
        {
            Label projectName = new Label();
            projectName.Text = title;
            projectName.Location = new Point(3, 20);
            projectName.Size = new Size(75, 20);
            projectName.Font = new Font("Microsoft Sans Serif", 12);
            projectName.AutoSize = true;

            ComponentPanel.Controls.Add(projectName);
        }
    }

}
