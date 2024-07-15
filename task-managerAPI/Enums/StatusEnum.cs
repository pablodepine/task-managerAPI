using System.Text.Json.Serialization;

namespace task_managerAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
    {
        AFazer,
        EmProgresso,
        Feito
    }
}
