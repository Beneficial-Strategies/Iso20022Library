// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Margin over or under an index that determines the repurchase rate expressed as a rate or an amount.
/// </summary>
[IsoId("_Q-niYtp-Ed-ak6NoX_4Aeg_-1715964179")]
[DisplayName("Spread Rate")]
public record SpreadRate1
{
    /// <summary>
    /// Specifies the sign of the rate.
    /// </summary>
    [IsoId("_Q-niY9p-Ed-ak6NoX_4Aeg_1222158444")]
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public required IsoPlusOrMinusIndicator Sign { get; init; }

    /// <summary>
    /// Specifies if the spreadf is expressed as an amount or a rate.
    /// </summary>
    [IsoId("_Q-niZNp-Ed-ak6NoX_4Aeg_88699368")]
    [DisplayName("Rate Or Amount")]
    [IsoXmlTag("RateOrAmt")]
    public required AmountOrRate1Choice_ RateOrAmount { get; init; }
}
