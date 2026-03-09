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
/// Identification of a proxy appointed to represent a party authorised to vote at a shareholders meeting and proxy vote.
/// </summary>
[IsoId("_ww1xRRrfEeyhRdHRjakS2w")]
[DisplayName("Proxy")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Proxy12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Proxy12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Proxy12( ProxyType3Code reqProxyType )
    {
        ProxyType = reqProxyType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of proxy.
    /// </summary>
    [IsoId("_xFQiBRrfEeyhRdHRjakS2w")]
    [DisplayName("Proxy Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrxyTp")]
    #endif
    [IsoXmlTag("PrxyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProxyType3Code ProxyType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProxyType3Code ProxyType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProxyType3Code ProxyType { get; init; } 
    #else
    public ProxyType3Code ProxyType { get; set; } 
    #endif
    
    /// <summary>
    /// Person, other than the chairman of the meeting, assigned by the security holder as the proxy.
    /// </summary>
    [IsoId("_xFQiBxrfEeyhRdHRjakS2w")]
    [DisplayName("Person Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrsnDtls")]
    #endif
    [IsoXmlTag("PrsnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson42? PersonDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson42? PersonDetails { get; init; } 
    #else
    public IndividualPerson42? PersonDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
