﻿Public Class Form3
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
        FrmInicio.LblTop.Text = ""
    End Sub
End Class