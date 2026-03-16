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
[IsoId("_SCuDutp-Ed-ak6NoX_4Aeg_-2008577847")]
[DisplayName("Redemption Order")]
public record RedemptionOrder7
{
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SCuDu9p-Ed-ak6NoX_4Aeg_-2008577838")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_SCuDvNp-Ed-ak6NoX_4Aeg_-2008577822")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Account impacted by an investment fund order.
    /// </summary>
    [IsoId("_SCuDvdp-Ed-ak6NoX_4Aeg_-1681730235")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount21 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_SCuDvtp-Ed-ak6NoX_4Aeg_-2007656908")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<FundOrderType2> OrderType { get; init; } = [];

    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("_SCuDv9p-Ed-ak6NoX_4Aeg_-2007657382")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public IndividualPerson12? BeneficiaryDetails { get; init; }

    /// <summary>
    /// Quantity of investment fund units redeemed.
    /// </summary>
    [IsoId("_SC3NoNp-Ed-ak6NoX_4Aeg_-2008577545")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; }

    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be sold, before deduction of charges, commissions, and taxes.|[Quantity * Price].
    /// </summary>
    [IsoId("_SC3Nodp-Ed-ak6NoX_4Aeg_-2008577475")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public required ActiveOrHistoricCurrencyAndAmount GrossAmount { get; init; }

    /// <summary>
    /// Amount of money to be received following redemption after deduction of charges, commissions and taxes and used to derive the quantity of investment fund units to be sold.|[(Quantity * Price) - (Charges + Commissions +Taxes)].
    /// </summary>
    [IsoId("_SC3Notp-Ed-ak6NoX_4Aeg_-2008577544")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public required ActiveOrHistoricCurrencyAndAmount NetAmount { get; init; }

    /// <summary>
    /// Portion of the investor&apos;s holdings, in a specific investment fund/ fund class, that is redeemed.
    /// </summary>
    [IsoId("_SC3No9p-Ed-ak6NoX_4Aeg_-2008577493")]
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate HoldingsRedemptionRate { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_SC3NpNp-Ed-ak6NoX_4Aeg_-2008577510")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_SC3Npdp-Ed-ak6NoX_4Aeg_-978531159")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_SC3Nptp-Ed-ak6NoX_4Aeg_-978530775")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("_SC3Np9p-Ed-ak6NoX_4Aeg_914252023")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_SC3NqNp-Ed-ak6NoX_4Aeg_-2007657263")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_SC3Nqdp-Ed-ak6NoX_4Aeg_-2008577450")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_SDA-oNp-Ed-ak6NoX_4Aeg_-2008577433")]
    [DisplayName("Group 1 Or 2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; }

    /// <summary>
    /// Charge for the placement of an order.
    /// </summary>
    [IsoId("_SDA-odp-Ed-ak6NoX_4Aeg_-2007657365")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge17> ChargeDetails { get; init; } = [];

    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_SDA-otp-Ed-ak6NoX_4Aeg_-2007656838")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission10> CommissionDetails { get; init; } = [];

    /// <summary>
    /// Tax applicable to an investment fund order.
    /// </summary>
    [IsoId("_SDA-o9p-Ed-ak6NoX_4Aeg_1145028926")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public ValueList<Tax16> TaxDetails { get; init; } = [];

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_SDA-pNp-Ed-ak6NoX_4Aeg_-2007657280")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_SDA-pdp-Ed-ak6NoX_4Aeg_-2008577415")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    [IsoId("_SDA-ptp-Ed-ak6NoX_4Aeg_-2007657228")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_SDA-p9p-Ed-ak6NoX_4Aeg_-2007656873")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction21? CashSettlementDetails { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_SDA-qNp-Ed-ak6NoX_4Aeg_-2007657426")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    [IsoId("_SDA-qdp-Ed-ak6NoX_4Aeg_-731123089")]
    [DisplayName("Staff Client Breakdown")]
    [IsoXmlTag("StffClntBrkdwn")]
    [MinLength(0)]
    [MaxLength(4)]
    public ValueList<InvestmentFundsOrderBreakdown1> StaffClientBreakdown { get; init; } = [];

    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("_SDKvoNp-Ed-ak6NoX_4Aeg_1291260610")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("_SDKvodp-Ed-ak6NoX_4Aeg_-598053836")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_SDKvotp-Ed-ak6NoX_4Aeg_-2007657151")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary8> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("_SDKvo9p-Ed-ak6NoX_4Aeg_1279178598")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }
}
