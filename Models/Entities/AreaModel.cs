namespace RfidWebAPI.Shared.Models.Entities
{
    /// <summary>
    /// 區域表：定義各個區域的配置資訊
    /// </summary>
    public class AreaModel
    {
        public int AreaID { get; set; }

        public string? AreaName { get; set; }

        public string? Description { get; set; }

        public string Status { get; set; } = string.Empty;

        public string? SSTID { get; set; }

        public string? LayoutImage { get; set; }
    }
}
