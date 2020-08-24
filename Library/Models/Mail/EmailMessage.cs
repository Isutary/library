namespace Library.Models.Mail
{
    public class EmailMessage
    {
        public string To { get; }
        public string Subject { get; }
        public string Content { get; }

        public EmailMessage(string to, string subject, string content)
            => (To, Subject, Content) = (to, subject, content);
    }
}
