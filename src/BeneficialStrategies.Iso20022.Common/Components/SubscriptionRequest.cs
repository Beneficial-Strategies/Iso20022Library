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
/// Used to subscribe or unsubscribe for the receipt of a certain message.
/// </summary>
[IsoId("_Q78B09p-Ed-ak6NoX_4Aeg_-246540997")]
[DisplayName("Subscription Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionRequest
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionRequest instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionRequest( SubscriptionRequest1Code reqValue )
    {
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Used to subscribe or unsubscribe for the receipt of a certain message.
    /// </summary>
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptReq")]
    #endif
    [IsoXmlTag("SbcptReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SubscriptionRequest1Code Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SubscriptionRequest1Code Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubscriptionRequest1Code Value { get; init; } 
    #else
    public SubscriptionRequest1Code Value { get; set; } 
    #endif
    
    
    #nullable disable
    
}
