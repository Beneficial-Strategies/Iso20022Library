// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the interest will be setlled in cash or rolled in.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YbAbc9p-Ed-ak6NoX_4Aeg_1343964956")]
[Description(@"Specifies whether the interest will be setlled in cash or rolled in.")]
[DerivedFrom(typeof(InterestMethodCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InterestMethod1Code>))]
#endif
public enum InterestMethod1Code
{
    /// <summary>
    /// Indicates that the interest is intended to be settled in cash.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_YbAbdNp-Ed-ak6NoX_4Aeg_-1896247899")]
    [Description(@"Indicates that the interest is intended to be settled in cash.")]
    PhysicalSettlement = InterestMethodCode.PhysicalSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the interest is intended to be rolled in to existing collateral balances.
    /// Encoded/decoded by serializers as &quot;ROLL&quot;.
    /// </summary>
    [EnumMember(Value = "ROLL")]
    [IsoId("_YbAbddp-Ed-ak6NoX_4Aeg_40977274")]
    [Description(
        @"Indicates that the interest is intended to be rolled in to existing collateral balances."
    )]
    RollIn = InterestMethodCode.RollIn, // same ordinal as derivation source for type conversions
}
