Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class spt_monitor
    <Key>
    <Column(Order:=0)>
    Public Property lastrun As Date

    <Key>
    <Column(Order:=1)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property cpu_busy As Integer

    <Key>
    <Column(Order:=2)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property io_busy As Integer

    <Key>
    <Column(Order:=3)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property idle As Integer

    <Key>
    <Column(Order:=4)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property pack_received As Integer

    <Key>
    <Column(Order:=5)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property pack_sent As Integer

    <Key>
    <Column(Order:=6)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property connections As Integer

    <Key>
    <Column(Order:=7)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property pack_errors As Integer

    <Key>
    <Column(Order:=8)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property total_read As Integer

    <Key>
    <Column(Order:=9)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property total_write As Integer

    <Key>
    <Column(Order:=10)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property total_errors As Integer
End Class
