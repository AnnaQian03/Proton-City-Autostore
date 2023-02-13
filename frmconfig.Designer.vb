<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmconfig))
        Me.pbClient = New System.Windows.Forms.PictureBox()
        Me.pbInvoice = New System.Windows.Forms.PictureBox()
        Me.pbOrders = New System.Windows.Forms.PictureBox()
        Me.pbUserProfile = New System.Windows.Forms.PictureBox()
        Me.pbNewUsers = New System.Windows.Forms.PictureBox()
        Me.pbReports = New System.Windows.Forms.PictureBox()
        CType(Me.pbClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUserProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNewUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbClient
        '
        Me.pbClient.BackgroundImage = CType(resources.GetObject("pbClient.BackgroundImage"), System.Drawing.Image)
        Me.pbClient.Location = New System.Drawing.Point(30, 42)
        Me.pbClient.Name = "pbClient"
        Me.pbClient.Size = New System.Drawing.Size(207, 88)
        Me.pbClient.TabIndex = 0
        Me.pbClient.TabStop = False
        '
        'pbInvoice
        '
        Me.pbInvoice.BackgroundImage = CType(resources.GetObject("pbInvoice.BackgroundImage"), System.Drawing.Image)
        Me.pbInvoice.Location = New System.Drawing.Point(243, 42)
        Me.pbInvoice.Name = "pbInvoice"
        Me.pbInvoice.Size = New System.Drawing.Size(214, 88)
        Me.pbInvoice.TabIndex = 1
        Me.pbInvoice.TabStop = False
        '
        'pbOrders
        '
        Me.pbOrders.BackgroundImage = CType(resources.GetObject("pbOrders.BackgroundImage"), System.Drawing.Image)
        Me.pbOrders.Location = New System.Drawing.Point(489, 42)
        Me.pbOrders.Name = "pbOrders"
        Me.pbOrders.Size = New System.Drawing.Size(204, 88)
        Me.pbOrders.TabIndex = 2
        Me.pbOrders.TabStop = False
        '
        'pbUserProfile
        '
        Me.pbUserProfile.BackgroundImage = CType(resources.GetObject("pbUserProfile.BackgroundImage"), System.Drawing.Image)
        Me.pbUserProfile.Location = New System.Drawing.Point(30, 161)
        Me.pbUserProfile.Name = "pbUserProfile"
        Me.pbUserProfile.Size = New System.Drawing.Size(207, 85)
        Me.pbUserProfile.TabIndex = 3
        Me.pbUserProfile.TabStop = False
        '
        'pbNewUsers
        '
        Me.pbNewUsers.BackgroundImage = CType(resources.GetObject("pbNewUsers.BackgroundImage"), System.Drawing.Image)
        Me.pbNewUsers.Location = New System.Drawing.Point(243, 161)
        Me.pbNewUsers.Name = "pbNewUsers"
        Me.pbNewUsers.Size = New System.Drawing.Size(214, 85)
        Me.pbNewUsers.TabIndex = 4
        Me.pbNewUsers.TabStop = False
        '
        'pbReports
        '
        Me.pbReports.BackgroundImage = CType(resources.GetObject("pbReports.BackgroundImage"), System.Drawing.Image)
        Me.pbReports.Location = New System.Drawing.Point(489, 161)
        Me.pbReports.Name = "pbReports"
        Me.pbReports.Size = New System.Drawing.Size(204, 85)
        Me.pbReports.TabIndex = 5
        Me.pbReports.TabStop = False
        '
        'frmconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 258)
        Me.Controls.Add(Me.pbReports)
        Me.Controls.Add(Me.pbNewUsers)
        Me.Controls.Add(Me.pbUserProfile)
        Me.Controls.Add(Me.pbOrders)
        Me.Controls.Add(Me.pbInvoice)
        Me.Controls.Add(Me.pbClient)
        Me.Name = "frmconfig"
        Me.Text = "frmconfig"
        CType(Me.pbClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUserProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNewUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbClient As PictureBox
    Friend WithEvents pbInvoice As PictureBox
    Friend WithEvents pbOrders As PictureBox
    Friend WithEvents pbUserProfile As PictureBox
    Friend WithEvents pbNewUsers As PictureBox
    Friend WithEvents pbReports As PictureBox
End Class
