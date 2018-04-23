using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace UsingZoomEvent {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void chartControl1_Zoom(object sender, ChartZoomEventArgs e) {
            ChartControl chart = (ChartControl)sender;
            XYDiagram diagram = (XYDiagram)chart.Diagram;
            diagram.SecondaryAxesY[0].VisualRange.SetMinMaxValues(Convert.ToDouble(e.NewYRange.MinValue) / 2,
                                                                  Convert.ToDouble(e.NewYRange.MaxValue));
        }
    }
}
