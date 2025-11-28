namespace RfidWebAPI.Shared.Models.Entities
{
    public class AccountRoleModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<PermissionModel>? Permissions { get; set; }
    }
}
