// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// </summary>
[IsoId("_3toyJW_HEe2g-IPZC9d7tA")]
[DisplayName("All External Master Registered Code Sets")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AllExternalMasterRegisteredCodeSets1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AllExternalMasterRegisteredCodeSets1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AllExternalMasterRegisteredCodeSets1( ExternalAcceptedReasonCode reqExternalAcceptedReasonCode,ExternalAccountIdentificationCode reqExternalAccountIdentificationCode,ExternalAgentInstructionCode reqExternalAgentInstructionCode,ExternalAgreementTypeCode reqExternalAgreementTypeCode,ExternalAuthenticationChannelCode reqExternalAuthenticationChannelCode,string reqExternalAuthenticationMethodCode,ExternalAuthorityExchangeReasonCode reqExternalAuthorityExchangeReasonCode,ExternalAuthorityIdentificationCode reqExternalAuthorityIdentificationCode,ExternalBalanceSubTypeCode reqExternalBalanceSubTypeCode,ExternalBalanceTypeCode reqExternalBalanceTypeCode,string reqExternalBankTransactionDomainCode,string reqExternalBankTransactionFamilyCode,string reqExternalBankTransactionSubFamilyCode,ExternalBillingBalanceTypeCode reqExternalBillingBalanceTypeCode,ExternalBillingCompensationTypeCode reqExternalBillingCompensationTypeCode,ExternalBillingRateIdentificationCode reqExternalBillingRateIdentificationCode,ExternalCancellationReasonCode reqExternalCancellationReasonCode,string reqExternalCardTransactionCategoryCode,ExternalCashAccountTypeCode reqExternalCashAccountTypeCode,ExternalCashClearingSystemCode reqExternalCashClearingSystemCode,ExternalCategoryPurposeCode reqExternalCategoryPurposeCode,ExternalChannelCode reqExternalChannelCode,ExternalChargeTypeCode reqExternalChargeTypeCode,string reqExternalChequeAgentInstructionCode,string reqExternalChequeCancellationReasonCode,string reqExternalChequeCancellationStatusCode,ExternalClaimNonReceiptRejectionCode reqExternalClaimNonReceiptRejectionCode,ExternalClearingSystemIdentificationCode reqExternalClearingSystemIdentificationCode,string reqExternalClearingSystemMemberCode,string reqExternalCommunicationFormatCode,ExternalContractBalanceTypeCode reqExternalContractBalanceTypeCode,ExternalContractClosureReasonCode reqExternalContractClosureReasonCode,string reqExternalCreditLineTypeCode,ExternalCreditorAgentInstructionCode reqExternalCreditorAgentInstructionCode,ExternalCreditorEnrolmentAmendmentReasonCode reqExternalCreditorEnrolmentAmendmentReasonCode,ExternalCreditorEnrolmentCancellationReasonCode reqExternalCreditorEnrolmentCancellationReasonCode,ExternalCreditorEnrolmentStatusReasonCode reqExternalCreditorEnrolmentStatusReasonCode,ExternalDateFrequencyCode reqExternalDateFrequencyCode,ExternalDebtorActivationAmendmentReasonCode reqExternalDebtorActivationAmendmentReasonCode,ExternalDebtorActivationCancellationReasonCode reqExternalDebtorActivationCancellationReasonCode,ExternalDebtorActivationStatusReasonCode reqExternalDebtorActivationStatusReasonCode,ExternalDebtorAgentInstructionCode reqExternalDebtorAgentInstructionCode,ExternalDiscountAmountTypeCode reqExternalDiscountAmountTypeCode,string reqExternalDiscrepancyCode,ExternalDocumentFormatCode reqExternalDocumentFormatCode,ExternalDocumentLineTypeCode reqExternalDocumentLineTypeCode,ExternalDocumentPurposeCode reqExternalDocumentPurposeCode,ExternalDocumentTypeCode reqExternalDocumentTypeCode,ExternalEffectiveDateParameterCode reqExternalEffectiveDateParameterCode,ExternalEncryptedElementIdentificationCode reqExternalEncryptedElementIdentificationCode,ExternalEnquiryRequestTypeCode reqExternalEnquiryRequestTypeCode,ExternalEntryStatusCode reqExternalEntryStatusCode,string reqExternalFinancialInstitutionIdentificationCode,ExternalFinancialInstrumentIdentificationTypeCode reqExternalFinancialInstrumentIdentificationTypeCode,string reqExternalFinancialInstrumentProductTypeCode,ExternalGarnishmentTypeCode reqExternalGarnishmentTypeCode,ExternalIncotermsCode reqExternalIncotermsCode,ExternalInformationTypeCode reqExternalInformationTypeCode,string reqExternalInstructedAgentInstructionCode,string reqExternalInvalidEventReasonCode,string reqExternalInvalidPaymentsEventCode,ExternalInvestigationExecutionConfirmationCode reqExternalInvestigationExecutionConfirmationCode,ExternalLetterTypeCode reqExternalLetterTypeCode,ExternalLocalInstrumentCode reqExternalLocalInstrumentCode,ExternalMandateReasonCode reqExternalMandateReasonCode,string reqExternalMandateSetupReasonCode,ExternalMandateStatusCode reqExternalMandateStatusCode,ExternalMandateSuspensionReasonCode reqExternalMandateSuspensionReasonCode,ExternalMarketInfrastructureCode reqExternalMarketInfrastructureCode,ExternalModelFormIdentificationCode reqExternalModelFormIdentificationCode,ExternalNarrativeTypeCode reqExternalNarrativeTypeCode,string reqExternalNotificationCancellationReasonCode,ExternalOrganisationIdentificationCode reqExternalOrganisationIdentificationCode,ExternalPackagingTypeCode reqExternalPackagingTypeCode,ExternalPaymentCancellationRejectionCode reqExternalPaymentCancellationRejectionCode,ExternalPaymentCompensationReasonCode reqExternalPaymentCompensationReasonCode,ExternalPaymentControlRequestTypeCode reqExternalPaymentControlRequestTypeCode,ExternalPaymentGroupStatusCode reqExternalPaymentGroupStatusCode,ExternalPaymentModificationRejectionCode reqExternalPaymentModificationRejectionCode,ExternalPaymentRoleCode reqExternalPaymentRoleCode,ExternalPaymentStatusReasonCode reqExternalPaymentStatusReasonCode,ExternalPaymentTransactionStatusCode reqExternalPaymentTransactionStatusCode,ExternalPendingProcessingReasonCode reqExternalPendingProcessingReasonCode,ExternalPersonIdentificationCode reqExternalPersonIdentificationCode,ExternalProxyAccountTypeCode reqExternalProxyAccountTypeCode,ExternalPurposeAndMarketAreaCode reqExternalPurposeAndMarketAreaCode,ExternalPurposeCode reqExternalPurposeCode,ExternalRatesAndTenorsCode reqExternalRatesAndTenorsCode,ExternalReceivedReasonCode reqExternalReceivedReasonCode,ExternalRejectedReasonCode reqExternalRejectedReasonCode,ExternalRelativeToCode reqExternalRelativeToCode,ExternalReportingSourceCode reqExternalReportingSourceCode,ExternalRePresentmentReasonCode reqExternalRePresentmentReasonCode,ExternalReservationTypeCode reqExternalReservationTypeCode,ExternalReturnReasonCode reqExternalReturnReasonCode,ExternalReversalReasonCode reqExternalReversalReasonCode,string reqExternalSecuritiesLendingTypeCode,ExternalSecuritiesPurpose1Code reqExternalSecuritiesPurpose1Code,string reqExternalSecuritiesUpdateReasonCode,ExternalServiceLevelCode reqExternalServiceLevelCode,ExternalShipmentConditionCode reqExternalShipmentConditionCode,ExternalStatusReasonCode reqExternalStatusReasonCode,ExternalSystemBalanceTypeCode reqExternalSystemBalanceTypeCode,ExternalSystemErrorHandlingCode reqExternalSystemErrorHandlingCode,ExternalSystemEventTypeCode reqExternalSystemEventTypeCode,ExternalSystemMemberTypeCode reqExternalSystemMemberTypeCode,string reqExternalSystemPartyTypeCode,ExternalTaxAmountTypeCode reqExternalTaxAmountTypeCode,ExternalTechnicalInputChannelCode reqExternalTechnicalInputChannelCode,ExternalTradeMarketCode reqExternalTradeMarketCode,ExternalTradeTransactionConditionCode reqExternalTradeTransactionConditionCode,ExternalTypeOfPartyCode reqExternalTypeOfPartyCode,ExternalUnableToApplyIncorrectDataCode reqExternalUnableToApplyIncorrectDataCode,ExternalUnableToApplyMissingDataCode reqExternalUnableToApplyMissingDataCode,ExternalUnderlyingTradeTransactionTypeCode reqExternalUnderlyingTradeTransactionTypeCode,ExternalUndertakingAmountTypeCode reqExternalUndertakingAmountTypeCode,ExternalUndertakingDocumentTypeCode reqExternalUndertakingDocumentTypeCode,ExternalUndertakingStatusCategoryCode reqExternalUndertakingStatusCategoryCode,ExternalUndertakingTypeCode reqExternalUndertakingTypeCode,ExternalValidationRuleIdentificationCode reqExternalValidationRuleIdentificationCode,ExternalVerificationReasonCode reqExternalVerificationReasonCode,ExternalBenchmarkCurveNameCode reqExternalBenchmarkCurveNameCode,string reqExternalPartyRelationshipTypeCode,ExternalUnitOfMeasureCode reqExternalUnitOfMeasureCode )
    {
        ExternalAcceptedReasonCode = reqExternalAcceptedReasonCode;
        ExternalAccountIdentificationCode = reqExternalAccountIdentificationCode;
        ExternalAgentInstructionCode = reqExternalAgentInstructionCode;
        ExternalAgreementTypeCode = reqExternalAgreementTypeCode;
        ExternalAuthenticationChannelCode = reqExternalAuthenticationChannelCode;
        ExternalAuthenticationMethodCode = reqExternalAuthenticationMethodCode;
        ExternalAuthorityExchangeReasonCode = reqExternalAuthorityExchangeReasonCode;
        ExternalAuthorityIdentificationCode = reqExternalAuthorityIdentificationCode;
        ExternalBalanceSubTypeCode = reqExternalBalanceSubTypeCode;
        ExternalBalanceTypeCode = reqExternalBalanceTypeCode;
        ExternalBankTransactionDomainCode = reqExternalBankTransactionDomainCode;
        ExternalBankTransactionFamilyCode = reqExternalBankTransactionFamilyCode;
        ExternalBankTransactionSubFamilyCode = reqExternalBankTransactionSubFamilyCode;
        ExternalBillingBalanceTypeCode = reqExternalBillingBalanceTypeCode;
        ExternalBillingCompensationTypeCode = reqExternalBillingCompensationTypeCode;
        ExternalBillingRateIdentificationCode = reqExternalBillingRateIdentificationCode;
        ExternalCancellationReasonCode = reqExternalCancellationReasonCode;
        ExternalCardTransactionCategoryCode = reqExternalCardTransactionCategoryCode;
        ExternalCashAccountTypeCode = reqExternalCashAccountTypeCode;
        ExternalCashClearingSystemCode = reqExternalCashClearingSystemCode;
        ExternalCategoryPurposeCode = reqExternalCategoryPurposeCode;
        ExternalChannelCode = reqExternalChannelCode;
        ExternalChargeTypeCode = reqExternalChargeTypeCode;
        ExternalChequeAgentInstructionCode = reqExternalChequeAgentInstructionCode;
        ExternalChequeCancellationReasonCode = reqExternalChequeCancellationReasonCode;
        ExternalChequeCancellationStatusCode = reqExternalChequeCancellationStatusCode;
        ExternalClaimNonReceiptRejectionCode = reqExternalClaimNonReceiptRejectionCode;
        ExternalClearingSystemIdentificationCode = reqExternalClearingSystemIdentificationCode;
        ExternalClearingSystemMemberCode = reqExternalClearingSystemMemberCode;
        ExternalCommunicationFormatCode = reqExternalCommunicationFormatCode;
        ExternalContractBalanceTypeCode = reqExternalContractBalanceTypeCode;
        ExternalContractClosureReasonCode = reqExternalContractClosureReasonCode;
        ExternalCreditLineTypeCode = reqExternalCreditLineTypeCode;
        ExternalCreditorAgentInstructionCode = reqExternalCreditorAgentInstructionCode;
        ExternalCreditorEnrolmentAmendmentReasonCode = reqExternalCreditorEnrolmentAmendmentReasonCode;
        ExternalCreditorEnrolmentCancellationReasonCode = reqExternalCreditorEnrolmentCancellationReasonCode;
        ExternalCreditorEnrolmentStatusReasonCode = reqExternalCreditorEnrolmentStatusReasonCode;
        ExternalDateFrequencyCode = reqExternalDateFrequencyCode;
        ExternalDebtorActivationAmendmentReasonCode = reqExternalDebtorActivationAmendmentReasonCode;
        ExternalDebtorActivationCancellationReasonCode = reqExternalDebtorActivationCancellationReasonCode;
        ExternalDebtorActivationStatusReasonCode = reqExternalDebtorActivationStatusReasonCode;
        ExternalDebtorAgentInstructionCode = reqExternalDebtorAgentInstructionCode;
        ExternalDiscountAmountTypeCode = reqExternalDiscountAmountTypeCode;
        ExternalDiscrepancyCode = reqExternalDiscrepancyCode;
        ExternalDocumentFormatCode = reqExternalDocumentFormatCode;
        ExternalDocumentLineTypeCode = reqExternalDocumentLineTypeCode;
        ExternalDocumentPurposeCode = reqExternalDocumentPurposeCode;
        ExternalDocumentTypeCode = reqExternalDocumentTypeCode;
        ExternalEffectiveDateParameterCode = reqExternalEffectiveDateParameterCode;
        ExternalEncryptedElementIdentificationCode = reqExternalEncryptedElementIdentificationCode;
        ExternalEnquiryRequestTypeCode = reqExternalEnquiryRequestTypeCode;
        ExternalEntryStatusCode = reqExternalEntryStatusCode;
        ExternalFinancialInstitutionIdentificationCode = reqExternalFinancialInstitutionIdentificationCode;
        ExternalFinancialInstrumentIdentificationTypeCode = reqExternalFinancialInstrumentIdentificationTypeCode;
        ExternalFinancialInstrumentProductTypeCode = reqExternalFinancialInstrumentProductTypeCode;
        ExternalGarnishmentTypeCode = reqExternalGarnishmentTypeCode;
        ExternalIncotermsCode = reqExternalIncotermsCode;
        ExternalInformationTypeCode = reqExternalInformationTypeCode;
        ExternalInstructedAgentInstructionCode = reqExternalInstructedAgentInstructionCode;
        ExternalInvalidEventReasonCode = reqExternalInvalidEventReasonCode;
        ExternalInvalidPaymentsEventCode = reqExternalInvalidPaymentsEventCode;
        ExternalInvestigationExecutionConfirmationCode = reqExternalInvestigationExecutionConfirmationCode;
        ExternalLetterTypeCode = reqExternalLetterTypeCode;
        ExternalLocalInstrumentCode = reqExternalLocalInstrumentCode;
        ExternalMandateReasonCode = reqExternalMandateReasonCode;
        ExternalMandateSetupReasonCode = reqExternalMandateSetupReasonCode;
        ExternalMandateStatusCode = reqExternalMandateStatusCode;
        ExternalMandateSuspensionReasonCode = reqExternalMandateSuspensionReasonCode;
        ExternalMarketInfrastructureCode = reqExternalMarketInfrastructureCode;
        ExternalModelFormIdentificationCode = reqExternalModelFormIdentificationCode;
        ExternalNarrativeTypeCode = reqExternalNarrativeTypeCode;
        ExternalNotificationCancellationReasonCode = reqExternalNotificationCancellationReasonCode;
        ExternalOrganisationIdentificationCode = reqExternalOrganisationIdentificationCode;
        ExternalPackagingTypeCode = reqExternalPackagingTypeCode;
        ExternalPaymentCancellationRejectionCode = reqExternalPaymentCancellationRejectionCode;
        ExternalPaymentCompensationReasonCode = reqExternalPaymentCompensationReasonCode;
        ExternalPaymentControlRequestTypeCode = reqExternalPaymentControlRequestTypeCode;
        ExternalPaymentGroupStatusCode = reqExternalPaymentGroupStatusCode;
        ExternalPaymentModificationRejectionCode = reqExternalPaymentModificationRejectionCode;
        ExternalPaymentRoleCode = reqExternalPaymentRoleCode;
        ExternalPaymentStatusReasonCode = reqExternalPaymentStatusReasonCode;
        ExternalPaymentTransactionStatusCode = reqExternalPaymentTransactionStatusCode;
        ExternalPendingProcessingReasonCode = reqExternalPendingProcessingReasonCode;
        ExternalPersonIdentificationCode = reqExternalPersonIdentificationCode;
        ExternalProxyAccountTypeCode = reqExternalProxyAccountTypeCode;
        ExternalPurposeAndMarketAreaCode = reqExternalPurposeAndMarketAreaCode;
        ExternalPurposeCode = reqExternalPurposeCode;
        ExternalRatesAndTenorsCode = reqExternalRatesAndTenorsCode;
        ExternalReceivedReasonCode = reqExternalReceivedReasonCode;
        ExternalRejectedReasonCode = reqExternalRejectedReasonCode;
        ExternalRelativeToCode = reqExternalRelativeToCode;
        ExternalReportingSourceCode = reqExternalReportingSourceCode;
        ExternalRePresentmentReasonCode = reqExternalRePresentmentReasonCode;
        ExternalReservationTypeCode = reqExternalReservationTypeCode;
        ExternalReturnReasonCode = reqExternalReturnReasonCode;
        ExternalReversalReasonCode = reqExternalReversalReasonCode;
        ExternalSecuritiesLendingTypeCode = reqExternalSecuritiesLendingTypeCode;
        ExternalSecuritiesPurpose1Code = reqExternalSecuritiesPurpose1Code;
        ExternalSecuritiesUpdateReasonCode = reqExternalSecuritiesUpdateReasonCode;
        ExternalServiceLevelCode = reqExternalServiceLevelCode;
        ExternalShipmentConditionCode = reqExternalShipmentConditionCode;
        ExternalStatusReasonCode = reqExternalStatusReasonCode;
        ExternalSystemBalanceTypeCode = reqExternalSystemBalanceTypeCode;
        ExternalSystemErrorHandlingCode = reqExternalSystemErrorHandlingCode;
        ExternalSystemEventTypeCode = reqExternalSystemEventTypeCode;
        ExternalSystemMemberTypeCode = reqExternalSystemMemberTypeCode;
        ExternalSystemPartyTypeCode = reqExternalSystemPartyTypeCode;
        ExternalTaxAmountTypeCode = reqExternalTaxAmountTypeCode;
        ExternalTechnicalInputChannelCode = reqExternalTechnicalInputChannelCode;
        ExternalTradeMarketCode = reqExternalTradeMarketCode;
        ExternalTradeTransactionConditionCode = reqExternalTradeTransactionConditionCode;
        ExternalTypeOfPartyCode = reqExternalTypeOfPartyCode;
        ExternalUnableToApplyIncorrectDataCode = reqExternalUnableToApplyIncorrectDataCode;
        ExternalUnableToApplyMissingDataCode = reqExternalUnableToApplyMissingDataCode;
        ExternalUnderlyingTradeTransactionTypeCode = reqExternalUnderlyingTradeTransactionTypeCode;
        ExternalUndertakingAmountTypeCode = reqExternalUndertakingAmountTypeCode;
        ExternalUndertakingDocumentTypeCode = reqExternalUndertakingDocumentTypeCode;
        ExternalUndertakingStatusCategoryCode = reqExternalUndertakingStatusCategoryCode;
        ExternalUndertakingTypeCode = reqExternalUndertakingTypeCode;
        ExternalValidationRuleIdentificationCode = reqExternalValidationRuleIdentificationCode;
        ExternalVerificationReasonCode = reqExternalVerificationReasonCode;
        ExternalBenchmarkCurveNameCode = reqExternalBenchmarkCurveNameCode;
        ExternalPartyRelationshipTypeCode = reqExternalPartyRelationshipTypeCode;
        ExternalUnitOfMeasureCode = reqExternalUnitOfMeasureCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyLG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Accepted Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAccptdRsnCd")]
    #endif
    [IsoXmlTag("XtrnlAccptdRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAcceptedReasonCode ExternalAcceptedReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalAcceptedReasonCode ExternalAcceptedReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAcceptedReasonCode ExternalAcceptedReasonCode { get; init; } 
    #else
    public ExternalAcceptedReasonCode ExternalAcceptedReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnA2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Account Identification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAcctIdCd")]
    #endif
    [IsoXmlTag("XtrnlAcctIdCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAccountIdentificationCode ExternalAccountIdentificationCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalAccountIdentificationCode ExternalAccountIdentificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAccountIdentificationCode ExternalAccountIdentificationCode { get; init; } 
    #else
    public ExternalAccountIdentificationCode ExternalAccountIdentificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_9W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Agent Instruction Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAgtInstrCd")]
    #endif
    [IsoXmlTag("XtrnlAgtInstrCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAgentInstructionCode ExternalAgentInstructionCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalAgentInstructionCode ExternalAgentInstructionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAgentInstructionCode ExternalAgentInstructionCode { get; init; } 
    #else
    public ExternalAgentInstructionCode ExternalAgentInstructionCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAa2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Agreement Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAgrmtTpCd")]
    #endif
    [IsoXmlTag("XtrnlAgrmtTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAgreementTypeCode ExternalAgreementTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalAgreementTypeCode ExternalAgreementTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAgreementTypeCode ExternalAgreementTypeCode { get; init; } 
    #else
    public ExternalAgreementTypeCode ExternalAgreementTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAXG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authentication Channel Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAuthntcnChanlCd")]
    #endif
    [IsoXmlTag("XtrnlAuthntcnChanlCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAuthenticationChannelCode ExternalAuthenticationChannelCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalAuthenticationChannelCode ExternalAuthenticationChannelCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAuthenticationChannelCode ExternalAuthenticationChannelCode { get; init; } 
    #else
    public ExternalAuthenticationChannelCode ExternalAuthenticationChannelCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyOG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authentication Method Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAuthntcnMtdCd")]
    #endif
    [IsoXmlTag("XtrnlAuthntcnMtdCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAuthenticationMethodCode ExternalAuthenticationMethodCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalAuthenticationMethodCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalAuthenticationMethodCode { get; init; } 
    #else
    public string ExternalAuthenticationMethodCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqATW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authority Exchange Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAuthrtyXchgRsnCd")]
    #endif
    [IsoXmlTag("XtrnlAuthrtyXchgRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAuthorityExchangeReasonCode ExternalAuthorityExchangeReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalAuthorityExchangeReasonCode ExternalAuthorityExchangeReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAuthorityExchangeReasonCode ExternalAuthorityExchangeReasonCode { get; init; } 
    #else
    public ExternalAuthorityExchangeReasonCode ExternalAuthorityExchangeReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAKm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authority Identification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAuthrtyIdCd")]
    #endif
    [IsoXmlTag("XtrnlAuthrtyIdCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAuthorityIdentificationCode ExternalAuthorityIdentificationCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalAuthorityIdentificationCode ExternalAuthorityIdentificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAuthorityIdentificationCode ExternalAuthorityIdentificationCode { get; init; } 
    #else
    public ExternalAuthorityIdentificationCode ExternalAuthorityIdentificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnG2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Balance Sub Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBalSubTpCd")]
    #endif
    [IsoXmlTag("XtrnlBalSubTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBalanceSubTypeCode ExternalBalanceSubTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalBalanceSubTypeCode ExternalBalanceSubTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalBalanceSubTypeCode ExternalBalanceSubTypeCode { get; init; } 
    #else
    public ExternalBalanceSubTypeCode ExternalBalanceSubTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAHG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Balance Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBalTpCd")]
    #endif
    [IsoXmlTag("XtrnlBalTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBalanceTypeCode ExternalBalanceTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalBalanceTypeCode ExternalBalanceTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalBalanceTypeCode ExternalBalanceTypeCode { get; init; } 
    #else
    public ExternalBalanceTypeCode ExternalBalanceTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAaG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Bank Transaction Domain Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBkTxDomnCd")]
    #endif
    [IsoXmlTag("XtrnlBkTxDomnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBankTransactionDomainCode ExternalBankTransactionDomainCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalBankTransactionDomainCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalBankTransactionDomainCode { get; init; } 
    #else
    public string ExternalBankTransactionDomainCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_8W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Bank Transaction Family Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBkTxFmlyCd")]
    #endif
    [IsoXmlTag("XtrnlBkTxFmlyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBankTransactionFamilyCode ExternalBankTransactionFamilyCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalBankTransactionFamilyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalBankTransactionFamilyCode { get; init; } 
    #else
    public string ExternalBankTransactionFamilyCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAIm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Bank Transaction Sub Family Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBkTxSubFmlyCd")]
    #endif
    [IsoXmlTag("XtrnlBkTxSubFmlyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBankTransactionSubFamilyCode ExternalBankTransactionSubFamilyCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalBankTransactionSubFamilyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalBankTransactionSubFamilyCode { get; init; } 
    #else
    public string ExternalBankTransactionSubFamilyCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY7m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Billing Balance Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBllgBalTpCd")]
    #endif
    [IsoXmlTag("XtrnlBllgBalTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBillingBalanceTypeCode ExternalBillingBalanceTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalBillingBalanceTypeCode ExternalBillingBalanceTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalBillingBalanceTypeCode ExternalBillingBalanceTypeCode { get; init; } 
    #else
    public ExternalBillingBalanceTypeCode ExternalBillingBalanceTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAJm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Billing Compensation Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBllgCompstnTpCd")]
    #endif
    [IsoXmlTag("XtrnlBllgCompstnTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBillingCompensationTypeCode ExternalBillingCompensationTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalBillingCompensationTypeCode ExternalBillingCompensationTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalBillingCompensationTypeCode ExternalBillingCompensationTypeCode { get; init; } 
    #else
    public ExternalBillingCompensationTypeCode ExternalBillingCompensationTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY72_HEe2g-IPZC9d7tA")]
    [DisplayName("External Billing Rate Identification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBllgRateIdCd")]
    #endif
    [IsoXmlTag("XtrnlBllgRateIdCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBillingRateIdentificationCode ExternalBillingRateIdentificationCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalBillingRateIdentificationCode ExternalBillingRateIdentificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalBillingRateIdentificationCode ExternalBillingRateIdentificationCode { get; init; } 
    #else
    public ExternalBillingRateIdentificationCode ExternalBillingRateIdentificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAD2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cancellation Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCxlRsnCd")]
    #endif
    [IsoXmlTag("XtrnlCxlRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCancellationReasonCode ExternalCancellationReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCancellationReasonCode ExternalCancellationReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCancellationReasonCode ExternalCancellationReasonCode { get; init; } 
    #else
    public ExternalCancellationReasonCode ExternalCancellationReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyMW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Card Transaction Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCardTxCtgyCd")]
    #endif
    [IsoXmlTag("XtrnlCardTxCtgyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCardTransactionCategoryCode ExternalCardTransactionCategoryCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalCardTransactionCategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalCardTransactionCategoryCode { get; init; } 
    #else
    public string ExternalCardTransactionCategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnEG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cash Account Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCshAcctTpCd")]
    #endif
    [IsoXmlTag("XtrnlCshAcctTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCashAccountTypeCode ExternalCashAccountTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCashAccountTypeCode ExternalCashAccountTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCashAccountTypeCode ExternalCashAccountTypeCode { get; init; } 
    #else
    public ExternalCashAccountTypeCode ExternalCashAccountTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnKG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cash Clearing System Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCshClrSysCd")]
    #endif
    [IsoXmlTag("XtrnlCshClrSysCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCashClearingSystemCode ExternalCashClearingSystemCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCashClearingSystemCode ExternalCashClearingSystemCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCashClearingSystemCode ExternalCashClearingSystemCode { get; init; } 
    #else
    public ExternalCashClearingSystemCode ExternalCashClearingSystemCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAGW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Category Purpose Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCtgyPurpCd")]
    #endif
    [IsoXmlTag("XtrnlCtgyPurpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCategoryPurposeCode ExternalCategoryPurposeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCategoryPurposeCode ExternalCategoryPurposeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCategoryPurposeCode ExternalCategoryPurposeCode { get; init; } 
    #else
    public ExternalCategoryPurposeCode ExternalCategoryPurposeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyVm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Channel Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlChanlCd")]
    #endif
    [IsoXmlTag("XtrnlChanlCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalChannelCode ExternalChannelCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalChannelCode ExternalChannelCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalChannelCode ExternalChannelCode { get; init; } 
    #else
    public ExternalChannelCode ExternalChannelCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyOW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Charge Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlChrgTpCd")]
    #endif
    [IsoXmlTag("XtrnlChrgTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalChargeTypeCode ExternalChargeTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalChargeTypeCode ExternalChargeTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalChargeTypeCode ExternalChargeTypeCode { get; init; } 
    #else
    public ExternalChargeTypeCode ExternalChargeTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAN2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cheque Agent Instruction Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlChqAgtInstrCd")]
    #endif
    [IsoXmlTag("XtrnlChqAgtInstrCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalChequeAgentInstructionCode ExternalChequeAgentInstructionCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalChequeAgentInstructionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalChequeAgentInstructionCode { get; init; } 
    #else
    public string ExternalChequeAgentInstructionCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqASm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cheque Cancellation Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlChqCxlRsnCd")]
    #endif
    [IsoXmlTag("XtrnlChqCxlRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalChequeCancellationReasonCode ExternalChequeCancellationReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalChequeCancellationReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalChequeCancellationReasonCode { get; init; } 
    #else
    public string ExternalChequeCancellationReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyNm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cheque Cancellation Status Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlChqCxlStsCd")]
    #endif
    [IsoXmlTag("XtrnlChqCxlStsCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalChequeCancellationStatusCode ExternalChequeCancellationStatusCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalChequeCancellationStatusCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalChequeCancellationStatusCode { get; init; } 
    #else
    public string ExternalChequeCancellationStatusCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnDm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Claim Non Receipt Rejection Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlClmNonRctRjctnCd")]
    #endif
    [IsoXmlTag("XtrnlClmNonRctRjctnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalClaimNonReceiptRejectionCode ExternalClaimNonReceiptRejectionCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalClaimNonReceiptRejectionCode ExternalClaimNonReceiptRejectionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalClaimNonReceiptRejectionCode ExternalClaimNonReceiptRejectionCode { get; init; } 
    #else
    public ExternalClaimNonReceiptRejectionCode ExternalClaimNonReceiptRejectionCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAAm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Clearing System Identification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlClrSysIdCd")]
    #endif
    [IsoXmlTag("XtrnlClrSysIdCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalClearingSystemIdentificationCode ExternalClearingSystemIdentificationCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalClearingSystemIdentificationCode ExternalClearingSystemIdentificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalClearingSystemIdentificationCode ExternalClearingSystemIdentificationCode { get; init; } 
    #else
    public ExternalClearingSystemIdentificationCode ExternalClearingSystemIdentificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAI2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Clearing System Member Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlClrSysMmbCd")]
    #endif
    [IsoXmlTag("XtrnlClrSysMmbCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalClearingSystemMemberCode ExternalClearingSystemMemberCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalClearingSystemMemberCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalClearingSystemMemberCode { get; init; } 
    #else
    public string ExternalClearingSystemMemberCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAH2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Communication Format Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlComFrmtCd")]
    #endif
    [IsoXmlTag("XtrnlComFrmtCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCommunicationFormatCode ExternalCommunicationFormatCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalCommunicationFormatCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalCommunicationFormatCode { get; init; } 
    #else
    public string ExternalCommunicationFormatCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAYm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Contract Balance Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCtrctBalTpCd")]
    #endif
    [IsoXmlTag("XtrnlCtrctBalTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalContractBalanceTypeCode ExternalContractBalanceTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalContractBalanceTypeCode ExternalContractBalanceTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalContractBalanceTypeCode ExternalContractBalanceTypeCode { get; init; } 
    #else
    public ExternalContractBalanceTypeCode ExternalContractBalanceTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAA2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Contract Closure Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCtrctClsrRsnCd")]
    #endif
    [IsoXmlTag("XtrnlCtrctClsrRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalContractClosureReasonCode ExternalContractClosureReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalContractClosureReasonCode ExternalContractClosureReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalContractClosureReasonCode ExternalContractClosureReasonCode { get; init; } 
    #else
    public ExternalContractClosureReasonCode ExternalContractClosureReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_9m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Credit Line Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCdtLineTpCd")]
    #endif
    [IsoXmlTag("XtrnlCdtLineTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCreditLineTypeCode ExternalCreditLineTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalCreditLineTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalCreditLineTypeCode { get; init; } 
    #else
    public string ExternalCreditLineTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOHm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Agent Instruction Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCdtrAgtInstrCd")]
    #endif
    [IsoXmlTag("XtrnlCdtrAgtInstrCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCreditorAgentInstructionCode ExternalCreditorAgentInstructionCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCreditorAgentInstructionCode ExternalCreditorAgentInstructionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCreditorAgentInstructionCode ExternalCreditorAgentInstructionCode { get; init; } 
    #else
    public ExternalCreditorAgentInstructionCode ExternalCreditorAgentInstructionCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqARG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Enrolment Amendment Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCdtrEnrlmntAmdmntRsnCd")]
    #endif
    [IsoXmlTag("XtrnlCdtrEnrlmntAmdmntRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCreditorEnrolmentAmendmentReasonCode ExternalCreditorEnrolmentAmendmentReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCreditorEnrolmentAmendmentReasonCode ExternalCreditorEnrolmentAmendmentReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCreditorEnrolmentAmendmentReasonCode ExternalCreditorEnrolmentAmendmentReasonCode { get; init; } 
    #else
    public ExternalCreditorEnrolmentAmendmentReasonCode ExternalCreditorEnrolmentAmendmentReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqATm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Enrolment Cancellation Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCdtrEnrlmntCxlRsnCd")]
    #endif
    [IsoXmlTag("XtrnlCdtrEnrlmntCxlRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCreditorEnrolmentCancellationReasonCode ExternalCreditorEnrolmentCancellationReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCreditorEnrolmentCancellationReasonCode ExternalCreditorEnrolmentCancellationReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCreditorEnrolmentCancellationReasonCode ExternalCreditorEnrolmentCancellationReasonCode { get; init; } 
    #else
    public ExternalCreditorEnrolmentCancellationReasonCode ExternalCreditorEnrolmentCancellationReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyVG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Enrolment Status Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCdtrEnrlmntStsRsnCd")]
    #endif
    [IsoXmlTag("XtrnlCdtrEnrlmntStsRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCreditorEnrolmentStatusReasonCode ExternalCreditorEnrolmentStatusReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCreditorEnrolmentStatusReasonCode ExternalCreditorEnrolmentStatusReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCreditorEnrolmentStatusReasonCode ExternalCreditorEnrolmentStatusReasonCode { get; init; } 
    #else
    public ExternalCreditorEnrolmentStatusReasonCode ExternalCreditorEnrolmentStatusReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY52_HEe2g-IPZC9d7tA")]
    [DisplayName("External Date Frequency Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDtFrqcyCd")]
    #endif
    [IsoXmlTag("XtrnlDtFrqcyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDateFrequencyCode ExternalDateFrequencyCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDateFrequencyCode ExternalDateFrequencyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDateFrequencyCode ExternalDateFrequencyCode { get; init; } 
    #else
    public ExternalDateFrequencyCode ExternalDateFrequencyCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_8G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Activation Amendment Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDbtrActvtnAmdmntRsnCd")]
    #endif
    [IsoXmlTag("XtrnlDbtrActvtnAmdmntRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDebtorActivationAmendmentReasonCode ExternalDebtorActivationAmendmentReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDebtorActivationAmendmentReasonCode ExternalDebtorActivationAmendmentReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDebtorActivationAmendmentReasonCode ExternalDebtorActivationAmendmentReasonCode { get; init; } 
    #else
    public ExternalDebtorActivationAmendmentReasonCode ExternalDebtorActivationAmendmentReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOEW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Activation Cancellation Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDbtrActvtnCxlRsnCd")]
    #endif
    [IsoXmlTag("XtrnlDbtrActvtnCxlRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDebtorActivationCancellationReasonCode ExternalDebtorActivationCancellationReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDebtorActivationCancellationReasonCode ExternalDebtorActivationCancellationReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDebtorActivationCancellationReasonCode ExternalDebtorActivationCancellationReasonCode { get; init; } 
    #else
    public ExternalDebtorActivationCancellationReasonCode ExternalDebtorActivationCancellationReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyT2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Activation Status Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDbtrActvtnStsRsnCd")]
    #endif
    [IsoXmlTag("XtrnlDbtrActvtnStsRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDebtorActivationStatusReasonCode ExternalDebtorActivationStatusReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDebtorActivationStatusReasonCode ExternalDebtorActivationStatusReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDebtorActivationStatusReasonCode ExternalDebtorActivationStatusReasonCode { get; init; } 
    #else
    public ExternalDebtorActivationStatusReasonCode ExternalDebtorActivationStatusReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqADW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Agent Instruction Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDbtrAgtInstrCd")]
    #endif
    [IsoXmlTag("XtrnlDbtrAgtInstrCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDebtorAgentInstructionCode ExternalDebtorAgentInstructionCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDebtorAgentInstructionCode ExternalDebtorAgentInstructionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDebtorAgentInstructionCode ExternalDebtorAgentInstructionCode { get; init; } 
    #else
    public ExternalDebtorAgentInstructionCode ExternalDebtorAgentInstructionCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqABG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Discount Amount Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDscntAmtTpCd")]
    #endif
    [IsoXmlTag("XtrnlDscntAmtTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDiscountAmountTypeCode ExternalDiscountAmountTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDiscountAmountTypeCode ExternalDiscountAmountTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDiscountAmountTypeCode ExternalDiscountAmountTypeCode { get; init; } 
    #else
    public ExternalDiscountAmountTypeCode ExternalDiscountAmountTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyQ2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Discrepancy Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDscrpncyCd")]
    #endif
    [IsoXmlTag("XtrnlDscrpncyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDiscrepancyCode ExternalDiscrepancyCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalDiscrepancyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalDiscrepancyCode { get; init; } 
    #else
    public string ExternalDiscrepancyCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOEG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Format Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDocFrmtCd")]
    #endif
    [IsoXmlTag("XtrnlDocFrmtCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDocumentFormatCode ExternalDocumentFormatCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDocumentFormatCode ExternalDocumentFormatCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDocumentFormatCode ExternalDocumentFormatCode { get; init; } 
    #else
    public ExternalDocumentFormatCode ExternalDocumentFormatCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAIW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Line Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDocLineTpCd")]
    #endif
    [IsoXmlTag("XtrnlDocLineTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDocumentLineTypeCode ExternalDocumentLineTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDocumentLineTypeCode ExternalDocumentLineTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDocumentLineTypeCode ExternalDocumentLineTypeCode { get; init; } 
    #else
    public ExternalDocumentLineTypeCode ExternalDocumentLineTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAUG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Purpose Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDocPurpCd")]
    #endif
    [IsoXmlTag("XtrnlDocPurpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDocumentPurposeCode ExternalDocumentPurposeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDocumentPurposeCode ExternalDocumentPurposeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDocumentPurposeCode ExternalDocumentPurposeCode { get; init; } 
    #else
    public ExternalDocumentPurposeCode ExternalDocumentPurposeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnHm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDocTpCd")]
    #endif
    [IsoXmlTag("XtrnlDocTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDocumentTypeCode ExternalDocumentTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDocumentTypeCode ExternalDocumentTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDocumentTypeCode ExternalDocumentTypeCode { get; init; } 
    #else
    public ExternalDocumentTypeCode ExternalDocumentTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqALG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Effective Date Parameter Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlFctvDtParamCd")]
    #endif
    [IsoXmlTag("XtrnlFctvDtParamCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalEffectiveDateParameterCode ExternalEffectiveDateParameterCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalEffectiveDateParameterCode ExternalEffectiveDateParameterCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalEffectiveDateParameterCode ExternalEffectiveDateParameterCode { get; init; } 
    #else
    public ExternalEffectiveDateParameterCode ExternalEffectiveDateParameterCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnFG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Encrypted Element Identification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlNcrptdElmtIdCd")]
    #endif
    [IsoXmlTag("XtrnlNcrptdElmtIdCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalEncryptedElementIdentificationCode ExternalEncryptedElementIdentificationCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalEncryptedElementIdentificationCode ExternalEncryptedElementIdentificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalEncryptedElementIdentificationCode ExternalEncryptedElementIdentificationCode { get; init; } 
    #else
    public ExternalEncryptedElementIdentificationCode ExternalEncryptedElementIdentificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAPm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Enquiry Request Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlEnqryReqTpCd")]
    #endif
    [IsoXmlTag("XtrnlEnqryReqTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalEnquiryRequestTypeCode ExternalEnquiryRequestTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalEnquiryRequestTypeCode ExternalEnquiryRequestTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalEnquiryRequestTypeCode ExternalEnquiryRequestTypeCode { get; init; } 
    #else
    public ExternalEnquiryRequestTypeCode ExternalEnquiryRequestTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyO2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Entry Status Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlNtryStsCd")]
    #endif
    [IsoXmlTag("XtrnlNtryStsCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalEntryStatusCode ExternalEntryStatusCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalEntryStatusCode ExternalEntryStatusCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalEntryStatusCode ExternalEntryStatusCode { get; init; } 
    #else
    public ExternalEntryStatusCode ExternalEntryStatusCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOG2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Financial Institution Identification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlFIIdCd")]
    #endif
    [IsoXmlTag("XtrnlFIIdCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalFinancialInstitutionIdentificationCode ExternalFinancialInstitutionIdentificationCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalFinancialInstitutionIdentificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalFinancialInstitutionIdentificationCode { get; init; } 
    #else
    public string ExternalFinancialInstitutionIdentificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnCG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Financial Instrument Identification Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlFinInstrmIdTpCd")]
    #endif
    [IsoXmlTag("XtrnlFinInstrmIdTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalFinancialInstrumentIdentificationTypeCode ExternalFinancialInstrumentIdentificationTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalFinancialInstrumentIdentificationTypeCode ExternalFinancialInstrumentIdentificationTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalFinancialInstrumentIdentificationTypeCode ExternalFinancialInstrumentIdentificationTypeCode { get; init; } 
    #else
    public ExternalFinancialInstrumentIdentificationTypeCode ExternalFinancialInstrumentIdentificationTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyQW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Financial Instrument Product Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlFinInstrmPdctTpCd")]
    #endif
    [IsoXmlTag("XtrnlFinInstrmPdctTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalFinancialInstrumentProductTypeCode ExternalFinancialInstrumentProductTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalFinancialInstrumentProductTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalFinancialInstrumentProductTypeCode { get; init; } 
    #else
    public string ExternalFinancialInstrumentProductTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAY2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Garnishment Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlGrnshmtTpCd")]
    #endif
    [IsoXmlTag("XtrnlGrnshmtTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalGarnishmentTypeCode ExternalGarnishmentTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalGarnishmentTypeCode ExternalGarnishmentTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalGarnishmentTypeCode ExternalGarnishmentTypeCode { get; init; } 
    #else
    public ExternalGarnishmentTypeCode ExternalGarnishmentTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAOm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Incoterms Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlIncotrmsCd")]
    #endif
    [IsoXmlTag("XtrnlIncotrmsCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalIncotermsCode ExternalIncotermsCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalIncotermsCode ExternalIncotermsCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalIncotermsCode ExternalIncotermsCode { get; init; } 
    #else
    public ExternalIncotermsCode ExternalIncotermsCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnCm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Information Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlInfTpCd")]
    #endif
    [IsoXmlTag("XtrnlInfTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalInformationTypeCode ExternalInformationTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalInformationTypeCode ExternalInformationTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalInformationTypeCode ExternalInformationTypeCode { get; init; } 
    #else
    public ExternalInformationTypeCode ExternalInformationTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAEG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Instructed Agent Instruction Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlInstdAgtInstrCd")]
    #endif
    [IsoXmlTag("XtrnlInstdAgtInstrCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalInstructedAgentInstructionCode ExternalInstructedAgentInstructionCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalInstructedAgentInstructionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalInstructedAgentInstructionCode { get; init; } 
    #else
    public string ExternalInstructedAgentInstructionCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyQm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Invalid Event Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlInvldEvtRsnCd")]
    #endif
    [IsoXmlTag("XtrnlInvldEvtRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalInvalidEventReasonCode ExternalInvalidEventReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalInvalidEventReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalInvalidEventReasonCode { get; init; } 
    #else
    public string ExternalInvalidEventReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyN2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Invalid Payments Event Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlInvldPmtsEvtCd")]
    #endif
    [IsoXmlTag("XtrnlInvldPmtsEvtCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalInvalidPaymentsEventCode ExternalInvalidPaymentsEventCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalInvalidPaymentsEventCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalInvalidPaymentsEventCode { get; init; } 
    #else
    public string ExternalInvalidPaymentsEventCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAU2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Investigation Execution Confirmation Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlInvstgtnExctnConfCd")]
    #endif
    [IsoXmlTag("XtrnlInvstgtnExctnConfCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalInvestigationExecutionConfirmationCode ExternalInvestigationExecutionConfirmationCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalInvestigationExecutionConfirmationCode ExternalInvestigationExecutionConfirmationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalInvestigationExecutionConfirmationCode ExternalInvestigationExecutionConfirmationCode { get; init; } 
    #else
    public ExternalInvestigationExecutionConfirmationCode ExternalInvestigationExecutionConfirmationCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqACm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Letter Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlLttrTpCd")]
    #endif
    [IsoXmlTag("XtrnlLttrTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalLetterTypeCode ExternalLetterTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalLetterTypeCode ExternalLetterTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalLetterTypeCode ExternalLetterTypeCode { get; init; } 
    #else
    public ExternalLetterTypeCode ExternalLetterTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnLG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Local Instrument Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlLclInstrmCd")]
    #endif
    [IsoXmlTag("XtrnlLclInstrmCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalLocalInstrumentCode ExternalLocalInstrumentCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalLocalInstrumentCode ExternalLocalInstrumentCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalLocalInstrumentCode ExternalLocalInstrumentCode { get; init; } 
    #else
    public ExternalLocalInstrumentCode ExternalLocalInstrumentCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAAG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlMndtRsnCd")]
    #endif
    [IsoXmlTag("XtrnlMndtRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalMandateReasonCode ExternalMandateReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalMandateReasonCode ExternalMandateReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalMandateReasonCode ExternalMandateReasonCode { get; init; } 
    #else
    public ExternalMandateReasonCode ExternalMandateReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAEm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Setup Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlMndtStpRsnCd")]
    #endif
    [IsoXmlTag("XtrnlMndtStpRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalMandateSetupReasonCode ExternalMandateSetupReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalMandateSetupReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalMandateSetupReasonCode { get; init; } 
    #else
    public string ExternalMandateSetupReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnDG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Status Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlMndtStsCd")]
    #endif
    [IsoXmlTag("XtrnlMndtStsCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalMandateStatusCode ExternalMandateStatusCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalMandateStatusCode ExternalMandateStatusCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalMandateStatusCode ExternalMandateStatusCode { get; init; } 
    #else
    public ExternalMandateStatusCode ExternalMandateStatusCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOE2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Suspension Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlMndtSspnsnRsnCd")]
    #endif
    [IsoXmlTag("XtrnlMndtSspnsnRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalMandateSuspensionReasonCode ExternalMandateSuspensionReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalMandateSuspensionReasonCode ExternalMandateSuspensionReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalMandateSuspensionReasonCode ExternalMandateSuspensionReasonCode { get; init; } 
    #else
    public ExternalMandateSuspensionReasonCode ExternalMandateSuspensionReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOGW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Market Infrastructure Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlMktInfrstrctrCd")]
    #endif
    [IsoXmlTag("XtrnlMktInfrstrctrCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalMarketInfrastructureCode ExternalMarketInfrastructureCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalMarketInfrastructureCode ExternalMarketInfrastructureCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalMarketInfrastructureCode ExternalMarketInfrastructureCode { get; init; } 
    #else
    public ExternalMarketInfrastructureCode ExternalMarketInfrastructureCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY5m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Model Form Identification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlMdlFormIdCd")]
    #endif
    [IsoXmlTag("XtrnlMdlFormIdCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalModelFormIdentificationCode ExternalModelFormIdentificationCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalModelFormIdentificationCode ExternalModelFormIdentificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalModelFormIdentificationCode ExternalModelFormIdentificationCode { get; init; } 
    #else
    public ExternalModelFormIdentificationCode ExternalModelFormIdentificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAYG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Narrative Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlNrrtvTpCd")]
    #endif
    [IsoXmlTag("XtrnlNrrtvTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalNarrativeTypeCode ExternalNarrativeTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalNarrativeTypeCode ExternalNarrativeTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalNarrativeTypeCode ExternalNarrativeTypeCode { get; init; } 
    #else
    public ExternalNarrativeTypeCode ExternalNarrativeTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqALm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Notification Cancellation Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlNtfctnCxlRsnCd")]
    #endif
    [IsoXmlTag("XtrnlNtfctnCxlRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalNotificationCancellationReasonCode ExternalNotificationCancellationReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalNotificationCancellationReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalNotificationCancellationReasonCode { get; init; } 
    #else
    public string ExternalNotificationCancellationReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqADm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Organisation Identification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlOrgIdCd")]
    #endif
    [IsoXmlTag("XtrnlOrgIdCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalOrganisationIdentificationCode ExternalOrganisationIdentificationCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalOrganisationIdentificationCode ExternalOrganisationIdentificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalOrganisationIdentificationCode ExternalOrganisationIdentificationCode { get; init; } 
    #else
    public ExternalOrganisationIdentificationCode ExternalOrganisationIdentificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_82_HEe2g-IPZC9d7tA")]
    [DisplayName("External Packaging Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPackgngTpCd")]
    #endif
    [IsoXmlTag("XtrnlPackgngTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPackagingTypeCode ExternalPackagingTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPackagingTypeCode ExternalPackagingTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPackagingTypeCode ExternalPackagingTypeCode { get; init; } 
    #else
    public ExternalPackagingTypeCode ExternalPackagingTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAaW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Cancellation Rejection Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtCxlRjctnCd")]
    #endif
    [IsoXmlTag("XtrnlPmtCxlRjctnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentCancellationRejectionCode ExternalPaymentCancellationRejectionCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentCancellationRejectionCode ExternalPaymentCancellationRejectionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentCancellationRejectionCode ExternalPaymentCancellationRejectionCode { get; init; } 
    #else
    public ExternalPaymentCancellationRejectionCode ExternalPaymentCancellationRejectionCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyNW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Compensation Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtCompstnRsnCd")]
    #endif
    [IsoXmlTag("XtrnlPmtCompstnRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentCompensationReasonCode ExternalPaymentCompensationReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentCompensationReasonCode ExternalPaymentCompensationReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentCompensationReasonCode ExternalPaymentCompensationReasonCode { get; init; } 
    #else
    public ExternalPaymentCompensationReasonCode ExternalPaymentCompensationReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqARm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Control Request Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtCtrlReqTpCd")]
    #endif
    [IsoXmlTag("XtrnlPmtCtrlReqTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentControlRequestTypeCode ExternalPaymentControlRequestTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentControlRequestTypeCode ExternalPaymentControlRequestTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentControlRequestTypeCode ExternalPaymentControlRequestTypeCode { get; init; } 
    #else
    public ExternalPaymentControlRequestTypeCode ExternalPaymentControlRequestTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnCW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Group Status Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtGrpStsCd")]
    #endif
    [IsoXmlTag("XtrnlPmtGrpStsCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentGroupStatusCode ExternalPaymentGroupStatusCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentGroupStatusCode ExternalPaymentGroupStatusCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentGroupStatusCode ExternalPaymentGroupStatusCode { get; init; } 
    #else
    public ExternalPaymentGroupStatusCode ExternalPaymentGroupStatusCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnJG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Modification Rejection Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtModRjctnCd")]
    #endif
    [IsoXmlTag("XtrnlPmtModRjctnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentModificationRejectionCode ExternalPaymentModificationRejectionCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentModificationRejectionCode ExternalPaymentModificationRejectionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentModificationRejectionCode ExternalPaymentModificationRejectionCode { get; init; } 
    #else
    public ExternalPaymentModificationRejectionCode ExternalPaymentModificationRejectionCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAT2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Role Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtRoleCd")]
    #endif
    [IsoXmlTag("XtrnlPmtRoleCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentRoleCode ExternalPaymentRoleCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentRoleCode ExternalPaymentRoleCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentRoleCode ExternalPaymentRoleCode { get; init; } 
    #else
    public ExternalPaymentRoleCode ExternalPaymentRoleCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY8G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Status Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtStsRsnCd")]
    #endif
    [IsoXmlTag("XtrnlPmtStsRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentStatusReasonCode ExternalPaymentStatusReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentStatusReasonCode ExternalPaymentStatusReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentStatusReasonCode ExternalPaymentStatusReasonCode { get; init; } 
    #else
    public ExternalPaymentStatusReasonCode ExternalPaymentStatusReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAb2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Transaction Status Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtTxStsCd")]
    #endif
    [IsoXmlTag("XtrnlPmtTxStsCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentTransactionStatusCode ExternalPaymentTransactionStatusCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentTransactionStatusCode ExternalPaymentTransactionStatusCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentTransactionStatusCode ExternalPaymentTransactionStatusCode { get; init; } 
    #else
    public ExternalPaymentTransactionStatusCode ExternalPaymentTransactionStatusCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyKG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Pending Processing Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPdgPrcgRsnCd")]
    #endif
    [IsoXmlTag("XtrnlPdgPrcgRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPendingProcessingReasonCode ExternalPendingProcessingReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPendingProcessingReasonCode ExternalPendingProcessingReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPendingProcessingReasonCode ExternalPendingProcessingReasonCode { get; init; } 
    #else
    public ExternalPendingProcessingReasonCode ExternalPendingProcessingReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_9G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Person Identification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPrsnIdCd")]
    #endif
    [IsoXmlTag("XtrnlPrsnIdCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPersonIdentificationCode ExternalPersonIdentificationCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPersonIdentificationCode ExternalPersonIdentificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPersonIdentificationCode ExternalPersonIdentificationCode { get; init; } 
    #else
    public ExternalPersonIdentificationCode ExternalPersonIdentificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_-m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Proxy Account Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPrxyAcctTpCd")]
    #endif
    [IsoXmlTag("XtrnlPrxyAcctTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalProxyAccountTypeCode ExternalProxyAccountTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalProxyAccountTypeCode ExternalProxyAccountTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalProxyAccountTypeCode ExternalProxyAccountTypeCode { get; init; } 
    #else
    public ExternalProxyAccountTypeCode ExternalProxyAccountTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_-2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Purpose And Market Area Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPurpAndMktAreaCd")]
    #endif
    [IsoXmlTag("XtrnlPurpAndMktAreaCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPurposeAndMarketAreaCode ExternalPurposeAndMarketAreaCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPurposeAndMarketAreaCode ExternalPurposeAndMarketAreaCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPurposeAndMarketAreaCode ExternalPurposeAndMarketAreaCode { get; init; } 
    #else
    public ExternalPurposeAndMarketAreaCode ExternalPurposeAndMarketAreaCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnKW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Purpose Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPurpCd")]
    #endif
    [IsoXmlTag("XtrnlPurpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPurposeCode ExternalPurposeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPurposeCode ExternalPurposeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPurposeCode ExternalPurposeCode { get; init; } 
    #else
    public ExternalPurposeCode ExternalPurposeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAVm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Rates And Tenors Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRatesAndTnrsCd")]
    #endif
    [IsoXmlTag("XtrnlRatesAndTnrsCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalRatesAndTenorsCode ExternalRatesAndTenorsCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalRatesAndTenorsCode ExternalRatesAndTenorsCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalRatesAndTenorsCode ExternalRatesAndTenorsCode { get; init; } 
    #else
    public ExternalRatesAndTenorsCode ExternalRatesAndTenorsCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAZ2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Received Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRcvdRsnCd")]
    #endif
    [IsoXmlTag("XtrnlRcvdRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalReceivedReasonCode ExternalReceivedReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalReceivedReasonCode ExternalReceivedReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalReceivedReasonCode ExternalReceivedReasonCode { get; init; } 
    #else
    public ExternalReceivedReasonCode ExternalReceivedReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAV2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Rejected Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRjctdRsnCd")]
    #endif
    [IsoXmlTag("XtrnlRjctdRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalRejectedReasonCode ExternalRejectedReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalRejectedReasonCode ExternalRejectedReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalRejectedReasonCode ExternalRejectedReasonCode { get; init; } 
    #else
    public ExternalRejectedReasonCode ExternalRejectedReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAOG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Relative To Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRltvToCd")]
    #endif
    [IsoXmlTag("XtrnlRltvToCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalRelativeToCode ExternalRelativeToCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalRelativeToCode ExternalRelativeToCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalRelativeToCode ExternalRelativeToCode { get; init; } 
    #else
    public ExternalRelativeToCode ExternalRelativeToCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAB2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Reporting Source Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRptgSrcCd")]
    #endif
    [IsoXmlTag("XtrnlRptgSrcCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalReportingSourceCode ExternalReportingSourceCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalReportingSourceCode ExternalReportingSourceCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalReportingSourceCode ExternalReportingSourceCode { get; init; } 
    #else
    public ExternalReportingSourceCode ExternalReportingSourceCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAR2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Re Presentment Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRePresntmntRsnCd")]
    #endif
    [IsoXmlTag("XtrnlRePresntmntRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalRePresentmentReasonCode ExternalRePresentmentReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalRePresentmentReasonCode ExternalRePresentmentReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalRePresentmentReasonCode ExternalRePresentmentReasonCode { get; init; } 
    #else
    public ExternalRePresentmentReasonCode ExternalRePresentmentReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnD2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Reservation Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRsvatnTpCd")]
    #endif
    [IsoXmlTag("XtrnlRsvatnTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalReservationTypeCode ExternalReservationTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalReservationTypeCode ExternalReservationTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalReservationTypeCode ExternalReservationTypeCode { get; init; } 
    #else
    public ExternalReservationTypeCode ExternalReservationTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyJ2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Return Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRtrRsnCd")]
    #endif
    [IsoXmlTag("XtrnlRtrRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalReturnReasonCode ExternalReturnReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalReturnReasonCode ExternalReturnReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalReturnReasonCode ExternalReturnReasonCode { get; init; } 
    #else
    public ExternalReturnReasonCode ExternalReturnReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY5G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Reversal Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRvslRsnCd")]
    #endif
    [IsoXmlTag("XtrnlRvslRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalReversalReasonCode ExternalReversalReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalReversalReasonCode ExternalReversalReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalReversalReasonCode ExternalReversalReasonCode { get; init; } 
    #else
    public ExternalReversalReasonCode ExternalReversalReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOF2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Securities Lending Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSctiesLndgTpCd")]
    #endif
    [IsoXmlTag("XtrnlSctiesLndgTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalSecuritiesLendingTypeCode ExternalSecuritiesLendingTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalSecuritiesLendingTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalSecuritiesLendingTypeCode { get; init; } 
    #else
    public string ExternalSecuritiesLendingTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY6W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Securities Purpose 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSctiesPurp1Cd")]
    #endif
    [IsoXmlTag("XtrnlSctiesPurp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalSecuritiesPurpose1Code ExternalSecuritiesPurpose1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalSecuritiesPurpose1Code ExternalSecuritiesPurpose1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalSecuritiesPurpose1Code ExternalSecuritiesPurpose1Code { get; init; } 
    #else
    public ExternalSecuritiesPurpose1Code ExternalSecuritiesPurpose1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAYW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Securities Update Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSctiesUpdRsnCd")]
    #endif
    [IsoXmlTag("XtrnlSctiesUpdRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalSecuritiesUpdateReasonCode ExternalSecuritiesUpdateReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalSecuritiesUpdateReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalSecuritiesUpdateReasonCode { get; init; } 
    #else
    public string ExternalSecuritiesUpdateReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tp_-G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Service Level Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSvcLvlCd")]
    #endif
    [IsoXmlTag("XtrnlSvcLvlCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalServiceLevelCode ExternalServiceLevelCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalServiceLevelCode ExternalServiceLevelCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalServiceLevelCode ExternalServiceLevelCode { get; init; } 
    #else
    public ExternalServiceLevelCode ExternalServiceLevelCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyK2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Shipment Condition Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlShipmntCondCd")]
    #endif
    [IsoXmlTag("XtrnlShipmntCondCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalShipmentConditionCode ExternalShipmentConditionCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalShipmentConditionCode ExternalShipmentConditionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalShipmentConditionCode ExternalShipmentConditionCode { get; init; } 
    #else
    public ExternalShipmentConditionCode ExternalShipmentConditionCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyLW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Status Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlStsRsnCd")]
    #endif
    [IsoXmlTag("XtrnlStsRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalStatusReasonCode ExternalStatusReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalStatusReasonCode ExternalStatusReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalStatusReasonCode ExternalStatusReasonCode { get; init; } 
    #else
    public ExternalStatusReasonCode ExternalStatusReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAJW_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Balance Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSysBalTpCd")]
    #endif
    [IsoXmlTag("XtrnlSysBalTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalSystemBalanceTypeCode ExternalSystemBalanceTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalSystemBalanceTypeCode ExternalSystemBalanceTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalSystemBalanceTypeCode ExternalSystemBalanceTypeCode { get; init; } 
    #else
    public ExternalSystemBalanceTypeCode ExternalSystemBalanceTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyUW_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Error Handling Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSysErrHdlgCd")]
    #endif
    [IsoXmlTag("XtrnlSysErrHdlgCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalSystemErrorHandlingCode ExternalSystemErrorHandlingCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalSystemErrorHandlingCode ExternalSystemErrorHandlingCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalSystemErrorHandlingCode ExternalSystemErrorHandlingCode { get; init; } 
    #else
    public ExternalSystemErrorHandlingCode ExternalSystemErrorHandlingCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqACW_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Event Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSysEvtTpCd")]
    #endif
    [IsoXmlTag("XtrnlSysEvtTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalSystemEventTypeCode ExternalSystemEventTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalSystemEventTypeCode ExternalSystemEventTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalSystemEventTypeCode ExternalSystemEventTypeCode { get; init; } 
    #else
    public ExternalSystemEventTypeCode ExternalSystemEventTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqANG_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Member Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSysMmbTpCd")]
    #endif
    [IsoXmlTag("XtrnlSysMmbTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalSystemMemberTypeCode ExternalSystemMemberTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalSystemMemberTypeCode ExternalSystemMemberTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalSystemMemberTypeCode ExternalSystemMemberTypeCode { get; init; } 
    #else
    public ExternalSystemMemberTypeCode ExternalSystemMemberTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY4m_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Party Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSysPtyTpCd")]
    #endif
    [IsoXmlTag("XtrnlSysPtyTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalSystemPartyTypeCode ExternalSystemPartyTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalSystemPartyTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalSystemPartyTypeCode { get; init; } 
    #else
    public string ExternalSystemPartyTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyU2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Tax Amount Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlTaxAmtTpCd")]
    #endif
    [IsoXmlTag("XtrnlTaxAmtTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalTaxAmountTypeCode ExternalTaxAmountTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalTaxAmountTypeCode ExternalTaxAmountTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalTaxAmountTypeCode ExternalTaxAmountTypeCode { get; init; } 
    #else
    public ExternalTaxAmountTypeCode ExternalTaxAmountTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnLm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Technical Input Channel Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlTechInptChanlCd")]
    #endif
    [IsoXmlTag("XtrnlTechInptChanlCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalTechnicalInputChannelCode ExternalTechnicalInputChannelCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalTechnicalInputChannelCode ExternalTechnicalInputChannelCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalTechnicalInputChannelCode ExternalTechnicalInputChannelCode { get; init; } 
    #else
    public ExternalTechnicalInputChannelCode ExternalTechnicalInputChannelCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAHm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Trade Market Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlTradMktCd")]
    #endif
    [IsoXmlTag("XtrnlTradMktCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalTradeMarketCode ExternalTradeMarketCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalTradeMarketCode ExternalTradeMarketCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalTradeMarketCode ExternalTradeMarketCode { get; init; } 
    #else
    public ExternalTradeMarketCode ExternalTradeMarketCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqnHG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Trade Transaction Condition Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlTradTxCondCd")]
    #endif
    [IsoXmlTag("XtrnlTradTxCondCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalTradeTransactionConditionCode ExternalTradeTransactionConditionCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalTradeTransactionConditionCode ExternalTradeTransactionConditionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalTradeTransactionConditionCode ExternalTradeTransactionConditionCode { get; init; } 
    #else
    public ExternalTradeTransactionConditionCode ExternalTradeTransactionConditionCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAC2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Type Of Party Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlTpOfPtyCd")]
    #endif
    [IsoXmlTag("XtrnlTpOfPtyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalTypeOfPartyCode ExternalTypeOfPartyCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalTypeOfPartyCode ExternalTypeOfPartyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalTypeOfPartyCode ExternalTypeOfPartyCode { get; init; } 
    #else
    public ExternalTypeOfPartyCode ExternalTypeOfPartyCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAEW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Unable To Apply Incorrect Data Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUblToApplyIncrrctDataCd")]
    #endif
    [IsoXmlTag("XtrnlUblToApplyIncrrctDataCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUnableToApplyIncorrectDataCode ExternalUnableToApplyIncorrectDataCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUnableToApplyIncorrectDataCode ExternalUnableToApplyIncorrectDataCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUnableToApplyIncorrectDataCode ExternalUnableToApplyIncorrectDataCode { get; init; } 
    #else
    public ExternalUnableToApplyIncorrectDataCode ExternalUnableToApplyIncorrectDataCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqANW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Unable To Apply Missing Data Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUblToApplyMssngDataCd")]
    #endif
    [IsoXmlTag("XtrnlUblToApplyMssngDataCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUnableToApplyMissingDataCode ExternalUnableToApplyMissingDataCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUnableToApplyMissingDataCode ExternalUnableToApplyMissingDataCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUnableToApplyMissingDataCode ExternalUnableToApplyMissingDataCode { get; init; } 
    #else
    public ExternalUnableToApplyMissingDataCode ExternalUnableToApplyMissingDataCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3toyS2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Underlying Trade Transaction Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUndrlygTradTxTpCd")]
    #endif
    [IsoXmlTag("XtrnlUndrlygTradTxTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUnderlyingTradeTransactionTypeCode ExternalUnderlyingTradeTransactionTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUnderlyingTradeTransactionTypeCode ExternalUnderlyingTradeTransactionTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUnderlyingTradeTransactionTypeCode ExternalUnderlyingTradeTransactionTypeCode { get; init; } 
    #else
    public ExternalUnderlyingTradeTransactionTypeCode ExternalUnderlyingTradeTransactionTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAFW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Amount Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUdrtkgAmtTpCd")]
    #endif
    [IsoXmlTag("XtrnlUdrtkgAmtTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUndertakingAmountTypeCode ExternalUndertakingAmountTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUndertakingAmountTypeCode ExternalUndertakingAmountTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUndertakingAmountTypeCode ExternalUndertakingAmountTypeCode { get; init; } 
    #else
    public ExternalUndertakingAmountTypeCode ExternalUndertakingAmountTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOFm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Document Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUdrtkgDocTpCd")]
    #endif
    [IsoXmlTag("XtrnlUdrtkgDocTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUndertakingDocumentTypeCode ExternalUndertakingDocumentTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUndertakingDocumentTypeCode ExternalUndertakingDocumentTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUndertakingDocumentTypeCode ExternalUndertakingDocumentTypeCode { get; init; } 
    #else
    public ExternalUndertakingDocumentTypeCode ExternalUndertakingDocumentTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAKG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Status Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUdrtkgStsCtgyCd")]
    #endif
    [IsoXmlTag("XtrnlUdrtkgStsCtgyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUndertakingStatusCategoryCode ExternalUndertakingStatusCategoryCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUndertakingStatusCategoryCode ExternalUndertakingStatusCategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUndertakingStatusCategoryCode ExternalUndertakingStatusCategoryCode { get; init; } 
    #else
    public ExternalUndertakingStatusCategoryCode ExternalUndertakingStatusCategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tqAUW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUdrtkgTpCd")]
    #endif
    [IsoXmlTag("XtrnlUdrtkgTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUndertakingTypeCode ExternalUndertakingTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUndertakingTypeCode ExternalUndertakingTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUndertakingTypeCode ExternalUndertakingTypeCode { get; init; } 
    #else
    public ExternalUndertakingTypeCode ExternalUndertakingTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3tpY7G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Validation Rule Identification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlVldtnRuleIdCd")]
    #endif
    [IsoXmlTag("XtrnlVldtnRuleIdCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalValidationRuleIdentificationCode ExternalValidationRuleIdentificationCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalValidationRuleIdentificationCode ExternalValidationRuleIdentificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalValidationRuleIdentificationCode ExternalValidationRuleIdentificationCode { get; init; } 
    #else
    public ExternalValidationRuleIdentificationCode ExternalValidationRuleIdentificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_3trOFW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Verification Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlVrfctnRsnCd")]
    #endif
    [IsoXmlTag("XtrnlVrfctnRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalVerificationReasonCode ExternalVerificationReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalVerificationReasonCode ExternalVerificationReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalVerificationReasonCode ExternalVerificationReasonCode { get; init; } 
    #else
    public ExternalVerificationReasonCode ExternalVerificationReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_xi3wc3C-Ee2QDe42vpiOiA")]
    [DisplayName("External Benchmark Curve Name Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBchmkCrvNmCd")]
    #endif
    [IsoXmlTag("XtrnlBchmkCrvNmCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBenchmarkCurveNameCode ExternalBenchmarkCurveNameCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalBenchmarkCurveNameCode ExternalBenchmarkCurveNameCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalBenchmarkCurveNameCode ExternalBenchmarkCurveNameCode { get; init; } 
    #else
    public ExternalBenchmarkCurveNameCode ExternalBenchmarkCurveNameCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_xi3wdHC-Ee2QDe42vpiOiA")]
    [DisplayName("External Party Relationship Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPtyRltshTpCd")]
    #endif
    [IsoXmlTag("XtrnlPtyRltshTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPartyRelationshipTypeCode ExternalPartyRelationshipTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalPartyRelationshipTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalPartyRelationshipTypeCode { get; init; } 
    #else
    public string ExternalPartyRelationshipTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_xi3wdXC-Ee2QDe42vpiOiA")]
    [DisplayName("External Unit Of Measure Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUnitOfMeasrCd")]
    #endif
    [IsoXmlTag("XtrnlUnitOfMeasrCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUnitOfMeasureCode ExternalUnitOfMeasureCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUnitOfMeasureCode ExternalUnitOfMeasureCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUnitOfMeasureCode ExternalUnitOfMeasureCode { get; init; } 
    #else
    public ExternalUnitOfMeasureCode ExternalUnitOfMeasureCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
