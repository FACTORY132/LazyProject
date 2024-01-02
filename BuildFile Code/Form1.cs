using System.CodeDom;
using System.Diagnostics;
using BuildFile.Main;

namespace BuildFile
{
    public partial class Form1 : Form
    {
        string? Path;
        readonly string Tailwind = "npm install -D tailwindcss@latest & npx tailwindcss init";
        ItemType? Type;

        public Form1()
        {
            InitializeComponent();
        }
        private void Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Box.SelectedIndex)
            {
                case 0:
                    Type = ItemType.React;
                    break;
                case 1:
                    Type = ItemType.Next;
                    break;
                case 2:
                    Type = ItemType.Vue;
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
            process.Start();
            process.WaitForExit();

        }

        string PathToFolder(string FileName)
        {
            return CheckBox.Checked ? Path + "\\" + Name_Label.Text + "\\" + FileName : "";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Path = Path_Label.Text;
            string Tailwind_Path = PathToFolder("tailwind.config.js");
            if (Box.SelectedItem != null && Path != "" && Name_Label.Text != "")
            {

                switch (Type)
                {
                    case ItemType.React:
                        RunPrompt($"/c cd {Path} & npx create-react-app@latest {Name_Label.Text} & " +
                            $"cd {Name_Label.Text} & " +
                            $"npm install react&latest react-dom@latest {(CheckBox.Checked ? "& " +
                            Tailwind : "")} " +
                            "& npm audit fix"
                            );
                        break;
                    case ItemType.Next:
                        RunPrompt($"/c cd {Path} & npx create-next-app@latest {Name_Label.Text} & " +
                          $"cd {Name_Label.Text} & " +
                          $"npm install next@latest react&latest react-dom@latest {(CheckBox.Checked ? "& " +
                          Tailwind : "")} " +
                          "& npm audit fix"
                          );
                        break;
                    case ItemType.Vue:
                        RunPrompt($"/c cd {Path} & vue create {Name_Label.Text} " +
                            $"cd {Name_Label.Text} " +
                            $"{(CheckBox.Checked ? "& " + Tailwind : "")} & " +
                            $"npm audit fix"
                            );
                        break;
                }

                FileOverwrite.TailwindConfigOverwrite(Tailwind_Path);
            }
            else
                MessageBox.Show((Box.SelectedItem == null) ? "Select something!!" : (Name_Label.Text == "" ? "Enter project name!!!" : "Enter Path!!"));
        }



        private void ChooseButton_Click(object sender, EventArgs e)
        {
            Dialog.SelectedPath = "C:\\";
            if (Dialog.ShowDialog() == DialogResult.OK)
                Path_Label.Text = Dialog.SelectedPath;
        }

        private void Install_Node_Click(object sender, EventArgs e)
        {
            if (Install_Folder_Dialog.ShowDialog() == DialogResult.OK)
                RunPrompt($"/c cd {Install_Folder_Dialog.SelectedPath} & " +
                    $"curl -O https://nodejs.org/dist/v21.5.0/node-v21.5.0-x64.msi & " +
                    $"node-v21.5.0-x64.msi " +
                    $"{(InstallNpx_Checker.Checked ? "& npm install npx&latest" : "")}");

        }

        private void Vue_InstallerButton(object sender, EventArgs e)
        {
            RunPrompt("npm install vue");
        }
    }
}
