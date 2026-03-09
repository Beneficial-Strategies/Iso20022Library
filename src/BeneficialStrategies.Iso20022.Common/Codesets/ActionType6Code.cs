// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to be performed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uiwXYIqGEeSRT5rEzcAHEw")]
[Description(@"Type of action to be performed.")]
[DerivedFrom(typeof(ActionTypeCode))]
public enum ActionType6Code
{
    /// <summary>
    /// Ask the cardholder to accept the currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_2zwkQYqGEeSRT5rEzcAHEw")]
    [Description(@"Ask the cardholder to accept the currency conversion.")]
    AcceptCurrencyConversion = ActionTypeCode.AcceptCurrencyConversion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fees must be accepted.
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_2_O0cYqGEeSRT5rEzcAHEw")]
    [Description(@"Fees must be accepted.")]
    AcceptFees = ActionTypeCode.AcceptFees, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// MinimumAmount must be accepted.
    /// Encoded/decoded by serializers as &quot;HAMT&quot;.
    /// </summary>
    [EnumMember(Value = "HAMT")]
    [IsoId("_3FfNcYqGEeSRT5rEzcAHEw")]
    [Description(@"MinimumAmount must be accepted.")]
    AcceptHigherAmount = ActionTypeCode.AcceptHigherAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// MaximumAuthorisedAmount must be accepted.
    /// Encoded/decoded by serializers as &quot;LAMT&quot;.
    /// </summary>
    [EnumMember(Value = "LAMT")]
    [IsoId("_3KjToYqGEeSRT5rEzcAHEw")]
    [Description(@"MaximumAuthorisedAmount must be accepted.")]
    AcceptLowerAmount = ActionTypeCode.AcceptLowerAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Server busy, try later.
    /// Encoded/decoded by serializers as &quot;BUSY&quot;.
    /// </summary>
    [EnumMember(Value = "BUSY")]
    [IsoId("_3-SdsYqGEeSRT5rEzcAHEw")]
    [Description(@"Server busy, try later.")]
    Busy = ActionTypeCode.Busy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as &quot;CPTR&quot;.
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_4DgU4YqGEeSRT5rEzcAHEw")]
    [Description(@"Capture the card.")]
    CaptureCard = ActionTypeCode.CaptureCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message to display, print or log.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_4REPwYqGEeSRT5rEzcAHEw")]
    [Description(@"Message to display, print or log.")]
    DisplayMessage = ActionTypeCode.DisplayMessage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribute a coupon from the cassette of coupon.
    /// Encoded/decoded by serializers as &quot;CPNS&quot;.
    /// </summary>
    [EnumMember(Value = "CPNS")]
    [IsoId("_4eLesYqGEeSRT5rEzcAHEw")]
    [Description(@"Distribute a coupon from the cassette of coupon.")]
    DistributeCoupon = ActionTypeCode.DistributeCoupon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to be performed by the ATM.
    /// Encoded/decoded by serializers as &quot;RQST&quot;.
    /// </summary>
    [EnumMember(Value = "RQST")]
    [IsoId("_5TFGYYqGEeSRT5rEzcAHEw")]
    [Description(@"Request to be performed by the ATM.")]
    PerformRequest = ActionTypeCode.PerformRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Last PIN (Personal Identification Number) try.
    /// Encoded/decoded by serializers as &quot;PINL&quot;.
    /// </summary>
    [EnumMember(Value = "PINL")]
    [IsoId("_5ZWGcYqGEeSRT5rEzcAHEw")]
    [Description(@"Last PIN (Personal Identification Number) try.")]
    PINLastTry = ActionTypeCode.PINLastTry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN (Personal Identification Number) is wrong, retry a PIN verification.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_5gyyQYqGEeSRT5rEzcAHEw")]
    [Description(@"PIN (Personal Identification Number) is wrong, retry a PIN verification.")]
    PINRetry = ActionTypeCode.PINRetry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Track provided in the response must be updated on the card.
    /// Encoded/decoded by serializers as &quot;TRCK&quot;.
    /// </summary>
    [EnumMember(Value = "TRCK")]
    [IsoId("_TUF-8YqMEeSRT5rEzcAHEw")]
    [Description(@"Track provided in the response must be updated on the card.")]
    UpdateTrack = ActionTypeCode.UpdateTrack, // same ordinal as derivation source for type conversions
    
}
