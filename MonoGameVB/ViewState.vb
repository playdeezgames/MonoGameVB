Imports Microsoft.Xna.Framework.Graphics

Public Class ViewState
    Implements IViewState
    Public Sub OnUpdate(elapsed As TimeSpan) Implements IViewState.OnUpdate
    End Sub
    Public Sub OnDraw(spriteBatch As SpriteBatch) Implements IViewState.OnDraw
    End Sub
    Public Function OnCommand(command As Command) As CommandResult Implements IViewState.OnCommand
        Select Case command
            Case Command.BACK
                Return CommandResult.HALT
            Case Else
                Return CommandResult.PROCEED
        End Select
    End Function
End Class
