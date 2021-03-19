Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Vessels
    <Key>
    Public Property VesselID As Integer

    <StringLength(64)>
    Public Property VesselName As String

    <StringLength(8)>
    Public Property CallSign As String

    Public Property IMONumber As Long?

    <StringLength(16)>
    Public Property MMSI As String

    Public Property ShipType As Integer

    <StringLength(64)>
    Public Property NssName As String

    <StringLength(32)>
    Public Property NssClass As String

    <StringLength(16)>
    Public Property NssType As String

    <StringLength(16)>
    Public Property NssPennantNumber As String

    Public Property LastUpdate As Date
End Class
