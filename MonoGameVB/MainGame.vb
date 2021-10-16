Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input
Public Enum TextureType
    BEER
    MONK
    NUMERALS
End Enum
Public Class MainGame
    Inherits Game

    Const SCREEN_WIDTH = 1280
    Const SCREEN_HEIGHT = 720
    Const COLLIDE_DISTANCE = 16
    Const NUMERAL_WIDTH = 16
    Const NUMERAL_HEIGHT = 16

    Dim monkPosition As New Vector2(0, 0)
    Dim beerPosition As Vector2
    Dim score As Integer = 0
    Const monkSpeedPerTick As Single = 0.000025
    ReadOnly minimumPosition As New Vector2(0, 0)
    ReadOnly maximumPosition As New Vector2(SCREEN_WIDTH - 32, SCREEN_HEIGHT - 32)

    Dim _graphics As GraphicsDeviceManager
    Dim _spriteBatch As SpriteBatch
    Dim _textures As New Dictionary(Of TextureType, Texture2D)
    Dim _random As New Random()

    Sub SpawnBeer()
        beerPosition.X = _random.NextDouble() * (maximumPosition.X - minimumPosition.X)
        beerPosition.Y = _random.NextDouble() * (maximumPosition.Y - minimumPosition.Y)
    End Sub

    Sub New()
        _graphics = New GraphicsDeviceManager(Me)
        Content.RootDirectory = "Content"
        Content.Dispose()
    End Sub

    Protected Overrides Sub Initialize()
        _graphics.PreferredBackBufferWidth = SCREEN_WIDTH
        _graphics.PreferredBackBufferHeight = SCREEN_HEIGHT
        _graphics.ApplyChanges()
        MyBase.Initialize()
    End Sub

    Protected Overrides Sub LoadContent()
        Window.Title = "Doing Stuff! In a Monastery!!"
        _spriteBatch = New SpriteBatch(GraphicsDevice)
        _textures(TextureType.BEER) = Texture2D.FromFile(GraphicsDevice, "beer-bottle-32.png")
        _textures(TextureType.MONK) = Texture2D.FromFile(GraphicsDevice, "monk-face-32.png")
        _textures(TextureType.NUMERALS) = Texture2D.FromFile(GraphicsDevice, "numerals.png")
        SpawnBeer()
        MyBase.LoadContent()
    End Sub

    Protected Overrides Sub UnloadContent()
        MyBase.UnloadContent()
    End Sub

    Protected Overrides Sub Update(gameTime As GameTime)
        If GamePad.GetState(PlayerIndex.One).Buttons.Back = ButtonState.Pressed OrElse Keyboard.GetState().IsKeyDown(Keys.Escape) Then
            [Exit]()
        ElseIf Keyboard.GetState().IsKeyDown(Keys.Down) Then
            monkPosition.Y += monkSpeedPerTick * gameTime.ElapsedGameTime.Ticks
        ElseIf Keyboard.GetState().IsKeyDown(Keys.Up) Then
            monkPosition.Y -= monkSpeedPerTick * gameTime.ElapsedGameTime.Ticks
        ElseIf Keyboard.GetState().IsKeyDown(Keys.Right) Then
            monkPosition.X += monkSpeedPerTick * gameTime.ElapsedGameTime.Ticks
        ElseIf Keyboard.GetState().IsKeyDown(Keys.Left) Then
            monkPosition.X -= monkSpeedPerTick * gameTime.ElapsedGameTime.Ticks
        End If
        If monkPosition.X < minimumPosition.X Then
            monkPosition.X = minimumPosition.X
        End If
        If monkPosition.Y < minimumPosition.Y Then
            monkPosition.Y = minimumPosition.Y
        End If
        If monkPosition.X > maximumPosition.X Then
            monkPosition.X = maximumPosition.X
        End If
        If monkPosition.Y > maximumPosition.Y Then
            monkPosition.Y = maximumPosition.Y
        End If
        If Vector2.Distance(monkPosition, beerPosition) < COLLIDE_DISTANCE Then
            score += 1
            SpawnBeer()
        End If
        MyBase.Update(gameTime)
    End Sub

    Private ReadOnly numeralTiles As New Dictionary(Of Char, Rectangle) From
    {
        {"0"c, New Rectangle(NUMERAL_WIDTH * 0, 0, NUMERAL_WIDTH, NUMERAL_HEIGHT)},
        {"1"c, New Rectangle(NUMERAL_WIDTH * 1, 0, NUMERAL_WIDTH, NUMERAL_HEIGHT)},
        {"2"c, New Rectangle(NUMERAL_WIDTH * 2, 0, NUMERAL_WIDTH, NUMERAL_HEIGHT)},
        {"3"c, New Rectangle(NUMERAL_WIDTH * 3, 0, NUMERAL_WIDTH, NUMERAL_HEIGHT)},
        {"4"c, New Rectangle(NUMERAL_WIDTH * 4, 0, NUMERAL_WIDTH, NUMERAL_HEIGHT)},
        {"5"c, New Rectangle(NUMERAL_WIDTH * 5, 0, NUMERAL_WIDTH, NUMERAL_HEIGHT)},
        {"6"c, New Rectangle(NUMERAL_WIDTH * 6, 0, NUMERAL_WIDTH, NUMERAL_HEIGHT)},
        {"7"c, New Rectangle(NUMERAL_WIDTH * 7, 0, NUMERAL_WIDTH, NUMERAL_HEIGHT)},
        {"8"c, New Rectangle(NUMERAL_WIDTH * 8, 0, NUMERAL_WIDTH, NUMERAL_HEIGHT)},
        {"9"c, New Rectangle(NUMERAL_WIDTH * 9, 0, NUMERAL_WIDTH, NUMERAL_HEIGHT)}
    }

    Private Sub DrawScore()
        Dim scoreText = score.ToString()
        Dim xy As New Vector2(0, 0)
        For Each character In scoreText
            _spriteBatch.Draw(_textures(TextureType.NUMERALS), xy, numeralTiles(character), Color.Green)
            xy.X += NUMERAL_WIDTH
        Next
    End Sub

    Protected Overrides Sub Draw(gameTime As GameTime)

        GraphicsDevice.Clear(Color.Black)

        _spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.NonPremultiplied)

        _spriteBatch.Draw(_textures(TextureType.BEER), beerPosition, Color.White)
        _spriteBatch.Draw(_textures(TextureType.MONK), monkPosition, Color.White)
        DrawScore()

        _spriteBatch.End()

        MyBase.Draw(gameTime)
    End Sub
End Class
