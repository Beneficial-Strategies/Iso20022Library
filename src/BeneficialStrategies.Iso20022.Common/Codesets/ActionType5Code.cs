// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to be performed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YAeyAHuYEeSVeNXcmBQ4hQ")]
[Description(@"Type of action to be performed.")]
[DerivedFrom(typeof(ActionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ActionType5Code>))]
#endif
public enum ActionType5Code
{
    /// <summary>
    /// Server busy, try later.
    /// Encoded/decoded by serializers as &quot;BUSY&quot;.
    /// </summary>
    [EnumMember(Value = "BUSY")]
    [IsoId("_cEJbwXuYEeSVeNXcmBQ4hQ")]
    [Description(@"Server busy, try later.")]
    Busy = ActionTypeCode.Busy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as &quot;CPTR&quot;.
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_cNY3U3uYEeSVeNXcmBQ4hQ")]
    [Description(@"Capture the card.")]
    CaptureCard = ActionTypeCode.CaptureCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message to display, print or log.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_cc4r43uYEeSVeNXcmBQ4hQ")]
    [Description(@"Message to display, print or log.")]
    DisplayMessage = ActionTypeCode.DisplayMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment application cannot propose to the merchant an override of the payment transaction.
    /// Encoded/decoded by serializers as &quot;NOVR&quot;.
    /// </summary>
    [EnumMember(Value = "NOVR")]
    [IsoId("_dZ0OM3uYEeSVeNXcmBQ4hQ")]
    [Description(
        @"Payment application cannot propose to the merchant an override of the payment transaction."
    )]
    ForbidOverride = ActionTypeCode.ForbidOverride, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional identification required (passport, ID card, etc.).
    /// Encoded/decoded by serializers as &quot;RQID&quot;.
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("_djpfo3uYEeSVeNXcmBQ4hQ")]
    [Description(@"Additional identification required (passport, ID card, etc.).")]
    IdentificationRequired = ActionTypeCode.IdentificationRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Last PIN (Personal Identification Number) try.
    /// Encoded/decoded by serializers as &quot;PINL&quot;.
    /// </summary>
    [EnumMember(Value = "PINL")]
    [IsoId("_exd9o3uYEeSVeNXcmBQ4hQ")]
    [Description(@"Last PIN (Personal Identification Number) try.")]
    PINLastTry = ActionTypeCode.PINLastTry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN (Personal Identification Number) is wrong, retry a PIN verification.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_e5qQU3uYEeSVeNXcmBQ4hQ")]
    [Description(@"PIN (Personal Identification Number) is wrong, retry a PIN verification.")]
    PINRetry = ActionTypeCode.PINRetry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Print a message.
    /// Encoded/decoded by serializers as &quot;PRNT&quot;.
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_fAhGQ3uYEeSVeNXcmBQ4hQ")]
    [Description(@"Print a message.")]
    PrintMessage = ActionTypeCode.PrintMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Referral has to be performed.
    /// Encoded/decoded by serializers as &quot;RFRL&quot;.
    /// </summary>
    [EnumMember(Value = "RFRL")]
    [IsoId("_f_w8w3uYEeSVeNXcmBQ4hQ")]
    [Description(@"Referral has to be performed.")]
    Referral = ActionTypeCode.Referral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request additional data through a displayed text and request confirmation by an attendant.
    /// Encoded/decoded by serializers as &quot;RQDT&quot;.
    /// </summary>
    [EnumMember(Value = "RQDT")]
    [IsoId("_hcqYk3uYEeSVeNXcmBQ4hQ")]
    [Description(
        @"Request additional data through a displayed text and request confirmation by an attendant."
    )]
    RequestData = ActionTypeCode.RequestData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Track provided in the response must be updated on the card.
    /// Encoded/decoded by serializers as &quot;TRCK&quot;.
    /// </summary>
    [EnumMember(Value = "TRCK")]
    [IsoId("_h-CnU3uYEeSVeNXcmBQ4hQ")]
    [Description(@"Track provided in the response must be updated on the card.")]
    UpdateTrack = ActionTypeCode.UpdateTrack, // same ordinal as derivation source for type conversions
}
