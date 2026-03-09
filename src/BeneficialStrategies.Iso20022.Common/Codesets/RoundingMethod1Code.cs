// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines how the rounding amount was applied in the calculation. For example, should the amount of collateral required be rounded up, down, to the closer integral multiple specified or not rounded.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yf7Xstp-Ed-ak6NoX_4Aeg_385330264")]
[Description(@"Defines how the rounding amount was applied in the calculation. For example, should the amount of collateral required be rounded up, down, to the closer integral multiple specified or not rounded.")]
[DerivedFrom(typeof(RoundingMethodCode))]
public enum RoundingMethod1Code
{
    /// <summary>
    /// Rounds the amount down.
    /// Encoded/decoded by serializers as &quot;DRDW&quot;.
    /// </summary>
    [EnumMember(Value = "DRDW")]
    [IsoId("_Yf7Xs9p-Ed-ak6NoX_4Aeg_857438224")]
    [Description(@"Rounds the amount down.")]
    Down = RoundingMethodCode.Down, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rounds the amount up.
    /// Encoded/decoded by serializers as &quot;DRUP&quot;.
    /// </summary>
    [EnumMember(Value = "DRUP")]
    [IsoId("_Yf7XtNp-Ed-ak6NoX_4Aeg_-1995269424")]
    [Description(@"Rounds the amount up.")]
    Up = RoundingMethodCode.Up, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Do not round.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_Yf7Xtdp-Ed-ak6NoX_4Aeg_718047814")]
    [Description(@"Do not round.")]
    None = RoundingMethodCode.None, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rounds the amount to the closer integral multiple specified.
    /// Encoded/decoded by serializers as &quot;CLSR&quot;.
    /// </summary>
    [EnumMember(Value = "CLSR")]
    [IsoId("_Yf7Xttp-Ed-ak6NoX_4Aeg_-1257761254")]
    [Description(@"Rounds the amount to the closer integral multiple specified.")]
    Closer = RoundingMethodCode.Closer, // same ordinal as derivation source for type conversions
    
}
