Friend Class MainView
    Implements IView(Of SpriteIdentifier, HueIdentifier, Command)
    Public Sub OnUpdate(elapsed As TimeSpan) Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnUpdate
    End Sub
    Public Sub OnDraw(spriteRenderer As ISpriteRenderer(Of SpriteIdentifier, HueIdentifier)) Implements IView(Of SpriteIdentifier, HueIdentifier, Command).OnDraw
        WriteText(spriteRenderer, 0, 0, "SOFTSIDE Presents", HueIdentifier.RED)
        WriteText(spriteRenderer, 0, 8, """ALIEN"" Adventure", HueIdentifier.RED)
        WriteText(spriteRenderer, 0, 16, "WRITTEN By Alan J. Zett", HueIdentifier.RED)
        WriteText(spriteRenderer, 0, 24, "PORTED By TheGrumpyGameDev", HueIdentifier.RED)
    End Sub

    Private Sub WriteText(spriteRenderer As ISpriteRenderer(Of SpriteIdentifier, HueIdentifier), x As Integer, y As Integer, text As String, hue As HueIdentifier)
        For Each c In text
            spriteRenderer.Draw(LetterSource(c), New XY(Of Integer)(x, y), hue)
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
