<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EsteroDataSet = New Codice_Fiscale.EsteroDataSet()
        Me.DatabaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseTableAdapter = New Codice_Fiscale.EsteroDataSetTableAdapters.databaseTableAdapter()
        Me.StatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EsteroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.Location = New System.Drawing.Point(1, 1)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(109, 164)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "A" & Global.Microsoft.VisualBasic.ChrW(9) & "Gennaio" & Global.Microsoft.VisualBasic.ChrW(10) & "B" & Global.Microsoft.VisualBasic.ChrW(9) & "Febbraio" & Global.Microsoft.VisualBasic.ChrW(10) & "C" & Global.Microsoft.VisualBasic.ChrW(9) & "Marzo" & Global.Microsoft.VisualBasic.ChrW(10) & "D" & Global.Microsoft.VisualBasic.ChrW(9) & "Aprile" & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(9) & "Maggio" & Global.Microsoft.VisualBasic.ChrW(10) & "H" & Global.Microsoft.VisualBasic.ChrW(9) & "Giugno" & Global.Microsoft.VisualBasic.ChrW(10) & "L" & Global.Microsoft.VisualBasic.ChrW(9) & "Luglio" & Global.Microsoft.VisualBasic.ChrW(10) & "M" & Global.Microsoft.VisualBasic.ChrW(9) & "Agosto" & Global.Microsoft.VisualBasic.ChrW(10) & "P" & Global.Microsoft.VisualBasic.ChrW(9) & "Sette" & _
            "mbre" & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(9) & "Ottobre" & Global.Microsoft.VisualBasic.ChrW(10) & "S" & Global.Microsoft.VisualBasic.ChrW(9) & "Novembre" & Global.Microsoft.VisualBasic.ChrW(10) & "T" & Global.Microsoft.VisualBasic.ChrW(9) & "Dicembre"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StatoDataGridViewTextBoxColumn, Me.CodiceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DatabaseBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(116, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.Size = New System.Drawing.Size(319, 164)
        Me.DataGridView1.TabIndex = 2
        '
        'EsteroDataSet
        '
        Me.EsteroDataSet.DataSetName = "EsteroDataSet"
        Me.EsteroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabaseBindingSource
        '
        Me.DatabaseBindingSource.DataMember = "database"
        Me.DatabaseBindingSource.DataSource = Me.EsteroDataSet
        '
        'DatabaseTableAdapter
        '
        Me.DatabaseTableAdapter.ClearBeforeFill = True
        '
        'StatoDataGridViewTextBoxColumn
        '
        Me.StatoDataGridViewTextBoxColumn.DataPropertyName = "Stato"
        Me.StatoDataGridViewTextBoxColumn.HeaderText = "Stato"
        Me.StatoDataGridViewTextBoxColumn.Name = "StatoDataGridViewTextBoxColumn"
        Me.StatoDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatoDataGridViewTextBoxColumn.Width = 199
        '
        'CodiceDataGridViewTextBoxColumn
        '
        Me.CodiceDataGridViewTextBoxColumn.DataPropertyName = "Codice"
        Me.CodiceDataGridViewTextBoxColumn.HeaderText = "Codice"
        Me.CodiceDataGridViewTextBoxColumn.Name = "CodiceDataGridViewTextBoxColumn"
        Me.CodiceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 167)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Database"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EsteroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EsteroDataSet As Codice_Fiscale.EsteroDataSet
    Friend WithEvents DatabaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseTableAdapter As Codice_Fiscale.EsteroDataSetTableAdapters.databaseTableAdapter
    Friend WithEvents StatoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodiceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
