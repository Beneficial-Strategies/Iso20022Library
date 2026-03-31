// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of payment instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hi6RENxgEeioifFt1dhnJA")]
[Description(@"Type of payment instrument.")]
[DerivedFrom(typeof(PaymentInstrumentTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PaymentInstrumentType1Code>))]
#endif
public enum PaymentInstrumentType1Code
{
    /// <summary>
    /// Payment card (credit or debit).
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_jjj6MdxgEeioifFt1dhnJA")]
    [Description(@"Payment card (credit or debit).")]
    Card = PaymentInstrumentTypeCode.Card, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash managed by a cash handling system.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_jmi8wdxgEeioifFt1dhnJA")]
    [Description(@"Cash managed by a cash handling system.")]
    Cash = PaymentInstrumentTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Paper check.
    /// Encoded/decoded by serializers as &quot;CHCK&quot;.
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_jp2IYdxgEeioifFt1dhnJA")]
    [Description(@"Paper check.")]
    Check = PaymentInstrumentTypeCode.Check, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account using loyalty processing.
    /// Encoded/decoded by serializers as &quot;LOYT&quot;.
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_jt13kdxgEeioifFt1dhnJA")]
    [Description(@"Account using loyalty processing.")]
    LoyaltyAccount = PaymentInstrumentTypeCode.LoyaltyAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account accessed by a stored value instrument such as a card or a certificate.
    /// Encoded/decoded by serializers as &quot;SVAC&quot;.
    /// </summary>
    [EnumMember(Value = "SVAC")]
    [IsoId("_jxDjodxgEeioifFt1dhnJA")]
    [Description(@"Account accessed by a stored value instrument such as a card or a certificate.")]
    StoredValueAccount = PaymentInstrumentTypeCode.StoredValueAccount, // same ordinal as derivation source for type conversions
}
