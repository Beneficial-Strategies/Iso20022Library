// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of message supporting a service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FtTOIQu2Eeq4I6UJxZQ2Qw")]
[Description(@"Type of message supporting a service.")]
[DerivedFrom(typeof(MessageFunctionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MessageFunction40Code>))]
#endif
public enum MessageFunction40Code
{
    /// <summary>
    /// Request for authorisation with financial capture.
    /// Encoded/decoded by serializers as &quot;FAUQ&quot;.
    /// </summary>
    [EnumMember(Value = "FAUQ")]
    [IsoId("_F4fxgQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"Request for authorisation with financial capture.")]
    FinancialAuthorisationRequest = MessageFunctionCode.FinancialAuthorisationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAQ&quot;.
    /// </summary>
    [EnumMember(Value = "CCAQ")]
    [IsoId("_F4fxgwu2Eeq4I6UJxZQ2Qw")]
    [Description(@"Request for cancellation.")]
    CancellationRequest = MessageFunctionCode.CancellationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for completion without financial capture.
    /// Encoded/decoded by serializers as &quot;CMPV&quot;.
    /// </summary>
    [EnumMember(Value = "CMPV")]
    [IsoId("_F4fxhQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"Advice for completion without financial capture.")]
    CompletionAdvice = MessageFunctionCode.CompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for diagnostic.
    /// Encoded/decoded by serializers as &quot;DGNP&quot;.
    /// </summary>
    [EnumMember(Value = "DGNP")]
    [IsoId("_F4fxhwu2Eeq4I6UJxZQ2Qw")]
    [Description(@"Request for diagnostic.")]
    DiagnosticRequest = MessageFunctionCode.DiagnosticRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for reconciliation.
    /// Encoded/decoded by serializers as &quot;RCLQ&quot;.
    /// </summary>
    [EnumMember(Value = "RCLQ")]
    [IsoId("_F4fxiQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"Request for reconciliation.")]
    ReconciliationRequest = MessageFunctionCode.ReconciliationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAV&quot;.
    /// </summary>
    [EnumMember(Value = "CCAV")]
    [IsoId("_F4fxiwu2Eeq4I6UJxZQ2Qw")]
    [Description(@"Advice for cancellation.")]
    CancellationAdvice = MessageFunctionCode.CancellationAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer the financial data as a collection of transction.
    /// Encoded/decoded by serializers as &quot;BTCH&quot;.
    /// </summary>
    [EnumMember(Value = "BTCH")]
    [IsoId("_F4fxjQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"Transfer the financial data as a collection of transction.")]
    BatchTransfer = MessageFunctionCode.BatchTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for reversal with financial capture.
    /// Encoded/decoded by serializers as &quot;FRVA&quot;.
    /// </summary>
    [EnumMember(Value = "FRVA")]
    [IsoId("_F4fxjwu2Eeq4I6UJxZQ2Qw")]
    [Description(@"Advice for reversal with financial capture.")]
    FinancialReversalAdvice = MessageFunctionCode.FinancialReversalAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The initiator requests an authorisation without financial impact to complete the transaction.
    /// Encoded/decoded by serializers as &quot;AUTQ&quot;.
    /// </summary>
    [EnumMember(Value = "AUTQ")]
    [IsoId("_F4fxkQu2Eeq4I6UJxZQ2Qw")]
    [Description(
        @"The initiator requests an authorisation without financial impact to complete the transaction."
    )]
    AuthorisationRequest = MessageFunctionCode.AuthorisationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for completion with financial capture.
    /// Encoded/decoded by serializers as &quot;FCMV&quot;.
    /// </summary>
    [EnumMember(Value = "FCMV")]
    [IsoId("_F4fxkwu2Eeq4I6UJxZQ2Qw")]
    [Description(@"Advice for completion with financial capture.")]
    FinancialCompletionAdvice = MessageFunctionCode.FinancialCompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_F4fxlQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"Request for dynamic currency conversion.")]
    CurrencyConversionRequest = MessageFunctionCode.CurrencyConversionRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for reversal without financial capture.
    /// Encoded/decoded by serializers as &quot;RVRA&quot;.
    /// </summary>
    [EnumMember(Value = "RVRA")]
    [IsoId("_F4fxlwu2Eeq4I6UJxZQ2Qw")]
    [Description(@"Advice for reversal without financial capture.")]
    ReversalAdvice = MessageFunctionCode.ReversalAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCAV&quot;.
    /// </summary>
    [EnumMember(Value = "DCAV")]
    [IsoId("_F4fxmQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"Advice for dynamic currency conversion.")]
    CurrencyConversionAdvice = MessageFunctionCode.CurrencyConversionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advise of the transaction&apos;s processing.
    /// Encoded/decoded by serializers as &quot;TRNA&quot;.
    /// </summary>
    [EnumMember(Value = "TRNA")]
    [IsoId("_5qUogQ02EeqUVL7sB4m7NA")]
    [Description(@"Advise of the transaction's processing.")]
    TransactionAdvice = MessageFunctionCode.TransactionAdvice, // same ordinal as derivation source for type conversions
}
