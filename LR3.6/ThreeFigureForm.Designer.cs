namespace LR3._6
{
    partial class ThreeFigureForm
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
            // ThreeFigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Name = "ThreeFigureForm";
            this.Text = "ThreeFigureForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThreeFigureForm_FormClosing);
            this.Shown += new System.EventHandler(this.ThreeFigureForm_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThreeFigureForm_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

