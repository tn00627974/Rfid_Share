using System.ComponentModel;

namespace RfidWebAPI.Shared.Models.Dtos.Area
{
    /// <summary>
    /// 區域資料傳輸物件
    /// </summary>
    public class AreaDto
    {
        /// <summary>
        /// 區域 ID
        /// </summary>
        [Description("區域 ID")]
        public int Id { get; set; }

        /// <summary>
        /// 區域名稱
        /// </summary>
        [Description("區域名稱")]
        public string? Name { get; set; }
    }
}
