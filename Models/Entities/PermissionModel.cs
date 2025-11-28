namespace RfidWebAPI.Shared.Models.Entities
{
    public class PermissionModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ResourceType { get; set; } = string.Empty;
        public string ResourceCode { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
