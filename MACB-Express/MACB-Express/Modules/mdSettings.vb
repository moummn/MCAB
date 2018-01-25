Module mdSettings
    Friend DBName As String = "(local)"
    Friend DBPort As String = "1433"
    Friend DBUser As String = "sa"
    Friend DBPasw As String = ""
    Private Function FnGetDefaultXML() As System.Xml.XmlDocument
        Dim XD As New System.Xml.XmlDocument
        Dim XN As System.Xml.XmlNode
        Dim XE As System.Xml.XmlElement
        XD.LoadXml("<DBSettings></DBSettings>")
        XN = XD.SelectSingleNode("DBSettings")
        XE = XD.CreateElement("DBSettings1")
        XE.SetAttribute("DBName", "(local)")
        'XD.AppendChild()
        Return XD
    End Function
    ''' <summary>
    ''' 读取保存的XML设置
    ''' </summary>
    Public Sub LoadSettings()
        Dim XD As New System.Xml.XmlDocument

        Try
            XD.Load("C:\Users\mmnst\Desktop\Settings.XML")
        Catch ex As System.IO.FileNotFoundException
            XD = FnGetDefaultXML()
        Catch ex As System.UnauthorizedAccessException
            XD = FnGetDefaultXML()
            'Catch ex As Exception
        End Try
        XD.Save("C:\Users\mmnst\Desktop\Settings.XML")
    End Sub

End Module
