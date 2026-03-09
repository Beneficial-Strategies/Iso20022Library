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
[IsoId("_R72T8XhSEeu3kecHd7QKUQ")]
[DisplayName("Other Payment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherPayment3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OtherPayment3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OtherPayment3( AmountAndDirection106 reqPaymentAmount )
    {
        PaymentAmount = reqPaymentAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money of any payment the reporting counterparty made or received.
    /// Usage: The negative symbol to be used to indicate that the payment was made, not received.
    /// </summary>
    [IsoId("_SKRxgXhSEeu3kecHd7QKUQ")]
    [DisplayName("Payment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtAmt")]
    #endif
    [IsoXmlTag("PmtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection106 PaymentAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection106 PaymentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection106 PaymentAmount { get; init; } 
    #else
    public AmountAndDirection106 PaymentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of other payment.
    /// </summary>
    [IsoId("_SKRxg3hSEeu3kecHd7QKUQ")]
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
    [IsoId("_SKRxhXhSEeu3kecHd7QKUQ")]
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
    [IsoId("_SKRxh3hSEeu3kecHd7QKUQ")]
    [DisplayName("Payment Payer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtPyer")]
    #endif
    [IsoXmlTag("PmtPyer")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification235Choice_? PaymentPayer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification235Choice_? PaymentPayer { get; init; } 
    #else
    public PartyIdentification235Choice_? PaymentPayer { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the receiver of the other payment amount.
    /// </summary>
    [IsoId("_SKRxiXhSEeu3kecHd7QKUQ")]
    [DisplayName("Payment Receiver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtRcvr")]
    #endif
    [IsoXmlTag("PmtRcvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification235Choice_? PaymentReceiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification235Choice_? PaymentReceiver { get; init; } 
    #else
    public PartyIdentification235Choice_? PaymentReceiver { get; set; } 
    #endif
    
    
    #nullable disable
    
}
