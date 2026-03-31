// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for requesting the cancellation of a payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bYGetdp-Ed-ak6NoX_4Aeg_-553056658")]
[Description(@"Specifies the reason for requesting the cancellation of a payment instruction.")]
[DerivedFrom(typeof(CancellationReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CancellationReason3Code>))]
#endif
public enum CancellationReason3Code
{
    /// <summary>
    /// Cancellation requested by the Debtor.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_bYGettp-Ed-ak6NoX_4Aeg_-553056545")]
    [Description(@"Cancellation requested by the Debtor.")]
    RequestedByCustomer = CancellationReasonCode.RequestedByCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_bYGet9p-Ed-ak6NoX_4Aeg_-553056520")]
    [Description(@"Payment is a duplicate of another payment.")]
    DuplicatePayment = CancellationReasonCode.DuplicatePayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agent in the payment workflow is incorrect.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_bYGeuNp-Ed-ak6NoX_4Aeg_-553056503")]
    [Description(@"Agent in the payment workflow is incorrect.")]
    IncorrectAgent = CancellationReasonCode.IncorrectAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Currency of the payment is incorrect.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_bYQPsNp-Ed-ak6NoX_4Aeg_-553056460")]
    [Description(@"Currency of the payment is incorrect.")]
    IncorrectCurrency = CancellationReasonCode.IncorrectCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_bYQPsdp-Ed-ak6NoX_4Aeg_-553056459")]
    [Description(@"Payment is not justified.")]
    UnduePayment = CancellationReasonCode.UnduePayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient or incoherent details about the debtor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM23&quot;.
    /// </summary>
    [EnumMember(Value = "MM23")]
    [IsoId("_bYQPstp-Ed-ak6NoX_4Aeg_-212277718")]
    [Description(
        @"Insufficient or incoherent details about the debtor with respect to regulatory requirements."
    )]
    InsufficientDebtorDetails = CancellationReasonCode.InsufficientDebtorDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient or incoherent details about the creditor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM24&quot;.
    /// </summary>
    [EnumMember(Value = "MM24")]
    [IsoId("_bYQPs9p-Ed-ak6NoX_4Aeg_-212277392")]
    [Description(
        @"Insufficient or incoherent details about the creditor with respect to regulatory requirements."
    )]
    InsufficientCreditorDetails = CancellationReasonCode.InsufficientCreditorDetails, // same ordinal as derivation source for type conversions
}
