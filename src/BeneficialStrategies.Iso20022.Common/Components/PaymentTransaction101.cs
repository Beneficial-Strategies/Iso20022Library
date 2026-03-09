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
[IsoId("_j2uCAIaFEeiMm4lwapNmDA")]
[DisplayName("Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransaction101
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentTransaction101 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentTransaction101( System.String reqUETR,PaymentStatus5 reqTransactionStatus,System.DateTime reqInitiationTime,System.DateTime reqLastUpdateTime )
    {
        UETR = reqUETR;
        TransactionStatus = reqTransactionStatus;
        InitiationTime = reqInitiationTime;
        LastUpdateTime = reqLastUpdateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the unique end to end transaction reference of a payment.
    /// </summary>
    [IsoId("_LXDOIYaFEeiMm4lwapNmDA")]
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
    [IsoId("_LXDOIoaFEeiMm4lwapNmDA")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentStatus5 TransactionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentStatus5 TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentStatus5 TransactionStatus { get; init; } 
    #else
    public PaymentStatus5 TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the status of the cancellation of a payment transaction.
    /// </summary>
    [IsoId("_LXDOI4aFEeiMm4lwapNmDA")]
    [DisplayName("Cancellation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlSts")]
    #endif
    [IsoXmlTag("CxlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransactionCancellationStatus1? CancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransactionCancellationStatus1? CancellationStatus { get; init; } 
    #else
    public PaymentTransactionCancellationStatus1? CancellationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies date and time at which the message enters the tracking system (for example gpi).
    /// </summary>
    [IsoId("_LXDOJIaFEeiMm4lwapNmDA")]
    [DisplayName("Initiation Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitnTm")]
    #endif
    [IsoXmlTag("InitnTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime InitiationTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime InitiationTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime InitiationTime { get; init; } 
    #else
    public System.DateTime InitiationTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the time at which the instructed bank reports that the transaction has been completed. 
    /// Usage:
    /// Date and time based on the creation date of the status confirmation containing a final status ACSC
    /// </summary>
    [IsoId("_LXDOJYaFEeiMm4lwapNmDA")]
    [DisplayName("Completion Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpltnTm")]
    #endif
    [IsoXmlTag("CmpltnTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? CompletionTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? CompletionTime { get; init; } 
    #else
    public System.DateTime? CompletionTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies last date and time at which the status of this transaction was updated.
    /// </summary>
    [IsoId("_LXDOJoaFEeiMm4lwapNmDA")]
    [DisplayName("Last Update Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastUpdTm")]
    #endif
    [IsoXmlTag("LastUpdTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime LastUpdateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime LastUpdateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime LastUpdateTime { get; init; } 
    #else
    public System.DateTime LastUpdateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Groups the information of an event, namely of a payment message or status confirmation update. It is repeated as many times as there are events to be returned.
    /// </summary>
    [IsoId("_LXDOJ4aFEeiMm4lwapNmDA")]
    [DisplayName("Payment Event")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtEvt")]
    #endif
    [IsoXmlTag("PmtEvt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentEvent7? PaymentEvent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentEvent7? PaymentEvent { get; init; } 
    #else
    public PaymentEvent7? PaymentEvent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
