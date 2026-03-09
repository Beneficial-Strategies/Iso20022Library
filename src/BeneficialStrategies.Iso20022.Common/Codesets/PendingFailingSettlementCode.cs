// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is pending failing settlement, and the settlement at the instruction settlement date is no longer possible.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z_vkptp-Ed-ak6NoX_4Aeg_689720580")]
[Description(@"Specifies the reason the transaction/instruction is pending failing settlement, and the settlement at the instruction settlement date is no longer possible.")]
[Derivations(typeof(PendingFailingSettlement1Code))]
public enum PendingFailingSettlementCode
{
    /// <summary>
    /// Securities have been delivered, but the money is still expected from the counterparty.
    /// Encoded/decoded by serializers as &quot;AWMO&quot;.
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("_Z_vkp9p-Ed-ak6NoX_4Aeg_689720581")]
    [Description(@"Securities have been delivered, but the money is still expected from the counterparty.")]
    AwaitingMoney,
    
    /// <summary>
    /// Securities have not yet been received from the counterparty. If the settlement instruction was a received against payment, the cash has been delivered.
    /// Encoded/decoded by serializers as &quot;AWSH&quot;.
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_Z_vkqNp-Ed-ak6NoX_4Aeg_689720582")]
    [Description(@"Securities have not yet been received from the counterparty. If the settlement instruction was a received against payment, the cash has been delivered.")]
    AwaitingSecuritiesFromCounterparty,
    
    /// <summary>
    /// Awaiting settlement of a linked &apos;buy&apos;.
    /// Encoded/decoded by serializers as &quot;LAAW&quot;.
    /// </summary>
    [EnumMember(Value = "LAAW")]
    [IsoId("_Z_vkqdp-Ed-ak6NoX_4Aeg_689720583")]
    [Description(@"Awaiting settlement of a linked 'buy'.")]
    AwaitingOtherTransaction,
    
    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as &quot;DOCY&quot;.
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_Z_4ukNp-Ed-ak6NoX_4Aeg_689720584")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou,
    
    /// <summary>
    /// Counterparty&apos;s instruction was too late for settlement, (that is, received too late, matching, or settlement problems were solved too late).
    /// Encoded/decoded by serializers as &quot;CLAT&quot;.
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_Z_4ukdp-Ed-ak6NoX_4Aeg_689720585")]
    [Description(@"Counterparty's instruction was too late for settlement, (that is, received too late, matching, or settlement problems were solved too late).")]
    CounterpartyTooLateForSettlement,
    
    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_Z_4uktp-Ed-ak6NoX_4Aeg_689720586")]
    [Description(@"Certificate number error.")]
    WrongCertificateNumbers,
    
    /// <summary>
    /// Securities quantity is lower than the minimum existing settlement quantity for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_Z_4uk9p-Ed-ak6NoX_4Aeg_689720594")]
    [Description(@"Securities quantity is lower than the minimum existing settlement quantity for the instructed financial instrument.")]
    MinimumSettlementAmount,
    
    /// <summary>
    /// Settlement is physical, and there is a delay in the delivery of the securities.
    /// Encoded/decoded by serializers as &quot;PHSE&quot;.
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("_Z_4ulNp-Ed-ak6NoX_4Aeg_689720595")]
    [Description(@"Settlement is physical, and there is a delay in the delivery of the securities.")]
    PhysicalDeliveryDelay,
    
    /// <summary>
    /// Securities are blocked, for example, because of a corporate action event or re-alignment.
    /// Encoded/decoded by serializers as &quot;SBLO&quot;.
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_Z_4uldp-Ed-ak6NoX_4Aeg_689720596")]
    [Description(@"Securities are blocked, for example, because of a corporate action event or re-alignment.")]
    SecuritiesBlocked,
    
    /// <summary>
    /// Counterparty has returned, refused, or does not recognize the securities.
    /// Encoded/decoded by serializers as &quot;DKNY&quot;.
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("_Z_4ultp-Ed-ak6NoX_4Aeg_689720597")]
    [Description(@"Counterparty has returned, refused, or does not recognize the securities.")]
    CounterpartyReturnedSecurities,
    
    /// <summary>
    /// Discrepancy in the settlement confirmation.
    /// Encoded/decoded by serializers as &quot;STCD&quot;.
    /// </summary>
    [EnumMember(Value = "STCD")]
    [IsoId("_Z_4ul9p-Ed-ak6NoX_4Aeg_689720598")]
    [Description(@"Discrepancy in the settlement confirmation.")]
    ConfirmationDiscrepancy,
    
    /// <summary>
    /// Disagreement over beneficial ownership.
    /// Encoded/decoded by serializers as &quot;BENO&quot;.
    /// </summary>
    [EnumMember(Value = "BENO")]
    [IsoId("_aACfkNp-Ed-ak6NoX_4Aeg_689720599")]
    [Description(@"Disagreement over beneficial ownership.")]
    BeneficialOwnershipDisagreement,
    
    /// <summary>
    /// Insufficient deliverable securities in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_aACfkdp-Ed-ak6NoX_4Aeg_689720608")]
    [Description(@"Insufficient deliverable securities in your account.")]
    LackOfSecurities,
    
    /// <summary>
    /// Settlement instruction was too late for settlement, that is, received too late, matching, or settlement problems were solved too late.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_aACfktp-Ed-ak6NoX_4Aeg_689720609")]
    [Description(@"Settlement instruction was too late for settlement, that is, received too late, matching, or settlement problems were solved too late.")]
    TooLateForSettlement,
    
    /// <summary>
    /// Transaction suspended. Because the suspension period is finished, the cancellation or confirmation of instructions is required.
    /// Encoded/decoded by serializers as &quot;CANR&quot;.
    /// </summary>
    [EnumMember(Value = "CANR")]
    [IsoId("_aACfk9p-Ed-ak6NoX_4Aeg_689720610")]
    [Description(@"Transaction suspended. Because the suspension period is finished, the cancellation or confirmation of instructions is required.")]
    CancellationConfirmationRequest,
    
    /// <summary>
    /// Payment for a buy of securities was received after the cut-off time for completing the settlement on a same day basis.
    /// Encoded/decoded by serializers as &quot;MLAT&quot;.
    /// </summary>
    [EnumMember(Value = "MLAT")]
    [IsoId("_aACflNp-Ed-ak6NoX_4Aeg_689720611")]
    [Description(@"Payment for a buy of securities was received after the cut-off time for completing the settlement on a same day basis.")]
    MoneyTooLateForSettlement,
    
    /// <summary>
    /// Securities are stolen, in dispute, and under objection.
    /// Encoded/decoded by serializers as &quot;OBJT&quot;.
    /// </summary>
    [EnumMember(Value = "OBJT")]
    [IsoId("_aACfldp-Ed-ak6NoX_4Aeg_689720612")]
    [Description(@"Securities are stolen, in dispute, and under objection.")]
    UnderObjection,
    
    /// <summary>
    /// Awaiting documents or endorsements from the counterparty.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_aACfltp-Ed-ak6NoX_4Aeg_689720613")]
    [Description(@"Awaiting documents or endorsements from the counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty,
    
    /// <summary>
    /// Account is blocked, so no instruction can settle.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_aACfl9p-Ed-ak6NoX_4Aeg_689720614")]
    [Description(@"Account is blocked, so no instruction can settle.")]
    AccountBlocked,
    
    /// <summary>
    /// Enquiry/chaser sent to the agent or depository.
    /// Encoded/decoded by serializers as &quot;CHAS&quot;.
    /// </summary>
    [EnumMember(Value = "CHAS")]
    [IsoId("_aACfmNp-Ed-ak6NoX_4Aeg_689720615")]
    [Description(@"Enquiry/chaser sent to the agent or depository.")]
    EnquirySent,
    
    /// <summary>
    /// Securities are new issues, and not yet available/tradeable.
    /// Encoded/decoded by serializers as &quot;NEWI&quot;.
    /// </summary>
    [EnumMember(Value = "NEWI")]
    [IsoId("_aACfmdp-Ed-ak6NoX_4Aeg_689720616")]
    [Description(@"Securities are new issues, and not yet available/tradeable.")]
    NewIssues,
    
    /// <summary>
    /// Insufficient deliverable securities in the counterparty&apos;s account, or counterparty does not hold the securities.
    /// Encoded/decoded by serializers as &quot;CLAC&quot;.
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_aAMQkNp-Ed-ak6NoX_4Aeg_689720617")]
    [Description(@"Insufficient deliverable securities in the counterparty's account, or counterparty does not hold the securities.")]
    CounterpartyInsufficientSecurities,
    
    /// <summary>
    /// Trade will settle in partials.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_aAMQkdp-Ed-ak6NoX_4Aeg_689720625")]
    [Description(@"Trade will settle in partials.")]
    TradeSettlesInPartials,
    
    /// <summary>
    /// Insufficient money in counterparty&apos;s account.
    /// Encoded/decoded by serializers as &quot;CMON&quot;.
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("_aAMQktp-Ed-ak6NoX_4Aeg_689720626")]
    [Description(@"Insufficient money in counterparty's account.")]
    CounterpartyInsufficientMoney,
    
    /// <summary>
    /// Securities are not deliverable as they are pledged as collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_aAMQk9p-Ed-ak6NoX_4Aeg_689720627")]
    [Description(@"Securities are not deliverable as they are pledged as collateral.")]
    SecuritiesPledgedAsCollateral,
    
    /// <summary>
    /// Deposit of shares for the issuance of a depositary receipt has been refused. The allotment for depositary receipts granted by the issuer would be exceeded by the transaction.
    /// Encoded/decoded by serializers as &quot;DEPO&quot;.
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("_aAMQlNp-Ed-ak6NoX_4Aeg_689720628")]
    [Description(@"Deposit of shares for the issuance of a depositary receipt has been refused. The allotment for depositary receipts granted by the issuer would be exceeded by the transaction.")]
    RefusedDepositForIssueOfDepositaryReceipts,
    
    /// <summary>
    /// Insufficient deliverable securities in your account, as maximum foreign limit has been reached.
    /// Encoded/decoded by serializers as &quot;FLIM&quot;.
    /// </summary>
    [EnumMember(Value = "FLIM")]
    [IsoId("_aAMQldp-Ed-ak6NoX_4Aeg_689720629")]
    [Description(@"Insufficient deliverable securities in your account, as maximum foreign limit has been reached.")]
    MaximumForeignLimitReached,
    
    /// <summary>
    /// A foreign exchange instruction from you is missing.
    /// Encoded/decoded by serializers as &quot;NOFX&quot;.
    /// </summary>
    [EnumMember(Value = "NOFX")]
    [IsoId("_aAMQltp-Ed-ak6NoX_4Aeg_689720630")]
    [Description(@"A foreign exchange instruction from you is missing.")]
    NoForeignExchangeInstruction,
    
    /// <summary>
    /// Securities require income adjustment, that is, dividend or interest.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_aAMQl9p-Ed-ak6NoX_4Aeg_689720639")]
    [Description(@"Securities require income adjustment, that is, dividend or interest.")]
    IncomeAdjustementRequired,
    
    /// <summary>
    /// Linked instruction is pending/failing.
    /// Encoded/decoded by serializers as &quot;LINK&quot;.
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_aAMQmNp-Ed-ak6NoX_4Aeg_689720640")]
    [Description(@"Linked instruction is pending/failing.")]
    PendingLinkedInstruction,
    
    /// <summary>
    /// A buy-in procedure has started on the market, on your behalf, if your instruction is a receipt, or on behalf of the counterparty if the instruction is a delivery.
    /// Encoded/decoded by serializers as &quot;BYIY&quot;.
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("_aAMQmdp-Ed-ak6NoX_4Aeg_689720641")]
    [Description(@"A buy-in procedure has started on the market, on your behalf, if your instruction is a receipt, or on behalf of the counterparty if the instruction is a delivery.")]
    BuyInProcedure,
    
    /// <summary>
    /// Awaiting securities from a corporate action issue or other procedure(s), for example, conversion, dematerialisation, exchange, registration, stamping, and splitting.
    /// Encoded/decoded by serializers as &quot;CAIS&quot;.
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_aAVagNp-Ed-ak6NoX_4Aeg_689720642")]
    [Description(@"Awaiting securities from a corporate action issue or other procedure(s), for example, conversion, dematerialisation, exchange, registration, stamping, and splitting.")]
    AwaitingSecurities,
    
    /// <summary>
    /// Insufficient deliverable securities in your account as securities are loaned out.
    /// Encoded/decoded by serializers as &quot;LALO&quot;.
    /// </summary>
    [EnumMember(Value = "LALO")]
    [IsoId("_aAVagdp-Ed-ak6NoX_4Aeg_689720643")]
    [Description(@"Insufficient deliverable securities in your account as securities are loaned out.")]
    SecuritiesLoanedOut,
    
    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_aAVagtp-Ed-ak6NoX_4Aeg_689720644")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney,
    
    /// <summary>
    /// Settlement confirmation has not yet been received.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_aAVag9p-Ed-ak6NoX_4Aeg_689720645")]
    [Description(@"Settlement confirmation has not yet been received.")]
    ConfirmationNotReceived,
    
    /// <summary>
    /// Not enough collateral in your account to execute the instruction.
    /// Encoded/decoded by serializers as &quot;YCOL&quot;.
    /// </summary>
    [EnumMember(Value = "YCOL")]
    [IsoId("_aAVahNp-Ed-ak6NoX_4Aeg_689720646")]
    [Description(@"Not enough collateral in your account to execute the instruction.")]
    CollateralShortage,
    
    /// <summary>
    /// Delivery/receipt is refused because the physical securities are not in good order.
    /// Encoded/decoded by serializers as &quot;REFS&quot;.
    /// </summary>
    [EnumMember(Value = "REFS")]
    [IsoId("_aAVahdp-Ed-ak6NoX_4Aeg_689720647")]
    [Description(@"Delivery/receipt is refused because the physical securities are not in good order.")]
    NotInGoodOrder,
    
    /// <summary>
    /// Instruction is failing since stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_aAVahtp-Ed-ak6NoX_4Aeg_689720648")]
    [Description(@"Instruction is failing since stamp duty information is missing.")]
    LackOfStampDutyInformation,
    
    /// <summary>
    /// Your instruction is confirmed in the local market, but is ready for settlement at the next settlement cycle.
    /// Encoded/decoded by serializers as &quot;CYCL&quot;.
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_aAVah9p-Ed-ak6NoX_4Aeg_689720656")]
    [Description(@"Your instruction is confirmed in the local market, but is ready for settlement at the next settlement cycle.")]
    AwaitingNextSettlementCycle,
    
    /// <summary>
    /// Processing batch differs in the counterparty&apos;s instruction, for example, day time/real time vs overnight.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_aAVaiNp-Ed-ak6NoX_4Aeg_689720657")]
    [Description(@"Processing batch differs in the counterparty's instruction, for example, day time/real time vs overnight.")]
    ProcessingBatchDifference,
    
    /// <summary>
    /// Guaranteed delivery indicator differs in the counterparty&apos;s instruction.
    /// Encoded/decoded by serializers as &quot;GUAD&quot;.
    /// </summary>
    [EnumMember(Value = "GUAD")]
    [IsoId("_aAVaidp-Ed-ak6NoX_4Aeg_689720658")]
    [Description(@"Guaranteed delivery indicator differs in the counterparty's instruction.")]
    GuaranteedDeliveryIndicatorDifference,
    
    /// <summary>
    /// Instruction is a preadvice, that is, matching only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_aAfLgNp-Ed-ak6NoX_4Aeg_689720659")]
    [Description(@"Instruction is a preadvice, that is, matching only.")]
    PreadviceInstructed,
    
    /// <summary>
    /// Securities are in global form.
    /// Encoded/decoded by serializers as &quot;GLOB&quot;.
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_aAfLgdp-Ed-ak6NoX_4Aeg_689720660")]
    [Description(@"Securities are in global form.")]
    GlobalFormSecurities,
    
    /// <summary>
    /// Counterparty is in receivership, that is, a form of bankruptcy.
    /// Encoded/decoded by serializers as &quot;CPEC&quot;.
    /// </summary>
    [EnumMember(Value = "CPEC")]
    [IsoId("_aAfLgtp-Ed-ak6NoX_4Aeg_689720661")]
    [Description(@"Counterparty is in receivership, that is, a form of bankruptcy.")]
    CounterpartyInReceivership,
    
    /// <summary>
    /// Amount is not a multiple of an existing settlement amount lot for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_aAfLg9p-Ed-ak6NoX_4Aeg_1270722330")]
    [Description(@"Amount is not a multiple of an existing settlement amount lot for the instructed financial instrument.")]
    MultipleSettlementAmount,
    
}
