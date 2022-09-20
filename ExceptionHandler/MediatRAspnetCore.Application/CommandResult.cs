namespace MediatR.AspnetCore.Application;

public class CoommandResult {
    public bool Success { get; set; }
    public bool IsInternalError { get; set; }
    public string Message { get; set; }
    public object Data { get; set; }
}