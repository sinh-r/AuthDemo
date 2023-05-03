using AuthPractice.Enum;
using AuthPractice.Models.Responses;

namespace AuthPractice.Interfaces
{
    public interface IPrepareResponseBusiness
    {
        public Response PrepareResponse(Status status, string successResponse, string invalidInputResponse, string exceptionResponse);
        public Response PrepareResponse(Status status, string successResponse, string invalidInputResponse, string exceptionResponse, string expiredResponse);
    }
}
