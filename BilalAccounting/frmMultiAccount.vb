Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.Entity
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Imports System.Drawing.Imaging
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports System.IO
Imports DevExpress.XtraEditors.Repository

Public Class frmMultiAccount

    Dim Load_cmb_Sch_Credit_Accounts_ID As New cmb_Sch_Credit_Accounts_ID
    Dim Load_cmb_Chart_Of_Accounts As New cmb_Chart_Of_Accounts
    Dim Load_cmb_Sch_Accounts_Default_ID As New cmb_Sch_Accounts_Default_ID
    Dim Load_cmb_Accounts As New cmb_Accounts

    Public intMultiAccount As Integer


    Dim db As New DbBilalAccountingsEntities
    Private Sub frmMultiAccount_Load(sender As Object, e As EventArgs) Handles Me.Load
        'PlazaUserID = 1
        lood()

        Load_cmb_Sch_Accounts_Default_ID.ColumnsAndData(SearchLookUpEdit1)

        Sch_Accounts_Added_Date.EditValue = Today

        'LoadAccountsSummary()
        GridControl5.DataSource = Nothing
        SearchLookUpEdit1.EditValue = Nothing
        Load_cmb_Accounts.ColumnsAndData(RepositoryItemLookUpEdit1)

        Sch_Accounts_Description.ReadOnly = True
        Sch_Accounts_Amount.ReadOnly = True

        'GridView4.ShowFindPanel()
        'GridView5.ShowFindPanel()


    End Sub

    'Public Btn_LayoutView() As BarButtonItem
    'Private Sub LoadPlaza(bgb As RibbonPageGroup)
    '    Using dzb As New DbBilalAccountingsEntities
    '        Dim dt = (From a In dzb.Plazas Select a).ToList
    '        If dt.Count > 0 Then
    '            bgb.ItemLinks.Clear()

    '            Dim km As Integer = 0

    '            ReDim Btn_LayoutView(dt.Count - 1)
    '            For Each dts In dt
    '                Btn_LayoutView(km) = New BarButtonItem

    '                Btn_LayoutView(km).Tag = dts.Plaza_ID
    '                Btn_LayoutView(km).Visibility = BarItemVisibility.Always
    '                Btn_LayoutView(km).ButtonStyle = BarButtonStyle.Check
    '                Btn_LayoutView(km).AllowAllUp = True
    '                Dim pl As String = ""
    '                If CBool(InStr(dts.Plaza_Name, " ")) Then
    '                    pl = dts.Plaza_Name
    '                Else
    '                    pl = dts.Plaza_Name & " Plaza"
    '                End If
    '                Btn_LayoutView(km).Caption = pl
    '                Dim img As Image = CreateImage(pl.Split(CType(" ", Char()))(0).First & " " & pl.Split(CType(" ", Char()))(1).First,
    '                            "",
    '                            New Font("A750-Sans-Cd-Light", 16, FontStyle.Bold),
    '                            Color.FromArgb(CInt(dts.Plaza_FontColor)),
    '                            Color.FromArgb(CInt(dts.Plaza_BackColor))) ' Image.FromFile(Application.StartupPath & "\Images\" & dts.Plaza_Name & ".png")
    '                Btn_LayoutView(km).LargeGlyph = img

    '                AddHandler Btn_LayoutView(km).ItemClick, AddressOf Btn_LayoutView_ItemClick
    '                bgb.ItemLinks.Add(Btn_LayoutView(km))

    '                'Btn_LayoutView(km).Glyph = img
    '                'Btn_LayoutView(km).PaintStyle = BarItemPaintStyle.Standard
    '                'Bar1.AddItem(Btn_LayoutView(km))





    '                km += 1
    '            Next

    '        End If
    '    End Using
    'End Sub
    'Private Sub Btn_LayoutView_ItemClick(sender As Object, e As ItemClickEventArgs)


    '    'Try
    '    '    If frmMain.TabX1.ActiveDocument.ControlName = frmCusAdds Then

    '    '        Dim frm As frmCusAdd = CType(frmMain.Dcm1.View.ActiveDocument.Form, frmCusAdd)

    '    Load_cmb_Sch_Accounts_Default_ID.ColumnsAndData(SearchLookUpEdit1)

    '    Sch_Accounts_Added_Date.EditValue = Today

    '    LoadAccountsSummary()
    '    GridControl5.DataSource = Nothing
    '    SearchLookUpEdit1.EditValue = Nothing
    '    'LoadCombo(intMultiPlaza)
    '    'LookUpEdit1.EditValue = intMultiPlaza
    '    'cmb_Load_Customer.EditValue = Nothing
    '    'LoadPlaza(frm.RibbonPageGroup7)
    '    '    End If
    '    'Catch ex As Exception

    '    'End Try
    '    'Dim frmx As frmShop = New frmShop
    '    '  frmShopA.BtnLayoutViewItemClick(intMultiPlaza)
    '    'If frmMain.TabX1.ActiveDocument.ControlName = frmShops Then
    '    '    Dim frm As frmShop = CType(frmMain.Dcm1.View.ActiveDocument.Form, frmShop)
    '    '    frm.BtnLayoutViewItemClick(intMultiPlaza)
    '    'End If




    '    'Load_cmb_Plaza.ColumnsAndData(RepositoryItemLookUpEdit3)
    '    'Load_cmb_Floor.ColumnsAndData(RepositoryItemLookUpEdit1, idx)
    '    'Load_cmb_Shop_Type.ColumnsAndData(RepositoryItemLookUpEdit4)
    '    'Db.Shops.Where(Function(o) o.Floor.Plaza_ID = idx).Load()
    '    'BindingSource1.DataSource = Db.Shops.Local.ToBindingList() '.Where(Function(o) o.Floor.Plaza_ID = idx)
    'End Sub




    Public Sub lood()
        Load_cmb_Sch_Credit_Accounts_ID.ColumnsAndData(Sch_Credit_Accounts_ID)
        Load_cmb_Chart_Of_Accounts.ColumnsAndData(Sch_Debit_Accounts_ID)
    End Sub
    Private Sub SearchLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEdit1.EditValueChanged
        Using db As New DbBilalAccountingsEntities
            'Try

            'If swi = False Then
            'FixID = Sch_Debit_Accounts_ID.EditValue
            'Sch_Credit_Accounts_ID.EditValue = Nothing
            LoadData(SearchLookUpEdit1.EditValue)
            'End If
            'Catch ex As Exception

            'End Try

        End Using
    End Sub
    'Where If(AccountID = 0, a.Chart_Of_Accounts.Chart_Of_Accounts_Status = True, a.Sch_Debit_Accounts_ID = AccountID And a.Chart_Of_Accounts.Chart_Of_Accounts_Status = True)
    Private Sub LoadData(AccountID As Integer)
        Using db As New DbBilalAccountingsEntities

            Dim kk = (From a In db.Sch_Accounts_Default Where a.Sch_Accounts_Default_ID = AccountID Select a).FirstOrDefault
            If kk IsNot Nothing Then
                Sch_Debit_Accounts_ID.EditValue = kk.Sch_Debit_Accounts_ID
                Sch_Credit_Accounts_ID.EditValue = kk.Sch_Credit_Accounts_ID
                Sch_Debit_Accounts_ID.Properties.ReadOnly = True
                Sch_Credit_Accounts_ID.Properties.ReadOnly = False
                Sch_Accounts_Description.ReadOnly = True
                Sch_Accounts_Amount.ReadOnly = True
                Dim imgg As Image = Image.FromFile(Application.StartupPath & "\Images\No Image.png")
                Dim img As Byte() = ImgToByteArray(imgg, ImageFormat.Png)
                Dim dt = (From a In db.Sch_Accounts Where a.Sch_Accounts_Default_ID = kk.Sch_Accounts_Default_ID Order By a.Sch_Accounts_Invoice_Number Descending
                          Select
                  a.Sch_Accounts_ID, a.Sch_Accounts_Default_ID,
                  a.Sch_Accounts_Added_Date,
                  a.Sch_Accounts_Invoice_Number,
                  a.Sch_Accounts_Default.Chart_Of_Accounts.Chart_Of_Accounts_Type.Account.Accounts_Name,
                  a.Sch_Accounts_Default.Chart_Of_Accounts.Chart_Of_Accounts_Type.Chart_Of_Accounts_Type_Name,
                  Chart_Of_Accounts_Description = a.Sch_Accounts_Default.Chart_Of_Accounts.Chart_Of_Accounts_Description,
                  Chart_Of_Accounts_Description1 = a.Sch_Accounts_Default.Chart_Of_Accounts1.Chart_Of_Accounts_Description,
                  a.Sch_Accounts_Description,
                  a.Sch_Accounts_Amount_Debit,
                  a.Sch_Accounts_Amount_Credits,
                  a.Sch_Accounts_Update_Date,
                              Sch_Accounts_Image = If(a.Sch_Accounts_Image IsNot Nothing, a.Sch_Accounts_Image, img)
                 ).ToList
                If dt.Count > 0 Then
                    GridControl1.DataSource = dt
                Else
                    GridControl1.DataSource = Nothing
                    Sch_Accounts_Description.ReadOnly = True
                    Sch_Accounts_Amount.ReadOnly = True
                End If
            End If



        End Using
    End Sub





    'Public Function CalculationOfCashAccount(CashID As Integer) As Double
    '    Using db As New DbBilalAccountingsEntities
    '        Dim SumX As Double = 0
    '        'Dim cashID As Integer = CInt(CashAccount.EditValue)
    '        Dim dt = (From a In db.P_Purchase_Detail_Account Where a.Chart_Of_Accounts_ID = CashID Group By a.Chart_Of_Accounts_ID
    '              Into z = Group, sumDebit = Sum(If(a.P_Purchase_Detail_Account_Debit IsNot Nothing, a.P_Purchase_Detail_Account_Debit, 0)), sumCredit = Sum(If(a.P_Purchase_Detail_Account_Credit IsNot Nothing, a.P_Purchase_Detail_Account_Credit, 0)) Select sumBalance = sumDebit - sumCredit).FirstOrDefault
    '        If dt IsNot Nothing Then
    '            SumX = CDbl(dt)
    '        Else
    '            SumX = 0
    '        End If
    '        Return SumX
    '    End Using
    'End Function
    Private Sub LoadAccountsSummary()
        Using db As New DbBilalAccountingsEntities
            'Dim dt = (From a In db.Chart_Of_Accounts Select a).ToList
            'If dt.Count > 0 Then
            '    For Each dts In dt
            '        Dim sumX1 As Double = 0
            '        Dim sumX2 As Double = 0
            '        Dim dta = (From a In db.Sch_Accounts Where a.Sch_Debit_Accounts_ID = dts.Chart_Of_Accounts_ID Select a.Sch_Accounts_Amount_Debit).Sum
            '        If dta IsNot Nothing Then
            '            sumX1 = dta
            '        Else
            '            sumX1 = 0
            '        End If
            '        Dim dtb = (From a In db.Sch_Accounts Where a.Sch_Credit_Accounts_ID = dts.Chart_Of_Accounts_ID Select a.Sch_Accounts_Amount_Credits).Sum
            '        If dtb IsNot Nothing Then
            '            sumX2 = dtb
            '        Else
            '            sumX2 = 0
            '        End If
            '        dts.Chart_Of_Accounts_Beginning_Balances = sumX1 - sumX2
            '        db.SaveChanges()
            '    Next
            'End If 
            'Dim dtzz = (From a In db.Chart_Of_Accounts Group Join b In db.Chart_Of_Accounts_Detail.Where(Function(o) o.Chart_Of_Accounts_Detail_Account_Type = "Jrnl") On a.Chart_Of_Accounts_ID Equals b.Chart_Of_Accounts_ID
            'Into z = Group, Debit = Sum(b.Chart_Of_Accounts_Detail_Account_Debit), Credit = Sum(b.Chart_Of_Accounts_Detail_Account_Credit)
            '            Let BalanceX = If(Debit Is Nothing, 0, Debit) - If(Credit Is Nothing, 0, Credit)
            '          Select New With {a.Chart_Of_Accounts_ID, a.Chart_Of_Accounts_Type.Account.Accounts_Type, a.Chart_Of_Accounts_Type.Account.Chart_Of_Accounts_Type, a.Chart_Of_Accounts_Description, BalanceX}).ToList
            'If dtzz.Count > 0 Then

            '    GridControl2.DataSource = dtzz
            '    GridView2.ActiveFilterString = "[BalanceX] <> 0 "
            'Else
            '    GridControl2.DataSource = Nothing
            'End If
            Dim dtzz = (From a In db.Chart_Of_Accounts Select New With {a.Chart_Of_Accounts_ID, a.Chart_Of_Accounts_Type.Account.Accounts_Name, a.Chart_Of_Accounts_Type.Chart_Of_Accounts_Type_Name, a.Chart_Of_Accounts_Description, .BalanceX = a.Chart_Of_Accounts_Beginning_Balances}).ToList
            If dtzz.Count > 0 Then

                GridControl2.DataSource = dtzz
                GridView2.ActiveFilterString = "[BalanceX] <> 0 "
            Else
                GridControl2.DataSource = Nothing
            End If
        End Using
    End Sub
    Dim FixID As Integer = 0
    Private Sub Sch_Debit_Accounts_ID_EditValueChanged(sender As Object, e As EventArgs) Handles Sch_Debit_Accounts_ID.EditValueChanged
        Using db As New DbBilalAccountingsEntities
            Dim IDX As Integer = CInt(Sch_Debit_Accounts_ID.EditValue)
            Dim dt = (From a In db.Chart_Of_Accounts Where a.Chart_Of_Accounts_ID = IDX Select a).FirstOrDefault
            If dt IsNot Nothing Then
                'Chart_Of_Accounts_oName.Text = dt.Chart_Of_Accounts_oName
                'Chart_Of_Accounts_oFather.Text = dt.Chart_Of_Accounts_oFather
                'Chart_Of_Accounts_oMobile.Text = dt.Chart_Of_Accounts_oMobile
                Dim fg = (From a In db.Sch_Accounts_Default Where a.Sch_Debit_Accounts_ID = IDX Select a).FirstOrDefault
                If fg IsNot Nothing Then
                    SearchLookUpEdit1.EditValue = fg.Sch_Accounts_Default_ID
                    Sch_Accounts_Invoice_Number.Text = Auto_Sch_Accounts_Invoice_Number()
                    Sch_Accounts_Description.Focus()
                    Sch_Accounts_Description.ReadOnly = False
                    Sch_Accounts_Amount.ReadOnly = False
                    Sch_Accounts_Description.Text = ""
                    Sch_Accounts_Amount.Text = ""
                Else
                    SearchLookUpEdit1.EditValue = Nothing
                End If
            End If
        End Using
    End Sub
    Private Sub Sch_Credit_Accounts_ID_EditValueChanged(sender As Object, e As EventArgs) Handles Sch_Credit_Accounts_ID.EditValueChanged
        Using db As New DbBilalAccountingsEntities
            Dim IDX As Integer = CInt(Sch_Credit_Accounts_ID.EditValue)
            Dim dt = (From a In db.Chart_Of_Accounts Where a.Chart_Of_Accounts_ID = IDX Select a).FirstOrDefault
            If dt IsNot Nothing Then
                'Chart_Of_Accounts_oName2.Text = dt.Chart_Of_Accounts_oName
                'Chart_Of_Accounts_oFather2.Text = dt.Chart_Of_Accounts_oFather
                'Chart_Of_Accounts_oMobile2.Text = dt.Chart_Of_Accounts_oMobile
            End If
        End Using


        'Using db As New DbBilalAccountingsEntities
        '    Dim Sch_Debit_Accounts_ID As Integer = Chart_Of_Accounts_ID.EditValue
        '    Dim aa As Integer = Sch_Credit_Accounts_ID.EditValue
        '    Dim dt = (From a In db.Sch_Accounts_Default Where a.Sch_Debit_Accounts_ID = Sch_Debit_Accounts_ID Select a).FirstOrDefault
        '    If dt IsNot Nothing Then
        '        dt.Sch_Credit_Accounts_ID = aa
        '    Else
        '    End If
        '    db.SaveChanges()
        'End Using


        ' ''Using db As New DbBilalAccountingsEntities
        ' ''    Dim Sch_Debit_Accounts_IDx As Integer = Sch_Debit_Accounts_ID.EditValue
        ' ''    Dim Sch_Credit_Accounts_IDx As Integer = Sch_Credit_Accounts_ID.EditValue
        ' ''    Dim dt = (From a In db.Sch_Accounts_Default Where a.Sch_Debit_Accounts_ID = Sch_Debit_Accounts_IDx And a.Sch_Credit_Accounts_ID = Sch_Credit_Accounts_IDx Select a).FirstOrDefault
        ' ''    If dt IsNot Nothing Then
        ' ''        'Try
        ' ''        '    Sch_Credit_Accounts_ID.EditValue = db.Sch_Accounts_Default.Where(Function(o) o.Sch_Debit_Accounts_ID = Sch_Debit_Accounts_ID).FirstOrDefault.Sch_Credit_Accounts_ID
        ' ''        'Catch ex As Exception

        ' ''        'End Try
        ' ''        '.Sch_Debit_Accounts_ID = Sch_Debit_Accounts_ID
        ' ''        Sch_Credit_Accounts_ID.EditValue = dt.Sch_Credit_Accounts_ID
        ' ''    Else
        ' ''        Dim dtNew = New Sch_Accounts_Default
        ' ''        With dtNew
        ' ''            .Sch_Debit_Accounts_ID = Sch_Debit_Accounts_IDx
        ' ''            .Sch_Credit_Accounts_ID = Sch_Credit_Accounts_IDx
        ' ''        End With
        ' ''        db.Sch_Accounts_Default.Add(dtNew)
        ' ''    End If
        ' ''    db.SaveChanges()

        ' ''    LoadData(Sch_Debit_Accounts_ID.EditValue)

        ' ''End Using
    End Sub
    Private Function AccountIDx() As Integer
        Dim Sch_Debit_Accounts_IDx As Integer = Sch_Debit_Accounts_ID.EditValue
        Dim Sch_Credit_Accounts_IDx As Integer = Sch_Credit_Accounts_ID.EditValue
        Dim idx As Integer = SearchLookUpEdit1.EditValue
        Dim Acc As Integer = 0
        Dim dt = (From a In db.Sch_Accounts_Default Where a.Sch_Accounts_Default_ID = idx And a.Sch_Debit_Accounts_ID = Sch_Debit_Accounts_IDx And a.Sch_Credit_Accounts_ID = Sch_Credit_Accounts_IDx Select a).FirstOrDefault
        If dt IsNot Nothing Then
            'Try
            '    Sch_Credit_Accounts_ID.EditValue = db.Sch_Accounts_Default.Where(Function(o) o.Sch_Debit_Accounts_ID = Sch_Debit_Accounts_ID).FirstOrDefault.Sch_Credit_Accounts_ID
            'Catch ex As Exception

            'End Try
            '.Sch_Debit_Accounts_ID = Sch_Debit_Accounts_ID

            'Sch_Credit_Accounts_ID.EditValue = dt.Sch_Credit_Accounts_ID
            'db.SaveChanges()
            Acc = dt.Sch_Accounts_Default_ID
        Else
            Dim dtNew = New Sch_Accounts_Default
            With dtNew
                .Sch_Debit_Accounts_ID = Sch_Debit_Accounts_IDx
                .Sch_Credit_Accounts_ID = Sch_Credit_Accounts_IDx
            End With
            db.Sch_Accounts_Default.Add(dtNew)
            db.SaveChanges()
            Acc = dtNew.Sch_Accounts_Default_ID
        End If


        Return Acc
    End Function
    'Dim swi As Boolean = False
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        'swi = True
        SearchLookUpEdit1.EditValue = Nothing
        SearchLookUpEdit1.Properties.ReadOnly = True
        Sch_Debit_Accounts_ID.EditValue = Nothing
        Sch_Credit_Accounts_ID.EditValue = Nothing
        Sch_Debit_Accounts_ID.Properties.ReadOnly = False
        Sch_Credit_Accounts_ID.Properties.ReadOnly = False
        'Load_cmb_Chart_Of_Accounts.ColumnsAndData(Sch_Debit_Accounts_ID)
        Sch_Accounts_Invoice_Number.Text = Auto_Sch_Accounts_Invoice_Number()
        Sch_Accounts_Description.Focus()
        Sch_Accounts_Description.ReadOnly = False
        Sch_Accounts_Amount.ReadOnly = False
        Sch_Accounts_Description.Text = ""
        Sch_Accounts_Amount.Text = ""
        GridControl1.DataSource = Nothing
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Sch_Accounts_Description.ReadOnly = False
        Sch_Accounts_Amount.ReadOnly = False
        Sch_Accounts_Description.Focus()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        SaveAndUpdate()
    End Sub


    Private Sub SaveAndUpdate()
        Using db As New DbBilalAccountingsEntities
            'If swi = False Then
            FixID = SearchLookUpEdit1.EditValue
            'Else
            '    FixID = AccountIDx()
            'End If
            'Dim Accc As Integer = AccountIDx()

            Dim DatX As DateTime = Sch_Accounts_Added_Date.EditValue
            If Sch_Debit_Accounts_ID.EditValue Is Nothing Then
                MsgBox("Please Select Debit side Account")
            Else
                If Sch_Credit_Accounts_ID.EditValue Is Nothing Then
                    MsgBox("Please Select Credit side Account")
                Else
                    If Sch_Accounts_Invoice_Number.Text = "" Then
                        MsgBox("Please Select Previous Invoice or Create NEW")
                    Else
                        If Sch_Accounts_Description.Text = "" Then
                            MsgBox("Please Type Item Name", vbCritical, "Canteen Error")
                        Else
                            Dim InCV As String = Sch_Accounts_Invoice_Number.Text

                            Dim dt = (From a In db.Sch_Accounts Where a.Sch_Accounts_Default_ID = FixID And a.Sch_Accounts_Invoice_Number = InCV Select a).FirstOrDefault
                            If dt IsNot Nothing Then
                                With dt
                                    .Sch_Debit_Accounts_ID = Sch_Debit_Accounts_ID.EditValue
                                    .Sch_Credit_Accounts_ID = Sch_Credit_Accounts_ID.EditValue
                                    .Sch_Accounts_Description = Sch_Accounts_Description.Text
                                    .Sch_Accounts_Amount_Debit = If(Sch_Accounts_Amount.Text = "", 0, CType(Sch_Accounts_Amount.Text, Decimal))
                                    .Sch_Accounts_Amount_Credits = If(Sch_Accounts_Amount.Text = "", 0, CType(Sch_Accounts_Amount.Text, Decimal))
                                    .Sch_Accounts_Update_Date = DatX
                                End With

                                'If Disc <> 0 Then
                                'MsgBox("hg")
                                Dim dtAccZ = (From a In db.Chart_Of_Accounts_Detail Where a.Sch_Accounts_ID = dt.Sch_Accounts_ID And a.Chart_Of_Accounts_ID = dt.Sch_Debit_Accounts_ID And a.Chart_Of_Accounts_Detail_Account_Type = "Jrnl" Select a).FirstOrDefault
                                If dtAccZ IsNot Nothing Then
                                    With dtAccZ
                                        .Chart_Of_Accounts_Detail_Account_Trans_No = dt.Sch_Accounts_Invoice_Number
                                        .Chart_Of_Accounts_Detail_Account_Type = "Jrnl"
                                        .Sch_Accounts_ID = dt.Sch_Accounts_ID
                                        .Chart_Of_Accounts_ID = dt.Sch_Debit_Accounts_ID
                                        .Chart_Of_Accounts_Detail_Account_Date = CDate(Sch_Accounts_Added_Date.EditValue)
                                        .Chart_Of_Accounts_Detail_Account_Debit = CDec(dt.Sch_Accounts_Amount_Debit)
                                    End With
                                    db.SaveChanges()
                                    'MsgBox("fgfg")
                                Else
                                    Dim dtAccxZ = New Chart_Of_Accounts_Detail
                                    With dtAccxZ
                                        .Chart_Of_Accounts_Detail_Account_Trans_No = dt.Sch_Accounts_Invoice_Number
                                        .Chart_Of_Accounts_Detail_Account_Type = "Jrnl"
                                        .Sch_Accounts_ID = dt.Sch_Accounts_ID
                                        .Chart_Of_Accounts_ID = dt.Sch_Debit_Accounts_ID
                                        .Chart_Of_Accounts_Detail_Account_Date = CDate(Sch_Accounts_Added_Date.EditValue)
                                        .Chart_Of_Accounts_Detail_Account_Debit = CDec(dt.Sch_Accounts_Amount_Debit)
                                    End With
                                    db.Chart_Of_Accounts_Detail.Add(dtAccxZ)


                                End If
                                Dim dtAccZ2 = (From a In db.Chart_Of_Accounts_Detail Where a.Sch_Accounts_ID = dt.Sch_Accounts_ID And a.Chart_Of_Accounts_ID = dt.Sch_Credit_Accounts_ID And a.Chart_Of_Accounts_Detail_Account_Type = "Jrnl" Select a).FirstOrDefault
                                If dtAccZ2 IsNot Nothing Then
                                    With dtAccZ2
                                        .Chart_Of_Accounts_Detail_Account_Trans_No = dt.Sch_Accounts_Invoice_Number
                                        .Chart_Of_Accounts_Detail_Account_Type = "Jrnl"
                                        .Sch_Accounts_ID = dt.Sch_Accounts_ID
                                        .Chart_Of_Accounts_ID = dt.Sch_Credit_Accounts_ID
                                        .Chart_Of_Accounts_Detail_Account_Date = CDate(Sch_Accounts_Added_Date.EditValue)
                                        .Chart_Of_Accounts_Detail_Account_Credit = CDec(dt.Sch_Accounts_Amount_Credits)
                                    End With
                                    db.SaveChanges()
                                    'MsgBox("fgfg")
                                Else

                                    Dim dtAccxZ3 = New Chart_Of_Accounts_Detail
                                    With dtAccxZ3
                                        .Chart_Of_Accounts_Detail_Account_Trans_No = dt.Sch_Accounts_Invoice_Number
                                        .Chart_Of_Accounts_Detail_Account_Type = "Jrnl"
                                        .Sch_Accounts_ID = dt.Sch_Accounts_ID
                                        .Chart_Of_Accounts_ID = dt.Sch_Credit_Accounts_ID
                                        .Chart_Of_Accounts_Detail_Account_Date = CDate(Sch_Accounts_Added_Date.EditValue)
                                        .Chart_Of_Accounts_Detail_Account_Credit = CDec(dt.Sch_Accounts_Amount_Credits)
                                    End With
                                    db.Chart_Of_Accounts_Detail.Add(dtAccxZ3)
                                End If
                                'Else
                                '    'Dim dtAccZ2 = (From a In db.P_Purchase_Detail_Account Where a.P_Purchase_Check_ID = dt.P_Purchase_Check_ID And a.P_Purchase_Check_Detail_ID = intP_Purchase_Check_Detail_ID And a.Chart_Of_Accounts_ID = MasPayableID And a.P_Purchase_Detail_Account_Type = "CHKPJ" Select a).FirstOrDefault
                                '    'If dtAccZ2 IsNot Nothing Then
                                '    '    db.P_Purchase_Detail_Account.Remove(dtAccZ2)
                                '    'End If
                                '    'Dim dtAccZ3 = (From a In db.P_Purchase_Detail_Account Where a.P_Purchase_Check_ID = dt.P_Purchase_Check_ID And a.P_Purchase_Check_Detail_ID = intP_Purchase_Check_Detail_ID And a.Chart_Of_Accounts_ID = dt.P_Purchase_Check_Amount_Income_Account_ID And a.P_Purchase_Detail_Account_Type = "CHKCDJIncome" Select a).FirstOrDefault
                                '    'If dtAccZ3 IsNot Nothing Then
                                '    '    db.P_Purchase_Detail_Account.Remove(dtAccZ3)
                                '    'End If
                                'End If


                                db.SaveChanges()
                                FixID = dt.Sch_Accounts_Default_ID
                            Else
                                Dim dtNew = New Sch_Accounts
                                With dtNew
                                    'Dim fg = (From a In db.Sch_Accounts_Default Where a.Sch_Accounts_Default_ID = FixID Select a).FirstOrDefault
                                    'If fg IsNot Nothing Then


                                    .Sch_Accounts_Default_ID = AccountIDx()
                                    .Sch_Debit_Accounts_ID = Sch_Debit_Accounts_ID.EditValue
                                    .Sch_Credit_Accounts_ID = Sch_Credit_Accounts_ID.EditValue
                                    .Sch_Accounts_Invoice_Number = Auto_Sch_Accounts_Invoice_Number()
                                    .Sch_Accounts_Description = Sch_Accounts_Description.Text
                                    .Sch_Accounts_Amount_Debit = If(Sch_Accounts_Amount.Text = "", 0, CType(Sch_Accounts_Amount.Text, Decimal))
                                    .Sch_Accounts_Amount_Credits = If(Sch_Accounts_Amount.Text = "", 0, CType(Sch_Accounts_Amount.Text, Decimal))
                                    .Sch_Accounts_Added_Date = DatX
                                    'End If

                                End With
                                db.Sch_Accounts.Add(dtNew)
                                'db.SaveChanges()
                                Dim AddNum = (From a In db.Auto_Number Select a).FirstOrDefault
                                If AddNum IsNot Nothing Then
                                    'Dim AddInt As String = Replace(AutoAdmissionNumber(), "A-", "")
                                    AddNum.Sch_Shop_Invoice_Number = Replace(Replace(Auto_Sch_Accounts_Invoice_Number(), "JOU-", ""), Microsoft.VisualBasic.Right(Replace(Auto_Sch_Accounts_Invoice_Number(), "JOU-", ""), 3), "")
                                End If
                                'If sumZ <> 0 Then
                                Dim dtAccxZ = New Chart_Of_Accounts_Detail
                                With dtAccxZ
                                    .Chart_Of_Accounts_Detail_Account_Trans_No = dtNew.Sch_Accounts_Invoice_Number
                                    .Chart_Of_Accounts_Detail_Account_Type = "Jrnl"
                                    .Sch_Accounts_ID = dtNew.Sch_Accounts_ID
                                    .Chart_Of_Accounts_ID = dtNew.Sch_Debit_Accounts_ID
                                    .Chart_Of_Accounts_Detail_Account_Date = CDate(Sch_Accounts_Added_Date.EditValue)
                                    .Chart_Of_Accounts_Detail_Account_Debit = CDec(dtNew.Sch_Accounts_Amount_Debit)
                                End With
                                db.Chart_Of_Accounts_Detail.Add(dtAccxZ)
                                'db.SaveChanges()

                                Dim dtAccxZ3 = New Chart_Of_Accounts_Detail
                                With dtAccxZ3
                                    .Chart_Of_Accounts_Detail_Account_Trans_No = dtNew.Sch_Accounts_Invoice_Number
                                    .Chart_Of_Accounts_Detail_Account_Type = "Jrnl"
                                    .Sch_Accounts_ID = dtNew.Sch_Accounts_ID
                                    .Chart_Of_Accounts_ID = dtNew.Sch_Credit_Accounts_ID
                                    .Chart_Of_Accounts_Detail_Account_Date = CDate(Sch_Accounts_Added_Date.EditValue)
                                    .Chart_Of_Accounts_Detail_Account_Credit = CDec(dtNew.Sch_Accounts_Amount_Credits)
                                End With
                                db.Chart_Of_Accounts_Detail.Add(dtAccxZ3)
                                db.SaveChanges()
                                'End If
                                'Accc = dtNew.Sch_Accounts_Default_ID
                                db.SaveChanges()
                                FixID = dtNew.Sch_Accounts_Default_ID
                            End If

                            Sch_Accounts_Description.Text = ""
                            Sch_Accounts_Amount.Text = ""
                            Sch_Accounts_Description.ReadOnly = True
                            Sch_Accounts_Amount.ReadOnly = True
                            'swi = False
                            Load_cmb_Sch_Accounts_Default_ID.ColumnsAndData(SearchLookUpEdit1)
                            SearchLookUpEdit1.EditValue = FixID
                            SearchLookUpEdit1.Properties.ReadOnly = False
                            'LoadData(idx)
                            Sch_Debit_Accounts_ID.Properties.ReadOnly = True
                            Sch_Credit_Accounts_ID.Properties.ReadOnly = True
                            UpdatesAccounts(FixID)
                            UpdatesAccountsNetIncome(139)
                            LoadAccountsSummary()
                            BarButtonItem4.PerformClick()
                        End If
                    End If
                End If
            End If

        End Using
    End Sub

    Private Sub UpdatesAccounts(ids As Integer)
        Using db As New DbBilalAccountingsEntities
            Dim dt = (From a In db.Sch_Accounts_Default Where a.Sch_Accounts_Default_ID = ids Select a).FirstOrDefault
            If dt IsNot Nothing Then
                Dim dtf = (From a In db.Chart_Of_Accounts Where a.Chart_Of_Accounts_ID = dt.Sch_Debit_Accounts_ID Select a).FirstOrDefault
                If dtf IsNot Nothing Then
                    Dim dtzz = (From a In db.Chart_Of_Accounts_Detail Where a.Chart_Of_Accounts_ID = dtf.Chart_Of_Accounts_ID Group a By a.Chart_Of_Accounts_ID
                                Into z = Group, Debit = Sum(a.Chart_Of_Accounts_Detail_Account_Debit), Credit = Sum(a.Chart_Of_Accounts_Detail_Account_Credit)
                                Let BalanceX = If(Debit Is Nothing, 0, Debit) - If(Credit Is Nothing, 0, Credit)
                                Select BalanceX).FirstOrDefault
                    If dtzz IsNot Nothing Then
                        dtf.Chart_Of_Accounts_Beginning_Balances = dtzz.Value
                    Else
                        dtf.Chart_Of_Accounts_Beginning_Balances = 0
                    End If
                End If
                Dim dtfd = (From a In db.Chart_Of_Accounts Where a.Chart_Of_Accounts_ID = dt.Sch_Credit_Accounts_ID Select a).FirstOrDefault
                If dtfd IsNot Nothing Then
                    Dim dtzz = (From a In db.Chart_Of_Accounts_Detail Where a.Chart_Of_Accounts_ID = dtfd.Chart_Of_Accounts_ID Group a By a.Chart_Of_Accounts_ID
                                Into z = Group, Debit = Sum(a.Chart_Of_Accounts_Detail_Account_Debit), Credit = Sum(a.Chart_Of_Accounts_Detail_Account_Credit)
                                Let BalanceX = If(Debit Is Nothing, 0, Debit) - If(Credit Is Nothing, 0, Credit)
                                Select BalanceX).FirstOrDefault
                    If dtzz IsNot Nothing Then
                        dtfd.Chart_Of_Accounts_Beginning_Balances = dtzz.Value
                    Else
                        dtfd.Chart_Of_Accounts_Beginning_Balances = 0
                    End If
                End If
                db.SaveChanges()
            End If
        End Using
    End Sub
    Private Sub UpdatesAccountsNetIncome(ids As Integer)
        Using db As New DbBilalAccountingsEntities

            Dim dtf = (From a In db.Chart_Of_Accounts Where a.Chart_Of_Accounts_ID = ids Select a).FirstOrDefault
            If dtf IsNot Nothing Then
                Dim Income As Double = 0
                Dim Expense As Double = 0
                Dim NetIncome As Double = 0

                Dim dtzz = (From a In db.Chart_Of_Accounts_Detail Where a.Chart_Of_Accounts.Chart_Of_Accounts_Type.Accounts_ID = 4 Group a By a.Chart_Of_Accounts.Chart_Of_Accounts_Type.Accounts_ID
                Into z = Group, Debit = Sum(a.Chart_Of_Accounts_Detail_Account_Debit), Credit = Sum(a.Chart_Of_Accounts_Detail_Account_Credit)
                            Let BalanceX = If(Debit Is Nothing, 0, Debit) - If(Credit Is Nothing, 0, Credit)
                            Select BalanceX).FirstOrDefault
                If dtzz IsNot Nothing Then
                    Income = dtzz.Value
                Else
                    Income = 0
                End If


                Dim dtzzd = (From a In db.Chart_Of_Accounts_Detail Where a.Chart_Of_Accounts.Chart_Of_Accounts_Type.Accounts_ID = 6 Group a By a.Chart_Of_Accounts.Chart_Of_Accounts_Type.Accounts_ID
                            Into z = Group, Debit = Sum(a.Chart_Of_Accounts_Detail_Account_Debit), Credit = Sum(a.Chart_Of_Accounts_Detail_Account_Credit)
                             Let BalanceX = If(Debit Is Nothing, 0, Debit) - If(Credit Is Nothing, 0, Credit)
                             Select BalanceX).FirstOrDefault
                If dtzzd IsNot Nothing Then
                    Expense = dtzzd.Value
                Else
                    Expense = 0
                End If
                NetIncome = Income - Expense
                dtf.Chart_Of_Accounts_Beginning_Balances = NetIncome
                db.SaveChanges()
            End If

        End Using
    End Sub
    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        'swi = False
        'If swi = False Then
        Load_cmb_Sch_Accounts_Default_ID.ColumnsAndData(SearchLookUpEdit1)

        SearchLookUpEdit1.EditValue = FixID
        SearchLookUpEdit1.Properties.ReadOnly = False
        LoadData(SearchLookUpEdit1.EditValue)
        'LoadAccountsSummary()
        'End If
    End Sub
    Private Sub Sch_Accounts_Added_Date_KeyDown(sender As Object, e As KeyEventArgs) Handles Sch_Accounts_Added_Date.KeyDown
        If e.KeyCode = Keys.Enter Then
            'SaveAndUpdate()
            Sch_Accounts_Amount.Focus()
        End If
    End Sub
    Private Sub Sch_Accounts_Description_KeyDown(sender As Object, e As KeyEventArgs) Handles Sch_Accounts_Description.KeyDown
        If e.KeyCode = Keys.Enter Then
            'SaveAndUpdate()
            Sch_Accounts_Amount.Focus()
        End If
    End Sub

    Private Sub Sch_Accounts_Amount_KeyDown(sender As Object, e As KeyEventArgs) Handles Sch_Accounts_Amount.KeyDown
        If e.KeyCode = Keys.Enter Then
            SaveAndUpdate()
        End If
    End Sub





    Private Sub GridView2_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView2.RowClick
        'swi = False
        intMultiAccount = GridView2.GetFocusedRowCellValue("Chart_Of_Accounts_ID")
        ''Dim dt = (From a In db.Sch_Accounts_Default Where a.Sch_Debit_Accounts_ID = a.Sch_Debit_Accounts_ID Select a).FirstOrDefault



        ''Lbl_Accounts.Text = GridView2.GetFocusedRowCellValue("DebitAccount") & " (" & GridView2.GetFocusedRowCellValue("Chart_Of_Accounts_Type_Name") & ")"
        'SearchLookUpEdit1.EditValue = intMultiAccount



        LoadDataX(intMultiAccount)
    End Sub

    Private Sub Sch_Accounts_Description_EditValueChanged(sender As Object, e As EventArgs) Handles Sch_Accounts_Description.EditValueChanged

    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        'Sch_Debit_Accounts_ID.EditValue = intMultiAccount
        'LoadDataX()
    End Sub
    Private Sub LoadDataX(AccountID As Integer)
        Using db As New DbBilalAccountingsEntities

            'Dim kk = (From a In db.Sch_Accounts_Default Where a.Sch_Accounts_Default_ID = AccountID Select a).FirstOrDefault
            'If kk IsNot Nothing Then
            '    Sch_Debit_Accounts_ID.EditValue = kk.Sch_Debit_Accounts_ID
            '    Sch_Credit_Accounts_ID.EditValue = kk.Sch_Credit_Accounts_ID
            '    Sch_Debit_Accounts_ID.Properties.ReadOnly = True
            '    Sch_Credit_Accounts_ID.Properties.ReadOnly = True
            '    Sch_Accounts_Description.ReadOnly = True
            '    Sch_Accounts_Amount.ReadOnly = True
            Dim imgg As Image = Image.FromFile(Application.StartupPath & "\Images\No Image.png")
            Dim img As Byte() = ImgToByteArray(imgg, ImageFormat.Png)
            Dim dt = (From a In db.Sch_Accounts Where a.Sch_Debit_Accounts_ID = AccountID Or a.Sch_Credit_Accounts_ID = AccountID Order By a.Sch_Accounts_Invoice_Number Descending
                      Select
                       a.Sch_Accounts_ID, a.Sch_Accounts_Default_ID,
                       a.Sch_Accounts_Added_Date,
                       a.Sch_Accounts_Invoice_Number,
                       a.Sch_Accounts_Default.Chart_Of_Accounts.Chart_Of_Accounts_Type.Account.Accounts_Name,
                       a.Sch_Accounts_Default.Chart_Of_Accounts.Chart_Of_Accounts_Type.Chart_Of_Accounts_Type_Name,
                       Chart_Of_Accounts_Description = a.Sch_Accounts_Default.Chart_Of_Accounts.Chart_Of_Accounts_Description,
                       Chart_Of_Accounts_Description1 = a.Sch_Accounts_Default.Chart_Of_Accounts1.Chart_Of_Accounts_Description,
                       a.Sch_Accounts_Description,
                       a.Sch_Accounts_Amount_Debit,
                       a.Sch_Accounts_Amount_Credits,
                       a.Sch_Accounts_Update_Date,
                              Sch_Accounts_Image = If(a.Sch_Accounts_Image IsNot Nothing, a.Sch_Accounts_Image, img)
             ).ToList
            If dt.Count > 0 Then
                GridControl1.DataSource = dt
            Else
                GridControl1.DataSource = Nothing
                Sch_Accounts_Description.ReadOnly = True
                Sch_Accounts_Amount.ReadOnly = True
            End If
            'End If



        End Using
    End Sub
    'Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
    '    GridView1.PrintDialog()
    'End Sub

    'Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
    '    GridView1.ShowRibbonPrintPreview()
    'End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        'Dim frm As New frmChartOfAccountsAdd1
        'frm.WindowState = FormWindowState.Normal
        'frm.ShowDialog()

    End Sub

    Private Sub AdvBandedGridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles AdvBandedGridView1.RowClick
        Sch_Accounts_Invoice_Number.Text = AdvBandedGridView1.GetFocusedRowCellValue("Sch_Accounts_Invoice_Number")
        Sch_Accounts_Description.Text = AdvBandedGridView1.GetFocusedRowCellValue("Sch_Accounts_Description")
        Sch_Accounts_Amount.Text = AdvBandedGridView1.GetFocusedRowCellValue("Sch_Accounts_Amount_Debit")
        'Sch_Accounts_Added_Date.EditValue = GridView1.GetFocusedRowCellValue("Sch_Accounts_Added_Date") 
    End Sub

    Private Sub Sch_Accounts_Amount_EditValueChanged(sender As Object, e As EventArgs) Handles Sch_Accounts_Amount.EditValueChanged

    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick

    End Sub

    Private Sub GridControl2_Click(sender As Object, e As EventArgs) Handles GridControl2.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Sch_Debit_Accounts_ID.Properties.ReadOnly = True
        Sch_Credit_Accounts_ID.Properties.ReadOnly = False
        Sch_Accounts_Invoice_Number.Text = Auto_Sch_Accounts_Invoice_Number()
        Sch_Accounts_Description.Focus()
        Sch_Accounts_Description.ReadOnly = False
        Sch_Accounts_Amount.ReadOnly = False
        Sch_Accounts_Description.Text = ""
        Sch_Accounts_Amount.Text = ""
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem6.ItemClick

    End Sub



    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        'swi = True
        SearchLookUpEdit1.EditValue = Nothing
        SearchLookUpEdit1.Properties.ReadOnly = True
        Sch_Debit_Accounts_ID.EditValue = Nothing
        Sch_Credit_Accounts_ID.EditValue = Nothing
        Sch_Debit_Accounts_ID.Properties.ReadOnly = False
        Sch_Credit_Accounts_ID.Properties.ReadOnly = False
        'Load_cmb_Chart_Of_Accounts.ColumnsAndData(Sch_Debit_Accounts_ID)
        Sch_Accounts_Invoice_Number.Text = Auto_Sch_Accounts_Invoice_Number()
        Sch_Accounts_Description.Focus()
        Sch_Accounts_Description.ReadOnly = False
        Sch_Accounts_Amount.ReadOnly = False
        Sch_Accounts_Description.Text = ""
        Sch_Accounts_Amount.Text = ""
        GridControl1.DataSource = Nothing
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        SaveAndUpdate()
    End Sub
    Dim chkMP As CheckButton
    Private Sub AccBtn(chkBtn As CheckButton)
        ''For k As Integer = 0 To RpAcc.ItemLinks.Count - 1
        ''    If TypeOf RpAcc.ItemLinks.Item(k).Item Is BarButtonItem Then
        ''        TryCast(RpAcc.ItemLinks.Item(k).Item, BarButtonItem).Down = False
        ''    End If
        ''Next
        ''DirectCast(sender, BarButtonItem).Down = True
        ''Dim id As Integer = DirectCast(sender, BarButtonItem).Tag
        '  Dim btnX As CheckButton = chkBtn
        'chkBtn.Checked = True
        Dim id As Integer = chkBtn.Tag


        'Using db As New DbBilalAccountingsEntities
        '    Dim dt = (From a In db.Chart_Of_Accounts_Type Where a.Accounts_ID = id Select New With {
        '                                                      .ID = a.Chart_Of_Accounts_Type_ID,
        '                                                      .AccountHead = a.Account.Accounts_Type,
        '                                                      .AccountTyyype = a.Chart_Of_Accounts_Type_Name}).ToList()
        '    If dt.Count() > 0 Then
        '        GridControl3.DataSource = dt
        '    Else
        '        GridControl3.DataSource = Nothing
        '    End If
        'End Using

        Dim dtzz = (From a In db.Chart_Of_Accounts Where a.Chart_Of_Accounts_Type.Accounts_ID = id Select New With {a.Chart_Of_Accounts_ID, a.Chart_Of_Accounts_Type.Account.Accounts_Name, a.Chart_Of_Accounts_Type.Chart_Of_Accounts_Type_Name, a.Chart_Of_Accounts_Description, .BalanceX = a.Chart_Of_Accounts_Beginning_Balances}).ToList
        If dtzz.Count > 0 Then

            GridControl2.DataSource = dtzz
            GridView2.ActiveFilterString = "[BalanceX] <> 0 "
        Else
            GridControl2.DataSource = Nothing
        End If



        dbContext = New DbBilalAccountingsEntities()
        'GridView4.Columns.Clear()
        'Dim ColH0 As GridColumn = New GridColumn With {.FieldName = "Chart_Of_Accounts_Type_ID", .Caption = "ID", .Visible = False}
        'GridView4.Columns.Add(ColH0)
        'Dim ColH1 As GridColumn = New GridColumn With {.FieldName = "Chart_Of_Accounts_Type_Name", .Caption = "AccountType", .Visible = True}
        'GridView4.Columns.Add(ColH1)
        'BindingSource1.DataSource = Nothing
        dbContext.Chart_Of_Accounts_Type.Where(Function(o) o.Accounts_ID = id).Load()
        GridControl4.DataSource = New BindingSource With {.DataSource = dbContext.Chart_Of_Accounts_Type.Local.ToBindingList()}

        ''''Dim txt As New TextBox


        ''''txt = New TextBox With {.Text = "jhjhgj", .BackColor = Color.Cyan}
        ''''Dim gridc As New GridColumn

        ''''gridc.Caption = ""


        ''''GridView1.Columns.Add(gridc)

        ''''GridView1.Columns.Add(New GridColumn With {.Caption = "", .FieldName = ""})

    End Sub
    Dim dbContext As DbBilalAccountingsEntities = New DbBilalAccountingsEntities()



    Private Sub BarButtonItem11_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem11.ItemClick,
        BarButtonItem12.ItemClick,
        BarButtonItem13.ItemClick,
        BarButtonItem14.ItemClick,
        BarButtonItem15.ItemClick

        'AccBtn(e.Item)
    End Sub

    Private Sub CheckButton1_Click(sender As Object, e As EventArgs) Handles CheckButton1.Click,
            CheckButton2.Click,
            CheckButton3.Click,
            CheckButton4.Click,
            CheckButton5.Click

        'For k As Integer = 0 To RpAcc.ItemLinks.Count - 1
        '    If TypeOf RpAcc.ItemLinks.Item(k).Item Is BarButtonItem Then
        '        TryCast(RpAcc.ItemLinks.Item(k).Item, BarButtonItem).Down = False
        '    End If
        'Next

        CheckButton1.Checked = False
        CheckButton2.Checked = False
        CheckButton3.Checked = False
        CheckButton4.Checked = False
        CheckButton5.Checked = False


        Dim chkBtn As CheckButton = TryCast(sender, CheckButton)

        'chkBtn.Checked = True
        chkMP = chkBtn
        AccBtn(chkBtn)






    End Sub

    'Private Sub CheckButton2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckButton2.Click
    '    CheckButton1.Checked = False
    '    'CheckButton2.Checked = True
    '    CheckButton3.Checked = False
    '    CheckButton4.Checked = False
    '    CheckButton5.Checked = False
    'End Sub
    'Private Sub CheckButton3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckButton3.Click
    '    CheckButton1.Checked = False
    '    CheckButton2.Checked = False
    '    'CheckButton3.Checked = True
    '    CheckButton4.Checked = False
    '    CheckButton5.Checked = False
    'End Sub

    Dim Load_cmb_Chart_Of_Accounts_Type As New cmb_Chart_Of_Accounts_Type
    Private Sub GridView4_RowClick(sender As Object, e As RowClickEventArgs) Handles GridView4.RowClick
        LoadAccounts(GridView4.GetFocusedRowCellValue("Chart_Of_Accounts_Type_ID"))
        Load_cmb_Chart_Of_Accounts_Type.ColumnsAndData(Chart_Of_Accounts_Type_ID)
        Chart_Of_Accounts_Type_ID.EditValue = CInt(GridView4.GetFocusedRowCellValue("Chart_Of_Accounts_Type_ID"))
        LabelControl1.Text = GridView4.GetFocusedRowCellValue("Chart_Of_Accounts_Type_Name")
        SearchLookUpEdit1.EditValue = Nothing
        Sch_Debit_Accounts_ID.EditValue = Nothing
        GridControl1.DataSource = Nothing
    End Sub

    Private Sub LoadAccounts(id As Integer)
        Using db As New DbBilalAccountingsEntities
            Dim dt = (From a In db.Chart_Of_Accounts Where a.Chart_Of_Accounts_Type_ID = id And a.Chart_Of_Accounts_Status = True Select New With {.ID = a.Chart_Of_Accounts_ID,
                                                                    .AccountNo = a.Chart_Of_Accounts_Code,
                                                                    .Discription = a.Chart_Of_Accounts_Description,
                                                                      .Balance = a.Chart_Of_Accounts_Beginning_Balances,
                                                                      .Status = a.Chart_Of_Accounts_Status}).ToList
            If dt.Count > 0 Then
                GridControl5.DataSource = dt
                GridView5.Columns("ID").Visible = False
                GridView5.Columns("Status").Visible = False
            Else
                GridControl5.DataSource = Nothing
            End If

        End Using
    End Sub

    Private Sub GridView5_RowClick(sender As Object, e As RowClickEventArgs) Handles GridView5.RowClick
        intMultiAccount = GridView5.GetFocusedRowCellValue("ID")
        ''Dim dt = (From a In db.Sch_Accounts_Default Where a.Sch_Debit_Accounts_ID = a.Sch_Debit_Accounts_ID Select a).FirstOrDefault



        ''Lbl_Accounts.Text = GridView2.GetFocusedRowCellValue("DebitAccount") & " (" & GridView2.GetFocusedRowCellValue("Chart_Of_Accounts_Type_Name") & ")"
        'SearchLookUpEdit1.EditValue = intMultiAccount

        Load_cmb_Chart_Of_Accounts.ColumnsAndData(Sch_Debit_Accounts_ID)
        Sch_Debit_Accounts_ID.EditValue = intMultiAccount
        LoadDataX(intMultiAccount)
    End Sub

    Private Sub GridView4_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView4.RowUpdated
        dbContext.SaveChanges()
        AccBtn(chkMP)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Chart_Of_Accounts_Status.Checked = True
        Chart_Of_Accounts_Code.Text = ""
        Chart_Of_Accounts_Description.Text = ""
        FlyoutPanel1.ShowPopup()
        Chart_Of_Accounts_Description.Focus()
    End Sub
    Dim UpdateId As Integer = 0
    Private Sub FlyoutPanel1_ButtonClick(sender As Object, e As DevExpress.Utils.FlyoutPanelButtonClickEventArgs)
        Select Case e.Button.Caption
            Case "Save"
        End Select
    End Sub

    Private Sub GridView5_DoubleClick(sender As Object, e As EventArgs) Handles GridView5.DoubleClick
        intMultiAccount = GridView5.GetFocusedRowCellValue("ID")
        FlyoutPanel1.ShowPopup()
        Chart_Of_Accounts_Description.Focus()
        GetAcc(intMultiAccount)
    End Sub
    Public Sub GetAcc(IDx As Integer)
        Using db = New DbBilalAccountingsEntities
            Dim Accounts = (From a In db.Chart_Of_Accounts Where a.Chart_Of_Accounts_ID = IDx Select a).FirstOrDefault()
            If Accounts IsNot Nothing Then
                With Accounts
                    'UpdateId = .Chart_Of_Accounts_ID
                    Chart_Of_Accounts_ID.Text = .Chart_Of_Accounts_ID
                    Chart_Of_Accounts_Code.Text = .Chart_Of_Accounts_Code
                    Chart_Of_Accounts_Description.Text = .Chart_Of_Accounts_Description
                    Chart_Of_Accounts_Type_ID.EditValue = .Chart_Of_Accounts_Type_ID
                    'Chart_Of_Accounts_Beginning_Balances.Text = .Chart_Of_Accounts_Beginning_Balances
                    Chart_Of_Accounts_Status.Checked = .Chart_Of_Accounts_Status
                    'Chart_Of_Accounts_oName.Text = .Chart_Of_Accounts_oName
                    'Chart_Of_Accounts_oFather.Text = .Chart_Of_Accounts_oFather
                    'Chart_Of_Accounts_oMobile.Text = .Chart_Of_Accounts_oMobile
                End With
            End If
        End Using
    End Sub

    Private Sub BarButtonItem16_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        FlyoutPanel2.ShowPopup()
        LoadDataJournal()
    End Sub

    Private Sub LoadDataJournal()
        Using db As New DbBilalAccountingsEntities
            Dim dt = (From a In db.Sch_Accounts Order By a.Sch_Accounts_Added_Date Descending
                      Select New With {
                 .ID = a.Sch_Accounts_ID,
                  .AddedDate = a.Sch_Accounts_Added_Date,
                 .Jrnl = a.Sch_Accounts_Invoice_Number,
                 .Account = a.Sch_Accounts_Default.Chart_Of_Accounts.Chart_Of_Accounts_Type.Account.Accounts_Name,
                 .AccountType = a.Sch_Accounts_Default.Chart_Of_Accounts.Chart_Of_Accounts_Type.Chart_Of_Accounts_Type_Name,
                 .AccountDebit = a.Sch_Accounts_Default.Chart_Of_Accounts.Chart_Of_Accounts_Description,
                 .AccountCredit = a.Sch_Accounts_Default.Chart_Of_Accounts1.Chart_Of_Accounts_Description,
                 .Description = a.Sch_Accounts_Description,
                .Debit = a.Sch_Accounts_Amount_Debit,
                .Credit = a.Sch_Accounts_Amount_Credits
                 }).ToList
            If dt.Count > 0 Then
                GridControl3.DataSource = dt
                GridView6.Columns("Jrnl").SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Count, "{0}")
                GridView6.Columns("Debit").SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0}")
                GridView6.Columns("Credit").SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0}")
            Else
                GridControl3.DataSource = Nothing
            End If
        End Using
    End Sub

    Private Sub FlyoutPanel2_ButtonClick(sender As Object, e As DevExpress.Utils.FlyoutPanelButtonClickEventArgs) Handles FlyoutPanel2.ButtonClick
        Select Case e.Button.Caption
            Case "Close"
                FlyoutPanel2.HidePopup()
        End Select
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            Using db As New DbBilalAccountingsEntities
                'Dim AccID As Integer
                If InStr(Chart_Of_Accounts_Code.Text, "ACC-") Or Chart_Of_Accounts_Code.Text = "" Then
                    Dim tyID As Integer = CInt(Chart_Of_Accounts_Type_ID.EditValue)
                    Dim val As Integer
                    Dim ko = (From a In db.Chart_Of_Accounts_Type Where a.Chart_Of_Accounts_Type_ID = tyID Select a).FirstOrDefault
                    If ko IsNot Nothing Then
                        val = CInt(ko.Accounts_ID * 10000)
                    End If
                    If tyID > 0 Then


                        Dim st As String = Chart_Of_Accounts_Code.Text
                        Dim Tea = (From a In db.Chart_Of_Accounts Where a.Chart_Of_Accounts_Code = st Select a).FirstOrDefault
                        If Not IsNothing(Tea) Then
                            With Tea
                                UpdateId = .Chart_Of_Accounts_ID
                                '.Chart_Of_Accounts_ID = Chart_Of_Accounts_ID.Text
                                '.Chart_Of_Accounts_Code = Chart_Of_Accounts_Code.Text
                                .Chart_Of_Accounts_Description = Chart_Of_Accounts_Description.Text
                                .Chart_Of_Accounts_Type_ID = tyID
                                '.Chart_Of_Accounts_Beginning_Balances = Chart_Of_Accounts_Beginning_Balances.Text
                                .Chart_Of_Accounts_Status = Chart_Of_Accounts_Status.Checked
                                '.Chart_Of_Accounts_oName = Chart_Of_Accounts_oName.Text
                                '.Chart_Of_Accounts_oFather = Chart_Of_Accounts_oFather.Text
                                '.Chart_Of_Accounts_oMobile = Chart_Of_Accounts_oMobile.Text
                            End With
                            'My.Computer.Audio.Play("Sounds\Windows Print complete.wav")
                            XtraMessageBox.Show("Update Account Done")
                        Else
                            Dim TeaNew = New Chart_Of_Accounts
                            With TeaNew
                                '.Chart_Of_Accounts_ID = Chart_Of_Accounts_ID.Text
                                .Chart_Of_Accounts_Code = Auto_Acc_Nos(tyID)
                                .Chart_Of_Accounts_Description = Chart_Of_Accounts_Description.Text
                                .Chart_Of_Accounts_Type_ID = tyID
                                .Chart_Of_Accounts_Beginning_Balances = 0 ' Chart_Of_Accounts_Beginning_Balances.Text
                                .Chart_Of_Accounts_Status = Chart_Of_Accounts_Status.Checked
                                '.Chart_Of_Accounts_oName = Chart_Of_Accounts_oName.Text
                                '.Chart_Of_Accounts_oFather = Chart_Of_Accounts_oFather.Text
                                '.Chart_Of_Accounts_oMobile = Chart_Of_Accounts_oMobile.Text
                            End With
                            db.Chart_Of_Accounts.Add(TeaNew)
                            UpdateId = TeaNew.Chart_Of_Accounts_ID
                            Dim AddNum = (From a In db.Auto_Number Select a).FirstOrDefault
                            If AddNum IsNot Nothing Then
                                'Dim AddInt As String = Replace(AutoAdmissionNumber(), "A-", "")
                                AddNum.Auto_Acc_No = CType(CType(Replace(Replace(Auto_Acc_Nos(tyID), "ACC-", ""), Microsoft.VisualBasic.Right(Replace(Auto_Acc_Nos(tyID), "ACC-", ""), 3), ""), Integer?) - val, Integer?)
                            End If
                            'Dim AddNum = (From a In db.Auto_Number Select a).FirstOrDefault
                            'If AddNum IsNot Nothing Then
                            '    AddNum.Driver_Reg_No = Replace(Replace(Auto_Driver_Reg_No(), "D-Reg-", ""), Microsoft.VisualBasic.Right(Replace(Auto_Driver_Reg_No(), "D-Reg-", ""), 3), "")
                            'End If
                            'My.Computer.Audio.Play("Sounds\Windows Notify.wav")
                            XtraMessageBox.Show("Add new Account Done")
                            db.SaveChanges()
                            UpdateId = CInt((From a In db.Chart_Of_Accounts Select a.Chart_Of_Accounts_ID).Max)
                        End If
                        db.SaveChanges()
                        LoadAccounts(GridView4.GetFocusedRowCellValue("Chart_Of_Accounts_Type_ID"))
                        FlyoutPanel1.HidePopup()
                    Else
                        XtraMessageBox.Show("Please Select  Type of Account")
                    End If
                Else
                    MsgBox("Note. This is Master Account not Allowed for Updating", vbCritical)
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GridView4_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles GridView4.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = (e.RowHandle + 1).ToString()
        End If
    End Sub

    Private Sub GridView5_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles GridView5.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = (e.RowHandle + 1).ToString()
        End If
    End Sub

    Private Sub GridView6_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles GridView6.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = (e.RowHandle + 1).ToString()
        End If
    End Sub

    Private Sub AdvBandedGridView1_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles AdvBandedGridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = (e.RowHandle + 1).ToString()
        End If
    End Sub

    Private Sub AdvBandedGridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles AdvBandedGridView1.CellValueChanged
        'Using db As New DbBilalAccountingsEntities
        '    If e.Column.FieldName = "Sch_Accounts_Image" Then


        '        'Dim view As AdvBandedGridView = TryCast(sender, AdvBandedGridView)
        '        'Dim edit As PictureEdit = RepositoryItemPictureEdit1
        '        'Dim idx As Integer = AdvBandedGridView1.GetFocusedRowCellValue("Sch_Accounts_ID")
        '        'Dim img As PictureEdit = TryCast(view.ActiveEditor, PictureEdit) ' AdvBandedGridView1.GetFocusedRowCellValue("Sch_Accounts_Image")
        '        idx = AdvBandedGridView1.GetFocusedRowCellValue("Sch_Accounts_ID")
        '        'Pic.Image = DbToImg(AdvBandedGridView1.GetFocusedRowCellValue("Sch_Accounts_Image"))
        '        'Dim Filename2 As String = view.GetRowCellValue(e.RowHandle, e.Column).ToString
        '        'Dim filePath2 As String = DevExpress.Utils.FilesHelper.FindingFileName(parentpathimage & SUBFOLDERP, Filename2, False)
        '        Dim imgv As Image = DbToImg(e.Value)

        '        Dim dt = (From a In db.Sch_Accounts Where a.Sch_Accounts_ID = idx Select a).FirstOrDefault
        '        If dt IsNot Nothing Then
        '            'Dim mmmk As New Bitmap(e.Value.ToString)
        '            Dim imgh As New Bitmap(Application.StartupPath & "\Images\No Image.png")
        '            dt.Sch_Accounts_Image = ImgToByteArray(If(imgv IsNot Nothing, imgv, imgh), ImageFormat.Png)
        '            db.SaveChanges()
        '        End If
        '        'FlyoutPanel3.HidePopup()
        '    End If
        'End Using
    End Sub
    Dim idx As Integer
    Private Sub AdvBandedGridView1_DoubleClick(sender As Object, e As EventArgs) Handles AdvBandedGridView1.DoubleClick
        idx = AdvBandedGridView1.GetFocusedRowCellValue("Sch_Accounts_ID")

        Dim imgg As Image = Image.FromFile(Application.StartupPath & "\Images\No Image.png")
        Dim img As Byte() = ImgToByteArray(imgg, ImageFormat.Png)
        Pic.Image = If(DbToImg(AdvBandedGridView1.GetFocusedRowCellValue("Sch_Accounts_Image")) IsNot Nothing, DbToImg(AdvBandedGridView1.GetFocusedRowCellValue("Sch_Accounts_Image")), img)
        FlyoutPanel3.ShowPopup()
    End Sub

    Private Sub Pic_ImageChanged(sender As Object, e As EventArgs) Handles Pic.ImageChanged

    End Sub

    Private Sub FlyoutPanel3_ButtonClick(sender As Object, e As DevExpress.Utils.FlyoutPanelButtonClickEventArgs) Handles FlyoutPanel3.ButtonClick
        Select Case e.Button.Caption
            Case "Save"
                Using db As New DbBilalAccountingsEntities
                    Dim dt = (From a In db.Sch_Accounts Where a.Sch_Accounts_ID = idx Select a).FirstOrDefault
                    If dt IsNot Nothing Then
                        Dim imgv As Image = Pic.Image
                        Dim imgh As New Bitmap(Application.StartupPath & "\Images\No Image.png")
                        dt.Sch_Accounts_Image = ImgToByteArray(If(imgv IsNot Nothing, imgv, imgh), ImageFormat.Png)
                        db.SaveChanges()
                    End If
                    FlyoutPanel3.HidePopup()
                    LoadDataX(intMultiAccount)
                End Using
            Case "Close"
                FlyoutPanel3.HidePopup()
        End Select
    End Sub






    ''Private Sub BarButtonItem12_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem12.ItemClick
    ''    AccBtn(e.Item)

    ''    'For k As Integer = 0 To RpAcc.ItemLinks.Count - 1
    ''    '    If TypeOf RpAcc.ItemLinks.Item(k).Item Is BarButtonItem Then
    ''    '        TryCast(RpAcc.ItemLinks.Item(k).Item, BarButtonItem).Down = False
    ''    '    End If
    ''    'Next
    ''    'BarButtonItem12.Down = True
    ''End Sub

    'Private Sub BarButtonItem13_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem13.ItemClick
    '    For Each BarButtonItem As BarButtonItem In RpAcc.ItemLinks
    '        If TypeOf BarButtonItem Is BarButtonItem Then
    '            TryCast(BarButtonItem, BarButtonItem).Down = False
    '        End If
    '    Next BarButtonItem
    '    BarButtonItem13.Down = True
    'End Sub

    'Private Sub BarButtonItem14_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem14.ItemClick
    '    For Each BarButtonItem As BarButtonItem In RpAcc.ItemLinks
    '        If TypeOf BarButtonItem Is BarButtonItem Then
    '            TryCast(BarButtonItem, BarButtonItem).Down = False
    '        End If
    '    Next BarButtonItem
    '    BarButtonItem14.Down = True
    'End Sub

    'Private Sub BarButtonItem15_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem15.ItemClick
    '    For Each BarButtonItem As BarButtonItem In RpAcc.ItemLinks
    '        If TypeOf BarButtonItem Is BarButtonItem Then
    '            TryCast(BarButtonItem, BarButtonItem).Down = False
    '        End If
    '    Next BarButtonItem
    '    BarButtonItem15.Down = True
    'End Sub
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX


    Public Function DbToImg(Imag As Byte()) As Image
        Dim Img As Image
        Dim ImgByte As Byte() = Nothing
        Dim stream As MemoryStream
        ImgByte = CType(Imag.ToArray(), Byte())
        stream = New MemoryStream(ImgByte, 0, ImgByte.Length)
        Img = Image.FromStream(stream)
        Return Img
    End Function
    Public Function ImgToByteArray(img As Image, imgFormat As ImageFormat) As Byte()
        Dim tmpData As Byte()
        Using ms As New MemoryStream()
            img.Save(ms, imgFormat)

            tmpData = ms.ToArray
        End Using              ' dispose of memstream
        Return tmpData
    End Function
    'QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ

    Public Function Auto_Sch_Accounts_Invoice_Number() As String
        Using db = New DbBilalAccountingsEntities
            Dim GetNumber As String = ""
            Dim AutoNumber = (From a In db.Auto_Number Select a).FirstOrDefault
            If AutoNumber Is Nothing Then
                'Dim NewInvoice As New Auto_Number
                'NewInvoice.Stu_Receipt = "R-00001" & Now.ToString("yy")
                'db.Auto_Number.Add(NewInvoice)
                'db.SaveChanges()
                'GetNumber = NewInvoice.Stu_Receipt
            Else
                AutoNumber.Sch_Shop_Invoice_Number += 1
                Dim num As String = "JOU-" & AutoNumber.Sch_Shop_Invoice_Number.ToString().PadLeft(5, "0") & "-" & Now.ToString("yy")
                GetNumber = num
            End If
            Return GetNumber
        End Using
    End Function

    Public Function Auto_Acc_Nos(tID As Integer) As String
        Using db = New DbBilalAccountingsEntities
            Dim GetNumber As String = ""
            Dim GetNumberT As Integer
            Dim df = (From a In db.Chart_Of_Accounts_Type Where a.Chart_Of_Accounts_Type_ID = tID Select a).FirstOrDefault
            If df IsNot Nothing Then
                GetNumberT = df.Accounts_ID * 10000
            Else

            End If

            Dim AutoNumber = (From a In db.Auto_Number Select a).FirstOrDefault
            If AutoNumber Is Nothing Then
                'Dim NewInvoice As New Auto_Number
                'NewInvoice.Stu_Receipt = "R-00001" & Now.ToString("yy")
                'db.Auto_Number.Add(NewInvoice)
                'db.SaveChanges()
                'GetNumber = NewInvoice.Stu_Receipt
            Else
                AutoNumber.Auto_Acc_No += 1 + GetNumberT
                Dim num As String = "ACC-" & AutoNumber.Auto_Acc_No.ToString().PadLeft(5, "0") & "-" & Now.ToString("yy")
                GetNumber = num
            End If
            Return GetNumber '/ 10000
        End Using
    End Function

    Private Sub BarButtonItem17_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        Dim frm As New Form6
        frm.ShowDialog()
    End Sub

    Private Sub FlyoutPanel1_ButtonClick_1(sender As Object, e As DevExpress.Utils.FlyoutPanelButtonClickEventArgs) Handles FlyoutPanel1.ButtonClick

    End Sub
End Class

'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Public Class cmb_Chart_Of_Accounts_Type
    Public Sub ColumnsAndData(GridLookUpEdit As GridLookUpEdit)
        Using db As New DbBilalAccountingsEntities
            Dim dt = (From a In db.Chart_Of_Accounts_Type Select New With {.ID = a.Chart_Of_Accounts_Type_ID, .AccountHead = a.Account.Accounts_Name, .AccountTyyype = a.Chart_Of_Accounts_Type_Name}).ToList()
            If dt.Count() > 0 Then
                'GridLookUpEdit.Properties.PopulateViewColumns()
                GridLookUpEdit.Properties.DataSource = dt
                GridLookUpEdit.Properties.DisplayMember = "AccountTyyype"
                GridLookUpEdit.Properties.ValueMember = "ID"
            End If
        End Using
    End Sub
End Class

Public Class cmb_Sch_Credit_Accounts_ID
    Public Sub ColumnsAndData(GridLookUpEdit As SearchLookUpEdit)
        Using db As New DbBilalAccountingsEntities
            Dim dt = (From a In db.Chart_Of_Accounts Where a.Chart_Of_Accounts_Status = True Select New With {.ID = a.Chart_Of_Accounts_ID, .AccType = a.Chart_Of_Accounts_Type.Chart_Of_Accounts_Type_Name, .AccountNo = a.Chart_Of_Accounts_Code, .Name = a.Chart_Of_Accounts_oName, .Father = a.Chart_Of_Accounts_oFather, .Mobile = a.Chart_Of_Accounts_oMobile, .AccountName = a.Chart_Of_Accounts_Description}).ToList()
            If dt.Count() > 0 Then
                GridLookUpEdit.Properties.DataSource = dt
                GridLookUpEdit.Properties.DisplayMember = "AccountName"
                GridLookUpEdit.Properties.ValueMember = "ID"
                GridLookUpEdit.Properties.PopulateViewColumns()
                GridLookUpEdit.Properties.View.Columns("ID").Visible = False
            End If
        End Using
    End Sub
End Class

Public Class cmb_Chart_Of_Accounts
    Public Sub ColumnsAndData(GridLookUpEdit As SearchLookUpEdit)
        Using db As New DbBilalAccountingsEntities
            'GridLookUpEdit.Properties.View.Columns.Clear()
            Dim dt = (From a In db.Chart_Of_Accounts Where a.Chart_Of_Accounts_Status = True Select New With {.ID = a.Chart_Of_Accounts_ID, .AccType = a.Chart_Of_Accounts_Type.Chart_Of_Accounts_Type_Name, .AccountNo = a.Chart_Of_Accounts_Code, .Name = a.Chart_Of_Accounts_oName, .Father = a.Chart_Of_Accounts_oFather, .Mobile = a.Chart_Of_Accounts_oMobile, .AccountName = a.Chart_Of_Accounts_Description}).ToList()
            If dt.Count() > 0 Then
                GridLookUpEdit.Properties.DataSource = dt
                GridLookUpEdit.Properties.DisplayMember = "AccountName"
                GridLookUpEdit.Properties.ValueMember = "ID"
                'GridLookUpEdit.Properties.View.Columns("ID").Visible = False
                GridLookUpEdit.Properties.PopulateViewColumns()
                GridLookUpEdit.Properties.View.Columns("ID").Visible = False
            End If
        End Using
    End Sub
End Class


Public Class cmb_Sch_Accounts_Default_ID
    Public Sub ColumnsAndData(GridLookUpEdit As SearchLookUpEdit)
        Using db As New DbBilalAccountingsEntities
            GridLookUpEdit.Properties.View.Columns.Clear()
            Dim dt = (From a In db.Sch_Accounts_Default Select New With {.ID = a.Sch_Accounts_Default_ID, .DebitAccountName = a.Chart_Of_Accounts.Chart_Of_Accounts_Description, .CreditAccountName = a.Chart_Of_Accounts1.Chart_Of_Accounts_Description}).ToList()
            If dt.Count() > 0 Then
                GridLookUpEdit.Properties.DataSource = dt
                GridLookUpEdit.Properties.DisplayMember = "DebitAccountName"
                GridLookUpEdit.Properties.ValueMember = "ID"
                'GridLookUpEdit.Properties.View.Columns("ID").Visible = False
                GridLookUpEdit.Properties.PopulateViewColumns()
                GridLookUpEdit.Properties.View.Columns("ID").Visible = False
            End If
        End Using
    End Sub
End Class


Public Class cmb_Accounts
    Public Sub ColumnsAndData(GridLookUpEdit As RepositoryItemLookUpEdit)
        Using db As New DbBilalAccountingsEntities
            Dim dt = (From a In db.Accounts Select New With {.ID = a.Accounts_ID, .AccountHead = a.Accounts_Name}).ToList()
            If dt.Count() > 0 Then
                GridLookUpEdit.DataSource = dt
                GridLookUpEdit.DisplayMember = "AccountHead"
                GridLookUpEdit.ValueMember = "ID"
            End If
        End Using
    End Sub
End Class







