namespace RfidWebAPI.Shared.Constants
{
    /// <summary>
    /// 權限代碼，對應 Permission 表的 ResourceCode
    /// </summary>
    public static class PermissionCode
    {
        /// <summary>
        /// 倉庫管理頁面存取權限
        /// </summary>
        public const string WarehouseManagement = "WarehouseManagement";

        /// <summary>
        /// 檢修包裝頁面存取權限
        /// </summary>
        public const string PackagingInspection = "PackagingInspection";

        /// <summary>
        /// 帳號管理頁面存取權限
        /// </summary>
        public const string Account = "Account";

        /// <summary>
        /// 權限管理頁面存取權限
        /// </summary>
        public const string Permission = "Permission";

        /// <summary>
        /// 異常處理頁面存取權限
        /// </summary>
        public const string AbnormalHandling = "AbnormalHandling";

        /// <summary>
        /// 待派送頁面存取權限
        /// </summary>
        public const string PendingDispatch = "PendingDispatch";

        //INFO: 未來新增權限時，在此加入新的 const string，並確保資料庫 Permission 表有對應記錄
    }
}
