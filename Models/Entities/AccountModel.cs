namespace RfidWebAPI.Shared.Models.Entities
{
    public class AccountModel
    {
        public int Id { get; set; }

        public string LoginAccount { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public int AccountRoleId { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? LastLoginAt { get; set; }

        /// <summary>
        /// 安全戳記，用於強制登出機制。每次登入/更新帳號時會產生新的 Guid
        /// </summary>
        public string? SecurityStamp { get; set; }

        public AccountRoleModel? AccountRoleModel { get; set; }
    }
}
