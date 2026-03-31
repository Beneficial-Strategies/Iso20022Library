// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to be performed by the point of interaction (POI).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3I4WYTGeEeO118ZQJgaQSQ")]
[Description(@"Type of action to be performed by the point of interaction (POI).")]
[DerivedFrom(typeof(ActionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ActionType3Code>))]
#endif
public enum ActionType3Code
{
    /// <summary>
    /// Server busy, try later.
    /// Encoded/decoded by serializers as &quot;BUSY&quot;.
    /// </summary>
    [EnumMember(Value = "BUSY")]
    [IsoId("_3ZsZkTGeEeO118ZQJgaQSQ")]
    [Description(@"Server busy, try later.")]
    Busy = ActionTypeCode.Busy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as &quot;CPTR&quot;.
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_3ZsZkzGeEeO118ZQJgaQSQ")]
    [Description(@"Capture the card.")]
    CaptureCard = ActionTypeCode.CaptureCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message to display, print or log.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_3ZsZlTGeEeO118ZQJgaQSQ")]
    [Description(@"Message to display, print or log.")]
    DisplayMessage = ActionTypeCode.DisplayMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment application cannot propose to the merchant an override of the payment transaction.
    /// Encoded/decoded by serializers as &quot;NOVR&quot;.
    /// </summary>
    [EnumMember(Value = "NOVR")]
    [IsoId("_3ZsZlzGeEeO118ZQJgaQSQ")]
    [Description(
        @"Payment application cannot propose to the merchant an override of the payment transaction."
    )]
    ForbidOverride = ActionTypeCode.ForbidOverride, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional identification required (passport, ID card, etc.).
    /// Encoded/decoded by serializers as &quot;RQID&quot;.
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("_3ZsZmTGeEeO118ZQJgaQSQ")]
    [Description(@"Additional identification required (passport, ID card, etc.).")]
    IdentificationRequired = ActionTypeCode.IdentificationRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Last PIN (Personal Identification Number) try.
    /// Encoded/decoded by serializers as &quot;PINL&quot;.
    /// </summary>
    [EnumMember(Value = "PINL")]
    [IsoId("_3ZsZmzGeEeO118ZQJgaQSQ")]
    [Description(@"Last PIN (Personal Identification Number) try.")]
    PINLastTry = ActionTypeCode.PINLastTry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN (Personal Identification Number) is wrong, retry a PIN verification.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_3ZsZnTGeEeO118ZQJgaQSQ")]
    [Description(@"PIN (Personal Identification Number) is wrong, retry a PIN verification.")]
    PINRetry = ActionTypeCode.PINRetry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Print a message.
    /// Encoded/decoded by serializers as &quot;PRNT&quot;.
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_3ZsZnzGeEeO118ZQJgaQSQ")]
    [Description(@"Print a message.")]
    PrintMessage = ActionTypeCode.PrintMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Referral has to be performed.
    /// Encoded/decoded by serializers as &quot;RFRL&quot;.
    /// </summary>
    [EnumMember(Value = "RFRL")]
    [IsoId("_3ZsZoTGeEeO118ZQJgaQSQ")]
    [Description(@"Referral has to be performed.")]
    Referral = ActionTypeCode.Referral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request additional data through a displayed text and request confirmation by an attendant.
    /// Encoded/decoded by serializers as &quot;RQDT&quot;.
    /// </summary>
    [EnumMember(Value = "RQDT")]
    [IsoId("_3ZsZozGeEeO118ZQJgaQSQ")]
    [Description(
        @"Request additional data through a displayed text and request confirmation by an attendant."
    )]
    RequestData = ActionTypeCode.RequestData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ask the cardholder to accept the currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_450IgTGeEeO118ZQJgaQSQ")]
    [Description(@"Ask the cardholder to accept the currency conversion.")]
    AcceptCurrencyConversion = ActionTypeCode.AcceptCurrencyConversion, // same ordinal as derivation source for type conversions
}
