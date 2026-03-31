// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an energy quantity unit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fXdYECi_EeuKKc2MztSwPw")]
[Description(@"Specifies an energy quantity unit.")]
[DerivedFrom(typeof(EnergyQuantityUnitCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EnergyQuantityUnit2Code>))]
#endif
public enum EnergyQuantityUnit2Code
{
    /// <summary>
    /// British Thermal Unit Per Day
    /// Encoded/decoded by serializers as &quot;BTUD&quot;.
    /// </summary>
    [EnumMember(Value = "BTUD")]
    [IsoId("_kRrPUSi_EeuKKc2MztSwPw")]
    [Description(@"British Thermal Unit Per Day")]
    BritishThermalUnitPerDay = EnergyQuantityUnitCode.BritishThermalUnitPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cm per day.
    /// Encoded/decoded by serializers as &quot;CMPD&quot;.
    /// </summary>
    [EnumMember(Value = "CMPD")]
    [IsoId("_kYg3ISi_EeuKKc2MztSwPw")]
    [Description(@"Cm per day.")]
    CMPerDay = EnergyQuantityUnitCode.CMPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GigaJoule Per Day.
    /// Encoded/decoded by serializers as &quot;GJDD&quot;.
    /// </summary>
    [EnumMember(Value = "GJDD")]
    [IsoId("_kduHQSi_EeuKKc2MztSwPw")]
    [Description(@"GigaJoule Per Day.")]
    GigaJoulePerDay = EnergyQuantityUnitCode.GigaJoulePerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Giga Watt.
    /// Encoded/decoded by serializers as &quot;GWAT&quot;.
    /// </summary>
    [EnumMember(Value = "GWAT")]
    [IsoId("_kmDj4Si_EeuKKc2MztSwPw")]
    [Description(@"Giga Watt.")]
    GW = EnergyQuantityUnitCode.GW, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Giga Watt hour per day.
    /// Encoded/decoded by serializers as &quot;GWHD&quot;.
    /// </summary>
    [EnumMember(Value = "GWHD")]
    [IsoId("_krtf8Si_EeuKKc2MztSwPw")]
    [Description(@"Giga Watt hour per day.")]
    GWhPerDay = EnergyQuantityUnitCode.GWhPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Giga Watt hour per hour.
    /// Encoded/decoded by serializers as &quot;GWHH&quot;.
    /// </summary>
    [EnumMember(Value = "GWHH")]
    [IsoId("_kvudQSi_EeuKKc2MztSwPw")]
    [Description(@"Giga Watt hour per hour.")]
    GWhPerHour = EnergyQuantityUnitCode.GWhPerHour, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Hundred MegaJoule Per Day.
    /// Encoded/decoded by serializers as &quot;HMJD&quot;.
    /// </summary>
    [EnumMember(Value = "HMJD")]
    [IsoId("_k0fBcSi_EeuKKc2MztSwPw")]
    [Description(@"Hundred MegaJoule Per Day.")]
    HundredMegaJoulePerDay = EnergyQuantityUnitCode.HundredMegaJoulePerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// KTherm per day.
    /// Encoded/decoded by serializers as &quot;KTMD&quot;.
    /// </summary>
    [EnumMember(Value = "KTMD")]
    [IsoId("_k4y5sSi_EeuKKc2MztSwPw")]
    [Description(@"KTherm per day.")]
    KThermPerDay = EnergyQuantityUnitCode.KThermPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Kilo Watt.
    /// Encoded/decoded by serializers as &quot;KWAT&quot;.
    /// </summary>
    [EnumMember(Value = "KWAT")]
    [IsoId("_k8XyISi_EeuKKc2MztSwPw")]
    [Description(@"Kilo Watt.")]
    KW = EnergyQuantityUnitCode.KW, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Kilo Watt hour per day.
    /// Encoded/decoded by serializers as &quot;KWHD&quot;.
    /// </summary>
    [EnumMember(Value = "KWHD")]
    [IsoId("_lAigcSi_EeuKKc2MztSwPw")]
    [Description(@"Kilo Watt hour per day.")]
    KWhPerDay = EnergyQuantityUnitCode.KWhPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Kilo Watt hour per hour.
    /// Encoded/decoded by serializers as &quot;KWHH&quot;.
    /// </summary>
    [EnumMember(Value = "KWHH")]
    [IsoId("_lLZFkSi_EeuKKc2MztSwPw")]
    [Description(@"Kilo Watt hour per hour.")]
    KWhPerHour = EnergyQuantityUnitCode.KWhPerHour, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mcm per day.
    /// Encoded/decoded by serializers as &quot;MCMD&quot;.
    /// </summary>
    [EnumMember(Value = "MCMD")]
    [IsoId("_lQwGsSi_EeuKKc2MztSwPw")]
    [Description(@"Mcm per day.")]
    MCMPerDay = EnergyQuantityUnitCode.MCMPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MegaJoule Per Day.
    /// Encoded/decoded by serializers as &quot;MJDD&quot;.
    /// </summary>
    [EnumMember(Value = "MJDD")]
    [IsoId("_lVqb4Si_EeuKKc2MztSwPw")]
    [Description(@"MegaJoule Per Day.")]
    MegaJoulePerDay = EnergyQuantityUnitCode.MegaJoulePerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Million British Thermal Unit Per Day.
    /// Encoded/decoded by serializers as &quot;MBTD&quot;.
    /// </summary>
    [EnumMember(Value = "MBTD")]
    [IsoId("_lZ-UISi_EeuKKc2MztSwPw")]
    [Description(@"Million British Thermal Unit Per Day.")]
    MillionBritishThermalUnitPerDay = EnergyQuantityUnitCode.MillionBritishThermalUnitPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Million MegaJoule Per Day.
    /// Encoded/decoded by serializers as &quot;MMJD&quot;.
    /// </summary>
    [EnumMember(Value = "MMJD")]
    [IsoId("_lh3E0Si_EeuKKc2MztSwPw")]
    [Description(@"Million MegaJoule Per Day.")]
    MillionMegaJoulePerDay = EnergyQuantityUnitCode.MillionMegaJoulePerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MTherm per day.
    /// Encoded/decoded by serializers as &quot;MTMD&quot;.
    /// </summary>
    [EnumMember(Value = "MTMD")]
    [IsoId("_lotTsSi_EeuKKc2MztSwPw")]
    [Description(@"MTherm per day.")]
    MThermPerDay = EnergyQuantityUnitCode.MThermPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mega Watt.
    /// Encoded/decoded by serializers as &quot;MWAT&quot;.
    /// </summary>
    [EnumMember(Value = "MWAT")]
    [IsoId("_ltBL8Si_EeuKKc2MztSwPw")]
    [Description(@"Mega Watt.")]
    MW = EnergyQuantityUnitCode.MW, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mega Watt hour per day.
    /// Encoded/decoded by serializers as &quot;MWHD&quot;.
    /// </summary>
    [EnumMember(Value = "MWHD")]
    [IsoId("_lx7hISi_EeuKKc2MztSwPw")]
    [Description(@"Mega Watt hour per day.")]
    MWhPerDay = EnergyQuantityUnitCode.MWhPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mega Watt hour per hour.
    /// Encoded/decoded by serializers as &quot;MWHH&quot;.
    /// </summary>
    [EnumMember(Value = "MWHH")]
    [IsoId("_l2iUUSi_EeuKKc2MztSwPw")]
    [Description(@"Mega Watt hour per hour.")]
    MWhPerHour = EnergyQuantityUnitCode.MWhPerHour, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Therm per day.
    /// Encoded/decoded by serializers as &quot;THMD&quot;.
    /// </summary>
    [EnumMember(Value = "THMD")]
    [IsoId("_l8o8USi_EeuKKc2MztSwPw")]
    [Description(@"Therm per day.")]
    ThermPerDay = EnergyQuantityUnitCode.ThermPerDay, // same ordinal as derivation source for type conversions
}
