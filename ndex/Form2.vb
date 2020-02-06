Imports System.Data.Odbc
Imports System.IO.Ports
Public Class Form2
    Dim StatusInput As String = "Save"
    Private Sub form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilDGV1()
        Call tampilDGV2()
        Call tampilDGV3()
        Call tampilDGV4()
    End Sub
    Sub kosongkan()
        numbers.Text = ""
        noinduk.Text = ""
        noinduk2.Text = ""
        nama1.Text = ""
        nama2.Text = ""
        kelas1.Text = ""
        kelas2.Text = ""
        jurusan1.Text = ""
        jurusan2.Text = ""
        fakultas1.Text = ""
        finger1.Text = ""
        finger2.Text = ""
        Finger3.Text = ""
        judul1.Text = ""
        judul2.Text = ""
        pengarang1.Text = ""
        pengarang2.Text = ""
        penerbit.Text = ""
        penerbit2.Text = ""
        tahun.Text = ""
        tahun2.Text = ""
        barcode1.Text = ""
        barcode2.Text = ""
        search1.Text = ""
        search2.Text = ""
        search3.Text = ""
    End Sub
    Sub tampilDGV1()
        Try
            Call Koneksi()
            DA = New OdbcDataAdapter("select * from datamhs ORDER BY No ASC", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "datamhs")
            DGV1.DataSource = DS.Tables("datamhs")
            DGV1.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show("Show data Failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub
    Sub tampilDGV2()
        Try
            Call Koneksi()
            DA = New OdbcDataAdapter("select * from databuku ORDER BY No ASC", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "databuku")
            DGV2.DataSource = DS.Tables("databuku")
            DGV2.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show("Show data Failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub
    Sub tampilDGV3()
        Try
            Call Koneksi()
            DA = New OdbcDataAdapter("select * from dataabsenn ORDER BY No ASC", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "dataabsenn")
            DGV3.DataSource = DS.Tables("dataabsenn")
            DGV3.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show("Show data Failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub
    Sub tampilDGV4()
        Try
            Call Koneksi()
            DA = New OdbcDataAdapter("select * from datapinjam ORDER BY No ASC", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "datapinjam")
            DGV4.DataSource = DS.Tables("datapinjam")
            DGV4.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show("Show data Failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        pnlselectposition.Height = btnhome.Height
        pnlselectposition.Top = btnhome.Top
        pnlhome.Visible = True
        pnlconnect.Visible = False
        pnlregis.Visible = False
        pnlbooklist.Visible = False
        pnlattendents.Visible = False
        pnlreturn.Visible = False
        pnlpinjam.Visible = False
    End Sub
    Private Sub btnregis_Click_1(sender As Object, e As EventArgs) Handles btnregis.Click
        pnlselectposition.Height = btnregis.Height
        pnlselectposition.Top = btnregis.Top
        pnlhome.Visible = False
        pnlconnect.Visible = False
        pnlregis.Visible = True
        pnlbooklist.Visible = False
        pnlattendents.Visible = False
        pnlreturn.Visible = False
        pnlpinjam.Visible = False
        noinduk.GetFocus()
        Call tampilDGV1()
        Call kosongkan()
    End Sub

    Private Sub btnconnect_Click_1(sender As Object, e As EventArgs) Handles btnconnect.Click
        pnlselectposition.Height = btnconnect.Height
        pnlselectposition.Top = btnconnect.Top
        pnlhome.Visible = False
        pnlconnect.Visible = True
        pnlregis.Visible = False
        pnlbooklist.Visible = False
        pnlattendents.Visible = False
        pnlreturn.Visible = False
        pnlpinjam.Visible = False
    End Sub

    Private Sub btnbooklist_Click(sender As Object, e As EventArgs) Handles btnbooklist.Click
        pnlselectposition.Height = btnbooklist.Height
        pnlselectposition.Top = btnbooklist.Top
        pnlhome.Visible = False
        pnlconnect.Visible = False
        pnlregis.Visible = False
        pnlbooklist.Visible = True
        pnlattendents.Visible = False
        pnlreturn.Visible = False
        pnlpinjam.Visible = False
        judul1.GetFocus()
        Call tampilDGV2()
        Call kosongkan()
    End Sub
    Private Sub btnattendent_Click(sender As Object, e As EventArgs) Handles btnattendent.Click
        pnlselectposition.Height = btnattendent.Height
        pnlselectposition.Top = btnattendent.Top
        pnlhome.Visible = False
        pnlconnect.Visible = False
        pnlregis.Visible = False
        pnlbooklist.Visible = False
        pnlattendents.Visible = True
        pnlreturn.Visible = False
        pnlpinjam.Visible = False
        Call tampilDGV3()
        Call kosongkan()
    End Sub
    Private Sub btnborrow_Click(sender As Object, e As EventArgs) Handles btnborrow.Click
        pnlselectposition.Height = btnborrow.Height
        pnlselectposition.Top = btnborrow.Top
        pnlhome.Visible = False
        pnlconnect.Visible = False
        pnlregis.Visible = False
        pnlbooklist.Visible = False
        pnlattendents.Visible = False
        pnlreturn.Visible = False
        pnlpinjam.Visible = True
        Call kosongkan()
    End Sub
    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        pnlselectposition.Height = btnreturn.Height
        pnlselectposition.Top = btnreturn.Top
        pnlhome.Visible = False
        pnlconnect.Visible = False
        pnlregis.Visible = False
        pnlbooklist.Visible = False
        pnlattendents.Visible = False
        pnlreturn.Visible = True
        pnlpinjam.Visible = False
        Call tampilDGV4()
        Call kosongkan()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        pnltop.Visible = False
        pnlmenu.Visible = False
        pnlhelp.Visible = True
        pnlhome.Visible = False
        pnlconnect.Visible = False
        pnlregis.Visible = False
        pnlbooklist.Visible = False
        pnlattendents.Visible = False
        pnlreturn.Visible = False
        pnlpinjam.Visible = False
    End Sub
    Private Sub btnclosee_Click(sender As Object, e As EventArgs) Handles btnclosee.Click
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
    Private Sub btnminn_Click(sender As Object, e As EventArgs) Handles btnmaxx.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub
    Private Sub btnmaxx_Click(sender As Object, e As EventArgs) Handles btnminn.Click
        Me.WindowState = WindowState.Minimized
    End Sub
    Private Sub clear1_Click(sender As Object, e As EventArgs) Handles clear1.Click
        Call kosongkan()
    End Sub
    Private Sub clear2_Click(sender As Object, e As EventArgs) Handles clear2.Click
        Call kosongkan()
    End Sub
    Private Sub clear3_Click(sender As Object, e As EventArgs) Handles clear3.Click
        Call kosongkan()
    End Sub
    Private Sub clear4_Click(sender As Object, e As EventArgs) Handles clear4.Click
        Call kosongkan()
    End Sub
    Private Sub clear5_Click(sender As Object, e As EventArgs) Handles clear5.Click
        Call kosongkan()
    End Sub

    ''''''''''''''''''''''''Registration User'''''''''''''''''''''''''''''''
    Private Sub save1_Click(sender As Object, e As EventArgs) Handles save1.Click
        If finger1.Text = "" Or noinduk.Text = "" Or nama1.Text = "" Or kelas1.Text = "" Or jurusan1.Text = "" Or fakultas1.Text = "" Then
            MessageBox.Show("Data masih kosong", "perpus App")
            Exit Sub
        End If
        If StatusInput = "Save" Then
            Try
                Call Koneksi()
                CMD = New OdbcCommand("select* from datamhs WHERE IDFinger='" & finger1.Text & "'", CONN)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    MsgBox("Data Sudah Ada")
                Else
                    Call Koneksi()
                    CMD = New OdbcCommand("INSERT INTO datamhs (NIM, Nama, Kelas, Jurusan, Fakultas, IDFinger) VALUES ('" & noinduk.Text & "','" & nama1.Text & "','" & kelas1.Text & "','" & jurusan1.Text & "','" & fakultas1.Text & "','" & finger1.Text & "')", CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data berhasil di simpan", MsgBoxStyle.Information, "Information")
                    Call kosongkan()
                    Call tampilDGV1()
                End If
            Catch ex As Exception
                MsgBox("Data gagal disimpan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                CONN.Close()
                Return
            End Try
        End If
    End Sub
    Private Sub del1_Click(sender As Object, e As EventArgs) Handles del1.Click
        If finger1.Text = "" Or noinduk.Text = "" Or nama1.Text = "" Or kelas1.Text = "" Or jurusan1.Text = "" Or fakultas1.Text = "" Then
            MessageBox.Show("Data masih kosong", "perpus App")
            Exit Sub
        End If
        Try
            If MessageBox.Show("Apakah data ingin dihapus ?", "Konfirmasi Penghapusan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Call Koneksi()
                CMD = New OdbcCommand("delete from datamhs where No='" & numbers.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus")
                Call tampilDGV1()
                Call kosongkan()
            Else
                CONN.Close()
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Data gagal dihapus !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            CONN.Close()
        End Try
    End Sub
    Private Sub edits1_Click(sender As Object, e As EventArgs) Handles edits1.Click
        If finger1.Text = "" Or noinduk.Text = "" Or nama1.Text = "" Or kelas1.Text = "" Or jurusan1.Text = "" Or fakultas1.Text = "" Then
            MessageBox.Show("Data masih kosong", "perpus App")
            Exit Sub
        End If
        Try
            If MessageBox.Show("Apakah data ingin diubah ?", "Konfirmasi Perubahan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Call Koneksi()
                Dim str As String
                str = "Update datamhs set NIM = '" & noinduk.Text & "', Nama = '" & nama1.Text & "', Kelas = '" & kelas1.Text & "', Jurusan = '" & jurusan1.Text & "', Fakultas = '" & fakultas1.Text & "', IDFinger = '" & finger1.Text & "' where No = '" & numbers.Text & "'"
                CMD = New OdbcCommand(str, CONN)
                CMD.ExecuteNonQuery()
                Call tampilDGV1()
                Call kosongkan()
                MessageBox.Show("Perubahan data berhasil", "perpus App")
            Else
                CONN.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Perubahan data gagal !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub
    Private Sub erase1_Click(sender As Object, e As EventArgs) Handles erase1.Click
        Call kosongkan()
        Call tampilDGV1()
    End Sub
    Private Sub search1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles search1.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                If search1.Text = "" Then
                    Call tampilDGV1()
                    Return
                End If
                Call Koneksi()
                CMD = New OdbcCommand("Select * from datamhs  where NIM like '%" & search1.Text & "%' or Nama like '%" & search1.Text & "%'or Kelas like '%" & search1.Text & "%'or Jurusan like '%" & search1.Text & "%'or Fakultas like '%" & search1.Text & "%'or IDFinger like '%" & search1.Text & "%' ", CONN)
                DR = CMD.ExecuteReader
                DR.Read()

                If DR.HasRows Then
                    noinduk.Text = DR.Item("NIM")
                    nama1.Text = DR.Item("Nama")
                    kelas1.Text = DR.Item("Kelas")
                    jurusan1.Text = DR.Item("jurusan")
                    fakultas1.Text = DR.Item("Fakultas")
                    finger1.Text = DR.Item("IDFinger")

                    Call Koneksi()
                    DA = New OdbcDataAdapter("Select * from datamhs  where NIM like '%" & search1.Text & "%' or Nama like '%" & search1.Text & "%'or Kelas like '%" & search1.Text & "%'or Jurusan like '%" & search1.Text & "%'or Fakultas like '%" & search1.Text & "%'or IDFinger like '%" & search1.Text & "%' ", CONN)
                    DS = New DataSet
                    DA.Fill(DS, "KetemuData")
                    DGV1.DataSource = DS.Tables("KetemuData")
                    DGV1.ReadOnly = True
                Else
                    MsgBox("Data tidak ditemukann", MsgBoxStyle.Information, "Information")
                    search1.Focus()
                End If
            Catch ex As Exception
                MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Finally
                CONN.Close()
            End Try
        End If
    End Sub
    Private Sub DGV1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV1.CellMouseClick
        Try
            numbers.Text = DGV1.Rows(e.RowIndex).Cells(0).Value
            noinduk.Text = DGV1.Rows(e.RowIndex).Cells(1).Value
            nama1.Text = DGV1.Rows(e.RowIndex).Cells(2).Value
            kelas1.Text = DGV1.Rows(e.RowIndex).Cells(3).Value
            jurusan1.Text = DGV1.Rows(e.RowIndex).Cells(4).Value
            fakultas1.Text = DGV1.Rows(e.RowIndex).Cells(5).Value
            finger1.Text = DGV1.Rows(e.RowIndex).Cells(6).Value
        Catch ex As Exception
            MsgBox("Data not found !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub cari1_Click(sender As Object, e As EventArgs) Handles cari1.Click
        Try
            If search1.Text = "" Then
                Call tampilDGV1()
                Return
            End If
            Call Koneksi()
            CMD = New OdbcCommand("Select * from datamhs  where NIM like '%" & search1.Text & "%' or Nama like '%" & search1.Text & "%'or Kelas like '%" & search1.Text & "%'or Jurusan like '%" & search1.Text & "%'or Fakultas like '%" & search1.Text & "%'or IDFinger like '%" & search1.Text & "%' ORDER BY No DESC", CONN)
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                noinduk.Text = DR.Item("NIM")
                nama1.Text = DR.Item("Nama")
                kelas1.Text = DR.Item("Kelas")
                jurusan1.Text = DR.Item("jurusan")
                fakultas1.Text = DR.Item("Fakultas")
                finger1.Text = DR.Item("IDFinger")

                Call Koneksi()
                DA = New OdbcDataAdapter("Select * from datamhs  where NIM like '%" & search1.Text & "%' or Nama like '%" & search1.Text & "%'or Kelas like '%" & search1.Text & "%'or Jurusan like '%" & search1.Text & "%'or Fakultas like '%" & search1.Text & "%'or IDFinger like '%" & search1.Text & "%' ORDER BY No DESC", CONN)
                DS = New DataSet
                DA.Fill(DS, "KetemuData")
                DGV1.DataSource = DS.Tables("KetemuData")
                DGV1.ReadOnly = True
            Else
                MsgBox("Data tidak ditemukann", MsgBoxStyle.Information, "Information")
                search1.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        Finally
            CONN.Close()
        End Try
    End Sub
    ''''''''''''''''''''''''Book List'''''''''''''''''''''''''''''''
    Private Sub save2_Click(sender As Object, e As EventArgs) Handles save2.Click
        If barcode1.Text = "" Or judul1.Text = "" Or pengarang1.Text = "" Or penerbit.Text = "" Or tahun.Text = "" Then
            MessageBox.Show("Data masih kosong", "perpus App")
            Exit Sub
        End If
        If StatusInput = "Save" Then
            Try
                Call Koneksi()
                CMD = New OdbcCommand("select* from databuku WHERE IDBarcode='" & barcode1.Text & "'", CONN)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    MsgBox("Data Sudah Ada")
                Else
                    Call Koneksi()
                    CMD = New OdbcCommand("INSERT INTO databuku (Judul, Pengarang, Penerbit, Tahun, IDBarcode) VALUES ('" & judul1.Text & "','" & pengarang1.Text & "','" & penerbit.Text & "','" & tahun.Text & "','" & barcode1.Text & "')", CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Information")
                    Call kosongkan()
                    Call tampilDGV2()
                End If
            Catch ex As Exception
                MsgBox("Data gagal disimpan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                CONN.Close()
                Return
            End Try
        End If
    End Sub

    Private Sub del2_Click(sender As Object, e As EventArgs) Handles del2.Click
        If barcode1.Text = "" Or judul1.Text = "" Or pengarang1.Text = "" Or penerbit.Text = "" Or tahun.Text = "" Then
            MessageBox.Show("Data masih kosong", "perpus App")
            Exit Sub
        End If
        Try
            If MessageBox.Show("Apakah data ingin dihapus ?", "Konfirmasi Penghapusan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Call Koneksi()
                CMD = New OdbcCommand("delete from databuku where No='" & numbers.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data berhasil disimpan", "perpus App")
                Call tampilDGV2()
                Call kosongkan()
            Else
                CONN.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Data gagal dihapus !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            CONN.Close()
        End Try
    End Sub

    Private Sub edits2_Click(sender As Object, e As EventArgs) Handles edits2.Click
        If barcode1.Text = "" Or judul1.Text = "" Or pengarang1.Text = "" Or penerbit.Text = "" Or tahun.Text = "" Then
            MessageBox.Show("Data belum lengkap", "perpus App")
            Exit Sub
        End If
        Try
            If MessageBox.Show("Apakah data ingin diubah ?", "Konfirmasi Perubahan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Call Koneksi()
                Dim str As String
                str = "Update databuku set Judul = '" & judul1.Text & "', Pengarang = '" & pengarang1.Text & "', Penerbit = '" & penerbit.Text & "', Tahun = '" & tahun.Text & "', IDBarcode = '" & barcode1.Text & "' where No = '" & numbers.Text & "'"
                CMD = New OdbcCommand(str, CONN)
                CMD.ExecuteNonQuery()
                Call tampilDGV2()
                Call kosongkan()
                MessageBox.Show("Perubahan data berhasil", "perpus App")

            Else
                CONN.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Perubahan data gagal !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub
    Private Sub erase2_Click(sender As Object, e As EventArgs) Handles erase2.Click
        Call kosongkan()
        Call tampilDGV2()
    End Sub
    Private Sub search2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles search2.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                If search2.Text = "" Then
                    Call tampilDGV2()
                    Return
                End If
                Call Koneksi()
                CMD = New OdbcCommand("Select * from databuku  where Judul like '%" & search2.Text & "%' or Pengarang like '%" & search2.Text & "%'or Penerbit like '%" & search2.Text & "%'or Tahun like '%" & search2.Text & "%'or IDBarcode like '%" & search2.Text & "%'", CONN)
                DR = CMD.ExecuteReader
                DR.Read()

                If DR.HasRows Then
                    judul1.Text = DR.Item("Judul")
                    pengarang1.Text = DR.Item("Pengarang")
                    penerbit.Text = DR.Item("Penerbit")
                    tahun.Text = DR.Item("Tahun")
                    barcode1.Text = DR.Item("IDBarcode")

                    Call Koneksi()
                    DA = New OdbcDataAdapter("Select * from databuku  where Judul like '%" & search2.Text & "%' or Pengarang like '%" & search2.Text & "%'or Penerbit like '%" & search2.Text & "%'or Tahun like '%" & search2.Text & "%'or IDBarcode like '%" & search2.Text & "%'", CONN)
                    DS = New DataSet
                    DA.Fill(DS, "KetemuData")
                    DGV2.DataSource = DS.Tables("KetemuData")
                    DGV2.ReadOnly = True
                Else
                    MsgBox("Data Tidak Ada, Silahkan coba lagi!", MsgBoxStyle.Information, "Information")
                    search2.Focus()
                End If
            Catch ex As Exception
                MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Finally
                CONN.Close()
            End Try
        End If
    End Sub
    Private Sub cari2_Click(sender As Object, e As EventArgs) Handles cari2.Click
        Try
            If search2.Text = "" Then
                Call tampilDGV2()
                Return
            End If
            Call Koneksi()
            CMD = New OdbcCommand("Select * from databuku  where Judul like '%" & search2.Text & "%' or Pengarang like '%" & search2.Text & "%'or Penerbit like '%" & search2.Text & "%'or Tahun like '%" & search2.Text & "%'or IDBarcode like '%" & search2.Text & "%'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                judul1.Text = DR.Item("Judul")
                pengarang1.Text = DR.Item("Pengarang")
                penerbit.Text = DR.Item("Penerbit")
                tahun.Text = DR.Item("Tahun")
                barcode1.Text = DR.Item("IDBarcode")

                Call Koneksi()
                DA = New OdbcDataAdapter("Select * from databuku  where Judul like '%" & search2.Text & "%' or Pengarang like '%" & search2.Text & "%'or Penerbit like '%" & search2.Text & "%'or Tahun like '%" & search2.Text & "%'or IDBarcode like '%" & search2.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "KetemuData")
                DGV2.DataSource = DS.Tables("KetemuData")
                DGV2.ReadOnly = True
            Else
                MsgBox("Data Tidak Ada, Silahkan coba lagi!", MsgBoxStyle.Information, "Information")
                search2.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        Finally
            CONN.Close()
        End Try
    End Sub
    Private Sub DGV2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV2.CellMouseClick
        Try
            numbers.Text = DGV2.Rows(e.RowIndex).Cells(0).Value
            judul1.Text = DGV2.Rows(e.RowIndex).Cells(1).Value
            pengarang1.Text = DGV2.Rows(e.RowIndex).Cells(2).Value
            penerbit.Text = DGV2.Rows(e.RowIndex).Cells(3).Value
            tahun.Text = DGV2.Rows(e.RowIndex).Cells(4).Value
            barcode1.Text = DGV2.Rows(e.RowIndex).Cells(5).Value
        Catch ex As Exception
            MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub
    ''''''''''''''''''''''''Attendent List'''''''''''''''''''''''''''''''
    Private Sub cari3_Click(sender As Object, e As EventArgs) Handles cari3.Click
        Try
            If finger2.Text = "" Then
                MessageBox.Show("Data masih kosong", "perpus App")
                Return
            End If
            Call Koneksi()
            CMD = New OdbcCommand("Select * from datamhs  where IDFinger='" & finger2.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                noinduk.Text = DR.Item("NIM")
                nama1.Text = DR.Item("Nama")
                kelas1.Text = DR.Item("Kelas")
                jurusan1.Text = DR.Item("jurusan")
                fakultas1.Text = DR.Item("Fakultas")

                Call Koneksi()
                DA = New OdbcDataAdapter("Select * from datamhs  where IDFinger='" & finger2.Text & "'", CONN)
                DS = New DataSet
                DA.Fill(DS, "KetemuData")
                DGV1.DataSource = DS.Tables("KetemuData")
                DGV1.ReadOnly = True

                MessageBox.Show("Data Ditemukan, Klik Tambah Untuk Absens", "perpus App")
                tampilDGV3()

            Else
                MsgBox("Data Tidak Ada, Silahkan coba lagi!", MsgBoxStyle.Information, "Information")
                finger2.Text = ""
                finger2.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data tidak ada !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        Finally
            CONN.Close()
        End Try
    End Sub
    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        If finger2.Text = "" Then
            MessageBox.Show("Input ID Fingerprint terlebih dahulu", "perpus App")
            Exit Sub
        ElseIf nama1.Text = "" Or noinduk.Text = "" Or jurusan1.Text = "" Or kelas1.Text = "" Then
            MessageBox.Show("Data Belum Ditemukan", "perpus App")
            Exit Sub
        End If
        If StatusInput = "Save" Then
            Try
                Call Koneksi()
                CMD = New OdbcCommand("select* from dataabsenn WHERE NIM='" & noinduk.Text & "'", CONN)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    MsgBox("Data Sudah Ada")
                Else
                    Call Koneksi()
                    CMD = New OdbcCommand("INSERT INTO dataabsenn (NIM, Nama, Kelas, Jurusan, Jam, Tanggal) VALUES ('" & noinduk.Text & "','" & nama1.Text & "','" & kelas1.Text & "','" & jurusan1.Text & "','" & waktu1.Text & "','" & tanggal1.Text & "')", CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Absensi berhasil", MsgBoxStyle.Information, "Information")
                    Call kosongkan()
                    Call tampilDGV3()
                End If
            Catch ex As Exception
                MsgBox("Absensi gagal !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                CONN.Close()
                Return
            End Try
        End If
    End Sub
    Private Sub search3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles search3.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                If search3.Text = "" Then
                    Call tampilDGV3()
                    Return
                End If
                Call Koneksi()
                CMD = New OdbcCommand("Select * from dataabsenn  where NIM like '%" & search3.Text & "%' or Nama like '%" & search3.Text & "%'or Kelas like '%" & search3.Text & "%'or Jurusan like '%" & search3.Text & "%' ", CONN)
                DR = CMD.ExecuteReader
                DR.Read()

                If DR.HasRows Then
                    noinduk.Text = DR.Item("NIM")
                    nama1.Text = DR.Item("Nama")
                    kelas1.Text = DR.Item("Kelas")
                    jurusan1.Text = DR.Item("jurusan")

                    Call Koneksi()
                    DA = New OdbcDataAdapter("Select * from dataabsenn  where NIM like '%" & search3.Text & "%' or Nama like '%" & search3.Text & "%'or Kelas like '%" & search3.Text & "%'or Jurusan like '%" & search3.Text & "%' ", CONN)
                    DS = New DataSet
                    DA.Fill(DS, "KetemuData")
                    DGV3.DataSource = DS.Tables("KetemuData")
                    DGV3.ReadOnly = True
                Else
                    MsgBox("Data tidak ditemukan, Silahkan coba lagi!", MsgBoxStyle.Information, "Information")
                    search3.Focus()
                End If
            Catch ex As Exception
                MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Finally
                CONN.Close()
            End Try
        End If
    End Sub
    Private Sub cari4_Click(sender As Object, e As EventArgs) Handles cari4.Click
        Try
            If search3.Text = "" Then
                Call tampilDGV3()
                Return
            End If
            Call Koneksi()
            CMD = New OdbcCommand("Select * from dataabsenn  where NIM like '%" & search3.Text & "%' or Nama like '%" & search3.Text & "%'or Kelas like '%" & search3.Text & "%'or Jurusan like '%" & search3.Text & "%' ", CONN)
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                noinduk.Text = DR.Item("NIM")
                nama1.Text = DR.Item("Nama")
                kelas1.Text = DR.Item("Kelas")
                jurusan1.Text = DR.Item("jurusan")

                Call Koneksi()
                DA = New OdbcDataAdapter("Select * from dataabsenn  where NIM like '%" & search3.Text & "%' or Nama like '%" & search3.Text & "%'or Kelas like '%" & search3.Text & "%'or Jurusan like '%" & search3.Text & "%' ", CONN)
                DS = New DataSet
                DA.Fill(DS, "KetemuData")
                DGV3.DataSource = DS.Tables("KetemuData")
                DGV3.ReadOnly = True
            Else
                MsgBox("Data tidak ditemukan, Silahkan coba lagi!", MsgBoxStyle.Information, "Information")
                search3.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        Finally
            CONN.Close()
        End Try
    End Sub
    ''''''''''''''''''''''''Peminjaman Buku'''''''''''''''''''''''''''''''
    Private Sub cari5_Click(sender As Object, e As EventArgs) Handles cari5.Click
        Try
            If Finger3.Text = "" Then
                MessageBox.Show("Data Tidak Boleh Kosong", "perpus App")
                Return
            End If
            Call Koneksi()
            CMD = New OdbcCommand("Select * from datamhs  where IDFinger='" & Finger3.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                noinduk2.Text = DR.Item("NIM")
                nama2.Text = DR.Item("Nama")
                kelas2.Text = DR.Item("Kelas")
                jurusan2.Text = DR.Item("Jurusan")

                Call Koneksi()
                DA = New OdbcDataAdapter("Select * from datamhs  where IDFinger='" & Finger3.Text & "'", CONN)
                DS = New DataSet
                DA.Fill(DS, "KetemuData")
                DGV1.DataSource = DS.Tables("KetemuData")
                DGV1.ReadOnly = True
                tampilDGV4()

            Else
                MsgBox("Data tidak ditemukan, Silahkan coba lagi!", MsgBoxStyle.Information, "Information")
                Finger3.Text = ""
                noinduk2.Text = ""
                nama2.Text = ""
                kelas2.Text = ""
                jurusan2.Text = ""
                Finger3.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        Finally
            CONN.Close()
        End Try
    End Sub
    Private Sub cari6_Click(sender As Object, e As EventArgs) Handles cari6.Click
        Try
            If barcode2.Text = "" Then
                MessageBox.Show("Data Tidak Boleh Kosong", "perpus App")
                Return
            End If
            Call Koneksi()
            CMD = New OdbcCommand("Select * from databuku  where IDBarcode='" & barcode2.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                judul2.Text = DR.Item("Judul")
                pengarang2.Text = DR.Item("Pengarang")
                penerbit2.Text = DR.Item("Penerbit")
                tahun2.Text = DR.Item("Tahun")

                Call Koneksi()
                DA = New OdbcDataAdapter("Select * from databuku where IDBarcode='" & barcode2.Text & "'", CONN)
                DS = New DataSet
                DA.Fill(DS, "KetemuData")
                DGV1.DataSource = DS.Tables("KetemuData")
                DGV1.ReadOnly = True
                tampilDGV4()

            Else
                MsgBox("Data tidak ditemukan, Silahkan coba lagi!", MsgBoxStyle.Information, "Information")
                barcode2.Text = ""
                judul2.Text = ""
                pengarang2.Text = ""
                penerbit2.Text = ""
                tahun2.Text = ""
                barcode2.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data tidak ditemukan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        Finally
            CONN.Close()
        End Try
    End Sub
    Private Sub save3_Click(sender As Object, e As EventArgs) Handles save3.Click
        If noinduk2.Text = "" Or nama2.Text = "" Or kelas2.Text = "" Or jurusan2.Text = "" Or judul2.Text = "" Or pengarang2.Text = "" Or penerbit2.Text = "" Or tahun2.Text = "" Then
            MessageBox.Show("Data Belum Lengkap", "perpus App")
            Exit Sub
        End If
        If StatusInput = "Save" Then
            Try
                Call Koneksi()
                CMD = New OdbcCommand("INSERT INTO datapinjam (NIM, Nama, Kelas, Jurusan, Judul_Buku, Pengarang, Penerbit, Tahun, IDFinger, IDBarcode, Tgl_Pinjam, Tgl_Batas) VALUES ('" & noinduk2.Text & "','" & nama2.Text & "','" & kelas2.Text & "','" & jurusan2.Text & "','" & judul2.Text & "','" & pengarang2.Text & "','" & penerbit2.Text & "','" & tahun2.Text & "','" & Finger3.Text & "','" & barcode2.Text & "','" & tanggal1.Text & "','" & tanggal2.Text & "')", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Information")
                Call kosongkan()
                Call tampilDGV1()
            Catch ex As Exception
                MsgBox("Data gagal disimpan !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                CONN.Close()
                Return
            End Try
        End If
    End Sub
    Private Sub erase3_Click(sender As Object, e As EventArgs) Handles erase3.Click
        Call kosongkan()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim tanggal As Date
        Dim Batas As Date
        Dim jumlah As Integer = 7
        Dim dendah As Integer = 1000

        waktu1.Text = TimeOfDay

        tanggal = Date.Today
        tanggal1.Text = tanggal.ToString("dd-MM-yyyy")

        Batas = tanggal.AddDays(jumlah)
        tanggal2.Text = Batas.ToString("dd-MM-yyyy")
    End Sub
    Private Sub DGV4_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV4.CellMouseClick
        Dim Batas2 As Date
        Try
            numbers.Text = DGV4.Rows(e.RowIndex).Cells(0).Value
            tanggal2.Text = DGV4.Rows(e.RowIndex).Cells(10).Value
            'Dim kembali As String = kembali2.Text
            'Dim time As DateTime = DateTime.Parse(kembali)
            'Console.WriteLine(time)

            Batas2 = Date.Today
            tanggal1.Text = Batas2.ToString("dd-MM-yyyy")

            'selisih.Text = DateDiff(DateInterval.Day, time, Batas2)
            'denda.Text = Val(selisih.Text) * 1000
        Catch ex As Exception
            MsgBox("Data not found !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    '''''''''''''''''''''Data Pengembalian'''''''''''''''''''''''''
    Private Sub del3_Click(sender As Object, e As EventArgs) Handles del3.Click
        If numbers.Text = "" Then
            MsgBox("Tidak Ada Data Yang Dihapus")
            Exit Sub
        End If
        Try
            If MessageBox.Show("Apakah data ingin dihapus ?", "Konfirmasi hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Call Koneksi()
                CMD = New OdbcCommand("delete from datapinjam where No='" & numbers.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus")
                Call tampilDGV4()
                Call kosongkan()
            Else
                CONN.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Data gagal dihapus !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            CONN.Close()
        End Try
    End Sub
    Private Sub search4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles search4.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                If search4.Text = "" Then
                    Call tampilDGV4()
                    Return
                End If
                Call Koneksi()
                CMD = New OdbcCommand("Select * from datapinjam  where NIM like '%" & search4.Text & "%' or Nama like '%" & search4.Text & "%'or Kelas like '%" & search4.Text & "%'or Jurusan like '%" & search4.Text & "%' or Judul_Buku like '%" & search4.Text & "%'or Pengarang like '%" & search4.Text & "%' or Penerbit like '%" & search4.Text & "%'or Tahun like '%" & search4.Text & "%' ", CONN)
                DR = CMD.ExecuteReader
                DR.Read()

                If DR.HasRows Then
                    Call Koneksi()
                    DA = New OdbcDataAdapter("Select * from datapinjam  where NIM like '%" & search4.Text & "%' or Nama like '%" & search4.Text & "%'or Kelas like '%" & search4.Text & "%'or Jurusan like '%" & search4.Text & "%' or Judul_Buku like '%" & search4.Text & "%'or Pengarang like '%" & search4.Text & "%' or Penerbit like '%" & search4.Text & "%'or Tahun like '%" & search4.Text & "%' ", CONN)
                    DS = New DataSet
                    DA.Fill(DS, "KetemuData")
                    DGV4.DataSource = DS.Tables("KetemuData")
                    DGV4.ReadOnly = True
                Else
                    MsgBox("Data Tidak Ada, Silahkan coba lagi!")
                    search4.Focus()
                End If
            Catch ex As Exception
                MsgBox("Data not found !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Finally
                CONN.Close()
            End Try
        End If
    End Sub
    Private Sub cari7_Click(sender As Object, e As EventArgs) Handles cari7.Click
        Try
            If search4.Text = "" Then
                Call tampilDGV4()
                Return
            End If
            Call Koneksi()
            CMD = New OdbcCommand("Select * from datapinjam  where NIM like '%" & search4.Text & "%' or Nama like '%" & search4.Text & "%'or Kelas like '%" & search4.Text & "%'or Jurusan like '%" & search4.Text & "%' or Judul_Buku like '%" & search4.Text & "%'or Pengarang like '%" & search4.Text & "%' or Penerbit like '%" & search4.Text & "%'or Tahun like '%" & search4.Text & "%' ", CONN)
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                Call Koneksi()
                DA = New OdbcDataAdapter("Select * from datapinjam  where NIM like '%" & search4.Text & "%' or Nama like '%" & search4.Text & "%'or Kelas like '%" & search4.Text & "%'or Jurusan like '%" & search4.Text & "%' or Judul_Buku like '%" & search4.Text & "%'or Pengarang like '%" & search4.Text & "%' or Penerbit like '%" & search4.Text & "%'or Tahun like '%" & search4.Text & "%' ", CONN)
                DS = New DataSet
                DA.Fill(DS, "KetemuData")
                DGV4.DataSource = DS.Tables("KetemuData")
                DGV4.ReadOnly = True
            Else
                MsgBox("Data Tidak Ada, Silahkan coba lagi!")
                search4.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data not found !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
        Finally
            CONN.Close()
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
                    info.Text = "Connected"
                    Timer_Serial.Enabled = True
                    MessageBox.Show("Serial Connected", " Note")
                Else
                    'MetroFramework.MetroMessageBox.Show(Me, "Select a COM port first", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MessageBox.Show("Select a COM port first", " Note")
                End If
            Else
                SerialPort1.Close()
                connect.ButtonText = "Connect"
                info.Text = "Disconnected"
                Timer_Serial.Enabled = False
                monitor.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Communication Failed", " Note")
        End Try
    End Sub
    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
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
    Private Sub Timer_Serial_Tick(sender As Object, e As EventArgs) Handles Timer_Serial.Tick
        Try
            receivedData = SerialPort1.ReadExisting
            monitor.Text &= receivedData
            finger1.Text &= receivedData
            finger2.Text &= receivedData
            Finger3.Text &= receivedData
        Catch ex As Exception
            Timer_Serial.Stop()
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
    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Try
            Form1.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Call Failed", " Note")
        End Try
    End Sub
End Class
