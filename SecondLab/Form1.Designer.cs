namespace SecondLab
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
            this.EquationInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.СalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EquationInputBox
            // 
            this.EquationInputBox.Location = new System.Drawing.Point(12, 49);
            this.EquationInputBox.Name = "EquationInputBox";
            this.EquationInputBox.Size = new System.Drawing.Size(228, 20);
            this.EquationInputBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите выражение: ";
            // 
            // СalculateButton
            // 
            this.СalculateButton.Font = new System.Drawing.Font("Palatino Linotype", 13.25F);
            this.СalculateButton.Location = new System.Drawing.Point(12, 75);
            this.СalculateButton.Name = "СalculateButton";
            this.СalculateButton.Size = new System.Drawing.Size(228, 35);
            this.СalculateButton.TabIndex = 2;
            this.СalculateButton.Text = "Рассчитать";
            this.СalculateButton.UseVisualStyleBackColor = true;
            this.СalculateButton.Click += new System.EventHandler(this.СalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 157);
            this.Controls.Add(this.СalculateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EquationInputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EquationInputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button СalculateButton;
    }
}

