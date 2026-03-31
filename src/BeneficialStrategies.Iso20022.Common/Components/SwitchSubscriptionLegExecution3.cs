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
[IsoId("_SKUggNp-Ed-ak6NoX_4Aeg_-815364317")]
[DisplayName("Switch Subscription Leg Execution")]
public record SwitchSubscriptionLegExecution3
{
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [IsoId("_SKUggdp-Ed-ak6NoX_4Aeg_-815364292")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegIdentification { get; init; }

    /// <summary>
    /// Unique identifier for an instance of a leg execution within a switch confirmation.
    /// </summary>
    [IsoId("_SKUggtp-Ed-ak6NoX_4Aeg_-815364275")]
    [DisplayName("Leg Execution Identification")]
    [IsoXmlTag("LegExctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegExecutionIdentification { get; init; }

    /// <summary>
    /// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
    /// </summary>
    [IsoId("_SKUgg9p-Ed-ak6NoX_4Aeg_-815361500")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument10 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Number of investment fund units subscribed.
    /// </summary>
    [IsoId("_SKUghNp-Ed-ak6NoX_4Aeg_-815364257")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; }

    /// <summary>
    /// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_SKUghdp-Ed-ak6NoX_4Aeg_-933349169")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount21? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Amount of money invested in a specific financial instrument by an investor, after deduction of charges, commissions and taxes.|[Quantity * Price].
    /// </summary>
    [IsoId("_SKUghtp-Ed-ak6NoX_4Aeg_-815364232")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Amount of money invested in a specific financial instrument by an investor, before deduction of charges, commissions, and taxes.|[(Quantity * Price) + (Charges + Commissions +Taxes)].
    /// </summary>
    [IsoId("_SKUgh9p-Ed-ak6NoX_4Aeg_-815364215")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_SKdqcNp-Ed-ak6NoX_4Aeg_-815363853")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("_SKdqcdp-Ed-ak6NoX_4Aeg_-815361735")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public required UnitPrice10 PriceDetails { get; init; }

    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_SKdqctp-Ed-ak6NoX_4Aeg_-815363828")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    [IsoId("_SKdqc9p-Ed-ak6NoX_4Aeg_-815363811")]
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss1Choice_? InterimProfitAmount { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_SKdqdNp-Ed-ak6NoX_4Aeg_-815363793")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_SKdqddp-Ed-ak6NoX_4Aeg_-815363768")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_SKdqdtp-Ed-ak6NoX_4Aeg_-815363733")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Charge for the execution of an order.
    /// </summary>
    [IsoId("_SKdqd9p-Ed-ak6NoX_4Aeg_52970258")]
    [DisplayName("Charge General Details")]
    [IsoXmlTag("ChrgGnlDtls")]
    public TotalCharges3? ChargeGeneralDetails { get; init; }

    /// <summary>
    /// Commission for the execution of an investment fund order.
    /// </summary>
    [IsoId("_SKdqeNp-Ed-ak6NoX_4Aeg_-11138940")]
    [DisplayName("Commission General Details")]
    [IsoXmlTag("ComssnGnlDtls")]
    public TotalCommissions3? CommissionGeneralDetails { get; init; }

    /// <summary>
    /// Tax applicable to execution of an investment fund order.
    /// </summary>
    [IsoId("_SKdqedp-Ed-ak6NoX_4Aeg_-815362010")]
    [DisplayName("Tax General Details")]
    [IsoXmlTag("TaxGnlDtls")]
    public TotalTaxes3? TaxGeneralDetails { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_SKnbcNp-Ed-ak6NoX_4Aeg_-815362311")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_SKnbcdp-Ed-ak6NoX_4Aeg_-815362786")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    [IsoId("_SKnbctp-Ed-ak6NoX_4Aeg_-815362293")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_SKnbc9p-Ed-ak6NoX_4Aeg_29539493")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("_SKnbdNp-Ed-ak6NoX_4Aeg_996758302")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }
}
