namespace ZEIL.HomeWork.DTO
{
    public class ResultCardNumberValidation
    {
        public ResultCardNumberValidation()
        {
        }
        public ResultCardNumberValidation(bool isValid, string message)
        : this()
        {
            this.IsValid = isValid;
            this.Message = message;
        }
        public bool IsValid { get; set; }
        public string Message { get; set; }
    }
}