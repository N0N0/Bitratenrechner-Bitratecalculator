VERSION 5.00
Begin VB.Form Form1 
   BorderStyle     =   1  'Fest Einfach
   Caption         =   "Bitraten-Rechner"
   ClientHeight    =   3195
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   2445
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3195
   ScaleWidth      =   2445
   StartUpPosition =   3  'Windows-Standard
   Begin VB.CheckBox Check1 
      Caption         =   "Check1"
      Height          =   255
      Left            =   1680
      TabIndex        =   13
      Top             =   1680
      Width           =   255
   End
   Begin VB.ComboBox Combo2 
      Enabled         =   0   'False
      Height          =   315
      Left            =   1560
      TabIndex        =   12
      Text            =   "Combo2"
      Top             =   1200
      Width           =   735
   End
   Begin VB.ComboBox Combo1 
      Height          =   315
      Left            =   720
      TabIndex        =   10
      Text            =   "Combo1"
      Top             =   1200
      Width           =   735
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Berechnen"
      Height          =   375
      Left            =   120
      TabIndex        =   6
      Top             =   2640
      Width           =   2175
   End
   Begin VB.TextBox Text5 
      Height          =   285
      Left            =   840
      TabIndex        =   3
      Top             =   2160
      Width           =   735
   End
   Begin VB.TextBox Text3 
      Height          =   285
      Left            =   1920
      TabIndex        =   2
      Text            =   "00"
      Top             =   360
      Width           =   375
   End
   Begin VB.TextBox Text2 
      Height          =   285
      Left            =   1320
      TabIndex        =   1
      Text            =   "00"
      Top             =   360
      Width           =   375
   End
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   720
      TabIndex        =   0
      Text            =   "00"
      Top             =   360
      Width           =   375
   End
   Begin VB.Line Line2 
      X1              =   0
      X2              =   2400
      Y1              =   2040
      Y2              =   2040
   End
   Begin VB.Line Line1 
      X1              =   0
      X2              =   2400
      Y1              =   720
      Y2              =   720
   End
   Begin VB.Label Label8 
      Caption         =   "Std.      Min.      Sek."
      Height          =   255
      Left            =   840
      TabIndex        =   16
      Top             =   120
      Width           =   1455
   End
   Begin VB.Label Label7 
      Caption         =   "größer        kleiner"
      Height          =   255
      Left            =   960
      TabIndex        =   15
      Top             =   840
      Width           =   1335
   End
   Begin VB.Label Label6 
      Caption         =   "Differenz ermitteln:"
      Height          =   255
      Left            =   120
      TabIndex        =   14
      Top             =   1680
      Width           =   1335
   End
   Begin VB.Label Label4 
      Caption         =   "MByte(s)"
      Height          =   255
      Left            =   1680
      TabIndex        =   11
      Top             =   2160
      Width           =   615
   End
   Begin VB.Label Label1 
      Caption         =   "Dauer:"
      Height          =   255
      Left            =   120
      TabIndex        =   9
      Top             =   360
      Width           =   495
   End
   Begin VB.Label Label5 
      Caption         =   ":"
      Height          =   255
      Index           =   1
      Left            =   1800
      TabIndex        =   8
      Top             =   360
      Width           =   135
   End
   Begin VB.Label Label5 
      Caption         =   ":"
      Height          =   255
      Index           =   0
      Left            =   1200
      TabIndex        =   7
      Top             =   360
      Width           =   135
   End
   Begin VB.Label Label3 
      Caption         =   "Größe:"
      Height          =   255
      Left            =   120
      TabIndex        =   5
      Top             =   2160
      Width           =   615
   End
   Begin VB.Label Label2 
      Caption         =   "Bitrate:"
      Height          =   255
      Left            =   120
      TabIndex        =   4
      Top             =   1200
      Width           =   495
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Check1_Click()

  If Check1 = 1 Then
    Combo2.Enabled = True
  Else
    Combo2.Enabled = False
  End If
  
End Sub

Private Sub Form_Load()

  Combo1.AddItem 32
  Combo1.AddItem 64
  Combo1.AddItem 96
  Combo1.AddItem 112
  Combo1.AddItem 128
  Combo1.AddItem 160
  Combo1.AddItem 192
  Combo1.AddItem 224
  Combo1.AddItem 256
  Combo1.AddItem 320
  Combo1.AddItem 384
  Combo1 = 128
  
  Combo2.AddItem 32
  Combo2.AddItem 64
  Combo2.AddItem 96
  Combo2.AddItem 112
  Combo2.AddItem 128
  Combo2.AddItem 160
  Combo2.AddItem 192
  Combo2.AddItem 224
  Combo2.AddItem 256
  Combo2.AddItem 320
  Combo2.AddItem 384
  Combo2 = 128
  
End Sub


Private Sub Command1_Click()
  On Error Resume Next
  Dauer = ""
  Ergebnis = ""

  Bits = Combo1 / 8
  
  Dauer = Text1.Text * 60
  Dauer = Dauer + Text2.Text
  Dauer = Dauer * 60
  Dauer = Dauer + Text3.Text
  
  Ergebnis = Dauer * Bits
  Ergebnis = Ergebnis / 1024
  
  If Check1 = 0 Then
    Text5.Text = Ergebnis
    Exit Sub
  Else
    Bits2 = Combo2 / 8
    Ergebnis2 = Dauer * Bits2
    Ergebnis2 = Ergebnis2 / 1024
    Ergebnis = Ergebnis - Ergebnis2
    Text5.Text = Ergebnis
  End If
  
End Sub


Private Sub Text1_Change()
' Verhindert die Eingabe von Buchstaben
On Error GoTo Fehler

  If Text1.Text = "" Then
    Text1.Text = 0
    Exit Sub
  ElseIf Text1.Text > 99 Then
    Text1.Text = 99
    Exit Sub
  End If
  Exit Sub
  
Fehler:
  Text1.Text = 0

End Sub

Private Sub Text2_Change()
' Verhindert die Eingabe von Buchstaben
On Error GoTo Fehler

  If Text2.Text = "" Then
    Text2.Text = 0
    Exit Sub
  ElseIf Text2.Text >= 60 Then
    Text1.Text = Text1.Text + 1
    Text2.Text = Text2.Text - 60
    Exit Sub
  End If
  Exit Sub
  
Fehler:
   Text2.Text = 0
   
End Sub

Private Sub Text3_Change()
' Verhindert die Eingabe von Buchstaben
On Error GoTo Fehler

  If Text3.Text = "" Then
    Text3.Text = 0
    Exit Sub
  ElseIf Text3.Text >= 60 Then
    Text2.Text = Text2.Text + 1
    Text3.Text = Text3.Text - 60
    Exit Sub
  End If
  Exit Sub
  
Fehler:
  Text3.Text = 0

End Sub

