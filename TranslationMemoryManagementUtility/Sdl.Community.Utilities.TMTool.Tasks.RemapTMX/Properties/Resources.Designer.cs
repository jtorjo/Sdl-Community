﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sdl.Community.Utilities.TMTool.Tasks.RemapTMX.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sdl.Community.Utilities.TMTool.Tasks.RemapTMX.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ChunkSize should be less than Sdl.LanguagePlatform.TranslationMemoryApi.TranslationMemoryExporter.MaxTranslationUnitChunkSize and greater than 20..
        /// </summary>
        internal static string ChunkSizeError {
            get {
                return ResourceManager.GetString("ChunkSizeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tranlation memory {0} is invalid..
        /// </summary>
        internal static string InvalidTranslationMemory {
            get {
                return ResourceManager.GetString("InvalidTranslationMemory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} culture is not supported by Trados Translators Workbench 2007. Do you wish to proceed?.
        /// </summary>
        internal static string NotSupportedCulture {
            get {
                return ResourceManager.GetString("NotSupportedCulture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output folder does not exist..
        /// </summary>
        internal static string OutputFolderError {
            get {
                return ResourceManager.GetString("OutputFolderError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unhalted exception ocurred while processing remap task:{0}.
        /// </summary>
        internal static string RemapException {
            get {
                return ResourceManager.GetString("RemapException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User decided to skip {0} translation memory..
        /// </summary>
        internal static string SkipTM {
            get {
                return ResourceManager.GetString("SkipTM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export for SDL Trados Studio 2021.
        /// </summary>
        internal static string TaskName {
            get {
                return ResourceManager.GetString("TaskName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Translation memory {0} export finished.
        /// </summary>
        internal static string TMExportFinished {
            get {
                return ResourceManager.GetString("TMExportFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting export {0} translation memory.
        /// </summary>
        internal static string TMExportStarted {
            get {
                return ResourceManager.GetString("TMExportStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Translation Memory Export ({0}).
        /// </summary>
        internal static string TmxDescription {
            get {
                return ResourceManager.GetString("TmxDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TMX file {0} successfully processed..
        /// </summary>
        internal static string TMXFlavouredConverted {
            get {
                return ResourceManager.GetString("TMXFlavouredConverted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total translation units exported: {0}.
        /// </summary>
        internal static string TotalTUExported {
            get {
                return ResourceManager.GetString("TotalTUExported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total translation units processed: {0}.
        /// </summary>
        internal static string TotalTUProcessed {
            get {
                return ResourceManager.GetString("TotalTUProcessed", resourceCulture);
            }
        }
    }
}
