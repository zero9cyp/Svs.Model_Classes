Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("vwCurrentSituation")>
Partial Public Class vwCurrentSituation
    <Key>
    <Column(Order:=0)>
    <StringLength(16)>
    Public Property TrackNo As String

    Public Property geometry As DbGeography

    <Key>
    <Column(Order:=1)>
    Public Property Latitude As Double

    <Key>
    <Column(Order:=2)>
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

    <StringLength(128)>
    Public Property VesselName As String

    Public Property IMONumber As Long?

    Public Property ShipType As Integer?

    <StringLength(255)>
    Public Property ShipTypeName As String

    <StringLength(255)>
    Public Property ShipTypeClass As String

    <Key>
    <Column(Order:=3)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property NavigationStatus As Integer

    <Key>
    <Column(Order:=4)>
    Public Property COG As Double

    <Key>
    <Column(Order:=5)>
    Public Property SOG As Double

    <StringLength(64)>
    Public Property DataSource As String

    <Key>
    <Column(Order:=6)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property NoOfDetectors As Integer

    <StringLength(512)>
    Public Property IDsOfDetectors As String

    <Key>
    <Column(Order:=7, TypeName:="datetime2")>
    Public Property DateInitiated As Date

    <Key>
    <Column(Order:=8, TypeName:="datetime2")>
    Public Property LastUpdate As Date

    <StringLength(16)>
    Public Property Amplification As String

    <StringLength(16)>
    Public Property Category As String

    <StringLength(16)>
    Public Property Identity As String

    <StringLength(512)>
    Public Property VesselDescription As String
End Class
