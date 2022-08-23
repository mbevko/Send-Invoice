Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.OEINVHOTableAdapter.Fill(Me.MFGCOMDataSet.OEINVHO)

        Me.OEINVHODataGridView.Sort(OEINVHODataGridView.Columns(2), System.ComponentModel.ListSortDirection.Descending)

    End Sub


    Private Sub OEINVHODataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles OEINVHODataGridView.CellMouseDoubleClick

        Dim result As String

        Dim yesNo As String

        yesNo = "1"

        If SEND_INVOICELabel1.Text = "1" Then
            yesNo = "0"
        ElseIf SEND_INVOICELabel1.Text = "0" Then
            yesNo = "1"
        End If

        result = Me.OEINVHOTableAdapter.UpdateInvoice(yesNo, INVUNIQLabel1.Text)

        Me.OEINVHOTableAdapter.Fill(Me.MFGCOMDataSet.OEINVHO)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.OEINVHOTableAdapter.FillBy(Me.MFGCOMDataSet.OEINVHO)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class