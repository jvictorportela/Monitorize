using System.Text.Json.Serialization;

namespace Monitorize.Core.Responses;

public class Response<TData>
{
    private int _statusCode = Configuration.DefaultStatusCode;

    public TData? Data { get; set; }
    public string? Message { get; set; }

    [JsonIgnore] //Não irá para o resultado final em json
    public bool IsSuccess => _statusCode is >= 200 and <= 299;


    [JsonConstructor]
    public Response()
    {
        _statusCode = Configuration.DefaultStatusCode;
    }

    public Response(TData? data,
        int statusCode = Configuration.DefaultStatusCode,
        string message = null)
    {
        Data = data;
        Message = message;
        _statusCode = statusCode;
    }
}
