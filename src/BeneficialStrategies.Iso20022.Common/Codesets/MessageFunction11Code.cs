// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of process related to an ATM message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_evJWQa1xEeWMg5rOByfExw")]
[Description(@"Identifies the type of process related to an ATM message.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction11Code
{
    /// <summary>
    /// Provide the ATM counters resettting those that are applicable.
    /// Encoded/decoded by serializers as &quot;BALN&quot;.
    /// </summary>
    [EnumMember(Value = "BALN")]
    [IsoId("_e61o4a1xEeWMg5rOByfExw")]
    [Description(@"Provide the ATM counters resettting those that are applicable.")]
    ATMBalance = MessageFunctionCode.ATMBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acknowledgement of a completion advice.
    /// Encoded/decoded by serializers as &quot;CMPA&quot;.
    /// </summary>
    [EnumMember(Value = "CMPA")]
    [IsoId("_e61o461xEeWMg5rOByfExw")]
    [Description(@"Acknowledgement of a completion advice.")]
    ATMCompletionAcknowledgement = MessageFunctionCode.ATMCompletionAcknowledgement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice of an ATM transaction completion.
    /// Encoded/decoded by serializers as &quot;CMPD&quot;.
    /// </summary>
    [EnumMember(Value = "CMPD")]
    [IsoId("_e61o5a1xEeWMg5rOByfExw")]
    [Description(@"Advice of an ATM transaction completion.")]
    ATMCompletionAdvice = MessageFunctionCode.ATMCompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Global ATM commands.
    /// Encoded/decoded by serializers as &quot;ACMD&quot;.
    /// </summary>
    [EnumMember(Value = "ACMD")]
    [IsoId("_e61o561xEeWMg5rOByfExw")]
    [Description(@"Global ATM commands.")]
    ATMControl = MessageFunctionCode.ATMControl, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maintenance commands to perform.
    /// Encoded/decoded by serializers as &quot;DVCC&quot;.
    /// </summary>
    [EnumMember(Value = "DVCC")]
    [IsoId("_e61o6a1xEeWMg5rOByfExw")]
    [Description(@"Maintenance commands to perform.")]
    ATMDeviceControl = MessageFunctionCode.ATMDeviceControl, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for a diagnostic.
    /// Encoded/decoded by serializers as &quot;DIAQ&quot;.
    /// </summary>
    [EnumMember(Value = "DIAQ")]
    [IsoId("_e61o661xEeWMg5rOByfExw")]
    [Description(@"Request for a diagnostic.")]
    ATMDiagnosticRequest = MessageFunctionCode.ATMDiagnosticRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to a diagnostic request.
    /// Encoded/decoded by serializers as &quot;DIAP&quot;.
    /// </summary>
    [EnumMember(Value = "DIAP")]
    [IsoId("_e61o7a1xEeWMg5rOByfExw")]
    [Description(@"Response to a diagnostic request.")]
    ATMDiagnosticResponse = MessageFunctionCode.ATMDiagnosticResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Global status of the ATM.
    /// Encoded/decoded by serializers as &quot;GSTS&quot;.
    /// </summary>
    [EnumMember(Value = "GSTS")]
    [IsoId("_e61o761xEeWMg5rOByfExw")]
    [Description(@"Global status of the ATM.")]
    ATMGlobalStatus = MessageFunctionCode.ATMGlobalStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for an inquiry.
    /// Encoded/decoded by serializers as &quot;INQQ&quot;.
    /// </summary>
    [EnumMember(Value = "INQQ")]
    [IsoId("_e61o8a1xEeWMg5rOByfExw")]
    [Description(@"Request for an inquiry.")]
    ATMInquiryRequest = MessageFunctionCode.ATMInquiryRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to an inquiry request.
    /// Encoded/decoded by serializers as &quot;INQP&quot;.
    /// </summary>
    [EnumMember(Value = "INQP")]
    [IsoId("_e61o861xEeWMg5rOByfExw")]
    [Description(@"Response to an inquiry request.")]
    ATMInquiryResponse = MessageFunctionCode.ATMInquiryResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for a key download.
    /// Encoded/decoded by serializers as &quot;KYAQ&quot;.
    /// </summary>
    [EnumMember(Value = "KYAQ")]
    [IsoId("_e61o9a1xEeWMg5rOByfExw")]
    [Description(@"Request for a key download.")]
    ATMKeyDownloadRequest = MessageFunctionCode.ATMKeyDownloadRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to a key download.
    /// Encoded/decoded by serializers as &quot;KYAP&quot;.
    /// </summary>
    [EnumMember(Value = "KYAP")]
    [IsoId("_e61o961xEeWMg5rOByfExw")]
    [Description(@"Response to a key download.")]
    ATMKeyDownloadResponse = MessageFunctionCode.ATMKeyDownloadResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for a cardholder PIN management.
    /// Encoded/decoded by serializers as &quot;PINQ&quot;.
    /// </summary>
    [EnumMember(Value = "PINQ")]
    [IsoId("_e61o-a1xEeWMg5rOByfExw")]
    [Description(@"Request for a cardholder PIN management.")]
    ATMPINManagementRequest = MessageFunctionCode.ATMPINManagementRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to a cardholder PIN management request.
    /// Encoded/decoded by serializers as &quot;PINP&quot;.
    /// </summary>
    [EnumMember(Value = "PINP")]
    [IsoId("_e61o-61xEeWMg5rOByfExw")]
    [Description(@"Response to a cardholder PIN management request.")]
    ATMPINManagementResponse = MessageFunctionCode.ATMPINManagementResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rejected request message.
    /// Encoded/decoded by serializers as &quot;RJAQ&quot;.
    /// </summary>
    [EnumMember(Value = "RJAQ")]
    [IsoId("_e61o_a1xEeWMg5rOByfExw")]
    [Description(@"Rejected request message.")]
    ATMRequestReject = MessageFunctionCode.ATMRequestReject, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rejected response message.
    /// Encoded/decoded by serializers as &quot;RJAP&quot;.
    /// </summary>
    [EnumMember(Value = "RJAP")]
    [IsoId("_e61o_61xEeWMg5rOByfExw")]
    [Description(@"Rejected response message.")]
    ATMResponseReject = MessageFunctionCode.ATMResponseReject, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response of a withdrawal transaction.
    /// Encoded/decoded by serializers as &quot;WITV&quot;.
    /// </summary>
    [EnumMember(Value = "WITV")]
    [IsoId("_e61pAa1xEeWMg5rOByfExw")]
    [Description(@"Response of a withdrawal transaction.")]
    ATMWithdrawalAdvice = MessageFunctionCode.ATMWithdrawalAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acknowledgement of a withdrawal transaction advice.
    /// Encoded/decoded by serializers as &quot;WITK&quot;.
    /// </summary>
    [EnumMember(Value = "WITK")]
    [IsoId("_e61pA61xEeWMg5rOByfExw")]
    [Description(@"Acknowledgement of a withdrawal transaction advice.")]
    ATMWithdrawalAknowledgement = MessageFunctionCode.ATMWithdrawalAknowledgement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for a withdrawal transaction.
    /// Encoded/decoded by serializers as &quot;WITQ&quot;.
    /// </summary>
    [EnumMember(Value = "WITQ")]
    [IsoId("_e61pBa1xEeWMg5rOByfExw")]
    [Description(@"Request for a withdrawal transaction.")]
    ATMWithdrawalRequest = MessageFunctionCode.ATMWithdrawalRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to a withdrawal transaction request.
    /// Encoded/decoded by serializers as &quot;WITP&quot;.
    /// </summary>
    [EnumMember(Value = "WITP")]
    [IsoId("_e61pB61xEeWMg5rOByfExw")]
    [Description(@"Response to a withdrawal transaction request.")]
    ATMWithdrawalResponse = MessageFunctionCode.ATMWithdrawalResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request the value of the ATM counters.
    /// Encoded/decoded by serializers as &quot;INQC&quot;.
    /// </summary>
    [EnumMember(Value = "INQC")]
    [IsoId("_e61pCa1xEeWMg5rOByfExw")]
    [Description(@"Request the value of the ATM counters.")]
    CountersInquiry = MessageFunctionCode.CountersInquiry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acknowledgement of a request from a host to an ATM for contacting.
    /// Encoded/decoded by serializers as &quot;H2AP&quot;.
    /// </summary>
    [EnumMember(Value = "H2AP")]
    [IsoId("_e61pC61xEeWMg5rOByfExw")]
    [Description(@"Acknowledgement of a request from a host to an ATM for contacting.")]
    HostToATMAcknowledgement = MessageFunctionCode.HostToATMAcknowledgement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request from a host to an ATM to be contacted by this ATM.
    /// Encoded/decoded by serializers as &quot;H2AQ&quot;.
    /// </summary>
    [EnumMember(Value = "H2AQ")]
    [IsoId("_e61pDa1xEeWMg5rOByfExw")]
    [Description(@"Request from a host to an ATM to be contacted by this ATM.")]
    HostToATMRequest = MessageFunctionCode.HostToATMRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Logical or physical operation on the ATM.
    /// Encoded/decoded by serializers as &quot;TMOP&quot;.
    /// </summary>
    [EnumMember(Value = "TMOP")]
    [IsoId("_e61pD61xEeWMg5rOByfExw")]
    [Description(@"Logical or physical operation on the ATM.")]
    ATMOperation = MessageFunctionCode.ATMOperation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security Commands.
    /// Encoded/decoded by serializers as &quot;CSEC&quot;.
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_e61pEa1xEeWMg5rOByfExw")]
    [Description(@"Security Commands.")]
    SecurityControl = MessageFunctionCode.SecurityControl, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security detailed report.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_e61pE61xEeWMg5rOByfExw")]
    [Description(@"Security detailed report.")]
    SecurityDetails = MessageFunctionCode.SecurityDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Result of the key download with the status of the downloaded keys including key check values.
    /// Encoded/decoded by serializers as &quot;SKSC&quot;.
    /// </summary>
    [EnumMember(Value = "SKSC")]
    [IsoId("_e61pFa1xEeWMg5rOByfExw")]
    [Description(
        @"Result of the key download with the status of the downloaded keys including key check values."
    )]
    SecurityKeyCompletion = MessageFunctionCode.SecurityKeyCompletion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status of cryptographic keys.
    /// Encoded/decoded by serializers as &quot;SSTS&quot;.
    /// </summary>
    [EnumMember(Value = "SSTS")]
    [IsoId("_e61pF61xEeWMg5rOByfExw")]
    [Description(@"Status of cryptographic keys.")]
    SecurityKeyStatus = MessageFunctionCode.SecurityKeyStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acknowledgement of a deposit completion advice.
    /// Encoded/decoded by serializers as &quot;DPSK&quot;.
    /// </summary>
    [EnumMember(Value = "DPSK")]
    [IsoId("_lLyCga1xEeWMg5rOByfExw")]
    [Description(@"Acknowledgement of a deposit completion advice.")]
    ATMDepositCompletionAcknowledgement = MessageFunctionCode.ATMDepositCompletionAcknowledgement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice of an ATM deposit transaction completion.
    /// Encoded/decoded by serializers as &quot;DPSV&quot;.
    /// </summary>
    [EnumMember(Value = "DPSV")]
    [IsoId("_lT-VMa1xEeWMg5rOByfExw")]
    [Description(@"Advice of an ATM deposit transaction completion.")]
    ATMDepositCompletionAdvice = MessageFunctionCode.ATMDepositCompletionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for a deposit.
    /// Encoded/decoded by serializers as &quot;DPSQ&quot;.
    /// </summary>
    [EnumMember(Value = "DPSQ")]
    [IsoId("_ld0Nsa1xEeWMg5rOByfExw")]
    [Description(@"Request for a deposit.")]
    ATMDepositRequest = MessageFunctionCode.ATMDepositRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to a deposit request.
    /// Encoded/decoded by serializers as &quot;DPSP&quot;.
    /// </summary>
    [EnumMember(Value = "DPSP")]
    [IsoId("_lmAgYa1xEeWMg5rOByfExw")]
    [Description(@"Response to a deposit request.")]
    ATMDepositResponse = MessageFunctionCode.ATMDepositResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acknowledgement of an exception advice.
    /// Encoded/decoded by serializers as &quot;EXPK&quot;.
    /// </summary>
    [EnumMember(Value = "EXPK")]
    [IsoId("_mGqWYa1xEeWMg5rOByfExw")]
    [Description(@"Acknowledgement of an exception advice.")]
    ATMExceptionAcknowledgement = MessageFunctionCode.ATMExceptionAcknowledgement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice of an ATM exception.
    /// Encoded/decoded by serializers as &quot;EXPV&quot;.
    /// </summary>
    [EnumMember(Value = "EXPV")]
    [IsoId("_mOakMa1xEeWMg5rOByfExw")]
    [Description(@"Advice of an ATM exception.")]
    ATMExceptionAdvice = MessageFunctionCode.ATMExceptionAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for a fund transfer.
    /// Encoded/decoded by serializers as &quot;TRFQ&quot;.
    /// </summary>
    [EnumMember(Value = "TRFQ")]
    [IsoId("_n5vdka1xEeWMg5rOByfExw")]
    [Description(@"Request for a fund transfer.")]
    ATMTransferRequest = MessageFunctionCode.ATMTransferRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to a fund transfer request.
    /// Encoded/decoded by serializers as &quot;TRFP&quot;.
    /// </summary>
    [EnumMember(Value = "TRFP")]
    [IsoId("_oCFhQa1xEeWMg5rOByfExw")]
    [Description(@"Response to a fund transfer request.")]
    ATMTransferResponse = MessageFunctionCode.ATMTransferResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Provide the value of the ATM counters, no reinitialisation of the counters.
    /// Encoded/decoded by serializers as &quot;RPTC&quot;.
    /// </summary>
    [EnumMember(Value = "RPTC")]
    [IsoId("_rsA1Ua1xEeWMg5rOByfExw")]
    [Description(@"Provide the value of the ATM counters, no reinitialisation of the counters.")]
    CountersReport = MessageFunctionCode.CountersReport, // same ordinal as derivation source for type conversions
}
