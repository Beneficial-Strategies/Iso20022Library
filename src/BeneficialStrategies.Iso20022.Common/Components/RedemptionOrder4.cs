// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction from an investor to sell investment fund units back to the fund.
/// </summary>
[IsoId("_VdBAW9p-Ed-ak6NoX_4Aeg_77313367")]
[DisplayName("Redemption Order")]
public record RedemptionOrder4
{
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_VdKxUNp-Ed-ak6NoX_4Aeg_77313376")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_VdKxUdp-Ed-ak6NoX_4Aeg_77313548")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public ValueList<FundOrderType1> OrderType { get; init; } = [];

    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    [IsoId("_VdKxUtp-Ed-ak6NoX_4Aeg_77313801")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument6 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Quantity of investment fund units redeemed.
    /// </summary>
    [IsoId("_VdKxU9p-Ed-ak6NoX_4Aeg_77313410")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; }

    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be sold.
    /// </summary>
    [IsoId("_VdKxVNp-Ed-ak6NoX_4Aeg_77313411")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public required ActiveOrHistoricCurrencyAndAmount NetAmount { get; init; }

    /// <summary>
    /// Portion of the investor&apos;s holdings, in a specific investment fund/ fund class, that is redeemed.
    /// </summary>
    [IsoId("_VdKxVdp-Ed-ak6NoX_4Aeg_77313453")]
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate HoldingsRedemptionRate { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_VdKxVtp-Ed-ak6NoX_4Aeg_-1252128766")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be sold, including all charges, commissions, and tax.
    /// </summary>
    [IsoId("_VdKxV9p-Ed-ak6NoX_4Aeg_77313428")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_VdKxWNp-Ed-ak6NoX_4Aeg_223517708")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms5? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_VdKxWdp-Ed-ak6NoX_4Aeg_77313505")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_VdUiUNp-Ed-ak6NoX_4Aeg_77313523")]
    [DisplayName("Group 1 Or 2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; }

    /// <summary>
    /// Charge for the placement of an order.
    /// </summary>
    [IsoId("_VdUiUdp-Ed-ak6NoX_4Aeg_77313956")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge8> ChargeDetails { get; init; } = [];

    /// <summary>
    /// Commission linked to the execution of an investment fund order.
    /// </summary>
    [IsoId("_VdUiUtp-Ed-ak6NoX_4Aeg_77313938")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission6> CommissionDetails { get; init; } = [];

    /// <summary>
    /// Tax applicable to an investment fund order.
    /// </summary>
    [IsoId("_VdUiU9p-Ed-ak6NoX_4Aeg_77313843")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public ValueList<Tax6> TaxDetails { get; init; } = [];

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_VdUiVNp-Ed-ak6NoX_4Aeg_77313861")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_VdUiVdp-Ed-ak6NoX_4Aeg_77313565")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    [IsoId("_VdUiVtp-Ed-ak6NoX_4Aeg_77313903")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_VdUiV9p-Ed-ak6NoX_4Aeg_77313470")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public CurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_VdUiWNp-Ed-ak6NoX_4Aeg_77313488")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public CurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VdUiWdp-Ed-ak6NoX_4Aeg_77314265")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction15? CashSettlementDetails { get; init; }
}
