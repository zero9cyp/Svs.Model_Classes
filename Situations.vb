Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Situations
    <Key>
    Public Property SituationID As Long

    <Required>
    <StringLength(16)>
    Public Property TrackNo As String

    <StringLength(64)>
    Public Property DataSource As String

    Public Property DateInitiated As Date

    Public Property DateLastUpdate As Date

    Public Property DateLost As Date?

    Public Property Latitude As Double

    Public Property Longitude As Double

    Public Property COG As Double

    Public Property SOG As Double

    Public Property NavigationStatus As Integer

    <StringLength(9)>
    Public Property MMSI As String

    <StringLength(128)>
    Public Property VesselName As String

    <StringLength(512)>
    Public Property VesselDescription As String

    Public Property NoOfDetectors As Integer

    <StringLength(512)>
    Public Property IDsOfDetectors As String

    <StringLength(16)>
    Public Property Amplification As String

    <StringLength(16)>
    Public Property Category As String

    <StringLength(16)>
    Public Property Identity As String
End Class
