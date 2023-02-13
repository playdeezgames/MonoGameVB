Public Class Presenter
    Inherits BasePresenter(Of SpriteIdentifier, HueIdentifier, TextureIdentifier, Command)

    Public Sub New()
        MyBase.New(New ApplicationConfiguration With
            {
                .FullScreen = False,
                .Title = "Doing Stuff!!!",
                .Screen = New ScreenConfiguration With
                {
                    .Width = 1280,
                    .Height = 720
                }
            }, New MainView(), CommandsTable, ButtonTable, SpriteSources, TextureSources, HueSources)
    End Sub
End Class
