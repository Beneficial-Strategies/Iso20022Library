// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_am7gdtp-Ed-ak6NoX_4Aeg_1744847021")]
[Description(
    @"Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible."
)]
[DerivedFrom(typeof(PendingFailingReasonCode))]
public enum FailingReason1Code
{
    /// <summary>
    /// Financial instruments are delivered, but still awaiting money from counterparty.
    /// Encoded/decoded by serializers as &quot;AWMO&quot;.
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("_am7gd9p-Ed-ak6NoX_4Aeg_-904852840")]
    [Description(
        @"Financial instruments are delivered, but still awaiting money from counterparty."
    )]
    AwaitingMoney = PendingFailingReasonCode.AwaitingMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Buy-in procedure has started on the market (on your behalf if your instruction is a receipt, by the counterparty if your instruction is a delivery).
    /// Encoded/decoded by serializers as &quot;BYIY&quot;.
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("_am7geNp-Ed-ak6NoX_4Aeg_747774668")]
    [Description(
        @"Buy-in procedure has started on the market (on your behalf if your instruction is a receipt, by the counterparty if your instruction is a delivery)."
    )]
    BuyInProcedure = PendingFailingReasonCode.BuyInProcedure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction was too late for settlement, that is the matching or settlement problems was solved too late.
    /// Encoded/decoded by serializers as &quot;CLAT&quot;.
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_anFRcNp-Ed-ak6NoX_4Aeg_455816930")]
    [Description(
        @"Counterparty's instruction was too late for settlement, that is the matching or settlement problems was solved too late."
    )]
    CounterpartyTooLateForSettlement = PendingFailingReasonCode.CounterpartyTooLateForSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_anFRcdp-Ed-ak6NoX_4Aeg_633935602")]
    [Description(
        @"Instruction was received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was in suspense. Suspense period is finished so your cancellation or confirmation of instruction is required.
    /// Encoded/decoded by serializers as &quot;CANR&quot;.
    /// </summary>
    [EnumMember(Value = "CANR")]
    [IsoId("_anFRctp-Ed-ak6NoX_4Aeg_-1901925193")]
    [Description(
        @"Instruction was in suspense. Suspense period is finished so your cancellation or confirmation of instruction is required."
    )]
    CancellationConfirmationRequested = PendingFailingReasonCode.CancellationConfirmationRequested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting.
    /// Encoded/decoded by serializers as &quot;CAIS&quot;.
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_anFRc9p-Ed-ak6NoX_4Aeg_-249297685")]
    [Description(
        @"Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting."
    )]
    AwaitingSecurities = PendingFailingReasonCode.AwaitingSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are, for example, stolen, in dispute, under objection.
    /// Encoded/decoded by serializers as &quot;OBJT&quot;.
    /// </summary>
    [EnumMember(Value = "OBJT")]
    [IsoId("_anFRdNp-Ed-ak6NoX_4Aeg_-541255423")]
    [Description(@"Financial instruments are, for example, stolen, in dispute, under objection.")]
    UnderObjection = PendingFailingReasonCode.UnderObjection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered.
    /// Encoded/decoded by serializers as &quot;AWSH&quot;.
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_anFRddp-Ed-ak6NoX_4Aeg_-363136751")]
    [Description(
        @"Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered."
    )]
    AwaitingSecuritiesFromCounterparty =
        PendingFailingReasonCode.AwaitingSecuritiesFromCounterparty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is physical. Financial instruments are being delivered.
    /// Encoded/decoded by serializers as &quot;PHSE&quot;.
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("_anFRdtp-Ed-ak6NoX_4Aeg_1395969750")]
    [Description(@"Settlement is physical. Financial instruments are being delivered.")]
    PhysicalDeliveryDelay = PendingFailingReasonCode.PhysicalDeliveryDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Discrepancy in the settlement confirmation.
    /// Encoded/decoded by serializers as &quot;STCD&quot;.
    /// </summary>
    [EnumMember(Value = "STCD")]
    [IsoId("_anFRd9p-Ed-ak6NoX_4Aeg_-1246370038")]
    [Description(@"Discrepancy in the settlement confirmation.")]
    ConfirmationDiscrepency = PendingFailingReasonCode.ConfirmationDiscrepency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as &quot;DOCY&quot;.
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_anFReNp-Ed-ak6NoX_4Aeg_-1538327776")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou =
        PendingFailingReasonCode.AwaitingDocumentsOrEndorsementsFromYou, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Covering money/financial instruments were received too late for completing settlement on a same day basis.
    /// Encoded/decoded by serializers as &quot;MLAT&quot;.
    /// </summary>
    [EnumMember(Value = "MLAT")]
    [IsoId("_anFRedp-Ed-ak6NoX_4Aeg_-1360209104")]
    [Description(
        @"Covering money/financial instruments were received too late for completing settlement on a same day basis."
    )]
    MoneySecuritiesTooLateForSettlement =
        PendingFailingReasonCode.MoneySecuritiesTooLateForSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting documents or endorsements from counterparty.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_anFRetp-Ed-ak6NoX_4Aeg_398897397")]
    [Description(@"Awaiting documents or endorsements from counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty =
        PendingFailingReasonCode.AwaitingDocumentsOrEndorsementsFromCounterparty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_anObYNp-Ed-ak6NoX_4Aeg_2051524905")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked = PendingFailingReasonCode.AccountBlocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A chaser/enquiry has been sent.
    /// Encoded/decoded by serializers as &quot;CHAS&quot;.
    /// </summary>
    [EnumMember(Value = "CHAS")]
    [IsoId("_anObYdp-Ed-ak6NoX_4Aeg_1759567167")]
    [Description(@"A chaser/enquiry has been sent.")]
    EnquirySent = PendingFailingReasonCode.EnquirySent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument is a new issue and not yet available/tradable.
    /// Encoded/decoded by serializers as &quot;NEWI&quot;.
    /// </summary>
    [EnumMember(Value = "NEWI")]
    [IsoId("_anObYtp-Ed-ak6NoX_4Aeg_1937685839")]
    [Description(@"Financial instrument is a new issue and not yet available/tradable.")]
    NewIssues = PendingFailingReasonCode.NewIssues, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient deliverable financial instruments in counterparty&apos;s account or counterparty does not hold financial instruments.
    /// Encoded/decoded by serializers as &quot;CLAC&quot;.
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_anObY9p-Ed-ak6NoX_4Aeg_-598174956")]
    [Description(
        @"Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments."
    )]
    CounterpartyInsufficientSecurities =
        PendingFailingReasonCode.CounterpartyInsufficientSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_anObZNp-Ed-ak6NoX_4Aeg_1054452552")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementAmount = PendingFailingReasonCode.MultipleSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement cannot be executed; financial instruments are in global form.
    /// Encoded/decoded by serializers as &quot;GLOB&quot;.
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_anObZdp-Ed-ak6NoX_4Aeg_762494814")]
    [Description(@"Settlement cannot be executed; financial instruments are in global form.")]
    GlobalFormSecurities = PendingFailingReasonCode.GlobalFormSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_anObZtp-Ed-ak6NoX_4Aeg_940613486")]
    [Description(@"Your instruction is a preadvice, that is, for matching only.")]
    YourInstructionOnHold = PendingFailingReasonCode.YourInstructionOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade will settle in partials.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_anObZ9p-Ed-ak6NoX_4Aeg_57380199")]
    [Description(@"Trade will settle in partials.")]
    TradeSettlesInPartials = PendingFailingReasonCode.TradeSettlesInPartials, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A foreign exchange instruction from you is missing.
    /// Encoded/decoded by serializers as &quot;NOFX&quot;.
    /// </summary>
    [EnumMember(Value = "NOFX")]
    [IsoId("_anObaNp-Ed-ak6NoX_4Aeg_-234577539")]
    [Description(@"A foreign exchange instruction from you is missing.")]
    NoForeignExchangeInstruction = PendingFailingReasonCode.NoForeignExchangeInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in counterparty&apos;s account.
    /// Encoded/decoded by serializers as &quot;CMON&quot;.
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("_anObadp-Ed-ak6NoX_4Aeg_-56458867")]
    [Description(@"Insufficient money in counterparty's account.")]
    CounterpartyInsufficientMoney = PendingFailingReasonCode.CounterpartyInsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient collateral in your account to execute the instruction.
    /// Encoded/decoded by serializers as &quot;YCOL&quot;.
    /// </summary>
    [EnumMember(Value = "YCOL")]
    [IsoId("_anYMYNp-Ed-ak6NoX_4Aeg_1702647634")]
    [Description(@"Insufficient collateral in your account to execute the instruction.")]
    CollateralShortage = PendingFailingReasonCode.CollateralShortage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are not deliverable as they are pledged as collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_anYMYdp-Ed-ak6NoX_4Aeg_-939692154")]
    [Description(@"Financial instruments are not deliverable as they are pledged as collateral.")]
    SecuritiesPledgedAsCollateral = PendingFailingReasonCode.SecuritiesPledgedAsCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction.
    /// Encoded/decoded by serializers as &quot;DEPO&quot;.
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("_anYMYtp-Ed-ak6NoX_4Aeg_-1231649892")]
    [Description(
        @"Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction."
    )]
    RefusedDepositForIssueOfDepositaryReceipts =
        PendingFailingReasonCode.RefusedDepositForIssueOfDepositaryReceipts, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached.
    /// Encoded/decoded by serializers as &quot;FLIM&quot;.
    /// </summary>
    [EnumMember(Value = "FLIM")]
    [IsoId("_anYMY9p-Ed-ak6NoX_4Aeg_-1053531220")]
    [Description(
        @"Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached."
    )]
    MaximumForeignLimitReached = PendingFailingReasonCode.MaximumForeignLimitReached, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments require income adjustment, for example, dividend or interest.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_anYMZNp-Ed-ak6NoX_4Aeg_705575281")]
    [Description(
        @"Financial instruments require income adjustment, for example, dividend or interest."
    )]
    IncomeAdjustementRequired = PendingFailingReasonCode.IncomeAdjustementRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as &quot;LINK&quot;.
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_anYMZdp-Ed-ak6NoX_4Aeg_-1936764507")]
    [Description(
        @"Your instruction is pending settlement because the instruction linked to it is pending."
    )]
    PendingLinkedInstruction = PendingFailingReasonCode.PendingLinkedInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_anYMZtp-Ed-ak6NoX_4Aeg_2066245051")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities = PendingFailingReasonCode.LackOfSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are out on loan.
    /// Encoded/decoded by serializers as &quot;LALO&quot;.
    /// </summary>
    [EnumMember(Value = "LALO")]
    [IsoId("_anYMZ9p-Ed-ak6NoX_4Aeg_-2050603573")]
    [Description(@"Financial instruments are out on loan.")]
    SecuritiesLoanedOut = PendingFailingReasonCode.SecuritiesLoanedOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_anYMaNp-Ed-ak6NoX_4Aeg_-291497072")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney = PendingFailingReasonCode.InsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation of settlement has not yet been received.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_anYMadp-Ed-ak6NoX_4Aeg_1361130436")]
    [Description(@"Confirmation of settlement has not yet been received.")]
    ConfirmationNotReceived = PendingFailingReasonCode.ConfirmationNotReceived, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery/receipt was refused because physical financial instruments are not in good order.
    /// Encoded/decoded by serializers as &quot;REFS&quot;.
    /// </summary>
    [EnumMember(Value = "REFS")]
    [IsoId("_anh9YNp-Ed-ak6NoX_4Aeg_1069172698")]
    [Description(
        @"Delivery/receipt was refused because physical financial instruments are not in good order."
    )]
    NotInGoodOrder = PendingFailingReasonCode.NotInGoodOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_anh9Ydp-Ed-ak6NoX_4Aeg_1247291370")]
    [Description(@"Stamp duty information is missing.")]
    LackOfStampDutyInformation = PendingFailingReasonCode.LackOfStampDutyInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing batch differs in the counterparty&apos;s instruction, for example, daytime/real-time versus overnight.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_anh9Ytp-Ed-ak6NoX_4Aeg_-1288569425")]
    [Description(
        @"Processing batch differs in the counterparty's instruction, for example, daytime/real-time versus overnight."
    )]
    ProcessingBatchDifference = PendingFailingReasonCode.ProcessingBatchDifference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle.
    /// Encoded/decoded by serializers as &quot;CYCL&quot;.
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_anh9Y9p-Ed-ak6NoX_4Aeg_-1323408739")]
    [Description(
        @"Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle."
    )]
    AwaitingNextSettlementCycle = PendingFailingReasonCode.AwaitingNextSettlementCycle, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are blocked due to, for example, a corporate action event, realignment.
    /// Encoded/decoded by serializers as &quot;SBLO&quot;.
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_anh9ZNp-Ed-ak6NoX_4Aeg_-1615366477")]
    [Description(
        @"Financial instruments are blocked due to, for example, a corporate action event, realignment."
    )]
    SecuritiesBlocked = PendingFailingReasonCode.SecuritiesBlocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business).
    /// Encoded/decoded by serializers as &quot;CPEC&quot;.
    /// </summary>
    [EnumMember(Value = "CPEC")]
    [IsoId("_anh9Zdp-Ed-ak6NoX_4Aeg_-1437247805")]
    [Description(
        @"Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business)."
    )]
    CounterpartyInReceivership = PendingFailingReasonCode.CounterpartyInReceivership, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_anh9Ztp-Ed-ak6NoX_4Aeg_321858696")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementAmount = PendingFailingReasonCode.MinimumSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending reason being investigated.
    /// Encoded/decoded by serializers as &quot;IAAD&quot;.
    /// </summary>
    [EnumMember(Value = "IAAD")]
    [IsoId("_anh9Z9p-Ed-ak6NoX_4Aeg_1974486204")]
    [Description(@"Pending reason being investigated.")]
    StatusReasonInvestigation = PendingFailingReasonCode.StatusReasonInvestigation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_anh9aNp-Ed-ak6NoX_4Aeg_1682528466")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical financial instruments have been received and are being checked for authenticity.
    /// Encoded/decoded by serializers as &quot;PHCK&quot;.
    /// </summary>
    [EnumMember(Value = "PHCK")]
    [IsoId("_anh9adp-Ed-ak6NoX_4Aeg_1860647138")]
    [Description(
        @"Physical financial instruments have been received and are being checked for authenticity."
    )]
    PhysicalSecuritiesVerification = PendingFailingReasonCode.PhysicalSecuritiesVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disagreement in beneficial ownership.
    /// Encoded/decoded by serializers as &quot;BENO&quot;.
    /// </summary>
    [EnumMember(Value = "BENO")]
    [IsoId("_anh9atp-Ed-ak6NoX_4Aeg_-675213657")]
    [Description(@"Disagreement in beneficial ownership.")]
    BeneficialOwnershipDisagreement = PendingFailingReasonCode.BeneficialOwnershipDisagreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction and your instruction are on hold/frozen/ in a preadvice mode.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_anrHUNp-Ed-ak6NoX_4Aeg_977413851")]
    [Description(
        @"Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode."
    )]
    BothInstructionsOnHold = PendingFailingReasonCode.BothInstructionsOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India.
    /// Encoded/decoded by serializers as &quot;CLHT&quot;.
    /// </summary>
    [EnumMember(Value = "CLHT")]
    [IsoId("_anrHUdp-Ed-ak6NoX_4Aeg_685456113")]
    [Description(
        @"Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India."
    )]
    ClearingHouseTrade = PendingFailingReasonCode.ClearingHouseTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities.
    /// Encoded/decoded by serializers as &quot;DENO&quot;.
    /// </summary>
    [EnumMember(Value = "DENO")]
    [IsoId("_anrHUtp-Ed-ak6NoX_4Aeg_863574785")]
    [Description(
        @"Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities."
    )]
    UnavailableDeliverableDenominatedQuantity =
        PendingFailingReasonCode.UnavailableDeliverableDenominatedQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exceptional closing of all financial institutions due to natural disaster, for example, earthquake.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_anrHU9p-Ed-ak6NoX_4Aeg_-1672286010")]
    [Description(
        @"Exceptional closing of all financial institutions due to natural disaster, for example, earthquake."
    )]
    NaturalDisaster = PendingFailingReasonCode.NaturalDisaster, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty has returned or refuses the securities.
    /// Encoded/decoded by serializers as &quot;DKNY&quot;.
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("_anrHVNp-Ed-ak6NoX_4Aeg_-19658502")]
    [Description(@"Counterparty has returned or refuses the securities.")]
    CounterpartyReturnedShares = PendingFailingReasonCode.CounterpartyReturnedShares, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event.
    /// Encoded/decoded by serializers as &quot;FROZ&quot;.
    /// </summary>
    [EnumMember(Value = "FROZ")]
    [IsoId("_anrHVdp-Ed-ak6NoX_4Aeg_-311616240")]
    [Description(
        @"Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event."
    )]
    SecuritiesFrozenAtCSD = PendingFailingReasonCode.SecuritiesFrozenAtCSD, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting settlement of a purchase to cover failing positions.
    /// Encoded/decoded by serializers as &quot;LAAW&quot;.
    /// </summary>
    [EnumMember(Value = "LAAW")]
    [IsoId("_anrHVtp-Ed-ak6NoX_4Aeg_-133497568")]
    [Description(@"Awaiting settlement of a purchase to cover failing positions.")]
    AwaitingOtherTransaction = PendingFailingReasonCode.AwaitingOtherTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_anrHV9p-Ed-ak6NoX_4Aeg_1625608933")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = PendingFailingReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central bank liquidity is insufficient.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_anrHWNp-Ed-ak6NoX_4Aeg_-1016730855")]
    [Description(@"Central bank liquidity is insufficient.")]
    InsufficientCentralBankLiquidity = PendingFailingReasonCode.InsufficientCentralBankLiquidity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PRCY&quot;.
    /// </summary>
    [EnumMember(Value = "PRCY")]
    [IsoId("_anrHWdp-Ed-ak6NoX_4Aeg_-1308688593")]
    [Description(@"Counterparty's instruction is a preadvice, that is, for matching only.")]
    CounterpartyInstructionOnHold = PendingFailingReasonCode.CounterpartyInstructionOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached.
    /// Encoded/decoded by serializers as &quot;REGT&quot;.
    /// </summary>
    [EnumMember(Value = "REGT")]
    [IsoId("_an04UNp-Ed-ak6NoX_4Aeg_-1130569921")]
    [Description(
        @"Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached."
    )]
    CertificatesRejected = PendingFailingReasonCode.CertificatesRejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement system/method has been modified at central securities depository to allow settlement.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_an04Udp-Ed-ak6NoX_4Aeg_628536580")]
    [Description(
        @"Settlement system/method has been modified at central securities depository to allow settlement."
    )]
    SettlementSystemMethodModified = PendingFailingReasonCode.SettlementSystemMethodModified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_an04Utp-Ed-ak6NoX_4Aeg_-2013803208")]
    [Description(@"Certificate number error.")]
    WrongCertificatesNumbers = PendingFailingReasonCode.WrongCertificatesNumbers, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction was put on hold/frozen by the system.
    /// Encoded/decoded by serializers as &quot;PRSY&quot;.
    /// </summary>
    [EnumMember(Value = "PRSY")]
    [IsoId("_an04U9p-Ed-ak6NoX_4Aeg_-1746851229")]
    [Description(@"Transaction was put on hold/frozen by the system.")]
    SystemOnHold = PendingFailingReasonCode.SystemOnHold, // same ordinal as derivation source for type conversions
}
