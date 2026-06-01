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
[IsoId("_2zX7gI16EfC7DL86GVtK-Q")]
[Description(@"Code that specifies the good or service delivery schedule.")]
[DerivedFrom(typeof(GoodAndServiceDeliveryScheduleV2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<GoodAndServiceDeliverySchedule2Code>))]
public enum GoodAndServiceDeliverySchedule2Code
{
    /// <summary>
    /// Overnight delivery.
    /// Encoded/decoded by serializers as &quot;ONDL&quot;.
    /// </summary>
    [EnumMember(Value = "ONDL")]
    [IsoId("_Nb-gEY17EfC7DL86GVtK-Q")]
    [Description(@"Overnight delivery.")]
    OvernightDelivery = GoodAndServiceDeliveryScheduleV2Code.OvernightDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Same day delivery.
    /// Encoded/decoded by serializers as &quot;SDDL&quot;.
    /// </summary>
    [EnumMember(Value = "SDDL")]
    [IsoId("_N6Ta0Y17EfC7DL86GVtK-Q")]
    [Description(@"Same day delivery.")]
    SameDayDelivery = GoodAndServiceDeliveryScheduleV2Code.SameDayDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Two days or more delivery.
    /// Encoded/decoded by serializers as &quot;TDDL&quot;.
    /// </summary>
    [EnumMember(Value = "TDDL")]
    [IsoId("_Odg1kY17EfC7DL86GVtK-Q")]
    [Description(@"Two days or more delivery.")]
    TwoDaysOrMoreDelivery = GoodAndServiceDeliveryScheduleV2Code.TwoDaysOrMoreDelivery, // same ordinal as derivation source for type conversions
}
