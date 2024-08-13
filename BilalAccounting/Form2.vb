Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridControl1.MainView = AdvBandedGridView1
        LoadGrid()
    End Sub
    Private Sub LoadGrid()
        Using db As New DbBilalAccountingsEntities
            Dim dt = (From a In db.Chart_Of_Accounts Select New With {
                                                         .ID = a.Chart_Of_Accounts_ID,
                                                         .Accounts = a.Chart_Of_Accounts_Type.Account.Accounts_Name,
                                                         .AccountType = a.Chart_Of_Accounts_Type.Chart_Of_Accounts_Type_Name,
                                                         .Code = a.Chart_Of_Accounts_Code,
                                                        .Desc = a.Chart_Of_Accounts_Description,
                                                        .oName = a.Chart_Of_Accounts_oName,
                                                        .oFather = a.Chart_Of_Accounts_oFather,
                                                        .oMobile = a.Chart_Of_Accounts_oMobile,
                                                        .Balance = a.Chart_Of_Accounts_Beginning_Balances,
                                                        .Status = a.Chart_Of_Accounts_Status}).ToList
            If dt.Count > 0 Then
                GridControl1.DataSource = dt
                'GridView1.Columns("ID").OptionsColumn.AllowEdit = False
                'GridView1.Columns("Accounts").OptionsColumn.AllowEdit = False
                'GridView1.Columns("AccountType").OptionsColumn.AllowEdit = False
                'GridView1.Columns("Code").OptionsColumn.AllowEdit = True
                'GridView1.Columns("Desc").OptionsColumn.AllowEdit = False
                'GridView1.Columns("oName").OptionsColumn.AllowEdit = False
                'GridView1.Columns("oFather").OptionsColumn.AllowEdit = False
                'GridView1.Columns("oMobile").OptionsColumn.AllowEdit = False
                'GridView1.Columns("Balance").OptionsColumn.AllowEdit = False
                'GridView1.Columns("Status").OptionsColumn.AllowEdit = False
                'GridView1.Columns("Accounts").Group()
                'GridView1.Columns("Accounts").Group()
                'GridView1.Columns("Accounts").Group()
                'GridView1.Columns("AccountType").Group()
                'GridView1.ExpandAllGroups()
            End If
        End Using
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs)
        'If e.Column.FieldName = "Code" Then
        '    Using db As New DbBilalAccountingsEntities
        '        Dim id As Integer = GridView1.GetFocusedRowCellValue("ID")
        '        Dim dt = (From a In db.Chart_Of_Accounts Where a.Chart_Of_Accounts_ID = id Select a).FirstOrDefault
        '        If dt IsNot Nothing Then
        '            dt.Chart_Of_Accounts_Code = e.Value
        '            dt.Chart_Of_Accounts_oFather = e.Value + e.Value
        '            db.SaveChanges()
        '            MsgBox("Record is Saved")
        '            GridView1.SetFocusedRowCellValue("oFather", e.Value + e.Value)
        '        End If
        '        'LoadGrid()
        '    End Using
        'End If
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As RowClickEventArgs)
        '   MsgBox(GridView1.GetFocusedRowCellValue("Code"))
    End Sub

    Private Sub GridView1_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs)

    End Sub

    Private Sub GridView1_RowStyle(sender As Object, e As RowStyleEventArgs)

    End Sub

    Private Sub GridView1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs)
        If e.Column.FieldName = "ID" Then
            e.Appearance.BackColor = Color.Black
            e.Appearance.ForeColor = Color.White

        End If

        If e.Column.FieldName = "Code" Then
            If e.CellValue = "2222" Then
                e.Appearance.BackColor = Color.Cyan
            End If
        End If


    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class