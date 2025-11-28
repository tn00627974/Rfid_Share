namespace RfidWebAPI.Shared.Models.Entities
{
    /// <summary>
    /// 帳號操作歷史記錄實體
    /// </summary>
    public class AccountOperationLogModel
    {
        public int Id { get; set; }

        public int OperatorAccountId { get; set; }

        public string OperatorName { get; set; } = string.Empty;

        /// <summary>
        /// 目標帳號ID(被操作的帳號，可為 null)
        /// </summary>
        public int? TargetAccountId { get; set; }

        public string? TargetAccountName { get; set; }

        /// <summary>
        /// 操作類型
        /// </summary>
        public string ActionType { get; set; } = string.Empty;

        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
