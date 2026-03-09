// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of communication network.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Wl2EAGpVEeSR-ZWLvO-1dg")]
[Description(@"Type of communication network.")]
[Derivations(typeof(NetworkType1Code),typeof(NetworkType2Code))]
public enum NetworkTypeCode
{
    /// <summary>
    /// Protocol of an IP network.
    /// Encoded/decoded by serializers as &quot;IPNW&quot;.
    /// </summary>
    [EnumMember(Value = "IPNW")]
    [IsoId("_bOwI0GpVEeSR-ZWLvO-1dg")]
    [Description(@"Protocol of an IP network.")]
    InternetProtocol,
    
    /// <summary>
    /// Protocol of a Public Switched Telephone Network (PSTN).
    /// Encoded/decoded by serializers as &quot;PSTN&quot;.
    /// </summary>
    [EnumMember(Value = "PSTN")]
    [IsoId("_iuROYGpVEeSR-ZWLvO-1dg")]
    [Description(@"Protocol of a Public Switched Telephone Network (PSTN).")]
    PublicTelephone,
    
    /// <summary>
    /// HTTP proxy.
    /// Encoded/decoded by serializers as &quot;HTTP&quot;.
    /// </summary>
    [EnumMember(Value = "HTTP")]
    [IsoId("_ykyg0I39EeWRwov1g9WL_A")]
    [Description(@"HTTP proxy.")]
    HTTP,
    
    /// <summary>
    /// Sock4 proxy.
    /// Encoded/decoded by serializers as &quot;SCK4&quot;.
    /// </summary>
    [EnumMember(Value = "SCK4")]
    [IsoId("_0jHOsI39EeWRwov1g9WL_A")]
    [Description(@"Sock4 proxy.")]
    Sock4,
    
    /// <summary>
    /// Sock5 proxy.
    /// Encoded/decoded by serializers as &quot;SCK5&quot;.
    /// </summary>
    [EnumMember(Value = "SCK5")]
    [IsoId("_5VfYkI39EeWRwov1g9WL_A")]
    [Description(@"Sock5 proxy.")]
    Sock5,
    
}
