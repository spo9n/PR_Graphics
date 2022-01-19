
namespace PR_Graphics_Surgai
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
            this.components = new System.ComponentModel.Container();
            this.timerYellowTick = new System.Windows.Forms.Timer(this.components);
            this.waitButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // waitButton
            // 
            this.waitButton.Location = new System.Drawing.Point(181, 207);
            this.waitButton.Name = "waitButton";
            this.waitButton.Size = new System.Drawing.Size(75, 23);
            this.waitButton.TabIndex = 0;
            this.waitButton.Text = "Очікувати";
            this.waitButton.UseVisualStyleBackColor = true;
            this.waitButton.Click += new System.EventHandler(this.waitButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(181, 248);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 389);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.waitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сургай А. П-81";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerYellowTick;
        private System.Windows.Forms.Button waitButton;
        private System.Windows.Forms.Button stopButton;
    }
}

