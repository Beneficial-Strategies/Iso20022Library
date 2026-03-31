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
[IsoId("_A39YNdokEeC60axPepSq7g_1995898844")]
[DisplayName("Underlying Ratio")]
public record UnderlyingRatio1
{
    /// <summary>
    /// Number of held securities for the exercise.
    /// </summary>
    [IsoId("_A39YNtokEeC60axPepSq7g_-1719900614")]
    [DisplayName("Underlying Quantity Denominator")]
    [IsoXmlTag("UndrlygQtyDnmtr")]
    public required FinancialInstrumentQuantity1Choice_ UnderlyingQuantityDenominator { get; init; }

    /// <summary>
    /// Number of related securities for the exercise.
    /// </summary>
    [IsoId("_A39YN9okEeC60axPepSq7g_1060347119")]
    [DisplayName("Underlying Quantity Numerator")]
    [IsoXmlTag("UndrlygQtyNmrtr")]
    public required FinancialInstrumentQuantity1Choice_ UnderlyingQuantityNumerator { get; init; }

    /// <summary>
    /// Related security into which the security can be converted.
    /// </summary>
    [IsoId("_A39YONokEeC60axPepSq7g_-177745809")]
    [DisplayName("Related Financial Instrument Identification")]
    [IsoXmlTag("RltdFinInstrmId")]
    public ValueList<SecurityIdentification14> RelatedFinancialInstrumentIdentification { get; init; } =
        [];
}
