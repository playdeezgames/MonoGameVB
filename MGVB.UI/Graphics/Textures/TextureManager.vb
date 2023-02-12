Friend Class TextureManager(Of TIdentifier)
    Implements ITextureManager(Of TIdentifier)
    Private _table As New Dictionary(Of TIdentifier, Texture2D)
    Private _sourceTable As Dictionary(Of TIdentifier, String)
    Private ReadOnly _graphicsDevice As GraphicsDevice

    Public Sub New(graphicsDevice As GraphicsDevice, sourceTable As Dictionary(Of TIdentifier, String))
        _graphicsDevice = graphicsDevice
        _sourceTable = sourceTable
    End Sub

    Public Function GetTexture(identifier As TIdentifier) As Texture2D Implements ITextureManager(Of TIdentifier).GetTexture
        If Not _table.ContainsKey(identifier) Then
            _table(identifier) = Texture2D.FromFile(_graphicsDevice, _sourceTable(identifier))
        End If
        Return _table(identifier)
    End Function
End Class
