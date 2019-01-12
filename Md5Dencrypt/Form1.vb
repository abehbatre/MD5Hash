Imports System.IO
Imports System.Net
Imports System.Text

Public Class Form1


    Dim LINE As String = vbCrLf
    Private Const Base_URL As String = "http://www.nitrxgen.net/md5db/"
    Private Const USER_AGENT As String = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.101 Safari/537.36"
    Private pCookie As New CookieContainer
    Private pCookieGambar As New CookieContainer
    Private pRaw As String = ""
    Private pUrlPicture As String = ""
    Private MouseIsDown As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        BackgroundWorker1.WorkerSupportsCancellation = True
        BackgroundWorker2.WorkerSupportsCancellation = True
    End Sub

#Region "Fungsi"

    Private Function GetHash(strToHash As String) As String

        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As New StringBuilder

        For Each b As Byte In bytesToHash
            strResult.Append(b.ToString("x2"))
        Next
        RichTextBox4.Text += strResult.ToString + LINE
        TextBox1.Text = strResult.ToString
        Return strResult.ToString

    End Function


    Private Function HGet(ByVal lpURL As String) As String
        Dim reader As StreamReader
        Dim Request As HttpWebRequest = HttpWebRequest.Create(lpURL)


        Request.UserAgent = USER_AGENT
        Request.CookieContainer = pCookie
        Request.Timeout = 10000
        Request.ReadWriteTimeout = 10000
        Request.AllowAutoRedirect = False
        Request.Referer = Base_URL
        Request.Method = "GET"


        Dim Response As HttpWebResponse = Request.GetResponse()

        For Each tempCookie In Response.Cookies
            pCookie.Add(tempCookie)
        Next

        reader = New StreamReader(Response.GetResponseStream())
        Dim result As String = reader.ReadToEnd()
        reader.Close()

        If result.Contains("<!DOCTYPE html PUBLIC") Or result.Contains("html") Then
            'nothing
        Else
            RichTextBox2.Text += result + LINE
        End If



        Return result
    End Function


    Public Function HPost(ByVal lpURL As String, ByVal lpPostData As String) As String
        Dim reader As StreamReader
        Dim Request As HttpWebRequest = HttpWebRequest.Create(lpURL)


        Request.AllowAutoRedirect = False
        Request.ContentType = "application/x-www-form-urlencoded"
        Request.Referer = Base_URL
        Request.Headers.Add("Origin: " + Base_URL)
        Request.Headers.Add("X-Requested-With: XMLHttpRequest")
        Request.Headers.Add("ADRUM: isAjax:true")

        Request.Method = "POST"
        Request.ContentLength = lpPostData.Length

        Dim requestStream As Stream = Request.GetRequestStream()
        Dim postBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(lpPostData)

        requestStream.Write(postBytes, 0, postBytes.Length)
        requestStream.Close()

        Dim Response As HttpWebResponse = Request.GetResponse()

        'For Each tempcookie In Response.Cookies
        '    pCookie.Add(tempcookie)
        'Next

        reader = New StreamReader(Response.GetResponseStream())
        Dim result As String = reader.ReadToEnd()
        reader.Close()

        If result.Contains("SUKSES") Then
            RichTextBox5.Text += "OK" + LINE
        Else
            RichTextBox5.Text += "FAIL"
        End If


    End Function



    Private Function GetStr(lpBaseString As String, lpPattern As String) As String
        Dim ketemu As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(lpBaseString, lpPattern)
        If ketemu.Success Then
            Dim result As String = ketemu.Groups(1).Value

            'RichTextBox2.Text += result + LINE
            Return result
        Else
            Return ""
        End If
    End Function
#End Region



    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        For i As Integer = 0 To RichTextBox1.Lines.Count - 1
            HGet(Base_URL + RichTextBox1.Lines(i))

            ProgressBar1.Value = (i + 1) / RichTextBox1.Lines.Count * 100
            Label1.Text = "Progress " + ProgressBar1.Value.ToString + " %"
        Next
        MsgBox("Done", vbInformation)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Try
            For i = 0 To RichTextBox3.Lines.Count - 1


                Dim newList As List(Of String) = RichTextBox3.Lines.ToList


                GetHash(RichTextBox3.Lines(i))
                'GetStr(RichTextBox1.Lines(i), "password  : (.*)")

                ProgressBar2.Value = (i + 1) / RichTextBox3.Lines.Count * 100
                Me.Text = "Progress Complite : " + ProgressBar1.Value.ToString + "%"

                Dim zzz As String = i.ToString
                Label2.Text = zzz

            Next
            ProgressBar1.Value = 100

        Catch ex As Exception
            MsgBox(ex.ToString, vbExclamation)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim CO As Integer = 0

        If (CO < 100) Then
            Dim random1 As Random = New Random()
            Me.Saya.ForeColor = System.Drawing.Color.FromArgb(random1.Next(0, 256), random1.Next(0, 256), random1.Next(0, 256))
        Else
            Me.Timer1.Enabled = False
        End If
        CO = (CO + 1)

    End Sub
End Class
