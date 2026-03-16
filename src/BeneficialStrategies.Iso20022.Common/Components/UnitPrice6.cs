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
[IsoId("_U4qWFdp-Ed-ak6NoX_4Aeg_-44720744")]
[DisplayName("Unit Price")]
public record UnitPrice6
{
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_U4qWFtp-Ed-ak6NoX_4Aeg_-44720725")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required PriceType2 Type { get; init; }

    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_U4qWF9p-Ed-ak6NoX_4Aeg_-44720701")]
    [DisplayName("Price Method")]
    [IsoXmlTag("PricMtd")]
    public PriceMethod1Code? PriceMethod { get; init; }

    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_U4qWGNp-Ed-ak6NoX_4Aeg_-44720684")]
    [DisplayName("Value In Investment Currency")]
    [IsoXmlTag("ValInInvstmtCcy")]
    public ValueList<PriceValue1> ValueInInvestmentCurrency { get; init; } = [];

    // ID for the above is _U4qWGNp-Ed-ak6NoX_4Aeg_-44720684

    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_U4qWGdp-Ed-ak6NoX_4Aeg_-44720418")]
    [DisplayName("Value In Alternative Currency")]
    [IsoXmlTag("ValInAltrntvCcy")]
    public PriceValue1? ValueInAlternativeCurrency { get; init; }

    /// <summary>
    /// Indicates whether the price information can be used for the execution of a transaction.
    /// </summary>
    [IsoId("_U40HENp-Ed-ak6NoX_4Aeg_-44720393")]
    [DisplayName("For Execution Indicator")]
    [IsoXmlTag("ForExctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ForExecutionIndicator { get; init; }

    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_U40HEdp-Ed-ak6NoX_4Aeg_-44720358")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    /// <summary>
    /// Ratio applied on the non-adjusted price.
    /// </summary>
    [IsoId("_U40HEtp-Ed-ak6NoX_4Aeg_-144399643")]
    [DisplayName("Calculation Basis")]
    [IsoXmlTag("ClctnBsis")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? CalculationBasis { get; init; }

    /// <summary>
    /// Specifies the number of days from trade date that the counterparty on the other side of the trade should &quot;given up&quot; or divulged.
    /// </summary>
    [IsoId("_U40HE9p-Ed-ak6NoX_4Aeg_-168219132")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_U40HFNp-Ed-ak6NoX_4Aeg_-168218824")]
    [DisplayName("Taxable Income Per Share")]
    [IsoXmlTag("TaxblIncmPerShr")]
    public AmountPrice1Choice_? TaxableIncomePerShare { get; init; }

    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_U40HFdp-Ed-ak6NoX_4Aeg_-514208777")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculated1? TaxableIncomePerShareCalculated { get; init; }

    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    [IsoId("_U40HFtp-Ed-ak6NoX_4Aeg_-44720322")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public Charge9? ChargeDetails { get; init; }

    /// <summary>
    /// Information related to taxes that are due.
    /// </summary>
    [IsoId("_U40HF9p-Ed-ak6NoX_4Aeg_-44720297")]
    [DisplayName("Tax Liability Details")]
    [IsoXmlTag("TaxLbltyDtls")]
    public Tax8? TaxLiabilityDetails { get; init; }

    /// <summary>
    /// Information related to taxes that are paid back.
    /// </summary>
    [IsoId("_U40HGNp-Ed-ak6NoX_4Aeg_-626866032")]
    [DisplayName("Tax Refund Details")]
    [IsoXmlTag("TaxRfndDtls")]
    public Tax8? TaxRefundDetails { get; init; }
}
