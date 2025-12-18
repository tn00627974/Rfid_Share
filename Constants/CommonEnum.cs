using System.ComponentModel;

namespace RfidWebAPI.Shared.Constants
{
    /// <summary>
    /// 操作日誌類型
    /// </summary>
    public enum OperationType
    {
        [Description("創建")]
        Create,

        [Description("啟用")]
        Enable,

        [Description("停用")]
        Disable,

        [Description("編輯")]
        Update
    }

    public enum SeverityType
    {
        Info,
        Warning,
        Error,
    }

    /// <summary>
    /// 頁面類型
    /// </summary>
    public enum PageType
    {
        Station,

        Menu
    }
}
