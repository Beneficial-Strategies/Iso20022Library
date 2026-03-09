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
/// Information about a blocked account.
/// </summary>
[IsoId("_EGbMcSGeEeWKAaDJcYGKLw")]
[DisplayName("Blocked")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Blocked2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Blocked2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Blocked2( System.String reqBlocked )
    {
        Blocked = reqBlocked;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the order or transaction type for which the account is blocked.
    /// </summary>
    [IsoId("_EjSuoSGeEeWKAaDJcYGKLw")]
    [DisplayName("Order Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrTp")]
    #endif
    [IsoXmlTag("OrdrTp")]
    public ValueList<OrderType2Choice_> OrderType { get; init; } = new ValueList<OrderType2Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _EjSuoSGeEeWKAaDJcYGKLw
    
    /// <summary>
    /// Indicates whether the account is blocked.
    /// </summary>
    [IsoId("_EjSuoyGeEeWKAaDJcYGKLw")]
    [DisplayName("Blocked")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Blckd")]
    #endif
    [IsoXmlTag("Blckd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Blocked { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Blocked { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Blocked { get; init; } 
    #else
    public System.String Blocked { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason the account is blocked.
    /// </summary>
    [IsoId("_EjSupSGeEeWKAaDJcYGKLw")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BlockedReason1Choice_? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BlockedReason1Choice_? Reason { get; init; } 
    #else
    public BlockedReason1Choice_? Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
