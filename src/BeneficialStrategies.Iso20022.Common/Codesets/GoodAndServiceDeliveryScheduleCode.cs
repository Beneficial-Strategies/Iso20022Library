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
[IsoId("_gRwkkD5KEeyHI64WSlzTlg")]
[Description(@"Code that specifies the good or service delivery schedule.")]
[Derivations(typeof(GoodAndServiceDeliverySchedule1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<GoodAndServiceDeliveryScheduleCode>))]
#endif
public enum GoodAndServiceDeliveryScheduleCode
{
    /// <summary>
    /// Same day delivery.
    /// Encoded/decoded by serializers as &quot;SDDL&quot;.
    /// </summary>
    [EnumMember(Value = "SDDL")]
    [IsoId("_qfb5gD5KEeyHI64WSlzTlg")]
    [Description(@"Same day delivery.|")]
    SameDayDelivery,

    /// <summary>
    /// Overnight delivery.
    /// Encoded/decoded by serializers as &quot;ONDL&quot;.
    /// </summary>
    [EnumMember(Value = "ONDL")]
    [IsoId("_qn5R8D5KEeyHI64WSlzTlg")]
    [Description(@"Overnight delivery.")]
    OvernightDelivery,

    /// <summary>
    /// Two days or more delivery.
    /// Encoded/decoded by serializers as &quot;TDDL&quot;.
    /// </summary>
    [EnumMember(Value = "TDDL")]
    [IsoId("_qw9uYD5KEeyHI64WSlzTlg")]
    [Description(@"Two days or more delivery.")]
    TwoDaysOrMoreDelivery,

    /// <summary>
    /// Other delivery schedule defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_q7pUYD5KEeyHI64WSlzTlg")]
    [Description(@"Other delivery schedule defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// Other delivery schedule defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_rMSYcD5KEeyHI64WSlzTlg")]
    [Description(@"Other delivery schedule defined at national level.|")]
    OtherNational,
}
