// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_1FBhMWp7EemmaZLSPtWX5A")]
[DisplayName("Price")]
public record Price8
{
    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_1RIqkWp7EemmaZLSPtWX5A")]
    [DisplayName("Value Type")]
    [IsoXmlTag("ValTp")]
    public PriceValueType3Code? ValueType { get; init; }

    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_1RIqn2p7EemmaZLSPtWX5A")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmount3Choice_ Value { get; init; }

    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_1RIqrWp7EemmaZLSPtWX5A")]
    [DisplayName("Price Type")]
    [IsoXmlTag("PricTp")]
    public TypeOfPrice1Code? PriceType { get; init; }
}
