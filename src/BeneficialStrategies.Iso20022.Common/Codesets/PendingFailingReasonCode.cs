// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z-QW5dp-Ed-ak6NoX_4Aeg_-2146608608")]
[Description(@"Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.")]
[Derivations(typeof(PendingCancellationReason7Code),typeof(FailingReason2Code),typeof(PendingReason1Code),typeof(PendingReason17Code),typeof(PendingReason2Code),typeof(PendingReason7Code),typeof(PendingReason9Code),typeof(PendingReason19Code),typeof(PendingReason5Code),typeof(PendingReason4Code),typeof(PendingProcessingReason2Code),typeof(PendingCancellationReason2Code),typeof(PendingProcessingReason3Code),typeof(PendingReason6Code),typeof(PendingReason10Code),typeof(PendingReason3Code),typeof(PendingCancellationReason1Code),typeof(PendingReason11Code),typeof(FailingReason1Code),typeof(FailingReason3Code),typeof(PendingReason8Code),typeof(PendingProcessingReason4Code),typeof(PendingReason13Code),typeof(PendingProcessingReason1Code),typeof(PendingReason21Code))]
public enum PendingFailingReasonCode
{
    /// <summary>
    /// Financial instruments are delivered, but still awaiting money from counterparty.
    /// Encoded/decoded by serializers as &quot;AWMO&quot;.
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("_Z-QW5tp-Ed-ak6NoX_4Aeg_-1613635595")]
    [Description(@"Financial instruments are delivered, but still awaiting money from counterparty.")]
    AwaitingMoney,
    
    /// <summary>
    /// Instruction was received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Z-QW59p-Ed-ak6NoX_4Aeg_1827471534")]
    [Description(@"Instruction was received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Tax reclaim has been sent to the tax authorities.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_Z-QW6Np-Ed-ak6NoX_4Aeg_-2043267962")]
    [Description(@"Tax reclaim has been sent to the tax authorities.")]
    SentToTaxAuthorities,
    
    /// <summary>
    /// Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting.
    /// Encoded/decoded by serializers as &quot;CAIS&quot;.
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_Z-Zg0Np-Ed-ak6NoX_4Aeg_-398000527")]
    [Description(@"Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting.")]
    AwaitingSecurities,
    
    /// <summary>
    /// Instruction has been refused or not recognised and is represented automatically.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_Z-Zg0dp-Ed-ak6NoX_4Aeg_1502828422")]
    [Description(@"Instruction has been refused or not recognised and is represented automatically.")]
    InstructionRefusedOrNotRecognised,
    
    /// <summary>
    /// Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered.
    /// Encoded/decoded by serializers as &quot;AWSH&quot;.
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_Z-Zg0tp-Ed-ak6NoX_4Aeg_327637397")]
    [Description(@"Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered.")]
    AwaitingSecuritiesFromCounterparty,
    
    /// <summary>
    /// Settlement is physical. Financial instruments are being delivered.
    /// Encoded/decoded by serializers as &quot;PHSE&quot;.
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("_Z-Zg09p-Ed-ak6NoX_4Aeg_-1987826458")]
    [Description(@"Settlement is physical. Financial instruments are being delivered.")]
    PhysicalDeliveryDelay,
    
    /// <summary>
    /// Trade is being amended in the market.
    /// Encoded/decoded by serializers as &quot;TAMM&quot;.
    /// </summary>
    [EnumMember(Value = "TAMM")]
    [IsoId("_Z-Zg1Np-Ed-ak6NoX_4Aeg_1131949813")]
    [Description(@"Trade is being amended in the market.")]
    TradeAmendedInMarket,
    
    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as &quot;DOCY&quot;.
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_Z-Zg1dp-Ed-ak6NoX_4Aeg_426835198")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou,
    
    /// <summary>
    /// Awaiting documents or endorsements from counterparty.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_Z-Zg1tp-Ed-ak6NoX_4Aeg_2072102633")]
    [Description(@"Awaiting documents or endorsements from counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty,
    
    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_Z-Zg19p-Ed-ak6NoX_4Aeg_-684076221")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked,
    
    /// <summary>
    /// A chaser/enquiry has been sent.
    /// Encoded/decoded by serializers as &quot;CHAS&quot;.
    /// </summary>
    [EnumMember(Value = "CHAS")]
    [IsoId("_Z-Zg2Np-Ed-ak6NoX_4Aeg_-1859267246")]
    [Description(@"A chaser/enquiry has been sent.")]
    EnquirySent,
    
    /// <summary>
    /// Financial instrument is a new issue and not yet available/tradable.
    /// Encoded/decoded by serializers as &quot;NEWI&quot;.
    /// </summary>
    [EnumMember(Value = "NEWI")]
    [IsoId("_Z-Zg2dp-Ed-ak6NoX_4Aeg_1730585435")]
    [Description(@"Financial instrument is a new issue and not yet available/tradable.")]
    NewIssues,
    
    /// <summary>
    /// Insufficient deliverable financial instruments in counterparty&apos;s account or counterparty does not hold financial instruments.
    /// Encoded/decoded by serializers as &quot;CLAC&quot;.
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_Z-Zg2tp-Ed-ak6NoX_4Aeg_-919114426")]
    [Description(@"Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments.")]
    CounterpartyInsufficientSecurities,
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_Z-jR0Np-Ed-ak6NoX_4Aeg_619674016")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementAmount,
    
    /// <summary>
    /// Settlement cannot be executed; financial instruments are in global form.
    /// Encoded/decoded by serializers as &quot;GLOB&quot;.
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_Z-jR0dp-Ed-ak6NoX_4Aeg_-555517009")]
    [Description(@"Settlement cannot be executed; financial instruments are in global form.")]
    GlobalFormSecurities,
    
    /// <summary>
    /// Your instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_Z-jR0tp-Ed-ak6NoX_4Aeg_505350819")]
    [Description(@"Your instruction is a preadvice, that is, for matching only.")]
    YourInstructionOnHold,
    
    /// <summary>
    /// Guaranteed delivery indicator differs in the counterparty&apos;s instruction.
    /// Encoded/decoded by serializers as &quot;GUAD&quot;.
    /// </summary>
    [EnumMember(Value = "GUAD")]
    [IsoId("_Z-jR09p-Ed-ak6NoX_4Aeg_-2144349042")]
    [Description(@"Guaranteed delivery indicator differs in the counterparty's instruction.")]
    GuaranteedDeliveryIndicatorDifference,
    
    /// <summary>
    /// Trade will settle in partials.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_Z-jR1Np-Ed-ak6NoX_4Aeg_-605560600")]
    [Description(@"Trade will settle in partials.")]
    TradeSettlesInPartials,
    
    /// <summary>
    /// Instruction has not been matched; matching process is not required.
    /// Encoded/decoded by serializers as &quot;NMAS&quot;.
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("_Z-jR1dp-Ed-ak6NoX_4Aeg_-1780751625")]
    [Description(@"Instruction has not been matched; matching process is not required.")]
    NoMatchingRequired,
    
    /// <summary>
    /// Insufficient money in counterparty&apos;s account.
    /// Encoded/decoded by serializers as &quot;CMON&quot;.
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("_Z-jR1tp-Ed-ak6NoX_4Aeg_1809101056")]
    [Description(@"Insufficient money in counterparty's account.")]
    CounterpartyInsufficientMoney,
    
    /// <summary>
    /// Insufficient collateral in your account to execute the instruction.
    /// Encoded/decoded by serializers as &quot;YCOL&quot;.
    /// </summary>
    [EnumMember(Value = "YCOL")]
    [IsoId("_Z-jR19p-Ed-ak6NoX_4Aeg_-840598805")]
    [Description(@"Insufficient collateral in your account to execute the instruction.")]
    CollateralShortage,
    
    /// <summary>
    /// Financial instruments are not deliverable as they are pledged as collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_Z-jR2Np-Ed-ak6NoX_4Aeg_698189637")]
    [Description(@"Financial instruments are not deliverable as they are pledged as collateral.")]
    SecuritiesPledgedAsCollateral,
    
    /// <summary>
    /// Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction.
    /// Encoded/decoded by serializers as &quot;DEPO&quot;.
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("_Z-jR2dp-Ed-ak6NoX_4Aeg_-477001388")]
    [Description(@"Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction.")]
    RefusedDepositForIssueOfDepositaryReceipts,
    
    /// <summary>
    /// Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached.
    /// Encoded/decoded by serializers as &quot;FLIM&quot;.
    /// </summary>
    [EnumMember(Value = "FLIM")]
    [IsoId("_Z-sbwNp-Ed-ak6NoX_4Aeg_-1182116003")]
    [Description(@"Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached.")]
    MaximumForeignLimitReached,
    
    /// <summary>
    /// A foreign exchange instruction from you is missing.
    /// Encoded/decoded by serializers as &quot;NOFX&quot;.
    /// </summary>
    [EnumMember(Value = "NOFX")]
    [IsoId("_Z-sbwdp-Ed-ak6NoX_4Aeg_463151432")]
    [Description(@"A foreign exchange instruction from you is missing.")]
    NoForeignExchangeInstruction,
    
    /// <summary>
    /// Financial instruments require income adjustment, for example, dividend or interest.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_Z-sbwtp-Ed-ak6NoX_4Aeg_2001939874")]
    [Description(@"Financial instruments require income adjustment, for example, dividend or interest.")]
    IncomeAdjustementRequired,
    
    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as &quot;LINK&quot;.
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_Z-sbw9p-Ed-ak6NoX_4Aeg_826748849")]
    [Description(@"Your instruction is pending settlement because the instruction linked to it is pending.")]
    PendingLinkedInstruction,
    
    /// <summary>
    /// Awaiting settlement date. No settlement problems to be reported.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_Z-sbxNp-Ed-ak6NoX_4Aeg_121634234")]
    [Description(@"Awaiting settlement date. No settlement problems to be reported.")]
    AwaitingSettlementDate,
    
    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_Z-sbxdp-Ed-ak6NoX_4Aeg_1766901669")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities,
    
    /// <summary>
    /// Financial instruments are out on loan.
    /// Encoded/decoded by serializers as &quot;LALO&quot;.
    /// </summary>
    [EnumMember(Value = "LALO")]
    [IsoId("_Z-sbxtp-Ed-ak6NoX_4Aeg_-912238484")]
    [Description(@"Financial instruments are out on loan.")]
    SecuritiesLoanedOut,
    
    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_Z-sbx9p-Ed-ak6NoX_4Aeg_595632746")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney,
    
    /// <summary>
    /// Confirmation of settlement has not yet been received.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_Z-sbyNp-Ed-ak6NoX_4Aeg_-109481869")]
    [Description(@"Confirmation of settlement has not yet been received.")]
    ConfirmationNotReceived,
    
    /// <summary>
    /// Delivery/receipt was refused because physical financial instruments are not in good order.
    /// Encoded/decoded by serializers as &quot;REFS&quot;.
    /// </summary>
    [EnumMember(Value = "REFS")]
    [IsoId("_Z-sbydp-Ed-ak6NoX_4Aeg_1535785566")]
    [Description(@"Delivery/receipt was refused because physical financial instruments are not in good order.")]
    NotInGoodOrder,
    
    /// <summary>
    /// Stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_Z-2MwNp-Ed-ak6NoX_4Aeg_-1220393288")]
    [Description(@"Stamp duty information is missing.")]
    LackOfStampDutyInformation,
    
    /// <summary>
    /// Processing batch differs in the counterparty&apos;s instruction, for example, daytime/real-time versus overnight.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_Z-2Mwdp-Ed-ak6NoX_4Aeg_1899382983")]
    [Description(@"Processing batch differs in the counterparty's instruction, for example, daytime/real-time versus overnight.")]
    ProcessingBatchDifference,
    
    /// <summary>
    /// Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle.
    /// Encoded/decoded by serializers as &quot;CYCL&quot;.
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_Z-2Mwtp-Ed-ak6NoX_4Aeg_1194268368")]
    [Description(@"Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle.")]
    AwaitingNextSettlementCycle,
    
    /// <summary>
    /// Financial instruments are blocked due to, for example, a corporate action event, realignment.
    /// Encoded/decoded by serializers as &quot;SBLO&quot;.
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_Z-2Mw9p-Ed-ak6NoX_4Aeg_-1455431493")]
    [Description(@"Financial instruments are blocked due to, for example, a corporate action event, realignment.")]
    SecuritiesBlocked,
    
    /// <summary>
    /// Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business).
    /// Encoded/decoded by serializers as &quot;CPEC&quot;.
    /// </summary>
    [EnumMember(Value = "CPEC")]
    [IsoId("_Z-2MxNp-Ed-ak6NoX_4Aeg_83356949")]
    [Description(@"Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business).")]
    CounterpartyInReceivership,
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_Z-2Mxdp-Ed-ak6NoX_4Aeg_-1091834076")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementAmount,
    
    /// <summary>
    /// Payment is pending, and does not settle because the actual use of the risk management limit on the counterpart (bilateral limit) prevents settlement.
    /// Encoded/decoded by serializers as &quot;PCAP&quot;.
    /// </summary>
    [EnumMember(Value = "PCAP")]
    [IsoId("_Z-2Mxtp-Ed-ak6NoX_4Aeg_-1796948691")]
    [Description(@"Payment is pending, and does not settle because the actual use of the risk management limit on the counterpart (bilateral limit) prevents settlement.")]
    PendingCAP,
    
    /// <summary>
    /// Pending reason being investigated.
    /// Encoded/decoded by serializers as &quot;IAAD&quot;.
    /// </summary>
    [EnumMember(Value = "IAAD")]
    [IsoId("_Z-2Mx9p-Ed-ak6NoX_4Aeg_-151681256")]
    [Description(@"Pending reason being investigated.")]
    StatusReasonInvestigation,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Z-2MyNp-Ed-ak6NoX_4Aeg_1387107186")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Physical financial instruments have been received and are being checked for authenticity.
    /// Encoded/decoded by serializers as &quot;PHCK&quot;.
    /// </summary>
    [EnumMember(Value = "PHCK")]
    [IsoId("_Z-2Mydp-Ed-ak6NoX_4Aeg_211916161")]
    [Description(@"Physical financial instruments have been received and are being checked for authenticity.")]
    PhysicalSecuritiesVerification,
    
    /// <summary>
    /// Information, for example, telephone number, contact person, is missing.
    /// Encoded/decoded by serializers as &quot;MINF&quot;.
    /// </summary>
    [EnumMember(Value = "MINF")]
    [IsoId("_Z-_9wNp-Ed-ak6NoX_4Aeg_-493198454")]
    [Description(@"Information, for example, telephone number, contact person, is missing.")]
    MissingInformation,
    
    /// <summary>
    /// Account must already be opened in order to process the transfer.
    /// Encoded/decoded by serializers as &quot;ACOP&quot;.
    /// </summary>
    [EnumMember(Value = "ACOP")]
    [IsoId("_Z-_9wdp-Ed-ak6NoX_4Aeg_1152068981")]
    [Description(@"Account must already be opened in order to process the transfer.")]
    AccountNotOpen,
    
    /// <summary>
    /// Intermediary is investigating the reason why the transfer is pending.
    /// Encoded/decoded by serializers as &quot;IINV&quot;.
    /// </summary>
    [EnumMember(Value = "IINV")]
    [IsoId("_Z-_9wtp-Ed-ak6NoX_4Aeg_-1604109873")]
    [Description(@"Intermediary is investigating the reason why the transfer is pending.")]
    UnderInvestigation,
    
    /// <summary>
    /// Client has been informed of a problem and is investigating.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_Z-_9w9p-Ed-ak6NoX_4Aeg_1515666398")]
    [Description(@"Client has been informed of a problem and is investigating.")]
    UnderClientInvestigation,
    
    /// <summary>
    /// Transfer agent is investigating.
    /// Encoded/decoded by serializers as &quot;AINV&quot;.
    /// </summary>
    [EnumMember(Value = "AINV")]
    [IsoId("_Z-_9xNp-Ed-ak6NoX_4Aeg_810551783")]
    [Description(@"Transfer agent is investigating.")]
    UnderTransferAgentInvestigation,
    
    /// <summary>
    /// Transfer is being processed by the transfer agent, awaiting status from transfer agent.
    /// Encoded/decoded by serializers as &quot;WTRF&quot;.
    /// </summary>
    [EnumMember(Value = "WTRF")]
    [IsoId("_Z-_9xdp-Ed-ak6NoX_4Aeg_-1839148078")]
    [Description(@"Transfer is being processed by the transfer agent, awaiting status from transfer agent.")]
    AwaitingTransferAgentStatus,
    
    /// <summary>
    /// Usual transfer agent&apos;s processing timeframe.
    /// Encoded/decoded by serializers as &quot;USUA&quot;.
    /// </summary>
    [EnumMember(Value = "USUA")]
    [IsoId("_Z-_9xtp-Ed-ak6NoX_4Aeg_-300359636")]
    [Description(@"Usual transfer agent's processing timeframe.")]
    UsualTransactionTime,
    
    /// <summary>
    /// At your request, the Intermediary is checking the status of your instruction with the transfer agent.
    /// Encoded/decoded by serializers as &quot;ASTA&quot;.
    /// </summary>
    [EnumMember(Value = "ASTA")]
    [IsoId("_Z-_9x9p-Ed-ak6NoX_4Aeg_-1475550661")]
    [Description(@"At your request, the Intermediary is checking the status of your instruction with the transfer agent.")]
    AwaitingStatus,
    
    /// <summary>
    /// Application form has been sent to the transfer agent.
    /// Encoded/decoded by serializers as &quot;AFST&quot;.
    /// </summary>
    [EnumMember(Value = "AFST")]
    [IsoId("_Z-_9yNp-Ed-ak6NoX_4Aeg_2114302020")]
    [Description(@"Application form has been sent to the transfer agent.")]
    ApplicationFormSent,
    
    /// <summary>
    /// Stock transfer form has been sent to the counterparty to sign and forward to the transfer agent.
    /// Encoded/decoded by serializers as &quot;STST&quot;.
    /// </summary>
    [EnumMember(Value = "STST")]
    [IsoId("_Z-_9ydp-Ed-ak6NoX_4Aeg_-535397841")]
    [Description(@"Stock transfer form has been sent to the counterparty to sign and forward to the transfer agent.")]
    StockTransferFormSent,
    
    /// <summary>
    /// Longer processing timeframe for this type of transfer, due to documentation requirements.
    /// Encoded/decoded by serializers as &quot;LPRO&quot;.
    /// </summary>
    [EnumMember(Value = "LPRO")]
    [IsoId("_Z_JHsNp-Ed-ak6NoX_4Aeg_1003390601")]
    [Description(@"Longer processing timeframe for this type of transfer, due to documentation requirements.")]
    LongerProcessing,
    
    /// <summary>
    /// Additional documents have been requested by the transfer agent.
    /// Encoded/decoded by serializers as &quot;ADRQ&quot;.
    /// </summary>
    [EnumMember(Value = "ADRQ")]
    [IsoId("_Z_JHsdp-Ed-ak6NoX_4Aeg_-171800424")]
    [Description(@"Additional documents have been requested by the transfer agent.")]
    AdditionalDocumentsRequested,
    
    /// <summary>
    /// Additional documents have been sent.
    /// Encoded/decoded by serializers as &quot;ADS1&quot;.
    /// </summary>
    [EnumMember(Value = "ADS1")]
    [IsoId("_Z_JHstp-Ed-ak6NoX_4Aeg_-876915039")]
    [Description(@"Additional documents have been sent.")]
    AdditionalDocumentsSent1,
    
    /// <summary>
    /// Upon request of the transfer agent, the intermediary has sent additional documents. The transfer agent has confirmed that all the necessary information is now in place.
    /// Encoded/decoded by serializers as &quot;ADS2&quot;.
    /// </summary>
    [EnumMember(Value = "ADS2")]
    [IsoId("_Z_JHs9p-Ed-ak6NoX_4Aeg_768352396")]
    [Description(@"Upon request of the transfer agent, the intermediary has sent additional documents. The transfer agent has confirmed that all the necessary information is now in place.")]
    AdditionalDocumentsSent2,
    
    /// <summary>
    /// Documents are rejected by the transfer agent.
    /// Encoded/decoded by serializers as &quot;DRJC&quot;.
    /// </summary>
    [EnumMember(Value = "DRJC")]
    [IsoId("_Z_JHtNp-Ed-ak6NoX_4Aeg_-1987826458")]
    [Description(@"Documents are rejected by the transfer agent.")]
    DocumentsRejected,
    
    /// <summary>
    /// Counterparty has not sent an instruction to receive. Check with counterparty.
    /// Encoded/decoded by serializers as &quot;CYIN&quot;.
    /// </summary>
    [EnumMember(Value = "CYIN")]
    [IsoId("_Z_JHtdp-Ed-ak6NoX_4Aeg_1131949813")]
    [Description(@"Counterparty has not sent an instruction to receive. Check with counterparty.")]
    AwaitingCounterpartyReceipt,
    
    /// <summary>
    /// Counterparty has not sent an instruction to deliver or delivered the shares. Check with counterparty.
    /// Encoded/decoded by serializers as &quot;CYDV&quot;.
    /// </summary>
    [EnumMember(Value = "CYDV")]
    [IsoId("_Z_JHttp-Ed-ak6NoX_4Aeg_426835198")]
    [Description(@"Counterparty has not sent an instruction to deliver or delivered the shares. Check with counterparty.")]
    AwaitingCounterpartyDelivery,
    
    /// <summary>
    /// The instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_Z_JHt9p-Ed-ak6NoX_4Aeg_2072102633")]
    [Description(@"The instructed position exceeds the eligible balance.")]
    NormalProcessingPeriodLapsed,
    
    /// <summary>
    /// Wrong counterparty account details.
    /// Encoded/decoded by serializers as &quot;WCPA&quot;.
    /// </summary>
    [EnumMember(Value = "WCPA")]
    [IsoId("_Z_JHuNp-Ed-ak6NoX_4Aeg_-684076221")]
    [Description(@"Wrong counterparty account details.")]
    WrongCounterpartyAccount,
    
    /// <summary>
    /// Transfer is being processed by transfer agent.
    /// Encoded/decoded by serializers as &quot;TAPR&quot;.
    /// </summary>
    [EnumMember(Value = "TAPR")]
    [IsoId("_Z_JHudp-Ed-ak6NoX_4Aeg_-1859267246")]
    [Description(@"Transfer is being processed by transfer agent.")]
    TransferAgentProcessing,
    
    /// <summary>
    /// Confirmation is expected from transfer agent.
    /// Encoded/decoded by serializers as &quot;XCNF&quot;.
    /// </summary>
    [EnumMember(Value = "XCNF")]
    [IsoId("_Z_JHutp-Ed-ak6NoX_4Aeg_1730585435")]
    [Description(@"Confirmation is expected from transfer agent.")]
    ExpectedConfirmation,
    
    /// <summary>
    /// Special follow-up is taking place.
    /// Encoded/decoded by serializers as &quot;ESCA&quot;.
    /// </summary>
    [EnumMember(Value = "ESCA")]
    [IsoId("_Z_S4sNp-Ed-ak6NoX_4Aeg_-919114426")]
    [Description(@"Special follow-up is taking place.")]
    Escalation,
    
    /// <summary>
    /// Transfer agent claims non-receipt of physical shares.
    /// Encoded/decoded by serializers as &quot;NRCP&quot;.
    /// </summary>
    [EnumMember(Value = "NRCP")]
    [IsoId("_Z_S4sdp-Ed-ak6NoX_4Aeg_619674016")]
    [Description(@"Transfer agent claims non-receipt of physical shares.")]
    TransferAgentNonReceipt,
    
    /// <summary>
    /// Confirmed but finality is to be verified.
    /// Encoded/decoded by serializers as &quot;FVER&quot;.
    /// </summary>
    [EnumMember(Value = "FVER")]
    [IsoId("_Z_S4stp-Ed-ak6NoX_4Aeg_2051983465")]
    [Description(@"Confirmed but finality is to be verified.")]
    FinalVerification,
    
    /// <summary>
    /// Disagreement in beneficial ownership.
    /// Encoded/decoded by serializers as &quot;BENO&quot;.
    /// </summary>
    [EnumMember(Value = "BENO")]
    [IsoId("_Z_S4s9p-Ed-ak6NoX_4Aeg_1346868850")]
    [Description(@"Disagreement in beneficial ownership.")]
    BeneficialOwnershipDisagreement,
    
    /// <summary>
    /// Counterparty&apos;s instruction and your instruction are on hold/frozen/ in a preadvice mode.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_Z_S4tNp-Ed-ak6NoX_4Aeg_-1302831011")]
    [Description(@"Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode.")]
    BothInstructionsOnHold,
    
    /// <summary>
    /// Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India.
    /// Encoded/decoded by serializers as &quot;CLHT&quot;.
    /// </summary>
    [EnumMember(Value = "CLHT")]
    [IsoId("_Z_S4tdp-Ed-ak6NoX_4Aeg_235957431")]
    [Description(@"Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India.")]
    ClearingHouseTrade,
    
    /// <summary>
    /// Prior payment credited to account based contractual income collection agreement has been collected from issuer.
    /// Encoded/decoded by serializers as &quot;PCNF&quot;.
    /// </summary>
    [EnumMember(Value = "PCNF")]
    [IsoId("_Z_S4ttp-Ed-ak6NoX_4Aeg_-939233594")]
    [Description(@"Prior payment credited to account based contractual income collection agreement has been collected from issuer.")]
    ConfirmationOfPayment,
    
    /// <summary>
    /// Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities.
    /// Encoded/decoded by serializers as &quot;DENO&quot;.
    /// </summary>
    [EnumMember(Value = "DENO")]
    [IsoId("_Z_S4t9p-Ed-ak6NoX_4Aeg_-1644348209")]
    [Description(@"Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities.")]
    UnavailableDeliverableDenominatedQuantity,
    
    /// <summary>
    /// Exceptional closing of all financial institutions due to natural disaster, for example, earthquake.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_Z_S4uNp-Ed-ak6NoX_4Aeg_919226")]
    [Description(@"Exceptional closing of all financial institutions due to natural disaster, for example, earthquake.")]
    NaturalDisaster,
    
    /// <summary>
    /// Counterparty has returned or refuses the securities.
    /// Encoded/decoded by serializers as &quot;DKNY&quot;.
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("_Z_S4udp-Ed-ak6NoX_4Aeg_1539707668")]
    [Description(@"Counterparty has returned or refuses the securities.")]
    CounterpartyReturnedShares,
    
    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Z_cpsNp-Ed-ak6NoX_4Aeg_364516643")]
    [Description(@"Quantity of financial instruments does not match.")]
    QuantityDisagreement,
    
    /// <summary>
    /// Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event.
    /// Encoded/decoded by serializers as &quot;FROZ&quot;.
    /// </summary>
    [EnumMember(Value = "FROZ")]
    [IsoId("_Z_cpsdp-Ed-ak6NoX_4Aeg_-340597972")]
    [Description(@"Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event.")]
    SecuritiesFrozenAtCSD,
    
    /// <summary>
    /// Awaiting settlement of a purchase to cover failing positions.
    /// Encoded/decoded by serializers as &quot;LAAW&quot;.
    /// </summary>
    [EnumMember(Value = "LAAW")]
    [IsoId("_Z_cpstp-Ed-ak6NoX_4Aeg_1304669463")]
    [Description(@"Awaiting settlement of a purchase to cover failing positions.")]
    AwaitingOtherTransaction,
    
    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_Z_cps9p-Ed-ak6NoX_4Aeg_-1451509391")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Central bank liquidity is insufficient.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_Z_cptNp-Ed-ak6NoX_4Aeg_1668266880")]
    [Description(@"Central bank liquidity is insufficient.")]
    InsufficientCentralBankLiquidity,
    
    /// <summary>
    /// Awaiting receipt of adequate certification.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_Z_cptdp-Ed-ak6NoX_4Aeg_963152265")]
    [Description(@"Awaiting receipt of adequate certification.")]
    MissingCertification,
    
    /// <summary>
    /// Payment has not been made by issuer.
    /// Encoded/decoded by serializers as &quot;NPAY&quot;.
    /// </summary>
    [EnumMember(Value = "NPAY")]
    [IsoId("_Z_cpttp-Ed-ak6NoX_4Aeg_-1686547596")]
    [Description(@"Payment has not been made by issuer.")]
    NoPayment,
    
    /// <summary>
    /// Financial instruments have not been delivered by the issuer.
    /// Encoded/decoded by serializers as &quot;NSEC&quot;.
    /// </summary>
    [EnumMember(Value = "NSEC")]
    [IsoId("_Z_cpt9p-Ed-ak6NoX_4Aeg_-147759154")]
    [Description(@"Financial instruments have not been delivered by the issuer.")]
    NotDelivered,
    
    /// <summary>
    /// The instruction is pending receipt of securities, for example, from a purchase, loan etc.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_Z_cpuNp-Ed-ak6NoX_4Aeg_-1405179977")]
    [Description(@"The instruction is pending receipt of securities, for example, from a purchase, loan etc.")]
    PendingReceipt,
    
    /// <summary>
    /// Counterparty&apos;s instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PRCY&quot;.
    /// </summary>
    [EnumMember(Value = "PRCY")]
    [IsoId("_Z_cpudp-Ed-ak6NoX_4Aeg_-2110294592")]
    [Description(@"Counterparty's instruction is a preadvice, that is, for matching only.")]
    CounterpartyInstructionOnHold,
    
    /// <summary>
    /// Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached.
    /// Encoded/decoded by serializers as &quot;REGT&quot;.
    /// </summary>
    [EnumMember(Value = "REGT")]
    [IsoId("_Z_lzoNp-Ed-ak6NoX_4Aeg_1383066640")]
    [Description(@"Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached.")]
    CertificatesRejected,
    
    /// <summary>
    /// Settlement system/method has been modified at central securities depository to allow settlement.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_Z_lzodp-Ed-ak6NoX_4Aeg_207875615")]
    [Description(@"Settlement system/method has been modified at central securities depository to allow settlement.")]
    SettlementSystemMethodModified,
    
    /// <summary>
    /// For tax reclaim, the event is pending, the tax reclaim is valid for the tax authorities.
    /// Encoded/decoded by serializers as &quot;VLDA&quot;.
    /// </summary>
    [EnumMember(Value = "VLDA")]
    [IsoId("_Z_lzotp-Ed-ak6NoX_4Aeg_-497239000")]
    [Description(@"For tax reclaim, the event is pending, the tax reclaim is valid for the tax authorities.")]
    ValidForTaxAuthorities,
    
    /// <summary>
    /// Buy-in procedure has started on the market (on your behalf if your instruction is a receipt, by the counterparty if your instruction is a delivery).
    /// Encoded/decoded by serializers as &quot;BYIY&quot;.
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("_Z_lzo9p-Ed-ak6NoX_4Aeg_1148028435")]
    [Description(@"Buy-in procedure has started on the market (on your behalf if your instruction is a receipt, by the counterparty if your instruction is a delivery).")]
    BuyInProcedure,
    
    /// <summary>
    /// Instruction was in suspense. Suspense period is finished so your cancellation or confirmation of instruction is required.
    /// Encoded/decoded by serializers as &quot;CANR&quot;.
    /// </summary>
    [EnumMember(Value = "CANR")]
    [IsoId("_Z_lzpNp-Ed-ak6NoX_4Aeg_-1608150419")]
    [Description(@"Instruction was in suspense. Suspense period is finished so your cancellation or confirmation of instruction is required.")]
    CancellationConfirmationRequested,
    
    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_Z_lzpdp-Ed-ak6NoX_4Aeg_1511625852")]
    [Description(@"Certificate number error.")]
    WrongCertificatesNumbers,
    
    /// <summary>
    /// Financial instruments are, for example, stolen, in dispute, under objection.
    /// Encoded/decoded by serializers as &quot;OBJT&quot;.
    /// </summary>
    [EnumMember(Value = "OBJT")]
    [IsoId("_Z_lzptp-Ed-ak6NoX_4Aeg_806511237")]
    [Description(@"Financial instruments are, for example, stolen, in dispute, under objection.")]
    UnderObjection,
    
    /// <summary>
    /// Discrepancy in the settlement confirmation.
    /// Encoded/decoded by serializers as &quot;STCD&quot;.
    /// </summary>
    [EnumMember(Value = "STCD")]
    [IsoId("_Z_lzp9p-Ed-ak6NoX_4Aeg_-1843188624")]
    [Description(@"Discrepancy in the settlement confirmation.")]
    ConfirmationDiscrepency,
    
    /// <summary>
    /// Counterparty&apos;s instruction was too late for settlement, that is the matching or settlement problems was solved too late.
    /// Encoded/decoded by serializers as &quot;CLAT&quot;.
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_Z_lzqNp-Ed-ak6NoX_4Aeg_-304400182")]
    [Description(@"Counterparty's instruction was too late for settlement, that is the matching or settlement problems was solved too late.")]
    CounterpartyTooLateForSettlement,
    
    /// <summary>
    /// Covering money/financial instruments were received too late for completing settlement on a same day basis.
    /// Encoded/decoded by serializers as &quot;MLAT&quot;.
    /// </summary>
    [EnumMember(Value = "MLAT")]
    [IsoId("_Z_lzqdp-Ed-ak6NoX_4Aeg_-1479591207")]
    [Description(@"Covering money/financial instruments were received too late for completing settlement on a same day basis.")]
    MoneySecuritiesTooLateForSettlement,
    
    /// <summary>
    /// Next process is launched. No processing pending problems to be reported.
    /// Encoded/decoded by serializers as &quot;NEXT&quot;.
    /// </summary>
    [EnumMember(Value = "NEXT")]
    [IsoId("_Z_vkoNp-Ed-ak6NoX_4Aeg_2110261474")]
    [Description(@"Next process is launched. No processing pending problems to be reported.")]
    NextProcess,
    
    /// <summary>
    /// Awaiting confirmation from the counterparty.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_Z_vkodp-Ed-ak6NoX_4Aeg_-539438387")]
    [Description(@"Awaiting confirmation from the counterparty.")]
    AwaitingConfirmation,
    
    /// <summary>
    /// Transaction was put on hold/frozen by the system.
    /// Encoded/decoded by serializers as &quot;PRSY&quot;.
    /// </summary>
    [EnumMember(Value = "PRSY")]
    [IsoId("_Z_vkotp-Ed-ak6NoX_4Aeg_2098404663")]
    [Description(@"Transaction was put on hold/frozen by the system.")]
    SystemOnHold,
    
    /// <summary>
    /// Execution is conditional to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as &quot;CDRE&quot;.
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("_Z_vko9p-Ed-ak6NoX_4Aeg_-136699018")]
    [Description(@"Execution is conditional to the execution of a process of realignment at the issuer CSD.")]
    ConditionalRealignement,
    
    /// <summary>
    /// Execution is conditional to the execution of a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as &quot;CDCY&quot;.
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("_Z_vkpNp-Ed-ak6NoX_4Aeg_-1425729109")]
    [Description(@"Execution is conditional to the execution of a process linked to the currency of the transaction.")]
    ConditionalCurrency,
    
    /// <summary>
    /// Execution is conditional to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as &quot;CDRG&quot;.
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("_Z_vkpdp-Ed-ak6NoX_4Aeg_2050284506")]
    [Description(@"Execution is conditional to the execution of a process at the registrar.")]
    ConditionalRegistrar,
    
    /// <summary>
    /// Instruction has been processed and cannot be cancelled.
    /// Encoded/decoded by serializers as &quot;IPNC&quot;.
    /// </summary>
    [EnumMember(Value = "IPNC")]
    [IsoId("_9wQoGT__EeCaq78Ig8ATcA")]
    [Description(@"Instruction has been processed and cannot be cancelled.")]
    CancelNotPossible,
    
    /// <summary>
    /// Central securities depository sets the instruction in a hold/frozen/preadvice mode.
    /// Encoded/decoded by serializers as &quot;CSDH&quot;.
    /// </summary>
    [EnumMember(Value = "CSDH")]
    [IsoId("_iLnCF_4yEeClUvPNHKL9Zw")]
    [Description(@"Central securities depository sets the instruction in a hold/frozen/preadvice mode.")]
    CSDHold,
    
    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditional delivery rules in the market infrastructure platform for conditional delivery.
    /// Encoded/decoded by serializers as &quot;CDEL&quot;.
    /// </summary>
    [EnumMember(Value = "CDEL")]
    [IsoId("_nm93h_4yEeClUvPNHKL9Zw")]
    [Description(@"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditional delivery rules in the market infrastructure platform for conditional delivery.")]
    ConditionalDelivery,
    
    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform.
    /// Encoded/decoded by serializers as &quot;CVAL&quot;.
    /// </summary>
    [EnumMember(Value = "CVAL")]
    [IsoId("_s5ruV_4yEeClUvPNHKL9Zw")]
    [Description(@"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform.")]
    CSDValidation,
    
    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode. Market infrastructure platform is awaiting release.
    /// Encoded/decoded by serializers as &quot;CDLR&quot;.
    /// </summary>
    [EnumMember(Value = "CDLR")]
    [IsoId("_0p6JZ_4yEeClUvPNHKL9Zw")]
    [Description(@"Instruction is in a hold/frozen/preadvice mode. Market infrastructure platform is awaiting release.")]
    ConditionalDeliveryAwaitingRelease,
    
    /// <summary>
    /// Not all the instructions part of a pool have been received.
    /// Encoded/decoded by serializers as &quot;INBC&quot;.
    /// </summary>
    [EnumMember(Value = "INBC")]
    [IsoId("__AI9Z_4yEeClUvPNHKL9Zw")]
    [Description(@"Not all the instructions part of a pool have been received.")]
    IncompleteNumberCount,
    
    /// <summary>
    /// Awaiting cancellation of one of the party.
    /// Encoded/decoded by serializers as &quot;CDAC&quot;.
    /// </summary>
    [EnumMember(Value = "CDAC")]
    [IsoId("_XFlTZ_4zEeClUvPNHKL9Zw")]
    [Description(@"Awaiting cancellation of one of the party.")]
    ConditionalDeliveryAwaitingCancellation,
    
    /// <summary>
    /// Conditional Delivery is still pending awaiting the cancellation from at least another party.
    /// Encoded/decoded by serializers as &quot;CDLC&quot;.
    /// </summary>
    [EnumMember(Value = "CDLC")]
    [IsoId("_9nQ0B_40EeClUvPNHKL9Zw")]
    [Description(@"Conditional Delivery is still pending awaiting the cancellation from at least another party.")]
    ConditionalDeliveryCancellationPending,
    
    /// <summary>
    /// Pending receipt of beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;BOIS&quot;.
    /// </summary>
    [EnumMember(Value = "BOIS")]
    [IsoId("_CetY4CdcEeOXAt_43VmZGw")]
    [Description(@"Pending receipt of beneficiary owner details.")]
    PendingBeneficiaryOwnerDetails,
    
}
