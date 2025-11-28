using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RfidWebAPI.Shared.Models.Dtos.Account
{
    /// <summary>
    /// 新增帳號資料傳輸物件
    /// </summary>
    public class CreateAccountDto
    {
        /// <summary>
        /// 登入帳號（3-50 字元）
        /// </summary>
        [Description("登入帳號")]
        [Required(ErrorMessage = "登入帳號不可為空")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "登入帳號長度需在 3-50 字元")]
        public string LoginAccount { get; set; } = string.Empty;

        /// <summary>
        /// 使用者名稱（顯示名稱，2-50 字元）
        /// </summary>
        [Description("使用者名稱")]
        [Required(ErrorMessage = "使用者名稱不可為空")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "使用者名稱長度需在 2-50 字元")]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// 密碼（6-100 字元）
        /// </summary>
        [Description("密碼")]
        [Required(ErrorMessage = "密碼不可為空")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "密碼長度需在 6-100 字元")]
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// 角色 ID
        /// </summary>
        [Description("角色 ID")]
        [Required(ErrorMessage = "角色 ID 不可為空")]
        public int AccountRoleId { get; set; }

        /// <summary>
        /// 是否啟用（預設為 true）
        /// </summary>
        [Description("是否啟用")]
        public bool IsActive { get; set; } = true;

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
