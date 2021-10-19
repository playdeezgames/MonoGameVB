Imports Microsoft.Xna.Framework.Graphics

Public Class MainView
    Implements IView
    Public Sub OnUpdate(elapsed As TimeSpan) Implements IView.OnUpdate
    End Sub
    Public Sub OnDraw(spriteBatch As SpriteBatch) Implements IView.OnDraw
    End Sub
    Public Function OnCommand(command As Command) As CommandResult Implements IView.OnCommand
        Select Case command
            Case Command.BACK
                Return CommandResult.HALT
            Case Else
                Return CommandResult.PROCEED
        End Select
    End Function
End Class
