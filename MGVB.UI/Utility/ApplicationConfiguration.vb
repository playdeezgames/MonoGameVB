Public Class ApplicationConfiguration
    Implements IApplicationConfiguration
    Property Screen As IScreenConfiguration Implements IApplicationConfiguration.Screen
    Property Title As String Implements IApplicationConfiguration.Title
    Property FullScreen As Boolean Implements IApplicationConfiguration.FullScreen
End Class
