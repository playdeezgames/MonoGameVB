Imports Microsoft.Xna.Framework.Graphics

Public Interface IViewState
    Function OnCommand(command As Command) As CommandResult
    Sub OnUpdate(elapsed As TimeSpan)
    Sub OnDraw(spriteBatch As SpriteBatch)
End Interface
