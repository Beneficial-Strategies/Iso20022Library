// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Direction of the collateral being reported expressed as a code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bpmYYAMyEeutW5-TpeYJhA")]
[Description(@"Direction of the collateral being reported expressed as a code.")]
[DerivedFrom(typeof(CollateralDirectionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CollateralDirection1Code>))]
#endif
public enum CollateralDirection1Code
{
    /// <summary>
    /// Collateral is due to party A.
    /// Encoded/decoded by serializers as &quot;CDPA&quot;.
    /// </summary>
    [EnumMember(Value = "CDPA")]
    [IsoId("_x_VEQQMyEeutW5-TpeYJhA")]
    [Description(@"Collateral is due to party A.|")]
    CollateralDueToPartyA = CollateralDirectionCode.CollateralDueToPartyA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral is due to party B.
    /// Encoded/decoded by serializers as &quot;CDPB&quot;.
    /// </summary>
    [EnumMember(Value = "CDPB")]
    [IsoId("_yKB4YgMyEeutW5-TpeYJhA")]
    [Description(@"Collateral is due to party B.")]
    CollateralDueToPartyB = CollateralDirectionCode.CollateralDueToPartyB, // same ordinal as derivation source for type conversions
}
