// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of codes representing type of fleet purchases.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hoJpkDEnEemzCpWiCwK4aQ")]
[Description(@"List of codes representing type of fleet purchases.")]
[DerivedFrom(typeof(FleetPurchaseTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FleetPurchaseType1Code>))]
#endif
public enum FleetPurchaseType1Code
{
    /// <summary>
    /// Fuel
    /// Encoded/decoded by serializers as &quot;FUEL&quot;.
    /// </summary>
    [EnumMember(Value = "FUEL")]
    [IsoId("_knUwcTEnEemzCpWiCwK4aQ")]
    [Description(@"Fuel")]
    Fuel = FleetPurchaseTypeCode.Fuel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Non fuel
    /// Encoded/decoded by serializers as &quot;NONF&quot;.
    /// </summary>
    [EnumMember(Value = "NONF")]
    [IsoId("_lSZGsTEnEemzCpWiCwK4aQ")]
    [Description(@"Non fuel")]
    NonFuel = FleetPurchaseTypeCode.NonFuel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fuel and non fuel
    /// Encoded/decoded by serializers as &quot;FANF&quot;.
    /// </summary>
    [EnumMember(Value = "FANF")]
    [IsoId("_lomAMTEnEemzCpWiCwK4aQ")]
    [Description(@"Fuel and non fuel")]
    FuelAndNonFuel = FleetPurchaseTypeCode.FuelAndNonFuel, // same ordinal as derivation source for type conversions
}
