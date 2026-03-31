// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is pending failing settlement, and the settlement at the instruction settlement date is no longer possible.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zcQUlA93EeGeV5vP7Mvdig_816274429")]
[Description(
    @"Specifies the reason the transaction/instruction is pending failing settlement, and the settlement at the instruction settlement date is no longer possible."
)]
[DerivedFrom(typeof(PendingFailingSettlementCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PendingFailingSettlement1Code>))]
#endif
public enum PendingFailingSettlement1Code
{
    /// <summary>
    /// Securities have been delivered, but the money is still expected from the counterparty.
    /// Encoded/decoded by serializers as &quot;AWMO&quot;.
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("_zcQUlQ93EeGeV5vP7Mvdig_-1625508054")]
    [Description(
        @"Securities have been delivered, but the money is still expected from the counterparty."
    )]
    AwaitingMoney = PendingFailingSettlementCode.AwaitingMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities have not yet been received from the counterparty. If the settlement instruction was a received against payment, the cash has been delivered.
    /// Encoded/decoded by serializers as &quot;AWSH&quot;.
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_zcQUlg93EeGeV5vP7Mvdig_-475206144")]
    [Description(
        @"Securities have not yet been received from the counterparty. If the settlement instruction was a received against payment, the cash has been delivered."
    )]
    AwaitingSecuritiesFromCounterparty =
        PendingFailingSettlementCode.AwaitingSecuritiesFromCounterparty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting settlement of a linked &apos;buy&apos;.
    /// Encoded/decoded by serializers as &quot;LAAW&quot;.
    /// </summary>
    [EnumMember(Value = "LAAW")]
    [IsoId("_zcaFkA93EeGeV5vP7Mvdig_-486304921")]
    [Description(@"Awaiting settlement of a linked 'buy'.")]
    AwaitingOtherTransaction = PendingFailingSettlementCode.AwaitingOtherTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as &quot;DOCY&quot;.
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_zcaFkQ93EeGeV5vP7Mvdig_-600143987")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou =
        PendingFailingSettlementCode.AwaitingDocumentsOrEndorsementsFromYou, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction was too late for settlement, (that is, received too late, matching, or settlement problems were solved too late).
    /// Encoded/decoded by serializers as &quot;CLAT&quot;.
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_zcaFkg93EeGeV5vP7Mvdig_274460232")]
    [Description(
        @"Counterparty's instruction was too late for settlement, (that is, received too late, matching, or settlement problems were solved too late)."
    )]
    CounterpartyTooLateForSettlement =
        PendingFailingSettlementCode.CounterpartyTooLateForSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_zcaFkw93EeGeV5vP7Mvdig_1798705517")]
    [Description(@"Certificate number error.")]
    WrongCertificateNumbers = PendingFailingSettlementCode.WrongCertificateNumbers, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities quantity is lower than the minimum existing settlement quantity for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_zcaFlA93EeGeV5vP7Mvdig_-1735496626")]
    [Description(
        @"Securities quantity is lower than the minimum existing settlement quantity for the instructed financial instrument."
    )]
    MinimumSettlementAmount = PendingFailingSettlementCode.MinimumSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is physical, and there is a delay in the delivery of the securities.
    /// Encoded/decoded by serializers as &quot;PHSE&quot;.
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("_zcaFlQ93EeGeV5vP7Mvdig_-684363554")]
    [Description(
        @"Settlement is physical, and there is a delay in the delivery of the securities."
    )]
    PhysicalDeliveryDelay = PendingFailingSettlementCode.PhysicalDeliveryDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities are blocked, for example, because of a corporate action event or re-alignment.
    /// Encoded/decoded by serializers as &quot;SBLO&quot;.
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_zcaFlg93EeGeV5vP7Mvdig_1766734753")]
    [Description(
        @"Securities are blocked, for example, because of a corporate action event or re-alignment."
    )]
    SecuritiesBlocked = PendingFailingSettlementCode.SecuritiesBlocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty has returned, refused, or does not recognize the securities.
    /// Encoded/decoded by serializers as &quot;DKNY&quot;.
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("_zcjPgA93EeGeV5vP7Mvdig_1652895687")]
    [Description(@"Counterparty has returned, refused, or does not recognize the securities.")]
    CounterpartyReturnedSecurities = PendingFailingSettlementCode.CounterpartyReturnedSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Discrepancy in the settlement confirmation.
    /// Encoded/decoded by serializers as &quot;STCD&quot;.
    /// </summary>
    [EnumMember(Value = "STCD")]
    [IsoId("_zcjPgQ93EeGeV5vP7Mvdig_-655709609")]
    [Description(@"Discrepancy in the settlement confirmation.")]
    ConfirmationDiscrepancy = PendingFailingSettlementCode.ConfirmationDiscrepancy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disagreement over beneficial ownership.
    /// Encoded/decoded by serializers as &quot;BENO&quot;.
    /// </summary>
    [EnumMember(Value = "BENO")]
    [IsoId("_zcjPgg93EeGeV5vP7Mvdig_-537838624")]
    [Description(@"Disagreement over beneficial ownership.")]
    BeneficialOwnershipDisagreement = PendingFailingSettlementCode.BeneficialOwnershipDisagreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient deliverable securities in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_zcjPgw93EeGeV5vP7Mvdig_1629300829")]
    [Description(@"Insufficient deliverable securities in your account.")]
    LackOfSecurities = PendingFailingSettlementCode.LackOfSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement instruction was too late for settlement, that is, received too late, matching, or settlement problems were solved too late.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_zcjPhA93EeGeV5vP7Mvdig_-1587646129")]
    [Description(
        @"Settlement instruction was too late for settlement, that is, received too late, matching, or settlement problems were solved too late."
    )]
    TooLateForSettlement = PendingFailingSettlementCode.TooLateForSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction suspended. Because the suspension period is finished, the cancellation or confirmation of instructions is required.
    /// Encoded/decoded by serializers as &quot;CANR&quot;.
    /// </summary>
    [EnumMember(Value = "CANR")]
    [IsoId("_zctAgA93EeGeV5vP7Mvdig_-1133558860")]
    [Description(
        @"Transaction suspended. Because the suspension period is finished, the cancellation or confirmation of instructions is required."
    )]
    CancellationConfirmationRequest = PendingFailingSettlementCode.CancellationConfirmationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment for a buy of securities was received after the cut-off time for completing the settlement on a same day basis.
    /// Encoded/decoded by serializers as &quot;MLAT&quot;.
    /// </summary>
    [EnumMember(Value = "MLAT")]
    [IsoId("_zctAgQ93EeGeV5vP7Mvdig_-1247397926")]
    [Description(
        @"Payment for a buy of securities was received after the cut-off time for completing the settlement on a same day basis."
    )]
    MoneyTooLateForSettlement = PendingFailingSettlementCode.MoneyTooLateForSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities are stolen, in dispute, and under objection.
    /// Encoded/decoded by serializers as &quot;OBJT&quot;.
    /// </summary>
    [EnumMember(Value = "OBJT")]
    [IsoId("_zctAgg93EeGeV5vP7Mvdig_-547611834")]
    [Description(@"Securities are stolen, in dispute, and under objection.")]
    UnderObjection = PendingFailingSettlementCode.UnderObjection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting documents or endorsements from the counterparty.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_zctAgw93EeGeV5vP7Mvdig_-160034632")]
    [Description(@"Awaiting documents or endorsements from the counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty =
        PendingFailingSettlementCode.AwaitingDocumentsOrEndorsementsFromCounterparty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is blocked, so no instruction can settle.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_zctAhA93EeGeV5vP7Mvdig_-171133409")]
    [Description(@"Account is blocked, so no instruction can settle.")]
    AccountBlocked = PendingFailingSettlementCode.AccountBlocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Enquiry/chaser sent to the agent or depository.
    /// Encoded/decoded by serializers as &quot;CHAS&quot;.
    /// </summary>
    [EnumMember(Value = "CHAS")]
    [IsoId("_zctAhQ93EeGeV5vP7Mvdig_589631744")]
    [Description(@"Enquiry/chaser sent to the agent or depository.")]
    EnquirySent = PendingFailingSettlementCode.EnquirySent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities are new issues, and not yet available/tradeable.
    /// Encoded/decoded by serializers as &quot;NEWI&quot;.
    /// </summary>
    [EnumMember(Value = "NEWI")]
    [IsoId("_zctAhg93EeGeV5vP7Mvdig_278240485")]
    [Description(@"Securities are new issues, and not yet available/tradeable.")]
    NewIssues = PendingFailingSettlementCode.NewIssues, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient deliverable securities in the counterparty&apos;s account, or counterparty does not hold the securities.
    /// Encoded/decoded by serializers as &quot;CLAC&quot;.
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_zc2xgA93EeGeV5vP7Mvdig_267141708")]
    [Description(
        @"Insufficient deliverable securities in the counterparty's account, or counterparty does not hold the securities."
    )]
    CounterpartyInsufficientSecurities =
        PendingFailingSettlementCode.CounterpartyInsufficientSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade will settle in partials.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_zc2xgQ93EeGeV5vP7Mvdig_153302642")]
    [Description(@"Trade will settle in partials.")]
    TradeSettlesInPartials = PendingFailingSettlementCode.TradeSettlesInPartials, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in counterparty&apos;s account.
    /// Encoded/decoded by serializers as &quot;CMON&quot;.
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("_zc2xgg93EeGeV5vP7Mvdig_592259215")]
    [Description(@"Insufficient money in counterparty's account.")]
    CounterpartyInsufficientMoney = PendingFailingSettlementCode.CounterpartyInsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities are not deliverable as they are pledged as collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_zc2xgw93EeGeV5vP7Mvdig_1307176003")]
    [Description(@"Securities are not deliverable as they are pledged as collateral.")]
    SecuritiesPledgedAsCollateral = PendingFailingSettlementCode.SecuritiesPledgedAsCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deposit of shares for the issuance of a depositary receipt has been refused. The allotment for depositary receipts granted by the issuer would be exceeded by the transaction.
    /// Encoded/decoded by serializers as &quot;DEPO&quot;.
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("_zc2xhA93EeGeV5vP7Mvdig_888642413")]
    [Description(
        @"Deposit of shares for the issuance of a depositary receipt has been refused. The allotment for depositary receipts granted by the issuer would be exceeded by the transaction."
    )]
    RefusedDepositForIssueOfDepositaryReceipts =
        PendingFailingSettlementCode.RefusedDepositForIssueOfDepositaryReceipts, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient deliverable securities in your account, as maximum foreign limit has been reached.
    /// Encoded/decoded by serializers as &quot;FLIM&quot;.
    /// </summary>
    [EnumMember(Value = "FLIM")]
    [IsoId("_zc2xhQ93EeGeV5vP7Mvdig_253610567")]
    [Description(
        @"Insufficient deliverable securities in your account, as maximum foreign limit has been reached."
    )]
    MaximumForeignLimitReached = PendingFailingSettlementCode.MaximumForeignLimitReached, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A foreign exchange instruction from you is missing.
    /// Encoded/decoded by serializers as &quot;NOFX&quot;.
    /// </summary>
    [EnumMember(Value = "NOFX")]
    [IsoId("_zc2xhg93EeGeV5vP7Mvdig_1331630905")]
    [Description(@"A foreign exchange instruction from you is missing.")]
    NoForeignExchangeInstruction = PendingFailingSettlementCode.NoForeignExchangeInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities require income adjustment, that is, dividend or interest.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_zc_7cA93EeGeV5vP7Mvdig_1217791839")]
    [Description(@"Securities require income adjustment, that is, dividend or interest.")]
    IncomeAdjustementRequired = PendingFailingSettlementCode.IncomeAdjustementRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Linked instruction is pending/failing.
    /// Encoded/decoded by serializers as &quot;LINK&quot;.
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_zc_7cQ93EeGeV5vP7Mvdig_-1132413222")]
    [Description(@"Linked instruction is pending/failing.")]
    PendingLinkedInstruction = PendingFailingSettlementCode.PendingLinkedInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A buy-in procedure has started on the market, on your behalf, if your instruction is a receipt, or on behalf of the counterparty if the instruction is a delivery.
    /// Encoded/decoded by serializers as &quot;BYIY&quot;.
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("_zc_7cg93EeGeV5vP7Mvdig_-678325953")]
    [Description(
        @"A buy-in procedure has started on the market, on your behalf, if your instruction is a receipt, or on behalf of the counterparty if the instruction is a delivery."
    )]
    BuyInProcedure = PendingFailingSettlementCode.BuyInProcedure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting securities from a corporate action issue or other procedure(s), for example, conversion, dematerialisation, exchange, registration, stamping, and splitting.
    /// Encoded/decoded by serializers as &quot;CAIS&quot;.
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_zc_7cw93EeGeV5vP7Mvdig_-92378927")]
    [Description(
        @"Awaiting securities from a corporate action issue or other procedure(s), for example, conversion, dematerialisation, exchange, registration, stamping, and splitting."
    )]
    AwaitingSecurities = PendingFailingSettlementCode.AwaitingSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient deliverable securities in your account as securities are loaned out.
    /// Encoded/decoded by serializers as &quot;LALO&quot;.
    /// </summary>
    [EnumMember(Value = "LALO")]
    [IsoId("_zc_7dA93EeGeV5vP7Mvdig_1688133855")]
    [Description(
        @"Insufficient deliverable securities in your account as securities are loaned out."
    )]
    SecuritiesLoanedOut = PendingFailingSettlementCode.SecuritiesLoanedOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_zc_7dQ93EeGeV5vP7Mvdig_-710296717")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney = PendingFailingSettlementCode.InsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement confirmation has not yet been received.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_zc_7dg93EeGeV5vP7Mvdig_-721395494")]
    [Description(@"Settlement confirmation has not yet been received.")]
    ConfirmationNotReceived = PendingFailingSettlementCode.ConfirmationNotReceived, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Not enough collateral in your account to execute the instruction.
    /// Encoded/decoded by serializers as &quot;YCOL&quot;.
    /// </summary>
    [EnumMember(Value = "YCOL")]
    [IsoId("_zdJscA93EeGeV5vP7Mvdig_-835234560")]
    [Description(@"Not enough collateral in your account to execute the instruction.")]
    CollateralShortage = PendingFailingSettlementCode.CollateralShortage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery/receipt is refused because the physical securities are not in good order.
    /// Encoded/decoded by serializers as &quot;REFS&quot;.
    /// </summary>
    [EnumMember(Value = "REFS")]
    [IsoId("_zdJscQ93EeGeV5vP7Mvdig_1574713721")]
    [Description(
        @"Delivery/receipt is refused because the physical securities are not in good order."
    )]
    NotInGoodOrder = PendingFailingSettlementCode.NotInGoodOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is failing since stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_zdJscg93EeGeV5vP7Mvdig_-2109851647")]
    [Description(@"Instruction is failing since stamp duty information is missing.")]
    LackOfStampDutyInformation = PendingFailingSettlementCode.LackOfStampDutyInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is confirmed in the local market, but is ready for settlement at the next settlement cycle.
    /// Encoded/decoded by serializers as &quot;CYCL&quot;.
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_zdJscw93EeGeV5vP7Mvdig_-2120950424")]
    [Description(
        @"Your instruction is confirmed in the local market, but is ready for settlement at the next settlement cycle."
    )]
    AwaitingNextSettlementCycle = PendingFailingSettlementCode.AwaitingNextSettlementCycle, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing batch differs in the counterparty&apos;s instruction, for example, day time/real time vs overnight.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_zdJsdA93EeGeV5vP7Mvdig_2060177806")]
    [Description(
        @"Processing batch differs in the counterparty's instruction, for example, day time/real time vs overnight."
    )]
    ProcessingBatchDifference = PendingFailingSettlementCode.ProcessingBatchDifference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Guaranteed delivery indicator differs in the counterparty&apos;s instruction.
    /// Encoded/decoded by serializers as &quot;GUAD&quot;.
    /// </summary>
    [EnumMember(Value = "GUAD")]
    [IsoId("_zdJsdQ93EeGeV5vP7Mvdig_-131996815")]
    [Description(@"Guaranteed delivery indicator differs in the counterparty's instruction.")]
    GuaranteedDeliveryIndicatorDifference =
        PendingFailingSettlementCode.GuaranteedDeliveryIndicatorDifference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is a preadvice, that is, matching only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_zdJsdg93EeGeV5vP7Mvdig_-1824177012")]
    [Description(@"Instruction is a preadvice, that is, matching only.")]
    PreadviceInstructed = PendingFailingSettlementCode.PreadviceInstructed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities are in global form.
    /// Encoded/decoded by serializers as &quot;GLOB&quot;.
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_zdTdcA93EeGeV5vP7Mvdig_-2141953673")]
    [Description(@"Securities are in global form.")]
    GlobalFormSecurities = PendingFailingSettlementCode.GlobalFormSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is in receivership, that is, a form of bankruptcy.
    /// Encoded/decoded by serializers as &quot;CPEC&quot;.
    /// </summary>
    [EnumMember(Value = "CPEC")]
    [IsoId("_zdTdcQ93EeGeV5vP7Mvdig_-1381188520")]
    [Description(@"Counterparty is in receivership, that is, a form of bankruptcy.")]
    CounterpartyInReceivership = PendingFailingSettlementCode.CounterpartyInReceivership, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount is not a multiple of an existing settlement amount lot for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_zdTdcg93EeGeV5vP7Mvdig_-795241494")]
    [Description(
        @"Amount is not a multiple of an existing settlement amount lot for the instructed financial instrument."
    )]
    MultipleSettlementAmount = PendingFailingSettlementCode.MultipleSettlementAmount, // same ordinal as derivation source for type conversions
}
