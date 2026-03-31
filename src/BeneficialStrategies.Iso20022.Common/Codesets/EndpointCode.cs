// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of endpoint.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_znpagINmEeuHqfO1LgkE9Q")]
[Description(@"Defines the type of endpoint.")]
[Derivations(typeof(Endpoint1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EndpointCode>))]
#endif
public enum EndpointCode
{
    /// <summary>
    /// Destination
    /// Encoded/decoded by serializers as &quot;DEST&quot;.
    /// </summary>
    [EnumMember(Value = "DEST")]
    [IsoId("_QzGoEINnEeuHqfO1LgkE9Q")]
    [Description(@"Destination	")]
    Destination,

    /// <summary>
    /// Origination
    /// Encoded/decoded by serializers as &quot;ORIG&quot;.
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_VhhfAINnEeuHqfO1LgkE9Q")]
    [Description(@"Origination")]
    Origination,

    /// <summary>
    /// Type specified at the national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_bKi9AINnEeuHqfO1LgkE9Q")]
    [Description(@"Type specified at the national level.")]
    OtherNational,

    /// <summary>
    /// Type specified at a private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_vNbcgINnEeuHqfO1LgkE9Q")]
    [Description(@"Type specified at a private level.")]
    OtherPrivate,
}
