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
[IsoId("_Z22DQZM5EemKz5EOjv82iQ")]
[DisplayName("Transfer Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferStatusAndReason7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransferStatusAndReason7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferStatusAndReason7( System.String reqTransferReference,TransferStatus4Choice_ reqTransferStatus )
    {
        TransferReference = reqTransferReference;
        TransferStatus = reqTransferStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_aLFN45M5EemKz5EOjv82iQ")]
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
    [IsoId("_aLFN5ZM5EemKz5EOjv82iQ")]
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
    [IsoId("_aLFN55M5EemKz5EOjv82iQ")]
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
    [IsoId("_aLFN6ZM5EemKz5EOjv82iQ")]
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
    [IsoId("_aLFN65M5EemKz5EOjv82iQ")]
    [DisplayName("Transfer Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfEvtTp")]
    #endif
    [IsoXmlTag("TrfEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransferStatusType1Choice_? TransferEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferStatusType1Choice_? TransferEventType { get; init; } 
    #else
    public TransferStatusType1Choice_? TransferEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    [IsoId("_aLFN7ZM5EemKz5EOjv82iQ")]
    [DisplayName("Transfer Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfSts")]
    #endif
    [IsoXmlTag("TrfSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferStatus4Choice_ TransferStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferStatus4Choice_ TransferStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferStatus4Choice_ TransferStatus { get; init; } 
    #else
    public TransferStatus4Choice_ TransferStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the transfer was executed.
    /// In some scenarios, this is the date and time to be used as the trade date when securities are settled through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_aLFN75M5EemKz5EOjv82iQ")]
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
    [IsoId("_aLFN8ZM5EemKz5EOjv82iQ")]
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
    [IsoId("_aLFN85M5EemKz5EOjv82iQ")]
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
    /// Number of units to be transferred.
    /// </summary>
    [IsoId("_aLFN9ZM5EemKz5EOjv82iQ")]
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
    [IsoId("_aLFN95M5EemKz5EOjv82iQ")]
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
    [IsoId("_aLFN-ZM5EemKz5EOjv82iQ")]
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
    /// Total transfer value.
    /// </summary>
    [IsoId("_aLFN-5M5EemKz5EOjv82iQ")]
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
    [IsoId("_aLFN_ZM5EemKz5EOjv82iQ")]
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
    [IsoId("_aLFN_5M5EemKz5EOjv82iQ")]
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
    [IsoId("_aLFOAZM5EemKz5EOjv82iQ")]
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
    /// Party that initiates the status.
    /// </summary>
    [IsoId("_aLFOA5M5EemKz5EOjv82iQ")]
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
    /// Party that issues the status message.
    /// </summary>
    [IsoId("_aLFOBZM5EemKz5EOjv82iQ")]
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
    /// Party that receives the status message.
    /// </summary>
    [IsoId("_aLFOB5M5EemKz5EOjv82iQ")]
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
    
    
    #nullable disable
    
}
