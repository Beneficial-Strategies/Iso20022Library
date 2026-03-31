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
[IsoId("_9zEEI_jUEeiM7KpzmLtmTQ")]
[Description(@"Contains the list of fleet service type codes.")]
[Derivations(typeof(FleetServiceType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FleetServiceTypeCode>))]
#endif
public enum FleetServiceTypeCode
{
    /// <summary>
    /// Full service
    /// Encoded/decoded by serializers as &quot;FLSV&quot;.
    /// </summary>
    [EnumMember(Value = "FLSV")]
    [IsoId("_9zEEJfjUEeiM7KpzmLtmTQ")]
    [Description(@"Full service")]
    FullService,

    /// <summary>
    /// Self service
    /// Encoded/decoded by serializers as &quot;SLSV&quot;.
    /// </summary>
    [EnumMember(Value = "SLSV")]
    [IsoId("_9zEEJPjUEeiM7KpzmLtmTQ")]
    [Description(@"Self service")]
    SelfService,

    /// <summary>
    /// High speed dispenser that may or may not support varying flow rates.
    /// Encoded/decoded by serializers as &quot;HSDI&quot;.
    /// </summary>
    [EnumMember(Value = "HSDI")]
    [IsoId("_itg-sP2sEeiS2rs-hXBB5Q")]
    [Description(@"High speed dispenser that may or may not support varying flow rates. ")]
    HighSpeedDispenser,
}
