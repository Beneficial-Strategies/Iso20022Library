// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a returned status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_n4Q-8IZOEe-4Qrkp6i5eWQ")]
[Description(@"Specifies the reason why the instruction/cancellation request has a returned status.")]
[Derivations(typeof(ReturnedStatus1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ReturnedStatusCode>))]
public enum ReturnedStatusCode
{
    /// <summary>
    /// See narrative field for reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_2WsXYIZOEe-4Qrkp6i5eWQ")]
    [Description(@"See narrative field for reason.")]
    NarrativeReason,

    /// <summary>
    /// Shares returned due to prorated acceptance.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_xaUkAIZOEe-4Qrkp6i5eWQ")]
    [Description(@"Shares returned due to prorated acceptance.")]
    Prorated,
}
