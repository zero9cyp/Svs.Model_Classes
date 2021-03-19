Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class VesselHistories
    <Key>
    Public Property HistoryID As Integer

    <StringLength(64)>
    Public Property VesselName As String

    <StringLength(8)>
    Public Property CallSign As String

    Public Property IMONumber As Long?

    <Required>
    <StringLength(16)>
    Public Property MMSI As String

    Public Property ShipType As Integer?

    Public Property Updated As Date
End Class
