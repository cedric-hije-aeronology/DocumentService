using System.Text.Json.Serialization;

namespace DocumentService.Models
{
    public class BaseResponse
    {
        [JsonPropertyName("context_id")]
        public string ContextId { get; set; }

        [JsonPropertyName("session_id")]
        public string SessionId { get; set; }

        [JsonPropertyName("error")]
        public Error Error { get; set; }
    }

    public class BaseRequest
    {
        [JsonPropertyName("x_session_id")]
        public string XSessionId { get; set; }
    }
}
