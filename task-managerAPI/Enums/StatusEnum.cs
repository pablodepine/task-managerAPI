using System.ComponentModel;
using System.Text.Json.Serialization;

namespace task_managerAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum : short
    {
        [Description("A Fazer")]
        AFazer = 0,
        [Description("Em Progresso")]
        EmProgresso = 1,
        [Description("Feito")]
        Feito = 2
    }
}
