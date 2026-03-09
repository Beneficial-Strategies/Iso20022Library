// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Segment of time of the day
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VEH74F1lEeeu75xdwwAXQw")]
[Description(@"Segment of time of the day")]
[Derivations(typeof(TimeSegment1Code))]
public enum TimeSegmentCode
{
    /// <summary>
    /// Ante meridiem or before noon time period.
    /// Encoded/decoded by serializers as &quot;AMBN&quot;.
    /// </summary>
    [EnumMember(Value = "AMBN")]
    [IsoId("_ZeDJgF1lEeeu75xdwwAXQw")]
    [Description(@"Ante meridiem or before noon time period.")]
    AM,
    
    /// <summary>
    /// Post meridiem or after noon time period.
    /// Encoded/decoded by serializers as &quot;PMAN&quot;.
    /// </summary>
    [EnumMember(Value = "PMAN")]
    [IsoId("_q_p_EF1lEeeu75xdwwAXQw")]
    [Description(@"Post meridiem or after noon time period.")]
    PM,
    
}
