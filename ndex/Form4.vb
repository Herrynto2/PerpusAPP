Imports System.Data.Odbc
Imports System.IO.Ports
Public Class Form4
    Dim StatusInput As String = "Save"
    Sub Kosongkan()
        nim.Text = ""
        nim2.Text = ""
        names.Text = ""
        name2.Text = ""
        classs.Text = ""
        classs2.Text = ""
        numbers.Text = ""
        mayor.Text = ""
        mayor2.Text = ""
        faculty.Text = ""
        fingers.Text = ""
        fingers2.Text = ""
        fingers3.Text = ""
        searchs.Text = ""
        searchs2.Text = ""
        barcodes.Text = ""
        judul.Text = ""
        penerbit.Text = ""
        pengarang.Text = ""
        tahun.Text = ""
    End Sub
    Sub tampilDGV()
        Try
            Call Koneksi()
            DA = New OdbcDataAdapter("select * from dataabsenn ORDER BY No ASC", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "dataabsenn")
            DBAbsen.DataSource = DS.Tables("dataabsenn")
            DBAbsen.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show("Show data Failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub
    Private Sub btnhome2_Click(sender As Object, e As EventArgs) Handles btnhome2.Click
        pnlselectposition2.Height = btnhome2.Height
        pnlselectposition2.Top = btnhome2.Top
        pnlhome2.Visible = True
        pnlconnect2.Visible = False
        pnlregis2.Visible = False
        pnlattendents2.Visible = False
        pnlkembali2.Visible = False
        pnlpinjam2.Visible = False
    End Sub
    Private Sub btnconnect2_Click(sender As Object, e As EventArgs) Handles btnconnect2.Click
        pnlselectposition2.Height = btnconnect2.Height
        pnlselectposition2.Top = btnconnect2.Top
        pnlhome2.Visible = False
        pnlconnect2.Visible = True
        pnlregis2.Visible = False
        pnlattendents2.Visible = False
        pnlkembali2.Visible = False
        pnlpinjam2.Visible = False
    End Sub
    Private Sub btnregis2_Click(sender As Object, e As EventArgs) Handles btnregis2.Click
        pnlselectposition2.Height = btnregis2.Height
        pnlselectposition2.Top = btnregis2.Top
        pnlhome2.Visible = False
        pnlconnect2.Visible = False
        pnlregis2.Visible = True
        pnlattendents2.Visible = False
        pnlkembali2.Visible = False
        pnlpinjam2.Visible = False
        names.GetFocus()
        Call Kosongkan()
    End Sub
    Private Sub btnattendent2_Click(sender As Object, e As EventArgs) Handles btnattendent2.Click
        pnlselectposition2.Height = btnattendent2.Height
        pnlselectposition2.Top = btnattendent2.Top
        pnlhome2.Visible = False
        pnlconnect2.Visible = False
        pnlregis2.Visible = False
        pnlattendents2.Visible = True
        pnlkembali2.Visible = False
        pnlpinjam2.Visible = False
        Call tampilDGV()
        Call Kosongkan()
    End Sub
    Private Sub btnborrow2_Click(sender As Object, e As EventArgs) Handles btnborrow2.Click
        pnlselectposition2.Height = btnborrow2.Height
        pnlselectposition2.Top = btnborrow2.Top
        pnlhome2.Visible = False
        pnlconnect2.Visible = False
        pnlregis2.Visible = False
        pnlattendents2.Visible = False
        pnlkembali2.Visible = False
        pnlpinjam2.Visible = True
        Call Kosongkan()
    End Sub
    Private Sub btnreturn2_Click(sender As Object, e As EventArgs) Handles btnreturn2.Click
        pnlselectposition2.Height = btnreturn2.Height
        pnlselectposition2.Top = btnreturn2.Top
        pnlhome2.Visible = False
        pnlconnect2.Visible = False
        pnlregis2.Visible = False
        pnlattendents2.Visible = False
        pnlkembali2.Visible = True
        pnlpinjam2.Visible = False
        Call Kosongkan()
    End Sub
    Private Sub btnclosee2_Click(sender As Object, e As EventArgs) Handles btnclosee2.Click
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
    Private Sub btnmaxx2_Click(sender As Object, e As EventArgs) Handles btnmaxx2.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub
    Private Sub btnminn2_Click(sender As Object, e As EventArgs) Handles btnminn2.Click
        Me.WindowState = WindowState.Minimized
    End Sub
    '''''''''''''''''''''''''''''''''''Registration''''''''''''''''''''''''''''''''''''''
    Private Sub saves_Click(sender As Object, e As EventArgs) Handles saves.Click
        If fingers.Text = "" Or nim.Text = "" Or names.Text = "" Or classs.Text = "" Or mayor.Text = "" Or faculty.Text = "" Then
            MessageBox.Show("Data masih kosong", "perpus App")
            Exit Sub
        End If
        If StatusInput = "Save" Then
            Try
                Call Koneksi()
                CMD = New OdbcCommand("select* from datamhs WHERE IDFinger='" & fingers.Text & "'", CONN)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    MsgBox("Data Sudah Ada")
                Else
                    Call Koneksi()
                    CMD = New OdbcCommand("INSERT INTO datamhs (NIM, Nama, Kelas, Jurusan, Fakultas, IDFinger) VALUES ('" & nim.Text & "','" & names.Text & "','" & classs.Text & "','" & mayor.Text & "','" & faculty.Text & "','" & fingers.Text & "')", CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data berhasil di simpan", MsgBoxStyle.Information, "Information")
                    Call Kosongkan()
                End If
            Catch ex As Exception
                MsgBox("Data gagal disimpan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                CONN.Close()
                Return
            End Try
        End If
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        If fingers.Text = "" Or nim.Text = "" Or names.Text = "" Or classs.Text = "" Or mayor.Text = "" Or faculty.Text = "" Then
            MessageBox.Show("Data masih kosong", "perpus App")
            Exit Sub
        End If
        Try
            If MessageBox.Show("Apakah data ingin diubah ?", "Konfirmasi Perubahan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Call Koneksi()
                Dim str As String
                str = "Update datamhs set NIM = '" & nim.Text & "', Nama = '" & names.Text & "', Kelas = '" & classs.Text & "', Jurusan = '" & mayor.Text & "', Fakultas = '" & faculty.Text & "', IDFinger = '" & fingers.Text & "' where No = '" & numbers.Text & "'"
                CMD = New OdbcCommand(str, CONN)
                CMD.ExecuteNonQuery()
                Call Kosongkan()
                MessageBox.Show("Perubahan data berhasil", "perpus App")
            Else
                CONN.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Perubahan data gagal !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub
    Private Sub resets_Click(sender As Object, e As EventArgs) Handles resets.Click
        Call Kosongkan()
    End Sub
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            If searchs.Text = "" Then
                MessageBox.Show("Data masih kosong")
                Return
            End If
            Call Koneksi()
            CMD = New OdbcCommand("Select * from datamhs  where NIM like '%" & searchs.Text & "%' or Nama like '%" & searchs.Text & "%'or Kelas like '%" & searchs.Text & "%'or Jurusan like '%" & searchs.Text & "%'or Fakultas like '%" & searchs.Text & "%'or IDFinger like '%" & searchs.Text & "%' ", CONN)
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                nim.Text = DR.Item("NIM")
                names.Text = DR.Item("Nama")
                classs.Text = DR.Item("Kelas")
                mayor.Text = DR.Item("jurusan")
                faculty.Text = DR.Item("Fakultas")
                fingers.Text = DR.Item("IDFinger")
            Else
                MsgBox("Data tidak ditemukann", MsgBoxStyle.Information, "Information")
                searchs.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        Finally
        End Try
    End Sub
    Private Sub searchs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles searchs.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                If searchs.Text = "" Then
                    MessageBox.Show("Data masih kosong")
                    Return
                End If
                Call Koneksi()
                CMD = New OdbcCommand("Select * from datamhs  where NIM like '%" & searchs.Text & "%' or Nama like '%" & searchs.Text & "%'or Kelas like '%" & searchs.Text & "%'or Jurusan like '%" & searchs.Text & "%'or Fakultas like '%" & searchs.Text & "%'or IDFinger like '%" & searchs.Text & "%' ", CONN)
                DR = CMD.ExecuteReader
                DR.Read()

                If DR.HasRows Then
                    nim.Text = DR.Item("NIM")
                    names.Text = DR.Item("Nama")
                    classs.Text = DR.Item("Kelas")
                    mayor.Text = DR.Item("jurusan")
                    faculty.Text = DR.Item("Fakultas")
                    fingers.Text = DR.Item("IDFinger")
                Else
                    MsgBox("Data tidak ditemukann", MsgBoxStyle.Information, "Information")
                    searchs.Focus()
                End If
            Catch ex As Exception
                MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Finally
            End Try
        End If
    End Sub
    '''''''''''''''''''''''''''''''''''Attendents''''''''''''''''''''''''''''''''''''''
    Private Sub btnsearch2_Click(sender As Object, e As EventArgs) Handles btnsearch2.Click
        Try
            If fingers2.Text = "" Then
                MessageBox.Show("Data masih kosong", "perpus App")
                Return
            End If
            Call Koneksi()
            CMD = New OdbcCommand("Select * from datamhs  where IDFinger='" & fingers2.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                nim.Text = DR.Item("NIM")
                names.Text = DR.Item("Nama")
                classs.Text = DR.Item("Kelas")
                mayor.Text = DR.Item("jurusan")
                MessageBox.Show("Data Ditemukan, Klik Tambah Untuk Absensi", "perpus App")
            Else
                MsgBox("Data Tidak Ada, Silahkan coba lagi!", MsgBoxStyle.Information, "Information")
                fingers2.Text = ""
                fingers2.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data tidak ada !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btnsearch3_Click(sender As Object, e As EventArgs) Handles btnsearch3.Click
        Try
            If searchs2.Text = "" Then
                MessageBox.Show("Data masih kosong")
                Return
            End If
            Call Koneksi()
            CMD = New OdbcCommand("Select * from datamhs  where NIM like '%" & searchs2.Text & "%' or Nama like '%" & searchs2.Text & "%'or Kelas like '%" & searchs2.Text & "%'or Jurusan like '%" & searchs2.Text & "%'or Fakultas like '%" & searchs2.Text & "%'or IDFinger like '%" & searchs2.Text & "%' ", CONN)
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                Call Koneksi()
                DA = New OdbcDataAdapter("Select * from datamhs  where NIM like '%" & searchs2.Text & "%' or Nama like '%" & searchs2.Text & "%'or Kelas like '%" & searchs2.Text & "%'or Jurusan like '%" & searchs2.Text & "%'or Fakultas like '%" & searchs2.Text & "%'or IDFinger like '%" & searchs2.Text & "%' ", CONN)
                DS = New DataSet
                DA.Fill(DS, "KetemuData")
                DBAbsen.DataSource = DS.Tables("KetemuData")
                DBAbsen.ReadOnly = True

            Else
                MsgBox("Data tidak ditemukann", MsgBoxStyle.Information, "Information")
                searchs.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        Finally
        End Try
    End Sub
    Private Sub searchs2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles searchs2.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                If searchs2.Text = "" Then
                    MessageBox.Show("Data masih kosong")
                    Return
                End If
                Call Koneksi()
                CMD = New OdbcCommand("Select * from datamhs  where NIM like '%" & searchs2.Text & "%' or Nama like '%" & searchs2.Text & "%'or Kelas like '%" & searchs2.Text & "%'or Jurusan like '%" & searchs2.Text & "%'or Fakultas like '%" & searchs2.Text & "%'or IDFinger like '%" & searchs2.Text & "%' ", CONN)
                DR = CMD.ExecuteReader
                DR.Read()

                If DR.HasRows Then
                    Call Koneksi()
                    DA = New OdbcDataAdapter("Select * from datamhs  where NIM like '%" & searchs2.Text & "%' or Nama like '%" & searchs2.Text & "%'or Kelas like '%" & searchs2.Text & "%'or Jurusan like '%" & searchs2.Text & "%'or Fakultas like '%" & searchs2.Text & "%'or IDFinger like '%" & searchs2.Text & "%' ", CONN)
                    DS = New DataSet
                    DA.Fill(DS, "KetemuData")
                    DBAbsen.DataSource = DS.Tables("KetemuData")
                    DBAbsen.ReadOnly = True

                Else
                    MsgBox("Data tidak ditemukann", MsgBoxStyle.Information, "Information")
                    searchs.Focus()
                End If
            Catch ex As Exception
                MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Finally
            End Try
        End If
    End Sub
    Private Sub adds_Click(sender As Object, e As EventArgs) Handles adds.Click
        If fingers2.Text = "" Then
            MessageBox.Show("Input ID Fingerprint terlebih dahulu", "perpus App")
            Exit Sub
        ElseIf nim.Text = "" Or names.Text = "" Or classs.Text = "" Or mayor.Text = "" Then
            MessageBox.Show("Data Belum Ditemukan", "perpus App")
            Exit Sub
        End If
        If StatusInput = "Save" Then
            Try
                Call Koneksi()
                CMD = New OdbcCommand("select* from dataabsenn WHERE NIM='" & nim.Text & "'", CONN)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    MsgBox("Data Sudah Ada")
                Else
                    Call Koneksi()
                    CMD = New OdbcCommand("INSERT INTO dataabsenn (NIM, Nama, Kelas, Jurusan, Jam, Tanggal) VALUES ('" & nim.Text & "','" & names.Text & "','" & classs.Text & "','" & mayor.Text & "','" & waktuu1.Text & "','" & tglpinjam.Text & "')", CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Absensi berhasil", MsgBoxStyle.Information, "Information")
                    Call Kosongkan()
                    Call tampilDGV()
                End If
            Catch ex As Exception
                MsgBox("Absensi gagal !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                CONN.Close()
                Return
            End Try
        End If
    End Sub

    '''''''''''''''''''''''''''''''''''Borrow Book''''''''''''''''''''''''''''''''''''''
    Private Sub fingers3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fingers3.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                If fingers3.Text = "" Then
                    MessageBox.Show("Data masih kosong")
                    Return
                End If
                Call Koneksi()
                CMD = New OdbcCommand("Select * from datamhs where IDFinger = '" & fingers3.Text & "' ", CONN)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    nim2.Text = DR.Item("NIM")
                    name2.Text = DR.Item("Nama")
                    classs2.Text = DR.Item("Kelas")
                    mayor2.Text = DR.Item("jurusan")
                Else
                    MsgBox("Data tidak ditemukann", MsgBoxStyle.Information, "Information")
                    fingers3.Focus()
                End If
            Catch ex As Exception
                MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Finally
            End Try
        End If
    End Sub
    Private Sub btnsearch4_Click(sender As Object, e As EventArgs) Handles btnsearch4.Click
        Try
            If fingers3.Text = "" Then
                MessageBox.Show("Data masih kosong")
                Return
            End If
            Call Koneksi()
            CMD = New OdbcCommand("Select * from datamhs  where IDFinger = '" & fingers3.Text & "' ", CONN)
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                nim2.Text = DR.Item("NIM")
                name2.Text = DR.Item("Nama")
                classs2.Text = DR.Item("Kelas")
                mayor2.Text = DR.Item("jurusan")
            Else
                MsgBox("Data tidak ditemukann", MsgBoxStyle.Information, "Information")
                fingers3.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        Finally
        End Try
    End Sub
    Private Sub barcodes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles barcodes.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                If barcodes.Text = "" Then
                    MessageBox.Show("Data masih kosong")
                    Return
                End If

                Call Koneksi()
                CMD = New OdbcCommand("Select * from databuku where IDBarcode = '" & barcodes.Text & "' ", CONN)
                DR = CMD.ExecuteReader
                DR.Read()

                If DR.HasRows Then
                    judul.Text = DR.Item("Judul")
                    pengarang.Text = DR.Item("Pengarang")
                    penerbit.Text = DR.Item("Penerbit")
                    tahun.Text = DR.Item("Tahun")
                Else
                    MsgBox("Data tidak ditemukann", MsgBoxStyle.Information, "Information")
                    barcodes.Focus()
                End If
            Catch ex As Exception
                MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Finally
            End Try
        End If
    End Sub
    Private Sub btnsearch5_Click(sender As Object, e As EventArgs) Handles btnsearch5.Click
        Try
            If barcodes.Text = "" Then
                MessageBox.Show("Data masih kosong")
                Return
            End If
            Call Koneksi()
            CMD = New OdbcCommand("Select * from databuku where IDBarcode = '" & barcodes.Text & "' ", CONN)
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                judul.Text = DR.Item("Judul")
                pengarang.Text = DR.Item("Pengarang")
                penerbit.Text = DR.Item("Penerbit")
                tahun.Text = DR.Item("Tahun")
            Else
                MsgBox("Data tidak ditemukann", MsgBoxStyle.Information, "Information")
                barcodes.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        Finally
        End Try
    End Sub
    Private Sub saves2_Click(sender As Object, e As EventArgs) Handles saves2.Click
        If nim2.Text = "" Or name2.Text = "" Or classs2.Text = "" Or mayor2.Text = "" Or judul.Text = "" Or pengarang.Text = "" Or penerbit.Text = "" Or tahun.Text = "" Then
            MessageBox.Show("Masih ada data yang kosong", "perpus App")
            Exit Sub
        End If
        If StatusInput = "Save" Then
            Try
                Call Koneksi()
                CMD = New OdbcCommand("INSERT INTO datapinjam (NIM, Nama, Kelas, Jurusan, Judul_Buku, Pengarang, Penerbit, Tahun, IDFinger, IDBarcode, Tgl_Pinjam, Tgl_Batas) VALUES ('" & nim2.Text & "','" & name2.Text & "','" & classs2.Text & "','" & mayor2.Text & "','" & judul.Text & "','" & pengarang.Text & "','" & penerbit.Text & "','" & tahun.Text & "', '" & fingers3.Text & "','" & barcodes.Text & "', '" & tglpinjam.Text & "', '" & tglkembali.Text & "')", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Information")
                Call Kosongkan()
            Catch ex As Exception
                MsgBox("Data gagal disimpan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                CONN.Close()
                Return
            End Try
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim tanggal As Date
        Dim Batas As Date
        Dim jumlah As Integer = 7
        Dim dendah As Integer = 1000

        waktuu1.Text = TimeOfDay

        tanggal = Date.Today
        tglpinjam.Text = tanggal.ToString("dd-MM-yyyy")
        tgltoday.Text = tanggal.ToString("dd-MM-yyyy")

        Batas = tanggal.AddDays(jumlah)
        tglkembali.Text = Batas.ToString("dd-MM-yyyy")
    End Sub
    Private Sub reset2_Click(sender As Object, e As EventArgs) Handles reset2.Click
        Call Kosongkan()
    End Sub
    Private Sub clear5_Click(sender As Object, e As EventArgs) Handles clear5.Click
        fingers3.Text = ""
    End Sub
    Private Sub clear4_Click(sender As Object, e As EventArgs) Handles clear4.Click
        barcodes.Text = ""
    End Sub
    '''''''''''''''''''''''''''''''''''Return Book''''''''''''''''''''''''''''''''''''''
    Private Sub checks_Click(sender As Object, e As EventArgs) Handles checks.Click
        Try
            ' If fingers4.Text = "" Then
            'MsgBox("Data masih kosong", MsgBoxStyle.Information, "Information")
            'Return
            'End If
            Call Koneksi()
            CMD = New OdbcCommand("Select NIM, Nama, Jurusan, Judul_Buku, Tgl_Pinjam, Tgl_Batas from datapinjam where IDFinger ='" & fingers4.Text & "' and IDBarcode ='" & barcodes2.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                pinjam2.Text = DR.Item("Tgl_Pinjam")
                kembali2.Text = DR.Item("Tgl_Batas")
                Call Koneksi()
                DA = New OdbcDataAdapter("Select NIM, Nama, Jurusan, Judul_Buku from datapinjam where IDFInger ='" & fingers4.Text & "' and IDBarcode ='" & barcodes2.Text & "' ", CONN)
                DS = New DataSet
                DA.Fill(DS, "KetemuData")
                DBKembali.DataSource = DS.Tables("KetemuData")
                DBKembali.ReadOnly = True
            Else
                MsgBox("Data tidak ditemukan", MsgBoxStyle.Information, "Information")

            End If
        Catch ex As Exception
            MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub
    Private Sub selesai_Click(sender As Object, e As EventArgs) Handles selesai.Click
        If pinjam2.Text = "" Then
            MessageBox.Show("Tidak ada buku yang dikembalikan", "perpus App")
            Exit Sub
        End If
        Try
            If MessageBox.Show("Apakah buku ingin dikembalikan ?", "Konfirmasi pengembalian buku", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Call Koneksi()
                Dim str As String
                str = "Update datapinjam set Tgl_Kembali = '" & tgltoday.Text & "' where IDFInger ='" & fingers4.Text & "' and IDBarcode ='" & barcodes2.Text & "' "
                CMD = New OdbcCommand(str, CONN)
                CMD.ExecuteNonQuery()
                Call Kosongkan()
                MessageBox.Show("Pengembalian buku berhasil", "perpus App")
            Else
                CONN.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Pengembalian buku berhasil gagal !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub
    ''''''''''''''''''''''''Connection'''''''''''''''''''''''''''''''
    Dim PORT As String
    Dim receivedData As String = " "
    Dim data_terima As String
    Public Shared StrSerialIn As String
    Dim GetID As Boolean = False
    Dim ViewUserData As Boolean = False
    Dim Data As Integer
    Private Sub comport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comport.SelectedIndexChanged
        If (comport.SelectedItem <> "") Then
            PORT = comport.SelectedItem
        End If
    End Sub
    Private Sub connect_Click(sender As Object, e As EventArgs) Handles connect.Click
        Try
            If (connect.ButtonText = "Connect") Then
                If (PORT <> "") Then
                    SerialPort1.Close()
                    SerialPort1.PortName = PORT
                    SerialPort1.BaudRate = 9600
                    SerialPort1.DataBits = 8
                    SerialPort1.Parity = Parity.None
                    SerialPort1.StopBits = StopBits.One
                    SerialPort1.Handshake = Handshake.None
                    SerialPort1.Encoding = System.Text.Encoding.Default
                    SerialPort1.ReadTimeout = 10000

                    SerialPort1.Open()
                    connect.ButtonText = "Disconnect"
                    info2.Text = "Connected"
                    Timer_serial.Enabled = True
                    MessageBox.Show("Serial Connected", " Note")
                Else
                    MessageBox.Show("Select a COM port first", " Note")
                End If
            Else
                SerialPort1.Close()
                connect.ButtonText = "Connect"
                info2.Text = "Disconnected"
                Timer_serial.Enabled = False
                monitor.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Communication Failed", " Note")
        End Try
    End Sub
    Private Sub reset4_Click(sender As Object, e As EventArgs) Handles resets.Click
        monitor.Text = ""
    End Sub
    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try
    End Function
    Private Sub Timer_serial_Tick(sender As Object, e As EventArgs) Handles Timer_serial.Tick
        Try
            receivedData = SerialPort1.ReadExisting
            monitor.Text &= receivedData
            fingers.Text &= receivedData
            fingers2.Text &= receivedData
            fingers3.Text &= receivedData
            fingers4.Text &= receivedData
        Catch ex As Exception
            Timer_serial.Stop()
            SerialPort1.Close()
            Return
        End Try
    End Sub
    Private Sub send_Click(sender As Object, e As EventArgs) Handles send.Click
        Try
            SerialPort1.Write(TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Communication Failed", " Note")
        End Try
    End Sub
    Private Sub registfinger_Click(sender As Object, e As EventArgs) Handles registfinger.Click
        Try
            monitor.Text = ""
            SerialPort1.Write("A")
        Catch ex As Exception
            MessageBox.Show("Communication Failed", " Note")
        End Try
    End Sub
    Private Sub checkfinger_Click(sender As Object, e As EventArgs) Handles checkfinger.Click
        Try
            monitor.Text = ""
            SerialPort1.Write("B")
        Catch ex As Exception
            MessageBox.Show("Communication Failed", " Note")
        End Try
    End Sub
    Private Sub deletefinger_Click(sender As Object, e As EventArgs) Handles deletefinger.Click
        Try
            monitor.Text = ""
            SerialPort1.Write("C")
        Catch ex As Exception
            MessageBox.Show("Communication Failed", " Note")
        End Try
    End Sub

    Private Sub login2_Click(sender As Object, e As EventArgs) Handles login2.Click
        Try
            Form1.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Call Failed", " Note")
        End Try
    End Sub
End Class
