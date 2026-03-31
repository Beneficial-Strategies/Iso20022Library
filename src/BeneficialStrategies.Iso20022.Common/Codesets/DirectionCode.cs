// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the direction of a payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_awK8BNp-Ed-ak6NoX_4Aeg_1863385862")]
[Description(@"Specifies the direction of a payment.")]
[Derivations(typeof(Direction1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DirectionCode>))]
#endif
public enum DirectionCode
{
    /// <summary>
    /// Down.
    /// Encoded/decoded by serializers as &quot;DRDW&quot;.
    /// </summary>
    [EnumMember(Value = "DRDW")]
    [IsoId("_awK8Bdp-Ed-ak6NoX_4Aeg_1863385879")]
    [Description(@"Down.")]
    Down,

    /// <summary>
    /// Up.
    /// Encoded/decoded by serializers as &quot;DRUP&quot;.
    /// </summary>
    [EnumMember(Value = "DRUP")]
    [IsoId("_awK8Btp-Ed-ak6NoX_4Aeg_1863385888")]
    [Description(@"Up.")]
    Up,
}
