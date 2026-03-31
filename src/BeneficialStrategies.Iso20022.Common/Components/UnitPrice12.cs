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
[IsoId("_QfCDZdp-Ed-ak6NoX_4Aeg_-338531466")]
[DisplayName("Unit Price")]
public record UnitPrice12
{
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_QfCDZtp-Ed-ak6NoX_4Aeg_-338529683")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice12Code Type { get; init; }

    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_QfCDZ9p-Ed-ak6NoX_4Aeg_664475414")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; }

    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_QfCDaNp-Ed-ak6NoX_4Aeg_-338529234")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceValue1 Value { get; init; }

    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_QfCDadp-Ed-ak6NoX_4Aeg_-338528777")]
    [DisplayName("Price Method")]
    [IsoXmlTag("PricMtd")]
    public PriceMethod1Code? PriceMethod { get; init; }

    /// <summary>
    /// Interest that has accumulated between the most recent payment of interest and the sale of the financial instrument.
    /// </summary>
    [IsoId("_QfCDatp-Ed-ak6NoX_4Aeg_-338528735")]
    [DisplayName("Accrued Interest NAV")]
    [IsoXmlTag("AcrdIntrstNAV")]
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestNAV { get; init; }

    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_QfCDa9p-Ed-ak6NoX_4Aeg_-338528225")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_QfCDbNp-Ed-ak6NoX_4Aeg_-337608159")]
    [DisplayName("Taxable Income Per Share")]
    [IsoXmlTag("TaxblIncmPerShr")]
    public ActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; }
}
