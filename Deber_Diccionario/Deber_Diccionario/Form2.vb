Imports System.IO
Public Class Form2
    Dim file As New OpenFileDialog()
    Dim list_diccionario As New List(Of String)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim palabra, definicion, dic As String
        palabra = txtPalabra.Text
        definicion = txtSignificado.Text
        dic = palabra + ":" + definicion + ":" + file.FileName
        Dim item1 As ListViewItem
        item1 = New ListViewItem(palabra, 0)
        item1.SubItems.Add(palabra)
        item1.SubItems.Add(definicion)
        Dim escribir As New StreamWriter("C:\Users\krafd\Documents\visual\diccionario.txt", True)
        escribir.WriteLine(palabra)
        escribir.WriteLine(definicion)
        escribir.Close()

        Form4.lvDiccionario.Items.Add(item1)
        Form3.lvDiccionario.Items.Add(item1.Clone)
        MsgBox("SE AGUARDADO CORRECTAMENTE")
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Form3.lvDiccionario =
        'Form4.lvDiccionario =

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        file.Filter = "Archivo JPG|*.jpg"

        If file.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(file.FileName)
            'MsgBox(file.FileName)
        End If
    End Sub
End Class