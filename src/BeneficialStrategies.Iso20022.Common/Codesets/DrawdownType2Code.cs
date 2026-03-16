// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of drawdown.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hZrdkJNwEembCsVG-3f_AA")]
[Description(@"Specifies a type of drawdown.")]
[DerivedFrom(typeof(DrawdownTypeCode))]
public enum DrawdownType2Code
{
    /// <summary>
    /// Drawdown type is both flexi-access and capped.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_i8LLEZNwEembCsVG-3f_AA")]
    [Description(@"Drawdown type is both flexi-access and capped.")]
    Both = DrawdownTypeCode.Both, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Drawdown type is capped.
    /// Encoded/decoded by serializers as &quot;CAPP&quot;.
    /// </summary>
    [EnumMember(Value = "CAPP")]
    [IsoId("_jBOqMZNwEembCsVG-3f_AA")]
    [Description(@"Drawdown type is capped.")]
    CappedIncomeDrawdown = DrawdownTypeCode.CappedIncomeDrawdown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Drawdown type is flexi-access.
    /// Encoded/decoded by serializers as &quot;FLEX&quot;.
    /// </summary>
    [EnumMember(Value = "FLEX")]
    [IsoId("_jHLhMZNwEembCsVG-3f_AA")]
    [Description(@"Drawdown type is flexi-access.")]
    FlexibleAccessDrawdown = DrawdownTypeCode.FlexibleAccessDrawdown, // same ordinal as derivation source for type conversions
}
