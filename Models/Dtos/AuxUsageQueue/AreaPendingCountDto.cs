using System.ComponentModel;

namespace RfidWebAPI.Shared.Models.Dtos.AuxUsageQueue
{
    /// <summary>
    /// 區域待處理項目數量資料傳輸物件
    /// </summary>
    public class AreaPendingCountDto
    {
        /// <summary>
        /// 區域 ID
        /// </summary>
        [Description("區域 ID")]
        public int AreaId { get; set; }

        /// <summary>
        /// 待處理項目數量
        /// </summary>
        [Description("待處理項目數量")]
        public int PendingCount { get; set; }
    }
}
