Imports System.Windows.Input

Module Program
    Private Const CONFIG_FILE_NAME As String = "config/application.json"
    <STAThread>
    Sub Main(args As String())
        Dim configuration As IApplicationConfiguration =
            New ApplicationConfiguration With
            {
                .FullScreen = False,
                .Title = "Doing Stuff!!!",
                .Screen = New ScreenConfiguration With
                {
                    .Width = 1280,
                    .Height = 720
}
}
        Using presenter As New Presenter(Of SpriteIdentifier, HueIdentifier, TextureIdentifier, Command)(configuration, New MainView(), CommandsTable, ButtonTable, SpriteSources, TextureSources, HueSources)
            presenter.Run()
        End Using
    End Sub
End Module

