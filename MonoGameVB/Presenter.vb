Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input
Public Class Presenter
    Inherits Game
    Dim _configuration As ApplicationConfiguration
    Dim _viewState As IViewState
    Dim _graphics As GraphicsDeviceManager
    Dim _spriteBatch As SpriteBatch
    Dim _keyboardState As KeyboardState
    Dim _gamePadState As GamePadState
    Dim _textureManager As ITextureManager(Of TextureIdentifier)
    Dim textureSources As New Dictionary(Of TextureIdentifier, String) From
        {
            {TextureIdentifier.BACKGROUND, "assets/images/background.png"},
            {TextureIdentifier.ROM_FONT_8X8, "assets/images/romfont8x8.png"}
        }
    Sub New(configuration As ApplicationConfiguration, viewState As IViewState)
        _configuration = configuration
        _viewState = viewState
        _graphics = New GraphicsDeviceManager(Me)
        Content.RootDirectory = "Content"
        Content.Dispose()
    End Sub
    Protected Overrides Sub Initialize()
        _graphics.PreferredBackBufferWidth = _configuration.Screen.Width
        _graphics.PreferredBackBufferHeight = _configuration.Screen.Height
        _graphics.IsFullScreen = _configuration.FullScreen
        _graphics.ApplyChanges()
        _keyboardState = Keyboard.GetState()
        _gamePadState = GamePad.GetState(PlayerIndex.One)
        MyBase.Initialize()
    End Sub

    Protected Overrides Sub LoadContent()
        Window.Title = _configuration.Title
        _textureManager = New TextureManager(Of TextureIdentifier)(GraphicsDevice, textureSources)
        _spriteBatch = New SpriteBatch(GraphicsDevice)
        _viewState.OnLoadContent()
        MyBase.LoadContent()
    End Sub
    Protected Overrides Sub UnloadContent()
        _viewState.OnUnloadContent()
        MyBase.UnloadContent()
    End Sub
    Private ReadOnly commandTable As New Dictionary(Of Keys, Command) From
        {
            {Keys.F4, Command.BACK},
            {Keys.F2, Command.START},
            {Keys.Up, Command.UP},
            {Keys.Down, Command.DOWN},
            {Keys.Left, Command.LEFT},
            {Keys.Right, Command.RIGHT},
            {Keys.Escape, Command.RED},
            {Keys.Space, Command.GREEN},
            {Keys.Enter, Command.BLUE},
            {Keys.Tab, Command.YELLOW},
            {Keys.OemPeriod, Command.NEXT},
            {Keys.OemComma, Command.PREVIOUS}
        }
    Private ReadOnly buttonTable As New Dictionary(Of Buttons, Command) From
        {
            {Buttons.A, Command.GREEN},
            {Buttons.B, Command.RED},
            {Buttons.Back, Command.BACK},
            {Buttons.DPadDown, Command.DOWN},
            {Buttons.DPadLeft, Command.LEFT},
            {Buttons.DPadUp, Command.UP},
            {Buttons.DPadRight, Command.RIGHT},
            {Buttons.Start, Command.START},
            {Buttons.LeftShoulder, Command.PREVIOUS},
            {Buttons.RightShoulder, Command.NEXT},
            {Buttons.X, Command.BLUE},
            {Buttons.Y, Command.YELLOW}
        }
    Protected Overrides Sub Update(gameTime As GameTime)
        Dim commands As New HashSet(Of Command)
        Dim keyboardState = Keyboard.GetState()
        For Each entry In commandTable
            If keyboardState.IsKeyDown(entry.Key) And Not _keyboardState.IsKeyDown(entry.Key) Then
                commands.Add(entry.Value)
            End If
        Next
        _keyboardState = keyboardState
        Dim gamePadState = GamePad.GetState(PlayerIndex.One)
        For Each entry In buttonTable
            If gamePadState.IsButtonDown(entry.Key) And Not _gamePadState.IsButtonDown(entry.Key) Then
                commands.Add(entry.Value)
            End If
        Next
        _gamePadState = gamePadState
        Dim shouldExit As Boolean = False
        For Each command In commands
            If Not _viewState.OnCommand(command) Then
                shouldExit = True
            End If
        Next
        If shouldExit Then
            [Exit]()
        Else
            _viewState.OnUpdate(gameTime.ElapsedGameTime)
        End If
        MyBase.Update(gameTime)
    End Sub
    Protected Overrides Sub Draw(gameTime As GameTime)
        GraphicsDevice.Clear(Color.Black)
        _spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.NonPremultiplied)
        _spriteBatch.Draw(_textureManager.GetTexture(TextureIdentifier.ROM_FONT_8X8), Vector2.Zero, Color.White)
        _viewState.OnDraw(_spriteBatch)
        _spriteBatch.End()
        MyBase.Draw(gameTime)
    End Sub
End Class
