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
[IsoId("_S9DdASeQEeOXAt_43VmZGw")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate47
{
    /// <summary>
    /// Rate proposed in a remarketing of variable rate notes.
    /// </summary>
    [IsoId("_TUa0ISeQEeOXAt_43VmZGw")]
    [DisplayName("Proposed Rate")]
    [IsoXmlTag("PropsdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ProposedRate { get; init; }

    /// <summary>
    /// Rate of allowed over-subscription.
    /// </summary>
    [IsoId("_TUa0KSeQEeOXAt_43VmZGw")]
    [DisplayName("Oversubscription Rate")]
    [IsoXmlTag("OvrsbcptRate")]
    public RateAndAmountFormat5Choice_? OversubscriptionRate { get; init; }

    /// <summary>
    /// Requested tax rate in case of breakdown of tax rate, for example, used for adjustment of tax rate. This is the new requested applicable rate.
    /// </summary>
    [IsoId("_TUa0MSeQEeOXAt_43VmZGw")]
    [DisplayName("Requested Taxation Rate")]
    [IsoXmlTag("ReqdTaxtnRate")]
    public ValueList<RateAndAmountFormat21Choice_> RequestedTaxationRate { get; init; } = [];

    /// <summary>
    /// Requested rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_bZ3RQieQEeOXAt_43VmZGw")]
    [DisplayName("Requested Withholding Of Foreign Tax")]
    [IsoXmlTag("ReqdWhldgOfFrgnTax")]
    public ValueList<RateAndAmountFormat21Choice_> RequestedWithholdingOfForeignTax { get; init; } =
        [];

    /// <summary>
    /// Requested rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_bZ3RQyeQEeOXAt_43VmZGw")]
    [DisplayName("Requested Withholding Of Local Tax")]
    [IsoXmlTag("ReqdWhldgOfLclTax")]
    public ValueList<RateAndAmountFormat21Choice_> RequestedWithholdingOfLocalTax { get; init; } =
        [];
}
