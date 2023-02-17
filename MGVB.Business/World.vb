Public Class World
    Implements IWorld
    Private Data As WorldData
    Sub New()
        Data = New WorldData
        InitializeRooms()
        InitializeNouns()
        InitializeVerbs()
        InitializeObjects()
    End Sub

    Private Sub InitializeObjects()
        '4010 OB$(1)="CAT":OB$(2)="HYPER-SLEEP POD":OB$(3)="LADDER"
        '4020 DATA 10,7,0, 0,9,1, 0,15,36
        Data.Objects(ObjectIdentifier.Object1) = New ObjectData With
            {
                .Name = "CAT",
                .Score = 10,
                .Noun = NounIdentifier.Noun7,
                .Room = Nothing
            }
        Data.Objects(ObjectIdentifier.Object2) = New ObjectData With
            {
                .Name = "HYPER-SLEEP POD",
                .Score = 0,
                .Noun = NounIdentifier.Noun9,
                .Room = RoomIdentifier.Room1
            }
        Data.Objects(ObjectIdentifier.Object3) = New ObjectData With
            {
                .Name = "LADDER",
                .Score = 0,
                .Noun = NounIdentifier.Noun15,
                .Room = RoomIdentifier.Room36
            }


        '4030 OB$(4)="SMALL ALIEN":OB$(5)="HUGE ALIEN":OB$(6)="TRACKER"
        '4040 DATA 0,8,0, 0,8,0, 0,11,34
        Data.Objects(ObjectIdentifier.Object4) = New ObjectData With
            {
                .Name = "SMALL ALIEN",
                .Score = 0,
                .Noun = NounIdentifier.Noun8,
                .Room = Nothing
            }
        Data.Objects(ObjectIdentifier.Object5) = New ObjectData With
            {
                .Name = "HUGE ALIEN",
                .Score = 0,
                .Noun = NounIdentifier.Noun8
            }
        Data.Objects(ObjectIdentifier.Object6) = New ObjectData With
            {
                .Name = "TRACKER",
                .Score = 0,
                .Noun = NounIdentifier.Noun11,
                .Room = RoomIdentifier.Room34
            }


        '4050 OB$(7)="EXAMINATION TABLE":OB$(8)="MICROSCOPE"
        '4060 DATA 0,12,4, 0,14,4
        Data.Objects(ObjectIdentifier.Object7) = New ObjectData With
            {
                .Name = "EXAMINATION TABLE",
                .Score = 0,
                .Noun = NounIdentifier.Noun12,
                .Room = RoomIdentifier.Room4
            }
        Data.Objects(ObjectIdentifier.Object8) = New ObjectData With
            {
                .Name = "MICROSCOPE",
                .Score = 0,
                .Noun = NounIdentifier.Noun14,
                .Room = RoomIdentifier.Room4
            }

        '4070 OB$(9)="ORGANIC OVOID":OB$(10)="LADDER":OB$(11)="TABLE"
        '4080 DATA 0,13,29, 0,15,35, 0,14,2
        Data.Objects(ObjectIdentifier.Object9) = New ObjectData With
            {
                .Name = "ORGANIC OVOID",
                .Score = 0,
                .Noun = NounIdentifier.Noun13,
                .Room = RoomIdentifier.Room29
            }
        Data.Objects(ObjectIdentifier.Object10) = New ObjectData With
            {
                .Name = "LADDER",
                .Score = 0,
                .Noun = NounIdentifier.Noun15,
                .Room = RoomIdentifier.Room35
            }
        Data.Objects(ObjectIdentifier.Object11) = New ObjectData With
            {
                .Name = "TABLE",
                .Score = 0,
                .Noun = NounIdentifier.Noun12,
                .Room = RoomIdentifier.Room2
            }

        '4090 OB$(12)="OPEN ORGANIC OVOID":OB$(13)="BATTERY PACK"
        '4100 DATA 0,13,0, 0,37,8
        Data.Objects(ObjectIdentifier.Object12) = New ObjectData With
            {
                .Name = "OPEN ORGANIC OVOID",
                .Score = 0,
                .Noun = NounIdentifier.Noun13,
                .Room = Nothing
            }
        Data.Objects(ObjectIdentifier.Object13) = New ObjectData With
            {
                .Name = "BATTERY PACK",
                .Score = 0,
                .Noun = NounIdentifier.Noun37,
                .Room = RoomIdentifier.Room8
            }

        '4110 OB$(14)="BUTTON":OB$(15)="VIEWPORT":OB$(16)="BUTTON"
        '4120 DATA 0,17,6, 0,27,3, 0,17,17
        Data.Objects(ObjectIdentifier.Object14) = New ObjectData With
            {
                .Name = "BUTTON",
                .Score = 0,
                .Noun = NounIdentifier.Noun17,
                .Room = RoomIdentifier.Room6
            }
        Data.Objects(ObjectIdentifier.Object15) = New ObjectData With
            {
                .Name = "VIEWPORT",
                .Score = 0,
                .Noun = NounIdentifier.Noun27,
                .Room = RoomIdentifier.Room3
            }
        Data.Objects(ObjectIdentifier.Object16) = New ObjectData With
            {
                .Name = "BUTTON",
                .Score = 0,
                .Noun = NounIdentifier.Noun17,
                .Room = RoomIdentifier.Room17
            }

        '4130 OB$(17)="FLAMETHROWER":OB$(18)="OXYGEN"
        '4140 DATA 0,21,16, 10,23,6
        Data.Objects(ObjectIdentifier.Object17) = New ObjectData With
            {
                .Name = "FLAMETHROWER",
                .Score = 0,
                .Noun = NounIdentifier.Noun21,
                .Room = RoomIdentifier.Room16
            }
        Data.Objects(ObjectIdentifier.Object18) = New ObjectData With
            {
                .Name = "OXYGEN",
                .Score = 10,
                .Noun = NounIdentifier.Noun23,
                .Room = RoomIdentifier.Room6
            }

        '4150 OB$(19)="ANOTHER HOLE":OB$(20)="COMPUTER CONSOLE"
        '4160 DATA 0,18,0, 0,36,37
        Data.Objects(ObjectIdentifier.Object19) = New ObjectData With
            {
                .Name = "ANOTHER HOLE",
                .Score = 0,
                .Noun = NounIdentifier.Noun18,
                .Room = Nothing
            }
        Data.Objects(ObjectIdentifier.Object20) = New ObjectData With
            {
                .Name = "COMPUTER CONSOLE",
                .Score = 0,
                .Noun = NounIdentifier.Noun36,
                .Room = RoomIdentifier.Room37
            }

        '4170 OB$(21)="SPACE SUIT":OB$(22)="CAT FOOD"
        '4180 DATA 0,30,32, 0,26,11
        Data.Objects(ObjectIdentifier.Object21) = New ObjectData With
            {
                .Name = "SPACE SUIT",
                .Score = 0,
                .Noun = NounIdentifier.Noun30,
                .Room = RoomIdentifier.Room32
            }
        Data.Objects(ObjectIdentifier.Object22) = New ObjectData With
            {
                .Name = "CAT FOOD",
                .Score = 0,
                .Noun = NounIdentifier.Noun26,
                .Room = RoomIdentifier.Room11
            }

        '4190 OB$(23)="FUEL":OB$(24)="CONTROL CONSOLE"
        '4200 DATA 10,24,10, 0,36,31
        Data.Objects(ObjectIdentifier.Object23) = New ObjectData With
            {
                .Name = "FUEL",
                .Score = 10,
                .Noun = NounIdentifier.Noun24,
                .Room = RoomIdentifier.Room10
            }
        Data.Objects(ObjectIdentifier.Object24) = New ObjectData With
            {
                .Name = "CONTROL CONSOLE",
                .Score = 0,
                .Noun = NounIdentifier.Noun36,
                .Room = RoomIdentifier.Room31
            }

        '4210 OB$(25)="OPEN DOOR":OB$(26)="CLOSED DOOR":OB$(27)="SHOVEL"
        '4220 DATA 0,31,0, 0,31,6, 0,33,38
        Data.Objects(ObjectIdentifier.Object25) = New ObjectData With
            {
                .Name = "OPEN DOOR",
                .Score = 0,
                .Noun = NounIdentifier.Noun31,
                .Room = Nothing
            }
        Data.Objects(ObjectIdentifier.Object26) = New ObjectData With
            {
                .Name = "CLOSED DOOR",
                .Score = 0,
                .Noun = NounIdentifier.Noun31,
                .Room = RoomIdentifier.Room6
            }
        Data.Objects(ObjectIdentifier.Object27) = New ObjectData With
            {
                .Name = "SHOVEL",
                .Score = 0,
                .Noun = NounIdentifier.Noun33,
                .Room = RoomIdentifier.Room38
            }

        '4230 OB$(28)="LOCKER":OB$(29)="* DIAMOND *"
        '4240 DATA 0,20,31, 10,43,21
        Data.Objects(ObjectIdentifier.Object28) = New ObjectData With
            {
                .Name = "LOCKER",
                .Score = 0,
                .Noun = NounIdentifier.Noun20,
                .Room = RoomIdentifier.Room31
            }
        Data.Objects(ObjectIdentifier.Object29) = New ObjectData With
            {
                .Name = "* DIAMOND *",
                .Score = 10,
                .Noun = NounIdentifier.Noun43,
                .Room = RoomIdentifier.Room21
            }

        '4250 OB$(30)="* RARE ALIEN JEWEL *":OB$(31)="* ALIEN BOOK *"
        '4270 OB$(32)="* ALIEN EXPLOSIVE *"
        '4280 OB$(33)="* ALIEN TELEPORTER *"
        '4290 OB$(34)="* MAP OF UNIVERSE! *"
        '4260 DATA 10,40,26, 10,39,0, 10,41,29, 10,44,28, 10,42,0
        Data.Objects(ObjectIdentifier.Object30) = New ObjectData With
            {
                .Name = "* RARE ALIEN JEWEL *",
                .Score = 10,
                .Noun = NounIdentifier.Noun40,
                .Room = RoomIdentifier.Room26
            }
        Data.Objects(ObjectIdentifier.Object31) = New ObjectData With
            {
                .Name = "* ALIEN BOOK *",
                .Score = 10,
                .Noun = NounIdentifier.Noun39,
                .Room = Nothing
            }
        Data.Objects(ObjectIdentifier.Object32) = New ObjectData With
            {
                .Name = "* ALIEN EXPLOSIVE *",
                .Score = 10,
                .Noun = NounIdentifier.Noun41,
                .Room = RoomIdentifier.Room29
            }
        Data.Objects(ObjectIdentifier.Object33) = New ObjectData With
            {
                .Name = "* ALIEN TELEPORTER *",
                .Score = 10,
                .Noun = NounIdentifier.Noun44,
                .Room = RoomIdentifier.Room28
            }
        Data.Objects(ObjectIdentifier.Object34) = New ObjectData With
            {
                .Name = "* MAP OF UNIVERSE! *",
                .Score = 10,
                .Noun = NounIdentifier.Noun42,
                .Room = Nothing
            }

        '4300 OB$(35)="PORTABLE WINCH & ROPE":
        '4330 DATA 0,34,10,
        Data.Objects(ObjectIdentifier.Object35) = New ObjectData With
            {
                .Name = "PORTABLE WINCH & ROPE",
                .Score = 0,
                .Noun = NounIdentifier.Noun34,
                .Room = RoomIdentifier.Room10
            }

        '4301 OB$(36)="CLOSET"
        '4331 DATA 0,25,34,
        Data.Objects(ObjectIdentifier.Object36) = New ObjectData With
            {
                .Name = "CLOSET",
                .Score = 0,
                .Noun = NounIdentifier.Noun25,
                .Room = RoomIdentifier.Room34
            }

        '4305 OB$(37)="CLOSET"
        '4332 DATA 0,25,0,
        Data.Objects(ObjectIdentifier.Object37) = New ObjectData With
            {
                .Name = "CLOSET",
                .Score = 0,
                .Noun = NounIdentifier.Noun25,
                .Room = Nothing
            }

        '4310 OB$(38)="DEEP HOLE"
        '4333 DATA 0,18,26,
        Data.Objects(ObjectIdentifier.Object38) = New ObjectData With
            {
                .Name = "DEEP HOLE",
                .Score = 0,
                .Noun = NounIdentifier.Noun18,
                .Room = RoomIdentifier.Room26
            }

        '4311 OB$(39)="HOLE"
        '4334 DATA 0,18,0,
        Data.Objects(ObjectIdentifier.Object39) = New ObjectData With
            {
                .Name = "HOLE",
                .Score = 0,
                .Noun = NounIdentifier.Noun18,
                .Room = Nothing
            }

        '4312 OB$(40)="HOLE IN WALL"
        '4335 DATA 0,18,0,
        Data.Objects(ObjectIdentifier.Object40) = New ObjectData With
            {
                .Name = "HOLE IN WALL",
                .Score = 0,
                .Noun = NounIdentifier.Noun18,
                .Room = Nothing
            }

        '4320 OB$(41)="AUTOMATIC HATCH"
        '4336 DATA 0,45,31
        Data.Objects(ObjectIdentifier.Object41) = New ObjectData With
            {
                .Name = "AUTOMATIC HATCH",
                .Score = 0,
                .Noun = NounIdentifier.Noun38,
                .Room = RoomIdentifier.Room31
            }
    End Sub

    Private Sub InitializeVerbs()
        '3010 VB$(1)="N":VB$(2)="S":VB$(3)="E":VB$(4)="W":VB$(5)="U"
        Data.Verbs(VerbIdentifier.Verb1) = "N"
        Data.Verbs(VerbIdentifier.Verb2) = "S"
        Data.Verbs(VerbIdentifier.Verb3) = "E"
        Data.Verbs(VerbIdentifier.Verb4) = "W"
        Data.Verbs(VerbIdentifier.Verb5) = "U"

        '3020 VB$(6)="D":VB$(7)="CON":VB$(8)="DRO":VB$(9)="SUI"
        Data.Verbs(VerbIdentifier.Verb6) = "D"
        Data.Verbs(VerbIdentifier.Verb7) = "CONNECT"
        Data.Verbs(VerbIdentifier.Verb8) = "DROP"
        Data.Verbs(VerbIdentifier.Verb9) = "SUIT"

        '3030 VB$(10)="SHO":VB$(11)="KIL":VB$(12)="SAY":VB$(13)="I"
        Data.Verbs(VerbIdentifier.Verb10) = "SHOVEL"
        Data.Verbs(VerbIdentifier.Verb11) = "KILL"
        Data.Verbs(VerbIdentifier.Verb12) = "SAY"
        Data.Verbs(VerbIdentifier.Verb13) = "I"

        '3040 VB$(14)="PRE":VB$(15)="PUL":VB$(16)="PUS":VB$(17)="EXA"
        Data.Verbs(VerbIdentifier.Verb14) = "PRE"
        Data.Verbs(VerbIdentifier.Verb15) = "PUL"
        Data.Verbs(VerbIdentifier.Verb16) = "PUS"
        Data.Verbs(VerbIdentifier.Verb17) = "EXA"

        '3050 VB$(18)="OPE":VB$(19)="GO":VB$(20)="CLI":VB$(21)="JUM"
        Data.Verbs(VerbIdentifier.Verb18) = "OPEN"
        Data.Verbs(VerbIdentifier.Verb19) = "GO"
        Data.Verbs(VerbIdentifier.Verb20) = "CLIMB"
        Data.Verbs(VerbIdentifier.Verb21) = "JUMP"

        '3060 VB$(22)="GET":VB$(23)="LOO":VB$(24)="SAV":VB$(25)="LOA"
        Data.Verbs(VerbIdentifier.Verb22) = "GET"
        Data.Verbs(VerbIdentifier.Verb23) = "LOOK"
        Data.Verbs(VerbIdentifier.Verb24) = "SAVE"
        Data.Verbs(VerbIdentifier.Verb25) = "LOAD"

        '3070 VB$(26)="DIG":VB$(27)="STA"::VB$(28)="HEL":VB$(29)="SCO"
        Data.Verbs(VerbIdentifier.Verb26) = "DIG"
        Data.Verbs(VerbIdentifier.Verb27) = "STA"
        Data.Verbs(VerbIdentifier.Verb28) = "HEL"
        Data.Verbs(VerbIdentifier.Verb29) = "SCO"

        '3080 VB$(30)="QUI":VB$(31)="FIR":VB$(32)="TAK":VB$(33)="PUT"
        Data.Verbs(VerbIdentifier.Verb30) = "QUIT"
        Data.Verbs(VerbIdentifier.Verb31) = "FIR"
        Data.Verbs(VerbIdentifier.Verb32) = "TAKE"
        Data.Verbs(VerbIdentifier.Verb33) = "PUT"

        '3090 VB$(34)="ENT"
        Data.Verbs(VerbIdentifier.Verb34) = "ENTER"
    End Sub

    Private Sub InitializeNouns()
        '2010 NO$(1)="NORTH":NO$(2) = "SOUTH" : NO$(3) = "EAST" : NO$(4) = "WEST"
        Data.Nouns(NounIdentifier.Noun1) = "NORTH"
        Data.Nouns(NounIdentifier.Noun2) = "SOUTH"
        Data.Nouns(NounIdentifier.Noun3) = "EAST"
        Data.Nouns(NounIdentifier.Noun4) = "WEST"

        '2020 NO$(5)="UP":NO$(6) = "DOWN" : NO$(7) = "CAT" : NO$(8) = "ALI"
        Data.Nouns(NounIdentifier.Noun5) = "UP"
        Data.Nouns(NounIdentifier.Noun6) = "DOWN"
        Data.Nouns(NounIdentifier.Noun7) = "CAT"
        Data.Nouns(NounIdentifier.Noun8) = "ALIEN"

        '2030 NO$(9)="POD":NO$(10) = "SKE" : NO$(11) = "TRA" : NO$(12) = "TAB"
        Data.Nouns(NounIdentifier.Noun9) = "POD"
        Data.Nouns(NounIdentifier.Noun10) = "SKELETON"
        Data.Nouns(NounIdentifier.Noun11) = "TRACKER"
        Data.Nouns(NounIdentifier.Noun12) = "TABLE"

        '2040 NO$(13)="OVO":NO$(14) = "MIC" : NO$(15) = "LAD" : NO$(16) = "LEV"
        Data.Nouns(NounIdentifier.Noun13) = "OVOID"
        Data.Nouns(NounIdentifier.Noun14) = "MICROSCOPE"
        Data.Nouns(NounIdentifier.Noun15) = "LADDER"
        Data.Nouns(NounIdentifier.Noun16) = "LEVER"

        '2050 NO$(17)="BUT":NO$(18) = "HOL" : NO$(19) = "SHU" : NO$(20) = "LOC"
        Data.Nouns(NounIdentifier.Noun17) = "BUTTON"
        Data.Nouns(NounIdentifier.Noun18) = "HOLE"
        Data.Nouns(NounIdentifier.Noun19) = "SHUTTLE"
        Data.Nouns(NounIdentifier.Noun20) = "LOCKER"

        '2060 NO$(21)="FLA":NO$(22) = "PLA" : NO$(23) = "OXY" : NO$(24) = "FUE"
        Data.Nouns(NounIdentifier.Noun21) = "FLAMETHROWER"
        Data.Nouns(NounIdentifier.Noun22) = "PLATFORM"
        Data.Nouns(NounIdentifier.Noun23) = "OXYGEN"
        Data.Nouns(NounIdentifier.Noun24) = "FUEL"

        '2070 NO$(25)="CLO":NO$(26) = "FOO" : NO$(27) = "VIE" : NO$(28) = "WAL"
        Data.Nouns(NounIdentifier.Noun25) = "CLOSET"
        Data.Nouns(NounIdentifier.Noun26) = "FOOD"
        Data.Nouns(NounIdentifier.Noun27) = "VIEWPORT"
        Data.Nouns(NounIdentifier.Noun28) = "WALL"

        '2080 NO$(29)="REA":NO$(30) = "SUI" : NO$(31) = "DOO" : NO$(32) = "COM"
        Data.Nouns(NounIdentifier.Noun29) = "REACTOR"
        Data.Nouns(NounIdentifier.Noun30) = "SUIT"
        Data.Nouns(NounIdentifier.Noun31) = "DOOR"
        Data.Nouns(NounIdentifier.Noun32) = "COMPUTER"

        '2090 NO$(33)="SHO":NO$(34) = "WIN" : NO$(35) = "ROP" : NO$(36) = "CON"
        Data.Nouns(NounIdentifier.Noun33) = "SHOVEL"
        Data.Nouns(NounIdentifier.Noun34) = "WINCH"
        Data.Nouns(NounIdentifier.Noun35) = "ROPE"
        Data.Nouns(NounIdentifier.Noun36) = "CONSOLE"

        '2100 NO$(37)="PAC":NO$(38) = "HAT" : NO$(39) = "BOO" : NO$(40) = "JEW"
        Data.Nouns(NounIdentifier.Noun37) = "PACK"
        Data.Nouns(NounIdentifier.Noun38) = "HATCH"
        Data.Nouns(NounIdentifier.Noun39) = "BOOK"
        Data.Nouns(NounIdentifier.Noun40) = "JEWEL"

        '2110 NO$(41)="EXP":NO$(42) = "MAP" : NO$(43) = "DIA" : NO$(44) = "TEL"
        Data.Nouns(NounIdentifier.Noun41) = "EXPLOSIVE"
        Data.Nouns(NounIdentifier.Noun42) = "MAP"
        Data.Nouns(NounIdentifier.Noun43) = "DIAMOND"
        Data.Nouns(NounIdentifier.Noun44) = "TELEPORTER"
    End Sub

    Private Sub InitializeRooms()
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
