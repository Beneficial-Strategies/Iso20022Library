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
[IsoId("_4NglvG_HEe2g-IPZC9d7tA")]
[DisplayName("All External Derived Registered Code Sets")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AllExternalDerivedRegisteredCodeSets1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AllExternalDerivedRegisteredCodeSets1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AllExternalDerivedRegisteredCodeSets1( ExternalAcceptedReason1Code reqExternalAcceptedReason1Code,ExternalAccountIdentification1Code reqExternalAccountIdentification1Code,ExternalAgentInstruction1Code reqExternalAgentInstruction1Code,ExternalAgreementType1Code reqExternalAgreementType1Code,ExternalAuthenticationChannel1Code reqExternalAuthenticationChannel1Code,string reqExternalAuthenticationMethod1Code,ExternalAuthorityExchangeReason1Code reqExternalAuthorityExchangeReason1Code,ExternalAuthorityIdentification1Code reqExternalAuthorityIdentification1Code,ExternalBalanceSubType1Code reqExternalBalanceSubType1Code,ExternalBalanceType1Code reqExternalBalanceType1Code,string reqExternalBankTransactionDomain1Code,string reqExternalBankTransactionFamily1Code,string reqExternalBankTransactionSubFamily1Code,ExternalBillingBalanceType1Code reqExternalBillingBalanceType1Code,ExternalBillingCompensationType1Code reqExternalBillingCompensationType1Code,ExternalBillingRateIdentification1Code reqExternalBillingRateIdentification1Code,ExternalCancellationReason1Code reqExternalCancellationReason1Code,string reqExternalCardTransactionCategory1Code,ExternalCashAccountType1Code reqExternalCashAccountType1Code,ExternalCashClearingSystem1Code reqExternalCashClearingSystem1Code,ExternalCategoryPurpose1Code reqExternalCategoryPurpose1Code,ExternalChannel1Code reqExternalChannel1Code,ExternalChargeType1Code reqExternalChargeType1Code,string reqExternalChequeAgentInstruction1Code,string reqExternalChequeCancellationReason1Code,string reqExternalChequeCancellationStatus1Code,ExternalClaimNonReceiptRejection1Code reqExternalClaimNonReceiptRejection1Code,ExternalClearingSystemIdentification1Code reqExternalClearingSystemIdentification1Code,string reqExternalCommunicationFormat1Code,ExternalContractBalanceType1Code reqExternalContractBalanceType1Code,ExternalContractClosureReason1Code reqExternalContractClosureReason1Code,string reqExternalCreditLineType1Code,ExternalCreditorAgentInstruction1Code reqExternalCreditorAgentInstruction1Code,ExternalCreditorEnrolmentAmendmentReason1Code reqExternalCreditorEnrolmentAmendmentReason1Code,ExternalCreditorEnrolmentCancellationReason1Code reqExternalCreditorEnrolmentCancellationReason1Code,ExternalCreditorEnrolmentStatusReason1Code reqExternalCreditorEnrolmentStatusReason1Code,ExternalDateFrequency1Code reqExternalDateFrequency1Code,ExternalDebtorActivationAmendmentReason1Code reqExternalDebtorActivationAmendmentReason1Code,ExternalDebtorActivationCancellationReason1Code reqExternalDebtorActivationCancellationReason1Code,ExternalDebtorActivationStatusReason1Code reqExternalDebtorActivationStatusReason1Code,string reqExternalDebtorAgentInstruction1Code,ExternalDiscountAmountType1Code reqExternalDiscountAmountType1Code,string reqExternalDiscrepancy1Code,ExternalDocumentFormat1Code reqExternalDocumentFormat1Code,ExternalDocumentLineType1Code reqExternalDocumentLineType1Code,ExternalDocumentPurpose1Code reqExternalDocumentPurpose1Code,ExternalDocumentType1Code reqExternalDocumentType1Code,ExternalEffectiveDateParameter1Code reqExternalEffectiveDateParameter1Code,ExternalEncryptedElementIdentification1Code reqExternalEncryptedElementIdentification1Code,ExternalEnquiryRequestType1Code reqExternalEnquiryRequestType1Code,ExternalEntryStatus1Code reqExternalEntryStatus1Code,string reqExternalFinancialInstitutionIdentification1Code,ExternalFinancialInstrumentIdentificationType1Code reqExternalFinancialInstrumentIdentificationType1Code,string reqExternalFinancialInstrumentProductType1Code,ExternalGarnishmentType1Code reqExternalGarnishmentType1Code,ExternalIncoterms1Code reqExternalIncoterms1Code,ExternalInformationType1Code reqExternalInformationType1Code,string reqExternalInstructedAgentInstruction1Code,ExternalInvestigationExecutionConfirmation1Code reqExternalInvestigationExecutionConfirmation1Code,ExternalLetterType1Code reqExternalLetterType1Code,ExternalLocalInstrument1Code reqExternalLocalInstrument1Code,ExternalMandateReason1Code reqExternalMandateReason1Code,string reqExternalMandateSetupReason1Code,ExternalMandateStatus1Code reqExternalMandateStatus1Code,ExternalMandateSuspensionReason1Code reqExternalMandateSuspensionReason1Code,ExternalMarketArea1Code reqExternalMarketArea1Code,ExternalMarketInfrastructure1Code reqExternalMarketInfrastructure1Code,ExternalModelFormIdentification1Code reqExternalModelFormIdentification1Code,ExternalNarrativeType1Code reqExternalNarrativeType1Code,string reqExternalNotificationCancellationReason1Code,ExternalOrganisationIdentification1Code reqExternalOrganisationIdentification1Code,ExternalPackagingType1Code reqExternalPackagingType1Code,ExternalPaymentCancellationRejection1Code reqExternalPaymentCancellationRejection1Code,ExternalPaymentCompensationReason1Code reqExternalPaymentCompensationReason1Code,ExternalPaymentControlRequestType1Code reqExternalPaymentControlRequestType1Code,ExternalPaymentGroupStatus1Code reqExternalPaymentGroupStatus1Code,ExternalPaymentModificationRejection1Code reqExternalPaymentModificationRejection1Code,ExternalPaymentRole1Code reqExternalPaymentRole1Code,ExternalPaymentTransactionStatus1Code reqExternalPaymentTransactionStatus1Code,ExternalPendingProcessingReason1Code reqExternalPendingProcessingReason1Code,ExternalPersonIdentification1Code reqExternalPersonIdentification1Code,ExternalProxyAccountType1Code reqExternalProxyAccountType1Code,ExternalPurpose1Code reqExternalPurpose1Code,ExternalRatesAndTenors1Code reqExternalRatesAndTenors1Code,ExternalReceivedReason1Code reqExternalReceivedReason1Code,ExternalRejectedReason1Code reqExternalRejectedReason1Code,ExternalRelativeTo1Code reqExternalRelativeTo1Code,ExternalReportingSource1Code reqExternalReportingSource1Code,ExternalRePresentmentReason1Code reqExternalRePresentmentReason1Code,ExternalReservationType1Code reqExternalReservationType1Code,ExternalReturnReason1Code reqExternalReturnReason1Code,ExternalReversalReason1Code reqExternalReversalReason1Code,string reqExternalSecuritiesLendingType1Code,ExternalSecuritiesPurpose1Code reqExternalSecuritiesPurpose1Code,string reqExternalSecuritiesUpdateReason1Code,ExternalServiceLevel1Code reqExternalServiceLevel1Code,ExternalShipmentCondition1Code reqExternalShipmentCondition1Code,ExternalStatusReason1Code reqExternalStatusReason1Code,ExternalSystemBalanceType1Code reqExternalSystemBalanceType1Code,ExternalSystemErrorHandling1Code reqExternalSystemErrorHandling1Code,ExternalSystemEventType1Code reqExternalSystemEventType1Code,ExternalSystemMemberType1Code reqExternalSystemMemberType1Code,string reqExternalSystemPartyType1Code,ExternalTaxAmountType1Code reqExternalTaxAmountType1Code,ExternalTechnicalInputChannel1Code reqExternalTechnicalInputChannel1Code,ExternalTradeMarket1Code reqExternalTradeMarket1Code,ExternalTradeTransactionCondition1Code reqExternalTradeTransactionCondition1Code,ExternalTypeOfParty1Code reqExternalTypeOfParty1Code,ExternalUnableToApplyIncorrectData1Code reqExternalUnableToApplyIncorrectData1Code,ExternalUnableToApplyMissingData1Code reqExternalUnableToApplyMissingData1Code,ExternalUnderlyingTradeTransactionType1Code reqExternalUnderlyingTradeTransactionType1Code,ExternalUndertakingAmountType1Code reqExternalUndertakingAmountType1Code,ExternalUndertakingChargeType1Code reqExternalUndertakingChargeType1Code,ExternalUndertakingDocumentType1Code reqExternalUndertakingDocumentType1Code,ExternalUndertakingStatusCategory1Code reqExternalUndertakingStatusCategory1Code,ExternalUndertakingType1Code reqExternalUndertakingType1Code,ExternalValidationRuleIdentification1Code reqExternalValidationRuleIdentification1Code,ExternalVerificationReason1Code reqExternalVerificationReason1Code,ExternalBenchmarkCurveName1Code reqExternalBenchmarkCurveName1Code,ExternalUnitOfMeasure1Code reqExternalUnitOfMeasure1Code,string reqExternalPartyRelationshipType1Code )
    {
        ExternalAcceptedReason1Code = reqExternalAcceptedReason1Code;
        ExternalAccountIdentification1Code = reqExternalAccountIdentification1Code;
        ExternalAgentInstruction1Code = reqExternalAgentInstruction1Code;
        ExternalAgreementType1Code = reqExternalAgreementType1Code;
        ExternalAuthenticationChannel1Code = reqExternalAuthenticationChannel1Code;
        ExternalAuthenticationMethod1Code = reqExternalAuthenticationMethod1Code;
        ExternalAuthorityExchangeReason1Code = reqExternalAuthorityExchangeReason1Code;
        ExternalAuthorityIdentification1Code = reqExternalAuthorityIdentification1Code;
        ExternalBalanceSubType1Code = reqExternalBalanceSubType1Code;
        ExternalBalanceType1Code = reqExternalBalanceType1Code;
        ExternalBankTransactionDomain1Code = reqExternalBankTransactionDomain1Code;
        ExternalBankTransactionFamily1Code = reqExternalBankTransactionFamily1Code;
        ExternalBankTransactionSubFamily1Code = reqExternalBankTransactionSubFamily1Code;
        ExternalBillingBalanceType1Code = reqExternalBillingBalanceType1Code;
        ExternalBillingCompensationType1Code = reqExternalBillingCompensationType1Code;
        ExternalBillingRateIdentification1Code = reqExternalBillingRateIdentification1Code;
        ExternalCancellationReason1Code = reqExternalCancellationReason1Code;
        ExternalCardTransactionCategory1Code = reqExternalCardTransactionCategory1Code;
        ExternalCashAccountType1Code = reqExternalCashAccountType1Code;
        ExternalCashClearingSystem1Code = reqExternalCashClearingSystem1Code;
        ExternalCategoryPurpose1Code = reqExternalCategoryPurpose1Code;
        ExternalChannel1Code = reqExternalChannel1Code;
        ExternalChargeType1Code = reqExternalChargeType1Code;
        ExternalChequeAgentInstruction1Code = reqExternalChequeAgentInstruction1Code;
        ExternalChequeCancellationReason1Code = reqExternalChequeCancellationReason1Code;
        ExternalChequeCancellationStatus1Code = reqExternalChequeCancellationStatus1Code;
        ExternalClaimNonReceiptRejection1Code = reqExternalClaimNonReceiptRejection1Code;
        ExternalClearingSystemIdentification1Code = reqExternalClearingSystemIdentification1Code;
        ExternalCommunicationFormat1Code = reqExternalCommunicationFormat1Code;
        ExternalContractBalanceType1Code = reqExternalContractBalanceType1Code;
        ExternalContractClosureReason1Code = reqExternalContractClosureReason1Code;
        ExternalCreditLineType1Code = reqExternalCreditLineType1Code;
        ExternalCreditorAgentInstruction1Code = reqExternalCreditorAgentInstruction1Code;
        ExternalCreditorEnrolmentAmendmentReason1Code = reqExternalCreditorEnrolmentAmendmentReason1Code;
        ExternalCreditorEnrolmentCancellationReason1Code = reqExternalCreditorEnrolmentCancellationReason1Code;
        ExternalCreditorEnrolmentStatusReason1Code = reqExternalCreditorEnrolmentStatusReason1Code;
        ExternalDateFrequency1Code = reqExternalDateFrequency1Code;
        ExternalDebtorActivationAmendmentReason1Code = reqExternalDebtorActivationAmendmentReason1Code;
        ExternalDebtorActivationCancellationReason1Code = reqExternalDebtorActivationCancellationReason1Code;
        ExternalDebtorActivationStatusReason1Code = reqExternalDebtorActivationStatusReason1Code;
        ExternalDebtorAgentInstruction1Code = reqExternalDebtorAgentInstruction1Code;
        ExternalDiscountAmountType1Code = reqExternalDiscountAmountType1Code;
        ExternalDiscrepancy1Code = reqExternalDiscrepancy1Code;
        ExternalDocumentFormat1Code = reqExternalDocumentFormat1Code;
        ExternalDocumentLineType1Code = reqExternalDocumentLineType1Code;
        ExternalDocumentPurpose1Code = reqExternalDocumentPurpose1Code;
        ExternalDocumentType1Code = reqExternalDocumentType1Code;
        ExternalEffectiveDateParameter1Code = reqExternalEffectiveDateParameter1Code;
        ExternalEncryptedElementIdentification1Code = reqExternalEncryptedElementIdentification1Code;
        ExternalEnquiryRequestType1Code = reqExternalEnquiryRequestType1Code;
        ExternalEntryStatus1Code = reqExternalEntryStatus1Code;
        ExternalFinancialInstitutionIdentification1Code = reqExternalFinancialInstitutionIdentification1Code;
        ExternalFinancialInstrumentIdentificationType1Code = reqExternalFinancialInstrumentIdentificationType1Code;
        ExternalFinancialInstrumentProductType1Code = reqExternalFinancialInstrumentProductType1Code;
        ExternalGarnishmentType1Code = reqExternalGarnishmentType1Code;
        ExternalIncoterms1Code = reqExternalIncoterms1Code;
        ExternalInformationType1Code = reqExternalInformationType1Code;
        ExternalInstructedAgentInstruction1Code = reqExternalInstructedAgentInstruction1Code;
        ExternalInvestigationExecutionConfirmation1Code = reqExternalInvestigationExecutionConfirmation1Code;
        ExternalLetterType1Code = reqExternalLetterType1Code;
        ExternalLocalInstrument1Code = reqExternalLocalInstrument1Code;
        ExternalMandateReason1Code = reqExternalMandateReason1Code;
        ExternalMandateSetupReason1Code = reqExternalMandateSetupReason1Code;
        ExternalMandateStatus1Code = reqExternalMandateStatus1Code;
        ExternalMandateSuspensionReason1Code = reqExternalMandateSuspensionReason1Code;
        ExternalMarketArea1Code = reqExternalMarketArea1Code;
        ExternalMarketInfrastructure1Code = reqExternalMarketInfrastructure1Code;
        ExternalModelFormIdentification1Code = reqExternalModelFormIdentification1Code;
        ExternalNarrativeType1Code = reqExternalNarrativeType1Code;
        ExternalNotificationCancellationReason1Code = reqExternalNotificationCancellationReason1Code;
        ExternalOrganisationIdentification1Code = reqExternalOrganisationIdentification1Code;
        ExternalPackagingType1Code = reqExternalPackagingType1Code;
        ExternalPaymentCancellationRejection1Code = reqExternalPaymentCancellationRejection1Code;
        ExternalPaymentCompensationReason1Code = reqExternalPaymentCompensationReason1Code;
        ExternalPaymentControlRequestType1Code = reqExternalPaymentControlRequestType1Code;
        ExternalPaymentGroupStatus1Code = reqExternalPaymentGroupStatus1Code;
        ExternalPaymentModificationRejection1Code = reqExternalPaymentModificationRejection1Code;
        ExternalPaymentRole1Code = reqExternalPaymentRole1Code;
        ExternalPaymentTransactionStatus1Code = reqExternalPaymentTransactionStatus1Code;
        ExternalPendingProcessingReason1Code = reqExternalPendingProcessingReason1Code;
        ExternalPersonIdentification1Code = reqExternalPersonIdentification1Code;
        ExternalProxyAccountType1Code = reqExternalProxyAccountType1Code;
        ExternalPurpose1Code = reqExternalPurpose1Code;
        ExternalRatesAndTenors1Code = reqExternalRatesAndTenors1Code;
        ExternalReceivedReason1Code = reqExternalReceivedReason1Code;
        ExternalRejectedReason1Code = reqExternalRejectedReason1Code;
        ExternalRelativeTo1Code = reqExternalRelativeTo1Code;
        ExternalReportingSource1Code = reqExternalReportingSource1Code;
        ExternalRePresentmentReason1Code = reqExternalRePresentmentReason1Code;
        ExternalReservationType1Code = reqExternalReservationType1Code;
        ExternalReturnReason1Code = reqExternalReturnReason1Code;
        ExternalReversalReason1Code = reqExternalReversalReason1Code;
        ExternalSecuritiesLendingType1Code = reqExternalSecuritiesLendingType1Code;
        ExternalSecuritiesPurpose1Code = reqExternalSecuritiesPurpose1Code;
        ExternalSecuritiesUpdateReason1Code = reqExternalSecuritiesUpdateReason1Code;
        ExternalServiceLevel1Code = reqExternalServiceLevel1Code;
        ExternalShipmentCondition1Code = reqExternalShipmentCondition1Code;
        ExternalStatusReason1Code = reqExternalStatusReason1Code;
        ExternalSystemBalanceType1Code = reqExternalSystemBalanceType1Code;
        ExternalSystemErrorHandling1Code = reqExternalSystemErrorHandling1Code;
        ExternalSystemEventType1Code = reqExternalSystemEventType1Code;
        ExternalSystemMemberType1Code = reqExternalSystemMemberType1Code;
        ExternalSystemPartyType1Code = reqExternalSystemPartyType1Code;
        ExternalTaxAmountType1Code = reqExternalTaxAmountType1Code;
        ExternalTechnicalInputChannel1Code = reqExternalTechnicalInputChannel1Code;
        ExternalTradeMarket1Code = reqExternalTradeMarket1Code;
        ExternalTradeTransactionCondition1Code = reqExternalTradeTransactionCondition1Code;
        ExternalTypeOfParty1Code = reqExternalTypeOfParty1Code;
        ExternalUnableToApplyIncorrectData1Code = reqExternalUnableToApplyIncorrectData1Code;
        ExternalUnableToApplyMissingData1Code = reqExternalUnableToApplyMissingData1Code;
        ExternalUnderlyingTradeTransactionType1Code = reqExternalUnderlyingTradeTransactionType1Code;
        ExternalUndertakingAmountType1Code = reqExternalUndertakingAmountType1Code;
        ExternalUndertakingChargeType1Code = reqExternalUndertakingChargeType1Code;
        ExternalUndertakingDocumentType1Code = reqExternalUndertakingDocumentType1Code;
        ExternalUndertakingStatusCategory1Code = reqExternalUndertakingStatusCategory1Code;
        ExternalUndertakingType1Code = reqExternalUndertakingType1Code;
        ExternalValidationRuleIdentification1Code = reqExternalValidationRuleIdentification1Code;
        ExternalVerificationReason1Code = reqExternalVerificationReason1Code;
        ExternalBenchmarkCurveName1Code = reqExternalBenchmarkCurveName1Code;
        ExternalUnitOfMeasure1Code = reqExternalUnitOfMeasure1Code;
        ExternalPartyRelationshipType1Code = reqExternalPartyRelationshipType1Code;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL12_HEe2g-IPZC9d7tA")]
    [DisplayName("External Accepted Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAccptdRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlAccptdRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAcceptedReason1Code ExternalAcceptedReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalAcceptedReason1Code ExternalAcceptedReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAcceptedReason1Code ExternalAcceptedReason1Code { get; init; } 
    #else
    public ExternalAcceptedReason1Code ExternalAcceptedReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzGW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Account Identification 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAcctId1Cd")]
    #endif
    [IsoXmlTag("XtrnlAcctId1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAccountIdentification1Code ExternalAccountIdentification1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalAccountIdentification1Code ExternalAccountIdentification1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAccountIdentification1Code ExternalAccountIdentification1Code { get; init; } 
    #else
    public ExternalAccountIdentification1Code ExternalAccountIdentification1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzEm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Agent Instruction 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAgtInstr1Cd")]
    #endif
    [IsoXmlTag("XtrnlAgtInstr1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAgentInstruction1Code ExternalAgentInstruction1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalAgentInstruction1Code ExternalAgentInstruction1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAgentInstruction1Code ExternalAgentInstruction1Code { get; init; } 
    #else
    public ExternalAgentInstruction1Code ExternalAgentInstruction1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ_2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Agreement Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAgrmtTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlAgrmtTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAgreementType1Code ExternalAgreementType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalAgreementType1Code ExternalAgreementType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAgreementType1Code ExternalAgreementType1Code { get; init; } 
    #else
    public ExternalAgreementType1Code ExternalAgreementType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy9W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authentication Channel 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAuthntcnChanl1Cd")]
    #endif
    [IsoXmlTag("XtrnlAuthntcnChanl1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAuthenticationChannel1Code ExternalAuthenticationChannel1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalAuthenticationChannel1Code ExternalAuthenticationChannel1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAuthenticationChannel1Code ExternalAuthenticationChannel1Code { get; init; } 
    #else
    public ExternalAuthenticationChannel1Code ExternalAuthenticationChannel1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL5W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authentication Method 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAuthntcnMtd1Cd")]
    #endif
    [IsoXmlTag("XtrnlAuthntcnMtd1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAuthenticationMethod1Code ExternalAuthenticationMethod1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalAuthenticationMethod1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalAuthenticationMethod1Code { get; init; } 
    #else
    public string ExternalAuthenticationMethod1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaHW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authority Exchange Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAuthrtyXchgRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlAuthrtyXchgRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAuthorityExchangeReason1Code ExternalAuthorityExchangeReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalAuthorityExchangeReason1Code ExternalAuthorityExchangeReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAuthorityExchangeReason1Code ExternalAuthorityExchangeReason1Code { get; init; } 
    #else
    public ExternalAuthorityExchangeReason1Code ExternalAuthorityExchangeReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ5m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Authority Identification 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlAuthrtyId1Cd")]
    #endif
    [IsoXmlTag("XtrnlAuthrtyId1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalAuthorityIdentification1Code ExternalAuthorityIdentification1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalAuthorityIdentification1Code ExternalAuthorityIdentification1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAuthorityIdentification1Code ExternalAuthorityIdentification1Code { get; init; } 
    #else
    public ExternalAuthorityIdentification1Code ExternalAuthorityIdentification1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy9m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Balance Sub Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBalSubTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlBalSubTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBalanceSubType1Code ExternalBalanceSubType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalBalanceSubType1Code ExternalBalanceSubType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalBalanceSubType1Code ExternalBalanceSubType1Code { get; init; } 
    #else
    public ExternalBalanceSubType1Code ExternalBalanceSubType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMEm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Balance Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBalTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlBalTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBalanceType1Code ExternalBalanceType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalBalanceType1Code ExternalBalanceType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalBalanceType1Code ExternalBalanceType1Code { get; init; } 
    #else
    public ExternalBalanceType1Code ExternalBalanceType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaJW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Bank Transaction Domain 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBkTxDomn1Cd")]
    #endif
    [IsoXmlTag("XtrnlBkTxDomn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBankTransactionDomain1Code ExternalBankTransactionDomain1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalBankTransactionDomain1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalBankTransactionDomain1Code { get; init; } 
    #else
    public string ExternalBankTransactionDomain1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzIW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Bank Transaction Family 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBkTxFmly1Cd")]
    #endif
    [IsoXmlTag("XtrnlBkTxFmly1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBankTransactionFamily1Code ExternalBankTransactionFamily1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalBankTransactionFamily1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalBankTransactionFamily1Code { get; init; } 
    #else
    public string ExternalBankTransactionFamily1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMIW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Bank Transaction Sub Family 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBkTxSubFmly1Cd")]
    #endif
    [IsoXmlTag("XtrnlBkTxSubFmly1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBankTransactionSubFamily1Code ExternalBankTransactionSubFamily1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalBankTransactionSubFamily1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalBankTransactionSubFamily1Code { get; init; } 
    #else
    public string ExternalBankTransactionSubFamily1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMB2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Billing Balance Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBllgBalTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlBllgBalTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBillingBalanceType1Code ExternalBillingBalanceType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalBillingBalanceType1Code ExternalBillingBalanceType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalBillingBalanceType1Code ExternalBillingBalanceType1Code { get; init; } 
    #else
    public ExternalBillingBalanceType1Code ExternalBillingBalanceType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy3W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Billing Compensation Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBllgCompstnTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlBllgCompstnTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBillingCompensationType1Code ExternalBillingCompensationType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalBillingCompensationType1Code ExternalBillingCompensationType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalBillingCompensationType1Code ExternalBillingCompensationType1Code { get; init; } 
    #else
    public ExternalBillingCompensationType1Code ExternalBillingCompensationType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL5G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Billing Rate Identification 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBllgRateId1Cd")]
    #endif
    [IsoXmlTag("XtrnlBllgRateId1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBillingRateIdentification1Code ExternalBillingRateIdentification1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalBillingRateIdentification1Code ExternalBillingRateIdentification1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalBillingRateIdentification1Code ExternalBillingRateIdentification1Code { get; init; } 
    #else
    public ExternalBillingRateIdentification1Code ExternalBillingRateIdentification1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMG2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cancellation Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCxlRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlCxlRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCancellationReason1Code ExternalCancellationReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCancellationReason1Code ExternalCancellationReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCancellationReason1Code ExternalCancellationReason1Code { get; init; } 
    #else
    public ExternalCancellationReason1Code ExternalCancellationReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzGm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Card Transaction Category 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCardTxCtgy1Cd")]
    #endif
    [IsoXmlTag("XtrnlCardTxCtgy1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCardTransactionCategory1Code ExternalCardTransactionCategory1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalCardTransactionCategory1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalCardTransactionCategory1Code { get; init; } 
    #else
    public string ExternalCardTransactionCategory1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy6G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cash Account Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCshAcctTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlCshAcctTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCashAccountType1Code ExternalCashAccountType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCashAccountType1Code ExternalCashAccountType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCashAccountType1Code ExternalCashAccountType1Code { get; init; } 
    #else
    public ExternalCashAccountType1Code ExternalCashAccountType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy8G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cash Clearing System 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCshClrSys1Cd")]
    #endif
    [IsoXmlTag("XtrnlCshClrSys1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCashClearingSystem1Code ExternalCashClearingSystem1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCashClearingSystem1Code ExternalCashClearingSystem1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCashClearingSystem1Code ExternalCashClearingSystem1Code { get; init; } 
    #else
    public ExternalCashClearingSystem1Code ExternalCashClearingSystem1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ8W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Category Purpose 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCtgyPurp1Cd")]
    #endif
    [IsoXmlTag("XtrnlCtgyPurp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCategoryPurpose1Code ExternalCategoryPurpose1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCategoryPurpose1Code ExternalCategoryPurpose1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCategoryPurpose1Code ExternalCategoryPurpose1Code { get; init; } 
    #else
    public ExternalCategoryPurpose1Code ExternalCategoryPurpose1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy6m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Channel 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlChanl1Cd")]
    #endif
    [IsoXmlTag("XtrnlChanl1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalChannel1Code ExternalChannel1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalChannel1Code ExternalChannel1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalChannel1Code ExternalChannel1Code { get; init; } 
    #else
    public ExternalChannel1Code ExternalChannel1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzFG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Charge Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlChrgTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlChrgTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalChargeType1Code ExternalChargeType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalChargeType1Code ExternalChargeType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalChargeType1Code ExternalChargeType1Code { get; init; } 
    #else
    public ExternalChargeType1Code ExternalChargeType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy2W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cheque Agent Instruction 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlChqAgtInstr1Cd")]
    #endif
    [IsoXmlTag("XtrnlChqAgtInstr1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalChequeAgentInstruction1Code ExternalChequeAgentInstruction1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalChequeAgentInstruction1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalChequeAgentInstruction1Code { get; init; } 
    #else
    public string ExternalChequeAgentInstruction1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy5G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cheque Cancellation Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlChqCxlRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlChqCxlRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalChequeCancellationReason1Code ExternalChequeCancellationReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalChequeCancellationReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalChequeCancellationReason1Code { get; init; } 
    #else
    public string ExternalChequeCancellationReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaGm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Cheque Cancellation Status 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlChqCxlSts1Cd")]
    #endif
    [IsoXmlTag("XtrnlChqCxlSts1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalChequeCancellationStatus1Code ExternalChequeCancellationStatus1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalChequeCancellationStatus1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalChequeCancellationStatus1Code { get; init; } 
    #else
    public string ExternalChequeCancellationStatus1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy2m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Claim Non Receipt Rejection 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlClmNonRctRjctn1Cd")]
    #endif
    [IsoXmlTag("XtrnlClmNonRctRjctn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalClaimNonReceiptRejection1Code ExternalClaimNonReceiptRejection1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalClaimNonReceiptRejection1Code ExternalClaimNonReceiptRejection1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalClaimNonReceiptRejection1Code ExternalClaimNonReceiptRejection1Code { get; init; } 
    #else
    public ExternalClaimNonReceiptRejection1Code ExternalClaimNonReceiptRejection1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy-G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Clearing System Identification 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlClrSysId1Cd")]
    #endif
    [IsoXmlTag("XtrnlClrSysId1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalClearingSystemIdentification1Code ExternalClearingSystemIdentification1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalClearingSystemIdentification1Code ExternalClearingSystemIdentification1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalClearingSystemIdentification1Code ExternalClearingSystemIdentification1Code { get; init; } 
    #else
    public ExternalClearingSystemIdentification1Code ExternalClearingSystemIdentification1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMCm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Communication Format 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlComFrmt1Cd")]
    #endif
    [IsoXmlTag("XtrnlComFrmt1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCommunicationFormat1Code ExternalCommunicationFormat1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalCommunicationFormat1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalCommunicationFormat1Code { get; init; } 
    #else
    public string ExternalCommunicationFormat1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzDG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Contract Balance Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCtrctBalTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlCtrctBalTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalContractBalanceType1Code ExternalContractBalanceType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalContractBalanceType1Code ExternalContractBalanceType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalContractBalanceType1Code ExternalContractBalanceType1Code { get; init; } 
    #else
    public ExternalContractBalanceType1Code ExternalContractBalanceType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL8W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Contract Closure Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCtrctClsrRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlCtrctClsrRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalContractClosureReason1Code ExternalContractClosureReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalContractClosureReason1Code ExternalContractClosureReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalContractClosureReason1Code ExternalContractClosureReason1Code { get; init; } 
    #else
    public ExternalContractClosureReason1Code ExternalContractClosureReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaG2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Credit Line Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCdtLineTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlCdtLineTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCreditLineType1Code ExternalCreditLineType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalCreditLineType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalCreditLineType1Code { get; init; } 
    #else
    public string ExternalCreditLineType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMDG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Agent Instruction 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCdtrAgtInstr1Cd")]
    #endif
    [IsoXmlTag("XtrnlCdtrAgtInstr1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCreditorAgentInstruction1Code ExternalCreditorAgentInstruction1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCreditorAgentInstruction1Code ExternalCreditorAgentInstruction1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCreditorAgentInstruction1Code ExternalCreditorAgentInstruction1Code { get; init; } 
    #else
    public ExternalCreditorAgentInstruction1Code ExternalCreditorAgentInstruction1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ52_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Enrolment Amendment Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCdtrEnrlmntAmdmntRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlCdtrEnrlmntAmdmntRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCreditorEnrolmentAmendmentReason1Code ExternalCreditorEnrolmentAmendmentReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCreditorEnrolmentAmendmentReason1Code ExternalCreditorEnrolmentAmendmentReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCreditorEnrolmentAmendmentReason1Code ExternalCreditorEnrolmentAmendmentReason1Code { get; init; } 
    #else
    public ExternalCreditorEnrolmentAmendmentReason1Code ExternalCreditorEnrolmentAmendmentReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaBW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Enrolment Cancellation Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCdtrEnrlmntCxlRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlCdtrEnrlmntCxlRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCreditorEnrolmentCancellationReason1Code ExternalCreditorEnrolmentCancellationReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCreditorEnrolmentCancellationReason1Code ExternalCreditorEnrolmentCancellationReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCreditorEnrolmentCancellationReason1Code ExternalCreditorEnrolmentCancellationReason1Code { get; init; } 
    #else
    public ExternalCreditorEnrolmentCancellationReason1Code ExternalCreditorEnrolmentCancellationReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaDm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Creditor Enrolment Status Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCdtrEnrlmntStsRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlCdtrEnrlmntStsRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalCreditorEnrolmentStatusReason1Code ExternalCreditorEnrolmentStatusReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalCreditorEnrolmentStatusReason1Code ExternalCreditorEnrolmentStatusReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalCreditorEnrolmentStatusReason1Code ExternalCreditorEnrolmentStatusReason1Code { get; init; } 
    #else
    public ExternalCreditorEnrolmentStatusReason1Code ExternalCreditorEnrolmentStatusReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL02_HEe2g-IPZC9d7tA")]
    [DisplayName("External Date Frequency 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDtFrqcy1Cd")]
    #endif
    [IsoXmlTag("XtrnlDtFrqcy1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDateFrequency1Code ExternalDateFrequency1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDateFrequency1Code ExternalDateFrequency1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDateFrequency1Code ExternalDateFrequency1Code { get; init; } 
    #else
    public ExternalDateFrequency1Code ExternalDateFrequency1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzBG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Activation Amendment Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDbtrActvtnAmdmntRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlDbtrActvtnAmdmntRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDebtorActivationAmendmentReason1Code ExternalDebtorActivationAmendmentReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDebtorActivationAmendmentReason1Code ExternalDebtorActivationAmendmentReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDebtorActivationAmendmentReason1Code ExternalDebtorActivationAmendmentReason1Code { get; init; } 
    #else
    public ExternalDebtorActivationAmendmentReason1Code ExternalDebtorActivationAmendmentReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaH2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Activation Cancellation Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDbtrActvtnCxlRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlDbtrActvtnCxlRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDebtorActivationCancellationReason1Code ExternalDebtorActivationCancellationReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDebtorActivationCancellationReason1Code ExternalDebtorActivationCancellationReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDebtorActivationCancellationReason1Code ExternalDebtorActivationCancellationReason1Code { get; init; } 
    #else
    public ExternalDebtorActivationCancellationReason1Code ExternalDebtorActivationCancellationReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMGm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Activation Status Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDbtrActvtnStsRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlDbtrActvtnStsRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDebtorActivationStatusReason1Code ExternalDebtorActivationStatusReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDebtorActivationStatusReason1Code ExternalDebtorActivationStatusReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDebtorActivationStatusReason1Code ExternalDebtorActivationStatusReason1Code { get; init; } 
    #else
    public ExternalDebtorActivationStatusReason1Code ExternalDebtorActivationStatusReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzJG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Debtor Agent Instruction 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDbtrAgtInstr1Cd")]
    #endif
    [IsoXmlTag("XtrnlDbtrAgtInstr1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDebtorAgentInstruction1Code ExternalDebtorAgentInstruction1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalDebtorAgentInstruction1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalDebtorAgentInstruction1Code { get; init; } 
    #else
    public string ExternalDebtorAgentInstruction1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy0W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Discount Amount Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDscntAmtTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlDscntAmtTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDiscountAmountType1Code ExternalDiscountAmountType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDiscountAmountType1Code ExternalDiscountAmountType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDiscountAmountType1Code ExternalDiscountAmountType1Code { get; init; } 
    #else
    public ExternalDiscountAmountType1Code ExternalDiscountAmountType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzG2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Discrepancy 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDscrpncy1Cd")]
    #endif
    [IsoXmlTag("XtrnlDscrpncy1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDiscrepancy1Code ExternalDiscrepancy1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalDiscrepancy1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalDiscrepancy1Code { get; init; } 
    #else
    public string ExternalDiscrepancy1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ9W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Format 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDocFrmt1Cd")]
    #endif
    [IsoXmlTag("XtrnlDocFrmt1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDocumentFormat1Code ExternalDocumentFormat1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDocumentFormat1Code ExternalDocumentFormat1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDocumentFormat1Code ExternalDocumentFormat1Code { get; init; } 
    #else
    public ExternalDocumentFormat1Code ExternalDocumentFormat1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhME2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Line Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDocLineTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlDocLineTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDocumentLineType1Code ExternalDocumentLineType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDocumentLineType1Code ExternalDocumentLineType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDocumentLineType1Code ExternalDocumentLineType1Code { get; init; } 
    #else
    public ExternalDocumentLineType1Code ExternalDocumentLineType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzBW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Purpose 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDocPurp1Cd")]
    #endif
    [IsoXmlTag("XtrnlDocPurp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDocumentPurpose1Code ExternalDocumentPurpose1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDocumentPurpose1Code ExternalDocumentPurpose1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDocumentPurpose1Code ExternalDocumentPurpose1Code { get; init; } 
    #else
    public ExternalDocumentPurpose1Code ExternalDocumentPurpose1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhLzm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Document Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlDocTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlDocTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDocumentType1Code ExternalDocumentType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDocumentType1Code ExternalDocumentType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDocumentType1Code ExternalDocumentType1Code { get; init; } 
    #else
    public ExternalDocumentType1Code ExternalDocumentType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL1m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Effective Date Parameter 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlFctvDtParam1Cd")]
    #endif
    [IsoXmlTag("XtrnlFctvDtParam1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalEffectiveDateParameter1Code ExternalEffectiveDateParameter1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalEffectiveDateParameter1Code ExternalEffectiveDateParameter1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalEffectiveDateParameter1Code ExternalEffectiveDateParameter1Code { get; init; } 
    #else
    public ExternalEffectiveDateParameter1Code ExternalEffectiveDateParameter1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhLym_HEe2g-IPZC9d7tA")]
    [DisplayName("External Encrypted Element Identification 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlNcrptdElmtId1Cd")]
    #endif
    [IsoXmlTag("XtrnlNcrptdElmtId1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalEncryptedElementIdentification1Code ExternalEncryptedElementIdentification1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalEncryptedElementIdentification1Code ExternalEncryptedElementIdentification1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalEncryptedElementIdentification1Code ExternalEncryptedElementIdentification1Code { get; init; } 
    #else
    public ExternalEncryptedElementIdentification1Code ExternalEncryptedElementIdentification1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMAG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Enquiry Request Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlEnqryReqTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlEnqryReqTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalEnquiryRequestType1Code ExternalEnquiryRequestType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalEnquiryRequestType1Code ExternalEnquiryRequestType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalEnquiryRequestType1Code ExternalEnquiryRequestType1Code { get; init; } 
    #else
    public ExternalEnquiryRequestType1Code ExternalEnquiryRequestType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMBG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Entry Status 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlNtrySts1Cd")]
    #endif
    [IsoXmlTag("XtrnlNtrySts1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalEntryStatus1Code ExternalEntryStatus1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalEntryStatus1Code ExternalEntryStatus1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalEntryStatus1Code ExternalEntryStatus1Code { get; init; } 
    #else
    public ExternalEntryStatus1Code ExternalEntryStatus1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaIW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Financial Institution Identification 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlFIId1Cd")]
    #endif
    [IsoXmlTag("XtrnlFIId1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalFinancialInstitutionIdentification1Code ExternalFinancialInstitutionIdentification1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalFinancialInstitutionIdentification1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalFinancialInstitutionIdentification1Code { get; init; } 
    #else
    public string ExternalFinancialInstitutionIdentification1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaDG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Financial Instrument Identification Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlFinInstrmIdTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlFinInstrmIdTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalFinancialInstrumentIdentificationType1Code ExternalFinancialInstrumentIdentificationType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalFinancialInstrumentIdentificationType1Code ExternalFinancialInstrumentIdentificationType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalFinancialInstrumentIdentificationType1Code ExternalFinancialInstrumentIdentificationType1Code { get; init; } 
    #else
    public ExternalFinancialInstrumentIdentificationType1Code ExternalFinancialInstrumentIdentificationType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhLz2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Financial Instrument Product Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlFinInstrmPdctTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlFinInstrmPdctTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalFinancialInstrumentProductType1Code ExternalFinancialInstrumentProductType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalFinancialInstrumentProductType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalFinancialInstrumentProductType1Code { get; init; } 
    #else
    public string ExternalFinancialInstrumentProductType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzF2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Garnishment Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlGrnshmtTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlGrnshmtTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalGarnishmentType1Code ExternalGarnishmentType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalGarnishmentType1Code ExternalGarnishmentType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalGarnishmentType1Code ExternalGarnishmentType1Code { get; init; } 
    #else
    public ExternalGarnishmentType1Code ExternalGarnishmentType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL3m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Incoterms 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlIncotrms1Cd")]
    #endif
    [IsoXmlTag("XtrnlIncotrms1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalIncoterms1Code ExternalIncoterms1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalIncoterms1Code ExternalIncoterms1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalIncoterms1Code ExternalIncoterms1Code { get; init; } 
    #else
    public ExternalIncoterms1Code ExternalIncoterms1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL52_HEe2g-IPZC9d7tA")]
    [DisplayName("External Information Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlInfTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlInfTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalInformationType1Code ExternalInformationType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalInformationType1Code ExternalInformationType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalInformationType1Code ExternalInformationType1Code { get; init; } 
    #else
    public ExternalInformationType1Code ExternalInformationType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhLzW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Instructed Agent Instruction 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlInstdAgtInstr1Cd")]
    #endif
    [IsoXmlTag("XtrnlInstdAgtInstr1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalInstructedAgentInstruction1Code ExternalInstructedAgentInstruction1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalInstructedAgentInstruction1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalInstructedAgentInstruction1Code { get; init; } 
    #else
    public string ExternalInstructedAgentInstruction1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzAW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Investigation Execution Confirmation 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlInvstgtnExctnConf1Cd")]
    #endif
    [IsoXmlTag("XtrnlInvstgtnExctnConf1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalInvestigationExecutionConfirmation1Code ExternalInvestigationExecutionConfirmation1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalInvestigationExecutionConfirmation1Code ExternalInvestigationExecutionConfirmation1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalInvestigationExecutionConfirmation1Code ExternalInvestigationExecutionConfirmation1Code { get; init; } 
    #else
    public ExternalInvestigationExecutionConfirmation1Code ExternalInvestigationExecutionConfirmation1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy82_HEe2g-IPZC9d7tA")]
    [DisplayName("External Letter Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlLttrTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlLttrTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalLetterType1Code ExternalLetterType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalLetterType1Code ExternalLetterType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalLetterType1Code ExternalLetterType1Code { get; init; } 
    #else
    public ExternalLetterType1Code ExternalLetterType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL6G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Local Instrument 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlLclInstrm1Cd")]
    #endif
    [IsoXmlTag("XtrnlLclInstrm1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalLocalInstrument1Code ExternalLocalInstrument1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalLocalInstrument1Code ExternalLocalInstrument1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalLocalInstrument1Code ExternalLocalInstrument1Code { get; init; } 
    #else
    public ExternalLocalInstrument1Code ExternalLocalInstrument1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ5G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlMndtRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlMndtRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalMandateReason1Code ExternalMandateReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalMandateReason1Code ExternalMandateReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalMandateReason1Code ExternalMandateReason1Code { get; init; } 
    #else
    public ExternalMandateReason1Code ExternalMandateReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy1W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Setup Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlMndtStpRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlMndtStpRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalMandateSetupReason1Code ExternalMandateSetupReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalMandateSetupReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalMandateSetupReason1Code { get; init; } 
    #else
    public string ExternalMandateSetupReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMHG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Status 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlMndtSts1Cd")]
    #endif
    [IsoXmlTag("XtrnlMndtSts1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalMandateStatus1Code ExternalMandateStatus1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalMandateStatus1Code ExternalMandateStatus1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalMandateStatus1Code ExternalMandateStatus1Code { get; init; } 
    #else
    public ExternalMandateStatus1Code ExternalMandateStatus1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMFm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Mandate Suspension Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlMndtSspnsnRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlMndtSspnsnRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalMandateSuspensionReason1Code ExternalMandateSuspensionReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalMandateSuspensionReason1Code ExternalMandateSuspensionReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalMandateSuspensionReason1Code ExternalMandateSuspensionReason1Code { get; init; } 
    #else
    public ExternalMandateSuspensionReason1Code ExternalMandateSuspensionReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaIm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Market Area 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlMktArea1Cd")]
    #endif
    [IsoXmlTag("XtrnlMktArea1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalMarketArea1Code ExternalMarketArea1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalMarketArea1Code ExternalMarketArea1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalMarketArea1Code ExternalMarketArea1Code { get; init; } 
    #else
    public ExternalMarketArea1Code ExternalMarketArea1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy3m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Market Infrastructure 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlMktInfrstrctr1Cd")]
    #endif
    [IsoXmlTag("XtrnlMktInfrstrctr1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalMarketInfrastructure1Code ExternalMarketInfrastructure1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalMarketInfrastructure1Code ExternalMarketInfrastructure1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalMarketInfrastructure1Code ExternalMarketInfrastructure1Code { get; init; } 
    #else
    public ExternalMarketInfrastructure1Code ExternalMarketInfrastructure1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzD2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Model Form Identification 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlMdlFormId1Cd")]
    #endif
    [IsoXmlTag("XtrnlMdlFormId1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalModelFormIdentification1Code ExternalModelFormIdentification1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalModelFormIdentification1Code ExternalModelFormIdentification1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalModelFormIdentification1Code ExternalModelFormIdentification1Code { get; init; } 
    #else
    public ExternalModelFormIdentification1Code ExternalModelFormIdentification1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ_W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Narrative Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlNrrtvTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlNrrtvTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalNarrativeType1Code ExternalNarrativeType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalNarrativeType1Code ExternalNarrativeType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalNarrativeType1Code ExternalNarrativeType1Code { get; init; } 
    #else
    public ExternalNarrativeType1Code ExternalNarrativeType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzDm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Notification Cancellation Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlNtfctnCxlRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlNtfctnCxlRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalNotificationCancellationReason1Code ExternalNotificationCancellationReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalNotificationCancellationReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalNotificationCancellationReason1Code { get; init; } 
    #else
    public string ExternalNotificationCancellationReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy8W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Organisation Identification 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlOrgId1Cd")]
    #endif
    [IsoXmlTag("XtrnlOrgId1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalOrganisationIdentification1Code ExternalOrganisationIdentification1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalOrganisationIdentification1Code ExternalOrganisationIdentification1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalOrganisationIdentification1Code ExternalOrganisationIdentification1Code { get; init; } 
    #else
    public ExternalOrganisationIdentification1Code ExternalOrganisationIdentification1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaKG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Packaging Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPackgngTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlPackgngTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPackagingType1Code ExternalPackagingType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPackagingType1Code ExternalPackagingType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPackagingType1Code ExternalPackagingType1Code { get; init; } 
    #else
    public ExternalPackagingType1Code ExternalPackagingType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaHG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Cancellation Rejection 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtCxlRjctn1Cd")]
    #endif
    [IsoXmlTag("XtrnlPmtCxlRjctn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentCancellationRejection1Code ExternalPaymentCancellationRejection1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentCancellationRejection1Code ExternalPaymentCancellationRejection1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentCancellationRejection1Code ExternalPaymentCancellationRejection1Code { get; init; } 
    #else
    public ExternalPaymentCancellationRejection1Code ExternalPaymentCancellationRejection1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaKW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Compensation Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtCompstnRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlPmtCompstnRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentCompensationReason1Code ExternalPaymentCompensationReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentCompensationReason1Code ExternalPaymentCompensationReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentCompensationReason1Code ExternalPaymentCompensationReason1Code { get; init; } 
    #else
    public ExternalPaymentCompensationReason1Code ExternalPaymentCompensationReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy52_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Control Request Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtCtrlReqTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlPmtCtrlReqTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentControlRequestType1Code ExternalPaymentControlRequestType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentControlRequestType1Code ExternalPaymentControlRequestType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentControlRequestType1Code ExternalPaymentControlRequestType1Code { get; init; } 
    #else
    public ExternalPaymentControlRequestType1Code ExternalPaymentControlRequestType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaMG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Group Status 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtGrpSts1Cd")]
    #endif
    [IsoXmlTag("XtrnlPmtGrpSts1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentGroupStatus1Code ExternalPaymentGroupStatus1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentGroupStatus1Code ExternalPaymentGroupStatus1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentGroupStatus1Code ExternalPaymentGroupStatus1Code { get; init; } 
    #else
    public ExternalPaymentGroupStatus1Code ExternalPaymentGroupStatus1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhLyG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Modification Rejection 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtModRjctn1Cd")]
    #endif
    [IsoXmlTag("XtrnlPmtModRjctn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentModificationRejection1Code ExternalPaymentModificationRejection1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentModificationRejection1Code ExternalPaymentModificationRejection1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentModificationRejection1Code ExternalPaymentModificationRejection1Code { get; init; } 
    #else
    public ExternalPaymentModificationRejection1Code ExternalPaymentModificationRejection1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ_m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Role 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtRole1Cd")]
    #endif
    [IsoXmlTag("XtrnlPmtRole1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentRole1Code ExternalPaymentRole1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentRole1Code ExternalPaymentRole1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentRole1Code ExternalPaymentRole1Code { get; init; } 
    #else
    public ExternalPaymentRole1Code ExternalPaymentRole1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzC2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Payment Transaction Status 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtTxSts1Cd")]
    #endif
    [IsoXmlTag("XtrnlPmtTxSts1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentTransactionStatus1Code ExternalPaymentTransactionStatus1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentTransactionStatus1Code ExternalPaymentTransactionStatus1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentTransactionStatus1Code ExternalPaymentTransactionStatus1Code { get; init; } 
    #else
    public ExternalPaymentTransactionStatus1Code ExternalPaymentTransactionStatus1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ8m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Pending Processing Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPdgPrcgRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlPdgPrcgRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPendingProcessingReason1Code ExternalPendingProcessingReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPendingProcessingReason1Code ExternalPendingProcessingReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPendingProcessingReason1Code ExternalPendingProcessingReason1Code { get; init; } 
    #else
    public ExternalPendingProcessingReason1Code ExternalPendingProcessingReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaBG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Person Identification 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPrsnId1Cd")]
    #endif
    [IsoXmlTag("XtrnlPrsnId1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPersonIdentification1Code ExternalPersonIdentification1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPersonIdentification1Code ExternalPersonIdentification1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPersonIdentification1Code ExternalPersonIdentification1Code { get; init; } 
    #else
    public ExternalPersonIdentification1Code ExternalPersonIdentification1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhLwG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Proxy Account Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPrxyAcctTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlPrxyAcctTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalProxyAccountType1Code ExternalProxyAccountType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalProxyAccountType1Code ExternalProxyAccountType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalProxyAccountType1Code ExternalProxyAccountType1Code { get; init; } 
    #else
    public ExternalProxyAccountType1Code ExternalProxyAccountType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMDm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Purpose 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPurp1Cd")]
    #endif
    [IsoXmlTag("XtrnlPurp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPurpose1Code ExternalPurpose1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPurpose1Code ExternalPurpose1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPurpose1Code ExternalPurpose1Code { get; init; } 
    #else
    public ExternalPurpose1Code ExternalPurpose1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzGG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Rates And Tenors 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRatesAndTnrs1Cd")]
    #endif
    [IsoXmlTag("XtrnlRatesAndTnrs1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalRatesAndTenors1Code ExternalRatesAndTenors1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalRatesAndTenors1Code ExternalRatesAndTenors1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalRatesAndTenors1Code ExternalRatesAndTenors1Code { get; init; } 
    #else
    public ExternalRatesAndTenors1Code ExternalRatesAndTenors1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaB2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Received Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRcvdRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlRcvdRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalReceivedReason1Code ExternalReceivedReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalReceivedReason1Code ExternalReceivedReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalReceivedReason1Code ExternalReceivedReason1Code { get; init; } 
    #else
    public ExternalReceivedReason1Code ExternalReceivedReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy-m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Rejected Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRjctdRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlRjctdRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalRejectedReason1Code ExternalRejectedReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalRejectedReason1Code ExternalRejectedReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalRejectedReason1Code ExternalRejectedReason1Code { get; init; } 
    #else
    public ExternalRejectedReason1Code ExternalRejectedReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaDW_HEe2g-IPZC9d7tA")]
    [DisplayName("External Relative To 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRltvTo1Cd")]
    #endif
    [IsoXmlTag("XtrnlRltvTo1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalRelativeTo1Code ExternalRelativeTo1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalRelativeTo1Code ExternalRelativeTo1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalRelativeTo1Code ExternalRelativeTo1Code { get; init; } 
    #else
    public ExternalRelativeTo1Code ExternalRelativeTo1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaCm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Reporting Source 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRptgSrc1Cd")]
    #endif
    [IsoXmlTag("XtrnlRptgSrc1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalReportingSource1Code ExternalReportingSource1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalReportingSource1Code ExternalReportingSource1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalReportingSource1Code ExternalReportingSource1Code { get; init; } 
    #else
    public ExternalReportingSource1Code ExternalReportingSource1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaFm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Re Presentment Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRePresntmntRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlRePresntmntRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalRePresentmentReason1Code ExternalRePresentmentReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalRePresentmentReason1Code ExternalRePresentmentReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalRePresentmentReason1Code ExternalRePresentmentReason1Code { get; init; } 
    #else
    public ExternalRePresentmentReason1Code ExternalRePresentmentReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ-G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Reservation Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRsvatnTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlRsvatnTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalReservationType1Code ExternalReservationType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalReservationType1Code ExternalReservationType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalReservationType1Code ExternalReservationType1Code { get; init; } 
    #else
    public ExternalReservationType1Code ExternalReservationType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy12_HEe2g-IPZC9d7tA")]
    [DisplayName("External Return Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRtrRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlRtrRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalReturnReason1Code ExternalReturnReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalReturnReason1Code ExternalReturnReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalReturnReason1Code ExternalReturnReason1Code { get; init; } 
    #else
    public ExternalReturnReason1Code ExternalReturnReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaLm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Reversal Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRvslRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlRvslRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalReversalReason1Code ExternalReversalReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalReversalReason1Code ExternalReversalReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalReversalReason1Code ExternalReversalReason1Code { get; init; } 
    #else
    public ExternalReversalReason1Code ExternalReversalReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaF2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Securities Lending Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSctiesLndgTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlSctiesLndgTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalSecuritiesLendingType1Code ExternalSecuritiesLendingType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalSecuritiesLendingType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalSecuritiesLendingType1Code { get; init; } 
    #else
    public string ExternalSecuritiesLendingType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ72_HEe2g-IPZC9d7tA")]
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
    [IsoId("_4Nhy4m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Securities Update Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSctiesUpdRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlSctiesUpdRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalSecuritiesUpdateReason1Code ExternalSecuritiesUpdateReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalSecuritiesUpdateReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalSecuritiesUpdateReason1Code { get; init; } 
    #else
    public string ExternalSecuritiesUpdateReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaK2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Service Level 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSvcLvl1Cd")]
    #endif
    [IsoXmlTag("XtrnlSvcLvl1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalServiceLevel1Code ExternalServiceLevel1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalServiceLevel1Code ExternalServiceLevel1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalServiceLevel1Code ExternalServiceLevel1Code { get; init; } 
    #else
    public ExternalServiceLevel1Code ExternalServiceLevel1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMGG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Shipment Condition 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlShipmntCond1Cd")]
    #endif
    [IsoXmlTag("XtrnlShipmntCond1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalShipmentCondition1Code ExternalShipmentCondition1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalShipmentCondition1Code ExternalShipmentCondition1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalShipmentCondition1Code ExternalShipmentCondition1Code { get; init; } 
    #else
    public ExternalShipmentCondition1Code ExternalShipmentCondition1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhL9m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Status Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlStsRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlStsRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalStatusReason1Code ExternalStatusReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalStatusReason1Code ExternalStatusReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalStatusReason1Code ExternalStatusReason1Code { get; init; } 
    #else
    public ExternalStatusReason1Code ExternalStatusReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy7m_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Balance Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSysBalTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlSysBalTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalSystemBalanceType1Code ExternalSystemBalanceType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalSystemBalanceType1Code ExternalSystemBalanceType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalSystemBalanceType1Code ExternalSystemBalanceType1Code { get; init; } 
    #else
    public ExternalSystemBalanceType1Code ExternalSystemBalanceType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ7G_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Error Handling 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSysErrHdlg1Cd")]
    #endif
    [IsoXmlTag("XtrnlSysErrHdlg1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalSystemErrorHandling1Code ExternalSystemErrorHandling1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalSystemErrorHandling1Code ExternalSystemErrorHandling1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalSystemErrorHandling1Code ExternalSystemErrorHandling1Code { get; init; } 
    #else
    public ExternalSystemErrorHandling1Code ExternalSystemErrorHandling1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMAm_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Event Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSysEvtTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlSysEvtTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalSystemEventType1Code ExternalSystemEventType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalSystemEventType1Code ExternalSystemEventType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalSystemEventType1Code ExternalSystemEventType1Code { get; init; } 
    #else
    public ExternalSystemEventType1Code ExternalSystemEventType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzCG_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Member Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSysMmbTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlSysMmbTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalSystemMemberType1Code ExternalSystemMemberType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalSystemMemberType1Code ExternalSystemMemberType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalSystemMemberType1Code ExternalSystemMemberType1Code { get; init; } 
    #else
    public ExternalSystemMemberType1Code ExternalSystemMemberType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy3G_HEe2g-IPZC9d7tA")]
    [DisplayName("External System Party Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlSysPtyTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlSysPtyTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalSystemPartyType1Code ExternalSystemPartyType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalSystemPartyType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalSystemPartyType1Code { get; init; } 
    #else
    public string ExternalSystemPartyType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMA2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Tax Amount Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlTaxAmtTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlTaxAmtTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalTaxAmountType1Code ExternalTaxAmountType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalTaxAmountType1Code ExternalTaxAmountType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalTaxAmountType1Code ExternalTaxAmountType1Code { get; init; } 
    #else
    public ExternalTaxAmountType1Code ExternalTaxAmountType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzA2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Technical Input Channel 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlTechInptChanl1Cd")]
    #endif
    [IsoXmlTag("XtrnlTechInptChanl1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalTechnicalInputChannel1Code ExternalTechnicalInputChannel1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalTechnicalInputChannel1Code ExternalTechnicalInputChannel1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalTechnicalInputChannel1Code ExternalTechnicalInputChannel1Code { get; init; } 
    #else
    public ExternalTechnicalInputChannel1Code ExternalTechnicalInputChannel1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy02_HEe2g-IPZC9d7tA")]
    [DisplayName("External Trade Market 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlTradMkt1Cd")]
    #endif
    [IsoXmlTag("XtrnlTradMkt1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalTradeMarket1Code ExternalTradeMarket1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalTradeMarket1Code ExternalTradeMarket1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalTradeMarket1Code ExternalTradeMarket1Code { get; init; } 
    #else
    public ExternalTradeMarket1Code ExternalTradeMarket1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhMEG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Trade Transaction Condition 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlTradTxCond1Cd")]
    #endif
    [IsoXmlTag("XtrnlTradTxCond1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalTradeTransactionCondition1Code ExternalTradeTransactionCondition1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalTradeTransactionCondition1Code ExternalTradeTransactionCondition1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalTradeTransactionCondition1Code ExternalTradeTransactionCondition1Code { get; init; } 
    #else
    public ExternalTradeTransactionCondition1Code ExternalTradeTransactionCondition1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzI2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Type Of Party 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlTpOfPty1Cd")]
    #endif
    [IsoXmlTag("XtrnlTpOfPty1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalTypeOfParty1Code ExternalTypeOfParty1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalTypeOfParty1Code ExternalTypeOfParty1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalTypeOfParty1Code ExternalTypeOfParty1Code { get; init; } 
    #else
    public ExternalTypeOfParty1Code ExternalTypeOfParty1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NhzFm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Unable To Apply Incorrect Data 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUblToApplyIncrrctData1Cd")]
    #endif
    [IsoXmlTag("XtrnlUblToApplyIncrrctData1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUnableToApplyIncorrectData1Code ExternalUnableToApplyIncorrectData1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUnableToApplyIncorrectData1Code ExternalUnableToApplyIncorrectData1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUnableToApplyIncorrectData1Code ExternalUnableToApplyIncorrectData1Code { get; init; } 
    #else
    public ExternalUnableToApplyIncorrectData1Code ExternalUnableToApplyIncorrectData1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy9G_HEe2g-IPZC9d7tA")]
    [DisplayName("External Unable To Apply Missing Data 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUblToApplyMssngData1Cd")]
    #endif
    [IsoXmlTag("XtrnlUblToApplyMssngData1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUnableToApplyMissingData1Code ExternalUnableToApplyMissingData1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUnableToApplyMissingData1Code ExternalUnableToApplyMissingData1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUnableToApplyMissingData1Code ExternalUnableToApplyMissingData1Code { get; init; } 
    #else
    public ExternalUnableToApplyMissingData1Code ExternalUnableToApplyMissingData1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ-W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Underlying Trade Transaction Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUndrlygTradTxTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlUndrlygTradTxTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUnderlyingTradeTransactionType1Code ExternalUnderlyingTradeTransactionType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUnderlyingTradeTransactionType1Code ExternalUnderlyingTradeTransactionType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUnderlyingTradeTransactionType1Code ExternalUnderlyingTradeTransactionType1Code { get; init; } 
    #else
    public ExternalUnderlyingTradeTransactionType1Code ExternalUnderlyingTradeTransactionType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy8m_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Amount Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUdrtkgAmtTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlUdrtkgAmtTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUndertakingAmountType1Code ExternalUndertakingAmountType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUndertakingAmountType1Code ExternalUndertakingAmountType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUndertakingAmountType1Code ExternalUndertakingAmountType1Code { get; init; } 
    #else
    public ExternalUndertakingAmountType1Code ExternalUndertakingAmountType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaIG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Charge Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUdrtkgChrgTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlUdrtkgChrgTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUndertakingChargeType1Code ExternalUndertakingChargeType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUndertakingChargeType1Code ExternalUndertakingChargeType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUndertakingChargeType1Code ExternalUndertakingChargeType1Code { get; init; } 
    #else
    public ExternalUndertakingChargeType1Code ExternalUndertakingChargeType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiZ7W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Document Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUdrtkgDocTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlUdrtkgDocTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUndertakingDocumentType1Code ExternalUndertakingDocumentType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUndertakingDocumentType1Code ExternalUndertakingDocumentType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUndertakingDocumentType1Code ExternalUndertakingDocumentType1Code { get; init; } 
    #else
    public ExternalUndertakingDocumentType1Code ExternalUndertakingDocumentType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaCG_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Status Category 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUdrtkgStsCtgy1Cd")]
    #endif
    [IsoXmlTag("XtrnlUdrtkgStsCtgy1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUndertakingStatusCategory1Code ExternalUndertakingStatusCategory1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUndertakingStatusCategory1Code ExternalUndertakingStatusCategory1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUndertakingStatusCategory1Code ExternalUndertakingStatusCategory1Code { get; init; } 
    #else
    public ExternalUndertakingStatusCategory1Code ExternalUndertakingStatusCategory1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaE2_HEe2g-IPZC9d7tA")]
    [DisplayName("External Undertaking Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUdrtkgTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlUdrtkgTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUndertakingType1Code ExternalUndertakingType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUndertakingType1Code ExternalUndertakingType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUndertakingType1Code ExternalUndertakingType1Code { get; init; } 
    #else
    public ExternalUndertakingType1Code ExternalUndertakingType1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4NiaAm_HEe2g-IPZC9d7tA")]
    [DisplayName("External Validation Rule Identification 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlVldtnRuleId1Cd")]
    #endif
    [IsoXmlTag("XtrnlVldtnRuleId1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalValidationRuleIdentification1Code ExternalValidationRuleIdentification1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalValidationRuleIdentification1Code ExternalValidationRuleIdentification1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalValidationRuleIdentification1Code ExternalValidationRuleIdentification1Code { get; init; } 
    #else
    public ExternalValidationRuleIdentification1Code ExternalValidationRuleIdentification1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_4Nhy_W_HEe2g-IPZC9d7tA")]
    [DisplayName("External Verification Reason 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlVrfctnRsn1Cd")]
    #endif
    [IsoXmlTag("XtrnlVrfctnRsn1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalVerificationReason1Code ExternalVerificationReason1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalVerificationReason1Code ExternalVerificationReason1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalVerificationReason1Code ExternalVerificationReason1Code { get; init; } 
    #else
    public ExternalVerificationReason1Code ExternalVerificationReason1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_uYEBU3C-Ee2QDe42vpiOiA")]
    [DisplayName("External Benchmark Curve Name 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlBchmkCrvNm1Cd")]
    #endif
    [IsoXmlTag("XtrnlBchmkCrvNm1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBenchmarkCurveName1Code ExternalBenchmarkCurveName1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalBenchmarkCurveName1Code ExternalBenchmarkCurveName1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalBenchmarkCurveName1Code ExternalBenchmarkCurveName1Code { get; init; } 
    #else
    public ExternalBenchmarkCurveName1Code ExternalBenchmarkCurveName1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_uYEBVHC-Ee2QDe42vpiOiA")]
    [DisplayName("External Unit Of Measure 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlUnitOfMeasr1Cd")]
    #endif
    [IsoXmlTag("XtrnlUnitOfMeasr1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUnitOfMeasure1Code ExternalUnitOfMeasure1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUnitOfMeasure1Code ExternalUnitOfMeasure1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUnitOfMeasure1Code ExternalUnitOfMeasure1Code { get; init; } 
    #else
    public ExternalUnitOfMeasure1Code ExternalUnitOfMeasure1Code { get; set; } 
    #endif
    
    /// <summary>
    /// </summary>
    [IsoId("_uYNyUHC-Ee2QDe42vpiOiA")]
    [DisplayName("External Party Relationship Type 1 Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPtyRltshTp1Cd")]
    #endif
    [IsoXmlTag("XtrnlPtyRltshTp1Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPartyRelationshipType1Code ExternalPartyRelationshipType1Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ExternalPartyRelationshipType1Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ExternalPartyRelationshipType1Code { get; init; } 
    #else
    public string ExternalPartyRelationshipType1Code { get; set; } 
    #endif
    
    
    #nullable disable
    
}
