﻿Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input
Public Class Presenter
    Inherits Game
    Dim _configuration As ApplicationConfiguration
    Dim _viewState As IViewState
    Dim _graphics As GraphicsDeviceManager
    Dim _spriteBatch As SpriteBatch
    Dim _keyboardState As KeyboardState
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
        MyBase.Initialize()
    End Sub

    Protected Overrides Sub LoadContent()
        Window.Title = _configuration.Title
        _spriteBatch = New SpriteBatch(GraphicsDevice)
        _viewState.HandleLoadContent()
        MyBase.LoadContent()
    End Sub
    Protected Overrides Sub UnloadContent()
        _viewState.HandleUnloadContent()
        MyBase.UnloadContent()
    End Sub
    Protected Overrides Sub Update(gameTime As GameTime)
        Dim keyboardState = Keyboard.GetState()
        If Not _viewState.HandleKeyboard(_keyboardState, keyboardState) Then
            [Exit]()
        Else
            _keyboardState = keyboardState
            _viewState.HandleUpdate(gameTime)
        End If
        MyBase.Update(gameTime)
    End Sub
    Protected Overrides Sub Draw(gameTime As GameTime)
        GraphicsDevice.Clear(Color.Black)
        _spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.NonPremultiplied)
        _viewState.HandleDraw(_spriteBatch)
        _spriteBatch.End()
        MyBase.Draw(gameTime)
    End Sub
End Class
