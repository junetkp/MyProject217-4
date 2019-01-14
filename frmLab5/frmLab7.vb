﻿Public Class frmLab7
    Private Sub frmLap7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub

    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text <> "" Then
            btnAdd.Enabled = True
        Else
            btnAdd.Enabled = False
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        lstAdd.SelectedIndex = lstAdd.Items.Count - 1

        txtAdd.Clear()
        txtAdd.Select()
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        If lstAdd.Items.Count = 0 Then
            MessageBox.Show("ไม่มีข้อมูลใน Lisbox")
            Exit Sub
        ElseIf lstAdd.Items.Count <> 0 Then
            cboOutput.Items.Add(lstAdd.SelectedItem)

            Dim n As Integer
            n = lstAdd.SelectedIndex

            If lstAdd.SelectedIndex = lstAdd.Items.Count - 1 Then

                lstAdd.Items.RemoveAt(lstAdd.SelectedIndex)
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Else
                lstAdd.Items.RemoveAt(lstAdd.SelectedIndex)
                lstAdd.SelectedIndex = n
            End If

            cboOutput.SelectedIndex = cboOutput.Items.Count - 1

        End If
    End Sub

    Private Sub cboOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOutput.SelectedIndexChanged
        lblOutput.Text = cboOutput.Text
    End Sub

    Private Sub btnMoveAll_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        If lstAdd.Items.Count = 0 Then
            MessageBox.Show("ไม่มีข้อมูลใน ListBox")
        Else
            For Each item As Object In lstAdd.Items
                cboOutput.Items.Add(item)
                cboOutput.SelectedIndex = 0
            Next
            lstAdd.Items.Clear()
        End If
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If cboOutput.Items.Count = 0 Then
            MessageBox.Show("ไม่มีข้อมูลใน ComboBox")

        ElseIf cboOutput.Items.Count <> 0 Then
            lstAdd.Items.Add(cboOutput.SelectedItem)

            Dim n As Integer
            n = cboOutput.SelectedIndex

            If cboOutput.SelectedIndex = cboOutput.Items.Count - 1 Then

                cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)
                cboOutput.SelectedIndex = cboOutput.Items.Count - 1
            Else
                cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)
                cboOutput.SelectedIndex = n
            End If

            lstAdd.SelectedIndex = lstAdd.Items.Count - 1
        End If

        If cboOutput.Items.Count = 0 Then
            cboOutput.Text = ""
            lblOutput.Text = ""
        End If
    End Sub

    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click
        If cboOutput.Items.Count = 0 Then
            MessageBox.Show("ไม่มีข้อมูลใน ComboBox")
        Else
            For Each item As Object In cboOutput.Items
                lstAdd.Items.Add(item)
            Next
            cboOutput.Items.Clear()

            Dim list As New List(Of Object)

            For Each item As String In list
                lstAdd.Items.Add(item)
                cboOutput.Items.Remove(item)
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Next
            If cboOutput.SelectedItem = 0 Then
                cboOutput.Text = ""
                lblOutput.Text = ""
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstAdd.Items.Clear()
        cboOutput.Items.Clear()
        lblOutput.Text = ""
        txtAdd.Clear()
        btnAdd.Enabled = False
    End Sub
End Class