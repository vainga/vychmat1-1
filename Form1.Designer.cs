namespace vychmat1_1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelXY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quaDFuncButton = new System.Windows.Forms.RadioButton();
            this.expFuncButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hordeButton = new System.Windows.Forms.RadioButton();
            this.simpleButton = new System.Windows.Forms.RadioButton();
            this.newtonButton = new System.Windows.Forms.RadioButton();
            this.roots = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rootCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.epsilonLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.promZnach = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelXY)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelXY
            // 
            this.panelXY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chartArea1.Name = "ChartArea1";
            this.panelXY.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.panelXY.Legends.Add(legend1);
            this.panelXY.Location = new System.Drawing.Point(6, 9);
            this.panelXY.Margin = new System.Windows.Forms.Padding(2);
            this.panelXY.Name = "panelXY";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.panelXY.Series.Add(series1);
            this.panelXY.Size = new System.Drawing.Size(358, 277);
            this.panelXY.TabIndex = 0;
            this.panelXY.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.quaDFuncButton);
            this.panel1.Controls.Add(this.expFuncButton);
            this.panel1.Location = new System.Drawing.Point(544, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 61);
            this.panel1.TabIndex = 1;
            // 
            // quaDFuncButton
            // 
            this.quaDFuncButton.AutoSize = true;
            this.quaDFuncButton.Location = new System.Drawing.Point(9, 31);
            this.quaDFuncButton.Margin = new System.Windows.Forms.Padding(2);
            this.quaDFuncButton.Name = "quaDFuncButton";
            this.quaDFuncButton.Size = new System.Drawing.Size(111, 17);
            this.quaDFuncButton.TabIndex = 1;
            this.quaDFuncButton.Text = "100*x^2-10000x-2";
            this.quaDFuncButton.UseVisualStyleBackColor = true;
            this.quaDFuncButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.quaDFuncButton_MouseClick);
            // 
            // expFuncButton
            // 
            this.expFuncButton.AutoSize = true;
            this.expFuncButton.Checked = true;
            this.expFuncButton.Location = new System.Drawing.Point(9, 11);
            this.expFuncButton.Margin = new System.Windows.Forms.Padding(2);
            this.expFuncButton.Name = "expFuncButton";
            this.expFuncButton.Size = new System.Drawing.Size(86, 17);
            this.expFuncButton.TabIndex = 0;
            this.expFuncButton.TabStop = true;
            this.expFuncButton.Text = "2^x-5x^2+10";
            this.expFuncButton.UseVisualStyleBackColor = true;
            this.expFuncButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expFuncButton_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.hordeButton);
            this.panel2.Controls.Add(this.simpleButton);
            this.panel2.Controls.Add(this.newtonButton);
            this.panel2.Location = new System.Drawing.Point(544, 73);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 79);
            this.panel2.TabIndex = 2;
            // 
            // hordeButton
            // 
            this.hordeButton.AutoSize = true;
            this.hordeButton.Location = new System.Drawing.Point(11, 51);
            this.hordeButton.Margin = new System.Windows.Forms.Padding(2);
            this.hordeButton.Name = "hordeButton";
            this.hordeButton.Size = new System.Drawing.Size(82, 17);
            this.hordeButton.TabIndex = 2;
            this.hordeButton.Text = "метод хорд";
            this.hordeButton.UseVisualStyleBackColor = true;
            this.hordeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hordeButton_MouseClick);
            // 
            // simpleButton
            // 
            this.simpleButton.AutoSize = true;
            this.simpleButton.Location = new System.Drawing.Point(11, 32);
            this.simpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton.Name = "simpleButton";
            this.simpleButton.Size = new System.Drawing.Size(151, 17);
            this.simpleButton.TabIndex = 1;
            this.simpleButton.Text = "метод простых итераций\r\n";
            this.simpleButton.UseVisualStyleBackColor = true;
            this.simpleButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.simpleButton_MouseClick);
            // 
            // newtonButton
            // 
            this.newtonButton.AutoSize = true;
            this.newtonButton.Checked = true;
            this.newtonButton.Location = new System.Drawing.Point(10, 12);
            this.newtonButton.Margin = new System.Windows.Forms.Padding(2);
            this.newtonButton.Name = "newtonButton";
            this.newtonButton.Size = new System.Drawing.Size(104, 17);
            this.newtonButton.TabIndex = 0;
            this.newtonButton.TabStop = true;
            this.newtonButton.Text = "метод Ньютона";
            this.newtonButton.UseVisualStyleBackColor = true;
            this.newtonButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.newtonButton_MouseClick);
            // 
            // roots
            // 
            this.roots.FormattingEnabled = true;
            this.roots.Location = new System.Drawing.Point(2, 42);
            this.roots.Margin = new System.Windows.Forms.Padding(2);
            this.roots.Name = "roots";
            this.roots.Size = new System.Drawing.Size(164, 69);
            this.roots.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Корни";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество: ";
            // 
            // rootCount
            // 
            this.rootCount.AutoSize = true;
            this.rootCount.Location = new System.Drawing.Point(78, 6);
            this.rootCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rootCount.Name = "rootCount";
            this.rootCount.Size = new System.Drawing.Size(13, 13);
            this.rootCount.TabIndex = 6;
            this.rootCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Погрешность";
            // 
            // epsilonLabel
            // 
            this.epsilonLabel.AutoSize = true;
            this.epsilonLabel.Location = new System.Drawing.Point(78, 27);
            this.epsilonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.epsilonLabel.Name = "epsilonLabel";
            this.epsilonLabel.Size = new System.Drawing.Size(13, 13);
            this.epsilonLabel.TabIndex = 8;
            this.epsilonLabel.Text = "0";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.roots);
            this.panel3.Controls.Add(this.epsilonLabel);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.rootCount);
            this.panel3.Location = new System.Drawing.Point(541, 174);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 115);
            this.panel3.TabIndex = 9;
            // 
            // promZnach
            // 
            this.promZnach.FormattingEnabled = true;
            this.promZnach.Location = new System.Drawing.Point(368, 8);
            this.promZnach.Margin = new System.Windows.Forms.Padding(2);
            this.promZnach.Name = "promZnach";
            this.promZnach.Size = new System.Drawing.Size(164, 277);
            this.promZnach.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 294);
            this.Controls.Add(this.promZnach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelXY);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelXY)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart panelXY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton quaDFuncButton;
        private System.Windows.Forms.RadioButton expFuncButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton hordeButton;
        private System.Windows.Forms.RadioButton simpleButton;
        private System.Windows.Forms.RadioButton newtonButton;
        private System.Windows.Forms.ListBox roots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rootCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label epsilonLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox promZnach;
    }
}

