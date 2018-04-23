Imports Microsoft.VisualBasic
Imports System
Namespace UsingZoomEvent
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim secondaryAxisY1 As New DevExpress.XtraCharts.SecondaryAxisY()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(1200R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(1340R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(1500R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (CObj(1000R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("E", New Object() { (CObj(1100R))})
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(10R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(13R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(25R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (CObj(23R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("E", New Object() { (CObj(16R))})
			Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(secondaryAxisY1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.Cursor = System.Windows.Forms.Cursors.Default
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.EnableAxisXScrolling = True
			xyDiagram1.EnableAxisXZooming = True
			xyDiagram1.EnableAxisYScrolling = True
			xyDiagram1.EnableAxisYZooming = True
			secondaryAxisY1.AxisID = 0
			secondaryAxisY1.GridLines.Visible = True
			secondaryAxisY1.Name = "Secondary AxisY 1"
			secondaryAxisY1.VisibleInPanesSerializable = "-1"
			xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() { secondaryAxisY1})
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5})
			series2.Name = "Series 2"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10})
			sideBySideBarSeriesView1.AxisYName = "Secondary AxisY 1"
			series2.View = sideBySideBarSeriesView1
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			Me.chartControl1.Size = New System.Drawing.Size(432, 290)
			Me.chartControl1.TabIndex = 0
'			Me.chartControl1.Zoom += New DevExpress.XtraCharts.ChartZoomEventHandler(Me.chartControl1_Zoom);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(432, 290)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(secondaryAxisY1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

