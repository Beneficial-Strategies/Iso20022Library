// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the interest rate
/// </summary>
[IsoId("_aygkEtuLEei2qvU6FBLZYA")]
[DisplayName("Interest Rate Details")]
public record InterestRateDetails1
{
    /// <summary>
    /// Interest rate applicable to the instalment.
    /// </summary>
    [IsoId("_aygkFNuLEei2qvU6FBLZYA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public InterestRate1Code? Type { get; init; }

    /// <summary>
    /// Other type of interest applied to the instalment, when Type is OtherNational or OtherPrivate.
    /// </summary>
    [IsoId("_aygkE9uLEei2qvU6FBLZYA")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Contains instalment period
    /// </summary>
    [IsoId("_JGuvwNuUEei2qvU6FBLZYA")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public required InstalmentPeriod1Code Period { get; init; }

    /// <summary>
    /// Rate expressed as a decimal, example, 0.7 is 7/10 and 70%.
    /// </summary>
    [IsoId("_POTyANuUEei2qvU6FBLZYA")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate Rate { get; init; }
}
