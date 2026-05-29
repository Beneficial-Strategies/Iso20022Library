// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of endpoint.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RiBHMSH1EfCkq6-p7S3J1Q")]
[Description(@"Defines the type of endpoint.")]
[DerivedFrom(typeof(EndpointCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<Endpoint2Code>))]
public enum Endpoint2Code
{
    /// <summary>
    /// Destination
    /// Encoded/decoded by serializers as &quot;DEST&quot;.
    /// </summary>
    [EnumMember(Value = "DEST")]
    [IsoId("_RkkE4SH1EfCkq6-p7S3J1Q")]
    [Description(@"Destination")]
    Destination = EndpointCode.Destination,

    /// <summary>
    /// Origination
    /// Encoded/decoded by serializers as &quot;ORIG&quot;.
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_RkkE4yH1EfCkq6-p7S3J1Q")]
    [Description(@"Origination")]
    Origination = EndpointCode.Origination,
}
