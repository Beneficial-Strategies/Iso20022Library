// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of Retail services available and used in the Retail messages. Helps to know which service to activate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_j0d1INt9EeiXqq0XHEoNUA")]
[Description(
    @"List of Retail services available and used in the Retail messages. Helps to know which service to activate."
)]
[DerivedFrom(typeof(RetailerServiceCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RetailerService1Code>))]
#endif
public enum RetailerService1Code
{
    /// <summary>
    /// A service to send commands to a card.
    /// Encoded/decoded by serializers as &quot;DCAQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCAQ")]
    [IsoId("_rENZUdt9EeiXqq0XHEoNUA")]
    [Description(@"A service to send commands to a card.")]
    DeviceSendApplicationProtocolDataUnitCardReaderRequest =
        RetailerServiceCode.DeviceSendApplicationProtocolDataUnitCardReaderRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An administrative request, to select and start customised administrative services provided by the POI, using a &quot;menu&quot; for an interactive or software interface, initiated by the Sale system.
    /// Encoded/decoded by serializers as &quot;ADAQ&quot;.
    /// </summary>
    [EnumMember(Value = "ADAQ")]
    [IsoId("_rWqbQdt9EeiXqq0XHEoNUA")]
    [Description(
        @"An administrative request, to select and start customised administrative services provided by the POI, using a ""menu"" for an interactive or software interface, initiated by the Sale system."
    )]
    AdministrativeAdminRequest = RetailerServiceCode.AdministrativeAdminRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System responds to an administrative request.
    /// Encoded/decoded by serializers as &quot;ADAP&quot;.
    /// </summary>
    [EnumMember(Value = "ADAP")]
    [IsoId("_rat00dt9EeiXqq0XHEoNUA")]
    [Description(@"The POI System responds to an administrative request.")]
    AdministrativeAdminResponse = RetailerServiceCode.AdministrativeAdminResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System responds to a totals figures request.
    /// Encoded/decoded by serializers as &quot;RPAP&quot;.
    /// </summary>
    [EnumMember(Value = "RPAP")]
    [IsoId("_rfJB0dt9EeiXqq0XHEoNUA")]
    [Description(@"The POI System responds to a totals figures request.")]
    AdministrativeReportGetTotalsResponse =
        RetailerServiceCode.AdministrativeReportGetTotalsResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System a report on the totals figures of the POI system.
    /// Encoded/decoded by serializers as &quot;RPAQ&quot;.
    /// </summary>
    [EnumMember(Value = "RPAQ")]
    [IsoId("_rkO9Mdt9EeiXqq0XHEoNUA")]
    [Description(
        @"The Sale System requests to the POI System a report on the totals figures of the POI system."
    )]
    AdministrativeReportGetTotalsRequest = RetailerServiceCode.AdministrativeReportGetTotalsRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System a report on a list of transactions.
    /// Encoded/decoded by serializers as &quot;RPTQ&quot;.
    /// </summary>
    [EnumMember(Value = "RPTQ")]
    [IsoId("_rpvIQdt9EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests to the POI System a report on a list of transactions.")]
    AdministrativeReportTransactionRequest =
        RetailerServiceCode.AdministrativeReportTransactionRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System responds to a transaction report request.
    /// Encoded/decoded by serializers as &quot;RPTP&quot;.
    /// </summary>
    [EnumMember(Value = "RPTP")]
    [IsoId("_rurSodt9EeiXqq0XHEoNUA")]
    [Description(@"The POI System responds to a transaction report request.")]
    AdministrativeReportTransactionResponse =
        RetailerServiceCode.AdministrativeReportTransactionResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests a session diagnosis to the POI System.
    /// Encoded/decoded by serializers as &quot;SMDQ&quot;.
    /// </summary>
    [EnumMember(Value = "SMDQ")]
    [IsoId("_rzHGsdt9EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests a session diagnosis to the POI System.")]
    AdministrativeSessionManagementDiagnosisRequest =
        RetailerServiceCode.AdministrativeSessionManagementDiagnosisRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System responds to a diagnosis request.
    /// Encoded/decoded by serializers as &quot;SMDP&quot;.
    /// </summary>
    [EnumMember(Value = "SMDP")]
    [IsoId("_r3ScEdt9EeiXqq0XHEoNUA")]
    [Description(@"The POI System responds to a diagnosis request.")]
    AdministrativeSessionManagementDiagnosisResponse =
        RetailerServiceCode.AdministrativeSessionManagementDiagnosisResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests a login to the POI System.
    /// Encoded/decoded by serializers as &quot;SMIQ&quot;.
    /// </summary>
    [EnumMember(Value = "SMIQ")]
    [IsoId("_r7j4Edt9EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests a login to the POI System.")]
    AdministrativeSessionManagementLoginRequest =
        RetailerServiceCode.AdministrativeSessionManagementLoginRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System responds to a login request.
    /// Encoded/decoded by serializers as &quot;SMIP&quot;.
    /// </summary>
    [EnumMember(Value = "SMIP")]
    [IsoId("_sAHn8dt9EeiXqq0XHEoNUA")]
    [Description(@"The POI System responds to a login request.")]
    AdministrativeSessionManagementLoginResponse =
        RetailerServiceCode.AdministrativeSessionManagementLoginResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests a logout to the POI System.
    /// Encoded/decoded by serializers as &quot;SMOQ&quot;.
    /// </summary>
    [EnumMember(Value = "SMOQ")]
    [IsoId("_sEkqIdt9EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests a logout to the POI System.")]
    AdministrativeSessionManagementLogoutRequest =
        RetailerServiceCode.AdministrativeSessionManagementLogoutRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System responds to a logout request.
    /// Encoded/decoded by serializers as &quot;SMOP&quot;.
    /// </summary>
    [EnumMember(Value = "SMOP")]
    [IsoId("_sIm1kdt9EeiXqq0XHEoNUA")]
    [Description(@"The POI System responds to a logout request.")]
    AdministrativeSessionManagementLogoutResponse =
        RetailerServiceCode.AdministrativeSessionManagementLogoutResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One System requests the other to display a message for cashier or customer.
    /// Encoded/decoded by serializers as &quot;DDYQ&quot;.
    /// </summary>
    [EnumMember(Value = "DDYQ")]
    [IsoId("_sM1OQdt9EeiXqq0XHEoNUA")]
    [Description(@"One System requests the other to display a message for cashier or customer.")]
    DeviceDisplayRequest = RetailerServiceCode.DeviceDisplayRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One system responds to the other system for a display request.
    /// Encoded/decoded by serializers as &quot;DDYP&quot;.
    /// </summary>
    [EnumMember(Value = "DDYP")]
    [IsoId("_sR3fQdt9EeiXqq0XHEoNUA")]
    [Description(@"One system responds to the other system for a display request.")]
    DeviceDisplayResponse = RetailerServiceCode.DeviceDisplayResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service to send parameters to use when card reader initializes a new communication with the card.
    /// Encoded/decoded by serializers as &quot;DCIQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCIQ")]
    [IsoId("_sV5qsdt9EeiXqq0XHEoNUA")]
    [Description(
        @"Service to send parameters to use when card reader initializes a new communication with the card."
    )]
    DeviceInitialisationCardReaderRequest =
        RetailerServiceCode.DeviceInitialisationCardReaderRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI system responds to the Sale System for a card reader initialisation.
    /// Encoded/decoded by serializers as &quot;DCIP&quot;.
    /// </summary>
    [EnumMember(Value = "DCIP")]
    [IsoId("_sadakdt9EeiXqq0XHEoNUA")]
    [Description(@"The POI system responds to the Sale System for a card reader initialisation.")]
    DeviceInitialisationCardReaderResponse =
        RetailerServiceCode.DeviceInitialisationCardReaderResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One system sends a notification to the POI System to update a input request.
    /// Encoded/decoded by serializers as &quot;DINO&quot;.
    /// </summary>
    [EnumMember(Value = "DINO")]
    [IsoId("_se1kQdt9EeiXqq0XHEoNUA")]
    [Description(@"One system sends a notification to the POI System to update a input request.")]
    DeviceInputNotification = RetailerServiceCode.DeviceInputNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One system requests to the other System to get data input.
    /// Encoded/decoded by serializers as &quot;DINQ&quot;.
    /// </summary>
    [EnumMember(Value = "DINQ")]
    [IsoId("_sjmIcdt9EeiXqq0XHEoNUA")]
    [Description(@"One system requests to the other System to get data input. ")]
    DeviceInputRequest = RetailerServiceCode.DeviceInputRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One system responds to the other System for a input request.
    /// Encoded/decoded by serializers as &quot;DINP&quot;.
    /// </summary>
    [EnumMember(Value = "DINP")]
    [IsoId("_snlQkdt9EeiXqq0XHEoNUA")]
    [Description(@"One system responds to the other System for a input request.")]
    DeviceInputResponse = RetailerServiceCode.DeviceInputResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One system requests to the Other System to play a sound.
    /// Encoded/decoded by serializers as &quot;DSOQ&quot;.
    /// </summary>
    [EnumMember(Value = "DSOQ")]
    [IsoId("_sr2Fgdt9EeiXqq0XHEoNUA")]
    [Description(@"One system requests to the Other System to play a sound.")]
    DevicePlaySoundRequest = RetailerServiceCode.DevicePlaySoundRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One system responds to the other System for a play sound request.
    /// Encoded/decoded by serializers as &quot;DSOP&quot;.
    /// </summary>
    [EnumMember(Value = "DSOP")]
    [IsoId("_sv2bwdt9EeiXqq0XHEoNUA")]
    [Description(@"One system responds to the other System for a play sound request.")]
    DevicePlaySoundResponse = RetailerServiceCode.DevicePlaySoundResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale system requests to the POI System to power off the card reader.
    /// Encoded/decoded by serializers as &quot;DCPQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCPQ")]
    [IsoId("_s4nWMdt9EeiXqq0XHEoNUA")]
    [Description(@"The Sale system requests to the POI System to power off the card reader.")]
    DevicePowerOffCardReaderRequest = RetailerServiceCode.DevicePowerOffCardReaderRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI system responds to the Sale System for a card reader power off.
    /// Encoded/decoded by serializers as &quot;DCPP&quot;.
    /// </summary>
    [EnumMember(Value = "DCPP")]
    [IsoId("_s86nYdt9EeiXqq0XHEoNUA")]
    [Description(@"The POI system responds to the Sale System for a card reader power off.")]
    DevicePowerOffCardRequestResponse = RetailerServiceCode.DevicePowerOffCardRequestResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One system requests to the other System to print data.
    /// Encoded/decoded by serializers as &quot;DPRQ&quot;.
    /// </summary>
    [EnumMember(Value = "DPRQ")]
    [IsoId("_tA_PEdt9EeiXqq0XHEoNUA")]
    [Description(@"One system requests to the other System to print data.")]
    DevicePrintRequest = RetailerServiceCode.DevicePrintRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One system responds to the other System for a print request.
    /// Encoded/decoded by serializers as &quot;DPRP&quot;.
    /// </summary>
    [EnumMember(Value = "DPRP")]
    [IsoId("_tF5kQdt9EeiXqq0XHEoNUA")]
    [Description(@"One system responds to the other System for a print request.")]
    DevicePrintResponse = RetailerServiceCode.DevicePrintResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One system requests to the Other System to securely get data input (e.g. for PIN).
    /// Encoded/decoded by serializers as &quot;DSIQ&quot;.
    /// </summary>
    [EnumMember(Value = "DSIQ")]
    [IsoId("_tQaLIdt9EeiXqq0XHEoNUA")]
    [Description(
        @"One system requests to the Other System to securely get data input (e.g. for PIN)."
    )]
    DeviceSecureInputRequest = RetailerServiceCode.DeviceSecureInputRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One system responds to the other System for secure data input.
    /// Encoded/decoded by serializers as &quot;DSIP&quot;.
    /// </summary>
    [EnumMember(Value = "DSIP")]
    [IsoId("_tUgoAdt9EeiXqq0XHEoNUA")]
    [Description(@"One system responds to the other System for secure data input.")]
    DeviceSecureInputResponse = RetailerServiceCode.DeviceSecureInputResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI system responds to the Sale System for a card reader Application Protocol Data Unit sending.
    /// Encoded/decoded by serializers as &quot;DCAP&quot;.
    /// </summary>
    [EnumMember(Value = "DCAP")]
    [IsoId("_txNLEdt9EeiXqq0XHEoNUA")]
    [Description(
        @"The POI system responds to the Sale System for a card reader Application Protocol Data Unit sending."
    )]
    DeviceSendApplicationProtocolDataUnitCardReaderResponse =
        RetailerServiceCode.DeviceSendApplicationProtocolDataUnitCardReaderResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale system requests to the POI System to transmit a message (for instance to a mobile server).
    /// Encoded/decoded by serializers as &quot;DCOQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCOQ")]
    [IsoId("_t1WrQdt9EeiXqq0XHEoNUA")]
    [Description(
        @"The Sale system requests to the POI System to transmit a message (for instance to a mobile server)."
    )]
    DeviceTransmissionMessageRequest = RetailerServiceCode.DeviceTransmissionMessageRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI system responds to the Sale System after a message transmission.
    /// Encoded/decoded by serializers as &quot;DCOP&quot;.
    /// </summary>
    [EnumMember(Value = "DCOP")]
    [IsoId("_t5fkYdt9EeiXqq0XHEoNUA")]
    [Description(@"The POI system responds to the Sale System after a message transmission.")]
    DeviceTransmissionMessageResponse = RetailerServiceCode.DeviceTransmissionMessageResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System to perform balance inquiry on the main account.
    /// Encoded/decoded by serializers as &quot;FSIQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSIQ")]
    [IsoId("_t9fTkdt9EeiXqq0XHEoNUA")]
    [Description(
        @"The Sale System requests to the POI System to perform balance inquiry on the main account."
    )]
    FinancialBalanceInquiryRequest = RetailerServiceCode.FinancialBalanceInquiryRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response to a Balance Inquiry request.
    /// Encoded/decoded by serializers as &quot;FSIP&quot;.
    /// </summary>
    [EnumMember(Value = "FSIP")]
    [IsoId("_uCehQdt9EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response to a Balance Inquiry request.")]
    FinancialBalanceInquiryResponse = RetailerServiceCode.FinancialBalanceInquiryResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Batch message pair is used to request or get the result of transactions (payment, loyalty and reversal) performed without connection to the Sale system (Payment delivery).
    /// Encoded/decoded by serializers as &quot;FSBQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSBQ")]
    [IsoId("_uHPFcdt9EeiXqq0XHEoNUA")]
    [Description(
        @"The Batch message pair is used to request or get the result of transactions (payment, loyalty and reversal) performed without connection to the Sale system (Payment delivery)."
    )]
    FinancialBatchRequest = RetailerServiceCode.FinancialBatchRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response to a batch processing request.
    /// Encoded/decoded by serializers as &quot;FSBP&quot;.
    /// </summary>
    [EnumMember(Value = "FSBP")]
    [IsoId("_uTA3odt9EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response to a batch processing request.")]
    FinancialBatchResponse = RetailerServiceCode.FinancialBatchResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System to handle a card data acquisition on the card reader.
    /// Encoded/decoded by serializers as &quot;FSAQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSAQ")]
    [IsoId("_uZhIQdt9EeiXqq0XHEoNUA")]
    [Description(
        @"The Sale System requests to the POI System to handle a card data acquisition on the card reader."
    )]
    FinancialCardAcquisitionRequest = RetailerServiceCode.FinancialCardAcquisitionRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response to a card data acquisition request.
    /// Encoded/decoded by serializers as &quot;FSAP&quot;.
    /// </summary>
    [EnumMember(Value = "FSAP")]
    [IsoId("_ukr2cdt9EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response to a card data acquisition request.")]
    FinancialCardAcquisitionResponse = RetailerServiceCode.FinancialCardAcquisitionResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System to enable a service on its side.
    /// Encoded/decoded by serializers as &quot;FSEQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSEQ")]
    [IsoId("_urGAcdt9EeiXqq0XHEoNUA")]
    [Description(@"The Sale System requests to the POI System to enable a service on its side.")]
    FinancialEnableServiceRequest = RetailerServiceCode.FinancialEnableServiceRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response after enabling or not some service.
    /// Encoded/decoded by serializers as &quot;FSEP&quot;.
    /// </summary>
    [EnumMember(Value = "FSEP")]
    [IsoId("_uwXiAdt9EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response after enabling or not some service.")]
    FinancialEnableServiceResponse = RetailerServiceCode.FinancialEnableServiceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System a loyalty service like loading or redeem.
    /// Encoded/decoded by serializers as &quot;FSLQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSLQ")]
    [IsoId("_u0nv4dt9EeiXqq0XHEoNUA")]
    [Description(
        @"The Sale System requests to the POI System a loyalty service like loading or redeem."
    )]
    FinancialLoyaltyRequest = RetailerServiceCode.FinancialLoyaltyRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response to a loyalty processing request.
    /// Encoded/decoded by serializers as &quot;FSLP&quot;.
    /// </summary>
    [EnumMember(Value = "FSLP")]
    [IsoId("_u5qA4dt9EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response to a loyalty processing request.")]
    FinancialLoyaltyResponse = RetailerServiceCode.FinancialLoyaltyResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System to perform a payment(Purchase/Refund/PWCB/MOTO Payment/...).
    /// Encoded/decoded by serializers as &quot;FSPQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSPQ")]
    [IsoId("_u-Nwwdt9EeiXqq0XHEoNUA")]
    [Description(
        @"The Sale System requests to the POI System to perform a payment(Purchase/Refund/PWCB/MOTO Payment/...)."
    )]
    FinancialPaymentRequest = RetailerServiceCode.FinancialPaymentRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response to a payment request (Purchase/refund/PWCB/MOTO Payment/...).
    /// Encoded/decoded by serializers as &quot;FSPP&quot;.
    /// </summary>
    [EnumMember(Value = "FSPP")]
    [IsoId("_vCOuEdt9EeiXqq0XHEoNUA")]
    [Description(
        @"The POI System sends a response to a payment request (Purchase/refund/PWCB/MOTO Payment/...)."
    )]
    FinancialPaymentResponse = RetailerServiceCode.FinancialPaymentResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System request to the POI System different kinds of transaction reconciliation.
    /// Encoded/decoded by serializers as &quot;FSCQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSCQ")]
    [IsoId("_vGdGwdt9EeiXqq0XHEoNUA")]
    [Description(
        @"The Sale System request to the POI System different kinds of transaction reconciliation. "
    )]
    FinancialReconciliationRequest = RetailerServiceCode.FinancialReconciliationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response to a reconciliation request.
    /// Encoded/decoded by serializers as &quot;FSCP&quot;.
    /// </summary>
    [EnumMember(Value = "FSCP")]
    [IsoId("_vKddAdt9EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response to a reconciliation request.")]
    FinancialReconciliationResponse = RetailerServiceCode.FinancialReconciliationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System to perform a reversal partial or complete to cancel a former payment service.
    /// Encoded/decoded by serializers as &quot;FSRQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSRQ")]
    [IsoId("_vOyjYdt9EeiXqq0XHEoNUA")]
    [Description(
        @"The Sale System requests to the POI System to perform a reversal partial or complete to cancel a former payment service."
    )]
    FinancialReversalRequest = RetailerServiceCode.FinancialReversalRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response to a reversal request.
    /// Encoded/decoded by serializers as &quot;FSRP&quot;.
    /// </summary>
    [EnumMember(Value = "FSRP")]
    [IsoId("_vlMRMdt9EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response to a reversal request.")]
    FinancialReversalResponse = RetailerServiceCode.FinancialReversalResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System to manage a stored value card or account (eg. Load, Payment, Reimbursement).
    /// Encoded/decoded by serializers as &quot;FSVQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSVQ")]
    [IsoId("_vpap4dt9EeiXqq0XHEoNUA")]
    [Description(
        @"The Sale System requests to the POI System to manage a stored value card or account (eg. Load, Payment, Reimbursement)."
    )]
    FinancialStoredValueRequest = RetailerServiceCode.FinancialStoredValueRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response to a stored value card or account request.
    /// Encoded/decoded by serializers as &quot;FSVP&quot;.
    /// </summary>
    [EnumMember(Value = "FSVP")]
    [IsoId("_vt6IUdt9EeiXqq0XHEoNUA")]
    [Description(@"The POI System sends a response to a stored value card or account request.")]
    FinancialStoredValueResponse = RetailerServiceCode.FinancialStoredValueResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Abort a former request or message by the sale system.
    /// Encoded/decoded by serializers as &quot;SSAB&quot;.
    /// </summary>
    [EnumMember(Value = "SSAB")]
    [IsoId("_vyRq8dt9EeiXqq0XHEoNUA")]
    [Description(@"Abort a former request or message by the sale system.")]
    SystemAbort = RetailerServiceCode.SystemAbort, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Send an Event notification to the other party.
    /// Encoded/decoded by serializers as &quot;SSEN&quot;.
    /// </summary>
    [EnumMember(Value = "SSEN")]
    [IsoId("_v2gDodt9EeiXqq0XHEoNUA")]
    [Description(@"Send an Event notification to the other party.")]
    SystemEventNotification = RetailerServiceCode.SystemEventNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Send a rejection for a previous message.
    /// Encoded/decoded by serializers as &quot;SSRR&quot;.
    /// </summary>
    [EnumMember(Value = "SSRR")]
    [IsoId("_v65bcdt9EeiXqq0XHEoNUA")]
    [Description(@"Send a rejection for a previous message.")]
    SystemMessageRejection = RetailerServiceCode.SystemMessageRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System the status of a previous transaction.
    /// Encoded/decoded by serializers as &quot;SSSQ&quot;.
    /// </summary>
    [EnumMember(Value = "SSSQ")]
    [IsoId("_v_N6wdt9EeiXqq0XHEoNUA")]
    [Description(
        @"The Sale System requests to the POI System the status of a previous transaction."
    )]
    SystemMessageStatusRequest = RetailerServiceCode.SystemMessageStatusRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System responds to a message status request.
    /// Encoded/decoded by serializers as &quot;SSSP&quot;.
    /// </summary>
    [EnumMember(Value = "SSSP")]
    [IsoId("_wD0G4dt9EeiXqq0XHEoNUA")]
    [Description(@"The POI System responds to a message status request.")]
    SystemMessageStatusResponse = RetailerServiceCode.SystemMessageStatusResponse, // same ordinal as derivation source for type conversions
}
