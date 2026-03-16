// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the direction of a payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_awK8Adp-Ed-ak6NoX_4Aeg_1477351773")]
[Description(@"Specifies the direction of a payment.")]
[DerivedFrom(typeof(DirectionCode))]
public enum Direction1Code
{
    /// <summary>
    /// Down.
    /// Encoded/decoded by serializers as &quot;DRDW&quot;.
    /// </summary>
    [EnumMember(Value = "DRDW")]
    [IsoId("_awK8Atp-Ed-ak6NoX_4Aeg_1520758160")]
    [Description(@"Down.")]
    Down = DirectionCode.Down, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Up.
    /// Encoded/decoded by serializers as &quot;DRUP&quot;.
    /// </summary>
    [EnumMember(Value = "DRUP")]
    [IsoId("_awK8A9p-Ed-ak6NoX_4Aeg_1752561964")]
    [Description(@"Up.")]
    Up = DirectionCode.Up, // same ordinal as derivation source for type conversions
}
