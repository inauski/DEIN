VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H80000007&
   BorderStyle     =   0  'None
   Caption         =   "MasterMind"
   ClientHeight    =   8340
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   4920
   DrawMode        =   12  'Nop
   LinkTopic       =   "Form1"
   Moveable        =   0   'False
   ScaleHeight     =   8340
   ScaleWidth      =   4920
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.Frame frmjuego 
      BackColor       =   &H8000000B&
      BorderStyle     =   0  'None
      Height          =   8055
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Visible         =   0   'False
      Width           =   4695
      Begin VB.CommandButton cmbnuevo 
         Caption         =   "Nuevo"
         Height          =   375
         Left            =   3480
         TabIndex        =   13
         Top             =   2520
         Width           =   975
      End
      Begin VB.CommandButton cmb0 
         Appearance      =   0  'Flat
         BackColor       =   &H0000FF00&
         Height          =   495
         Index           =   6
         Left            =   3840
         Style           =   1  'Graphical
         TabIndex        =   12
         Top             =   7320
         Width           =   495
      End
      Begin VB.CommandButton cmb0 
         Appearance      =   0  'Flat
         BackColor       =   &H00000000&
         Height          =   495
         Index           =   5
         Left            =   3240
         Style           =   1  'Graphical
         TabIndex        =   11
         Top             =   7320
         Width           =   495
      End
      Begin VB.CommandButton cmb0 
         Appearance      =   0  'Flat
         BackColor       =   &H00FFFFFF&
         Height          =   495
         Index           =   4
         Left            =   2640
         Style           =   1  'Graphical
         TabIndex        =   10
         Top             =   7320
         Width           =   495
      End
      Begin VB.CommandButton cmb0 
         Appearance      =   0  'Flat
         BackColor       =   &H000080FF&
         Height          =   495
         Index           =   3
         Left            =   2040
         Style           =   1  'Graphical
         TabIndex        =   9
         Top             =   7320
         Width           =   495
      End
      Begin VB.CommandButton cmb0 
         Appearance      =   0  'Flat
         BackColor       =   &H0000FFFF&
         Height          =   495
         Index           =   2
         Left            =   1440
         Style           =   1  'Graphical
         TabIndex        =   8
         Top             =   7320
         Width           =   495
      End
      Begin VB.CommandButton cmb0 
         Appearance      =   0  'Flat
         BackColor       =   &H00FF0000&
         Height          =   495
         Index           =   1
         Left            =   840
         Style           =   1  'Graphical
         TabIndex        =   7
         Top             =   7320
         Width           =   495
      End
      Begin VB.CommandButton cmbsalirj 
         Caption         =   "Salir"
         Height          =   375
         Left            =   3480
         TabIndex        =   6
         Top             =   3720
         Width           =   975
      End
      Begin VB.CommandButton cmb0 
         Appearance      =   0  'Flat
         BackColor       =   &H000000FF&
         Height          =   495
         Index           =   0
         Left            =   240
         Style           =   1  'Graphical
         TabIndex        =   4
         Top             =   7320
         Width           =   495
      End
      Begin VB.CommandButton cmbmenu 
         Appearance      =   0  'Flat
         Caption         =   "Menu"
         Height          =   375
         Left            =   3480
         TabIndex        =   3
         Top             =   3120
         Width           =   975
      End
      Begin VB.Shape Shape5 
         BackStyle       =   1  'Opaque
         Height          =   735
         Left            =   120
         Top             =   240
         Width           =   2535
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   39
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   1440
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   38
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   1440
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   37
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   1320
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   36
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   1320
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   35
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   2040
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   34
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   2040
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   33
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   1920
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   32
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   1920
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   31
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   2640
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   30
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   2640
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   29
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   2520
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   28
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   2520
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   27
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   3240
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   26
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   3240
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   25
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   3120
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   24
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   3120
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   23
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   3840
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   22
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   3840
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   21
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   3720
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   20
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   3720
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   19
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   4440
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   18
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   4440
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   17
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   4320
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   16
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   4320
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   15
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   5040
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   14
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   5040
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   13
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   4920
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   12
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   4920
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   11
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   5640
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   10
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   5640
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   9
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   5520
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   8
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   5520
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   7
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   6240
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   6
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   6240
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   5
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   6120
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   4
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   6120
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   3
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   6840
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   2
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   6840
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   1
         Left            =   3000
         Shape           =   3  'Circle
         Top             =   6720
         Width           =   135
      End
      Begin VB.Shape Shape4 
         BackColor       =   &H80000004&
         BackStyle       =   1  'Opaque
         Height          =   135
         Index           =   0
         Left            =   2880
         Shape           =   3  'Circle
         Top             =   6720
         Width           =   135
      End
      Begin VB.Shape Shape3 
         Height          =   735
         Left            =   120
         Top             =   240
         Width           =   2535
      End
      Begin VB.Shape Shape2 
         BackColor       =   &H8000000A&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   3
         Left            =   2040
         Shape           =   3  'Circle
         Top             =   360
         Width           =   495
      End
      Begin VB.Shape Shape2 
         BackColor       =   &H8000000A&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   2
         Left            =   1440
         Shape           =   3  'Circle
         Top             =   360
         Width           =   495
      End
      Begin VB.Shape Shape2 
         BackColor       =   &H8000000A&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   1
         Left            =   840
         Shape           =   3  'Circle
         Top             =   360
         Width           =   495
      End
      Begin VB.Shape Shape2 
         BackColor       =   &H8000000A&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   0
         Left            =   240
         Shape           =   3  'Circle
         Top             =   360
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   39
         Left            =   2040
         Shape           =   3  'Circle
         Top             =   1200
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   38
         Left            =   1440
         Shape           =   3  'Circle
         Top             =   1200
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   37
         Left            =   840
         Shape           =   3  'Circle
         Top             =   1200
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   36
         Left            =   240
         Shape           =   3  'Circle
         Top             =   1200
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   35
         Left            =   2040
         Shape           =   3  'Circle
         Top             =   1800
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   34
         Left            =   1440
         Shape           =   3  'Circle
         Top             =   1800
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   33
         Left            =   840
         Shape           =   3  'Circle
         Top             =   1800
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   32
         Left            =   240
         Shape           =   3  'Circle
         Top             =   1800
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   31
         Left            =   2040
         Shape           =   3  'Circle
         Top             =   2400
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   30
         Left            =   1440
         Shape           =   3  'Circle
         Top             =   2400
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   29
         Left            =   840
         Shape           =   3  'Circle
         Top             =   2400
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   28
         Left            =   240
         Shape           =   3  'Circle
         Top             =   2400
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   27
         Left            =   2040
         Shape           =   3  'Circle
         Top             =   3000
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   26
         Left            =   1440
         Shape           =   3  'Circle
         Top             =   3000
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   25
         Left            =   840
         Shape           =   3  'Circle
         Top             =   3000
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   24
         Left            =   240
         Shape           =   3  'Circle
         Top             =   3000
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   23
         Left            =   2040
         Shape           =   3  'Circle
         Top             =   3600
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   22
         Left            =   1440
         Shape           =   3  'Circle
         Top             =   3600
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   21
         Left            =   840
         Shape           =   3  'Circle
         Top             =   3600
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   20
         Left            =   240
         Shape           =   3  'Circle
         Top             =   3600
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   19
         Left            =   2040
         Shape           =   3  'Circle
         Top             =   4200
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   18
         Left            =   1440
         Shape           =   3  'Circle
         Top             =   4200
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   17
         Left            =   840
         Shape           =   3  'Circle
         Top             =   4200
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   16
         Left            =   240
         Shape           =   3  'Circle
         Top             =   4200
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   15
         Left            =   2040
         Shape           =   3  'Circle
         Top             =   4800
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   14
         Left            =   1440
         Shape           =   3  'Circle
         Top             =   4800
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   13
         Left            =   840
         Shape           =   3  'Circle
         Top             =   4800
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   12
         Left            =   240
         Shape           =   3  'Circle
         Top             =   4800
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   11
         Left            =   2040
         Shape           =   3  'Circle
         Top             =   5400
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   10
         Left            =   1440
         Shape           =   3  'Circle
         Top             =   5400
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   9
         Left            =   840
         Shape           =   3  'Circle
         Top             =   5400
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   8
         Left            =   240
         Shape           =   3  'Circle
         Top             =   5400
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   7
         Left            =   2040
         Shape           =   3  'Circle
         Top             =   6000
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   6
         Left            =   1440
         Shape           =   3  'Circle
         Top             =   6000
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   5
         Left            =   840
         Shape           =   3  'Circle
         Top             =   6000
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   4
         Left            =   240
         Shape           =   3  'Circle
         Top             =   6000
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   3
         Left            =   2040
         Shape           =   3  'Circle
         Top             =   6600
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   2
         Left            =   1440
         Shape           =   3  'Circle
         Top             =   6600
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   1
         Left            =   840
         Shape           =   3  'Circle
         Top             =   6600
         Width           =   495
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H8000000B&
         BackStyle       =   1  'Opaque
         Height          =   495
         Index           =   0
         Left            =   240
         Shape           =   3  'Circle
         Top             =   6600
         Width           =   495
      End
   End
   Begin VB.Frame frminicio 
      BorderStyle     =   0  'None
      Height          =   8055
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   4695
      Begin VB.CommandButton cmbsalir 
         Caption         =   "Salir"
         Height          =   615
         Left            =   2400
         TabIndex        =   5
         Top             =   1440
         Width           =   1455
      End
      Begin VB.CommandButton cmbjugar 
         Caption         =   "Jugar"
         Height          =   615
         Left            =   720
         TabIndex        =   1
         Top             =   1440
         Width           =   1455
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         Caption         =   "Desarrollado por JoxeDuKe12 www.quedese.110mb.com http://lospillaos.es/foro/index.php"
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1095
         Left            =   120
         TabIndex        =   16
         Top             =   6480
         Width           =   4455
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         Caption         =   $"Form1.frx":0000
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   3855
         Left            =   720
         TabIndex        =   15
         Top             =   2280
         Width           =   3255
      End
      Begin VB.Label Label1 
         Alignment       =   2  'Center
         Caption         =   "MasterMind"
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   36
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   240
         TabIndex        =   14
         Top             =   240
         Width           =   4215
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Dim colorsecreto(3) As Integer
Dim combinaciones(3) As Integer
Dim i As Byte
Dim numero As Byte
Dim turnos As Byte
Dim puntos As Byte
Dim famas As Byte
Dim total As Byte
Dim totalpistas As Byte
Dim gano As Byte

Private Sub cmb0_Click(Index As Integer)
combinaciones(turnos) = Index
Me.Shape1(total).BackColor = Me.cmb0(Index).BackColor
Me.cmb0(Index).Enabled = False
If turnos = 3 Then
    valida
    limpia
Else
    'guardar combinacion a validar
    turnos = turnos + 1
End If
If total = 39 Then
    If gano = 1 Then
        Me.Shape5.Visible = False
        MsgBox "Excelente, descubriste la combinacion."
        nuevojuego
    Else
        Me.Shape5.Visible = False
        MsgBox "No has podido descubrir la combinacion."
        nuevojuego
    End If
Else
    If gano = 1 Then
        Me.Shape5.Visible = False
        MsgBox "Excelente, descubriste la combinacion."
        nuevojuego
    Else
        total = total + 1
    End If
End If
End Sub

Sub limpia()
For j = 0 To 6
    Me.cmb0(j).Enabled = True
Next j
turnos = 0
puntos = 0
famas = 0
End Sub

Sub valida()
    For j = 0 To 3
        For t = 0 To 3
            If combinaciones(j) = colorsecreto(t) Then
                If j = t Then
                    famas = famas + 1 'igual y en la misma posion
                    t = 3
                Else
                    puntos = puntos + 1 'igual
                    t = 3
                End If
            Else
                'no es igual
            End If
        Next t
    Next j
    For j = 1 To famas
        Me.Shape4(totalpistas).BackColor = &H0&
        totalpistas = totalpistas + 1
    Next j
    If famas = 4 Then
        gano = 1
    Else
        For j = famas + 1 To puntos + famas
            Me.Shape4(totalpistas).BackColor = &H404040
            totalpistas = totalpistas + 1
        Next j
        If puntos = 4 Then
            'no mas
        Else
            For j = famas + puntos + 1 To 4
                Me.Shape4(totalpistas).BackColor = &H80000004
                totalpistas = totalpistas + 1
            Next j
        End If
    End If
End Sub

Private Sub cmbjugar_Click()
    Me.frminicio.Visible = False
    Me.frmjuego.Visible = True
    jugar
End Sub

Private Sub cmbmenu_Click()
    Me.frminicio.Visible = True
    Me.frmjuego.Visible = False
End Sub

Private Sub cmbnuevo_Click()
nuevojuego
End Sub

Private Sub cmbsalir_Click()
salir
End Sub

Private Sub cmbsalirj_Click()
salir
End Sub

Sub jugar()
    combinacion
    turnos = 0
    total = 0
    totalpistas = 0
    gano = 0
    Me.Shape5.Visible = True
    For j = 0 To 39
        Me.Shape1(j).BackColor = &H80000004
        Me.Shape4(j).BackColor = &H80000004
    Next j
    For j = 0 To 6
        Me.cmb0(j).Enabled = True
    Next j
End Sub

Sub combinacion()
For j = 0 To 3
    colorsecreto(j) = 9
Next j
For i = 0 To 3
    aleatorio
Next i
End Sub

Sub aleatorio()
    Randomize
    numero = (Rnd * 6)
    validar
End Sub

Sub validar()
    For j = 0 To 3
        If numero = colorsecreto(j) Then
            fin = 0
            j = 3
        Else
            fin = 1
        End If
    Next j
    If fin = 0 Then
        aleatorio
    Else
        colorsecreto(i) = numero
        Select Case numero
            Case 0
                Shape2(i).BackColor = &HFF&
            Case 1
                Shape2(i).BackColor = &HFF0000
            Case 2
                Shape2(i).BackColor = &HFFFF&
            Case 3
                Shape2(i).BackColor = &H80FF&
            Case 4
                Shape2(i).BackColor = &HFFFFFF
            Case 5
                Shape2(i).BackColor = &H0&
            Case 6
                Shape2(i).BackColor = &HFF00&
        End Select
    End If
End Sub

Private Sub Form_Load()
    Me.frmjuego.BackColor = RGB(160, 108, 0)
    Me.Shape5.BackColor = RGB(160, 108, 0)
End Sub

Sub salir()
menzaje = MsgBox("Desea salir de juego ", vbYesNo, "MasterMind")
If menzaje = 6 Then
    End
Else
    
End If
End Sub

Sub nuevojuego()
menzaje = MsgBox("Desea volver a jugar ", vbYesNo, "MasterMind")
If menzaje = 6 Then
    jugar
Else
    End
End If
End Sub

