// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to qualify the interest rate.
/// </summary>
[IsoId("_SR69Udp-Ed-ak6NoX_4Aeg_-59286801")]
[DisplayName("Rate")]
public record Rate3
{
    /// <summary>
    /// Specifies the type of interest rate.
    /// </summary>
    [IsoId("_SR69Utp-Ed-ak6NoX_4Aeg_-59286460")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required RateType4Choice_ Type { get; init; }

    /// <summary>
    /// An amount range where the interest rate is applicable.
    /// </summary>
    [IsoId("_SR69U9p-Ed-ak6NoX_4Aeg_-59286399")]
    [DisplayName("Validity Range")]
    [IsoXmlTag("VldtyRg")]
    public CurrencyAndAmountRange2? ValidityRange { get; init; }
}
