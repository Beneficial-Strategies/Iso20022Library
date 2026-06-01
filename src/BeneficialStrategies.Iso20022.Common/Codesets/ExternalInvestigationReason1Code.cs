// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigation reason, as published in an external investigation reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7kAjkFEUEe2YkcF60skG_A")]
[Description(
    @"Specifies the investigation reason, as published in an external investigation reason code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalInvestigationReasonCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationReason1Code>))]
public enum ExternalInvestigationReason1Code
{
    /// <summary>
    /// Investigation relating to an account.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("___asGdYUEe68t8Cw380-tA")]
    [Description(@"Investigation relating to an account.")]
    AccountRelatedInvestigation = ExternalInvestigationReasonCode.AccountRelatedInvestigation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request message relates to anti-money laundering.
    /// Encoded/decoded by serializers as &quot;AMLI&quot;.
    /// </summary>
    [EnumMember(Value = "AMLI")]
    [IsoId("___ar99YUEe68t8Cw380-tA")]
    [Description(@"Request message relates to anti-money laundering.")]
    AntiMoneyLaundering = ExternalInvestigationReasonCode.AntiMoneyLaundering, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An amount element has triggered the investigation.
    /// Encoded/decoded by serializers as &quot;AMNT&quot;.
    /// </summary>
    [EnumMember(Value = "AMNT")]
    [IsoId("___Q7R9YUEe68t8Cw380-tA")]
    [Description(@"An amount element has triggered the investigation.")]
    Amount = ExternalInvestigationReasonCode.Amount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment type category purpose is incorrect, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;CAPU&quot;.
    /// </summary>
    [EnumMember(Value = "CAPU")]
    [IsoId("___Q7P9YUEe68t8Cw380-tA")]
    [Description(@"Payment type category purpose is incorrect, incomplete or missing.")]
    CategoryPurpose = ExternalInvestigationReasonCode.CategoryPurpose, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Creditor claims non-receipt of payment.
    /// Encoded/decoded by serializers as &quot;CCNR&quot;.
    /// </summary>
    [EnumMember(Value = "CCNR")]
    [IsoId("___asDdYUEe68t8Cw380-tA")]
    [Description(@"Creditor claims non-receipt of payment.")]
    CreditorClaimNonReceipt = ExternalInvestigationReasonCode.CreditorClaimNonReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the charge bearer is requested.
    /// Encoded/decoded by serializers as &quot;CHBE&quot;.
    /// </summary>
    [EnumMember(Value = "CHBE")]
    [IsoId("___Q7X9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the charge bearer is requested.")]
    ChargeBearer = ExternalInvestigationReasonCode.ChargeBearer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Copy of cheque is requested.
    /// Encoded/decoded by serializers as &quot;CHCO&quot;.
    /// </summary>
    [EnumMember(Value = "CHCO")]
    [IsoId("___ar89YUEe68t8Cw380-tA")]
    [Description(@"Copy of cheque is requested.")]
    RequestChequeCopy = ExternalInvestigationReasonCode.RequestChequeCopy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the charges information is requested.
    /// Encoded/decoded by serializers as &quot;CHIN&quot;.
    /// </summary>
    [EnumMember(Value = "CHIN")]
    [IsoId("___Q7adYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the charges information is requested.")]
    ChargesInformation = ExternalInvestigationReasonCode.ChargesInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque not yet paid despite being sent to agent.
    /// Encoded/decoded by serializers as &quot;CHNP&quot;.
    /// </summary>
    [EnumMember(Value = "CHNP")]
    [IsoId("___asBdYUEe68t8Cw380-tA")]
    [Description(@"Cheque not yet paid despite being sent to agent.")]
    ChequeNotYetPaid = ExternalInvestigationReasonCode.ChequeNotYetPaid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Creditor agent claims non-receipt of cover or settlement.
    /// Encoded/decoded by serializers as &quot;CONR&quot;.
    /// </summary>
    [EnumMember(Value = "CONR")]
    [IsoId("___asD9YUEe68t8Cw380-tA")]
    [Description(@"Creditor agent claims non-receipt of cover or settlement.")]
    CreditorAgentClaimCoverNonReceipt = ExternalInvestigationReasonCode.CreditorAgentClaimCoverNonReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the creditor agent is requested.
    /// Encoded/decoded by serializers as &quot;CTAG&quot;.
    /// </summary>
    [EnumMember(Value = "CTAG")]
    [IsoId("___Q7V9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the creditor agent is requested.")]
    CreditorAgent = ExternalInvestigationReasonCode.CreditorAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the creditor is requested.
    /// Encoded/decoded by serializers as &quot;CTOR&quot;.
    /// </summary>
    [EnumMember(Value = "CTOR")]
    [IsoId("___Q7WdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the creditor is requested.")]
    Creditor = ExternalInvestigationReasonCode.Creditor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Copy of draft is requested.
    /// Encoded/decoded by serializers as &quot;DRCO&quot;.
    /// </summary>
    [EnumMember(Value = "DRCO")]
    [IsoId("___ar9dYUEe68t8Cw380-tA")]
    [Description(@"Copy of draft is requested.")]
    RequestDraftCopy = ExternalInvestigationReasonCode.RequestDraftCopy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the debtor agent is requested.
    /// Encoded/decoded by serializers as &quot;DTAG&quot;.
    /// </summary>
    [EnumMember(Value = "DTAG")]
    [IsoId("___Q7S9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the debtor agent is requested.")]
    DebtorAgent = ExternalInvestigationReasonCode.DebtorAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the debtor is requested.
    /// Encoded/decoded by serializers as &quot;DTOR&quot;.
    /// </summary>
    [EnumMember(Value = "DTOR")]
    [IsoId("___Q7SdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the debtor is requested.")]
    Debtor = ExternalInvestigationReasonCode.Debtor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation relates to financial crimes compliance.
    /// Encoded/decoded by serializers as &quot;FCCI&quot;.
    /// </summary>
    [EnumMember(Value = "FCCI")]
    [IsoId("___Q7edYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to financial crimes compliance.")]
    FinancialCrimeCompliance = ExternalInvestigationReasonCode.FinancialCrimeCompliance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instrument is confirmed as fraudulent.
    /// Encoded/decoded by serializers as &quot;FRAD&quot;.
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("___Q7d9YUEe68t8Cw380-tA")]
    [Description(@"Instrument is confirmed as fraudulent.")]
    FraudulentInstrument = ExternalInvestigationReasonCode.FraudulentInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation relates to funds transfer regulation or wire transfer regulation.
    /// Encoded/decoded by serializers as &quot;FWTR&quot;.
    /// </summary>
    [EnumMember(Value = "FWTR")]
    [IsoId("___ar8dYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to funds transfer regulation or wire transfer regulation.")]
    FundsTransferRegulationOrWireTransferRegulation = ExternalInvestigationReasonCode.FundsTransferRegulationOrWireTransferRegulation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Incorrect accrued interest balance.
    /// Encoded/decoded by serializers as &quot;IAIB&quot;.
    /// </summary>
    [EnumMember(Value = "IAIB")]
    [IsoId("_U4afQ_XXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect accrued interest balance.")]
    IncorrectAccruedInterest = ExternalInvestigationReasonCode.IncorrectAccruedInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Incorrect daily accrued interest amount.
    /// Encoded/decoded by serializers as &quot;IDAI&quot;.
    /// </summary>
    [EnumMember(Value = "IDAI")]
    [IsoId("_U4afRfXXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect daily accrued interest amount.")]
    IncorrectDailyAccruedInterest = ExternalInvestigationReasonCode.IncorrectDailyAccruedInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the instructed reimbursement agent is requested.
    /// Encoded/decoded by serializers as &quot;IDRA&quot;.
    /// </summary>
    [EnumMember(Value = "IDRA")]
    [IsoId("___Q7T9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instructed reimbursement agent is requested.")]
    InstructedReimbursementAgent = ExternalInvestigationReasonCode.InstructedReimbursementAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the instructing reimbursement agent is requested.
    /// Encoded/decoded by serializers as &quot;IGRA&quot;.
    /// </summary>
    [EnumMember(Value = "IGRA")]
    [IsoId("___Q7TdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instructing reimbursement agent is requested.")]
    InstructingReimbursementAgent = ExternalInvestigationReasonCode.InstructingReimbursementAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid interest rate.
    /// Encoded/decoded by serializers as &quot;IIRT&quot;.
    /// </summary>
    [EnumMember(Value = "IIRT")]
    [IsoId("_U4Z4NfXXEe-Ig-GynGPh9A")]
    [Description(@"Invalid interest rate.")]
    InvalidInterestRateType = ExternalInvestigationReasonCode.InvalidInterestRateType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to an intermediary agent is requested.
    /// Encoded/decoded by serializers as &quot;INAG&quot;.
    /// </summary>
    [EnumMember(Value = "INAG")]
    [IsoId("___Q7U9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to an intermediary agent is requested.")]
    IntermediaryAgent = ExternalInvestigationReasonCode.IntermediaryAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the instruction for creditor agent is requested.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("___Q7Y9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instruction for creditor agent is requested.")]
    InstructionForCreditorAgent = ExternalInvestigationReasonCode.InstructionForCreditorAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Incorrect closing balance.
    /// Encoded/decoded by serializers as &quot;INCB&quot;.
    /// </summary>
    [EnumMember(Value = "INCB")]
    [IsoId("_U4afQfXXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect closing balance.")]
    IncorrectClosingBalance = ExternalInvestigationReasonCode.IncorrectClosingBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the instruction for next agent is requested.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("___Q7YdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instruction for next agent is requested.")]
    InstructionForNextAgent = ExternalInvestigationReasonCode.InstructionForNextAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the initiating party is requested.
    /// Encoded/decoded by serializers as &quot;INPA&quot;.
    /// </summary>
    [EnumMember(Value = "INPA")]
    [IsoId("___Q7cdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the initiating party is requested.")]
    InitiatingParty = ExternalInvestigationReasonCode.InitiatingParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Incorrect transaction amount.
    /// Encoded/decoded by serializers as &quot;INTA&quot;.
    /// </summary>
    [EnumMember(Value = "INTA")]
    [IsoId("_U4afR_XXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect transaction amount.")]
    IncorrectTransactionAmount = ExternalInvestigationReasonCode.IncorrectTransactionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interbank settlement amount is incorrect.
    /// Encoded/decoded by serializers as &quot;ISAM&quot;.
    /// </summary>
    [EnumMember(Value = "ISAM")]
    [IsoId("___Q7RdYUEe68t8Cw380-tA")]
    [Description(@"Interbank settlement amount is incorrect.")]
    InterbankSettlementAmount = ExternalInvestigationReasonCode.InterbankSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interbank settlement date is incorrect.
    /// Encoded/decoded by serializers as &quot;ISDT&quot;.
    /// </summary>
    [EnumMember(Value = "ISDT")]
    [IsoId("___Q7Q9YUEe68t8Cw380-tA")]
    [Description(@"Interbank settlement date is incorrect.")]
    InterbankSettlementDate = ExternalInvestigationReasonCode.InterbankSettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Missing credit amount on statement.
    /// Encoded/decoded by serializers as &quot;MCAT&quot;.
    /// </summary>
    [EnumMember(Value = "MCAT")]
    [IsoId("_U4Z4MfXXEe-Ig-GynGPh9A")]
    [Description(@"Missing credit amount on statement.")]
    MissingCreditAmount = ExternalInvestigationReasonCode.MissingCreditAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Missing debit amount on statement.
    /// Encoded/decoded by serializers as &quot;MDAT&quot;.
    /// </summary>
    [EnumMember(Value = "MDAT")]
    [IsoId("_U4Z4M_XXEe-Ig-GynGPh9A")]
    [Description(@"Missing debit amount on statement.")]
    MissingDebitAmount = ExternalInvestigationReasonCode.MissingDebitAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// See AdditionalRequestData element for additional information
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("___asB9YUEe68t8Cw380-tA")]
    [Description(@"See AdditionalRequestData element for additional information")]
    Narrative = ExternalInvestigationReasonCode.Narrative, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment initiation has not been settled or confirmed.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("___asEdYUEe68t8Cw380-tA")]
    [Description(@"Payment initiation has not been settled or confirmed.")]
    PaymentInitiationNotConfirmed = ExternalInvestigationReasonCode.PaymentInitiationNotConfirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the purpose is requested.
    /// Encoded/decoded by serializers as &quot;PURP&quot;.
    /// </summary>
    [EnumMember(Value = "PURP")]
    [IsoId("___Q7b9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the purpose is requested.")]
    Purpose = ExternalInvestigationReasonCode.Purpose, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment type clearing channel is incorrect, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;PYCC&quot;.
    /// </summary>
    [EnumMember(Value = "PYCC")]
    [IsoId("___Q7VdYUEe68t8Cw380-tA")]
    [Description(@"Payment type clearing channel is incorrect, incomplete or missing.")]
    PaymentClearingChannel = ExternalInvestigationReasonCode.PaymentClearingChannel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction payment purpose is incorrect, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;PYPU&quot;.
    /// </summary>
    [EnumMember(Value = "PYPU")]
    [IsoId("___Q7XdYUEe68t8Cw380-tA")]
    [Description(@"Transaction payment purpose is incorrect, incomplete or missing.")]
    PaymentPurpose = ExternalInvestigationReasonCode.PaymentPurpose, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested execution date is incorrect or missing.
    /// Encoded/decoded by serializers as &quot;REDT&quot;.
    /// </summary>
    [EnumMember(Value = "REDT")]
    [IsoId("___Q7QdYUEe68t8Cw380-tA")]
    [Description(@"Requested execution date is incorrect or missing.")]
    RequestedExecutionDate = ExternalInvestigationReasonCode.RequestedExecutionDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Regulatory reporting is incomplete or missing.
    /// Encoded/decoded by serializers as &quot;REGR&quot;.
    /// </summary>
    [EnumMember(Value = "REGR")]
    [IsoId("___Q7c9YUEe68t8Cw380-tA")]
    [Description(@"Regulatory reporting is incomplete or missing.")]
    RegulatoryReporting = ExternalInvestigationReasonCode.RegulatoryReporting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Remittance information is incorrect, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;REIN&quot;.
    /// </summary>
    [EnumMember(Value = "REIN")]
    [IsoId("___Q7W9YUEe68t8Cw380-tA")]
    [Description(@"Remittance information is incorrect, incomplete or missing.")]
    RemittanceInformation = ExternalInvestigationReasonCode.RemittanceInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Related transaction reference is incorrect, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;RERE&quot;.
    /// </summary>
    [EnumMember(Value = "RERE")]
    [IsoId("___Q7O9YUEe68t8Cw380-tA")]
    [Description(@"Related transaction reference is incorrect, incomplete or missing.")]
    RelatedReference = ExternalInvestigationReasonCode.RelatedReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request from International Monetary Fund.
    /// Encoded/decoded by serializers as &quot;RIMF&quot;.
    /// </summary>
    [EnumMember(Value = "RIMF")]
    [IsoId("___asHdYUEe68t8Cw380-tA")]
    [Description(@"Request from International Monetary Fund.")]
    RequestFromIMF = ExternalInvestigationReasonCode.RequestFromIMF, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account closure date is requested.
    /// Encoded/decoded by serializers as &quot;RQCD&quot;.
    /// </summary>
    [EnumMember(Value = "RQCD")]
    [IsoId("___asCdYUEe68t8Cw380-tA")]
    [Description(@"Account closure date is requested.")]
    RequestAccountClosureDate = ExternalInvestigationReasonCode.RequestAccountClosureDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation relating to charges that have been taken or are unpaid.
    /// Encoded/decoded by serializers as &quot;RQCH&quot;.
    /// </summary>
    [EnumMember(Value = "RQCH")]
    [IsoId("___asG9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relating to charges that have been taken or are unpaid.")]
    RequestRelatedToCharges = ExternalInvestigationReasonCode.RequestRelatedToCharges, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debit authorisation on an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQDA&quot;.
    /// </summary>
    [EnumMember(Value = "RQDA")]
    [IsoId("___asF9YUEe68t8Cw380-tA")]
    [Description(@"Debit authorisation on an entry is requested.")]
    RequestDebitAuthorisation = ExternalInvestigationReasonCode.RequestDebitAuthorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Documentation relating to the transaction is requested.
    /// Encoded/decoded by serializers as &quot;RQDO&quot;.
    /// </summary>
    [EnumMember(Value = "RQDO")]
    [IsoId("___asA9YUEe68t8Cw380-tA")]
    [Description(@"Documentation relating to the transaction is requested.")]
    RequestDocumentation = ExternalInvestigationReasonCode.RequestDocumentation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Clarification over when goods or services were exchanged is requested.
    /// Encoded/decoded by serializers as &quot;RQED&quot;.
    /// </summary>
    [EnumMember(Value = "RQED")]
    [IsoId("___asAdYUEe68t8Cw380-tA")]
    [Description(@"Clarification over when goods or services were exchanged is requested.")]
    RequestServicesOrGoodsExchangeDate = ExternalInvestigationReasonCode.RequestServicesOrGoodsExchangeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Clarification over location details is requested.
    /// Encoded/decoded by serializers as &quot;RQLD&quot;.
    /// </summary>
    [EnumMember(Value = "RQLD")]
    [IsoId("___ar_dYUEe68t8Cw380-tA")]
    [Description(@"Clarification over location details is requested.")]
    RequestLocationDetails = ExternalInvestigationReasonCode.RequestLocationDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Clarification over a party relationship is requested.
    /// Encoded/decoded by serializers as &quot;RQPR&quot;.
    /// </summary>
    [EnumMember(Value = "RQPR")]
    [IsoId("___ar-dYUEe68t8Cw380-tA")]
    [Description(@"Clarification over a party relationship is requested.")]
    RequestPartyRelationship = ExternalInvestigationReasonCode.RequestPartyRelationship, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Clarification over goods or services involved is requested.
    /// Encoded/decoded by serializers as &quot;RQSG&quot;.
    /// </summary>
    [EnumMember(Value = "RQSG")]
    [IsoId("___ar_9YUEe68t8Cw380-tA")]
    [Description(@"Clarification over goods or services involved is requested.")]
    RequestServicesOrGoodsDetails = ExternalInvestigationReasonCode.RequestServicesOrGoodsDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Use of funds on an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQUF&quot;.
    /// </summary>
    [EnumMember(Value = "RQUF")]
    [IsoId("___asFdYUEe68t8Cw380-tA")]
    [Description(@"Use of funds on an entry is requested.")]
    RequestUseOfFunds = ExternalInvestigationReasonCode.RequestUseOfFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Revaluation of an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQVA&quot;.
    /// </summary>
    [EnumMember(Value = "RQVA")]
    [IsoId("___asE9YUEe68t8Cw380-tA")]
    [Description(@"Revaluation of an entry is requested.")]
    RequestValueDateAdjustment = ExternalInvestigationReasonCode.RequestValueDateAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Clarification over a vessel or aircraft is requested.
    /// Encoded/decoded by serializers as &quot;RQVD&quot;.
    /// </summary>
    [EnumMember(Value = "RQVD")]
    [IsoId("___ar-9YUEe68t8Cw380-tA")]
    [Description(@"Clarification over a vessel or aircraft is requested.")]
    RequestVesselOrAircraftDetails = ExternalInvestigationReasonCode.RequestVesselOrAircraftDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the settlement account is requested.
    /// Encoded/decoded by serializers as &quot;SEAC&quot;.
    /// </summary>
    [EnumMember(Value = "SEAC")]
    [IsoId("___Q7Z9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the settlement account is requested.")]
    SettlementAccount = ExternalInvestigationReasonCode.SettlementAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to a statement entry is requested.
    /// Encoded/decoded by serializers as &quot;STET&quot;.
    /// </summary>
    [EnumMember(Value = "STET")]
    [IsoId("___Q7ZdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to a statement entry is requested.")]
    StatementEntry = ExternalInvestigationReasonCode.StatementEntry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment type service level is incorrect, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;SVLV&quot;.
    /// </summary>
    [EnumMember(Value = "SVLV")]
    [IsoId("___Q7PdYUEe68t8Cw380-tA")]
    [Description(@"Payment type service level is incorrect, incomplete or missing.")]
    PaymentServiceLevel = ExternalInvestigationReasonCode.PaymentServiceLevel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax data is incomplete or missing.
    /// Encoded/decoded by serializers as &quot;TAXD&quot;.
    /// </summary>
    [EnumMember(Value = "TAXD")]
    [IsoId("___Q7ddYUEe68t8Cw380-tA")]
    [Description(@"Tax data is incomplete or missing.")]
    Tax = ExternalInvestigationReasonCode.Tax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the third reimbursement agent is requested.
    /// Encoded/decoded by serializers as &quot;TDRA&quot;.
    /// </summary>
    [EnumMember(Value = "TDRA")]
    [IsoId("___Q7UdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the third reimbursement agent is requested.")]
    ThirdReimbursementAgent = ExternalInvestigationReasonCode.ThirdReimbursementAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the ultimate creditor is requested.
    /// Encoded/decoded by serializers as &quot;ULTC&quot;.
    /// </summary>
    [EnumMember(Value = "ULTC")]
    [IsoId("___Q7bdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the ultimate creditor is requested.")]
    UltimateCreditor = ExternalInvestigationReasonCode.UltimateCreditor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information pertaining to the ultimate debtor is requested.
    /// Encoded/decoded by serializers as &quot;ULTD&quot;.
    /// </summary>
    [EnumMember(Value = "ULTD")]
    [IsoId("___Q7a9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the ultimate debtor is requested.")]
    UltimateDebtor = ExternalInvestigationReasonCode.UltimateDebtor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A booked entry cannot be applied by the creditor.
    /// Encoded/decoded by serializers as &quot;UTAP&quot;.
    /// </summary>
    [EnumMember(Value = "UTAP")]
    [IsoId("___asC9YUEe68t8Cw380-tA")]
    [Description(@"A booked entry cannot be applied by the creditor.")]
    UnableToApplyByCreditor = ExternalInvestigationReasonCode.UnableToApplyByCreditor, // same ordinal as derivation source for type conversions
}
