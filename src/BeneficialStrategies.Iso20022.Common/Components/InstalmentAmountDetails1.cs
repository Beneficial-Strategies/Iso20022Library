// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instalment amount details
/// </summary>
[IsoId("_yiOENNuXEei2qvU6FBLZYA")]
[DisplayName("Instalment Amount Details")]
public record InstalmentAmountDetails1
{
    /// <summary>
    /// Grace period unit type.
    /// </summary>
    [IsoId("_yiOENtuXEei2qvU6FBLZYA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public InstalmentAmountDetailsType1Code? Type { get; init; }

    /// <summary>
    /// Grace period other unit type.
    /// </summary>
    [IsoId("_yiOEN9uXEei2qvU6FBLZYA")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Grace period sub type.
    /// </summary>
    [IsoId("_yiOENduXEei2qvU6FBLZYA")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubType { get; init; }

    /// <summary>
    /// Detailed instalment amount.
    /// </summary>
    [IsoId("_gJzQgNuZEei2qvU6FBLZYA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public Amount5? Amount { get; init; }

    /// <summary>
    /// Rate expressed as a percentage, that is, in hundredths, example, 0.7 is 7/10 of a percent, and 7.0 is 7%.
    /// </summary>
    [IsoId("_kqktANuZEei2qvU6FBLZYA")]
    [DisplayName("Percentage")]
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Percentage { get; init; }
}
