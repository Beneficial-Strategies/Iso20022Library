// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying product of the margin.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZq-t9p-Ed-ak6NoX_4Aeg_1067655731")]
[Description(@"Specifies the underlying product of the margin.")]
[Derivations(typeof(MarginProduct1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MarginProductCode>))]
#endif
public enum MarginProductCode
{
    /// <summary>
    /// Specifies that the margin is related to equities.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_YZq-uNp-Ed-ak6NoX_4Aeg_997889557")]
    [Description(@"Specifies that the margin is related to equities.")]
    Equities,

    /// <summary>
    /// Specifies that the margin is related to fixed income.
    /// Encoded/decoded by serializers as &quot;FIXI&quot;.
    /// </summary>
    [EnumMember(Value = "FIXI")]
    [IsoId("_YZ0IoNp-Ed-ak6NoX_4Aeg_-1565139017")]
    [Description(@"Specifies that the margin is related to fixed income.")]
    FixedIncome,
}
