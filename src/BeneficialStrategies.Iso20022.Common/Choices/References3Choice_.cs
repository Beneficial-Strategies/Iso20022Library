// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References3Choice.SecuritiesSettlementTransactionConfirmationIdentification))]
    [KnownType(typeof(References3Choice.IntraPositionMovementConfirmationIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesBalanceAccountingReportIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesBalanceCustodyReportIdentification))]
    [KnownType(typeof(References3Choice.IntraPositionMovementPostingReportIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesFinancingConfirmationIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesTransactionPendingReportIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesTransactionPostingReportIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesSettlementTransactionAllegementReportIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification))]
    [KnownType(typeof(References3Choice.PortfolioTransferNotificationIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification))]
    [KnownType(typeof(References3Choice.OtherMessageIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References3Choice.SecuritiesSettlementTransactionConfirmationIdentification),nameof(References3Choice.SecuritiesSettlementTransactionConfirmationIdentification))]
    [JsonDerivedType(typeof(References3Choice.IntraPositionMovementConfirmationIdentification),nameof(References3Choice.IntraPositionMovementConfirmationIdentification))]
    [JsonDerivedType(typeof(References3Choice.SecuritiesBalanceAccountingReportIdentification),nameof(References3Choice.SecuritiesBalanceAccountingReportIdentification))]
    [JsonDerivedType(typeof(References3Choice.SecuritiesBalanceCustodyReportIdentification),nameof(References3Choice.SecuritiesBalanceCustodyReportIdentification))]
    [JsonDerivedType(typeof(References3Choice.IntraPositionMovementPostingReportIdentification),nameof(References3Choice.IntraPositionMovementPostingReportIdentification))]
    [JsonDerivedType(typeof(References3Choice.SecuritiesFinancingConfirmationIdentification),nameof(References3Choice.SecuritiesFinancingConfirmationIdentification))]
    [JsonDerivedType(typeof(References3Choice.SecuritiesTransactionPendingReportIdentification),nameof(References3Choice.SecuritiesTransactionPendingReportIdentification))]
    [JsonDerivedType(typeof(References3Choice.SecuritiesTransactionPostingReportIdentification),nameof(References3Choice.SecuritiesTransactionPostingReportIdentification))]
    [JsonDerivedType(typeof(References3Choice.SecuritiesSettlementTransactionAllegementReportIdentification),nameof(References3Choice.SecuritiesSettlementTransactionAllegementReportIdentification))]
    [JsonDerivedType(typeof(References3Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification),nameof(References3Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification))]
    [JsonDerivedType(typeof(References3Choice.PortfolioTransferNotificationIdentification),nameof(References3Choice.PortfolioTransferNotificationIdentification))]
    [JsonDerivedType(typeof(References3Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification),nameof(References3Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification))]
    [JsonDerivedType(typeof(References3Choice.OtherMessageIdentification),nameof(References3Choice.OtherMessageIdentification))]
    #endif
    [IsoId("_USqtF9p-Ed-ak6NoX_4Aeg_1744760474")]
    [DisplayName("References 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References3Choice_
    #else
    public abstract partial class References3Choice_
    #endif
    {
    }
}
