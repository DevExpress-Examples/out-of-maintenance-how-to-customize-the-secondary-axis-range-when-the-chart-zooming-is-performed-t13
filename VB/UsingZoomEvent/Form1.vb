Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace UsingZoomEvent
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub chartControl1_Zoom(ByVal sender As Object, ByVal e As ChartZoomEventArgs) Handles chartControl1.Zoom
			Dim chart As ChartControl = CType(sender, ChartControl)
			Dim diagram As XYDiagram = CType(chart.Diagram, XYDiagram)
			diagram.SecondaryAxesY(0).VisualRange.SetMinMaxValues(Convert.ToDouble(e.NewYRange.MinValue) / 2, Convert.ToDouble(e.NewYRange.MaxValue))
		End Sub
	End Class
End Namespace
