// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Change amount and rate.
/// </summary>
[IsoId("_nAOYZvNBEeCuA5Tr22BnwA_-1763287912")]
[DisplayName("Amount And Rate")]
public record AmountAndRate2
{
    /// <summary>
    /// Amount expressed as an amount of money.
    /// </summary>
    [IsoId("_nAOYZ_NBEeCuA5Tr22BnwA_-817933214")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountAndDirection30? Amount { get; init; }

    /// <summary>
    /// Amount expressed as a rate.
    /// </summary>
    [IsoId("_nAOYaPNBEeCuA5Tr22BnwA_905937363")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }
}
