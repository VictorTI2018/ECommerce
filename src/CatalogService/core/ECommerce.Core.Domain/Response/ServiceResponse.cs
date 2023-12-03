namespace ECommerce.Core.Domain.Response
{
    public class ServiceResponse
    {
        public List<string> Messages { get; private set; }

        public bool Status { get; private set; }


        public ServiceResponse(string message, bool status)
        {
            Messages = new List<string> { message };
            Status = status;
        }

        public ServiceResponse(List<string> messages, bool status)
        {
            Messages = messages;
            Status = status;
        }

        public ServiceResponse(bool status)
        {
            Messages = new List<string>();
            Status = status;
        }
    }
}
