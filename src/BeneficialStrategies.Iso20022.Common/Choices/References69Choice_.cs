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
    [KnownType(typeof(References69Choice.SecuritiesSettlementTransactionConfirmationIdentification))]
    [KnownType(typeof(References69Choice.IntraPositionMovementConfirmationIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesBalanceAccountingReportIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesBalanceCustodyReportIdentification))]
    [KnownType(typeof(References69Choice.IntraPositionMovementPostingReportIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesFinancingConfirmationIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesTransactionPendingReportIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesTransactionPostingReportIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesSettlementTransactionAllegementReportIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification))]
    [KnownType(typeof(References69Choice.PortfolioTransferNotificationIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification))]
    [KnownType(typeof(References69Choice.OtherMessageIdentification))]
    [KnownType(typeof(References69Choice.TotalPortfolioValuationReportIdentification))]
    [KnownType(typeof(References69Choice.TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification))]
    [KnownType(typeof(References69Choice.TripartyCollateralStatusAdviceIdentification))]
    [KnownType(typeof(References69Choice.TripartyCollateralAndExposureReportIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References69Choice.SecuritiesSettlementTransactionConfirmationIdentification),nameof(References69Choice.SecuritiesSettlementTransactionConfirmationIdentification))]
    [JsonDerivedType(typeof(References69Choice.IntraPositionMovementConfirmationIdentification),nameof(References69Choice.IntraPositionMovementConfirmationIdentification))]
    [JsonDerivedType(typeof(References69Choice.SecuritiesBalanceAccountingReportIdentification),nameof(References69Choice.SecuritiesBalanceAccountingReportIdentification))]
    [JsonDerivedType(typeof(References69Choice.SecuritiesBalanceCustodyReportIdentification),nameof(References69Choice.SecuritiesBalanceCustodyReportIdentification))]
    [JsonDerivedType(typeof(References69Choice.IntraPositionMovementPostingReportIdentification),nameof(References69Choice.IntraPositionMovementPostingReportIdentification))]
    [JsonDerivedType(typeof(References69Choice.SecuritiesFinancingConfirmationIdentification),nameof(References69Choice.SecuritiesFinancingConfirmationIdentification))]
    [JsonDerivedType(typeof(References69Choice.SecuritiesTransactionPendingReportIdentification),nameof(References69Choice.SecuritiesTransactionPendingReportIdentification))]
    [JsonDerivedType(typeof(References69Choice.SecuritiesTransactionPostingReportIdentification),nameof(References69Choice.SecuritiesTransactionPostingReportIdentification))]
    [JsonDerivedType(typeof(References69Choice.SecuritiesSettlementTransactionAllegementReportIdentification),nameof(References69Choice.SecuritiesSettlementTransactionAllegementReportIdentification))]
    [JsonDerivedType(typeof(References69Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification),nameof(References69Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification))]
    [JsonDerivedType(typeof(References69Choice.PortfolioTransferNotificationIdentification),nameof(References69Choice.PortfolioTransferNotificationIdentification))]
    [JsonDerivedType(typeof(References69Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification),nameof(References69Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification))]
    [JsonDerivedType(typeof(References69Choice.OtherMessageIdentification),nameof(References69Choice.OtherMessageIdentification))]
    [JsonDerivedType(typeof(References69Choice.TotalPortfolioValuationReportIdentification),nameof(References69Choice.TotalPortfolioValuationReportIdentification))]
    [JsonDerivedType(typeof(References69Choice.TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification),nameof(References69Choice.TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification))]
    [JsonDerivedType(typeof(References69Choice.TripartyCollateralStatusAdviceIdentification),nameof(References69Choice.TripartyCollateralStatusAdviceIdentification))]
    [JsonDerivedType(typeof(References69Choice.TripartyCollateralAndExposureReportIdentification),nameof(References69Choice.TripartyCollateralAndExposureReportIdentification))]
    #endif
    [IsoId("_zwc0sQzXEeuUZuaHWzkTew")]
    [DisplayName("References 69 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References69Choice_
    #else
    public abstract partial class References69Choice_
    #endif
    {
    }
}
