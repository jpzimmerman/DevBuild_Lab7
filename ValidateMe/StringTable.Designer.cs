﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ValidateMe {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class StringTable {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringTable() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ValidateMe.StringTable", typeof(StringTable).Assembly);
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
        ///   Looks up a localized string similar to Please enter a valid date: .
        /// </summary>
        internal static string DatePrompt {
            get {
                return ResourceManager.GetString("DatePrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter a valid email address: .
        /// </summary>
        internal static string EmailPrompt {
            get {
                return ResourceManager.GetString("EmailPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Date format is invalid!.
        /// </summary>
        internal static string InvalidDateMessage {
            get {
                return ResourceManager.GetString("InvalidDateMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, email address is not valid!.
        /// </summary>
        internal static string InvalidEmailMessage {
            get {
                return ResourceManager.GetString("InvalidEmailMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, name is not valid!.
        /// </summary>
        internal static string InvalidNameMessage {
            get {
                return ResourceManager.GetString("InvalidNameMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, telephone number is not valid!.
        /// </summary>
        internal static string InvalidTelephoneNumberMessage {
            get {
                return ResourceManager.GetString("InvalidTelephoneNumberMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter a valid name: .
        /// </summary>
        internal static string NamePrompt {
            get {
                return ResourceManager.GetString("NamePrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Would you like to re-enter data? (y/n) .
        /// </summary>
        internal static string ReEnterDataPrompt {
            get {
                return ResourceManager.GetString("ReEnterDataPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Would you like to restart? (y/n) .
        /// </summary>
        internal static string RestartPrompt {
            get {
                return ResourceManager.GetString("RestartPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter a valid telephone number: .
        /// </summary>
        internal static string TelephoneNumberPrompt {
            get {
                return ResourceManager.GetString("TelephoneNumberPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Format of the date is right, but we&apos;ll still need to check the day and month by hand..
        /// </summary>
        internal static string ValidDateMessage {
            get {
                return ResourceManager.GetString("ValidDateMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email address is valid!.
        /// </summary>
        internal static string ValidEmailMessage {
            get {
                return ResourceManager.GetString("ValidEmailMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name is valid!.
        /// </summary>
        internal static string ValidNameMessage {
            get {
                return ResourceManager.GetString("ValidNameMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Telephone number is valid!.
        /// </summary>
        internal static string ValidTelephoneNumberMessage {
            get {
                return ResourceManager.GetString("ValidTelephoneNumberMessage", resourceCulture);
            }
        }
    }
}
