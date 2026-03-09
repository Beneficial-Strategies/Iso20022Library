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
    [KnownType(typeof(References71Choice.SecuritiesSettlementTransactionConfirmationIdentification))]
    [KnownType(typeof(References71Choice.IntraPositionMovementConfirmationIdentification))]
    [KnownType(typeof(References71Choice.SecuritiesBalanceAccountingReportIdentification))]
    [KnownType(typeof(References71Choice.SecuritiesBalanceCustodyReportIdentification))]
    [KnownType(typeof(References71Choice.IntraPositionMovementPostingReportIdentification))]
    [KnownType(typeof(References71Choice.SecuritiesFinancingConfirmationIdentification))]
    [KnownType(typeof(References71Choice.SecuritiesTransactionPendingReportIdentification))]
    [KnownType(typeof(References71Choice.SecuritiesTransactionPostingReportIdentification))]
    [KnownType(typeof(References71Choice.SecuritiesSettlementTransactionAllegementReportIdentification))]
    [KnownType(typeof(References71Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification))]
    [KnownType(typeof(References71Choice.PortfolioTransferNotificationIdentification))]
    [KnownType(typeof(References71Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification))]
    [KnownType(typeof(References71Choice.OtherMessageIdentification))]
    [KnownType(typeof(References71Choice.TotalPortfolioValuationReportIdentification))]
    [KnownType(typeof(References71Choice.TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification))]
    [KnownType(typeof(References71Choice.TripartyCollateralStatusAdviceIdentification))]
    [KnownType(typeof(References71Choice.TripartyCollateralAndExposureReportIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References71Choice.SecuritiesSettlementTransactionConfirmationIdentification),nameof(References71Choice.SecuritiesSettlementTransactionConfirmationIdentification))]
    [JsonDerivedType(typeof(References71Choice.IntraPositionMovementConfirmationIdentification),nameof(References71Choice.IntraPositionMovementConfirmationIdentification))]
    [JsonDerivedType(typeof(References71Choice.SecuritiesBalanceAccountingReportIdentification),nameof(References71Choice.SecuritiesBalanceAccountingReportIdentification))]
    [JsonDerivedType(typeof(References71Choice.SecuritiesBalanceCustodyReportIdentification),nameof(References71Choice.SecuritiesBalanceCustodyReportIdentification))]
    [JsonDerivedType(typeof(References71Choice.IntraPositionMovementPostingReportIdentification),nameof(References71Choice.IntraPositionMovementPostingReportIdentification))]
    [JsonDerivedType(typeof(References71Choice.SecuritiesFinancingConfirmationIdentification),nameof(References71Choice.SecuritiesFinancingConfirmationIdentification))]
    [JsonDerivedType(typeof(References71Choice.SecuritiesTransactionPendingReportIdentification),nameof(References71Choice.SecuritiesTransactionPendingReportIdentification))]
    [JsonDerivedType(typeof(References71Choice.SecuritiesTransactionPostingReportIdentification),nameof(References71Choice.SecuritiesTransactionPostingReportIdentification))]
    [JsonDerivedType(typeof(References71Choice.SecuritiesSettlementTransactionAllegementReportIdentification),nameof(References71Choice.SecuritiesSettlementTransactionAllegementReportIdentification))]
    [JsonDerivedType(typeof(References71Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification),nameof(References71Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification))]
    [JsonDerivedType(typeof(References71Choice.PortfolioTransferNotificationIdentification),nameof(References71Choice.PortfolioTransferNotificationIdentification))]
    [JsonDerivedType(typeof(References71Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification),nameof(References71Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification))]
    [JsonDerivedType(typeof(References71Choice.OtherMessageIdentification),nameof(References71Choice.OtherMessageIdentification))]
    [JsonDerivedType(typeof(References71Choice.TotalPortfolioValuationReportIdentification),nameof(References71Choice.TotalPortfolioValuationReportIdentification))]
    [JsonDerivedType(typeof(References71Choice.TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification),nameof(References71Choice.TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification))]
    [JsonDerivedType(typeof(References71Choice.TripartyCollateralStatusAdviceIdentification),nameof(References71Choice.TripartyCollateralStatusAdviceIdentification))]
    [JsonDerivedType(typeof(References71Choice.TripartyCollateralAndExposureReportIdentification),nameof(References71Choice.TripartyCollateralAndExposureReportIdentification))]
    #endif
    [IsoId("_KDxvryAaEeu4a6pNulzZ4Q")]
    [DisplayName("References 71 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References71Choice_
    #else
    public abstract partial class References71Choice_
    #endif
    {
    }
}
