using Microsoft.Extensions.Logging;

namespace BSIOAuth.Common.BSICustomeLog;

public static class CustomLogger
{
    public  static void CustomeLogInformation(this ILogger logger,string Message,int Line , string Service,string ServiceName,string? ExceptionMessage = null)
    {
        logger.LogInformation($"CreateAt: {DateTime.Now}, ExceptionMessage: {ExceptionMessage} , Message: {Message}, Line: {Line}, Service: {Service}, ServiceName: {ServiceName}");
    }
    public  static void CustomeLogWarning(this ILogger logger,string Message,int Line , string Service,string ServiceName,string? ExceptionMessage = null)
    {
        logger.LogWarning($"CreatAt: {DateTime.Now}, ExceptionMessage: {ExceptionMessage} , Message: {Message}, Line: {Line}, Service: {Service}, ServiceName: {ServiceName}");
    }
    public  static void CustomeLogError(this ILogger logger,string Message,int Line , string Service,string ServiceName,string? ExceptionMessage = null)
    {
        logger.LogError($"CreatAt: {DateTime.Now}, ExceptionMessage: {ExceptionMessage} , Message: {Message}, Line: {Line}, Service: {Service}, ServiceName: {ServiceName}");
    }
}