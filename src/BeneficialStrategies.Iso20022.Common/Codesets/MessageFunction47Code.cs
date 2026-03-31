// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of message supporting a service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gFqv4ZxIEe-Jl6tBAvMHqA")]
[Description(@"Type of message supporting a service.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction47Code
{
    /// <summary>
    /// Concatenation of multiple exchanges in one file.
    /// Encoded/decoded by serializers as &quot;ATAF&quot;.
    /// </summary>
    [EnumMember(Value = "ATAF")]
    [IsoId("")]
    [Description(@"Concatenation of multiple exchanges in one file.")]
    AcceptorToAcquirerBatchFileExchange = MessageFunctionCode.AcceptorToAcquirerBatchFileExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The initiator requests an authorisation without financial impact to complete the transaction.
    /// Encoded/decoded by serializers as &quot;AUTQ&quot;.
    /// </summary>
    [EnumMember(Value = "AUTQ")]
    [IsoId("")]
    [Description(
        @"The initiator requests an authorisation without financial impact to complete the transaction."
    )]
    AuthorisationRequest = MessageFunctionCode.AuthorisationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer the financial data as a collection of transction.
    /// Encoded/decoded by serializers as &quot;BTCH&quot;.
    /// </summary>
    [EnumMember(Value = "BTCH")]
    [IsoId("")]
    [Description(@"Transfer the financial data as a collection of transction.")]
    BatchTransfer = MessageFunctionCode.BatchTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAQ&quot;.
    /// </summary>
    [EnumMember(Value = "CCAQ")]
    [IsoId("")]
    [Description(@"Request for cancellation.")]
    CancellationRequest = MessageFunctionCode.CancellationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAV&quot;.
    /// </summary>
    [EnumMember(Value = "CCAV")]
    [IsoId("")]
    [Description(@"Advice for cancellation.")]
    CancellationAdvice = MessageFunctionCode.CancellationAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for completion without financial capture.
    /// Encoded/decoded by serializers as &quot;CMPV&quot;.
    /// </summary>
    [EnumMember(Value = "CMPV")]
    [IsoId("")]
    [Description(@"Advice for completion without financial capture.")]
    CompletionAdvice = MessageFunctionCode.CompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCAV&quot;.
    /// </summary>
    [EnumMember(Value = "DCAV")]
    [IsoId("")]
    [Description(@"Advice for dynamic currency conversion.")]
    CurrencyConversionAdvice = MessageFunctionCode.CurrencyConversionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("")]
    [Description(@"Request for dynamic currency conversion.")]
    CurrencyConversionRequest = MessageFunctionCode.CurrencyConversionRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for diagnostic.
    /// Encoded/decoded by serializers as &quot;DGNP&quot;.
    /// </summary>
    [EnumMember(Value = "DGNP")]
    [IsoId("")]
    [Description(@"Request for diagnostic.")]
    DiagnosticRequest = MessageFunctionCode.DiagnosticRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for authorisation with financial capture.
    /// Encoded/decoded by serializers as &quot;FAUQ&quot;.
    /// </summary>
    [EnumMember(Value = "FAUQ")]
    [IsoId("")]
    [Description(@"Request for authorisation with financial capture.")]
    FinancialAuthorisationRequest = MessageFunctionCode.FinancialAuthorisationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for completion with financial capture.
    /// Encoded/decoded by serializers as &quot;FCMV&quot;.
    /// </summary>
    [EnumMember(Value = "FCMV")]
    [IsoId("")]
    [Description(@"Advice for completion with financial capture.")]
    FinancialCompletionAdvice = MessageFunctionCode.FinancialCompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for reversal with financial capture.
    /// Encoded/decoded by serializers as &quot;FRVA&quot;.
    /// </summary>
    [EnumMember(Value = "FRVA")]
    [IsoId("")]
    [Description(@"Advice for reversal with financial capture.")]
    FinancialReversalAdvice = MessageFunctionCode.FinancialReversalAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Initiator of the message requests additional information to the receiver.
    /// Encoded/decoded by serializers as &quot;NFRQ&quot;.
    /// </summary>
    [EnumMember(Value = "NFRQ")]
    [IsoId("")]
    [Description(@"Initiator of the message requests additional information to the receiver.")]
    NonFinancialRequest = MessageFunctionCode.NonFinancialRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for reconciliation.
    /// Encoded/decoded by serializers as &quot;RCLQ&quot;.
    /// </summary>
    [EnumMember(Value = "RCLQ")]
    [IsoId("")]
    [Description(@"Request for reconciliation.")]
    ReconciliationRequest = MessageFunctionCode.ReconciliationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for reversal without financial capture.
    /// Encoded/decoded by serializers as &quot;RVRA&quot;.
    /// </summary>
    [EnumMember(Value = "RVRA")]
    [IsoId("")]
    [Description(@"Advice for reversal without financial capture.")]
    ReversalAdvice = MessageFunctionCode.ReversalAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advise of the transaction's processing.
    /// Encoded/decoded by serializers as &quot;TRNA&quot;.
    /// </summary>
    [EnumMember(Value = "TRNA")]
    [IsoId("")]
    [Description(@"Advise of the transaction's processing.")]
    TransactionAdvice = MessageFunctionCode.TransactionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to receive of a report of transaction from the issuer to the receiver.
    /// Encoded/decoded by serializers as &quot;TRPQ&quot;.
    /// </summary>
    [EnumMember(Value = "TRPQ")]
    [IsoId("")]
    [Description(@"Request to receive of a report of transaction from the issuer to the receiver.")]
    TransactionReportRequest = MessageFunctionCode.TransactionReportRequest, // same ordinal as derivation source for type conversions
}
