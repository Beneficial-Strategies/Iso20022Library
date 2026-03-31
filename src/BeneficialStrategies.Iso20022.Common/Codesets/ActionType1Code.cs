// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to be performed by the POI System.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TR6hggEcEeCQm6a_G2yO_w_-1866554273")]
[Description(@"Type of action to be performed by the POI System.")]
[DerivedFrom(typeof(ActionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ActionType1Code>))]
#endif
public enum ActionType1Code
{
    /// <summary>
    /// Message to display, print or log.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_TR6hgwEcEeCQm6a_G2yO_w_707859768")]
    [Description(@"Message to display, print or log.")]
    DisplayMessage = ActionTypeCode.DisplayMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Print a message.
    /// Encoded/decoded by serializers as &quot;PRNT&quot;.
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_TR6hhAEcEeCQm6a_G2yO_w_-1829270022")]
    [Description(@"Print a message.")]
    PrintMessage = ActionTypeCode.PrintMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Referral has to be performed.
    /// Encoded/decoded by serializers as &quot;RFRL&quot;.
    /// </summary>
    [EnumMember(Value = "RFRL")]
    [IsoId("_TR6hhQEcEeCQm6a_G2yO_w_107955151")]
    [Description(@"Referral has to be performed.")]
    Referral = ActionTypeCode.Referral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as &quot;CPTR&quot;.
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_TR6hhgEcEeCQm6a_G2yO_w_-1550000880")]
    [Description(@"Capture the card.")]
    CaptureCard = ActionTypeCode.CaptureCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN (Personal Identification Number) is wrong, retry a PIN verification.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_TR6hhwEcEeCQm6a_G2yO_w_1672961357")]
    [Description(@"PIN (Personal Identification Number) is wrong, retry a PIN verification.")]
    PINRetry = ActionTypeCode.PINRetry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Last PIN (Personal Identification Number) try.
    /// Encoded/decoded by serializers as &quot;PINL&quot;.
    /// </summary>
    [EnumMember(Value = "PINL")]
    [IsoId("_TR6hiAEcEeCQm6a_G2yO_w_-684780766")]
    [Description(@"Last PIN (Personal Identification Number) try.")]
    PINLastTry = ActionTypeCode.PINLastTry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request additional data through a displayed text and request confirmation by an attendant.
    /// Encoded/decoded by serializers as &quot;RQDT&quot;.
    /// </summary>
    [EnumMember(Value = "RQDT")]
    [IsoId("_TR6hiQEcEeCQm6a_G2yO_w_1355184696")]
    [Description(
        @"Request additional data through a displayed text and request confirmation by an attendant."
    )]
    RequestData = ActionTypeCode.RequestData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Server busy, try later.
    /// Encoded/decoded by serializers as &quot;BUSY&quot;.
    /// </summary>
    [EnumMember(Value = "BUSY")]
    [IsoId("_TR6higEcEeCQm6a_G2yO_w_-1002557427")]
    [Description(@"Server busy, try later.")]
    Busy = ActionTypeCode.Busy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional identification required (passport, ID card, etc.).
    /// Encoded/decoded by serializers as &quot;RQID&quot;.
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("_TR6hiwEcEeCQm6a_G2yO_w_2115949849")]
    [Description(@"Additional identification required (passport, ID card, etc.).")]
    IdentificationRequired = ActionTypeCode.IdentificationRequired, // same ordinal as derivation source for type conversions
}
