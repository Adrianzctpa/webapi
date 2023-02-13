using System.Text.Json.Serialization;

namespace webapi.Models
{
   [JsonConverter(typeof(JsonStringEnumConverter))]
   public enum Roles
    {
        genericUser = 1,
        admin = 2,
        OP = 3,
    }
}