namespace Colors
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.schemeComboBox = new System.Windows.Forms.ComboBox();
            this.resultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // schemeComboBox
            // 
            this.schemeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schemeComboBox.FormattingEnabled = true;
            this.schemeComboBox.Items.AddRange(new object[] {
            "Complementary",
            "Analogous",
            "Triad"});
            this.schemeComboBox.Location = new System.Drawing.Point(13, 13);
            this.schemeComboBox.Name = "schemeComboBox";
            this.schemeComboBox.Size = new System.Drawing.Size(121, 21);
            this.schemeComboBox.TabIndex = 0;
            this.schemeComboBox.SelectedIndexChanged += new System.EventHandler(this.schemeComboBox_SelectedIndexChanged);
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(13, 41);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(121, 23);
            this.resultButton.TabIndex = 1;
            this.resultButton.Text = "Colors!";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.schemeComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainForm";
            this.Text = "Colors";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox schemeComboBox;
        private System.Windows.Forms.Button resultButton;
    }
}

