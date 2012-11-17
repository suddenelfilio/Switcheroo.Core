﻿namespace Switcheroo.Configuration
{
    using System.Configuration;

    /// <summary>
    /// A configuration element for the <see cref="FeatureToggleCollection"/>.
    /// </summary>
    public class ToggleConfig : ConfigurationElement
    {
        /// <summary>
        /// Gets or sets the name of the feature toggle.
        /// </summary>
        /// <value>
        /// The name of th efeature toggle.
        /// </value>
        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this toggle is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if enabled; otherwise, <c>false</c>.
        /// </value>
        [ConfigurationProperty("enabled", IsRequired = true, IsKey = false)]
        public bool Enabled
        {
            get { return (bool)this["enabled"]; }
            set { this["enabled"] = value; }
        }
    }
}