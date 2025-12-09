namespace RfidWebAPI.Shared.Models.Dtos.AuxUsageQueue
{
    /// <summary>
    /// 處理佇列回應
    /// </summary>
    public class ResolveQueueResponse
    {
        /// <summary>
        /// 處理訊息
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// 成功處理的項目數量
        /// </summary>
        public int SuccessCount { get; set; }

        /// <summary>
        /// 失敗的項目詳細資訊
        /// </summary>
        public List<FailedItem> FailedItems { get; set; } = [];
    }

    /// <summary>
    /// 失敗項目資訊
    /// </summary>
    public class FailedItem
    {
        /// <summary>
        /// 佇列項目 ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 失敗原因
        /// </summary>
        public string Reason { get; set; } = string.Empty;
    }
}
