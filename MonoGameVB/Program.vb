Module Program
    <STAThread>
    Sub Main(args As String())
        Using game As New MainGame()
            game.Run()
        End Using
    End Sub
End Module

