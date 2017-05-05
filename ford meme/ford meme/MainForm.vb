

Public Class MainForm
   Dim webClient As New System.Net.WebClient
   Dim result As String
   Dim credentials As New System.Net.NetworkCredential("", "")
   Dim ticker As String

   ' loose goose kind of meme here watch out 
   Private Sub btnFord_Click(sender As Object, e As EventArgs) Handles btnFord.Click
      'webClient.Credentials = credentials
      ticker = txtTicker.Text
      ticker = ticker.ToUpper
      Try
      result = webClient.DownloadString("https://api.intrinio.com/data_point?identifier=" & ticker & "&item=last_price")
         txtFord.Text = result
      Catch ex As Exception
         MsgBox(ex.Message)
         txtTicker.Enabled = False
      End Try




   End Sub

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      txtTicker.Enabled = False
      'btnSave.Enabled = False
      'txtPass.Enabled = False
      'txtUser.Enabled = False
      'lblUser.Enabled = False
      'lblPass.Enabled = False

   End Sub



   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      credentials = New Net.NetworkCredential(txtUser.Text, txtPass.Text)
      webClient.Credentials = credentials
      txtTicker.Enabled = True
   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()
   End Sub
End Class
