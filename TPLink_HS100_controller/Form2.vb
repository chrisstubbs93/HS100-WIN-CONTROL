Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSelectedDeviceName.Text = Form1.listviewDevices.Items(Form1.listviewDevices.FocusedItem.Index).SubItems(0).Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class