Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class spt_fallback_dev
    <Key>
    <Column(Order:=0)>
    <StringLength(30)>
    Public Property xserver_name As String

    <Key>
    <Column(Order:=1)>
    Public Property xdttm_ins As Date

    <Key>
    <Column(Order:=2)>
    Public Property xdttm_last_ins_upd As Date

    Public Property xfallback_low As Integer?

    <StringLength(2)>
    Public Property xfallback_drive As String

    <Key>
    <Column(Order:=3)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property low As Integer

    <Key>
    <Column(Order:=4)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property high As Integer

    <Key>
    <Column(Order:=5)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property status As Short

    <Key>
    <Column(Order:=6)>
    <StringLength(30)>
    Public Property name As String

    <Key>
    <Column(Order:=7)>
    <StringLength(127)>
    Public Property phyname As String
End Class
