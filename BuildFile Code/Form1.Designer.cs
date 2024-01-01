namespace BuildFile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        ///
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Path_Label = new Label();
            Dialog = new FolderBrowserDialog();
            Box = new ComboBox();
            CreateButton = new Button();
            CheckBox = new CheckBox();
            ChooseButton = new Button();
            Tailwind_Label = new Label();
            Name_Label = new TextBox();
            Name_Title = new Label();
            Install_Node = new Button();
            Install_Folder_Dialog = new FolderBrowserDialog();
            InstallNpx_Title = new Label();
            InstallNpx_Checker = new CheckBox();
            SuspendLayout();
            // 
            // Path_Label
            // 
            Path_Label.BackColor = SystemColors.ButtonHighlight;
            Path_Label.BorderStyle = BorderStyle.FixedSingle;
            Path_Label.Font = new Font("Segoe UI", 12F);
            Path_Label.Location = new Point(46, 128);
            Path_Label.Name = "Path_Label";
            Path_Label.Size = new Size(231, 24);
            Path_Label.TabIndex = 1;
            Path_Label.Text = "C:\\Program Files";
            Path_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Box
            // 
            Box.DropDownStyle = ComboBoxStyle.DropDownList;
            Box.Items.AddRange(new object[] { "React", "Next" });
            Box.Location = new Point(90, 184);
            Box.Name = "Box";
            Box.Size = new Size(247, 23);
            Box.TabIndex = 0;
            Box.Tag = "Selector";
            Box.SelectedIndexChanged += Box_SelectedIndexChanged;
            // 
            // CreateButton
            // 
            CreateButton.FlatStyle = FlatStyle.System;
            CreateButton.Font = new Font("Harrington", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateButton.Location = new Point(122, 257);
            CreateButton.Name = "CreateButton";
            CreateButton.RightToLeft = RightToLeft.No;
            CreateButton.Size = new Size(180, 40);
            CreateButton.TabIndex = 0;
            CreateButton.Text = "Create";
            CreateButton.Click += CreateButton_Click;
            // 
            // CheckBox
            // 
            CheckBox.Location = new Point(160, 227);
            CheckBox.Name = "CheckBox";
            CheckBox.Size = new Size(15, 14);
            CheckBox.TabIndex = 0;
            // 
            // ChooseButton
            // 
            ChooseButton.Location = new Point(293, 129);
            ChooseButton.Name = "ChooseButton";
            ChooseButton.Size = new Size(75, 23);
            ChooseButton.TabIndex = 2;
            ChooseButton.Text = "Choose";
            ChooseButton.Click += ChooseButton_Click;
            // 
            // Tailwind_Label
            // 
            Tailwind_Label.Location = new Point(181, 226);
            Tailwind_Label.Name = "Tailwind_Label";
            Tailwind_Label.Size = new Size(57, 15);
            Tailwind_Label.TabIndex = 3;
            Tailwind_Label.Text = "Tailwind";
            Tailwind_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Name_Label
            // 
            Name_Label.Location = new Point(134, 79);
            Name_Label.Name = "Name_Label";
            Name_Label.Size = new Size(153, 23);
            Name_Label.TabIndex = 6;
            Name_Label.TextAlign = HorizontalAlignment.Center;
            // 
            // Name_Title
            // 
            Name_Title.Font = new Font("Viner Hand ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name_Title.Location = new Point(61, 79);
            Name_Title.Name = "Name_Title";
            Name_Title.Size = new Size(67, 23);
            Name_Title.TabIndex = 7;
            Name_Title.Text = "Name";
            Name_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Install_Node
            // 
            Install_Node.BackColor = SystemColors.Desktop;
            Install_Node.Font = new Font("Snap ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Install_Node.ForeColor = SystemColors.ButtonHighlight;
            Install_Node.Location = new Point(12, 324);
            Install_Node.Name = "Install_Node";
            Install_Node.Size = new Size(131, 25);
            Install_Node.TabIndex = 8;
            Install_Node.Text = "Install Node";
            Install_Node.UseVisualStyleBackColor = false;
            Install_Node.Click += Install_Node_Click;
            // 
            // InstallNpx_Title
            // 
            InstallNpx_Title.Location = new Point(56, 351);
            InstallNpx_Title.Name = "InstallNpx_Title";
            InstallNpx_Title.Size = new Size(27, 15);
            InstallNpx_Title.TabIndex = 10;
            InstallNpx_Title.Text = "npx";
            InstallNpx_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InstallNpx_Checker
            // 
            InstallNpx_Checker.Location = new Point(40, 353);
            InstallNpx_Checker.Name = "InstallNpx_Checker";
            InstallNpx_Checker.Size = new Size(15, 14);
            InstallNpx_Checker.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 410);
            Controls.Add(InstallNpx_Title);
            Controls.Add(InstallNpx_Checker);
            Controls.Add(Name_Title);
            Controls.Add(Tailwind_Label);
            Controls.Add(Box);
            Controls.Add(CreateButton);
            Controls.Add(CheckBox);
            Controls.Add(Path_Label);
            Controls.Add(ChooseButton);
            Controls.Add(Name_Label);
            Controls.Add(Install_Node);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lazy Builder";
            TransparencyKey = Color.Red;
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox Box;
        private Button CreateButton;
        private Button ChooseButton;
        private CheckBox CheckBox;
        private FolderBrowserDialog Dialog;
        private FolderBrowserDialog Install_Folder_Dialog;
        private Label Path_Label;
        private TextBox Name_Label;
        private Button Install_Node;
        #endregion

        private Label Tailwind_Label;
        private Label Name_Title;
        private Label InstallNpx_Title;
        private CheckBox InstallNpx_Checker;
    }
}
