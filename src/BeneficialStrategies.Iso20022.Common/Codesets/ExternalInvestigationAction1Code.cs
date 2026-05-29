// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the requested action, as published in an external investigation action code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rkVJUBZdEe6d6Ip1Ob2kaQ")]
[Description(
    @"Specifies the requested action, as published in an external investigation action code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalInvestigationActionCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationAction1Code>))]
public enum ExternalInvestigationAction1Code
{
    /// <summary>
    /// Responder is requested to close the investigation. All investigation requests relating to the investigation may be disregarded.
    /// Encoded/decoded by serializers as &quot;RQCL&quot;.
    /// </summary>
    [EnumMember(Value = "RQCL")]
    [IsoId("___Q68dYUEe68t8Cw380-tA")]
    [Description(
        @"Responder is requested to close the investigation. All investigation requests relating to the investigation may be disregarded."
    )]
    RequestInvestigationClosure = ExternalInvestigationActionCode.RequestInvestigationClosure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Responder is requested to review an earlier response as the requestor objects to it.
    /// Encoded/decoded by serializers as &quot;RQOB&quot;.
    /// </summary>
    [EnumMember(Value = "RQOB")]
    [IsoId("___Q69dYUEe68t8Cw380-tA")]
    [Description(@"Responder is requested to review an earlier response as the requestor objects to it.")]
    RequestObjection = ExternalInvestigationActionCode.RequestObjection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Responder is requested to provide the status of the investigation.
    /// Encoded/decoded by serializers as &quot;RQST&quot;.
    /// </summary>
    [EnumMember(Value = "RQST")]
    [IsoId("___Q689YUEe68t8Cw380-tA")]
    [Description(@"Responder is requested to provide the status of the investigation.")]
    RequestInvestigationStatus = ExternalInvestigationActionCode.RequestInvestigationStatus, // same ordinal as derivation source for type conversions
}
