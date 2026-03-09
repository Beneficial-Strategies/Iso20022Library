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
    [KnownType(typeof(References18Choice.SecuritiesSettlementTransactionConfirmationIdentification))]
    [KnownType(typeof(References18Choice.IntraPositionMovementConfirmationIdentification))]
    [KnownType(typeof(References18Choice.SecuritiesBalanceAccountingReportIdentification))]
    [KnownType(typeof(References18Choice.SecuritiesBalanceCustodyReportIdentification))]
    [KnownType(typeof(References18Choice.IntraPositionMovementPostingReportIdentification))]
    [KnownType(typeof(References18Choice.SecuritiesFinancingConfirmationIdentification))]
    [KnownType(typeof(References18Choice.SecuritiesTransactionPendingReportIdentification))]
    [KnownType(typeof(References18Choice.SecuritiesTransactionPostingReportIdentification))]
    [KnownType(typeof(References18Choice.SecuritiesSettlementTransactionAllegementReportIdentification))]
    [KnownType(typeof(References18Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification))]
    [KnownType(typeof(References18Choice.PortfolioTransferNotificationIdentification))]
    [KnownType(typeof(References18Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification))]
    [KnownType(typeof(References18Choice.OtherMessageIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References18Choice.SecuritiesSettlementTransactionConfirmationIdentification),nameof(References18Choice.SecuritiesSettlementTransactionConfirmationIdentification))]
    [JsonDerivedType(typeof(References18Choice.IntraPositionMovementConfirmationIdentification),nameof(References18Choice.IntraPositionMovementConfirmationIdentification))]
    [JsonDerivedType(typeof(References18Choice.SecuritiesBalanceAccountingReportIdentification),nameof(References18Choice.SecuritiesBalanceAccountingReportIdentification))]
    [JsonDerivedType(typeof(References18Choice.SecuritiesBalanceCustodyReportIdentification),nameof(References18Choice.SecuritiesBalanceCustodyReportIdentification))]
    [JsonDerivedType(typeof(References18Choice.IntraPositionMovementPostingReportIdentification),nameof(References18Choice.IntraPositionMovementPostingReportIdentification))]
    [JsonDerivedType(typeof(References18Choice.SecuritiesFinancingConfirmationIdentification),nameof(References18Choice.SecuritiesFinancingConfirmationIdentification))]
    [JsonDerivedType(typeof(References18Choice.SecuritiesTransactionPendingReportIdentification),nameof(References18Choice.SecuritiesTransactionPendingReportIdentification))]
    [JsonDerivedType(typeof(References18Choice.SecuritiesTransactionPostingReportIdentification),nameof(References18Choice.SecuritiesTransactionPostingReportIdentification))]
    [JsonDerivedType(typeof(References18Choice.SecuritiesSettlementTransactionAllegementReportIdentification),nameof(References18Choice.SecuritiesSettlementTransactionAllegementReportIdentification))]
    [JsonDerivedType(typeof(References18Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification),nameof(References18Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification))]
    [JsonDerivedType(typeof(References18Choice.PortfolioTransferNotificationIdentification),nameof(References18Choice.PortfolioTransferNotificationIdentification))]
    [JsonDerivedType(typeof(References18Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification),nameof(References18Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification))]
    [JsonDerivedType(typeof(References18Choice.OtherMessageIdentification),nameof(References18Choice.OtherMessageIdentification))]
    #endif
    [IsoId("_9EijET9mEeCuVfEpWlZb5g")]
    [DisplayName("References 18 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References18Choice_
    #else
    public abstract partial class References18Choice_
    #endif
    {
    }
}
