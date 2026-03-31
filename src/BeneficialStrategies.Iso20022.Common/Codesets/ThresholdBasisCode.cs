// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Nature of the quantity used as a basis to set a threshold for voting on resolutions at general meetings.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CvEvwBuNEeyhRdHRjakS2w")]
[Description(
    @"Nature of the quantity used as a basis to set a threshold for voting on resolutions at general meetings."
)]
[Derivations(typeof(ThresholdBasis1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ThresholdBasisCode>))]
#endif
public enum ThresholdBasisCode
{
    /// <summary>
    /// Basis is the total number of shares issued.
    /// Encoded/decoded by serializers as &quot;ALSH&quot;.
    /// </summary>
    [EnumMember(Value = "ALSH")]
    [IsoId("_pkdE8BuNEeyhRdHRjakS2w")]
    [Description(@"Basis is the total number of shares issued.")]
    AllIssuedShares,

    /// <summary>
    /// Basis is the total number of shares represented at the meeting by attendees.
    /// Encoded/decoded by serializers as &quot;ALSM&quot;.
    /// </summary>
    [EnumMember(Value = "ALSM")]
    [IsoId("_yAePABuNEeyhRdHRjakS2w")]
    [Description(@"Basis is the total number of shares represented at the meeting by attendees. ")]
    AllSharesRepresentedAtMeeting,

    /// <summary>
    /// Basis is the total number of vote cast for a resolution.
    /// Encoded/decoded by serializers as &quot;ALVO&quot;.
    /// </summary>
    [EnumMember(Value = "ALVO")]
    [IsoId("__pr2sBuNEeyhRdHRjakS2w")]
    [Description(@"Basis is the total number of vote cast for a resolution.")]
    AllVoteCast,
}
