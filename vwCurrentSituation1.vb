Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class vwCurrentSituation1
    <Key>
    <StringLength(16)>
    Public Property TrackNo As String

    Public Property geometry As DbGeography

    Public Property Latitude As Double

    Public Property Longitude As Double

    <StringLength(3)>
    Public Property CountryAISCode As String

    <StringLength(255)>
    Public Property Country As String

    <StringLength(8)>
    Public Property CountryISOCode As String

    <StringLength(8)>
    Public Property ISOCode3 As String

    <StringLength(8)>
    Public Property CallSign As String

    <StringLength(9)>
    Public Property MMSI As String

    <StringLength(512)>
    Public Property VesselDescription As String

    <StringLength(128)>
    Public Property VesselName As String

    Public Property IMONumber As Long?

    Public Property ShipType As Integer?

    <StringLength(255)>
    Public Property ShipTypeName As String

    <StringLength(255)>
    Public Property ShipTypeClass As String

    Public Property NavigationStatus As Integer

    Public Property COG As Double

    Public Property SOG As Double

    <StringLength(64)>
    Public Property DataSource As String

    <StringLength(512)>
    Public Property IDsOfDetectors As String

    Public Property NoOfDetectors As Integer

    Public Property DateInitiated As Date

    Public Property LastUpdate As Date

    <StringLength(16)>
    Public Property Amplification As String

    <StringLength(16)>
    Public Property Category As String

    <StringLength(16)>
    Public Property Identity As String
End Class
