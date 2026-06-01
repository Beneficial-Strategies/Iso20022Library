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
[IsoId("_2lb_8ElBEe2sNe7Wx9q_CQ")]
[Description(
    @"Specifies the investigation reason, as published in an external investigation reason code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalInvestigationReason1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationReasonCode>))]
public enum ExternalInvestigationReasonCode
{
    /// <summary>
    /// Investigation relating to an account.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("__-hUEdYUEe68t8Cw380-tA")]
    [Description(@"Investigation relating to an account.")]
    AccountRelatedInvestigation,

    /// <summary>
    /// Request message relates to anti-money laundering.
    /// Encoded/decoded by serializers as &quot;AMLI&quot;.
    /// </summary>
    [EnumMember(Value = "AMLI")]
    [IsoId("__-YKZ9YUEe68t8Cw380-tA")]
    [Description(@"Request message relates to anti-money laundering.")]
    AntiMoneyLaundering,

    /// <summary>
    /// An amount element has triggered the investigation.
    /// Encoded/decoded by serializers as &quot;AMNT&quot;.
    /// </summary>
    [EnumMember(Value = "AMNT")]
    [IsoId("__-YKStYUEe68t8Cw380-tA")]
    [Description(@"An amount element has triggered the investigation.")]
    Amount,

    /// <summary>
    /// Payment type category purpose is incorrect, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;CAPU&quot;.
    /// </summary>
    [EnumMember(Value = "CAPU")]
    [IsoId("__-YKRtYUEe68t8Cw380-tA")]
    [Description(@"Payment type category purpose is incorrect, incomplete or missing.")]
    CategoryPurpose,

    /// <summary>
    /// Creditor claims non-receipt of payment.
    /// Encoded/decoded by serializers as &quot;CCNR&quot;.
    /// </summary>
    [EnumMember(Value = "CCNR")]
    [IsoId("__-YKctYUEe68t8Cw380-tA")]
    [Description(@"Creditor claims non-receipt of payment.")]
    CreditorClaimNonReceipt,

    /// <summary>
    /// Further information pertaining to the charge bearer is requested.
    /// Encoded/decoded by serializers as &quot;CHBE&quot;.
    /// </summary>
    [EnumMember(Value = "CHBE")]
    [IsoId("__-YKVtYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the charge bearer is requested.")]
    ChargeBearer,

    /// <summary>
    /// Copy of cheque is requested.
    /// Encoded/decoded by serializers as &quot;CHCO&quot;.
    /// </summary>
    [EnumMember(Value = "CHCO")]
    [IsoId("__-YKZdYUEe68t8Cw380-tA")]
    [Description(@"Copy of cheque is requested.")]
    RequestChequeCopy,

    /// <summary>
    /// Further information pertaining to the charges information is requested.
    /// Encoded/decoded by serializers as &quot;CHIN&quot;.
    /// </summary>
    [EnumMember(Value = "CHIN")]
    [IsoId("__-YKW9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the charges information is requested.")]
    ChargesInformation,

    /// <summary>
    /// Cheque not yet paid despite being sent to agent.
    /// Encoded/decoded by serializers as &quot;CHNP&quot;.
    /// </summary>
    [EnumMember(Value = "CHNP")]
    [IsoId("__-YKbtYUEe68t8Cw380-tA")]
    [Description(@"Cheque not yet paid despite being sent to agent.")]
    ChequeNotYetPaid,

    /// <summary>
    /// Creditor agent claims non-receipt of cover or settlement.
    /// Encoded/decoded by serializers as &quot;CONR&quot;.
    /// </summary>
    [EnumMember(Value = "CONR")]
    [IsoId("__-YKc9YUEe68t8Cw380-tA")]
    [Description(@"Creditor agent claims non-receipt of cover or settlement.")]
    CreditorAgentClaimCoverNonReceipt,

    /// <summary>
    /// Further information pertaining to the creditor agent is requested.
    /// Encoded/decoded by serializers as &quot;CTAG&quot;.
    /// </summary>
    [EnumMember(Value = "CTAG")]
    [IsoId("__-YKUtYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the creditor agent is requested.")]
    CreditorAgent,

    /// <summary>
    /// Further information pertaining to the creditor is requested.
    /// Encoded/decoded by serializers as &quot;CTOR&quot;.
    /// </summary>
    [EnumMember(Value = "CTOR")]
    [IsoId("__-YKU9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the creditor is requested.")]
    Creditor,

    /// <summary>
    /// Copy of draft is requested.
    /// Encoded/decoded by serializers as &quot;DRCO&quot;.
    /// </summary>
    [EnumMember(Value = "DRCO")]
    [IsoId("__-YKZtYUEe68t8Cw380-tA")]
    [Description(@"Copy of draft is requested.")]
    RequestDraftCopy,

    /// <summary>
    /// Further information pertaining to the debtor agent is requested.
    /// Encoded/decoded by serializers as &quot;DTAG&quot;.
    /// </summary>
    [EnumMember(Value = "DTAG")]
    [IsoId("__-YKTNYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the debtor agent is requested.")]
    DebtorAgent,

    /// <summary>
    /// Further information pertaining to the debtor is requested.
    /// Encoded/decoded by serializers as &quot;DTOR&quot;.
    /// </summary>
    [EnumMember(Value = "DTOR")]
    [IsoId("__-YKS9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the debtor is requested.")]
    Debtor,

    /// <summary>
    /// Investigation relates to financial crimes compliance.
    /// Encoded/decoded by serializers as &quot;FCCI&quot;.
    /// </summary>
    [EnumMember(Value = "FCCI")]
    [IsoId("__-YKY9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to financial crimes compliance.")]
    FinancialCrimeCompliance,

    /// <summary>
    /// Instrument is confirmed as fraudulent.
    /// Encoded/decoded by serializers as &quot;FRAD&quot;.
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("__-YKYtYUEe68t8Cw380-tA")]
    [Description(@"Instrument is confirmed as fraudulent.")]
    FraudulentInstrument,

    /// <summary>
    /// Investigation relates to funds transfer regulation or wire transfer regulation.
    /// Encoded/decoded by serializers as &quot;FWTR&quot;.
    /// </summary>
    [EnumMember(Value = "FWTR")]
    [IsoId("__-YKZNYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to funds transfer regulation or wire transfer regulation.")]
    FundsTransferRegulationOrWireTransferRegulation,

    /// <summary>
    /// Incorrect accrued interest balance.
    /// Encoded/decoded by serializers as &quot;IAIB&quot;.
    /// </summary>
    [EnumMember(Value = "IAIB")]
    [IsoId("_U3OMcfXXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect accrued interest balance.")]
    IncorrectAccruedInterest,

    /// <summary>
    /// Incorrect daily accrued interest amount.
    /// Encoded/decoded by serializers as &quot;IDAI&quot;.
    /// </summary>
    [EnumMember(Value = "IDAI")]
    [IsoId("_U3OzgPXXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect daily accrued interest amount.")]
    IncorrectDailyAccruedInterest,

    /// <summary>
    /// Further information pertaining to the instructed reimbursement agent is requested.
    /// Encoded/decoded by serializers as &quot;IDRA&quot;.
    /// </summary>
    [EnumMember(Value = "IDRA")]
    [IsoId("__-YKTtYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instructed reimbursement agent is requested.")]
    InstructedReimbursementAgent,

    /// <summary>
    /// Further information pertaining to the instructing reimbursement agent is requested.
    /// Encoded/decoded by serializers as &quot;IGRA&quot;.
    /// </summary>
    [EnumMember(Value = "IGRA")]
    [IsoId("__-YKTdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instructing reimbursement agent is requested.")]
    InstructingReimbursementAgent,

    /// <summary>
    /// Invalid interest rate.
    /// Encoded/decoded by serializers as &quot;IIRT&quot;.
    /// </summary>
    [EnumMember(Value = "IIRT")]
    [IsoId("_U3NlYPXXEe-Ig-GynGPh9A")]
    [Description(@"Invalid interest rate.")]
    InvalidInterestRateType,

    /// <summary>
    /// Further information pertaining to an intermediary agent is requested.
    /// Encoded/decoded by serializers as &quot;INAG&quot;.
    /// </summary>
    [EnumMember(Value = "INAG")]
    [IsoId("__-YKUNYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to an intermediary agent is requested.")]
    IntermediaryAgent,

    /// <summary>
    /// Further information pertaining to the instruction for creditor agent is requested.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("__-YKWNYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instruction for creditor agent is requested.")]
    InstructionForCreditorAgent,

    /// <summary>
    /// Incorrect closing balance.
    /// Encoded/decoded by serializers as &quot;INCB&quot;.
    /// </summary>
    [EnumMember(Value = "INCB")]
    [IsoId("_U3OMcPXXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect closing balance.")]
    IncorrectClosingBalance,

    /// <summary>
    /// Further information pertaining to the instruction for next agent is requested.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("__-YKV9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instruction for next agent is requested.")]
    InstructionForNextAgent,

    /// <summary>
    /// Further information pertaining to the initiating party is requested.
    /// Encoded/decoded by serializers as &quot;INPA&quot;.
    /// </summary>
    [EnumMember(Value = "INPA")]
    [IsoId("__-YKX9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the initiating party is requested.")]
    InitiatingParty,

    /// <summary>
    /// Incorrect transaction amount.
    /// Encoded/decoded by serializers as &quot;INTA&quot;.
    /// </summary>
    [EnumMember(Value = "INTA")]
    [IsoId("_U3OzgfXXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect transaction amount.")]
    IncorrectTransactionAmount,

    /// <summary>
    /// Interbank settlement amount is incorrect.
    /// Encoded/decoded by serializers as &quot;ISAM&quot;.
    /// </summary>
    [EnumMember(Value = "ISAM")]
    [IsoId("__-YKSdYUEe68t8Cw380-tA")]
    [Description(@"Interbank settlement amount is incorrect.")]
    InterbankSettlementAmount,

    /// <summary>
    /// Interbank settlement date is incorrect.
    /// Encoded/decoded by serializers as &quot;ISDT&quot;.
    /// </summary>
    [EnumMember(Value = "ISDT")]
    [IsoId("__-YKSNYUEe68t8Cw380-tA")]
    [Description(@"Interbank settlement date is incorrect.")]
    InterbankSettlementDate,

    /// <summary>
    /// Missing credit amount on statement.
    /// Encoded/decoded by serializers as &quot;MCAT&quot;.
    /// </summary>
    [EnumMember(Value = "MCAT")]
    [IsoId("_U3M-UPXXEe-Ig-GynGPh9A")]
    [Description(@"Missing credit amount on statement.")]
    MissingCreditAmount,

    /// <summary>
    /// Missing debit amount on statement.
    /// Encoded/decoded by serializers as &quot;MDAT&quot;.
    /// </summary>
    [EnumMember(Value = "MDAT")]
    [IsoId("_U3M-UfXXEe-Ig-GynGPh9A")]
    [Description(@"Missing debit amount on statement.")]
    MissingDebitAmount,

    /// <summary>
    /// See AdditionalRequestData element for additional information
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("__-YKb9YUEe68t8Cw380-tA")]
    [Description(@"See AdditionalRequestData element for additional information")]
    Narrative,

    /// <summary>
    /// Payment initiation has not been settled or confirmed.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("__-YKdNYUEe68t8Cw380-tA")]
    [Description(@"Payment initiation has not been settled or confirmed.")]
    PaymentInitiationNotConfirmed,

    /// <summary>
    /// Further information pertaining to the purpose is requested.
    /// Encoded/decoded by serializers as &quot;PURP&quot;.
    /// </summary>
    [EnumMember(Value = "PURP")]
    [IsoId("__-YKXtYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the purpose is requested.")]
    Purpose,

    /// <summary>
    /// Payment type clearing channel is incorrect, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;PYCC&quot;.
    /// </summary>
    [EnumMember(Value = "PYCC")]
    [IsoId("__-YKUdYUEe68t8Cw380-tA")]
    [Description(@"Payment type clearing channel is incorrect, incomplete or missing.")]
    PaymentClearingChannel,

    /// <summary>
    /// Transaction payment purpose is incorrect, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;PYPU&quot;.
    /// </summary>
    [EnumMember(Value = "PYPU")]
    [IsoId("__-YKVdYUEe68t8Cw380-tA")]
    [Description(@"Transaction payment purpose is incorrect, incomplete or missing.")]
    PaymentPurpose,

    /// <summary>
    /// Requested execution date is incorrect or missing.
    /// Encoded/decoded by serializers as &quot;REDT&quot;.
    /// </summary>
    [EnumMember(Value = "REDT")]
    [IsoId("__-YKR9YUEe68t8Cw380-tA")]
    [Description(@"Requested execution date is incorrect or missing.")]
    RequestedExecutionDate,

    /// <summary>
    /// Regulatory reporting is incomplete or missing.
    /// Encoded/decoded by serializers as &quot;REGR&quot;.
    /// </summary>
    [EnumMember(Value = "REGR")]
    [IsoId("__-YKYNYUEe68t8Cw380-tA")]
    [Description(@"Regulatory reporting is incomplete or missing.")]
    RegulatoryReporting,

    /// <summary>
    /// Remittance information is incorrect, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;REIN&quot;.
    /// </summary>
    [EnumMember(Value = "REIN")]
    [IsoId("__-YKVNYUEe68t8Cw380-tA")]
    [Description(@"Remittance information is incorrect, incomplete or missing.")]
    RemittanceInformation,

    /// <summary>
    /// Related transaction reference is incorrect, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;RERE&quot;.
    /// </summary>
    [EnumMember(Value = "RERE")]
    [IsoId("__-YKRNYUEe68t8Cw380-tA")]
    [Description(@"Related transaction reference is incorrect, incomplete or missing.")]
    RelatedReference,

    /// <summary>
    /// Request from International Monetary Fund.
    /// Encoded/decoded by serializers as &quot;RIMF&quot;.
    /// </summary>
    [EnumMember(Value = "RIMF")]
    [IsoId("__-hUE9YUEe68t8Cw380-tA")]
    [Description(@"Request from International Monetary Fund.")]
    RequestFromIMF,

    /// <summary>
    /// Account closure date is requested.
    /// Encoded/decoded by serializers as &quot;RQCD&quot;.
    /// </summary>
    [EnumMember(Value = "RQCD")]
    [IsoId("__-YKcNYUEe68t8Cw380-tA")]
    [Description(@"Account closure date is requested.")]
    RequestAccountClosureDate,

    /// <summary>
    /// Investigation relating to charges that have been taken or are unpaid.
    /// Encoded/decoded by serializers as &quot;RQCH&quot;.
    /// </summary>
    [EnumMember(Value = "RQCH")]
    [IsoId("__-hUEtYUEe68t8Cw380-tA")]
    [Description(@"Investigation relating to charges that have been taken or are unpaid.")]
    RequestRelatedToCharges,

    /// <summary>
    /// Debit authorisation on an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQDA&quot;.
    /// </summary>
    [EnumMember(Value = "RQDA")]
    [IsoId("__-hUENYUEe68t8Cw380-tA")]
    [Description(@"Debit authorisation on an entry is requested.")]
    RequestDebitAuthorisation,

    /// <summary>
    /// Documentation relating to the transaction is requested.
    /// Encoded/decoded by serializers as &quot;RQDO&quot;.
    /// </summary>
    [EnumMember(Value = "RQDO")]
    [IsoId("__-YKbdYUEe68t8Cw380-tA")]
    [Description(@"Documentation relating to the transaction is requested.")]
    RequestDocumentation,

    /// <summary>
    /// Clarification over when goods or services were exchanged is requested.
    /// Encoded/decoded by serializers as &quot;RQED&quot;.
    /// </summary>
    [EnumMember(Value = "RQED")]
    [IsoId("__-YKbNYUEe68t8Cw380-tA")]
    [Description(@"Clarification over when goods or services were exchanged is requested.")]
    RequestServicesOrGoodsExchangeDate,

    /// <summary>
    /// Clarification over location details is requested.
    /// Encoded/decoded by serializers as &quot;RQLD&quot;.
    /// </summary>
    [EnumMember(Value = "RQLD")]
    [IsoId("__-YKatYUEe68t8Cw380-tA")]
    [Description(@"Clarification over location details is requested.")]
    RequestLocationDetails,

    /// <summary>
    /// Clarification over a party relationship is requested.
    /// Encoded/decoded by serializers as &quot;RQPR&quot;.
    /// </summary>
    [EnumMember(Value = "RQPR")]
    [IsoId("__-YKaNYUEe68t8Cw380-tA")]
    [Description(@"Clarification over a party relationship is requested.")]
    RequestPartyRelationship,

    /// <summary>
    /// Clarification over goods or services involved is requested.
    /// Encoded/decoded by serializers as &quot;RQSG&quot;.
    /// </summary>
    [EnumMember(Value = "RQSG")]
    [IsoId("__-YKa9YUEe68t8Cw380-tA")]
    [Description(@"Clarification over goods or services involved is requested.")]
    RequestServicesOrGoodsDetails,

    /// <summary>
    /// Use of funds on an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQUF&quot;.
    /// </summary>
    [EnumMember(Value = "RQUF")]
    [IsoId("__-YKdtYUEe68t8Cw380-tA")]
    [Description(@"Use of funds on an entry is requested.")]
    RequestUseOfFunds,

    /// <summary>
    /// Revaluation of an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQVA&quot;.
    /// </summary>
    [EnumMember(Value = "RQVA")]
    [IsoId("__-YKddYUEe68t8Cw380-tA")]
    [Description(@"Revaluation of an entry is requested.")]
    RequestValueDateAdjustment,

    /// <summary>
    /// Clarification over a vessel or aircraft is requested.
    /// Encoded/decoded by serializers as &quot;RQVD&quot;.
    /// </summary>
    [EnumMember(Value = "RQVD")]
    [IsoId("__-YKadYUEe68t8Cw380-tA")]
    [Description(@"Clarification over a vessel or aircraft is requested.")]
    RequestVesselOrAircraftDetails,

    /// <summary>
    /// Further information pertaining to the settlement account is requested.
    /// Encoded/decoded by serializers as &quot;SEAC&quot;.
    /// </summary>
    [EnumMember(Value = "SEAC")]
    [IsoId("__-YKWtYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the settlement account is requested.")]
    SettlementAccount,

    /// <summary>
    /// Further information pertaining to a statement entry is requested.
    /// Encoded/decoded by serializers as &quot;STET&quot;.
    /// </summary>
    [EnumMember(Value = "STET")]
    [IsoId("__-YKWdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to a statement entry is requested.")]
    StatementEntry,

    /// <summary>
    /// Payment type service level is incorrect, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;SVLV&quot;.
    /// </summary>
    [EnumMember(Value = "SVLV")]
    [IsoId("__-YKRdYUEe68t8Cw380-tA")]
    [Description(@"Payment type service level is incorrect, incomplete or missing.")]
    PaymentServiceLevel,

    /// <summary>
    /// Tax data is incomplete or missing.
    /// Encoded/decoded by serializers as &quot;TAXD&quot;.
    /// </summary>
    [EnumMember(Value = "TAXD")]
    [IsoId("__-YKYdYUEe68t8Cw380-tA")]
    [Description(@"Tax data is incomplete or missing.")]
    Tax,

    /// <summary>
    /// Further information pertaining to the third reimbursement agent is requested.
    /// Encoded/decoded by serializers as &quot;TDRA&quot;.
    /// </summary>
    [EnumMember(Value = "TDRA")]
    [IsoId("__-YKT9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the third reimbursement agent is requested.")]
    ThirdReimbursementAgent,

    /// <summary>
    /// Further information pertaining to the ultimate creditor is requested.
    /// Encoded/decoded by serializers as &quot;ULTC&quot;.
    /// </summary>
    [EnumMember(Value = "ULTC")]
    [IsoId("__-YKXdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the ultimate creditor is requested.")]
    UltimateCreditor,

    /// <summary>
    /// Further information pertaining to the ultimate debtor is requested.
    /// Encoded/decoded by serializers as &quot;ULTD&quot;.
    /// </summary>
    [EnumMember(Value = "ULTD")]
    [IsoId("__-YKXNYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the ultimate debtor is requested.")]
    UltimateDebtor,

    /// <summary>
    /// A booked entry cannot be applied by the creditor.
    /// Encoded/decoded by serializers as &quot;UTAP&quot;.
    /// </summary>
    [EnumMember(Value = "UTAP")]
    [IsoId("__-YKcdYUEe68t8Cw380-tA")]
    [Description(@"A booked entry cannot be applied by the creditor.")]
    UnableToApplyByCreditor,
}
