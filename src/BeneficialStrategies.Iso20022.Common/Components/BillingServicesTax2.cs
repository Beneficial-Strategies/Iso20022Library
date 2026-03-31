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
[IsoId("_6RcRcJqlEeGSON8vddiWzQ_-480249725")]
[DisplayName("Billing Services Tax")]
public record BillingServicesTax2
{
    /// <summary>
    /// Identification number of the specific region tax used to calculate the tax.
    /// </summary>
    [IsoId("_6RcRcZqlEeGSON8vddiWzQ_-1477322078")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Number { get; init; }

    /// <summary>
    /// Name used to describe the tax (such as the national value added tax).
    /// </summary>
    [IsoId("_6RcRcpqlEeGSON8vddiWzQ_1706733799")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40, MinimumLength = 1)]
    public IsoMax40Text? Description { get; init; }

    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_6RcRc5qlEeGSON8vddiWzQ_-173571841")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Rate { get; init; }

    /// <summary>
    /// Amount of the tax obligation expressed in the tax region&apos;s pricing currency.
    /// </summary>
    [IsoId("_6RcRdJqlEeGSON8vddiWzQ_126308982")]
    [DisplayName("Pricing Amount")]
    [IsoXmlTag("PricgAmt")]
    public required AmountAndDirection34 PricingAmount { get; init; }
}
