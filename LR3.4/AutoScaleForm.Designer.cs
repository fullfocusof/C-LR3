namespace LR3._4
{
    partial class AutoScaleForm
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
            this.SuspendLayout();
            // 
            // AutoScaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 741);
            this.MinimumSize = new System.Drawing.Size(150, 150);
            this.Name = "AutoScaleForm";
            this.Text = "AutoScaleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AutoScaleForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AutoScaleForm_Paint);
            this.Move += new System.EventHandler(this.AutoScaleForm_Move);
            this.Resize += new System.EventHandler(this.AutoScaleForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

