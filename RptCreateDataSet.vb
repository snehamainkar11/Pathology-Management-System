Partial Class RptCreateDataSet
    Partial Class ReportResultDataTable

        Private Sub ReportResultDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.TestNameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class RCreateDataTable

        Private Sub RCreateDataTable_RCreateRowChanging(ByVal sender As System.Object, ByVal e As RCreateRowChangeEvent) Handles Me.RCreateRowChanging

        End Sub

    End Class

End Class

Namespace RptCreateDataSetTableAdapters
    
    Partial Class ReportResultTableAdapter

    End Class

    Partial Public Class RCreateTableAdapter
    End Class
End Namespace
