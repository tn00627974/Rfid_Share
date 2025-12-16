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

    /// <summary>
    /// 權限代碼，對應 Permission 表的 ResourceCode
    /// </summary>
    public enum PermissionCode
    {
        /// <summary>
        /// 倉庫管理頁面存取權限
        /// </summary>
        WarehouseManagement,

        /// <summary>
        /// 檢修包裝頁面存取權限
        /// </summary>
        PackagingInspection,

        /// <summary>
        /// 帳號管理頁面存取權限
        /// </summary>
        Account,

        /// <summary>
        /// 權限管理頁面存取權限
        /// </summary>
        Permission,

        /// <summary>
        /// 異常處理頁面存取權限
        /// </summary>
        AbnormalHandling,

        /// <summary>
        /// 待派送頁面存取權限
        /// </summary>
        PendingDispatch,

        //INFO: 未來新增權限時，在此加入新的 Enum 值，並確保資料庫 Permission 表有對應記錄
    }
}
