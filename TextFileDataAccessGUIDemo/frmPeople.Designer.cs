namespace TextFileDataAccessGUIDemo
{
    partial class frmPeople
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirst = new Label();
            lblLast = new Label();
            lblUrl = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtURL = new TextBox();
            btnAddPerson = new Button();
            lbPersonList = new ListBox();
            btnSaveFile = new Button();
            btnLoadFile = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            SuspendLayout();
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Location = new Point(42, 52);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(134, 32);
            lblFirst.TabIndex = 0;
            lblFirst.Text = "First Name:";
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Location = new Point(42, 129);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(131, 32);
            lblLast.TabIndex = 1;
            lblLast.Text = "Last Name:";
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(42, 207);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(60, 32);
            lblUrl.TabIndex = 2;
            lblUrl.Text = "URL:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(191, 52);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 39);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(191, 126);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 39);
            txtLastName.TabIndex = 4;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(191, 204);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(200, 39);
            txtURL.TabIndex = 5;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Location = new Point(104, 284);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(229, 46);
            btnAddPerson.TabIndex = 6;
            btnAddPerson.Text = "Add to List -->";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // lbPersonList
            // 
            lbPersonList.FormattingEnabled = true;
            lbPersonList.ItemHeight = 32;
            lbPersonList.Location = new Point(434, 48);
            lbPersonList.Name = "lbPersonList";
            lbPersonList.Size = new Size(537, 516);
            lbPersonList.TabIndex = 7;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(145, 448);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(201, 46);
            btnSaveFile.TabIndex = 8;
            btnSaveFile.Text = "Save to File";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(145, 518);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(201, 46);
            btnLoadFile.TabIndex = 9;
            btnLoadFile.Text = "Load from File";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // frmPeople
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 598);
            Controls.Add(btnLoadFile);
            Controls.Add(btnSaveFile);
            Controls.Add(lbPersonList);
            Controls.Add(btnAddPerson);
            Controls.Add(txtURL);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblUrl);
            Controls.Add(lblLast);
            Controls.Add(lblFirst);
            Name = "frmPeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPeople";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirst;
        private Label lblLast;
        private Label lblUrl;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtURL;
        private Button btnAddPerson;
        private ListBox lbPersonList;
        private Button btnSaveFile;
        private Button btnLoadFile;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}