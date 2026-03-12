// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References43Choice.SecuritiesSettlementTransactionConfirmationIdentification))]
    [KnownType(typeof(References43Choice.IntraPositionMovementConfirmationIdentification))]
    [KnownType(typeof(References43Choice.SecuritiesBalanceAccountingReportIdentification))]
    [KnownType(typeof(References43Choice.SecuritiesBalanceCustodyReportIdentification))]
    [KnownType(typeof(References43Choice.IntraPositionMovementPostingReportIdentification))]
    [KnownType(typeof(References43Choice.SecuritiesFinancingConfirmationIdentification))]
    [KnownType(typeof(References43Choice.SecuritiesTransactionPendingReportIdentification))]
    [KnownType(typeof(References43Choice.SecuritiesTransactionPostingReportIdentification))]
    [KnownType(typeof(References43Choice.SecuritiesSettlementTransactionAllegementReportIdentification))]
    [KnownType(typeof(References43Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification))]
    [KnownType(typeof(References43Choice.PortfolioTransferNotificationIdentification))]
    [KnownType(typeof(References43Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification))]
    [KnownType(typeof(References43Choice.OtherMessageIdentification))]
    [KnownType(typeof(References43Choice.TotalPortfolioValuationReportIdentification))]
    [JsonDerivedType(typeof(References43Choice.SecuritiesSettlementTransactionConfirmationIdentification),nameof(References43Choice.SecuritiesSettlementTransactionConfirmationIdentification))]
    [JsonDerivedType(typeof(References43Choice.IntraPositionMovementConfirmationIdentification),nameof(References43Choice.IntraPositionMovementConfirmationIdentification))]
    [JsonDerivedType(typeof(References43Choice.SecuritiesBalanceAccountingReportIdentification),nameof(References43Choice.SecuritiesBalanceAccountingReportIdentification))]
    [JsonDerivedType(typeof(References43Choice.SecuritiesBalanceCustodyReportIdentification),nameof(References43Choice.SecuritiesBalanceCustodyReportIdentification))]
    [JsonDerivedType(typeof(References43Choice.IntraPositionMovementPostingReportIdentification),nameof(References43Choice.IntraPositionMovementPostingReportIdentification))]
    [JsonDerivedType(typeof(References43Choice.SecuritiesFinancingConfirmationIdentification),nameof(References43Choice.SecuritiesFinancingConfirmationIdentification))]
    [JsonDerivedType(typeof(References43Choice.SecuritiesTransactionPendingReportIdentification),nameof(References43Choice.SecuritiesTransactionPendingReportIdentification))]
    [JsonDerivedType(typeof(References43Choice.SecuritiesTransactionPostingReportIdentification),nameof(References43Choice.SecuritiesTransactionPostingReportIdentification))]
    [JsonDerivedType(typeof(References43Choice.SecuritiesSettlementTransactionAllegementReportIdentification),nameof(References43Choice.SecuritiesSettlementTransactionAllegementReportIdentification))]
    [JsonDerivedType(typeof(References43Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification),nameof(References43Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification))]
    [JsonDerivedType(typeof(References43Choice.PortfolioTransferNotificationIdentification),nameof(References43Choice.PortfolioTransferNotificationIdentification))]
    [JsonDerivedType(typeof(References43Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification),nameof(References43Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification))]
    [JsonDerivedType(typeof(References43Choice.OtherMessageIdentification),nameof(References43Choice.OtherMessageIdentification))]
    [JsonDerivedType(typeof(References43Choice.TotalPortfolioValuationReportIdentification),nameof(References43Choice.TotalPortfolioValuationReportIdentification))]
    [IsoId("_5JyDATqnEeWyoP0PbocV1Q")]
    [DisplayName("References 43 Choice")]
    public abstract partial record References43Choice_
    {
    }
}
