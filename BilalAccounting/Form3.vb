Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadGrid()
    End Sub
    Private Sub LoadGrid()
        Using db As New DbBilalAccountingsEntities
            Dim dt = (From a In db.Chart_Of_Accounts Select New With {
                                                         .ID = a.Chart_Of_Accounts_ID,
                                                         .a1 = a.Chart_Of_Accounts_Type.Account.Accounts_Name,
                                                         .a2 = a.Chart_Of_Accounts_Type.Chart_Of_Accounts_Type_Name,
                                                         .b1 = a.Chart_Of_Accounts_Code,
                                                        .b2 = a.Chart_Of_Accounts_Description,
                                                         .e1 = "Name", .e2 = "Father", .e3 = "Mobile",
                                                        .c1 = a.Chart_Of_Accounts_oName,
                                                        .c2 = a.Chart_Of_Accounts_oFather,
                                                        .c3 = a.Chart_Of_Accounts_oMobile,
                                                        .d1 = "Balance",
                                                        .d2 = a.Chart_Of_Accounts_Beginning_Balances,
                                                        .a3 = a.Chart_Of_Accounts_Status}).ToList
            If dt.Count > 0 Then
                VGridControl1.DataSource = dt
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
End Class