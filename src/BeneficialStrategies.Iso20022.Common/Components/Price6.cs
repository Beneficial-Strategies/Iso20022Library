// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the value, type and source of price.
/// </summary>
[IsoId("_E_XYoaB6EeOEyO7fCl8lLA")]
[DisplayName("Price")]
public record Price6
{
    /// <summary>
    /// Value of the price expressed as a currency and value or as a rate.
    /// </summary>
    [IsoId("_PsBIkKB6EeOEyO7fCl8lLA")]
    [DisplayName("Rate Or Amount")]
    [IsoXmlTag("RateOrAmt")]
    public required PriceRateOrAmountChoice_ RateOrAmount { get; init; }

    /// <summary>
    /// Specification of the price type.
    /// </summary>
    [IsoId("_VrjpIKB6EeOEyO7fCl8lLA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice13Code Type { get; init; }

    /// <summary>
    /// Source for the price valuation.
    /// </summary>
    [IsoId("_ctv5gKB6EeOEyO7fCl8lLA")]
    [DisplayName("Source")]
    [IsoXmlTag("Src")]
    public required PriceSource2Code Source { get; init; }
}
