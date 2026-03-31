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
[IsoId("_aAUwIINoEeuHqfO1LgkE9Q")]
[Description(@"Defines the type of endpoint.")]
[DerivedFrom(typeof(EndpointCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Endpoint1Code>))]
#endif
public enum Endpoint1Code
{
    /// <summary>
    /// Destination
    /// Encoded/decoded by serializers as &quot;DEST&quot;.
    /// </summary>
    [EnumMember(Value = "DEST")]
    [IsoId("_lMjYAYNoEeuHqfO1LgkE9Q")]
    [Description(@"Destination	")]
    Destination = EndpointCode.Destination, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Origination
    /// Encoded/decoded by serializers as &quot;ORIG&quot;.
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_lVDzwYNoEeuHqfO1LgkE9Q")]
    [Description(@"Origination")]
    Origination = EndpointCode.Origination, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type specified at a private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_m5vSkYNoEeuHqfO1LgkE9Q")]
    [Description(@"Type specified at a private level.")]
    OtherPrivate = EndpointCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type specified at the national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_nJ4nYoNoEeuHqfO1LgkE9Q")]
    [Description(@"Type specified at the national level.")]
    OtherNational = EndpointCode.OtherNational, // same ordinal as derivation source for type conversions
}
