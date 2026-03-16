// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_u0BzoSW-EeygjNFjAlVoPA")]
[Description(
    @"Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible."
)]
[DerivedFrom(typeof(PendingFailingReasonV2Code))]
public enum FailingReason4Code
{
    /// <summary>
    /// Financial instruments are delivered, but still awaiting money from counterparty.
    /// Encoded/decoded by serializers as &quot;AWMO&quot;.
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("_QUsRcSXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Financial instruments are delivered, but still awaiting money from counterparty."
    )]
    AwaitingMoney = PendingFailingReasonV2Code.AwaitingMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Buy-in procedure has started on the market (on your behalf if your instruction is a receipt, by the counterparty if your instruction is a delivery).
    /// Encoded/decoded by serializers as &quot;BYIY&quot;.
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("_QUsRcyXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Buy-in procedure has started on the market (on your behalf if your instruction is a receipt, by the counterparty if your instruction is a delivery)."
    )]
    BuyInProcedure = PendingFailingReasonV2Code.BuyInProcedure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction was too late for settlement, that is the matching or settlement problems was solved too late.
    /// Encoded/decoded by serializers as &quot;CLAT&quot;.
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_QUsRdSXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Counterparty's instruction was too late for settlement, that is the matching or settlement problems was solved too late."
    )]
    CounterpartyTooLateForSettlement = PendingFailingReasonV2Code.CounterpartyTooLateForSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_QUsRdyXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Instruction was received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was in suspense. Suspense period is finished so your cancellation or confirmation of instruction is required.
    /// Encoded/decoded by serializers as &quot;CANR&quot;.
    /// </summary>
    [EnumMember(Value = "CANR")]
    [IsoId("_QUsReSXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Instruction was in suspense. Suspense period is finished so your cancellation or confirmation of instruction is required."
    )]
    CancellationConfirmationRequested =
        PendingFailingReasonV2Code.CancellationConfirmationRequested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting.
    /// Encoded/decoded by serializers as &quot;CAIS&quot;.
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_QUsReyXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting."
    )]
    AwaitingSecurities = PendingFailingReasonV2Code.AwaitingSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are stolen, in dispute, under objection etc.
    /// Encoded/decoded by serializers as &quot;OBJT&quot;.
    /// </summary>
    [EnumMember(Value = "OBJT")]
    [IsoId("_QUsRfSXAEeyr3ZXX_BfH2g")]
    [Description(@"Financial instruments are stolen, in dispute, under objection etc.")]
    UnderObjection = PendingFailingReasonV2Code.UnderObjection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered.
    /// Encoded/decoded by serializers as &quot;AWSH&quot;.
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_QUsRfyXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered."
    )]
    AwaitingSecuritiesFromCounterparty =
        PendingFailingReasonV2Code.AwaitingSecuritiesFromCounterparty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is physical. Financial instruments are being delivered.
    /// Encoded/decoded by serializers as &quot;PHSE&quot;.
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("_QUsRgSXAEeyr3ZXX_BfH2g")]
    [Description(@"Settlement is physical. Financial instruments are being delivered.")]
    PhysicalDeliveryDelay = PendingFailingReasonV2Code.PhysicalDeliveryDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Discrepancy in the settlement confirmation.
    /// Encoded/decoded by serializers as &quot;STCD&quot;.
    /// </summary>
    [EnumMember(Value = "STCD")]
    [IsoId("_QUsRgyXAEeyr3ZXX_BfH2g")]
    [Description(@"Discrepancy in the settlement confirmation.")]
    ConfirmationDiscrepency = PendingFailingReasonV2Code.ConfirmationDiscrepency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as &quot;DOCY&quot;.
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_QUsRhSXAEeyr3ZXX_BfH2g")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou =
        PendingFailingReasonV2Code.AwaitingDocumentsOrEndorsementsFromYou, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Covering money/financial instruments were received too late for completing settlement on a same day basis.
    /// Encoded/decoded by serializers as &quot;MLAT&quot;.
    /// </summary>
    [EnumMember(Value = "MLAT")]
    [IsoId("_QUsRhyXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Covering money/financial instruments were received too late for completing settlement on a same day basis."
    )]
    MoneySecuritiesTooLateForSettlement =
        PendingFailingReasonV2Code.MoneySecuritiesTooLateForSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting documents or endorsements from counterparty.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_QUsRiSXAEeyr3ZXX_BfH2g")]
    [Description(@"Awaiting documents or endorsements from counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty =
        PendingFailingReasonV2Code.AwaitingDocumentsOrEndorsementsFromCounterparty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_QUsRiyXAEeyr3ZXX_BfH2g")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked = PendingFailingReasonV2Code.AccountBlocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A chaser/enquiry has been sent.
    /// Encoded/decoded by serializers as &quot;CHAS&quot;.
    /// </summary>
    [EnumMember(Value = "CHAS")]
    [IsoId("_QUsRjSXAEeyr3ZXX_BfH2g")]
    [Description(@"A chaser/enquiry has been sent.")]
    EnquirySent = PendingFailingReasonV2Code.EnquirySent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument is a new issue and not yet available/tradable.
    /// Encoded/decoded by serializers as &quot;NEWI&quot;.
    /// </summary>
    [EnumMember(Value = "NEWI")]
    [IsoId("_QUsRjyXAEeyr3ZXX_BfH2g")]
    [Description(@"Financial instrument is a new issue and not yet available/tradable.")]
    NewIssues = PendingFailingReasonV2Code.NewIssues, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient deliverable financial instruments in counterparty&apos;s account or counterparty does not hold financial instruments.
    /// Encoded/decoded by serializers as &quot;CLAC&quot;.
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_QUsRkSXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments."
    )]
    CounterpartyInsufficientSecurities =
        PendingFailingReasonV2Code.CounterpartyInsufficientSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_QUsRkyXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementAmount = PendingFailingReasonV2Code.MultipleSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement cannot be executed; financial instruments are in global form.
    /// Encoded/decoded by serializers as &quot;GLOB&quot;.
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_QUsRlSXAEeyr3ZXX_BfH2g")]
    [Description(@"Settlement cannot be executed; financial instruments are in global form.")]
    GlobalFormSecurities = PendingFailingReasonV2Code.GlobalFormSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_QUsRlyXAEeyr3ZXX_BfH2g")]
    [Description(@"Your instruction is a preadvice, that is, for matching only.")]
    YourInstructionOnHold = PendingFailingReasonV2Code.YourInstructionOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade will settle in partials.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_QUsRmSXAEeyr3ZXX_BfH2g")]
    [Description(@"Trade will settle in partials.")]
    TradeSettlesInPartials = PendingFailingReasonV2Code.TradeSettlesInPartials, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A foreign exchange instruction from you is missing.
    /// Encoded/decoded by serializers as &quot;NOFX&quot;.
    /// </summary>
    [EnumMember(Value = "NOFX")]
    [IsoId("_QUsRmyXAEeyr3ZXX_BfH2g")]
    [Description(@"A foreign exchange instruction from you is missing.")]
    NoForeignExchangeInstruction = PendingFailingReasonV2Code.NoForeignExchangeInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in counterparty&apos;s account.
    /// Encoded/decoded by serializers as &quot;CMON&quot;.
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("_QUsRnSXAEeyr3ZXX_BfH2g")]
    [Description(@"Insufficient money in counterparty's account.")]
    CounterpartyInsufficientMoney = PendingFailingReasonV2Code.CounterpartyInsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient collateral in your account to execute the instruction.
    /// Encoded/decoded by serializers as &quot;YCOL&quot;.
    /// </summary>
    [EnumMember(Value = "YCOL")]
    [IsoId("_QUsRnyXAEeyr3ZXX_BfH2g")]
    [Description(@"Insufficient collateral in your account to execute the instruction.")]
    CollateralShortage = PendingFailingReasonV2Code.CollateralShortage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are not deliverable as they are pledged as collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_QUsRoSXAEeyr3ZXX_BfH2g")]
    [Description(@"Financial instruments are not deliverable as they are pledged as collateral.")]
    SecuritiesPledgedAsCollateral = PendingFailingReasonV2Code.SecuritiesPledgedAsCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction.
    /// Encoded/decoded by serializers as &quot;DEPO&quot;.
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("_QUsRoyXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction."
    )]
    RefusedDepositForIssueOfDepositaryReceipts =
        PendingFailingReasonV2Code.RefusedDepositForIssueOfDepositaryReceipts, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached.
    /// Encoded/decoded by serializers as &quot;FLIM&quot;.
    /// </summary>
    [EnumMember(Value = "FLIM")]
    [IsoId("_QUsRpSXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached."
    )]
    MaximumForeignLimitReached = PendingFailingReasonV2Code.MaximumForeignLimitReached, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments require income adjustment, for example, dividend or interest.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_QUsRpyXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Financial instruments require income adjustment, for example, dividend or interest."
    )]
    IncomeAdjustementRequired = PendingFailingReasonV2Code.IncomeAdjustementRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as &quot;LINK&quot;.
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_QUsRqSXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Your instruction is pending settlement because the instruction linked to it is pending."
    )]
    PendingLinkedInstruction = PendingFailingReasonV2Code.PendingLinkedInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_QUsRqyXAEeyr3ZXX_BfH2g")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities = PendingFailingReasonV2Code.LackOfSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are out on loan.
    /// Encoded/decoded by serializers as &quot;LALO&quot;.
    /// </summary>
    [EnumMember(Value = "LALO")]
    [IsoId("_QUsRrSXAEeyr3ZXX_BfH2g")]
    [Description(@"Financial instruments are out on loan.")]
    SecuritiesLoanedOut = PendingFailingReasonV2Code.SecuritiesLoanedOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_QUsRryXAEeyr3ZXX_BfH2g")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney = PendingFailingReasonV2Code.InsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation of settlement has not yet been received.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_QUsRsSXAEeyr3ZXX_BfH2g")]
    [Description(@"Confirmation of settlement has not yet been received.")]
    ConfirmationNotReceived = PendingFailingReasonV2Code.ConfirmationNotReceived, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery/receipt was refused because physical financial instruments are not in good order.
    /// Encoded/decoded by serializers as &quot;REFS&quot;.
    /// </summary>
    [EnumMember(Value = "REFS")]
    [IsoId("_QUsRsyXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Delivery/receipt was refused because physical financial instruments are not in good order."
    )]
    NotInGoodOrder = PendingFailingReasonV2Code.NotInGoodOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_QUsRtSXAEeyr3ZXX_BfH2g")]
    [Description(@"Stamp duty information is missing.")]
    LackOfStampDutyInformation = PendingFailingReasonV2Code.LackOfStampDutyInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing batch differs in the counterparty&apos;s instruction, for example, daytime/real-time versus overnight.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_QUsRtyXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Processing batch differs in the counterparty's instruction, for example, daytime/real-time versus overnight."
    )]
    ProcessingBatchDifference = PendingFailingReasonV2Code.ProcessingBatchDifference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle.
    /// Encoded/decoded by serializers as &quot;CYCL&quot;.
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_QUsRuSXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle."
    )]
    AwaitingNextSettlementCycle = PendingFailingReasonV2Code.AwaitingNextSettlementCycle, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are blocked due to a corporate action event, realignment, etc.
    /// Encoded/decoded by serializers as &quot;SBLO&quot;.
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_QUsRuyXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Financial instruments are blocked due to a corporate action event, realignment, etc."
    )]
    SecuritiesBlocked = PendingFailingReasonV2Code.SecuritiesBlocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business).
    /// Encoded/decoded by serializers as &quot;CPEC&quot;.
    /// </summary>
    [EnumMember(Value = "CPEC")]
    [IsoId("_QUsRvSXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business)."
    )]
    CounterpartyInReceivership = PendingFailingReasonV2Code.CounterpartyInReceivership, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_QUsRvyXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementAmount = PendingFailingReasonV2Code.MinimumSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending reason being investigated.
    /// Encoded/decoded by serializers as &quot;IAAD&quot;.
    /// </summary>
    [EnumMember(Value = "IAAD")]
    [IsoId("_QUsRwSXAEeyr3ZXX_BfH2g")]
    [Description(@"Pending reason being investigated.")]
    StatusReasonInvestigation = PendingFailingReasonV2Code.StatusReasonInvestigation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_QUsRwyXAEeyr3ZXX_BfH2g")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical financial instruments have been received and are being checked for authenticity.
    /// Encoded/decoded by serializers as &quot;PHCK&quot;.
    /// </summary>
    [EnumMember(Value = "PHCK")]
    [IsoId("_QUsRxSXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Physical financial instruments have been received and are being checked for authenticity."
    )]
    PhysicalSecuritiesVerification = PendingFailingReasonV2Code.PhysicalSecuritiesVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disagreement in beneficial ownership.
    /// Encoded/decoded by serializers as &quot;BENO&quot;.
    /// </summary>
    [EnumMember(Value = "BENO")]
    [IsoId("_QUsRxyXAEeyr3ZXX_BfH2g")]
    [Description(@"Disagreement in beneficial ownership.")]
    BeneficialOwnershipDisagreement = PendingFailingReasonV2Code.BeneficialOwnershipDisagreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction and your instruction are on hold/frozen/ in a preadvice mode.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_QUsRySXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode."
    )]
    BothInstructionsOnHold = PendingFailingReasonV2Code.BothInstructionsOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India.
    /// Encoded/decoded by serializers as &quot;CLHT&quot;.
    /// </summary>
    [EnumMember(Value = "CLHT")]
    [IsoId("_QUsRyyXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India."
    )]
    ClearingHouseTrade = PendingFailingReasonV2Code.ClearingHouseTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities.
    /// Encoded/decoded by serializers as &quot;DENO&quot;.
    /// </summary>
    [EnumMember(Value = "DENO")]
    [IsoId("_QUsRzSXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities."
    )]
    UnavailableDeliverableDenominatedQuantity =
        PendingFailingReasonV2Code.UnavailableDeliverableDenominatedQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exceptional closing of all financial institutions due to natural disaster, for example, earthquake.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_QUsRzyXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Exceptional closing of all financial institutions due to natural disaster, for example, earthquake."
    )]
    NaturalDisaster = PendingFailingReasonV2Code.NaturalDisaster, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty has returned or refuses the securities.
    /// Encoded/decoded by serializers as &quot;DKNY&quot;.
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("_QUsR0SXAEeyr3ZXX_BfH2g")]
    [Description(@"Counterparty has returned or refuses the securities.")]
    CounterpartyReturnedShares = PendingFailingReasonV2Code.CounterpartyReturnedShares, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event.
    /// Encoded/decoded by serializers as &quot;FROZ&quot;.
    /// </summary>
    [EnumMember(Value = "FROZ")]
    [IsoId("_QUsR0yXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event."
    )]
    SecuritiesFrozenAtCSD = PendingFailingReasonV2Code.SecuritiesFrozenAtCSD, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting settlement of a purchase to cover failing positions.
    /// Encoded/decoded by serializers as &quot;LAAW&quot;.
    /// </summary>
    [EnumMember(Value = "LAAW")]
    [IsoId("_QUsR1SXAEeyr3ZXX_BfH2g")]
    [Description(@"Awaiting settlement of a purchase to cover failing positions.")]
    AwaitingOtherTransaction = PendingFailingReasonV2Code.AwaitingOtherTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_QUsR1yXAEeyr3ZXX_BfH2g")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = PendingFailingReasonV2Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central bank liquidity is insufficient.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_QUsR2SXAEeyr3ZXX_BfH2g")]
    [Description(@"Central bank liquidity is insufficient.")]
    InsufficientCentralBankLiquidity = PendingFailingReasonV2Code.InsufficientCentralBankLiquidity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PRCY&quot;.
    /// </summary>
    [EnumMember(Value = "PRCY")]
    [IsoId("_QUsR2yXAEeyr3ZXX_BfH2g")]
    [Description(@"Counterparty's instruction is a preadvice, that is, for matching only.")]
    CounterpartyInstructionOnHold = PendingFailingReasonV2Code.CounterpartyInstructionOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached.
    /// Encoded/decoded by serializers as &quot;REGT&quot;.
    /// </summary>
    [EnumMember(Value = "REGT")]
    [IsoId("_QUsR3SXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached."
    )]
    CertificatesRejected = PendingFailingReasonV2Code.CertificatesRejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement system/method has been modified at central securities depository to allow settlement.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_QUsR3yXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Settlement system/method has been modified at central securities depository to allow settlement."
    )]
    SettlementSystemMethodModified = PendingFailingReasonV2Code.SettlementSystemMethodModified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_QUsR4SXAEeyr3ZXX_BfH2g")]
    [Description(@"Certificate number error.")]
    WrongCertificatesNumbers = PendingFailingReasonV2Code.WrongCertificatesNumbers, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction was put on hold/frozen by the system.
    /// Encoded/decoded by serializers as &quot;PRSY&quot;.
    /// </summary>
    [EnumMember(Value = "PRSY")]
    [IsoId("_QUsR4yXAEeyr3ZXX_BfH2g")]
    [Description(@"Transaction was put on hold/frozen by the system.")]
    SystemOnHold = PendingFailingReasonV2Code.SystemOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode. Market infrastructure platform is awaiting release.
    /// Encoded/decoded by serializers as &quot;CDLR&quot;.
    /// </summary>
    [EnumMember(Value = "CDLR")]
    [IsoId("_QUsR5SXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Instruction is in a hold/frozen/preadvice mode. Market infrastructure platform is awaiting release."
    )]
    ConditionalDeliveryAwaitingRelease =
        PendingFailingReasonV2Code.ConditionalDeliveryAwaitingRelease, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central securities depository sets the instruction in a hold/frozen/preadvice mode.
    /// Encoded/decoded by serializers as &quot;CSDH&quot;.
    /// </summary>
    [EnumMember(Value = "CSDH")]
    [IsoId("_QUsR5yXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Central securities depository sets the instruction in a hold/frozen/preadvice mode."
    )]
    CSDHold = PendingFailingReasonV2Code.CSDHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform.
    /// Encoded/decoded by serializers as &quot;CVAL&quot;.
    /// </summary>
    [EnumMember(Value = "CVAL")]
    [IsoId("_QUsR6SXAEeyr3ZXX_BfH2g")]
    [Description(
        @"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform."
    )]
    CSDValidation = PendingFailingReasonV2Code.CSDValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Not all the instructions part of a pool have been received.
    /// Encoded/decoded by serializers as &quot;INBC&quot;.
    /// </summary>
    [EnumMember(Value = "INBC")]
    [IsoId("_QUsR6yXAEeyr3ZXX_BfH2g")]
    [Description(@"Not all the instructions part of a pool have been received.")]
    IncompleteNumberCount = PendingFailingReasonV2Code.IncompleteNumberCount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been partially released.
    /// Encoded/decoded by serializers as &quot;PREL&quot;.
    /// </summary>
    [EnumMember(Value = "PREL")]
    [IsoId("_UGiLYSXAEeyr3ZXX_BfH2g")]
    [Description(@"Transaction has been partially released.")]
    PartiallyReleased = PendingFailingReasonV2Code.PartiallyReleased, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disagreement on partial indicator preventing partial settlement.
    /// Encoded/decoded by serializers as &quot;PATD&quot;.
    /// </summary>
    [EnumMember(Value = "PATD")]
    [IsoId("_B3NwgSgLEeym1_Zp1BTvEw")]
    [Description(@"Disagreement on partial indicator preventing partial settlement.")]
    PartialDiffer = PendingFailingReasonV2Code.PartialDiffer, // same ordinal as derivation source for type conversions
}
