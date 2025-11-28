namespace RfidWebAPI.Shared.Models.Entities
{
    /// <summary>
    /// 輔具狀態表：定義輔具的各種狀態
    /// </summary>
    public class AuxStateModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
