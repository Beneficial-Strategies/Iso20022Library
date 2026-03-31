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
[IsoId("_ZmYyEZJOEeuuktRxxQZoNQ")]
[DisplayName("Instalment Amount Details")]
public record InstalmentAmountDetails2
{
    /// <summary>
    /// Instalment amount detail type.
    /// </summary>
    [IsoId("_Zulr0ZJOEeuuktRxxQZoNQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public InstalmentAmountDetailsType2Code? Type { get; init; }

    /// <summary>
    /// Other instalment amount detail type.
    /// </summary>
    [IsoId("_Zulr05JOEeuuktRxxQZoNQ")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Grace period sub type.
    /// </summary>
    [IsoId("_Zulr1ZJOEeuuktRxxQZoNQ")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubType { get; init; }

    /// <summary>
    /// Detailed instalment amount.
    /// </summary>
    [IsoId("_Zulr15JOEeuuktRxxQZoNQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public Amount16? Amount { get; init; }

    /// <summary>
    /// Rate expressed as a percentage, that is, in hundredths, example, 0.7 is 7/10 of a percent, and 7.0 is 7%.
    /// </summary>
    [IsoId("_Zulr2ZJOEeuuktRxxQZoNQ")]
    [DisplayName("Percentage")]
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Percentage { get; init; }
}
