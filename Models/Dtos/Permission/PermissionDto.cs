using System.ComponentModel;

namespace RfidWebAPI.Shared.Models.Dtos.Permission
{
    /// <summary>
    /// 權限資料傳輸物件（用於查詢和回傳）
    /// </summary>
    public class PermissionDto
    {
        /// <summary>
        /// 權限 ID
        /// </summary>
        [Description("權限 ID")]
        public int Id { get; set; }

        /// <summary>
        /// 權限名稱
        /// </summary>
        [Description("權限名稱")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 權限資源代碼
        /// </summary>
        [Description("權限資源代碼")]
        public string ResourceCode { get; set; } = string.Empty;

        /// <summary>
        /// 權限描述
        /// </summary>
        [Description("權限描述")]
        public string? Description { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        [Description("建立時間")]
        public DateTime? CreatedDate { get; set; }
    }
}
