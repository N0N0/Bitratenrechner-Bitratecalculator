Public Class Form1
    ' hat (noch) keine Funktion
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    'Der Berechnen Button (Button wurde entfernt da die Funktion automatisiert wurde)
    Private Sub Command1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Dim Dauer As Long 'wenn als String deklariert, werden Ergebnis und Ergebnis2 falsch berechnet (wenn TextX = 00 ist, wird & statt + angewendet)
        Dim Ergebnis, Ergebnis2 As String
        Dim BitsA As String = Quelle_AudRate.Text / 8
        Dim BitsA2 As String = Ziel_AudRate.Text / 8
        Dim BitsV As String = Quelle_VidRate.Text / 8
        Dim BitsV2 As String = Ziel_VidRate.Text / 8

        Dauer = Text_Stunden.Text * 60
        Dauer += Text_Minuten.Text
        Dauer *= 60
        Dauer += Text_Sekunden.Text
        Ergebnis = (Dauer * BitsA) + (Dauer * BitsV)
        Ergebnis /= 1024

        If Check1.Checked = False Then
            Text5.Text = Ergebnis
            Exit Sub
        Else
            Ergebnis2 = (Dauer * BitsA2) + (Dauer * BitsV2)
            Ergebnis2 /= 1024
            Ergebnis -= Ergebnis2
            Text5.Text = Ergebnis * -1
        End If

    End Sub

    'beschränkt den Max.Wert von Text_Stunden auf 99
    Private Sub Text_Stunden_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_Stunden.TextChanged
        On Error GoTo Fehler

        If Text_Stunden.Text = "" Then
            Text_Stunden.Text = 0
            Exit Sub
        ElseIf Text_Stunden.Text > 99 Then
            Text_Stunden.Text = 99
            Exit Sub
        End If

        Call Command1_Click(sender, e)

        Exit Sub

Fehler:
        Text_Stunden.Text = 0
    End Sub

    'beschränkt den Max.Wert von Text_Minuten auf 59, wobei größere Eingaben solange durch 60 dividiert
    'werden bis das Endergebnis darunter liegt, und für jede Erfolgreiche (ganze) Division Text_Stunden
    'um 1 erhöht wird
    Private Sub Text_Minuten_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_Minuten.TextChanged
        On Error GoTo Fehler

        If Text_Minuten.Text = "" Then
            Text_Minuten.Text = 0
            Exit Sub
        ElseIf Text_Minuten.Text >= 60 Then
            Text_Stunden.Text += 1
            Text_Minuten.Text -= 60
            Exit Sub
        End If

        Call Command1_Click(sender, e)

        Exit Sub

Fehler:
        Text_Minuten.Text = 0
    End Sub

    'selbe Funtion wie Text_Minuten, nur dass hier jeweils Text_Minuten um 1 erhöht wird
    Private Sub Text3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_Sekunden.TextChanged
        On Error GoTo Fehler

        If Text_Sekunden.Text = "" Then
            Text_Sekunden.Text = 0
            Exit Sub
        ElseIf Text_Sekunden.Text >= 60 Then
            Text_Minuten.Text += 1
            Text_Sekunden.Text -= 60
            Exit Sub
        End If

        Call Command1_Click(sender, e)

        Exit Sub

Fehler:
        Text_Sekunden.Text = 0
    End Sub

    ' Checkbox "Differenz ermitteln"
    Private Sub Check1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check1.CheckedChanged

        If Check1.Checked = True Then
            Ziel_AudRate.Enabled = True
            Ziel_VidRate.Enabled = True
            Label7.Enabled = True
            Label8.Enabled = True
            Ziel_VidRate.Text = Quelle_VidRate.Text
        End If
        If Check1.Checked = False Then
            Ziel_AudRate.Enabled = False
            Ziel_VidRate.Enabled = False
            Label7.Enabled = False
            Label8.Enabled = False
        End If

        Call Command1_Click(sender, e)

    End Sub

    Private Sub Quelle_AudRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quelle_AudRate.TextChanged
        Call Command1_Click(sender, e)
    End Sub

    Private Sub Quelle_AudRate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quelle_AudRate.SelectedIndexChanged
        Call Command1_Click(sender, e)
    End Sub

    Private Sub Ziel_AudRate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ziel_AudRate.SelectedIndexChanged
        Call Command1_Click(sender, e)
    End Sub

    Private Sub Ziel_AudRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ziel_AudRate.TextChanged
        Call Command1_Click(sender, e)
    End Sub

    Private Sub Ziel_VidRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ziel_VidRate.TextChanged
        Call Command1_Click(sender, e)
    End Sub

    Private Sub Quelle_VidRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quelle_VidRate.TextChanged
        Call Command1_Click(sender, e)
    End Sub


    'Eingabe von Buchstaben verhindern
    Private Sub Text_Stunden_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_Stunden.KeyPress
        Call BuchstabenVerhindern(e)
    End Sub

    Private Sub Text_Minuten_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_Minuten.KeyPress
        Call BuchstabenVerhindern(e)
    End Sub

    Private Sub Text_Sekunden_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_Sekunden.KeyPress
        Call BuchstabenVerhindern(e)
    End Sub
    Private Sub Quelle_AudRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Quelle_AudRate.KeyPress
        Call BuchstabenVerhindern(e)
    End Sub

    Private Sub Ziel_AudRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ziel_AudRate.KeyPress
        Call BuchstabenVerhindern(e)
    End Sub

    Private Sub Quelle_VidRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Quelle_VidRate.KeyPress
        Call BuchstabenVerhindern(e)
    End Sub

    Private Sub Ziel_VidRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ziel_VidRate.KeyPress
        Call BuchstabenVerhindern(e)
    End Sub

    ' Ist etwas unsauber aber kA wie ich das anders formulieren soll :(
    Public Function BuchstabenVerhindern(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Object
        On Error GoTo fehler
        Dim sKeyStroke As Char
        Dim sNULL As Char = Chr(0)
        sKeyStroke = e.KeyChar

        Select Case sKeyStroke
            Case "0" To "9", vbBack, vbCr
            Case Else
                sKeyStroke = sNULL
        End Select

        If sKeyStroke = sNULL Then
            e.Handled = True
        Else
            e.Handled = False
        End If
        GoTo Ende

        ' Bei Fehler tue nichts
fehler:
        e.Handled = False

Ende:

    End Function

End Class

