// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the priority level of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKUc8Np-Ed-ak6NoX_4Aeg_1584820248")]
[Description(@"Specifies the priority level of an event.")]
[DerivedFrom(typeof(PriorityCode))]
public enum Priority3Code
{
    /// <summary>
    /// Priority level is urgent (highest priority possible).
    /// Encoded/decoded by serializers as &quot;URGT&quot;.
    /// </summary>
    [EnumMember(Value = "URGT")]
    [IsoId("_aKUc8dp-Ed-ak6NoX_4Aeg_1584820280")]
    [Description(@"Priority level is urgent (highest priority possible).")]
    Urgent = PriorityCode.Urgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Priority level is high.
    /// Encoded/decoded by serializers as &quot;HIGH&quot;.
    /// </summary>
    [EnumMember(Value = "HIGH")]
    [IsoId("_aKUc8tp-Ed-ak6NoX_4Aeg_1584820309")]
    [Description(@"Priority level is high.")]
    High = PriorityCode.High, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Priority level is normal.
    /// Encoded/decoded by serializers as &quot;NORM&quot;.
    /// </summary>
    [EnumMember(Value = "NORM")]
    [IsoId("_aKUc89p-Ed-ak6NoX_4Aeg_1584820310")]
    [Description(@"Priority level is normal.")]
    Normal = PriorityCode.Normal, // same ordinal as derivation source for type conversions
}
