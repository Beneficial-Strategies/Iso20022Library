// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of clearing method used for card payment services.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_U4YxUW79EfC68Y4jZPNEug")]
[Description(@"Type of clearing method used for card payment services.")]
[DerivedFrom(typeof(ClearingMethodCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ClearingMethod3Code>))]
public enum ClearingMethod3Code
{
    /// <summary>
    /// Day clearing.
    /// Encoded/decoded by serializers as &quot;DAYC&quot;.
    /// </summary>
    [EnumMember(Value = "DAYC")]
    [IsoId("_U61BUW79EfC68Y4jZPNEug")]
    [Description(@"Day clearing.")]
    Day = ClearingMethodCode.Day,

    /// <summary>
    /// Clearing to be deferred in time.
    /// Encoded/decoded by serializers as &quot;DFRD&quot;.
    /// </summary>
    [EnumMember(Value = "DFRD")]
    [IsoId("_U61BU279EfC68Y4jZPNEug")]
    [Description(@"Clearing to be deferred in time.")]
    Deferred = ClearingMethodCode.Deferred,

    /// <summary>
    /// Clearing for instant payments and transfers.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_U61BVW79EfC68Y4jZPNEug")]
    [Description(@"Clearing for instant payments and transfers.")]
    Instant = ClearingMethodCode.Instant,

    /// <summary>
    /// Clearing done in real time.
    /// Encoded/decoded by serializers as &quot;RLTM&quot;.
    /// </summary>
    [EnumMember(Value = "RLTM")]
    [IsoId("_U61BW279EfC68Y4jZPNEug")]
    [Description(@"Clearing done in real time.")]
    RealTime = ClearingMethodCode.RealTime,
}
