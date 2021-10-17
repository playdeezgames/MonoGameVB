Imports System.IO
Imports System.Text.Json

Module Program
    <STAThread>
    Sub Main(args As String())
        Dim configuration As ApplicationConfiguration = JsonSerializer.Deserialize(Of ApplicationConfiguration)(File.ReadAllText("config/application.json"), New JsonSerializerOptions With {
            .PropertyNameCaseInsensitive = True
        })
        Using presenter As New Presenter(configuration)
            presenter.Run()
        End Using
    End Sub
End Module

