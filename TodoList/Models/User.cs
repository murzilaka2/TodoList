namespace TodoList.Models
{
    public class User
    {
        public Guid Id { get; set; } 
        public string Email { get; set; }
        public string HashedPasssword { get; set; }
        public string Salt { get; set; }
    }

}
