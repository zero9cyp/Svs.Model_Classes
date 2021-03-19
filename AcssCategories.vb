Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class AcssCategories
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property CategoryID As Integer

    <Required>
    <StringLength(64)>
    Public Property CategoryName As String
End Class
