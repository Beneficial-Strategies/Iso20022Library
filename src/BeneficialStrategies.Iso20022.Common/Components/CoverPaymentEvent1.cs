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
/// Provides details on the payment transaction related to the underlying cover payment.
/// </summary>
[IsoId("_IEdxMD72EeiJbZ2wCAV0-w")]
[DisplayName("Cover Payment Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CoverPaymentEvent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CoverPaymentEvent1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CoverPaymentEvent1( PaymentStatus5 reqTransactionStatus,System.DateTime reqInitiationTime,System.DateTime reqLastUpdateTime )
    {
        TransactionStatus = reqTransactionStatus;
        InitiationTime = reqInitiationTime;
        LastUpdateTime = reqLastUpdateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_hx708T72EeiJbZ2wCAV0-w")]
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
    /// Identifies the party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_3QZFIT73EeiJbZ2wCAV0-w")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Debtor { get; init; } 
    #else
    public System.String? Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the agent(s) currently participating in a transaction.
    /// </summary>
    [IsoId("_8jCDcT73EeiJbZ2wCAV0-w")]
    [DisplayName("Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agt")]
    #endif
    [IsoXmlTag("Agt")]
    public ValueList<PaymentEvent2> Agent { get; init; } = new ValueList<PaymentEvent2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _8jCDcT73EeiJbZ2wCAV0-w
    
    /// <summary>
    /// Identifies the party to which an amount of money is due.
    /// </summary>
    [IsoId("_FjBAwT75EeiJbZ2wCAV0-w")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Creditor { get; init; } 
    #else
    public System.String? Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date and time at which the message enters the Gpi system.
    /// </summary>
    [IsoId("_SCO6gT75EeiJbZ2wCAV0-w")]
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
    /// Date and time are based on the creation date of the status confirmation containing a final status ACSC.
    /// </summary>
    [IsoId("_TPcUgT75EeiJbZ2wCAV0-w")]
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
    /// Identifies the amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage:
    /// This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_VKfr8T75EeiJbZ2wCAV0-w")]
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
    /// Identifies the last date and time at which the status of this transaction was updated.
    /// </summary>
    [IsoId("_YgUYQT75EeiJbZ2wCAV0-w")]
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
    
    
    #nullable disable
    
}
