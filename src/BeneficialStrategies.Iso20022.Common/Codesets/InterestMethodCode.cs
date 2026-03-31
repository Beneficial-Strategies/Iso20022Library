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
[IsoId("_YbAbdtp-Ed-ak6NoX_4Aeg_-843141968")]
[Description(@"Specifies whether the interest will be setlled in cash or rolled in.")]
[Derivations(typeof(InterestMethod1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InterestMethodCode>))]
#endif
public enum InterestMethodCode
{
    /// <summary>
    /// Indicates that the interest is intended to be settled in cash.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_YbAbd9p-Ed-ak6NoX_4Aeg_-1909597864")]
    [Description(@"Indicates that the interest is intended to be settled in cash.")]
    PhysicalSettlement,

    /// <summary>
    /// Indicates that the interest is intended to be rolled in to existing collateral balances.
    /// Encoded/decoded by serializers as &quot;ROLL&quot;.
    /// </summary>
    [EnumMember(Value = "ROLL")]
    [IsoId("_YbKMcNp-Ed-ak6NoX_4Aeg_-2144375015")]
    [Description(
        @"Indicates that the interest is intended to be rolled in to existing collateral balances."
    )]
    RollIn,
}
