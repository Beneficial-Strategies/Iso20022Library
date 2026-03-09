// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of message supporting a service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BGHa8S_aEeugIJ3Gvoevmg")]
[Description(@"Type of message supporting a service.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction42Code
{
    /// <summary>
    /// The initiator requests an authorisation without financial impact to complete the transaction.
    /// Encoded/decoded by serializers as &quot;AUTQ&quot;.
    /// </summary>
    [EnumMember(Value = "AUTQ")]
    [IsoId("_Bbd_4S_aEeugIJ3Gvoevmg")]
    [Description(@"The initiator requests an authorisation without financial impact to complete the transaction.")]
    AuthorisationRequest = MessageFunctionCode.AuthorisationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response for authorisation without financial capture.
    /// Encoded/decoded by serializers as &quot;AUTP&quot;.
    /// </summary>
    [EnumMember(Value = "AUTP")]
    [IsoId("_Bbd_4y_aEeugIJ3Gvoevmg")]
    [Description(@"Response for authorisation without financial capture.")]
    AuthorisationResponse = MessageFunctionCode.AuthorisationResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAV&quot;.
    /// </summary>
    [EnumMember(Value = "CCAV")]
    [IsoId("_Bbd_5S_aEeugIJ3Gvoevmg")]
    [Description(@"Advice for cancellation.")]
    CancellationAdvice = MessageFunctionCode.CancellationAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice response for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAK&quot;.
    /// </summary>
    [EnumMember(Value = "CCAK")]
    [IsoId("_Bbd_5y_aEeugIJ3Gvoevmg")]
    [Description(@"Advice response for cancellation.")]
    CancellationAdviceResponse = MessageFunctionCode.CancellationAdviceResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAQ&quot;.
    /// </summary>
    [EnumMember(Value = "CCAQ")]
    [IsoId("_Bbd_6S_aEeugIJ3Gvoevmg")]
    [Description(@"Request for cancellation.")]
    CancellationRequest = MessageFunctionCode.CancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAP&quot;.
    /// </summary>
    [EnumMember(Value = "CCAP")]
    [IsoId("_Bbd_6y_aEeugIJ3Gvoevmg")]
    [Description(@"Response for cancellation.")]
    CancellationResponse = MessageFunctionCode.CancellationResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice for completion without financial capture.
    /// Encoded/decoded by serializers as &quot;CMPV&quot;.
    /// </summary>
    [EnumMember(Value = "CMPV")]
    [IsoId("_Bbd_7S_aEeugIJ3Gvoevmg")]
    [Description(@"Advice for completion without financial capture.")]
    CompletionAdvice = MessageFunctionCode.CompletionAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice response for completion without financial capture.
    /// Encoded/decoded by serializers as &quot;CMPK&quot;.
    /// </summary>
    [EnumMember(Value = "CMPK")]
    [IsoId("_Bbd_7y_aEeugIJ3Gvoevmg")]
    [Description(@"Advice response for completion without financial capture.")]
    CompletionAdviceResponse = MessageFunctionCode.CompletionAdviceResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCAV&quot;.
    /// </summary>
    [EnumMember(Value = "DCAV")]
    [IsoId("_Bbd_8S_aEeugIJ3Gvoevmg")]
    [Description(@"Advice for dynamic currency conversion.")]
    CurrencyConversionAdvice = MessageFunctionCode.CurrencyConversionAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice response for the currency conversion from the service provider to the acceptor.
    /// Encoded/decoded by serializers as &quot;DCRR&quot;.
    /// </summary>
    [EnumMember(Value = "DCRR")]
    [IsoId("_Bbd_8y_aEeugIJ3Gvoevmg")]
    [Description(@"Advice response for the currency conversion from the service provider to the acceptor.")]
    CurrencyConversionAdviceResponse = MessageFunctionCode.CurrencyConversionAdviceResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_Bbd_9S_aEeugIJ3Gvoevmg")]
    [Description(@"Request for dynamic currency conversion.")]
    CurrencyConversionRequest = MessageFunctionCode.CurrencyConversionRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response from a dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCP&quot;.
    /// </summary>
    [EnumMember(Value = "DCCP")]
    [IsoId("_Bbd_9y_aEeugIJ3Gvoevmg")]
    [Description(@"Response from a dynamic currency conversion.")]
    CurrencyConversionResponse = MessageFunctionCode.CurrencyConversionResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for diagnostic.
    /// Encoded/decoded by serializers as &quot;DGNP&quot;.
    /// </summary>
    [EnumMember(Value = "DGNP")]
    [IsoId("_Bbd_-S_aEeugIJ3Gvoevmg")]
    [Description(@"Request for diagnostic.")]
    DiagnosticRequest = MessageFunctionCode.DiagnosticRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response for diagnostic.
    /// Encoded/decoded by serializers as &quot;DGNQ&quot;.
    /// </summary>
    [EnumMember(Value = "DGNQ")]
    [IsoId("_Bbd_-y_aEeugIJ3Gvoevmg")]
    [Description(@"Response for diagnostic.")]
    DiagnosticResponse = MessageFunctionCode.DiagnosticResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for authorisation with financial capture.
    /// Encoded/decoded by serializers as &quot;FAUQ&quot;.
    /// </summary>
    [EnumMember(Value = "FAUQ")]
    [IsoId("_Bbd__S_aEeugIJ3Gvoevmg")]
    [Description(@"Request for authorisation with financial capture.")]
    FinancialAuthorisationRequest = MessageFunctionCode.FinancialAuthorisationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response for authorisation with financial capture.
    /// Encoded/decoded by serializers as &quot;FAUP&quot;.
    /// </summary>
    [EnumMember(Value = "FAUP")]
    [IsoId("_Bbd__y_aEeugIJ3Gvoevmg")]
    [Description(@"Response for authorisation with financial capture.")]
    FinancialAuthorisationResponse = MessageFunctionCode.FinancialAuthorisationResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice for completion with financial capture.
    /// Encoded/decoded by serializers as &quot;FCMV&quot;.
    /// </summary>
    [EnumMember(Value = "FCMV")]
    [IsoId("_BbeAAS_aEeugIJ3Gvoevmg")]
    [Description(@"Advice for completion with financial capture.")]
    FinancialCompletionAdvice = MessageFunctionCode.FinancialCompletionAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice response for completion with financial capture.
    /// Encoded/decoded by serializers as &quot;FCMK&quot;.
    /// </summary>
    [EnumMember(Value = "FCMK")]
    [IsoId("_BbeAAy_aEeugIJ3Gvoevmg")]
    [Description(@"Advice response for completion with financial capture.")]
    FinancialCompletionAdviceResponse = MessageFunctionCode.FinancialCompletionAdviceResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice for reversal with financial capture.
    /// Encoded/decoded by serializers as &quot;FRVA&quot;.
    /// </summary>
    [EnumMember(Value = "FRVA")]
    [IsoId("_BbeABS_aEeugIJ3Gvoevmg")]
    [Description(@"Advice for reversal with financial capture.")]
    FinancialReversalAdvice = MessageFunctionCode.FinancialReversalAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice response for reversal with financial capture.
    /// Encoded/decoded by serializers as &quot;FRVR&quot;.
    /// </summary>
    [EnumMember(Value = "FRVR")]
    [IsoId("_BbeABy_aEeugIJ3Gvoevmg")]
    [Description(@"Advice response for reversal with financial capture.")]
    FinancialReversalAdviceResponse = MessageFunctionCode.FinancialReversalAdviceResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for reconciliation.
    /// Encoded/decoded by serializers as &quot;RCLQ&quot;.
    /// </summary>
    [EnumMember(Value = "RCLQ")]
    [IsoId("_BbeACS_aEeugIJ3Gvoevmg")]
    [Description(@"Request for reconciliation.")]
    ReconciliationRequest = MessageFunctionCode.ReconciliationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response for reconciliation.
    /// Encoded/decoded by serializers as &quot;RCLP&quot;.
    /// </summary>
    [EnumMember(Value = "RCLP")]
    [IsoId("_BbeACy_aEeugIJ3Gvoevmg")]
    [Description(@"Response for reconciliation.")]
    ReconciliationResponse = MessageFunctionCode.ReconciliationResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice for reversal without financial capture.
    /// Encoded/decoded by serializers as &quot;RVRA&quot;.
    /// </summary>
    [EnumMember(Value = "RVRA")]
    [IsoId("_BbeADS_aEeugIJ3Gvoevmg")]
    [Description(@"Advice for reversal without financial capture.")]
    ReversalAdvice = MessageFunctionCode.ReversalAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice response for reversal without financial capture.
    /// Encoded/decoded by serializers as &quot;RVRR&quot;.
    /// </summary>
    [EnumMember(Value = "RVRR")]
    [IsoId("_BbeADy_aEeugIJ3Gvoevmg")]
    [Description(@"Advice response for reversal without financial capture.")]
    ReversalAdviceResponse = MessageFunctionCode.ReversalAdviceResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice for a Card Direct Debit.
    /// Encoded/decoded by serializers as &quot;CDDQ&quot;.
    /// </summary>
    [EnumMember(Value = "CDDQ")]
    [IsoId("_BbeAES_aEeugIJ3Gvoevmg")]
    [Description(@"Advice for a Card Direct Debit.")]
    CardDebitAdvice = MessageFunctionCode.CardDebitAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to a Card Direct Debit Advice.
    /// Encoded/decoded by serializers as &quot;CDDK&quot;.
    /// </summary>
    [EnumMember(Value = "CDDK")]
    [IsoId("_BbeAEy_aEeugIJ3Gvoevmg")]
    [Description(@"Response to a Card Direct Debit Advice.")]
    CardDebitAdviceResponse = MessageFunctionCode.CardDebitAdviceResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to initiate a Card Direct Debit.
    /// Encoded/decoded by serializers as &quot;CDDR&quot;.
    /// </summary>
    [EnumMember(Value = "CDDR")]
    [IsoId("_BbeAFS_aEeugIJ3Gvoevmg")]
    [Description(@"Request to initiate a Card Direct Debit.")]
    CardDebitRequest = MessageFunctionCode.CardDebitRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to a Card Direct Debit Request.
    /// Encoded/decoded by serializers as &quot;CDDP&quot;.
    /// </summary>
    [EnumMember(Value = "CDDP")]
    [IsoId("_BbeAFy_aEeugIJ3Gvoevmg")]
    [Description(@"Response to a Card Direct Debit Request.")]
    CardDebitResponse = MessageFunctionCode.CardDebitResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to a transaction advice.
    /// Encoded/decoded by serializers as &quot;TRNR&quot;.
    /// </summary>
    [EnumMember(Value = "TRNR")]
    [IsoId("_BbeAGS_aEeugIJ3Gvoevmg")]
    [Description(@"Response to a transaction advice.")]
    TransactionAdviceResponse = MessageFunctionCode.TransactionAdviceResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advise of the transaction&apos;s processing.
    /// Encoded/decoded by serializers as &quot;TRNA&quot;.
    /// </summary>
    [EnumMember(Value = "TRNA")]
    [IsoId("_BbeAGy_aEeugIJ3Gvoevmg")]
    [Description(@"Advise of the transaction's processing.")]
    TransactionAdvice = MessageFunctionCode.TransactionAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Initiator of the message requests additional information to the receiver.
    /// Encoded/decoded by serializers as &quot;NFRQ&quot;.
    /// </summary>
    [EnumMember(Value = "NFRQ")]
    [IsoId("_JjlWgS_aEeugIJ3Gvoevmg")]
    [Description(@"Initiator of the message requests additional information to the receiver.")]
    NonFinancialRequest = MessageFunctionCode.NonFinancialRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Provision of additional information to the issuer of a NonFinancialRequest.
    /// Encoded/decoded by serializers as &quot;NFRP&quot;.
    /// </summary>
    [EnumMember(Value = "NFRP")]
    [IsoId("_Jo57YS_aEeugIJ3Gvoevmg")]
    [Description(@"Provision of additional information to the issuer of a NonFinancialRequest.")]
    NonFinancialResponse = MessageFunctionCode.NonFinancialResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to receive of a report of transaction from the issuer to the receiver.
    /// Encoded/decoded by serializers as &quot;TRPQ&quot;.
    /// </summary>
    [EnumMember(Value = "TRPQ")]
    [IsoId("_KTaQ8S_aEeugIJ3Gvoevmg")]
    [Description(@"Request to receive of a report of transaction from the issuer to the receiver.")]
    TransactionReportRequest = MessageFunctionCode.TransactionReportRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to provide a sanitized report of transactions.
    /// Encoded/decoded by serializers as &quot;TRPP&quot;.
    /// </summary>
    [EnumMember(Value = "TRPP")]
    [IsoId("_KeBlgS_aEeugIJ3Gvoevmg")]
    [Description(@"Response to provide a sanitized report of transactions.")]
    TransactionReportResponse = MessageFunctionCode.TransactionReportResponse, // same ordinal as derivation source for type conversions
    
}
