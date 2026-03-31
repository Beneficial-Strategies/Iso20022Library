// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the priority level of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKUc9Np-Ed-ak6NoX_4Aeg_1549809096")]
[Description(@"Specifies the priority level of an event.")]
[Derivations(
    typeof(Priority1Code),
    typeof(Priority3Code),
    typeof(Priority2Code),
    typeof(Priority5Code)
)]
public enum PriorityCode
{
    /// <summary>
    /// Priority level is urgent (highest priority possible).
    /// Encoded/decoded by serializers as &quot;URGT&quot;.
    /// </summary>
    [EnumMember(Value = "URGT")]
    [IsoId("_aKUc9dp-Ed-ak6NoX_4Aeg_-940450716")]
    [Description(@"Priority level is urgent (highest priority possible).")]
    Urgent,

    /// <summary>
    /// Priority level is high.
    /// Encoded/decoded by serializers as &quot;HIGH&quot;.
    /// </summary>
    [EnumMember(Value = "HIGH")]
    [IsoId("_aKUc9tp-Ed-ak6NoX_4Aeg_2036504741")]
    [Description(@"Priority level is high.")]
    High,

    /// <summary>
    /// Priority level is normal.
    /// Encoded/decoded by serializers as &quot;NORM&quot;.
    /// </summary>
    [EnumMember(Value = "NORM")]
    [IsoId("_aKUc99p-Ed-ak6NoX_4Aeg_-552715931")]
    [Description(@"Priority level is normal.")]
    Normal,

    /// <summary>
    /// Priority level is low.
    /// Encoded/decoded by serializers as &quot;LOWW&quot;.
    /// </summary>
    [EnumMember(Value = "LOWW")]
    [IsoId("_aKUc-Np-Ed-ak6NoX_4Aeg_2049436362")]
    [Description(@"Priority level is low.")]
    Low,
}
