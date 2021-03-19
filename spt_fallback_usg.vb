Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class spt_fallback_usg
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

    Public Property xfallback_vstart As Integer?

    <Key>
    <Column(Order:=3)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property dbid As Short

    <Key>
    <Column(Order:=4)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property segmap As Integer

    <Key>
    <Column(Order:=5)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property lstart As Integer

    <Key>
    <Column(Order:=6)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property sizepg As Integer

    <Key>
    <Column(Order:=7)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property vstart As Integer
End Class
