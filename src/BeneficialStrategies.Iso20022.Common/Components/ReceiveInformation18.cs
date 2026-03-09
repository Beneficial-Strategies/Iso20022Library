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
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("_BUbtQ4fuEeevKP8c-ilVhA")]
[DisplayName("Receive Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReceiveInformation18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that receives (transferee) securities from the delivering agent (transferor).
    /// </summary>
    [IsoId("_BlF_aYfuEeevKP8c-ilVhA")]
    [DisplayName("Transferee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trfee")]
    #endif
    [IsoXmlTag("Trfee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification113? Transferee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification113? Transferee { get; init; } 
    #else
    public PartyIdentification113? Transferee { get; set; } 
    #endif
    
    /// <summary>
    /// Account into which the securities are to be received.
    /// </summary>
    [IsoId("_BlF_a4fuEeevKP8c-ilVhA")]
    [DisplayName("Transferee Registered Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfeeRegdAcct")]
    #endif
    [IsoXmlTag("TrfeeRegdAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account24? TransfereeRegisteredAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account24? TransfereeRegisteredAccount { get; init; } 
    #else
    public Account24? TransfereeRegisteredAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_BlF_bYfuEeevKP8c-ilVhA")]
    [DisplayName("Intermediary Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyInf")]
    #endif
    [IsoXmlTag("IntrmyInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Intermediary41? IntermediaryInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Intermediary41? IntermediaryInformation { get; init; } 
    #else
    public Intermediary41? IntermediaryInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_BlF_b4fuEeevKP8c-ilVhA")]
    [DisplayName("Requested Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdSttlmDt")]
    #endif
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedSettlementDate { get; init; } 
    #else
    public System.DateOnly? RequestedSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_BlF_cYfuEeevKP8c-ilVhA")]
    [DisplayName("Effective Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvSttlmDt")]
    #endif
    [IsoXmlTag("FctvSttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument.
    /// </summary>
    [IsoId("_BlF_c4fuEeevKP8c-ilVhA")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if whether the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_BlF_dYfuEeevKP8c-ilVhA")]
    [DisplayName("Stamp Duty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmpDty")]
    #endif
    [IsoXmlTag("StmpDty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StampDutyType2Code? StampDuty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StampDutyType2Code? StampDuty { get; init; } 
    #else
    public StampDutyType2Code? StampDuty { get; set; } 
    #endif
    
    /// <summary>
    /// Deal amount.
    /// </summary>
    [IsoId("_BlF_d4fuEeevKP8c-ilVhA")]
    [DisplayName("Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetAmt")]
    #endif
    [IsoXmlTag("NetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? NetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? NetAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? NetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Fee related to the transfer of the financial instrument.
    /// </summary>
    [IsoId("_NgrPcYjREeeiYZ2e3mpBRA")]
    [DisplayName("Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fees")]
    #endif
    [IsoXmlTag("Fees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Fees1? Fees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Fees1? Fees { get; init; } 
    #else
    public Fees1? Fees { get; set; } 
    #endif
    
    /// <summary>
    /// Tax related to the transfer of the financial instrument.
    /// </summary>
    [IsoId("_RmOvkYjREeeiYZ2e3mpBRA")]
    [DisplayName("Individual Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvTax")]
    #endif
    [IsoXmlTag("IndvTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax34? IndividualTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax34? IndividualTax { get; init; } 
    #else
    public Tax34? IndividualTax { get; set; } 
    #endif
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// How the exchange rate is expressed determines which currency is the Unit Currency and Quoted Currency. If the amounts concerned are EUR 1000 and USD 1300, the exchange rate may be expressed as per either of the following examples:
    /// EXAMPLE 1 
    /// UnitCurrency EUR
    /// QuotedCurrency USD
    /// ExchangeRate 1.300
    /// EXAMPLE 2
    /// UnitCurrency USD
    /// QuotedCurrency EUR
    /// ExchangeRate 0.769.
    /// </summary>
    [IsoId("_BlF_f4fuEeevKP8c-ilVhA")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms33? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms33? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms33? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Chain of parties involved in the settlement of the transaction.
    /// </summary>
    [IsoId("_BlF_gYfuEeevKP8c-ilVhA")]
    [DisplayName("Settlement Parties Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPtiesDtls")]
    #endif
    [IsoXmlTag("SttlmPtiesDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReceivingPartiesAndAccount17? SettlementPartiesDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceivingPartiesAndAccount17? SettlementPartiesDetails { get; init; } 
    #else
    public ReceivingPartiesAndAccount17? SettlementPartiesDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_BlF_g4fuEeevKP8c-ilVhA")]
    [DisplayName("Physical Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysTrf")]
    #endif
    [IsoXmlTag("PhysTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; } 
    #else
    public PhysicalTransferType1Code? PhysicalTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_BlF_hYfuEeevKP8c-ilVhA")]
    [DisplayName("Physical Transfer Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysTrfDtls")]
    #endif
    [IsoXmlTag("PhysTrfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryParameters4? PhysicalTransferDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryParameters4? PhysicalTransferDetails { get; init; } 
    #else
    public DeliveryParameters4? PhysicalTransferDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_BlF_h4fuEeevKP8c-ilVhA")]
    [DisplayName("Client Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntRef")]
    #endif
    [IsoXmlTag("ClntRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference8? ClientReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference8? ClientReference { get; init; } 
    #else
    public AdditionalReference8? ClientReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
