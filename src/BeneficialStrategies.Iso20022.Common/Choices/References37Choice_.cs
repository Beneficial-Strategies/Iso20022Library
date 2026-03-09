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
    [KnownType(typeof(References37Choice.SecuritiesSettlementTransactionConfirmationIdentification))]
    [KnownType(typeof(References37Choice.IntraPositionMovementConfirmationIdentification))]
    [KnownType(typeof(References37Choice.SecuritiesBalanceAccountingReportIdentification))]
    [KnownType(typeof(References37Choice.SecuritiesBalanceCustodyReportIdentification))]
    [KnownType(typeof(References37Choice.IntraPositionMovementPostingReportIdentification))]
    [KnownType(typeof(References37Choice.SecuritiesFinancingConfirmationIdentification))]
    [KnownType(typeof(References37Choice.SecuritiesTransactionPendingReportIdentification))]
    [KnownType(typeof(References37Choice.SecuritiesTransactionPostingReportIdentification))]
    [KnownType(typeof(References37Choice.SecuritiesSettlementTransactionAllegementReportIdentification))]
    [KnownType(typeof(References37Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification))]
    [KnownType(typeof(References37Choice.PortfolioTransferNotificationIdentification))]
    [KnownType(typeof(References37Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification))]
    [KnownType(typeof(References37Choice.OtherMessageIdentification))]
    [KnownType(typeof(References37Choice.TotalPortfolioValuationReportIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References37Choice.SecuritiesSettlementTransactionConfirmationIdentification),nameof(References37Choice.SecuritiesSettlementTransactionConfirmationIdentification))]
    [JsonDerivedType(typeof(References37Choice.IntraPositionMovementConfirmationIdentification),nameof(References37Choice.IntraPositionMovementConfirmationIdentification))]
    [JsonDerivedType(typeof(References37Choice.SecuritiesBalanceAccountingReportIdentification),nameof(References37Choice.SecuritiesBalanceAccountingReportIdentification))]
    [JsonDerivedType(typeof(References37Choice.SecuritiesBalanceCustodyReportIdentification),nameof(References37Choice.SecuritiesBalanceCustodyReportIdentification))]
    [JsonDerivedType(typeof(References37Choice.IntraPositionMovementPostingReportIdentification),nameof(References37Choice.IntraPositionMovementPostingReportIdentification))]
    [JsonDerivedType(typeof(References37Choice.SecuritiesFinancingConfirmationIdentification),nameof(References37Choice.SecuritiesFinancingConfirmationIdentification))]
    [JsonDerivedType(typeof(References37Choice.SecuritiesTransactionPendingReportIdentification),nameof(References37Choice.SecuritiesTransactionPendingReportIdentification))]
    [JsonDerivedType(typeof(References37Choice.SecuritiesTransactionPostingReportIdentification),nameof(References37Choice.SecuritiesTransactionPostingReportIdentification))]
    [JsonDerivedType(typeof(References37Choice.SecuritiesSettlementTransactionAllegementReportIdentification),nameof(References37Choice.SecuritiesSettlementTransactionAllegementReportIdentification))]
    [JsonDerivedType(typeof(References37Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification),nameof(References37Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification))]
    [JsonDerivedType(typeof(References37Choice.PortfolioTransferNotificationIdentification),nameof(References37Choice.PortfolioTransferNotificationIdentification))]
    [JsonDerivedType(typeof(References37Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification),nameof(References37Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification))]
    [JsonDerivedType(typeof(References37Choice.OtherMessageIdentification),nameof(References37Choice.OtherMessageIdentification))]
    [JsonDerivedType(typeof(References37Choice.TotalPortfolioValuationReportIdentification),nameof(References37Choice.TotalPortfolioValuationReportIdentification))]
    #endif
    [IsoId("_tWL8sQ34EeKN_Y-2Awiamw")]
    [DisplayName("References 37 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References37Choice_
    #else
    public abstract partial class References37Choice_
    #endif
    {
    }
}
