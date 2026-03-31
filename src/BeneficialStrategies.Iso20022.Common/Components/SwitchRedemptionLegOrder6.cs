// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Redemption leg, or switch-out, of a switch transaction.
/// </summary>
[IsoId("_4kpxMzbsEead9bDRE_1DAQ")]
[DisplayName("Switch Redemption Leg Order")]
public record SwitchRedemptionLegOrder6
{
    /// <summary>
    /// Unique technical identifier for the instance of the leg within a switch.
    /// </summary>
    [IsoId("_48wIBTbsEead9bDRE_1DAQ")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegIdentification { get; init; }

    /// <summary>
    /// Investment fund class related to the redemption leg of the order.
    /// </summary>
    [IsoId("_48wIBzbsEead9bDRE_1DAQ")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument57 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Amount of money, number of units or percentage for the subscription leg of the switch order.
    /// </summary>
    [IsoId("_48wICTbsEead9bDRE_1DAQ")]
    [DisplayName("Financial Instrument Quantity Choice")]
    [IsoXmlTag("FinInstrmQtyChc")]
    public FinancialInstrumentQuantity29Choice_? FinancialInstrumentQuantityChoice { get; init; }

    /// <summary>
    /// Account impacted by the investment fund order.
    /// </summary>
    [IsoId("_48wICzbsEead9bDRE_1DAQ")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount58? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_48wIDTbsEead9bDRE_1DAQ")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_48wIDzbsEead9bDRE_1DAQ")]
    [DisplayName("Group 1 Or 2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_48wIETbsEead9bDRE_1DAQ")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_48wIEzbsEead9bDRE_1DAQ")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Fees (charges/commission) and tax to be applied to the gross amount.
    /// </summary>
    [IsoId("_fBLhMTk5EeapUO0vUIo9Xw")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public FeeAndTax1? TransactionOverhead { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_48wIGzbsEead9bDRE_1DAQ")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters12? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_48wIHTbsEead9bDRE_1DAQ")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    [IsoId("_48wIHzbsEead9bDRE_1DAQ")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_48wIITbsEead9bDRE_1DAQ")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Part of an investor&apos;s retained subscription amount that is returned by the fund in order to reimburse preliminary incentive/performance fees.
    /// </summary>
    [IsoId("_48wIIzbsEead9bDRE_1DAQ")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }
}
