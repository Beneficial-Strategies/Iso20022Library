// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the approach of the Autorite des Marches Financiers (AMF) recommendation 2020-03 to which the fund complies.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OrKFoNA-EeuSBa1PsnseFg")]
[Description(
    @"Specifies the approach of the Autorite des Marches Financiers (AMF) recommendation 2020-03 to which the fund complies."
)]
[DerivedFrom(typeof(AMFDoctrineCode))]
public enum AMFDoctrine1Code
{
    /// <summary>
    /// Approach based on a significantly engaging methodology.
    /// Encoded/decoded by serializers as &quot;AMF1&quot;.
    /// </summary>
    [EnumMember(Value = "AMF1")]
    [IsoId("_SYhvQdA-EeuSBa1PsnseFg")]
    [Description(@"Approach based on a significantly engaging methodology.")]
    SignificantlyEngagingMethodology = AMFDoctrineCode.SignificantlyEngagingMethodology, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Approach not meeting central communication standards or based on limited communication standards.
    /// Encoded/decoded by serializers as &quot;AMF3&quot;.
    /// </summary>
    [EnumMember(Value = "AMF3")]
    [IsoId("_Se75QdA-EeuSBa1PsnseFg")]
    [Description(
        @"Approach not meeting central communication standards or based on limited communication standards."
    )]
    NotMeetingCentralCommunicationStandards =
        AMFDoctrineCode.NotMeetingCentralCommunicationStandards, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Approach based on a non-significantly engaging methodology.
    /// Encoded/decoded by serializers as &quot;AMF2&quot;.
    /// </summary>
    [EnumMember(Value = "AMF2")]
    [IsoId("_SlWDQdA-EeuSBa1PsnseFg")]
    [Description(@"Approach based on a non-significantly engaging methodology.")]
    NonSignificantlyEngagingMethodology = AMFDoctrineCode.NonSignificantlyEngagingMethodology, // same ordinal as derivation source for type conversions
}
