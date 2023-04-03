using System;
using System.Collections.Generic;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;

public partial class Mascote
{
        [JsonPropertyName("abilities")]
        public List<Ability> abilities { get; set; }

        [JsonPropertyName("base_experience")]
        public long BaseExperience { get; set; }

        [JsonPropertyName("forms")]
        public List<Species> Forms { get; set; }

        [JsonPropertyName("game_indices")]
        public List<GameIndex> GameIndices { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }

        [JsonPropertyName("held_items")]
        public List<object> HeldItems { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        [JsonPropertyName("location_area_encounters")]
        public Uri LocationAreaEncounters { get; set; }

        [JsonPropertyName("moves")]
        public List<Move> Moves { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("order")]
        public long Order { get; set; }

        [JsonPropertyName("past_types")]
        public List<object> PastTypes { get; set; }

        [JsonPropertyName("species")]
        public Species Species { get; set; }

        [JsonPropertyName("sprites")]
        public Sprites Sprites { get; set; }

        [JsonPropertyName("stats")]
        public List<Stat> Stats { get; set; }

        [JsonPropertyName("types")]
        public List<TypeElement> Types { get; set; }

        [JsonPropertyName("weight")]
        public long Weight { get; set; }


}

    public partial class Mascote
    {
        public static Mascote FromJson(string json) => JsonSerializer.Deserialize<Mascote>(json, Converter.Settings);
    }



