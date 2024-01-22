namespace BSIOAuth.Common.BSIApiConteract;

public class AppError
{
    public int Code { get; set; }
    public string Message { get; set; }

    public KeyValuePair<string, string> ExteraFields { get; set; }
}