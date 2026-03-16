// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the message function within a card payment exchange.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1Pxg4S9HEeOlZIh7PImd0A")]
[Description(@"Identifies the message function within a card payment exchange.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction4Code
{
    /// <summary>
    /// The initiator requests an authorisation without financial impact to complete the transaction.
    /// Encoded/decoded by serializers as &quot;AUTQ&quot;.
    /// </summary>
    [EnumMember(Value = "AUTQ")]
    [IsoId("_1g4fAS9HEeOlZIh7PImd0A")]
    [Description(
        @"The initiator requests an authorisation without financial impact to complete the transaction."
    )]
    AuthorisationRequest = MessageFunctionCode.AuthorisationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response for authorisation without financial capture.
    /// Encoded/decoded by serializers as &quot;AUTP&quot;.
    /// </summary>
    [EnumMember(Value = "AUTP")]
    [IsoId("_1g4fAy9HEeOlZIh7PImd0A")]
    [Description(@"Response for authorisation without financial capture.")]
    AuthorisationResponse = MessageFunctionCode.AuthorisationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for authorisation with financial capture.
    /// Encoded/decoded by serializers as &quot;FAUQ&quot;.
    /// </summary>
    [EnumMember(Value = "FAUQ")]
    [IsoId("_1g4fBS9HEeOlZIh7PImd0A")]
    [Description(@"Request for authorisation with financial capture.")]
    FinancialAuthorisationRequest = MessageFunctionCode.FinancialAuthorisationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response for authorisation with financial capture.
    /// Encoded/decoded by serializers as &quot;FAUP&quot;.
    /// </summary>
    [EnumMember(Value = "FAUP")]
    [IsoId("_1g4fBy9HEeOlZIh7PImd0A")]
    [Description(@"Response for authorisation with financial capture.")]
    FinancialAuthorisationResponse = MessageFunctionCode.FinancialAuthorisationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for completion without financial capture.
    /// Encoded/decoded by serializers as &quot;CMPV&quot;.
    /// </summary>
    [EnumMember(Value = "CMPV")]
    [IsoId("_1g4fCS9HEeOlZIh7PImd0A")]
    [Description(@"Advice for completion without financial capture.")]
    CompletionAdvice = MessageFunctionCode.CompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for completion without financial capture.
    /// Encoded/decoded by serializers as &quot;CMPK&quot;.
    /// </summary>
    [EnumMember(Value = "CMPK")]
    [IsoId("_1g4fCy9HEeOlZIh7PImd0A")]
    [Description(@"Advice response for completion without financial capture.")]
    CompletionAdviceResponse = MessageFunctionCode.CompletionAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for completion with financial capture.
    /// Encoded/decoded by serializers as &quot;FCMV&quot;.
    /// </summary>
    [EnumMember(Value = "FCMV")]
    [IsoId("_1g4fDS9HEeOlZIh7PImd0A")]
    [Description(@"Advice for completion with financial capture.")]
    FinancialCompletionAdvice = MessageFunctionCode.FinancialCompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for completion with financial capture.
    /// Encoded/decoded by serializers as &quot;FCMK&quot;.
    /// </summary>
    [EnumMember(Value = "FCMK")]
    [IsoId("_1g4fDy9HEeOlZIh7PImd0A")]
    [Description(@"Advice response for completion with financial capture.")]
    FinancialCompletionAdviceResponse = MessageFunctionCode.FinancialCompletionAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for reversal without financial capture.
    /// Encoded/decoded by serializers as &quot;RVRA&quot;.
    /// </summary>
    [EnumMember(Value = "RVRA")]
    [IsoId("_1g4fES9HEeOlZIh7PImd0A")]
    [Description(@"Advice for reversal without financial capture.")]
    ReversalAdvice = MessageFunctionCode.ReversalAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for reversal without financial capture.
    /// Encoded/decoded by serializers as &quot;RVRR&quot;.
    /// </summary>
    [EnumMember(Value = "RVRR")]
    [IsoId("_1g4fEy9HEeOlZIh7PImd0A")]
    [Description(@"Advice response for reversal without financial capture.")]
    ReversalAdviceResponse = MessageFunctionCode.ReversalAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for reversal with financial capture.
    /// Encoded/decoded by serializers as &quot;FRVA&quot;.
    /// </summary>
    [EnumMember(Value = "FRVA")]
    [IsoId("_1g4fFS9HEeOlZIh7PImd0A")]
    [Description(@"Advice for reversal with financial capture.")]
    FinancialReversalAdvice = MessageFunctionCode.FinancialReversalAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for reversal with financial capture.
    /// Encoded/decoded by serializers as &quot;FRVR&quot;.
    /// </summary>
    [EnumMember(Value = "FRVR")]
    [IsoId("_1g4fFy9HEeOlZIh7PImd0A")]
    [Description(@"Advice response for reversal with financial capture.")]
    FinancialReversalAdviceResponse = MessageFunctionCode.FinancialReversalAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAQ&quot;.
    /// </summary>
    [EnumMember(Value = "CCAQ")]
    [IsoId("_1g4fGS9HEeOlZIh7PImd0A")]
    [Description(@"Request for cancellation.")]
    CancellationRequest = MessageFunctionCode.CancellationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAP&quot;.
    /// </summary>
    [EnumMember(Value = "CCAP")]
    [IsoId("_1g4fGy9HEeOlZIh7PImd0A")]
    [Description(@"Response for cancellation.")]
    CancellationResponse = MessageFunctionCode.CancellationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAV&quot;.
    /// </summary>
    [EnumMember(Value = "CCAV")]
    [IsoId("_1g4fHS9HEeOlZIh7PImd0A")]
    [Description(@"Advice for cancellation.")]
    CancellationAdvice = MessageFunctionCode.CancellationAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAK&quot;.
    /// </summary>
    [EnumMember(Value = "CCAK")]
    [IsoId("_1g4fHy9HEeOlZIh7PImd0A")]
    [Description(@"Advice response for cancellation.")]
    CancellationAdviceResponse = MessageFunctionCode.CancellationAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for diagnostic.
    /// Encoded/decoded by serializers as &quot;DGNP&quot;.
    /// </summary>
    [EnumMember(Value = "DGNP")]
    [IsoId("_1g4fIS9HEeOlZIh7PImd0A")]
    [Description(@"Request for diagnostic.")]
    DiagnosticRequest = MessageFunctionCode.DiagnosticRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response for diagnostic.
    /// Encoded/decoded by serializers as &quot;DGNQ&quot;.
    /// </summary>
    [EnumMember(Value = "DGNQ")]
    [IsoId("_1g4fIy9HEeOlZIh7PImd0A")]
    [Description(@"Response for diagnostic.")]
    DiagnosticResponse = MessageFunctionCode.DiagnosticResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for reconciliation.
    /// Encoded/decoded by serializers as &quot;RCLQ&quot;.
    /// </summary>
    [EnumMember(Value = "RCLQ")]
    [IsoId("_1g4fJS9HEeOlZIh7PImd0A")]
    [Description(@"Request for reconciliation.")]
    ReconciliationRequest = MessageFunctionCode.ReconciliationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response for reconciliation.
    /// Encoded/decoded by serializers as &quot;RCLP&quot;.
    /// </summary>
    [EnumMember(Value = "RCLP")]
    [IsoId("_1g4fJy9HEeOlZIh7PImd0A")]
    [Description(@"Response for reconciliation.")]
    ReconciliationResponse = MessageFunctionCode.ReconciliationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reject a request or an advice.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_1g4fKS9HEeOlZIh7PImd0A")]
    [Description(@"Reject a request or an advice.")]
    Rejection = MessageFunctionCode.Rejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_4mdI0S9HEeOlZIh7PImd0A")]
    [Description(@"Request for dynamic currency conversion.")]
    CurrencyConversionRequest = MessageFunctionCode.CurrencyConversionRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response from a dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCP&quot;.
    /// </summary>
    [EnumMember(Value = "DCCP")]
    [IsoId("_4x6K4S9HEeOlZIh7PImd0A")]
    [Description(@"Response from a dynamic currency conversion.")]
    CurrencyConversionResponse = MessageFunctionCode.CurrencyConversionResponse, // same ordinal as derivation source for type conversions
}
