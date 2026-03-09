// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of process related to an ATM message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ha36YInyEeS9F4Qrq_eaVA")]
[Description(@"Identifies the type of process related to an ATM message.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction7Code
{
    /// <summary>
    /// Provide the ATM counters resettting those that are applicable.
    /// Encoded/decoded by serializers as &quot;BALN&quot;.
    /// </summary>
    [EnumMember(Value = "BALN")]
    [IsoId("_nT2f8YnyEeS9F4Qrq_eaVA")]
    [Description(@"Provide the ATM counters resettting those that are applicable.")]
    ATMBalance = MessageFunctionCode.ATMBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Acknowledgement of a completion advice.
    /// Encoded/decoded by serializers as &quot;CMPA&quot;.
    /// </summary>
    [EnumMember(Value = "CMPA")]
    [IsoId("_neu6Q4nyEeS9F4Qrq_eaVA")]
    [Description(@"Acknowledgement of a completion advice.")]
    ATMCompletionAcknowledgement = MessageFunctionCode.ATMCompletionAcknowledgement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice of an ATM transaction completion.
    /// Encoded/decoded by serializers as &quot;CMPD&quot;.
    /// </summary>
    [EnumMember(Value = "CMPD")]
    [IsoId("_nksYU4nyEeS9F4Qrq_eaVA")]
    [Description(@"Advice of an ATM transaction completion.")]
    ATMCompletionAdvice = MessageFunctionCode.ATMCompletionAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Global ATM commands.
    /// Encoded/decoded by serializers as &quot;ACMD&quot;.
    /// </summary>
    [EnumMember(Value = "ACMD")]
    [IsoId("_nq01g4nyEeS9F4Qrq_eaVA")]
    [Description(@"Global ATM commands.")]
    ATMControl = MessageFunctionCode.ATMControl, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maintenance commands to perform.
    /// Encoded/decoded by serializers as &quot;DVCC&quot;.
    /// </summary>
    [EnumMember(Value = "DVCC")]
    [IsoId("_nwyTk4nyEeS9F4Qrq_eaVA")]
    [Description(@"Maintenance commands to perform.")]
    ATMDeviceControl = MessageFunctionCode.ATMDeviceControl, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for a diagnostic.
    /// Encoded/decoded by serializers as &quot;DIAQ&quot;.
    /// </summary>
    [EnumMember(Value = "DIAQ")]
    [IsoId("_n4FOY4nyEeS9F4Qrq_eaVA")]
    [Description(@"Request for a diagnostic.")]
    ATMDiagnosticRequest = MessageFunctionCode.ATMDiagnosticRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to a diagnostic request.
    /// Encoded/decoded by serializers as &quot;DIAP&quot;.
    /// </summary>
    [EnumMember(Value = "DIAP")]
    [IsoId("_n-Csc4nyEeS9F4Qrq_eaVA")]
    [Description(@"Response to a diagnostic request.")]
    ATMDiagnosticResponse = MessageFunctionCode.ATMDiagnosticResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Global status of the ATM.
    /// Encoded/decoded by serializers as &quot;GSTS&quot;.
    /// </summary>
    [EnumMember(Value = "GSTS")]
    [IsoId("_oEJ7g4nyEeS9F4Qrq_eaVA")]
    [Description(@"Global status of the ATM.")]
    ATMGlobalStatus = MessageFunctionCode.ATMGlobalStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for an inquiry.
    /// Encoded/decoded by serializers as &quot;INQQ&quot;.
    /// </summary>
    [EnumMember(Value = "INQQ")]
    [IsoId("_oKHZk4nyEeS9F4Qrq_eaVA")]
    [Description(@"Request for an inquiry.")]
    ATMInquiryRequest = MessageFunctionCode.ATMInquiryRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to an inquiry request.
    /// Encoded/decoded by serializers as &quot;INQP&quot;.
    /// </summary>
    [EnumMember(Value = "INQP")]
    [IsoId("_oQOoo4nyEeS9F4Qrq_eaVA")]
    [Description(@"Response to an inquiry request.")]
    ATMInquiryResponse = MessageFunctionCode.ATMInquiryResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for a key download.
    /// Encoded/decoded by serializers as &quot;KYAQ&quot;.
    /// </summary>
    [EnumMember(Value = "KYAQ")]
    [IsoId("_oWMGs4nyEeS9F4Qrq_eaVA")]
    [Description(@"Request for a key download.")]
    ATMKeyDownloadRequest = MessageFunctionCode.ATMKeyDownloadRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to a key download.
    /// Encoded/decoded by serializers as &quot;KYAP&quot;.
    /// </summary>
    [EnumMember(Value = "KYAP")]
    [IsoId("_ocT804nyEeS9F4Qrq_eaVA")]
    [Description(@"Response to a key download.")]
    ATMKeyDownloadResponse = MessageFunctionCode.ATMKeyDownloadResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for a cardholder PIN management.
    /// Encoded/decoded by serializers as &quot;PINQ&quot;.
    /// </summary>
    [EnumMember(Value = "PINQ")]
    [IsoId("_oibL44nyEeS9F4Qrq_eaVA")]
    [Description(@"Request for a cardholder PIN management.")]
    ATMPINManagementRequest = MessageFunctionCode.ATMPINManagementRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to a cardholder PIN management request.
    /// Encoded/decoded by serializers as &quot;PINP&quot;.
    /// </summary>
    [EnumMember(Value = "PINP")]
    [IsoId("_okqAgYnyEeS9F4Qrq_eaVA")]
    [Description(@"Response to a cardholder PIN management request.")]
    ATMPINManagementResponse = MessageFunctionCode.ATMPINManagementResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rejected request message.
    /// Encoded/decoded by serializers as &quot;RJAQ&quot;.
    /// </summary>
    [EnumMember(Value = "RJAQ")]
    [IsoId("_osj_U4nyEeS9F4Qrq_eaVA")]
    [Description(@"Rejected request message.")]
    ATMRequestReject = MessageFunctionCode.ATMRequestReject, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rejected response message.
    /// Encoded/decoded by serializers as &quot;RJAP&quot;.
    /// </summary>
    [EnumMember(Value = "RJAP")]
    [IsoId("_oyqnU4nyEeS9F4Qrq_eaVA")]
    [Description(@"Rejected response message.")]
    ATMResponseReject = MessageFunctionCode.ATMResponseReject, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response of a withdrawal transaction.
    /// Encoded/decoded by serializers as &quot;WITV&quot;.
    /// </summary>
    [EnumMember(Value = "WITV")]
    [IsoId("_o4oFY4nyEeS9F4Qrq_eaVA")]
    [Description(@"Response of a withdrawal transaction.")]
    ATMWithdrawalAdvice = MessageFunctionCode.ATMWithdrawalAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Acknowledgement of a withdrawal transaction advice.
    /// Encoded/decoded by serializers as &quot;WITK&quot;.
    /// </summary>
    [EnumMember(Value = "WITK")]
    [IsoId("_o6twEYnyEeS9F4Qrq_eaVA")]
    [Description(@"Acknowledgement of a withdrawal transaction advice.")]
    ATMWithdrawalAknowledgement = MessageFunctionCode.ATMWithdrawalAknowledgement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for a withdrawal transaction.
    /// Encoded/decoded by serializers as &quot;WITQ&quot;.
    /// </summary>
    [EnumMember(Value = "WITQ")]
    [IsoId("_pEsyg4nyEeS9F4Qrq_eaVA")]
    [Description(@"Request for a withdrawal transaction.")]
    ATMWithdrawalRequest = MessageFunctionCode.ATMWithdrawalRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to a withdrawal transaction request.
    /// Encoded/decoded by serializers as &quot;WITP&quot;.
    /// </summary>
    [EnumMember(Value = "WITP")]
    [IsoId("_pLIKo4nyEeS9F4Qrq_eaVA")]
    [Description(@"Response to a withdrawal transaction request.")]
    ATMWithdrawalResponse = MessageFunctionCode.ATMWithdrawalResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request the value of the ATM counters.
    /// Encoded/decoded by serializers as &quot;INQC&quot;.
    /// </summary>
    [EnumMember(Value = "INQC")]
    [IsoId("_rAP5M4nyEeS9F4Qrq_eaVA")]
    [Description(@"Request the value of the ATM counters.")]
    CountersInquiry = MessageFunctionCode.CountersInquiry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Acknowledgement of a request from a host to an ATM for contacting.
    /// Encoded/decoded by serializers as &quot;H2AP&quot;.
    /// </summary>
    [EnumMember(Value = "H2AP")]
    [IsoId("_tMFeo4nyEeS9F4Qrq_eaVA")]
    [Description(@"Acknowledgement of a request from a host to an ATM for contacting.")]
    HostToATMAcknowledgement = MessageFunctionCode.HostToATMAcknowledgement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request from a host to an ATM to be contacted by this ATM.
    /// Encoded/decoded by serializers as &quot;H2AQ&quot;.
    /// </summary>
    [EnumMember(Value = "H2AQ")]
    [IsoId("_tSMts4nyEeS9F4Qrq_eaVA")]
    [Description(@"Request from a host to an ATM to be contacted by this ATM.")]
    HostToATMRequest = MessageFunctionCode.HostToATMRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Logical or physical operation on the ATM.
    /// Encoded/decoded by serializers as &quot;TMOP&quot;.
    /// </summary>
    [EnumMember(Value = "TMOP")]
    [IsoId("_uYV2Y4nyEeS9F4Qrq_eaVA")]
    [Description(@"Logical or physical operation on the ATM.")]
    ATMOperation = MessageFunctionCode.ATMOperation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Security Commands.
    /// Encoded/decoded by serializers as &quot;CSEC&quot;.
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_untvI4nyEeS9F4Qrq_eaVA")]
    [Description(@"Security Commands.")]
    SecurityControl = MessageFunctionCode.SecurityControl, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Security detailed report.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_vaugc4nyEeS9F4Qrq_eaVA")]
    [Description(@"Security detailed report.")]
    SecurityDetails = MessageFunctionCode.SecurityDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Result of the key download with the status of the downloaded keys including key check values.
    /// Encoded/decoded by serializers as &quot;SKSC&quot;.
    /// </summary>
    [EnumMember(Value = "SKSC")]
    [IsoId("_v9qOY4nyEeS9F4Qrq_eaVA")]
    [Description(@"Result of the key download with the status of the downloaded keys including key check values.")]
    SecurityKeyCompletion = MessageFunctionCode.SecurityKeyCompletion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status of cryptographic keys.
    /// Encoded/decoded by serializers as &quot;SSTS&quot;.
    /// </summary>
    [EnumMember(Value = "SSTS")]
    [IsoId("_whAMA4nyEeS9F4Qrq_eaVA")]
    [Description(@"Status of cryptographic keys.")]
    SecurityKeyStatus = MessageFunctionCode.SecurityKeyStatus, // same ordinal as derivation source for type conversions
    
}
