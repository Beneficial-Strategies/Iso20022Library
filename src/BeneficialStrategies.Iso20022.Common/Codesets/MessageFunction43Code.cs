// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of message supporting a service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t9w48S_4EeugIJ3Gvoevmg")]
[Description(@"Type of message supporting a service.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction43Code
{
    /// <summary>
    /// Request for authorisation with financial capture.
    /// Encoded/decoded by serializers as &quot;FAUQ&quot;.
    /// </summary>
    [EnumMember(Value = "FAUQ")]
    [IsoId("_uLcvoS_4EeugIJ3Gvoevmg")]
    [Description(@"Request for authorisation with financial capture.")]
    FinancialAuthorisationRequest = MessageFunctionCode.FinancialAuthorisationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAQ&quot;.
    /// </summary>
    [EnumMember(Value = "CCAQ")]
    [IsoId("_uLcvoy_4EeugIJ3Gvoevmg")]
    [Description(@"Request for cancellation.")]
    CancellationRequest = MessageFunctionCode.CancellationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for completion without financial capture.
    /// Encoded/decoded by serializers as &quot;CMPV&quot;.
    /// </summary>
    [EnumMember(Value = "CMPV")]
    [IsoId("_uLcvpS_4EeugIJ3Gvoevmg")]
    [Description(@"Advice for completion without financial capture.")]
    CompletionAdvice = MessageFunctionCode.CompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for diagnostic.
    /// Encoded/decoded by serializers as &quot;DGNP&quot;.
    /// </summary>
    [EnumMember(Value = "DGNP")]
    [IsoId("_uLcvpy_4EeugIJ3Gvoevmg")]
    [Description(@"Request for diagnostic.")]
    DiagnosticRequest = MessageFunctionCode.DiagnosticRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for reconciliation.
    /// Encoded/decoded by serializers as &quot;RCLQ&quot;.
    /// </summary>
    [EnumMember(Value = "RCLQ")]
    [IsoId("_uLcvqS_4EeugIJ3Gvoevmg")]
    [Description(@"Request for reconciliation.")]
    ReconciliationRequest = MessageFunctionCode.ReconciliationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAV&quot;.
    /// </summary>
    [EnumMember(Value = "CCAV")]
    [IsoId("_uLcvqy_4EeugIJ3Gvoevmg")]
    [Description(@"Advice for cancellation.")]
    CancellationAdvice = MessageFunctionCode.CancellationAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer the financial data as a collection of transction.
    /// Encoded/decoded by serializers as &quot;BTCH&quot;.
    /// </summary>
    [EnumMember(Value = "BTCH")]
    [IsoId("_uLcvrS_4EeugIJ3Gvoevmg")]
    [Description(@"Transfer the financial data as a collection of transction.")]
    BatchTransfer = MessageFunctionCode.BatchTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for reversal with financial capture.
    /// Encoded/decoded by serializers as &quot;FRVA&quot;.
    /// </summary>
    [EnumMember(Value = "FRVA")]
    [IsoId("_uLcvry_4EeugIJ3Gvoevmg")]
    [Description(@"Advice for reversal with financial capture.")]
    FinancialReversalAdvice = MessageFunctionCode.FinancialReversalAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The initiator requests an authorisation without financial impact to complete the transaction.
    /// Encoded/decoded by serializers as &quot;AUTQ&quot;.
    /// </summary>
    [EnumMember(Value = "AUTQ")]
    [IsoId("_uLcvsS_4EeugIJ3Gvoevmg")]
    [Description(
        @"The initiator requests an authorisation without financial impact to complete the transaction."
    )]
    AuthorisationRequest = MessageFunctionCode.AuthorisationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for completion with financial capture.
    /// Encoded/decoded by serializers as &quot;FCMV&quot;.
    /// </summary>
    [EnumMember(Value = "FCMV")]
    [IsoId("_uLcvsy_4EeugIJ3Gvoevmg")]
    [Description(@"Advice for completion with financial capture.")]
    FinancialCompletionAdvice = MessageFunctionCode.FinancialCompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_uLcvtS_4EeugIJ3Gvoevmg")]
    [Description(@"Request for dynamic currency conversion.")]
    CurrencyConversionRequest = MessageFunctionCode.CurrencyConversionRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for reversal without financial capture.
    /// Encoded/decoded by serializers as &quot;RVRA&quot;.
    /// </summary>
    [EnumMember(Value = "RVRA")]
    [IsoId("_uLcvty_4EeugIJ3Gvoevmg")]
    [Description(@"Advice for reversal without financial capture.")]
    ReversalAdvice = MessageFunctionCode.ReversalAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCAV&quot;.
    /// </summary>
    [EnumMember(Value = "DCAV")]
    [IsoId("_uLcvuS_4EeugIJ3Gvoevmg")]
    [Description(@"Advice for dynamic currency conversion.")]
    CurrencyConversionAdvice = MessageFunctionCode.CurrencyConversionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advise of the transaction&apos;s processing.
    /// Encoded/decoded by serializers as &quot;TRNA&quot;.
    /// </summary>
    [EnumMember(Value = "TRNA")]
    [IsoId("_uLcvuy_4EeugIJ3Gvoevmg")]
    [Description(@"Advise of the transaction's processing.")]
    TransactionAdvice = MessageFunctionCode.TransactionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Initiator of the message requests additional information to the receiver.
    /// Encoded/decoded by serializers as &quot;NFRQ&quot;.
    /// </summary>
    [EnumMember(Value = "NFRQ")]
    [IsoId("_8gdtYS_4EeugIJ3Gvoevmg")]
    [Description(@"Initiator of the message requests additional information to the receiver.")]
    NonFinancialRequest = MessageFunctionCode.NonFinancialRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to receive of a report of transaction from the issuer to the receiver.
    /// Encoded/decoded by serializers as &quot;TRPQ&quot;.
    /// </summary>
    [EnumMember(Value = "TRPQ")]
    [IsoId("_-BMgUS_4EeugIJ3Gvoevmg")]
    [Description(@"Request to receive of a report of transaction from the issuer to the receiver.")]
    TransactionReportRequest = MessageFunctionCode.TransactionReportRequest, // same ordinal as derivation source for type conversions
}
