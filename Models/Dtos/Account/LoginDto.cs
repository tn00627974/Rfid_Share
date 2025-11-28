using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RfidWebAPI.Shared.Models.Dtos.Account
{
    /// <summary>
    /// 登入資料傳輸物件
    /// </summary>
    public class LoginDto
    {
        /// <summary>
        /// 登入帳號
        /// </summary>
        [Description("登入帳號")]
        [Required(ErrorMessage = "登入帳號不可為空")]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// 密碼
        /// </summary>
        [Description("密碼")]
        [Required(ErrorMessage = "密碼不可為空")]
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// 登入來源 IP 位址（由前端提供）
        /// </summary>
        [Description("登入來源 IP 位址")]
        [Required(ErrorMessage = "IP 位址不可為空")]
        public string IpAddress { get; set; } = string.Empty;
    }
}
