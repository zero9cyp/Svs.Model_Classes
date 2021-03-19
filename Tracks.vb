Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Tracks
    <Key>
    Public Property TrackID As Long

    Public Property UpdateID As Long

    <Required>
    <StringLength(16)>
    Public Property TrackNo As String

    <StringLength(64)>
    Public Property DataSource As String

    Public Property Latitude As Double

    Public Property Longitude As Double

    Public Property COG As Double

    Public Property SOG As Double

    Public Property NavigationStatus As Integer

    Public Property DateRecieved As Date

    <Required>
    <StringLength(8)>
    Public Property NssAmplification As String

    <Required>
    <StringLength(2)>
    Public Property NssStatus As String

    <Required>
    <StringLength(4)>
    Public Property NssPort As String

    <Required>
    <StringLength(4)>
    Public Property NssCategoryIdentity As String

    <StringLength(256)>
    Public Property NssRemarks As String

    <StringLength(128)>
    Public Property VesselName As String

    <StringLength(9)>
    Public Property MMSI As String

    Public Property Confidence As Double?

    Public Property AcssCategory As Integer

    Public Property AcssStatus As Integer

    Public Property AcssType As Integer

    Public Property AcssNoOfDetectors As Integer

    <StringLength(256)>
    Public Property AcssIDsOfDetectors As String

    Public Overridable Property Updates As Updates
End Class
