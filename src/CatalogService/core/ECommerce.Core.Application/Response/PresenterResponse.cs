namespace ECommerce.Core.Application.Response
{
    public class PresenterResponse
    {
        public List<string> Messages { get; private set; }

        public bool Status { get; private set; }

        public object? Data { get; private set; }


        public PresenterResponse(List<string> messages, bool status)
        {
            Messages = messages;
            Status = status;
        }

        public PresenterResponse(string messages, bool status, object? data)
        {
            Messages = new List<string> { messages  };
            Status = status;
            Data = data;
        }

        public PresenterResponse(string messages, bool status)
        {
            Messages = new List<string> { messages };
            Status = status;
        }
    }
}
