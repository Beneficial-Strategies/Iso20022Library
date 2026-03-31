// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the risk level.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FSdaIBdxEeKYM7Bc71nDlA")]
[Description(@"Specifies the risk level.")]
[DerivedFrom(typeof(RiskLevelCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RiskLevel1Code>))]
#endif
public enum RiskLevel1Code
{
    /// <summary>
    /// High.
    /// Encoded/decoded by serializers as &quot;HIGH&quot;.
    /// </summary>
    [EnumMember(Value = "HIGH")]
    [IsoId("_Lx6w4RdxEeKYM7Bc71nDlA")]
    [Description(@"High.")]
    High = RiskLevelCode.High, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Low.
    /// Encoded/decoded by serializers as &quot;LOWW&quot;.
    /// </summary>
    [EnumMember(Value = "LOWW")]
    [IsoId("_L595oRdxEeKYM7Bc71nDlA")]
    [Description(@"Low.")]
    Low = RiskLevelCode.Low, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Medium.
    /// Encoded/decoded by serializers as &quot;MEDM&quot;.
    /// </summary>
    [EnumMember(Value = "MEDM")]
    [IsoId("_MDqBIRdxEeKYM7Bc71nDlA")]
    [Description(@"Medium.")]
    Medium = RiskLevelCode.Medium, // same ordinal as derivation source for type conversions
}
