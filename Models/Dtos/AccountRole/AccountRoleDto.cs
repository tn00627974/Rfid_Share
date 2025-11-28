using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RfidWebAPI.Shared.Models.Dtos.AccountRole
{
    /// <summary>
    /// 帳號角色資料傳輸物件（用於查詢和回傳）
    /// </summary>
    public class AccountRoleDto
    {
        /// <summary>
        /// 角色 ID
        /// </summary>
        [Description("角色 ID")]
        public int? Id { get; set; }

        /// <summary>
        /// 角色名稱（2-30 字元）
        /// </summary>
        [Description("角色名稱")]
        [Required(ErrorMessage = "名稱不可為空")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "名稱長度需在 2-30 字元")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 角色描述（最多 100 字元）
        /// </summary>
        [Description("角色描述")]
        [StringLength(100, ErrorMessage = "描述長度不可超過 100 字元")]
        public string? Description { get; set; }

        /// <summary>
        /// 權限 ID 列表
        /// </summary>
        [Description("權限 ID 列表")]
        public List<int> PermissionId { get; set; } = [];

        /// <summary>
        /// 建立時間
        /// </summary>
        [Description("建立時間")]
        public DateTime? CreatedAt { get; set; }
    }
}
