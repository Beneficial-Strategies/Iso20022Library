// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of services and functions available in ISO20022 Retail messages.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hlqYENt5EeiXqq0XHEoNUA")]
[Description(@"List of services and functions available in ISO20022 Retail messages.")]
[Derivations(typeof(RetailerService9Code),typeof(RetailerService4Code),typeof(RetailerService3Code),typeof(RetailerService5Code),typeof(RetailerService6Code),typeof(RetailerService1Code),typeof(RetailerService7Code),typeof(RetailerService2Code),typeof(RetailerService8Code))]
public enum RetailerServiceCode
{
    /// <summary>
    /// The Sale System requests to the POI System to perform a payment(Purchase/Refund/PWCB/MOTO Payment/...).
    /// Encoded/decoded by serializers as &quot;FSPQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSPQ")]
    [IsoId("_rzfokNt6EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests to the POI System to perform a payment(Purchase/Refund/PWCB/MOTO Payment/...).")]
    FinancialPaymentRequest,
    
    /// <summary>
    /// The Sale System requests to the POI System to perform a reversal partial or complete to cancel a former payment service.
    /// Encoded/decoded by serializers as &quot;FSRQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSRQ")]
    [IsoId("_yLg6kNt6EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests to the POI System to perform a reversal partial or complete to cancel a former payment service.")]
    FinancialReversalRequest,
    
    /// <summary>
    /// The Sale System requests to the POI System to perform balance inquiry on the main account.
    /// Encoded/decoded by serializers as &quot;FSIQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSIQ")]
    [IsoId("_0u75kNt6EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests to the POI System to perform balance inquiry on the main account.")]
    FinancialBalanceInquiryRequest,
    
    /// <summary>
    /// The Batch message pair is used to request or get the result of transactions (payment, loyalty and reversal) performed without connection to the Sale system (Payment delivery).
    /// Encoded/decoded by serializers as &quot;FSBQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSBQ")]
    [IsoId("_3QYioNt6EeiXqq0XHEoNUA")]
    [Description(@"The Batch message pair is used to request or get the result of transactions (payment, loyalty and reversal) performed without connection to the Sale system (Payment delivery).")]
    FinancialBatchRequest,
    
    /// <summary>
    /// The Sale System requests to the POI System a loyalty service like loading or redeem.
    /// Encoded/decoded by serializers as &quot;FSLQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSLQ")]
    [IsoId("_6Tr7kNt6EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests to the POI System a loyalty service like loading or redeem.")]
    FinancialLoyaltyRequest,
    
    /// <summary>
    /// The Sale System requests to the POI System to manage a stored value card or account (eg. Load, Payment, Reimbursement).
    /// Encoded/decoded by serializers as &quot;FSVQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSVQ")]
    [IsoId("_9MoeoNt6EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests to the POI System to manage a stored value card or account (eg. Load, Payment, Reimbursement).")]
    FinancialStoredValueRequest,
    
    /// <summary>
    /// The Sale System requests to the POI System to enable a service on its side.
    /// Encoded/decoded by serializers as &quot;FSEQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSEQ")]
    [IsoId("_AIsAENt7EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests to the POI System to enable a service on its side.")]
    FinancialEnableServiceRequest,
    
    /// <summary>
    /// The Sale System requests to the POI System to handle a card data acquisition on the card reader.
    /// Encoded/decoded by serializers as &quot;FSAQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSAQ")]
    [IsoId("_C3yDkNt7EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests to the POI System to handle a card data acquisition on the card reader.")]
    FinancialCardAcquisitionRequest,
    
    /// <summary>
    /// The Sale System request to the POI System different kinds of transaction reconciliation. 
    /// Encoded/decoded by serializers as &quot;FSCQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSCQ")]
    [IsoId("_Fq7goNt7EeiXqq0XHEoNUA")]
    [Description(@"The Sale System request to the POI System different kinds of transaction reconciliation. ")]
    FinancialReconciliationRequest,
    
    /// <summary>
    /// The POI System sends a response to a payment request (Purchase/refund/PWCB/MOTO Payment/...).
    /// Encoded/decoded by serializers as &quot;FSPP&quot;.
    /// </summary>
    [EnumMember(Value = "FSPP")]
    [IsoId("_JK19ENt7EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response to a payment request (Purchase/refund/PWCB/MOTO Payment/...).")]
    FinancialPaymentResponse,
    
    /// <summary>
    /// The POI System sends a response to a reversal request.
    /// Encoded/decoded by serializers as &quot;FSRP&quot;.
    /// </summary>
    [EnumMember(Value = "FSRP")]
    [IsoId("_L2qDENt7EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response to a reversal request.")]
    FinancialReversalResponse,
    
    /// <summary>
    /// The POI System sends a response to a Balance Inquiry request.
    /// Encoded/decoded by serializers as &quot;FSIP&quot;.
    /// </summary>
    [EnumMember(Value = "FSIP")]
    [IsoId("_Oa6vkNt7EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response to a Balance Inquiry request.")]
    FinancialBalanceInquiryResponse,
    
    /// <summary>
    /// The POI System sends a response to a batch processing request.
    /// Encoded/decoded by serializers as &quot;FSBP&quot;.
    /// </summary>
    [EnumMember(Value = "FSBP")]
    [IsoId("_RoYKENt7EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response to a batch processing request.")]
    FinancialBatchResponse,
    
    /// <summary>
    /// The POI System sends a response to a loyalty processing request.
    /// Encoded/decoded by serializers as &quot;FSLP&quot;.
    /// </summary>
    [EnumMember(Value = "FSLP")]
    [IsoId("_U6pzINt7EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response to a loyalty processing request.")]
    FinancialLoyaltyResponse,
    
    /// <summary>
    /// The POI System sends a response to a stored value card or account request.
    /// Encoded/decoded by serializers as &quot;FSVP&quot;.
    /// </summary>
    [EnumMember(Value = "FSVP")]
    [IsoId("_XwTxoNt7EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response to a stored value card or account request.")]
    FinancialStoredValueResponse,
    
    /// <summary>
    /// The POI System sends a response after enabling or not some service.
    /// Encoded/decoded by serializers as &quot;FSEP&quot;.
    /// </summary>
    [EnumMember(Value = "FSEP")]
    [IsoId("_aPctkNt7EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response after enabling or not some service.")]
    FinancialEnableServiceResponse,
    
    /// <summary>
    /// The POI System sends a response to a card data acquisition request.
    /// Encoded/decoded by serializers as &quot;FSAP&quot;.
    /// </summary>
    [EnumMember(Value = "FSAP")]
    [IsoId("_clwdoNt7EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response to a card data acquisition request.")]
    FinancialCardAcquisitionResponse,
    
    /// <summary>
    /// The POI System sends a response to a reconciliation request.
    /// Encoded/decoded by serializers as &quot;FSCP&quot;.
    /// </summary>
    [EnumMember(Value = "FSCP")]
    [IsoId("_fDS3ENt7EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response to a reconciliation request.")]
    FinancialReconciliationResponse,
    
    /// <summary>
    /// An administrative request, to select and start customised administrative services provided by the POI, using a &quot;menu&quot; for an interactive or software interface, initiated by the Sale system.
    /// Encoded/decoded by serializers as &quot;ADAQ&quot;.
    /// </summary>
    [EnumMember(Value = "ADAQ")]
    [IsoId("_hxZcENt7EeiXqq0XHEoNUA")]
    [Description(@"An administrative request, to select and start customised administrative services provided by the POI, using a ""menu"" for an interactive or software interface, initiated by the Sale system.")]
    AdministrativeAdminRequest,
    
    /// <summary>
    /// The Sale System requests a login to the POI System.
    /// Encoded/decoded by serializers as &quot;SMIQ&quot;.
    /// </summary>
    [EnumMember(Value = "SMIQ")]
    [IsoId("_lSPFkNt7EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests a login to the POI System.")]
    AdministrativeSessionManagementLoginRequest,
    
    /// <summary>
    /// The Sale System requests a logout to the POI System.
    /// Encoded/decoded by serializers as &quot;SMOQ&quot;.
    /// </summary>
    [EnumMember(Value = "SMOQ")]
    [IsoId("_nyElENt7EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests a logout to the POI System.")]
    AdministrativeSessionManagementLogoutRequest,
    
    /// <summary>
    /// The Sale System requests a session diagnosis to the POI System.
    /// Encoded/decoded by serializers as &quot;SMDQ&quot;.
    /// </summary>
    [EnumMember(Value = "SMDQ")]
    [IsoId("_qk-xkNt7EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests a session diagnosis to the POI System.")]
    AdministrativeSessionManagementDiagnosisRequest,
    
    /// <summary>
    /// The Sale System requests to the POI System a report on a list of transactions.
    /// Encoded/decoded by serializers as &quot;RPTQ&quot;.
    /// </summary>
    [EnumMember(Value = "RPTQ")]
    [IsoId("_vWn7oNt7EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests to the POI System a report on a list of transactions.")]
    AdministrativeReportTransactionRequest,
    
    /// <summary>
    /// The Sale System requests to the POI System a report on the totals figures of the POI system.
    /// Encoded/decoded by serializers as &quot;RPAQ&quot;.
    /// </summary>
    [EnumMember(Value = "RPAQ")]
    [IsoId("_x3q8ENt7EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests to the POI System a report on the totals figures of the POI system.")]
    AdministrativeReportGetTotalsRequest,
    
    /// <summary>
    /// The POI System responds to an administrative request.
    /// Encoded/decoded by serializers as &quot;ADAP&quot;.
    /// </summary>
    [EnumMember(Value = "ADAP")]
    [IsoId("_0N5MkNt7EeiXqq0XHEoNUA")]
    [Description(@"The POI System responds to an administrative request.")]
    AdministrativeAdminResponse,
    
    /// <summary>
    /// The POI System responds to a login request.
    /// Encoded/decoded by serializers as &quot;SMIP&quot;.
    /// </summary>
    [EnumMember(Value = "SMIP")]
    [IsoId("_5GtVoNt7EeiXqq0XHEoNUA")]
    [Description(@"The POI System responds to a login request.")]
    AdministrativeSessionManagementLoginResponse,
    
    /// <summary>
    /// The POI System responds to a logout request.
    /// Encoded/decoded by serializers as &quot;SMOP&quot;.
    /// </summary>
    [EnumMember(Value = "SMOP")]
    [IsoId("_7hWzINt7EeiXqq0XHEoNUA")]
    [Description(@"The POI System responds to a logout request.")]
    AdministrativeSessionManagementLogoutResponse,
    
    /// <summary>
    /// The POI System responds to a diagnosis request.
    /// Encoded/decoded by serializers as &quot;SMDP&quot;.
    /// </summary>
    [EnumMember(Value = "SMDP")]
    [IsoId("_972foNt7EeiXqq0XHEoNUA")]
    [Description(@"The POI System responds to a diagnosis request.")]
    AdministrativeSessionManagementDiagnosisResponse,
    
    /// <summary>
    /// The POI System responds to a transaction report request.
    /// Encoded/decoded by serializers as &quot;RPTP&quot;.
    /// </summary>
    [EnumMember(Value = "RPTP")]
    [IsoId("_Apt0ENt8EeiXqq0XHEoNUA")]
    [Description(@"The POI System responds to a transaction report request.")]
    AdministrativeReportTransactionResponse,
    
    /// <summary>
    /// The POI System responds to a totals figures request.
    /// Encoded/decoded by serializers as &quot;RPAP&quot;.
    /// </summary>
    [EnumMember(Value = "RPAP")]
    [IsoId("_DIe8kNt8EeiXqq0XHEoNUA")]
    [Description(@"The POI System responds to a totals figures request.")]
    AdministrativeReportGetTotalsResponse,
    
    /// <summary>
    /// Abort a former request or message by the sale system.
    /// Encoded/decoded by serializers as &quot;SSAB&quot;.
    /// </summary>
    [EnumMember(Value = "SSAB")]
    [IsoId("_FqKPINt8EeiXqq0XHEoNUA")]
    [Description(@"Abort a former request or message by the sale system.")]
    SystemAbort,
    
    /// <summary>
    /// Send an Event notification to the other party.
    /// Encoded/decoded by serializers as &quot;SSEN&quot;.
    /// </summary>
    [EnumMember(Value = "SSEN")]
    [IsoId("_IjsoENt8EeiXqq0XHEoNUA")]
    [Description(@"Send an Event notification to the other party.")]
    SystemEventNotification,
    
    /// <summary>
    /// Send a rejection for a previous message.
    /// Encoded/decoded by serializers as &quot;SSRR&quot;.
    /// </summary>
    [EnumMember(Value = "SSRR")]
    [IsoId("_LvBUkNt8EeiXqq0XHEoNUA")]
    [Description(@"Send a rejection for a previous message.")]
    SystemMessageRejection,
    
    /// <summary>
    /// The Sale System requests to the POI System the status of a previous transaction.
    /// Encoded/decoded by serializers as &quot;SSSQ&quot;.
    /// </summary>
    [EnumMember(Value = "SSSQ")]
    [IsoId("_OzyGENt8EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests to the POI System the status of a previous transaction.")]
    SystemMessageStatusRequest,
    
    /// <summary>
    /// The POI System responds to a message status request.
    /// Encoded/decoded by serializers as &quot;SSSP&quot;.
    /// </summary>
    [EnumMember(Value = "SSSP")]
    [IsoId("_RujOENt8EeiXqq0XHEoNUA")]
    [Description(@"The POI System responds to a message status request.")]
    SystemMessageStatusResponse,
    
    /// <summary>
    /// One system requests to the other System to get data input. 
    /// Encoded/decoded by serializers as &quot;DINQ&quot;.
    /// </summary>
    [EnumMember(Value = "DINQ")]
    [IsoId("_UiOPkNt8EeiXqq0XHEoNUA")]
    [Description(@"One system requests to the other System to get data input. ")]
    DeviceInputRequest,
    
    /// <summary>
    /// One System requests the other to display a message for cashier or customer.
    /// Encoded/decoded by serializers as &quot;DDYQ&quot;.
    /// </summary>
    [EnumMember(Value = "DDYQ")]
    [IsoId("_u5jIoNt8EeiXqq0XHEoNUA")]
    [Description(@"One System requests the other to display a message for cashier or customer.")]
    DeviceDisplayRequest,
    
    /// <summary>
    /// One system requests to the other System to print data.
    /// Encoded/decoded by serializers as &quot;DPRQ&quot;.
    /// </summary>
    [EnumMember(Value = "DPRQ")]
    [IsoId("_08gwoNt8EeiXqq0XHEoNUA")]
    [Description(@"One system requests to the other System to print data.")]
    DevicePrintRequest,
    
    /// <summary>
    /// One system requests to the Other System to play a sound.
    /// Encoded/decoded by serializers as &quot;DSOQ&quot;.
    /// </summary>
    [EnumMember(Value = "DSOQ")]
    [IsoId("_3iIvENt8EeiXqq0XHEoNUA")]
    [Description(@"One system requests to the Other System to play a sound.")]
    DevicePlaySoundRequest,
    
    /// <summary>
    /// One system requests to the Other System to securely get data input (e.g. for PIN).
    /// Encoded/decoded by serializers as &quot;DSIQ&quot;.
    /// </summary>
    [EnumMember(Value = "DSIQ")]
    [IsoId("_5wbyoNt8EeiXqq0XHEoNUA")]
    [Description(@"One system requests to the Other System to securely get data input (e.g. for PIN).")]
    DeviceSecureInputRequest,
    
    /// <summary>
    /// Service to send parameters to use when card reader initializes a new communication with the card.
    /// Encoded/decoded by serializers as &quot;DCIQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCIQ")]
    [IsoId("_8K1_kNt8EeiXqq0XHEoNUA")]
    [Description(@"Service to send parameters to use when card reader initializes a new communication with the card.")]
    DeviceInitialisationCardReaderRequest,
    
    /// <summary>
    /// A service to send commands to a card.
    /// Encoded/decoded by serializers as &quot;DCAQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCAQ")]
    [IsoId("_-neaENt8EeiXqq0XHEoNUA")]
    [Description(@"A service to send commands to a card.")]
    DeviceSendApplicationProtocolDataUnitCardReaderRequest,
    
    /// <summary>
    /// The Sale system requests to the POI System to power off the card reader.
    /// Encoded/decoded by serializers as &quot;DCPQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCPQ")]
    [IsoId("_BROqkNt9EeiXqq0XHEoNUA")]
    [Description(@"The Sale system requests to the POI System to power off the card reader.")]
    DevicePowerOffCardReaderRequest,
    
    /// <summary>
    /// The Sale system requests to the POI System to transmit a message (for instance to a mobile server).
    /// Encoded/decoded by serializers as &quot;DCOQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCOQ")]
    [IsoId("_DmYkENt9EeiXqq0XHEoNUA")]
    [Description(@"The Sale system requests to the POI System to transmit a message (for instance to a mobile server).")]
    DeviceTransmissionMessageRequest,
    
    /// <summary>
    /// One system sends a notification to the POI System to update a input request.
    /// Encoded/decoded by serializers as &quot;DINO&quot;.
    /// </summary>
    [EnumMember(Value = "DINO")]
    [IsoId("_GD2sENt9EeiXqq0XHEoNUA")]
    [Description(@"One system sends a notification to the POI System to update a input request.")]
    DeviceInputNotification,
    
    /// <summary>
    /// One system responds to the other system for a display request.
    /// Encoded/decoded by serializers as &quot;DDYP&quot;.
    /// </summary>
    [EnumMember(Value = "DDYP")]
    [IsoId("_IppCkNt9EeiXqq0XHEoNUA")]
    [Description(@"One system responds to the other system for a display request.")]
    DeviceDisplayResponse,
    
    /// <summary>
    /// One system responds to the other System for a input request.
    /// Encoded/decoded by serializers as &quot;DINP&quot;.
    /// </summary>
    [EnumMember(Value = "DINP")]
    [IsoId("_LndekNt9EeiXqq0XHEoNUA")]
    [Description(@"One system responds to the other System for a input request.")]
    DeviceInputResponse,
    
    /// <summary>
    /// One system responds to the other System for a print request.
    /// Encoded/decoded by serializers as &quot;DPRP&quot;.
    /// </summary>
    [EnumMember(Value = "DPRP")]
    [IsoId("_On80ENt9EeiXqq0XHEoNUA")]
    [Description(@"One system responds to the other System for a print request.")]
    DevicePrintResponse,
    
    /// <summary>
    /// One system responds to the other System for a play sound request.
    /// Encoded/decoded by serializers as &quot;DSOP&quot;.
    /// </summary>
    [EnumMember(Value = "DSOP")]
    [IsoId("_RqCsENt9EeiXqq0XHEoNUA")]
    [Description(@"One system responds to the other System for a play sound request.")]
    DevicePlaySoundResponse,
    
    /// <summary>
    /// One system responds to the other System for secure data input.
    /// Encoded/decoded by serializers as &quot;DSIP&quot;.
    /// </summary>
    [EnumMember(Value = "DSIP")]
    [IsoId("_T_SFINt9EeiXqq0XHEoNUA")]
    [Description(@"One system responds to the other System for secure data input.")]
    DeviceSecureInputResponse,
    
    /// <summary>
    /// The POI system responds to the Sale System for a card reader initialisation.
    /// Encoded/decoded by serializers as &quot;DCIP&quot;.
    /// </summary>
    [EnumMember(Value = "DCIP")]
    [IsoId("_WNykENt9EeiXqq0XHEoNUA")]
    [Description(@"The POI system responds to the Sale System for a card reader initialisation.")]
    DeviceInitialisationCardReaderResponse,
    
    /// <summary>
    /// The POI system responds to the Sale System for a card reader Application Protocol Data Unit sending.
    /// Encoded/decoded by serializers as &quot;DCAP&quot;.
    /// </summary>
    [EnumMember(Value = "DCAP")]
    [IsoId("_YdxCoNt9EeiXqq0XHEoNUA")]
    [Description(@"The POI system responds to the Sale System for a card reader Application Protocol Data Unit sending.")]
    DeviceSendApplicationProtocolDataUnitCardReaderResponse,
    
    /// <summary>
    /// The POI system responds to the Sale System for a card reader power off.
    /// Encoded/decoded by serializers as &quot;DCPP&quot;.
    /// </summary>
    [EnumMember(Value = "DCPP")]
    [IsoId("_bSChENt9EeiXqq0XHEoNUA")]
    [Description(@"The POI system responds to the Sale System for a card reader power off.")]
    DevicePowerOffCardRequestResponse,
    
    /// <summary>
    /// The POI system responds to the Sale System after a message transmission.
    /// Encoded/decoded by serializers as &quot;DCOP&quot;.
    /// </summary>
    [EnumMember(Value = "DCOP")]
    [IsoId("_d5lLENt9EeiXqq0XHEoNUA")]
    [Description(@"The POI system responds to the Sale System after a message transmission.")]
    DeviceTransmissionMessageResponse,
    
}
