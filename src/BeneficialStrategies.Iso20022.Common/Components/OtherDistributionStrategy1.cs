// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other distribution strategy.
/// </summary>
[IsoId("_q5CaAD8PEeih8-WNbS6hbA")]
[DisplayName("Other Distribution Strategy")]
public record OtherDistributionStrategy1
{
    /// <summary>
    /// Type of distribution strategy.
    /// </summary>
    [IsoId("_TfymMj8QEeih8-WNbS6hbA")]
    [DisplayName("Distribution Strategy Type")]
    [IsoXmlTag("DstrbtnStrtgyTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DistributionStrategyType { get; init; }

    /// <summary>
    /// Choice of formats for the specification of whether the product is aimed at the type of return profile.
    /// </summary>
    [IsoId("_TfymMz8QEeih8-WNbS6hbA")]
    [DisplayName("Target")]
    [IsoXmlTag("Trgt")]
    public DistributionStrategy1Choice_? Target { get; init; }

    /// <summary>
    /// Additional information about the target market and the investor&apos;s risk tolerance.
    /// </summary>
    [IsoId("_l4QyUT8QEeih8-WNbS6hbA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
