// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identify the method of delivery or distribution.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DnQc8JVJEeWu36UkS2TkoQ")]
[Description(@"Identify the method of delivery or distribution.")]
[DerivedFrom(typeof(AttendanceContextCode))]
public enum AttendanceContext2Code
{
    /// <summary>
    /// Delivery by an attendant.
    /// Encoded/decoded by serializers as &quot;ATTL&quot;.
    /// </summary>
    [EnumMember(Value = "ATTL")]
    [IsoId("_f2LJwZVJEeWu36UkS2TkoQ")]
    [Description(@"Delivery by an attendant.")]
    AttendantDelivery = AttendanceContextCode.AttendantDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery by a carrier.
    /// Encoded/decoded by serializers as &quot;CARR&quot;.
    /// </summary>
    [EnumMember(Value = "CARR")]
    [IsoId("_f-q-cZVJEeWu36UkS2TkoQ")]
    [Description(@"Delivery by a carrier.")]
    CarrierDelivery = AttendanceContextCode.CarrierDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery by the customer.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_gRMR0ZVJEeWu36UkS2TkoQ")]
    [Description(@"Delivery by the customer.")]
    CustomerDelivery = AttendanceContextCode.CustomerDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Full service for fuel distribution.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_gcBo0ZVJEeWu36UkS2TkoQ")]
    [Description(@"Full service for fuel distribution.")]
    FullServe = AttendanceContextCode.FullServe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Self service for fuel distribution.
    /// Encoded/decoded by serializers as &quot;SELF&quot;.
    /// </summary>
    [EnumMember(Value = "SELF")]
    [IsoId("_gpQMgZVJEeWu36UkS2TkoQ")]
    [Description(@"Self service for fuel distribution.")]
    SelfServe = AttendanceContextCode.SelfServe, // same ordinal as derivation source for type conversions
}
