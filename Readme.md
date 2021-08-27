<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574292/14.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T137138)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/UsingZoomEvent/Form1.cs) (VB: [Form1.vb](./VB/UsingZoomEvent/Form1.vb))
<!-- default file list end -->
# How to customize the secondary axis range when the chart zooming is performed 


<p>This example shows how to adjust the secondary Y-axis range along which the chart is zoomed.</p>
<p> </p>


<h3>Description</h3>

<p>To accomplish this task, obtain the secondary Y-axis in the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraChartsChartControl_Zoomtopic">ChartControl.Zoom</a>&nbsp;event&nbsp;handler and&nbsp;specify a custom secondary Y-axis range by calling&nbsp; the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsRange_SetMinMaxValuestopic">Range.SetMinMaxValues</a> method.</p>

<br/>


