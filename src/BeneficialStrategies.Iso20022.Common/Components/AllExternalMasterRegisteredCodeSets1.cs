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
[IsoId("_3toyJW_HEe2g-IPZC9d7tA")]
[DisplayName("All External Master Registered Code Sets")]
public partial record AllExternalMasterRegisteredCodeSets1
{
    #nullable enable
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyLG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Accepted Reason Code")]
    [IsoXmlTag("XtrnlAccptdRsnCd")]
    public required ExternalAcceptedReasonCode ExternalAcceptedReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnA2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Account Identification Code")]
    [IsoXmlTag("XtrnlAcctIdCd")]
    public required ExternalAccountIdentificationCode ExternalAccountIdentificationCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_9W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Agent Instruction Code")]
    [IsoXmlTag("XtrnlAgtInstrCd")]
    public required ExternalAgentInstructionCode ExternalAgentInstructionCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAa2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Agreement Type Code")]
    [IsoXmlTag("XtrnlAgrmtTpCd")]
    public required ExternalAgreementTypeCode ExternalAgreementTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAXG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authentication Channel Code")]
    [IsoXmlTag("XtrnlAuthntcnChanlCd")]
    public required ExternalAuthenticationChannelCode ExternalAuthenticationChannelCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyOG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authentication Method Code")]
    [IsoXmlTag("XtrnlAuthntcnMtdCd")]
    public required ExternalAuthenticationMethodCode ExternalAuthenticationMethodCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqATW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authority Exchange Reason Code")]
    [IsoXmlTag("XtrnlAuthrtyXchgRsnCd")]
    public required ExternalAuthorityExchangeReasonCode ExternalAuthorityExchangeReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAKm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authority Identification Code")]
    [IsoXmlTag("XtrnlAuthrtyIdCd")]
    public required ExternalAuthorityIdentificationCode ExternalAuthorityIdentificationCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnG2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Balance Sub Type Code")]
    [IsoXmlTag("XtrnlBalSubTpCd")]
    public required ExternalBalanceSubTypeCode ExternalBalanceSubTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAHG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Balance Type Code")]
    [IsoXmlTag("XtrnlBalTpCd")]
    public required ExternalBalanceTypeCode ExternalBalanceTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAaG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Bank Transaction Domain Code")]
    [IsoXmlTag("XtrnlBkTxDomnCd")]
    public required ExternalBankTransactionDomainCode ExternalBankTransactionDomainCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_8W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Bank Transaction Family Code")]
    [IsoXmlTag("XtrnlBkTxFmlyCd")]
    public required ExternalBankTransactionFamilyCode ExternalBankTransactionFamilyCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAIm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Bank Transaction Sub Family Code")]
    [IsoXmlTag("XtrnlBkTxSubFmlyCd")]
    public required ExternalBankTransactionSubFamilyCode ExternalBankTransactionSubFamilyCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY7m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Billing Balance Type Code")]
    [IsoXmlTag("XtrnlBllgBalTpCd")]
    public required ExternalBillingBalanceTypeCode ExternalBillingBalanceTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAJm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Billing Compensation Type Code")]
    [IsoXmlTag("XtrnlBllgCompstnTpCd")]
    public required ExternalBillingCompensationTypeCode ExternalBillingCompensationTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY72_HEe2g-IPZC9d7tA")]
    [DisplayName("External Billing Rate Identification Code")]
    [IsoXmlTag("XtrnlBllgRateIdCd")]
    public required ExternalBillingRateIdentificationCode ExternalBillingRateIdentificationCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAD2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cancellation Reason Code")]
    [IsoXmlTag("XtrnlCxlRsnCd")]
    public required ExternalCancellationReasonCode ExternalCancellationReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyMW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Card Transaction Category Code")]
    [IsoXmlTag("XtrnlCardTxCtgyCd")]
    public required ExternalCardTransactionCategoryCode ExternalCardTransactionCategoryCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnEG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cash Account Type Code")]
    [IsoXmlTag("XtrnlCshAcctTpCd")]
    public required ExternalCashAccountTypeCode ExternalCashAccountTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnKG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cash Clearing System Code")]
    [IsoXmlTag("XtrnlCshClrSysCd")]
    public required ExternalCashClearingSystemCode ExternalCashClearingSystemCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAGW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Category Purpose Code")]
    [IsoXmlTag("XtrnlCtgyPurpCd")]
    public required ExternalCategoryPurposeCode ExternalCategoryPurposeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyVm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Channel Code")]
    [IsoXmlTag("XtrnlChanlCd")]
    public required ExternalChannelCode ExternalChannelCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyOW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Charge Type Code")]
    [IsoXmlTag("XtrnlChrgTpCd")]
    public required ExternalChargeTypeCode ExternalChargeTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAN2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cheque Agent Instruction Code")]
    [IsoXmlTag("XtrnlChqAgtInstrCd")]
    public required ExternalChequeAgentInstructionCode ExternalChequeAgentInstructionCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqASm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cheque Cancellation Reason Code")]
    [IsoXmlTag("XtrnlChqCxlRsnCd")]
    public required ExternalChequeCancellationReasonCode ExternalChequeCancellationReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyNm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cheque Cancellation Status Code")]
    [IsoXmlTag("XtrnlChqCxlStsCd")]
    public required ExternalChequeCancellationStatusCode ExternalChequeCancellationStatusCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnDm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Claim Non Receipt Rejection Code")]
    [IsoXmlTag("XtrnlClmNonRctRjctnCd")]
    public required ExternalClaimNonReceiptRejectionCode ExternalClaimNonReceiptRejectionCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAAm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Clearing System Identification Code")]
    [IsoXmlTag("XtrnlClrSysIdCd")]
    public required ExternalClearingSystemIdentificationCode ExternalClearingSystemIdentificationCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAI2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Clearing System Member Code")]
    [IsoXmlTag("XtrnlClrSysMmbCd")]
    public required ExternalClearingSystemMemberCode ExternalClearingSystemMemberCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAH2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Communication Format Code")]
    [IsoXmlTag("XtrnlComFrmtCd")]
    public required ExternalCommunicationFormatCode ExternalCommunicationFormatCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAYm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Contract Balance Type Code")]
    [IsoXmlTag("XtrnlCtrctBalTpCd")]
    public required ExternalContractBalanceTypeCode ExternalContractBalanceTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAA2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Contract Closure Reason Code")]
    [IsoXmlTag("XtrnlCtrctClsrRsnCd")]
    public required ExternalContractClosureReasonCode ExternalContractClosureReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_9m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Credit Line Type Code")]
    [IsoXmlTag("XtrnlCdtLineTpCd")]
    public required ExternalCreditLineTypeCode ExternalCreditLineTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOHm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Agent Instruction Code")]
    [IsoXmlTag("XtrnlCdtrAgtInstrCd")]
    public required ExternalCreditorAgentInstructionCode ExternalCreditorAgentInstructionCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqARG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Enrolment Amendment Reason Code")]
    [IsoXmlTag("XtrnlCdtrEnrlmntAmdmntRsnCd")]
    public required ExternalCreditorEnrolmentAmendmentReasonCode ExternalCreditorEnrolmentAmendmentReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqATm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Enrolment Cancellation Reason Code")]
    [IsoXmlTag("XtrnlCdtrEnrlmntCxlRsnCd")]
    public required ExternalCreditorEnrolmentCancellationReasonCode ExternalCreditorEnrolmentCancellationReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyVG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Enrolment Status Reason Code")]
    [IsoXmlTag("XtrnlCdtrEnrlmntStsRsnCd")]
    public required ExternalCreditorEnrolmentStatusReasonCode ExternalCreditorEnrolmentStatusReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY52_HEe2g-IPZC9d7tA")]
    [DisplayName("External Date Frequency Code")]
    [IsoXmlTag("XtrnlDtFrqcyCd")]
    public required ExternalDateFrequencyCode ExternalDateFrequencyCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_8G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Activation Amendment Reason Code")]
    [IsoXmlTag("XtrnlDbtrActvtnAmdmntRsnCd")]
    public required ExternalDebtorActivationAmendmentReasonCode ExternalDebtorActivationAmendmentReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOEW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Activation Cancellation Reason Code")]
    [IsoXmlTag("XtrnlDbtrActvtnCxlRsnCd")]
    public required ExternalDebtorActivationCancellationReasonCode ExternalDebtorActivationCancellationReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyT2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Activation Status Reason Code")]
    [IsoXmlTag("XtrnlDbtrActvtnStsRsnCd")]
    public required ExternalDebtorActivationStatusReasonCode ExternalDebtorActivationStatusReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqADW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Agent Instruction Code")]
    [IsoXmlTag("XtrnlDbtrAgtInstrCd")]
    public required ExternalDebtorAgentInstructionCode ExternalDebtorAgentInstructionCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqABG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Discount Amount Type Code")]
    [IsoXmlTag("XtrnlDscntAmtTpCd")]
    public required ExternalDiscountAmountTypeCode ExternalDiscountAmountTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyQ2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Discrepancy Code")]
    [IsoXmlTag("XtrnlDscrpncyCd")]
    public required ExternalDiscrepancyCode ExternalDiscrepancyCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOEG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Format Code")]
    [IsoXmlTag("XtrnlDocFrmtCd")]
    public required ExternalDocumentFormatCode ExternalDocumentFormatCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAIW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Line Type Code")]
    [IsoXmlTag("XtrnlDocLineTpCd")]
    public required ExternalDocumentLineTypeCode ExternalDocumentLineTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAUG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Purpose Code")]
    [IsoXmlTag("XtrnlDocPurpCd")]
    public required ExternalDocumentPurposeCode ExternalDocumentPurposeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnHm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Type Code")]
    [IsoXmlTag("XtrnlDocTpCd")]
    public required ExternalDocumentTypeCode ExternalDocumentTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqALG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Effective Date Parameter Code")]
    [IsoXmlTag("XtrnlFctvDtParamCd")]
    public required ExternalEffectiveDateParameterCode ExternalEffectiveDateParameterCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnFG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Encrypted Element Identification Code")]
    [IsoXmlTag("XtrnlNcrptdElmtIdCd")]
    public required ExternalEncryptedElementIdentificationCode ExternalEncryptedElementIdentificationCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAPm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Enquiry Request Type Code")]
    [IsoXmlTag("XtrnlEnqryReqTpCd")]
    public required ExternalEnquiryRequestTypeCode ExternalEnquiryRequestTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyO2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Entry Status Code")]
    [IsoXmlTag("XtrnlNtryStsCd")]
    public required ExternalEntryStatusCode ExternalEntryStatusCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOG2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Financial Institution Identification Code")]
    [IsoXmlTag("XtrnlFIIdCd")]
    public required ExternalFinancialInstitutionIdentificationCode ExternalFinancialInstitutionIdentificationCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnCG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Financial Instrument Identification Type Code")]
    [IsoXmlTag("XtrnlFinInstrmIdTpCd")]
    public required ExternalFinancialInstrumentIdentificationTypeCode ExternalFinancialInstrumentIdentificationTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyQW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Financial Instrument Product Type Code")]
    [IsoXmlTag("XtrnlFinInstrmPdctTpCd")]
    public required ExternalFinancialInstrumentProductTypeCode ExternalFinancialInstrumentProductTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAY2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Garnishment Type Code")]
    [IsoXmlTag("XtrnlGrnshmtTpCd")]
    public required ExternalGarnishmentTypeCode ExternalGarnishmentTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAOm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Incoterms Code")]
    [IsoXmlTag("XtrnlIncotrmsCd")]
    public required ExternalIncotermsCode ExternalIncotermsCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnCm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Information Type Code")]
    [IsoXmlTag("XtrnlInfTpCd")]
    public required ExternalInformationTypeCode ExternalInformationTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAEG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Instructed Agent Instruction Code")]
    [IsoXmlTag("XtrnlInstdAgtInstrCd")]
    public required ExternalInstructedAgentInstructionCode ExternalInstructedAgentInstructionCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyQm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Invalid Event Reason Code")]
    [IsoXmlTag("XtrnlInvldEvtRsnCd")]
    public required ExternalInvalidEventReasonCode ExternalInvalidEventReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyN2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Invalid Payments Event Code")]
    [IsoXmlTag("XtrnlInvldPmtsEvtCd")]
    public required ExternalInvalidPaymentsEventCode ExternalInvalidPaymentsEventCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAU2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Investigation Execution Confirmation Code")]
    [IsoXmlTag("XtrnlInvstgtnExctnConfCd")]
    public required ExternalInvestigationExecutionConfirmationCode ExternalInvestigationExecutionConfirmationCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqACm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Letter Type Code")]
    [IsoXmlTag("XtrnlLttrTpCd")]
    public required ExternalLetterTypeCode ExternalLetterTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnLG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Local Instrument Code")]
    [IsoXmlTag("XtrnlLclInstrmCd")]
    public required ExternalLocalInstrumentCode ExternalLocalInstrumentCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAAG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Reason Code")]
    [IsoXmlTag("XtrnlMndtRsnCd")]
    public required ExternalMandateReasonCode ExternalMandateReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAEm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Setup Reason Code")]
    [IsoXmlTag("XtrnlMndtStpRsnCd")]
    public required ExternalMandateSetupReasonCode ExternalMandateSetupReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnDG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Status Code")]
    [IsoXmlTag("XtrnlMndtStsCd")]
    public required ExternalMandateStatusCode ExternalMandateStatusCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOE2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Suspension Reason Code")]
    [IsoXmlTag("XtrnlMndtSspnsnRsnCd")]
    public required ExternalMandateSuspensionReasonCode ExternalMandateSuspensionReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOGW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Market Infrastructure Code")]
    [IsoXmlTag("XtrnlMktInfrstrctrCd")]
    public required ExternalMarketInfrastructureCode ExternalMarketInfrastructureCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY5m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Model Form Identification Code")]
    [IsoXmlTag("XtrnlMdlFormIdCd")]
    public required ExternalModelFormIdentificationCode ExternalModelFormIdentificationCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAYG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Narrative Type Code")]
    [IsoXmlTag("XtrnlNrrtvTpCd")]
    public required ExternalNarrativeTypeCode ExternalNarrativeTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqALm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Notification Cancellation Reason Code")]
    [IsoXmlTag("XtrnlNtfctnCxlRsnCd")]
    public required ExternalNotificationCancellationReasonCode ExternalNotificationCancellationReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqADm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Organisation Identification Code")]
    [IsoXmlTag("XtrnlOrgIdCd")]
    public required ExternalOrganisationIdentificationCode ExternalOrganisationIdentificationCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_82_HEe2g-IPZC9d7tA")]
    [DisplayName("External Packaging Type Code")]
    [IsoXmlTag("XtrnlPackgngTpCd")]
    public required ExternalPackagingTypeCode ExternalPackagingTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAaW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Cancellation Rejection Code")]
    [IsoXmlTag("XtrnlPmtCxlRjctnCd")]
    public required ExternalPaymentCancellationRejectionCode ExternalPaymentCancellationRejectionCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyNW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Compensation Reason Code")]
    [IsoXmlTag("XtrnlPmtCompstnRsnCd")]
    public required ExternalPaymentCompensationReasonCode ExternalPaymentCompensationReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqARm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Control Request Type Code")]
    [IsoXmlTag("XtrnlPmtCtrlReqTpCd")]
    public required ExternalPaymentControlRequestTypeCode ExternalPaymentControlRequestTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnCW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Group Status Code")]
    [IsoXmlTag("XtrnlPmtGrpStsCd")]
    public required ExternalPaymentGroupStatusCode ExternalPaymentGroupStatusCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnJG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Modification Rejection Code")]
    [IsoXmlTag("XtrnlPmtModRjctnCd")]
    public required ExternalPaymentModificationRejectionCode ExternalPaymentModificationRejectionCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAT2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Role Code")]
    [IsoXmlTag("XtrnlPmtRoleCd")]
    public required ExternalPaymentRoleCode ExternalPaymentRoleCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY8G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Status Reason Code")]
    [IsoXmlTag("XtrnlPmtStsRsnCd")]
    public required ExternalPaymentStatusReasonCode ExternalPaymentStatusReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAb2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Transaction Status Code")]
    [IsoXmlTag("XtrnlPmtTxStsCd")]
    public required ExternalPaymentTransactionStatusCode ExternalPaymentTransactionStatusCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyKG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Pending Processing Reason Code")]
    [IsoXmlTag("XtrnlPdgPrcgRsnCd")]
    public required ExternalPendingProcessingReasonCode ExternalPendingProcessingReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_9G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Person Identification Code")]
    [IsoXmlTag("XtrnlPrsnIdCd")]
    public required ExternalPersonIdentificationCode ExternalPersonIdentificationCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_-m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Proxy Account Type Code")]
    [IsoXmlTag("XtrnlPrxyAcctTpCd")]
    public required ExternalProxyAccountTypeCode ExternalProxyAccountTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_-2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Purpose And Market Area Code")]
    [IsoXmlTag("XtrnlPurpAndMktAreaCd")]
    public required ExternalPurposeAndMarketAreaCode ExternalPurposeAndMarketAreaCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnKW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Purpose Code")]
    [IsoXmlTag("XtrnlPurpCd")]
    public required ExternalPurposeCode ExternalPurposeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAVm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Rates And Tenors Code")]
    [IsoXmlTag("XtrnlRatesAndTnrsCd")]
    public required ExternalRatesAndTenorsCode ExternalRatesAndTenorsCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAZ2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Received Reason Code")]
    [IsoXmlTag("XtrnlRcvdRsnCd")]
    public required ExternalReceivedReasonCode ExternalReceivedReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAV2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Rejected Reason Code")]
    [IsoXmlTag("XtrnlRjctdRsnCd")]
    public required ExternalRejectedReasonCode ExternalRejectedReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAOG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Relative To Code")]
    [IsoXmlTag("XtrnlRltvToCd")]
    public required ExternalRelativeToCode ExternalRelativeToCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAB2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Reporting Source Code")]
    [IsoXmlTag("XtrnlRptgSrcCd")]
    public required ExternalReportingSourceCode ExternalReportingSourceCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAR2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Re Presentment Reason Code")]
    [IsoXmlTag("XtrnlRePresntmntRsnCd")]
    public required ExternalRePresentmentReasonCode ExternalRePresentmentReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnD2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Reservation Type Code")]
    [IsoXmlTag("XtrnlRsvatnTpCd")]
    public required ExternalReservationTypeCode ExternalReservationTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyJ2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Return Reason Code")]
    [IsoXmlTag("XtrnlRtrRsnCd")]
    public required ExternalReturnReasonCode ExternalReturnReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY5G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Reversal Reason Code")]
    [IsoXmlTag("XtrnlRvslRsnCd")]
    public required ExternalReversalReasonCode ExternalReversalReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOF2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Securities Lending Type Code")]
    [IsoXmlTag("XtrnlSctiesLndgTpCd")]
    public required ExternalSecuritiesLendingTypeCode ExternalSecuritiesLendingTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY6W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Securities Purpose 1 Code")]
    [IsoXmlTag("XtrnlSctiesPurp1Cd")]
    public required ExternalSecuritiesPurpose1Code ExternalSecuritiesPurpose1Code { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAYW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Securities Update Reason Code")]
    [IsoXmlTag("XtrnlSctiesUpdRsnCd")]
    public required ExternalSecuritiesUpdateReasonCode ExternalSecuritiesUpdateReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_-G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Service Level Code")]
    [IsoXmlTag("XtrnlSvcLvlCd")]
    public required ExternalServiceLevelCode ExternalServiceLevelCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyK2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Shipment Condition Code")]
    [IsoXmlTag("XtrnlShipmntCondCd")]
    public required ExternalShipmentConditionCode ExternalShipmentConditionCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyLW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Status Reason Code")]
    [IsoXmlTag("XtrnlStsRsnCd")]
    public required ExternalStatusReasonCode ExternalStatusReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAJW_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Balance Type Code")]
    [IsoXmlTag("XtrnlSysBalTpCd")]
    public required ExternalSystemBalanceTypeCode ExternalSystemBalanceTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyUW_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Error Handling Code")]
    [IsoXmlTag("XtrnlSysErrHdlgCd")]
    public required ExternalSystemErrorHandlingCode ExternalSystemErrorHandlingCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqACW_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Event Type Code")]
    [IsoXmlTag("XtrnlSysEvtTpCd")]
    public required ExternalSystemEventTypeCode ExternalSystemEventTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqANG_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Member Type Code")]
    [IsoXmlTag("XtrnlSysMmbTpCd")]
    public required ExternalSystemMemberTypeCode ExternalSystemMemberTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY4m_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Party Type Code")]
    [IsoXmlTag("XtrnlSysPtyTpCd")]
    public required ExternalSystemPartyTypeCode ExternalSystemPartyTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyU2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Tax Amount Type Code")]
    [IsoXmlTag("XtrnlTaxAmtTpCd")]
    public required ExternalTaxAmountTypeCode ExternalTaxAmountTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnLm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Technical Input Channel Code")]
    [IsoXmlTag("XtrnlTechInptChanlCd")]
    public required ExternalTechnicalInputChannelCode ExternalTechnicalInputChannelCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAHm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Trade Market Code")]
    [IsoXmlTag("XtrnlTradMktCd")]
    public required ExternalTradeMarketCode ExternalTradeMarketCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnHG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Trade Transaction Condition Code")]
    [IsoXmlTag("XtrnlTradTxCondCd")]
    public required ExternalTradeTransactionConditionCode ExternalTradeTransactionConditionCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAC2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Type Of Party Code")]
    [IsoXmlTag("XtrnlTpOfPtyCd")]
    public required ExternalTypeOfPartyCode ExternalTypeOfPartyCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAEW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Unable To Apply Incorrect Data Code")]
    [IsoXmlTag("XtrnlUblToApplyIncrrctDataCd")]
    public required ExternalUnableToApplyIncorrectDataCode ExternalUnableToApplyIncorrectDataCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqANW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Unable To Apply Missing Data Code")]
    [IsoXmlTag("XtrnlUblToApplyMssngDataCd")]
    public required ExternalUnableToApplyMissingDataCode ExternalUnableToApplyMissingDataCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyS2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Underlying Trade Transaction Type Code")]
    [IsoXmlTag("XtrnlUndrlygTradTxTpCd")]
    public required ExternalUnderlyingTradeTransactionTypeCode ExternalUnderlyingTradeTransactionTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAFW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Amount Type Code")]
    [IsoXmlTag("XtrnlUdrtkgAmtTpCd")]
    public required ExternalUndertakingAmountTypeCode ExternalUndertakingAmountTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOFm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Document Type Code")]
    [IsoXmlTag("XtrnlUdrtkgDocTpCd")]
    public required ExternalUndertakingDocumentTypeCode ExternalUndertakingDocumentTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAKG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Status Category Code")]
    [IsoXmlTag("XtrnlUdrtkgStsCtgyCd")]
    public required ExternalUndertakingStatusCategoryCode ExternalUndertakingStatusCategoryCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAUW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Type Code")]
    [IsoXmlTag("XtrnlUdrtkgTpCd")]
    public required ExternalUndertakingTypeCode ExternalUndertakingTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY7G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Validation Rule Identification Code")]
    [IsoXmlTag("XtrnlVldtnRuleIdCd")]
    public required ExternalValidationRuleIdentificationCode ExternalValidationRuleIdentificationCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOFW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Verification Reason Code")]
    [IsoXmlTag("XtrnlVrfctnRsnCd")]
    public required ExternalVerificationReasonCode ExternalVerificationReasonCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_xi3wc3C-Ee2QDe42vpiOiA")]
    [DisplayName("External Benchmark Curve Name Code")]
    [IsoXmlTag("XtrnlBchmkCrvNmCd")]
    public required ExternalBenchmarkCurveNameCode ExternalBenchmarkCurveNameCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_xi3wdHC-Ee2QDe42vpiOiA")]
    [DisplayName("External Party Relationship Type Code")]
    [IsoXmlTag("XtrnlPtyRltshTpCd")]
    public required ExternalPartyRelationshipTypeCode ExternalPartyRelationshipTypeCode { get; init; } 
    
    /// <summary>
    /// </summary>
    [IsoId("_xi3wdXC-Ee2QDe42vpiOiA")]
    [DisplayName("External Unit Of Measure Code")]
    [IsoXmlTag("XtrnlUnitOfMeasrCd")]
    public required ExternalUnitOfMeasureCode ExternalUnitOfMeasureCode { get; init; } 
    
    
    #nullable disable
    
}
