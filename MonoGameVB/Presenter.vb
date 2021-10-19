Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input
Public Class Presenter
    Inherits Game
    Private _configuration As ApplicationConfiguration
    Private _viewState As IView(Of SpriteIdentifier, HueIdentifier)
    Private _spriteRenderer As ISpriteRenderer(Of SpriteIdentifier, HueIdentifier)
    Private _graphics As GraphicsDeviceManager
    Private _spriteBatch As SpriteBatch
    Private _keyboardState As KeyboardState
    Private _gamePadState As GamePadState
    Private _textureManager As ITextureManager(Of TextureIdentifier)
    Private _spriteManager As ISpriteManager(Of SpriteIdentifier, TextureIdentifier)
    Sub New(configuration As ApplicationConfiguration, viewState As IView(Of SpriteIdentifier, HueIdentifier))
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
        _spriteRenderer = New SpriteRenderer(_textureManager, _spriteManager, HueSources, _spriteBatch)
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
        Dim commands As New HashSet(Of Command)
        AccumulateKeyCommands(commands)
        AccumulateGamePadCommands(commands)
        Dim shouldExit As Boolean = False
        For Each command In commands
            If _viewState.OnCommand(command) = CommandResult.HALT Then
                shouldExit = True
                Exit For
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
        _spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied, SamplerState.PointClamp)
        _viewState.OnDraw(_spriteRenderer)
        _spriteBatch.End()
        MyBase.Draw(gameTime)
    End Sub
End Class
