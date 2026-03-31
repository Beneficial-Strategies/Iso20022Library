// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed statistics on reconciliation.
/// </summary>
[IsoId("_6PTLRVfcEeqZr5K1Woax-g")]
[DisplayName("Detailed Reconciliation Statistics")]
public record DetailedReconciliationStatistics2
{
    /// <summary>
    /// Detailed statistics on derivatives accepted by trade repository since the beginning of reporting.
    /// </summary>
    [IsoId("_6lXh4VfcEeqZr5K1Woax-g")]
    [DisplayName("Total Accepted")]
    [IsoXmlTag("TtlAccptd")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public required IsoMax20PositiveNumber TotalAccepted { get; init; }

    /// <summary>
    /// Detailed statistics on derivatives that are not single-sided non-EEA and are not included in to the inter trade repository reconciliation process due to lack of compliance with LEI or the UTI specifications.
    /// </summary>
    [IsoId("_6lXh41fcEeqZr5K1Woax-g")]
    [DisplayName("Total Not Submitted To Reconciliation")]
    [IsoXmlTag("TtlNotSubmittdToRcncltn")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public required IsoMax20PositiveNumber TotalNotSubmittedToReconciliation { get; init; }

    /// <summary>
    /// Detailed statistics on single-sided EEA unpaired derivatives.
    /// </summary>
    [IsoId("_6lXh5VfcEeqZr5K1Woax-g")]
    [DisplayName("Total Single Sided EEA Unpaired")]
    [IsoXmlTag("TtlSnglSddEEAUnprd")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public required IsoMax20PositiveNumber TotalSingleSidedEEAUnpaired { get; init; }

    /// <summary>
    /// Detailed statistics on single-sided EEA paired derivatives.
    /// </summary>
    [IsoId("_6lXh51fcEeqZr5K1Woax-g")]
    [DisplayName("Total Single Sided EEA Paired")]
    [IsoXmlTag("TtlSnglSddEEAPaird")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public required IsoMax20PositiveNumber TotalSingleSidedEEAPaired { get; init; }

    /// <summary>
    /// Detailed statistics on single-sided EEA matched derivatives.
    /// </summary>
    [IsoId("_6lXh6VfcEeqZr5K1Woax-g")]
    [DisplayName("Total Single Sided EEA Matched")]
    [IsoXmlTag("TtlSnglSddEEAMtchd")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public required IsoMax20PositiveNumber TotalSingleSidedEEAMatched { get; init; }

    /// <summary>
    /// Detailed statistics on dual-sided non-matched derivatives.
    /// </summary>
    [IsoId("_6lXh61fcEeqZr5K1Woax-g")]
    [DisplayName("Total Dual Sided Non Matched")]
    [IsoXmlTag("TtlDualSddNonMtchd")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public required IsoMax20PositiveNumber TotalDualSidedNonMatched { get; init; }

    /// <summary>
    /// Detailed statistics on dual-sided matched derivatives.
    /// </summary>
    [IsoId("_6lXh7VfcEeqZr5K1Woax-g")]
    [DisplayName("Total Dual Sided Matched")]
    [IsoXmlTag("TtlDualSddMtchd")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public required IsoMax20PositiveNumber TotalDualSidedMatched { get; init; }

    /// <summary>
    /// Detailed statistics on single-sided non-EEA derivatives.
    /// </summary>
    [IsoId("_6lXh71fcEeqZr5K1Woax-g")]
    [DisplayName("Total Single Sided Non EEA")]
    [IsoXmlTag("TtlSnglSddNonEEA")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public required IsoMax20PositiveNumber TotalSingleSidedNonEEA { get; init; }

    /// <summary>
    /// Identification of the most common data field considered as reason for paired non-matched derivatives.
    /// </summary>
    [IsoId("_6lXh8VfcEeqZr5K1Woax-g")]
    [DisplayName("Top Reasons For Paired Non Matched")]
    [IsoXmlTag("TopRsnsForPairdNonMtchd")]
    public SimpleValueList<IsoMax35Text> TopReasonsForPairedNonMatched { get; init; } = [];
}
