'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class servicios_citas
    Public Property id As Long
    Public Property fechaInicio As Nullable(Of Date)
    Public Property fechaFin As Nullable(Of Date)
    Public Property nombreServicio As String
    Public Property descripcion As String
    Public Property idTrabajador As Nullable(Of Long)
    Public Property email As String
    Public Property tramoHorario As Nullable(Of System.TimeSpan)
    Public Property personasMax As Nullable(Of Integer)
    Public Property idFrecuencia As Nullable(Of Long)
    Public Property color As String
    Public Property mostrarApp As Nullable(Of Boolean)
    Public Property tipoCita As String
    Public Property noValoracionEsfuerzos As Nullable(Of Boolean)
    Public Property checkRecordar As Nullable(Of Boolean)
    Public Property eliminado As Nullable(Of Boolean)
    Public Property fechaEliminado As Nullable(Of Date)

End Class
