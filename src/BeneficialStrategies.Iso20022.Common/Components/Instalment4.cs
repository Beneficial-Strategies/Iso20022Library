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
/// Data exclusively related to a card issuer financial loan of the payment transaction, or instalment.
/// </summary>
[IsoId("_Amb4cZJKEeuuktRxxQZoNQ")]
[DisplayName("Instalment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Instalment4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the occurrence of a single instalment payment within a series of instalment payments. 
    /// </summary>
    [IsoId("_AsZ9kZJKEeuuktRxxQZoNQ")]
    [DisplayName("Payment Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtSeqNb")]
    #endif
    [IsoXmlTag("PmtSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? PaymentSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PaymentSequenceNumber { get; init; } 
    #else
    public System.UInt64? PaymentSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Attributes of the instalment plan.
    /// </summary>
    [IsoId("_AsZ9k5JKEeuuktRxxQZoNQ")]
    [DisplayName("Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Plan")]
    #endif
    [IsoXmlTag("Plan")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Plan2? Plan { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Plan2? Plan { get; init; } 
    #else
    public Plan2? Plan { get; set; } 
    #endif
    
    
    #nullable disable
    
}
