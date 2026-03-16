// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code defining the dvidend / distribution class where this franking information applies to.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yOyeMFfuEeOuDtoQo1qilA")]
[Description(
    @"Code defining the dvidend / distribution class where this franking information applies to."
)]
[DerivedFrom(typeof(FrankingClassCode))]
public enum FrankingClass1Code
{
    /// <summary>
    /// Franking information applies to ordinary cash dividend.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_0eNjIVfuEeOuDtoQo1qilA")]
    [Description(@"Franking information applies to ordinary cash dividend.")]
    CashDividend = FrankingClassCode.CashDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Franking information applies to interest payment.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_0l8i0VfuEeOuDtoQo1qilA")]
    [Description(@"Franking information applies to interest payment.")]
    Interest = FrankingClassCode.Interest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Franking information applies to NZD Declared dividend/distributions - supplementary dividend/distribution.
    /// Encoded/decoded by serializers as &quot;NZDD&quot;.
    /// </summary>
    [EnumMember(Value = "NZDD")]
    [IsoId("_0tYnkVfuEeOuDtoQo1qilA")]
    [Description(
        @"Franking information applies to NZD Declared dividend/distributions - supplementary dividend/distribution."
    )]
    NZDDeclared = FrankingClassCode.NZDDeclared, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Franking information applies to scrip dividend.
    /// Encoded/decoded by serializers as &quot;DVSC&quot;.
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("_00O2cVfuEeOuDtoQo1qilA")]
    [Description(@"Franking information applies to scrip dividend.")]
    ScripDividend = FrankingClassCode.ScripDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Franking information applies to special dividend.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_07YAQVfuEeOuDtoQo1qilA")]
    [Description(@"Franking information applies to special dividend.")]
    SpecialDividend = FrankingClassCode.SpecialDividend, // same ordinal as derivation source for type conversions
}
