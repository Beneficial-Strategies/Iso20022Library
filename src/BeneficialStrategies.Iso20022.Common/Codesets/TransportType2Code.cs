// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the transportation type code list
/// </summary>
[DataContract]
[Serializable]
[IsoId("_S9CLEVN2EfC0lMwgjvMClw")]
[Description(@"Contains the transportation type code list")]
[DerivedFrom(typeof(TransportTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TransportType2Code>))]
public enum TransportType2Code
{
    /// <summary>
    /// Air
    /// Encoded/decoded by serializers as &quot;AIRR&quot;.
    /// </summary>
    [EnumMember(Value = "AIRR")]
    [IsoId("_S_xWAVN2EfC0lMwgjvMClw")]
    [Description(@"Air")]
    Air = TransportTypeCode.Air, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bus
    /// Encoded/decoded by serializers as &quot;BUSS&quot;.
    /// </summary>
    [EnumMember(Value = "BUSS")]
    [IsoId("_S_xWA1N2EfC0lMwgjvMClw")]
    [Description(@"Bus")]
    Bus = TransportTypeCode.Bus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rail
    /// Encoded/decoded by serializers as &quot;RAIL&quot;.
    /// </summary>
    [EnumMember(Value = "RAIL")]
    [IsoId("_S_xWCVN2EfC0lMwgjvMClw")]
    [Description(@"Rail")]
    Rail = TransportTypeCode.Rail, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ship
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_S_xWC1N2EfC0lMwgjvMClw")]
    [Description(@"Ship")]
    Ship = TransportTypeCode.Ship, // same ordinal as derivation source for type conversions
}
