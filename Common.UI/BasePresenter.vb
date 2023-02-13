Public Class BasePresenter(Of TSpriteIdentifier, THueIdentifier, TTextureIdentifier, TCommand)
    Inherits Game
    Private ReadOnly _configuration As IApplicationConfiguration
    Private ReadOnly _viewState As IView(Of TSpriteIdentifier, THueIdentifier, TCommand)
    Private _spriteRenderer As ISpriteRenderer(Of TSpriteIdentifier, THueIdentifier)
    Private ReadOnly _graphics As GraphicsDeviceManager
    Private _spriteBatch As SpriteBatch
    Private _keyboardState As KeyboardState
    Private _gamePadState As GamePadState
    Private _textureManager As ITextureManager(Of TTextureIdentifier)
    Private _spriteManager As ISpriteManager(Of TSpriteIdentifier)
    Private ReadOnly _commandsTable As IReadOnlyDictionary(Of Keys, TCommand)
    Private ReadOnly _buttonTable As IReadOnlyDictionary(Of Buttons, TCommand)
    Private ReadOnly _spriteSources As IReadOnlyDictionary(Of TSpriteIdentifier, ISprite)
    Private ReadOnly _textureSources As IReadOnlyDictionary(Of TTextureIdentifier, String)
    Private ReadOnly _hueSources As IReadOnlyDictionary(Of THueIdentifier, Color)
    Sub New(
           configuration As IApplicationConfiguration,
           viewState As IView(Of TSpriteIdentifier, THueIdentifier, TCommand),
           commandsTable As IReadOnlyDictionary(Of Keys, TCommand),
           buttonTable As IReadOnlyDictionary(Of Buttons, TCommand),
           spriteSources As IReadOnlyDictionary(Of TSpriteIdentifier, ISprite),
           textureSources As IReadOnlyDictionary(Of TTextureIdentifier, String),
           hueSources As IReadOnlyDictionary(Of THueIdentifier, Color))
        _configuration = configuration
        _viewState = viewState
        _graphics = New GraphicsDeviceManager(Me)
        _commandsTable = commandsTable
        _buttonTable = buttonTable
        _spriteSources = spriteSources
        _textureSources = textureSources
        _hueSources = hueSources
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
        _textureManager = New TextureManager(Of TTextureIdentifier)(GraphicsDevice, _textureSources)
        _spriteBatch = New SpriteBatch(GraphicsDevice)
        _spriteManager = New SpriteManager(Of TSpriteIdentifier, TTextureIdentifier)(_spriteSources)
        _spriteRenderer = New SpriteRenderer(Of TSpriteIdentifier, THueIdentifier, TTextureIdentifier)(_textureManager, _spriteManager, _hueSources, _spriteBatch)
        MyBase.LoadContent()
    End Sub
    Protected Overrides Sub UnloadContent()
        MyBase.UnloadContent()
    End Sub
    Private Sub AccumulateKeyCommands(ByRef commands As HashSet(Of TCommand))
        Dim keyboardState = Keyboard.GetState()
        For Each entry In _commandsTable
            If keyboardState.IsKeyDown(entry.Key) And Not _keyboardState.IsKeyDown(entry.Key) Then
                commands.Add(entry.Value)
            End If
        Next
        _keyboardState = keyboardState
    End Sub
    Private Sub AccumulateGamePadCommands(ByRef commands As HashSet(Of TCommand))
        Dim gamePadState = GamePad.GetState(PlayerIndex.One)
        For Each entry In _buttonTable
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
        Dim commands As New HashSet(Of TCommand)
        AccumulateKeyCommands(commands)
        AccumulateGamePadCommands(commands)
        For Each entry In commands
            If _viewState.OnCommand(entry) = CommandResult.HALT Then
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
