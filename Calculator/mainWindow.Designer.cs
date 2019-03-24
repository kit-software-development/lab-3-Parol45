namespace Calculator
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
            this.displayLabel = new System.Windows.Forms.Label();
            this.digitsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.divideButton = new System.Windows.Forms.Button();
            this.separatorButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.multipyButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.substractionButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.digitsContainer.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.displayLabel.Location = new System.Drawing.Point(0, 0);
            this.displayLabel.Margin = new System.Windows.Forms.Padding(0);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayLabel.Size = new System.Drawing.Size(234, 55);
            this.displayLabel.TabIndex = 3;
            this.displayLabel.Text = "©Danilius2003";
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // digitsContainer
            // 
            this.digitsContainer.AutoSize = true;
            this.digitsContainer.ColumnCount = 4;
            this.digitsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.digitsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.digitsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.digitsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.digitsContainer.Controls.Add(this.divideButton, 3, 3);
            this.digitsContainer.Controls.Add(this.separatorButton, 2, 3);
            this.digitsContainer.Controls.Add(this.zeroButton, 1, 3);
            this.digitsContainer.Controls.Add(this.clearButton, 0, 3);
            this.digitsContainer.Controls.Add(this.multipyButton, 3, 2);
            this.digitsContainer.Controls.Add(this.threeButton, 2, 2);
            this.digitsContainer.Controls.Add(this.twoButton, 1, 2);
            this.digitsContainer.Controls.Add(this.oneButton, 0, 2);
            this.digitsContainer.Controls.Add(this.substractionButton, 3, 1);
            this.digitsContainer.Controls.Add(this.sixButton, 2, 1);
            this.digitsContainer.Controls.Add(this.fiveButton, 1, 1);
            this.digitsContainer.Controls.Add(this.fourButton, 0, 1);
            this.digitsContainer.Controls.Add(this.sumButton, 3, 0);
            this.digitsContainer.Controls.Add(this.nineButton, 2, 0);
            this.digitsContainer.Controls.Add(this.eightButton, 1, 0);
            this.digitsContainer.Controls.Add(this.sevenButton, 0, 0);
            this.digitsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digitsContainer.Location = new System.Drawing.Point(0, 55);
            this.digitsContainer.Margin = new System.Windows.Forms.Padding(0);
            this.digitsContainer.Name = "digitsContainer";
            this.digitsContainer.RowCount = 4;
            this.digitsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.digitsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.digitsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.digitsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.digitsContainer.Size = new System.Drawing.Size(234, 243);
            this.digitsContainer.TabIndex = 0;
            // 
            // divideButton
            // 
            this.divideButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divideButton.Location = new System.Drawing.Point(179, 185);
            this.divideButton.Margin = new System.Windows.Forms.Padding(5);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(50, 53);
            this.divideButton.TabIndex = 15;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.onOperatorButtonClick);
            // 
            // separatorButton
            // 
            this.separatorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.separatorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.separatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.separatorButton.Location = new System.Drawing.Point(121, 185);
            this.separatorButton.Margin = new System.Windows.Forms.Padding(5);
            this.separatorButton.Name = "separatorButton";
            this.separatorButton.Size = new System.Drawing.Size(48, 53);
            this.separatorButton.TabIndex = 14;
            this.separatorButton.Text = ",";
            this.separatorButton.UseVisualStyleBackColor = true;
            this.separatorButton.Click += new System.EventHandler(this.onSeparatorButtonClick);
            // 
            // zeroButton
            // 
            this.zeroButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.zeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroButton.Location = new System.Drawing.Point(63, 185);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(5);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(48, 53);
            this.zeroButton.TabIndex = 13;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.onDigitButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(5, 185);
            this.clearButton.Margin = new System.Windows.Forms.Padding(5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(48, 53);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "CE";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.onClearButtonClick);
            // 
            // multipyButton
            // 
            this.multipyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.multipyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multipyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multipyButton.Location = new System.Drawing.Point(179, 125);
            this.multipyButton.Margin = new System.Windows.Forms.Padding(5);
            this.multipyButton.Name = "multipyButton";
            this.multipyButton.Size = new System.Drawing.Size(50, 50);
            this.multipyButton.TabIndex = 11;
            this.multipyButton.Text = "*";
            this.multipyButton.UseVisualStyleBackColor = true;
            this.multipyButton.Click += new System.EventHandler(this.onOperatorButtonClick);
            // 
            // threeButton
            // 
            this.threeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.threeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threeButton.Location = new System.Drawing.Point(121, 125);
            this.threeButton.Margin = new System.Windows.Forms.Padding(5);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(48, 50);
            this.threeButton.TabIndex = 10;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.onDigitButtonClick);
            // 
            // twoButton
            // 
            this.twoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.twoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoButton.Location = new System.Drawing.Point(63, 125);
            this.twoButton.Margin = new System.Windows.Forms.Padding(5);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(48, 50);
            this.twoButton.TabIndex = 9;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.onDigitButtonClick);
            // 
            // oneButton
            // 
            this.oneButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.oneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneButton.Location = new System.Drawing.Point(5, 125);
            this.oneButton.Margin = new System.Windows.Forms.Padding(5);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(48, 50);
            this.oneButton.TabIndex = 8;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.onDigitButtonClick);
            // 
            // substractionButton
            // 
            this.substractionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.substractionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.substractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.substractionButton.Location = new System.Drawing.Point(179, 65);
            this.substractionButton.Margin = new System.Windows.Forms.Padding(5);
            this.substractionButton.Name = "substractionButton";
            this.substractionButton.Size = new System.Drawing.Size(50, 50);
            this.substractionButton.TabIndex = 7;
            this.substractionButton.Text = "-";
            this.substractionButton.UseVisualStyleBackColor = true;
            this.substractionButton.Click += new System.EventHandler(this.onSubstractButtonClick);
            // 
            // sixButton
            // 
            this.sixButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixButton.Location = new System.Drawing.Point(121, 65);
            this.sixButton.Margin = new System.Windows.Forms.Padding(5);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(48, 50);
            this.sixButton.TabIndex = 6;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.onDigitButtonClick);
            // 
            // fiveButton
            // 
            this.fiveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiveButton.Location = new System.Drawing.Point(63, 65);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(5);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(48, 50);
            this.fiveButton.TabIndex = 5;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.onDigitButtonClick);
            // 
            // fourButton
            // 
            this.fourButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourButton.Location = new System.Drawing.Point(5, 65);
            this.fourButton.Margin = new System.Windows.Forms.Padding(5);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(48, 50);
            this.fourButton.TabIndex = 4;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.onDigitButtonClick);
            // 
            // sumButton
            // 
            this.sumButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sumButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumButton.Location = new System.Drawing.Point(179, 5);
            this.sumButton.Margin = new System.Windows.Forms.Padding(5);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(50, 50);
            this.sumButton.TabIndex = 3;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.onOperatorButtonClick);
            // 
            // nineButton
            // 
            this.nineButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nineButton.Location = new System.Drawing.Point(121, 5);
            this.nineButton.Margin = new System.Windows.Forms.Padding(5);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(48, 50);
            this.nineButton.TabIndex = 2;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.onDigitButtonClick);
            // 
            // eightButton
            // 
            this.eightButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eightButton.Location = new System.Drawing.Point(63, 5);
            this.eightButton.Margin = new System.Windows.Forms.Padding(5);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(48, 50);
            this.eightButton.TabIndex = 1;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.onDigitButtonClick);
            // 
            // sevenButton
            // 
            this.sevenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sevenButton.Location = new System.Drawing.Point(5, 5);
            this.sevenButton.Margin = new System.Windows.Forms.Padding(5);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(48, 50);
            this.sevenButton.TabIndex = 0;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.onDigitButtonClick);
            // 
            // equalButton
            // 
            this.equalButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.equalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalButton.Location = new System.Drawing.Point(5, 303);
            this.equalButton.Margin = new System.Windows.Forms.Padding(5);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(224, 33);
            this.equalButton.TabIndex = 2;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.onEqualButtonClick);
            // 
            // mainContainer
            // 
            this.mainContainer.AutoSize = true;
            this.mainContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainContainer.ColumnCount = 1;
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer.Controls.Add(this.equalButton, 0, 2);
            this.mainContainer.Controls.Add(this.digitsContainer, 0, 1);
            this.mainContainer.Controls.Add(this.displayLabel, 0, 0);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.RowCount = 3;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainContainer.Size = new System.Drawing.Size(234, 341);
            this.mainContainer.TabIndex = 0;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 341);
            this.Controls.Add(this.mainContainer);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 700);
            this.MinimumSize = new System.Drawing.Size(250, 380);
            this.Name = "mainWindow";
            this.Text = "Calculator";
            this.SizeChanged += new System.EventHandler(this.onSizeChg);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            this.digitsContainer.ResumeLayout(false);
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.TableLayoutPanel digitsContainer;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button separatorButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button multipyButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button substractionButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.TableLayoutPanel mainContainer;
    }
}

