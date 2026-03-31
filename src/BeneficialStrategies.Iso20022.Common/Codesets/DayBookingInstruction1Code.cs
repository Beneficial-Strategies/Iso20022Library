// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes of the nature of execution booking process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aytSpNp-Ed-ak6NoX_4Aeg_1419752225")]
[Description(@"Describes of the nature of execution booking process.")]
[DerivedFrom(typeof(DayBookingInstructionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DayBookingInstruction1Code>))]
#endif
public enum DayBookingInstruction1Code
{
    /// <summary>
    /// Can trigger booking without reference to the order initiator.
    /// Encoded/decoded by serializers as &quot;AUTO&quot;.
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_aytSpdp-Ed-ak6NoX_4Aeg_1465007733")]
    [Description(@"Can trigger booking without reference to the order initiator.")]
    Auto = DayBookingInstructionCode.Auto, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Speak with order initiator before booking.
    /// Encoded/decoded by serializers as &quot;TALK&quot;.
    /// </summary>
    [EnumMember(Value = "TALK")]
    [IsoId("_aytSptp-Ed-ak6NoX_4Aeg_1465007750")]
    [Description(@"Speak with order initiator before booking.")]
    SpeakFirst = DayBookingInstructionCode.SpeakFirst, // same ordinal as derivation source for type conversions
}
