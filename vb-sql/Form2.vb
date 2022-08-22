Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MFGCOMDataSet2.OEINVHO' table. You can move, or remove it, as needed.
        Me.OEINVHOTableAdapter.Fill(Me.MFGCOMDataSet2.OEINVHO)
        'TODO: This line of code loads data into the 'MFGCOMDataSet.OEINVHO' table. You can move, or remove it, as needed.
        Me.OEINVHOTableAdapter.Fill(Me.MFGCOMDataSet.OEINVHO)
        'TODO: This line of code loads data into the 'MFGCOMDataSet1.OEINVHO' table. You can move, or remove it, as needed.
        Me.OEINVHOTableAdapter.Fill(Me.MFGCOMDataSet1.OEINVHO)
        'TODO: This line of code loads data into the 'MFGCOMDataSet.OEINVHO' table. You can move, or remove it, as needed.
        Me.OEINVHOTableAdapter.Fill(Me.MFGCOMDataSet.OEINVHO)
        'TODO: This line of code loads data into the 'MFGCOMDataSet1.OEINVHO' table. You can move, or remove it, as needed.
        Me.OEINVHOTableAdapter.Fill(Me.MFGCOMDataSet1.OEINVHO)
        Me.OEINVHOTableAdapter.Fill(Me.MFGCOMDataSet.OEINVHO)


    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim new_sendInvoice As Integer
    '    new_sendInvoice = InputBox("Please enter new value:", "Edit your record", Me.SEND_INVOICELabel1.Text)



    '    Dim result As Integer

    '    result = Me.OEINVHOTableAdapter.UpdateInvoice(new_sendInvoice, INVUNIQLabel1.Text)

    '    If result > 0 Then
    '        MessageBox.Show(result.ToString)
    '        Me.OEINVHOTableAdapter.Fill(Me.MFGCOMDataSet.OEINVHO)
    '    Else
    '        MessageBox.Show("Please enter 1 or 0")
    '    End If

    'End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim new_sendInvoice As Integer
        new_sendInvoice = InputBox("Please enter   1 or 0", "Edit your record", Me.SEND_INVOICELabel1.Text)



        Dim result As Integer

        result = Me.OEINVHOTableAdapter.UpdateInvoice(new_sendInvoice, INVUNIQLabel1.Text)
        Me.OEINVHOTableAdapter.Fill(Me.MFGCOMDataSet.OEINVHO)

        'If result = 0 Then
        '    MessageBox.Show(result.ToString)
        '    Me.OEINVHOTableAdapter.Fill(Me.MFGCOMDataSet.OEINVHO)
        'Else
        '    MessageBox.Show("Please enter 1 or 0")
        'End If


    End Sub

    Private Sub OEINVHODataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles OEINVHODataGridView.CellMouseDoubleClick
        Dim new_sendInvoice As String
        new_sendInvoice = InputBox("Please enter 1 or 0", "Edit your record", Me.SEND_INVOICELabel1.Text)

        Dim result As Integer

        result = Me.OEINVHOTableAdapter.UpdateInvoice(new_sendInvoice, INVUNIQLabel1.Text)
        Me.OEINVHOTableAdapter.Fill(Me.MFGCOMDataSet.OEINVHO)
        Me.OEINVHOTableAdapter.Fill(Me.MFGCOMDataSet1.OEINVHO)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.OEINVHOTableAdapter.FillBy(Me.MFGCOMDataSet.OEINVHO)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class