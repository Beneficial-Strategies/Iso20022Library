// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of message supporting a service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FttZcXC8Ee2bmOA3bkVsMg")]
[Description(@"Type of message supporting a service.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction46Code
{
    /// <summary>
    /// The initiator requests an authorisation without financial impact to complete the transaction.
    /// Encoded/decoded by serializers as &quot;AUTQ&quot;.
    /// </summary>
    [EnumMember(Value = "AUTQ")]
    [IsoId("_F1FMwXC8Ee2bmOA3bkVsMg")]
    [Description(
        @"The initiator requests an authorisation without financial impact to complete the transaction."
    )]
    AuthorisationRequest = MessageFunctionCode.AuthorisationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response for authorisation without financial capture.
    /// Encoded/decoded by serializers as &quot;AUTP&quot;.
    /// </summary>
    [EnumMember(Value = "AUTP")]
    [IsoId("_F1FMw3C8Ee2bmOA3bkVsMg")]
    [Description(@"Response for authorisation without financial capture.")]
    AuthorisationResponse = MessageFunctionCode.AuthorisationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAV&quot;.
    /// </summary>
    [EnumMember(Value = "CCAV")]
    [IsoId("_F1FMxXC8Ee2bmOA3bkVsMg")]
    [Description(@"Advice for cancellation.")]
    CancellationAdvice = MessageFunctionCode.CancellationAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAK&quot;.
    /// </summary>
    [EnumMember(Value = "CCAK")]
    [IsoId("_F1FMx3C8Ee2bmOA3bkVsMg")]
    [Description(@"Advice response for cancellation.")]
    CancellationAdviceResponse = MessageFunctionCode.CancellationAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAQ&quot;.
    /// </summary>
    [EnumMember(Value = "CCAQ")]
    [IsoId("_F1FMyXC8Ee2bmOA3bkVsMg")]
    [Description(@"Request for cancellation.")]
    CancellationRequest = MessageFunctionCode.CancellationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAP&quot;.
    /// </summary>
    [EnumMember(Value = "CCAP")]
    [IsoId("_F1FMy3C8Ee2bmOA3bkVsMg")]
    [Description(@"Response for cancellation.")]
    CancellationResponse = MessageFunctionCode.CancellationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for completion without financial capture.
    /// Encoded/decoded by serializers as &quot;CMPV&quot;.
    /// </summary>
    [EnumMember(Value = "CMPV")]
    [IsoId("_F1FMzXC8Ee2bmOA3bkVsMg")]
    [Description(@"Advice for completion without financial capture.")]
    CompletionAdvice = MessageFunctionCode.CompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for completion without financial capture.
    /// Encoded/decoded by serializers as &quot;CMPK&quot;.
    /// </summary>
    [EnumMember(Value = "CMPK")]
    [IsoId("_F1FMz3C8Ee2bmOA3bkVsMg")]
    [Description(@"Advice response for completion without financial capture.")]
    CompletionAdviceResponse = MessageFunctionCode.CompletionAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCAV&quot;.
    /// </summary>
    [EnumMember(Value = "DCAV")]
    [IsoId("_F1FM0XC8Ee2bmOA3bkVsMg")]
    [Description(@"Advice for dynamic currency conversion.")]
    CurrencyConversionAdvice = MessageFunctionCode.CurrencyConversionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for the currency conversion from the service provider to the acceptor.
    /// Encoded/decoded by serializers as &quot;DCRR&quot;.
    /// </summary>
    [EnumMember(Value = "DCRR")]
    [IsoId("_F1FM03C8Ee2bmOA3bkVsMg")]
    [Description(
        @"Advice response for the currency conversion from the service provider to the acceptor."
    )]
    CurrencyConversionAdviceResponse = MessageFunctionCode.CurrencyConversionAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_F1FM1XC8Ee2bmOA3bkVsMg")]
    [Description(@"Request for dynamic currency conversion.")]
    CurrencyConversionRequest = MessageFunctionCode.CurrencyConversionRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response from a dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCP&quot;.
    /// </summary>
    [EnumMember(Value = "DCCP")]
    [IsoId("_F1FM13C8Ee2bmOA3bkVsMg")]
    [Description(@"Response from a dynamic currency conversion.")]
    CurrencyConversionResponse = MessageFunctionCode.CurrencyConversionResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for diagnostic.
    /// Encoded/decoded by serializers as &quot;DGNP&quot;.
    /// </summary>
    [EnumMember(Value = "DGNP")]
    [IsoId("_F1FM2XC8Ee2bmOA3bkVsMg")]
    [Description(@"Request for diagnostic.")]
    DiagnosticRequest = MessageFunctionCode.DiagnosticRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response for diagnostic.
    /// Encoded/decoded by serializers as &quot;DGNQ&quot;.
    /// </summary>
    [EnumMember(Value = "DGNQ")]
    [IsoId("_F1FM23C8Ee2bmOA3bkVsMg")]
    [Description(@"Response for diagnostic.")]
    DiagnosticResponse = MessageFunctionCode.DiagnosticResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for authorisation with financial capture.
    /// Encoded/decoded by serializers as &quot;FAUQ&quot;.
    /// </summary>
    [EnumMember(Value = "FAUQ")]
    [IsoId("_F1FM3XC8Ee2bmOA3bkVsMg")]
    [Description(@"Request for authorisation with financial capture.")]
    FinancialAuthorisationRequest = MessageFunctionCode.FinancialAuthorisationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response for authorisation with financial capture.
    /// Encoded/decoded by serializers as &quot;FAUP&quot;.
    /// </summary>
    [EnumMember(Value = "FAUP")]
    [IsoId("_F1FM33C8Ee2bmOA3bkVsMg")]
    [Description(@"Response for authorisation with financial capture.")]
    FinancialAuthorisationResponse = MessageFunctionCode.FinancialAuthorisationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for completion with financial capture.
    /// Encoded/decoded by serializers as &quot;FCMV&quot;.
    /// </summary>
    [EnumMember(Value = "FCMV")]
    [IsoId("_F1FM4XC8Ee2bmOA3bkVsMg")]
    [Description(@"Advice for completion with financial capture.")]
    FinancialCompletionAdvice = MessageFunctionCode.FinancialCompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for completion with financial capture.
    /// Encoded/decoded by serializers as &quot;FCMK&quot;.
    /// </summary>
    [EnumMember(Value = "FCMK")]
    [IsoId("_F1FM43C8Ee2bmOA3bkVsMg")]
    [Description(@"Advice response for completion with financial capture.")]
    FinancialCompletionAdviceResponse = MessageFunctionCode.FinancialCompletionAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for reversal with financial capture.
    /// Encoded/decoded by serializers as &quot;FRVA&quot;.
    /// </summary>
    [EnumMember(Value = "FRVA")]
    [IsoId("_F1FM5XC8Ee2bmOA3bkVsMg")]
    [Description(@"Advice for reversal with financial capture.")]
    FinancialReversalAdvice = MessageFunctionCode.FinancialReversalAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for reversal with financial capture.
    /// Encoded/decoded by serializers as &quot;FRVR&quot;.
    /// </summary>
    [EnumMember(Value = "FRVR")]
    [IsoId("_F1FM53C8Ee2bmOA3bkVsMg")]
    [Description(@"Advice response for reversal with financial capture.")]
    FinancialReversalAdviceResponse = MessageFunctionCode.FinancialReversalAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for reconciliation.
    /// Encoded/decoded by serializers as &quot;RCLQ&quot;.
    /// </summary>
    [EnumMember(Value = "RCLQ")]
    [IsoId("_F1FM6XC8Ee2bmOA3bkVsMg")]
    [Description(@"Request for reconciliation.")]
    ReconciliationRequest = MessageFunctionCode.ReconciliationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response for reconciliation.
    /// Encoded/decoded by serializers as &quot;RCLP&quot;.
    /// </summary>
    [EnumMember(Value = "RCLP")]
    [IsoId("_F1FM63C8Ee2bmOA3bkVsMg")]
    [Description(@"Response for reconciliation.")]
    ReconciliationResponse = MessageFunctionCode.ReconciliationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for reversal without financial capture.
    /// Encoded/decoded by serializers as &quot;RVRA&quot;.
    /// </summary>
    [EnumMember(Value = "RVRA")]
    [IsoId("_F1FM7XC8Ee2bmOA3bkVsMg")]
    [Description(@"Advice for reversal without financial capture.")]
    ReversalAdvice = MessageFunctionCode.ReversalAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for reversal without financial capture.
    /// Encoded/decoded by serializers as &quot;RVRR&quot;.
    /// </summary>
    [EnumMember(Value = "RVRR")]
    [IsoId("_F1FM73C8Ee2bmOA3bkVsMg")]
    [Description(@"Advice response for reversal without financial capture.")]
    ReversalAdviceResponse = MessageFunctionCode.ReversalAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for a Card Direct Debit.
    /// Encoded/decoded by serializers as &quot;CDDQ&quot;.
    /// </summary>
    [EnumMember(Value = "CDDQ")]
    [IsoId("_F1FM8XC8Ee2bmOA3bkVsMg")]
    [Description(@"Advice for a Card Direct Debit.")]
    CardDebitAdvice = MessageFunctionCode.CardDebitAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to a Card Direct Debit Advice.
    /// Encoded/decoded by serializers as &quot;CDDK&quot;.
    /// </summary>
    [EnumMember(Value = "CDDK")]
    [IsoId("_F1FM83C8Ee2bmOA3bkVsMg")]
    [Description(@"Response to a Card Direct Debit Advice.")]
    CardDebitAdviceResponse = MessageFunctionCode.CardDebitAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to initiate a Card Direct Debit.
    /// Encoded/decoded by serializers as &quot;CDDR&quot;.
    /// </summary>
    [EnumMember(Value = "CDDR")]
    [IsoId("_F1FM9XC8Ee2bmOA3bkVsMg")]
    [Description(@"Request to initiate a Card Direct Debit.")]
    CardDebitRequest = MessageFunctionCode.CardDebitRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to a Card Direct Debit Request.
    /// Encoded/decoded by serializers as &quot;CDDP&quot;.
    /// </summary>
    [EnumMember(Value = "CDDP")]
    [IsoId("_F1FM93C8Ee2bmOA3bkVsMg")]
    [Description(@"Response to a Card Direct Debit Request.")]
    CardDebitResponse = MessageFunctionCode.CardDebitResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to a transaction advice.
    /// Encoded/decoded by serializers as &quot;TRNR&quot;.
    /// </summary>
    [EnumMember(Value = "TRNR")]
    [IsoId("_F1FM-XC8Ee2bmOA3bkVsMg")]
    [Description(@"Response to a transaction advice.")]
    TransactionAdviceResponse = MessageFunctionCode.TransactionAdviceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advise of the transaction&apos;s processing.
    /// Encoded/decoded by serializers as &quot;TRNA&quot;.
    /// </summary>
    [EnumMember(Value = "TRNA")]
    [IsoId("_F1FM-3C8Ee2bmOA3bkVsMg")]
    [Description(@"Advise of the transaction's processing.")]
    TransactionAdvice = MessageFunctionCode.TransactionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Initiator of the message requests additional information to the receiver.
    /// Encoded/decoded by serializers as &quot;NFRQ&quot;.
    /// </summary>
    [EnumMember(Value = "NFRQ")]
    [IsoId("_F1FM_XC8Ee2bmOA3bkVsMg")]
    [Description(@"Initiator of the message requests additional information to the receiver.")]
    NonFinancialRequest = MessageFunctionCode.NonFinancialRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Provision of additional information to the issuer of a NonFinancialRequest.
    /// Encoded/decoded by serializers as &quot;NFRP&quot;.
    /// </summary>
    [EnumMember(Value = "NFRP")]
    [IsoId("_F1FM_3C8Ee2bmOA3bkVsMg")]
    [Description(@"Provision of additional information to the issuer of a NonFinancialRequest.")]
    NonFinancialResponse = MessageFunctionCode.NonFinancialResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to receive of a report of transaction from the issuer to the receiver.
    /// Encoded/decoded by serializers as &quot;TRPQ&quot;.
    /// </summary>
    [EnumMember(Value = "TRPQ")]
    [IsoId("_F1FNAXC8Ee2bmOA3bkVsMg")]
    [Description(@"Request to receive of a report of transaction from the issuer to the receiver.")]
    TransactionReportRequest = MessageFunctionCode.TransactionReportRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to provide a sanitized report of transactions.
    /// Encoded/decoded by serializers as &quot;TRPP&quot;.
    /// </summary>
    [EnumMember(Value = "TRPP")]
    [IsoId("_F1FNA3C8Ee2bmOA3bkVsMg")]
    [Description(@"Response to provide a sanitized report of transactions.")]
    TransactionReportResponse = MessageFunctionCode.TransactionReportResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to receive catalogue of Currency Conversion rates.
    /// Encoded/decoded by serializers as &quot;DCRQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCRQ")]
    [IsoId("_RGDxwXC8Ee2bmOA3bkVsMg")]
    [Description(@"Request to receive catalogue of Currency Conversion rates.")]
    CurrencyConversionRateRequest = MessageFunctionCode.CurrencyConversionRateRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response with catalogue of Currency Conversion rates.
    /// Encoded/decoded by serializers as &quot;DCRP&quot;.
    /// </summary>
    [EnumMember(Value = "DCRP")]
    [IsoId("_RR-G0XC8Ee2bmOA3bkVsMg")]
    [Description(@"Response with catalogue of Currency Conversion rates.")]
    CurrencyConversionRateResponse = MessageFunctionCode.CurrencyConversionRateResponse, // same ordinal as derivation source for type conversions
}
