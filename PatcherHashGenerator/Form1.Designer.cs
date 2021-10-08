namespace PatcherHashGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileReader = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNamesHashSize = new System.Windows.Forms.ListBox();
            this.clearItems = new System.Windows.Forms.Button();
            this.exitApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileReader
            // 
            this.fileReader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fileReader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fileReader.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileReader.Location = new System.Drawing.Point(37, 102);
            this.fileReader.Name = "fileReader";
            this.fileReader.Size = new System.Drawing.Size(178, 42);
            this.fileReader.TabIndex = 0;
            this.fileReader.Text = "Fájlok beolvasása";
            this.fileReader.UseVisualStyleBackColor = false;
            this.fileReader.Click += new System.EventHandler(this.fileReader_Click);
            // 
            // filePath
            // 
            this.filePath.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.filePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filePath.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.filePath.Location = new System.Drawing.Point(11, 40);
            this.filePath.Multiline = true;
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(230, 34);
            this.filePath.TabIndex = 1;
            this.filePath.Text = "pack/";
            this.filePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fájlok Elérése: ( pack/ )";
            // 
            // fileNamesHashSize
            // 
            this.fileNamesHashSize.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fileNamesHashSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileNamesHashSize.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileNamesHashSize.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.fileNamesHashSize.FormattingEnabled = true;
            this.fileNamesHashSize.ItemHeight = 19;
            this.fileNamesHashSize.Location = new System.Drawing.Point(306, 9);
            this.fileNamesHashSize.Name = "fileNamesHashSize";
            this.fileNamesHashSize.Size = new System.Drawing.Size(654, 399);
            this.fileNamesHashSize.TabIndex = 3;
            // 
            // clearItems
            // 
            this.clearItems.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clearItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearItems.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearItems.Location = new System.Drawing.Point(37, 165);
            this.clearItems.Name = "clearItems";
            this.clearItems.Size = new System.Drawing.Size(178, 42);
            this.clearItems.TabIndex = 4;
            this.clearItems.Text = "Lista kiürítése";
            this.clearItems.UseVisualStyleBackColor = false;
            this.clearItems.Click += new System.EventHandler(this.clearItems_Click);
            // 
            // exitApp
            // 
            this.exitApp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitApp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitApp.Location = new System.Drawing.Point(37, 364);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(178, 42);
            this.exitApp.TabIndex = 5;
            this.exitApp.Text = "Kilépés";
            this.exitApp.UseVisualStyleBackColor = false;
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(972, 418);
            this.Controls.Add(this.exitApp);
            this.Controls.Add(this.clearItems);
            this.Controls.Add(this.fileNamesHashSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.fileReader);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PatcherHashGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileReader;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox fileNamesHashSize;
        private System.Windows.Forms.Button clearItems;
        public System.Windows.Forms.Button exitApp;
    }
}

