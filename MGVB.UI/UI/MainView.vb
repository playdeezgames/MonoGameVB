Imports MGVB.Business

Friend Class MainView
    Implements IView(Of SpriteIdentifier, HueIdentifier, Command)
    Private _state As UIState = UIState.Title
    Private _world As IWorld
    Private ReadOnly _states As IReadOnlyDictionary(Of UIState, IView(Of SpriteIdentifier, HueIdentifier, Command)) =
        New Dictionary(Of UIState, IView(Of SpriteIdentifier, HueIdentifier, Command)) From
        {
            {UIState.Title, New TitleView}
        }
    Sub New()
        _world = New World()
    End Sub
    Public Sub OnUpdate(elapsed As TimeSpan) Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnUpdate
        _states(_state).OnUpdate(elapsed)
    End Sub
    Public Sub OnDraw(spriteRenderer As ISpriteRenderer(Of SpriteIdentifier, HueIdentifier)) Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnDraw
        _states(_state).OnDraw(spriteRenderer)
    End Sub
    Public Function OnCommand(command As Command) As CommandResult Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnCommand
        Return _states(_state).OnCommand(command)
    End Function
End Class
