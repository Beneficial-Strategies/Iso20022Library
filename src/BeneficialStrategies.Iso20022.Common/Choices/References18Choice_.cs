// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

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
    [IsoId("_9EijET9mEeCuVfEpWlZb5g")]
    [DisplayName("References 18 Choice")]
    public abstract partial record References18Choice_
    {
    }
}
