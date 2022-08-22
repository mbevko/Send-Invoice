Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MFGCOMDataSet.OEINVHO' table. You can move, or remove it, as needed.
        Try
            Me.OEINVHOTableAdapter.Fill(Me.MFGCOMDataSet.OEINVHO)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        InputBox("1 for yes and 0 for no")
    End Sub


End Class
