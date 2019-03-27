namespace lab_3_Parol45
{
    partial class mainWindow
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
            this.runningButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runningButton
            // 
            this.runningButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runningButton.Location = new System.Drawing.Point(0, 0);
            this.runningButton.Margin = new System.Windows.Forms.Padding(0);
            this.runningButton.Name = "runningButton";
            this.runningButton.Size = new System.Drawing.Size(124, 30);
            this.runningButton.TabIndex = 2;
            this.runningButton.TabStop = false;
            this.runningButton.Text = "Catch me";
            this.runningButton.UseVisualStyleBackColor = true;
            this.runningButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMouseClick);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 129);
            this.Controls.Add(this.runningButton);
            this.MinimumSize = new System.Drawing.Size(140, 69);
            this.Name = "mainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Why are you runnin";
            this.ResizeBegin += new System.EventHandler(this.saveState);
            this.ResizeEnd += new System.EventHandler(this.saveState);
            this.SizeChanged += new System.EventHandler(this.onWindowResize);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMoved);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runningButton;
    }
}

