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
[IsoId("a787f63f-e868-4065-ad2e-ac35bd273aa3")]
[DisplayName("Unit Price24")]
public record UnitPrice24
{
    [IsoId("_6Pw7gMXxEfCHqr1PtvL9kg")]
    [DisplayName("Price Type")]
    [IsoXmlTag("PricTp")]
    public required PriceType6Choice_ PriceType { get; init; }

    [IsoId("45d414d8-2074-4628-8275-72613b96ac30")]
    [DisplayName("Price Method")]
    [IsoXmlTag("PricMtd")]
    public PriceMethod1Code? PriceMethod { get; init; }

    [IsoId("a866a433-7c0e-4d6f-834c-833cb8b4c6a8")]
    [DisplayName("Value In Investment Currency")]
    [IsoXmlTag("ValInInvstmtCcy")]
    [MinLength(1)]
    public ValueList<PriceValue1> ValueInInvestmentCurrency { get; init; } = [];

    [IsoId("1b447b2f-5e09-4bf9-a8be-b05cd035be70")]
    [DisplayName("Value In Alternative Currency")]
    [IsoXmlTag("ValInAltrntvCcy")]
    public ValueList<PriceValue1> ValueInAlternativeCurrency { get; init; } = [];

    [IsoId("0c8cadf8-6b42-4681-b14a-f1e76b80b6bc")]
    [DisplayName("For Execution Indicator")]
    [IsoXmlTag("ForExctnInd")]
    public required IsoYesNoIndicator ForExecutionIndicator { get; init; }

    [IsoId("1939a559-a2ea-48b1-b43f-a4a90bc336b6")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    [IsoId("95c060bd-230b-4d3d-bc6f-68c7e114434c")]
    [DisplayName("Calculation Basis")]
    [IsoXmlTag("ClctnBsis")]
    public IsoPercentageRate? CalculationBasis { get; init; }

    [IsoId("2dec4b60-abf6-4848-9288-c99b374f596a")]
    [DisplayName("Estimated Price Indicator")]
    [IsoXmlTag("EstmtdPricInd")]
    public required IsoYesNoIndicator EstimatedPriceIndicator { get; init; }

    [IsoId("124b3f54-e1c6-407e-832e-36c52cc80a7f")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    public IsoNumber? NumberOfDaysAccrued { get; init; }

    [IsoId("2355114d-c331-49ad-a243-cc374dfbed02")]
    [DisplayName("Taxable Income Per Share")]
    [IsoXmlTag("TaxblIncmPerShr")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; }

    [IsoId("e9d58338-1979-4568-bb9f-20da0a06f7bc")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculated3Choice_? TaxableIncomePerShareCalculated { get; init; }

    [IsoId("ff06665e-2c26-4add-851c-1266592ea645")]
    [DisplayName("Taxable Income Per Dividend")]
    [IsoXmlTag("TaxblIncmPerDvdd")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? TaxableIncomePerDividend { get; init; }

    [IsoId("183861a3-a305-4783-99a8-4584aa8aad1a")]
    [DisplayName("EU Dividend Status")]
    [IsoXmlTag("EUDvddSts")]
    public EUDividendStatusType3Choice_? EUDividendStatus { get; init; }

    [IsoId("78b4af1c-d518-476c-ad8f-903d221edde1")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge33> ChargeDetails { get; init; } = [];

    [IsoId("d22f22f4-4d27-4d1e-83af-94a2d0b239c1")]
    [DisplayName("Tax Liability Details")]
    [IsoXmlTag("TaxLbltyDtls")]
    public ValueList<Tax43> TaxLiabilityDetails { get; init; } = [];

    [IsoId("af010d17-5a30-428a-9b50-d6a90a8471c0")]
    [DisplayName("Tax Refund Details")]
    [IsoXmlTag("TaxRfndDtls")]
    public ValueList<Tax43> TaxRefundDetails { get; init; } = [];
}
