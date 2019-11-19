//using System.Net;

//namespace DataStreamPro.Producer.Spotify.WebApi.Results
//{
//    public class ErrorResult : ObjectResult
//    {
//        public ErrorResult(Error error, string reason, HttpStatusCode statusCode) : this(CreateErrorMessage(error, reason), statusCode)
//        {
//        }

//        public ErrorResult(Error error, HttpStatusCode statusCode) : base(error)
//        {
//            StatusCode = (int)statusCode;
//        }

//        private static ErrorMessage CreateErrorMessage(Error error, string reason)
//        {
//            return new ErrorMessage()
//            {
//                Error = error.ToString(),
//                Reason = reason
//            };
//        }
//    }
//}
