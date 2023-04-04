Imports System.Runtime.Serialization
<Serializable>
Public Class PostModelo
    Public userId As Integer
    Public id As Integer
    Public title As String
    Public body As String

    Private userIdL_ As String
    Public Property userIdL() As Integer
        Get
            Return userId
        End Get
        Set(value As Integer)
            userId = value
        End Set
    End Property

    Private idL_ As String
    Public Property idL() As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Private titleL_ As String
    Public Property titleL() As String
        Get
            Return title
        End Get
        Set(value As String)
            title = value
        End Set
    End Property

    Private bodyL_ As String
    Public Property bodyL() As String
        Get
            Return body
        End Get
        Set(value As String)
            body = value
        End Set
    End Property
End Class
