// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of drawdown.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_goS4AFNdEeijdq8ilaxyOA")]
[Description(@"Specifies a type of drawdown.")]
[Derivations(typeof(DrawdownType1Code), typeof(DrawdownType2Code))]
public enum DrawdownTypeCode
{
    /// <summary>
    /// Drawdown type is flexi-access.
    /// Encoded/decoded by serializers as &quot;FLEX&quot;.
    /// </summary>
    [EnumMember(Value = "FLEX")]
    [IsoId("_kBqAgFNdEeijdq8ilaxyOA")]
    [Description(@"Drawdown type is flexi-access.")]
    FlexibleAccessDrawdown,

    /// <summary>
    /// Drawdown type is capped.
    /// Encoded/decoded by serializers as &quot;CAPP&quot;.
    /// </summary>
    [EnumMember(Value = "CAPP")]
    [IsoId("_oKCLIFNdEeijdq8ilaxyOA")]
    [Description(@"Drawdown type is capped.")]
    CappedIncomeDrawdown,

    /// <summary>
    /// Drawdown type is both flexi-access and capped.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_VwLq4JNwEembCsVG-3f_AA")]
    [Description(@"Drawdown type is both flexi-access and capped.")]
    Both,
}
