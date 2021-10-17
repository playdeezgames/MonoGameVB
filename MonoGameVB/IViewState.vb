Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Interface IViewState
    Sub HandleLoadContent()
    Sub HandleUnloadContent()
    Function HandleKeyboard(oldState As KeyboardState, newState As KeyboardState) As Boolean
    Sub HandleUpdate(gameTime As GameTime)
    Sub HandleDraw(spriteBatch As SpriteBatch)
End Interface
