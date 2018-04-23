Namespace DocumentMapInWebReport
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
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As New DevExpress.DataAccess.Sql.Table()
            Dim column2 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2})
            Me.Detail.Dpi = 100F
            Me.Detail.HeightF = 23F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.BookmarkParent = Me.xrLabel1
            Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { _
                New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryProducts.ProductName"), _
                New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "CategoryProducts.ProductName") _
            })
            Me.xrLabel2.Dpi = 100F
            Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 9.75F)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(59.375F, 0F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(590.625F, 23F)
            Me.xrLabel2.StylePriority.UseFont = False
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { _
                New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryProducts.CategoryName"), _
                New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "CategoryProducts.CategoryName") _
            })
            Me.xrLabel1.Dpi = 100F
            Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold)
            Me.xrLabel1.ForeColor = System.Drawing.Color.SteelBlue
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10.00001F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(650F, 23F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Dpi = 100F
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Dpi = 100F
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "ProductID"
            table1.MetaSerializable = "30|30|125|160"
            table1.Name = "CategoryProducts"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "SupplierID"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "ProductName"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "CategoryName"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Picture"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "Description"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Name = "CategoryProducts"
            selectQuery1.Tables.Add(table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
            Me.GroupHeader1.Dpi = 100F
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.HeightF = 33.33333F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1})
            Me.Bookmark = "Products by Categories"
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
            Me.DataMember = "CategoryProducts"
            Me.DataSource = Me.sqlDataSource1
            Me.Version = "16.1"
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    End Class
End Namespace
