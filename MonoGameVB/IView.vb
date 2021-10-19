Imports Microsoft.Xna.Framework.Graphics

Public Interface IView(Of TSpriteIdentifier, THueIdentifier)
    Function OnCommand(command As Command) As CommandResult
    Sub OnUpdate(elapsed As TimeSpan)
    Sub OnDraw(spriteRenderer As ISpriteRenderer(Of TSpriteIdentifier, THueIdentifier))
End Interface
