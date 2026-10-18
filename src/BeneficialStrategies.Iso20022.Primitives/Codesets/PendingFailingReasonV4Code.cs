// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AaBdELMUEfCEXew4g5B5oA")]
[Description(
    @"Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing."
)]
[Derivations(
    typeof(PendingCancellationReason10Code),
    typeof(PendingProcessingReason5Code),
    typeof(PendingProcessingReason6Code),
    typeof(PendingProcessingReason7Code),
    typeof(PendingProcessingReason8Code),
    typeof(PendingReason32Code),
    typeof(PendingReason34Code),
    typeof(PendingReason35Code),
    typeof(PendingReason37Code),
    typeof(PendingReason38Code),
    typeof(PendingReason39Code),
    typeof(PendingReason41Code)
)]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PendingFailingReasonV4Code>))]
public enum PendingFailingReasonV4Code
{
    /// <summary>
    /// Account must already be opened in order to process the transfer.
    /// Encoded/decoded by serializers as &quot;ACOP&quot;.
    /// </summary>
    [EnumMember(Value = "ACOP")]
    [IsoId("_fsokp7MUEfCEXew4g5B5oA")]
    [Description(@"Account must already be opened in order to process the transfer.")]
    AccountNotOpen,

    /// <summary>
    /// Additional documents requested missing.
    /// Encoded/decoded by serializers as &quot;ADDM&quot;.
    /// </summary>
    [EnumMember(Value = "ADDM")]
    [IsoId("_fspLcbMUEfCEXew4g5B5oA")]
    [Description(@"Additional documents requested missing.")]
    AdditionalDocumentationMissing,

    /// <summary>
    /// Instruction was received after the account servicer's deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_fspLcLMUEfCEXew4g5B5oA")]
    [Description(
        @"Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner."
    )]
    AccountServicerDeadlineMissed,

    /// <summary>
    /// Additional documents have been requested by the transfer agent.
    /// Encoded/decoded by serializers as &quot;ADRQ&quot;.
    /// </summary>
    [EnumMember(Value = "ADRQ")]
    [IsoId("_fspLcrMUEfCEXew4g5B5oA")]
    [Description(@"Additional documents have been requested by the transfer agent.")]
    AdditionalDocumentsRequested,

    /// <summary>
    /// Additional documents have been sent.
    /// Encoded/decoded by serializers as &quot;ADS1&quot;.
    /// </summary>
    [EnumMember(Value = "ADS1")]
    [IsoId("_fspLc7MUEfCEXew4g5B5oA")]
    [Description(@"Additional documents have been sent.")]
    AdditionalDocumentsSent1,

    /// <summary>
    /// Upon request of the transfer agent, the intermediary has sent additional documents.
    /// Encoded/decoded by serializers as &quot;ADS2&quot;.
    /// </summary>
    [EnumMember(Value = "ADS2")]
    [IsoId("_fspLdLMUEfCEXew4g5B5oA")]
    [Description(
        @"Upon request of the transfer agent, the intermediary has sent additional documents. The transfer agent has confirmed that all the necessary information is now in place."
    )]
    AdditionalDocumentsSent2,

    /// <summary>
    /// Application form has been sent to the transfer agent.
    /// Encoded/decoded by serializers as &quot;AFST&quot;.
    /// </summary>
    [EnumMember(Value = "AFST")]
    [IsoId("_fspLdbMUEfCEXew4g5B5oA")]
    [Description(@"Application form has been sent to the transfer agent.")]
    ApplicationFormSent,

    /// <summary>
    /// Transfer agent is investigating.
    /// Encoded/decoded by serializers as &quot;AINV&quot;.
    /// </summary>
    [EnumMember(Value = "AINV")]
    [IsoId("_fsqZoLMUEfCEXew4g5B5oA")]
    [Description(@"Transfer agent is investigating.")]
    UnderTransferAgentInvestigation,

    /// <summary>
    /// At your request, the Intermediary is checking the status of your instruction with the transfer agent.
    /// Encoded/decoded by serializers as &quot;ASTA&quot;.
    /// </summary>
    [EnumMember(Value = "ASTA")]
    [IsoId("_fspLgrMUEfCEXew4g5B5oA")]
    [Description(
        @"At your request, the Intermediary is checking the status of your instruction with the transfer agent."
    )]
    AwaitingStatus,

    /// <summary>
    /// Instruction/event is pending because the reclaim is sent to the tax authorities.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_fsqZkrMUEfCEXew4g5B5oA")]
    [Description(@"Instruction/event is pending because the reclaim is sent to the tax authorities.")]
    SentToTaxAuthorities,

    /// <summary>
    /// Financial instruments are delivered, but still awaiting money from counterparty.
    /// Encoded/decoded by serializers as &quot;AWMO&quot;.
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("_fspLfLMUEfCEXew4g5B5oA")]
    [Description(@"Financial instruments are delivered, but still awaiting money from counterparty.")]
    AwaitingMoney,

    /// <summary>
    /// Financial instruments have not yet been received from the counterparty, the money has been delivered.
    /// Encoded/decoded by serializers as &quot;AWSH&quot;.
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_fspLgLMUEfCEXew4g5B5oA")]
    [Description(
        @"Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered."
    )]
    AwaitingSecuritiesFromCounterparty,

    /// <summary>
    /// Processing batch differs in the counterparty's instruction.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_fspyrrMUEfCEXew4g5B5oA")]
    [Description(
        @"Processing batch differs in the counterparty's instruction, for example, daytime/real-time versus overnight."
    )]
    ProcessingBatchDifference,

    /// <summary>
    /// Disagreement in beneficial ownership.
    /// Encoded/decoded by serializers as &quot;BENO&quot;.
    /// </summary>
    [EnumMember(Value = "BENO")]
    [IsoId("_fspLhbMUEfCEXew4g5B5oA")]
    [Description(@"Disagreement in beneficial ownership.")]
    BeneficialOwnershipDisagreement,

    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_fsokprMUEfCEXew4g5B5oA")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked,

    /// <summary>
    /// Counterparty's instruction and your instruction are on hold/frozen/in a preadvice mode.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_fspLhrMUEfCEXew4g5B5oA")]
    [Description(@"Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode.")]
    BothInstructionsOnHold,

    /// <summary>
    /// Instruction is submitted before instruction start date.
    /// Encoded/decoded by serializers as &quot;BSTR&quot;.
    /// </summary>
    [EnumMember(Value = "BSTR")]
    [IsoId("_fspLhLMUEfCEXew4g5B5oA")]
    [Description(@"Instruction is submitted before instruction start date.")]
    BeforeInstructionPeriod,

    /// <summary>
    /// Counterparty disagreement on the chosen corporate action outturn.
    /// Encoded/decoded by serializers as &quot;BUMM&quot;.
    /// </summary>
    [EnumMember(Value = "BUMM")]
    [IsoId("_fspLh7MUEfCEXew4g5B5oA")]
    [Description(@"Counterparty disagreement on the chosen corporate action outturn.")]
    BuyerProtectionMismatch,

    /// <summary>
    /// Buy-in procedure has started on the market.
    /// Encoded/decoded by serializers as &quot;BYIY&quot;.
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("_fspLiLMUEfCEXew4g5B5oA")]
    [Description(
        @"Buy-in procedure has started on the market (on your behalf if your instruction is a receipt, by the counterparty if your instruction is a delivery)."
    )]
    BuyInProcedure,

    /// <summary>
    /// Awaiting financial instruments from a corporate action or other procedure.
    /// Encoded/decoded by serializers as &quot;CAIS&quot;.
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_fspLf7MUEfCEXew4g5B5oA")]
    [Description(
        @"Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting."
    )]
    AwaitingSecurities,

    /// <summary>
    /// Instruction was in suspense. Suspense period is finished so your cancellation or confirmation of instruction is required.
    /// Encoded/decoded by serializers as &quot;CANR&quot;.
    /// </summary>
    [EnumMember(Value = "CANR")]
    [IsoId("_fspLibMUEfCEXew4g5B5oA")]
    [Description(
        @"Instruction was in suspense. Suspense period is finished so your cancellation or confirmation of instruction is required."
    )]
    CancellationConfirmationRequested,

    /// <summary>
    /// Awaiting cancellation of one of the party.
    /// Encoded/decoded by serializers as &quot;CDAC&quot;.
    /// </summary>
    [EnumMember(Value = "CDAC")]
    [IsoId("_fspLkLMUEfCEXew4g5B5oA")]
    [Description(@"Awaiting cancellation of one of the party.")]
    ConditionalDeliveryAwaitingCancellation,

    /// <summary>
    /// Execution is conditional to the execution of a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as &quot;CDCY&quot;.
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("_fspLjrMUEfCEXew4g5B5oA")]
    [Description(
        @"Execution is conditional to the execution of a process linked to the currency of the transaction."
    )]
    ConditionalCurrency,

    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditional delivery rules.
    /// Encoded/decoded by serializers as &quot;CDEL&quot;.
    /// </summary>
    [EnumMember(Value = "CDEL")]
    [IsoId("_fspLj7MUEfCEXew4g5B5oA")]
    [Description(
        @"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditional delivery rules in the market infrastructure platform for conditional delivery."
    )]
    ConditionalDelivery,

    /// <summary>
    /// Conditional Delivery is still pending awaiting the cancellation from at least another party.
    /// Encoded/decoded by serializers as &quot;CDLC&quot;.
    /// </summary>
    [EnumMember(Value = "CDLC")]
    [IsoId("_fspLkrMUEfCEXew4g5B5oA")]
    [Description(
        @"Conditional Delivery is still pending awaiting the cancellation from at least another party."
    )]
    ConditionalDeliveryCancellationPending,

    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode. Market infrastructure platform is awaiting release.
    /// Encoded/decoded by serializers as &quot;CDLR&quot;.
    /// </summary>
    [EnumMember(Value = "CDLR")]
    [IsoId("_fspLkbMUEfCEXew4g5B5oA")]
    [Description(
        @"Instruction is in a hold/frozen/preadvice mode. Market infrastructure platform is awaiting release."
    )]
    ConditionalDeliveryAwaitingRelease,

    /// <summary>
    /// Execution is conditional to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as &quot;CDRE&quot;.
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("_fspLk7MUEfCEXew4g5B5oA")]
    [Description(
        @"Execution is conditional to the execution of a process of realignment at the issuer CSD."
    )]
    ConditionalRealignement,

    /// <summary>
    /// Execution is conditional to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as &quot;CDRG&quot;.
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("_fspLlLMUEfCEXew4g5B5oA")]
    [Description(@"Execution is conditional to the execution of a process at the registrar.")]
    ConditionalRegistrar,

    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_fsqZo7MUEfCEXew4g5B5oA")]
    [Description(@"Certificate number error.")]
    WrongCertificatesNumbers,

    /// <summary>
    /// A chaser/enquiry has been sent.
    /// Encoded/decoded by serializers as &quot;CHAS&quot;.
    /// </summary>
    [EnumMember(Value = "CHAS")]
    [IsoId("_fspLpLMUEfCEXew4g5B5oA")]
    [Description(@"A chaser/enquiry has been sent.")]
    EnquirySent,

    /// <summary>
    /// Client has been informed of a problem and is investigating.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_fsqZnbMUEfCEXew4g5B5oA")]
    [Description(@"Client has been informed of a problem and is investigating.")]
    UnderClientInvestigation,

    /// <summary>
    /// Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments.
    /// Encoded/decoded by serializers as &quot;CLAC&quot;.
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_fspLm7MUEfCEXew4g5B5oA")]
    [Description(
        @"Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments."
    )]
    CounterpartyInsufficientSecurities,

    /// <summary>
    /// Counterparty's instruction was too late for settlement.
    /// Encoded/decoded by serializers as &quot;CLAT&quot;.
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_fspLnbMUEfCEXew4g5B5oA")]
    [Description(
        @"Counterparty's instruction was too late for settlement, that is the matching or settlement problems was solved too late."
    )]
    CounterpartyTooLateForSettlement,

    /// <summary>
    /// Instructed settlement date does not agree with the settlement date on the clearing house trade.
    /// Encoded/decoded by serializers as &quot;CLHT&quot;.
    /// </summary>
    [EnumMember(Value = "CLHT")]
    [IsoId("_fspLjLMUEfCEXew4g5B5oA")]
    [Description(
        @"Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India."
    )]
    ClearingHouseTrade,

    /// <summary>
    /// Insufficient money in counterparty's account.
    /// Encoded/decoded by serializers as &quot;CMON&quot;.
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("_fspLmrMUEfCEXew4g5B5oA")]
    [Description(@"Insufficient money in counterparty's account.")]
    CounterpartyInsufficientMoney,

    /// <summary>
    /// Financial instruments are not deliverable as they are pledged as collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_fsqZkbMUEfCEXew4g5B5oA")]
    [Description(@"Financial instruments are not deliverable as they are pledged as collateral.")]
    SecuritiesPledgedAsCollateral,

    /// <summary>
    /// Awaiting confirmation from the counterparty.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_fspLdrMUEfCEXew4g5B5oA")]
    [Description(@"Awaiting confirmation from the counterparty.")]
    AwaitingConfirmation,

    /// <summary>
    /// Counterparty is in receivership.
    /// Encoded/decoded by serializers as &quot;CPEC&quot;.
    /// </summary>
    [EnumMember(Value = "CPEC")]
    [IsoId("_fspLmLMUEfCEXew4g5B5oA")]
    [Description(
        @"Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business)."
    )]
    CounterpartyInReceivership,

    /// <summary>
    /// Central securities depository sets the instruction in a hold/frozen/preadvice mode.
    /// Encoded/decoded by serializers as &quot;CSDH&quot;.
    /// </summary>
    [EnumMember(Value = "CSDH")]
    [IsoId("_fspLnrMUEfCEXew4g5B5oA")]
    [Description(
        @"Central securities depository sets the instruction in a hold/frozen/preadvice mode."
    )]
    CSDHold,

    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type.
    /// Encoded/decoded by serializers as &quot;CVAL&quot;.
    /// </summary>
    [EnumMember(Value = "CVAL")]
    [IsoId("_fspLn7MUEfCEXew4g5B5oA")]
    [Description(
        @"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform."
    )]
    CSDValidation,

    /// <summary>
    /// Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle.
    /// Encoded/decoded by serializers as &quot;CYCL&quot;.
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_fspLfbMUEfCEXew4g5B5oA")]
    [Description(
        @"Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle."
    )]
    AwaitingNextSettlementCycle,

    /// <summary>
    /// Counterparty has not sent an instruction to deliver or delivered the shares.
    /// Encoded/decoded by serializers as &quot;CYDV&quot;.
    /// </summary>
    [EnumMember(Value = "CYDV")]
    [IsoId("_fspLd7MUEfCEXew4g5B5oA")]
    [Description(
        @"Counterparty has not sent an instruction to deliver or delivered the shares. Check with counterparty."
    )]
    AwaitingCounterpartyDelivery,

    /// <summary>
    /// Counterparty has not sent an instruction to receive.
    /// Encoded/decoded by serializers as &quot;CYIN&quot;.
    /// </summary>
    [EnumMember(Value = "CYIN")]
    [IsoId("_fspLeLMUEfCEXew4g5B5oA")]
    [Description(@"Counterparty has not sent an instruction to receive. Check with counterparty.")]
    AwaitingCounterpartyReceipt,

    /// <summary>
    /// Quantity instructed does not match the denomination available/deliverable.
    /// Encoded/decoded by serializers as &quot;DENO&quot;.
    /// </summary>
    [EnumMember(Value = "DENO")]
    [IsoId("_fsqZnLMUEfCEXew4g5B5oA")]
    [Description(
        @"Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities."
    )]
    UnavailableDeliverableDenominatedQuantity,

    /// <summary>
    /// Deposit of shares for the issuing of depositary receipts has been refused.
    /// Encoded/decoded by serializers as &quot;DEPO&quot;.
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("_fspysbMUEfCEXew4g5B5oA")]
    [Description(
        @"Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction."
    )]
    RefusedDepositForIssueOfDepositaryReceipts,

    /// <summary>
    /// Exceptional closing of all financial institutions due to natural disaster.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_fspym7MUEfCEXew4g5B5oA")]
    [Description(
        @"Exceptional closing of all financial institutions due to natural disaster, for example, earthquake."
    )]
    NaturalDisaster,

    /// <summary>
    /// Counterparty has returned or refuses the securities.
    /// Encoded/decoded by serializers as &quot;DKNY&quot;.
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("_fspLnLMUEfCEXew4g5B5oA")]
    [Description(@"Counterparty has returned or refuses the securities.")]
    CounterpartyReturnedShares,

    /// <summary>
    /// Awaiting documents or endorsements from counterparty.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_fspLerMUEfCEXew4g5B5oA")]
    [Description(@"Awaiting documents or endorsements from counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty,

    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as &quot;DOCY&quot;.
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_fspLe7MUEfCEXew4g5B5oA")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou,

    /// <summary>
    /// Unrecognised or invalid instructed cash amount.
    /// Encoded/decoded by serializers as &quot;DQCS&quot;.
    /// </summary>
    [EnumMember(Value = "DQCS")]
    [IsoId("_fspLobMUEfCEXew4g5B5oA")]
    [Description(@"Unrecognised or invalid instructed cash amount.")]
    DisagreementOnCashAmount,

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_fspysLMUEfCEXew4g5B5oA")]
    [Description(@"Quantity of financial instruments does not match.")]
    QuantityDisagreement,

    /// <summary>
    /// Deadline to register is missed.
    /// Encoded/decoded by serializers as &quot;DREM&quot;.
    /// </summary>
    [EnumMember(Value = "DREM")]
    [IsoId("_fspLoLMUEfCEXew4g5B5oA")]
    [Description(@"Deadline to register is missed.")]
    DeadlineToRegisterMissed,

    /// <summary>
    /// Documents are rejected by the transfer agent.
    /// Encoded/decoded by serializers as &quot;DRJC&quot;.
    /// </summary>
    [EnumMember(Value = "DRJC")]
    [IsoId("_fspLorMUEfCEXew4g5B5oA")]
    [Description(@"Documents are rejected by the transfer agent.")]
    DocumentsRejected,

    /// <summary>
    /// Received after the election to counterparty response deadline.
    /// Encoded/decoded by serializers as &quot;ECRD&quot;.
    /// </summary>
    [EnumMember(Value = "ECRD")]
    [IsoId("_fspLo7MUEfCEXew4g5B5oA")]
    [Description(@"Received after the election to counterparty response deadline.")]
    ElectionToCounterpartyResponseDeadlineMissed,

    /// <summary>
    /// Special follow-up is taking place.
    /// Encoded/decoded by serializers as &quot;ESCA&quot;.
    /// </summary>
    [EnumMember(Value = "ESCA")]
    [IsoId("_fspygLMUEfCEXew4g5B5oA")]
    [Description(@"Special follow-up is taking place.")]
    Escalation,

    /// <summary>
    /// Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached.
    /// Encoded/decoded by serializers as &quot;FLIM&quot;.
    /// </summary>
    [EnumMember(Value = "FLIM")]
    [IsoId("_fspyk7MUEfCEXew4g5B5oA")]
    [Description(
        @"Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached."
    )]
    MaximumForeignLimitReached,

    /// <summary>
    /// Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event.
    /// Encoded/decoded by serializers as &quot;FROZ&quot;.
    /// </summary>
    [EnumMember(Value = "FROZ")]
    [IsoId("_fspytLMUEfCEXew4g5B5oA")]
    [Description(
        @"Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event."
    )]
    SecuritiesFrozenAtCSD,

    /// <summary>
    /// Pending receipt of beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_fspyqLMUEfCEXew4g5B5oA")]
    [Description(@"Pending receipt of beneficiary owner details.")]
    PendingBeneficiaryOwnerDetails,

    /// <summary>
    /// Awaiting settlement date.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_fspLgbMUEfCEXew4g5B5oA")]
    [Description(@"Awaiting settlement date. No settlement problems to be reported.")]
    AwaitingSettlementDate,

    /// <summary>
    /// Confirmed but finality is to be verified.
    /// Encoded/decoded by serializers as &quot;FVER&quot;.
    /// </summary>
    [EnumMember(Value = "FVER")]
    [IsoId("_fspygrMUEfCEXew4g5B5oA")]
    [Description(@"Confirmed but finality is to be verified.")]
    FinalVerification,

    /// <summary>
    /// Settlement cannot be executed; financial instruments are in global form.
    /// Encoded/decoded by serializers as &quot;GLOB&quot;.
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_fspyg7MUEfCEXew4g5B5oA")]
    [Description(@"Settlement cannot be executed; financial instruments are in global form.")]
    GlobalFormSecurities,

    /// <summary>
    /// Guaranteed delivery indicator differs in the counterparty's instruction.
    /// Encoded/decoded by serializers as &quot;GUAD&quot;.
    /// </summary>
    [EnumMember(Value = "GUAD")]
    [IsoId("_fspyhLMUEfCEXew4g5B5oA")]
    [Description(@"Guaranteed delivery indicator differs in the counterparty's instruction.")]
    GuaranteedDeliveryIndicatorDifference,

    /// <summary>
    /// Pending reason being investigated.
    /// Encoded/decoded by serializers as &quot;IAAD&quot;.
    /// </summary>
    [EnumMember(Value = "IAAD")]
    [IsoId("_fsqZlLMUEfCEXew4g5B5oA")]
    [Description(@"Pending reason being investigated.")]
    StatusReasonInvestigation,

    /// <summary>
    /// Intermediary is investigating the reason why the transfer is pending.
    /// Encoded/decoded by serializers as &quot;IINV&quot;.
    /// </summary>
    [EnumMember(Value = "IINV")]
    [IsoId("_fsqZnrMUEfCEXew4g5B5oA")]
    [Description(@"Intermediary is investigating the reason why the transfer is pending.")]
    UnderInvestigation,

    /// <summary>
    /// Not all the instructions part of a pool have been received.
    /// Encoded/decoded by serializers as &quot;INBC&quot;.
    /// </summary>
    [EnumMember(Value = "INBC")]
    [IsoId("_fspyhrMUEfCEXew4g5B5oA")]
    [Description(@"Not all the instructions part of a pool have been received.")]
    IncompleteNumberCount,

    /// <summary>
    /// Financial instruments require income adjustment, for example, dividend or interest.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_fspyhbMUEfCEXew4g5B5oA")]
    [Description(
        @"Financial instruments require income adjustment, for example, dividend or interest."
    )]
    IncomeAdjustementRequired,

    /// <summary>
    /// Required paperwork is invalid, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;IPAW&quot;.
    /// </summary>
    [EnumMember(Value = "IPAW")]
    [IsoId("_fspyjrMUEfCEXew4g5B5oA")]
    [Description(@"Required paperwork is invalid, incomplete or missing.")]
    InvalidPaperwork,

    /// <summary>
    /// Instruction was received prior to entitlement date.
    /// Encoded/decoded by serializers as &quot;IPED&quot;.
    /// </summary>
    [EnumMember(Value = "IPED")]
    [IsoId("_fspyibMUEfCEXew4g5B5oA")]
    [Description(@"Instruction was received prior to entitlement date.")]
    InstructionPriorToEntitlementDate,

    /// <summary>
    /// Instruction has been processed and cannot be cancelled.
    /// Encoded/decoded by serializers as &quot;IPNC&quot;.
    /// </summary>
    [EnumMember(Value = "IPNC")]
    [IsoId("_fspLirMUEfCEXew4g5B5oA")]
    [Description(@"Instruction has been processed and cannot be cancelled.")]
    CancelNotPossible,

    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as &quot;IPOA&quot;.
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("_fspyl7MUEfCEXew4g5B5oA")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA,

    /// <summary>
    /// Position is less than required threshold.
    /// Encoded/decoded by serializers as &quot;IPOS&quot;.
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("_fspyjbMUEfCEXew4g5B5oA")]
    [Description(@"Position is less than required threshold.")]
    InsufficientThresholdPosition,

    /// <summary>
    /// Invalid registration discrepancy.
    /// Encoded/decoded by serializers as &quot;IREG&quot;.
    /// </summary>
    [EnumMember(Value = "IREG")]
    [IsoId("_fspysrMUEfCEXew4g5B5oA")]
    [Description(@"Invalid registration discrepancy.")]
    RegistrationDiscrepancy,

    /// <summary>
    /// Tax rate provided is incorrect.
    /// Encoded/decoded by serializers as &quot;ITAX&quot;.
    /// </summary>
    [EnumMember(Value = "ITAX")]
    [IsoId("_fspyiLMUEfCEXew4g5B5oA")]
    [Description(
        @"Tax rate provided is incorrect. It falls outside the acceptable values for that investment country."
    )]
    IncorrectTaxRate,

    /// <summary>
    /// Awaiting settlement of a purchase to cover failing positions.
    /// Encoded/decoded by serializers as &quot;LAAW&quot;.
    /// </summary>
    [EnumMember(Value = "LAAW")]
    [IsoId("_fspLfrMUEfCEXew4g5B5oA")]
    [Description(@"Awaiting settlement of a purchase to cover failing positions.")]
    AwaitingOtherTransaction,

    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_fspyj7MUEfCEXew4g5B5oA")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities,

    /// <summary>
    /// Financial instruments are out on loan.
    /// Encoded/decoded by serializers as &quot;LALO&quot;.
    /// </summary>
    [EnumMember(Value = "LALO")]
    [IsoId("_fsqZkLMUEfCEXew4g5B5oA")]
    [Description(@"Financial instruments are out on loan.")]
    SecuritiesLoanedOut,

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_fspykrMUEfCEXew4g5B5oA")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed,

    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as &quot;LINK&quot;.
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_fspyqrMUEfCEXew4g5B5oA")]
    [Description(
        @"Your instruction is pending settlement because the instruction linked to it is pending."
    )]
    PendingLinkedInstruction,

    /// <summary>
    /// Central bank liquidity is insufficient.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_fspyi7MUEfCEXew4g5B5oA")]
    [Description(@"Central bank liquidity is insufficient.")]
    InsufficientCentralBankLiquidity,

    /// <summary>
    /// Longer processing timeframe for this type of transfer, due to documentation requirements.
    /// Encoded/decoded by serializers as &quot;LPRO&quot;.
    /// </summary>
    [EnumMember(Value = "LPRO")]
    [IsoId("_fspykbMUEfCEXew4g5B5oA")]
    [Description(
        @"Longer processing timeframe for this type of transfer, due to documentation requirements."
    )]
    LongerProcessing,

    /// <summary>
    /// Awaiting receipt of adequate certification.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_fspylbMUEfCEXew4g5B5oA")]
    [Description(@"Awaiting receipt of adequate certification.")]
    MissingCertification,

    /// <summary>
    /// Information, for example, telephone number, contact person, is missing.
    /// Encoded/decoded by serializers as &quot;MINF&quot;.
    /// </summary>
    [EnumMember(Value = "MINF")]
    [IsoId("_fspylrMUEfCEXew4g5B5oA")]
    [Description(
        @"Information, for example, telephone number, contact person, is missing."
    )]
    MissingInformation,

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_fspylLMUEfCEXew4g5B5oA")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementAmount,

    /// <summary>
    /// Covering money/financial instruments were received too late for completing settlement on a same day basis.
    /// Encoded/decoded by serializers as &quot;MLAT&quot;.
    /// </summary>
    [EnumMember(Value = "MLAT")]
    [IsoId("_fspymbMUEfCEXew4g5B5oA")]
    [Description(
        @"Covering money/financial instruments were received too late for completing settlement on a same day basis."
    )]
    MoneySecuritiesTooLateForSettlement,

    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_fspyjLMUEfCEXew4g5B5oA")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney,

    /// <summary>
    /// Tax rate is missing.
    /// Encoded/decoded by serializers as &quot;MTAX&quot;.
    /// </summary>
    [EnumMember(Value = "MTAX")]
    [IsoId("_fspymLMUEfCEXew4g5B5oA")]
    [Description(@"Tax rate is missing.")]
    MissingTaxRate,

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_fspymrMUEfCEXew4g5B5oA")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementAmount,

    /// <summary>
    /// Confirmation of settlement has not yet been received.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_fspLlrMUEfCEXew4g5B5oA")]
    [Description(@"Confirmation of settlement has not yet been received.")]
    ConfirmationNotReceived,

    /// <summary>
    /// Financial instrument is a new issue and not yet available/tradable.
    /// Encoded/decoded by serializers as &quot;NEWI&quot;.
    /// </summary>
    [EnumMember(Value = "NEWI")]
    [IsoId("_fspynLMUEfCEXew4g5B5oA")]
    [Description(@"Financial instrument is a new issue and not yet available/tradable.")]
    NewIssues,

    /// <summary>
    /// Next process is launched. No processing pending problems to be reported.
    /// Encoded/decoded by serializers as &quot;NEXT&quot;.
    /// </summary>
    [EnumMember(Value = "NEXT")]
    [IsoId("_fspynbMUEfCEXew4g5B5oA")]
    [Description(@"Next process is launched. No processing pending problems to be reported.")]
    NextProcess,

    /// <summary>
    /// Instruction has not been matched; matching process is not required.
    /// Encoded/decoded by serializers as &quot;NMAS&quot;.
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("_fspyn7MUEfCEXew4g5B5oA")]
    [Description(@"Instruction has not been matched; matching process is not required.")]
    NoMatchingRequired,

    /// <summary>
    /// A foreign exchange instruction from you is missing.
    /// Encoded/decoded by serializers as &quot;NOFX&quot;.
    /// </summary>
    [EnumMember(Value = "NOFX")]
    [IsoId("_fspynrMUEfCEXew4g5B5oA")]
    [Description(@"A foreign exchange instruction from you is missing.")]
    NoForeignExchangeInstruction,

    /// <summary>
    /// Payment has not been made by issuer.
    /// Encoded/decoded by serializers as &quot;NPAY&quot;.
    /// </summary>
    [EnumMember(Value = "NPAY")]
    [IsoId("_fspyoLMUEfCEXew4g5B5oA")]
    [Description(@"Payment has not been made by issuer.")]
    NoPayment,

    /// <summary>
    /// Insufficient or no registered position.
    /// Encoded/decoded by serializers as &quot;NPOS&quot;.
    /// </summary>
    [EnumMember(Value = "NPOS")]
    [IsoId("_fspyobMUEfCEXew4g5B5oA")]
    [Description(@"Insufficient or no registered position.")]
    NoRegisteredPosition,

    /// <summary>
    /// Transfer agent claims non-receipt of physical shares.
    /// Encoded/decoded by serializers as &quot;NRCP&quot;.
    /// </summary>
    [EnumMember(Value = "NRCP")]
    [IsoId("_fsqZmrMUEfCEXew4g5B5oA")]
    [Description(@"Transfer agent claims non-receipt of physical shares.")]
    TransferAgentNonReceipt,

    /// <summary>
    /// Financial instruments have not been delivered by the issuer.
    /// Encoded/decoded by serializers as &quot;NSEC&quot;.
    /// </summary>
    [EnumMember(Value = "NSEC")]
    [IsoId("_fspyo7MUEfCEXew4g5B5oA")]
    [Description(@"Financial instruments have not been delivered by the issuer.")]
    NotDelivered,

    /// <summary>
    /// Tax rate is not consistent with the documentation in place.
    /// Encoded/decoded by serializers as &quot;NTAX&quot;.
    /// </summary>
    [EnumMember(Value = "NTAX")]
    [IsoId("_fspyh7MUEfCEXew4g5B5oA")]
    [Description(@"Tax rate is not consistent with the documentation in place.")]
    InconsistentTaxRate,

    /// <summary>
    /// Financial instruments are stolen, in dispute, under objection etc.
    /// Encoded/decoded by serializers as &quot;OBJT&quot;.
    /// </summary>
    [EnumMember(Value = "OBJT")]
    [IsoId("_fsqZn7MUEfCEXew4g5B5oA")]
    [Description(@"Financial instruments are stolen, in dispute, under objection etc.")]
    UnderObjection,

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_fspypbMUEfCEXew4g5B5oA")]
    [Description(@"Other. See Narrative.")]
    Other,

    /// <summary>
    /// The instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_fspyorMUEfCEXew4g5B5oA")]
    [Description(@"The instructed position exceeds the eligible balance.")]
    NormalProcessingPeriodLapsed,

    /// <summary>
    /// Trade will settle in partials.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_fsqZmbMUEfCEXew4g5B5oA")]
    [Description(@"Trade will settle in partials.")]
    TradeSettlesInPartials,

    /// <summary>
    /// Disagreement on partial indicator preventing partial settlement.
    /// Encoded/decoded by serializers as &quot;PATD&quot;.
    /// </summary>
    [EnumMember(Value = "PATD")]
    [IsoId("_fspyprMUEfCEXew4g5B5oA")]
    [Description(@"Disagreement on partial indicator preventing partial settlement.")]
    PartialDiffer,

    /// <summary>
    /// Payment is pending, and does not settle because the actual use of the risk management limit on the counterpart prevents settlement.
    /// Encoded/decoded by serializers as &quot;PCAP&quot;.
    /// </summary>
    [EnumMember(Value = "PCAP")]
    [IsoId("_fspyqbMUEfCEXew4g5B5oA")]
    [Description(
        @"Payment is pending, and does not settle because the actual use of the risk management limit on the counterpart (bilateral limit) prevents settlement."
    )]
    PendingCAP,

    /// <summary>
    /// Prior payment credited to account based contractual income collection agreement has been collected from issuer.
    /// Encoded/decoded by serializers as &quot;PCNF&quot;.
    /// </summary>
    [EnumMember(Value = "PCNF")]
    [IsoId("_fspLl7MUEfCEXew4g5B5oA")]
    [Description(
        @"Prior payment credited to account based contractual income collection agreement has been collected from issuer."
    )]
    ConfirmationOfPayment,

    /// <summary>
    /// Instruction is pending receipt of securities, for example, from a purchase or loan.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_fspyq7MUEfCEXew4g5B5oA")]
    [Description(
        @"Instruction is pending receipt of securities, for example, from a purchase or loan."
    )]
    PendingReceipt,

    /// <summary>
    /// Physical financial instruments have been received and are being checked for authenticity.
    /// Encoded/decoded by serializers as &quot;PHCK&quot;.
    /// </summary>
    [EnumMember(Value = "PHCK")]
    [IsoId("_fspyrbMUEfCEXew4g5B5oA")]
    [Description(
        @"Physical financial instruments have been received and are being checked for authenticity."
    )]
    PhysicalSecuritiesVerification,

    /// <summary>
    /// Settlement is physical. Financial instruments are being delivered.
    /// Encoded/decoded by serializers as &quot;PHSE&quot;.
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("_fspyrLMUEfCEXew4g5B5oA")]
    [Description(@"Settlement is physical. Financial instruments are being delivered.")]
    PhysicalDeliveryDelay,

    /// <summary>
    /// Counterparty's instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PRCY&quot;.
    /// </summary>
    [EnumMember(Value = "PRCY")]
    [IsoId("_fspLmbMUEfCEXew4g5B5oA")]
    [Description(@"Counterparty's instruction is a preadvice, that is, for matching only.")]
    CounterpartyInstructionOnHold,

    /// <summary>
    /// Your instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_fsqZpbMUEfCEXew4g5B5oA")]
    [Description(@"Your instruction is a preadvice, that is, for matching only.")]
    YourInstructionOnHold,

    /// <summary>
    /// Transaction has been partially released.
    /// Encoded/decoded by serializers as &quot;PREL&quot;.
    /// </summary>
    [EnumMember(Value = "PREL")]
    [IsoId("_fspyp7MUEfCEXew4g5B5oA")]
    [Description(@"Transaction has been partially released.")]
    PartiallyReleased,

    /// <summary>
    /// Transaction was put on hold/frozen by the system.
    /// Encoded/decoded by serializers as &quot;PRSY&quot;.
    /// </summary>
    [EnumMember(Value = "PRSY")]
    [IsoId("_fsqZl7MUEfCEXew4g5B5oA")]
    [Description(@"Transaction was put on hold/frozen by the system.")]
    SystemOnHold,

    /// <summary>
    /// Invalid Proxy Information.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_fspyr7MUEfCEXew4g5B5oA")]
    [Description(@"Invalid Proxy Information.")]
    ProxyCardDiscrepancy,

    /// <summary>
    /// Delivery/receipt was refused because physical financial instruments are not in good order.
    /// Encoded/decoded by serializers as &quot;REFS&quot;.
    /// </summary>
    [EnumMember(Value = "REFS")]
    [IsoId("_fspypLMUEfCEXew4g5B5oA")]
    [Description(
        @"Delivery/receipt was refused because physical financial instruments are not in good order."
    )]
    NotInGoodOrder,

    /// <summary>
    /// Instruction has been refused or not recognised and is represented automatically.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_fspyirMUEfCEXew4g5B5oA")]
    [Description(
        @"Instruction has been refused or not recognised and is represented automatically."
    )]
    InstructionRefusedOrNotRecognised,

    /// <summary>
    /// Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached.
    /// Encoded/decoded by serializers as &quot;REGT&quot;.
    /// </summary>
    [EnumMember(Value = "REGT")]
    [IsoId("_fspLi7MUEfCEXew4g5B5oA")]
    [Description(
        @"Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached."
    )]
    CertificatesRejected,

    /// <summary>
    /// Financial instruments are blocked due to a corporate action event, realignment, etc.
    /// Encoded/decoded by serializers as &quot;SBLO&quot;.
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_fspys7MUEfCEXew4g5B5oA")]
    [Description(
        @"Financial instruments are blocked due to a corporate action event, realignment, etc."
    )]
    SecuritiesBlocked,

    /// <summary>
    /// Stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_fspykLMUEfCEXew4g5B5oA")]
    [Description(@"Stamp duty information is missing.")]
    LackOfStampDutyInformation,

    /// <summary>
    /// Settlement system/method has been modified at central securities depository to allow settlement.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_fsqZk7MUEfCEXew4g5B5oA")]
    [Description(
        @"Settlement system/method has been modified at central securities depository to allow settlement."
    )]
    SettlementSystemMethodModified,

    /// <summary>
    /// System is not available. Instruction is sent outside of business hours.
    /// Encoded/decoded by serializers as &quot;SNAV&quot;.
    /// </summary>
    [EnumMember(Value = "SNAV")]
    [IsoId("_fsqZlrMUEfCEXew4g5B5oA")]
    [Description(@"System is not available. Instruction is sent outside of business hours.")]
    SystemNotAvailable,

    /// <summary>
    /// Discrepancy in the settlement confirmation.
    /// Encoded/decoded by serializers as &quot;STCD&quot;.
    /// </summary>
    [EnumMember(Value = "STCD")]
    [IsoId("_fspLlbMUEfCEXew4g5B5oA")]
    [Description(@"Discrepancy in the settlement confirmation.")]
    ConfirmationDiscrepency,

    /// <summary>
    /// Stock transfer form has been sent to the counterparty to sign and forward to the transfer agent.
    /// Encoded/decoded by serializers as &quot;STST&quot;.
    /// </summary>
    [EnumMember(Value = "STST")]
    [IsoId("_fsqZlbMUEfCEXew4g5B5oA")]
    [Description(
        @"Stock transfer form has been sent to the counterparty to sign and forward to the transfer agent."
    )]
    StockTransferFormSent,

    /// <summary>
    /// Trade is being amended in the market.
    /// Encoded/decoded by serializers as &quot;TAMM&quot;.
    /// </summary>
    [EnumMember(Value = "TAMM")]
    [IsoId("_fsqZmLMUEfCEXew4g5B5oA")]
    [Description(@"Trade is being amended in the market.")]
    TradeAmendedInMarket,

    /// <summary>
    /// Transfer is being processed by transfer agent.
    /// Encoded/decoded by serializers as &quot;TAPR&quot;.
    /// </summary>
    [EnumMember(Value = "TAPR")]
    [IsoId("_fsqZm7MUEfCEXew4g5B5oA")]
    [Description(@"Transfer is being processed by transfer agent.")]
    TransferAgentProcessing,

    /// <summary>
    /// Usual transfer agent's processing timeframe.
    /// Encoded/decoded by serializers as &quot;USUA&quot;.
    /// </summary>
    [EnumMember(Value = "USUA")]
    [IsoId("_fsqZobMUEfCEXew4g5B5oA")]
    [Description(@"Usual transfer agent's processing timeframe.")]
    UsualTransactionTime,

    /// <summary>
    /// For tax reclaim, the event is pending, the tax reclaim is valid for the tax authorities.
    /// Encoded/decoded by serializers as &quot;VLDA&quot;.
    /// </summary>
    [EnumMember(Value = "VLDA")]
    [IsoId("_fsqZorMUEfCEXew4g5B5oA")]
    [Description(
        @"For tax reclaim, the event is pending, the tax reclaim is valid for the tax authorities."
    )]
    ValidForTaxAuthorities,

    /// <summary>
    /// Wrong counterparty account details.
    /// Encoded/decoded by serializers as &quot;WCPA&quot;.
    /// </summary>
    [EnumMember(Value = "WCPA")]
    [IsoId("_fsqZpLMUEfCEXew4g5B5oA")]
    [Description(@"Wrong counterparty account details.")]
    WrongCounterpartyAccount,

    /// <summary>
    /// Allegement has been sent out to counterparty. Waiting for their response.
    /// Encoded/decoded by serializers as &quot;WCTF&quot;.
    /// </summary>
    [EnumMember(Value = "WCTF")]
    [IsoId("_fspLebMUEfCEXew4g5B5oA")]
    [Description(@"Allegement has been sent out to counterparty. Waiting for their response.")]
    AwaitingCounterpartyResponse,

    /// <summary>
    /// Transfer is being processed by the transfer agent, awaiting status from transfer agent.
    /// Encoded/decoded by serializers as &quot;WTRF&quot;.
    /// </summary>
    [EnumMember(Value = "WTRF")]
    [IsoId("_fspLg7MUEfCEXew4g5B5oA")]
    [Description(
        @"Transfer is being processed by the transfer agent, awaiting status from transfer agent."
    )]
    AwaitingTransferAgentStatus,

    /// <summary>
    /// Confirmation is expected from transfer agent.
    /// Encoded/decoded by serializers as &quot;XCNF&quot;.
    /// </summary>
    [EnumMember(Value = "XCNF")]
    [IsoId("_fspygbMUEfCEXew4g5B5oA")]
    [Description(@"Confirmation is expected from transfer agent.")]
    ExpectedConfirmation,

    /// <summary>
    /// Insufficient collateral in your account to execute the instruction.
    /// Encoded/decoded by serializers as &quot;YCOL&quot;.
    /// </summary>
    [EnumMember(Value = "YCOL")]
    [IsoId("_fspLjbMUEfCEXew4g5B5oA")]
    [Description(@"Insufficient collateral in your account to execute the instruction.")]
    CollateralShortage,
}
