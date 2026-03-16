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
[IsoId("_QelXdtp-Ed-ak6NoX_4Aeg_116968013")]
[DisplayName("Unit Price")]
public record UnitPrice15
{
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_QelXd9p-Ed-ak6NoX_4Aeg_116968049")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice9Code Type { get; init; }

    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_QelXeNp-Ed-ak6NoX_4Aeg_-1035184327")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; }

    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_QeuhYNp-Ed-ak6NoX_4Aeg_116968125")]
    [DisplayName("Price Method")]
    [IsoXmlTag("PricMtd")]
    public PriceMethod1Code? PriceMethod { get; init; }

    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_QeuhYdp-Ed-ak6NoX_4Aeg_116968420")]
    [DisplayName("Value In Investment Currency")]
    [IsoXmlTag("ValInInvstmtCcy")]
    public ValueList<PriceValue1> ValueInInvestmentCurrency { get; init; } = [];

    // ID for the above is _QeuhYdp-Ed-ak6NoX_4Aeg_116968420

    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_QeuhYtp-Ed-ak6NoX_4Aeg_116968480")]
    [DisplayName("Value In Alternative Currency")]
    [IsoXmlTag("ValInAltrntvCcy")]
    public ValueList<PriceValue1> ValueInAlternativeCurrency { get; init; } = [];

    /// <summary>
    /// Indicates whether the price information can be used for the execution of a transaction.
    /// </summary>
    [IsoId("_QeuhY9p-Ed-ak6NoX_4Aeg_116968557")]
    [DisplayName("For Execution Indicator")]
    [IsoXmlTag("ForExctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ForExecutionIndicator { get; init; }

    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_QeuhZNp-Ed-ak6NoX_4Aeg_116968883")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    /// <summary>
    /// Ratio applied on the non-adjusted price.
    /// </summary>
    [IsoId("_QeuhZdp-Ed-ak6NoX_4Aeg_116968944")]
    [DisplayName("Calculation Basis")]
    [IsoXmlTag("ClctnBsis")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? CalculationBasis { get; init; }

    /// <summary>
    /// Indicates whether the price is an estimated price.
    /// </summary>
    [IsoId("_QeuhZtp-Ed-ak6NoX_4Aeg_240626510")]
    [DisplayName("Estimated Price Indicator")]
    [IsoXmlTag("EstmtdPricInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator EstimatedPriceIndicator { get; init; }

    /// <summary>
    /// Specifies the number of days from trade date that the counterparty on the other side of the trade should &quot;given up&quot; or divulged.
    /// </summary>
    [IsoId("_QeuhZ9p-Ed-ak6NoX_4Aeg_116969021")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_QeuhaNp-Ed-ak6NoX_4Aeg_116969074")]
    [DisplayName("Taxable Income Per Share")]
    [IsoXmlTag("TaxblIncmPerShr")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; }

    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_Qeuhadp-Ed-ak6NoX_4Aeg_116969376")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; init; }

    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_Qe4SYNp-Ed-ak6NoX_4Aeg_911625097")]
    [DisplayName("Extended Taxable Income Per Share Calculated")]
    [IsoXmlTag("XtndedTaxblIncmPerShrClctd")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedTaxableIncomePerShareCalculated { get; init; }

    /// <summary>
    /// Amount included in the dividend that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_Qe4SYdp-Ed-ak6NoX_4Aeg_-450781721")]
    [DisplayName("Taxable Income Per Dividend")]
    [IsoXmlTag("TaxblIncmPerDvdd")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? TaxableIncomePerDividend { get; init; }

    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_Qe4SYtp-Ed-ak6NoX_4Aeg_-107228916")]
    [DisplayName("EU Dividend Status")]
    [IsoXmlTag("EUDvddSts")]
    public EUDividendStatus1Code? EUDividendStatus { get; init; }

    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_Qe4SY9p-Ed-ak6NoX_4Aeg_1319885059")]
    [DisplayName("Extended EU Dividend Status")]
    [IsoXmlTag("XtndedEUDvddSts")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedEUDividendStatus { get; init; }

    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    [IsoId("_Qe4SZNp-Ed-ak6NoX_4Aeg_116969935")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge15> ChargeDetails { get; init; } = [];

    /// <summary>
    /// Information related to taxes that are due.
    /// </summary>
    [IsoId("_Qe4SZdp-Ed-ak6NoX_4Aeg_1606728234")]
    [DisplayName("Tax Liability Details")]
    [IsoXmlTag("TaxLbltyDtls")]
    public ValueList<Tax17> TaxLiabilityDetails { get; init; } = [];

    /// <summary>
    /// Information related to taxes that are paid back.
    /// </summary>
    [IsoId("_Qe4SZtp-Ed-ak6NoX_4Aeg_1615962093")]
    [DisplayName("Tax Refund Details")]
    [IsoXmlTag("TaxRfndDtls")]
    public ValueList<Tax17> TaxRefundDetails { get; init; } = [];
}
