﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Archetype.Models
{
    public class ArchetypePreValue
    {
        [JsonProperty("showAdvancedOptions")]
        public bool ShowAdvancedOptions { get; set; }

        [JsonProperty("startWithAddButton")]
        public bool StartWithAddButton { get; set; }

        [JsonProperty("hideFieldsetToolbar")]
        public bool HideFieldsetToolbar { get; set; }

        [JsonProperty("enableMultipleFieldsets")]
        public bool EnableMultipleFieldsets { get; set; }

        [JsonProperty("enableCollapsing")]
        public bool EnableCollapsing { get; set; }

        [JsonProperty("enableCloning")]
        public bool EnableCloning { get; set; }

        [JsonProperty("enableDisabling")]
        public bool EnableDisabling { get; set; }

        [JsonProperty("hideFieldsetControls")]
        public bool HideFieldsetControls { get; set; }

        [JsonProperty("hidePropertyLabel")]
        public bool HidePropertyLabel { get; set; }

        [JsonProperty("maxFieldsets", NullValueHandling = NullValueHandling.Ignore)]
        public int MaxFieldsets { get; set; }

        [JsonProperty("fieldsets")]
        public IEnumerable<ArchetypePreValueFieldset> Fieldsets { get; set; }

        [JsonProperty("hidePropertyLabels")]
        public bool HidePropertyLabels { get; set; }

        [JsonProperty("customCssClass")]
        public string CustomCssClass { get; set; }

        [JsonProperty("customCssPath")]
        public string CustomCssPath { get; set; }

        [JsonProperty("customJsPath")]
        public string CustomJsPath { get; set; }

        [JsonProperty("customViewPath")]
        public string CustomViewPath { get; set; }

        [JsonProperty("enableDeepDatatypeRequests")]
        public bool EnableDeepDatatypeRequests { get; set; }
        
        [JsonProperty("developerMode")]
        public bool DeveloperMode { get; set; }

        [JsonProperty("overrideDefaultPropertyValueConverter")]
        public bool OverrideDefaultPropertyValueConverter { get; set; }
    }
}
