// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Includes data elements that can be used for reporting to trade repositories, it is not to be used on regular trade confirmations. Although some fields, for example, unique transaction identifier and prior unique transaction identifier, might be used on regular trade confirmations.
/// </summary>
[IsoId("_vafxwZR6Eeak6e8_Fc5fQg")]
[DisplayName("Regulatory Reporting")]
public partial record RegulatoryReporting6
{
    #nullable enable
    
    /// <summary>
    /// Regulatory transaction reporting information from the Trading Side party.
    /// </summary>
    [IsoId("_vlrHAZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Trading Side Transaction Reporting")]
    [IsoXmlTag("TradgSdTxRptg")]
    public TradingSideTransactionReporting1? TradingSideTransactionReporting { get; init; } 
    
    /// <summary>
    /// Regulatory transaction reporting information from the Counterparty Side party.
    /// </summary>
    [IsoId("_vlrHA5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Counterparty Side Transaction Reporting")]
    [IsoXmlTag("CtrPtySdTxRptg")]
    public CounterpartySideTransactionReporting1? CounterpartySideTransactionReporting { get; init; } 
    
    /// <summary>
    /// Identifies an agency or separate corporation of a futures exchange responsible for settling and
    /// clearing trades, collecting and maintaining margins, regulating delivery and reporting trade data. This can also be known as a Central Counterparty (CCP).
    /// </summary>
    [IsoId("_vlrHBZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Central Counterparty Clearing House")]
    [IsoXmlTag("CntrlCtrPtyClrHs")]
    public PartyIdentification73Choice_? CentralCounterpartyClearingHouse { get; init; } 
    
    /// <summary>
    /// Identifies the party that is a member of the clearing house (CCP) and that acts as a liaison between the investor and the Cntral Counterparty (CCP).
    /// </summary>
    [IsoId("_vlrHB5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Clearing Broker")]
    [IsoXmlTag("ClrBrkr")]
    public PartyIdentification73Choice_? ClearingBroker { get; init; } 
    
    /// <summary>
    /// Identifies the party that is exempt from a clearing obligation.
    /// </summary>
    [IsoId("_vlrHCZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Clearing Exception Party")]
    [IsoXmlTag("ClrXcptnPty")]
    public PartyIdentification73Choice_? ClearingExceptionParty { get; init; } 
    
    /// <summary>
    /// Specifies the reference number assigned by the clearing broker. A distinction can be made between the reference for the Central Counterparty (CCP) leg and the reference for the client leg of the transaction.
    /// </summary>
    [IsoId("_vlrHC5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Clearing Broker Identification")]
    [IsoXmlTag("ClrBrkrId")]
    public ClearingBrokerIdentification1? ClearingBrokerIdentification { get; init; } 
    
    /// <summary>
    /// Specifies whether the contract is above or below the clearing threshold. Where No indicates the contract is below the clearing threshold and Yes indicates the contract is above the clearing threshold.
    /// </summary>
    [IsoId("_vlrHDZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Clearing Threshold Indicator")]
    [IsoXmlTag("ClrThrshldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ClearingThresholdIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the reference number assigned by the Central Counterparty (CCP).
    /// </summary>
    [IsoId("_vlrHD5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Cleared Product Identification")]
    [IsoXmlTag("ClrdPdctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClearedProductIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the underlying product type.
    /// </summary>
    [IsoId("_vlrHEZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Underlying Product Identifier")]
    [IsoXmlTag("UndrlygPdctIdr")]
    public UnderlyingProductIdentifier1Code? UnderlyingProductIdentifier { get; init; } 
    
    /// <summary>
    /// Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated.
    /// </summary>
    [IsoId("_vlrHE5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Allocation Indicator")]
    [IsoXmlTag("AllcnInd")]
    public AllocationIndicator1Code? AllocationIndicator { get; init; } 
    
    /// <summary>
    /// Specifies whether the transaction is collateralised.
    /// </summary>
    [IsoId("_vlrHFZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Collateralisation Indicator")]
    [IsoXmlTag("CollstnInd")]
    public CollateralisationIndicator1Code? CollateralisationIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the trading venue of the transaction.
    /// </summary>
    [IsoId("_vlrHF5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Execution Venue")]
    [IsoXmlTag("ExctnVn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ExecutionVenue { get; init; } 
    
    /// <summary>
    /// Specifies the date and time of the execution of the transaction in Coordinated Universal Time (UTC).
    /// </summary>
    [IsoId("_vlrHGZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Execution Timestamp")]
    [IsoXmlTag("ExctnTmstmp")]
    public DateAndDateTimeChoice_? ExecutionTimestamp { get; init; } 
    
    /// <summary>
    /// Specifies whether the reportable transaction has one or more additional terms or provisions, other than those listed in the required real-time data fields, that materially affects the price of the reportable transaction.
    /// </summary>
    [IsoId("_vlrHG5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Non Standard Flag")]
    [IsoXmlTag("NonStdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NonStandardFlag { get; init; } 
    
    /// <summary>
    /// Specifies the common reference or correlation identification for a swap transaction where the near and far leg are confirmed separately.
    /// </summary>
    [IsoId("_vlrHHZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Link Swap Identification")]
    [IsoXmlTag("LkSwpId")]
    [IsoSimpleType(IsoSimpleType.Exact42Text)]
    public IsoExact42Text? LinkSwapIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the financial nature of the reporting counterparty.
    /// </summary>
    [IsoId("_vlrHH5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Financial Nature Of The Counterparty Indicator")]
    [IsoXmlTag("FinNtrOfTheCtrPtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? FinancialNatureOfTheCounterpartyIndicator { get; init; } 
    
    /// <summary>
    /// Specifies if the collateral is posted on a portfolio basis.
    /// </summary>
    [IsoId("_vlrHIZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Collateral Portfolio Indicator")]
    [IsoXmlTag("CollPrtflInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CollateralPortfolioIndicator { get; init; } 
    
    /// <summary>
    /// Identifies the portfolio code to which the trade belongs if the collateral is posted on a portfolio basis (and not trade by trade).
    /// </summary>
    [IsoId("_vlrHI5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Collateral Portfolio Code")]
    [IsoXmlTag("CollPrtflCd")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    public IsoMax10Text? CollateralPortfolioCode { get; init; } 
    
    /// <summary>
    /// Indicates if the trade results from portfolio compression.
    /// </summary>
    [IsoId("_vlrHJZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Portfolio Compression Indicator")]
    [IsoXmlTag("PrtflCmprssnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PortfolioCompressionIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the corporate sector of the counterparty.
    /// </summary>
    [IsoId("_vlrHJ5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Corporate Sector Indicator")]
    [IsoXmlTag("CorpSctrInd")]
    public CorporateSectorIdentifier1Code? CorporateSectorIndicator { get; init; } 
    
    /// <summary>
    /// Specifies whether the counterparty has entered into a trade with a non-European Economic Area (EEA) counterparty that is not subject to the reporting obligation.
    /// </summary>
    [IsoId("_vlrHKZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Trade With Non EEA Counterparty Indicator")]
    [IsoXmlTag("TradWthNonEEACtrPtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TradeWithNonEEACounterpartyIndicator { get; init; } 
    
    /// <summary>
    /// To indicate if a reported trade falls under the definition of intragroup transaction, as defined by European Securities and Markets Authority (ESMA) in the Technical Standards.
    /// </summary>
    [IsoId("_vlrHK5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Intragroup Trade Indicator")]
    [IsoXmlTag("NtrgrpTradInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? IntragroupTradeIndicator { get; init; } 
    
    /// <summary>
    /// Specifies whether the contract is objectively measurable as directly linked to the non-financial counterparty&apos;s commercial or treasury financing activity.
    /// </summary>
    [IsoId("_vlrHLZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Commercial Or Treasury Financing Indicator")]
    [IsoXmlTag("ComrclOrTrsrFincgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CommercialOrTreasuryFinancingIndicator { get; init; } 
    
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_DF-d4ZR7Eeak6e8_Fc5fQg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the date and time of the confirmation of the trade in UTC.
    /// </summary>
    [IsoId("_kyLvAJUZEea7vKctaoIyEQ")]
    [DisplayName("Confirmation Date And Timestamp")]
    [IsoXmlTag("ConfDtAndTmstmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ConfirmationDateAndTimestamp { get; init; } 
    
    /// <summary>
    /// Specifies the time at which the CCP has legally taken on the clearing of the trade in UTC.
    /// </summary>
    [IsoId("_s3QYsJUZEea7vKctaoIyEQ")]
    [DisplayName("Clearing Timestamp")]
    [IsoXmlTag("ClrTmstmp")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? ClearingTimestamp { get; init; } 
    
    /// <summary>
    /// Specifies additional information that might be required by the regulator.
    /// </summary>
    [IsoId("_vlrHL5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Additional Reporting Information")]
    [IsoXmlTag("AddtlRptgInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? AdditionalReportingInformation { get; init; } 
    
    
    #nullable disable
    
}
