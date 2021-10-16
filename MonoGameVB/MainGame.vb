Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input
Public Class MainGame
    Inherits Game

    Dim _graphics As GraphicsDeviceManager
    Dim _spriteBatch As SpriteBatch

    Sub New()
        _graphics = New GraphicsDeviceManager(Me)
        Content.RootDirectory = "Content"
        Content.Dispose()
    End Sub

    Protected Overrides Sub Initialize()
        MyBase.Initialize()
    End Sub

    Protected Overrides Sub LoadContent()
        _spriteBatch = New SpriteBatch(GraphicsDevice)
        MyBase.LoadContent()
    End Sub

    Protected Overrides Sub UnloadContent()
        MyBase.UnloadContent()
    End Sub

    Protected Overrides Sub Update(gameTime As GameTime)
        If GamePad.GetState(PlayerIndex.One).Buttons.Back = ButtonState.Pressed OrElse Keyboard.GetState().IsKeyDown(Keys.Escape) Then
            [Exit]()
        End If

        MyBase.Update(gameTime)
    End Sub

    Protected Overrides Sub Draw(gameTime As GameTime)

        GraphicsDevice.Clear(Color.Black)

        _spriteBatch.Begin()

        _spriteBatch.End()

        MyBase.Draw(gameTime)
    End Sub
End Class
