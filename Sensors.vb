Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Sensors
    <Key>
    Public Property SensorID As Long

    <Required>
    <StringLength(50)>
    Public Property SensorName As String

    Public Property Latitude As Double

    Public Property Longitude As Double
End Class
