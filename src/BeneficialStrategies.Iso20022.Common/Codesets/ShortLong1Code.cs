// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the securities position is short or long, that is, whether the balance is a negative or positive balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZOtwUtp-Ed-ak6NoX_4Aeg_136531631")]
[Description(@"Specifies whether the securities position is short or long, that is, whether the balance is a negative or positive balance.")]
[DerivedFrom(typeof(ShortLongCode))]
public enum ShortLong1Code
{
    /// <summary>
    /// Position is short, that is, the balance is negative.
    /// Encoded/decoded by serializers as &quot;SHOR&quot;.
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_ZOtwU9p-Ed-ak6NoX_4Aeg_179013074")]
    [Description(@"Position is short, that is, the balance is negative.")]
    Short = ShortLongCode.Short, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Position is long, that is, the balance is positive.
    /// Encoded/decoded by serializers as &quot;LONG&quot;.
    /// </summary>
    [EnumMember(Value = "LONG")]
    [IsoId("_ZOtwVNp-Ed-ak6NoX_4Aeg_1366496716")]
    [Description(@"Position is long, that is, the balance is positive.")]
    Long = ShortLongCode.Long, // same ordinal as derivation source for type conversions
    
}
