Imports Microsoft.VisualBasic
Imports System
Namespace WebApplication1
	Partial Public Class XtraReport1
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
			Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
			Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim tableQuery2 As New DevExpress.DataAccess.Sql.TableQuery()
			Dim tableInfo2 As New DevExpress.DataAccess.Sql.TableInfo()
			Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo9 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo10 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo11 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo12 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo13 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo14 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo15 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo16 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo17 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim masterDetailInfo1 As New DevExpress.DataAccess.Sql.MasterDetailInfo()
			Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource("nwind.mdb")
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.Detail.HeightF = 33.00001F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 100F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 100F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' sqlDataSource1
			' 
			tableQuery1.Name = "Categories"
			tableInfo1.Name = "Categories"
			columnInfo1.Name = "CategoryID"
			columnInfo2.Name = "CategoryName"
			columnInfo3.Name = "Description"
			columnInfo4.Name = "Picture"
			columnInfo5.Name = "Icon_17"
			columnInfo6.Name = "Icon_25"
			tableInfo1.SelectedColumns.Add(columnInfo1)
			tableInfo1.SelectedColumns.Add(columnInfo2)
			tableInfo1.SelectedColumns.Add(columnInfo3)
			tableInfo1.SelectedColumns.Add(columnInfo4)
			tableInfo1.SelectedColumns.Add(columnInfo5)
			tableInfo1.SelectedColumns.Add(columnInfo6)
			tableQuery1.Tables.Add(tableInfo1)
			tableQuery2.Name = "Products"
			tableInfo2.Name = "Products"
			columnInfo7.Name = "ProductID"
			columnInfo8.Name = "ProductName"
			columnInfo9.Name = "SupplierID"
			columnInfo10.Name = "CategoryID"
			columnInfo11.Name = "QuantityPerUnit"
			columnInfo12.Name = "UnitPrice"
			columnInfo13.Name = "UnitsInStock"
			columnInfo14.Name = "UnitsOnOrder"
			columnInfo15.Name = "ReorderLevel"
			columnInfo16.Name = "Discontinued"
			columnInfo17.Name = "EAN13"
			tableInfo2.SelectedColumns.Add(columnInfo7)
			tableInfo2.SelectedColumns.Add(columnInfo8)
			tableInfo2.SelectedColumns.Add(columnInfo9)
			tableInfo2.SelectedColumns.Add(columnInfo10)
			tableInfo2.SelectedColumns.Add(columnInfo11)
			tableInfo2.SelectedColumns.Add(columnInfo12)
			tableInfo2.SelectedColumns.Add(columnInfo13)
			tableInfo2.SelectedColumns.Add(columnInfo14)
			tableInfo2.SelectedColumns.Add(columnInfo15)
			tableInfo2.SelectedColumns.Add(columnInfo16)
			tableInfo2.SelectedColumns.Add(columnInfo17)
			tableQuery2.Tables.Add(tableInfo2)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1, tableQuery2})
			masterDetailInfo1.DetailQueryName = "Products"
			relationColumnInfo1.NestedKeyColumn = "CategoryID"
			relationColumnInfo1.ParentKeyColumn = "CategoryID"
			masterDetailInfo1.KeyColumns.Add(relationColumnInfo1)
			masterDetailInfo1.MasterQueryName = "Categories"
			masterDetailInfo1.Name = "CategoriesProducts"
			Me.sqlDataSource1.Relations.Add(masterDetailInfo1)
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName"), New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Categories.CategoryName")})
			Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel1.ForeColor = System.Drawing.Color.SteelBlue
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(629.9999F, 23F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseForeColor = False
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1})
			Me.DetailReport.DataMember = "Categories.CategoriesProducts"
			Me.DetailReport.DataSource = Me.sqlDataSource1
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2})
			Me.Detail1.HeightF = 23F
			Me.Detail1.Name = "Detail1"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.BookmarkParent = Me.xrLabel1
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName"), New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Categories.CategoriesProducts.ProductName")})
			Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 9.75F)
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(36.04167F, 0F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(603.9582F, 23F)
			Me.xrLabel2.StylePriority.UseFont = False
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
			Me.Bookmark = "Products by Categories"
			Me.DataMember = "Categories"
			Me.DataSource = Me.sqlDataSource1
			Me.Version = "14.1"
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
