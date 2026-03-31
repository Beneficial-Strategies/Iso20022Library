// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes whether peg or discretion price is static/fixed or floats.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aM2zkdp-Ed-ak6NoX_4Aeg_1618903822")]
[Description(@"Describes whether peg or discretion price is static/fixed or floats.")]
[Derivations(typeof(MoveType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MoveTypeCode>))]
#endif
public enum MoveTypeCode
{
    /// <summary>
    /// Indicates that the peg is static/fixed.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_aM2zktp-Ed-ak6NoX_4Aeg_1710334276")]
    [Description(@"Indicates that the peg is static/fixed.")]
    Static,

    /// <summary>
    /// Indicates that peg floats.
    /// Encoded/decoded by serializers as &quot;FLOA&quot;.
    /// </summary>
    [EnumMember(Value = "FLOA")]
    [IsoId("_aM2zk9p-Ed-ak6NoX_4Aeg_1722339290")]
    [Description(@"Indicates that peg floats.")]
    Float,
}
