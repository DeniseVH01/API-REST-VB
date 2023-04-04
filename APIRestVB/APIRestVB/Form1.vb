Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization.Json
Imports Newtonsoft.Json

Public Class Form1
    Dim URL As String = "https://jsonplaceholder.typicode.com/posts"

    Public Async Function GetHttp() As Task(Of String)
        Dim oRequest As WebRequest = WebRequest.Create(URL)
        Dim oResponse As WebResponse = oRequest.GetResponse()
        oResponse.Headers("Placeholder-Token") = "3951d5d8-b2f8-4cd8-bf5f-9d619e03a5c2"
        Dim sr As StreamReader = New StreamReader(oResponse.GetResponseStream())
        Return Await sr.ReadToEndAsync()
    End Function

    Private Async Sub BTNaceptar_Click(sender As Object, e As EventArgs) Handles BTNaceptar.Click
        Dim respuesta As String = Await GetHttp()
        Dim lista As List(Of PostModelo) = JsonConvert.DeserializeObject(Of List(Of PostModelo))(respuesta)
        DGVlista.DataSource = lista
        DGVlista.CurrentCell = Nothing


    End Sub


    Private Async Sub BTNbuscar_Click_1(sender As Object, e As EventArgs) Handles BTNbuscar.Click
        Dim respuesta As String = Await GetHttp()
        DGVlista.CurrentCell = Nothing
        For Each row As DataGridViewRow In DGVlista.Rows

            row.Visible = (row.Cells("userId").Value.ToString().Contains(TXTbuscar.Text))
        Next
    End Sub
End Class
