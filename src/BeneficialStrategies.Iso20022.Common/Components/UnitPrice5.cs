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
[IsoId("_U4glF9p-Ed-ak6NoX_4Aeg_1893016197")]
[DisplayName("Unit Price")]
public record UnitPrice5
{
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_U4glGNp-Ed-ak6NoX_4Aeg_1893016199")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required PriceType1 Type { get; init; }

    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_U4qWENp-Ed-ak6NoX_4Aeg_1893016232")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceValue1 Value { get; init; }

    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_U4qWEdp-Ed-ak6NoX_4Aeg_1893016474")]
    [DisplayName("Price Method")]
    [IsoXmlTag("PricMtd")]
    public PriceMethod1Code? PriceMethod { get; init; }

    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_U4qWEtp-Ed-ak6NoX_4Aeg_2008456077")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_U4qWE9p-Ed-ak6NoX_4Aeg_2008456102")]
    [DisplayName("Taxable Income Per Share")]
    [IsoXmlTag("TaxblIncmPerShr")]
    public AmountPrice1Choice_? TaxableIncomePerShare { get; init; }

    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_U4qWFNp-Ed-ak6NoX_4Aeg_1650193655")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculated1? TaxableIncomePerShareCalculated { get; init; }
}
