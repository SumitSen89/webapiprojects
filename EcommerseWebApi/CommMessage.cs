using System.ComponentModel.DataAnnotations;

namespace EcommerseWebApi
{
    public class CommMessage
    {
        ApplicationDBContext db;

        public CommMessage(ApplicationDBContext _db)
        {
            db = _db;
        }

        [Key]
        public int? Id { get; set; }        

        public Boolean isError { get; set; } = false;

        public string? ErrorNumber { get; set; }

        public string?  ErrorMessage { get; set; }

        public DateTime Created { get; set; }

        public string UserID { get; set; }

        public string Controler { get; set; }

        public string method { get; set; }

        public string Operation { get; set; }

        public CommMessage_Modal RecordError(string ErrorMessage, string ErrNumber, string uid, string Controller, string Method , string Operation)
        {
            CommMessage_Modal returnmessage = new CommMessage_Modal();
            returnmessage.isError = true;
            returnmessage.ErrorMessage = ErrorMessage;

            this.isError = true;
            this.ErrorMessage = ErrorMessage;
            this.UserID = uid;
            this.Controler = Controller;
            this.method = Method;
            this.Created = DateTime.Now;
            this.Operation = Operation;

            db.commMessages.Add(this);
            db.SaveChanges();

            return returnmessage;
        }

        public CommMessage_Modal GenerateMessage(string ErrorMesage)
        {
            CommMessage_Modal returnmessage = new CommMessage_Modal();
            //returnmessage.Message = Message;
            returnmessage.isSuccess = true;
            return returnmessage;
        }
    }




    public class CommMessage_Modal
    {

        public int Id { get; set; }
        public string Message { get; set; }
        public Boolean isSuccess { get; set; } = false;
        public Boolean isError { get; set; } = false;
        public string ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }
    }
}
