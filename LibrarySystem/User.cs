public class User : BaseEntity
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public UserRole Role { get; set; }
}
