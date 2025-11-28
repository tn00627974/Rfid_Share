namespace RfidWebAPI.Shared.Models.Entities
{
    /// <summary>
    /// 輔具異常處理記錄表：記錄輔具異常狀態處理原因
    /// </summary>
    public class AuxAbnormalLogsModel
    {
        public int Id { get; set; }

        public int FromStateId { get; set; }

        public string FromState { get; set; } = string.Empty;

        public int ToStateId { get; set; }

        public string ToState { get; set; } = string.Empty;

        public int AccountId { get; set; }

        public string AccountName { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }
    }
}
