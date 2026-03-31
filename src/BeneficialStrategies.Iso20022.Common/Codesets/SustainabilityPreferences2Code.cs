// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the product is compatible with investors that have sustainability preferences.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hSE6gcQYEe2pvZQ_33Qz1Q")]
[Description(
    @"Specifies whether the product is compatible with investors that have sustainability preferences."
)]
[DerivedFrom(typeof(SustainabilityPreferencesCode))]
public enum SustainabilityPreferences2Code
{
    /// <summary>
    /// Neutral or has no impact.
    /// Encoded/decoded by serializers as &quot;NEUT&quot;.
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("")]
    [Description(@"Neutral or has no impact.")]
    Neutral = SustainabilityPreferencesCode.Neutral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Yes, is applicable.
    /// Encoded/decoded by serializers as &quot;YSCO&quot;.
    /// </summary>
    [EnumMember(Value = "YSCO")]
    [IsoId("")]
    [Description(@"Yes, is applicable.")]
    InScope = SustainabilityPreferencesCode.InScope, // same ordinal as derivation source for type conversions
}
