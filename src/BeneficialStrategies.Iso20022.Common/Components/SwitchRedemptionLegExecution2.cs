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
[IsoId("_VWBAgtp-Ed-ak6NoX_4Aeg_-733728591")]
[DisplayName("Switch Redemption Leg Execution")]
public record SwitchRedemptionLegExecution2
{
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [IsoId("_VWBAg9p-Ed-ak6NoX_4Aeg_-733727652")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegIdentification { get; init; }

    /// <summary>
    /// Unique identifier for an instance of a leg execution within a switch confirmation.
    /// </summary>
    [IsoId("_VWKxcNp-Ed-ak6NoX_4Aeg_-733727635")]
    [DisplayName("Leg Execution Identification")]
    [IsoXmlTag("LegExctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegExecutionIdentification { get; init; }

    /// <summary>
    /// Investment fund class to which an investment fund order execution is related.
    /// </summary>
    [IsoId("_VWKxcdp-Ed-ak6NoX_4Aeg_-732807532")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument6 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Number of investment funds units redeemed.
    /// </summary>
    [IsoId("_VWKxctp-Ed-ak6NoX_4Aeg_-733728565")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; }

    /// <summary>
    /// Portion of the investor&apos;s holdings, in a specific investment fund/ fund class, that is redeemed.
    /// </summary>
    [IsoId("_VWKxc9p-Ed-ak6NoX_4Aeg_-733728265")]
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; }

    /// <summary>
    /// Net amount of money paid to the investor as a result of the redemption.
    /// </summary>
    [IsoId("_VWKxdNp-Ed-ak6NoX_4Aeg_-733728548")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public required ActiveCurrencyAndAmount NetAmount { get; init; }

    /// <summary>
    /// Gross amount of money as a result of the redemption.
    /// </summary>
    [IsoId("_VWKxddp-Ed-ak6NoX_4Aeg_-733728531")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_VWKxdtp-Ed-ak6NoX_4Aeg_-733728170")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("_VWKxd9p-Ed-ak6NoX_4Aeg_-733727616")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public required UnitPrice5 PriceDetails { get; init; }

    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_VWKxeNp-Ed-ak6NoX_4Aeg_-733728144")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    [IsoId("_VWKxedp-Ed-ak6NoX_4Aeg_-733727695")]
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss1Choice_? InterimProfitAmount { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_VWT7YNp-Ed-ak6NoX_4Aeg_-733728007")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_VWT7Ydp-Ed-ak6NoX_4Aeg_-733727737")]
    [DisplayName("Group 1 Or 2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_VWT7Ytp-Ed-ak6NoX_4Aeg_932528977")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public CurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_VWT7Y9p-Ed-ak6NoX_4Aeg_932529072")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public CurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Charge for the execution of an order.
    /// </summary>
    [IsoId("_VWT7ZNp-Ed-ak6NoX_4Aeg_-732807585")]
    [DisplayName("Charge General Details")]
    [IsoXmlTag("ChrgGnlDtls")]
    public TotalCharges2? ChargeGeneralDetails { get; init; }

    /// <summary>
    /// Commission for the execution of an investment fund order.
    /// </summary>
    [IsoId("_VWT7Zdp-Ed-ak6NoX_4Aeg_-732807550")]
    [DisplayName("Commission General Details")]
    [IsoXmlTag("ComssnGnlDtls")]
    public TotalCommissions2? CommissionGeneralDetails { get; init; }

    /// <summary>
    /// Tax applicable to execution of an investment fund order.
    /// </summary>
    [IsoId("_VWT7Ztp-Ed-ak6NoX_4Aeg_-732807602")]
    [DisplayName("Tax General Details")]
    [IsoXmlTag("TaxGnlDtls")]
    public TotalTaxes2? TaxGeneralDetails { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_VWT7Z9p-Ed-ak6NoX_4Aeg_-732807431")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters4? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_VWT7aNp-Ed-ak6NoX_4Aeg_-733727677")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    [IsoId("_VWT7adp-Ed-ak6NoX_4Aeg_-732807471")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }
}
