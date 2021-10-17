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
        _textureManager = New TextureManager(Of TextureIdentifier)(GraphicsDevice, TextureSources)
        _spriteBatch = New SpriteBatch(GraphicsDevice)
        _viewState.OnLoadContent()
        MyBase.LoadContent()
    End Sub
    Protected Overrides Sub UnloadContent()
        _viewState.OnUnloadContent()
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
        _spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.NonPremultiplied)
        _spriteBatch.Draw(_textureManager.GetTexture(TextureIdentifier.ROM_FONT_8X8), Vector2.Zero, Color.White)
        _viewState.OnDraw(_spriteBatch)
        _spriteBatch.End()
        MyBase.Draw(gameTime)
    End Sub
End Class
