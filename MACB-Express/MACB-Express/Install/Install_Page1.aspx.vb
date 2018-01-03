Public Class Install_Page1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'My.Settings.DBName = tbDBName.Text
        'My.Settings.DBPort = tbDBPort.Text
        'My.Settings.Save()

        Response.Redirect(".\Install_page2.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SqlDataSource1.ConnectionString = "Data Source=FASTAR-ZN-VMVS;Persist Security Info=True;User ID=sa;Password=zn8915383"
        SqlDataSource1.SelectCommand = "SELECT name FROM master.sys.sysdatabases"
        Dim dv As DataView = SqlDataSource1.Select(DataSourceSelectArguments.Empty)
        Dim S As String = ""
        For I As Long = 0 To dv.Table.Rows.Count - 1
            S = S & dv.Table.Rows.Item(I).Item(0).ToString & vbCrLf
        Next

        Label1.Text = S
    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles form1.Load
        'tbDBName.Text = My.Settings.DBName
        'tbDBPort.Text = My.Settings.DBPort
        'tbDBUser.Text = My.Settings.DBUser
        'tbDBPass.Text = My.Settings.DBPass

    End Sub
End Class