

Partial Public Class MFGCOMDataSet
    Partial Public Class OEINVHODataTable
        Private Sub OEINVHODataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.INVUNIQColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class OEINVHO1DataTable
        Private Sub OEINVHO1DataTable_OEINVHO1RowChanging(sender As Object, e As OEINVHO1RowChangeEvent) Handles Me.OEINVHO1RowChanging

        End Sub

    End Class
End Class

Namespace MFGCOMDataSetTableAdapters
    Partial Public Class OEINVHOTableAdapter
    End Class
End Namespace
