Imports Microsoft.Xna.Framework.Graphics

Public Interface IView
    Function OnCommand(command As Command) As CommandResult
    Sub OnUpdate(elapsed As TimeSpan)
    Sub OnDraw(spriteBatch As SpriteBatch)
End Interface
