using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RfidWebAPI.Shared.Models.Dtos.Account
{
    /// <summary>
    /// 更新帳號資料傳輸物件（部分更新，所有欄位皆為可選）
    /// </summary>
    public class UpdateAccountDto
    {
        /// <summary>
        /// 登入帳號（可選）
        /// </summary>
        [Description("登入帳號")]
        public string? LoginAccount { get; set; }

        /// <summary>
        /// 使用者名稱（可選）
        /// </summary>
        [Description("使用者名稱")]
        public string? Username { get; set; }

        /// <summary>
        /// 密碼（可選，Service 層會轉換為 BCrypt 雜湊）
        /// </summary>
        [Description("密碼")]
        public string? Password { get; set; }

        /// <summary>
        /// 角色 ID（可選）
        /// </summary>
        [Description("角色 ID")]
        public int? AccountRoleId { get; set; }

        /// <summary>
        /// 是否啟用（可選）
        /// </summary>
        [Description("是否啟用")]
        public bool? IsActive { get; set; }

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
