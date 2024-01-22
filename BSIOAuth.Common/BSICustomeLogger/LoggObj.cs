namespace BSIOAuth.Common.BSICustomeLog;

public class LoggObj
{
    public LoggerTypes logType { get; set; }
    public DateTime CreateAt { get; set; }
    public string? ExceptionMessage { get; set; } = string.Empty;
    public string Message { get; set; }
    public int Line { get; set; }
    public string Service { get; set; }
    public string ServiceName { get; set; }

    // public override string ToString()
    // {
    //     return $"logType: {logType}, CreateAt: {CreateAt}, isException: {isException}, ExceptionMessage: {ExceptionMessage}," +
    //            $" Message: {Message}, Line: {Line}, Service: {Service}, ServiceName: {ServiceName}";
    // }
}