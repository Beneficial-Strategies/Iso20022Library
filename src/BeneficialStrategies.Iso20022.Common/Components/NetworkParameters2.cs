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
/// Configuration parameters to communicate with a host.
/// </summary>
[IsoId("_xeuz0UeTEeODR7vDcYOqmg")]
[DisplayName("Network Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NetworkParameters2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NetworkParameters2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NetworkParameters2( System.String reqAddress )
    {
        Address = reqAddress;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// IP address or hostname.
    /// </summary>
    [IsoId("_qiiBQEeUEeODR7vDcYOqmg")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Address { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Address { get; init; } 
    #else
    public System.String Address { get; set; } 
    #endif
    
    /// <summary>
    /// Port number of the server, if the default port number is not used.
    /// </summary>
    [IsoId("_c3emgEeUEeODR7vDcYOqmg")]
    [DisplayName("Port Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PortNb")]
    #endif
    [IsoXmlTag("PortNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? PortNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PortNumber { get; init; } 
    #else
    public System.UInt64? PortNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Delay between two contacts of the server.
    /// </summary>
    [IsoId("_QxlywEeUEeODR7vDcYOqmg")]
    [DisplayName("Delay")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dely")]
    #endif
    [IsoXmlTag("Dely")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? Delay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? Delay { get; init; } 
    #else
    public System.TimeOnly? Delay { get; set; } 
    #endif
    
    
    #nullable disable
    
}
