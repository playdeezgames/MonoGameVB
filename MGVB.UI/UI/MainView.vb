Friend Class MainView
    Implements IView(Of SpriteIdentifier, HueIdentifier, Command)
    Private state As UIState = UIState.Title
    Private ReadOnly states As IReadOnlyDictionary(Of UIState, IView(Of SpriteIdentifier, HueIdentifier, Command)) =
        New Dictionary(Of UIState, IView(Of SpriteIdentifier, HueIdentifier, Command)) From
        {
            {UIState.Title, New TitleView}
        }
    Sub New()
    End Sub
    Public Sub OnUpdate(elapsed As TimeSpan) Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnUpdate
        states(state).OnUpdate(elapsed)
    End Sub
    Public Sub OnDraw(spriteRenderer As ISpriteRenderer(Of SpriteIdentifier, HueIdentifier)) Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnDraw
        states(state).OnDraw(spriteRenderer)
    End Sub
    Public Function OnCommand(command As Command) As CommandResult Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnCommand
        Return states(state).OnCommand(command)
    End Function
End Class
