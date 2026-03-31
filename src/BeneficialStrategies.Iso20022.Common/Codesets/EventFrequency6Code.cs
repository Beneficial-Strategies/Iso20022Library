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
[IsoId("_YZq-sNp-Ed-ak6NoX_4Aeg_-209191195")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(EventFrequencyCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EventFrequency6Code>))]
#endif
public enum EventFrequency6Code
{
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_YZq-sdp-Ed-ak6NoX_4Aeg_903765456")]
    [Description(@"Event takes place every day.")]
    Daily = EventFrequencyCode.Daily, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place several times a day.
    /// Encoded/decoded by serializers as &quot;INDA&quot;.
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_YZq-stp-Ed-ak6NoX_4Aeg_699827861")]
    [Description(@"Event takes place several times a day.")]
    IntraDay = EventFrequencyCode.IntraDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place on demand.
    /// Encoded/decoded by serializers as &quot;ONDE&quot;.
    /// </summary>
    [EnumMember(Value = "ONDE")]
    [IsoId("_YZq-s9p-Ed-ak6NoX_4Aeg_-652104133")]
    [Description(@"Event takes place on demand.")]
    OnDemand = EventFrequencyCode.OnDemand, // same ordinal as derivation source for type conversions
}
