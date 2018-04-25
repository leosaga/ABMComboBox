Imports System.Xml

Imports System.IO
Public Class Form1


    Private Sub Alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alta.Click
        TextBox1.Focus()
        If TextBox1.Text.Trim = "" Then Exit Sub


        ComboBox1.Items.Add(TextBox1.Text.Trim)


        TextBox1.Clear()
    End Sub

    Private Sub Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Baja.Click
        TextBox1.Focus()
        'control de esexion(sin seleccion de lista)
        If ComboBox1.SelectedIndex = -1 Then Exit Sub
        'borra la fila del combobox1
        ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex)



        TextBox1.Clear()
    End Sub

    Private Sub modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modificar.Click
        TextBox1.Focus()
        'control de esexion(sin seleccion de lista)
        If ComboBox1.SelectedIndex = -1 Then Exit Sub

        ComboBox1.Items.Item(ComboBox1.SelectedIndex) = TextBox1.Text
        'TextBox1.Text = ComboBox1.Items.Item(ComboBox1.SelectedIndex)
        'combobox no tiene clearselected
        TextBox1.Clear()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Focus()
        'control de esexion(sin seleccion de lista)
        If ComboBox1.SelectedIndex = -1 Then Exit Sub

        'graba lo que seleccionamos en el listbox
        TextBox1.Text = ComboBox1.Items.Item(ComboBox1.SelectedIndex)
    End Sub

    Private Sub GrabarXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrabarXml.Click
        Dim ruta As String
        ruta = CurDir.Substring(0, CurDir.Length - 9)
        Dim escritor As New XmlTextWriter(ruta + "lista.xml", System.Text.Encoding.UTF8)
        escritor.WriteStartDocument(True)
        escritor.Formatting = Formatting.Indented
        'tabulacion (es como una sangria)
        escritor.Indentation = (4)
        escritor.WriteStartElement("lista")
        Dim x As Integer
        For x = 0 To ComboBox1.Items.Count - 1
            escritor.WriteStartElement("elemento")
            escritor.WriteString(ComboBox1.Items.Item(x).ToString)
            escritor.WriteEndElement()
        Next
        escritor.WriteEndElement()
        escritor.WriteEndDocument()
        escritor.Close()

        MsgBox("guardado correctamente")
        TextBox1.Focus()
    End Sub

    Private Sub LeerXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeerXml.Click
        Dim xmld As New XmlDocument
        Dim listanodos As XmlNodeList
        Dim nodo As XmlNode
        Dim ruta As String
        ruta = CurDir().Substring(0, CurDir().Length - 9)
        If Not File.Exists(ruta + "lista.xml") Then Exit Sub
        xmld.Load(ruta + "lista.xml")
        listanodos = xmld.SelectNodes("lista/elemento")
        For Each nodo In listanodos
            ComboBox1.Items.Add(nodo.InnerText)

        Next
        TextBox1.Focus()
    End Sub
End Class
