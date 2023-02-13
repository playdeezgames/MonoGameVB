Friend Module ButtonCommands
    Friend ReadOnly ButtonTable As New Dictionary(Of Buttons, Command) From
        {
            {Buttons.A, Command.GREEN},
            {Buttons.B, Command.RED},
            {Buttons.Back, Command.BACK},
            {Buttons.DPadDown, Command.DOWN},
            {Buttons.DPadLeft, Command.LEFT},
            {Buttons.DPadUp, Command.UP},
            {Buttons.DPadRight, Command.RIGHT},
            {Buttons.Start, Command.START},
            {Buttons.LeftShoulder, Command.PREVIOUS},
            {Buttons.RightShoulder, Command.NEXT},
            {Buttons.X, Command.BLUE},
            {Buttons.Y, Command.YELLOW}
        }
End Module
