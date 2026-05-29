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
[IsoId("_ezFrcBZdEe6d6Ip1Ob2kaQ")]
[Description(
    @"Specifies the requested action, as published in an external investigation action code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalInvestigationAction1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationActionCode>))]
public enum ExternalInvestigationActionCode
{
    /// <summary>
    /// Responder is requested to close the investigation. All investigation requests relating to the investigation may be disregarded.
    /// Encoded/decoded by serializers as &quot;RQCL&quot;.
    /// </summary>
    [EnumMember(Value = "RQCL")]
    [IsoId("__-OZINYUEe68t8Cw380-tA")]
    [Description(
        @"Responder is requested to close the investigation. All investigation requests relating to the investigation may be disregarded."
    )]
    RequestInvestigationClosure,

    /// <summary>
    /// Responder is requested to review an earlier response as the requestor objects to it.
    /// Encoded/decoded by serializers as &quot;RQOB&quot;.
    /// </summary>
    [EnumMember(Value = "RQOB")]
    [IsoId("__-YKIdYUEe68t8Cw380-tA")]
    [Description(@"Responder is requested to review an earlier response as the requestor objects to it.")]
    RequestObjection,

    /// <summary>
    /// Responder is requested to provide the status of the investigation.
    /// Encoded/decoded by serializers as &quot;RQST&quot;.
    /// </summary>
    [EnumMember(Value = "RQST")]
    [IsoId("__-YKINYUEe68t8Cw380-tA")]
    [Description(@"Responder is requested to provide the status of the investigation.")]
    RequestInvestigationStatus,
}
