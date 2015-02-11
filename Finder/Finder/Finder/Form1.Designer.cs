namespace Finder
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (folderTxtbox.Text != "")
            {
                Finder.Properties.Settings.Default.Setting = folderTxtbox.Text;
            }

            if (filterTxtbox.Text != "")
            {
                Finder.Properties.Settings.Default.Setting1 = filterTxtbox.Text;
            }

            if (textTxtbox.Text != "")
            {
                Finder.Properties.Settings.Default.Setting2 = textTxtbox.Text;
            }
            if (treeView1 != null)
            {
                Finder.Properties.Settings.Default.Setting3 = treeView1;
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            Finder.Properties.Settings.Default.Save();
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.textTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.filterTxtbox = new System.Windows.Forms.TextBox();
            this.folderTxtbox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(1, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(123, 197);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textTxtbox
            // 
            this.textTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTxtbox.Location = new System.Drawing.Point(133, 114);
            this.textTxtbox.Name = "textTxtbox";
            this.textTxtbox.Size = new System.Drawing.Size(175, 20);
            this.textTxtbox.TabIndex = 3;
            this.textTxtbox.Text = "Введите текст в файле";
            this.textTxtbox.Click += new System.EventHandler(this.textTxtbox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 21);
            this.button2.TabIndex = 5;
            this.button2.Text = "Директория";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // filterTxtbox
            // 
            this.filterTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterTxtbox.Location = new System.Drawing.Point(133, 83);
            this.filterTxtbox.Name = "filterTxtbox";
            this.filterTxtbox.Size = new System.Drawing.Size(175, 20);
            this.filterTxtbox.TabIndex = 2;
            this.filterTxtbox.Text = "Введите имя файла";
            this.filterTxtbox.Click += new System.EventHandler(this.filterTxtbox_Click);
            // 
            // folderTxtbox
            // 
            this.folderTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderTxtbox.Location = new System.Drawing.Point(133, 57);
            this.folderTxtbox.Name = "folderTxtbox";
            this.folderTxtbox.Size = new System.Drawing.Size(175, 20);
            this.folderTxtbox.TabIndex = 1;
            this.folderTxtbox.Text = "Введите путь";
            this.folderTxtbox.Click += new System.EventHandler(this.folderTxtbox_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 221);
            this.Controls.Add(this.folderTxtbox);
            this.Controls.Add(this.filterTxtbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTxtbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.MinimumSize = new System.Drawing.Size(336, 259);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox filterTxtbox;
        private System.Windows.Forms.TextBox folderTxtbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;

    }
}

