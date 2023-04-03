using System.Text.Json.Serialization;



public partial class Move
{
    [JsonPropertyName("move")]
    public Species MoveMove { get; set; }

    [JsonPropertyName("version_group_details")]
    public List<VersionGroupDetail> VersionGroupDetails { get; set; }
}