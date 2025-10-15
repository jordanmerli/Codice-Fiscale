Friend Class Form1
    Dim strCognome, strConsonanti, strVocali, strNome, strConsonanti_Nome, strVocali_Nome, strAnno, strMese, Mese_Estratto, strGiorno, strCodice_Senza_Controllo, strCodice_Controllo As String
    Function Estrazione_Cognome(ByVal strCognome As String) As String
        strCognome = txtCognome.Text 'Memorizzo il cognome nella variabile strCognome
        strCognome = UCase(strCognome) 'trasformo tutti i caratteri in MAIUSCOLI
        strCognome = Replace(strCognome, " ", "") 'elimino eventuali spazi vuoti
        strConsonanti = ""
        strVocali = ""
        For i = 1 To Len(strCognome) 'inizio un ciclo che partedal primo carattere(i=1) e prosegue per tutta la lunghezza (LEN) della variabile strCognome
            If InStr("AEIOU", Mid(strCognome, i, 1)) Then 'Se il carattere è una vocale allora la prendo
                strVocali = strVocali + Mid(strCognome, i, 1) 'e la memorizzo (il ciclo si ripete)
            ElseIf InStr("BCDFGHJKLMNPQRSTVWXYZ", Mid(strCognome, i, 1)) Then 'se il carattere è una consonante allora
                strConsonanti = strConsonanti + Mid(strCognome, i, 1) 'la memorizzo (il ciclo si ripete)
            End If
            If (Len(strConsonanti) = 3) Then ' alla fine del ciclo, se la variabile sConsonanti ha almeno 3 caratteri allora
                Exit For 'esco dal ciclo
            End If
        Next i 'altrimenti proseguo il ciclo
        Select Case Len(strConsonanti)
            Case Is = 2
                strConsonanti = strConsonanti
                If (Len(strVocali) >= 1) Then
                    strConsonanti = strConsonanti + Mid(strVocali, 1, 1)
                End If
                If (Len(strVocali) = 0) Then
                    strConsonanti = strConsonanti + "X"
                End If
            Case Is = 1
                strConsonanti = strConsonanti
                If (Len(strVocali) >= 2) Then
                    strConsonanti = strConsonanti + Mid(strVocali, 1, 2)
                End If
                If (Len(strVocali) = 1) Then
                    strConsonanti = strConsonanti + Mid(strVocali, 1, 1) + "X"
                End If
                If (Len(strVocali) = 0) Then
                    strConsonanti = strConsonanti + "X" + "X"
                End If
            Case Is = 0
                strConsonanti = strConsonanti + Mid(strVocali, 1, 3)
                If (Len(strVocali) >= 3) Then
                    strConsonanti = Mid(strVocali, 1, 3)
                End If
                If (Len(strVocali) = 2) Then
                    strConsonanti = strVocali + "X"
                End If
                If (Len(strVocali) = 1) Then
                    strConsonanti = strVocali + "X" + "X"
                End If
                If (Len(strVocali) = 0) Then
                    strConsonanti = "X" + "X" + "X"
                End If
        End Select
        Return strCognome = strConsonanti
    End Function
    Function Estrazione_Nome(ByVal strNome As String) As String
        strNome = txtNome.Text 'Memorizzo il nome nella variabile strnome
        strNome = UCase(strNome) 'trasformo tutti i caratteri in MAIUSCOLI
        strNome = Replace(strNome, " ", "") 'elimino eventuali spazi vuoti
        strConsonanti_Nome = ""
        strVocali_Nome = ""
        For i = 1 To Len(strNome) 'inizio un ciclo che partedal primo carattere(i=1) e prosegue per tutta la lunghezza (LEN) della variabile strnome
            If InStr("AEIOU", Mid(strNome, i, 1)) Then 'Se il carattere è una vocale allora la prendo
                strVocali_Nome = strVocali_Nome + Mid(strNome, i, 1) 'e la memorizzo (il ciclo si ripete)
            ElseIf InStr("BCDFGHJKLMNPQRSTVWXYZ", Mid(strNome, i, 1)) Then 'se il carattere è una consonante allora
                strConsonanti_Nome = strConsonanti_Nome + Mid(strNome, i, 1) 'la memorizzo (il ciclo si ripete)
            End If
        Next i 'proseguo il ciclo

        If (Len(strConsonanti_Nome) >= 4) Then ' alla fine del ciclo, se la variabile sConsonanti ha almeno 3 caratteri allora
            strConsonanti_Nome = Mid(strConsonanti_Nome, 1, 1) & Mid(strConsonanti_Nome, 3, 1) & Mid(strConsonanti_Nome, 4, 1)
        End If
        Select Case Len(strConsonanti_Nome)
            Case Is = 3
                strConsonanti_Nome = Mid(strConsonanti_Nome, 1, 3)
            Case Is = 2
                strConsonanti_Nome = Mid(strConsonanti_Nome, 1, 2)
                If (Len(strVocali_Nome) >= 1) Then
                    strConsonanti_Nome = Mid(strConsonanti_Nome, 1, 2) + Mid(strVocali_Nome, 1, 1)
                End If
                If (Len(strVocali_Nome) = 0) Then
                    strConsonanti_Nome = Mid(strConsonanti_Nome, 1, 2) + "X"
                End If
            Case Is = 1
                strConsonanti_Nome = strConsonanti_Nome
                If (Len(strVocali_Nome) >= 2) Then
                    strConsonanti_Nome = strConsonanti_Nome + Mid(strVocali_Nome, 1, 2)
                End If
                If (Len(strVocali_Nome) = 1) Then
                    strConsonanti_Nome = strConsonanti_Nome + strVocali_Nome + "X"
                End If
                If (Len(strVocali_Nome) = 0) Then
                    strConsonanti_Nome = strConsonanti_Nome + "X" + "X"
                End If
            Case Is = 0
                If (Len(strVocali_Nome) >= 3) Then
                    strConsonanti_Nome = strConsonanti_Nome + Mid(strVocali_Nome, 1, 3)
                End If
                If (Len(strVocali_Nome) = 2) Then
                    strConsonanti_Nome = Mid(strVocali_Nome, 1, 2) + "X"
                End If
                If (Len(strVocali_Nome) = 1) Then
                    strConsonanti_Nome = strVocali_Nome + "X" + "X"
                End If
                If (Len(strVocali_Nome) = 0) Then
                    strConsonanti_Nome = "X" + "X" + "X"
                End If
        End Select
        Return strNome = strConsonanti_Nome
    End Function
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://nanoteck.altervista.org")
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("mailto:joe_nanoteck@hotmail.it")
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'EsteroDataSet.database'. È possibile spostarla o rimuoverla se necessario.
        Me.DatabaseTableAdapter.Fill(Me.EsteroDataSet.database)
        cmbGiorno.MaxLength = "2"
        txtAnno.MaxLength = "4"
        Timer1.Start()
        txtCognome.Select()
    End Sub
    Private Sub txtAnno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAnno.TextChanged
        If Not IsNumeric(txtAnno.Text) Then
            txtAnno.Text = ""
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If txtCognome.Text = "" Or txtNome.Text = "" Or txtAnno.Text = "" Or cmbGiorno.Text = "" Or cmbMese.Text = "" Or cmbSesso.Text = "" Or cmbStao_Provincia.Text = "" Then
        Else
            Call Estrazione_Cognome(strCognome)
            strCognome = strConsonanti
            Call Estrazione_Nome(strNome)
            strNome = strConsonanti_Nome
            strAnno = Mid(txtAnno.Text, 3, 4)
            strMese = cmbMese.Text
            Select Case strMese
                Case "Gennaio"
                    Mese_Estratto = "A"
                Case "Febbraio"
                    Mese_Estratto = "B"
                Case "Marzo"
                    Mese_Estratto = "C"
                Case "Aprile"
                    Mese_Estratto = "D"
                Case "Maggio"
                    Mese_Estratto = "E"
                Case "Giugno"
                    Mese_Estratto = "H"
                Case "Luglio"
                    Mese_Estratto = "L"
                Case "Agosto"
                    Mese_Estratto = "M"
                Case "Settembre"
                    Mese_Estratto = "P"
                Case "Ottobre"
                    Mese_Estratto = "R"
                Case "Novembre"
                    Mese_Estratto = "S"
                Case "Dicembre"
                    Mese_Estratto = "T"
                Case Else
            End Select
            strGiorno = cmbGiorno.Text
            Dim giorno_estratto As String = ""
            Select Case strGiorno
                Case Is = 1
                    If cmbSesso.Text = "Femmina" Then
                        giorno_estratto = (strGiorno + 40)
                    ElseIf cmbSesso.Text = "Maschio" Then
                        giorno_estratto = "0" & strGiorno
                    End If
                Case Is = 2
                    If cmbSesso.Text = "Femmina" Then
                        giorno_estratto = (strGiorno + 40)
                    ElseIf cmbSesso.Text = "Maschio" Then
                        giorno_estratto = "0" & strGiorno
                    End If
                Case Is = 3
                    If cmbSesso.Text = "Femmina" Then
                        giorno_estratto = (strGiorno + 40)
                    ElseIf cmbSesso.Text = "Maschio" Then
                        giorno_estratto = "0" & strGiorno
                    End If
                Case Is = 4
                    If cmbSesso.Text = "Femmina" Then
                        giorno_estratto = (strGiorno + 40)
                    ElseIf cmbSesso.Text = "Maschio" Then
                        giorno_estratto = "0" & strGiorno
                    End If
                Case Is = 5
                    If cmbSesso.Text = "Femmina" Then
                        giorno_estratto = (strGiorno + 40)
                    ElseIf cmbSesso.Text = "Maschio" Then
                        giorno_estratto = "0" & strGiorno
                    End If
                Case Is = 6
                    If cmbSesso.Text = "Femmina" Then
                        giorno_estratto = (strGiorno + 40)
                    ElseIf cmbSesso.Text = "Maschio" Then
                        giorno_estratto = "0" & strGiorno
                    End If
                Case Is = 7
                    If cmbSesso.Text = "Femmina" Then
                        giorno_estratto = (strGiorno + 40)
                    ElseIf cmbSesso.Text = "Maschio" Then
                        giorno_estratto = "0" & strGiorno
                    End If
                Case Is = 8
                    If cmbSesso.Text = "Femmina" Then
                        giorno_estratto = (strGiorno + 40)
                    ElseIf cmbSesso.Text = "Maschio" Then
                        giorno_estratto = "0" & strGiorno
                    End If
                Case Is = 9
                    If cmbSesso.Text = "Femmina" Then
                        giorno_estratto = (strGiorno + 40)
                    ElseIf cmbSesso.Text = "Maschio" Then
                        giorno_estratto = "0" & strGiorno
                    End If
                Case Is >= 10
                    If cmbSesso.Text = "Femmina" Then
                        giorno_estratto = (strGiorno + 40)
                    ElseIf cmbSesso.Text = "Maschio" Then
                        giorno_estratto = strGiorno
                    End If
            End Select
            strCodice_Senza_Controllo = strCognome + strNome + strAnno + Mese_Estratto + giorno_estratto + ComboBox2.Text
            'Controllo caratteri in posizione pari
            Dim strPari As String = ""
            For i = 2 To 14
                strPari = strPari & Mid(strCodice_Senza_Controllo, i, 1)
                i = i + 1
            Next
            Dim strControllo_Pari
            Dim strNumeri_Pari As String = 0
            For i = 1 To 8
                strControllo_Pari = Mid(strPari, i, 1)
                Select Case strControllo_Pari
                    Case "0"
                        strNumeri_Pari = strNumeri_Pari + 0
                    Case "1"
                        strNumeri_Pari = strNumeri_Pari + 1
                    Case "2"
                        strNumeri_Pari = strNumeri_Pari + 2
                    Case "3"
                        strNumeri_Pari = strNumeri_Pari + 3
                    Case "4"
                        strNumeri_Pari = strNumeri_Pari + 4
                    Case "5"
                        strNumeri_Pari = strNumeri_Pari + 5
                    Case "6"
                        strNumeri_Pari = strNumeri_Pari + 6
                    Case "7"
                        strNumeri_Pari = strNumeri_Pari + 7
                    Case "8"
                        strNumeri_Pari = strNumeri_Pari + 8
                    Case "9"
                        strNumeri_Pari = strNumeri_Pari + 9
                    Case "A"
                        strNumeri_Pari = strNumeri_Pari + 0
                    Case "B"
                        strNumeri_Pari = strNumeri_Pari + 1
                    Case "C"
                        strNumeri_Pari = strNumeri_Pari + 2
                    Case "D"
                        strNumeri_Pari = strNumeri_Pari + 3
                    Case "E"
                        strNumeri_Pari = strNumeri_Pari + 4
                    Case "F"
                        strNumeri_Pari = strNumeri_Pari + 5
                    Case "G"
                        strNumeri_Pari = strNumeri_Pari + 6
                    Case "H"
                        strNumeri_Pari = strNumeri_Pari + 7
                    Case "I"
                        strNumeri_Pari = strNumeri_Pari + 8
                    Case "J"
                        strNumeri_Pari = strNumeri_Pari + 9
                    Case "K"
                        strNumeri_Pari = strNumeri_Pari + 10
                    Case "L"
                        strNumeri_Pari = strNumeri_Pari + 11
                    Case "M"
                        strNumeri_Pari = strNumeri_Pari + 12
                    Case "N"
                        strNumeri_Pari = strNumeri_Pari + 13
                    Case "O"
                        strNumeri_Pari = strNumeri_Pari + 14
                    Case "P"
                        strNumeri_Pari = strNumeri_Pari + 15
                    Case "Q"
                        strNumeri_Pari = strNumeri_Pari + 16
                    Case "R"
                        strNumeri_Pari = strNumeri_Pari + 17
                    Case "S"
                        strNumeri_Pari = strNumeri_Pari + 18
                    Case "T"
                        strNumeri_Pari = strNumeri_Pari + 19
                    Case "U"
                        strNumeri_Pari = strNumeri_Pari + 20
                    Case "V"
                        strNumeri_Pari = strNumeri_Pari + 21
                    Case "W"
                        strNumeri_Pari = strNumeri_Pari + 22
                    Case "X"
                        strNumeri_Pari = strNumeri_Pari + 23
                    Case "Y"
                        strNumeri_Pari = strNumeri_Pari + 24
                    Case "Z"
                        strNumeri_Pari = strNumeri_Pari + 25
                End Select
            Next
            'Controllo caratteri in posizione dispari
            Dim strDispari As String = ""
            For i = 1 To 15
                strDispari = strDispari & Mid(strCodice_Senza_Controllo, i, 1)
                i = i + 1
            Next
            Dim strControllo_Dispari
            Dim strNumeri_Dispari As String = 0
            For i = 1 To 8
                strControllo_Dispari = Mid(strDispari, i, 1)
                Select Case strControllo_Dispari
                    Case "0"
                        strNumeri_Dispari = strNumeri_Dispari + 1
                    Case "1"
                        strNumeri_Dispari = strNumeri_Dispari + 0
                    Case "2"
                        strNumeri_Dispari = strNumeri_Dispari + 5
                    Case "3"
                        strNumeri_Dispari = strNumeri_Dispari + 7
                    Case "4"
                        strNumeri_Dispari = strNumeri_Dispari + 9
                    Case "5"
                        strNumeri_Dispari = strNumeri_Dispari + 13
                    Case "6"
                        strNumeri_Dispari = strNumeri_Dispari + 15
                    Case "7"
                        strNumeri_Dispari = strNumeri_Dispari + 17
                    Case "8"
                        strNumeri_Dispari = strNumeri_Dispari + 19
                    Case "9"
                        strNumeri_Dispari = strNumeri_Dispari + 21
                    Case "A"
                        strNumeri_Dispari = strNumeri_Dispari + 1
                    Case "B"
                        strNumeri_Dispari = strNumeri_Dispari + 0
                    Case "C"
                        strNumeri_Dispari = strNumeri_Dispari + 5
                    Case "D"
                        strNumeri_Dispari = strNumeri_Dispari + 7
                    Case "E"
                        strNumeri_Dispari = strNumeri_Dispari + 9
                    Case "F"
                        strNumeri_Dispari = strNumeri_Dispari + 13
                    Case "G"
                        strNumeri_Dispari = strNumeri_Dispari + 15
                    Case "H"
                        strNumeri_Dispari = strNumeri_Dispari + 17
                    Case "I"
                        strNumeri_Dispari = strNumeri_Dispari + 19
                    Case "J"
                        strNumeri_Dispari = strNumeri_Dispari + 21
                    Case "K"
                        strNumeri_Dispari = strNumeri_Dispari + 2
                    Case "L"
                        strNumeri_Dispari = strNumeri_Dispari + 4
                    Case "M"
                        strNumeri_Dispari = strNumeri_Dispari + 18
                    Case "N"
                        strNumeri_Dispari = strNumeri_Dispari + 20
                    Case "O"
                        strNumeri_Dispari = strNumeri_Dispari + 11
                    Case "P"
                        strNumeri_Dispari = strNumeri_Dispari + 3
                    Case "Q"
                        strNumeri_Dispari = strNumeri_Dispari + 6
                    Case "R"
                        strNumeri_Dispari = strNumeri_Dispari + 8
                    Case "S"
                        strNumeri_Dispari = strNumeri_Dispari + 12
                    Case "T"
                        strNumeri_Dispari = strNumeri_Dispari + 14
                    Case "U"
                        strNumeri_Dispari = strNumeri_Dispari + 16
                    Case "V"
                        strNumeri_Dispari = strNumeri_Dispari + 10
                    Case "W"
                        strNumeri_Dispari = strNumeri_Dispari + 22
                    Case "X"
                        strNumeri_Dispari = strNumeri_Dispari + 25
                    Case "Y"
                        strNumeri_Dispari = strNumeri_Dispari + 24
                    Case "Z"
                        strNumeri_Dispari = strNumeri_Dispari + 23
                End Select
            Next
            Dim Totale As String
            Totale = (CInt(strNumeri_Pari) + CInt(strNumeri_Dispari)) Mod 26 'CInt trasfroma la variabile in numero INTERO per la somma
            Dim Codice_Controllo As String = ""
            Select Case Totale
                Case "0"
                    Codice_Controllo = "A"
                Case "1"
                    Codice_Controllo = "B"
                Case "2"
                    Codice_Controllo = "C"
                Case "3"
                    Codice_Controllo = "D"
                Case "4"
                    Codice_Controllo = "E"
                Case "5"
                    Codice_Controllo = "F"
                Case "6"
                    Codice_Controllo = "G"
                Case "7"
                    Codice_Controllo = "H"
                Case "8"
                    Codice_Controllo = "I"
                Case "9"
                    Codice_Controllo = "J"
                Case "10"
                    Codice_Controllo = "K"
                Case "11"
                    Codice_Controllo = "L"
                Case "12"
                    Codice_Controllo = "M"
                Case "13"
                    Codice_Controllo = "N"
                Case "14"
                    Codice_Controllo = "O"
                Case "15"
                    Codice_Controllo = "P"
                Case "16"
                    Codice_Controllo = "Q"
                Case "17"
                    Codice_Controllo = "S"
                Case "18"
                    Codice_Controllo = "R"
                Case "19"
                    Codice_Controllo = "T"
                Case "20"
                    Codice_Controllo = "U"
                Case "21"
                    Codice_Controllo = "V"
                Case "22"
                    Codice_Controllo = "W"
                Case "23"
                    Codice_Controllo = "X"
                Case "24"
                    Codice_Controllo = "Y"
                Case "25"
                    Codice_Controllo = "Z"
            End Select
            lblCodice_Completo.Text = strCodice_Senza_Controllo + Codice_Controllo
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form2.Show()
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If lblCodice_Completo.Text = "" Then
        Else
            My.Computer.Clipboard.SetText(lblCodice_Completo.Text)
            MsgBox("Codice Fiscale copiato con successo!", MsgBoxStyle.Exclamation, "")
        End If
    End Sub
    Private Sub cmbSesso_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSesso.TextChanged
        Select Case cmbSesso.Text
            Case "Maschio"
                cmbSesso.Text = "Maschio"
            Case "m"
                cmbSesso.Text = "Maschio"
            Case "M"
                cmbSesso.Text = "Maschio"
            Case "maschio"
                cmbSesso.Text = "Maschio"
            Case "Uomo"
                cmbSesso.Text = "Maschio"
            Case "u"
                cmbSesso.Text = "Maschio"
            Case "U"
                cmbSesso.Text = "Maschio"
            Case "uomo"
                cmbSesso.Text = "Maschio"
            Case "Femmina"
                cmbSesso.Text = "Femmina"
            Case "f"
                cmbSesso.Text = "Femmina"
            Case "F"
                cmbSesso.Text = "Femmina"
            Case "femmina"
                cmbSesso.Text = "Femmina"
            Case "Donna"
                cmbSesso.Text = "Femmina"
            Case "d"
                cmbSesso.Text = "Femmina"
            Case "D"
                cmbSesso.Text = "Femmina"
            Case "donna"
                cmbSesso.Text = "Femmina"
            Case Else
                MsgBox("Selezionare Maschio o Femmina", MsgBoxStyle.Information)
        End Select
    End Sub
End Class
