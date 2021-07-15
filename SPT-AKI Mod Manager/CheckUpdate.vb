﻿Imports System.Windows.Forms

Public Class CheckUpdate

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://mods.sp-tarkov.com/files/file/221-spt-aki-mod-manager")
    End Sub

    Private Sub CheckUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Version " + Form1.latestVersion.ToString + " is now available to download!"
    End Sub
End Class
