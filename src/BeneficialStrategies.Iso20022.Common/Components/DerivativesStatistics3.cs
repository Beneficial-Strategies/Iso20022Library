// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass data validations.
/// </summary>
[IsoId("_NHlf5VfdEeqZr5K1Woax-g")]
[DisplayName("Derivatives Statistics")]
public record DerivativesStatistics3
{
    /// <summary>
    /// Total number of derivatives submitted by the report submitting entity for the reporting counterparty.
    /// </summary>
    [IsoId("_NeaEcVfdEeqZr5K1Woax-g")]
    [DisplayName("Total Submitted")]
    [IsoXmlTag("TtlSubmittd")]
    public required StatisticsPerActionType1 TotalSubmitted { get; init; }

    /// <summary>
    /// Total number of rejected derivatives submitted by the report submitting entity for the reporting counterparty.
    /// </summary>
    [IsoId("_NeaEc1fdEeqZr5K1Woax-g")]
    [DisplayName("Total Rejected")]
    [IsoXmlTag("TtlRjctd")]
    public required StatisticsPerActionType1 TotalRejected { get; init; }

    /// <summary>
    /// Total number of rejected derivatives submitted by the report submitting entity for the reporting counterparty which were then corrected within ten business days.
    /// </summary>
    [IsoId("_NeaEdVfdEeqZr5K1Woax-g")]
    [DisplayName("Total Corrected Rejections")]
    [IsoXmlTag("TtlCrrctdRjctns")]
    public required StatisticsPerActionType1 TotalCorrectedRejections { get; init; }

    /// <summary>
    /// Identification of the most common data field in reported derivatives that has not passed the validation rule.
    /// </summary>
    [IsoId("_NeaEd1fdEeqZr5K1Woax-g")]
    [DisplayName("Top Rejection Reasons")]
    [IsoXmlTag("TopRjctnRsns")]
    public required TopReasonsForRejections2 TopRejectionReasons { get; init; }
}
