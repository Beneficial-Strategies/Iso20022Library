// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZZvUk9p-Ed-ak6NoX_4Aeg_-1169758568")]
[Description(@"Specifies the type of rate.")]
[DerivedFrom(typeof(RateTypeCode))]
public enum RateType9Code
{
    /// <summary>
    /// Any and all rate is sought.
    /// Encoded/decoded by serializers as &quot;ANYA&quot;.
    /// </summary>
    [EnumMember(Value = "ANYA")]
    [IsoId("_ZZvUlNp-Ed-ak6NoX_4Aeg_-1126354403")]
    [Description(@"Any and all rate is sought.")]
    AnyAndAll = RateTypeCode.AnyAndAll, // same ordinal as derivation source for type conversions
}
