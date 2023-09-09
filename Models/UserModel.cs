namespace Pathfinder_API.Models;

public class UserModel
{
    [Key]
    public Int32 Id { get; set; }
    public String? FirstName { get; set; }
    public String? LastName { get; set; }
    public String? Email { get; set; }
    public String? Password { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Int32 ModifiedBy { get; set; }
    public Boolean Active { get; set; }
    public Roles Role { get; set; } = new Roles();
}