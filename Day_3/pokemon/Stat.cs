    using System;
    using System.Collections.Generic;

    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Globalization;




    public partial class Stat
    {
        [JsonPropertyName("base_stat")]
        public long BaseStat { get; set; }

        [JsonPropertyName("effort")]
        public long Effort { get; set; }

        [JsonPropertyName("stat")]
        public Species StatStat { get; set; }
    }
