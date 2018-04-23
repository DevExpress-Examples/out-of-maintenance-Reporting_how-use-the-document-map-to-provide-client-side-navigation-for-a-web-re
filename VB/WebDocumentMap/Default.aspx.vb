Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.Web
' ...

Namespace WebDocumentMap
	Partial Public Class _Default
		Inherits System.Web.UI.Page

		Protected Overrides Sub OnPreRender(ByVal e As EventArgs)
			SiteMapBookmarkFiller.FillSiteMapWithBookmarks(ASPxSiteMapDataSource1, _ 
				ReportViewer1)
			MyBase.OnPreRender(e)
		End Sub


	End Class
End Namespace



