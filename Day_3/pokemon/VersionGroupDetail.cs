using System.Text.Json.Serialization;





public partial class VersionGroupDetail
{
    [JsonPropertyName("level_learned_at")]
    public long LevelLearnedAt { get; set; }

    [JsonPropertyName("move_learn_method")]
    public Species MoveLearnMethod { get; set; }

    [JsonPropertyName("version_group")]
    public Species VersionGroup { get; set; }
}
