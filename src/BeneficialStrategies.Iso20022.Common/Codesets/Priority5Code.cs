// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the priority level of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kUSkAH_QEeiik6YN_dzlEA")]
[Description(@"Specifies the priority level of an event.")]
[DerivedFrom(typeof(PriorityCode))]
public enum Priority5Code
{
    /// <summary>
    /// Priority level is high.
    /// Encoded/decoded by serializers as &quot;HIGH&quot;.
    /// </summary>
    [EnumMember(Value = "HIGH")]
    [IsoId("_mcdxcH_QEeiik6YN_dzlEA")]
    [Description(@"Priority level is high.")]
    High = PriorityCode.High, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Priority level is low.
    /// Encoded/decoded by serializers as &quot;LOWW&quot;.
    /// </summary>
    [EnumMember(Value = "LOWW")]
    [IsoId("_mh3O0X_QEeiik6YN_dzlEA")]
    [Description(@"Priority level is low.")]
    Low = PriorityCode.Low, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Priority level is normal.
    /// Encoded/decoded by serializers as &quot;NORM&quot;.
    /// </summary>
    [EnumMember(Value = "NORM")]
    [IsoId("_mpC04X_QEeiik6YN_dzlEA")]
    [Description(@"Priority level is normal.")]
    Normal = PriorityCode.Normal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Priority level is urgent (highest priority possible).
    /// Encoded/decoded by serializers as &quot;URGT&quot;.
    /// </summary>
    [EnumMember(Value = "URGT")]
    [IsoId("_muQFAX_QEeiik6YN_dzlEA")]
    [Description(@"Priority level is urgent (highest priority possible).")]
    Urgent = PriorityCode.Urgent, // same ordinal as derivation source for type conversions
}
