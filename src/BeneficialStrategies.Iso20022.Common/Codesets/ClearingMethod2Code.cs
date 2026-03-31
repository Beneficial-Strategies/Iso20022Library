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
[IsoId("_jfwVUFA7EeedyPuM0kK2EQ")]
[Description(@"Type of clearing method used for card payment services.")]
[DerivedFrom(typeof(ClearingMethodCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ClearingMethod2Code>))]
#endif
public enum ClearingMethod2Code
{
    /// <summary>
    /// Day clearing.
    /// Encoded/decoded by serializers as &quot;DAYC&quot;.
    /// </summary>
    [EnumMember(Value = "DAYC")]
    [IsoId("_CO0dUX0lEemfrNOe0zHQyg")]
    [Description(@"Day clearing.")]
    Day = ClearingMethodCode.Day, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Clearing to be deferred in time.
    /// Encoded/decoded by serializers as &quot;DFRD&quot;.
    /// </summary>
    [EnumMember(Value = "DFRD")]
    [IsoId("_CO0dU30lEemfrNOe0zHQyg")]
    [Description(@"Clearing to be deferred in time.")]
    Deferred = ClearingMethodCode.Deferred, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Clearing for instant payments and transfers.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_CO0dVX0lEemfrNOe0zHQyg")]
    [Description(@"Clearing for instant payments and transfers.")]
    Instant = ClearingMethodCode.Instant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of clearing method defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_CO0dV30lEemfrNOe0zHQyg")]
    [Description(@"Other type of clearing method defined at national level.")]
    OtherNational = ClearingMethodCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of clearing method defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_CO0dWX0lEemfrNOe0zHQyg")]
    [Description(@"Other type of clearing method defined at private level.")]
    OtherPrivate = ClearingMethodCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Clearing done in real time.
    /// Encoded/decoded by serializers as &quot;RLTM&quot;.
    /// </summary>
    [EnumMember(Value = "RLTM")]
    [IsoId("_CO0dW30lEemfrNOe0zHQyg")]
    [Description(@"Clearing done in real time.")]
    RealTime = ClearingMethodCode.RealTime, // same ordinal as derivation source for type conversions
}
