// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the details provided about an event are complete or incomplete.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ajDtF9p-Ed-ak6NoX_4Aeg_1258156300")]
[Description(@"Indicates whether the details provided about an event are complete or incomplete.")]
[Derivations(typeof(EventCompletenessStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EventCompletenessStatusCode>))]
#endif
public enum EventCompletenessStatusCode
{
    /// <summary>
    /// Event details are complete.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_ajDtGNp-Ed-ak6NoX_4Aeg_1323729253")]
    [Description(@"Event details are complete.")]
    Complete,

    /// <summary>
    /// Event details are not complete.
    /// Encoded/decoded by serializers as &quot;INCO&quot;.
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_ajNeENp-Ed-ak6NoX_4Aeg_1340352229")]
    [Description(@"Event details are not complete.")]
    Incomplete,
}
