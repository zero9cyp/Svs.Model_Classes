Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class spt_values
    <StringLength(35)>
    Public Property name As String

    <Key>
    <Column(Order:=0)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property number As Integer

    <Key>
    <Column(Order:=1)>
    <StringLength(3)>
    Public Property type As String

    Public Property low As Integer?

    Public Property high As Integer?

    Public Property status As Integer?
End Class
