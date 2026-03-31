// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the list of fleet service type codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uyzQgDEoEemzCpWiCwK4aQ")]
[Description(@"Contains the list of fleet service type codes.")]
[DerivedFrom(typeof(FleetServiceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FleetServiceType1Code>))]
#endif
public enum FleetServiceType1Code
{
    /// <summary>
    /// Self service
    /// Encoded/decoded by serializers as &quot;SLSV&quot;.
    /// </summary>
    [EnumMember(Value = "SLSV")]
    [IsoId("_1wy9YTEoEemzCpWiCwK4aQ")]
    [Description(@"Self service")]
    SelfService = FleetServiceTypeCode.SelfService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// High speed dispenser that may or may not support varying flow rates.
    /// Encoded/decoded by serializers as &quot;HSDI&quot;.
    /// </summary>
    [EnumMember(Value = "HSDI")]
    [IsoId("_2FW4ITEoEemzCpWiCwK4aQ")]
    [Description(@"High speed dispenser that may or may not support varying flow rates. ")]
    HighSpeedDispenser = FleetServiceTypeCode.HighSpeedDispenser, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Full service
    /// Encoded/decoded by serializers as &quot;FLSV&quot;.
    /// </summary>
    [EnumMember(Value = "FLSV")]
    [IsoId("_2cwrgTEoEemzCpWiCwK4aQ")]
    [Description(@"Full service")]
    FullService = FleetServiceTypeCode.FullService, // same ordinal as derivation source for type conversions
}
