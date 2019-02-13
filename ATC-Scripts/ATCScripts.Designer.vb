<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ATCScripts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Standard Clearance")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Amended Route")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Amended FL")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Amended Route & FL")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("No SID")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("No SID Amended")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("No SID Amended Route & FL")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("IFR Clearances", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("IFR Taxi")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("VFRTaxi")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Taxi Instructions", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Standard Clearance")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Circuits")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("VFR Clearances", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13})
        Me.ATCMenu = New System.Windows.Forms.TreeView()
        Me.btnGenerateScript = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ATCMenu
        '
        Me.ATCMenu.Location = New System.Drawing.Point(12, 12)
        Me.ATCMenu.Name = "ATCMenu"
        TreeNode1.Name = "StandardClearance"
        TreeNode1.Text = "Standard Clearance"
        TreeNode2.Name = "AmendedRoute"
        TreeNode2.Text = "Amended Route"
        TreeNode3.Name = "AmendedFL"
        TreeNode3.Text = "Amended FL"
        TreeNode4.Name = "AmendedRouteFL"
        TreeNode4.Text = "Amended Route & FL"
        TreeNode5.Name = "NoSID"
        TreeNode5.Text = "No SID"
        TreeNode6.Name = "NoSIDAmended"
        TreeNode6.Text = "No SID Amended"
        TreeNode7.Name = "NoSIDFL"
        TreeNode7.Text = "No SID Amended Route & FL"
        TreeNode8.Name = "IFRClearances"
        TreeNode8.Text = "IFR Clearances"
        TreeNode9.Name = "TaxiIFR"
        TreeNode9.Text = "IFR Taxi"
        TreeNode10.Name = "TaxiVFR"
        TreeNode10.Text = "VFRTaxi"
        TreeNode11.Name = "TaxiInstructions"
        TreeNode11.Text = "Taxi Instructions"
        TreeNode12.Name = "VFRStandard"
        TreeNode12.Text = "Standard Clearance"
        TreeNode13.Name = "VFRCircuits"
        TreeNode13.Text = "Circuits"
        TreeNode14.Name = "VFRClearances"
        TreeNode14.Text = "VFR Clearances"
        Me.ATCMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode11, TreeNode14})
        Me.ATCMenu.Size = New System.Drawing.Size(204, 435)
        Me.ATCMenu.TabIndex = 0
        '
        'btnGenerateScript
        '
        Me.btnGenerateScript.Location = New System.Drawing.Point(222, 147)
        Me.btnGenerateScript.Name = "btnGenerateScript"
        Me.btnGenerateScript.Size = New System.Drawing.Size(170, 83)
        Me.btnGenerateScript.TabIndex = 1
        Me.btnGenerateScript.Text = "Generate Script"
        Me.btnGenerateScript.UseVisualStyleBackColor = True
        '
        'ATCScripts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 459)
        Me.Controls.Add(Me.btnGenerateScript)
        Me.Controls.Add(Me.ATCMenu)
        Me.Name = "ATCScripts"
        Me.Text = "ATC Scripts"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ATCMenu As TreeView
    Friend WithEvents btnGenerateScript As Button
End Class
