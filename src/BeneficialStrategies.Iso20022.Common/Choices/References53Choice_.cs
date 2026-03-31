// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(
        typeof(References53Choice.SecuritiesSettlementTransactionConfirmationIdentification)
    )]
    [KnownType(typeof(References53Choice.IntraPositionMovementConfirmationIdentification))]
    [KnownType(typeof(References53Choice.SecuritiesBalanceAccountingReportIdentification))]
    [KnownType(typeof(References53Choice.SecuritiesBalanceCustodyReportIdentification))]
    [KnownType(typeof(References53Choice.IntraPositionMovementPostingReportIdentification))]
    [KnownType(typeof(References53Choice.SecuritiesFinancingConfirmationIdentification))]
    [KnownType(typeof(References53Choice.SecuritiesTransactionPendingReportIdentification))]
    [KnownType(typeof(References53Choice.SecuritiesTransactionPostingReportIdentification))]
    [KnownType(
        typeof(References53Choice.SecuritiesSettlementTransactionAllegementReportIdentification)
    )]
    [KnownType(
        typeof(References53Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification)
    )]
    [KnownType(typeof(References53Choice.PortfolioTransferNotificationIdentification))]
    [KnownType(
        typeof(References53Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification)
    )]
    [KnownType(typeof(References53Choice.OtherMessageIdentification))]
    [KnownType(typeof(References53Choice.TotalPortfolioValuationReportIdentification))]
    [JsonDerivedType(
        typeof(References53Choice.SecuritiesSettlementTransactionConfirmationIdentification),
        nameof(References53Choice.SecuritiesSettlementTransactionConfirmationIdentification)
    )]
    [JsonDerivedType(
        typeof(References53Choice.IntraPositionMovementConfirmationIdentification),
        nameof(References53Choice.IntraPositionMovementConfirmationIdentification)
    )]
    [JsonDerivedType(
        typeof(References53Choice.SecuritiesBalanceAccountingReportIdentification),
        nameof(References53Choice.SecuritiesBalanceAccountingReportIdentification)
    )]
    [JsonDerivedType(
        typeof(References53Choice.SecuritiesBalanceCustodyReportIdentification),
        nameof(References53Choice.SecuritiesBalanceCustodyReportIdentification)
    )]
    [JsonDerivedType(
        typeof(References53Choice.IntraPositionMovementPostingReportIdentification),
        nameof(References53Choice.IntraPositionMovementPostingReportIdentification)
    )]
    [JsonDerivedType(
        typeof(References53Choice.SecuritiesFinancingConfirmationIdentification),
        nameof(References53Choice.SecuritiesFinancingConfirmationIdentification)
    )]
    [JsonDerivedType(
        typeof(References53Choice.SecuritiesTransactionPendingReportIdentification),
        nameof(References53Choice.SecuritiesTransactionPendingReportIdentification)
    )]
    [JsonDerivedType(
        typeof(References53Choice.SecuritiesTransactionPostingReportIdentification),
        nameof(References53Choice.SecuritiesTransactionPostingReportIdentification)
    )]
    [JsonDerivedType(
        typeof(References53Choice.SecuritiesSettlementTransactionAllegementReportIdentification),
        nameof(References53Choice.SecuritiesSettlementTransactionAllegementReportIdentification)
    )]
    [JsonDerivedType(
        typeof(References53Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification),
        nameof(
            References53Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification
        )
    )]
    [JsonDerivedType(
        typeof(References53Choice.PortfolioTransferNotificationIdentification),
        nameof(References53Choice.PortfolioTransferNotificationIdentification)
    )]
    [JsonDerivedType(
        typeof(References53Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification),
        nameof(
            References53Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification
        )
    )]
    [JsonDerivedType(
        typeof(References53Choice.OtherMessageIdentification),
        nameof(References53Choice.OtherMessageIdentification)
    )]
    [JsonDerivedType(
        typeof(References53Choice.TotalPortfolioValuationReportIdentification),
        nameof(References53Choice.TotalPortfolioValuationReportIdentification)
    )]
    [IsoId("_6EvMLZNLEeWGlc8L7oPDIg")]
    [DisplayName("References 53 Choice")]
    public abstract record References53Choice_ { }
}
