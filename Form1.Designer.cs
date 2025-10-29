namespace FileApplication
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
        private void InitializeComponent()
        {
            btnReadFile = new Button();
            btnAddFile = new Button();
            btnDelete = new Button();
            btnFileChoose = new Button();
            txtpath = new TextBox();
            reada = new RichTextBox();
            btnInfo = new Button();
            label1 = new Label();
            label2 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(651, 134);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(146, 40);
            btnReadFile.TabIndex = 0;
            btnReadFile.Text = "Read File";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnAddFile
            // 
            btnAddFile.Location = new Point(651, 208);
            btnAddFile.Name = "btnAddFile";
            btnAddFile.Size = new Size(146, 40);
            btnAddFile.TabIndex = 1;
            btnAddFile.Text = "Add File";
            btnAddFile.UseVisualStyleBackColor = true;
            btnAddFile.Click += btnAddFile_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(651, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 44);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete File";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFileChoose
            // 
            btnFileChoose.Location = new Point(215, 49);
            btnFileChoose.Name = "btnFileChoose";
            btnFileChoose.Size = new Size(137, 39);
            btnFileChoose.TabIndex = 3;
            btnFileChoose.Text = "Choose File Path";
            btnFileChoose.UseVisualStyleBackColor = true;
            btnFileChoose.Click += btnFileChoose_Click;
            // 
            // txtpath
            // 
            txtpath.Location = new Point(143, 106);
            txtpath.Name = "txtpath";
            txtpath.Size = new Size(302, 23);
            txtpath.TabIndex = 5;
            // 
            // reada
            // 
            reada.Location = new Point(136, 208);
            reada.Name = "reada";
            reada.Size = new Size(309, 194);
            reada.TabIndex = 7;
            reada.Text = "";
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(651, 358);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(146, 47);
            btnInfo.TabIndex = 8;
            btnInfo.Text = "File Info";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 114);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 9;
            label1.Text = "File Path : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 271);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 10;
            label2.Text = "File Contents :";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(873, 492);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 27);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 531);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInfo);
            Controls.Add(reada);
            Controls.Add(txtpath);
            Controls.Add(btnFileChoose);
            Controls.Add(btnDelete);
            Controls.Add(btnAddFile);
            Controls.Add(btnReadFile);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReadFile;
        private Button btnAddFile;
        private Button btnDelete;
        private Button btnFileChoose;
        private TextBox txtpath;
        private RichTextBox reada;
        private Button btnInfo;
        private Label label1;
        private Label label2;
        private Button btnExit;
    }
}
