// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of proxy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9wfkQI39EeWRwov1g9WL_A")]
[Description(@"Type of proxy.")]
[DerivedFrom(typeof(NetworkTypeCode))]
public enum NetworkType2Code
{
    /// <summary>
    /// Sock5 proxy.
    /// Encoded/decoded by serializers as &quot;SCK5&quot;.
    /// </summary>
    [EnumMember(Value = "SCK5")]
    [IsoId("_BAFFsY3-EeWRwov1g9WL_A")]
    [Description(@"Sock5 proxy.")]
    Sock5 = NetworkTypeCode.Sock5, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sock4 proxy.
    /// Encoded/decoded by serializers as &quot;SCK4&quot;.
    /// </summary>
    [EnumMember(Value = "SCK4")]
    [IsoId("_BLtG4Y3-EeWRwov1g9WL_A")]
    [Description(@"Sock4 proxy.")]
    Sock4 = NetworkTypeCode.Sock4, // same ordinal as derivation source for type conversions

    /// <summary>
    /// HTTP proxy.
    /// Encoded/decoded by serializers as &quot;HTTP&quot;.
    /// </summary>
    [EnumMember(Value = "HTTP")]
    [IsoId("_BYqk0Y3-EeWRwov1g9WL_A")]
    [Description(@"HTTP proxy.")]
    HTTP = NetworkTypeCode.HTTP, // same ordinal as derivation source for type conversions
}
