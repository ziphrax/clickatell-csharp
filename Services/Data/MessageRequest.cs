namespace Clickatell.Services.Data
{
    public class MessageRequest
    {
        public MessageRequest(params string[] phoneNumber)
        {
            PhoneNumbers = phoneNumber;
        }
        public MessageRequest(string sendID, params string[] phoneNumber)
        {
            PhoneNumbers = phoneNumber;
            SenderID = sendID;
        }

        public MessageRequest() { }

        public string[] PhoneNumbers { get; set; }

        public string SenderID { get; set; }
    }
}
