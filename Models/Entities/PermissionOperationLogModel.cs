namespace RfidWebAPI.Shared.Models.Entities
{
    public class PermissionOperationLogModel
    {
        public int Id { get; set; }
        public int OperatorAccountId { get; set; }
        public string OperatorName { get; set; } = string.Empty;
        public int? TargetAccountRoleId { get; set; }
        public string? TargetAccountRoleName { get; set; }
        public string ActionType { get; set; } = string.Empty;
        public string? PermissionChangesJSON { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
