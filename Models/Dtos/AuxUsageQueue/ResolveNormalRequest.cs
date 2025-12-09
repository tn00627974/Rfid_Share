using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfidWebAPI.Shared.Models.Dtos.AuxUsageQueue
{
    public class ResolveNormalRequest
    {        
        /// <summary>
        /// 正常佇列項目 ID 列表
        /// </summary>
        [Required(ErrorMessage = "正常佇列項目 ID 列表不可為空")]
        [MinLength(1, ErrorMessage = "至少需要一筆正常項目")]
        public List<int> Ids { get; set; } = [];

        /// <summary>
        /// 更改後的輔具狀態 ID
        /// </summary>
        [Required(ErrorMessage = "更改後的狀態不可為空")]
        public int StateId { get; set; }

        /// <summary>
        /// 操作者帳號 ID（由呼叫方提供，用於審計日誌）
        /// </summary>
        [Description("操作者帳號 ID")]
        [Required(ErrorMessage = "操作者 ID 不可為空")]
        public int OperatorAccountId { get; set; }

        /// <summary>
        /// 操作者帳號名稱（由呼叫方提供，用於審計日誌）
        /// </summary>
        [Description("操作者帳號名稱")]
        [Required(ErrorMessage = "操作者名稱不可為空")]
        public string OperatorAccountName { get; set; } = string.Empty;
    }
}
