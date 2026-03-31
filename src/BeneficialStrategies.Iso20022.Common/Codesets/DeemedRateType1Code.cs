// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of a deemed rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_moeRYJSlEeeh5JjedkaA_g")]
[Description(@"Specifies the type of a deemed rate.")]
[DerivedFrom(typeof(DeemedRateTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DeemedRateType1Code>))]
#endif
public enum DeemedRateType1Code
{
    /// <summary>
    /// Deemed rate of dividend proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as &quot;DEDI&quot;.
    /// </summary>
    [EnumMember(Value = "DEDI")]
    [IsoId("_qLgTQZSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of dividend proceeds attributed to the security holder.")]
    DeemedDividendProceeds = DeemedRateTypeCode.DeemedDividendProceeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deemed rate of fund proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as &quot;DEFP&quot;.
    /// </summary>
    [EnumMember(Value = "DEFP")]
    [IsoId("_qaYcwZSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of fund proceeds attributed to the security holder.")]
    DeemedFundProceeds = DeemedRateTypeCode.DeemedFundProceeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deemed rate of interest proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as &quot;DEIT&quot;.
    /// </summary>
    [EnumMember(Value = "DEIT")]
    [IsoId("_qfvd4ZSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of interest proceeds attributed to the security holder.")]
    DeemedInterestProceeds = DeemedRateTypeCode.DeemedInterestProceeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deemed rate of royalties proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as &quot;DERY&quot;.
    /// </summary>
    [EnumMember(Value = "DERY")]
    [IsoId("_qm4AoZSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of royalties proceeds attributed to the security holder.")]
    DeemedRoyaltiesProceeds = DeemedRateTypeCode.DeemedRoyaltiesProceeds, // same ordinal as derivation source for type conversions
}
