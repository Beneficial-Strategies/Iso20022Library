// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the approach of the Autorite des Marches Financiers (AMF) recommendation 2020-03 to which the fund complies.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ty7h0M3AEeuAE-cYsQdwHQ")]
[Description(
    @"Specifies the approach of the Autorite des Marches Financiers (AMF) recommendation 2020-03 to which the fund complies."
)]
[Derivations(typeof(AMFDoctrine1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AMFDoctrineCode>))]
#endif
public enum AMFDoctrineCode
{
    /// <summary>
    /// Approach based on a significantly engaging methodology.
    /// Encoded/decoded by serializers as &quot;AMF1&quot;.
    /// </summary>
    [EnumMember(Value = "AMF1")]
    [IsoId("_16WU4M3AEeuAE-cYsQdwHQ")]
    [Description(@"Approach based on a significantly engaging methodology.")]
    SignificantlyEngagingMethodology,

    /// <summary>
    /// Approach based on a non-significantly engaging methodology.
    /// Encoded/decoded by serializers as &quot;AMF2&quot;.
    /// </summary>
    [EnumMember(Value = "AMF2")]
    [IsoId("_5VtBcM3AEeuAE-cYsQdwHQ")]
    [Description(@"Approach based on a non-significantly engaging methodology.")]
    NonSignificantlyEngagingMethodology,

    /// <summary>
    /// Approach not meeting central communication standards or based on limited communication standards.
    /// Encoded/decoded by serializers as &quot;AMF3&quot;.
    /// </summary>
    [EnumMember(Value = "AMF3")]
    [IsoId("_-MfxQM3AEeuAE-cYsQdwHQ")]
    [Description(
        @"Approach not meeting central communication standards or based on limited communication standards."
    )]
    NotMeetingCentralCommunicationStandards,
}
