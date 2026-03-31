// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Exception occurring outside the service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oMx7AK5FEeWCgYcWSNgX5g")]
[Description(@"Exception occurring outside the service.")]
[DerivedFrom(typeof(FailureReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FailureReason8Code>))]
#endif
public enum FailureReason8Code
{
    /// <summary>
    /// Card has been retained by the ATM or the terminal.
    /// Encoded/decoded by serializers as &quot;CDRT&quot;.
    /// </summary>
    [EnumMember(Value = "CDRT")]
    [IsoId("_tLl-Ya5FEeWCgYcWSNgX5g")]
    [Description(@"Card has been retained by the ATM or the terminal.")]
    CardRetained = FailureReasonCode.CardRetained, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ATM manager has requested to capture the card.
    /// Encoded/decoded by serializers as &quot;CDCP&quot;.
    /// </summary>
    [EnumMember(Value = "CDCP")]
    [IsoId("_tV4i065FEeWCgYcWSNgX5g")]
    [Description(@"ATM manager has requested to capture the card.")]
    CardCaptured = FailureReasonCode.CardCaptured, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer cancellation, for example removing the card before the end of the transaction.
    /// Encoded/decoded by serializers as &quot;CUCL&quot;.
    /// </summary>
    [EnumMember(Value = "CUCL")]
    [IsoId("_th8o465FEeWCgYcWSNgX5g")]
    [Description(
        @"Customer cancellation, for example removing the card before the end of the transaction."
    )]
    CustomerCancel = FailureReasonCode.CustomerCancel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer has left the card in the ATM or a motorised card reader.
    /// Encoded/decoded by serializers as &quot;CDFG&quot;.
    /// </summary>
    [EnumMember(Value = "CDFG")]
    [IsoId("_uU69865FEeWCgYcWSNgX5g")]
    [Description(@"Customer has left the card in the ATM or a motorised card reader.")]
    ForgottenCard = FailureReasonCode.ForgottenCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspected malfunction.
    /// Encoded/decoded by serializers as &quot;MALF&quot;.
    /// </summary>
    [EnumMember(Value = "MALF")]
    [IsoId("_upyas65FEeWCgYcWSNgX5g")]
    [Description(@"Suspected malfunction.")]
    Malfunction = FailureReasonCode.Malfunction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security error has occurred in the authorisation response message sent by the acquirer.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_vc0aI65FEeWCgYcWSNgX5g")]
    [Description(
        @"Security error has occurred in the authorisation response message sent by the acquirer."
    )]
    SecurityError = FailureReasonCode.SecurityError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card payment transaction fails because the merchant suspect a fraud.
    /// Encoded/decoded by serializers as &quot;SFRD&quot;.
    /// </summary>
    [EnumMember(Value = "SFRD")]
    [IsoId("_vomMU65FEeWCgYcWSNgX5g")]
    [Description(@"Card payment transaction fails because the merchant suspect a fraud.")]
    SuspectedFraud = FailureReasonCode.SuspectedFraud, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unable to capture the card as requested.
    /// Encoded/decoded by serializers as &quot;UCPT&quot;.
    /// </summary>
    [EnumMember(Value = "UCPT")]
    [IsoId("_wAJJo65FEeWCgYcWSNgX5g")]
    [Description(@"Unable to capture the card as requested.")]
    UnableToCapture = FailureReasonCode.UnableToCapture, // same ordinal as derivation source for type conversions
}
