// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code that specifies the good or service delivery schedule.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UqvosD5LEeyHI64WSlzTlg")]
[Description(@"Code that specifies the good or service delivery schedule.")]
[DerivedFrom(typeof(GoodAndServiceDeliveryScheduleCode))]
public enum GoodAndServiceDeliverySchedule1Code
{
    /// <summary>
    /// Other delivery schedule defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_XHWOAT5LEeyHI64WSlzTlg")]
    [Description(@"Other delivery schedule defined at national level.|")]
    OtherNational = GoodAndServiceDeliveryScheduleCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other delivery schedule defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_XMX38T5LEeyHI64WSlzTlg")]
    [Description(@"Other delivery schedule defined at private level.")]
    OtherPrivate = GoodAndServiceDeliveryScheduleCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Overnight delivery.
    /// Encoded/decoded by serializers as &quot;ONDL&quot;.
    /// </summary>
    [EnumMember(Value = "ONDL")]
    [IsoId("_XQlpkT5LEeyHI64WSlzTlg")]
    [Description(@"Overnight delivery.")]
    OvernightDelivery = GoodAndServiceDeliveryScheduleCode.OvernightDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Same day delivery.
    /// Encoded/decoded by serializers as &quot;SDDL&quot;.
    /// </summary>
    [EnumMember(Value = "SDDL")]
    [IsoId("_XW6UAT5LEeyHI64WSlzTlg")]
    [Description(@"Same day delivery.|")]
    SameDayDelivery = GoodAndServiceDeliveryScheduleCode.SameDayDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Two days or more delivery.
    /// Encoded/decoded by serializers as &quot;TDDL&quot;.
    /// </summary>
    [EnumMember(Value = "TDDL")]
    [IsoId("_XalTET5LEeyHI64WSlzTlg")]
    [Description(@"Two days or more delivery.")]
    TwoDaysOrMoreDelivery = GoodAndServiceDeliveryScheduleCode.TwoDaysOrMoreDelivery, // same ordinal as derivation source for type conversions
    
}
