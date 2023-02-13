Friend Class MainView
    Implements IView(Of SpriteIdentifier, HueIdentifier, Command)
    Private titleView As IView(Of SpriteIdentifier, HueIdentifier, Command)
    Sub New()
        titleView = New TitleView()
    End Sub
    Public Sub OnUpdate(elapsed As TimeSpan) Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnUpdate
        titleView.OnUpdate(elapsed)
    End Sub
    Public Sub OnDraw(spriteRenderer As ISpriteRenderer(Of SpriteIdentifier, HueIdentifier)) Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnDraw
        titleView.OnDraw(spriteRenderer)
    End Sub

    Public Function OnCommand(command As Command) As CommandResult Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnCommand
        Return titleView.OnCommand(command)
    End Function
End Class
