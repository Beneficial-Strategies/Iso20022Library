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
[IsoId("_5RKOsQ1DEeqjM-rxn3HuXQ")]
[DisplayName("Network Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NetworkParameters9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NetworkParameters9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NetworkParameters9( NetworkType1Code reqNetworkType,System.String reqAddressValue )
    {
        NetworkType = reqNetworkType;
        AddressValue = reqAddressValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of communication network.
    /// </summary>
    [IsoId("_5did0Q1DEeqjM-rxn3HuXQ")]
    [DisplayName("Network Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtwkTp")]
    #endif
    [IsoXmlTag("NtwkTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NetworkType1Code NetworkType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NetworkType1Code NetworkType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkType1Code NetworkType { get; init; } 
    #else
    public NetworkType1Code NetworkType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the address. The value of an internet protocol address contains the IP address or the DNS (Domain Name Server) address, followed by the character &apos;: &apos; and the port number if the default port is not used. The value of a public telephone address contains the phone number with possible prefix and extensions.
    /// </summary>
    [IsoId("_5did0w1DEeqjM-rxn3HuXQ")]
    [DisplayName("Address Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdrVal")]
    #endif
    [IsoXmlTag("AdrVal")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax500Text AddressValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AddressValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AddressValue { get; init; } 
    #else
    public System.String AddressValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
