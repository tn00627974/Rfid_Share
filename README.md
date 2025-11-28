# RfidWebAPI.Shared

RfidWebAPI 系統的共享類別庫，包含所有共用的資料模型、DTO（資料傳輸物件）和實體定義。

## 專案說明

此專案為 .NET 8.0 類別庫，提供 RFID Web API 生態系統中各服務間的資料契約層，確保資料結構的一致性。

## 專案結構

```
RfidWebAPI.Shared/
├── Models/
│   ├── Entities/          # 資料庫實體模型
│   │   ├── AccountModel.cs              # 帳號實體
│   │   ├── AccountRoleModel.cs          # 帳號角色實體
│   │   ├── PermissionModel.cs           # 權限實體
│   │   ├── AccountOperationLogModel.cs  # 帳號操作日誌
│   │   ├── SystemEventLogModel.cs       # 系統事件日誌
│   │   ├── AuxUsageQueueModel.cs        # 輔具使用佇列
│   │   └── AuxAbnormalLogsModel.cs      # 輔具異常記錄
│   └── Dtos/              # 資料傳輸物件
│       ├── Account/       # 帳號相關 DTO
│       ├── AccountRole/   # 角色相關 DTO
│       ├── Permission/    # 權限相關 DTO
│       └── Log/          # 日誌相關 DTO
```

## 主要功能

### 帳號管理
- 帳號 CRUD 操作的 DTO
- 角色權限管理模型
- 登入驗證 DTO
- 安全戳記（Security Stamp）機制

### 審計日誌
- 帳號操作歷史記錄
- 權限變更記錄
- 系統事件追蹤

### RFID 輔具追蹤
- 輔具處理佇列管理
- 輔具異常狀態記錄

## 開發規範

### Entity（實體）
- 對應資料庫表格結構
- 包含導航屬性
- 可能包含不對外公開的欄位（如 PasswordHash）

### DTO（資料傳輸物件）
- API 的請求/回應契約
- 依操作類型分為 Create、Update、Read DTO
- 包含資料驗證屬性
- 包含 XML 文件註解和 Swagger 描述

### 命名慣例
- 查詢操作：`{Entity}Dto.cs`
- 新增操作：`Create{Entity}Dto.cs`
- 更新操作：`Update{Entity}Dto.cs`
- 特殊操作：`{Action}{Entity}Dto.cs`

## 相關專案

- [RfidWebAPI](https://github.com/tn00627974/RfidWebApi) - 主要 API 專案
