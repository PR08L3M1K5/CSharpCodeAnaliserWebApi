namespace CSharpCodeAnaliserWebApi.CodeAnaliser.Utils
{
    public class CodeStatus
    {
        public bool Status { get; set; }
        public string StatusTitle { get; set; }
        public string StatusDescription { get; set; }

        public CodeStatus(bool status, string title, string description)
        {
            Status = status;
            StatusTitle = title;
            StatusDescription = description;
        }
        public bool GetStatus()
        {
            return Status;
        }
        public string GetTitle()
        {
            return StatusTitle;
        }
        public string GetDescription()
        {
            return StatusDescription;
        }
 
    }
}
