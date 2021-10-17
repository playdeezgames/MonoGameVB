Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class ViewState
    Implements IViewState
    Public Sub HandleLoadContent() Implements IViewState.HandleLoadContent
    End Sub
    Public Sub HandleUpdate(gameTime As GameTime) Implements IViewState.HandleUpdate
    End Sub
    Public Sub HandleDraw(spriteBatch As SpriteBatch) Implements IViewState.HandleDraw
    End Sub
    Public Sub HandleUnloadContent() Implements IViewState.HandleUnloadContent
    End Sub
    Public Function HandleKeyboard(oldState As KeyboardState, newState As KeyboardState) As Boolean Implements IViewState.HandleKeyboard
        If newState.IsKeyDown(Keys.Escape) Then
            Return False
        End If
        Return True
    End Function
End Class
