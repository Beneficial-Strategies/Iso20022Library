// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Related financial instrument into which the security can be converted.
/// </summary>
[IsoId("_XOn1CY-eEeaEa8S_GI1QNA")]
[DisplayName("Underlying Ratio")]
public record UnderlyingRatio2
{
    /// <summary>
    /// Number of held securities for the exercise.
    /// </summary>
    [IsoId("_XcwXgY-eEeaEa8S_GI1QNA")]
    [DisplayName("Underlying Quantity Denominator")]
    [IsoXmlTag("UndrlygQtyDnmtr")]
    public required FinancialInstrumentQuantity1Choice_ UnderlyingQuantityDenominator { get; init; }

    /// <summary>
    /// Number of related securities for the exercise.
    /// </summary>
    [IsoId("_XcwXg4-eEeaEa8S_GI1QNA")]
    [DisplayName("Underlying Quantity Numerator")]
    [IsoXmlTag("UndrlygQtyNmrtr")]
    public required FinancialInstrumentQuantity1Choice_ UnderlyingQuantityNumerator { get; init; }

    /// <summary>
    /// Related security into which the security can be converted.
    /// </summary>
    [IsoId("_XcwXhY-eEeaEa8S_GI1QNA")]
    [DisplayName("Related Financial Instrument Identification")]
    [IsoXmlTag("RltdFinInstrmId")]
    public SecurityIdentification19? RelatedFinancialInstrumentIdentification { get; init; }
}
