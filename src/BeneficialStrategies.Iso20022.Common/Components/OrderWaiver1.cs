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
/// Information about how an order is to be processed.
/// </summary>
[IsoId("_-312EToQEeabspMEjqY5TQ")]
[DisplayName("Order Waiver")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OrderWaiver1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason why the order has to be handled differently, probably in a manual fashion, because, for example, the investment manager has agreed a waiver to the terms.
    /// </summary>
    [IsoId("__Q1k4ToQEeabspMEjqY5TQ")]
    [DisplayName("Order Waiver Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrWvrRsn")]
    #endif
    [IsoXmlTag("OrdrWvrRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrderWaiverReason3Choice_? OrderWaiverReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderWaiverReason3Choice_? OrderWaiverReason { get; init; } 
    #else
    public OrderWaiverReason3Choice_? OrderWaiverReason { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the order waiver.
    /// </summary>
    [IsoId("__Q1k4zoQEeabspMEjqY5TQ")]
    [DisplayName("Information Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfVal")]
    #endif
    [IsoXmlTag("InfVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? InformationValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InformationValue { get; init; } 
    #else
    public System.String? InformationValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
