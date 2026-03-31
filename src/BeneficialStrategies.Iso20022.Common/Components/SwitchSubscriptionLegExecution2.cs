// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of the subscription part, in a switch between investment funds or investment fund classes.
/// </summary>
[IsoId("_VX86K9p-Ed-ak6NoX_4Aeg_-468679588")]
[DisplayName("Switch Subscription Leg Execution")]
public record SwitchSubscriptionLegExecution2
{
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [IsoId("_VX86LNp-Ed-ak6NoX_4Aeg_-468679398")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegIdentification { get; init; }

    /// <summary>
    /// Unique identifier for an instance of a leg execution within a switch confirmation.
    /// </summary>
    [IsoId("_VYGrINp-Ed-ak6NoX_4Aeg_-468679380")]
    [DisplayName("Leg Execution Identification")]
    [IsoXmlTag("LegExctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegExecutionIdentification { get; init; }

    /// <summary>
    /// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
    /// </summary>
    [IsoId("_VYGrIdp-Ed-ak6NoX_4Aeg_-468679025")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument6 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Number of investment fund units subscribed.
    /// </summary>
    [IsoId("_VYGrItp-Ed-ak6NoX_4Aeg_-468679569")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; }

    /// <summary>
    /// Net amount of money invested in a specific financial instrument by an investor, expressed in the currency requested by the investor.
    /// </summary>
    [IsoId("_VYGrI9p-Ed-ak6NoX_4Aeg_-468679553")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public required ActiveCurrencyAndAmount NetAmount { get; init; }

    /// <summary>
    /// Gross amount of money invested in a specific financial instrument by an investor, expressed in the currency requested by the investor.
    /// </summary>
    [IsoId("_VYGrJNp-Ed-ak6NoX_4Aeg_-468679535")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_VYGrJdp-Ed-ak6NoX_4Aeg_-468679510")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("_VYGrJtp-Ed-ak6NoX_4Aeg_-468679137")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public required UnitPrice5 PriceDetails { get; init; }

    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_VYGrJ9p-Ed-ak6NoX_4Aeg_-468679493")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    [IsoId("_VYGrKNp-Ed-ak6NoX_4Aeg_-468679450")]
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss1Choice_? InterimProfitAmount { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_VYGrKdp-Ed-ak6NoX_4Aeg_-468679475")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_VYGrKtp-Ed-ak6NoX_4Aeg_961157849")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public CurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_VYP1ENp-Ed-ak6NoX_4Aeg_961158174")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public CurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Charge for the execution of an order.
    /// </summary>
    [IsoId("_VYP1Edp-Ed-ak6NoX_4Aeg_-468679077")]
    [DisplayName("Charge General Details")]
    [IsoXmlTag("ChrgGnlDtls")]
    public TotalCharges2? ChargeGeneralDetails { get; init; }

    /// <summary>
    /// Commission for the execution of an investment fund order.
    /// </summary>
    [IsoId("_VYP1Etp-Ed-ak6NoX_4Aeg_-468679060")]
    [DisplayName("Commission General Details")]
    [IsoXmlTag("ComssnGnlDtls")]
    public TotalCommissions2? CommissionGeneralDetails { get; init; }

    /// <summary>
    /// Tax applicable to execution of an investment fund order.
    /// </summary>
    [IsoId("_VYP1E9p-Ed-ak6NoX_4Aeg_-468679120")]
    [DisplayName("Tax General Details")]
    [IsoXmlTag("TaxGnlDtls")]
    public TotalTaxes2? TaxGeneralDetails { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_VYP1FNp-Ed-ak6NoX_4Aeg_-468678965")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_VYP1Fdp-Ed-ak6NoX_4Aeg_-468679433")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    [IsoId("_VYP1Ftp-Ed-ak6NoX_4Aeg_-468678699")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }
}
