﻿Imports System.IO
Public Class Form3
    Public indiceItem As Integer
    Public path As String
    ':::Ruta donde crearemos nuestro archivo txt
    Dim ruta As String = "C:\Users\krafd\Documents\visual"
    ':::Nombre del archivo
    Dim archivo As String = "diccionario.txt"
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim item1 As ListViewItem = New ListViewItem()
        For Each item1 In lvDiccionario.SelectedItems
            item1.Remove()
        Next

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lvDiccionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDiccionario.SelectedIndexChanged
        Dim indice As Integer
        If lvDiccionario.SelectedItems.Count > 0 Then
            indice = lvDiccionario.SelectedIndices(0)
            lvDiccionario.SelectedItems.Item(0).Remove()
            Form4.lvDiccionario.Items.Item(indice).Remove()
            MsgBox("La palabra ha sido eliminada")

            Dim fs As FileStream
            Dim Directorio As String
            If Dir(Environ("UserProfile") & "\Escritorio\", vbDirectory) <> "" Then Directorio = Environ("USERPROFILE") & "\Escritorio\"
            If Dir(Environ("UserProfile") & "\Desktop\", vbDirectory) <> "" Then Directorio = Environ("USERPROFILE") & "\Desktop\"
        End If
    End Sub
End Class