// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines how the rounding amount was applied in the calculation. For example, should the amount of collateral required be rounded up, down, to the closer integral multiple specified or not rounded.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YgFIsNp-Ed-ak6NoX_4Aeg_757152502")]
[Description(@"Defines how the rounding amount was applied in the calculation. For example, should the amount of collateral required be rounded up, down, to the closer integral multiple specified or not rounded.")]
[Derivations(typeof(RoundingMethod1Code))]
public enum RoundingMethodCode
{
    /// <summary>
    /// Rounds the amount down.
    /// Encoded/decoded by serializers as &quot;DRDW&quot;.
    /// </summary>
    [EnumMember(Value = "DRDW")]
    [IsoId("_YgFIsdp-Ed-ak6NoX_4Aeg_643313436")]
    [Description(@"Rounds the amount down.")]
    Down,
    
    /// <summary>
    /// Rounds the amount up.
    /// Encoded/decoded by serializers as &quot;DRUP&quot;.
    /// </summary>
    [EnumMember(Value = "DRUP")]
    [IsoId("_YgFIstp-Ed-ak6NoX_4Aeg_-239919851")]
    [Description(@"Rounds the amount up.")]
    Up,
    
    /// <summary>
    /// Do not round.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_YgFIs9p-Ed-ak6NoX_4Aeg_-1503003469")]
    [Description(@"Do not round.")]
    None,
    
    /// <summary>
    /// Rounds the amount to the closer integral multiple specified.
    /// Encoded/decoded by serializers as &quot;CLSR&quot;.
    /// </summary>
    [EnumMember(Value = "CLSR")]
    [IsoId("_YgFItNp-Ed-ak6NoX_4Aeg_-1640204487")]
    [Description(@"Rounds the amount to the closer integral multiple specified.")]
    Closer,
    
}
