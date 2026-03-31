// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the trigger code used by the sender to generate the file.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0bBW4MmLEeWAGphE2LvqeA")]
[Description(@"Specifies the trigger code used by the sender to generate the file.")]
[DerivedFrom(typeof(SenderTriggerCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SenderTrigger1Code>))]
#endif
public enum SenderTrigger1Code
{
    /// <summary>
    /// File generated based on a date/time event.
    /// Encoded/decoded by serializers as &quot;DTTM&quot;.
    /// </summary>
    [EnumMember(Value = "DTTM")]
    [IsoId("_sdhbYcm4EeWAGphE2LvqeA")]
    [Description(@"File generated based on a date/time event.")]
    DateTime = SenderTriggerCode.DateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File generated based on a manual event (file has been
    /// generated manually).
    /// Encoded/decoded by serializers as &quot;MANL&quot;.
    /// </summary>
    [EnumMember(Value = "MANL")]
    [IsoId("_sx6XAcm4EeWAGphE2LvqeA")]
    [Description(@"File generated based on a manual event (file has been|generated manually).")]
    Manual = SenderTriggerCode.Manual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File generated based on a signature event (file has the minimum required signature from the sender).
    /// Encoded/decoded by serializers as &quot;SFSG&quot;.
    /// </summary>
    [EnumMember(Value = "SFSG")]
    [IsoId("_s8U3Qsm4EeWAGphE2LvqeA")]
    [Description(
        @"File generated based on a signature event (file has the minimum required signature from the sender)."
    )]
    SufficientlySigned = SenderTriggerCode.SufficientlySigned, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File generated based on a forced event (file generation has been forced).
    /// Encoded/decoded by serializers as &quot;FRCD&quot;.
    /// </summary>
    [EnumMember(Value = "FRCD")]
    [IsoId("_s9gjAcm4EeWAGphE2LvqeA")]
    [Description(@"File generated based on a forced event (file generation has been forced).")]
    Forced = SenderTriggerCode.Forced, // same ordinal as derivation source for type conversions
}
