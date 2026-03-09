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
/// Telecom services carries telephony billing data.
/// </summary>
[IsoId("_vShsAR1DEey8XKHwKquEQw")]
[DisplayName("Telecom Services")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TelecomServices2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Telecom Services Summary component is designed to carry summary level telephony billing data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to telecommunications services and related billing information. 
    /// </summary>
    [IsoId("_vZWswR1DEey8XKHwKquEQw")]
    [DisplayName("Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Summry")]
    #endif
    [IsoXmlTag("Summry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TelecomServicesSummary2? Summary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TelecomServicesSummary2? Summary { get; init; } 
    #else
    public TelecomServicesSummary2? Summary { get; set; } 
    #endif
    
    /// <summary>
    /// Telecom Services Line Item component is designed to carry detail level telephony billing data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to telecommunications services and related billing information. 
    /// </summary>
    [IsoId("_vZWswx1DEey8XKHwKquEQw")]
    [DisplayName("Line Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineItm")]
    #endif
    [IsoXmlTag("LineItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TelecomServicesLineItem2? LineItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TelecomServicesLineItem2? LineItem { get; init; } 
    #else
    public TelecomServicesLineItem2? LineItem { get; set; } 
    #endif
    
    
    #nullable disable
    
}
