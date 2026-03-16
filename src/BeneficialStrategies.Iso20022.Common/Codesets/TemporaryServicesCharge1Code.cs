// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Charge types for temporary services
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3qdwkDEvEemzCpWiCwK4aQ")]
[Description(@"Charge types for temporary services")]
[DerivedFrom(typeof(TemporaryServicesChargeCode))]
public enum TemporaryServicesCharge1Code
{
    /// <summary>
    /// Weekend
    /// Encoded/decoded by serializers as &quot;WKND&quot;.
    /// </summary>
    [EnumMember(Value = "WKND")]
    [IsoId("_8LRpUTEvEemzCpWiCwK4aQ")]
    [Description(@"Weekend")]
    Weekend = TemporaryServicesChargeCode.Weekend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Regular
    /// Encoded/decoded by serializers as &quot;REGL&quot;.
    /// </summary>
    [EnumMember(Value = "REGL")]
    [IsoId("_8fsaITEvEemzCpWiCwK4aQ")]
    [Description(@"Regular")]
    Regular = TemporaryServicesChargeCode.Regular, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Overtime
    /// Encoded/decoded by serializers as &quot;OVRT&quot;.
    /// </summary>
    [EnumMember(Value = "OVRT")]
    [IsoId("_8gvjATEvEemzCpWiCwK4aQ")]
    [Description(@"Overtime")]
    Overtime = TemporaryServicesChargeCode.Overtime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_8oV_0TEvEemzCpWiCwK4aQ")]
    [Description(@"Other Private")]
    OtherPrivate = TemporaryServicesChargeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_83--UTEvEemzCpWiCwK4aQ")]
    [Description(@"Other National")]
    OtherNational = TemporaryServicesChargeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// On call
    /// Encoded/decoded by serializers as &quot;ONCL&quot;.
    /// </summary>
    [EnumMember(Value = "ONCL")]
    [IsoId("_844WMTEvEemzCpWiCwK4aQ")]
    [Description(@"On call")]
    OnCall = TemporaryServicesChargeCode.OnCall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Night
    /// Encoded/decoded by serializers as &quot;NITE&quot;.
    /// </summary>
    [EnumMember(Value = "NITE")]
    [IsoId("_87j2wTEvEemzCpWiCwK4aQ")]
    [Description(@"Night")]
    Night = TemporaryServicesChargeCode.Night, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holiday
    /// Encoded/decoded by serializers as &quot;HOLI&quot;.
    /// </summary>
    [EnumMember(Value = "HOLI")]
    [IsoId("_9FG0UTEvEemzCpWiCwK4aQ")]
    [Description(@"Holiday")]
    Holiday = TemporaryServicesChargeCode.Holiday, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Hazard
    /// Encoded/decoded by serializers as &quot;HAZD&quot;.
    /// </summary>
    [EnumMember(Value = "HAZD")]
    [IsoId("_9Uc34TEvEemzCpWiCwK4aQ")]
    [Description(@"Hazard")]
    Hazard = TemporaryServicesChargeCode.Hazard, // same ordinal as derivation source for type conversions
}
