using System.ComponentModel;

namespace RfidWebAPI.Shared.Models.Dtos.AuxUsageQueue
{
    /// <summary>
    /// 輔具處理佇列資料傳輸物件
    /// </summary>
    public class AuxUsageQueueDto
    {
        /// <summary>
        /// 佇列項目 ID
        /// </summary>
        [Description("佇列項目 ID")]
        public int Id { get; set; }

        /// <summary>
        /// 輔具序號
        /// </summary>
        [Description("輔具序號")]
        public string? AuxSn { get; set; }

        /// <summary>
        /// 輔具名稱
        /// </summary>
        [Description("輔具名稱")]
        public string? AuxName { get; set; }

        /// <summary>
        /// 輔具類別
        /// </summary>
        [Description("輔具類別")]
        public string? Category { get; set; }

        /// <summary>
        /// 輔具狀態 ID
        /// </summary>
        [Description("輔具狀態 ID")]
        public int AuxStateId { get; set; }

        /// <summary>
        /// RFID 標籤
        /// </summary>
        [Description("RFID 標籤")]
        public string? Tag { get; set; }

        /// <summary>
        /// 區域 ID
        /// </summary>
        [Description("區域 ID")]
        public int AreaId { get; set; }

        /// <summary>
        /// 是否為異常輔具
        /// </summary>
        [Description("是否為異常輔具")]
        public bool IsNormal { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        [Description("建立時間")]
        public DateTime CreatedAt { get; set; }
    }
}
