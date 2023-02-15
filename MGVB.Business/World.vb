Public Class World
    Implements IWorld
    Private Data As WorldData
    Sub New()
        Data = New WorldData
        '1010 RM$(1)="in the hyper-sleep chamber of the NOSTROMO
        '1020 DATA0,0,0,9,0,0
        Data.Rooms(RoomIdentifier.Room1) = New RoomData With
            {
                .Description = "in the hyper-sleep chamber of the NOSTROMO",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction3, RoomIdentifier.Room9}
                }
            }

        '1030 RM$(2)="in the kitchen, standing by the auto-chef
        '1040 DATA0,0,27,0,0,0
        Data.Rooms(RoomIdentifier.Room2) = New RoomData With
            {
                .Description = "in the kitchen, standing by the auto-chef",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction2, RoomIdentifier.Room2}
                }
            }


        '1050 RM$(3)="in the BRIDGE CONTROL room":DATA27,0,0,0,0,0
        Data.Rooms(RoomIdentifier.Room3) = New RoomData With
            {
                .Description = "in the BRIDGE CONTROL room",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room27}
                }
            }

        '1060 RM$(4)="in the INFIRMARY, standing by the autodoc
        '1070 DATA0,0,0,27,0,0
        Data.Rooms(RoomIdentifier.Room4) = New RoomData With
            {
                .Description = "in the INFIRMARY, standing by the autodoc",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room27}
                }
            }

        '1080 RM$(5)="in the chamber next to the MAIN AIRLOCK
        '1090 DATA0,9,0,6,0,0
        Data.Rooms(RoomIdentifier.Room5) = New RoomData With
            {
                .Description = "in the chamber next to the MAIN AIRLOCK",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction1, RoomIdentifier.Room9},
                    {DirectionIdentifier.Direction3, RoomIdentifier.Room6}
                }
            }

        '1100 RM$(6)="in the MAIN AIRLOCK":DATA0,0,5,0,0,0
        Data.Rooms(RoomIdentifier.Room6) = New RoomData With
            {
                .Description = "in the MAIN AIRLOCK",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction2, RoomIdentifier.Room5}
                }
            }

        '1110 RM$(7)="on a platform outside the AIRLOCK
        '1120 DATA0,0,6,0,0,0
        Data.Rooms(RoomIdentifier.Room7) = New RoomData With
            {
                .Description = "on a platform outside the AIRLOCK",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction2, RoomIdentifier.Room6}
                }
            }

        '1130 RM$(8)="in a RESERVE SUPPLIES closet":DATA0,0,0,4,0,0
        Data.Rooms(RoomIdentifier.Room8) = New RoomData With
            {
                .Description = "in a RESERVE SUPPLIES closet",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction3, RoomIdentifier.Room4}
                }
            }

        '1140 RM$(9)="in the corridor outside the STORAGE ROOM
        '1150 DATA5,10,1,0,35,0
        Data.Rooms(RoomIdentifier.Room9) = New RoomData With
            {
                .Description = "in the corridor outside the STORAGE ROOM",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room5},
                    {DirectionIdentifier.Direction1, RoomIdentifier.Room10},
                    {DirectionIdentifier.Direction2, RoomIdentifier.Room1},
                    {DirectionIdentifier.Direction4, RoomIdentifier.Room35}
                }
            }

        '1160 RM$(10)="in the STORAGE ROOM":DATA9,11,0,0,0,0
        Data.Rooms(RoomIdentifier.Room10) = New RoomData With
            {
                .Description = "in the STORAGE ROOM",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room9},
                    {DirectionIdentifier.Direction1, RoomIdentifier.Room11}
                }
            }

        '1170 RM$(11)="inside the FOOD LOCKER":DATA10,0,0,0,0,0
        Data.Rooms(RoomIdentifier.Room11) = New RoomData With
            {
                .Description = "inside the FOOD LOCKER",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room10}
                }
            }

        '1180 RM$(12)="inside one of the air ducts":DATA12,12,13,12,0,11
        Data.Rooms(RoomIdentifier.Room12) = New RoomData With
            {
                .Description = "inside one of the air ducts",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room12},
                    {DirectionIdentifier.Direction1, RoomIdentifier.Room12},
                    {DirectionIdentifier.Direction2, RoomIdentifier.Room13},
                    {DirectionIdentifier.Direction3, RoomIdentifier.Room12},
                    {DirectionIdentifier.Direction5, RoomIdentifier.Room11}
                }
            }

        '1190 RM$(13)="in a narrow section of the air duct
        '1200 DATA13,13,13,12,13,14
        Data.Rooms(RoomIdentifier.Room13) = New RoomData With
            {
                .Description = "in a narrow section of the air duct",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room13},
                    {DirectionIdentifier.Direction1, RoomIdentifier.Room13},
                    {DirectionIdentifier.Direction2, RoomIdentifier.Room13},
                    {DirectionIdentifier.Direction3, RoomIdentifier.Room12},
                    {DirectionIdentifier.Direction4, RoomIdentifier.Room13},
                    {DirectionIdentifier.Direction5, RoomIdentifier.Room14}
                }
            }

        '1210 RM$(14)="at the A/B air duct junction":DATA0,14,12,0,13,15
        Data.Rooms(RoomIdentifier.Room14) = New RoomData With
            {
                .Description = "at the A/B air duct junction",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction1, RoomIdentifier.Room14},
                    {DirectionIdentifier.Direction2, RoomIdentifier.Room12},
                    {DirectionIdentifier.Direction4, RoomIdentifier.Room13},
                    {DirectionIdentifier.Direction5, RoomIdentifier.Room15}
                }
            }

        '1220 RM$(15)="in the A/B air duct crawlway":DATA0,0,0,0,14,0
        Data.Rooms(RoomIdentifier.Room15) = New RoomData With
            {
                .Description = "in the A/B air duct crawlway",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction4, RoomIdentifier.Room14}
                }
            }

        '1230 RM$(16)="in the ENGINEERING section":DATA0,33,17,0,0,0
        Data.Rooms(RoomIdentifier.Room16) = New RoomData With
            {
                .Description = "in the ENGINEERING section",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction1, RoomIdentifier.Room33},
                    {DirectionIdentifier.Direction2, RoomIdentifier.Room17}
                }
            }

        '1240 RM$(17)="in the REACTOR CONTROL room":DATA34,0,0,16,0,0
        Data.Rooms(RoomIdentifier.Room17) = New RoomData With
            {
                .Description = "in the REACTOR CONTROL room",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room34},
                    {DirectionIdentifier.Direction3, RoomIdentifier.Room16}
                }
            }

        '1250 RM$(18)="on the surface, outside the ship
        '1260 DATA19,0,0,0,0,0
        Data.Rooms(RoomIdentifier.Room18) = New RoomData With
            {
                .Description = "on the surface, outside the ship",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room19}
                }
            }

        '1270 RM$(19)="on the surface of a small planet
        '1280 DATA20,18,19,19,0,0
        Data.Rooms(RoomIdentifier.Room19) = New RoomData With
            {
                .Description = "on the surface of a small planet",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room20},
                    {DirectionIdentifier.Direction1, RoomIdentifier.Room18},
                    {DirectionIdentifier.Direction2, RoomIdentifier.Room19},
                    {DirectionIdentifier.Direction3, RoomIdentifier.Room19}
                }
            }

        '1290 RM$(20)=RM$(19):DATA22,19,20,20,0,0
        Data.Rooms(RoomIdentifier.Room20) = New RoomData With
            {
                .Description = "on the surface of a small planet",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room22},
                    {DirectionIdentifier.Direction1, RoomIdentifier.Room19},
                    {DirectionIdentifier.Direction2, RoomIdentifier.Room20},
                    {DirectionIdentifier.Direction3, RoomIdentifier.Room20}
                }
            }

        '1300 RM$(21)="in a hole":DATA0,0,0,0,20,0
        Data.Rooms(RoomIdentifier.Room21) = New RoomData With
            {
                .Description = "in a hole",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction5, RoomIdentifier.Room20}
                }
            }

        '1310 RM$(22)="standing outside an ALIEN ship":DATA0,20,23,0,0,0
        Data.Rooms(RoomIdentifier.Room22) = New RoomData With
            {
                .Description = "standing outside an ALIEN ship",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction1, RoomIdentifier.Room20},
                    {DirectionIdentifier.Direction2, RoomIdentifier.Room23}
                }
            }

        '1320 RM$(23)="inside what seems to be an open airlock
        '1330 DATA0,0,24,22,0,0
        Data.Rooms(RoomIdentifier.Room23) = New RoomData With
            {
                .Description = "inside what seems to be an open airlock",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction2, RoomIdentifier.Room24},
                    {DirectionIdentifier.Direction3, RoomIdentifier.Room22}
                }
            }

        '1340 RM$(24)="in a slimy, long dark corridor":DATA25,0,0,23,0,0
        Data.Rooms(RoomIdentifier.Room24) = New RoomData With
            {
                .Description = "in a slimy, long dark corridor",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room25},
                    {DirectionIdentifier.Direction3, RoomIdentifier.Room23}
                }
            }

        '1350 RM$(25)="at a dead end in front of a high wall
        '1360 DATA0,24,0,0,0,0
        Data.Rooms(RoomIdentifier.Room25) = New RoomData With
            {
                .Description = "at a dead end in front of a high wall",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction1, RoomIdentifier.Room24}
                }
            }

        '1370 RM$(26)="standing next to a HUGE skeleton of an alien
        '1380 DATA0,0,0,0,0,25
        Data.Rooms(RoomIdentifier.Room26) = New RoomData With
            {
                .Description = "standing next to a HUGE skeleton of an alien",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction5, RoomIdentifier.Room25}
                }
            }

        '1390 RM$(27)="at a junction of hallways":DATA37,3,4,2,36,35
        Data.Rooms(RoomIdentifier.Room27) = New RoomData With
            {
                .Description = "at a junction of hallways",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room37},
                    {DirectionIdentifier.Direction1, RoomIdentifier.Room3},
                    {DirectionIdentifier.Direction2, RoomIdentifier.Room4},
                    {DirectionIdentifier.Direction3, RoomIdentifier.Room2},
                    {DirectionIdentifier.Direction4, RoomIdentifier.Room36},
                    {DirectionIdentifier.Direction5, RoomIdentifier.Room35}
                }
            }

        '1400 RM$(28)="in a deeper hole":DATA0,0,0,0,0,0
        Data.Rooms(RoomIdentifier.Room28) = New RoomData With
            {
                .Description = "in a deeper hole",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier)
            }

        '1410 RM$(29)="in something like a storage hold":DATA0,0,0,0,0,0
        Data.Rooms(RoomIdentifier.Room29) = New RoomData With
            {
                .Description = "in something like a storage hold",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier)
            }

        '1420 RM$(30)="in the SHUTTLE AIRLOCK":DATA33,0,0,0,0,0
        Data.Rooms(RoomIdentifier.Room30) = New RoomData With
            {
                .Description = "in the SHUTTLE AIRLOCK",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room33}
                }
            }

        '1430 RM$(31)="in the EMERGENCY ESCAPE SHUTTLE":DATA30,0,0,0,0,0
        Data.Rooms(RoomIdentifier.Room31) = New RoomData With
            {
                .Description = "in the EMERGENCY ESCAPE SHUTTLE",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room30}
                }
            }

        '1440 RM$(32)="in the SHUTTLE SUIT LOCKER":DATA0,0,0,31,0,0
        Data.Rooms(RoomIdentifier.Room32) = New RoomData With
            {
                .Description = "in the SHUTTLE SUIT LOCKER",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction3, RoomIdentifier.Room31}
                }
            }

        '1450 RM$(33)="in a long straight hallway":DATA16,30,0,0,0,36
        Data.Rooms(RoomIdentifier.Room33) = New RoomData With
            {
                .Description = "in a long straight hallway",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction0, RoomIdentifier.Room16},
                    {DirectionIdentifier.Direction1, RoomIdentifier.Room30},
                    {DirectionIdentifier.Direction5, RoomIdentifier.Room36}
                }
            }

        '1460 RM$(34)="in the CLAW room, by the retracted landing legs
        '1470 DATA0,17,0,0,0,0
        Data.Rooms(RoomIdentifier.Room34) = New RoomData With
            {
                .Description = "in the CLAW room, by the retracted landing legs",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction1, RoomIdentifier.Room17}
                }
            }

        '1480 RM$(35)="in the A/B deck crawlway":DATA0,0,0,0,27,9
        Data.Rooms(RoomIdentifier.Room35) = New RoomData With
            {
                .Description = "in the A/B deck crawlway",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction4, RoomIdentifier.Room27},
                    {DirectionIdentifier.Direction5, RoomIdentifier.Room9}
                }
            }

        '1490 RM$(36)="in the B/C deck crawlway":DATA0,0,0,0,33,27
        Data.Rooms(RoomIdentifier.Room36) = New RoomData With
            {
                .Description = "in the B/C deck crawlway",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction4, RoomIdentifier.Room33},
                    {DirectionIdentifier.Direction5, RoomIdentifier.Room27}
                }
            }

        '1500 RM$(37)="in the MAIN COMPUTER room":DATA0,27,0,0,0,0
        Data.Rooms(RoomIdentifier.Room37) = New RoomData With
            {
                .Description = "in the MAIN COMPUTER room",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction1, RoomIdentifier.Room27}
                }
            }

        '1510 RM$(38)="in a UTILITY closet":DATA0,0,0,34,0,0
        Data.Rooms(RoomIdentifier.Room38) = New RoomData With
            {
                .Description = "in a UTILITY closet",
                .Exits = New Dictionary(Of DirectionIdentifier, RoomIdentifier) From
                {
                    {DirectionIdentifier.Direction3, RoomIdentifier.Room34}
                }
            }
    End Sub
End Class
