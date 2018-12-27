namespace Edi.Blog.Pingback
{
    public enum PingbackServiceResponse
    {
        Success,
        GenericError,
        TerminatedMethodNotFound,
        TerminatedUrlNotFound,
        Error32TargetUriNotExist,
        Error48PingbackAlreadyRegistered,
        Error17SourceNotContainTargetUri,
        SpamDetectedFakeNotFound,
        ValidPingRequest,
        InvalidPingRequest
    }
}