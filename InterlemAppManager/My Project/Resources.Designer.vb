﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Il codice è stato generato da uno strumento.
'     Versione runtime:4.0.30319.42000
'
'     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
'     il codice viene rigenerato.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Questa classe è stata generata automaticamente dalla classe StronglyTypedResourceBuilder.
    'tramite uno strumento quale ResGen o Visual Studio.
    'Per aggiungere o rimuovere un membro, modificare il file con estensione ResX ed eseguire nuovamente ResGen
    'con l'opzione /str oppure ricompilare il progetto VS.
    '''<summary>
    '''  Classe di risorse fortemente tipizzata per la ricerca di stringhe localizzate e così via.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Restituisce l'istanza di ResourceManager nella cache utilizzata da questa classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("InterlemAppManager.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Esegue l'override della proprietà CurrentUICulture del thread corrente per tutte le
        '''  ricerche di risorse eseguite utilizzando questa classe di risorse fortemente tipizzata.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property antex_logo_circolare() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("antex_logo_circolare", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a &lt;iframe src=&quot;https://calendar.google.com/calendar/embed?src=giacomo.guaresi%40interlem.it&amp;ctz=Europe%2FRome&quot; style=&quot;border: 0&quot; width=&quot;800&quot; height=&quot;600&quot; frameborder=&quot;0&quot; scrolling=&quot;no&quot;&gt;&lt;/iframe&gt;.
        '''</summary>
        Friend ReadOnly Property calendar() As String
            Get
                Return ResourceManager.GetString("calendar", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Versione:	1.2.0
        ''' + aggiunta connessione mail tramite smtp
        ''' + aggiunto pannello impostazioni messaggi e profili 
        ''' + aggiunto tasto synk per sincronizzazione istantanea
        '''
        '''Versione:	1.1.1
        ''' * diminuita sensibilità spostamento
        ''' * cambiato font changelog
        '''
        '''Versione:	1.1.0
        '''Data: 08-02-2018
        ''' + aggiunto CLI per testing delle varie funzioni
        ''' + aggiunta possibilità di spostare la barra sull&apos;asse y 
        ''' * cambiato colore barra 
        '''
        '''Versione:	1.0.1
        '''Data:	30-01-2018  
        ''' + aggiunto changelog
        ''' + aggiunto autoview  [stringa troncata]&quot;;.
        '''</summary>
        Friend ReadOnly Property ChangeLog() As String
            Get
                Return ResourceManager.GetString("ChangeLog", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property credit() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("credit", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property cropped_siteicon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("cropped-siteicon", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Gmail() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Gmail", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property google_calendar() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("google-calendar", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property hangouts() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("hangouts", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property hangouts1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("hangouts1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icon_hourly() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon-hourly", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property openProject_logo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("openProject_logo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property

        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property keep_512() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("keep_512", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
    End Module
End Namespace
