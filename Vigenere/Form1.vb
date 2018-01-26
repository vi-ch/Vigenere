Imports System.IO

Public Class Form1

    Dim a(25, 25) As Char

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'creazione della matrice quadrata di alfabeti(a)
        Dim parolachiave As String = tbKey.Text
        Dim aa() As Char = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim i, j As Integer
        Dim t As Char
        For i = 0 To 25
            a(0, i) = aa(i)
        Next
        For i = 1 To 25
            t = aa(0)
            For j = 0 To 24
                aa(j) = aa(j + 1)
            Next
            aa(25) = t
            For j = 0 To 25
                a(i, j) = aa(j)
            Next
        Next
        ofd.InitialDirectory = Application.StartupPath
        sfd.InitialDirectory = Application.StartupPath
    End Sub

    'Funzione di cifratura. Restituische il testo cifrato secondo la parola chiave. 
    'Ai caratteri del passo a capo riga non viene assegnato, come possiamo dedurre dall'esempio, 
    'nessun corrispondente carattere della parola chiave.
    'Vengono dunque semplicemente tralasciati.
    Private Function encrypt(ByVal testo As String, ByVal parolaChiave As String) As String
        Dim k, x, y As Integer
        Dim s As String = ""
        testo = testo.ToUpper()
        parolaChiave = parolaChiave.ToUpper()
        Dim testolength As Integer = testo.Length
        Dim parolaChiavelength As Integer = parolaChiave.Length
        k = 0
        Do While k < testolength
            If (testo(k) = vbCr) Then
                s = s + vbCrLf
                testo = testo.Remove(k, 2)
                testolength = testo.Length
            Else
                x = findi(testo(k))
                If (x <> -1) Then
                    If ((k + 1) > parolaChiavelength) Then
                        If (parolaChiavelength > 0) Then
                            y = findj(parolaChiave(k Mod parolaChiavelength))
                        Else
                            y = -1
                        End If
                    Else
                        y = findj(parolaChiave(k))
                    End If
                    If (y <> -1) Then
                        s = s + a(x, y)
                    Else
                        s = s + testo(k)
                    End If
                Else
                    s = s + testo(k)
                End If
                k += 1
            End If
        Loop
        Return s
    End Function

    'Funzione di decifratura
    Private Function decrypt(ByVal testo As String, ByVal parolaChiave As String) As String
        Dim s As String = ""
        testo = testo.ToUpper()
        parolaChiave = parolaChiave.ToUpper()
        Dim testolength As Integer = testo.Length
        Dim parolaChiavelength As Integer = parolaChiave.Length
        Dim i, x, y As Integer
        i = 0
        Do While i < testolength
            If (testo(i) = vbCr) Then
                s = s + vbCrLf
                testo = testo.Remove(i, 2)
                testolength = testo.Length
            Else
                If ((i + 1) > parolaChiavelength) Then
                    If (parolaChiavelength > 0) Then
                        x = findj(parolaChiave(i Mod parolaChiavelength))
                    Else
                        x = -1
                    End If
                Else
                    x = findj(parolaChiave(i))
                End If
                If (x <> -1) Then
                    y = findij(x, testo(i))
                    If (y <> -1) Then
                        s = s + a(y, 0)
                    Else
                        s = s + testo(i)
                    End If
                Else
                    s = s + testo(i)
                End If
                i += 1
            End If
        Loop
        Return s
    End Function

    'Funzione della ricerca di un carattere nella prima colonna della matrice. Se il carattere non è presente, 
    'la funzione restituisce -1, altrimenti restituisce la posizione del carattere.
    Private Function findi(ByVal x As Char) As Integer
        Dim i As Integer = 0
        Do While ((i < 26) AndAlso (a(i, 0) <> x))
            i += 1
        Loop
        If (i > 25) Then
            Return -1
        Else
            Return i
        End If
    End Function

    'Funzione della ricerca di un carattere nella prima riga della matrice. Se il carattere non è presente, 
    'la funzione restituisce -1, altrimenti restituisce la posizione del carattere.
    Private Function findj(ByVal x As Char) As Integer
        Dim j As Integer = 0
        Do While ((j < 26) AndAlso (a(0, j) <> x))
            j += 1
        Loop
        If (j > 25) Then
            Return -1
        Else
            Return j
        End If
    End Function

    'Funzione della ricerca del carattere nella colonna della matrice, specificata in x.
    '(funzione necessaria per la decifratura)
    Private Function findij(ByVal x As Integer, ByVal p2 As Char) As Integer
        Dim j As Integer = 0
        Do While ((j < 26) AndAlso (a(j, x) <> p2))
            j += 1
        Loop
        If (j > 25) Then
            Return -1
        Else
            Return j
        End If
    End Function

    Private Sub btnLoadSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadSource.Click
        Dim dgRes As DialogResult = ofd.ShowDialog()
        If (dgRes <> DialogResult.Cancel) Then
            tbSourceFile.Text = ofd.FileName()
        End If

    End Sub

    Private Sub btnLoadDest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadDest.Click
        Dim dgRes As DialogResult = sfd.ShowDialog()
        If (dgRes <> DialogResult.Cancel) Then
            tbDestFile.Text = sfd.FileName()
        End If
    End Sub

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        If (File.Exists(tbSourceFile.Text)) Then
            If (MessageBox.Show("Vuole scrivere il testo crittato in " & tbDestFile.Text & "?", "Confermare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                Try
                    Dim sr As New StreamReader(tbSourceFile.Text)
                    Dim s As String = sr.ReadToEnd()
                    sr.Close()
                    s = encrypt(s, tbKey.Text)
                    Dim l As ULong
                    Dim sw As New StreamWriter(tbDestFile.Text)
                    For l = 0 To s.Length - 1
                        sw.Write(s(l))
                    Next
                    sw.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    MessageBox.Show("La cifratura è stata terminata!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        Else
            MessageBox.Show("File sorgente non esiste!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        If (File.Exists(tbSourceFile.Text)) Then
            If (MessageBox.Show("Vuole scrivere il testo decrittato in " & tbDestFile.Text & "?", "Confermare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                Try
                    Dim sr As New StreamReader(tbSourceFile.Text)
                    Dim s As String = sr.ReadToEnd()
                    sr.Close()
                    s = decrypt(s, tbKey.Text)
                    Dim l As ULong
                    Dim sw As New StreamWriter(tbDestFile.Text)
                    For l = 0 To s.Length - 1
                        sw.Write(s(l))
                    Next
                    sw.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    MessageBox.Show("La decifratura è stata terminata!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        Else
            MessageBox.Show("File sorgente non esiste!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub mnuEsci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEsci.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        abtVigenere.Show()
    End Sub
End Class
