using Case1.Enums;

namespace Case1.Entity
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }
        public List<Perms> Perms { get; set; }
    }
}
