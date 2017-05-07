namespace Polygons
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
			this.panel1 = new System.Windows.Forms.Panel();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDraw = new System.Windows.Forms.Button();
			this.nudRadius = new System.Windows.Forms.NumericUpDown();
			this.nudAngleCount = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.tbArea = new System.Windows.Forms.TextBox();
			this.tbPerimeter = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAngleCount)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.chart1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(573, 417);
			this.panel1.TabIndex = 0;
			// 
			// chart1
			// 
			chartArea3.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			chartArea3.AxisX.LineColor = System.Drawing.Color.Gray;
			chartArea3.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea3.AxisX2.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
			chartArea3.AxisY.Crossing = 1.7976931348623157E+308D;
			chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea3.AxisY.Interval = 3D;
			chartArea3.AxisY.LineColor = System.Drawing.Color.Gray;
			chartArea3.AxisY.Maximum = 3D;
			chartArea3.AxisY.Minimum = 0D;
			chartArea3.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea3.Name = "ChartArea";
			this.chart1.ChartAreas.Add(chartArea3);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chart1.Location = new System.Drawing.Point(0, 0);
			this.chart1.Name = "chart1";
			series3.BorderWidth = 3;
			series3.ChartArea = "ChartArea";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
			series3.Color = System.Drawing.Color.LightSeaGreen;
			series3.Name = "Series";
			series3.Points.Add(dataPoint3);
			series3.ShadowOffset = 2;
			this.chart1.Series.Add(series3);
			this.chart1.Size = new System.Drawing.Size(569, 413);
			this.chart1.TabIndex = 3;
			this.chart1.Text = "Chart";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(591, 12);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Size = new System.Drawing.Size(177, 417);
			this.splitContainer1.SplitterDistance = 207;
			this.splitContainer1.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDraw);
			this.groupBox1.Controls.Add(this.nudRadius);
			this.groupBox1.Controls.Add(this.nudAngleCount);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(177, 207);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Draw polygon";
			// 
			// btnDraw
			// 
			this.btnDraw.Location = new System.Drawing.Point(52, 84);
			this.btnDraw.Name = "btnDraw";
			this.btnDraw.Size = new System.Drawing.Size(75, 23);
			this.btnDraw.TabIndex = 2;
			this.btnDraw.Text = "Draw";
			this.btnDraw.UseVisualStyleBackColor = true;
			this.btnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
			// 
			// nudRadius
			// 
			this.nudRadius.DecimalPlaces = 4;
			this.nudRadius.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.nudRadius.Location = new System.Drawing.Point(81, 54);
			this.nudRadius.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.nudRadius.Name = "nudRadius";
			this.nudRadius.Size = new System.Drawing.Size(90, 20);
			this.nudRadius.TabIndex = 1;
			this.nudRadius.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// nudAngleCount
			// 
			this.nudAngleCount.Location = new System.Drawing.Point(81, 28);
			this.nudAngleCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.nudAngleCount.Name = "nudAngleCount";
			this.nudAngleCount.Size = new System.Drawing.Size(90, 20);
			this.nudAngleCount.TabIndex = 1;
			this.nudAngleCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Radius";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Angles count";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnCalculate);
			this.groupBox2.Controls.Add(this.tbArea);
			this.groupBox2.Controls.Add(this.tbPerimeter);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(177, 206);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Statistics";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(52, 102);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 2;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
			// 
			// tbArea
			// 
			this.tbArea.Location = new System.Drawing.Point(81, 62);
			this.tbArea.Name = "tbArea";
			this.tbArea.ReadOnly = true;
			this.tbArea.Size = new System.Drawing.Size(90, 20);
			this.tbArea.TabIndex = 1;
			// 
			// tbPerimeter
			// 
			this.tbPerimeter.Location = new System.Drawing.Point(81, 36);
			this.tbPerimeter.Name = "tbPerimeter";
			this.tbPerimeter.ReadOnly = true;
			this.tbPerimeter.Size = new System.Drawing.Size(90, 20);
			this.tbPerimeter.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Area";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Perimeter";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 441);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.splitContainer1);
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "MainForm";
			this.Text = "Polygons";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAngleCount)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnDraw;
		private System.Windows.Forms.NumericUpDown nudRadius;
		private System.Windows.Forms.NumericUpDown nudAngleCount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.TextBox tbArea;
		private System.Windows.Forms.TextBox tbPerimeter;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}

