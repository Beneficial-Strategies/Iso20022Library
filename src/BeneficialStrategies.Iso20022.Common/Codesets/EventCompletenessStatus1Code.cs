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
[IsoId("_ajDtFNp-Ed-ak6NoX_4Aeg_1571232805")]
[Description(@"Indicates whether the details provided about an event are complete or incomplete.")]
[DerivedFrom(typeof(EventCompletenessStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EventCompletenessStatus1Code>))]
#endif
public enum EventCompletenessStatus1Code
{
    /// <summary>
    /// Event details are complete.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_ajDtFdp-Ed-ak6NoX_4Aeg_1572153086")]
    [Description(@"Event details are complete.")]
    Complete = EventCompletenessStatusCode.Complete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event details are not complete.
    /// Encoded/decoded by serializers as &quot;INCO&quot;.
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_ajDtFtp-Ed-ak6NoX_4Aeg_1572153199")]
    [Description(@"Event details are not complete.")]
    Incomplete = EventCompletenessStatusCode.Incomplete, // same ordinal as derivation source for type conversions
}
