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
/// Parameters to communicate with a host.
/// </summary>
[IsoId("_OsB4UY3-EeWRwov1g9WL_A")]
[DisplayName("Network Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NetworkParameters6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NetworkParameters6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NetworkParameters6( NetworkType2Code reqType,NetworkParameters5 reqAccess )
    {
        Type = reqType;
        Access = reqAccess;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of proxy.
    /// </summary>
    [IsoId("_csPDsI3-EeWRwov1g9WL_A")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NetworkType2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NetworkType2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkType2Code Type { get; init; } 
    #else
    public NetworkType2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Access information to the proxy.
    /// </summary>
    [IsoId("_O2dmtY3-EeWRwov1g9WL_A")]
    [DisplayName("Access")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Accs")]
    #endif
    [IsoXmlTag("Accs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NetworkParameters5 Access { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NetworkParameters5 Access { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters5 Access { get; init; } 
    #else
    public NetworkParameters5 Access { get; set; } 
    #endif
    
    
    #nullable disable
    
}
