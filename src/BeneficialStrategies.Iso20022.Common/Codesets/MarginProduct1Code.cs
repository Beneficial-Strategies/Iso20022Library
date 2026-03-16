// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying product of the margin.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZq-tNp-Ed-ak6NoX_4Aeg_115662957")]
[Description(@"Specifies the underlying product of the margin.")]
[DerivedFrom(typeof(MarginProductCode))]
public enum MarginProduct1Code
{
    /// <summary>
    /// Specifies that the margin is related to equities.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_YZq-tdp-Ed-ak6NoX_4Aeg_1188512534")]
    [Description(@"Specifies that the margin is related to equities.")]
    Equities = MarginProductCode.Equities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the margin is related to fixed income.
    /// Encoded/decoded by serializers as &quot;FIXI&quot;.
    /// </summary>
    [EnumMember(Value = "FIXI")]
    [IsoId("_YZq-ttp-Ed-ak6NoX_4Aeg_1074673468")]
    [Description(@"Specifies that the margin is related to fixed income.")]
    FixedIncome = MarginProductCode.FixedIncome, // same ordinal as derivation source for type conversions
}
