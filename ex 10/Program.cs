using System;
using System.Drawing;
using System.Windows.Forms;
namespace MDIApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
    public class MainForm : Form
    {
        MenuStrip menuStrip;
        ToolStripMenuItem fileMenu;
        ToolStripMenuItem newMenu;
        ToolStripMenuItem exitMenu;
        ToolStripMenuItem toolsMenu;
        ToolStripMenuItem customDialogMenu;
        ToolStripMenuItem windowMenu;
        ToolStripMenuItem cascadeMenu;
        ToolStripMenuItem tileMenu;

        public MainForm()
        {
            Text = "My MDI Application";
            Width = 900;
            Height = 600;
            IsMdiContainer = true;
            // Create MenuStrip
            menuStrip = new MenuStrip();
            // File Menu
            fileMenu = new ToolStripMenuItem("File");
            newMenu = new ToolStripMenuItem("New");
            exitMenu = new ToolStripMenuItem("Exit");
            fileMenu.DropDownItems.Add(newMenu);
            fileMenu.DropDownItems.Add(exitMenu);
            // Tools Menu
            toolsMenu = new ToolStripMenuItem("Tools");
            customDialogMenu =
                new ToolStripMenuItem("Custom Dialog");

            toolsMenu.DropDownItems.Add(customDialogMenu);
            // Window Menu
            windowMenu = new ToolStripMenuItem("Window");
            cascadeMenu =
                new ToolStripMenuItem("Cascade");
            tileMenu =
                new ToolStripMenuItem("Tile");
            windowMenu.DropDownItems.Add(cascadeMenu);
            windowMenu.DropDownItems.Add(tileMenu);
            // Add menus
            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(toolsMenu);
            menuStrip.Items.Add(windowMenu);
            MainMenuStrip = menuStrip;
            Controls.Add(menuStrip);
            // New Child Form
            newMenu.Click += (sender, e) =>
            {
                ChildForm child = new ChildForm();
                child.MdiParent = this;
                child.Show();
            };
            // Exit
            exitMenu.Click += (sender, e) =>
            {
                Application.Exit();
            };
            // Custom Dialog
            customDialogMenu.Click += (sender, e) =>
            {
                using (CustomDialog dialog = new CustomDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show(
                            "Name: " + dialog.StudentName +
                            "\nAge: " + dialog.StudentAge,
                            "Student Details",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
            };

            // Cascade
            cascadeMenu.Click += (sender, e) =>
            {
                LayoutMdi(MdiLayout.Cascade);
            };
            // Tile
            tileMenu.Click += (sender, e) =>
            {
                LayoutMdi(MdiLayout.TileHorizontal);
            };
        }
    }

    // MDI Child Form
    public class ChildForm : Form
    {
        public ChildForm()
        {
            Text = "Child Form";
            Width = 600;
            Height = 400;

            Label label = new Label();

            label.Text = "This is an MDI Child Form";
            label.AutoSize = true;
            label.Font = new Font("Arial", 20);
            label.Location = new Point(100, 100);

            Controls.Add(label);
        }
    }
    // Custom Dialog
    public class CustomDialog : Form
    {
        TextBox nameTextBox;
        TextBox ageTextBox;
        Button okButton;
        Button cancelButton;

        public string StudentName
        {
            get
            {
                return nameTextBox.Text;
            }
        }

        public string StudentAge
        {
            get
            {
                return ageTextBox.Text;
            }
        }
        public CustomDialog()
        {
            Text = "Student Details";
            Width = 350;
            Height = 220;
            StartPosition =
                FormStartPosition.CenterParent;
            // Name Label
            Label nameLabel = new Label();
            nameLabel.Text = "Name:";
            nameLabel.Location = new Point(30, 30);
            nameLabel.AutoSize = true;
            // Name TextBox
            nameTextBox = new TextBox();
            nameTextBox.Location =
                new Point(100, 25);
            nameTextBox.Width = 180;
            // Age Label
            Label ageLabel = new Label();
            ageLabel.Text = "Age:";
            ageLabel.Location = new Point(30, 70);
            ageLabel.AutoSize = true;
            // Age TextBox
            ageTextBox = new TextBox();
            ageTextBox.Location =
                new Point(100, 65);
            ageTextBox.Width = 180;
            // OK Button
            okButton = new Button();
            okButton.Text = "OK";
            okButton.Location =
                new Point(100, 120);
            okButton.Width = 80;
            // Cancel Button
            cancelButton = new Button();
            cancelButton.Text = "Cancel";
            cancelButton.Location =
                new Point(190, 120);

            cancelButton.Width = 80;
            // Add Controls
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(ageLabel);
            Controls.Add(ageTextBox);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
            // OK Button Click
            okButton.Click += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(
                    nameTextBox.Text))
                {
                    MessageBox.Show(
                        "Please enter Name."
                    );
                    return;
                }
                if (string.IsNullOrWhiteSpace(
                    ageTextBox.Text))
                {
                    MessageBox.Show(
                        "Please enter Age."
                    );
                    return;
                }
                DialogResult = DialogResult.OK;
                Close();
            };
            // Cancel Button Click
            cancelButton.Click += (sender, e) =>
            {
                DialogResult =
                    DialogResult.Cancel;

                Close();
            };
        }
    }
}
 


