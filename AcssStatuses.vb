Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class AcssStatuses
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    <StringLength(64)>
    Public Property Name As String

    Public Property LocationLatitude As Double

    Public Property LocationLongitude As Double

    Public Property MinRange As Integer

    Public Property MaxRange As Integer

    Public Property AzimuthFrom As Double

    Public Property AzimuthTo As Double

    Public Property OperatingMode As Short

    Public Property Connected As Integer
End Class
