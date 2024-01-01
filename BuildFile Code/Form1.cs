using System.CodeDom;
using System.Diagnostics;
using BuildFile.Main;

namespace BuildFile
{
    public partial class Form1 : Form
    {
        string? Path;
        string? Command;
        readonly string Tailwind = "npm install -D tailwindcss@latest & npx tailwindcss init";
        ItemType? Type;

        public Form1()
        {
            InitializeComponent();
        }

        private string Pack() => (Box.SelectedItem == null) ? "Select something!!" : "npx create-" + Command + "-app";
        private void Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Box.SelectedIndex)
            {
                case 0:
                    Command = "react";
                    Type = ItemType.React;
                    break;
                case 1:
                    Command = "next";
                    Type = ItemType.Next;
                    break;
            }
        }

        
        static void RunPrompt(string? prompt)
        {
            if (prompt == null) return;
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = prompt;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Path = Path_Label.Text;
            if (Box.SelectedItem != null && Path != "" && Name_Label.Text != "")
                RunPrompt($"/c cd {Path} & {Pack()} {Name_Label.Text} & " +
                          $"cd {Name_Label.Text} & " +
                          $"npm install {((Type == ItemType.Next) ? "next@latest" : "")} " +
                          $"react@latest react-dom@latest {(CheckBox.Checked ? "& " + Tailwind : "")} " +
                          $"& npm audit fix ");
            else
                MessageBox.Show((Box.SelectedItem == null) ? "Select something!!" : (Name_Label.Text == "" ? "Enter project name!!!" : "Enter Path!!"));
        }



        private void ChooseButton_Click(object sender, EventArgs e)
        {
            Dialog.SelectedPath = "C:\\";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                Path_Label.Text = Dialog.SelectedPath;
            }
        }

        private void Install_Node_Click(object sender, EventArgs e)
        {
            if (Install_Folder_Dialog.ShowDialog() == DialogResult.OK)
                RunPrompt($"/c cd {Install_Folder_Dialog.SelectedPath} & " +
                    $"curl -O https://nodejs.org/dist/v21.5.0/node-v21.5.0-x64.msi & " +
                    $"node-v21.5.0-x64.msi " +
                    $"{(InstallNpx_Checker.Checked ? "& npm install npx&latest" : "")}");
        }


    }
}
