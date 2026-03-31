// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates related to a corporate action option.
/// </summary>
[IsoId("_cheNB5KQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate73
{
    /// <summary>
    /// Rate proposed in a remarketing of variable rate notes.
    /// </summary>
    [IsoId("_cheNCZKQEeWHWpTQn1FFVg")]
    [DisplayName("Proposed Rate")]
    [IsoXmlTag("PropsdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ProposedRate { get; init; }

    /// <summary>
    /// Rate of allowed over-subscription.
    /// </summary>
    [IsoId("_cheNEZKQEeWHWpTQn1FFVg")]
    [DisplayName("Oversubscription Rate")]
    [IsoXmlTag("OvrsbcptRate")]
    public RateAndAmountFormat43Choice_? OversubscriptionRate { get; init; }

    /// <summary>
    /// Requested tax rate that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_cheNGZKQEeWHWpTQn1FFVg")]
    [DisplayName("Requested Withholding Tax Rate")]
    [IsoXmlTag("ReqdWhldgTaxRate")]
    public ValueList<RateAndAmountFormat45Choice_> RequestedWithholdingTaxRate { get; init; } = [];

    /// <summary>
    /// Requested rate at which the income will be withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_cheNIZKQEeWHWpTQn1FFVg")]
    [DisplayName("Requested Second Level Tax Rate")]
    [IsoXmlTag("ReqdScndLvlTaxRate")]
    public ValueList<RateAndAmountFormat45Choice_> RequestedSecondLevelTaxRate { get; init; } = [];
}
