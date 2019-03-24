namespace Color_palette
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
            this.components = new System.ComponentModel.Container();
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.palette = new System.Windows.Forms.FlowLayoutPanel();
            this.colorTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.blueMax = new System.Windows.Forms.Label();
            this.blueMin = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.greenMax = new System.Windows.Forms.Label();
            this.greenMin = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.redMax = new System.Windows.Forms.Label();
            this.redMin = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueBar = new System.Windows.Forms.TrackBar();
            this.greenBar = new System.Windows.Forms.TrackBar();
            this.redBar = new System.Windows.Forms.TrackBar();
            this.trackbarContainer = new System.Windows.Forms.TableLayoutPanel();
            this.mainContainer.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).BeginInit();
            this.trackbarContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.ColumnCount = 2;
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.mainContainer.Controls.Add(this.palette, 0, 0);
            this.mainContainer.Controls.Add(this.trackbarContainer, 1, 0);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.RowCount = 1;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 394F));
            this.mainContainer.Size = new System.Drawing.Size(484, 211);
            this.mainContainer.TabIndex = 0;
            // 
            // palette
            // 
            this.palette.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.palette.BackColor = System.Drawing.Color.Red;
            this.palette.Location = new System.Drawing.Point(10, 10);
            this.palette.Margin = new System.Windows.Forms.Padding(10);
            this.palette.Name = "palette";
            this.palette.Size = new System.Drawing.Size(187, 191);
            this.palette.TabIndex = 1;
            // 
            // colorTip
            // 
            this.colorTip.AutoPopDelay = 0;
            this.colorTip.InitialDelay = 500;
            this.colorTip.IsBalloon = true;
            this.colorTip.ReshowDelay = 0;
            this.colorTip.ShowAlways = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.blueMin, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.blueMax, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(49, 180);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(228, 31);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // blueMax
            // 
            this.blueMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blueMax.AutoSize = true;
            this.blueMax.Location = new System.Drawing.Point(188, 0);
            this.blueMax.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.blueMax.Name = "blueMax";
            this.blueMax.Size = new System.Drawing.Size(25, 13);
            this.blueMax.TabIndex = 1;
            this.blueMax.Text = "255";
            // 
            // blueMin
            // 
            this.blueMin.AutoSize = true;
            this.blueMin.Location = new System.Drawing.Point(3, 0);
            this.blueMin.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.blueMin.Name = "blueMin";
            this.blueMin.Size = new System.Drawing.Size(13, 13);
            this.blueMin.TabIndex = 0;
            this.blueMin.Text = "0";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.greenMin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.greenMax, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(49, 110);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(228, 30);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // greenMax
            // 
            this.greenMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.greenMax.AutoSize = true;
            this.greenMax.Location = new System.Drawing.Point(188, 0);
            this.greenMax.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.greenMax.Name = "greenMax";
            this.greenMax.Size = new System.Drawing.Size(25, 13);
            this.greenMax.TabIndex = 1;
            this.greenMax.Text = "255";
            // 
            // greenMin
            // 
            this.greenMin.AutoSize = true;
            this.greenMin.Location = new System.Drawing.Point(3, 0);
            this.greenMin.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.greenMin.Name = "greenMin";
            this.greenMin.Size = new System.Drawing.Size(13, 13);
            this.greenMin.TabIndex = 0;
            this.greenMin.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.redMin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.redMax, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(49, 40);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(228, 30);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // redMax
            // 
            this.redMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.redMax.AutoSize = true;
            this.redMax.Location = new System.Drawing.Point(188, 0);
            this.redMax.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.redMax.Name = "redMax";
            this.redMax.Size = new System.Drawing.Size(25, 13);
            this.redMax.TabIndex = 1;
            this.redMax.Text = "255";
            // 
            // redMin
            // 
            this.redMin.AutoSize = true;
            this.redMin.Location = new System.Drawing.Point(3, 0);
            this.redMin.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.redMin.Name = "redMin";
            this.redMin.Size = new System.Drawing.Size(13, 13);
            this.redMin.TabIndex = 0;
            this.redMin.Text = "0";
            // 
            // blueLabel
            // 
            this.blueLabel.Location = new System.Drawing.Point(10, 155);
            this.blueLabel.Margin = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(34, 13);
            this.blueLabel.TabIndex = 0;
            this.blueLabel.Text = "Blue:";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(10, 85);
            this.greenLabel.Margin = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(39, 13);
            this.greenLabel.TabIndex = 4;
            this.greenLabel.Text = "Green:";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(10, 15);
            this.redLabel.Margin = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(30, 13);
            this.redLabel.TabIndex = 3;
            this.redLabel.Text = "Red:";
            // 
            // blueBar
            // 
            this.blueBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blueBar.Location = new System.Drawing.Point(49, 150);
            this.blueBar.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.blueBar.Maximum = 255;
            this.blueBar.Name = "blueBar";
            this.blueBar.Size = new System.Drawing.Size(218, 30);
            this.blueBar.TabIndex = 2;
            this.blueBar.TickFrequency = 15;
            this.blueBar.Value = 125;
            this.blueBar.Scroll += new System.EventHandler(this.onScroll);
            // 
            // greenBar
            // 
            this.greenBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.greenBar.Location = new System.Drawing.Point(49, 80);
            this.greenBar.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.greenBar.Maximum = 255;
            this.greenBar.Name = "greenBar";
            this.greenBar.Size = new System.Drawing.Size(218, 30);
            this.greenBar.TabIndex = 1;
            this.greenBar.TickFrequency = 15;
            this.greenBar.Value = 125;
            this.greenBar.Scroll += new System.EventHandler(this.onScroll);
            // 
            // redBar
            // 
            this.redBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redBar.Location = new System.Drawing.Point(49, 10);
            this.redBar.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.redBar.Maximum = 255;
            this.redBar.Name = "redBar";
            this.redBar.Size = new System.Drawing.Size(218, 30);
            this.redBar.TabIndex = 0;
            this.redBar.TickFrequency = 15;
            this.redBar.Value = 125;
            this.redBar.Scroll += new System.EventHandler(this.onScroll);
            // 
            // trackbarContainer
            // 
            this.trackbarContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackbarContainer.AutoSize = true;
            this.trackbarContainer.ColumnCount = 2;
            this.trackbarContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.trackbarContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.trackbarContainer.Controls.Add(this.redBar, 1, 0);
            this.trackbarContainer.Controls.Add(this.greenBar, 1, 2);
            this.trackbarContainer.Controls.Add(this.blueBar, 1, 4);
            this.trackbarContainer.Controls.Add(this.redLabel, 0, 0);
            this.trackbarContainer.Controls.Add(this.greenLabel, 0, 2);
            this.trackbarContainer.Controls.Add(this.blueLabel, 0, 4);
            this.trackbarContainer.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.trackbarContainer.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.trackbarContainer.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.trackbarContainer.Location = new System.Drawing.Point(207, 0);
            this.trackbarContainer.Margin = new System.Windows.Forms.Padding(0);
            this.trackbarContainer.Name = "trackbarContainer";
            this.trackbarContainer.RowCount = 6;
            this.trackbarContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.trackbarContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.trackbarContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.trackbarContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.trackbarContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.trackbarContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.trackbarContainer.Size = new System.Drawing.Size(277, 211);
            this.trackbarContainer.TabIndex = 2;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.mainContainer);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "mainWindow";
            this.Text = "Color Picker";
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).EndInit();
            this.trackbarContainer.ResumeLayout(false);
            this.trackbarContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer;
        private System.Windows.Forms.FlowLayoutPanel palette;
        private System.Windows.Forms.ToolTip colorTip;
        private System.Windows.Forms.TableLayoutPanel trackbarContainer;
        private System.Windows.Forms.TrackBar redBar;
        private System.Windows.Forms.TrackBar greenBar;
        private System.Windows.Forms.TrackBar blueBar;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label redMin;
        private System.Windows.Forms.Label redMax;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label greenMin;
        private System.Windows.Forms.Label greenMax;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label blueMin;
        private System.Windows.Forms.Label blueMax;
    }
}

