// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an energy quantity unit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Wps_YQ3fEeWc7_0KPiuk6w")]
[Description(@"Specifies an energy quantity unit.")]
[Derivations(typeof(EnergyQuantityUnit1Code), typeof(EnergyQuantityUnit2Code))]
public enum EnergyQuantityUnitCode
{
    /// <summary>
    /// Kilo Watt hour per hour.
    /// Encoded/decoded by serializers as &quot;KWHH&quot;.
    /// </summary>
    [EnumMember(Value = "KWHH")]
    [IsoId("_aTIUkBYsEeWK8am9Oj92Tg")]
    [Description(@"Kilo Watt hour per hour.")]
    KWhPerHour,

    /// <summary>
    /// Kilo Watt.
    /// Encoded/decoded by serializers as &quot;KWAT&quot;.
    /// </summary>
    [EnumMember(Value = "KWAT")]
    [IsoId("_ggqN0RYsEeWK8am9Oj92Tg")]
    [Description(@"Kilo Watt.")]
    KW,

    /// <summary>
    /// Kilo Watt hour per day.
    /// Encoded/decoded by serializers as &quot;KWHD&quot;.
    /// </summary>
    [EnumMember(Value = "KWHD")]
    [IsoId("_oaVf0RYsEeWK8am9Oj92Tg")]
    [Description(@"Kilo Watt hour per day.")]
    KWhPerDay,

    /// <summary>
    /// Mega Watt.
    /// Encoded/decoded by serializers as &quot;MWAT&quot;.
    /// </summary>
    [EnumMember(Value = "MWAT")]
    [IsoId("_wwItIxYsEeWK8am9Oj92Tg")]
    [Description(@"Mega Watt.")]
    MW,

    /// <summary>
    /// Mega Watt hour per day.
    /// Encoded/decoded by serializers as &quot;MWHD&quot;.
    /// </summary>
    [EnumMember(Value = "MWHD")]
    [IsoId("_wwItJBYsEeWK8am9Oj92Tg")]
    [Description(@"Mega Watt hour per day.")]
    MWhPerDay,

    /// <summary>
    /// Mega Watt hour per hour.
    /// Encoded/decoded by serializers as &quot;MWHH&quot;.
    /// </summary>
    [EnumMember(Value = "MWHH")]
    [IsoId("_wwItJRYsEeWK8am9Oj92Tg")]
    [Description(@"Mega Watt hour per hour.")]
    MWhPerHour,

    /// <summary>
    /// Giga Watt.
    /// Encoded/decoded by serializers as &quot;GWAT&quot;.
    /// </summary>
    [EnumMember(Value = "GWAT")]
    [IsoId("_xqdAUxYsEeWK8am9Oj92Tg")]
    [Description(@"Giga Watt.")]
    GW,

    /// <summary>
    /// Giga Watt hour per day.
    /// Encoded/decoded by serializers as &quot;GWHD&quot;.
    /// </summary>
    [EnumMember(Value = "GWHD")]
    [IsoId("_xqdAVBYsEeWK8am9Oj92Tg")]
    [Description(@"Giga Watt hour per day.")]
    GWhPerDay,

    /// <summary>
    /// Giga Watt hour per hour.
    /// Encoded/decoded by serializers as &quot;GWHH&quot;.
    /// </summary>
    [EnumMember(Value = "GWHH")]
    [IsoId("_xqdAVRYsEeWK8am9Oj92Tg")]
    [Description(@"Giga Watt hour per hour.")]
    GWhPerHour,

    /// <summary>
    /// Therm per day.
    /// Encoded/decoded by serializers as &quot;THMD&quot;.
    /// </summary>
    [EnumMember(Value = "THMD")]
    [IsoId("_H6hJEBYtEeWK8am9Oj92Tg")]
    [Description(@"Therm per day.")]
    ThermPerDay,

    /// <summary>
    /// MTherm per day.
    /// Encoded/decoded by serializers as &quot;MTMD&quot;.
    /// </summary>
    [EnumMember(Value = "MTMD")]
    [IsoId("_YtG8gRYtEeWK8am9Oj92Tg")]
    [Description(@"MTherm per day.")]
    MThermPerDay,

    /// <summary>
    /// KTherm per day.
    /// Encoded/decoded by serializers as &quot;KTMD&quot;.
    /// </summary>
    [EnumMember(Value = "KTMD")]
    [IsoId("_Zvm7URYtEeWK8am9Oj92Tg")]
    [Description(@"KTherm per day.")]
    KThermPerDay,

    /// <summary>
    /// Cm per day.
    /// Encoded/decoded by serializers as &quot;CMPD&quot;.
    /// </summary>
    [EnumMember(Value = "CMPD")]
    [IsoId("_aKF34RYtEeWK8am9Oj92Tg")]
    [Description(@"Cm per day.")]
    CMPerDay,

    /// <summary>
    /// Mcm per day.
    /// Encoded/decoded by serializers as &quot;MCMD&quot;.
    /// </summary>
    [EnumMember(Value = "MCMD")]
    [IsoId("_an2K4RYtEeWK8am9Oj92Tg")]
    [Description(@"Mcm per day.")]
    MCMPerDay,

    /// <summary>
    /// British Thermal Unit Per Day
    /// Encoded/decoded by serializers as &quot;BTUD&quot;.
    /// </summary>
    [EnumMember(Value = "BTUD")]
    [IsoId("_qdN2cCi9EeuKKc2MztSwPw")]
    [Description(@"British Thermal Unit Per Day")]
    BritishThermalUnitPerDay,

    /// <summary>
    /// Million British Thermal Unit Per Day.
    /// Encoded/decoded by serializers as &quot;MBTD&quot;.
    /// </summary>
    [EnumMember(Value = "MBTD")]
    [IsoId("_x95ZoCi9EeuKKc2MztSwPw")]
    [Description(@"Million British Thermal Unit Per Day.")]
    MillionBritishThermalUnitPerDay,

    /// <summary>
    /// MegaJoule Per Day.
    /// Encoded/decoded by serializers as &quot;MJDD&quot;.
    /// </summary>
    [EnumMember(Value = "MJDD")]
    [IsoId("_5qyM0Ci9EeuKKc2MztSwPw")]
    [Description(@"MegaJoule Per Day.")]
    MegaJoulePerDay,

    /// <summary>
    /// Hundred MegaJoule Per Day.
    /// Encoded/decoded by serializers as &quot;HMJD&quot;.
    /// </summary>
    [EnumMember(Value = "HMJD")]
    [IsoId("_A-OlQCi-EeuKKc2MztSwPw")]
    [Description(@"Hundred MegaJoule Per Day.")]
    HundredMegaJoulePerDay,

    /// <summary>
    /// Million MegaJoule Per Day.
    /// Encoded/decoded by serializers as &quot;MMJD&quot;.
    /// </summary>
    [EnumMember(Value = "MMJD")]
    [IsoId("_hXFi8Ci-EeuKKc2MztSwPw")]
    [Description(@"Million MegaJoule Per Day.")]
    MillionMegaJoulePerDay,

    /// <summary>
    /// GigaJoule Per Day.
    /// Encoded/decoded by serializers as &quot;GJDD&quot;.
    /// </summary>
    [EnumMember(Value = "GJDD")]
    [IsoId("_AzPn0Ci_EeuKKc2MztSwPw")]
    [Description(@"GigaJoule Per Day.")]
    GigaJoulePerDay,
}
