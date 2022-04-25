namespace UOD
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
            this.LAB_StatusIS = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LAB_StatusIS
            // 
            this.LAB_StatusIS.AutoSize = true;
            this.LAB_StatusIS.Location = new System.Drawing.Point(50, 202);
            this.LAB_StatusIS.Name = "LAB_StatusIS";
            this.LAB_StatusIS.Size = new System.Drawing.Size(35, 13);
            this.LAB_StatusIS.TabIndex = 0;
            this.LAB_StatusIS.Text = "status";
            this.LAB_StatusIS.UseMnemonic = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Decript";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(598, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LAB_StatusIS);
            this.Name = "Form1";
            this.Text = "UOD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LAB_StatusIS;
        private System.Windows.Forms.Button button1;
    }
}

