// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the status of the occurrence of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ajNeEdp-Ed-ak6NoX_4Aeg_-477138119")]
[Description(@"Indicates the status of the occurrence of an event.")]
[DerivedFrom(typeof(EventConfirmationStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EventConfirmationStatus1Code>))]
#endif
public enum EventConfirmationStatus1Code
{
    /// <summary>
    /// Occurrence of the event has been confirmed.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_ajNeEtp-Ed-ak6NoX_4Aeg_-181611544")]
    [Description(@"Occurrence of the event has been confirmed.")]
    Confirmed = EventConfirmationStatusCode.Confirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Occurrence of the event has not been confirmed.
    /// Encoded/decoded by serializers as &quot;UCON&quot;.
    /// </summary>
    [EnumMember(Value = "UCON")]
    [IsoId("_ajNeE9p-Ed-ak6NoX_4Aeg_-176071125")]
    [Description(@"Occurrence of the event has not been confirmed.")]
    Unconfirmed = EventConfirmationStatusCode.Unconfirmed, // same ordinal as derivation source for type conversions
}
