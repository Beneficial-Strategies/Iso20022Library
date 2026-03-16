// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of the redemption part, in a switch between investment funds or investment fund classes.
/// </summary>
[IsoId("_ASu3KzbtEead9bDRE_1DAQ")]
[DisplayName("Switch Redemption Leg Execution")]
public record SwitchRedemptionLegExecution4
{
    /// <summary>
    /// Unique technical identifier for the instance of the leg within a switch.
    /// </summary>
    [IsoId("_Arbq9TbtEead9bDRE_1DAQ")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegIdentification { get; init; }

    /// <summary>
    /// Unique identifier for the instance of the leg execution within a switch confirmation.
    /// </summary>
    [IsoId("_Arbq9zbtEead9bDRE_1DAQ")]
    [DisplayName("Leg Execution Identification")]
    [IsoXmlTag("LegExctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegExecutionIdentification { get; init; }

    /// <summary>
    /// Investment fund class to which the redemption leg of the investment fund order execution is related.
    /// </summary>
    [IsoId("_Arbq-TbtEead9bDRE_1DAQ")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument57 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Number of investment funds units redeemed.
    /// </summary>
    [IsoId("_Arbq-zbtEead9bDRE_1DAQ")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber UnitsNumber { get; init; }

    /// <summary>
    /// Portion of the investor&apos;s holdings redeemed.
    /// </summary>
    [IsoId("_Arbq_zbtEead9bDRE_1DAQ")]
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; }

    /// <summary>
    /// Amount of money paid to the investor when redeeming fund units.
    /// Net amount = (Quantity * Price) – (Fees + Taxes).
    /// </summary>
    [IsoId("_ArbrATbtEead9bDRE_1DAQ")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Amount of money redeemed from the fund.
    /// Gross Amount = Quantity * Price.
    /// </summary>
    [IsoId("_ArbrAzbtEead9bDRE_1DAQ")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; }

    /// <summary>
    /// Account impacted by the investment fund order execution.
    /// </summary>
    [IsoId("_Arbq_TbtEead9bDRE_1DAQ")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount58? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_ArbrBTbtEead9bDRE_1DAQ")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("_ArbrBzbtEead9bDRE_1DAQ")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public required UnitPrice22 PriceDetails { get; init; }

    /// <summary>
    /// Other quoted price than the one at which the order was executed.
    /// </summary>
    [IsoId("_INsAYTxcEea9KZ_pBxG-rQ")]
    [DisplayName("Informative Price Details")]
    [IsoXmlTag("InftvPricDtls")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<UnitPrice22> InformativePriceDetails { get; init; } = [];

    /// <summary>
    /// Indicates whether the dividend is included, that is, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_ArbrCTbtEead9bDRE_1DAQ")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    [IsoId("_ArbrCzbtEead9bDRE_1DAQ")]
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss2Choice_? InterimProfitAmount { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_ArbrDTbtEead9bDRE_1DAQ")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_ArbrDzbtEead9bDRE_1DAQ")]
    [DisplayName("Group 1 Or 2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_ArbrETbtEead9bDRE_1DAQ")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_ArbrEzbtEead9bDRE_1DAQ")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Fees (charges/commission) and taxes that are taken into consideration for the transaction, so that the total difference between the net amount and gross amount is known, without taking into account equalisation.
    /// </summary>
    [IsoId("_Z46xcjk6EeapUO0vUIo9Xw")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public TotalFeesAndTaxes40? TransactionOverhead { get; init; }

    /// <summary>
    /// Additional information about tax that does not have an impact on the transaction overhead.
    /// </summary>
    [IsoId("_Z46xczk6EeapUO0vUIo9Xw")]
    [DisplayName("Informative Tax Details")]
    [IsoXmlTag("InftvTaxDtls")]
    public InformativeTax1? InformativeTaxDetails { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_ArbrGzbtEead9bDRE_1DAQ")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters11? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_ArbrHTbtEead9bDRE_1DAQ")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    [IsoId("_ArbrHzbtEead9bDRE_1DAQ")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_ArbrITbtEead9bDRE_1DAQ")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Part of an investor&apos;s subscription amount that was held by the fund in order to pay incentive/performance fees at the end of the fiscal year, and is returned due to the redemption.
    /// </summary>
    [IsoId("_ArbrIzbtEead9bDRE_1DAQ")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }

    /// <summary>
    /// Information about gating and hold back of redemption proceeds.
    /// </summary>
    [IsoId("_J5po0UgWEea9YuSvQGoi-w")]
    [DisplayName("Gating Or Hold Back Details")]
    [IsoXmlTag("GtgOrHldBckDtls")]
    public HoldBackInformation2? GatingOrHoldBackDetails { get; init; }
}
