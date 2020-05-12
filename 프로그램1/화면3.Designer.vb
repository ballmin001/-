<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 화면3
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(화면3))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button43 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "넘기기"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 1
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Location = New System.Drawing.Point(247, 132)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(52, 51)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "O2"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Location = New System.Drawing.Point(552, 299)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(36, 26)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "N2"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button43
        '
        Me.Button43.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button43.Location = New System.Drawing.Point(765, 141)
        Me.Button43.Name = "Button43"
        Me.Button43.Size = New System.Drawing.Size(72, 33)
        Me.Button43.TabIndex = 45
        Me.Button43.Text = "CuSO4"
        Me.Button43.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button17.Location = New System.Drawing.Point(472, 513)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(48, 24)
        Me.Button17.TabIndex = 46
        Me.Button17.Text = "H2O"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button18.Location = New System.Drawing.Point(536, 439)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(86, 26)
        Me.Button18.TabIndex = 47
        Me.Button18.Text = "알루미늄"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(34, 345)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 24)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "H2O"
        Me.Button2.UseVisualStyleBackColor = True
        '
        '화면3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(955, 688)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button43)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "화면3"
        Me.Text = "화면3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button43 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button2 As Button
End Class
