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
[IsoId("_Vb_nYQ0xEeqUVL7sB4m7NA")]
[Description(@"Type of message supporting a service.")]
[DerivedFrom(typeof(MessageFunctionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MessageFunction41Code>))]
#endif
public enum MessageFunction41Code
{
    /// <summary>
    /// The initiator requests an authorisation without financial impact to complete the transaction.
    /// Encoded/decoded by serializers as &quot;AUTQ&quot;.
    /// </summary>
    [EnumMember(Value = "AUTQ")]
    [IsoId("_VoGwwQ0xEeqUVL7sB4m7NA")]
    [Description(
        @"The initiator requests an authorisation without financial impact to complete the transaction."
    )]
    AuthorisationRequest = MessageFunctionCode.AuthorisationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response for authorisation without financial capture.
    /// Encoded/decoded by serializers as &quot;AUTP&quot;.
    /// </summary>
    [EnumMember(Value = "AUTP")]
    [IsoId("_VoGwww0xEeqUVL7sB4m7NA")]
    [Description(@"Response for authorisation without financial capture.")]
    AuthorisationResponse = MessageFunctionCode.AuthorisationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAV&quot;.
    /// </summary>
    [EnumMember(Value = "CCAV")]
    [IsoId("_VoGwxQ0xEeqUVL7sB4m7NA")]
    [Description(@"Advice for cancellation.")]
    CancellationAdvice = MessageFunctionCode.CancellationAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAK&quot;.
    /// </summary>
    [EnumMember(Value = "CCAK")]
    [IsoId("_VoGwxw0xEeqUVL7sB4m7NA")]
    [Description(@"Advice response for cancellation.")]
    CancellationAdviceResponse = MessageFunctionCode.CancellationAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAQ&quot;.
    /// </summary>
    [EnumMember(Value = "CCAQ")]
    [IsoId("_VoGwyQ0xEeqUVL7sB4m7NA")]
    [Description(@"Request for cancellation.")]
    CancellationRequest = MessageFunctionCode.CancellationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAP&quot;.
    /// </summary>
    [EnumMember(Value = "CCAP")]
    [IsoId("_VoGwyw0xEeqUVL7sB4m7NA")]
    [Description(@"Response for cancellation.")]
    CancellationResponse = MessageFunctionCode.CancellationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for completion without financial capture.
    /// Encoded/decoded by serializers as &quot;CMPV&quot;.
    /// </summary>
    [EnumMember(Value = "CMPV")]
    [IsoId("_VoGwzQ0xEeqUVL7sB4m7NA")]
    [Description(@"Advice for completion without financial capture.")]
    CompletionAdvice = MessageFunctionCode.CompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for completion without financial capture.
    /// Encoded/decoded by serializers as &quot;CMPK&quot;.
    /// </summary>
    [EnumMember(Value = "CMPK")]
    [IsoId("_VoGwzw0xEeqUVL7sB4m7NA")]
    [Description(@"Advice response for completion without financial capture.")]
    CompletionAdviceResponse = MessageFunctionCode.CompletionAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCAV&quot;.
    /// </summary>
    [EnumMember(Value = "DCAV")]
    [IsoId("_VoGw0Q0xEeqUVL7sB4m7NA")]
    [Description(@"Advice for dynamic currency conversion.")]
    CurrencyConversionAdvice = MessageFunctionCode.CurrencyConversionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for the currency conversion from the service provider to the acceptor.
    /// Encoded/decoded by serializers as &quot;DCRR&quot;.
    /// </summary>
    [EnumMember(Value = "DCRR")]
    [IsoId("_VoGw0w0xEeqUVL7sB4m7NA")]
    [Description(
        @"Advice response for the currency conversion from the service provider to the acceptor."
    )]
    CurrencyConversionAdviceResponse = MessageFunctionCode.CurrencyConversionAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_VoGw1Q0xEeqUVL7sB4m7NA")]
    [Description(@"Request for dynamic currency conversion.")]
    CurrencyConversionRequest = MessageFunctionCode.CurrencyConversionRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response from a dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCP&quot;.
    /// </summary>
    [EnumMember(Value = "DCCP")]
    [IsoId("_VoGw1w0xEeqUVL7sB4m7NA")]
    [Description(@"Response from a dynamic currency conversion.")]
    CurrencyConversionResponse = MessageFunctionCode.CurrencyConversionResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for diagnostic.
    /// Encoded/decoded by serializers as &quot;DGNP&quot;.
    /// </summary>
    [EnumMember(Value = "DGNP")]
    [IsoId("_VoGw2Q0xEeqUVL7sB4m7NA")]
    [Description(@"Request for diagnostic.")]
    DiagnosticRequest = MessageFunctionCode.DiagnosticRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response for diagnostic.
    /// Encoded/decoded by serializers as &quot;DGNQ&quot;.
    /// </summary>
    [EnumMember(Value = "DGNQ")]
    [IsoId("_VoGw2w0xEeqUVL7sB4m7NA")]
    [Description(@"Response for diagnostic.")]
    DiagnosticResponse = MessageFunctionCode.DiagnosticResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for authorisation with financial capture.
    /// Encoded/decoded by serializers as &quot;FAUQ&quot;.
    /// </summary>
    [EnumMember(Value = "FAUQ")]
    [IsoId("_VoGw3Q0xEeqUVL7sB4m7NA")]
    [Description(@"Request for authorisation with financial capture.")]
    FinancialAuthorisationRequest = MessageFunctionCode.FinancialAuthorisationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response for authorisation with financial capture.
    /// Encoded/decoded by serializers as &quot;FAUP&quot;.
    /// </summary>
    [EnumMember(Value = "FAUP")]
    [IsoId("_VoGw3w0xEeqUVL7sB4m7NA")]
    [Description(@"Response for authorisation with financial capture.")]
    FinancialAuthorisationResponse = MessageFunctionCode.FinancialAuthorisationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for completion with financial capture.
    /// Encoded/decoded by serializers as &quot;FCMV&quot;.
    /// </summary>
    [EnumMember(Value = "FCMV")]
    [IsoId("_VoGw4Q0xEeqUVL7sB4m7NA")]
    [Description(@"Advice for completion with financial capture.")]
    FinancialCompletionAdvice = MessageFunctionCode.FinancialCompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for completion with financial capture.
    /// Encoded/decoded by serializers as &quot;FCMK&quot;.
    /// </summary>
    [EnumMember(Value = "FCMK")]
    [IsoId("_VoGw4w0xEeqUVL7sB4m7NA")]
    [Description(@"Advice response for completion with financial capture.")]
    FinancialCompletionAdviceResponse = MessageFunctionCode.FinancialCompletionAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for reversal with financial capture.
    /// Encoded/decoded by serializers as &quot;FRVA&quot;.
    /// </summary>
    [EnumMember(Value = "FRVA")]
    [IsoId("_VoGw5Q0xEeqUVL7sB4m7NA")]
    [Description(@"Advice for reversal with financial capture.")]
    FinancialReversalAdvice = MessageFunctionCode.FinancialReversalAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for reversal with financial capture.
    /// Encoded/decoded by serializers as &quot;FRVR&quot;.
    /// </summary>
    [EnumMember(Value = "FRVR")]
    [IsoId("_VoGw5w0xEeqUVL7sB4m7NA")]
    [Description(@"Advice response for reversal with financial capture.")]
    FinancialReversalAdviceResponse = MessageFunctionCode.FinancialReversalAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for reconciliation.
    /// Encoded/decoded by serializers as &quot;RCLQ&quot;.
    /// </summary>
    [EnumMember(Value = "RCLQ")]
    [IsoId("_VoGw6Q0xEeqUVL7sB4m7NA")]
    [Description(@"Request for reconciliation.")]
    ReconciliationRequest = MessageFunctionCode.ReconciliationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response for reconciliation.
    /// Encoded/decoded by serializers as &quot;RCLP&quot;.
    /// </summary>
    [EnumMember(Value = "RCLP")]
    [IsoId("_VoGw6w0xEeqUVL7sB4m7NA")]
    [Description(@"Response for reconciliation.")]
    ReconciliationResponse = MessageFunctionCode.ReconciliationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for reversal without financial capture.
    /// Encoded/decoded by serializers as &quot;RVRA&quot;.
    /// </summary>
    [EnumMember(Value = "RVRA")]
    [IsoId("_VoGw7Q0xEeqUVL7sB4m7NA")]
    [Description(@"Advice for reversal without financial capture.")]
    ReversalAdvice = MessageFunctionCode.ReversalAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for reversal without financial capture.
    /// Encoded/decoded by serializers as &quot;RVRR&quot;.
    /// </summary>
    [EnumMember(Value = "RVRR")]
    [IsoId("_VoGw7w0xEeqUVL7sB4m7NA")]
    [Description(@"Advice response for reversal without financial capture.")]
    ReversalAdviceResponse = MessageFunctionCode.ReversalAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for a Card Direct Debit.
    /// Encoded/decoded by serializers as &quot;CDDQ&quot;.
    /// </summary>
    [EnumMember(Value = "CDDQ")]
    [IsoId("_VoGw8Q0xEeqUVL7sB4m7NA")]
    [Description(@"Advice for a Card Direct Debit.")]
    CardDebitAdvice = MessageFunctionCode.CardDebitAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to a Card Direct Debit Advice.
    /// Encoded/decoded by serializers as &quot;CDDK&quot;.
    /// </summary>
    [EnumMember(Value = "CDDK")]
    [IsoId("_VoGw8w0xEeqUVL7sB4m7NA")]
    [Description(@"Response to a Card Direct Debit Advice.")]
    CardDebitAdviceResponse = MessageFunctionCode.CardDebitAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to initiate a Card Direct Debit.
    /// Encoded/decoded by serializers as &quot;CDDR&quot;.
    /// </summary>
    [EnumMember(Value = "CDDR")]
    [IsoId("_VoGw9Q0xEeqUVL7sB4m7NA")]
    [Description(@"Request to initiate a Card Direct Debit.")]
    CardDebitRequest = MessageFunctionCode.CardDebitRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to a Card Direct Debit Request.
    /// Encoded/decoded by serializers as &quot;CDDP&quot;.
    /// </summary>
    [EnumMember(Value = "CDDP")]
    [IsoId("_VoGw9w0xEeqUVL7sB4m7NA")]
    [Description(@"Response to a Card Direct Debit Request.")]
    CardDebitResponse = MessageFunctionCode.CardDebitResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to a transaction advice.
    /// Encoded/decoded by serializers as &quot;TRNR&quot;.
    /// </summary>
    [EnumMember(Value = "TRNR")]
    [IsoId("_2kmNsQ02EeqUVL7sB4m7NA")]
    [Description(@"Response to a transaction advice.")]
    TransactionAdviceResponse = MessageFunctionCode.TransactionAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advise of the transaction&apos;s processing.
    /// Encoded/decoded by serializers as &quot;TRNA&quot;.
    /// </summary>
    [EnumMember(Value = "TRNA")]
    [IsoId("_2odaAQ02EeqUVL7sB4m7NA")]
    [Description(@"Advise of the transaction's processing.")]
    TransactionAdvice = MessageFunctionCode.TransactionAdvice, // same ordinal as derivation source for type conversions
}
