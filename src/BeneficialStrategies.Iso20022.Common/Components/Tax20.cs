// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax related to an investment fund order.
/// </summary>
[IsoId("_WKLBSNp-Ed-ak6NoX_4Aeg_-2019251269")]
[DisplayName("Tax")]
public record Tax20
{
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_WKLBSdp-Ed-ak6NoX_4Aeg_-2019251238")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType14Code Type { get; init; }

    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_WKLBStp-Ed-ak6NoX_4Aeg_-2019250906")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("_WKLBS9p-Ed-ak6NoX_4Aeg_-1006152759")]
    [DisplayName("Exemption Indicator")]
    [IsoXmlTag("XmptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExemptionIndicator { get; init; }
}
