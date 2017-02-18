using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Polygons
{
	public partial class MainForm : Form
	{
		private double radius;
		private int anglesCount;
		private double side => 2 * radius * Math.Sin(Math.PI / anglesCount);

		public double Perimeter => side * anglesCount;
		public double Area => (anglesCount * Math.Pow(radius, 2) / 2)
							  * Math.Sin(2 * Math.PI / anglesCount);
		public MainForm()
		{
			InitializeComponent();
		}

		private void BtnDraw_Click(object sender, EventArgs e) => RedrawChart();

		private void RedrawChart()
		{
			if (!TryReadInput()) return;

			SetUpChart();

			foreach (var dataPoint in FillDataPoints(anglesCount))
			{
				chart1.Series.FirstOrDefault()?.Points.Add(dataPoint);
			}
		}

		private bool TryReadInput()
		{
			if (nudRadius.Value.Equals(0))
			{
				MessageBox.Show("Radius can not be equal 0",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				nudRadius.Value = 0.1M;
				return false;
			}

			anglesCount = (int)nudAngleCount.Value;
			radius = (double)nudRadius.Value;
			return true;
		}

		private void SetUpChart()
		{
			chart1.Series.FirstOrDefault()?.Points.Clear();
			var area = chart1.ChartAreas.FirstOrDefault();
			if (area != null)
			{
				area.AxisX.Interval = 360.0 / anglesCount;
				area.AxisY.Maximum = area.AxisY.Interval = radius;
			}
		}

		private IEnumerable<DataPoint> FillDataPoints(int count)
		{
			if (count <= 0)
				yield break;

			for (int i = 0; i <= count; i++)
			{
				var angle = 360 * i / count;
				yield return new DataPoint(angle, radius);
			}
		}

		private void BtnCalculate_Click(object sender, EventArgs e)
		{
			if (!TryReadInput()) return;
			tbPerimeter.Text = Math.Round(Perimeter, 4).ToString(CultureInfo.InvariantCulture);
			tbArea.Text = Math.Round(Area, 4).ToString(CultureInfo.InvariantCulture);
		}
	}
}
