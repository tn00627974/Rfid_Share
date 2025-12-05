namespace RfidWebAPI.Shared.Models.Entities
{
    public class AuxSnTableModel
    {
        public int RowID { get; set; }
        public string? Org { get; set; }

        /// <summary>
        /// 輔具編號
        /// </summary>
        public string? AuxID { get; set; }

        /// <summary>
        /// 新的輔具編號
        /// </summary>
        public string? AuxID_L1 { get; set; }

        /// <summary>
        /// 種類
        /// </summary>
        public string? AuxCat { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        public string? Auxname { get; set; }

        public string? Auxat { get; set; }

        /// <summary>
        /// 所在地
        /// </summary>
        public string? NowAuxat { get; set; }

        public string? Reserveat { get; set; }
        public int? LeasetablerowID { get; set; }
        public string? Setuptime { get; set; }
        public string? Setupuser { get; set; }

        /// <summary>
        /// Barcode 代碼
        /// </summary>
        public string? AuxBarcode { get; set; }

        public string? Auxqrbs64str { get; set; }
        public string? DeviceSN { get; set; }

        /// <summary>
        /// 廠商名稱
        /// </summary>
        public string? ManufacturerBrand { get; set; }

        /// <summary>
        /// 型號
        /// </summary>
        public string? ManufacturerModel { get; set; }
        public string? ItemSpec { get; set; }
        public string? Unit { get; set; }
        public string? DeviceMakeTime { get; set; }
        public string? AuxNote { get; set; }
        public string? Itempic01 { get; set; }
        public string? Itempic02 { get; set; }
        public string? Warrantypaper01 { get; set; }
        public string? Warrantypaper02 { get; set; }
        public string? DeviceSNpic { get; set; }
        public string? InvoicePic { get; set; }

        /// <summary>
        /// 狀態
        /// </summary>
        public string? State { get; set; }

        public string? Itemstate { get; set; }
        public string? PdfPapper { get; set; }
        public string? DelYN { get; set; }
        public string? ItemHis { get; set; }

        /// <summary>
        /// RFID Tag
        /// </summary>
        public string? Rfidname { get; set; }

        public string? AuxPrice { get; set; }

        /// <summary>
        /// 更新時間
        /// </summary>
        public DateTime? UpdateTime { get; set; }
    }
}
