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
        typeof(References79Choice.SecuritiesSettlementTransactionConfirmationIdentification)
    )]
    [KnownType(typeof(References79Choice.IntraPositionMovementConfirmationIdentification))]
    [KnownType(typeof(References79Choice.SecuritiesBalanceAccountingReportIdentification))]
    [KnownType(typeof(References79Choice.SecuritiesBalanceCustodyReportIdentification))]
    [KnownType(typeof(References79Choice.IntraPositionMovementPostingReportIdentification))]
    [KnownType(typeof(References79Choice.SecuritiesFinancingConfirmationIdentification))]
    [KnownType(typeof(References79Choice.SecuritiesTransactionPendingReportIdentification))]
    [KnownType(typeof(References79Choice.SecuritiesTransactionPostingReportIdentification))]
    [KnownType(
        typeof(References79Choice.SecuritiesSettlementTransactionAllegementReportIdentification)
    )]
    [KnownType(
        typeof(References79Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification)
    )]
    [KnownType(typeof(References79Choice.PortfolioTransferNotificationIdentification))]
    [KnownType(
        typeof(References79Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification)
    )]
    [KnownType(typeof(References79Choice.OtherMessageIdentification))]
    [KnownType(typeof(References79Choice.TotalPortfolioValuationReportIdentification))]
    [KnownType(
        typeof(References79Choice.TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification)
    )]
    [KnownType(typeof(References79Choice.TripartyCollateralStatusAdviceIdentification))]
    [KnownType(typeof(References79Choice.TripartyCollateralAndExposureReportIdentification))]
    [JsonDerivedType(
        typeof(References79Choice.SecuritiesSettlementTransactionConfirmationIdentification),
        nameof(References79Choice.SecuritiesSettlementTransactionConfirmationIdentification)
    )]
    [JsonDerivedType(
        typeof(References79Choice.IntraPositionMovementConfirmationIdentification),
        nameof(References79Choice.IntraPositionMovementConfirmationIdentification)
    )]
    [JsonDerivedType(
        typeof(References79Choice.SecuritiesBalanceAccountingReportIdentification),
        nameof(References79Choice.SecuritiesBalanceAccountingReportIdentification)
    )]
    [JsonDerivedType(
        typeof(References79Choice.SecuritiesBalanceCustodyReportIdentification),
        nameof(References79Choice.SecuritiesBalanceCustodyReportIdentification)
    )]
    [JsonDerivedType(
        typeof(References79Choice.IntraPositionMovementPostingReportIdentification),
        nameof(References79Choice.IntraPositionMovementPostingReportIdentification)
    )]
    [JsonDerivedType(
        typeof(References79Choice.SecuritiesFinancingConfirmationIdentification),
        nameof(References79Choice.SecuritiesFinancingConfirmationIdentification)
    )]
    [JsonDerivedType(
        typeof(References79Choice.SecuritiesTransactionPendingReportIdentification),
        nameof(References79Choice.SecuritiesTransactionPendingReportIdentification)
    )]
    [JsonDerivedType(
        typeof(References79Choice.SecuritiesTransactionPostingReportIdentification),
        nameof(References79Choice.SecuritiesTransactionPostingReportIdentification)
    )]
    [JsonDerivedType(
        typeof(References79Choice.SecuritiesSettlementTransactionAllegementReportIdentification),
        nameof(References79Choice.SecuritiesSettlementTransactionAllegementReportIdentification)
    )]
    [JsonDerivedType(
        typeof(References79Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification),
        nameof(
            References79Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification
        )
    )]
    [JsonDerivedType(
        typeof(References79Choice.PortfolioTransferNotificationIdentification),
        nameof(References79Choice.PortfolioTransferNotificationIdentification)
    )]
    [JsonDerivedType(
        typeof(References79Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification),
        nameof(
            References79Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification
        )
    )]
    [JsonDerivedType(
        typeof(References79Choice.OtherMessageIdentification),
        nameof(References79Choice.OtherMessageIdentification)
    )]
    [JsonDerivedType(
        typeof(References79Choice.TotalPortfolioValuationReportIdentification),
        nameof(References79Choice.TotalPortfolioValuationReportIdentification)
    )]
    [JsonDerivedType(
        typeof(References79Choice.TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification),
        nameof(
            References79Choice.TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification
        )
    )]
    [JsonDerivedType(
        typeof(References79Choice.TripartyCollateralStatusAdviceIdentification),
        nameof(References79Choice.TripartyCollateralStatusAdviceIdentification)
    )]
    [JsonDerivedType(
        typeof(References79Choice.TripartyCollateralAndExposureReportIdentification),
        nameof(References79Choice.TripartyCollateralAndExposureReportIdentification)
    )]
    [IsoId("_WVQM4UfGEey6Is2iMqV8fg")]
    [DisplayName("References 79 Choice")]
    public abstract record References79Choice_ { }
}
