// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Application stack minor version.
    /// </summary>
    public partial class StackMinorVersion
    {
        /// <summary>
        /// Initializes a new instance of the StackMinorVersion class.
        /// </summary>
        public StackMinorVersion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StackMinorVersion class.
        /// </summary>
        /// <param name="displayVersion">Application stack minor version
        /// (display only).</param>
        /// <param name="runtimeVersion">Application stack minor version
        /// (runtime only).</param>
        /// <param name="isDefault">&lt;code&gt;true&lt;/code&gt; if this is
        /// the default minor version; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        public StackMinorVersion(string displayVersion = default(string), string runtimeVersion = default(string), bool? isDefault = default(bool?))
        {
            DisplayVersion = displayVersion;
            RuntimeVersion = runtimeVersion;
            IsDefault = isDefault;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets application stack minor version (display only).
        /// </summary>
        [JsonProperty(PropertyName = "displayVersion")]
        public string DisplayVersion { get; set; }

        /// <summary>
        /// Gets or sets application stack minor version (runtime only).
        /// </summary>
        [JsonProperty(PropertyName = "runtimeVersion")]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if this
        /// is the default minor version; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "isDefault")]
        public bool? IsDefault { get; set; }

    }
}