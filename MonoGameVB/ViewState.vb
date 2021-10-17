Imports Microsoft.Xna.Framework.Graphics

Public Class ViewState
    Implements IViewState
    Public Sub OnLoadContent() Implements IViewState.OnLoadContent
    End Sub
    Public Sub OnUpdate(elapsed As TimeSpan) Implements IViewState.OnUpdate
    End Sub
    Public Sub OnDraw(spriteBatch As SpriteBatch) Implements IViewState.OnDraw
    End Sub
    Public Sub OnUnloadContent() Implements IViewState.OnUnloadContent
    End Sub
    Public Function OnCommands(command As Command) As Boolean Implements IViewState.OnCommand
        Return command <> Command.BACK
    End Function
End Class
