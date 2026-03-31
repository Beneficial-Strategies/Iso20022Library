// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the aggregated data of settlement fails instructions.
/// </summary>
[IsoId("_afLKcR2lEeqF2P5v-Rtejg")]
[DisplayName("Settlement Fails Data")]
public record SettlementFailsData3
{
    /// <summary>
    /// Total of all types of settlement transactions.
    /// </summary>
    [IsoId("_ahZ_ER2lEeqF2P5v-Rtejg")]
    [DisplayName("Total")]
    [IsoXmlTag("Ttl")]
    public required SettlementTotalData1 Total { get; init; }

    /// <summary>
    /// Further details on the central securities depositories participants with the highest rates of settlement fails.
    /// </summary>
    [IsoId("_ahZ_Ex2lEeqF2P5v-Rtejg")]
    [DisplayName("Participant In Fail")]
    [IsoXmlTag("PtcptInFail")]
    public SettlementFailsParticipantRange1? ParticipantInFail { get; init; }

    /// <summary>
    /// Further details on the settlement fails per currency.
    /// </summary>
    [IsoId("_ahZ_FR2lEeqF2P5v-Rtejg")]
    [DisplayName("Fails Per Currency")]
    [IsoXmlTag("FlsPerCcy")]
    public ValueList<SettlementFailsCurrency2> FailsPerCurrency { get; init; } = [];

    /// <summary>
    /// Further details on the settlement fails per financial instrument type.
    /// </summary>
    [IsoId("_ahZ_Fx2lEeqF2P5v-Rtejg")]
    [DisplayName("Fails Per Financial Instrument Type")]
    [IsoXmlTag("FlsPerFinInstrmTp")]
    public SettlementFailsInstrument2? FailsPerFinancialInstrumentType { get; init; }

    /// <summary>
    /// Further details on the securities with the highest rates of settlement fails.
    /// </summary>
    [IsoId("_ahZ_GR2lEeqF2P5v-Rtejg")]
    [DisplayName("Securities In Fail")]
    [IsoXmlTag("SctiesInFail")]
    public SettlementFailsSecuritiesRange1? SecuritiesInFail { get; init; }

    /// <summary>
    /// Further details on the settlement fails per transaction type.
    /// </summary>
    [IsoId("_ahZ_Gx2lEeqF2P5v-Rtejg")]
    [DisplayName("Fails Per Transaction Type")]
    [IsoXmlTag("FlsPerTxTp")]
    public SettlementFailsTransactionType2? FailsPerTransactionType { get; init; }

    /// <summary>
    /// Total of all types of settlement penalties (such as total of late matching and settlement fails).
    /// </summary>
    [IsoId("_ahZ_HR2lEeqF2P5v-Rtejg")]
    [DisplayName("Total Settlement Penalties")]
    [IsoXmlTag("TtlSttlmPnlties")]
    public SettlementDataVolume2? TotalSettlementPenalties { get; init; }

    /// <summary>
    /// Further details on the reason for the settlement fails.
    /// </summary>
    [IsoId("_ahZ_Hx2lEeqF2P5v-Rtejg")]
    [DisplayName("Failure Reason")]
    [IsoXmlTag("FailrRsn")]
    public required SettlementFailureReason3 FailureReason { get; init; }
}
