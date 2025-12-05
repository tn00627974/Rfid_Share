namespace RfidWebAPI.Shared.Models.Entities
{
    /// <summary>
    /// 輔具處理佇列表：追蹤輔具在站點的處理狀態
    /// </summary>
    public class AuxUsageQueueModel
    {
        public int Id { get; set; }
        /// <summary>
        /// 輔具序號
        /// </summary>
        public string AuxSn { get; set; } = string.Empty;

        public string? AuxName { get; set; }

        public string? Category { get; set; }

        public int AuxStateId { get; set; }

        public string? Tag { get; set; }

        public int AreaId { get; set; }

        public bool IsNormal { get; set; } = true;

        public DateTime CreatedAt { get; set; }
    }
}
