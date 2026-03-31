// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of process related to a specific message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUvzFgEcEeCQm6a_G2yO_w_-366537525")]
[Description(@"Type of process related to a specific message.")]
[Derivations(
    typeof(MessageFunction25Code),
    typeof(MessageFunction40Code),
    typeof(MessageFunction12Code),
    typeof(MessageFunction17Code),
    typeof(MessageFunction44Code),
    typeof(MessageFunction29Code),
    typeof(MessageFunction39Code),
    typeof(MessageFunction9Code),
    typeof(MessageFunction15Code),
    typeof(MessageFunction5Code),
    typeof(MessageFunction41Code),
    typeof(MessageFunction2Code),
    typeof(MessageFunction13Code),
    typeof(MessageFunction23Code),
    typeof(MessageFunction6Code),
    typeof(MessageFunction4Code),
    typeof(MessageFunction46Code),
    typeof(MessageFunction27Code),
    typeof(MessageFunction18Code),
    typeof(MessageFunction7Code),
    typeof(MessageFunction8Code),
    typeof(MessageFunction16Code),
    typeof(MessageFunction14Code),
    typeof(MessageFunction45Code),
    typeof(MessageFunction1Code),
    typeof(MessageFunction43Code),
    typeof(MessageFunction11Code),
    typeof(MessageFunction3Code),
    typeof(MessageFunction10Code),
    typeof(MessageFunction37Code),
    typeof(MessageFunction42Code),
    typeof(MessageFunction20Code)
)]
public enum MessageFunctionCode
{
    /// <summary>
    /// The initiator requests an authorisation without financial impact to complete the transaction.
    /// Encoded/decoded by serializers as &quot;AUTQ&quot;.
    /// </summary>
    [EnumMember(Value = "AUTQ")]
    [IsoId("_TUvzFwEcEeCQm6a_G2yO_w_-1378428132")]
    [Description(
        @"The initiator requests an authorisation without financial impact to complete the transaction."
    )]
    AuthorisationRequest,

    /// <summary>
    /// Response for authorisation without financial capture.
    /// Encoded/decoded by serializers as &quot;AUTP&quot;.
    /// </summary>
    [EnumMember(Value = "AUTP")]
    [IsoId("_TUvzGAEcEeCQm6a_G2yO_w_906582306")]
    [Description(@"Response for authorisation without financial capture.")]
    AuthorisationResponse,

    /// <summary>
    /// Request for authorisation with financial capture.
    /// Encoded/decoded by serializers as &quot;FAUQ&quot;.
    /// </summary>
    [EnumMember(Value = "FAUQ")]
    [IsoId("_TUvzGQEcEeCQm6a_G2yO_w_1116098920")]
    [Description(@"Request for authorisation with financial capture.")]
    FinancialAuthorisationRequest,

    /// <summary>
    /// Response for authorisation with financial capture.
    /// Encoded/decoded by serializers as &quot;FAUP&quot;.
    /// </summary>
    [EnumMember(Value = "FAUP")]
    [IsoId("_TUvzGgEcEeCQm6a_G2yO_w_-717572302")]
    [Description(@"Response for authorisation with financial capture.")]
    FinancialAuthorisationResponse,

    /// <summary>
    /// Advice for completion without financial capture.
    /// Encoded/decoded by serializers as &quot;CMPV&quot;.
    /// </summary>
    [EnumMember(Value = "CMPV")]
    [IsoId("_TUvzGwEcEeCQm6a_G2yO_w_-393346155")]
    [Description(@"Advice for completion without financial capture.")]
    CompletionAdvice,

    /// <summary>
    /// Advice response for completion without financial capture.
    /// Encoded/decoded by serializers as &quot;CMPK&quot;.
    /// </summary>
    [EnumMember(Value = "CMPK")]
    [IsoId("_TUvzHAEcEeCQm6a_G2yO_w_-79327425")]
    [Description(@"Advice response for completion without financial capture.")]
    CompletionAdviceResponse,

    /// <summary>
    /// Advice for completion with financial capture.
    /// Encoded/decoded by serializers as &quot;FCMV&quot;.
    /// </summary>
    [EnumMember(Value = "FCMV")]
    [IsoId("_TUvzHQEcEeCQm6a_G2yO_w_-159306308")]
    [Description(@"Advice for completion with financial capture.")]
    FinancialCompletionAdvice,

    /// <summary>
    /// Advice response for completion with financial capture.
    /// Encoded/decoded by serializers as &quot;FCMK&quot;.
    /// </summary>
    [EnumMember(Value = "FCMK")]
    [IsoId("_TUvzHgEcEeCQm6a_G2yO_w_-421770368")]
    [Description(@"Advice response for completion with financial capture.")]
    FinancialCompletionAdviceResponse,

    /// <summary>
    /// Advice for reversal without financial capture.
    /// Encoded/decoded by serializers as &quot;RVRA&quot;.
    /// </summary>
    [EnumMember(Value = "RVRA")]
    [IsoId("_TUvzHwEcEeCQm6a_G2yO_w_-116796232")]
    [Description(@"Advice for reversal without financial capture.")]
    ReversalAdvice,

    /// <summary>
    /// Advice response for reversal without financial capture.
    /// Encoded/decoded by serializers as &quot;RVRR&quot;.
    /// </summary>
    [EnumMember(Value = "RVRR")]
    [IsoId("_TUvzIAEcEeCQm6a_G2yO_w_495669693")]
    [Description(@"Advice response for reversal without financial capture.")]
    ReversalAdviceResponse,

    /// <summary>
    /// Advice for reversal with financial capture.
    /// Encoded/decoded by serializers as &quot;FRVA&quot;.
    /// </summary>
    [EnumMember(Value = "FRVA")]
    [IsoId("_TUvzIQEcEeCQm6a_G2yO_w_-1325398086")]
    [Description(@"Advice for reversal with financial capture.")]
    FinancialReversalAdvice,

    /// <summary>
    /// Advice response for reversal with financial capture.
    /// Encoded/decoded by serializers as &quot;FRVR&quot;.
    /// </summary>
    [EnumMember(Value = "FRVR")]
    [IsoId("_TU5kEAEcEeCQm6a_G2yO_w_340919462")]
    [Description(@"Advice response for reversal with financial capture.")]
    FinancialReversalAdviceResponse,

    /// <summary>
    /// Request for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAQ&quot;.
    /// </summary>
    [EnumMember(Value = "CCAQ")]
    [IsoId("_TU5kEQEcEeCQm6a_G2yO_w_881952388")]
    [Description(@"Request for cancellation.")]
    CancellationRequest,

    /// <summary>
    /// Response for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAP&quot;.
    /// </summary>
    [EnumMember(Value = "CCAP")]
    [IsoId("_TU5kEgEcEeCQm6a_G2yO_w_-38885355")]
    [Description(@"Response for cancellation.")]
    CancellationResponse,

    /// <summary>
    /// Advice for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAV&quot;.
    /// </summary>
    [EnumMember(Value = "CCAV")]
    [IsoId("_TU5kEwEcEeCQm6a_G2yO_w_1946616601")]
    [Description(@"Advice for cancellation.")]
    CancellationAdvice,

    /// <summary>
    /// Advice response for cancellation.
    /// Encoded/decoded by serializers as &quot;CCAK&quot;.
    /// </summary>
    [EnumMember(Value = "CCAK")]
    [IsoId("_TU5kFAEcEeCQm6a_G2yO_w_556834881")]
    [Description(@"Advice response for cancellation.")]
    CancellationAdviceResponse,

    /// <summary>
    /// Request for diagnostic.
    /// Encoded/decoded by serializers as &quot;DGNP&quot;.
    /// </summary>
    [EnumMember(Value = "DGNP")]
    [IsoId("_TU5kFQEcEeCQm6a_G2yO_w_2020896569")]
    [Description(@"Request for diagnostic.")]
    DiagnosticRequest,

    /// <summary>
    /// Response for diagnostic.
    /// Encoded/decoded by serializers as &quot;DGNQ&quot;.
    /// </summary>
    [EnumMember(Value = "DGNQ")]
    [IsoId("_TU5kFgEcEeCQm6a_G2yO_w_-81954896")]
    [Description(@"Response for diagnostic.")]
    DiagnosticResponse,

    /// <summary>
    /// Request for reconciliation.
    /// Encoded/decoded by serializers as &quot;RCLQ&quot;.
    /// </summary>
    [EnumMember(Value = "RCLQ")]
    [IsoId("_TU5kFwEcEeCQm6a_G2yO_w_-872063342")]
    [Description(@"Request for reconciliation.")]
    ReconciliationRequest,

    /// <summary>
    /// Response for reconciliation.
    /// Encoded/decoded by serializers as &quot;RCLP&quot;.
    /// </summary>
    [EnumMember(Value = "RCLP")]
    [IsoId("_TU5kGAEcEeCQm6a_G2yO_w_952002003")]
    [Description(@"Response for reconciliation.")]
    ReconciliationResponse,

    /// <summary>
    /// Transfer the financial data as a collection of transction.
    /// Encoded/decoded by serializers as &quot;BTCH&quot;.
    /// </summary>
    [EnumMember(Value = "BTCH")]
    [IsoId("_KVkWYH1DEeCF8NjrBemJWQ_390722880")]
    [Description(@"Transfer the financial data as a collection of transction.")]
    BatchTransfer,

    /// <summary>
    /// Reject a request or an advice.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_TU5kGQEcEeCQm6a_G2yO_w_-1349912593")]
    [Description(@"Reject a request or an advice.")]
    Rejection,

    /// <summary>
    /// Message function is a response.
    /// Encoded/decoded by serializers as &quot;RESP&quot;.
    /// </summary>
    [EnumMember(Value = "RESP")]
    [IsoId("_TU5kGgEcEeCQm6a_G2yO_w_-2144652866")]
    [Description(@"Message function is a response.")]
    Response,

    /// <summary>
    /// Message function is a request.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_TU5kGwEcEeCQm6a_G2yO_w_1972195758")]
    [Description(@"Message function is a request.")]
    Request,

    /// <summary>
    /// Request for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_NpHfwC9HEeOlZIh7PImd0A")]
    [Description(@"Request for dynamic currency conversion.")]
    CurrencyConversionRequest,

    /// <summary>
    /// Response from a dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCP&quot;.
    /// </summary>
    [EnumMember(Value = "DCCP")]
    [IsoId("_Tp_dEC9HEeOlZIh7PImd0A")]
    [Description(@"Response from a dynamic currency conversion.")]
    CurrencyConversionResponse,

    /// <summary>
    /// Advice of transaction totals from an acquirer.
    /// Encoded/decoded by serializers as &quot;RCAV&quot;.
    /// </summary>
    [EnumMember(Value = "RCAV")]
    [IsoId("_3tyd4Hq_EeSA34QF-FhTBw")]
    [Description(@"Advice of transaction totals from an acquirer.")]
    AcquirerReconciliationAdvice,

    /// <summary>
    /// Acknowledgement from an issuer or a processor of an acquirer reconciliation advice.
    /// Encoded/decoded by serializers as &quot;RCAK&quot;.
    /// </summary>
    [EnumMember(Value = "RCAK")]
    [IsoId("__YhU8Hq_EeSA34QF-FhTBw")]
    [Description(
        @"Acknowledgement from an issuer or a processor of an acquirer reconciliation advice."
    )]
    AcquirerReconciliationAdviceResponse,

    /// <summary>
    /// Notification of transaction totals from an acquirer.
    /// Encoded/decoded by serializers as &quot;RCAN&quot;.
    /// </summary>
    [EnumMember(Value = "RCAN")]
    [IsoId("_DOEDIHrAEeSA34QF-FhTBw")]
    [Description(@"Notification of transaction totals from an acquirer.")]
    AcquirerReconciliationNotification,

    /// <summary>
    /// Request of transaction totals exchange from an acquirer.
    /// Encoded/decoded by serializers as &quot;RCAQ&quot;.
    /// </summary>
    [EnumMember(Value = "RCAQ")]
    [IsoId("_LANw0HrAEeSA34QF-FhTBw")]
    [Description(@"Request of transaction totals exchange from an acquirer.")]
    AcquirerReconciliationRequest,

    /// <summary>
    /// Response from an issuer or a processor to an acquirer reconciliation request.
    /// Encoded/decoded by serializers as &quot;RCAP&quot;.
    /// </summary>
    [EnumMember(Value = "RCAP")]
    [IsoId("_QoFYQHrAEeSA34QF-FhTBw")]
    [Description(@"Response from an issuer or a processor to an acquirer reconciliation request.")]
    AcquirerReconciliationResponse,

    /// <summary>
    /// Reject of a message by an acquirer.
    /// Encoded/decoded by serializers as &quot;REJA&quot;.
    /// </summary>
    [EnumMember(Value = "REJA")]
    [IsoId("_UVdo8HrAEeSA34QF-FhTBw")]
    [Description(@"Reject of a message by an acquirer.")]
    AcquirerReject,

    /// <summary>
    /// Advice of transaction totals from a processor.
    /// Encoded/decoded by serializers as &quot;RCPV&quot;.
    /// </summary>
    [EnumMember(Value = "RCPV")]
    [IsoId("_aZu4gHrAEeSA34QF-FhTBw")]
    [Description(@"Advice of transaction totals from a processor.")]
    AgentReconciliationAdvice,

    /// <summary>
    /// Acknowledgement from an issuer or an acquirer of a processor reconciliation advice.
    /// Encoded/decoded by serializers as &quot;RCPK&quot;.
    /// </summary>
    [EnumMember(Value = "RCPK")]
    [IsoId("_y7hMQHrAEeSA34QF-FhTBw")]
    [Description(
        @"Acknowledgement from an issuer or an acquirer of a processor reconciliation advice."
    )]
    AgentReconciliationAdviceResponse,

    /// <summary>
    /// Notification of transaction totals from a processor.
    /// Encoded/decoded by serializers as &quot;RCPN&quot;.
    /// </summary>
    [EnumMember(Value = "RCPN")]
    [IsoId("_39MWYHrAEeSA34QF-FhTBw")]
    [Description(@"Notification of transaction totals from a processor.")]
    AgentReconciliationNotification,

    /// <summary>
    /// Request of transaction totals exchange from a processor.
    /// Encoded/decoded by serializers as &quot;RCPQ&quot;.
    /// </summary>
    [EnumMember(Value = "RCPQ")]
    [IsoId("_6k-4AHrAEeSA34QF-FhTBw")]
    [Description(@"Request of transaction totals exchange from a processor.")]
    AgentReconciliationRequest,

    /// <summary>
    /// Response from an issuer or an acquirer to a processor reconciliation request.
    /// Encoded/decoded by serializers as &quot;RCPP&quot;.
    /// </summary>
    [EnumMember(Value = "RCPP")]
    [IsoId("_AeJDwHrBEeSA34QF-FhTBw")]
    [Description(@"Response from an issuer or an acquirer to a processor reconciliation request.")]
    AgentReconciliationResponse,

    /// <summary>
    /// Reject of a message by an agent.
    /// Encoded/decoded by serializers as &quot;REJP&quot;.
    /// </summary>
    [EnumMember(Value = "REJP")]
    [IsoId("_DKGTsHrBEeSA34QF-FhTBw")]
    [Description(@"Reject of a message by an agent.")]
    AgentReject,

    /// <summary>
    /// Initiator of the message advises the recipient about the result of an authorisation already performed.
    /// Encoded/decoded by serializers as &quot;AUTV&quot;.
    /// </summary>
    [EnumMember(Value = "AUTV")]
    [IsoId("_JhzcoHrBEeSA34QF-FhTBw")]
    [Description(
        @"Initiator of the message advises the recipient about the result of an authorisation already performed."
    )]
    AuthorisationAdvice,

    /// <summary>
    /// Response to an AuthorisationAdvice.
    /// Encoded/decoded by serializers as &quot;AUTK&quot;.
    /// </summary>
    [EnumMember(Value = "AUTK")]
    [IsoId("_QUhGkHrBEeSA34QF-FhTBw")]
    [Description(@"Response to an AuthorisationAdvice.")]
    AuthorisationAdviceResponse,

    /// <summary>
    /// Information about an authorisation.
    /// Encoded/decoded by serializers as &quot;AUTN&quot;.
    /// </summary>
    [EnumMember(Value = "AUTN")]
    [IsoId("_VUoKcHrBEeSA34QF-FhTBw")]
    [Description(@"Information about an authorisation.")]
    AuthorisationNotification,

    /// <summary>
    /// Initiator of the message advises the receptor that an authorisation has been successfully delivered or completed with a final amount, and requests the clearing of the transaction.
    /// Encoded/decoded by serializers as &quot;FNCV&quot;.
    /// </summary>
    [EnumMember(Value = "FNCV")]
    [IsoId("_YeF1wHrBEeSA34QF-FhTBw")]
    [Description(
        @"Initiator of the message advises the receptor that an authorisation has been successfully delivered or completed with a final amount, and requests the clearing of the transaction."
    )]
    FinancialAdvice,

    /// <summary>
    /// Response to a FinancialAdvice.
    /// Encoded/decoded by serializers as &quot;FNCK&quot;.
    /// </summary>
    [EnumMember(Value = "FNCK")]
    [IsoId("_CuqfcHrCEeSA34QF-FhTBw")]
    [Description(@"Response to a FinancialAdvice.")]
    FinancialAdviceResponse,

    /// <summary>
    /// Initiator requests the clearing of the transaction.
    /// Encoded/decoded by serializers as &quot;FNCN&quot;.
    /// </summary>
    [EnumMember(Value = "FNCN")]
    [IsoId("_GQzJcHrCEeSA34QF-FhTBw")]
    [Description(@"Initiator requests the clearing of the transaction.")]
    FinancialNotification,

    /// <summary>
    /// Initiator of the message requests both the authorisation and the clearing of the transaction.
    /// Encoded/decoded by serializers as &quot;FNCQ&quot;.
    /// </summary>
    [EnumMember(Value = "FNCQ")]
    [IsoId("_Mb1IUHrCEeSA34QF-FhTBw")]
    [Description(
        @"Initiator of the message requests both the authorisation and the clearing of the transaction."
    )]
    FinancialRequest,

    /// <summary>
    /// Response to a FinancialRequest.
    /// Encoded/decoded by serializers as &quot;FNCP&quot;.
    /// </summary>
    [EnumMember(Value = "FNCP")]
    [IsoId("_THM0IHrCEeSA34QF-FhTBw")]
    [Description(@"Response to a FinancialRequest.")]
    FinancialResponse,

    /// <summary>
    /// Advice of transaction totals from an issuer.
    /// Encoded/decoded by serializers as &quot;RCIV&quot;.
    /// </summary>
    [EnumMember(Value = "RCIV")]
    [IsoId("_XpesgHrCEeSA34QF-FhTBw")]
    [Description(@"Advice of transaction totals from an issuer.")]
    IssuerReconciliationAdvice,

    /// <summary>
    /// Acknowledgement from an acquirer or a processor of an issuer reconciliation advice.
    /// Encoded/decoded by serializers as &quot;RCIK&quot;.
    /// </summary>
    [EnumMember(Value = "RCIK")]
    [IsoId("_bedaAHrCEeSA34QF-FhTBw")]
    [Description(
        @"Acknowledgement from an acquirer or a processor of an issuer reconciliation advice."
    )]
    IssuerReconciliationAdviceResponse,

    /// <summary>
    /// Notification of transaction totals from an issuer.
    /// Encoded/decoded by serializers as &quot;RCIN&quot;.
    /// </summary>
    [EnumMember(Value = "RCIN")]
    [IsoId("_fSGDsHrCEeSA34QF-FhTBw")]
    [Description(@"Notification of transaction totals from an issuer.")]
    IssuerReconciliationNotification,

    /// <summary>
    /// Request of transaction totals exchange from an issuer.
    /// Encoded/decoded by serializers as &quot;RCIQ&quot;.
    /// </summary>
    [EnumMember(Value = "RCIQ")]
    [IsoId("_kHhhkHrCEeSA34QF-FhTBw")]
    [Description(@"Request of transaction totals exchange from an issuer.")]
    IssuerReconciliationRequest,

    /// <summary>
    /// Response from an acquirer or a processor to an issuer reconciliation request.
    /// Encoded/decoded by serializers as &quot;RCIP&quot;.
    /// </summary>
    [EnumMember(Value = "RCIP")]
    [IsoId("_opkJYHrCEeSA34QF-FhTBw")]
    [Description(@"Response from an acquirer or a processor to an issuer reconciliation request.")]
    IssuerReconciliationResponse,

    /// <summary>
    /// Reject of a message by an issuer.
    /// Encoded/decoded by serializers as &quot;REJI&quot;.
    /// </summary>
    [EnumMember(Value = "REJI")]
    [IsoId("_umv5gHrCEeSA34QF-FhTBw")]
    [Description(@"Reject of a message by an issuer.")]
    IssuerReject,

    /// <summary>
    /// Advise of a performed network management service.
    /// Encoded/decoded by serializers as &quot;MGTV&quot;.
    /// </summary>
    [EnumMember(Value = "MGTV")]
    [IsoId("_3onioHrCEeSA34QF-FhTBw")]
    [Description(@"Advise of a performed network management service.")]
    NetworkManagementAdvice,

    /// <summary>
    /// Response to a NetworkManagementAdvice.
    /// Encoded/decoded by serializers as &quot;MGTK&quot;.
    /// </summary>
    [EnumMember(Value = "MGTK")]
    [IsoId("_ZKGf0HrEEeSA34QF-FhTBw")]
    [Description(@"Response to a NetworkManagementAdvice.")]
    NetworkManagementAdviceResponse,

    /// <summary>
    /// Request of a network management service.
    /// Encoded/decoded by serializers as &quot;MGTQ&quot;.
    /// </summary>
    [EnumMember(Value = "MGTQ")]
    [IsoId("_hGZA8HrEEeSA34QF-FhTBw")]
    [Description(@"Request of a network management service.")]
    NetworkManagementRequest,

    /// <summary>
    /// Response to a NetworkManagementRequest.
    /// Encoded/decoded by serializers as &quot;MGTP&quot;.
    /// </summary>
    [EnumMember(Value = "MGTP")]
    [IsoId("_lk-FEHrEEeSA34QF-FhTBw")]
    [Description(@"Response to a NetworkManagementRequest.")]
    NetworkManagementResponse,

    /// <summary>
    /// Advise of a performed key update.
    /// Encoded/decoded by serializers as &quot;KEYV&quot;.
    /// </summary>
    [EnumMember(Value = "KEYV")]
    [IsoId("_qCQvwHrEEeSA34QF-FhTBw")]
    [Description(@"Advise of a performed key update.")]
    KeyExchangeAdvice,

    /// <summary>
    /// Response to a KeyExchangeAdvice.
    /// Encoded/decoded by serializers as &quot;KEYK&quot;.
    /// </summary>
    [EnumMember(Value = "KEYK")]
    [IsoId("_t_R-8HrEEeSA34QF-FhTBw")]
    [Description(@"Response to a KeyExchangeAdvice.")]
    KeyExchangeAdviceResponse,

    /// <summary>
    /// Request of a key exchange.
    /// Encoded/decoded by serializers as &quot;KEYQ&quot;.
    /// </summary>
    [EnumMember(Value = "KEYQ")]
    [IsoId("_xrLB4HrEEeSA34QF-FhTBw")]
    [Description(@"Request of a key exchange.")]
    KeyExchangeRequest,

    /// <summary>
    /// Response to a KeyExchangeRequest.
    /// Encoded/decoded by serializers as &quot;KEYP&quot;.
    /// </summary>
    [EnumMember(Value = "KEYP")]
    [IsoId("_1dUd0HrEEeSA34QF-FhTBw")]
    [Description(@"Response to a KeyExchangeRequest.")]
    KeyExchangeResponse,

    /// <summary>
    /// Reversal advice of an authorisation or a financial message.
    /// Encoded/decoded by serializers as &quot;REVV&quot;.
    /// </summary>
    [EnumMember(Value = "REVV")]
    [IsoId("_576JAHrEEeSA34QF-FhTBw")]
    [Description(@"Reversal advice of an authorisation or a financial message.")]
    AcquirerReversalAdvice,

    /// <summary>
    /// Response to a reversal advice.
    /// Encoded/decoded by serializers as &quot;REVK&quot;.
    /// </summary>
    [EnumMember(Value = "REVK")]
    [IsoId("_-Xx3YHrEEeSA34QF-FhTBw")]
    [Description(@"Response to a reversal advice.")]
    AcquirerReversalAdviceResponse,

    /// <summary>
    /// Reversal notification of an authorisation or a financial message.
    /// Encoded/decoded by serializers as &quot;REVN&quot;.
    /// </summary>
    [EnumMember(Value = "REVN")]
    [IsoId("_DUqBEHrFEeSA34QF-FhTBw")]
    [Description(@"Reversal notification of an authorisation or a financial message.")]
    AcquirerReversalNotification,

    /// <summary>
    /// Reversal request of an authorisation or a financial message.
    /// Encoded/decoded by serializers as &quot;REVQ&quot;.
    /// </summary>
    [EnumMember(Value = "REVQ")]
    [IsoId("_GkrnYHrFEeSA34QF-FhTBw")]
    [Description(@"Reversal request of an authorisation or a financial message.")]
    AcquirerReversalRequest,

    /// <summary>
    /// Response to a reversal request.
    /// Encoded/decoded by serializers as &quot;REVP&quot;.
    /// </summary>
    [EnumMember(Value = "REVP")]
    [IsoId("_Kx-uQHrFEeSA34QF-FhTBw")]
    [Description(@"Response to a reversal request.")]
    AcquirerReversalResponse,

    /// <summary>
    /// Provide the ATM counters resettting those that are applicable.
    /// Encoded/decoded by serializers as &quot;BALN&quot;.
    /// </summary>
    [EnumMember(Value = "BALN")]
    [IsoId("_c5PNIInwEeS9F4Qrq_eaVA")]
    [Description(@"Provide the ATM counters resettting those that are applicable.")]
    ATMBalance,

    /// <summary>
    /// Advice of an ATM transaction completion.
    /// Encoded/decoded by serializers as &quot;CMPD&quot;.
    /// </summary>
    [EnumMember(Value = "CMPD")]
    [IsoId("_heKJ0InwEeS9F4Qrq_eaVA")]
    [Description(@"Advice of an ATM transaction completion.")]
    ATMCompletionAdvice,

    /// <summary>
    /// Acknowledgement of a completion advice.
    /// Encoded/decoded by serializers as &quot;CMPA&quot;.
    /// </summary>
    [EnumMember(Value = "CMPA")]
    [IsoId("_kg8lYInwEeS9F4Qrq_eaVA")]
    [Description(@"Acknowledgement of a completion advice.")]
    ATMCompletionAcknowledgement,

    /// <summary>
    /// Global ATM commands.
    /// Encoded/decoded by serializers as &quot;ACMD&quot;.
    /// </summary>
    [EnumMember(Value = "ACMD")]
    [IsoId("_nhdJAInwEeS9F4Qrq_eaVA")]
    [Description(@"Global ATM commands.")]
    ATMControl,

    /// <summary>
    /// Maintenance commands to perform.
    /// Encoded/decoded by serializers as &quot;DVCC&quot;.
    /// </summary>
    [EnumMember(Value = "DVCC")]
    [IsoId("_rNgkAInwEeS9F4Qrq_eaVA")]
    [Description(@"Maintenance commands to perform.")]
    ATMDeviceControl,

    /// <summary>
    /// Request for a diagnostic.
    /// Encoded/decoded by serializers as &quot;DIAQ&quot;.
    /// </summary>
    [EnumMember(Value = "DIAQ")]
    [IsoId("_vzyLkInwEeS9F4Qrq_eaVA")]
    [Description(@"Request for a diagnostic.")]
    ATMDiagnosticRequest,

    /// <summary>
    /// Response to a diagnostic request.
    /// Encoded/decoded by serializers as &quot;DIAP&quot;.
    /// </summary>
    [EnumMember(Value = "DIAP")]
    [IsoId("_zMWp4InwEeS9F4Qrq_eaVA")]
    [Description(@"Response to a diagnostic request.")]
    ATMDiagnosticResponse,

    /// <summary>
    /// Global status of the ATM.
    /// Encoded/decoded by serializers as &quot;GSTS&quot;.
    /// </summary>
    [EnumMember(Value = "GSTS")]
    [IsoId("_2TA40InwEeS9F4Qrq_eaVA")]
    [Description(@"Global status of the ATM.")]
    ATMGlobalStatus,

    /// <summary>
    /// Request for an inquiry.
    /// Encoded/decoded by serializers as &quot;INQQ&quot;.
    /// </summary>
    [EnumMember(Value = "INQQ")]
    [IsoId("_5iUtcInwEeS9F4Qrq_eaVA")]
    [Description(@"Request for an inquiry.")]
    ATMInquiryRequest,

    /// <summary>
    /// Response to an inquiry request.
    /// Encoded/decoded by serializers as &quot;INQP&quot;.
    /// </summary>
    [EnumMember(Value = "INQP")]
    [IsoId("_9TWvEInwEeS9F4Qrq_eaVA")]
    [Description(@"Response to an inquiry request.")]
    ATMInquiryResponse,

    /// <summary>
    /// Request for a key download.
    /// Encoded/decoded by serializers as &quot;KYAQ&quot;.
    /// </summary>
    [EnumMember(Value = "KYAQ")]
    [IsoId("___ygIInwEeS9F4Qrq_eaVA")]
    [Description(@"Request for a key download.")]
    ATMKeyDownloadRequest,

    /// <summary>
    /// Response to a cardholder PIN management request.
    /// Encoded/decoded by serializers as &quot;PINP&quot;.
    /// </summary>
    [EnumMember(Value = "PINP")]
    [IsoId("_DMlMQInxEeS9F4Qrq_eaVA")]
    [Description(@"Response to a cardholder PIN management request.")]
    ATMPINManagementResponse,

    /// <summary>
    /// Request for a cardholder PIN management.
    /// Encoded/decoded by serializers as &quot;PINQ&quot;.
    /// </summary>
    [EnumMember(Value = "PINQ")]
    [IsoId("_GETAQInxEeS9F4Qrq_eaVA")]
    [Description(@"Request for a cardholder PIN management.")]
    ATMPINManagementRequest,

    /// <summary>
    /// Response to a key download.
    /// Encoded/decoded by serializers as &quot;KYAP&quot;.
    /// </summary>
    [EnumMember(Value = "KYAP")]
    [IsoId("_KNgRUInxEeS9F4Qrq_eaVA")]
    [Description(@"Response to a key download.")]
    ATMKeyDownloadResponse,

    /// <summary>
    /// Rejected request message.
    /// Encoded/decoded by serializers as &quot;RJAQ&quot;.
    /// </summary>
    [EnumMember(Value = "RJAQ")]
    [IsoId("_M2ZmMInxEeS9F4Qrq_eaVA")]
    [Description(@"Rejected request message.")]
    ATMRequestReject,

    /// <summary>
    /// Rejected response message.
    /// Encoded/decoded by serializers as &quot;RJAP&quot;.
    /// </summary>
    [EnumMember(Value = "RJAP")]
    [IsoId("_QXCbYInxEeS9F4Qrq_eaVA")]
    [Description(@"Rejected response message.")]
    ATMResponseReject,

    /// <summary>
    /// Request for a withdrawal transaction.
    /// Encoded/decoded by serializers as &quot;WITQ&quot;.
    /// </summary>
    [EnumMember(Value = "WITQ")]
    [IsoId("_TA-SEInxEeS9F4Qrq_eaVA")]
    [Description(@"Request for a withdrawal transaction.")]
    ATMWithdrawalRequest,

    /// <summary>
    /// Response to a withdrawal transaction request.
    /// Encoded/decoded by serializers as &quot;WITP&quot;.
    /// </summary>
    [EnumMember(Value = "WITP")]
    [IsoId("_WgXxIInxEeS9F4Qrq_eaVA")]
    [Description(@"Response to a withdrawal transaction request.")]
    ATMWithdrawalResponse,

    /// <summary>
    /// Response of a withdrawal transaction.
    /// Encoded/decoded by serializers as &quot;WITV&quot;.
    /// </summary>
    [EnumMember(Value = "WITV")]
    [IsoId("_ZG_OEInxEeS9F4Qrq_eaVA")]
    [Description(@"Response of a withdrawal transaction.")]
    ATMWithdrawalAdvice,

    /// <summary>
    /// Acknowledgement of a withdrawal transaction advice.
    /// Encoded/decoded by serializers as &quot;WITK&quot;.
    /// </summary>
    [EnumMember(Value = "WITK")]
    [IsoId("_bkZrsInxEeS9F4Qrq_eaVA")]
    [Description(@"Acknowledgement of a withdrawal transaction advice.")]
    ATMWithdrawalAknowledgement,

    /// <summary>
    /// Request the value of the ATM counters.
    /// Encoded/decoded by serializers as &quot;INQC&quot;.
    /// </summary>
    [EnumMember(Value = "INQC")]
    [IsoId("_d9seUInxEeS9F4Qrq_eaVA")]
    [Description(@"Request the value of the ATM counters.")]
    CountersInquiry,

    /// <summary>
    /// Request from a host to an ATM to be contacted by this ATM.
    /// Encoded/decoded by serializers as &quot;H2AQ&quot;.
    /// </summary>
    [EnumMember(Value = "H2AQ")]
    [IsoId("_iNKvcInxEeS9F4Qrq_eaVA")]
    [Description(@"Request from a host to an ATM to be contacted by this ATM.")]
    HostToATMRequest,

    /// <summary>
    /// Acknowledgement of a request from a host to an ATM for contacting.
    /// Encoded/decoded by serializers as &quot;H2AP&quot;.
    /// </summary>
    [EnumMember(Value = "H2AP")]
    [IsoId("_knxwsInxEeS9F4Qrq_eaVA")]
    [Description(@"Acknowledgement of a request from a host to an ATM for contacting.")]
    HostToATMAcknowledgement,

    /// <summary>
    /// Logical or physical operation on the ATM.
    /// Encoded/decoded by serializers as &quot;TMOP&quot;.
    /// </summary>
    [EnumMember(Value = "TMOP")]
    [IsoId("_nuGocInxEeS9F4Qrq_eaVA")]
    [Description(@"Logical or physical operation on the ATM.")]
    ATMOperation,

    /// <summary>
    /// Security Commands.
    /// Encoded/decoded by serializers as &quot;CSEC&quot;.
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_qWbVkInxEeS9F4Qrq_eaVA")]
    [Description(@"Security Commands.")]
    SecurityControl,

    /// <summary>
    /// Security detailed report.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_sytKwInxEeS9F4Qrq_eaVA")]
    [Description(@"Security detailed report.")]
    SecurityDetails,

    /// <summary>
    /// Result of the key download with the status of the downloaded keys including key check values.
    /// Encoded/decoded by serializers as &quot;SKSC&quot;.
    /// </summary>
    [EnumMember(Value = "SKSC")]
    [IsoId("_vn_84InxEeS9F4Qrq_eaVA")]
    [Description(
        @"Result of the key download with the status of the downloaded keys including key check values."
    )]
    SecurityKeyCompletion,

    /// <summary>
    /// Status of cryptographic keys.
    /// Encoded/decoded by serializers as &quot;SSTS&quot;.
    /// </summary>
    [EnumMember(Value = "SSTS")]
    [IsoId("_x9nJYInxEeS9F4Qrq_eaVA")]
    [Description(@"Status of cryptographic keys.")]
    SecurityKeyStatus,

    /// <summary>
    /// Reject of a request or an advice message by an acquirer or an agent.
    /// Encoded/decoded by serializers as &quot;RJCQ&quot;.
    /// </summary>
    [EnumMember(Value = "RJCQ")]
    [IsoId("_HPX9kI0OEeWRYffwL7E13A")]
    [Description(@"Reject of a request or an advice message by an acquirer or an agent.")]
    AcceptorRequestReject,

    /// <summary>
    /// Reject of a response or an advice response message by a card acceptor or an agent.
    /// Encoded/decoded by serializers as &quot;RJCP&quot;.
    /// </summary>
    [EnumMember(Value = "RJCP")]
    [IsoId("_LDTiMI0OEeWRYffwL7E13A")]
    [Description(
        @"Reject of a response or an advice response message by a card acceptor or an agent."
    )]
    AcceptorResponseReject,

    /// <summary>
    /// Request for a deposit.
    /// Encoded/decoded by serializers as &quot;DPSQ&quot;.
    /// </summary>
    [EnumMember(Value = "DPSQ")]
    [IsoId("_yVVIIK1wEeWMg5rOByfExw")]
    [Description(@"Request for a deposit.")]
    ATMDepositRequest,

    /// <summary>
    /// Response to a deposit request.
    /// Encoded/decoded by serializers as &quot;DPSP&quot;.
    /// </summary>
    [EnumMember(Value = "DPSP")]
    [IsoId("_2kwV8K1wEeWMg5rOByfExw")]
    [Description(@"Response to a deposit request.")]
    ATMDepositResponse,

    /// <summary>
    /// Advice of an ATM deposit transaction completion.
    /// Encoded/decoded by serializers as &quot;DPSV&quot;.
    /// </summary>
    [EnumMember(Value = "DPSV")]
    [IsoId("_5Ta7oK1wEeWMg5rOByfExw")]
    [Description(@"Advice of an ATM deposit transaction completion.")]
    ATMDepositCompletionAdvice,

    /// <summary>
    /// Acknowledgement of a deposit completion advice.
    /// Encoded/decoded by serializers as &quot;DPSK&quot;.
    /// </summary>
    [EnumMember(Value = "DPSK")]
    [IsoId("_87f1kK1wEeWMg5rOByfExw")]
    [Description(@"Acknowledgement of a deposit completion advice.")]
    ATMDepositCompletionAcknowledgement,

    /// <summary>
    /// Advice of an ATM exception.
    /// Encoded/decoded by serializers as &quot;EXPV&quot;.
    /// </summary>
    [EnumMember(Value = "EXPV")]
    [IsoId("_D3GVwK1xEeWMg5rOByfExw")]
    [Description(@"Advice of an ATM exception.")]
    ATMExceptionAdvice,

    /// <summary>
    /// Acknowledgement of an exception advice.
    /// Encoded/decoded by serializers as &quot;EXPK&quot;.
    /// </summary>
    [EnumMember(Value = "EXPK")]
    [IsoId("_GTPoEK1xEeWMg5rOByfExw")]
    [Description(@"Acknowledgement of an exception advice.")]
    ATMExceptionAcknowledgement,

    /// <summary>
    /// Request for a fund transfer.
    /// Encoded/decoded by serializers as &quot;TRFQ&quot;.
    /// </summary>
    [EnumMember(Value = "TRFQ")]
    [IsoId("_KLcBoK1xEeWMg5rOByfExw")]
    [Description(@"Request for a fund transfer.")]
    ATMTransferRequest,

    /// <summary>
    /// Response to a fund transfer request.
    /// Encoded/decoded by serializers as &quot;TRFP&quot;.
    /// </summary>
    [EnumMember(Value = "TRFP")]
    [IsoId("_MfvmkK1xEeWMg5rOByfExw")]
    [Description(@"Response to a fund transfer request.")]
    ATMTransferResponse,

    /// <summary>
    /// Provide the value of the ATM counters, no reinitialisation of the counters.
    /// Encoded/decoded by serializers as &quot;RPTC&quot;.
    /// </summary>
    [EnumMember(Value = "RPTC")]
    [IsoId("_PXaXQK1xEeWMg5rOByfExw")]
    [Description(@"Provide the value of the ATM counters, no reinitialisation of the counters.")]
    CountersReport,

    /// <summary>
    /// Advice for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCAV&quot;.
    /// </summary>
    [EnumMember(Value = "DCAV")]
    [IsoId("_dn3m4LDEEeamYaqfhG1ZuA")]
    [Description(@"Advice for dynamic currency conversion.")]
    CurrencyConversionAdvice,

    /// <summary>
    /// Advice response for the currency conversion from the service provider to the acceptor.
    /// Encoded/decoded by serializers as &quot;DCRR&quot;.
    /// </summary>
    [EnumMember(Value = "DCRR")]
    [IsoId("_ede6oBCHEeeriKqGwDrUEg")]
    [Description(
        @"Advice response for the currency conversion from the service provider to the acceptor."
    )]
    CurrencyConversionAdviceResponse,

    /// <summary>
    /// Request to initiate a Card Direct Debit.
    /// Encoded/decoded by serializers as &quot;CDDR&quot;.
    /// </summary>
    [EnumMember(Value = "CDDR")]
    [IsoId("_CQyRINnGEeeN3v2fup_Shw")]
    [Description(@"Request to initiate a Card Direct Debit.")]
    CardDebitRequest,

    /// <summary>
    /// Response to a Card Direct Debit Request.
    /// Encoded/decoded by serializers as &quot;CDDP&quot;.
    /// </summary>
    [EnumMember(Value = "CDDP")]
    [IsoId("_Ht72UNnGEeeN3v2fup_Shw")]
    [Description(@"Response to a Card Direct Debit Request.")]
    CardDebitResponse,

    /// <summary>
    /// Advice for a Card Direct Debit.
    /// Encoded/decoded by serializers as &quot;CDDQ&quot;.
    /// </summary>
    [EnumMember(Value = "CDDQ")]
    [IsoId("_O9cJ8NnGEeeN3v2fup_Shw")]
    [Description(@"Advice for a Card Direct Debit.")]
    CardDebitAdvice,

    /// <summary>
    /// Response to a Card Direct Debit Advice.
    /// Encoded/decoded by serializers as &quot;CDDK&quot;.
    /// </summary>
    [EnumMember(Value = "CDDK")]
    [IsoId("_SyODINnGEeeN3v2fup_Shw")]
    [Description(@"Response to a Card Direct Debit Advice.")]
    CardDebitAdviceResponse,

    /// <summary>
    /// Advice about the capture of an authorisation already performed (response expected).
    /// Encoded/decoded by serializers as &quot;AUCV&quot;.
    /// </summary>
    [EnumMember(Value = "AUCV")]
    [IsoId("_JAPRm3yHEemHsOqJOzMVfg")]
    [Description(
        @"Advice about the capture of an authorisation already performed (response expected)."
    )]
    AuthorisationCaptureAdvice,

    /// <summary>
    /// Notification about the capture of an authorisation already performed (no response expected).
    /// Encoded/decoded by serializers as &quot;AUCN&quot;.
    /// </summary>
    [EnumMember(Value = "AUCN")]
    [IsoId("_JAPRnHyHEemHsOqJOzMVfg")]
    [Description(
        @"Notification about the capture of an authorisation already performed (no response expected)."
    )]
    AuthorisationCaptureNotification,

    /// <summary>
    /// Advice for the transfer of a batch file.
    /// Encoded/decoded by serializers as &quot;BTAD&quot;.
    /// </summary>
    [EnumMember(Value = "BTAD")]
    [IsoId("_JAPRnXyHEemHsOqJOzMVfg")]
    [Description(@"Advice for the transfer of a batch file.")]
    BatchAdvice,

    /// <summary>
    /// Notification to initiate the transfer of a batch (no response expected).
    /// Encoded/decoded by serializers as &quot;BTNF&quot;.
    /// </summary>
    [EnumMember(Value = "BTNF")]
    [IsoId("_JAPRnnyHEemHsOqJOzMVfg")]
    [Description(@"Notification to initiate the transfer of a batch (no response expected).")]
    BatchNotification,

    /// <summary>
    /// Request to initiate the transfer of a batch (response expected).
    /// Encoded/decoded by serializers as &quot;BTRQ&quot;.
    /// </summary>
    [EnumMember(Value = "BTRQ")]
    [IsoId("_JAPRn3yHEemHsOqJOzMVfg")]
    [Description(@"Request to initiate the transfer of a batch (response expected).")]
    BatchRequest,

    /// <summary>
    /// Notification to initiate the transfer of a collection (no response expected).
    /// Encoded/decoded by serializers as &quot;CLNF&quot;.
    /// </summary>
    [EnumMember(Value = "CLNF")]
    [IsoId("_JAPRoHyHEemHsOqJOzMVfg")]
    [Description(@"Notification to initiate the transfer of a collection (no response expected).")]
    CollectionNotification,

    /// <summary>
    /// Request to initiate the transfer of a collection (response expected).
    /// Encoded/decoded by serializers as &quot;CLRQ&quot;.
    /// </summary>
    [EnumMember(Value = "CLRQ")]
    [IsoId("_JAPRoXyHEemHsOqJOzMVfg")]
    [Description(@"Request to initiate the transfer of a collection (response expected).")]
    CollectionRequest,

    /// <summary>
    /// Advice about the result of an authorisation and financial presentment already performed (response expected).
    /// Encoded/decoded by serializers as &quot;FICV&quot;.
    /// </summary>
    [EnumMember(Value = "FICV")]
    [IsoId("_JAPRonyHEemHsOqJOzMVfg")]
    [Description(
        @"Advice about the result of an authorisation and financial presentment already performed (response expected)."
    )]
    FinancialCaptureAdvice,

    /// <summary>
    /// Advice about the result of an authorisation and financial presentment already performed (no response expected).
    /// Encoded/decoded by serializers as &quot;FICN&quot;.
    /// </summary>
    [EnumMember(Value = "FICN")]
    [IsoId("_JAPRo3yHEemHsOqJOzMVfg")]
    [Description(
        @"Advice about the result of an authorisation and financial presentment already performed (no response expected)."
    )]
    FinancialCaptureNotification,

    /// <summary>
    /// Confirmation of financial totals.
    /// Encoded/decoded by serializers as &quot;RCLA&quot;.
    /// </summary>
    [EnumMember(Value = "RCLA")]
    [IsoId("_JAPRpHyHEemHsOqJOzMVfg")]
    [Description(@"Confirmation of financial totals.")]
    ReconciliationAdvice,

    /// <summary>
    /// Provision of financial totals.
    /// Encoded/decoded by serializers as &quot;RCLN&quot;.
    /// </summary>
    [EnumMember(Value = "RCLN")]
    [IsoId("_JAPRpXyHEemHsOqJOzMVfg")]
    [Description(@"Provision of financial totals.")]
    ReconciliationNotification,

    /// <summary>
    /// Advice of a charge back.
    /// Encoded/decoded by serializers as &quot;CBAD&quot;.
    /// </summary>
    [EnumMember(Value = "CBAD")]
    [IsoId("_VDnj7nyHEemHsOqJOzMVfg")]
    [Description(@"Advice of a charge back.")]
    ChargeBackAdvice,

    /// <summary>
    /// Notification of a chargeback.
    /// Encoded/decoded by serializers as &quot;CBNF&quot;.
    /// </summary>
    [EnumMember(Value = "CBNF")]
    [IsoId("_VDnj73yHEemHsOqJOzMVfg")]
    [Description(@"Notification of a chargeback.")]
    ChargeBackNotification,

    /// <summary>
    /// Request for a chargeback.
    /// Encoded/decoded by serializers as &quot;CBRQ&quot;.
    /// </summary>
    [EnumMember(Value = "CBRQ")]
    [IsoId("_VDnj8HyHEemHsOqJOzMVfg")]
    [Description(@"Request for a chargeback.")]
    ChargeBackRequest,

    /// <summary>
    /// Advice of a chargeback reversal.
    /// Encoded/decoded by serializers as &quot;CBRA&quot;.
    /// </summary>
    [EnumMember(Value = "CBRA")]
    [IsoId("_VDnj8XyHEemHsOqJOzMVfg")]
    [Description(@"Advice of a chargeback reversal.")]
    ChargeBackReversalAdvice,

    /// <summary>
    /// Notification of a chargeback reversal.
    /// Encoded/decoded by serializers as &quot;CBRN&quot;.
    /// </summary>
    [EnumMember(Value = "CBRN")]
    [IsoId("_VDnj8nyHEemHsOqJOzMVfg")]
    [Description(@"Notification of a chargeback reversal.")]
    ChargeBackReversalNotification,

    /// <summary>
    /// Request of the status of a chargeback.
    /// Encoded/decoded by serializers as &quot;CBSA&quot;.
    /// </summary>
    [EnumMember(Value = "CBSA")]
    [IsoId("_VDnj83yHEemHsOqJOzMVfg")]
    [Description(@"Request of the status of a chargeback.")]
    ChargeBackStatusAdvice,

    /// <summary>
    /// Notification of the status of a chargeback.
    /// Encoded/decoded by serializers as &quot;CBSN&quot;.
    /// </summary>
    [EnumMember(Value = "CBSN")]
    [IsoId("_VDnj9HyHEemHsOqJOzMVfg")]
    [Description(@"Notification of the status of a chargeback. ")]
    ChargeBackStatusNotification,

    /// <summary>
    /// Advice of a performed file action.
    /// Encoded/decoded by serializers as &quot;FADV&quot;.
    /// </summary>
    [EnumMember(Value = "FADV")]
    [IsoId("_VDnj9XyHEemHsOqJOzMVfg")]
    [Description(@"Advice of a performed file action.")]
    FileActionAdvice,

    /// <summary>
    /// Notification of a performed file action.
    /// Encoded/decoded by serializers as &quot;FANT&quot;.
    /// </summary>
    [EnumMember(Value = "FANT")]
    [IsoId("_VDnj9nyHEemHsOqJOzMVfg")]
    [Description(@"Notification of a performed file action.")]
    FileActionNotification,

    /// <summary>
    /// Request for a file action.
    /// Encoded/decoded by serializers as &quot;FARQ&quot;.
    /// </summary>
    [EnumMember(Value = "FARQ")]
    [IsoId("_VDnj93yHEemHsOqJOzMVfg")]
    [Description(@"Request for a file action.")]
    FileActionRequest,

    /// <summary>
    /// Reversal advice of a data capture authorisation of financial message by an agent.
    /// Encoded/decoded by serializers as &quot;RVCA&quot;.
    /// </summary>
    [EnumMember(Value = "RVCA")]
    [IsoId("_VDnj-HyHEemHsOqJOzMVfg")]
    [Description(
        @"Reversal advice of a data capture authorisation of financial message by an agent."
    )]
    ReversalCaptureAdvice,

    /// <summary>
    /// Notification of reversal of a data capture authorisation or financial by an agent (no response expected).
    /// Encoded/decoded by serializers as &quot;RVCN&quot;.
    /// </summary>
    [EnumMember(Value = "RVCN")]
    [IsoId("_VDnj-XyHEemHsOqJOzMVfg")]
    [Description(
        @"Notification of reversal of a data capture authorisation or financial by an agent (no response expected)."
    )]
    ReversalCaptureNotification,

    /// <summary>
    /// Notification of reversal for either an authorisation or a financial message (response not expected).
    /// Encoded/decoded by serializers as &quot;RVNO&quot;.
    /// </summary>
    [EnumMember(Value = "RVNO")]
    [IsoId("_VDnj-nyHEemHsOqJOzMVfg")]
    [Description(
        @"Notification of reversal for either an authorisation or a financial message (response not expected)."
    )]
    ReversalNotification,

    /// <summary>
    /// Request for reversal for either an authorisation or a financial message.
    /// Encoded/decoded by serializers as &quot;RVRQ&quot;.
    /// </summary>
    [EnumMember(Value = "RVRQ")]
    [IsoId("_VDnj-3yHEemHsOqJOzMVfg")]
    [Description(@"Request for reversal for either an authorisation or a financial message.")]
    ReversalRequest,

    /// <summary>
    /// Notification about a correction or amendment brought to an original message.
    /// Encoded/decoded by serializers as &quot;AMET&quot;.
    /// </summary>
    [EnumMember(Value = "AMET")]
    [IsoId("_gXGDS3yHEemHsOqJOzMVfg")]
    [Description(@"Notification about a correction or amendment brought to an original message.")]
    AmendmentNotification,

    /// <summary>
    /// Advise about a fee collection.
    /// Encoded/decoded by serializers as &quot;FECA&quot;.
    /// </summary>
    [EnumMember(Value = "FECA")]
    [IsoId("_gXGDTHyHEemHsOqJOzMVfg")]
    [Description(@"Advise about a fee collection.")]
    FeeCollectionAdvice,

    /// <summary>
    /// Notification about a fee collection.
    /// Encoded/decoded by serializers as &quot;FECN&quot;.
    /// </summary>
    [EnumMember(Value = "FECN")]
    [IsoId("_gXGDTXyHEemHsOqJOzMVfg")]
    [Description(@"Notification about a fee collection.")]
    FeeCollectionNotification,

    /// <summary>
    /// Request for a key exchange activity.
    /// Encoded/decoded by serializers as &quot;KEYI&quot;.
    /// </summary>
    [EnumMember(Value = "KEYI")]
    [IsoId("_gXGDTnyHEemHsOqJOzMVfg")]
    [Description(@"Request for a key exchange activity.")]
    KeyExchangeInitiation,

    /// <summary>
    /// Advice about a retrieval.
    /// Encoded/decoded by serializers as &quot;RTAV&quot;.
    /// </summary>
    [EnumMember(Value = "RTAV")]
    [IsoId("_gXGDT3yHEemHsOqJOzMVfg")]
    [Description(@"Advice about a retrieval.")]
    RetrievalAdvice,

    /// <summary>
    /// Advice about the fulfilment of a retrieval.
    /// Encoded/decoded by serializers as &quot;RTFA&quot;.
    /// </summary>
    [EnumMember(Value = "RTFA")]
    [IsoId("_gXGDUHyHEemHsOqJOzMVfg")]
    [Description(@"Advice about the fulfilment of a retrieval.")]
    RetrievalFulfilmentAdvice,

    /// <summary>
    /// Request for fulfilment retrieval.
    /// Encoded/decoded by serializers as &quot;RTFR&quot;.
    /// </summary>
    [EnumMember(Value = "RTFR")]
    [IsoId("_gXGDUXyHEemHsOqJOzMVfg")]
    [Description(@"Request for fulfilment retrieval.")]
    RetrievalFulfilmentlRequest,

    /// <summary>
    /// Notification about the fulfilment of a retrieval.
    /// Encoded/decoded by serializers as &quot;RTFN&quot;.
    /// </summary>
    [EnumMember(Value = "RTFN")]
    [IsoId("_gXGDUnyHEemHsOqJOzMVfg")]
    [Description(@"Notification about the fulfilment of a retrieval.")]
    RetrievalFulfilmentNotification,

    /// <summary>
    /// Notification about a retrieval.
    /// Encoded/decoded by serializers as &quot;RTNF&quot;.
    /// </summary>
    [EnumMember(Value = "RTNF")]
    [IsoId("_gXGDU3yHEemHsOqJOzMVfg")]
    [Description(@"Notification about a retrieval.")]
    RetrievalNotification,

    /// <summary>
    /// Advice about the status of a retrieval.
    /// Encoded/decoded by serializers as &quot;RTSA&quot;.
    /// </summary>
    [EnumMember(Value = "RTSA")]
    [IsoId("_gXGDVHyHEemHsOqJOzMVfg")]
    [Description(@"Advice about the status of a retrieval.")]
    RetrievalStatusAdvice,

    /// <summary>
    /// Notification about the status of a retrieval.
    /// Encoded/decoded by serializers as &quot;RTSN&quot;.
    /// </summary>
    [EnumMember(Value = "RTSN")]
    [IsoId("_gXGDVXyHEemHsOqJOzMVfg")]
    [Description(@"Notification about the status of a retrieval.")]
    RetrievalStatusNotification,

    /// <summary>
    /// Advice of the result of an operation performed on the cardholder card.
    /// Encoded/decoded by serializers as &quot;CRMA&quot;.
    /// </summary>
    [EnumMember(Value = "CRMA")]
    [IsoId("_t6IxkXyHEemHsOqJOzMVfg")]
    [Description(@"Advice of the result of an operation performed on the cardholder card.")]
    CardManagementAdvice,

    /// <summary>
    /// Notification of the result of an operation performed on the cardholder card.
    /// Encoded/decoded by serializers as &quot;CRMN&quot;.
    /// </summary>
    [EnumMember(Value = "CRMN")]
    [IsoId("_t6IxknyHEemHsOqJOzMVfg")]
    [Description(@"Notification of the result of an operation performed on the cardholder card.")]
    CardManagementNotification,

    /// <summary>
    /// Request for an operation on the cardholder card.
    /// Encoded/decoded by serializers as &quot;CRMR&quot;.
    /// </summary>
    [EnumMember(Value = "CRMR")]
    [IsoId("_t6Ixk3yHEemHsOqJOzMVfg")]
    [Description(@"Request for an operation on the cardholder card.")]
    CardManagementRequest,

    /// <summary>
    /// Advice of disposition of a confirmed fraud.
    /// Encoded/decoded by serializers as &quot;FRDA&quot;.
    /// </summary>
    [EnumMember(Value = "FRDA")]
    [IsoId("_t6IxlHyHEemHsOqJOzMVfg")]
    [Description(@"Advice of disposition of a confirmed fraud.")]
    FraudDispositionAdvice,

    /// <summary>
    /// Notification of disposition of a confirmed fraud.
    /// Encoded/decoded by serializers as &quot;FRDN&quot;.
    /// </summary>
    [EnumMember(Value = "FRDN")]
    [IsoId("_t6IxlXyHEemHsOqJOzMVfg")]
    [Description(@"Notification of disposition of a confirmed fraud.")]
    FraudDispositionNotification,

    /// <summary>
    /// Advice of a confirmed fraud
    /// Encoded/decoded by serializers as &quot;FRRA&quot;.
    /// </summary>
    [EnumMember(Value = "FRRA")]
    [IsoId("_t6IxlnyHEemHsOqJOzMVfg")]
    [Description(@"Advice of a confirmed fraud")]
    FraudReportingAdvice,

    /// <summary>
    /// Notification of a confirmed fraud.
    /// Encoded/decoded by serializers as &quot;FRRN&quot;.
    /// </summary>
    [EnumMember(Value = "FRRN")]
    [IsoId("_t6Ixl3yHEemHsOqJOzMVfg")]
    [Description(@"Notification of a confirmed fraud.")]
    FraudReportingNotification,

    /// <summary>
    /// Advice about the result of an inquiry already performed.
    /// Encoded/decoded by serializers as &quot;INAV&quot;.
    /// </summary>
    [EnumMember(Value = "INAV")]
    [IsoId("_t6IxmHyHEemHsOqJOzMVfg")]
    [Description(@"Advice about the result of an inquiry already performed.")]
    InquiryAdvice,

    /// <summary>
    /// Notification about the result of an inquiry already performed.
    /// Encoded/decoded by serializers as &quot;INNF&quot;.
    /// </summary>
    [EnumMember(Value = "INNF")]
    [IsoId("_t6IxmXyHEemHsOqJOzMVfg")]
    [Description(@"Notification about the result of an inquiry already performed.")]
    InquiryNotification,

    /// <summary>
    /// Request for information related to a card or a cardholder.
    /// Encoded/decoded by serializers as &quot;INRQ&quot;.
    /// </summary>
    [EnumMember(Value = "INRQ")]
    [IsoId("_t6IxmnyHEemHsOqJOzMVfg")]
    [Description(@"Request for information related to a card or a cardholder.")]
    InquiryRequest,

    /// <summary>
    /// Request for retrieval of transaction information
    /// Encoded/decoded by serializers as &quot;RTRQ&quot;.
    /// </summary>
    [EnumMember(Value = "RTRQ")]
    [IsoId("_t6Ixm3yHEemHsOqJOzMVfg")]
    [Description(@"Request for retrieval of transaction information")]
    RetrievalRequest,

    /// <summary>
    /// Request the status of a retrieval
    /// Encoded/decoded by serializers as &quot;RTSR&quot;.
    /// </summary>
    [EnumMember(Value = "RTSR")]
    [IsoId("_t6IxnHyHEemHsOqJOzMVfg")]
    [Description(@"Request the status of a retrieval")]
    RetrievalStatusRequest,

    /// <summary>
    /// Advice of an amount settled or to be settled with a financial institution.
    /// Encoded/decoded by serializers as &quot;STRA&quot;.
    /// </summary>
    [EnumMember(Value = "STRA")]
    [IsoId("_t6IxnXyHEemHsOqJOzMVfg")]
    [Description(@"Advice of an amount settled or to be settled with a financial institution.")]
    SettlementReportingAdvice,

    /// <summary>
    /// Notification of an amount settled or to be settled with a financial institution.
    /// Encoded/decoded by serializers as &quot;STRN&quot;.
    /// </summary>
    [EnumMember(Value = "STRN")]
    [IsoId("_t6IxnnyHEemHsOqJOzMVfg")]
    [Description(
        @"Notification of an amount settled or to be settled with a financial institution."
    )]
    SettlementReportingNotification,

    /// <summary>
    /// Advice sent by a sender to a receiver about an information, a verification or an authentication already performed.
    /// Encoded/decoded by serializers as &quot;VFAD&quot;.
    /// </summary>
    [EnumMember(Value = "VFAD")]
    [IsoId("_t6Ixn3yHEemHsOqJOzMVfg")]
    [Description(
        @"Advice sent by a sender to a receiver about an information, a verification or an authentication already performed."
    )]
    VerificationAdvice,

    /// <summary>
    /// Notification sent by a sender to a receiver about an information, a verification or an authentication already performed.
    /// Encoded/decoded by serializers as &quot;VFNT&quot;.
    /// </summary>
    [EnumMember(Value = "VFNT")]
    [IsoId("_t6IxoHyHEemHsOqJOzMVfg")]
    [Description(
        @"Notification sent by a sender to a receiver about an information, a verification or an authentication already performed."
    )]
    VerificationNotification,

    /// <summary>
    /// Request sent by a sender about an information, a verification or an authentication to be performed by the receiver.
    /// Encoded/decoded by serializers as &quot;VFRQ&quot;.
    /// </summary>
    [EnumMember(Value = "VFRQ")]
    [IsoId("_t6IxoXyHEemHsOqJOzMVfg")]
    [Description(
        @"Request sent by a sender about an information, a verification or an authentication to be performed by the receiver."
    )]
    VerificationRequest,

    /// <summary>
    /// Error
    /// Encoded/decoded by serializers as &quot;EROR&quot;.
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_vceG8nyHEemHsOqJOzMVfg")]
    [Description(@"Error")]
    Error,

    /// <summary>
    /// Notification of a message containing errors.
    /// Encoded/decoded by serializers as &quot;ERNO&quot;.
    /// </summary>
    [EnumMember(Value = "ERNO")]
    [IsoId("_vceG83yHEemHsOqJOzMVfg")]
    [Description(@"Notification of a message containing errors.")]
    ErrorNotification,

    /// <summary>
    /// Advice of an addendum
    /// Encoded/decoded by serializers as &quot;ADAD&quot;.
    /// </summary>
    [EnumMember(Value = "ADAD")]
    [IsoId("_30fh03yHEemHsOqJOzMVfg")]
    [Description(@"Advice of an addendum")]
    AddendumAdvice,

    /// <summary>
    /// Notification of an addendum
    /// Encoded/decoded by serializers as &quot;ADNO&quot;.
    /// </summary>
    [EnumMember(Value = "ADNO")]
    [IsoId("_30fh1HyHEemHsOqJOzMVfg")]
    [Description(@"Notification of an addendum")]
    AddendumNotification,

    /// <summary>
    /// Notification of a rejected message.
    /// Encoded/decoded by serializers as &quot;RENO&quot;.
    /// </summary>
    [EnumMember(Value = "RENO")]
    [IsoId("_30fh1XyHEemHsOqJOzMVfg")]
    [Description(@"Notification of a rejected message.")]
    RejectNotification,

    /// <summary>
    /// Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response.
    /// Encoded/decoded by serializers as &quot;ADVC&quot;.
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_ULwDoOmnEemNVKPwszFC-A")]
    [Description(
        @"Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. "
    )]
    Advice,

    /// <summary>
    /// Advice about the capture of an activity already performed (response expected).
    /// Encoded/decoded by serializers as &quot;CAAD&quot;.
    /// </summary>
    [EnumMember(Value = "CAAD")]
    [IsoId("_0JucIOmnEemNVKPwszFC-A")]
    [Description(@"Advice about the capture of an activity already performed (response expected).")]
    CaptureAdvice,

    /// <summary>
    /// Notification about the capture of an activity already performed (no response expected).
    /// Encoded/decoded by serializers as &quot;CANO&quot;.
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_Dk_3UOmoEemNVKPwszFC-A")]
    [Description(
        @"Notification about the capture of an activity already performed (no response expected)."
    )]
    CaptureNotification,

    /// <summary>
    /// Information about the transaction.
    /// Encoded/decoded by serializers as &quot;NOTI&quot;.
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_XFO8wOmoEemNVKPwszFC-A")]
    [Description(@"Information about the transaction.")]
    Notification,

    /// <summary>
    /// Advice about the status of a transaction.
    /// Encoded/decoded by serializers as &quot;STAD&quot;.
    /// </summary>
    [EnumMember(Value = "STAD")]
    [IsoId("_0DSAcOmoEemNVKPwszFC-A")]
    [Description(@"Advice about the status of a transaction.")]
    StatusAdvice,

    /// <summary>
    /// Notification about the status of a transaction.
    /// Encoded/decoded by serializers as &quot;STNO&quot;.
    /// </summary>
    [EnumMember(Value = "STNO")]
    [IsoId("_5V5JkOmoEemNVKPwszFC-A")]
    [Description(@"Notification about the status of a transaction.")]
    StatusNotification,

    /// <summary>
    /// Message function is a status request.
    /// Encoded/decoded by serializers as &quot;STRQ&quot;.
    /// </summary>
    [EnumMember(Value = "STRQ")]
    [IsoId("_ACXooOmpEemNVKPwszFC-A")]
    [Description(@"Message function is a status request.")]
    StatusRequest,

    /// <summary>
    /// Advise of the transaction&apos;s processing.
    /// Encoded/decoded by serializers as &quot;TRNA&quot;.
    /// </summary>
    [EnumMember(Value = "TRNA")]
    [IsoId("_oLxuAA02EeqUVL7sB4m7NA")]
    [Description(@"Advise of the transaction's processing.")]
    TransactionAdvice,

    /// <summary>
    /// Response to a transaction advice.
    /// Encoded/decoded by serializers as &quot;TRNR&quot;.
    /// </summary>
    [EnumMember(Value = "TRNR")]
    [IsoId("_wLKmcA02EeqUVL7sB4m7NA")]
    [Description(@"Response to a transaction advice.")]
    TransactionAdviceResponse,

    /// <summary>
    /// Initiator of the message requests additional information to the receiver.
    /// Encoded/decoded by serializers as &quot;NFRQ&quot;.
    /// </summary>
    [EnumMember(Value = "NFRQ")]
    [IsoId("_qiFCwC_YEeugIJ3Gvoevmg")]
    [Description(@"Initiator of the message requests additional information to the receiver.")]
    NonFinancialRequest,

    /// <summary>
    /// Provision of additional information to the issuer of a NonFinancialRequest.
    /// Encoded/decoded by serializers as &quot;NFRP&quot;.
    /// </summary>
    [EnumMember(Value = "NFRP")]
    [IsoId("_JCobAC_ZEeugIJ3Gvoevmg")]
    [Description(@"Provision of additional information to the issuer of a NonFinancialRequest.")]
    NonFinancialResponse,

    /// <summary>
    /// Request to receive of a report of transaction from the issuer to the receiver.
    /// Encoded/decoded by serializers as &quot;TRPQ&quot;.
    /// </summary>
    [EnumMember(Value = "TRPQ")]
    [IsoId("_ekW3EC_ZEeugIJ3Gvoevmg")]
    [Description(@"Request to receive of a report of transaction from the issuer to the receiver.")]
    TransactionReportRequest,

    /// <summary>
    /// Response to provide a sanitized report of transactions.
    /// Encoded/decoded by serializers as &quot;TRPP&quot;.
    /// </summary>
    [EnumMember(Value = "TRPP")]
    [IsoId("_p8P8YC_ZEeugIJ3Gvoevmg")]
    [Description(@"Response to provide a sanitized report of transactions.")]
    TransactionReportResponse,

    /// <summary>
    /// Informs of an action to be taken.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_Y9ImsEGHEeyZG7AU5fJYtQ")]
    [Description(@"Informs of an action to be taken.")]
    Instructure,

    /// <summary>
    /// Request to receive catalogue of Currency Conversion rates.
    /// Encoded/decoded by serializers as &quot;DCRQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCRQ")]
    [IsoId("_kV0dIHC6Ee2bmOA3bkVsMg")]
    [Description(@"Request to receive catalogue of Currency Conversion rates.")]
    CurrencyConversionRateRequest,

    /// <summary>
    /// Response with catalogue of Currency Conversion rates.
    /// Encoded/decoded by serializers as &quot;DCRP&quot;.
    /// </summary>
    [EnumMember(Value = "DCRP")]
    [IsoId("_o9UMsHC6Ee2bmOA3bkVsMg")]
    [Description(@"Response with catalogue of Currency Conversion rates.")]
    CurrencyConversionRateResponse,

    /// <summary>
    /// Concatenation of multiple exchanges in one file.
    /// Encoded/decoded by serializers as &quot;ATAF&quot;.
    /// </summary>
    [EnumMember(Value = "ATAF")]
    [IsoId("")]
    [Description(@"Concatenation of multiple exchanges in one file.")]
    AcceptorToAcquirerBatchFileExchange,
}
