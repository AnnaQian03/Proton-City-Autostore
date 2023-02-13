Public Class frmconfig
    Private Sub pbClient_MouseMove(sender As Object, e As MouseEventArgs) Handles pbClient.MouseMove
        pbClient.Image = Proton_Auto_Store.My.Resources.clients2
    End Sub

    Private Sub pbInvoice_MouseHover(sender As Object, e As EventArgs) Handles pbInvoice.MouseHover
        pbInvoice.Image = Proton_Auto_Store.My.Resources.invoice2
    End Sub

    Private Sub pbInvoice_Click(sender As Object, e As EventArgs) Handles pbInvoice.Click
        MsgBox("Koniichiwa")
    End Sub
End Class