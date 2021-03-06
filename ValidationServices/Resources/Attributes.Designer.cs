﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ValidationServices.Resources {
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
    internal class Attributes {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Attributes() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ValidationServices.Resources.Attributes", typeof(Attributes).Assembly);
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
        ///   Looks up a localized string similar to &quot;Validation argument is not a string&quot;.
        /// </summary>
        internal static string ArgumentExceptionArgumentIsNotAString {
            get {
                return ResourceManager.GetString("ArgumentExceptionArgumentIsNotAString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Constraint is not specified&quot;.
        /// </summary>
        internal static string ArgumentExceptionConstraintNotSpecified {
            get {
                return ResourceManager.GetString("ArgumentExceptionConstraintNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Range constraints are not compatible&quot;.
        /// </summary>
        internal static string ArgumentExceptionIncompatibleConstraints {
            get {
                return ResourceManager.GetString("ArgumentExceptionIncompatibleConstraints", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Range constraints and validated object are not compatible&quot;.
        /// </summary>
        internal static string ArgumentExceptionIncompatibleConstraintsAndObject {
            get {
                return ResourceManager.GetString("ArgumentExceptionIncompatibleConstraintsAndObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Lower constraint exceeds upper constraint&quot;.
        /// </summary>
        internal static string ArgumentExceptionInvalidConstraints {
            get {
                return ResourceManager.GetString("ArgumentExceptionInvalidConstraints", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Property value must satisfy specified constraints&quot;.
        /// </summary>
        internal static string RangeConstraintDefaultFailureMessage {
            get {
                return ResourceManager.GetString("RangeConstraintDefaultFailureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Required property must be initialized with valid value&quot;.
        /// </summary>
        internal static string RequiredPropertyDefaultFailureMessage {
            get {
                return ResourceManager.GetString("RequiredPropertyDefaultFailureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Length of a string must satisfy specified constraints&quot;.
        /// </summary>
        internal static string StringLengthDefaultFailureMessage {
            get {
                return ResourceManager.GetString("StringLengthDefaultFailureMessage", resourceCulture);
            }
        }
    }
}
