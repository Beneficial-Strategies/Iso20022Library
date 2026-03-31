// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aLED19p-Ed-ak6NoX_4Aeg_-1833350814")]
[Description(@"Specifies the processing status.")]
[DerivedFrom(typeof(ProcessingStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ProcessingStatus1Code>))]
#endif
public enum ProcessingStatus1Code
{
    /// <summary>
    /// Message contains complete details of the corporate action event at the time the event is communicated and the occurrence of the event has been confirmed by the account servicer&apos;s chosen official source. Further updates to the event are still possible.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_aLED2Np-Ed-ak6NoX_4Aeg_-1833350782")]
    [Description(
        @"Message contains complete details of the corporate action event at the time the event is communicated and the occurrence of the event has been confirmed by the account servicer's chosen official source. Further updates to the event are still possible."
    )]
    Complete = ProcessingStatusCode.Complete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message may not contain complete details of the corporate action event,|however, the occurrence of the event is confirmed.
    /// Encoded/decoded by serializers as &quot;PREC&quot;.
    /// </summary>
    [EnumMember(Value = "PREC")]
    [IsoId("_aLN00Np-Ed-ak6NoX_4Aeg_-1833350781")]
    [Description(
        @"Message may not contain complete details of the corporate action event,|however, the occurrence of the event is confirmed."
    )]
    PreliminaryConfirmed = ProcessingStatusCode.PreliminaryConfirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message may not contain complete details of the corporate action event and|the occurrence of the event is not yet confirmed.
    /// Encoded/decoded by serializers as &quot;PREU&quot;.
    /// </summary>
    [EnumMember(Value = "PREU")]
    [IsoId("_aLN00dp-Ed-ak6NoX_4Aeg_-1833350780")]
    [Description(
        @"Message may not contain complete details of the corporate action event and|the occurrence of the event is not yet confirmed."
    )]
    PreliminaryUnconfirmed = ProcessingStatusCode.PreliminaryUnconfirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The message is for information only.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_aLN00tp-Ed-ak6NoX_4Aeg_-1833350752")]
    [Description(@"The message is for information only.")]
    ForInformationOnly = ProcessingStatusCode.ForInformationOnly, // same ordinal as derivation source for type conversions
}
