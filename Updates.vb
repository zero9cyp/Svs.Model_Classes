Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Updates
    Public Sub New()
        Tracks = New HashSet(Of Tracks)()
    End Sub

    <Key>
    Public Property UpdateID As Long

    Public Property DateReceived As Date

    <StringLength(64)>
    Public Property DataSource As String

    Public Property MessageSource As String

    Public Overridable Property Tracks As ICollection(Of Tracks)
End Class
