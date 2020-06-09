Partial Class patholabDBDataSet3
    Partial Class ChemMasterDataTable

        Private Sub ChemMasterDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ObsByColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
