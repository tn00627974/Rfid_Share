using System.ComponentModel;

namespace RfidWebAPI.Shared.Models.Dtos.Log
{
    /// <summary>
    /// 操作日誌資料傳輸物件（用於查詢和回傳）
    /// </summary>
    public class LogDto
    {
        /// <summary>
        /// 操作者名稱
        /// </summary>
        [Description("操作者名稱")]
        public string OperatorName { get; set; } = string.Empty;

        /// <summary>
        /// 目標名稱
        /// </summary>
        [Description("目標帳號名稱")]
        public string TargetName { get; set; } = string.Empty;

        /// <summary>
        /// 操作類型（Create/Update/Delete/Enable/Disable）
        /// </summary>
        [Description("操作類型")]
        public string ActionType { get; set; } = string.Empty;

        /// <summary>
        /// 操作描述
        /// </summary>
        [Description("操作描述")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 操作時間
        /// </summary>
        [Description("操作時間")]
        public DateTime CreatedAt { get; set; }
    }
}
