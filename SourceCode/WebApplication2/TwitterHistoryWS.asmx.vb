Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports MySql.Data.MySqlClient

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class TwitterHistoryWS
    Inherits System.Web.Services.WebService

    Private constring As String = "Server=cse.unl.edu;Database=pmorrow;Uid=pmorrow;Pwd=ep3jcS"
    Private conn As MySqlConnection = New MySqlConnection
    Private comm As MySqlCommand
    Private reader As MySqlDataReader

    <WebMethod(Description:="Gets the user list")>
    Public Function GetUsers() As DataSet
        Dim mySQLQuery = "SELECT screen_name FROM users"

        conn.ConnectionString = constring
        conn.Open()

        Dim MyAdapter As New MySqlDataAdapter(mySQLQuery, conn)
        comm = New MySqlCommand()
        comm.Connection = conn
        comm.CommandType = System.Data.CommandType.Text
        comm.CommandText = mySQLQuery
        MyAdapter.SelectCommand = comm
        Dim users As DataSet = New DataSet()

        MyAdapter.Fill(users, "users")
        Return users

        conn.Close()

    End Function

    Public Function GetFeed() As DataSet
        Dim mySQLQuery = "SELECT screen_name FROM users"

        conn.ConnectionString = constring
        conn.Open()

        Dim MyAdapter As New MySqlDataAdapter(mySQLQuery, conn)
        comm = New MySqlCommand()
        comm.Connection = conn
        comm.CommandType = System.Data.CommandType.Text
        comm.CommandText = mySQLQuery
        MyAdapter.SelectCommand = comm
        Dim users As DataSet = New DataSet()

        MyAdapter.Fill(users, "users")
        Return users

        conn.Close()

    End Function

End Class