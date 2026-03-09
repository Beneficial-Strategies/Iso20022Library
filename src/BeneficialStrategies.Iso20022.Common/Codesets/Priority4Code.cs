// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the priority level of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jc3ekMmJEeWAGphE2LvqeA")]
[Description(@"Specifies the priority level of an event.")]
[DerivedFrom(typeof(PriorityCode))]
public enum Priority4Code
{
    /// <summary>
    /// Priority level is normal.
    /// Encoded/decoded by serializers as &quot;NORM&quot;.
    /// </summary>
    [EnumMember(Value = "NORM")]
    [IsoId("_nOxC4cmJEeWAGphE2LvqeA")]
    [Description(@"Priority level is normal.")]
    Normal = PriorityCode.Normal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Priority level is urgent (highest priority possible).
    /// Encoded/decoded by serializers as &quot;URGT&quot;.
    /// </summary>
    [EnumMember(Value = "URGT")]
    [IsoId("_nbaXwsmJEeWAGphE2LvqeA")]
    [Description(@"Priority level is urgent (highest priority possible).")]
    Urgent = PriorityCode.Urgent, // same ordinal as derivation source for type conversions
    
}
