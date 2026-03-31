// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Service provided by the card payment transaction, in addition to the main service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TSqIbwEcEeCQm6a_G2yO_w_2042569244")]
[Description(@"Service provided by the card payment transaction, in addition to the main service.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardPaymentServiceType2Code>))]
#endif
public enum CardPaymentServiceType2Code
{
    /// <summary>
    /// Aggregation of low payments.
    /// Encoded/decoded by serializers as &quot;AGGR&quot;.
    /// </summary>
    [EnumMember(Value = "AGGR")]
    [IsoId("_TSqIcAEcEeCQm6a_G2yO_w_-607130617")]
    [Description(@"Aggregation of low payments.")]
    Aggregation = CardPaymentServiceTypeCode.Aggregation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dynamic currency conversion (DCC).
    /// Encoded/decoded by serializers as &quot;DCCV&quot;.
    /// </summary>
    [EnumMember(Value = "DCCV")]
    [IsoId("_TSqIcQEcEeCQm6a_G2yO_w_1045496891")]
    [Description(@"Dynamic currency conversion (DCC).")]
    DCC = CardPaymentServiceTypeCode.DCC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card payment with gratuity.
    /// Encoded/decoded by serializers as &quot;GRTT&quot;.
    /// </summary>
    [EnumMember(Value = "GRTT")]
    [IsoId("_TSqIcgEcEeCQm6a_G2yO_w_1223615563")]
    [Description(@"Card payment with gratuity.")]
    Gratuity = CardPaymentServiceTypeCode.Gratuity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instalment payment.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_TSqIcwEcEeCQm6a_G2yO_w_931657825")]
    [Description(@"Instalment payment.")]
    Instalment = CardPaymentServiceTypeCode.Instalment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Loyalty services.
    /// Encoded/decoded by serializers as &quot;LOYT&quot;.
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_TSqIdAEcEeCQm6a_G2yO_w_-1604202970")]
    [Description(@"Loyalty services.")]
    Loyalty = CardPaymentServiceTypeCode.Loyalty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No show after reservation.
    /// Encoded/decoded by serializers as &quot;NRES&quot;.
    /// </summary>
    [EnumMember(Value = "NRES")]
    [IsoId("_TSz5YAEcEeCQm6a_G2yO_w_48424538")]
    [Description(@"No show after reservation.")]
    NoShow = CardPaymentServiceTypeCode.NoShow, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Purchase and corporate data.
    /// Encoded/decoded by serializers as &quot;PUCO&quot;.
    /// </summary>
    [EnumMember(Value = "PUCO")]
    [IsoId("_TSz5YQEcEeCQm6a_G2yO_w_226543210")]
    [Description(@"Purchase and corporate data.")]
    PurchaseCorporate = CardPaymentServiceTypeCode.PurchaseCorporate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Recurring payment.
    /// Encoded/decoded by serializers as &quot;RECP&quot;.
    /// </summary>
    [EnumMember(Value = "RECP")]
    [IsoId("_TSz5YgEcEeCQm6a_G2yO_w_-65414528")]
    [Description(@"Recurring payment.")]
    RecurringPayment = CardPaymentServiceTypeCode.RecurringPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Solicited available funds.
    /// Encoded/decoded by serializers as &quot;SOAF&quot;.
    /// </summary>
    [EnumMember(Value = "SOAF")]
    [IsoId("_TSz5YwEcEeCQm6a_G2yO_w_1693691973")]
    [Description(@"Solicited available funds.")]
    SolicitedAvailableFunds = CardPaymentServiceTypeCode.SolicitedAvailableFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unsolicited available funds.
    /// Encoded/decoded by serializers as &quot;UNAF&quot;.
    /// </summary>
    [EnumMember(Value = "UNAF")]
    [IsoId("_TSz5ZAEcEeCQm6a_G2yO_w_-948647815")]
    [Description(@"Unsolicited available funds.")]
    UnsolicitedAvailableFunds = CardPaymentServiceTypeCode.UnsolicitedAvailableFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Voice authorisation.
    /// Encoded/decoded by serializers as &quot;VCAU&quot;.
    /// </summary>
    [EnumMember(Value = "VCAU")]
    [IsoId("_TSz5ZQEcEeCQm6a_G2yO_w_-770529143")]
    [Description(@"Voice authorisation.")]
    VoiceAuthorisation = CardPaymentServiceTypeCode.VoiceAuthorisation, // same ordinal as derivation source for type conversions
}
