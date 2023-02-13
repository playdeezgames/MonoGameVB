Public Class MainView
    Implements IView(Of SpriteIdentifier, HueIdentifier, Command)
    Public Sub OnUpdate(elapsed As TimeSpan) Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnUpdate
    End Sub
    Public Sub OnDraw(spriteRenderer As ISpriteRenderer(Of SpriteIdentifier, HueIdentifier)) Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnDraw
        spriteRenderer.Draw(SpriteIdentifier.CHARACTER_40, New XY(Of Integer)(0, 0), HueIdentifier.RED)
    End Sub
    Public Function OnCommand(command As Command) As CommandResult Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnCommand
        Select Case command
            Case Command.BACK
                Return CommandResult.HALT
            Case Else
                Return CommandResult.PROCEED
        End Select
    End Function
End Class
