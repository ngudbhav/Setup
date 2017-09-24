Option Strict Off
Option Explicit On
Friend Class Form8
	Inherits System.Windows.Forms.Form
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Form1.Show()
		Me.Hide()
		Timer1.Enabled = False
	End Sub
End Class