using System.ComponentModel;

namespace RfidWebAPI.Shared.Models.Dtos.Account
{
    /// <summary>
    /// 帳號資料傳輸物件（用於查詢和回傳）
    /// </summary>
    public class AccountDto
    {
        /// <summary>
        /// 帳號 ID
        /// </summary>
        [Description("帳號 ID")]
        public int Id { get; set; }

        /// <summary>
        /// 登入帳號
        /// </summary>
        [Description("登入帳號")]
        public string LoginAccount { get; set; } = string.Empty;

        /// <summary>
        /// 使用者名稱（顯示名稱）
        /// </summary>
        [Description("使用者名稱")]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// 角色 ID
        /// </summary>
        [Description("角色 ID")]
        public int RoleId { get; set; }

        /// <summary>
        /// 角色名稱
        /// </summary>
        [Description("角色名稱")]
        public string RoleName { get; set; } = string.Empty;

        /// <summary>
        /// 是否啟用
        /// </summary>
        [Description("是否啟用")]
        public bool IsActive { get; set; }

        /// <summary>
        /// 最後登入時間
        /// </summary>
        [Description("最後登入時間")]
        public DateTime? LastLogin { get; set; }

        /// <summary>
        /// 安全戳記（用於驗證 Session 有效性）
        /// </summary>
        [Description("安全戳記")]
        public string? SecurityStamp { get; set; }
    }
}
