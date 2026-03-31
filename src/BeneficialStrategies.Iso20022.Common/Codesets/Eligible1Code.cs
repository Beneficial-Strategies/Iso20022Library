// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the item is eligible or not eligible.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_unGN4CC9EeWPMvNwVtiMsA")]
[Description(@"Specifies whether the item is eligible or not eligible.")]
[DerivedFrom(typeof(EligibleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Eligible1Code>))]
#endif
public enum Eligible1Code
{
    /// <summary>
    /// Item is eligible.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_RBY30SC-EeWPMvNwVtiMsA")]
    [Description(@"Item is eligible.")]
    Eligible = EligibleCode.Eligible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Item is not eligible.
    /// Encoded/decoded by serializers as &quot;NELI&quot;.
    /// </summary>
    [EnumMember(Value = "NELI")]
    [IsoId("_RIY3sSC-EeWPMvNwVtiMsA")]
    [Description(@"Item is not eligible.")]
    NotEligible = EligibleCode.NotEligible, // same ordinal as derivation source for type conversions
}
