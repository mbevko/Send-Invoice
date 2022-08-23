Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.OEINVHOTableAdapter.Fill(Me.MFGCOMDataSet.OEINVHO)

        Me.OEINVHODataGridView.Sort(OEINVHODataGridView.Columns(2), System.ComponentModel.ListSortDirection.Descending)

        For i As Integer = 0 To Me.OEINVHODataGridView.Rows.Count - 1
            If Me.OEINVHODataGridView.Rows(i).Cells(4).Value = "YES" Then
                Me.OEINVHODataGridView.Rows(i).DefaultCellStyle.BackColor = Color.WhiteSmoke
            ElseIf Me.OEINVHODataGridView.Rows(i).Cells(4).Value = "NO" Then
                Me.OEINVHODataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Gainsboro
            End If
        Next

    End Sub


    Private Sub OEINVHODataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles OEINVHODataGridView.CellMouseDoubleClick

        If e.ColumnIndex = 4 And e.RowIndex > -1 Then
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

            For i As Integer = 0 To Me.OEINVHODataGridView.Rows.Count - 1
                If Me.OEINVHODataGridView.Rows(i).Cells(4).Value = "YES" Then
                    Me.OEINVHODataGridView.Rows(i).DefaultCellStyle.BackColor = Color.WhiteSmoke
                ElseIf Me.OEINVHODataGridView.Rows(i).Cells(4).Value = "NO" Then
                    Me.OEINVHODataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Gainsboro
                End If
            Next
        End If



    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.OEINVHOTableAdapter.FillBy(Me.MFGCOMDataSet.OEINVHO)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub OEINVHODataGridView_Sorted(sender As Object, e As EventArgs) Handles OEINVHODataGridView.Sorted
        For i As Integer = 0 To Me.OEINVHODataGridView.Rows.Count - 1
            If Me.OEINVHODataGridView.Rows(i).Cells(4).Value = "YES" Then
                Me.OEINVHODataGridView.Rows(i).DefaultCellStyle.BackColor = Color.WhiteSmoke
            ElseIf Me.OEINVHODataGridView.Rows(i).Cells(4).Value = "NO" Then
                Me.OEINVHODataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Gainsboro
            End If
        Next
    End Sub
End Class