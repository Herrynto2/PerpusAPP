Imports System.Data.Odbc
Public Class Form1
    Private Sub form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub power_Click(sender As Object, e As EventArgs) Handles power.Click
        Try
            If MessageBox.Show("Apakah yakin ingin keluar ?", "Konfirmasi keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Me.Close()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("error !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Try
            If verify.Checked = True Then
                If username.Text = "" Or password.Text = "" Then
                    MsgBox("Data masih kosong", MsgBoxStyle.Information, "Information")
                    Return
                End If
                Call Koneksi()
                CMD = New OdbcCommand("Select username from datauser where username='" & username.Text & "' and password='" & password.Text & "' ", CONN)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    Call Koneksi()
                    Form2.Show()
                    Me.Hide()
                    username.Text = ""
                    password.Text = ""
                Else
                    MsgBox("Username atau password salah", MsgBoxStyle.Information, "Information")
                    username.Focus()
                End If
            Else
                Form4.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("Username atau password salah !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub
    Private Sub verify_OnChange(sender As Object, e As EventArgs) Handles verify.OnChange
        Try
            If verify.Checked = True Then
                username.Enabled = True
                password.Enabled = True
                username.Text = ""
                password.Text = ""
                username.LineIdleColor = Color.Gray
                password.LineIdleColor = Color.Gray
                username.LineFocusedColor = Color.Gainsboro
                password.LineFocusedColor = Color.Gainsboro
                username.LineMouseHoverColor = Color.Gainsboro
                password.LineMouseHoverColor = Color.Gainsboro
                Label4.Text = "As Admin"
            Else
                username.Enabled = False
                password.Enabled = False
                username.Text = ""
                password.Text = ""
                username.LineIdleColor = Color.Transparent
                password.LineIdleColor = Color.Transparent
                username.LineFocusedColor = Color.Transparent
                password.LineFocusedColor = Color.Transparent
                username.LineMouseHoverColor = Color.Transparent
                password.LineMouseHoverColor = Color.Transparent
                Label4.Text = "As User"
            End If
        Catch ex As Exception
            MsgBox("error !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub
End Class