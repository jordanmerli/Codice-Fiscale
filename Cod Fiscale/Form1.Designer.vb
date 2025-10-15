<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbGiorno = New System.Windows.Forms.ComboBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblCodice_Completo = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.EsteroDataSet = New Codice_Fiscale.EsteroDataSet()
        Me.cmbStao_Provincia = New System.Windows.Forms.ComboBox()
        Me.DatabaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbSesso = New System.Windows.Forms.ComboBox()
        Me.txtAnno = New System.Windows.Forms.TextBox()
        Me.cmbMese = New System.Windows.Forms.ComboBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCognome = New System.Windows.Forms.TextBox()
        Me.DatabaseTableAdapter = New Codice_Fiscale.EsteroDataSetTableAdapters.databaseTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EsteroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(454, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "COPIA!"
        Me.ToolTip1.SetToolTip(Me.Label1, "Attenziona! I dati negli appunti verranno sovrascritti! / Clipboard datas will be" & _
        " overwrite")
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Codice_Fiscale.My.Resources.Resources.copy
        Me.PictureBox2.Location = New System.Drawing.Point(446, 180)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 115
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Copia negli appunti / Copy to clipboard")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Codice_Fiscale.My.Resources.Resources.domanda
        Me.PictureBox1.Location = New System.Drawing.Point(446, 243)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 114
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Come funziona / How to")
        '
        'cmbGiorno
        '
        Me.cmbGiorno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbGiorno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGiorno.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGiorno.FormattingEnabled = True
        Me.cmbGiorno.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbGiorno.Location = New System.Drawing.Point(221, 273)
        Me.cmbGiorno.MaxLength = 2
        Me.cmbGiorno.Name = "cmbGiorno"
        Me.cmbGiorno.Size = New System.Drawing.Size(46, 22)
        Me.cmbGiorno.TabIndex = 107
        Me.ToolTip1.SetToolTip(Me.cmbGiorno, "Giorno / Day")
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(298, 297)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(156, 18)
        Me.LinkLabel2.TabIndex = 112
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "joe_nanoteck@hotmail.it"
        Me.ToolTip1.SetToolTip(Me.LinkLabel2, "joe_nanoteck@hotmail.it")
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(17, 297)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(182, 18)
        Me.LinkLabel1.TabIndex = 110
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "nanoteck.altervista.org"
        Me.ToolTip1.SetToolTip(Me.LinkLabel1, "http://jordanmerli.sitiwebs.com")
        '
        'lblCodice_Completo
        '
        Me.lblCodice_Completo.BackColor = System.Drawing.Color.Transparent
        Me.lblCodice_Completo.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodice_Completo.ForeColor = System.Drawing.Color.Red
        Me.lblCodice_Completo.Location = New System.Drawing.Point(201, 110)
        Me.lblCodice_Completo.Name = "lblCodice_Completo"
        Me.lblCodice_Completo.Size = New System.Drawing.Size(233, 27)
        Me.lblCodice_Completo.TabIndex = 111
        Me.lblCodice_Completo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblCodice_Completo, "Codice Fiscale / Tax Code")
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EsteroDataSet, "database.Codice", True))
        Me.ComboBox2.DataSource = Me.EsteroDataSet
        Me.ComboBox2.DisplayMember = "database.Codice"
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(221, 238)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(73, 22)
        Me.ComboBox2.TabIndex = 113
        Me.ComboBox2.ValueMember = "database.Codice"
        '
        'EsteroDataSet
        '
        Me.EsteroDataSet.DataSetName = "EsteroDataSet"
        Me.EsteroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbStao_Provincia
        '
        Me.cmbStao_Provincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbStao_Provincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStao_Provincia.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DatabaseBindingSource, "Stato", True))
        Me.cmbStao_Provincia.DataSource = Me.EsteroDataSet
        Me.cmbStao_Provincia.DisplayMember = "database.Stato"
        Me.cmbStao_Provincia.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStao_Provincia.FormattingEnabled = True
        Me.cmbStao_Provincia.ItemHeight = 14
        Me.cmbStao_Provincia.Location = New System.Drawing.Point(221, 205)
        Me.cmbStao_Provincia.Name = "cmbStao_Provincia"
        Me.cmbStao_Provincia.Size = New System.Drawing.Size(177, 22)
        Me.cmbStao_Provincia.TabIndex = 106
        Me.ToolTip1.SetToolTip(Me.cmbStao_Provincia, "Luogo di nascita / Place of birth")
        Me.cmbStao_Provincia.ValueMember = "database.Stato"
        '
        'DatabaseBindingSource
        '
        Me.DatabaseBindingSource.DataMember = "database"
        Me.DatabaseBindingSource.DataSource = Me.EsteroDataSet
        '
        'cmbSesso
        '
        Me.cmbSesso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSesso.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSesso.FormattingEnabled = True
        Me.cmbSesso.Items.AddRange(New Object() {"Maschio", "Femmina"})
        Me.cmbSesso.Location = New System.Drawing.Point(430, 131)
        Me.cmbSesso.Name = "cmbSesso"
        Me.cmbSesso.Size = New System.Drawing.Size(72, 22)
        Me.cmbSesso.TabIndex = 105
        Me.ToolTip1.SetToolTip(Me.cmbSesso, "Sesso / Gender")
        '
        'txtAnno
        '
        Me.txtAnno.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnno.Location = New System.Drawing.Point(364, 273)
        Me.txtAnno.MaxLength = 4
        Me.txtAnno.Name = "txtAnno"
        Me.txtAnno.Size = New System.Drawing.Size(60, 22)
        Me.txtAnno.TabIndex = 109
        Me.ToolTip1.SetToolTip(Me.txtAnno, "Anno / Year")
        '
        'cmbMese
        '
        Me.cmbMese.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMese.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMese.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMese.FormattingEnabled = True
        Me.cmbMese.Items.AddRange(New Object() {"Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"})
        Me.cmbMese.Location = New System.Drawing.Point(273, 273)
        Me.cmbMese.Name = "cmbMese"
        Me.cmbMese.Size = New System.Drawing.Size(85, 22)
        Me.cmbMese.TabIndex = 108
        Me.ToolTip1.SetToolTip(Me.cmbMese, "Mese / Month")
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(221, 175)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(203, 22)
        Me.txtNome.TabIndex = 104
        Me.ToolTip1.SetToolTip(Me.txtNome, "Nome / First Name")
        '
        'txtCognome
        '
        Me.txtCognome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCognome.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCognome.Location = New System.Drawing.Point(221, 147)
        Me.txtCognome.Name = "txtCognome"
        Me.txtCognome.Size = New System.Drawing.Size(203, 22)
        Me.txtCognome.TabIndex = 103
        Me.ToolTip1.SetToolTip(Me.txtCognome, "Cognome / Last Name")
        '
        'DatabaseTableAdapter
        '
        Me.DatabaseTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Codice_Fiscale.My.Resources.Resources.tesserasanitaria
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(526, 324)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmbGiorno)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.cmbStao_Provincia)
        Me.Controls.Add(Me.cmbSesso)
        Me.Controls.Add(Me.txtAnno)
        Me.Controls.Add(Me.cmbMese)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCognome)
        Me.Controls.Add(Me.lblCodice_Completo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Codice Fiscale - Jordan Merli"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EsteroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbGiorno As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblCodice_Completo As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStao_Provincia As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSesso As System.Windows.Forms.ComboBox
    Friend WithEvents txtAnno As System.Windows.Forms.TextBox
    Friend WithEvents cmbMese As System.Windows.Forms.ComboBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtCognome As System.Windows.Forms.TextBox
    Friend WithEvents EsteroDataSet As Codice_Fiscale.EsteroDataSet
    Friend WithEvents DatabaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseTableAdapter As Codice_Fiscale.EsteroDataSetTableAdapters.databaseTableAdapter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
