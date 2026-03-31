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
[IsoId("_MoMKoNxgEeioifFt1dhnJA")]
[Description(@"Type of payment instrument.")]
[Derivations(typeof(PaymentInstrumentType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PaymentInstrumentTypeCode>))]
#endif
public enum PaymentInstrumentTypeCode
{
    /// <summary>
    /// Payment card (credit or debit).
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_SadrQNxgEeioifFt1dhnJA")]
    [Description(@"Payment card (credit or debit).")]
    Card,

    /// <summary>
    /// Paper check.
    /// Encoded/decoded by serializers as &quot;CHCK&quot;.
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_UlszwNxgEeioifFt1dhnJA")]
    [Description(@"Paper check.")]
    Check,

    /// <summary>
    /// Account accessed by a stored value instrument such as a card or a certificate.
    /// Encoded/decoded by serializers as &quot;SVAC&quot;.
    /// </summary>
    [EnumMember(Value = "SVAC")]
    [IsoId("_Wh6BwNxgEeioifFt1dhnJA")]
    [Description(@"Account accessed by a stored value instrument such as a card or a certificate.")]
    StoredValueAccount,

    /// <summary>
    /// Cash managed by a cash handling system.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_aoljQNxgEeioifFt1dhnJA")]
    [Description(@"Cash managed by a cash handling system.")]
    Cash,

    /// <summary>
    /// Account using loyalty processing.
    /// Encoded/decoded by serializers as &quot;LOYT&quot;.
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_ci9lQNxgEeioifFt1dhnJA")]
    [Description(@"Account using loyalty processing.")]
    LoyaltyAccount,
}
