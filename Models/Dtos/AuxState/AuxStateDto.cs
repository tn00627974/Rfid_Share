using System.ComponentModel;

namespace RfidWebAPI.Shared.Models.Dtos.AuxState
{
    /// <summary>
    /// 輔具狀態資料傳輸物件
    /// </summary>
    public class AuxStateDto
    {
        /// <summary>
        /// 狀態 ID
        /// </summary>
        [Description("狀態 ID")]
        public int Id { get; set; }

        /// <summary>
        /// 狀態名稱
        /// </summary>
        [Description("狀態名稱")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 狀態顏色
        /// </summary>
        [Description("狀態顏色")]
        public string? Color { get; set; }

        /// <summary>
        /// 狀態描述
        /// </summary>
        [Description("狀態描述")]
        public string? Description { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        [Description("建立時間")]
        public DateTime CreatedAt { get; set; }
    }
}
