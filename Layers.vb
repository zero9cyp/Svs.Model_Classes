Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Layers
    Public Property id As Integer

    <Required>
    <StringLength(64)>
    Public Property label As String

    <StringLength(128)>
    Public Property description As String

    <Required>
    <StringLength(64)>
    Public Property filename As String

    <StringLength(64)>
    Public Property groupname As String

    Public Property sortorder As Integer

    <StringLength(256)>
    Public Property style As String

    Public Property visible As Boolean
End Class
