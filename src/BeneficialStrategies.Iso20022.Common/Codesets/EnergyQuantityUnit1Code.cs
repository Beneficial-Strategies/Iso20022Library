// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an energy quantity unit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_agE0AA3fEeWc7_0KPiuk6w")]
[Description(@"Specifies an energy quantity unit.")]
[DerivedFrom(typeof(EnergyQuantityUnitCode))]
public enum EnergyQuantityUnit1Code
{
    /// <summary>
    /// Therm per day.
    /// Encoded/decoded by serializers as &quot;THMD&quot;.
    /// </summary>
    [EnumMember(Value = "THMD")]
    [IsoId("_1m7AcRYtEeWK8am9Oj92Tg")]
    [Description(@"Therm per day.")]
    ThermPerDay = EnergyQuantityUnitCode.ThermPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mega Watt hour per hour.
    /// Encoded/decoded by serializers as &quot;MWHH&quot;.
    /// </summary>
    [EnumMember(Value = "MWHH")]
    [IsoId("_1zjuQRYtEeWK8am9Oj92Tg")]
    [Description(@"Mega Watt hour per hour.")]
    MWhPerHour = EnergyQuantityUnitCode.MWhPerHour, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mega Watt hour per day.
    /// Encoded/decoded by serializers as &quot;MWHD&quot;.
    /// </summary>
    [EnumMember(Value = "MWHD")]
    [IsoId("_13uckRYtEeWK8am9Oj92Tg")]
    [Description(@"Mega Watt hour per day.")]
    MWhPerDay = EnergyQuantityUnitCode.MWhPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mega Watt.
    /// Encoded/decoded by serializers as &quot;MWAT&quot;.
    /// </summary>
    [EnumMember(Value = "MWAT")]
    [IsoId("_2EXxcRYtEeWK8am9Oj92Tg")]
    [Description(@"Mega Watt.")]
    MW = EnergyQuantityUnitCode.MW, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MTherm per day.
    /// Encoded/decoded by serializers as &quot;MTMD&quot;.
    /// </summary>
    [EnumMember(Value = "MTMD")]
    [IsoId("_2IifwRYtEeWK8am9Oj92Tg")]
    [Description(@"MTherm per day.")]
    MThermPerDay = EnergyQuantityUnitCode.MThermPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mcm per day.
    /// Encoded/decoded by serializers as &quot;MCMD&quot;.
    /// </summary>
    [EnumMember(Value = "MCMD")]
    [IsoId("_2VLNkRYtEeWK8am9Oj92Tg")]
    [Description(@"Mcm per day.")]
    MCMPerDay = EnergyQuantityUnitCode.MCMPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Kilo Watt hour per hour.
    /// Encoded/decoded by serializers as &quot;KWHH&quot;.
    /// </summary>
    [EnumMember(Value = "KWHH")]
    [IsoId("_2ZV74RYtEeWK8am9Oj92Tg")]
    [Description(@"Kilo Watt hour per hour.")]
    KWhPerHour = EnergyQuantityUnitCode.KWhPerHour, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Kilo Watt hour per day.
    /// Encoded/decoded by serializers as &quot;KWHD&quot;.
    /// </summary>
    [EnumMember(Value = "KWHD")]
    [IsoId("_2l1fwRYtEeWK8am9Oj92Tg")]
    [Description(@"Kilo Watt hour per day.")]
    KWhPerDay = EnergyQuantityUnitCode.KWhPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Kilo Watt.
    /// Encoded/decoded by serializers as &quot;KWAT&quot;.
    /// </summary>
    [EnumMember(Value = "KWAT")]
    [IsoId("_2yL5sRYtEeWK8am9Oj92Tg")]
    [Description(@"Kilo Watt.")]
    KW = EnergyQuantityUnitCode.KW, // same ordinal as derivation source for type conversions

    /// <summary>
    /// KTherm per day.
    /// Encoded/decoded by serializers as &quot;KTMD&quot;.
    /// </summary>
    [EnumMember(Value = "KTMD")]
    [IsoId("_22WoARYtEeWK8am9Oj92Tg")]
    [Description(@"KTherm per day.")]
    KThermPerDay = EnergyQuantityUnitCode.KThermPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Giga Watt hour per hour.
    /// Encoded/decoded by serializers as &quot;GWHH&quot;.
    /// </summary>
    [EnumMember(Value = "GWHH")]
    [IsoId("_3DJG0RYtEeWK8am9Oj92Tg")]
    [Description(@"Giga Watt hour per hour.")]
    GWhPerHour = EnergyQuantityUnitCode.GWhPerHour, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Giga Watt hour per day.
    /// Encoded/decoded by serializers as &quot;GWHD&quot;.
    /// </summary>
    [EnumMember(Value = "GWHD")]
    [IsoId("_3HT1IRYtEeWK8am9Oj92Tg")]
    [Description(@"Giga Watt hour per day.")]
    GWhPerDay = EnergyQuantityUnitCode.GWhPerDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Giga Watt.
    /// Encoded/decoded by serializers as &quot;GWAT&quot;.
    /// </summary>
    [EnumMember(Value = "GWAT")]
    [IsoId("_3TgeERYtEeWK8am9Oj92Tg")]
    [Description(@"Giga Watt.")]
    GW = EnergyQuantityUnitCode.GW, // same ordinal as derivation source for type conversions
}
