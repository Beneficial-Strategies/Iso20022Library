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
[IsoId("_Vck7c9p-Ed-ak6NoX_4Aeg_-984991905")]
[DisplayName("Redemption Order")]
public record RedemptionOrder3
{
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Vck7dNp-Ed-ak6NoX_4Aeg_-984991870")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_Vck7ddp-Ed-ak6NoX_4Aeg_-984989500")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public FundOrderType1? OrderType { get; init; }

    /// <summary>
    /// Account impacted by an investment fund order.
    /// </summary>
    [IsoId("_Vck7dtp-Ed-ak6NoX_4Aeg_-984989421")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("_Vck7d9p-Ed-ak6NoX_4Aeg_-1826065942")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public IndividualPerson2? BeneficiaryDetails { get; init; }

    /// <summary>
    /// Quantity of investment fund units redeemed.
    /// </summary>
    [IsoId("_Vck7eNp-Ed-ak6NoX_4Aeg_-984989889")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; }

    /// <summary>
    /// Net amount of money used to derive the quantity of investment fund units to be sold.
    /// </summary>
    [IsoId("_Vck7edp-Ed-ak6NoX_4Aeg_-984989794")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public required ActiveOrHistoricCurrencyAndAmount NetAmount { get; init; }

    /// <summary>
    /// Portion of the investor&apos;s holdings, in a specific investment fund/ fund class, that is redeemed.
    /// </summary>
    [IsoId("_Vck7etp-Ed-ak6NoX_4Aeg_-984989854")]
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate HoldingsRedemptionRate { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_VcuFYNp-Ed-ak6NoX_4Aeg_1486363053")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be sold, including all charges, commissions, and tax.
    /// </summary>
    [IsoId("_VcuFYdp-Ed-ak6NoX_4Aeg_-984989769")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_VcuFYtp-Ed-ak6NoX_4Aeg_1056533246")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms5? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_VcuFY9p-Ed-ak6NoX_4Aeg_-984989752")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_VcuFZNp-Ed-ak6NoX_4Aeg_-984989517")]
    [DisplayName("Group 1 Or 2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; }

    /// <summary>
    /// Charge for the placement of an order.
    /// </summary>
    [IsoId("_VcuFZdp-Ed-ak6NoX_4Aeg_-984989017")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public Charge8? ChargeDetails { get; init; }

    /// <summary>
    /// Commission linked to the execution of an investment fund order.
    /// </summary>
    [IsoId("_VcuFZtp-Ed-ak6NoX_4Aeg_-984989052")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public Commission6? CommissionDetails { get; init; }

    /// <summary>
    /// Tax applicable to an investment fund order.
    /// </summary>
    [IsoId("_VcuFZ9p-Ed-ak6NoX_4Aeg_-984989438")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public Tax6? TaxDetails { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_VcuFaNp-Ed-ak6NoX_4Aeg_-984989379")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_VcuFadp-Ed-ak6NoX_4Aeg_-984989482")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    [IsoId("_Vc32YNp-Ed-ak6NoX_4Aeg_-984989070")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_Vc32Ydp-Ed-ak6NoX_4Aeg_2055848687")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction18? CashSettlementDetails { get; init; }
}
