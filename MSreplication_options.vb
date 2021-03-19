Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class MSreplication_options
    <Key>
    <Column(Order:=0)>
    Public Property optname As String

    <Key>
    <Column(Order:=1)>
    Public Property value As Boolean

    <Key>
    <Column(Order:=2)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property major_version As Integer

    <Key>
    <Column(Order:=3)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property minor_version As Integer

    <Key>
    <Column(Order:=4)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property revision As Integer

    <Key>
    <Column(Order:=5)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property install_failures As Integer
End Class
