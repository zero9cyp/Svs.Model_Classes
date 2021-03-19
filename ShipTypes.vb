Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class ShipTypes
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property ShipTypeID As Integer

    <StringLength(255)>
    Public Property ShipType As String

    <StringLength(255)>
    Public Property Summary As String

    Public Property Description As String
End Class
