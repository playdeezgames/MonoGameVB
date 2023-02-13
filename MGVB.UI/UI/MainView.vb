Friend Class MainView
    Implements IView(Of SpriteIdentifier, HueIdentifier, Command)
    Public Sub OnUpdate(elapsed As TimeSpan) Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnUpdate
    End Sub
    Public Sub OnDraw(spriteRenderer As ISpriteRenderer(Of SpriteIdentifier, HueIdentifier)) Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnDraw
        Dim text = "SOFTSIDE Presents"
        Dim x = 0
        Dim y = 0
        For Each c In text
            spriteRenderer.Draw(LetterSource(c), New XY(Of Integer)(x, y), HueIdentifier.RED)
            x += 8
        Next
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
