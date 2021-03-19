Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class MaritimeIdentificationDigits
    <Key>
    <StringLength(3)>
    Public Property Digit As String

    <StringLength(255)>
    Public Property AllocatedTo As String

    <StringLength(8)>
    Public Property ISOCode As String

    <StringLength(8)>
    Public Property ISOCode3 As String

    <StringLength(8)>
    Public Property ISONumeric As String
End Class
