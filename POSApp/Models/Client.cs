using System.ComponentModel.DataAnnotations.Schema;

namespace POSApp.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public bool Active { get; set; }

        [NotMapped]
        public string UserName 
        { 
            get
            {
                return Email?.Split('@').FirstOrDefault() ?? string.Empty;
            }
            set
            {

            }
        } 

    }
}
