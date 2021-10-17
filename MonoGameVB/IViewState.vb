﻿Imports Microsoft.Xna.Framework.Graphics

Public Interface IViewState
    Sub OnLoadContent()
    Sub OnUnloadContent()
    Function OnCommand(command As Command) As Boolean
    Sub OnUpdate(elapsed As TimeSpan)
    Sub OnDraw(spriteBatch As SpriteBatch)
End Interface
