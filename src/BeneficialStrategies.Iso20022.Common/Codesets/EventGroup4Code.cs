// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) processing domain for the event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_i8tCgAB8EeqouY-yI_q3qQ")]
[Description(@"Specifies DTC (The Depository Trust Company) processing domain for the event.")]
[DerivedFrom(typeof(EventGroupCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EventGroup4Code>))]
#endif
public enum EventGroup4Code
{
    /// <summary>
    /// Distribution domain events.
    /// Encoded/decoded by serializers as &quot;DISN&quot;.
    /// </summary>
    [EnumMember(Value = "DISN")]
    [IsoId("_mGuugQB8EeqouY-yI_q3qQ")]
    [Description(@"Distribution domain events.")]
    Distribution = EventGroupCode.Distribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// General domain events.
    /// Encoded/decoded by serializers as &quot;GENL&quot;.
    /// </summary>
    [EnumMember(Value = "GENL")]
    [IsoId("_mLWIwQB8EeqouY-yI_q3qQ")]
    [Description(@"General domain events.")]
    General = EventGroupCode.General, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Redemption domain events.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_mPg3EQB8EeqouY-yI_q3qQ")]
    [Description(@"Redemption domain events.")]
    Redemption = EventGroupCode.Redemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reorganization domain events.
    /// Encoded/decoded by serializers as &quot;REOR&quot;.
    /// </summary>
    [EnumMember(Value = "REOR")]
    [IsoId("_mT0vUQB8EeqouY-yI_q3qQ")]
    [Description(@"Reorganization domain events.")]
    Reorganization = EventGroupCode.Reorganization, // same ordinal as derivation source for type conversions
}
