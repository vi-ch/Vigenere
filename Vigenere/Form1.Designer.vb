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
        Me.tbKey = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.tbSourceFile = New System.Windows.Forms.TextBox()
        Me.btnLoadSource = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbDestFile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLoadDest = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEsci = New System.Windows.Forms.ToolStripMenuItem()
        Me.AiutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbKey
        '
        Me.tbKey.Location = New System.Drawing.Point(730, 58)
        Me.tbKey.Name = "tbKey"
        Me.tbKey.Size = New System.Drawing.Size(200, 20)
        Me.tbKey.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(727, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Parola chiave:"
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnEncrypt.Location = New System.Drawing.Point(730, 98)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(197, 70)
        Me.btnEncrypt.TabIndex = 7
        Me.btnEncrypt.Text = "Cifrare"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDecrypt.Location = New System.Drawing.Point(730, 174)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(197, 76)
        Me.btnDecrypt.TabIndex = 8
        Me.btnDecrypt.Text = "Decifrare"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'tbSourceFile
        '
        Me.tbSourceFile.Location = New System.Drawing.Point(165, 58)
        Me.tbSourceFile.Name = "tbSourceFile"
        Me.tbSourceFile.Size = New System.Drawing.Size(429, 20)
        Me.tbSourceFile.TabIndex = 9
        '
        'btnLoadSource
        '
        Me.btnLoadSource.Location = New System.Drawing.Point(600, 56)
        Me.btnLoadSource.Name = "btnLoadSource"
        Me.btnLoadSource.Size = New System.Drawing.Size(124, 23)
        Me.btnLoadSource.TabIndex = 10
        Me.btnLoadSource.Text = "Seleziona file"
        Me.btnLoadSource.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "File sorgente:"
        '
        'tbDestFile
        '
        Me.tbDestFile.Location = New System.Drawing.Point(165, 95)
        Me.tbDestFile.Name = "tbDestFile"
        Me.tbDestFile.Size = New System.Drawing.Size(429, 20)
        Me.tbDestFile.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "File di destinazione:"
        '
        'btnLoadDest
        '
        Me.btnLoadDest.Location = New System.Drawing.Point(600, 93)
        Me.btnLoadDest.Name = "btnLoadDest"
        Me.btnLoadDest.Size = New System.Drawing.Size(124, 23)
        Me.btnLoadDest.TabIndex = 14
        Me.btnLoadDest.Text = "Seleziona file"
        Me.btnLoadDest.UseVisualStyleBackColor = True
        '
        'ofd
        '
        Me.ofd.Filter = "File di testo|*.txt|Tutti i file|*.*"
        '
        'sfd
        '
        Me.sfd.Filter = "File di testo|*.txt|Tutti i file|*.*"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AiutoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(942, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEsci})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuEsci
        '
        Me.mnuEsci.Name = "mnuEsci"
        Me.mnuEsci.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuEsci.Size = New System.Drawing.Size(142, 22)
        Me.mnuEsci.Text = "Esci"
        '
        'AiutoToolStripMenuItem
        '
        Me.AiutoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.AiutoToolStripMenuItem.Name = "AiutoToolStripMenuItem"
        Me.AiutoToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.AiutoToolStripMenuItem.Text = "&Aiuto"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnClose.Location = New System.Drawing.Point(63, 174)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(173, 76)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Chiudere il programma"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 296)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLoadDest)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbDestFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLoadSource)
        Me.Controls.Add(Me.tbSourceFile)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbKey)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Vigenere"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbKey As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents tbSourceFile As System.Windows.Forms.TextBox
    Friend WithEvents btnLoadSource As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbDestFile As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLoadDest As System.Windows.Forms.Button
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEsci As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AiutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
