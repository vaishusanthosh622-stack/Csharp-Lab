using System;
using System.Windows.Forms;

namespace MDIApplication
{
    public class Form1 : Form
    {
        public Form1()
        {
            Text = "MDI Application";
            Width = 800;
            Height = 500;
            IsMdiContainer = true;

            MenuStrip menuStrip = new MenuStrip();

            ToolStripMenuItem fileMenu =
                new ToolStripMenuItem("File");

            ToolStripMenuItem newForm =
                new ToolStripMenuItem("New Form");

            ToolStripMenuItem exit =
                new ToolStripMenuItem("Exit");

            ToolStripMenuItem helpMenu =
                new ToolStripMenuItem("Help");

            ToolStripMenuItem about =
                new ToolStripMenuItem("About");

            fileMenu.DropDownItems.Add(newForm);
            fileMenu.DropDownItems.Add(exit);

            helpMenu.DropDownItems.Add(about);

            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(helpMenu);

            MainMenuStrip = menuStrip;
            Controls.Add(menuStrip);

            newForm.Click += NewForm_Click;
            exit.Click += Exit_Click;
            about.Click += About_Click;
        }

        private void NewForm_Click(object sender, EventArgs e)
        {
            Form childForm = new Form();

            childForm.Text = "Child Form";
            childForm.MdiParent = this;
            childForm.Width = 400;
            childForm.Height = 300;

            childForm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "MDI Application with Menu",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}