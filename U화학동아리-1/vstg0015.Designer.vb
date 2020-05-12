<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 화면1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "넘기기"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.No
        Me.Button2.Location = New System.Drawing.Point(12, 513)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 24)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "이스터에그"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(297, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 51)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "소금"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(502, 408)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(52, 51)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "구리"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(701, 150)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(52, 51)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "철"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(297, 320)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(52, 51)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "금"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(502, 82)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(52, 51)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "은"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(701, 320)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(52, 51)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "알루미늄"
        Me.Button8.UseVisualStyleBackColor = True
        '
        '화면1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 549)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "화면1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "화면1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
