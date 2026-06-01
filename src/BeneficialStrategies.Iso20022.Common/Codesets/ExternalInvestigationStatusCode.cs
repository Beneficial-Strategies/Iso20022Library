// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigation status, as published in an external investigation status code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oYPdUEr1Ee2FOehj7wEwQQ")]
[Description(
    @"Specifies the investigation status, as published in an external investigation status code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalInvestigationStatus1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationStatusCode>))]
public enum ExternalInvestigationStatusCode
{
    /// <summary>
    /// Investigation is closed.
    /// Encoded/decoded by serializers as &quot;CLSD&quot;.
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("__-hUatYUEe68t8Cw380-tA")]
    [Description(@"Investigation is closed.")]
    InvestigationClosed,

    /// <summary>
    /// Investigation is opened/pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("__-hUa9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is opened/pending.")]
    InvestigationPending,

    /// <summary>
    /// Investigation is rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("__-hUbNYUEe68t8Cw380-tA")]
    [Description(@"Investigation is rejected.")]
    InvestigationRejected,
}
