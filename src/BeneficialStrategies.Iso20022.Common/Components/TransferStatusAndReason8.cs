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
/// Information about the status of a transfer instruction and its reason.
/// </summary>
[IsoId("_UEdjodx9EeqKxsvOxFQHKA")]
[DisplayName("Transfer Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferStatusAndReason8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransferStatusAndReason8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferStatusAndReason8( System.String reqTransferReference,TransferStatus5Choice_ reqTransferStatus )
    {
        TransferReference = reqTransferReference;
        TransferStatus = reqTransferStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_UXplY9x9EeqKxsvOxFQHKA")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the transfer, as assigned by the instructing party.
    /// </summary>
    [IsoId("_UXplZdx9EeqKxsvOxFQHKA")]
    [DisplayName("Transfer Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfRef")]
    #endif
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransferReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransferReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransferReference { get; init; } 
    #else
    public System.String TransferReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_UXzWYdx9EeqKxsvOxFQHKA")]
    [DisplayName("Client Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntRef")]
    #endif
    [IsoXmlTag("ClntRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference10? ClientReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference10? ClientReference { get; init; } 
    #else
    public AdditionalReference10? ClientReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_UXzWY9x9EeqKxsvOxFQHKA")]
    [DisplayName("Cancellation Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRef")]
    #endif
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CancellationReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancellationReference { get; init; } 
    #else
    public System.String? CancellationReference { get; set; } 
    #endif
    
    /// <summary>
    /// Type of event for which the message is sent.
    /// </summary>
    [IsoId("_UXzWZdx9EeqKxsvOxFQHKA")]
    [DisplayName("Transfer Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfEvtTp")]
    #endif
    [IsoXmlTag("TrfEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransferStatusType3Choice_? TransferEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferStatusType3Choice_? TransferEventType { get; init; } 
    #else
    public TransferStatusType3Choice_? TransferEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    [IsoId("_UXzWZ9x9EeqKxsvOxFQHKA")]
    [DisplayName("Transfer Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfSts")]
    #endif
    [IsoXmlTag("TrfSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferStatus5Choice_ TransferStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferStatus5Choice_ TransferStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferStatus5Choice_ TransferStatus { get; init; } 
    #else
    public TransferStatus5Choice_ TransferStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("_ZMzWcdx9EeqKxsvOxFQHKA")]
    [DisplayName("Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Instrm")]
    #endif
    [IsoXmlTag("Instrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument63Choice_? Instrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument63Choice_? Instrument { get; init; } 
    #else
    public FinancialInstrument63Choice_? Instrument { get; set; } 
    #endif
    
    /// <summary>
    /// Investment account information of the transfer for which the status or information is provided.
    /// </summary>
    [IsoId("_chGYwdx9EeqKxsvOxFQHKA")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account33? InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account33? InvestmentAccountDetails { get; init; } 
    #else
    public Account33? InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_vRGQMXdhEeuvip1zrZRWzw")]
    [DisplayName("Intermediary Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyInf")]
    #endif
    [IsoXmlTag("IntrmyInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Intermediary48? IntermediaryInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Intermediary48? IntermediaryInformation { get; init; } 
    #else
    public Intermediary48? IntermediaryInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the transfer was executed.
    /// In some scenarios, this is the date and time to be used as the trade date when securities are settled through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_UXzWadx9EeqKxsvOxFQHKA")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TradeDate { get; init; } 
    #else
    public System.DateOnly? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the securities are to be exchanged or were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_UXzWa9x9EeqKxsvOxFQHKA")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SettlementDate { get; init; } 
    #else
    public System.DateOnly? SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the document, for example, the application form, was sent.
    /// </summary>
    [IsoId("_UXzWbdx9EeqKxsvOxFQHKA")]
    [DisplayName("Send Out Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndOutDt")]
    #endif
    [IsoXmlTag("SndOutDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SendOutDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SendOutDate { get; init; } 
    #else
    public System.DateOnly? SendOutDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_0ksRsXgaEeuvip1zrZRWzw")]
    [DisplayName("Cash Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlmDt")]
    #endif
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CashSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CashSettlementDate { get; init; } 
    #else
    public System.DateOnly? CashSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units to be transferred.
    /// </summary>
    [IsoId("_UXzWb9x9EeqKxsvOxFQHKA")]
    [DisplayName("Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlUnitsNb")]
    #endif
    [IsoXmlTag("TtlUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? TotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalUnitsNumber { get; init; } 
    #else
    public System.UInt64? TotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Weighted average price of the units in the account. The average price may also be known as the average acquisition price.
    /// </summary>
    [IsoId("_UXzWcdx9EeqKxsvOxFQHKA")]
    [DisplayName("Average Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgPric")]
    #endif
    [IsoXmlTag("AvrgPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of units to be transferred.
    /// </summary>
    [IsoId("_UXzWc9x9EeqKxsvOxFQHKA")]
    [DisplayName("Units Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsDtls")]
    #endif
    [IsoXmlTag("UnitsDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Unit11? UnitsDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Unit11? UnitsDetails { get; init; } 
    #else
    public Unit11? UnitsDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the source security following a conversion.
    /// </summary>
    [IsoId("_zeZsAXwgEeuQY_68iqAoCQ")]
    [DisplayName("Conversion")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Convs")]
    #endif
    [IsoXmlTag("Convs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Conversion2? Conversion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Conversion2? Conversion { get; init; } 
    #else
    public Conversion2? Conversion { get; set; } 
    #endif
    
    /// <summary>
    /// Total transfer value.
    /// </summary>
    [IsoId("_UXzWddx9EeqKxsvOxFQHKA")]
    [DisplayName("Total Transfer Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlTrfVal")]
    #endif
    [IsoXmlTag("TtlTrfVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? TotalTransferValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? TotalTransferValue { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? TotalTransferValue { get; set; } 
    #endif
    
    /// <summary>
    /// Details of a payment that will result from or resulting from the liquation of an asset and transfer of cash or for the transfer of cash that was not invested.
    /// </summary>
    [IsoId("_UXzWd9x9EeqKxsvOxFQHKA")]
    [DisplayName("Payment Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDtls")]
    #endif
    [IsoXmlTag("PmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument18? PaymentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument18? PaymentDetails { get; init; } 
    #else
    public PaymentInstrument18? PaymentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the realisation of benefits taken from a pension.
    /// </summary>
    [IsoId("_UXzWedx9EeqKxsvOxFQHKA")]
    [DisplayName("Benefit Crystallisation Event")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnftCrstllstnEvt")]
    #endif
    [IsoXmlTag("BnftCrstllstnEvt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BenefitCrystallisationEvent2? BenefitCrystallisationEvent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BenefitCrystallisationEvent2? BenefitCrystallisationEvent { get; init; } 
    #else
    public BenefitCrystallisationEvent2? BenefitCrystallisationEvent { get; set; } 
    #endif
    
    /// <summary>
    /// Details of a drawdown tranche.
    /// </summary>
    [IsoId("_UXzWe9x9EeqKxsvOxFQHKA")]
    [DisplayName("Drawdown Tranche")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrwdwnTrch")]
    #endif
    [IsoXmlTag("DrwdwnTrch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Drawdown2? DrawdownTranche { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Drawdown2? DrawdownTranche { get; init; } 
    #else
    public Drawdown2? DrawdownTranche { get; set; } 
    #endif
    
    /// <summary>
    /// Drawdown information not specifically associated with a drawdown tranche.
    /// </summary>
    [IsoId("_3A6zoHzoEeuEHsEB8Johfw")]
    [DisplayName("Other Drawdown Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrDrwdwnInf")]
    #endif
    [IsoXmlTag("OthrDrwdwnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Drawdown3? OtherDrawdownInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Drawdown3? OtherDrawdownInformation { get; init; } 
    #else
    public Drawdown3? OtherDrawdownInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Response information.
    /// </summary>
    [IsoId("_OfS3sXp6EeuldpLtvj4F0Q")]
    [DisplayName("Query Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryRspn")]
    #endif
    [IsoXmlTag("QryRspn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? QueryResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QueryResponse { get; init; } 
    #else
    public System.String? QueryResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    [IsoId("_UXzWfdx9EeqKxsvOxFQHKA")]
    [DisplayName("Status Initiator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsInitr")]
    #endif
    [IsoXmlTag("StsInitr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification139? StatusInitiator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification139? StatusInitiator { get; init; } 
    #else
    public PartyIdentification139? StatusInitiator { get; set; } 
    #endif
    
    /// <summary>
    /// Party that issues the status or information message.
    /// </summary>
    [IsoId("_UXzWf9x9EeqKxsvOxFQHKA")]
    [DisplayName("Status Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsIssr")]
    #endif
    [IsoXmlTag("StsIssr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification139? StatusIssuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification139? StatusIssuer { get; init; } 
    #else
    public PartyIdentification139? StatusIssuer { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives the status or information message.
    /// </summary>
    [IsoId("_UXzWgdx9EeqKxsvOxFQHKA")]
    [DisplayName("Status Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRcpt")]
    #endif
    [IsoXmlTag("StsRcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification139? StatusRecipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification139? StatusRecipient { get; init; } 
    #else
    public PartyIdentification139? StatusRecipient { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_tGEMsXp6EeuldpLtvj4F0Q")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
