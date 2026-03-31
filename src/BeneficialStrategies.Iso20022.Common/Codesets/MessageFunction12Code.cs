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
[IsoId("_5ke4MbDDEeamYaqfhG1ZuA")]
[Description(@"Type of message supporting a service.")]
[DerivedFrom(typeof(MessageFunctionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MessageFunction12Code>))]
#endif
public enum MessageFunction12Code
{
    /// <summary>
    /// Request for authorisation with financial capture.
    /// Encoded/decoded by serializers as &quot;FAUQ&quot;.
    /// </summary>
    [EnumMember(Value = "FAUQ")]
    [IsoId("_5vGz0bDDEeamYaqfhG1ZuA")]
    [Description(@"Request for authorisation with financial capture.")]
    FinancialAuthorisationRequest = MessageFunctionCode.FinancialAuthorisationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAQ&quot;.
    /// </summary>
    [EnumMember(Value = "CCAQ")]
    [IsoId("_5vGz07DDEeamYaqfhG1ZuA")]
    [Description(@"Request for cancellation.")]
    CancellationRequest = MessageFunctionCode.CancellationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for completion without financial capture.
    /// Encoded/decoded by serializers as &quot;CMPV&quot;.
    /// </summary>
    [EnumMember(Value = "CMPV")]
    [IsoId("_5vGz1bDDEeamYaqfhG1ZuA")]
    [Description(@"Advice for completion without financial capture.")]
    CompletionAdvice = MessageFunctionCode.CompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for diagnostic.
    /// Encoded/decoded by serializers as &quot;DGNP&quot;.
    /// </summary>
    [EnumMember(Value = "DGNP")]
    [IsoId("_5vGz17DDEeamYaqfhG1ZuA")]
    [Description(@"Request for diagnostic.")]
    DiagnosticRequest = MessageFunctionCode.DiagnosticRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for reconciliation.
    /// Encoded/decoded by serializers as &quot;RCLQ&quot;.
    /// </summary>
    [EnumMember(Value = "RCLQ")]
    [IsoId("_5vGz2bDDEeamYaqfhG1ZuA")]
    [Description(@"Request for reconciliation.")]
    ReconciliationRequest = MessageFunctionCode.ReconciliationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAV&quot;.
    /// </summary>
    [EnumMember(Value = "CCAV")]
    [IsoId("_5vGz27DDEeamYaqfhG1ZuA")]
    [Description(@"Advice for cancellation.")]
    CancellationAdvice = MessageFunctionCode.CancellationAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer the financial data as a collection of transction.
    /// Encoded/decoded by serializers as &quot;BTCH&quot;.
    /// </summary>
    [EnumMember(Value = "BTCH")]
    [IsoId("_5vGz3bDDEeamYaqfhG1ZuA")]
    [Description(@"Transfer the financial data as a collection of transction.")]
    BatchTransfer = MessageFunctionCode.BatchTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for reversal with financial capture.
    /// Encoded/decoded by serializers as &quot;FRVA&quot;.
    /// </summary>
    [EnumMember(Value = "FRVA")]
    [IsoId("_5vGz37DDEeamYaqfhG1ZuA")]
    [Description(@"Advice for reversal with financial capture.")]
    FinancialReversalAdvice = MessageFunctionCode.FinancialReversalAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The initiator requests an authorisation without financial impact to complete the transaction.
    /// Encoded/decoded by serializers as &quot;AUTQ&quot;.
    /// </summary>
    [EnumMember(Value = "AUTQ")]
    [IsoId("_5vGz4bDDEeamYaqfhG1ZuA")]
    [Description(
        @"The initiator requests an authorisation without financial impact to complete the transaction."
    )]
    AuthorisationRequest = MessageFunctionCode.AuthorisationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for completion with financial capture.
    /// Encoded/decoded by serializers as &quot;FCMV&quot;.
    /// </summary>
    [EnumMember(Value = "FCMV")]
    [IsoId("_5vGz47DDEeamYaqfhG1ZuA")]
    [Description(@"Advice for completion with financial capture.")]
    FinancialCompletionAdvice = MessageFunctionCode.FinancialCompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_5vHa4LDDEeamYaqfhG1ZuA")]
    [Description(@"Request for dynamic currency conversion.")]
    CurrencyConversionRequest = MessageFunctionCode.CurrencyConversionRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice for reversal without financial capture.
    /// Encoded/decoded by serializers as &quot;RVRA&quot;.
    /// </summary>
    [EnumMember(Value = "RVRA")]
    [IsoId("_Ks8N8bDEEeamYaqfhG1ZuA")]
    [Description(@"Advice for reversal without financial capture.")]
    ReversalAdvice = MessageFunctionCode.ReversalAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice response for the currency conversion from the service provider to the acceptor.
    /// Encoded/decoded by serializers as &quot;DCRR&quot;.
    /// </summary>
    [EnumMember(Value = "DCRR")]
    [IsoId("_mPtmcbDEEeamYaqfhG1ZuA")]
    [Description(
        @"Advice response for the currency conversion from the service provider to the acceptor."
    )]
    CurrencyConversionAdviceResponse = MessageFunctionCode.CurrencyConversionAdviceResponse, // same ordinal as derivation source for type conversions
}
