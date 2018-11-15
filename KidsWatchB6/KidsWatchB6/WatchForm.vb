﻿Public Class WatchForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeLabel.Text = TimeOfDay.ToString("hh:mm tt")
        DateLabel.Text = TimeOfDay.ToString("D")
        PhoneApp.Show()
        'Make all other panels not visible
        ContactPanel.Visible = False
        ContactPanel1.Visible = False
        ContactPanel2.Visible = False
        PaymentPanel.Visible = False
        PaymentPanel1.Visible = False
        PaymentPanel2.Visible = False
        SchedulePanel.Visible = False
        SchedulePanel1.Visible = False
        GamesPanel.Visible = False
        GamesPanel1.Visible = False
        MusicPanel.Visible = False
    End Sub

    Private Sub RightButton_Click(sender As Object, e As EventArgs) Handles RightButton.Click
        ClockPanel.Visible = False
        ContactPanel.Visible = True
    End Sub

    Private Sub ContactLeft_Click(sender As Object, e As EventArgs) Handles ContactLeft.Click
        ClockPanel.Visible = True
        ContactPanel.Visible = False
    End Sub

    Private Sub ContactRight_Click(sender As Object, e As EventArgs) Handles ContactRight.Click
        ContactPanel.Visible = False
        PaymentPanel.Visible = True
    End Sub

    Private Sub PaymentLeft_Click(sender As Object, e As EventArgs) Handles PaymentLeft.Click
        PaymentPanel.Visible = False
        ContactPanel.Visible = True
    End Sub

    Private Sub PaymentRight_Click(sender As Object, e As EventArgs) Handles PaymentRight.Click
        PaymentPanel.Visible = False
        SchedulePanel.Visible = True
    End Sub

    Private Sub ScheduleLeft_Click(sender As Object, e As EventArgs) Handles ScheduleLeft.Click
        SchedulePanel.Visible = False
        PaymentPanel.Visible = True
    End Sub
    Private Sub ScheduleRight_Click(sender As Object, e As EventArgs) Handles ScheduleRight.Click
        SchedulePanel.Visible = False
        GamesPanel.Visible = True
    End Sub
    Private Sub GamesLeft_Click(sender As Object, e As EventArgs) Handles GamesLeft.Click
        SchedulePanel.Visible = True
        GamesPanel.Visible = False
    End Sub

    Private Sub GamesRight_Click(sender As Object, e As EventArgs) Handles GamesRight.Click
        GamesPanel.Visible = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ContactDown_Click(sender As Object, e As EventArgs) Handles ContactDown.Click
        ContactPanel.Visible = False
        ContactPanel1.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ContactPanel.Visible = True
        ContactPanel1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ContactPanel1.Visible = False
        ContactPanel2.Visible = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ContactPanel2.Visible = False
        ContactPanel1.Visible = True
    End Sub

    Private Sub PaymentDown_Click(sender As Object, e As EventArgs) Handles PaymentDown.Click
        PaymentPanel.Visible = False
        PaymentPanel1.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PaymentPanel.Visible = True
        PaymentPanel1.Visible = False
    End Sub
End Class
