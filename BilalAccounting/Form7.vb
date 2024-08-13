Public Class Form7
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        For i As Integer = 1 To 10
            TreeList1.Nodes.Add()
        Next
    End Sub
End Class