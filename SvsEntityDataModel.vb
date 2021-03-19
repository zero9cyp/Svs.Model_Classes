Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class SvsEntityDataModel
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=SvsEntityDataModel")
    End Sub

    Public Overridable Property AcssCategories As DbSet(Of AcssCategories)
    Public Overridable Property AcssStatuses As DbSet(Of AcssStatuses)
    Public Overridable Property Layers As DbSet(Of Layers)
    Public Overridable Property MSreplication_options As DbSet(Of MSreplication_options)
    Public Overridable Property Sensors As DbSet(Of Sensors)
    Public Overridable Property ShipTypes As DbSet(Of ShipTypes)
    Public Overridable Property Situations As DbSet(Of Situations)
    Public Overridable Property spt_fallback_db As DbSet(Of spt_fallback_db)
    Public Overridable Property spt_fallback_dev As DbSet(Of spt_fallback_dev)
    Public Overridable Property spt_fallback_usg As DbSet(Of spt_fallback_usg)
    Public Overridable Property spt_monitor As DbSet(Of spt_monitor)
    Public Overridable Property spt_values As DbSet(Of spt_values)
    Public Overridable Property Tracks As DbSet(Of Tracks)
    Public Overridable Property Updates As DbSet(Of Updates)
    Public Overridable Property VesselHistories As DbSet(Of VesselHistories)
    Public Overridable Property Vessels As DbSet(Of Vessels)
    Public Overridable Property vwCurrentSituation1 As DbSet(Of vwCurrentSituation1)
    Public Overridable Property vwCurrentSituations As DbSet(Of vwCurrentSituations)
    Public Overridable Property MaritimeIdentificationDigits As DbSet(Of MaritimeIdentificationDigits)
    Public Overridable Property vwCurrentSituation As DbSet(Of vwCurrentSituation)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Situations)() _
            .Property(Function(e) e.TrackNo) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Situations)() _
            .Property(Function(e) e.DataSource) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Situations)() _
            .Property(Function(e) e.MMSI) _
            .IsUnicode(False)

        modelBuilder.Entity(Of spt_fallback_db)() _
            .Property(Function(e) e.xserver_name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of spt_fallback_db)() _
            .Property(Function(e) e.name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of spt_fallback_dev)() _
            .Property(Function(e) e.xserver_name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of spt_fallback_dev)() _
            .Property(Function(e) e.xfallback_drive) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of spt_fallback_dev)() _
            .Property(Function(e) e.name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of spt_fallback_dev)() _
            .Property(Function(e) e.phyname) _
            .IsUnicode(False)

        modelBuilder.Entity(Of spt_fallback_usg)() _
            .Property(Function(e) e.xserver_name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of spt_values)() _
            .Property(Function(e) e.type) _
            .IsFixedLength()

        modelBuilder.Entity(Of Tracks)() _
            .Property(Function(e) e.TrackNo) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Tracks)() _
            .Property(Function(e) e.DataSource) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Tracks)() _
            .Property(Function(e) e.NssAmplification) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Tracks)() _
            .Property(Function(e) e.NssStatus) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Tracks)() _
            .Property(Function(e) e.NssPort) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Tracks)() _
            .Property(Function(e) e.NssCategoryIdentity) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Tracks)() _
            .Property(Function(e) e.MMSI) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Updates)() _
            .Property(Function(e) e.DataSource) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Updates)() _
            .Property(Function(e) e.MessageSource) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Updates)() _
            .HasMany(Function(e) e.Tracks) _
            .WithRequired(Function(e) e.Updates) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of vwCurrentSituation1)() _
            .Property(Function(e) e.TrackNo) _
            .IsUnicode(False)

        modelBuilder.Entity(Of vwCurrentSituation1)() _
            .Property(Function(e) e.CountryAISCode) _
            .IsUnicode(False)

        modelBuilder.Entity(Of vwCurrentSituation1)() _
            .Property(Function(e) e.MMSI) _
            .IsUnicode(False)

        modelBuilder.Entity(Of vwCurrentSituation1)() _
            .Property(Function(e) e.DataSource) _
            .IsUnicode(False)

        modelBuilder.Entity(Of vwCurrentSituations)() _
            .Property(Function(e) e.TrackNo) _
            .IsUnicode(False)

        modelBuilder.Entity(Of vwCurrentSituations)() _
            .Property(Function(e) e.CountryAISCode) _
            .IsUnicode(False)

        modelBuilder.Entity(Of vwCurrentSituations)() _
            .Property(Function(e) e.MMSI) _
            .IsUnicode(False)

        modelBuilder.Entity(Of vwCurrentSituations)() _
            .Property(Function(e) e.DataSource) _
            .IsUnicode(False)

        modelBuilder.Entity(Of MaritimeIdentificationDigits)() _
            .Property(Function(e) e.Digit) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of vwCurrentSituation)() _
            .Property(Function(e) e.TrackNo) _
            .IsUnicode(False)

        modelBuilder.Entity(Of vwCurrentSituation)() _
            .Property(Function(e) e.CountryAISCode) _
            .IsUnicode(False)

        modelBuilder.Entity(Of vwCurrentSituation)() _
            .Property(Function(e) e.MMSI) _
            .IsUnicode(False)

        modelBuilder.Entity(Of vwCurrentSituation)() _
            .Property(Function(e) e.DataSource) _
            .IsUnicode(False)
    End Sub
End Class
