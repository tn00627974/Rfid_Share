namespace RfidWebAPI.Shared.Models.Entities
{
    /// <summary>
    /// 狀態轉換表：定義輔具狀態之間允許的轉換路徑
    /// </summary>
    public class AuxStateTransitionModel
    {
        public int Id { get; set; }

        public int FromStateId { get; set; }

        public int ToStateId { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
