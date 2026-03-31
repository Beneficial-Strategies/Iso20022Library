// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of goods and services purchased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XQ414ErDEeenp6hmNprBHg")]
[Description(@"Type of goods and services purchased.")]
[DerivedFrom(typeof(GoodsAndServicesCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<GoodsAndServices1Code>))]
#endif
public enum GoodsAndServices1Code
{
    /// <summary>
    /// Electronic goods and services.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_cGi64VHiEeeJoafcMZup1w")]
    [Description(@"Electronic goods and services.")]
    Electronic = GoodsAndServicesCode.Electronic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical goods or services.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_cTo7sVHiEeeJoafcMZup1w")]
    [Description(@"Physical goods or services.")]
    Physical = GoodsAndServicesCode.Physical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic and physical goods and services.
    /// Encoded/decoded by serializers as &quot;ELPH&quot;.
    /// </summary>
    [EnumMember(Value = "ELPH")]
    [IsoId("_cjQsEVHiEeeJoafcMZup1w")]
    [Description(@"Electronic and physical goods and services.")]
    ElectronicAndPhysical = GoodsAndServicesCode.ElectronicAndPhysical, // same ordinal as derivation source for type conversions
}
