Public Class Presenter
    Inherits Game
    Private ReadOnly _configuration As ApplicationConfiguration
    Private ReadOnly _viewState As IView(Of SpriteIdentifier, HueIdentifier, Command)
    Private _spriteRenderer As ISpriteRenderer(Of SpriteIdentifier, HueIdentifier)
    Private ReadOnly _graphics As GraphicsDeviceManager
    Private _spriteBatch As SpriteBatch
    Private _keyboardState As KeyboardState
    Private _gamePadState As GamePadState
    Private _textureManager As ITextureManager(Of TextureIdentifier)
    Private _spriteManager As ISpriteManager(Of SpriteIdentifier)
    Sub New(configuration As ApplicationConfiguration, viewState As IView(Of SpriteIdentifier, HueIdentifier, Command))
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
        _textureManager = New TextureManager(Of TextureIdentifier)(GraphicsDevice, TextureSources)
        _spriteBatch = New SpriteBatch(GraphicsDevice)
        _spriteManager = New SpriteManager(Of SpriteIdentifier, TextureIdentifier)(SpriteSources)
        _spriteRenderer = New SpriteRenderer(Of SpriteIdentifier, HueIdentifier, TextureIdentifier)(_textureManager, _spriteManager, HueSources, _spriteBatch)
        MyBase.LoadContent()
    End Sub
    Protected Overrides Sub UnloadContent()
        MyBase.UnloadContent()
    End Sub
    Private Sub AccumulateKeyCommands(ByRef commands As HashSet(Of Command))
        Dim keyboardState = Keyboard.GetState()
        For Each entry In CommandsTable
            If keyboardState.IsKeyDown(entry.Key) And Not _keyboardState.IsKeyDown(entry.Key) Then
                commands.Add(entry.Value)
            End If
        Next
        _keyboardState = keyboardState
    End Sub
    Private Sub AccumulateGamePadCommands(ByRef commands As HashSet(Of Command))
        Dim gamePadState = GamePad.GetState(PlayerIndex.One)
        For Each entry In ButtonTable
            If gamePadState.IsButtonDown(entry.Key) And Not _gamePadState.IsButtonDown(entry.Key) Then
                commands.Add(entry.Value)
            End If
        Next
        _gamePadState = gamePadState
    End Sub
    Protected Overrides Sub Update(gameTime As GameTime)
        If ProcessInputs() Then
            _viewState.OnUpdate(gameTime.ElapsedGameTime)
            MyBase.Update(gameTime)
            Return
        End If
        [Exit]()
    End Sub

    Private Function ProcessInputs() As Boolean
        Dim commands As New HashSet(Of Command)
        AccumulateKeyCommands(commands)
        AccumulateGamePadCommands(commands)
        For Each command In commands
            If _viewState.OnCommand(command) = CommandResult.HALT Then
                Return False
            End If
        Next
        Return True
    End Function

    Protected Overrides Sub Draw(gameTime As GameTime)
        GraphicsDevice.Clear(Color.Black)
        _spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied, SamplerState.PointClamp)
        _viewState.OnDraw(_spriteRenderer)
        _spriteBatch.End()
        MyBase.Draw(gameTime)
    End Sub
End Class
