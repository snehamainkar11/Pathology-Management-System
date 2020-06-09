Partial Class BillDataSet
    Partial Class BillCostDataTable

        Private Sub BillCostDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.BNoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace BillDataSetTableAdapters
    
    Partial Public Class BillCostTableAdapter
    End Class
End Namespace
