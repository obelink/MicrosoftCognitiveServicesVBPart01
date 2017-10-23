Imports System.IO
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports JsonPrettyPrinterPlus.PrettyPrinterExtensions

Public Class MainForm

    Private ReadOnly _subscriptionKey = "17e72298c40a4532901b20c1df72c5b2"
    Private ReadOnly _uriBase = "https://westeurope.api.cognitive.microsoft.com/vision/v1.0/"

    Private Async Function GetAnalyzeImageResultAsync(imageFilePath As String) As Task(Of String)

        Dim imageAsBytes = GetImageAsByteArray(imageFilePath)
        Dim requestUri = GetRequestUri()

        using client As New HttpClient()
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _subscriptionKey)

            using content = new ByteArrayContent(imageAsBytes)
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream")
                Dim response = await client.PostAsync(requestUri, content)
                return await response.Content.ReadAsStringAsync()
            End Using
               
        End Using

    End Function

    Private Function GetImageAsByteArray(imageFilePath As String) As Byte()

        Using fileStream As New FileStream(imageFilePath, FileMode.Open, FileAccess.Read)
            Using binaryReader As New BinaryReader(fileStream)
                Return binaryReader.ReadBytes(fileStream.Length)
            End Using
        End Using

    End Function

    Private Function GetImageFilePath() As String

        Dim dialog As New OpenFileDialog
        With dialog
            .Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*"

            If .ShowDialog = DialogResult.OK Then
                Return .FileName
            Else
                Return String.Empty
            End If

        End With
  
    End Function

    Private Function GetRequestUri() As String

        Const operation = "analyze/"
        Const requestParameters = "visualFeatures=Categories,Tags,Description"

        Return _uriBase & operation & "?" & requestParameters

    End Function
    
    Private Async Sub SelectFileButton_Click(sender As Object, e As EventArgs) Handles SelectFileButton.Click

        Dim imageFilePath = GetImageFilePath()

        If imageFilePath <> String.Empty Then
            Dim jsonResult = Await GetAnalyzeImageResultAsync(imageFilePath)
            JsonResultTextBox.Text = jsonResult.PrettyPrintJson()
        End If

    End Sub
    
End Class
