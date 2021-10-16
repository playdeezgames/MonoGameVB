Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input
Public Enum TextureType
    BEER
    MONK
End Enum
Public Class MainGame
    Inherits Game

    Const CELL_WIDTH As Single = 32
    Const CELL_HEIGHT As Single = 32

    Dim monkPosition As New Vector2(0, 0)

    Dim _graphics As GraphicsDeviceManager
    Dim _spriteBatch As SpriteBatch
    Dim _textures As New Dictionary(Of TextureType, Texture2D)

    Sub New()
        _graphics = New GraphicsDeviceManager(Me)
        Content.RootDirectory = "Content"
        Content.Dispose()
    End Sub

    Protected Overrides Sub Initialize()
        _graphics.PreferredBackBufferWidth = 1280
        _graphics.PreferredBackBufferHeight = 720
        _graphics.ApplyChanges()
        MyBase.Initialize()
    End Sub

    Protected Overrides Sub LoadContent()
        Window.Title = "YerMom"
        _spriteBatch = New SpriteBatch(GraphicsDevice)
        _textures(TextureType.BEER) = Texture2D.FromFile(GraphicsDevice, "beer-bottle-32.png")
        _textures(TextureType.MONK) = Texture2D.FromFile(GraphicsDevice, "monk-face-32.png")
        MyBase.LoadContent()
    End Sub

    Protected Overrides Sub UnloadContent()
        MyBase.UnloadContent()
    End Sub

    Protected Overrides Sub Update(gameTime As GameTime)
        If GamePad.GetState(PlayerIndex.One).Buttons.Back = ButtonState.Pressed OrElse Keyboard.GetState().IsKeyDown(Keys.Escape) Then
            [Exit]()
        ElseIf Keyboard.GetState().IsKeyDown(Keys.Down) Then
            monkPosition.Y += 1
        ElseIf Keyboard.GetState().IsKeyDown(Keys.Up) Then
            monkPosition.Y -= 1
        ElseIf Keyboard.GetState().IsKeyDown(Keys.Right) Then
            monkPosition.X += 1
        ElseIf Keyboard.GetState().IsKeyDown(Keys.Left) Then
            monkPosition.X -= 1
        End If

        MyBase.Update(gameTime)
    End Sub

    Protected Overrides Sub Draw(gameTime As GameTime)

        GraphicsDevice.Clear(Color.Black)

        _spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.NonPremultiplied)

        Dim xy As New Vector2(monkPosition.X * CELL_WIDTH, monkPosition.Y * CELL_HEIGHT)

        _spriteBatch.Draw(_textures(TextureType.MONK), xy, Color.White)
        _spriteBatch.End()

        MyBase.Draw(gameTime)
    End Sub
End Class
