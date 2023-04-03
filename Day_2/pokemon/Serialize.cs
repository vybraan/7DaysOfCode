using System.Text.Json;

    public static class Serialize
{
    public static string ToJson(this Mascote self) => JsonSerializer.Serialize(self, Converter.Settings);
}