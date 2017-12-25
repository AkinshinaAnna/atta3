namespace _10._1._1F
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultbutton = new System.Windows.Forms.Button();
            this.InputLineDGV = new System.Windows.Forms.DataGridView();
            this.InputLineDGV_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputLineDGV_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputLineDGV_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputListlabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.InputLineDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultbutton
            // 
            this.resultbutton.Location = new System.Drawing.Point(43, 321);
            this.resultbutton.Name = "resultbutton";
            this.resultbutton.Size = new System.Drawing.Size(75, 23);
            this.resultbutton.TabIndex = 0;
            this.resultbutton.Text = "Выполнить";
            this.resultbutton.UseVisualStyleBackColor = true;
            this.resultbutton.Click += new System.EventHandler(this.resultbutton_Click);
            // 
            // InputLineDGV
            // 
            this.InputLineDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputLineDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InputLineDGV_a,
            this.InputLineDGV_b,
            this.InputLineDGV_c});
            this.InputLineDGV.Location = new System.Drawing.Point(12, 59);
            this.InputLineDGV.Name = "InputLineDGV";
            this.InputLineDGV.Size = new System.Drawing.Size(352, 232);
            this.InputLineDGV.TabIndex = 1;
            // 
            // InputLineDGV_a
            // 
            this.InputLineDGV_a.HeaderText = "a";
            this.InputLineDGV_a.Name = "InputLineDGV_a";
            // 
            // InputLineDGV_b
            // 
            this.InputLineDGV_b.HeaderText = "b";
            this.InputLineDGV_b.Name = "InputLineDGV_b";
            // 
            // InputLineDGV_c
            // 
            this.InputLineDGV_c.HeaderText = "c";
            this.InputLineDGV_c.Name = "InputLineDGV_c";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Результат";
            // 
            // OutputListlabel
            // 
            this.OutputListlabel.AutoSize = true;
            this.OutputListlabel.Location = new System.Drawing.Point(255, 326);
            this.OutputListlabel.Name = "OutputListlabel";
            this.OutputListlabel.Size = new System.Drawing.Size(0, 13);
            this.OutputListlabel.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFileOpen,
            this.MainMenuFileSave});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // MainMenuFileOpen
            // 
            this.MainMenuFileOpen.Name = "MainMenuFileOpen";
            this.MainMenuFileOpen.Size = new System.Drawing.Size(132, 22);
            this.MainMenuFileOpen.Text = "Открыть";
            this.MainMenuFileOpen.Click += new System.EventHandler(this.MainMenuFileOpen_Click);
            // 
            // MainMenuFileSave
            // 
            this.MainMenuFileSave.Name = "MainMenuFileSave";
            this.MainMenuFileSave.Size = new System.Drawing.Size(132, 22);
            this.MainMenuFileSave.Text = "Сохранить";
            this.MainMenuFileSave.Click += new System.EventHandler(this.MainMenuFileSave_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.OutputListlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputLineDGV);
            this.Controls.Add(this.resultbutton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputLineDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resultbutton;
        private System.Windows.Forms.DataGridView InputLineDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputLineDGV_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputLineDGV_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputLineDGV_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OutputListlabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileSave;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}

