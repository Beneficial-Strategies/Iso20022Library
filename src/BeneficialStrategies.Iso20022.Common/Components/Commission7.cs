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
[IsoId("_VPdsitp-Ed-ak6NoX_4Aeg_-1738143487")]
[DisplayName("Commission")]
public record Commission7
{
    /// <summary>
    /// Commission expressed as an amount of money.
    /// </summary>
    [IsoId("_VPm2cNp-Ed-ak6NoX_4Aeg_-1738143452")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Commission expressed as a percentage.
    /// </summary>
    [IsoId("_VPm2cdp-Ed-ak6NoX_4Aeg_-1738143410")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; }

    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_VPm2ctp-Ed-ak6NoX_4Aeg_-1738143469")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CommissionType1 Type { get; init; }
}
