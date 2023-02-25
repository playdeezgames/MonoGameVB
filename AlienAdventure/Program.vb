Imports System.Drawing
Imports System.Linq.Expressions

Module Program
    Dim Q As Integer = -1
    Dim V As Integer = 0
    Dim TC As Integer = V
    Dim L As Integer = V
    Dim AR As Integer = V
    Dim TH As Integer = Q
    Dim SA As Integer = Q
    Dim HA As Integer = Q
    Dim R As Integer = 1
    Dim OB As Integer = 41
    Dim TS As Integer = V
    Dim RE As Integer = Q
    Dim LP As Integer = Q
    Dim [AS] As Integer = Q
    Dim PR As Integer = V
    Dim OB_(,) As Integer = {
                {0, 0, 0},'there is no object 0
                {10, 7, 0},
                {0, 9, 1},
                {0, 15, 36},
                {0, 8, 0},
                {0, 8, 0},
                {0, 11, 34},
                {0, 12, 4},
                {0, 14, 4},
                {0, 13, 29},
                {0, 15, 35},
                {0, 14, 2},
                {0, 13, 0},
                {0, 37, 8},
                {0, 17, 6},
                {0, 27, 3},
                {0, 17, 17},
                {0, 21, 16},
                {10, 23, 6},
                {0, 18, 0},
                {0, 36, 37},
                {0, 30, 32},
                {0, 26, 11},
                {10, 24, 10},
                {0, 36, 31},
                {0, 31, 0},
                {0, 31, 6},
                {0, 33, 38},
                {0, 20, 31},
                {10, 43, 21},
                {10, 40, 26},
                {10, 39, 0},
                {10, 41, 29},
                {10, 44, 28},
                {10, 42, 0},
                {0, 34, 10},
                {0, 25, 34},
                {0, 25, 0},
                {0, 18, 26},
                {0, 18, 0},
                {0, 18, 0},
                {0, 45, 31}
            }
    Dim RM_(,) As Integer =
            {
                {0, 0, 0, 0, 0, 0},'RM=0 is blank, because we start with 1!
                {0, 0, 0, 9, 0, 0},
                {0, 0, 27, 0, 0, 0},
                {27, 0, 0, 0, 0, 0},
                {0, 0, 0, 27, 0, 0},
                {0, 9, 0, 6, 0, 0},
                {0, 0, 5, 0, 0, 0},
                {0, 0, 6, 0, 0, 0},
                {0, 0, 0, 4, 0, 0},
                {5, 10, 1, 0, 35, 0},
                {9, 11, 0, 0, 0, 0},
                {10, 0, 0, 0, 0, 0},
                {12, 12, 13, 12, 0, 11},
                {13, 13, 13, 12, 13, 14},
                {0, 14, 12, 0, 13, 15},
                {0, 0, 0, 0, 14, 0},
                {0, 33, 17, 0, 0, 0},
                {34, 0, 0, 16, 0, 0},
                {19, 0, 0, 0, 0, 0},
                {20, 18, 19, 19, 0, 0},
                {22, 19, 20, 20, 0, 0},
                {0, 0, 0, 0, 20, 0},
                {0, 20, 23, 0, 0, 0},
                {0, 0, 24, 22, 0, 0},
                {25, 0, 0, 23, 0, 0},
                {0, 24, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 25},
                {37, 3, 4, 2, 36, 35},
                {0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0},
                {33, 0, 0, 0, 0, 0},
                {30, 0, 0, 0, 0, 0},
                {0, 0, 0, 31, 0, 0},
                {16, 30, 0, 0, 0, 36},
                {0, 17, 0, 0, 0, 0},
                {0, 0, 0, 0, 27, 9},
                {0, 0, 0, 0, 33, 27},
                {0, 27, 0, 0, 0, 0},
                {0, 0, 0, 34, 0, 0}
            }
    Sub Main(args As String())
Label1:
        AnsiConsole.Clear()
        Dim A_s As String = "================================"
        AnsiConsole.MarkupLine("
" + A_s + "
SOFTSIDE Presents")
        AnsiConsole.MarkupLine(A_s & "
" + Chr(34) + "ALIEN" + Chr(34) + " Adventure")
        AnsiConsole.MarkupLine(A_s + "
WRITTEN By Alan J. Zett")
        AnsiConsole.MarkupLine(A_s)

Label10:
        A_s = ""
        Dim NO_s = ""
        Dim VB_s = ""
        Dim CH_s = Chr(30)
        Dim PR = V
        Dim N = V
        Dim AO = Q
        Dim SO = Q
        Dim OL = V
        Dim PD = Q
        Dim PP = Q
        Dim RD = Q
        Dim FS = 9
        Dim OC = V
        Dim RO = V
        Dim TMP = V
        Dim A = V
        Dim RF = Q
        Dim DF = Q
        Dim RC = Q
        Dim H1 = Q
        Dim H2 = Q
        Dim SL = Q
        Dim SC = Q
        Dim Z = V
        Dim I = 640

        Dim RM = 38
        Dim RM_s(RM) As String
        RM_s(1) = "in the hyper-sleep chamber of the NOSTROMO"
        RM_s(2) = "in the kitchen, standing by the auto-chef"
        RM_s(3) = "in the BRIDGE CONTROL room"
        RM_s(4) = "in the INFIRMARY, standing by the autodoc"
        RM_s(5) = "in the chamber next to the MAIN AIRLOCK"
        RM_s(6) = "in the MAIN AIRLOCK"
        RM_s(7) = "on a platform outside the AIRLOCK"
        RM_s(8) = "in a RESERVE SUPPLIES closet"
        RM_s(9) = "in the corridor outside the STORAGE ROOM"
        RM_s(10) = "in the STORAGE ROOM"
        RM_s(11) = "inside the FOOD LOCKER"
        RM_s(12) = "inside one of the air ducts"
        RM_s(13) = "in a narrow section of the air duct"
        RM_s(14) = "at the A/B air duct junction"
        RM_s(15) = "in the A/B air duct crawlway"
        RM_s(16) = "in the ENGINEERING section"
        RM_s(17) = "in the REACTOR CONTROL room"
        RM_s(18) = "on the surface, outside the ship"
        RM_s(19) = "on the surface of a small planet"
        RM_s(20) = RM_s(19)
        RM_s(21) = "in a hole"
        RM_s(22) = "standing outside an ALIEN ship"
        RM_s(23) = "inside what seems to be an open airlock"
        RM_s(24) = "in a slimy, long dark corridor"
        RM_s(25) = "at a dead end in front of a high wall"
        RM_s(26) = "standing next to a HUGE skeleton of an alien"
        RM_s(27) = "at a junction of hallways"
        RM_s(28) = "in a deeper hole"
        RM_s(29) = "in something like a storage hold"
        RM_s(30) = "in the SHUTTLE AIRLOCK"
        RM_s(31) = "in the EMERGENCY ESCAPE SHUTTLE"
        RM_s(32) = "in the SHUTTLE SUIT LOCKER"
        RM_s(33) = "in a long straight hallway"
        RM_s(34) = "in the CLAW room, by the retracted landing legs"
        RM_s(35) = "in the A/B deck crawlway"
        RM_s(36) = "in the B/C deck crawlway"
        RM_s(37) = "in the MAIN COMPUTER room"
        RM_s(38) = "in a UTILITY closet"

        Dim NO = 44
        Dim NO_sa(NO) As String
        NO_sa(1) = "NORTH" : NO_sa(2) = "SOUTH" : NO_sa(3) = "EAST" : NO_sa(4) = "WEST"
        NO_sa(5) = "UP" : NO_sa(6) = "DOWN" : NO_sa(7) = "CAT" : NO_sa(8) = "ALI"
        NO_sa(9) = "POD" : NO_sa(10) = "SKE" : NO_sa(11) = "TRA" : NO_sa(12) = "TAB"
        NO_sa(13) = "OVO" : NO_sa(14) = "MIC" : NO_sa(15) = "LAD" : NO_sa(16) = "LEV"
        NO_sa(17) = "BUT" : NO_sa(18) = "HOL" : NO_sa(19) = "SHU" : NO_sa(20) = "LOC"
        NO_sa(21) = "FLA" : NO_sa(22) = "PLA" : NO_sa(23) = "OXY" : NO_sa(24) = "FUE"
        NO_sa(25) = "CLO" : NO_sa(26) = "FOO" : NO_sa(27) = "VIE" : NO_sa(28) = "WAL"
        NO_sa(29) = "REA" : NO_sa(30) = "SUI" : NO_sa(31) = "DOO" : NO_sa(32) = "COM"
        NO_sa(33) = "SHO" : NO_sa(34) = "WIN" : NO_sa(35) = "ROP" : NO_sa(36) = "CON"
        NO_sa(37) = "PAC" : NO_sa(38) = "HAT" : NO_sa(39) = "BOO" : NO_sa(40) = "JEW"
        NO_sa(41) = "EXP" : NO_sa(42) = "MAP" : NO_sa(43) = "DIA" : NO_sa(44) = "TEL"
        Dim VB = 34
        Dim VB_sa(VB) As String
        VB_sa(1) = "N" : VB_sa(2) = "S" : VB_sa(3) = "E" : VB_sa(4) = "W" : VB_sa(5) = "U"
        VB_sa(6) = "D" : VB_sa(7) = "CON" : VB_sa(8) = "DRO" : VB_sa(9) = "SUI"
        VB_sa(10) = "SHO" : VB_sa(11) = "KIL" : VB_sa(12) = "SAY" : VB_sa(13) = "I"
        VB_sa(14) = "PRE" : VB_sa(15) = "PUL" : VB_sa(16) = "PUS" : VB_sa(17) = "EXA"
        VB_sa(18) = "OPE" : VB_sa(19) = "GO" : VB_sa(20) = "CLI" : VB_sa(21) = "JUM"
        VB_sa(22) = "GET" : VB_sa(23) = "LOO" : VB_sa(24) = "SAV" : VB_sa(25) = "LOA"
        VB_sa(26) = "DIG" : VB_sa(27) = "STA" : VB_sa(28) = "HEL" : VB_sa(29) = "SCO"
        VB_sa(30) = "QUI" : VB_sa(31) = "FIR" : VB_sa(32) = "TAK" : VB_sa(33) = "PUT"
        VB_sa(34) = "ENT"

        Dim OB_sa(OB) As String
        OB_sa(1) = "CAT" : OB_sa(2) = "HYPER-SLEEP POD" : OB_sa(3) = "LADDER"
        OB_sa(4) = "SMALL ALIEN" : OB_sa(5) = "HUGE ALIEN" : OB_sa(6) = "TRACKER"
        OB_sa(7) = "EXAMINATION TABLE" : OB_sa(8) = "MICROSCOPE"
        OB_sa(9) = "ORGANIC OVOID" : OB_sa(10) = "LADDER" : OB_sa(11) = "TABLE"
        OB_sa(12) = "OPEN ORGANIC OVOID" : OB_sa(13) = "BATTERY PACK"
        OB_sa(14) = "BUTTON" : OB_sa(15) = "VIEWPORT" : OB_sa(16) = "BUTTON"
        OB_sa(17) = "FLAMETHROWER" : OB_sa(18) = "OXYGEN"
        OB_sa(19) = "ANOTHER HOLE" : OB_sa(20) = "COMPUTER CONSOLE"
        OB_sa(21) = "SPACE SUIT" : OB_sa(22) = "CAT FOOD"
        OB_sa(23) = "FUEL" : OB_sa(24) = "CONTROL CONSOLE"
        OB_sa(25) = "OPEN DOOR" : OB_sa(26) = "CLOSED DOOR" : OB_sa(27) = "SHOVEL"
        OB_sa(28) = "LOCKER" : OB_sa(29) = "* DIAMOND *"
        OB_sa(30) = "* RARE ALIEN JEWEL *" : OB_sa(31) = "* ALIEN BOOK *"
        OB_sa(32) = "* ALIEN EXPLOSIVE *"
        OB_sa(33) = "* ALIEN TELEPORTER *"
        OB_sa(34) = "* MAP OF UNIVERSE! *"
        OB_sa(35) = "PORTABLE WINCH & ROPE" : OB_sa(36) = "CLOSET"
        OB_sa(38) = "DEEP HOLE" : OB_sa(39) = "HOLE" : OB_sa(40) = "HOLE IN WALL"
        OB_sa(41) = "AUTOMATIC HATCH" : OB_sa(37) = OB_sa(36)

        Dim M0_s = "I don't see it here!"
        Dim M1_s = "I can't go that way!"
        Dim M2_s = "I don't understand what you mean!"
        Dim M3_s = "I can't do that... YET!"
        Dim M5_s = "I'm carrying:"
        Dim M4_s = "I can't carry any more! DROP something!"
        Dim M6_s = "I can't go anywhere with the ROPE attached to me!"
        Dim M7_s = "I'm not carrying it!"
        Dim M8_s = "The cat scrambled for the exit!"
        Dim M9_s = "There's no room left to DROP anything!"
        Dim N0_s = "I see nothing special"
        Dim N1_s = "Nothing happened"
        Dim N2_s = "There's a warning light on it"

        Dim prompt As New SelectionPrompt(Of String) With {.Title = "Skill Level:"}
        prompt.AddChoices("Advanced", "Average", "Beginner")
        Select Case AnsiConsole.Prompt(prompt)
            Case "Advanced"
                OL = 80
            Case "Average"
                OL = 160
            Case "Beginner"
                OL = 240
        End Select

Label20:
        AnsiConsole.MarkupLine(M3_s)
        GoTo Label140

Label30:
        AnsiConsole.Clear()
        AnsiConsole.MarkupLine($"I'm{RM_s(R)}")
        A_s = ""

Label40:
        If TH = 0 Then
            If OB_(1, 2) > 0 Then
                OB_(1, 2) = 15
                OB_(40, 2) = 11
                TH = 1
            Else
                OB_(40, 2) = 11
            End If
        End If
Label50:
        Z = -1
        RO = 0
        For A = 1 To OB
            If OB_(A, 2) = R Then
                RO = RO + 1
            Else
                GoTo Label90
            End If
Label60:
            If Z <> 0 Then
                Z = 0
                AnsiConsole.MarkupLine("Visible items:")
                A_s = OB_sa(A)
                AnsiConsole.WriteLine()
                GoTo Label90
            End If
Label70:
            If A_s.Length + 4 + OB_sa(A).Length > 60 Then
                AnsiConsole.MarkupLine(A_s)
                A_s = OB_sa(A)
                GoTo Label90
            End If
Label80:
            A_s = A_s + "    " + OB_sa(A)
Label90:
        Next
        If A_s <> "" Then
            AnsiConsole.MarkupLine(A_s)
        End If
Label95:
        If AR = R AndAlso HA = -1 Then HA = 1
label100:
        AnsiConsole.WriteLine()
        AnsiConsole.Markup("       Some obvious exits: ")
        Z = -1
        For A = 0 To 5
label110:
            If RM_(R, A) > 0 Then
                Z = 0
                AnsiConsole.Markup($"{NO_sa(A + 1)} ")
            End If
        Next
Label120:
        If Z <> 0 Then
            AnsiConsole.MarkupLine(" THERE AREN'T ANY!!")
        End If

        Gosub130()
Label140:
        OB_(5, 2) = AR
        A_s = ""
        TC = TC + 1
        If SO = 0 Then
            AnsiConsole.Markup($"There's enough air in the suit for {OL} moves")
            OL = OL - 1
            If OL < 0 Then
                LP = -1
                GoTo Label670
            End If
        End If
Label150:
        If AO = 0 Then
            If SO = -1 Then
                GoTo Label670
            End If
        End If
Label160:
        If RD <> -1 Then
            If RD = TC Then
                AnsiConsole.Clear()
                AnsiConsole.MarkupLine("BOOM!!!  The reactor EXPLODED!! There's NOTHING LEFT OF ME!!")
                AnsiConsole.WriteLine()
                GoTo Label700
            Else
                AnsiConsole.Markup($"{RD - TC} Moves till reactor goes critical!")
            End If
        End If
Label170:
        Gosub780()
        If HA = 0 Or SA = 0 Then
            SO = 1
            GoTo Label670
        Else
            If AR = R And HA = -1 Then
                GoTo Label30
            Else
                Gosub750()
                A_s = AnsiConsole.Ask(Of String)("  ========> Tell me what to do")
                If PR = R And [AS] = 0 And AR <> R Then
                    AR = R
                    OB_(5, 2) = AR
                    GoTo Label30
                Else
                    PR = R
                End If
            End If
        End If
Label180:
        For A = 1 To Len(A_s)
            If Mid(A_s, A, 1) = " "c Then
                GoTo Label180A
            End If
        Next
        VB_s = A_s
        NO_s = ""
        GoTo Label180Z
Label180A:
        VB_s = Left(A_s, A - 1)
        For A = A To Len(A_s)
            If Mid(A_s, A, 1) <> " "c Then
                GoTo Label180C
            End If
        Next
        NO_s = ""
        GoTo Label180Z
Label180C:
        NO_s = Right(A_s, Len(A_s) - (A - 1))
Label180Z:
Label190:
        V = 0
        For A = 1 To VB
            If Left(VB_s, 3) = VB_sa(A) Then
                V = A
                Exit For
            End If
        Next
Label200:
        N = 0
        For A = 1 To NO
            If Left(NO_s, 3) = Left(NO_sa(A), 3) Then
                N = A
                Exit For
            End If
        Next
Label210:
        If N = 0 And V = 0 And VB_s = "" Then
            AnsiConsole.MarkupLine(M2_s)
            GoTo Label140
        End If
Label220:
        If V = 0 Then
            AnsiConsole.MarkupLine($"I don't know how to '{VB_s}' something")
            GoTo Label140
        End If
Label230:
        If R <> 21 Then
            If RC = 0 Then
                If V < 7 Then
                    If OB_(35, 2) <> -1 Then
                        AnsiConsole.MarkupLine(M6_s)
                        GoTo Label140
                    Else
                        GoTo Label240
                    End If
                Else
                    If V = 19 Or V = 20 Then
                        If N < 7 Then
                            AnsiConsole.MarkupLine(M6_s)
                            GoTo Label140
                        End If
                    End If
                End If
            End If
        End If
Label240:
        If V < 7 Then
            If R = 5 And (N = 4 Or V = 4) And OB_(1, 2) = -1 Then
                AnsiConsole.MarkupLine("SPCA HERE: YOU CAN'T TAKE THAT CAT OUT THE AIRLOCK!!")
                GoTo Label140
            End If
        Else
            If LP = 0 And V = 1 Then
                GoTo Label670
            Else
                If RM_(R, V - 1) <> 0 Then
                    R = RM_(R, V - 1)
                    GoTo Label30
                Else
                    AnsiConsole.MarkupLine(M1_s)
                    GoTo Label140
                End If
            End If
        End If
Label250:
        If (N = 0 And ((V < 23 And (V <> 12 And V <> 13)) Or (V > 25 And V < 28) Or V > 30)) Then
            If NO_s = "" Then
                AnsiConsole.MarkupLine("Please be more specific!")
                GoTo Label140
            Else
                AnsiConsole.MarkupLine($"I don't know what a '{NO_s}' is!")
                GoTo Label140
            End If
        End If
Label260:
        If V <> 19 And V <> 34 Then
            GoTo Label320
        Else
            If N < 7 Then
                V = N
                GoTo Label240
            Else
                If N = 19 Then
                    If R <> 30 Then
                        GoTo Label20
                    Else
                        R = 31
                        GoTo Label30
                    End If
                End If
            End If
        End If
Label270:
        If N = 22 Then
            If R = 18 Then
                If PD = 0 Then
                    R = 7
                    GoTo Label30
                Else
                    AnsiConsole.MarkupLine("OH NO! I can't reach it!")
                    GoTo Label140
                End If
            Else
                GoTo Label20
            End If
        End If
Label280:
        If N = 20 Then
            If R <> 31 Then
                GoTo Label20
            Else
                If SL = 0 Then
                    R = 32
                    GoTo Label30
                Else
                    GoTo Label20
                End If
            End If
        End If
Label290:
        If N = 25 Then
            If R <> 4 And R <> 34 Then
                GoTo Label20
            Else
                If R = 4 Then
                    If SC = 0 Then
                        R = 8
                        GoTo Label30
                    Else
                        GoTo Label20
                    End If
                Else
                    R = 38
                    GoTo Label30
                End If
            End If
        End If
Label300:
        If N = 18 Then
            If R <> 20 And R <> 26 And R <> 21 And R <> 11 Then
                GoTo Label20
            Else
                If R = 20 Then
                    If H1 = 0 Then
                        R = 21
                        GoTo Label30
                    Else GoTo Label20
                    End If
                Else
                    If R = 21 Then
                        If H2 = 0 Then
                            R = 28
                            GoTo Label30
                        Else
                            GoTo Label20
                        End If
                    Else
                        If R = 11 Then
                            If TH > -1 Then
                                R = 12
                                GoTo Label30
                            Else
                                GoTo Label20
                            End If
                        Else
                            If RC <> 0 Then
                                DF = 0
                                GoTo Label670
                            Else
                                R = 29
                                GoTo Label30
                            End If
                        End If
                    End If
                End If
            End If
        End If
Label310:
        If N = 31 Then
            If R = 6 And AO = 0 Then
                R = 7
                GoTo Label30
            Else
                GoTo Label20
            End If
        Else
            AnsiConsole.MarkupLine(M2_s)
            GoTo Label140
        End If
Label320:
        If V = 8 Or V = 33 Then
            If N = 7 And TH = 0 Then
                AnsiConsole.MarkupLine(M8_s)
                OB_(1, 2) = 15
                GoTo Label140
            Else
                If RO > 6 Then
                    AnsiConsole.MarkupLine(M9_s)
                    GoTo Label140
                Else
                    If OB_(21, 2) = -1 And SO = 0 And N = 30 Then
                        SO = -1
                        OB_(21, 2) = R
                        OC = OC - 1
                        GoTo Label30
                    Else
                        For A = 1 To OB
                            If OB_(A, 1) = N Then
                                If OB_(A, 2) = -1 Then
                                    OB_(A, 2) = R
                                    OC = OC - 1
                                    GoTo Label30
                                Else
                                    AnsiConsole.MarkupLine(M7_s)
                                    GoTo Label140
                                End If
                            End If
                        Next
                    End If
                End If
            End If
        End If
Label330:
        If V <> 22 And V <> 32 Then
            GoTo Label350
        Else
            If N <> 7 And N <> 11 And N <> 21 And N <> 23 And N <> 24 And N <> 26 And N <> 30 And N <> 33 And N <> 34 And (N < 37 Or N = 38) Then
                AnsiConsole.MarkupLine("THAT'S IMPOSSIBLE!")
                GoTo Label140
            Else
                For A = 1 To OB
                    If OB_(A, 1) = N Then
                        If OB_(A, 2) <> R Then
                            AnsiConsole.MarkupLine(M0_s)
                            GoTo Label140
                        Else
Label340:
                            If (OC + 1) > 5 Then
                                AnsiConsole.MarkupLine(M4_s)
                                GoTo Label140
                            Else
                                OC = OC + 1
                                OB_(A, 2) = -1
                                If N = 7 Then
                                    If R = 15 Then
                                        TH = 0
                                    End If
                                End If
                                GoTo Label30
                            End If
                        End If
                    End If
                Next
            End If
        End If
Label350:
        If V = 13 Then
            A_s = ""
            AnsiConsole.Markup(M5_s)
            TMP = -1
            For A = 1 To OB
                If OB_(A, 2) = -1 Then
                    If Len(A_s) + 4 + Len(OB_sa(A)) > 50 Then
                        AnsiConsole.MarkupLine(A_s)
                        A_s = OB_sa(A)
                        Continue For
                    Else
                        A_s = A_s & "    " & OB_sa(A)
                        TMP = TMP + 1
                        Continue For
                    End If
                End If
            Next
            If A_s <> "" Then
                AnsiConsole.MarkupLine(A_s)
                GoTo Label140
            End If
        End If
Label360:
        If V = 13 And TMP = -1 Then
            AnsiConsole.MarkupLine("    NOTHING!")
            GoTo Label140
        End If
Label370:
        If V = 29 Then
            Gosub720()
            GoTo Label140
        Else
            If V = 30 Then
                Q = 0
                GoTo Label670
            End If
        End If
Label380:
        If V = 28 Then
            If R = 4 Then
                AnsiConsole.MarkupLine("LOOK around carefully...")
            Else
                If TC < L * 120 Then
                    AnsiConsole.MarkupLine("BEWARE of ALIENS... Be kind to animals...")
                Else
                    AnsiConsole.MarkupLine("DESTROY THE SHIP! Know why? THINK!")
                End If
            End If
            GoTo Label140
        End If
Label390:
        If V <> 17 Then
            GoTo Label460
        Else
            If N = 8 Then
                If AR = R Or OB_(4, 2) = R Then
                    AnsiConsole.MarkupLine("I'M NOT GOING ANYWHERE NEAR IT!!")
                    GoTo Label140
                Else
                    GoTo Label20
                End If
            Else
                If N = 9 Then
                    If R = 1 Then
                        If OB_(1, 2) = 0 Then
                            AnsiConsole.MarkupLine("There's a cat in it!")
                            OB_(1, 2) = R
                            GoTo Label140
                        Else
                            GoTo Label400
                        End If
                    Else
                        GoTo Label20
                    End If
                End If
            End If
        End If
Label400:
        If N = 10 Then
            If R = 26 Then
                If OB_(31, 2) = 0 Then
                    AnsiConsole.MarkupLine("It's holding a book")
                    OB_(31, 2) = R
                    GoTo Label140
                Else
                    GoTo Label410
                End If
            Else
                GoTo Label20
            End If
        Else
            If N = 11 Then
                If OB_(6, 2) = -1 Then
                    AnsiConsole.MarkupLine(N2_s)
                    GoTo Label140
                Else
                    GoTo Label20
                End If
            Else
                If N = 13 Then
                    If R = 29 Then
                        OB_(9, 2) = 0
                        OB_(12, 2) = R
                        OB_(4, 2) = R
                        SA = 3
                        GoTo Label30
                    Else
                        GoTo Label20
                    End If
                End If
            End If
        End If
Label410:
        If N = 16 Then
            If R = 31 Then
                AnsiConsole.MarkupLine("It's marked: MAIN THRUSTERS")
                GoTo Label140
            Else
                GoTo Label20
            End If
        Else
            If N = 17 Then
                If R <> 6 And R <> 17 Then
                    GoTo Label20
                Else
                    If R = 6 Then
                        AnsiConsole.MarkupLine("It's marked: AIRLOCK RELEASE")
                        GoTo Label140
                    Else
                        AnsiConsole.MarkupLine("It's marked: RESTRICTED - DO NOT TOUCH")
                        GoTo Label140
                    End If
                End If
            End If
        End If
Label420:
        If N = 21 Then
            If OB_(17, 2) = -1 Or OB_(17, 2) = R Then
                AnsiConsole.MarkupLine($"It has {FS} shots left in it")
                GoTo Label140
            Else
                GoTo Label20
            End If
        Else
            If N = 22 Then
                If R = 7 Then
                    AnsiConsole.MarkupLine("There's a button marked: PLATFORM CONTROL")
                    GoTo Label140
                Else
                    GoTo Label20
                End If
            End If
        End If
Label430:
        If N = 27 Then
            If R = 3 Then
                AnsiConsole.MarkupLine("I SEE AN ALIEN PLANET OUTSIDE")
                GoTo Label140
            Else
                GoTo Label20
            End If
        Else
            If N = 37 Then
                If OB_(13, 2) = -1 Then
                    AnsiConsole.MarkupLine("IT'S MARKED: STARTER CELLS")
                    GoTo Label140
                Else
                    GoTo Label20
                End If
            Else
                If N = 39 Then
                    If OB_(31, 2) = -1 Then
                        AnsiConsole.MarkupLine("THE COVER SAYS: TELEPORTER MANUAL")
                        GoTo Label140
                    End If
                Else
                    GoTo Label20
                End If
            End If
        End If
Label440:
        If N = 36 Then
            If R <> 37 And R <> 31 Then
                GoTo Label20
            Else
                If R = 37 Then
                    AnsiConsole.MarkupLine("COMPUTER: It's been nice knowing you!")
                    GoTo Label140
                Else
                    If PP = 0 Then
                        AnsiConsole.MarkupLine("There's a large lever")
                        GoTo Label140
                    Else
                        AnsiConsole.MarkupLine("There's an empty slot next to a large lever")
                        GoTo Label140
                    End If
                End If
            End If
        End If
Label450:
        If N = 35 Then
            If RC = 0 Or OB_(35, 2) = -1 Then
                AnsiConsole.MarkupLine("There is a box on the end marked:")
                AnsiConsole.MarkupLine("''START WINCH'' to wind up rope")
                GoTo Label140
            Else
                GoTo Label20
            End If
        Else
            If N = 42 Then
                If OB_(34, 2) = -1 Then
                    AnsiConsole.MarkupLine($"OH WOW! It's a {OB_sa(34)}")
                    GoTo Label140
                Else
                    GoTo Label20
                End If
            Else
                AnsiConsole.MarkupLine(N0_s)
                GoTo Label140
            End If
        End If
Label460:
        If V = 23 Then
            If R = 4 Then
                OB_(37, 2) = R
                GoTo Label30
            Else
                GoTo Label30
            End If
        End If
Label470:
        If V = 7 Then
            If N = 35 Then
                If OB_(35, 2) = R Then
                    If RC = -1 Then
                        RC = 0
                        AnsiConsole.MarkupLine("OK")
                        GoTo Label140
                    Else
                        AnsiConsole.MarkupLine("It's already connected!")
                        GoTo Label140
                    End If
                Else
                    If OB_(35, 2) = -1 Then
                        AnsiConsole.MarkupLine("I should put the winch down first")
                        GoTo Label140
                    Else
                        GoTo Label20
                    End If
                End If
            End If
        End If
Label480:
        If V = 7 Then
            If N = 37 Then
                If OB_(13, 2) <> -1 Then
                    GoTo Label20
                Else
                    If R = 31 Then
                        AnsiConsole.MarkupLine("OK")
                        PP = 0
                        OC = OC - 1
                        OB_(13, 2) = 0
                        GoTo Label140
                    Else
                        GoTo Label20
                    End If
                End If
            Else
                AnsiConsole.MarkupLine(M2_s)
                GoTo Label140
            End If
        End If
Label490:
        If (V = 8 Or V = 33) Then
            If N = 35 And RC = 0 Then
                RC = -1
                AnsiConsole.MarkupLine("OK - HEY! It wound back into the winch!!")
                GoTo Label140
            Else
                AnsiConsole.MarkupLine(M7_s)
                GoTo Label140
            End If
        End If
Label500:
        If V = 21 Then
            If N = 6 And R = 7 Then
                R = 18
                GoTo Label30
            Else
                AnsiConsole.MarkupLine("OK")
                GoTo Label140
            End If
        End If
Label510:
        If V = 12 Then
            AnsiConsole.MarkupLine($"OK:  {NO_s}")
            GoTo Label140
        End If
Label520:
        If V = 20 Then
            If N = 28 Then
                If R = 25 Then
                    R = 26
                    GoTo Label30
                Else
                    GoTo Label20
                End If
            Else
                AnsiConsole.MarkupLine("I DON'T WANT TO!")
                GoTo Label140
            End If
        End If
Label530:
        If V = 9 Then
            If N = 5 Then
                If SO = -1 Then
                    If OB_(21, 2) = -1 Then
                        SO = 0
                        OB_(21, 2) = -1
                        AnsiConsole.MarkupLine("OK")
                        GoTo Label140
                    Else
                        GoTo Label20
                    End If
                Else
                    AnsiConsole.MarkupLine("I'm already wearing it!")
                    GoTo Label140
                End If
            Else
                AnsiConsole.MarkupLine(M2_s)
                GoTo Label140
            End If
        End If
Label540:
        If V <> 14 And V <> 16 Then
            GoTo Label570
        Else
            If N <> 17 Then
                AnsiConsole.MarkupLine(N1_s)
                GoTo Label140
            Else
                If R = 17 Then
                    If RE = 0 Then
                        AnsiConsole.MarkupLine($"{N1_s}!")
                        GoTo Label30
                    Else
                        AnsiConsole.MarkupLine($"OH NO! A panel lit up and reads: REACTOR CRITICAL IN {25 * L} MOVES!!")
                        RD = TC + (25 * L) + 1
                        RE = 0
                        GoTo Label140
                    End If
                End If
            End If
        End If
Label550:
        If R = 6 Then
            If OB_(25, 2) = 6 Then
                AO = -1
                RM_(6, 2) = 5
                OB_(26, 2) = 6
                OB_(25, 2) = 0
                GoTo Label30
            Else
                OB_(25, 2) = 6
                OB_(26, 2) = 0
                AO = 0
                RM_(6, 2) = 0
                GoTo Label30
            End If
        End If
Label560:
        If R = 7 Then
            If PD = 0 Then
                PD = -1
                RM_(7, 2) = 6
                RM_(7, 3) = 0
                RM_(18, 2) = 0
                GoTo Label30
            Else
                PD = 0
                RM_(7, 2) = 0
                RM_(7, 3) = 18
                RM_(18, 2) = 7
                GoTo Label30
            End If
        Else
            AnsiConsole.MarkupLine("OK")
            GoTo Label140
        End If
Label570:
        If V = 26 Then
            If N <> 18 Then
                AnsiConsole.MarkupLine("Yeah man, GROOVY!!")
                GoTo Label140
            Else
                If OB_(27, 2) <> -1 Then
                    AnsiConsole.MarkupLine("Bare-handed?!")
                    GoTo Label140
                Else
                    If R = 20 Then
                        OB_(39, 2) = R
                        H1 = 0
                        GoTo Label30
                    Else
                        If R <> 21 Then
                            AnsiConsole.MarkupLine(N0_s)
                            GoTo Label140
                        Else
                            OB_(19, 2) = 21
                            H2 = 0
                            If OB_(29, 2) = 21 Then
                                OB_(29, 2) = 28
                                GoTo Label30
                            Else
                                GoTo Label30
                            End If
                        End If
                    End If
                End If
            End If
        End If
Label580:
        If V = 27 Then
            If RC = 0 Then
                If OB_(35, 2) <> R Then
                    R = OB_(35, 2)
                    GoTo Label30
                Else
                    AnsiConsole.MarkupLine("Ropes already wound up")
                    GoTo Label140
                End If
            Else
                AnsiConsole.MarkupLine("The rope isn't connected to my suit!")
                GoTo Label140
            End If
        End If
Label590:
        If V = 18 Then
            If N <> 20 And N <> 25 And N <> 39 Then
                AnsiConsole.MarkupLine("I CAN'T")
                GoTo Label140
            Else
                If N = 39 Then
                    If OB_(31, 2) <> -1 Then
                        GoTo Label20
                    Else
                        OB_(34, 2) = R
                        AnsiConsole.MarkupLine("I see a map")
                        GoTo Label140
                    End If
                Else
                    If N = 20 Then
                        If R = 31 Then
                            SL = 0
                            AnsiConsole.MarkupLine("OK")
                            GoTo Label140
                        Else
                            GoTo Label20
                        End If
                    Else
                        If R = 4 Then
                            SC = 0
                            AnsiConsole.MarkupLine("OK")
                            GoTo Label140
                        Else
                            GoTo Label20
                        End If
                    End If
                End If
            End If
        End If
Label600:
        If V = 31 Or V = 10 Or V = 11 Then
            If FS = 0 Then
                AnsiConsole.MarkupLine("IT'S EMPTY!")
                GoTo Label140
            Else
                If OB_(17, 2) <> -1 Then
                    AnsiConsole.MarkupLine(M7_s)
                    GoTo Label140
                Else
                    FS = FS - 1
                    If [AS] = 0 Then
                        AR = 0
                        [AS] = -1
                        HA = -1
                        OB_(5, 2) = 0
                        GoTo Label30
                    Else
                        AnsiConsole.MarkupLine("OK")
                        GoTo Label140
                    End If
                End If
            End If
        End If
Label610:
        If V = 15 Then
            If N <> 16 Then
                AnsiConsole.MarkupLine(N1_s)
                GoTo Label140
            Else
                If R <> 31 Then
                    GoTo Label20
                Else
                    If PP = -1 Then
                        AnsiConsole.MarkupLine(N1_s)
                        GoTo Label140
                    Else
                        If AR = 31 Or AR = 32 Then
                            SO = 1
                            GoTo Label670
                        Else
                            AnsiConsole.MarkupLine("Shuttle leaves airlock, autopilot sets course for home")
                            LP = 0
                            GoTo Label670
                        End If
                    End If
                End If
            End If
        End If

Label620:
        If V <> 24 Then
            GoTo Label640
        Else
            AnsiConsole.MarkupLine("TODO: Saving!")
            GoTo Label140
        End If
        '620 IFV<>24THEN640:ELSEPRINT@I,CH$"To Cassette or Disk";:INPUTA$:B=(LEFT$(A$,1)="C"):IFB=-1THENPRINT#-1,AS,AO,SO,OL,PD,PP,RE,RD,FS,OC,AR,SA,HA,TC,TH,RC,H1,H2,SL,SC,R,RM(5,3),RM(6,2),RM(7,2),RM(7,3),RM(18,2),L
Label625:
        '625 IFB=0THENOPEN"O",1,"ALIEN/DAT":PRINT#1,AS,AO,SO,OL,PD,PP,RE,RD,FS,OC,AR,SA,HA,TC,TH,RC,H1,H2,SL,SC,R,RM(5,3),RM(6,2),RM(7,2),RM(7,3),RM(18,2),L
Label630:
        '630 IFB=-1THENFORA=1TO40STEP5:PRINT#-1,OB(A,1),OB(A,2),OB(A+1,1),OB(A+1,2),OB(A+2,1),OB(A+2,2),OB(A+3,1),OB(A+3,2),OB(A+4,1),OB(A+4,2):NEXTA:PRINT"OK":GOTO140
Label635:
        '635 IFB<>0THEN620:ELSEFORA=1TO40STEP5:PRINT#1,OB(A,1),OB(A,2),OB(A+1,1),OB(A+1,2),OB(A+2,1),OB(A+2,2),OB(A+3,1),OB(A+3,2),OB(A+4,1),OB(A+4,2):NEXTA:CLOSE:PRINT"OK":GOTO140

Label640:
        If V <> 25 Then
            GoTo Label660
        Else
            AnsiConsole.MarkupLine("TODO: Loading!")
            GoTo Label140
        End If
        '640 IFV<>25THEN660:ELSEPRINT@I,CH$"From Cassette or Disk";:INPUTA$:B=(LEFT$(A$,1)="C"):IFB=-1THENINPUT#-1,AS,AO,SO,OL,PD,PP,RE,RD,FS,OC,AR,SA,HA,TC,TH,RC,H1,H2,SL,SC,R,RM(5,3),RM(6,2),RM(7,2),RM(7,3),RM(18,2),L
Label645:
        '645 IFB=0THENOPEN"I",1,"ALIEN/DAT":INPUT#1,AS,AO,SO,OL,PD,PP,RE,RD,FS,OC,AR,SA,HA,TC,TH,RC,H1,H2,SL,SC,R,RM(5,3),RM(6,2),RM(7,2),RM(7,3),RM(18,2),L
Label650:
        '650 IFB=-1THENFORA=1TO40STEP5:PRINT@54,"LOADING * ":INPUT#-1,OB(A,1),OB(A,2),OB(A+1,1),OB(A+1,2),OB(A+2,1),OB(A+2,2),OB(A+3,1),OB(A+3,2),OB(A+4,1),OB(A+4,2):NEXTA:GOTO30
Label655:
        '655 IFB<>0THEN640:ELSEFORA=1TO40STEP5:PRINT@I,CH$"LOADING":INPUT#1,OB(A,1),OB(A,2),OB(A+1,1),OB(A+1,2),OB(A+2,1),OB(A+2,2),OB(A+3,1),OB(A+3,2),OB(A+4,1),OB(A+4,2):NEXTA:CLOSE:GOTO30

Label660:
        AnsiConsole.MarkupLine(M2_s)
        GoTo Label140
Label670:
        If Q = 0 Or LP = 0 Then
            GoTo Label700
        Else
            RF = 0
            AnsiConsole.Clear()
            AnsiConsole.MarkupLine("I'M IN A LOT OF TROUBLE!")
            Gosub130()
            If LP = -1 Then
                If DF = 0 Then
                    AnsiConsole.MarkupLine("I FELL DOWN A DEEP HOLE!")
                Else
                    If SO = -1 Then
                        AnsiConsole.MarkupLine("THE AIR'S NOT BREATHABLE!")
                    Else
                        If SO = 0 Then
                            AnsiConsole.MarkupLine("AIR RAN OUT... CAN'T BREATHE!")
                        End If
                    End If
                End If
            End If
        End If
Label680:
        If SO = 1 Then
            AnsiConsole.MarkupLine("ALIEN ATTACKS...")
            AnsiConsole.MarkupLine("IT'S TEARING ME TO SHREDS...")
            AnsiConsole.MarkupLine("AARRRRGH... ")
        End If
Label690:
        AnsiConsole.MarkupLine("I'M DEAD!!!")
Label700:
        Gosub720()
Label710:
        AnsiConsole.MarkupLine("TODO: Play again prompt")
        '710 INPUT"Would you like to try this adventure again";A$:CLS:IFLEFT$(A$,1)="Y"THENRUN:ELSECLS:CLEAR50:END
    End Sub
    Sub Gosub130()
        AnsiConsole.MarkupLine("
================================================================
"
)
    End Sub
    Sub Gosub720()
        AnsiConsole.Markup("Out of a possible 100 points, ")
        TS = 0
        For A = 1 To OB
            If (OB_(A, 2) = -1 And (R = 31 Or R = 32)) Or OB_(A, 2) = 31 Or OB_(A, 2) = 32 Then
                TS = TS + OB_(A, 0)
            End If
        Next
        If (R = 31 Or R = 32) And LP = 0 And RE = 0 Then
            TS = TS + 10
        End If
        AnsiConsole.MarkupLine($"you have{TS}")
        If TS = 100 Then
            AnsiConsole.MarkupLine("FANTASTIC!! You've solved it ALL!")
        End If
    End Sub
    Sub Gosub780()
        If TC <L * 120 Then
            Return
        Else
            If TC = L * 120 Then
                AnsiConsole.Markup("I just heard a LOUD tearing noise!")
                TH = 0
                AR = 11
                OB_(5, 2) = 11
                Return
            End If
        End If
        If [AS] = -1 And AR <> R Then
            AR = Rnd(38)
            GoTo label800
        Else
            GoTo label810
        End If
Label800:
        If AR = 7 Or (AR > 17 And AR < 27) Or AR = 28 Or AR = 29 Then
            If Rnd(4) = 1 Then
                Gosub780()
                Return
            Else
                AR = 0
                Return
            End If
        Else
            OB_(5, 2) = AR
            For A = 0 To 5
                If RM_(R, A) = AR Then
                    GoTo Label810
                End If
            Next
            Return
        End If
Label810:
        [AS] = 0
        AR = PR
        OB_(5, 2) = AR
        If OB_(6, 2) = R Or OB_(6, 2) = -1 Then
            AnsiConsole.MarkupLine("A warning light on the tracker is FLASHING!")
            Return
        Else
            Return
        End If
    End Sub
    Sub Gosub750()
        If R = 29 Then
            If SA <> -1 Then
                SA = SA - 1
                Return
            Else
                If AR = R Then
                    HA = HA - 1
                End If
            End If
        End If
        If AR = R Then
            HA = HA - 1
        Else
            HA = -1
        End If
    End Sub
    Dim random As New Random()
    Function Rnd(v As Integer) As Integer
        Return random.Next(v) + 1
    End Function
End Module
