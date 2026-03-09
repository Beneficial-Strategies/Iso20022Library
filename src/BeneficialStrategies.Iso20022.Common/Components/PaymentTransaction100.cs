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
/// Contains the details on the payment transaction.
/// </summary>
[IsoId("_bpDbAEI_EeinU6Cqu8f2Ow")]
[DisplayName("Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransaction100
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentTransaction100 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentTransaction100( System.String reqUETR,PaymentStatus4 reqTransactionStatus,System.DateTime reqEventTime,System.String reqOriginator )
    {
        UETR = reqUETR;
        TransactionStatus = reqTransactionStatus;
        EventTime = reqEventTime;
        Originator = reqOriginator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the unique end to end transaction reference of a payment, issued by the originator.
    /// </summary>
    [IsoId("_e3BusUJGEeinU6Cqu8f2Ow")]
    [DisplayName("UETR")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UETR")]
    #endif
    [IsoXmlTag("UETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoUUIDv4Identifier UETR { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String UETR { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String UETR { get; init; } 
    #else
    public System.String UETR { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_j1xVEUJQEeinU6Cqu8f2Ow")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentStatus4 TransactionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentStatus4 TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentStatus4 TransactionStatus { get; init; } 
    #else
    public PaymentStatus4 TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the time when the related status was reached.
    /// </summary>
    [IsoId("_prt0wUJQEeinU6Cqu8f2Ow")]
    [DisplayName("Event Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTm")]
    #endif
    [IsoXmlTag("EvtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime EventTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime EventTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime EventTime { get; init; } 
    #else
    public System.DateTime EventTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the party that issues the status.
    /// </summary>
    [IsoId("_sJJEAUJREeinU6Cqu8f2Ow")]
    [DisplayName("Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Orgtr")]
    #endif
    [IsoXmlTag("Orgtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier Originator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Originator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Originator { get; init; } 
    #else
    public System.String Originator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_V7WMIUJREeinU6Cqu8f2Ow")]
    [DisplayName("Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAmt")]
    #endif
    [IsoXmlTag("InstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the actual amount that has been paid to the ultimate beneficiary, after all charges etc... have been deducted.
    /// </summary>
    [IsoId("_XKECAUJREeinU6Cqu8f2Ow")]
    [DisplayName("Confirmed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfdAmt")]
    #endif
    [IsoXmlTag("ConfdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ConfirmedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ConfirmedAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ConfirmedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// This groups the information of an event which is a payment message or status confirmation update. It is repeated as many times as there are events to be returned.
    /// </summary>
    [IsoId("__su_cUJREeinU6Cqu8f2Ow")]
    [DisplayName("Payment Event")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtEvt")]
    #endif
    [IsoXmlTag("PmtEvt")]
    public ValueList<PaymentEvent6> PaymentEvent { get; init; } = new ValueList<PaymentEvent6>(){}; // Warning: Don't know multiplicity.
    // ID for the above is __su_cUJREeinU6Cqu8f2Ow
    
    
    #nullable disable
    
}
