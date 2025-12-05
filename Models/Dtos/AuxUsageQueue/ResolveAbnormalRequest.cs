using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RfidWebAPI.Shared.Models.Dtos.AuxUsageQueue
{
    /// <summary>
    /// 解決異常佇列請求
    /// </summary>
    public class ResolveAbnormalRequest
    {
        /// <summary>
        /// 異常佇列項目 ID 列表
        /// </summary>
        [Required(ErrorMessage = "異常佇列項目 ID 列表不可為空")]
        [MinLength(1, ErrorMessage = "至少需要一筆異常項目")]
        public List<int> Ids { get; set; } = [];

        /// <summary>
        /// 更改後的輔具狀態 ID
        /// </summary>
        [Required(ErrorMessage = "更改後的狀態不可為空")]
        public int StateId { get; set; }

        /// <summary>
        /// 異常原因說明
        /// </summary>
        [Required(ErrorMessage = "異常原因不可為空")]
        [StringLength(500, ErrorMessage = "異常原因不可超過 500 字元")]
        public string AbnormalReason { get; set; } = string.Empty;

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
