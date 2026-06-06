// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Redemption leg of a switch order.
/// </summary>
[IsoId("fc3f78a9-f91e-4880-a8ee-df34d88caf54")]
[DisplayName("Switch Redemption Leg Order7")]
public record SwitchRedemptionLegOrder7
{
    /// <summary>
    /// Unique technical identifier for the instance of the leg within a switch.
    /// </summary>
    [IsoId("fc3f78a9-lgid-0001-0001-df34d88caf54")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    public IsoMax35Text? LegIdentification { get; init; }

    /// <summary>
    /// Investment fund class related to the redemption leg of the order.
    /// </summary>
    [IsoId("fc3f78a9-fiin-0001-0002-df34d88caf54")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument107 FinancialInstrumentDetails { get; init; }

    [IsoId("fc3f78a9-fiqc-0001-0003-df34d88caf54")]
    [DisplayName("Financial Instrument Quantity Choice")]
    [IsoXmlTag("FinInstrmQtyChc")]
    public FinancialInstrumentQuantity50Choice_? FinancialInstrumentQuantityChoice_ { get; init; }

    /// <summary>
    /// Account impacted by the investment fund order.
    /// </summary>
    [IsoId("fc3f78a9-invs-0001-0004-df34d88caf54")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount81? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("fc3f78a9-incp-0001-0005-df34d88caf54")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("fc3f78a9-grp1-0001-0006-df34d88caf54")]
    [DisplayName("Group1 Or2 Units")]
    [IsoXmlTag("Grp1Or2Unts")]
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("fc3f78a9-rqsc-0001-0007-df34d88caf54")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("fc3f78a9-rqnc-0001-0008-df34d88caf54")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Fees (charges/commission) and tax to be applied to the gross amount.
    /// </summary>
    [IsoId("fc3f78a9-txov-0001-0009-df34d88caf54")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public FeeAndTax2? TransactionOverhead { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("fc3f78a9-stcd-0001-0010-df34d88caf54")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters28? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("fc3f78a9-phyd-0001-0011-df34d88caf54")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    [IsoId("fc3f78a9-phdd-0001-0012-df34d88caf54")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Total quantity of digital asset to be paid or received in exchange for the securities token.
    /// </summary>
    [IsoId("fc3f78a9-dgts-0001-0013-df34d88caf54")]
    [DisplayName("Digital Asset Settlement")]
    [IsoXmlTag("DgtlAsstSttlm")]
    public DigitalPaymentSettlement3? DigitalAssetSettlement { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("fc3f78a9-nsts-0001-0014-df34d88caf54")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Part of an investor's retained subscription amount that is returned by the fund in order to reimburse preliminary incentive/performance fees.
    /// </summary>
    [IsoId("fc3f78a9-eqls-0001-0015-df34d88caf54")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }
}
