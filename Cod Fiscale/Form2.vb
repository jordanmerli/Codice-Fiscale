Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'EsteroDataSet.database'. È possibile spostarla o rimuoverla se necessario.
        Me.DatabaseTableAdapter.Fill(Me.EsteroDataSet.database)
        'TODO: questa riga di codice carica i dati nella tabella 'EsteroDataSet.database'. È possibile spostarla o rimuoverla se necessario.
        Me.DatabaseTableAdapter.Fill(Me.EsteroDataSet.database)

    End Sub
End Class