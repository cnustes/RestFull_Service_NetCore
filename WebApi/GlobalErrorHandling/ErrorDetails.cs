using Newtonsoft.Json;

namespace WebApi.GlobalErrorHandling
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public int Message { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
