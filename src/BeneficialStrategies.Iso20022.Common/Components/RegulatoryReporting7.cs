// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Includes data elements that can be used for reporting to trade repositories.
/// Usage: It is not to be used on regular trade confirmations. Although some fields, for example, unique transaction identifier and prior unique transaction identifier, might be used on regular trade confirmations.
/// </summary>
[IsoId("_VB4PMQNwEe2-vqzwMUAewg")]
[DisplayName("Regulatory Reporting")]
public partial record RegulatoryReporting7
{
    #nullable enable
    
    /// <summary>
    /// Regulatory transaction reporting information from the Trading Side party.
    /// </summary>
    [IsoId("_VHDDEQNwEe2-vqzwMUAewg")]
    [DisplayName("Trading Side Transaction Reporting")]
    [IsoXmlTag("TradgSdTxRptg")]
    public TradingSideTransactionReporting2? TradingSideTransactionReporting { get; init; } 
    
    /// <summary>
    /// Regulatory transaction reporting information from the Counterparty Side party.
    /// </summary>
    [IsoId("_VHDDEwNwEe2-vqzwMUAewg")]
    [DisplayName("Counterparty Side Transaction Reporting")]
    [IsoXmlTag("CtrPtySdTxRptg")]
    public CounterpartySideTransactionReporting2? CounterpartySideTransactionReporting { get; init; } 
    
    /// <summary>
    /// Identifies an agency or separate corporation of a futures exchange responsible for settling and
    /// clearing trades, collecting and maintaining margins, regulating delivery and reporting trade data. This can also be known as a Central Counterparty (CCP).
    /// </summary>
    [IsoId("_VHDDFQNwEe2-vqzwMUAewg")]
    [DisplayName("Central Counterparty Clearing House")]
    [IsoXmlTag("CntrlCtrPtyClrHs")]
    public PartyIdentification242Choice_? CentralCounterpartyClearingHouse { get; init; } 
    
    /// <summary>
    /// Identifies the party that is a member of the clearing house and that acts as a liaison between the investor and the Central Counterparty (CCP).
    /// </summary>
    [IsoId("_VHDDFwNwEe2-vqzwMUAewg")]
    [DisplayName("Clearing Broker")]
    [IsoXmlTag("ClrBrkr")]
    public PartyIdentification242Choice_? ClearingBroker { get; init; } 
    
    /// <summary>
    /// Identifies the party that is exempt from a clearing obligation.
    /// </summary>
    [IsoId("_VHDDGQNwEe2-vqzwMUAewg")]
    [DisplayName("Clearing Exception Party")]
    [IsoXmlTag("ClrXcptnPty")]
    public PartyIdentification242Choice_? ClearingExceptionParty { get; init; } 
    
    /// <summary>
    /// Specifies the reference number assigned by the clearing broker. A distinction can be made between the reference for the Central Counterparty (CCP) leg and the reference for the client leg of the transaction.
    /// </summary>
    [IsoId("_VHDDGwNwEe2-vqzwMUAewg")]
    [DisplayName("Clearing Broker Identification")]
    [IsoXmlTag("ClrBrkrId")]
    public ClearingBrokerIdentification1? ClearingBrokerIdentification { get; init; } 
    
    /// <summary>
    /// Specifies whether the contract is above or below the clearing threshold. Where No indicates the contract is below the clearing threshold and Yes indicates the contract is above the clearing threshold.
    /// </summary>
    [IsoId("_VHDDHQNwEe2-vqzwMUAewg")]
    [DisplayName("Clearing Threshold Indicator")]
    [IsoXmlTag("ClrThrshldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ClearingThresholdIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the reference number assigned by the Central Counterparty (CCP).
    /// </summary>
    [IsoId("_VHDDHwNwEe2-vqzwMUAewg")]
    [DisplayName("Cleared Product Identification")]
    [IsoXmlTag("ClrdPdctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClearedProductIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the underlying product type.
    /// </summary>
    [IsoId("_VHDDIQNwEe2-vqzwMUAewg")]
    [DisplayName("Underlying Product Identifier")]
    [IsoXmlTag("UndrlygPdctIdr")]
    public UnderlyingProductIdentifier1Code? UnderlyingProductIdentifier { get; init; } 
    
    /// <summary>
    /// Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated.
    /// </summary>
    [IsoId("_VHDDIwNwEe2-vqzwMUAewg")]
    [DisplayName("Allocation Indicator")]
    [IsoXmlTag("AllcnInd")]
    public AllocationIndicator1Code? AllocationIndicator { get; init; } 
    
    /// <summary>
    /// Specifies whether the transaction is collateralised.
    /// </summary>
    [IsoId("_VHDDJQNwEe2-vqzwMUAewg")]
    [DisplayName("Collateralisation Indicator")]
    [IsoXmlTag("CollstnInd")]
    public CollateralisationIndicator1Code? CollateralisationIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the trading venue of the transaction.
    /// </summary>
    [IsoId("_VHDDJwNwEe2-vqzwMUAewg")]
    [DisplayName("Execution Venue")]
    [IsoXmlTag("ExctnVn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ExecutionVenue { get; init; } 
    
    /// <summary>
    /// Specifies the date and time of the execution of the transaction in Coordinated Universal Time (UTC).
    /// </summary>
    [IsoId("_VHDDKQNwEe2-vqzwMUAewg")]
    [DisplayName("Execution Timestamp")]
    [IsoXmlTag("ExctnTmstmp")]
    public DateAndDateTime2Choice_? ExecutionTimestamp { get; init; } 
    
    /// <summary>
    /// Specifies whether the reportable transaction has one or more additional terms or provisions, other than those listed in the required real-time data fields, that materially affects the price of the reportable transaction.
    /// </summary>
    [IsoId("_VHDDKwNwEe2-vqzwMUAewg")]
    [DisplayName("Non Standard Flag")]
    [IsoXmlTag("NonStdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NonStandardFlag { get; init; } 
    
    /// <summary>
    /// Specifies the common reference or correlation identification for a swap transaction where the near and far leg are confirmed separately.
    /// </summary>
    [IsoId("_VHDDLQNwEe2-vqzwMUAewg")]
    [DisplayName("Link Swap Identification")]
    [IsoXmlTag("LkSwpId")]
    [IsoSimpleType(IsoSimpleType.Exact42Text)]
    public IsoExact42Text? LinkSwapIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the financial nature of the reporting counterparty.
    /// </summary>
    [IsoId("_VHDDLwNwEe2-vqzwMUAewg")]
    [DisplayName("Financial Nature Of The Counterparty Indicator")]
    [IsoXmlTag("FinNtrOfTheCtrPtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? FinancialNatureOfTheCounterpartyIndicator { get; init; } 
    
    /// <summary>
    /// Specifies if the collateral is posted on a portfolio basis.
    /// </summary>
    [IsoId("_VHDDMQNwEe2-vqzwMUAewg")]
    [DisplayName("Collateral Portfolio Indicator")]
    [IsoXmlTag("CollPrtflInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CollateralPortfolioIndicator { get; init; } 
    
    /// <summary>
    /// Identifies the portfolio code to which the trade belongs if the collateral is posted on a portfolio basis (and not trade by trade).
    /// </summary>
    [IsoId("_VHDDMwNwEe2-vqzwMUAewg")]
    [DisplayName("Collateral Portfolio Code")]
    [IsoXmlTag("CollPrtflCd")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    public IsoMax10Text? CollateralPortfolioCode { get; init; } 
    
    /// <summary>
    /// Indicates if the trade results from portfolio compression.
    /// </summary>
    [IsoId("_VHDDNQNwEe2-vqzwMUAewg")]
    [DisplayName("Portfolio Compression Indicator")]
    [IsoXmlTag("PrtflCmprssnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PortfolioCompressionIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the corporate sector of the counterparty.
    /// </summary>
    [IsoId("_VHDDNwNwEe2-vqzwMUAewg")]
    [DisplayName("Corporate Sector Indicator")]
    [IsoXmlTag("CorpSctrInd")]
    public CorporateSectorIdentifier1Code? CorporateSectorIndicator { get; init; } 
    
    /// <summary>
    /// Specifies whether the counterparty has entered into a trade with a non-European Economic Area (EEA) counterparty that is not subject to the reporting obligation.
    /// </summary>
    [IsoId("_VHDDOQNwEe2-vqzwMUAewg")]
    [DisplayName("Trade With Non EEA Counterparty Indicator")]
    [IsoXmlTag("TradWthNonEEACtrPtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TradeWithNonEEACounterpartyIndicator { get; init; } 
    
    /// <summary>
    /// Indicate if a reported trade falls under the definition of intragroup transaction, as defined by European Securities and Markets Authority (ESMA) in the Technical Standards.
    /// </summary>
    [IsoId("_VHDDOwNwEe2-vqzwMUAewg")]
    [DisplayName("Intragroup Trade Indicator")]
    [IsoXmlTag("NtrgrpTradInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? IntragroupTradeIndicator { get; init; } 
    
    /// <summary>
    /// Specifies whether the contract is objectively measurable as directly linked to the non-financial counterparty&apos;s commercial or treasury financing activity.
    /// </summary>
    [IsoId("_VHDDPQNwEe2-vqzwMUAewg")]
    [DisplayName("Commercial Or Treasury Financing Indicator")]
    [IsoXmlTag("ComrclOrTrsrFincgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CommercialOrTreasuryFinancingIndicator { get; init; } 
    
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_VHDDPwNwEe2-vqzwMUAewg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the date and time of the confirmation of the trade in Universal Time Coordinated (UTC).
    /// </summary>
    [IsoId("_VHDDQQNwEe2-vqzwMUAewg")]
    [DisplayName("Confirmation Date And Timestamp")]
    [IsoXmlTag("ConfDtAndTmstmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ConfirmationDateAndTimestamp { get; init; } 
    
    /// <summary>
    /// Specifies the time at which the Central Counterparty (CCP) has legally taken on the clearing of the trade in Universal Time Coordinated (UTC).
    /// </summary>
    [IsoId("_VHDDQwNwEe2-vqzwMUAewg")]
    [DisplayName("Clearing Timestamp")]
    [IsoXmlTag("ClrTmstmp")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? ClearingTimestamp { get; init; } 
    
    /// <summary>
    /// Provides the commission and fee type anf amout or rate.
    /// </summary>
    [IsoId("_vk2-oANwEe2-vqzwMUAewg")]
    [DisplayName("Commissions And Fees")]
    [IsoXmlTag("ComssnsAndFees")]
    public FXCommissionOrFee1? CommissionsAndFees { get; init; } 
    
    /// <summary>
    /// Specifies additional information that might be required by the regulator.
    /// </summary>
    [IsoId("_VHDDRQNwEe2-vqzwMUAewg")]
    [DisplayName("Additional Reporting Information")]
    [IsoXmlTag("AddtlRptgInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? AdditionalReportingInformation { get; init; } 
    
    
    #nullable disable
    
}
