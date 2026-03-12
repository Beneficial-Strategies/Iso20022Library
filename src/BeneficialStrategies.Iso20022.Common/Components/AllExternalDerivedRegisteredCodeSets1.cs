// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// </summary>
[IsoId("_4NglvG_HEe2g-IPZC9d7tA")]
[DisplayName("All External Derived Registered Code Sets")]
public partial record AllExternalDerivedRegisteredCodeSets1
{
    #nullable enable
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL12_HEe2g-IPZC9d7tA")]
    [DisplayName("External Accepted Reason 1 Code")]
    [IsoXmlTag("XtrnlAccptdRsn1Cd")]
    public required ExternalAcceptedReason1Code ExternalAcceptedReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzGW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Account Identification 1 Code")]
    [IsoXmlTag("XtrnlAcctId1Cd")]
    public required ExternalAccountIdentification1Code ExternalAccountIdentification1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzEm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Agent Instruction 1 Code")]
    [IsoXmlTag("XtrnlAgtInstr1Cd")]
    public required ExternalAgentInstruction1Code ExternalAgentInstruction1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ_2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Agreement Type 1 Code")]
    [IsoXmlTag("XtrnlAgrmtTp1Cd")]
    public required ExternalAgreementType1Code ExternalAgreementType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy9W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authentication Channel 1 Code")]
    [IsoXmlTag("XtrnlAuthntcnChanl1Cd")]
    public required ExternalAuthenticationChannel1Code ExternalAuthenticationChannel1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL5W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authentication Method 1 Code")]
    [IsoXmlTag("XtrnlAuthntcnMtd1Cd")]
    public required ExternalAuthenticationMethod1Code ExternalAuthenticationMethod1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaHW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authority Exchange Reason 1 Code")]
    [IsoXmlTag("XtrnlAuthrtyXchgRsn1Cd")]
    public required ExternalAuthorityExchangeReason1Code ExternalAuthorityExchangeReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ5m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authority Identification 1 Code")]
    [IsoXmlTag("XtrnlAuthrtyId1Cd")]
    public required ExternalAuthorityIdentification1Code ExternalAuthorityIdentification1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy9m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Balance Sub Type 1 Code")]
    [IsoXmlTag("XtrnlBalSubTp1Cd")]
    public required ExternalBalanceSubType1Code ExternalBalanceSubType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMEm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Balance Type 1 Code")]
    [IsoXmlTag("XtrnlBalTp1Cd")]
    public required ExternalBalanceType1Code ExternalBalanceType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaJW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Bank Transaction Domain 1 Code")]
    [IsoXmlTag("XtrnlBkTxDomn1Cd")]
    public required ExternalBankTransactionDomain1Code ExternalBankTransactionDomain1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzIW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Bank Transaction Family 1 Code")]
    [IsoXmlTag("XtrnlBkTxFmly1Cd")]
    public required ExternalBankTransactionFamily1Code ExternalBankTransactionFamily1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMIW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Bank Transaction Sub Family 1 Code")]
    [IsoXmlTag("XtrnlBkTxSubFmly1Cd")]
    public required ExternalBankTransactionSubFamily1Code ExternalBankTransactionSubFamily1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMB2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Billing Balance Type 1 Code")]
    [IsoXmlTag("XtrnlBllgBalTp1Cd")]
    public required ExternalBillingBalanceType1Code ExternalBillingBalanceType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy3W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Billing Compensation Type 1 Code")]
    [IsoXmlTag("XtrnlBllgCompstnTp1Cd")]
    public required ExternalBillingCompensationType1Code ExternalBillingCompensationType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL5G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Billing Rate Identification 1 Code")]
    [IsoXmlTag("XtrnlBllgRateId1Cd")]
    public required ExternalBillingRateIdentification1Code ExternalBillingRateIdentification1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMG2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cancellation Reason 1 Code")]
    [IsoXmlTag("XtrnlCxlRsn1Cd")]
    public required ExternalCancellationReason1Code ExternalCancellationReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzGm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Card Transaction Category 1 Code")]
    [IsoXmlTag("XtrnlCardTxCtgy1Cd")]
    public required ExternalCardTransactionCategory1Code ExternalCardTransactionCategory1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy6G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cash Account Type 1 Code")]
    [IsoXmlTag("XtrnlCshAcctTp1Cd")]
    public required ExternalCashAccountType1Code ExternalCashAccountType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy8G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cash Clearing System 1 Code")]
    [IsoXmlTag("XtrnlCshClrSys1Cd")]
    public required ExternalCashClearingSystem1Code ExternalCashClearingSystem1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ8W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Category Purpose 1 Code")]
    [IsoXmlTag("XtrnlCtgyPurp1Cd")]
    public required ExternalCategoryPurpose1Code ExternalCategoryPurpose1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy6m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Channel 1 Code")]
    [IsoXmlTag("XtrnlChanl1Cd")]
    public required ExternalChannel1Code ExternalChannel1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzFG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Charge Type 1 Code")]
    [IsoXmlTag("XtrnlChrgTp1Cd")]
    public required ExternalChargeType1Code ExternalChargeType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy2W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cheque Agent Instruction 1 Code")]
    [IsoXmlTag("XtrnlChqAgtInstr1Cd")]
    public required ExternalChequeAgentInstruction1Code ExternalChequeAgentInstruction1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy5G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cheque Cancellation Reason 1 Code")]
    [IsoXmlTag("XtrnlChqCxlRsn1Cd")]
    public required ExternalChequeCancellationReason1Code ExternalChequeCancellationReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaGm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cheque Cancellation Status 1 Code")]
    [IsoXmlTag("XtrnlChqCxlSts1Cd")]
    public required ExternalChequeCancellationStatus1Code ExternalChequeCancellationStatus1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy2m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Claim Non Receipt Rejection 1 Code")]
    [IsoXmlTag("XtrnlClmNonRctRjctn1Cd")]
    public required ExternalClaimNonReceiptRejection1Code ExternalClaimNonReceiptRejection1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy-G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Clearing System Identification 1 Code")]
    [IsoXmlTag("XtrnlClrSysId1Cd")]
    public required ExternalClearingSystemIdentification1Code ExternalClearingSystemIdentification1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMCm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Communication Format 1 Code")]
    [IsoXmlTag("XtrnlComFrmt1Cd")]
    public required ExternalCommunicationFormat1Code ExternalCommunicationFormat1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzDG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Contract Balance Type 1 Code")]
    [IsoXmlTag("XtrnlCtrctBalTp1Cd")]
    public required ExternalContractBalanceType1Code ExternalContractBalanceType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL8W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Contract Closure Reason 1 Code")]
    [IsoXmlTag("XtrnlCtrctClsrRsn1Cd")]
    public required ExternalContractClosureReason1Code ExternalContractClosureReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaG2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Credit Line Type 1 Code")]
    [IsoXmlTag("XtrnlCdtLineTp1Cd")]
    public required ExternalCreditLineType1Code ExternalCreditLineType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMDG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Agent Instruction 1 Code")]
    [IsoXmlTag("XtrnlCdtrAgtInstr1Cd")]
    public required ExternalCreditorAgentInstruction1Code ExternalCreditorAgentInstruction1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ52_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Enrolment Amendment Reason 1 Code")]
    [IsoXmlTag("XtrnlCdtrEnrlmntAmdmntRsn1Cd")]
    public required ExternalCreditorEnrolmentAmendmentReason1Code ExternalCreditorEnrolmentAmendmentReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaBW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Enrolment Cancellation Reason 1 Code")]
    [IsoXmlTag("XtrnlCdtrEnrlmntCxlRsn1Cd")]
    public required ExternalCreditorEnrolmentCancellationReason1Code ExternalCreditorEnrolmentCancellationReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaDm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Enrolment Status Reason 1 Code")]
    [IsoXmlTag("XtrnlCdtrEnrlmntStsRsn1Cd")]
    public required ExternalCreditorEnrolmentStatusReason1Code ExternalCreditorEnrolmentStatusReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL02_HEe2g-IPZC9d7tA")]
    [DisplayName("External Date Frequency 1 Code")]
    [IsoXmlTag("XtrnlDtFrqcy1Cd")]
    public required ExternalDateFrequency1Code ExternalDateFrequency1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzBG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Activation Amendment Reason 1 Code")]
    [IsoXmlTag("XtrnlDbtrActvtnAmdmntRsn1Cd")]
    public required ExternalDebtorActivationAmendmentReason1Code ExternalDebtorActivationAmendmentReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaH2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Activation Cancellation Reason 1 Code")]
    [IsoXmlTag("XtrnlDbtrActvtnCxlRsn1Cd")]
    public required ExternalDebtorActivationCancellationReason1Code ExternalDebtorActivationCancellationReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMGm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Activation Status Reason 1 Code")]
    [IsoXmlTag("XtrnlDbtrActvtnStsRsn1Cd")]
    public required ExternalDebtorActivationStatusReason1Code ExternalDebtorActivationStatusReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzJG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Agent Instruction 1 Code")]
    [IsoXmlTag("XtrnlDbtrAgtInstr1Cd")]
    public required ExternalDebtorAgentInstruction1Code ExternalDebtorAgentInstruction1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy0W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Discount Amount Type 1 Code")]
    [IsoXmlTag("XtrnlDscntAmtTp1Cd")]
    public required ExternalDiscountAmountType1Code ExternalDiscountAmountType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzG2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Discrepancy 1 Code")]
    [IsoXmlTag("XtrnlDscrpncy1Cd")]
    public required ExternalDiscrepancy1Code ExternalDiscrepancy1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ9W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Format 1 Code")]
    [IsoXmlTag("XtrnlDocFrmt1Cd")]
    public required ExternalDocumentFormat1Code ExternalDocumentFormat1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhME2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Line Type 1 Code")]
    [IsoXmlTag("XtrnlDocLineTp1Cd")]
    public required ExternalDocumentLineType1Code ExternalDocumentLineType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzBW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Purpose 1 Code")]
    [IsoXmlTag("XtrnlDocPurp1Cd")]
    public required ExternalDocumentPurpose1Code ExternalDocumentPurpose1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhLzm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Type 1 Code")]
    [IsoXmlTag("XtrnlDocTp1Cd")]
    public required ExternalDocumentType1Code ExternalDocumentType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL1m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Effective Date Parameter 1 Code")]
    [IsoXmlTag("XtrnlFctvDtParam1Cd")]
    public required ExternalEffectiveDateParameter1Code ExternalEffectiveDateParameter1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhLym_HEe2g-IPZC9d7tA")]
    [DisplayName("External Encrypted Element Identification 1 Code")]
    [IsoXmlTag("XtrnlNcrptdElmtId1Cd")]
    public required ExternalEncryptedElementIdentification1Code ExternalEncryptedElementIdentification1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMAG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Enquiry Request Type 1 Code")]
    [IsoXmlTag("XtrnlEnqryReqTp1Cd")]
    public required ExternalEnquiryRequestType1Code ExternalEnquiryRequestType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMBG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Entry Status 1 Code")]
    [IsoXmlTag("XtrnlNtrySts1Cd")]
    public required ExternalEntryStatus1Code ExternalEntryStatus1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaIW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Financial Institution Identification 1 Code")]
    [IsoXmlTag("XtrnlFIId1Cd")]
    public required ExternalFinancialInstitutionIdentification1Code ExternalFinancialInstitutionIdentification1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaDG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Financial Instrument Identification Type 1 Code")]
    [IsoXmlTag("XtrnlFinInstrmIdTp1Cd")]
    public required ExternalFinancialInstrumentIdentificationType1Code ExternalFinancialInstrumentIdentificationType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhLz2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Financial Instrument Product Type 1 Code")]
    [IsoXmlTag("XtrnlFinInstrmPdctTp1Cd")]
    public required ExternalFinancialInstrumentProductType1Code ExternalFinancialInstrumentProductType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzF2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Garnishment Type 1 Code")]
    [IsoXmlTag("XtrnlGrnshmtTp1Cd")]
    public required ExternalGarnishmentType1Code ExternalGarnishmentType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL3m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Incoterms 1 Code")]
    [IsoXmlTag("XtrnlIncotrms1Cd")]
    public required ExternalIncoterms1Code ExternalIncoterms1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL52_HEe2g-IPZC9d7tA")]
    [DisplayName("External Information Type 1 Code")]
    [IsoXmlTag("XtrnlInfTp1Cd")]
    public required ExternalInformationType1Code ExternalInformationType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhLzW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Instructed Agent Instruction 1 Code")]
    [IsoXmlTag("XtrnlInstdAgtInstr1Cd")]
    public required ExternalInstructedAgentInstruction1Code ExternalInstructedAgentInstruction1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzAW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Investigation Execution Confirmation 1 Code")]
    [IsoXmlTag("XtrnlInvstgtnExctnConf1Cd")]
    public required ExternalInvestigationExecutionConfirmation1Code ExternalInvestigationExecutionConfirmation1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy82_HEe2g-IPZC9d7tA")]
    [DisplayName("External Letter Type 1 Code")]
    [IsoXmlTag("XtrnlLttrTp1Cd")]
    public required ExternalLetterType1Code ExternalLetterType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL6G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Local Instrument 1 Code")]
    [IsoXmlTag("XtrnlLclInstrm1Cd")]
    public required ExternalLocalInstrument1Code ExternalLocalInstrument1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ5G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Reason 1 Code")]
    [IsoXmlTag("XtrnlMndtRsn1Cd")]
    public required ExternalMandateReason1Code ExternalMandateReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy1W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Setup Reason 1 Code")]
    [IsoXmlTag("XtrnlMndtStpRsn1Cd")]
    public required ExternalMandateSetupReason1Code ExternalMandateSetupReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMHG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Status 1 Code")]
    [IsoXmlTag("XtrnlMndtSts1Cd")]
    public required ExternalMandateStatus1Code ExternalMandateStatus1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMFm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Suspension Reason 1 Code")]
    [IsoXmlTag("XtrnlMndtSspnsnRsn1Cd")]
    public required ExternalMandateSuspensionReason1Code ExternalMandateSuspensionReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaIm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Market Area 1 Code")]
    [IsoXmlTag("XtrnlMktArea1Cd")]
    public required ExternalMarketArea1Code ExternalMarketArea1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy3m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Market Infrastructure 1 Code")]
    [IsoXmlTag("XtrnlMktInfrstrctr1Cd")]
    public required ExternalMarketInfrastructure1Code ExternalMarketInfrastructure1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzD2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Model Form Identification 1 Code")]
    [IsoXmlTag("XtrnlMdlFormId1Cd")]
    public required ExternalModelFormIdentification1Code ExternalModelFormIdentification1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ_W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Narrative Type 1 Code")]
    [IsoXmlTag("XtrnlNrrtvTp1Cd")]
    public required ExternalNarrativeType1Code ExternalNarrativeType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzDm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Notification Cancellation Reason 1 Code")]
    [IsoXmlTag("XtrnlNtfctnCxlRsn1Cd")]
    public required ExternalNotificationCancellationReason1Code ExternalNotificationCancellationReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy8W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Organisation Identification 1 Code")]
    [IsoXmlTag("XtrnlOrgId1Cd")]
    public required ExternalOrganisationIdentification1Code ExternalOrganisationIdentification1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaKG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Packaging Type 1 Code")]
    [IsoXmlTag("XtrnlPackgngTp1Cd")]
    public required ExternalPackagingType1Code ExternalPackagingType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaHG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Cancellation Rejection 1 Code")]
    [IsoXmlTag("XtrnlPmtCxlRjctn1Cd")]
    public required ExternalPaymentCancellationRejection1Code ExternalPaymentCancellationRejection1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaKW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Compensation Reason 1 Code")]
    [IsoXmlTag("XtrnlPmtCompstnRsn1Cd")]
    public required ExternalPaymentCompensationReason1Code ExternalPaymentCompensationReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy52_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Control Request Type 1 Code")]
    [IsoXmlTag("XtrnlPmtCtrlReqTp1Cd")]
    public required ExternalPaymentControlRequestType1Code ExternalPaymentControlRequestType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaMG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Group Status 1 Code")]
    [IsoXmlTag("XtrnlPmtGrpSts1Cd")]
    public required ExternalPaymentGroupStatus1Code ExternalPaymentGroupStatus1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhLyG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Modification Rejection 1 Code")]
    [IsoXmlTag("XtrnlPmtModRjctn1Cd")]
    public required ExternalPaymentModificationRejection1Code ExternalPaymentModificationRejection1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ_m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Role 1 Code")]
    [IsoXmlTag("XtrnlPmtRole1Cd")]
    public required ExternalPaymentRole1Code ExternalPaymentRole1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzC2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Transaction Status 1 Code")]
    [IsoXmlTag("XtrnlPmtTxSts1Cd")]
    public required ExternalPaymentTransactionStatus1Code ExternalPaymentTransactionStatus1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ8m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Pending Processing Reason 1 Code")]
    [IsoXmlTag("XtrnlPdgPrcgRsn1Cd")]
    public required ExternalPendingProcessingReason1Code ExternalPendingProcessingReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaBG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Person Identification 1 Code")]
    [IsoXmlTag("XtrnlPrsnId1Cd")]
    public required ExternalPersonIdentification1Code ExternalPersonIdentification1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhLwG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Proxy Account Type 1 Code")]
    [IsoXmlTag("XtrnlPrxyAcctTp1Cd")]
    public required ExternalProxyAccountType1Code ExternalProxyAccountType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMDm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Purpose 1 Code")]
    [IsoXmlTag("XtrnlPurp1Cd")]
    public required ExternalPurpose1Code ExternalPurpose1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzGG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Rates And Tenors 1 Code")]
    [IsoXmlTag("XtrnlRatesAndTnrs1Cd")]
    public required ExternalRatesAndTenors1Code ExternalRatesAndTenors1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaB2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Received Reason 1 Code")]
    [IsoXmlTag("XtrnlRcvdRsn1Cd")]
    public required ExternalReceivedReason1Code ExternalReceivedReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy-m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Rejected Reason 1 Code")]
    [IsoXmlTag("XtrnlRjctdRsn1Cd")]
    public required ExternalRejectedReason1Code ExternalRejectedReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaDW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Relative To 1 Code")]
    [IsoXmlTag("XtrnlRltvTo1Cd")]
    public required ExternalRelativeTo1Code ExternalRelativeTo1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaCm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Reporting Source 1 Code")]
    [IsoXmlTag("XtrnlRptgSrc1Cd")]
    public required ExternalReportingSource1Code ExternalReportingSource1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaFm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Re Presentment Reason 1 Code")]
    [IsoXmlTag("XtrnlRePresntmntRsn1Cd")]
    public required ExternalRePresentmentReason1Code ExternalRePresentmentReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ-G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Reservation Type 1 Code")]
    [IsoXmlTag("XtrnlRsvatnTp1Cd")]
    public required ExternalReservationType1Code ExternalReservationType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy12_HEe2g-IPZC9d7tA")]
    [DisplayName("External Return Reason 1 Code")]
    [IsoXmlTag("XtrnlRtrRsn1Cd")]
    public required ExternalReturnReason1Code ExternalReturnReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaLm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Reversal Reason 1 Code")]
    [IsoXmlTag("XtrnlRvslRsn1Cd")]
    public required ExternalReversalReason1Code ExternalReversalReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaF2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Securities Lending Type 1 Code")]
    [IsoXmlTag("XtrnlSctiesLndgTp1Cd")]
    public required ExternalSecuritiesLendingType1Code ExternalSecuritiesLendingType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ72_HEe2g-IPZC9d7tA")]
    [DisplayName("External Securities Purpose 1 Code")]
    [IsoXmlTag("XtrnlSctiesPurp1Cd")]
    public required ExternalSecuritiesPurpose1Code ExternalSecuritiesPurpose1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy4m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Securities Update Reason 1 Code")]
    [IsoXmlTag("XtrnlSctiesUpdRsn1Cd")]
    public required ExternalSecuritiesUpdateReason1Code ExternalSecuritiesUpdateReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaK2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Service Level 1 Code")]
    [IsoXmlTag("XtrnlSvcLvl1Cd")]
    public required ExternalServiceLevel1Code ExternalServiceLevel1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMGG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Shipment Condition 1 Code")]
    [IsoXmlTag("XtrnlShipmntCond1Cd")]
    public required ExternalShipmentCondition1Code ExternalShipmentCondition1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL9m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Status Reason 1 Code")]
    [IsoXmlTag("XtrnlStsRsn1Cd")]
    public required ExternalStatusReason1Code ExternalStatusReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy7m_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Balance Type 1 Code")]
    [IsoXmlTag("XtrnlSysBalTp1Cd")]
    public required ExternalSystemBalanceType1Code ExternalSystemBalanceType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ7G_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Error Handling 1 Code")]
    [IsoXmlTag("XtrnlSysErrHdlg1Cd")]
    public required ExternalSystemErrorHandling1Code ExternalSystemErrorHandling1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMAm_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Event Type 1 Code")]
    [IsoXmlTag("XtrnlSysEvtTp1Cd")]
    public required ExternalSystemEventType1Code ExternalSystemEventType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzCG_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Member Type 1 Code")]
    [IsoXmlTag("XtrnlSysMmbTp1Cd")]
    public required ExternalSystemMemberType1Code ExternalSystemMemberType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy3G_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Party Type 1 Code")]
    [IsoXmlTag("XtrnlSysPtyTp1Cd")]
    public required ExternalSystemPartyType1Code ExternalSystemPartyType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMA2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Tax Amount Type 1 Code")]
    [IsoXmlTag("XtrnlTaxAmtTp1Cd")]
    public required ExternalTaxAmountType1Code ExternalTaxAmountType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzA2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Technical Input Channel 1 Code")]
    [IsoXmlTag("XtrnlTechInptChanl1Cd")]
    public required ExternalTechnicalInputChannel1Code ExternalTechnicalInputChannel1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy02_HEe2g-IPZC9d7tA")]
    [DisplayName("External Trade Market 1 Code")]
    [IsoXmlTag("XtrnlTradMkt1Cd")]
    public required ExternalTradeMarket1Code ExternalTradeMarket1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMEG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Trade Transaction Condition 1 Code")]
    [IsoXmlTag("XtrnlTradTxCond1Cd")]
    public required ExternalTradeTransactionCondition1Code ExternalTradeTransactionCondition1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzI2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Type Of Party 1 Code")]
    [IsoXmlTag("XtrnlTpOfPty1Cd")]
    public required ExternalTypeOfParty1Code ExternalTypeOfParty1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzFm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Unable To Apply Incorrect Data 1 Code")]
    [IsoXmlTag("XtrnlUblToApplyIncrrctData1Cd")]
    public required ExternalUnableToApplyIncorrectData1Code ExternalUnableToApplyIncorrectData1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy9G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Unable To Apply Missing Data 1 Code")]
    [IsoXmlTag("XtrnlUblToApplyMssngData1Cd")]
    public required ExternalUnableToApplyMissingData1Code ExternalUnableToApplyMissingData1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ-W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Underlying Trade Transaction Type 1 Code")]
    [IsoXmlTag("XtrnlUndrlygTradTxTp1Cd")]
    public required ExternalUnderlyingTradeTransactionType1Code ExternalUnderlyingTradeTransactionType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy8m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Amount Type 1 Code")]
    [IsoXmlTag("XtrnlUdrtkgAmtTp1Cd")]
    public required ExternalUndertakingAmountType1Code ExternalUndertakingAmountType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaIG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Charge Type 1 Code")]
    [IsoXmlTag("XtrnlUdrtkgChrgTp1Cd")]
    public required ExternalUndertakingChargeType1Code ExternalUndertakingChargeType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ7W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Document Type 1 Code")]
    [IsoXmlTag("XtrnlUdrtkgDocTp1Cd")]
    public required ExternalUndertakingDocumentType1Code ExternalUndertakingDocumentType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaCG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Status Category 1 Code")]
    [IsoXmlTag("XtrnlUdrtkgStsCtgy1Cd")]
    public required ExternalUndertakingStatusCategory1Code ExternalUndertakingStatusCategory1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaE2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Type 1 Code")]
    [IsoXmlTag("XtrnlUdrtkgTp1Cd")]
    public required ExternalUndertakingType1Code ExternalUndertakingType1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaAm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Validation Rule Identification 1 Code")]
    [IsoXmlTag("XtrnlVldtnRuleId1Cd")]
    public required ExternalValidationRuleIdentification1Code ExternalValidationRuleIdentification1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy_W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Verification Reason 1 Code")]
    [IsoXmlTag("XtrnlVrfctnRsn1Cd")]
    public required ExternalVerificationReason1Code ExternalVerificationReason1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_uYEBU3C-Ee2QDe42vpiOiA")]
    [DisplayName("External Benchmark Curve Name 1 Code")]
    [IsoXmlTag("XtrnlBchmkCrvNm1Cd")]
    public required ExternalBenchmarkCurveName1Code ExternalBenchmarkCurveName1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_uYEBVHC-Ee2QDe42vpiOiA")]
    [DisplayName("External Unit Of Measure 1 Code")]
    [IsoXmlTag("XtrnlUnitOfMeasr1Cd")]
    public required ExternalUnitOfMeasure1Code ExternalUnitOfMeasure1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_uYNyUHC-Ee2QDe42vpiOiA")]
    [DisplayName("External Party Relationship Type 1 Code")]
    [IsoXmlTag("XtrnlPtyRltshTp1Cd")]
    public required ExternalPartyRelationshipType1Code ExternalPartyRelationshipType1Code { get; init; } 
    
    
    #nullable disable
    
}
