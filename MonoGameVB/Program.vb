Module Program
    Private Const CONFIG_FILE_NAME As String = "config/application.json"
    <STAThread>
    Sub Main(args As String())
        Dim configuration As ApplicationConfiguration = JsonSerializer.Deserialize(Of ApplicationConfiguration)(File.ReadAllText(CONFIG_FILE_NAME), New JsonSerializerOptions With {
            .PropertyNameCaseInsensitive = True
        })
        Using presenter As New Presenter(configuration, New MainView())
            presenter.Run()
        End Using
    End Sub
End Module

