using System.Text.Json.Serialization;

namespace task_managerAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PrioridadeEnum
    {
        Alta,
        Media,
        Baixa
    }
}
