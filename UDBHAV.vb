Option Strict Off
Option Explicit On
Friend Class Form4
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Me.Hide()
		Form3.Show()
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Me.Hide()
		Form5.Show()
	End Sub
	
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Image1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Image1.Width) + 10)
		If VB6.PixelsToTwipsX(Image1.Width) = 6675 Then
			Timer1.Enabled = False
			Me.Hide()
			Form6.Show()
		End If
	End Sub
	
	Private Sub Timer2_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer2.Tick
		Label3.Text = "STATUS:--- c\\PROGRAM FILES\AYS\"
		
	End Sub
	
	Private Sub Timer3_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer3.Tick
		Label3.Text = "STATUS:--- UPDATING REGISTRY"
		Timer3.Enabled = False
	End Sub
	
	Private Sub Timer4_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer4.Tick
		Label3.Text = "STATUS:---C\\WINDOWS\SYSTEM32\"
		Timer4.Enabled = False
	End Sub
End Class