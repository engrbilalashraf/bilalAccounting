<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim UpcaGenerator2 As DevExpress.XtraPrinting.BarCode.UPCAGenerator = New DevExpress.XtraPrinting.BarCode.UPCAGenerator()
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.TreeListColumn7 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.RepositoryItemToggleSwitch1 = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.BarCodeControl1 = New DevExpress.XtraEditors.BarCodeControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1, Me.TreeListColumn2, Me.TreeListColumn3, Me.TreeListColumn4, Me.TreeListColumn5, Me.TreeListColumn6, Me.TreeListColumn7})
        Me.TreeList1.Location = New System.Drawing.Point(12, 161)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsView.ShowRoot = False
        Me.TreeList1.OptionsView.ShowTreeLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.TreeList1.OptionsView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Large
        Me.TreeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemToggleSwitch1, Me.RepositoryItemPictureEdit1})
        Me.TreeList1.Size = New System.Drawing.Size(776, 277)
        Me.TreeList1.TabIndex = 0
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "TreeListColumn1"
        Me.TreeListColumn1.FieldName = "TreeListColumn1"
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.Visible = True
        Me.TreeListColumn1.VisibleIndex = 0
        '
        'TreeListColumn2
        '
        Me.TreeListColumn2.Caption = "TreeListColumn2"
        Me.TreeListColumn2.FieldName = "TreeListColumn2"
        Me.TreeListColumn2.Name = "TreeListColumn2"
        Me.TreeListColumn2.Visible = True
        Me.TreeListColumn2.VisibleIndex = 1
        '
        'TreeListColumn3
        '
        Me.TreeListColumn3.Caption = "TreeListColumn3"
        Me.TreeListColumn3.FieldName = "TreeListColumn3"
        Me.TreeListColumn3.Name = "TreeListColumn3"
        Me.TreeListColumn3.Visible = True
        Me.TreeListColumn3.VisibleIndex = 2
        '
        'TreeListColumn4
        '
        Me.TreeListColumn4.Caption = "TreeListColumn4"
        Me.TreeListColumn4.FieldName = "TreeListColumn4"
        Me.TreeListColumn4.Name = "TreeListColumn4"
        Me.TreeListColumn4.Visible = True
        Me.TreeListColumn4.VisibleIndex = 3
        '
        'TreeListColumn5
        '
        Me.TreeListColumn5.Caption = "TreeListColumn5"
        Me.TreeListColumn5.FieldName = "TreeListColumn5"
        Me.TreeListColumn5.Name = "TreeListColumn5"
        Me.TreeListColumn5.Visible = True
        Me.TreeListColumn5.VisibleIndex = 4
        '
        'TreeListColumn6
        '
        Me.TreeListColumn6.Caption = "TreeListColumn6"
        Me.TreeListColumn6.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.TreeListColumn6.FieldName = "TreeListColumn6"
        Me.TreeListColumn6.Name = "TreeListColumn6"
        Me.TreeListColumn6.Visible = True
        Me.TreeListColumn6.VisibleIndex = 5
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'TreeListColumn7
        '
        Me.TreeListColumn7.Caption = "TreeListColumn7"
        Me.TreeListColumn7.ColumnEdit = Me.RepositoryItemToggleSwitch1
        Me.TreeListColumn7.FieldName = "TreeListColumn7"
        Me.TreeListColumn7.Name = "TreeListColumn7"
        Me.TreeListColumn7.Visible = True
        Me.TreeListColumn7.VisibleIndex = 6
        '
        'RepositoryItemToggleSwitch1
        '
        Me.RepositoryItemToggleSwitch1.AutoHeight = False
        Me.RepositoryItemToggleSwitch1.Name = "RepositoryItemToggleSwitch1"
        Me.RepositoryItemToggleSwitch1.OffText = "Off"
        Me.RepositoryItemToggleSwitch1.OnText = "On"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(48, 37)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'BarCodeControl1
        '
        Me.BarCodeControl1.Location = New System.Drawing.Point(195, 12)
        Me.BarCodeControl1.Name = "BarCodeControl1"
        Me.BarCodeControl1.Padding = New System.Windows.Forms.Padding(10, 2, 10, 0)
        Me.BarCodeControl1.Size = New System.Drawing.Size(244, 116)
        Me.BarCodeControl1.Symbology = UpcaGenerator2
        Me.BarCodeControl1.TabIndex = 2
        Me.BarCodeControl1.Text = "009090"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(479, 39)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.TextEdit1.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.TextEdit1.Properties.MaskSettings.Set("mask", "------_------_--")
        Me.TextEdit1.Size = New System.Drawing.Size(162, 20)
        Me.TextEdit1.TabIndex = 3
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.BarCodeControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.TreeList1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn7 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents RepositoryItemToggleSwitch1 As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
    Friend WithEvents BarCodeControl1 As DevExpress.XtraEditors.BarCodeControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
End Class
