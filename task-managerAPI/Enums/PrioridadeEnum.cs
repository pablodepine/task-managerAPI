using System.ComponentModel;
using System.Text.Json.Serialization;

namespace task_managerAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PrioridadeEnum : short
    {
        [Description("Alta")]
        Alta = 0,
        [Description("Media")]
        Media = 1,
        [Description("Baixa")]
        Baixa = 2
    }
}
