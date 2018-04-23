Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Configuration
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Data.Filtering

''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1
    Inherits System.Windows.Forms.Form
    Private panelControl1 As DevExpress.XtraEditors.PanelControl
    Private labelControl1 As DevExpress.XtraEditors.LabelControl
    Private unitOfWork1 As DevExpress.Xpo.UnitOfWork
    Private xpCollection1 As DevExpress.Xpo.XPCollection
    Private labelControl2 As DevExpress.XtraEditors.LabelControl
    Private gridControl1 As DevExpress.XtraGrid.GridControl
    Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
    Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Private colContactTitle As DevExpress.XtraGrid.Columns.GridColumn
    Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
    Private colEmployeeFirstName As DevExpress.XtraGrid.Columns.GridColumn
    Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Private colEmployeeLastName As DevExpress.XtraGrid.Columns.GridColumn
    Private colFreight As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents btnFiterSimplified As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btnFilterStandard As DevExpress.XtraEditors.SimpleButton
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.Container = Nothing

    Public Sub New()
        InitializeComponent()

    End Sub

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmployeeFirstName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmployeeLastName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFreight = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl
        Me.xpCollection1 = New DevExpress.Xpo.XPCollection
        Me.unitOfWork1 = New DevExpress.Xpo.UnitOfWork
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnFilterStandard = New DevExpress.XtraEditors.SimpleButton
        Me.btnFiterSimplified = New DevExpress.XtraEditors.SimpleButton
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridView2
        '
        Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderID, Me.colEmployeeFirstName, Me.colEmployeeLastName, Me.colOrderDate, Me.colFreight})
        Me.gridView2.GridControl = Me.gridControl1
        Me.gridView2.Name = "gridView2"
        Me.gridView2.OptionsView.ShowGroupPanel = False
        '
        'colOrderID
        '
        Me.colOrderID.Caption = "OrderID"
        Me.colOrderID.FieldName = "OrderID"
        Me.colOrderID.Name = "colOrderID"
        Me.colOrderID.Visible = True
        Me.colOrderID.VisibleIndex = 0
        '
        'colEmployeeFirstName
        '
        Me.colEmployeeFirstName.Caption = "Employee First Name"
        Me.colEmployeeFirstName.FieldName = "Employee.FirstName"
        Me.colEmployeeFirstName.Name = "colEmployeeFirstName"
        Me.colEmployeeFirstName.Visible = True
        Me.colEmployeeFirstName.VisibleIndex = 1
        '
        'colEmployeeLastName
        '
        Me.colEmployeeLastName.Caption = "Employee Last Name"
        Me.colEmployeeLastName.FieldName = "Employee.LastName"
        Me.colEmployeeLastName.Name = "colEmployeeLastName"
        Me.colEmployeeLastName.Visible = True
        Me.colEmployeeLastName.VisibleIndex = 2
        '
        'colOrderDate
        '
        Me.colOrderDate.Caption = "Order Date"
        Me.colOrderDate.FieldName = "OrderDate"
        Me.colOrderDate.Name = "colOrderDate"
        Me.colOrderDate.Visible = True
        Me.colOrderDate.VisibleIndex = 3
        '
        'colFreight
        '
        Me.colFreight.Caption = "Freight"
        Me.colFreight.FieldName = "Freight"
        Me.colFreight.Name = "colFreight"
        Me.colFreight.Visible = True
        Me.colFreight.VisibleIndex = 4
        '
        'gridControl1
        '
        Me.gridControl1.DataSource = Me.xpCollection1
        Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gridView2
        GridLevelNode1.RelationName = "Orders"
        Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gridControl1.Location = New System.Drawing.Point(0, 0)
        Me.gridControl1.MainView = Me.gridView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.ShowOnlyPredefinedDetails = True
        Me.gridControl1.Size = New System.Drawing.Size(547, 279)
        Me.gridControl1.TabIndex = 1
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1, Me.gridView2})
        '
        'xpCollection1
        '
        Me.xpCollection1.DisplayableProperties = "This;CustomerID;CompanyName;ContactTitle;Orders"
        Me.xpCollection1.ObjectType = GetType(AggregateFilterOnAssociatedCollection.Customer)
        Me.xpCollection1.Session = Me.unitOfWork1
        '
        'gridView1
        '
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustomerID, Me.colCompanyName, Me.colContactTitle})
        Me.gridView1.GridControl = Me.gridControl1
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsDetail.ShowDetailTabs = False
        Me.gridView1.OptionsView.ShowFooter = True
        Me.gridView1.OptionsView.ShowGroupPanel = False
        '
        'colCustomerID
        '
        Me.colCustomerID.Caption = "CustomerID"
        Me.colCustomerID.FieldName = "CustomerID"
        Me.colCustomerID.Name = "colCustomerID"
        Me.colCustomerID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colCustomerID.Visible = True
        Me.colCustomerID.VisibleIndex = 0
        '
        'colCompanyName
        '
        Me.colCompanyName.Caption = "CompanyName"
        Me.colCompanyName.FieldName = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        Me.colCompanyName.Visible = True
        Me.colCompanyName.VisibleIndex = 1
        '
        'colContactTitle
        '
        Me.colContactTitle.Caption = "ContactTitle"
        Me.colContactTitle.FieldName = "ContactTitle"
        Me.colContactTitle.Name = "colContactTitle"
        Me.colContactTitle.Visible = True
        Me.colContactTitle.VisibleIndex = 2
        '
        'panelControl1
        '
        Me.panelControl1.Controls.Add(Me.labelControl2)
        Me.panelControl1.Controls.Add(Me.labelControl1)
        Me.panelControl1.Controls.Add(Me.btnFilterStandard)
        Me.panelControl1.Controls.Add(Me.btnFiterSimplified)
        Me.panelControl1.Controls.Add(Me.btnClear)
        Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelControl1.Location = New System.Drawing.Point(0, 279)
        Me.panelControl1.Name = "panelControl1"
        Me.panelControl1.Size = New System.Drawing.Size(547, 88)
        Me.panelControl1.TabIndex = 0
        '
        'labelControl2
        '
        Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.labelControl2.Location = New System.Drawing.Point(16, 64)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(63, 13)
        Me.labelControl2.TabIndex = 4
        Me.labelControl2.Text = "labelControl2"
        '
        'labelControl1
        '
        Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.labelControl1.Location = New System.Drawing.Point(16, 40)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(63, 13)
        Me.labelControl1.TabIndex = 3
        Me.labelControl1.Text = "labelControl1"
        '
        'btnFilterStandard
        '
        Me.btnFilterStandard.Location = New System.Drawing.Point(18, 8)
        Me.btnFilterStandard.Name = "btnFilterStandard"
        Me.btnFilterStandard.Size = New System.Drawing.Size(184, 23)
        Me.btnFilterStandard.TabIndex = 2
        Me.btnFilterStandard.Text = "Apply Filter (Standard Syntax)"
        '
        'btnFiterSimplified
        '
        Me.btnFiterSimplified.Location = New System.Drawing.Point(208, 8)
        Me.btnFiterSimplified.Name = "btnFiterSimplified"
        Me.btnFiterSimplified.Size = New System.Drawing.Size(184, 23)
        Me.btnFiterSimplified.TabIndex = 2
        Me.btnFiterSimplified.Text = "Apply Filter (Simplified Syntax)"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(400, 8)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Filter"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(547, 367)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.panelControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControl1.ResumeLayout(False)
        Me.panelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Shared Sub Main()
        Dim conn As String = MSSqlConnectionProvider.GetConnectionString("(local)", "Northwind")
        XpoDefault.DataLayer = XpoDefault.GetDataLayer(conn, AutoCreateOption.SchemaAlreadyExists)

        Application.Run(New Form1())
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFilter(Nothing)
    End Sub

    Private Sub SetFilter(ByVal criteria As CriteriaOperator)
        xpCollection1.Criteria = criteria

        If ReferenceEquals(criteria, Nothing) Then
            labelControl1.Text = String.Empty
        Else
            labelControl1.Text = criteria.ToString()
        End If
        labelControl2.Text = String.Format("Total row count: {0}", xpCollection1.Count)
    End Sub

    Private Sub btnFiterStandard_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFilterStandard.Click
        Dim criteria As CriteriaOperator = New AggregateOperand("Orders", Aggregate.Count) > 0
        SetFilter(criteria)
    End Sub

    Private Sub btnFiterSimplified_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFiterSimplified.Click
        Dim criteria As CriteriaOperator = New OperandProperty("Orders").Item(Nothing).Count() > 0
        SetFilter(criteria)
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        SetFilter(Nothing)
    End Sub
End Class
