﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class Finnish
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("BEM.Finnish", GetType(Finnish).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Alkuperäinen {0} on varmuuskopioitu ja uusi versio tallennettu onnistuneesti..
        '''</summary>
        Friend Shared ReadOnly Property s_backed_up() As String
            Get
                Return ResourceManager.GetString("s_backed_up", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Olet tehnyt tähän tiedostoon muutoksia, tallenna tämä tiedosto ensin.{0}{0}Jos et tahdo tallentaa, klikkaa OK ja avaa uusi tiedosto uudelleen..
        '''</summary>
        Friend Shared ReadOnly Property s_changes_to_file() As String
            Get
                Return ResourceManager.GetString("s_changes_to_file", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Haluatko varmasti poistaa tämän suodatinmerkinnän?.
        '''</summary>
        Friend Shared ReadOnly Property s_confirm_delete_filter() As String
            Get
                Return ResourceManager.GetString("s_confirm_delete_filter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Haluatko varmasti poistaa tämän avainsanan?.
        '''</summary>
        Friend Shared ReadOnly Property s_confirm_delete_keyword() As String
            Get
                Return ResourceManager.GetString("s_confirm_delete_keyword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tiedostoa &quot;&quot;{0}.txt&quot;&quot; ei voitu paikantaa. Varmista, että olet suorittamassa tätä ohjelmaa serverisi Battleye-hakemistosta..
        '''</summary>
        Friend Shared ReadOnly Property s_could_not_open_file() As String
            Get
                Return ResourceManager.GetString("s_could_not_open_file", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Valmis!.
        '''</summary>
        Friend Shared ReadOnly Property s_done() As String
            Get
                Return ResourceManager.GetString("s_done", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to muokattu.
        '''</summary>
        Friend Shared ReadOnly Property s_edited() As String
            Get
                Return ResourceManager.GetString("s_edited", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tätä tiedostoa ei voitu tallentaa. Tapahtui seuraava virhe:{0}{0}{1}.
        '''</summary>
        Friend Shared ReadOnly Property s_failed_backed_up() As String
            Get
                Return ResourceManager.GetString("s_failed_backed_up", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tekstissä voi olla joitain kenoviivoja jotka täytyy mahdollisesti ohittaa, haluatko korjata ne?.
        '''</summary>
        Friend Shared ReadOnly Property s_fix_backslash() As String
            Get
                Return ResourceManager.GetString("s_fix_backslash", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Valitut kohteet on tuotu. Muistathan tallentaa muutokset..
        '''</summary>
        Friend Shared ReadOnly Property s_items_imported() As String
            Get
                Return ResourceManager.GetString("s_items_imported", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Viimeisin versio.
        '''</summary>
        Friend Shared ReadOnly Property s_latest_version() As String
            Get
                Return ResourceManager.GetString("s_latest_version", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tätä tiedostoa ladattaessa tapahtui virhe, onko kyseessä BattlEye -tiedosto?.
        '''</summary>
        Friend Shared ReadOnly Property s_loading_error() As String
            Get
                Return ResourceManager.GetString("s_loading_error", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sinun täytyy syöttää hakusana. Jos haluat tyhjän hakuasnan, syötä &quot;&quot;.
        '''</summary>
        Friend Shared ReadOnly Property s_need_keyword() As String
            Get
                Return ResourceManager.GetString("s_need_keyword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sinun tulee valita Poikkeustyyppi..
        '''</summary>
        Friend Shared ReadOnly Property s_need_to_exception_type() As String
            Get
                Return ResourceManager.GetString("s_need_to_exception_type", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sinun tulee valita Kirjaustyyppi..
        '''</summary>
        Friend Shared ReadOnly Property s_need_to_logging_type() As String
            Get
                Return ResourceManager.GetString("s_need_to_logging_type", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sinun tulee avata tiedosto ensin..
        '''</summary>
        Friend Shared ReadOnly Property s_need_to_open_file() As String
            Get
                Return ResourceManager.GetString("s_need_to_open_file", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sinun tulee valita suodatin ensin..
        '''</summary>
        Friend Shared ReadOnly Property s_need_to_select_filter() As String
            Get
                Return ResourceManager.GetString("s_need_to_select_filter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sinun tulee valita rivi ensin..
        '''</summary>
        Friend Shared ReadOnly Property s_need_to_select_line() As String
            Get
                Return ResourceManager.GetString("s_need_to_select_line", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sinun tulee syöttää lukuarvo..
        '''</summary>
        Friend Shared ReadOnly Property s_need_value() As String
            Get
                Return ResourceManager.GetString("s_need_value", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Ei löytyneitä tiedostoja.
        '''</summary>
        Friend Shared ReadOnly Property s_no_files_found() As String
            Get
                Return ResourceManager.GetString("s_no_files_found", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sinulla ei ole lokia tälle tiedostolle.
        '''</summary>
        Friend Shared ReadOnly Property s_no_log() As String
            Get
                Return ResourceManager.GetString("s_no_log", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tämä lista toimii eri tavalla kuin ohjelmakoodit.{0}{0}Me lisäämme poikkekusen valitsemillesi kohteille, mutta avainsanat voivat myös joissain tapauksissa tulla poistetuiksi..
        '''</summary>
        Friend Shared ReadOnly Property s_not_scripts() As String
            Get
                Return ResourceManager.GetString("s_not_scripts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Pahoittelut, BEM ei vielä tue tämän lokitiedoston tuontia..
        '''</summary>
        Friend Shared ReadOnly Property s_not_supported() As String
            Get
                Return ResourceManager.GetString("s_not_supported", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Et ole valinnut mitään tuotavaksi..
        '''</summary>
        Friend Shared ReadOnly Property s_nothing_to_import() As String
            Get
                Return ResourceManager.GetString("s_nothing_to_import", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Käsitellään.
        '''</summary>
        Friend Shared ReadOnly Property s_processing() As String
            Get
                Return ResourceManager.GetString("s_processing", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Skannataan.
        '''</summary>
        Friend Shared ReadOnly Property s_scanning() As String
            Get
                Return ResourceManager.GetString("s_scanning", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tämä lokitiedosto on yli 50,000 riviä pitkä. Skannattiin vain ensimmäiset 50,000 riviä..
        '''</summary>
        Friend Shared ReadOnly Property s_too_long() As String
            Get
                Return ResourceManager.GetString("s_too_long", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to BEM ei tällä hetkellä pysty käynnistymään. Varmista, että molemmat seuraavista ehdoista on täytetty:{0}{0}- Olet suorittamassa ohjelmaa BattlEye -kansiostasi.{0}- Olet ajanut ArmA 3 -serverin ainakin kerran..
        '''</summary>
        Friend Shared ReadOnly Property s_unable_to_launch() As String
            Get
                Return ResourceManager.GetString("s_unable_to_launch", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Päivitä ohjelma.
        '''</summary>
        Friend Shared ReadOnly Property s_update_application() As String
            Get
                Return ResourceManager.GetString("s_update_application", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Antamasi sähköpostiosoite ei kelpaa..
        '''</summary>
        Friend Shared ReadOnly Property s_upload_email() As String
            Get
                Return ResourceManager.GetString("s_upload_email", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Auttaaksesi BEM:n parantamisessa, kerro lyhyesti mikä ei toimi oikein..
        '''</summary>
        Friend Shared ReadOnly Property s_upload_explain() As String
            Get
                Return ResourceManager.GetString("s_upload_explain", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Auttaaksesi BEM:n parantamisessa, valitse vähintään 1 tiedosto lähetettäväksi..
        '''</summary>
        Friend Shared ReadOnly Property s_upload_one_file() As String
            Get
                Return ResourceManager.GetString("s_upload_one_file", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tiedostosi on lähetetty! Kiitos, että jätit ohjelmakoodisi BEM:n parantamista varten!.
        '''</summary>
        Friend Shared ReadOnly Property s_upload_thanks() As String
            Get
                Return ResourceManager.GetString("s_upload_thanks", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Lähetetään ZIP-tiedostoa.
        '''</summary>
        Friend Shared ReadOnly Property s_upload_upload_zip() As String
            Get
                Return ResourceManager.GetString("s_upload_upload_zip", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Luodaan ZIP-tiedostoa.
        '''</summary>
        Friend Shared ReadOnly Property s_upload_zip() As String
            Get
                Return ResourceManager.GetString("s_upload_zip", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ZIP-tiedosto siirretty!.
        '''</summary>
        Friend Shared ReadOnly Property s_uploaded_zip() As String
            Get
                Return ResourceManager.GetString("s_uploaded_zip", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Odota!.
        '''</summary>
        Friend Shared ReadOnly Property s_wait() As String
            Get
                Return ResourceManager.GetString("s_wait", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Asetuksia ei voitu tallentaa tiedoston kirjoittamisen virheestä johtuen..
        '''</summary>
        Friend Shared ReadOnly Property s_write_protect() As String
            Get
                Return ResourceManager.GetString("s_write_protect", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tietoa.
        '''</summary>
        Friend Shared ReadOnly Property t_about() As String
            Get
                Return ResourceManager.GetString("t_about", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Lisää suodatin.
        '''</summary>
        Friend Shared ReadOnly Property t_add_filter() As String
            Get
                Return ResourceManager.GetString("t_add_filter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Lisää avainsana.
        '''</summary>
        Friend Shared ReadOnly Property t_add_keyword() As String
            Get
                Return ResourceManager.GetString("t_add_keyword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Peruuta.
        '''</summary>
        Friend Shared ReadOnly Property t_cancel() As String
            Get
                Return ResourceManager.GetString("t_cancel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tarkista, onko päivityksiä.
        '''</summary>
        Friend Shared ReadOnly Property t_check_for_updates() As String
            Get
                Return ResourceManager.GetString("t_check_for_updates", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Valitse.
        '''</summary>
        Friend Shared ReadOnly Property t_choose() As String
            Get
                Return ResourceManager.GetString("t_choose", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Valitse Tiedosto:.
        '''</summary>
        Friend Shared ReadOnly Property t_choose_file() As String
            Get
                Return ResourceManager.GetString("t_choose_file", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Ladattu tällä hetkellä.
        '''</summary>
        Friend Shared ReadOnly Property t_currently_loaded() As String
            Get
                Return ResourceManager.GetString("t_currently_loaded", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Lahjoita.
        '''</summary>
        Friend Shared ReadOnly Property t_donate() As String
            Get
                Return ResourceManager.GetString("t_donate", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Muokkaa Suodatinta.
        '''</summary>
        Friend Shared ReadOnly Property t_edit_filter() As String
            Get
                Return ResourceManager.GetString("t_edit_filter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Muokkaa Avainsanaa.
        '''</summary>
        Friend Shared ReadOnly Property t_edit_keyword() As String
            Get
                Return ResourceManager.GetString("t_edit_keyword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Poikkeuksen tyyppi.
        '''</summary>
        Friend Shared ReadOnly Property t_exception_type() As String
            Get
                Return ResourceManager.GetString("t_exception_type", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Toimeton.
        '''</summary>
        Friend Shared ReadOnly Property t_idle() As String
            Get
                Return ResourceManager.GetString("t_idle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tuo valitut muodossa.
        '''</summary>
        Friend Shared ReadOnly Property t_import_as() As String
            Get
                Return ResourceManager.GetString("t_import_as", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tuo lokeista.
        '''</summary>
        Friend Shared ReadOnly Property t_import_from_logs() As String
            Get
                Return ResourceManager.GetString("t_import_from_logs", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Avainsana.
        '''</summary>
        Friend Shared ReadOnly Property t_keyword() As String
            Get
                Return ResourceManager.GetString("t_keyword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Kaksoisheittomerkit avainsanoissa tulee ohittaa kenoviivalla..
        '''</summary>
        Friend Shared ReadOnly Property t_keyword_backslash() As String
            Get
                Return ResourceManager.GetString("t_keyword_backslash", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Välilyöntejä sisältävät avainsanat tulee rajata kaksoisheittomerkein..
        '''</summary>
        Friend Shared ReadOnly Property t_keyword_double_quotes() As String
            Get
                Return ResourceManager.GetString("t_keyword_double_quotes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Lataa tiedosto.
        '''</summary>
        Friend Shared ReadOnly Property t_load_file() As String
            Get
                Return ResourceManager.GetString("t_load_file", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tyhjä. Lataa tiedosto aloittaaksesi..
        '''</summary>
        Friend Shared ReadOnly Property t_load_to_start() As String
            Get
                Return ResourceManager.GetString("t_load_to_start", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Kirjaustyyppi.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type() As String
            Get
                Return ResourceManager.GetString("t_logging_type", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Kirjaa pelkästään .log -tiedostoon.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type_1() As String
            Get
                Return ResourceManager.GetString("t_logging_type_1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Kirjaa pelkästään konsoliin.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type_2() As String
            Get
                Return ResourceManager.GetString("t_logging_type_2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Kirjaa molempiin.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type_3() As String
            Get
                Return ResourceManager.GetString("t_logging_type_3", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Potki ilman lokia.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type_4() As String
            Get
                Return ResourceManager.GetString("t_logging_type_4", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Potki ja kirjaa ainoastaan .log -tiedostoon.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type_5() As String
            Get
                Return ResourceManager.GetString("t_logging_type_5", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Potki ja kirjaa ainoastaan konsoliin.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type_6() As String
            Get
                Return ResourceManager.GetString("t_logging_type_6", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Potki ja kirjaa molempiin.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type_7() As String
            Get
                Return ResourceManager.GetString("t_logging_type_7", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Ei tiedostoa havaittu.
        '''</summary>
        Friend Shared ReadOnly Property t_no_file_selected() As String
            Get
                Return ResourceManager.GetString("t_no_file_selected", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Asetukset.
        '''</summary>
        Friend Shared ReadOnly Property t_options() As String
            Get
                Return ResourceManager.GetString("t_options", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Muuttujan tulee täsmälleen vastata poikkeusta..
        '''</summary>
        Friend Shared ReadOnly Property t_parameter_match_1() As String
            Get
                Return ResourceManager.GetString("t_parameter_match_1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Muuttujan tulee sisältää poikkeus..
        '''</summary>
        Friend Shared ReadOnly Property t_parameter_match_2() As String
            Get
                Return ResourceManager.GetString("t_parameter_match_2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Poista suodatin.
        '''</summary>
        Friend Shared ReadOnly Property t_remove_filter() As String
            Get
                Return ResourceManager.GetString("t_remove_filter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Poista avainsana.
        '''</summary>
        Friend Shared ReadOnly Property t_remove_keyword() As String
            Get
                Return ResourceManager.GetString("t_remove_keyword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tallenna tiedosto.
        '''</summary>
        Friend Shared ReadOnly Property t_save_file() As String
            Get
                Return ResourceManager.GetString("t_save_file", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Valitse kaikki.
        '''</summary>
        Friend Shared ReadOnly Property t_select_all() As String
            Get
                Return ResourceManager.GetString("t_select_all", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Älä valitse mitään.
        '''</summary>
        Friend Shared ReadOnly Property t_select_none() As String
            Get
                Return ResourceManager.GetString("t_select_none", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Lähetä.
        '''</summary>
        Friend Shared ReadOnly Property t_send() As String
            Get
                Return ResourceManager.GetString("t_send", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Vaihtoehtoisesti, jätä minulle sinun sähköpostiosoitteesi, jos uskot että minun tarvitsee ottaa sinuun yhteyttä..
        '''</summary>
        Friend Shared ReadOnly Property t_upload_email() As String
            Get
                Return ResourceManager.GetString("t_upload_email", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Seuraavat tiedostot lähetetään minulle, poista valinta niiden tiedostojen kohdalta joita et halua lähetettävän.
        '''</summary>
        Friend Shared ReadOnly Property t_upload_filelist() As String
            Get
                Return ResourceManager.GetString("t_upload_filelist", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Jos kohtaat ongelmia suodatintiedostojesi latautumisen kanssa, tai jos tietyt kohteet eivät tule havaituksi oikein, käytäthän alla olevaa lomaketta lähettääksesi suodattimesi minulle, niin katson saanko BEM:n toimimaan sinulle paremmin! Käytäthän tätä lomaketta vain jos kohtaat ongelmia..
        '''</summary>
        Friend Shared ReadOnly Property t_upload_intro() As String
            Get
                Return ResourceManager.GetString("t_upload_intro", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Kirjoita lyhyt kuvaus siitä millaisia ongelmia sinulla on suodattimiesi kanssa.
        '''</summary>
        Friend Shared ReadOnly Property t_upload_message() As String
            Get
                Return ResourceManager.GetString("t_upload_message", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Lähetä ohjelmakoodeja.
        '''</summary>
        Friend Shared ReadOnly Property t_upload_scripts() As String
            Get
                Return ResourceManager.GetString("t_upload_scripts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Arvo.
        '''</summary>
        Friend Shared ReadOnly Property t_value() As String
            Get
                Return ResourceManager.GetString("t_value", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Arvon tulisi olla rajattu kaksoisheittomerkein.
        '''</summary>
        Friend Shared ReadOnly Property t_value_double_quotes() As String
            Get
                Return ResourceManager.GetString("t_value_double_quotes", resourceCulture)
            End Get
        End Property
    End Class
End Namespace