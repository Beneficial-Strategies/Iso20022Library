// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code that specifies the good or service delivery schedule.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rEt8Bo16EfC7DL86GVtK-Q")]
[Description(@"Code that specifies the good or service delivery schedule.")]
[Derivations(typeof(GoodAndServiceDeliverySchedule2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<GoodAndServiceDeliveryScheduleV2Code>))]
public enum GoodAndServiceDeliveryScheduleV2Code
{
    /// <summary>
    /// Overnight delivery.
    /// Encoded/decoded by serializers as &quot;ONDL&quot;.
    /// </summary>
    [EnumMember(Value = "ONDL")]
    [IsoId("_rEt8CI16EfC7DL86GVtK-Q")]
    [Description(@"Overnight delivery.")]
    OvernightDelivery,

    /// <summary>
    /// Other delivery schedule defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_rEt8B416EfC7DL86GVtK-Q")]
    [Description(@"Other delivery schedule defined at national level.")]
    OtherNational,

    /// <summary>
    /// Other delivery schedule defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_rEt8C416EfC7DL86GVtK-Q")]
    [Description(@"Other delivery schedule defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// Same day delivery.
    /// Encoded/decoded by serializers as &quot;SDDL&quot;.
    /// </summary>
    [EnumMember(Value = "SDDL")]
    [IsoId("_rEt8Co16EfC7DL86GVtK-Q")]
    [Description(@"Same day delivery.")]
    SameDayDelivery,

    /// <summary>
    /// Two days or more delivery.
    /// Encoded/decoded by serializers as &quot;TDDL&quot;.
    /// </summary>
    [EnumMember(Value = "TDDL")]
    [IsoId("_rEt8CY16EfC7DL86GVtK-Q")]
    [Description(@"Two days or more delivery.")]
    TwoDaysOrMoreDelivery,
}
