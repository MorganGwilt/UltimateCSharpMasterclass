using System.Runtime.Serialization;

[Serializable]
public class CustomException : Exception
{
    public int StatusCode { get; }

    [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
    protected CustomException(
        SerializationInfo info,
        StreamingContext context) : base(info, context)
    {

    }

    public CustomException()
    {

    }

    public CustomException(string message, int statusCode) : base(message)
    {
        StatusCode = statusCode;
    }

    public CustomException(
        string message,
        int statusCode,
        Exception innerException) : base(message, innerException)
    {
        StatusCode = statusCode;
    }

    public CustomException(string message) : base(message)
    {

    }

    public CustomException(string message, Exception innerException)
        : base(message, innerException)
    {

    }
}
