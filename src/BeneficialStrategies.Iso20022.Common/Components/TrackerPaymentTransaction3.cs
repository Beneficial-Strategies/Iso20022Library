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
/// Key elements used to identify the original transaction(s) that is being referred to.
/// </summary>
[IsoId("_XaBDNfWfEemtd4wHZYvFUQ")]
[DisplayName("Tracker Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerPaymentTransaction3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerPaymentTransaction3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerPaymentTransaction3( TrackerPartyIdentification1 reqTrackerInformingParty,PaymentIdentification11 reqPaymentIdentification )
    {
        TrackerInformingParty = reqTrackerInformingParty;
        PaymentIdentification = reqPaymentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information on the original tracked message that contained the transaction.
    /// </summary>
    [IsoId("_XaBDN_WfEemtd4wHZYvFUQ")]
    [DisplayName("Tracked Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckdMsgId")]
    #endif
    [IsoXmlTag("TrckdMsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalBusinessInstruction2? TrackedMessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalBusinessInstruction2? TrackedMessageIdentification { get; init; } 
    #else
    public OriginalBusinessInstruction2? TrackedMessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that provides information on the status and related details of a transaction.
    /// </summary>
    [IsoId("_XaBqMfWfEemtd4wHZYvFUQ")]
    [DisplayName("Tracker Informing Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckrInfrmgPty")]
    #endif
    [IsoXmlTag("TrckrInfrmgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TrackerPartyIdentification1 TrackerInformingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TrackerPartyIdentification1 TrackerInformingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerPartyIdentification1 TrackerInformingParty { get; init; } 
    #else
    public TrackerPartyIdentification1 TrackerInformingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_XaBqNfWfEemtd4wHZYvFUQ")]
    [DisplayName("Payment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtId")]
    #endif
    [IsoXmlTag("PmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentIdentification11 PaymentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentIdentification11 PaymentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification11 PaymentIdentification { get; init; } 
    #else
    public PaymentIdentification11 PaymentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the instructed agent is completed.
    /// </summary>
    [IsoId("_XaBqOfWfEemtd4wHZYvFUQ")]
    [DisplayName("Settlement Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmInf")]
    #endif
    [IsoXmlTag("SttlmInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementInstruction10? SettlementInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementInstruction10? SettlementInformation { get; init; } 
    #else
    public SettlementInstruction10? SettlementInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_XaBqPfWfEemtd4wHZYvFUQ")]
    [DisplayName("Instructed Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAgt")]
    #endif
    [IsoXmlTag("InstdAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrackerFinancialInstitutionIdentification1? InstructedAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerFinancialInstitutionIdentification1? InstructedAgent { get; init; } 
    #else
    public TrackerFinancialInstitutionIdentification1? InstructedAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_XaBqP_WfEemtd4wHZYvFUQ")]
    [DisplayName("Interbank Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmAmt")]
    #endif
    [IsoXmlTag("IntrBkSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? InterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? InterbankSettlementAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? InterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of the rate and the currencies used in the foreign exchange.
    /// </summary>
    [IsoId("_XaBqT_WfEemtd4wHZYvFUQ")]
    [DisplayName("Exchange Rate Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRateData")]
    #endif
    [IsoXmlTag("XchgRateData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyExchange16? ExchangeRateData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyExchange16? ExchangeRateData { get; init; } 
    #else
    public CurrencyExchange16? ExchangeRateData { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_XaBqUfWfEemtd4wHZYvFUQ")]
    [DisplayName("Charge Bearer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBr")]
    #endif
    [IsoXmlTag("ChrgBr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeBearerType4Code? ChargeBearer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBearerType4Code? ChargeBearer { get; init; } 
    #else
    public ChargeBearerType4Code? ChargeBearer { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the payment transaction.
    /// </summary>
    [IsoId("_XaBqU_WfEemtd4wHZYvFUQ")]
    [DisplayName("Charges Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsInf")]
    #endif
    [IsoXmlTag("ChrgsInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrackerCharges1? ChargesInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerCharges1? ChargesInformation { get; init; } 
    #else
    public TrackerCharges1? ChargesInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the tracking of the interbank transaction related to the payment.
    /// </summary>
    [IsoId("_XaBqVfWfEemtd4wHZYvFUQ")]
    [DisplayName("Tracker Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckrData")]
    #endif
    [IsoXmlTag("TrckrData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrackerData3? TrackerData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerData3? TrackerData { get; init; } 
    #else
    public TrackerData3? TrackerData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
