// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is pending settlement, ie, pending delivery or receipt of the financial instrument. Settlement on the instructed settlement date is still possible.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aFGlxdp-Ed-ak6NoX_4Aeg_-870507202")]
[Description(
    @"Specifies the reason the transaction/instruction is pending settlement, ie, pending delivery or receipt of the financial instrument. Settlement on the instructed settlement date is still possible."
)]
[Derivations(
    typeof(PendingSettlement2Code),
    typeof(PendingSettlementStatusReason1Code),
    typeof(PendingSettlementStatusReason2Code)
)]
public enum PendingSettlementStatusReasonCode
{
    /// <summary>
    /// Securities have been delivered, but the settlement amount has not been received from the counterparty.
    /// Encoded/decoded by serializers as &quot;AWMO&quot;.
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("_aFGlxtp-Ed-ak6NoX_4Aeg_689720503")]
    [Description(
        @"Securities have been delivered, but the settlement amount has not been received from the counterparty."
    )]
    AwaitingMoney,

    /// <summary>
    /// Awaiting securities from corporate action issue or other procedures, for example, conversion, dematerialisation, exchange, registration, stamping, splitting, etc.
    /// Encoded/decoded by serializers as &quot;CAIS&quot;.
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_aFGlx9p-Ed-ak6NoX_4Aeg_689720504")]
    [Description(
        @"Awaiting securities from corporate action issue or other procedures, for example, conversion, dematerialisation, exchange, registration, stamping, splitting, etc."
    )]
    AwaitingSecurities,

    /// <summary>
    /// Instruction that has been refused or not recognised, and is represented automatically.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_aFQWwNp-Ed-ak6NoX_4Aeg_689720505")]
    [Description(
        @"Instruction that has been refused or not recognised, and is represented automatically."
    )]
    InstructionRefusedOrNotRecognised,

    /// <summary>
    /// Securities have not yet been received from the counterparty.
    /// Encoded/decoded by serializers as &quot;AWSH&quot;.
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_aFQWwdp-Ed-ak6NoX_4Aeg_689720506")]
    [Description(@"Securities have not yet been received from the counterparty.")]
    AwaitingSharesFromCounterparty,

    /// <summary>
    /// Settlement is physical and securities are being delivered.
    /// Encoded/decoded by serializers as &quot;PHSE&quot;.
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("_aFQWwtp-Ed-ak6NoX_4Aeg_689720515")]
    [Description(@"Settlement is physical and securities are being delivered.")]
    PhysicalDeliveryDelay,

    /// <summary>
    /// Trade is being amended in the market.
    /// Encoded/decoded by serializers as &quot;TAMM&quot;.
    /// </summary>
    [EnumMember(Value = "TAMM")]
    [IsoId("_aFQWw9p-Ed-ak6NoX_4Aeg_689720516")]
    [Description(@"Trade is being amended in the market.")]
    TradeAmendedInMarket,

    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as &quot;DOCY&quot;.
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_aFQWxNp-Ed-ak6NoX_4Aeg_689720517")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou,

    /// <summary>
    /// Awaiting documents or endorsements from the counterparty.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_aFQWxdp-Ed-ak6NoX_4Aeg_689720518")]
    [Description(@"Awaiting documents or endorsements from the counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty,

    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_aFQWxtp-Ed-ak6NoX_4Aeg_689720519")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked,

    /// <summary>
    /// Chaser/enquiry sent to the agent or depository.
    /// Encoded/decoded by serializers as &quot;CHAS&quot;.
    /// </summary>
    [EnumMember(Value = "CHAS")]
    [IsoId("_aFQWx9p-Ed-ak6NoX_4Aeg_689720520")]
    [Description(@"Chaser/enquiry sent to the agent or depository.")]
    EnquirySent,

    /// <summary>
    /// Securities are new issues and are not yet available/tradable.
    /// Encoded/decoded by serializers as &quot;NEWI&quot;.
    /// </summary>
    [EnumMember(Value = "NEWI")]
    [IsoId("_aFQWyNp-Ed-ak6NoX_4Aeg_689720521")]
    [Description(@"Securities are new issues and are not yet available/tradable.")]
    NewIssues,

    /// <summary>
    /// Insufficient deliverable securities in the counterparty&apos;s account, or counterparty does not hold the securities.
    /// Encoded/decoded by serializers as &quot;CLAC&quot;.
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_aFQWydp-Ed-ak6NoX_4Aeg_689720522")]
    [Description(
        @"Insufficient deliverable securities in the counterparty's account, or counterparty does not hold the securities."
    )]
    CounterpartyInsufficientSecurities,

    /// <summary>
    /// Securities quantity is not a multiple of an existing settlement amount lot for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_aFaHwNp-Ed-ak6NoX_4Aeg_689720523")]
    [Description(
        @"Securities quantity is not a multiple of an existing settlement amount lot for the instructed financial instrument."
    )]
    MultipleSettlementAmount,

    /// <summary>
    /// Settlement cannot be executed as securities are in global form.
    /// Encoded/decoded by serializers as &quot;GLOB&quot;.
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_aFaHwdp-Ed-ak6NoX_4Aeg_689720524")]
    [Description(@"Settlement cannot be executed as securities are in global form.")]
    GlobalFormSecurities,

    /// <summary>
    /// Your instruction is a preadvice, that is, matching only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_aFaHwtp-Ed-ak6NoX_4Aeg_689720532")]
    [Description(@"Your instruction is a preadvice, that is, matching only.")]
    PreadviceInstructed,

    /// <summary>
    /// Guaranteed delivery indicator differs in the counterparty&apos;s instruction.
    /// Encoded/decoded by serializers as &quot;GUAD&quot;.
    /// </summary>
    [EnumMember(Value = "GUAD")]
    [IsoId("_aFaHw9p-Ed-ak6NoX_4Aeg_689720533")]
    [Description(@"Guaranteed delivery indicator differs in the counterparty's instruction.")]
    GuaranteedDeliveryIndicatorDifference,

    /// <summary>
    /// Trade will settle in partials.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_aFaHxNp-Ed-ak6NoX_4Aeg_689720534")]
    [Description(@"Trade will settle in partials.")]
    TradeSettlesInPartials,

    /// <summary>
    /// Instruction has not been matched because the matching process is not required.
    /// Encoded/decoded by serializers as &quot;NMAS&quot;.
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("_aFaHxdp-Ed-ak6NoX_4Aeg_689720535")]
    [Description(@"Instruction has not been matched because the matching process is not required.")]
    NoMatchingRequired,

    /// <summary>
    /// Insufficient money in the counterparty&apos;s account.
    /// Encoded/decoded by serializers as &quot;CMON&quot;.
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("_aFaHxtp-Ed-ak6NoX_4Aeg_689720536")]
    [Description(@"Insufficient money in the counterparty's account.")]
    CounterpartyInsufficientMoney,

    /// <summary>
    /// Not enough collateral in your account to execute the transaction.
    /// Encoded/decoded by serializers as &quot;YCOL&quot;.
    /// </summary>
    [EnumMember(Value = "YCOL")]
    [IsoId("_aFaHx9p-Ed-ak6NoX_4Aeg_689720537")]
    [Description(@"Not enough collateral in your account to execute the transaction.")]
    CollateralShortage,

    /// <summary>
    /// Securities are not deliverable as they are pledged as collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_aFaHyNp-Ed-ak6NoX_4Aeg_689720546")]
    [Description(@"Securities are not deliverable as they are pledged as collateral.")]
    SecuritiesPledgedAsCollateral,

    /// <summary>
    /// Deposit of shares for the issuing of depositary receipts has been refused. The allotment for depositary receipts granted by the issuer is exceeded by the transaction.
    /// Encoded/decoded by serializers as &quot;DEPO&quot;.
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("_aFaHydp-Ed-ak6NoX_4Aeg_689720547")]
    [Description(
        @"Deposit of shares for the issuing of depositary receipts has been refused. The allotment for depositary receipts granted by the issuer is exceeded by the transaction."
    )]
    RefusedDepositForIssueOfDepositaryReceipts,

    /// <summary>
    /// Insufficient deliverable securities in your account because the maximum foreign limit has been reached.
    /// Encoded/decoded by serializers as &quot;FLIM&quot;.
    /// </summary>
    [EnumMember(Value = "FLIM")]
    [IsoId("_aFjRsNp-Ed-ak6NoX_4Aeg_689720548")]
    [Description(
        @"Insufficient deliverable securities in your account because the maximum foreign limit has been reached."
    )]
    MaximumForeignLimitReached,

    /// <summary>
    /// Foreign exchange instruction is missing.
    /// Encoded/decoded by serializers as &quot;NOFX&quot;.
    /// </summary>
    [EnumMember(Value = "NOFX")]
    [IsoId("_aFjRsdp-Ed-ak6NoX_4Aeg_689720549")]
    [Description(@"Foreign exchange instruction is missing.")]
    NoForeignExchangeInstruction,

    /// <summary>
    /// Securities require income adjustment, for example, dividend or interest.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_aFjRstp-Ed-ak6NoX_4Aeg_689720550")]
    [Description(@"Securities require income adjustment, for example, dividend or interest.")]
    IncomeAdjustementRequired,

    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as &quot;LINK&quot;.
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_aFjRs9p-Ed-ak6NoX_4Aeg_689720551")]
    [Description(
        @"Your instruction is pending settlement because the instruction linked to it is pending."
    )]
    PendingLinkedInstruction,

    /// <summary>
    /// Instruction is awaiting the settlement date, and no settlement problems have been reported.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_aFjRtNp-Ed-ak6NoX_4Aeg_689720552")]
    [Description(
        @"Instruction is awaiting the settlement date, and no settlement problems have been reported."
    )]
    AwaitingSettlementDate,

    /// <summary>
    /// Insufficient deliverable securities in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_aFjRtdp-Ed-ak6NoX_4Aeg_689720553")]
    [Description(@"Insufficient deliverable securities in your account.")]
    LackOfSecurities,

    /// <summary>
    /// Insufficient deliverable securities in your account because securities are loaned out.
    /// Encoded/decoded by serializers as &quot;LALO&quot;.
    /// </summary>
    [EnumMember(Value = "LALO")]
    [IsoId("_aFjRttp-Ed-ak6NoX_4Aeg_689720554")]
    [Description(
        @"Insufficient deliverable securities in your account because securities are loaned out."
    )]
    SecuritiesLoanedOut,

    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_aFjRt9p-Ed-ak6NoX_4Aeg_689720555")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney,

    /// <summary>
    /// Settlement confirmation has not been received.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_aFjRuNp-Ed-ak6NoX_4Aeg_689720563")]
    [Description(@"Settlement confirmation has not been received.")]
    ConfirmationNotReceived,

    /// <summary>
    /// Delivery/receipt has been refused because the physical securities are not in good order.
    /// Encoded/decoded by serializers as &quot;REFS&quot;.
    /// </summary>
    [EnumMember(Value = "REFS")]
    [IsoId("_aFjRudp-Ed-ak6NoX_4Aeg_689720564")]
    [Description(
        @"Delivery/receipt has been refused because the physical securities are not in good order."
    )]
    NotInGoodOrder,

    /// <summary>
    /// Instruction is pending as stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_aFjRutp-Ed-ak6NoX_4Aeg_689720565")]
    [Description(@"Instruction is pending as stamp duty information is missing.")]
    LackOfStampDutyInformation,

    /// <summary>
    /// Processing batch differs in the counterparty&apos;s instruction, for example, day time/real time versus overnight.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_aFtCsNp-Ed-ak6NoX_4Aeg_689720566")]
    [Description(
        @"Processing batch differs in the counterparty's instruction, for example, day time/real time versus overnight."
    )]
    ProcessingBatchDifference,

    /// <summary>
    /// Instruction is confirmed in the local market or is ready for settlement, awaiting the next settlement cycle.
    /// Encoded/decoded by serializers as &quot;CYCL&quot;.
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_aFtCsdp-Ed-ak6NoX_4Aeg_689720567")]
    [Description(
        @"Instruction is confirmed in the local market or is ready for settlement, awaiting the next settlement cycle."
    )]
    AwaitingNextSettlementCycle,

    /// <summary>
    /// Settlement is pending. The securities are blocked due to, for example, a corporate action event, re-alignment.
    /// Encoded/decoded by serializers as &quot;SBLO&quot;.
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_aFtCstp-Ed-ak6NoX_4Aeg_689720568")]
    [Description(
        @"Settlement is pending. The securities are blocked due to, for example, a corporate action event, re-alignment."
    )]
    SecuritiesBlocked,

    /// <summary>
    /// Counterparty is in receivership, that is, the form of bankruptcy where a court appointed person, the receiver, manages the affairs of the business.
    /// Encoded/decoded by serializers as &quot;CPEC&quot;.
    /// </summary>
    [EnumMember(Value = "CPEC")]
    [IsoId("_aFtCs9p-Ed-ak6NoX_4Aeg_689720577")]
    [Description(
        @"Counterparty is in receivership, that is, the form of bankruptcy where a court appointed person, the receiver, manages the affairs of the business."
    )]
    CounterpartyInReceivership,

    /// <summary>
    /// Securities amount is lower than the minimum existing settlement amount for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_aFtCtNp-Ed-ak6NoX_4Aeg_689720578")]
    [Description(
        @"Securities amount is lower than the minimum existing settlement amount for the instructed financial instrument."
    )]
    MinimumSettlementAmount,

    /// <summary>
    /// Payment is pending, and does not settle because the actual use of the risk management limit on the counterpart (bilateral limit) prevents settlement.
    /// Encoded/decoded by serializers as &quot;PCAP&quot;.
    /// </summary>
    [EnumMember(Value = "PCAP")]
    [IsoId("_aFtCtdp-Ed-ak6NoX_4Aeg_2113515296")]
    [Description(
        @"Payment is pending, and does not settle because the actual use of the risk management limit on the counterpart (bilateral limit) prevents settlement."
    )]
    PendingCAP,

    /// <summary>
    /// Pending reason is being investigated.
    /// Encoded/decoded by serializers as &quot;IAAD&quot;.
    /// </summary>
    [EnumMember(Value = "IAAD")]
    [IsoId("_aFtCttp-Ed-ak6NoX_4Aeg_-768376490")]
    [Description(@"Pending reason is being investigated.")]
    StatusReasonInvestigation,

    /// <summary>
    /// Another settlement pending reason.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aFtCt9p-Ed-ak6NoX_4Aeg_-768376395")]
    [Description(@"Another settlement pending reason.")]
    Other,

    /// <summary>
    /// Physical shares have been received and are being checked for authenticity.
    /// Encoded/decoded by serializers as &quot;PHCK&quot;.
    /// </summary>
    [EnumMember(Value = "PHCK")]
    [IsoId("_aFtCuNp-Ed-ak6NoX_4Aeg_-768376052")]
    [Description(@"Physical shares have been received and are being checked for authenticity.")]
    PhysicalSecuritiesVerification,

    /// <summary>
    /// Information, for example, telephone number, contact person, is missing.
    /// Encoded/decoded by serializers as &quot;MINF&quot;.
    /// </summary>
    [EnumMember(Value = "MINF")]
    [IsoId("_aFtCudp-Ed-ak6NoX_4Aeg_-768375932")]
    [Description(@"Information, for example, telephone number, contact person, is missing.")]
    MissingInformation,

    /// <summary>
    /// Account must already be opened in order to process the transfer.
    /// Encoded/decoded by serializers as &quot;ACOP&quot;.
    /// </summary>
    [EnumMember(Value = "ACOP")]
    [IsoId("_aF2MoNp-Ed-ak6NoX_4Aeg_-1056391733")]
    [Description(@"Account must already be opened in order to process the transfer.")]
    AccountNotOpen,

    /// <summary>
    /// Intermediary is investigating the reason why the transfer is pending.
    /// Encoded/decoded by serializers as &quot;IINV&quot;.
    /// </summary>
    [EnumMember(Value = "IINV")]
    [IsoId("_aF2Modp-Ed-ak6NoX_4Aeg_-1056390743")]
    [Description(@"Intermediary is investigating the reason why the transfer is pending.")]
    UnderInvestigation,

    /// <summary>
    /// Client has been informed of a problem and is investigating.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_aF2Motp-Ed-ak6NoX_4Aeg_-1056390357")]
    [Description(@"Client has been informed of a problem and is investigating.")]
    UnderClientInvestigation,

    /// <summary>
    /// Transfer agent is investigating.
    /// Encoded/decoded by serializers as &quot;AINV&quot;.
    /// </summary>
    [EnumMember(Value = "AINV")]
    [IsoId("_aF2Mo9p-Ed-ak6NoX_4Aeg_-1056389812")]
    [Description(@"Transfer agent is investigating.")]
    UnderTransferAgentInvestigation,

    /// <summary>
    /// Transfer is being processed by the transfer agent, awaiting status from transfer agent.
    /// Encoded/decoded by serializers as &quot;WTRF&quot;.
    /// </summary>
    [EnumMember(Value = "WTRF")]
    [IsoId("_aF2MpNp-Ed-ak6NoX_4Aeg_-1056389194")]
    [Description(
        @"Transfer is being processed by the transfer agent, awaiting status from transfer agent."
    )]
    AwaitingTransferAgentStatus,

    /// <summary>
    /// Usual transfer agent&apos;s processing timeframe.
    /// Encoded/decoded by serializers as &quot;USUA&quot;.
    /// </summary>
    [EnumMember(Value = "USUA")]
    [IsoId("_aF2Mpdp-Ed-ak6NoX_4Aeg_-1055468635")]
    [Description(@"Usual transfer agent's processing timeframe.")]
    UsualTransactionTime,

    /// <summary>
    /// At your request, the Intermediary is checking the status of your instruction with the transfer agent.
    /// Encoded/decoded by serializers as &quot;ASTA&quot;.
    /// </summary>
    [EnumMember(Value = "ASTA")]
    [IsoId("_aF2Mptp-Ed-ak6NoX_4Aeg_-1055467782")]
    [Description(
        @"At your request, the Intermediary is checking the status of your instruction with the transfer agent."
    )]
    AwaitingStatus,

    /// <summary>
    /// Application form has been sent to the transfer agent.
    /// Encoded/decoded by serializers as &quot;AFST&quot;.
    /// </summary>
    [EnumMember(Value = "AFST")]
    [IsoId("_aF2Mp9p-Ed-ak6NoX_4Aeg_-1055467177")]
    [Description(@"Application form has been sent to the transfer agent.")]
    ApplicationFormSent,

    /// <summary>
    /// Stock transfer form has been sent to the counterparty to sign and forward to the transfer agent.
    /// Encoded/decoded by serializers as &quot;STST&quot;.
    /// </summary>
    [EnumMember(Value = "STST")]
    [IsoId("_aF2MqNp-Ed-ak6NoX_4Aeg_-1055466342")]
    [Description(
        @"Stock transfer form has been sent to the counterparty to sign and forward to the transfer agent."
    )]
    StockTransferFormSent,

    /// <summary>
    /// Longer processing timeframe for this type of transfer, due to documentation requirements.
    /// Encoded/decoded by serializers as &quot;LPRO&quot;.
    /// </summary>
    [EnumMember(Value = "LPRO")]
    [IsoId("_aF2Mqdp-Ed-ak6NoX_4Aeg_-1055465714")]
    [Description(
        @"Longer processing timeframe for this type of transfer, due to documentation requirements."
    )]
    LongerProcessing,

    /// <summary>
    /// Additional documents have been requested by the transfer agent.
    /// Encoded/decoded by serializers as &quot;ADRQ&quot;.
    /// </summary>
    [EnumMember(Value = "ADRQ")]
    [IsoId("_aF_9oNp-Ed-ak6NoX_4Aeg_-1054545130")]
    [Description(@"Additional documents have been requested by the transfer agent.")]
    AdditionalDocumentsRequested,

    /// <summary>
    /// Additional documents have been sent.
    /// Encoded/decoded by serializers as &quot;ADS1&quot;.
    /// </summary>
    [EnumMember(Value = "ADS1")]
    [IsoId("_aF_9odp-Ed-ak6NoX_4Aeg_-1054544568")]
    [Description(@"Additional documents have been sent.")]
    AdditionalDocumentsSent1,

    /// <summary>
    /// Upon request of the transfer agent, the intermediary has sent additional documents. The transfer agent has confirmed that all the necessary information is now in place.
    /// Encoded/decoded by serializers as &quot;ADS2&quot;.
    /// </summary>
    [EnumMember(Value = "ADS2")]
    [IsoId("_aF_9otp-Ed-ak6NoX_4Aeg_-1054543715")]
    [Description(
        @"Upon request of the transfer agent, the intermediary has sent additional documents. The transfer agent has confirmed that all the necessary information is now in place."
    )]
    AdditionalDocumentsSent2,

    /// <summary>
    /// Documents are rejected by the transfer agent.
    /// Encoded/decoded by serializers as &quot;DRJC&quot;.
    /// </summary>
    [EnumMember(Value = "DRJC")]
    [IsoId("_aF_9o9p-Ed-ak6NoX_4Aeg_-1054543079")]
    [Description(@"Documents are rejected by the transfer agent.")]
    DocumentsRejected,

    /// <summary>
    /// Counterparty has not sent an instruction to receive. Check with counterparty.
    /// Encoded/decoded by serializers as &quot;CYIN&quot;.
    /// </summary>
    [EnumMember(Value = "CYIN")]
    [IsoId("_aF_9pNp-Ed-ak6NoX_4Aeg_-1054542201")]
    [Description(@"Counterparty has not sent an instruction to receive. Check with counterparty.")]
    AwaitingCounterpartyReceipt,

    /// <summary>
    /// Counterparty has not sent an instruction to deliver or delivered the shares. Check with counterparty.
    /// Encoded/decoded by serializers as &quot;CYDV&quot;.
    /// </summary>
    [EnumMember(Value = "CYDV")]
    [IsoId("_aF_9pdp-Ed-ak6NoX_4Aeg_-1053621608")]
    [Description(
        @"Counterparty has not sent an instruction to deliver or delivered the shares. Check with counterparty."
    )]
    AwaitingCounterpartyDelivery,

    /// <summary>
    /// Normal processing period for the instruction has lapsed. The transfer agent has been or will be contacted.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_aF_9ptp-Ed-ak6NoX_4Aeg_-1053620738")]
    [Description(
        @"Normal processing period for the instruction has lapsed. The transfer agent has been or will be contacted."
    )]
    NormalProcessingPeriodLapsed,

    /// <summary>
    /// Wrong counterparty account details.
    /// Encoded/decoded by serializers as &quot;WCPA&quot;.
    /// </summary>
    [EnumMember(Value = "WCPA")]
    [IsoId("_aF_9p9p-Ed-ak6NoX_4Aeg_-1053619549")]
    [Description(@"Wrong counterparty account details.")]
    WrongCounterpartyAccount,

    /// <summary>
    /// Transfer is being processed by transfer agent.
    /// Encoded/decoded by serializers as &quot;TAPR&quot;.
    /// </summary>
    [EnumMember(Value = "TAPR")]
    [IsoId("_aF_9qNp-Ed-ak6NoX_4Aeg_-1052698145")]
    [Description(@"Transfer is being processed by transfer agent.")]
    TransferAgentProcessing,

    /// <summary>
    /// Confirmation is expected from transfer agent.
    /// Encoded/decoded by serializers as &quot;XCNF&quot;.
    /// </summary>
    [EnumMember(Value = "XCNF")]
    [IsoId("_aF_9qdp-Ed-ak6NoX_4Aeg_-1052697540")]
    [Description(@"Confirmation is expected from transfer agent.")]
    ExpectedConfirmation,

    /// <summary>
    /// Special follow-up is taking place.
    /// Encoded/decoded by serializers as &quot;ESCA&quot;.
    /// </summary>
    [EnumMember(Value = "ESCA")]
    [IsoId("_aGJuoNp-Ed-ak6NoX_4Aeg_-1052696670")]
    [Description(@"Special follow-up is taking place.")]
    Escalation,

    /// <summary>
    /// Transfer agent claims non-receipt of physical shares.
    /// Encoded/decoded by serializers as &quot;NRCP&quot;.
    /// </summary>
    [EnumMember(Value = "NRCP")]
    [IsoId("_aGJuodp-Ed-ak6NoX_4Aeg_-1052696010")]
    [Description(@"Transfer agent claims non-receipt of physical shares.")]
    TransferAgentNonReceipt,

    /// <summary>
    /// Confirmed but finality is to be verified.
    /// Encoded/decoded by serializers as &quot;FVER&quot;.
    /// </summary>
    [EnumMember(Value = "FVER")]
    [IsoId("_aGJuotp-Ed-ak6NoX_4Aeg_-1052695079")]
    [Description(@"Confirmed but finality is to be verified.")]
    FinalVerification,
}
