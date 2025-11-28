using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RfidWebAPI.Shared.Models.Dtos.AccountRole
{
    /// <summary>
    /// 更新帳號角色資料傳輸物件（部分更新，所有欄位皆為可選）
    /// </summary>
    public class UpdateAccountRoleDto
    {
        /// <summary>
        /// 角色名稱（可選，2-30 字元）
        /// </summary>
        [Description("角色名稱")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "名稱長度需在 2-30 字元")]
        public string? Name { get; set; }

        /// <summary>
        /// 角色描述（可選，最多 100 字元）
        /// </summary>
        [Description("角色描述")]
        [StringLength(100, ErrorMessage = "描述長度不可超過 100 字元")]
        public string? Description { get; set; }

        /// <summary>
        /// 是否啟用（可選）
        /// </summary>
        [Description("是否啟用")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// 權限 ID 列表（可選，null 表示不更新權限）
        /// </summary>
        [Description("權限 ID 列表")]
        public List<int>? PermissionId { get; set; }

        /// <summary>
        /// 操作者帳號 ID（由呼叫方提供，用於審計日誌）
        /// </summary>
        [Description("操作者帳號 ID")]
        [Required(ErrorMessage = "操作者 ID 不可為空")]
        public int OperatorAccountId { get; set; }

        /// <summary>
        /// 操作者帳號名稱（由呼叫方提供，用於審計日誌）
        /// </summary>
        [Description("操作者帳號名稱")]
        [Required(ErrorMessage = "操作者名稱不可為空")]
        public string OperatorAccountName { get; set; } = string.Empty;
    }
}
