Public Class ATCScripts
    Private Sub ATCScripts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Menu As TreeView
        Menu = ATCMenu

        Menu.ExpandAll()

    End Sub

    Private Sub btnGenerateScript_Click(sender As Object, e As EventArgs) Handles btnGenerateScript.Click
        Dim Menu As TreeView
        Menu = ATCMenu
        Dim nodeName As String
        nodeName = Menu.SelectedNode.Name
        If (nodeName = "StandardClearance") Then
            '<Callsign>, cleared to <Destination> via <SID> departure, flight planned route. Depart runway <Runway>. Squawk <Squawk>.
            Dim callsign, destination, sid, runway, squawk As String
            callsign = InputBox("Enter callsign")
            destination = InputBox("Enter destination")
            sid = InputBox("Enter SID")
            runway = InputBox("Enter runway")
            squawk = InputBox("Enter squawk")
            MsgBox(callsign + ", cleared to " + destination + " via " + sid + " departure, flight planned route. Depart runway " + runway + ". Squawk " + squawk)
        ElseIf (nodeName = "AmendedRoute") Then
            '<Callsign>, cleared to <desintation> via <sid> departure, amended route <sid>  flight planned route. Depart runway <runway>. Squawk <squawk>
            Dim callsign, destination, sid, runway, squawk, amendedsid As String
            callsign = InputBox("Enter callsign")
            destination = InputBox("Enter destination")
            sid = InputBox("Enter SID")
            runway = InputBox("Enter runway")
            squawk = InputBox("Enter squawk")
            amendedsid = InputBox("Enter amended sid")
            MsgBox(callsign + ", cleared to " + destination + " via " + sid + " departure, amended route " + amendedsid + ", flight planned route. Depart runway " + runway + ". Squawk " + squawk)
        ElseIf (nodeName = "AmendedFL") Then
            '<Callsign>, cleared to <desintation> via <sid> departure, flight planned route. Depart runway <runway>. Expect flight level <flight level> 1-0 minutes after departure. Squawk <squawk>
            Dim callsign, destination, sid, runway, squawk, flightlevel As String
            callsign = InputBox("Enter callsign")
            destination = InputBox("Enter destination")
            sid = InputBox("Enter SID")
            runway = InputBox("Enter runway")
            squawk = InputBox("Enter squawk")
            flightlevel = InputBox("Enter amended flight level")
            MsgBox(callsign + ", cleared to " + destination + " via " + sid + " departure, flight planned route. Depart runway " + runway + ". Expect flight level " + flightlevel + " 1-0 minutes after departure. Squawk " + squawk)
        ElseIf (nodeName = "AmendedRouteFL") Then
            '<Callsign>, cleared to <desintation> via <sid> departure, amended route <sid>  flight planned route. Depart runway <runway>. Expect flight level <flight level> 1-0 minutes after departure. Squawk <squawk>
            Dim callsign, destination, sid, runway, squawk, flightlevel, amendedsid As String
            callsign = InputBox("Enter callsign")
            destination = InputBox("Enter destination")
            sid = InputBox("Enter SID")
            amendedsid = InputBox("Enter amended sid")
            runway = InputBox("Enter runway")
            flightlevel = InputBox("Enter amended flight level")
            squawk = InputBox("Enter squawk")
            MsgBox(callsign + ", cleared to " + destination + " via " + sid + " departure, amended route " + amendedsid + ", flight planned route. Depart runway " + runway + ". Expect flight level " + flightlevel + " 1-0 minutes after departure. Squawk " + squawk)
        ElseIf (nodeName = "NoSID") Then
            '<Callsign>, cleared to <destination>. Flight planned route. Depart runway <runway>. On departure, fly runway heading, Climb 7000. Squawk <squawk>
            Dim callsign, destination, runway, squawk As String
            callsign = InputBox("Enter callsign")
            destination = InputBox("Enter destination")
            runway = InputBox("Enter runway")
            squawk = InputBox("Enter squawk")
            MsgBox(callsign + ", cleared to " + destination + ". Flight planned route. Depart runway " + runway + ". On departure, fly runway heading, Climb 7000. Squawk " + squawk)
        ElseIf (nodeName = "NoSIDAmended") Then
            '<Callsign>, cleared to <destination>. Amended Route <SID>. Flight planned route. Depart runway <runway>. On departure, fly runway heading, Climb 7000. Squawk <squawk>
            Dim callsign, destination, runway, squawk, amendedsid As String
            callsign = InputBox("Enter callsign")
            destination = InputBox("Enter destination")
            amendedsid = InputBox("Enter amended sid")
            runway = InputBox("Enter runway")
            squawk = InputBox("Enter squawk")
            MsgBox(callsign + ", cleared to " + destination + ". Amended route " + amendedsid + ". Flight planned route. Depart runway " + runway + ". On departure, fly runway heading, Climb 7000. Squawk " + squawk)
        ElseIf (nodeName = "NoSIDFL") Then
            '<Callsign>, cleared to <destination>. Amended Route <SID>. Flight planned route. Depart runway <runway>. Expect flight level <flight level> 1-0 minutes after departure. On departure, fly runway heading, Climb 7000. Squawk <squawk>
            Dim callsign, destination, runway, squawk, amendedsid, flightlevel As String
            callsign = InputBox("Enter callsign")
            destination = InputBox("Enter destination")
            amendedsid = InputBox("Enter amended sid")
            runway = InputBox("Enter runway")
            flightlevel = InputBox("Enter amended flight level")
            squawk = InputBox("Enter squawk")
            MsgBox(callsign + ", cleared to " + destination + ". Amended route " + amendedsid + ". Flight planned route. Depart runway " + runway + ". Expect flight level " + flightlevel + " 1-0 minutes after departure. On departure, fly runway heading, Climb 7000. Squawk " + squawk)
        ElseIf (nodeName = "TaxiIFR") Then
            '<Callsign>, Runway <runway>, Altimeter <setting>.Taxi apron your discretion <route>. Hold short runway <runway>.
            Dim callsign, runway, setting, route, holdrnwy As String
            callsign = InputBox("Enter callsign")
            runway = InputBox("Enter runway")
            setting = InputBox("Enter altimeter setting")
            route = InputBox("Enter route")
            holdrnwy = InputBox("Enter hold short runway")
            MsgBox(callsign + ", Runway " + runway + ", Altimeter " + setting + ". Texi apron your discrection " + route + ". Hold short runway " + holdrnwy)
        ElseIf (nodeName = "TaxiVFR") Then
            '<Callsign>, Runway <runway>, Winds <winds>. Altimeter <setting>. Taxi via <route>. Hold short runway <runway>.
            Dim callsign, runway, winds, setting, route, holdrnwy As String
            callsign = InputBox("Enter callsign")
            runway = InputBox("Enter runway")
            winds = InputBox("Enter winds")
            setting = InputBox("Enter altimeter setting")
            route = InputBox("Enter route")
            holdrnwy = InputBox("Enter hold short runway")
            MsgBox(callsign + ", Runway " + runway + ", Winds " + winds + ", Altimeter " + setting + ". Texi apron your discrection " + route + ". Hold short runway " + holdrnwy)
        ElseIf (nodeName = "VFRStandard") Then
            '<Callsign>, VFR to <destination> Approved. Depart runway <runway>. Climb runway heading, not above 4500. Squawk <code>.
            Dim callsign, destination, runway, code As String
            callsign = InputBox("Enter callsign")
            destination = InputBox("Enter destination")
            runway = InputBox("Enter runway")
            code = InputBox("Enter squawk")
            MsgBox(callsign + ", VFR to " + destination + " approved. Depart runway " + runway + ". Climb runway heading, not above 4500. Squawk " + code)
        ElseIf (nodeName = "VFRCircuits") Then
            '<Callsign>, VFR Circuits Approved. Depart runway <runway>, <left/right> hand circuits, not above 4500. Squawk <code>.
            Dim callsign, direction, runway, code As String
            callsign = InputBox("Enter callsign")
            runway = InputBox("Enter runway")
            direction = InputBox("Enter left/right")
            code = InputBox("Enter squawk")
            MsgBox(callsign + ", VFR Circuits approved. Depart runway " + runway + ", " + direction + " hand circuits, not above 4500. Squawk " + code)
        End If

    End Sub
End Class
