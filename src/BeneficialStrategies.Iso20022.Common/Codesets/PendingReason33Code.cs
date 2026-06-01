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
[IsoId("_dB0WIKoPEfCG2_q2WT-90w")]
[Description(
    @"Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing."
)]
[DerivedFrom(typeof(PendingFailingReasonV3Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PendingReason33Code>))]
public enum PendingReason33Code
{
    /// <summary>
    /// Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_71mCwym7EfGfZ9PfK70MMg")]
    [Description(
        @"Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax reclaim has been sent to the tax authorities.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_71mDNSm7EfGfZ9PfK70MMg")]
    [Description(@"Tax reclaim has been sent to the tax authorities.")]
    SentToTaxAuthorities = PendingFailingReasonV3Code.SentToTaxAuthorities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are delivered, but still awaiting money from counterparty.
    /// Encoded/decoded by serializers as &quot;AWMO&quot;.
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("_71mCyym7EfGfZ9PfK70MMg")]
    [Description(
        @"Financial instruments are delivered, but still awaiting money from counterparty."
    )]
    AwaitingMoney = PendingFailingReasonV3Code.AwaitingMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered.
    /// Encoded/decoded by serializers as &quot;AWSH&quot;.
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_71mC0ym7EfGfZ9PfK70MMg")]
    [Description(
        @"Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered."
    )]
    AwaitingSecuritiesFromCounterparty = PendingFailingReasonV3Code.AwaitingSecuritiesFromCounterparty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing batch differs in the counterparty's instruction, for example, daytime/real-time versus overnight.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_71mDJym7EfGfZ9PfK70MMg")]
    [Description(
        @"Processing batch differs in the counterparty's instruction, for example, daytime/real-time versus overnight."
    )]
    ProcessingBatchDifference = PendingFailingReasonV3Code.ProcessingBatchDifference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disagreement in beneficial ownership.
    /// Encoded/decoded by serializers as &quot;BENO&quot;.
    /// </summary>
    [EnumMember(Value = "BENO")]
    [IsoId("_71mC1ym7EfGfZ9PfK70MMg")]
    [Description(@"Disagreement in beneficial ownership.")]
    BeneficialOwnershipDisagreement = PendingFailingReasonV3Code.BeneficialOwnershipDisagreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_71mCwSm7EfGfZ9PfK70MMg")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked = PendingFailingReasonV3Code.AccountBlocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_71mC2Sm7EfGfZ9PfK70MMg")]
    [Description(
        @"Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode."
    )]
    BothInstructionsOnHold = PendingFailingReasonV3Code.BothInstructionsOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting.
    /// Encoded/decoded by serializers as &quot;CAIS&quot;.
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_71mC0Sm7EfGfZ9PfK70MMg")]
    [Description(
        @"Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting."
    )]
    AwaitingSecurities = PendingFailingReasonV3Code.AwaitingSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is conditional to the execution of a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as &quot;CDCY&quot;.
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("_71mC3Sm7EfGfZ9PfK70MMg")]
    [Description(
        @"Execution is conditional to the execution of a process linked to the currency of the transaction."
    )]
    ConditionalCurrency = PendingFailingReasonV3Code.ConditionalCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is conditional to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as &quot;CDRE&quot;.
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("_71mC5Sm7EfGfZ9PfK70MMg")]
    [Description(
        @"Execution is conditional to the execution of a process of realignment at the issuer CSD."
    )]
    ConditionalRealignement = PendingFailingReasonV3Code.ConditionalRealignement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is conditional to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as &quot;CDRG&quot;.
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("_71mC5ym7EfGfZ9PfK70MMg")]
    [Description(@"Execution is conditional to the execution of a process at the registrar.")]
    ConditionalRegistrar = PendingFailingReasonV3Code.ConditionalRegistrar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A chaser/enquiry has been sent.
    /// Encoded/decoded by serializers as &quot;CHAS&quot;.
    /// </summary>
    [EnumMember(Value = "CHAS")]
    [IsoId("_71mC9Sm7EfGfZ9PfK70MMg")]
    [Description(@"A chaser/enquiry has been sent.")]
    EnquirySent = PendingFailingReasonV3Code.EnquirySent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments.
    /// Encoded/decoded by serializers as &quot;CLAC&quot;.
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_71mC8Sm7EfGfZ9PfK70MMg")]
    [Description(
        @"Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments."
    )]
    CounterpartyInsufficientSecurities = PendingFailingReasonV3Code.CounterpartyInsufficientSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India.
    /// Encoded/decoded by serializers as &quot;CLHT&quot;.
    /// </summary>
    [EnumMember(Value = "CLHT")]
    [IsoId("_71mC4Sm7EfGfZ9PfK70MMg")]
    [Description(
        @"Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India."
    )]
    ClearingHouseTrade = PendingFailingReasonV3Code.ClearingHouseTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in counterparty's account.
    /// Encoded/decoded by serializers as &quot;CMON&quot;.
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("_71mC7ym7EfGfZ9PfK70MMg")]
    [Description(@"Insufficient money in counterparty's account.")]
    CounterpartyInsufficientMoney = PendingFailingReasonV3Code.CounterpartyInsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are not deliverable as they are pledged as collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_71mDMym7EfGfZ9PfK70MMg")]
    [Description(@"Financial instruments are not deliverable as they are pledged as collateral.")]
    SecuritiesPledgedAsCollateral = PendingFailingReasonV3Code.SecuritiesPledgedAsCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting confirmation from the counterparty.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_71mCxSm7EfGfZ9PfK70MMg")]
    [Description(@"Awaiting confirmation from the counterparty.")]
    AwaitingConfirmation = PendingFailingReasonV3Code.AwaitingConfirmation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business).
    /// Encoded/decoded by serializers as &quot;CPEC&quot;.
    /// </summary>
    [EnumMember(Value = "CPEC")]
    [IsoId("_71mC6ym7EfGfZ9PfK70MMg")]
    [Description(
        @"Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business)."
    )]
    CounterpartyInReceivership = PendingFailingReasonV3Code.CounterpartyInReceivership, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle.
    /// Encoded/decoded by serializers as &quot;CYCL&quot;.
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_71mCzSm7EfGfZ9PfK70MMg")]
    [Description(
        @"Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle."
    )]
    AwaitingNextSettlementCycle = PendingFailingReasonV3Code.AwaitingNextSettlementCycle, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities.
    /// Encoded/decoded by serializers as &quot;DENO&quot;.
    /// </summary>
    [EnumMember(Value = "DENO")]
    [IsoId("_71mDQSm7EfGfZ9PfK70MMg")]
    [Description(
        @"Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities."
    )]
    UnavailableDeliverableDenominatedQuantity = PendingFailingReasonV3Code.UnavailableDeliverableDenominatedQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction.
    /// Encoded/decoded by serializers as &quot;DEPO&quot;.
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("_71mDKym7EfGfZ9PfK70MMg")]
    [Description(
        @"Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction."
    )]
    RefusedDepositForIssueOfDepositaryReceipts = PendingFailingReasonV3Code.RefusedDepositForIssueOfDepositaryReceipts, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exceptional closing of all financial institutions due to natural disaster, for example, earthquake.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_71mDDym7EfGfZ9PfK70MMg")]
    [Description(
        @"Exceptional closing of all financial institutions due to natural disaster, for example, earthquake."
    )]
    NaturalDisaster = PendingFailingReasonV3Code.NaturalDisaster, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty has returned or refuses the securities.
    /// Encoded/decoded by serializers as &quot;DKNY&quot;.
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("_71mC8ym7EfGfZ9PfK70MMg")]
    [Description(@"Counterparty has returned or refuses the securities.")]
    CounterpartyReturnedShares = PendingFailingReasonV3Code.CounterpartyReturnedShares, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting documents or endorsements from counterparty.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_71mCxym7EfGfZ9PfK70MMg")]
    [Description(@"Awaiting documents or endorsements from counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty = PendingFailingReasonV3Code.AwaitingDocumentsOrEndorsementsFromCounterparty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as &quot;DOCY&quot;.
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_71mCySm7EfGfZ9PfK70MMg")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou = PendingFailingReasonV3Code.AwaitingDocumentsOrEndorsementsFromYou, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_71mDKSm7EfGfZ9PfK70MMg")]
    [Description(@"Quantity of financial instruments does not match.")]
    QuantityDisagreement = PendingFailingReasonV3Code.QuantityDisagreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached.
    /// Encoded/decoded by serializers as &quot;FLIM&quot;.
    /// </summary>
    [EnumMember(Value = "FLIM")]
    [IsoId("_71mDBym7EfGfZ9PfK70MMg")]
    [Description(
        @"Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached."
    )]
    MaximumForeignLimitReached = PendingFailingReasonV3Code.MaximumForeignLimitReached, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event.
    /// Encoded/decoded by serializers as &quot;FROZ&quot;.
    /// </summary>
    [EnumMember(Value = "FROZ")]
    [IsoId("_71mDLym7EfGfZ9PfK70MMg")]
    [Description(
        @"Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event."
    )]
    SecuritiesFrozenAtCSD = PendingFailingReasonV3Code.SecuritiesFrozenAtCSD, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting settlement date. No settlement problems to be reported.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_71mC1Sm7EfGfZ9PfK70MMg")]
    [Description(@"Awaiting settlement date. No settlement problems to be reported.")]
    AwaitingSettlementDate = PendingFailingReasonV3Code.AwaitingSettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement cannot be executed; financial instruments are in global form.
    /// Encoded/decoded by serializers as &quot;GLOB&quot;.
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_71mC9ym7EfGfZ9PfK70MMg")]
    [Description(@"Settlement cannot be executed; financial instruments are in global form.")]
    GlobalFormSecurities = PendingFailingReasonV3Code.GlobalFormSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending reason being investigated.
    /// Encoded/decoded by serializers as &quot;IAAD&quot;.
    /// </summary>
    [EnumMember(Value = "IAAD")]
    [IsoId("_71mDOSm7EfGfZ9PfK70MMg")]
    [Description(@"Pending reason being investigated.")]
    StatusReasonInvestigation = PendingFailingReasonV3Code.StatusReasonInvestigation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments require income adjustment, for example, dividend or interest.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_71mC-Sm7EfGfZ9PfK70MMg")]
    [Description(
        @"Financial instruments require income adjustment, for example, dividend or interest."
    )]
    IncomeAdjustementRequired = PendingFailingReasonV3Code.IncomeAdjustementRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been processed and cannot be cancelled.
    /// Encoded/decoded by serializers as &quot;IPNC&quot;.
    /// </summary>
    [EnumMember(Value = "IPNC")]
    [IsoId("_71mC2ym7EfGfZ9PfK70MMg")]
    [Description(@"Instruction has been processed and cannot be cancelled.")]
    CancelNotPossible = PendingFailingReasonV3Code.CancelNotPossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting settlement of a purchase to cover failing positions.
    /// Encoded/decoded by serializers as &quot;LAAW&quot;.
    /// </summary>
    [EnumMember(Value = "LAAW")]
    [IsoId("_71mCzym7EfGfZ9PfK70MMg")]
    [Description(@"Awaiting settlement of a purchase to cover failing positions.")]
    AwaitingOtherTransaction = PendingFailingReasonV3Code.AwaitingOtherTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_71mDASm7EfGfZ9PfK70MMg")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities = PendingFailingReasonV3Code.LackOfSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are out on loan.
    /// Encoded/decoded by serializers as &quot;LALO&quot;.
    /// </summary>
    [EnumMember(Value = "LALO")]
    [IsoId("_71mDMSm7EfGfZ9PfK70MMg")]
    [Description(@"Financial instruments are out on loan.")]
    SecuritiesLoanedOut = PendingFailingReasonV3Code.SecuritiesLoanedOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_71mDBSm7EfGfZ9PfK70MMg")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = PendingFailingReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as &quot;LINK&quot;.
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_71mDHym7EfGfZ9PfK70MMg")]
    [Description(
        @"Your instruction is pending settlement because the instruction linked to it is pending."
    )]
    PendingLinkedInstruction = PendingFailingReasonV3Code.PendingLinkedInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central bank liquidity is insufficient.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_71mC_Sm7EfGfZ9PfK70MMg")]
    [Description(@"Central bank liquidity is insufficient.")]
    InsufficientCentralBankLiquidity = PendingFailingReasonV3Code.InsufficientCentralBankLiquidity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting receipt of adequate certification.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_71mDCym7EfGfZ9PfK70MMg")]
    [Description(@"Awaiting receipt of adequate certification.")]
    MissingCertification = PendingFailingReasonV3Code.MissingCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_71mDCSm7EfGfZ9PfK70MMg")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementAmount = PendingFailingReasonV3Code.MinimumSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_71mC_ym7EfGfZ9PfK70MMg")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney = PendingFailingReasonV3Code.InsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_71mDDSm7EfGfZ9PfK70MMg")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementAmount = PendingFailingReasonV3Code.MultipleSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation of settlement has not yet been received.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_71mC6Sm7EfGfZ9PfK70MMg")]
    [Description(@"Confirmation of settlement has not yet been received.")]
    ConfirmationNotReceived = PendingFailingReasonV3Code.ConfirmationNotReceived, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument is a new issue and not yet available/tradable.
    /// Encoded/decoded by serializers as &quot;NEWI&quot;.
    /// </summary>
    [EnumMember(Value = "NEWI")]
    [IsoId("_71mDESm7EfGfZ9PfK70MMg")]
    [Description(@"Financial instrument is a new issue and not yet available/tradable.")]
    NewIssues = PendingFailingReasonV3Code.NewIssues, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has not been matched; matching process is not required.
    /// Encoded/decoded by serializers as &quot;NMAS&quot;.
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("_71mDFSm7EfGfZ9PfK70MMg")]
    [Description(@"Instruction has not been matched; matching process is not required.")]
    NoMatchingRequired = PendingFailingReasonV3Code.NoMatchingRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A foreign exchange instruction from you is missing.
    /// Encoded/decoded by serializers as &quot;NOFX&quot;.
    /// </summary>
    [EnumMember(Value = "NOFX")]
    [IsoId("_71mDEym7EfGfZ9PfK70MMg")]
    [Description(@"A foreign exchange instruction from you is missing.")]
    NoForeignExchangeInstruction = PendingFailingReasonV3Code.NoForeignExchangeInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment has not been made by issuer.
    /// Encoded/decoded by serializers as &quot;NPAY&quot;.
    /// </summary>
    [EnumMember(Value = "NPAY")]
    [IsoId("_71mDFym7EfGfZ9PfK70MMg")]
    [Description(@"Payment has not been made by issuer.")]
    NoPayment = PendingFailingReasonV3Code.NoPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments have not been delivered by the issuer.
    /// Encoded/decoded by serializers as &quot;NSEC&quot;.
    /// </summary>
    [EnumMember(Value = "NSEC")]
    [IsoId("_71mDGSm7EfGfZ9PfK70MMg")]
    [Description(@"Financial instruments have not been delivered by the issuer.")]
    NotDelivered = PendingFailingReasonV3Code.NotDelivered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_71mDHSm7EfGfZ9PfK70MMg")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonV3Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade will settle in partials.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_71mDPym7EfGfZ9PfK70MMg")]
    [Description(@"Trade will settle in partials.")]
    TradeSettlesInPartials = PendingFailingReasonV3Code.TradeSettlesInPartials, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The instruction is pending receipt of securities, for example, from a purchase, loan etc.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_71mDISm7EfGfZ9PfK70MMg")]
    [Description(
        @"The instruction is pending receipt of securities, for example, from a purchase, loan etc."
    )]
    PendingReceipt = PendingFailingReasonV3Code.PendingReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical financial instruments have been received and are being checked for authenticity.
    /// Encoded/decoded by serializers as &quot;PHCK&quot;.
    /// </summary>
    [EnumMember(Value = "PHCK")]
    [IsoId("_71mDJSm7EfGfZ9PfK70MMg")]
    [Description(
        @"Physical financial instruments have been received and are being checked for authenticity."
    )]
    PhysicalSecuritiesVerification = PendingFailingReasonV3Code.PhysicalSecuritiesVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is physical. Financial instruments are being delivered.
    /// Encoded/decoded by serializers as &quot;PHSE&quot;.
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("_71mDIym7EfGfZ9PfK70MMg")]
    [Description(@"Settlement is physical. Financial instruments are being delivered.")]
    PhysicalDeliveryDelay = PendingFailingReasonV3Code.PhysicalDeliveryDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty's instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PRCY&quot;.
    /// </summary>
    [EnumMember(Value = "PRCY")]
    [IsoId("_71mC7Sm7EfGfZ9PfK70MMg")]
    [Description(@"Counterparty's instruction is a preadvice, that is, for matching only.")]
    CounterpartyInstructionOnHold = PendingFailingReasonV3Code.CounterpartyInstructionOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_71mDRSm7EfGfZ9PfK70MMg")]
    [Description(@"Your instruction is a preadvice, that is, for matching only.")]
    YourInstructionOnHold = PendingFailingReasonV3Code.YourInstructionOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction was put on hold/frozen by the system.
    /// Encoded/decoded by serializers as &quot;PRSY&quot;.
    /// </summary>
    [EnumMember(Value = "PRSY")]
    [IsoId("_71mDOym7EfGfZ9PfK70MMg")]
    [Description(@"Transaction was put on hold/frozen by the system.")]
    SystemOnHold = PendingFailingReasonV3Code.SystemOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery/receipt was refused because physical financial instruments are not in good order.
    /// Encoded/decoded by serializers as &quot;REFS&quot;.
    /// </summary>
    [EnumMember(Value = "REFS")]
    [IsoId("_71mDGym7EfGfZ9PfK70MMg")]
    [Description(
        @"Delivery/receipt was refused because physical financial instruments are not in good order."
    )]
    NotInGoodOrder = PendingFailingReasonV3Code.NotInGoodOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been refused or not recognised and is represented automatically.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_71mC-ym7EfGfZ9PfK70MMg")]
    [Description(
        @"Instruction has been refused or not recognised and is represented automatically."
    )]
    InstructionRefusedOrNotRecognised = PendingFailingReasonV3Code.InstructionRefusedOrNotRecognised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached.
    /// Encoded/decoded by serializers as &quot;REGT&quot;.
    /// </summary>
    [EnumMember(Value = "REGT")]
    [IsoId("_71mC4ym7EfGfZ9PfK70MMg")]
    [Description(
        @"Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached."
    )]
    CertificatesRejected = PendingFailingReasonV3Code.CertificatesRejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are blocked due to, for example, a corporate action event, realignment.
    /// Encoded/decoded by serializers as &quot;SBLO&quot;.
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_71mDLSm7EfGfZ9PfK70MMg")]
    [Description(
        @"Financial instruments are blocked due to, for example, a corporate action event, realignment."
    )]
    SecuritiesBlocked = PendingFailingReasonV3Code.SecuritiesBlocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_71mDAym7EfGfZ9PfK70MMg")]
    [Description(@"Stamp duty information is missing.")]
    LackOfStampDutyInformation = PendingFailingReasonV3Code.LackOfStampDutyInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement system/method has been modified at central securities depository to allow settlement.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_71mDNym7EfGfZ9PfK70MMg")]
    [Description(
        @"Settlement system/method has been modified at central securities depository to allow settlement."
    )]
    SettlementSystemMethodModified = PendingFailingReasonV3Code.SettlementSystemMethodModified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is being amended in the market.
    /// Encoded/decoded by serializers as &quot;TAMM&quot;.
    /// </summary>
    [EnumMember(Value = "TAMM")]
    [IsoId("_71mDPSm7EfGfZ9PfK70MMg")]
    [Description(@"Trade is being amended in the market.")]
    TradeAmendedInMarket = PendingFailingReasonV3Code.TradeAmendedInMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// For tax reclaim, the event is pending, the tax reclaim is valid for the tax authorities.
    /// Encoded/decoded by serializers as &quot;VLDA&quot;.
    /// </summary>
    [EnumMember(Value = "VLDA")]
    [IsoId("_71mDQym7EfGfZ9PfK70MMg")]
    [Description(
        @"For tax reclaim, the event is pending, the tax reclaim is valid for the tax authorities."
    )]
    ValidForTaxAuthorities = PendingFailingReasonV3Code.ValidForTaxAuthorities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient collateral in your account to execute the instruction.
    /// Encoded/decoded by serializers as &quot;YCOL&quot;.
    /// </summary>
    [EnumMember(Value = "YCOL")]
    [IsoId("_71mC3ym7EfGfZ9PfK70MMg")]
    [Description(@"Insufficient collateral in your account to execute the instruction.")]
    CollateralShortage = PendingFailingReasonV3Code.CollateralShortage, // same ordinal as derivation source for type conversions
}
