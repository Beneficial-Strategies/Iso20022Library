// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to a party as compensation for a service.
/// </summary>
[IsoId("_Rr6tQtp-Ed-ak6NoX_4Aeg_1803280729")]
[DisplayName("Commission")]
public record Commission9
{
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_Rr6tQ9p-Ed-ak6NoX_4Aeg_1803281144")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CommissionType6Code Type { get; init; }

    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_Rr6tRNp-Ed-ak6NoX_4Aeg_1154241590")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; }

    /// <summary>
    /// Commission expressed as an amount of money.
    /// </summary>
    [IsoId("_Rr6tRdp-Ed-ak6NoX_4Aeg_1804201271")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Commission expressed as a percentage.
    /// </summary>
    [IsoId("_Rr6tRtp-Ed-ak6NoX_4Aeg_1804201348")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; }
}
