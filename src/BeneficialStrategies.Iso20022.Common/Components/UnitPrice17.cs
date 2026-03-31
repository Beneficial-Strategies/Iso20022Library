// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_WL9J-dp-Ed-ak6NoX_4Aeg_-680211431")]
[DisplayName("Unit Price")]
public record UnitPrice17
{
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_WL9J-tp-Ed-ak6NoX_4Aeg_-680211401")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice15Code Type { get; init; }

    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_WL9J-9p-Ed-ak6NoX_4Aeg_-680211309")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceValue6 Value { get; init; }

    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_WL9J_Np-Ed-ak6NoX_4Aeg_-680211164")]
    [DisplayName("Taxable Income Per Share")]
    [IsoXmlTag("TaxblIncmPerShr")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; }

    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_WL9J_dp-Ed-ak6NoX_4Aeg_-680210885")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; init; }
}
