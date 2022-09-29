namespace LakesSurvey.Models;

public class DnrLakeSurveyResponse<T>
{
    public string Message { get; set; }
    public T Result { get; set; }
    public long Timestamp { get; set; }
    public string Status { get; set; }
}

public class DnrLakeResponse<T>
{
    public string Message { get; set; }
    public T Results { get; set; }
    public long Timestamp { get; set; }
    public string Status { get; set; }
}
