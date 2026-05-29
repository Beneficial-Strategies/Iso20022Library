// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how a date is adjusted when it falls on a non-business day.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_heg90BfvEeSBdtDwJiNe1g")]
[Description(@"Specifies how a date is adjusted when it falls on a non-business day.")]
[Derivations(typeof(BusinessDayConvention2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BusinessDayConventionV2Code>))]
#endif
public enum BusinessDayConventionV2Code
{
    /// <summary>
    /// Floating rate note convention.
    /// Encoded/decoded by serializers as &quot;FRNC&quot;.
    /// </summary>
    [EnumMember(Value = "FRNC")]
    [IsoId("_4DkfJxfvEeSBdtDwJiNe1g")]
    [Description(@"Floating rate note convention.")]
    FloatingRateNoteConvention,

    /// <summary>
    /// Date will be the first following day that is a business day.
    /// Encoded/decoded by serializers as &quot;FWNG&quot;.
    /// </summary>
    [EnumMember(Value = "FWNG")]
    [IsoId("_4DkfJhfvEeSBdtDwJiNe1g")]
    [Description(@"Date will be the first following day that is a business day.")]
    Following,

    /// <summary>
    /// Date will be the first following day that is a business day unless that day falls in the next calendar month, in which case that date will be the first preceding day that is a business day.
    /// Encoded/decoded by serializers as &quot;MODF&quot;.
    /// </summary>
    [EnumMember(Value = "MODF")]
    [IsoId("_4DkfKBfvEeSBdtDwJiNe1g")]
    [Description(@"Date will be the first following day that is a business day unless that day falls in the next calendar month, in which case that date will be the first preceding day that is a business day.")]
    ModifiedFollowing,

    /// <summary>
    /// Date will be the first preceding day that is a business day unless that day falls on a day other than a sunday or a monday, and will be the first following day that is a business day, if the relevant date otherwise falls on a Sunday or a Monday.
    /// Encoded/decoded by serializers as &quot;NEAR&quot;.
    /// </summary>
    [EnumMember(Value = "NEAR")]
    [IsoId("_4DkfKRfvEeSBdtDwJiNe1g")]
    [Description(@"Date will be the first preceding day that is a business day unless that day falls on a day other than a sunday or a monday, and will be the first following day that is a business day, if the relevant date otherwise falls on a Sunday or a Monday.")]
    Nearest,

    /// <summary>
    /// Other business day convention.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_4DkfKhfvEeSBdtDwJiNe1g")]
    [Description(@"Other business day convention.")]
    Other,

    /// <summary>
    /// Non-business day will be adjusted to the first preceding day that is a business day.
    /// Encoded/decoded by serializers as &quot;PREC&quot;.
    /// </summary>
    [EnumMember(Value = "PREC")]
    [IsoId("_4DkfKxfvEeSBdtDwJiNe1g")]
    [Description(@"Non-business day will be adjusted to the first preceding day that is a business day.")]
    Preceding,
}
