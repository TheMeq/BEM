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
    Friend Class English
        
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("BEM.English", GetType(English).Assembly)
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
        '''  Looks up a localized string similar to Original {0} has been backed up and new one has successfully saved..
        '''</summary>
        Friend Shared ReadOnly Property s_backed_up() As String
            Get
                Return ResourceManager.GetString("s_backed_up", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You have made changes to this file, please save this file first.{0}{0}If you do not want to save, click OK and load the new file again..
        '''</summary>
        Friend Shared ReadOnly Property s_changes_to_file() As String
            Get
                Return ResourceManager.GetString("s_changes_to_file", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are you sure you want to delete this filter entry?.
        '''</summary>
        Friend Shared ReadOnly Property s_confirm_delete_filter() As String
            Get
                Return ResourceManager.GetString("s_confirm_delete_filter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are you sure you want to delete this keyword entry?.
        '''</summary>
        Friend Shared ReadOnly Property s_confirm_delete_keyword() As String
            Get
                Return ResourceManager.GetString("s_confirm_delete_keyword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Could not locate the file &quot;&quot;{0}.txt&quot;&quot;. Make sure you are running this program from the BattlEye directory on your server..
        '''</summary>
        Friend Shared ReadOnly Property s_could_not_open_file() As String
            Get
                Return ResourceManager.GetString("s_could_not_open_file", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Done!.
        '''</summary>
        Friend Shared ReadOnly Property s_done() As String
            Get
                Return ResourceManager.GetString("s_done", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to edited.
        '''</summary>
        Friend Shared ReadOnly Property s_edited() As String
            Get
                Return ResourceManager.GetString("s_edited", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Could not save this file. The following error occured:{0}{0}{1}.
        '''</summary>
        Friend Shared ReadOnly Property s_failed_backed_up() As String
            Get
                Return ResourceManager.GetString("s_failed_backed_up", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The text may contain some backslashes that may need to be escaped, did you want to fix these?.
        '''</summary>
        Friend Shared ReadOnly Property s_fix_backslash() As String
            Get
                Return ResourceManager.GetString("s_fix_backslash", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Selected items have been imported. Please remember to save your changes..
        '''</summary>
        Friend Shared ReadOnly Property s_items_imported() As String
            Get
                Return ResourceManager.GetString("s_items_imported", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Latest Version.
        '''</summary>
        Friend Shared ReadOnly Property s_latest_version() As String
            Get
                Return ResourceManager.GetString("s_latest_version", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to There was an error loading this file, is it a BattlEye file?.
        '''</summary>
        Friend Shared ReadOnly Property s_loading_error() As String
            Get
                Return ResourceManager.GetString("s_loading_error", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You need to enter a keyword. If you want a blank keyword, please enter.
        '''</summary>
        Friend Shared ReadOnly Property s_need_keyword() As String
            Get
                Return ResourceManager.GetString("s_need_keyword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You need to select an Exception Type..
        '''</summary>
        Friend Shared ReadOnly Property s_need_to_exception_type() As String
            Get
                Return ResourceManager.GetString("s_need_to_exception_type", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You need to select a Logging Type..
        '''</summary>
        Friend Shared ReadOnly Property s_need_to_logging_type() As String
            Get
                Return ResourceManager.GetString("s_need_to_logging_type", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You need to open a file first..
        '''</summary>
        Friend Shared ReadOnly Property s_need_to_open_file() As String
            Get
                Return ResourceManager.GetString("s_need_to_open_file", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You need to select a filter first..
        '''</summary>
        Friend Shared ReadOnly Property s_need_to_select_filter() As String
            Get
                Return ResourceManager.GetString("s_need_to_select_filter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You need to select a line first..
        '''</summary>
        Friend Shared ReadOnly Property s_need_to_select_line() As String
            Get
                Return ResourceManager.GetString("s_need_to_select_line", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You need to enter a value..
        '''</summary>
        Friend Shared ReadOnly Property s_need_value() As String
            Get
                Return ResourceManager.GetString("s_need_value", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No Files Found.
        '''</summary>
        Friend Shared ReadOnly Property s_no_files_found() As String
            Get
                Return ResourceManager.GetString("s_no_files_found", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You don&apos;t have a log for this file..
        '''</summary>
        Friend Shared ReadOnly Property s_no_log() As String
            Get
                Return ResourceManager.GetString("s_no_log", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to This list works differently than scripts.{0}{0}We will add the exceptions for the ones you choose, but the keywords might as well be removed in some cases..
        '''</summary>
        Friend Shared ReadOnly Property s_not_scripts() As String
            Get
                Return ResourceManager.GetString("s_not_scripts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sorry, This log file is not yet supported by BEM for importing..
        '''</summary>
        Friend Shared ReadOnly Property s_not_supported() As String
            Get
                Return ResourceManager.GetString("s_not_supported", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You haven&apos;t selected anything to import..
        '''</summary>
        Friend Shared ReadOnly Property s_nothing_to_import() As String
            Get
                Return ResourceManager.GetString("s_nothing_to_import", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Processing.
        '''</summary>
        Friend Shared ReadOnly Property s_processing() As String
            Get
                Return ResourceManager.GetString("s_processing", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Scanning.
        '''</summary>
        Friend Shared ReadOnly Property s_scanning() As String
            Get
                Return ResourceManager.GetString("s_scanning", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to This log file is more then 50,000 lines long. Only scanned first 50,000 lines..
        '''</summary>
        Friend Shared ReadOnly Property s_too_long() As String
            Get
                Return ResourceManager.GetString("s_too_long", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unable to launch BEM right now. Please ensure both of the following conditions are met:{0}{0}- You are running this from your BattlEye Folder.{0}- You have run the ArmA 3 server at least once..
        '''</summary>
        Friend Shared ReadOnly Property s_unable_to_launch() As String
            Get
                Return ResourceManager.GetString("s_unable_to_launch", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Update Application.
        '''</summary>
        Friend Shared ReadOnly Property s_update_application() As String
            Get
                Return ResourceManager.GetString("s_update_application", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The email address you have entered is not valid..
        '''</summary>
        Friend Shared ReadOnly Property s_upload_email() As String
            Get
                Return ResourceManager.GetString("s_upload_email", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to To help me make BEM better, please give a brief explanation of what is not working..
        '''</summary>
        Friend Shared ReadOnly Property s_upload_explain() As String
            Get
                Return ResourceManager.GetString("s_upload_explain", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to To help me make BEM better, please choose at least 1 file to upload..
        '''</summary>
        Friend Shared ReadOnly Property s_upload_one_file() As String
            Get
                Return ResourceManager.GetString("s_upload_one_file", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Your files have been uploaded! Thanks for submitting your scripts to help make BEM better!.
        '''</summary>
        Friend Shared ReadOnly Property s_upload_thanks() As String
            Get
                Return ResourceManager.GetString("s_upload_thanks", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Uploading ZIP file.
        '''</summary>
        Friend Shared ReadOnly Property s_upload_upload_zip() As String
            Get
                Return ResourceManager.GetString("s_upload_upload_zip", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Creating ZIP file.
        '''</summary>
        Friend Shared ReadOnly Property s_upload_zip() As String
            Get
                Return ResourceManager.GetString("s_upload_zip", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Uploaded ZIP file!.
        '''</summary>
        Friend Shared ReadOnly Property s_uploaded_zip() As String
            Get
                Return ResourceManager.GetString("s_uploaded_zip", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Wait!.
        '''</summary>
        Friend Shared ReadOnly Property s_wait() As String
            Get
                Return ResourceManager.GetString("s_wait", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Could not save settings due to an error writing the file..
        '''</summary>
        Friend Shared ReadOnly Property s_write_protect() As String
            Get
                Return ResourceManager.GetString("s_write_protect", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to About.
        '''</summary>
        Friend Shared ReadOnly Property t_about() As String
            Get
                Return ResourceManager.GetString("t_about", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add Filter.
        '''</summary>
        Friend Shared ReadOnly Property t_add_filter() As String
            Get
                Return ResourceManager.GetString("t_add_filter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add Keyword.
        '''</summary>
        Friend Shared ReadOnly Property t_add_keyword() As String
            Get
                Return ResourceManager.GetString("t_add_keyword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Cancel.
        '''</summary>
        Friend Shared ReadOnly Property t_cancel() As String
            Get
                Return ResourceManager.GetString("t_cancel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Check for Updates.
        '''</summary>
        Friend Shared ReadOnly Property t_check_for_updates() As String
            Get
                Return ResourceManager.GetString("t_check_for_updates", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Choose.
        '''</summary>
        Friend Shared ReadOnly Property t_choose() As String
            Get
                Return ResourceManager.GetString("t_choose", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Choose File:.
        '''</summary>
        Friend Shared ReadOnly Property t_choose_file() As String
            Get
                Return ResourceManager.GetString("t_choose_file", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Currently Loaded.
        '''</summary>
        Friend Shared ReadOnly Property t_currently_loaded() As String
            Get
                Return ResourceManager.GetString("t_currently_loaded", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Donate.
        '''</summary>
        Friend Shared ReadOnly Property t_donate() As String
            Get
                Return ResourceManager.GetString("t_donate", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Edit Filter.
        '''</summary>
        Friend Shared ReadOnly Property t_edit_filter() As String
            Get
                Return ResourceManager.GetString("t_edit_filter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Edit Keyword.
        '''</summary>
        Friend Shared ReadOnly Property t_edit_keyword() As String
            Get
                Return ResourceManager.GetString("t_edit_keyword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Exception Type.
        '''</summary>
        Friend Shared ReadOnly Property t_exception_type() As String
            Get
                Return ResourceManager.GetString("t_exception_type", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Idle.
        '''</summary>
        Friend Shared ReadOnly Property t_idle() As String
            Get
                Return ResourceManager.GetString("t_idle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Import Checked as .
        '''</summary>
        Friend Shared ReadOnly Property t_import_as() As String
            Get
                Return ResourceManager.GetString("t_import_as", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Import from Logs.
        '''</summary>
        Friend Shared ReadOnly Property t_import_from_logs() As String
            Get
                Return ResourceManager.GetString("t_import_from_logs", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Keyword.
        '''</summary>
        Friend Shared ReadOnly Property t_keyword() As String
            Get
                Return ResourceManager.GetString("t_keyword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Keywords containing double quotes must have them escaped with a backslash..
        '''</summary>
        Friend Shared ReadOnly Property t_keyword_backslash() As String
            Get
                Return ResourceManager.GetString("t_keyword_backslash", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Keywords containing spaces must be contained within double quotes..
        '''</summary>
        Friend Shared ReadOnly Property t_keyword_double_quotes() As String
            Get
                Return ResourceManager.GetString("t_keyword_double_quotes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Load File.
        '''</summary>
        Friend Shared ReadOnly Property t_load_file() As String
            Get
                Return ResourceManager.GetString("t_load_file", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to None. Load a file to start..
        '''</summary>
        Friend Shared ReadOnly Property t_load_to_start() As String
            Get
                Return ResourceManager.GetString("t_load_to_start", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Logging Type.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type() As String
            Get
                Return ResourceManager.GetString("t_logging_type", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Log to .log file only.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type_1() As String
            Get
                Return ResourceManager.GetString("t_logging_type_1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Log to console only.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type_2() As String
            Get
                Return ResourceManager.GetString("t_logging_type_2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Log to both.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type_3() As String
            Get
                Return ResourceManager.GetString("t_logging_type_3", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Kick with no log.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type_4() As String
            Get
                Return ResourceManager.GetString("t_logging_type_4", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Kick and log to .log file only.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type_5() As String
            Get
                Return ResourceManager.GetString("t_logging_type_5", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Kick and log to console only.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type_6() As String
            Get
                Return ResourceManager.GetString("t_logging_type_6", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Kick and log to both.
        '''</summary>
        Friend Shared ReadOnly Property t_logging_type_7() As String
            Get
                Return ResourceManager.GetString("t_logging_type_7", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No File Detected.
        '''</summary>
        Friend Shared ReadOnly Property t_no_file_selected() As String
            Get
                Return ResourceManager.GetString("t_no_file_selected", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Options.
        '''</summary>
        Friend Shared ReadOnly Property t_options() As String
            Get
                Return ResourceManager.GetString("t_options", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The parameter must exactly match the exception..
        '''</summary>
        Friend Shared ReadOnly Property t_parameter_match_1() As String
            Get
                Return ResourceManager.GetString("t_parameter_match_1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The parameter must contain the exception..
        '''</summary>
        Friend Shared ReadOnly Property t_parameter_match_2() As String
            Get
                Return ResourceManager.GetString("t_parameter_match_2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Remove Filter.
        '''</summary>
        Friend Shared ReadOnly Property t_remove_filter() As String
            Get
                Return ResourceManager.GetString("t_remove_filter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Remove Keyword.
        '''</summary>
        Friend Shared ReadOnly Property t_remove_keyword() As String
            Get
                Return ResourceManager.GetString("t_remove_keyword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Save File.
        '''</summary>
        Friend Shared ReadOnly Property t_save_file() As String
            Get
                Return ResourceManager.GetString("t_save_file", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Select All.
        '''</summary>
        Friend Shared ReadOnly Property t_select_all() As String
            Get
                Return ResourceManager.GetString("t_select_all", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Select None.
        '''</summary>
        Friend Shared ReadOnly Property t_select_none() As String
            Get
                Return ResourceManager.GetString("t_select_none", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Send.
        '''</summary>
        Friend Shared ReadOnly Property t_send() As String
            Get
                Return ResourceManager.GetString("t_send", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Optionally, leave me your email address if you think I need to contact you.
        '''</summary>
        Friend Shared ReadOnly Property t_upload_email() As String
            Get
                Return ResourceManager.GetString("t_upload_email", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The following files will be sent to me, uncheck items you do not want to send.
        '''</summary>
        Friend Shared ReadOnly Property t_upload_filelist() As String
            Get
                Return ResourceManager.GetString("t_upload_filelist", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to If you are having issues with your filter files not loading correctly or some items not being correctly detected, please use the form below to submit your filters to me and I will see if I can make BEM work better for you! Please only use this if you are having issues..
        '''</summary>
        Friend Shared ReadOnly Property t_upload_intro() As String
            Get
                Return ResourceManager.GetString("t_upload_intro", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please write a brief message explaining what issues you are having with your filters.
        '''</summary>
        Friend Shared ReadOnly Property t_upload_message() As String
            Get
                Return ResourceManager.GetString("t_upload_message", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Upload Scripts.
        '''</summary>
        Friend Shared ReadOnly Property t_upload_scripts() As String
            Get
                Return ResourceManager.GetString("t_upload_scripts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Value.
        '''</summary>
        Friend Shared ReadOnly Property t_value() As String
            Get
                Return ResourceManager.GetString("t_value", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Value should be contained within double quotes.
        '''</summary>
        Friend Shared ReadOnly Property t_value_double_quotes() As String
            Get
                Return ResourceManager.GetString("t_value_double_quotes", resourceCulture)
            End Get
        End Property
    End Class
End Namespace