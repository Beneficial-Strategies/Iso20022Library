// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Subscription leg of a switch order.
/// </summary>
[IsoId("696a1285-d3fc-427d-be05-073e778482f8")]
[DisplayName("Switch Subscription Leg Order7")]
public record SwitchSubscriptionLegOrder7
{
    /// <summary>
    /// Unique technical identifier for the instance of the leg within a switch.
    /// </summary>
    [IsoId("696a1285-lgid-0001-0001-073e778482f8")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    public IsoMax35Text? LegIdentification { get; init; }

    /// <summary>
    /// Investment fund class related to the subscription leg of the order.
    /// </summary>
    [IsoId("696a1285-fiin-0001-0002-073e778482f8")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument107 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Amount of money, number of units or percentage for the redemption leg of the switch order.
    /// </summary>
    [IsoId("696a1285-fiqc-0001-0003-073e778482f8")]
    [DisplayName("Financial Instrument Quantity Choice")]
    [IsoXmlTag("FinInstrmQtyChc")]
    public FinancialInstrumentQuantity51Choice_? FinancialInstrumentQuantityChoice_ { get; init; }

    /// <summary>
    /// Account impacted by the investment fund order.
    /// </summary>
    [IsoId("696a1285-invs-0001-0004-073e778482f8")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount81? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("696a1285-incp-0001-0005-073e778482f8")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("696a1285-rqsc-0001-0006-073e778482f8")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("696a1285-rqnc-0001-0007-073e778482f8")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Fees (charges/commission) and tax to be applied to the net amount.
    /// </summary>
    [IsoId("696a1285-txov-0001-0008-073e778482f8")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public FeeAndTax2? TransactionOverhead { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("696a1285-stcd-0001-0009-073e778482f8")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters22? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("696a1285-phyd-0001-0010-073e778482f8")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    [IsoId("696a1285-phdd-0001-0011-073e778482f8")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public NameAndAddress4? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Total quantity of digital asset to be paid or received in exchange for the securities token.
    /// </summary>
    [IsoId("696a1285-dgts-0001-0012-073e778482f8")]
    [DisplayName("Digital Asset Settlement")]
    [IsoXmlTag("DgtlAsstSttlm")]
    public DigitalPaymentSettlement3? DigitalAssetSettlement { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("696a1285-nsts-0001-0013-073e778482f8")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Part of an investor's subscription amount that is held by the fund in order to pay incentive/performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("696a1285-eqls-0001-0014-073e778482f8")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }
}
