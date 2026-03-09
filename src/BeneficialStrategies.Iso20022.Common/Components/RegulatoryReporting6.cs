// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Includes data elements that can be used for reporting to trade repositories, it is not to be used on regular trade confirmations. Although some fields, for example, unique transaction identifier and prior unique transaction identifier, might be used on regular trade confirmations.
/// </summary>
[IsoId("_vafxwZR6Eeak6e8_Fc5fQg")]
[DisplayName("Regulatory Reporting")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegulatoryReporting6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Regulatory transaction reporting information from the Trading Side party.
    /// </summary>
    [IsoId("_vlrHAZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Trading Side Transaction Reporting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdTxRptg")]
    #endif
    [IsoXmlTag("TradgSdTxRptg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradingSideTransactionReporting1? TradingSideTransactionReporting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingSideTransactionReporting1? TradingSideTransactionReporting { get; init; } 
    #else
    public TradingSideTransactionReporting1? TradingSideTransactionReporting { get; set; } 
    #endif
    
    /// <summary>
    /// Regulatory transaction reporting information from the Counterparty Side party.
    /// </summary>
    [IsoId("_vlrHA5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Counterparty Side Transaction Reporting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySdTxRptg")]
    #endif
    [IsoXmlTag("CtrPtySdTxRptg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CounterpartySideTransactionReporting1? CounterpartySideTransactionReporting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartySideTransactionReporting1? CounterpartySideTransactionReporting { get; init; } 
    #else
    public CounterpartySideTransactionReporting1? CounterpartySideTransactionReporting { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies an agency or separate corporation of a futures exchange responsible for settling and
    /// clearing trades, collecting and maintaining margins, regulating delivery and reporting trade data. This can also be known as a Central Counterparty (CCP).
    /// </summary>
    [IsoId("_vlrHBZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Central Counterparty Clearing House")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CntrlCtrPtyClrHs")]
    #endif
    [IsoXmlTag("CntrlCtrPtyClrHs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification73Choice_? CentralCounterpartyClearingHouse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification73Choice_? CentralCounterpartyClearingHouse { get; init; } 
    #else
    public PartyIdentification73Choice_? CentralCounterpartyClearingHouse { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party that is a member of the clearing house (CCP) and that acts as a liaison between the investor and the Cntral Counterparty (CCP).
    /// </summary>
    [IsoId("_vlrHB5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Clearing Broker")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrBrkr")]
    #endif
    [IsoXmlTag("ClrBrkr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification73Choice_? ClearingBroker { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification73Choice_? ClearingBroker { get; init; } 
    #else
    public PartyIdentification73Choice_? ClearingBroker { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party that is exempt from a clearing obligation.
    /// </summary>
    [IsoId("_vlrHCZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Clearing Exception Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrXcptnPty")]
    #endif
    [IsoXmlTag("ClrXcptnPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification73Choice_? ClearingExceptionParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification73Choice_? ClearingExceptionParty { get; init; } 
    #else
    public PartyIdentification73Choice_? ClearingExceptionParty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reference number assigned by the clearing broker. A distinction can be made between the reference for the Central Counterparty (CCP) leg and the reference for the client leg of the transaction.
    /// </summary>
    [IsoId("_vlrHC5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Clearing Broker Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrBrkrId")]
    #endif
    [IsoXmlTag("ClrBrkrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingBrokerIdentification1? ClearingBrokerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingBrokerIdentification1? ClearingBrokerIdentification { get; init; } 
    #else
    public ClearingBrokerIdentification1? ClearingBrokerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the contract is above or below the clearing threshold. Where No indicates the contract is below the clearing threshold and Yes indicates the contract is above the clearing threshold.
    /// </summary>
    [IsoId("_vlrHDZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Clearing Threshold Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrThrshldInd")]
    #endif
    [IsoXmlTag("ClrThrshldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ClearingThresholdIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClearingThresholdIndicator { get; init; } 
    #else
    public System.String? ClearingThresholdIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reference number assigned by the Central Counterparty (CCP).
    /// </summary>
    [IsoId("_vlrHD5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Cleared Product Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrdPdctId")]
    #endif
    [IsoXmlTag("ClrdPdctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClearedProductIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClearedProductIdentification { get; init; } 
    #else
    public System.String? ClearedProductIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying product type.
    /// </summary>
    [IsoId("_vlrHEZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Underlying Product Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygPdctIdr")]
    #endif
    [IsoXmlTag("UndrlygPdctIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingProductIdentifier1Code? UnderlyingProductIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingProductIdentifier1Code? UnderlyingProductIdentifier { get; init; } 
    #else
    public UnderlyingProductIdentifier1Code? UnderlyingProductIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated.
    /// </summary>
    [IsoId("_vlrHE5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Allocation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllcnInd")]
    #endif
    [IsoXmlTag("AllcnInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AllocationIndicator1Code? AllocationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AllocationIndicator1Code? AllocationIndicator { get; init; } 
    #else
    public AllocationIndicator1Code? AllocationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the transaction is collateralised.
    /// </summary>
    [IsoId("_vlrHFZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Collateralisation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollstnInd")]
    #endif
    [IsoXmlTag("CollstnInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralisationIndicator1Code? CollateralisationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralisationIndicator1Code? CollateralisationIndicator { get; init; } 
    #else
    public CollateralisationIndicator1Code? CollateralisationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the trading venue of the transaction.
    /// </summary>
    [IsoId("_vlrHF5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Execution Venue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnVn")]
    #endif
    [IsoXmlTag("ExctnVn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ExecutionVenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExecutionVenue { get; init; } 
    #else
    public System.String? ExecutionVenue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date and time of the execution of the transaction in Coordinated Universal Time (UTC).
    /// </summary>
    [IsoId("_vlrHGZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Execution Timestamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnTmstmp")]
    #endif
    [IsoXmlTag("ExctnTmstmp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? ExecutionTimestamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? ExecutionTimestamp { get; init; } 
    #else
    public DateAndDateTimeChoice_? ExecutionTimestamp { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the reportable transaction has one or more additional terms or provisions, other than those listed in the required real-time data fields, that materially affects the price of the reportable transaction.
    /// </summary>
    [IsoId("_vlrHG5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Non Standard Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonStdFlg")]
    #endif
    [IsoXmlTag("NonStdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? NonStandardFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NonStandardFlag { get; init; } 
    #else
    public System.String? NonStandardFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the common reference or correlation identification for a swap transaction where the near and far leg are confirmed separately.
    /// </summary>
    [IsoId("_vlrHHZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Link Swap Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkSwpId")]
    #endif
    [IsoXmlTag("LkSwpId")]
    [IsoSimpleType(IsoSimpleType.Exact42Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact42Text? LinkSwapIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LinkSwapIdentification { get; init; } 
    #else
    public System.String? LinkSwapIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the financial nature of the reporting counterparty.
    /// </summary>
    [IsoId("_vlrHH5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Financial Nature Of The Counterparty Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinNtrOfTheCtrPtyInd")]
    #endif
    [IsoXmlTag("FinNtrOfTheCtrPtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? FinancialNatureOfTheCounterpartyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FinancialNatureOfTheCounterpartyIndicator { get; init; } 
    #else
    public System.String? FinancialNatureOfTheCounterpartyIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the collateral is posted on a portfolio basis.
    /// </summary>
    [IsoId("_vlrHIZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Collateral Portfolio Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPrtflInd")]
    #endif
    [IsoXmlTag("CollPrtflInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CollateralPortfolioIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralPortfolioIndicator { get; init; } 
    #else
    public System.String? CollateralPortfolioIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the portfolio code to which the trade belongs if the collateral is posted on a portfolio basis (and not trade by trade).
    /// </summary>
    [IsoId("_vlrHI5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Collateral Portfolio Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPrtflCd")]
    #endif
    [IsoXmlTag("CollPrtflCd")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? CollateralPortfolioCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralPortfolioCode { get; init; } 
    #else
    public System.String? CollateralPortfolioCode { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the trade results from portfolio compression.
    /// </summary>
    [IsoId("_vlrHJZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Portfolio Compression Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtflCmprssnInd")]
    #endif
    [IsoXmlTag("PrtflCmprssnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PortfolioCompressionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PortfolioCompressionIndicator { get; init; } 
    #else
    public System.String? PortfolioCompressionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate sector of the counterparty.
    /// </summary>
    [IsoId("_vlrHJ5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Corporate Sector Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpSctrInd")]
    #endif
    [IsoXmlTag("CorpSctrInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateSectorIdentifier1Code? CorporateSectorIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateSectorIdentifier1Code? CorporateSectorIndicator { get; init; } 
    #else
    public CorporateSectorIdentifier1Code? CorporateSectorIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the counterparty has entered into a trade with a non-European Economic Area (EEA) counterparty that is not subject to the reporting obligation.
    /// </summary>
    [IsoId("_vlrHKZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Trade With Non EEA Counterparty Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradWthNonEEACtrPtyInd")]
    #endif
    [IsoXmlTag("TradWthNonEEACtrPtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TradeWithNonEEACounterpartyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradeWithNonEEACounterpartyIndicator { get; init; } 
    #else
    public System.String? TradeWithNonEEACounterpartyIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// To indicate if a reported trade falls under the definition of intragroup transaction, as defined by European Securities and Markets Authority (ESMA) in the Technical Standards.
    /// </summary>
    [IsoId("_vlrHK5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Intragroup Trade Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtrgrpTradInd")]
    #endif
    [IsoXmlTag("NtrgrpTradInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? IntragroupTradeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IntragroupTradeIndicator { get; init; } 
    #else
    public System.String? IntragroupTradeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the contract is objectively measurable as directly linked to the non-financial counterparty&apos;s commercial or treasury financing activity.
    /// </summary>
    [IsoId("_vlrHLZR6Eeak6e8_Fc5fQg")]
    [DisplayName("Commercial Or Treasury Financing Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComrclOrTrsrFincgInd")]
    #endif
    [IsoXmlTag("ComrclOrTrsrFincgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CommercialOrTreasuryFinancingIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommercialOrTreasuryFinancingIndicator { get; init; } 
    #else
    public System.String? CommercialOrTreasuryFinancingIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_DF-d4ZR7Eeak6e8_Fc5fQg")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date and time of the confirmation of the trade in UTC.
    /// </summary>
    [IsoId("_kyLvAJUZEea7vKctaoIyEQ")]
    [DisplayName("Confirmation Date And Timestamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfDtAndTmstmp")]
    #endif
    [IsoXmlTag("ConfDtAndTmstmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ConfirmationDateAndTimestamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ConfirmationDateAndTimestamp { get; init; } 
    #else
    public System.DateTime? ConfirmationDateAndTimestamp { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the time at which the CCP has legally taken on the clearing of the trade in UTC.
    /// </summary>
    [IsoId("_s3QYsJUZEea7vKctaoIyEQ")]
    [DisplayName("Clearing Timestamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrTmstmp")]
    #endif
    [IsoXmlTag("ClrTmstmp")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? ClearingTimestamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? ClearingTimestamp { get; init; } 
    #else
    public System.TimeOnly? ClearingTimestamp { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies additional information that might be required by the regulator.
    /// </summary>
    [IsoId("_vlrHL5R6Eeak6e8_Fc5fQg")]
    [DisplayName("Additional Reporting Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRptgInf")]
    #endif
    [IsoXmlTag("AddtlRptgInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? AdditionalReportingInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalReportingInformation { get; init; } 
    #else
    public System.String? AdditionalReportingInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
