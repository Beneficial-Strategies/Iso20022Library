// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Time period of the day.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-A6pgF1lEeeu75xdwwAXQw")]
[Description(@"Time period of the day.")]
[DerivedFrom(typeof(TimeSegmentCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TimeSegment1Code>))]
#endif
public enum TimeSegment1Code
{
    /// <summary>
    /// Ante meridiem or before noon time period.
    /// Encoded/decoded by serializers as &quot;AMBN&quot;.
    /// </summary>
    [EnumMember(Value = "AMBN")]
    [IsoId("_VvKAcV1mEeeu75xdwwAXQw")]
    [Description(@"Ante meridiem or before noon time period.")]
    AM = TimeSegmentCode.AM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Post meridiem or after noon time period.
    /// Encoded/decoded by serializers as &quot;PMAN&quot;.
    /// </summary>
    [EnumMember(Value = "PMAN")]
    [IsoId("_V8i8Ml1mEeeu75xdwwAXQw")]
    [Description(@"Post meridiem or after noon time period.")]
    PM = TimeSegmentCode.PM, // same ordinal as derivation source for type conversions
}
