// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for regional taxes on the service.
/// </summary>
[IsoId("_6RSgdJqlEeGSON8vddiWzQ_-1349987745")]
[DisplayName("Billing Services Tax")]
public record BillingServicesTax1
{
    /// <summary>
    /// Identification number of the specific region tax used to calculate the tax.
    /// </summary>
    [IsoId("_6RSgdZqlEeGSON8vddiWzQ_150555380")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Number { get; init; }

    /// <summary>
    /// Name used to describe the tax (such as the national value added tax).
    /// </summary>
    [IsoId("_6RSgdpqlEeGSON8vddiWzQ_-837346944")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40, MinimumLength = 1)]
    public IsoMax40Text? Description { get; init; }

    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_6RSgd5qlEeGSON8vddiWzQ_972377869")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Rate { get; init; }

    /// <summary>
    /// Amount of the tax obligation expressed in the tax region&apos;s host currency.
    /// </summary>
    [IsoId("_6RSgeJqlEeGSON8vddiWzQ_-1171869073")]
    [DisplayName("Host Amount")]
    [IsoXmlTag("HstAmt")]
    public required AmountAndDirection34 HostAmount { get; init; }

    /// <summary>
    /// Amount of the tax obligation expressed in the tax region&apos;s pricing currency.
    /// </summary>
    [IsoId("_6RSgeZqlEeGSON8vddiWzQ_1947907198")]
    [DisplayName("Pricing Amount")]
    [IsoXmlTag("PricgAmt")]
    public AmountAndDirection34? PricingAmount { get; init; }
}
