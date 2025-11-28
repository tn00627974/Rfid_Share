namespace RfidWebAPI.Shared.Models.Entities
{
    /// <summary>
    /// 系統事件日誌實體
    /// </summary>
    public class SystemEventLogModel
    {
        public int Id { get; set; }

        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// 事件來源(ex: RateLimiter, RfidApiService, SecurityStampFilter)
        /// </summary>
        public string? Source { get; set; }

        /// <summary>
        /// 嚴重程度(Info, Warning, Error, Critical)
        /// </summary>
        public string Severity { get; set; } = string.Empty;

        /// <summary>
        /// 訊息摘要
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// 詳細資訊 (可存 JSON、StackTrace 等)
        /// </summary>
        public string? Details { get; set; }

        /// <summary>
        /// 觸發事件的IP位址
        /// </summary>
        public string? IpAddress { get; set; }

        /// <summary>
        /// 關聯的帳號ID(部分系統事件無使用者)
        /// </summary>
        public int? AccountId { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
