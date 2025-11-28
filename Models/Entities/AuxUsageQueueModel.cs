namespace RfidWebAPI.Shared.Models.Entities
{
    /// <summary>
    /// 輔具處理佇列表：追蹤輔具在站點的處理狀態
    /// </summary>
    public class AuxUsageQueueModel
    {
        public int Id { get; set; }

        /// <summary>
        /// 對應 ERP 輔具 Id
        /// </summary>
        public int AuxId { get; set; }

        public string? Category { get; set; }

        public int AuxStateId { get; set; }

        public string? Tag { get; set; }

        public string Area { get; set; } = string.Empty;

        public bool IsAuxAbnormal { get; set; } = false;

        public DateTime CreatedAt { get; set; }
    }
}
