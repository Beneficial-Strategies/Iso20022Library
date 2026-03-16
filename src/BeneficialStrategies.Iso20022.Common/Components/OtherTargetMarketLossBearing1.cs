// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loss bearing target market.
/// </summary>
[IsoId("_jj99EDcQEeiIxKQErQxblg")]
[DisplayName("Other Target Market Loss Bearing")]
public record OtherTargetMarketLossBearing1
{
    /// <summary>
    /// Type of loss bearing.
    /// </summary>
    [IsoId("_pQdl0jcQEeiIxKQErQxblg")]
    [DisplayName("Ability To Bear Losses Type")]
    [IsoXmlTag("AbltyToBearLossesTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AbilityToBearLossesType { get; init; }

    /// <summary>
    /// Choice of formats for the specification of whether the product is aimed at the type of loss bearing.
    /// </summary>
    [IsoId("_pQdl0zcQEeiIxKQErQxblg")]
    [DisplayName("Target")]
    [IsoXmlTag("Trgt")]
    public TargetMarket1Choice_? Target { get; init; }

    /// <summary>
    /// Additional information about the target market and the investor&apos;s loss bearing.
    /// </summary>
    [IsoId("_fC3pEDcTEeiIxKQErQxblg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
