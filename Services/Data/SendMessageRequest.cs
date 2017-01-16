namespace Clickatell.Services.Data
{
    public class SendMessageRequest : MessageRequest
    {
        public SendMessageRequest(string message, params string[] phoneNumbers)
            : base(phoneNumbers)
        {
            Message = message;
        }
        public SendMessageRequest(string sendID,string message, params string[] phoneNumbers)
           : base(sendID,phoneNumbers)
        {
            Message = message;
        }

        public SendMessageRequest() { }

        public string Message { get; set; }
    }
}
