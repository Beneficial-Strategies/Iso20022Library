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
/// Payment related to elements not reported in dedicated fields.
/// </summary>
[IsoId("_KgvEwYjnEeyf7vGW3nM0lg")]
[DisplayName("Other Payment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherPayment5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money of any payment the reporting counterparty made or received.
    /// Usage: The negative symbol to be used to indicate that the payment was made, not received.
    /// </summary>
    [IsoId("_KiHk0YjnEeyf7vGW3nM0lg")]
    [DisplayName("Payment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtAmt")]
    #endif
    [IsoXmlTag("PmtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection106? PaymentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection106? PaymentAmount { get; init; } 
    #else
    public AmountAndDirection106? PaymentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of other payment.
    /// </summary>
    [IsoId("_KiHk04jnEeyf7vGW3nM0lg")]
    [DisplayName("Payment Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTp")]
    #endif
    [IsoXmlTag("PmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentType5Choice_? PaymentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentType5Choice_? PaymentType { get; init; } 
    #else
    public PaymentType5Choice_? PaymentType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the unadjusted date on which the other payment is paid.
    /// </summary>
    [IsoId("_KiHk1YjnEeyf7vGW3nM0lg")]
    [DisplayName("Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDt")]
    #endif
    [IsoXmlTag("PmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? PaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? PaymentDate { get; init; } 
    #else
    public System.DateOnly? PaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the payer of the other payment amount.
    /// </summary>
    [IsoId("_KiHk14jnEeyf7vGW3nM0lg")]
    [DisplayName("Payment Payer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtPyer")]
    #endif
    [IsoXmlTag("PmtPyer")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification236Choice_? PaymentPayer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification236Choice_? PaymentPayer { get; init; } 
    #else
    public PartyIdentification236Choice_? PaymentPayer { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the receiver of the other payment amount.
    /// </summary>
    [IsoId("_KiHk2YjnEeyf7vGW3nM0lg")]
    [DisplayName("Payment Receiver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtRcvr")]
    #endif
    [IsoXmlTag("PmtRcvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification236Choice_? PaymentReceiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification236Choice_? PaymentReceiver { get; init; } 
    #else
    public PartyIdentification236Choice_? PaymentReceiver { get; set; } 
    #endif
    
    
    #nullable disable
    
}
