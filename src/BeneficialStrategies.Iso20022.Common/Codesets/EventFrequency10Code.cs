// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9DnqYCDUEeWCLu74WLgP4w")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(EventFrequencyCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EventFrequency10Code>))]
#endif
public enum EventFrequency10Code
{
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_ASy8ISDVEeWCLu74WLgP4w")]
    [Description(@"Event takes place every day.")]
    Daily = EventFrequencyCode.Daily, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place as necessary.
    /// Encoded/decoded by serializers as &quot;ADHO&quot;.
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_Aryq8SDVEeWCLu74WLgP4w")]
    [Description(@"Event takes place as necessary.")]
    Adhoc = EventFrequencyCode.Adhoc, // same ordinal as derivation source for type conversions
}
