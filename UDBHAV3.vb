Option Strict Off
Option Explicit On
Friend Class Form1
	Inherits System.Windows.Forms.Form
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Hide()
		Form2.Show()
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Me.Hide()
		Form5.Show()
	End Sub
	
	Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Text = InputBox("PLEASE ENTER YOUR NAME", "Name", CStr(MsgBoxStyle.OKCancel))
		Me.Text = CStr(MsgBox("WELCOME TO THE SETUP", MsgBoxStyle.OKOnly))
		Me.Text = "WELCOME TO THE SETUP"
	End Sub
End Class