<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.category = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.row = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.row1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.category1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.row4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties11 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties12 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties13 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.row2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties6 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties7 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties8 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.category2 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.row3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties9 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties10 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.PropertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VGridControl1
        '
        Me.VGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.VGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGridControl1.Location = New System.Drawing.Point(21, 41)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.OptionsView.ShowRows = False
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.category, Me.row, Me.row1, Me.category1, Me.row4, Me.row2, Me.category2, Me.row3})
        Me.VGridControl1.Size = New System.Drawing.Size(333, 310)
        Me.VGridControl1.TabIndex = 0
        '
        'category
        '
        Me.category.Height = 23
        Me.category.Name = "category"
        Me.category.Properties.Caption = "Chart of Accounts"
        '
        'row
        '
        Me.row.Name = "row"
        Me.row.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties1, Me.MultiEditorRowProperties2, Me.MultiEditorRowProperties3})
        '
        'MultiEditorRowProperties1
        '
        Me.MultiEditorRowProperties1.FieldName = "a1"
        Me.MultiEditorRowProperties1.Name = "MultiEditorRowProperties1"
        '
        'MultiEditorRowProperties2
        '
        Me.MultiEditorRowProperties2.FieldName = "a2"
        Me.MultiEditorRowProperties2.Name = "MultiEditorRowProperties2"
        '
        'MultiEditorRowProperties3
        '
        Me.MultiEditorRowProperties3.FieldName = "a3"
        Me.MultiEditorRowProperties3.Name = "MultiEditorRowProperties3"
        '
        'row1
        '
        Me.row1.Name = "row1"
        Me.row1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties4, Me.MultiEditorRowProperties5})
        '
        'MultiEditorRowProperties4
        '
        Me.MultiEditorRowProperties4.FieldName = "b1"
        Me.MultiEditorRowProperties4.Name = "MultiEditorRowProperties4"
        '
        'MultiEditorRowProperties5
        '
        Me.MultiEditorRowProperties5.CellWidth = 40
        Me.MultiEditorRowProperties5.FieldName = "b2"
        Me.MultiEditorRowProperties5.Name = "MultiEditorRowProperties5"
        '
        'category1
        '
        Me.category1.Height = 24
        Me.category1.Name = "category1"
        Me.category1.Properties.Caption = "Account Holder"
        '
        'row4
        '
        Me.row4.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.row4.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.row4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.row4.AppearanceHeader.Options.UseBackColor = True
        Me.row4.AppearanceHeader.Options.UseBorderColor = True
        Me.row4.AppearanceHeader.Options.UseFont = True
        Me.row4.Name = "row4"
        Me.row4.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties11, Me.MultiEditorRowProperties12, Me.MultiEditorRowProperties13})
        '
        'MultiEditorRowProperties11
        '
        Me.MultiEditorRowProperties11.FieldName = "e1"
        Me.MultiEditorRowProperties11.Name = "MultiEditorRowProperties11"
        '
        'MultiEditorRowProperties12
        '
        Me.MultiEditorRowProperties12.FieldName = "e2"
        Me.MultiEditorRowProperties12.Name = "MultiEditorRowProperties12"
        '
        'MultiEditorRowProperties13
        '
        Me.MultiEditorRowProperties13.FieldName = "e3"
        Me.MultiEditorRowProperties13.Name = "MultiEditorRowProperties13"
        '
        'row2
        '
        Me.row2.Name = "row2"
        Me.row2.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties6, Me.MultiEditorRowProperties7, Me.MultiEditorRowProperties8})
        '
        'MultiEditorRowProperties6
        '
        Me.MultiEditorRowProperties6.FieldName = "c1"
        Me.MultiEditorRowProperties6.Name = "MultiEditorRowProperties6"
        '
        'MultiEditorRowProperties7
        '
        Me.MultiEditorRowProperties7.FieldName = "c2"
        Me.MultiEditorRowProperties7.Name = "MultiEditorRowProperties7"
        '
        'MultiEditorRowProperties8
        '
        Me.MultiEditorRowProperties8.FieldName = "c3"
        Me.MultiEditorRowProperties8.Name = "MultiEditorRowProperties8"
        '
        'category2
        '
        Me.category2.Height = 25
        Me.category2.Name = "category2"
        Me.category2.Properties.Caption = "Balance"
        '
        'row3
        '
        Me.row3.Name = "row3"
        Me.row3.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties9, Me.MultiEditorRowProperties10})
        '
        'MultiEditorRowProperties9
        '
        Me.MultiEditorRowProperties9.CellWidth = 40
        Me.MultiEditorRowProperties9.FieldName = "d1"
        Me.MultiEditorRowProperties9.Name = "MultiEditorRowProperties9"
        '
        'MultiEditorRowProperties10
        '
        Me.MultiEditorRowProperties10.FieldName = "d2"
        Me.MultiEditorRowProperties10.Name = "MultiEditorRowProperties10"
        '
        'PropertyGridControl1
        '
        Me.PropertyGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PropertyGridControl1.Location = New System.Drawing.Point(710, 5)
        Me.PropertyGridControl1.Name = "PropertyGridControl1"
        Me.PropertyGridControl1.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.[True]
        Me.PropertyGridControl1.SelectedObject = Me.VGridControl1
        Me.PropertyGridControl1.Size = New System.Drawing.Size(400, 433)
        Me.PropertyGridControl1.TabIndex = 1
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 450)
        Me.Controls.Add(Me.PropertyGridControl1)
        Me.Controls.Add(Me.VGridControl1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents category As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents row As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents MultiEditorRowProperties1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents row1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents MultiEditorRowProperties4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties5 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents category1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents row2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents MultiEditorRowProperties6 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties7 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties8 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents category2 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents row3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents MultiEditorRowProperties9 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties10 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents row4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents MultiEditorRowProperties11 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties12 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties13 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents PropertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
End Class
