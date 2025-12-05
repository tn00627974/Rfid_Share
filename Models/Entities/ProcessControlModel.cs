namespace RfidWebAPI.Shared.Models.Entities
{
    /// <summary>
    /// 輔具處理歷程記錄表
    /// </summary>
    public class ProcessControlModel
    {
        public int RowId { get; set; }

        /// <summary>
        /// 輔具編號
        /// </summary>
        public string Sn { get; set; } = string.Empty;

        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 狀態
        /// </summary>
        public int? State { get; set; }

        /// <summary>
        /// 所在地
        /// </summary>
        public string Location { get; set; } = string.Empty;

        /// <summary>
        /// 站點
        /// </summary>
        public string Station { get; set; } = string.Empty;

        /// <summary>
        /// 其他資訊
        /// </summary>
        public string? Misc { get; set; }

        /// <summary>
        /// 建立者
        /// </summary>
        public string? CreateBy { get; set; }
    }
}
