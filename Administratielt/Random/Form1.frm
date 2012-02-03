VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   510
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   5865
   LinkTopic       =   "Form1"
   ScaleHeight     =   510
   ScaleWidth      =   5865
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer tmrTimer 
      Enabled         =   0   'False
      Interval        =   20
      Left            =   3600
      Top             =   0
   End
   Begin VB.CommandButton cmdGenerer 
      Caption         =   "Generer"
      Height          =   255
      Left            =   3960
      TabIndex        =   1
      Top             =   120
      Width           =   1815
   End
   Begin VB.Label lblNavn 
      Height          =   255
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   3375
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim navnID, i As Integer
Dim navne(1 To 7) As String
Dim navneTæller(1 To 7) As Integer
Dim sidsteTrukket As Integer
Dim tmrAntal As Integer
Dim antalGennemgange As Integer
Dim antalTrukkede As Integer

Private Sub cmdGenerer_Click()
    Randomize
    tmrAntal = Int(Rnd * 200 + 1)
    tmrTimer.Enabled = True
End Sub

Private Sub Form_Load()
    navne(1) = "Mette"
    navne(2) = "Christian"
    navne(3) = "Dag"
    navne(4) = "Niels"
    navne(5) = "Aleksander"
    navne(6) = "Kasper"
    navne(7) = "Rasmus"
    antalGennemgange = 1
End Sub

Private Sub tmrTimer_Timer()
    Randomize
    If i < tmrAntal Then
        navnID = Int(Rnd * 7 + 1)
        lblNavn.Caption = navne(navnID)
        i = i + 1
    Else
        If navneTæller(navnID) < antalGennemgange Then
            If navnID = sidsteTrukket Then
            Else
                tmrTimer.Enabled = False
                i = 0
                sidsteTrukket = navnID
                navneTæller(navnID) = navneTæller(navnID) + 1
                
                If antalTrukkede < 7 Then
                    antalTrukkede = antalTrukkede + 1
                Else
                    antalTrukkede = 0
                    antalGennemgange = antalGennemgange + 1
                End If
            End If
        Else
            i = i - 1
        End If
        
        
    End If
End Sub

