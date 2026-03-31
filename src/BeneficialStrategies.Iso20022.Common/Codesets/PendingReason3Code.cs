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
[IsoId("_aBreUNp-Ed-ak6NoX_4Aeg_1193465665")]
[Description(
    @"Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing."
)]
[DerivedFrom(typeof(PendingFailingReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PendingReason3Code>))]
#endif
public enum PendingReason3Code
{
    /// <summary>
    /// Financial instruments are delivered, but still awaiting money from counterparty.
    /// Encoded/decoded by serializers as &quot;AWMO&quot;.
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("_aBreUdp-Ed-ak6NoX_4Aeg_-1456234196")]
    [Description(
        @"Financial instruments are delivered, but still awaiting money from counterparty."
    )]
    AwaitingMoney = PendingFailingReasonCode.AwaitingMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_aBreUtp-Ed-ak6NoX_4Aeg_196393312")]
    [Description(
        @"Instruction was received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax reclaim has been sent to the tax authorities.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_aBreU9p-Ed-ak6NoX_4Aeg_-95564426")]
    [Description(@"Tax reclaim has been sent to the tax authorities.")]
    SentToTaxAuthorities = PendingFailingReasonCode.SentToTaxAuthorities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting.
    /// Encoded/decoded by serializers as &quot;CAIS&quot;.
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_aBreVNp-Ed-ak6NoX_4Aeg_82554246")]
    [Description(
        @"Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting."
    )]
    AwaitingSecurities = PendingFailingReasonCode.AwaitingSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been refused or not recognised and is represented automatically.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_aBreVdp-Ed-ak6NoX_4Aeg_1841660747")]
    [Description(
        @"Instruction has been refused or not recognised and is represented automatically."
    )]
    InstructionRefusedOrNotRecognised = PendingFailingReasonCode.InstructionRefusedOrNotRecognised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered.
    /// Encoded/decoded by serializers as &quot;AWSH&quot;.
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_aBreVtp-Ed-ak6NoX_4Aeg_-800679041")]
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
    [IsoId("_aBreV9p-Ed-ak6NoX_4Aeg_-1092636779")]
    [Description(@"Settlement is physical. Financial instruments are being delivered.")]
    PhysicalDeliveryDelay = PendingFailingReasonCode.PhysicalDeliveryDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is being amended in the market.
    /// Encoded/decoded by serializers as &quot;TAMM&quot;.
    /// </summary>
    [EnumMember(Value = "TAMM")]
    [IsoId("_aBreWNp-Ed-ak6NoX_4Aeg_-914518107")]
    [Description(@"Trade is being amended in the market.")]
    TradeAmendedInMarket = PendingFailingReasonCode.TradeAmendedInMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as &quot;DOCY&quot;.
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_aB1PUNp-Ed-ak6NoX_4Aeg_844588394")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou =
        PendingFailingReasonCode.AwaitingDocumentsOrEndorsementsFromYou, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting documents or endorsements from counterparty.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_aB1PUdp-Ed-ak6NoX_4Aeg_-1797751394")]
    [Description(@"Awaiting documents or endorsements from counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty =
        PendingFailingReasonCode.AwaitingDocumentsOrEndorsementsFromCounterparty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_aB1PUtp-Ed-ak6NoX_4Aeg_-2089709132")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked = PendingFailingReasonCode.AccountBlocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A chaser/enquiry has been sent.
    /// Encoded/decoded by serializers as &quot;CHAS&quot;.
    /// </summary>
    [EnumMember(Value = "CHAS")]
    [IsoId("_aB1PU9p-Ed-ak6NoX_4Aeg_-1911590460")]
    [Description(@"A chaser/enquiry has been sent.")]
    EnquirySent = PendingFailingReasonCode.EnquirySent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument is a new issue and not yet available/tradable.
    /// Encoded/decoded by serializers as &quot;NEWI&quot;.
    /// </summary>
    [EnumMember(Value = "NEWI")]
    [IsoId("_aB1PVNp-Ed-ak6NoX_4Aeg_-152483959")]
    [Description(@"Financial instrument is a new issue and not yet available/tradable.")]
    NewIssues = PendingFailingReasonCode.NewIssues, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient deliverable financial instruments in counterparty&apos;s account or counterparty does not hold financial instruments.
    /// Encoded/decoded by serializers as &quot;CLAC&quot;.
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_aB1PVdp-Ed-ak6NoX_4Aeg_1500143549")]
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
    [IsoId("_aB1PVtp-Ed-ak6NoX_4Aeg_1208185811")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementAmount = PendingFailingReasonCode.MultipleSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement cannot be executed; financial instruments are in global form.
    /// Encoded/decoded by serializers as &quot;GLOB&quot;.
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_aB1PV9p-Ed-ak6NoX_4Aeg_1386304483")]
    [Description(@"Settlement cannot be executed; financial instruments are in global form.")]
    GlobalFormSecurities = PendingFailingReasonCode.GlobalFormSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_aB1PWNp-Ed-ak6NoX_4Aeg_-1149556312")]
    [Description(@"Your instruction is a preadvice, that is, for matching only.")]
    YourInstructionOnHold = PendingFailingReasonCode.YourInstructionOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade will settle in partials.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_aB1PWdp-Ed-ak6NoX_4Aeg_211113458")]
    [Description(@"Trade will settle in partials.")]
    TradeSettlesInPartials = PendingFailingReasonCode.TradeSettlesInPartials, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has not been matched; matching process is not required.
    /// Encoded/decoded by serializers as &quot;NMAS&quot;.
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("_aB1PWtp-Ed-ak6NoX_4Aeg_389232130")]
    [Description(@"Instruction has not been matched; matching process is not required.")]
    NoMatchingRequired = PendingFailingReasonCode.NoMatchingRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in counterparty&apos;s account.
    /// Encoded/decoded by serializers as &quot;CMON&quot;.
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("_aB-ZQNp-Ed-ak6NoX_4Aeg_-2146628665")]
    [Description(@"Insufficient money in counterparty's account.")]
    CounterpartyInsufficientMoney = PendingFailingReasonCode.CounterpartyInsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient collateral in your account to execute the instruction.
    /// Encoded/decoded by serializers as &quot;YCOL&quot;.
    /// </summary>
    [EnumMember(Value = "YCOL")]
    [IsoId("_aB-ZQdp-Ed-ak6NoX_4Aeg_-416962456")]
    [Description(@"Insufficient collateral in your account to execute the instruction.")]
    CollateralShortage = PendingFailingReasonCode.CollateralShortage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are not deliverable as they are pledged as collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_aB-ZQtp-Ed-ak6NoX_4Aeg_-708920194")]
    [Description(@"Financial instruments are not deliverable as they are pledged as collateral.")]
    SecuritiesPledgedAsCollateral = PendingFailingReasonCode.SecuritiesPledgedAsCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction.
    /// Encoded/decoded by serializers as &quot;DEPO&quot;.
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("_aB-ZQ9p-Ed-ak6NoX_4Aeg_-530801522")]
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
    [IsoId("_aB-ZRNp-Ed-ak6NoX_4Aeg_1228304979")]
    [Description(
        @"Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached."
    )]
    MaximumForeignLimitReached = PendingFailingReasonCode.MaximumForeignLimitReached, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A foreign exchange instruction from you is missing.
    /// Encoded/decoded by serializers as &quot;NOFX&quot;.
    /// </summary>
    [EnumMember(Value = "NOFX")]
    [IsoId("_aB-ZRdp-Ed-ak6NoX_4Aeg_1269027446")]
    [Description(@"A foreign exchange instruction from you is missing.")]
    NoForeignExchangeInstruction = PendingFailingReasonCode.NoForeignExchangeInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments require income adjustment, for example, dividend or interest.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_aB-ZRtp-Ed-ak6NoX_4Aeg_977069708")]
    [Description(
        @"Financial instruments require income adjustment, for example, dividend or interest."
    )]
    IncomeAdjustementRequired = PendingFailingReasonCode.IncomeAdjustementRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as &quot;LINK&quot;.
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_aB-ZR9p-Ed-ak6NoX_4Aeg_1155188380")]
    [Description(
        @"Your instruction is pending settlement because the instruction linked to it is pending."
    )]
    PendingLinkedInstruction = PendingFailingReasonCode.PendingLinkedInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting settlement date. No settlement problems to be reported.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_aB-ZSNp-Ed-ak6NoX_4Aeg_-1380672415")]
    [Description(@"Awaiting settlement date. No settlement problems to be reported.")]
    AwaitingSettlementDate = PendingFailingReasonCode.AwaitingSettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_aB-ZSdp-Ed-ak6NoX_4Aeg_271955093")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities = PendingFailingReasonCode.LackOfSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are out on loan.
    /// Encoded/decoded by serializers as &quot;LALO&quot;.
    /// </summary>
    [EnumMember(Value = "LALO")]
    [IsoId("_aCIKQNp-Ed-ak6NoX_4Aeg_-20002645")]
    [Description(@"Financial instruments are out on loan.")]
    SecuritiesLoanedOut = PendingFailingReasonCode.SecuritiesLoanedOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_aCIKQdp-Ed-ak6NoX_4Aeg_158116027")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney = PendingFailingReasonCode.InsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation of settlement has not yet been received.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_aCIKQtp-Ed-ak6NoX_4Aeg_1917222528")]
    [Description(@"Confirmation of settlement has not yet been received.")]
    ConfirmationNotReceived = PendingFailingReasonCode.ConfirmationNotReceived, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery/receipt was refused because physical financial instruments are not in good order.
    /// Encoded/decoded by serializers as &quot;REFS&quot;.
    /// </summary>
    [EnumMember(Value = "REFS")]
    [IsoId("_aCIKQ9p-Ed-ak6NoX_4Aeg_-725117260")]
    [Description(
        @"Delivery/receipt was refused because physical financial instruments are not in good order."
    )]
    NotInGoodOrder = PendingFailingReasonCode.NotInGoodOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_aCIKRNp-Ed-ak6NoX_4Aeg_-1017074998")]
    [Description(@"Stamp duty information is missing.")]
    LackOfStampDutyInformation = PendingFailingReasonCode.LackOfStampDutyInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing batch differs in the counterparty&apos;s instruction, for example, daytime/real-time versus overnight.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_aCIKRdp-Ed-ak6NoX_4Aeg_-838956326")]
    [Description(
        @"Processing batch differs in the counterparty's instruction, for example, daytime/real-time versus overnight."
    )]
    ProcessingBatchDifference = PendingFailingReasonCode.ProcessingBatchDifference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle.
    /// Encoded/decoded by serializers as &quot;CYCL&quot;.
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_aCIKRtp-Ed-ak6NoX_4Aeg_920150175")]
    [Description(
        @"Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle."
    )]
    AwaitingNextSettlementCycle = PendingFailingReasonCode.AwaitingNextSettlementCycle, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are blocked due to, for example, a corporate action event, realignment.
    /// Encoded/decoded by serializers as &quot;SBLO&quot;.
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_aCIKR9p-Ed-ak6NoX_4Aeg_-1722189613")]
    [Description(
        @"Financial instruments are blocked due to, for example, a corporate action event, realignment."
    )]
    SecuritiesBlocked = PendingFailingReasonCode.SecuritiesBlocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business).
    /// Encoded/decoded by serializers as &quot;CPEC&quot;.
    /// </summary>
    [EnumMember(Value = "CPEC")]
    [IsoId("_aCIKSNp-Ed-ak6NoX_4Aeg_-2014147351")]
    [Description(
        @"Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business)."
    )]
    CounterpartyInReceivership = PendingFailingReasonCode.CounterpartyInReceivership, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_aCIKSdp-Ed-ak6NoX_4Aeg_-1836028679")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementAmount = PendingFailingReasonCode.MinimumSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending reason being investigated.
    /// Encoded/decoded by serializers as &quot;IAAD&quot;.
    /// </summary>
    [EnumMember(Value = "IAAD")]
    [IsoId("_aCRUMNp-Ed-ak6NoX_4Aeg_-76922178")]
    [Description(@"Pending reason being investigated.")]
    StatusReasonInvestigation = PendingFailingReasonCode.StatusReasonInvestigation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical financial instruments have been received and are being checked for authenticity.
    /// Encoded/decoded by serializers as &quot;PHCK&quot;.
    /// </summary>
    [EnumMember(Value = "PHCK")]
    [IsoId("_aCRUMdp-Ed-ak6NoX_4Aeg_1575705330")]
    [Description(
        @"Physical financial instruments have been received and are being checked for authenticity."
    )]
    PhysicalSecuritiesVerification = PendingFailingReasonCode.PhysicalSecuritiesVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disagreement in beneficial ownership.
    /// Encoded/decoded by serializers as &quot;BENO&quot;.
    /// </summary>
    [EnumMember(Value = "BENO")]
    [IsoId("_aCRUMtp-Ed-ak6NoX_4Aeg_1283747592")]
    [Description(@"Disagreement in beneficial ownership.")]
    BeneficialOwnershipDisagreement = PendingFailingReasonCode.BeneficialOwnershipDisagreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction and your instruction are on hold/frozen/ in a preadvice mode.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_aCRUM9p-Ed-ak6NoX_4Aeg_1461866264")]
    [Description(
        @"Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode."
    )]
    BothInstructionsOnHold = PendingFailingReasonCode.BothInstructionsOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India.
    /// Encoded/decoded by serializers as &quot;CLHT&quot;.
    /// </summary>
    [EnumMember(Value = "CLHT")]
    [IsoId("_aCRUNNp-Ed-ak6NoX_4Aeg_-1073994531")]
    [Description(
        @"Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India."
    )]
    ClearingHouseTrade = PendingFailingReasonCode.ClearingHouseTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities.
    /// Encoded/decoded by serializers as &quot;DENO&quot;.
    /// </summary>
    [EnumMember(Value = "DENO")]
    [IsoId("_aCRUNdp-Ed-ak6NoX_4Aeg_286675239")]
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
    [IsoId("_aCRUNtp-Ed-ak6NoX_4Aeg_464793911")]
    [Description(
        @"Exceptional closing of all financial institutions due to natural disaster, for example, earthquake."
    )]
    NaturalDisaster = PendingFailingReasonCode.NaturalDisaster, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty has returned or refuses the securities.
    /// Encoded/decoded by serializers as &quot;DKNY&quot;.
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("_aCRUN9p-Ed-ak6NoX_4Aeg_-2071066884")]
    [Description(@"Counterparty has returned or refuses the securities.")]
    CounterpartyReturnedShares = PendingFailingReasonCode.CounterpartyReturnedShares, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_aCRUONp-Ed-ak6NoX_4Aeg_-418439376")]
    [Description(@"Quantity of financial instruments does not match.")]
    QuantityDisagreement = PendingFailingReasonCode.QuantityDisagreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event.
    /// Encoded/decoded by serializers as &quot;FROZ&quot;.
    /// </summary>
    [EnumMember(Value = "FROZ")]
    [IsoId("_aCRUOdp-Ed-ak6NoX_4Aeg_-710397114")]
    [Description(
        @"Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event."
    )]
    SecuritiesFrozenAtCSD = PendingFailingReasonCode.SecuritiesFrozenAtCSD, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting settlement of a purchase to cover failing positions.
    /// Encoded/decoded by serializers as &quot;LAAW&quot;.
    /// </summary>
    [EnumMember(Value = "LAAW")]
    [IsoId("_aCbFMNp-Ed-ak6NoX_4Aeg_-532278442")]
    [Description(@"Awaiting settlement of a purchase to cover failing positions.")]
    AwaitingOtherTransaction = PendingFailingReasonCode.AwaitingOtherTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_aCbFMdp-Ed-ak6NoX_4Aeg_1226828059")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = PendingFailingReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central bank liquidity is insufficient.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_aCbFMtp-Ed-ak6NoX_4Aeg_-1415511729")]
    [Description(@"Central bank liquidity is insufficient.")]
    InsufficientCentralBankLiquidity = PendingFailingReasonCode.InsufficientCentralBankLiquidity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting receipt of adequate certification.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_aCbFM9p-Ed-ak6NoX_4Aeg_-1707469467")]
    [Description(@"Awaiting receipt of adequate certification.")]
    MissingCertification = PendingFailingReasonCode.MissingCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment has not been made by issuer.
    /// Encoded/decoded by serializers as &quot;NPAY&quot;.
    /// </summary>
    [EnumMember(Value = "NPAY")]
    [IsoId("_aCbFNNp-Ed-ak6NoX_4Aeg_-1529350795")]
    [Description(@"Payment has not been made by issuer.")]
    NoPayment = PendingFailingReasonCode.NoPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments have not been delivered by the issuer.
    /// Encoded/decoded by serializers as &quot;NSEC&quot;.
    /// </summary>
    [EnumMember(Value = "NSEC")]
    [IsoId("_aCbFNdp-Ed-ak6NoX_4Aeg_229755706")]
    [Description(@"Financial instruments have not been delivered by the issuer.")]
    NotDelivered = PendingFailingReasonCode.NotDelivered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The instruction is pending receipt of securities, for example, from a purchase, loan etc.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_aCbFNtp-Ed-ak6NoX_4Aeg_1882383214")]
    [Description(
        @"The instruction is pending receipt of securities, for example, from a purchase, loan etc."
    )]
    PendingReceipt = PendingFailingReasonCode.PendingReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PRCY&quot;.
    /// </summary>
    [EnumMember(Value = "PRCY")]
    [IsoId("_aCbFN9p-Ed-ak6NoX_4Aeg_1590425476")]
    [Description(@"Counterparty's instruction is a preadvice, that is, for matching only.")]
    CounterpartyInstructionOnHold = PendingFailingReasonCode.CounterpartyInstructionOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached.
    /// Encoded/decoded by serializers as &quot;REGT&quot;.
    /// </summary>
    [EnumMember(Value = "REGT")]
    [IsoId("_aCk2MNp-Ed-ak6NoX_4Aeg_1768544148")]
    [Description(
        @"Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached."
    )]
    CertificatesRejected = PendingFailingReasonCode.CertificatesRejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement system/method has been modified at central securities depository to allow settlement.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_aCk2Mdp-Ed-ak6NoX_4Aeg_-767316647")]
    [Description(
        @"Settlement system/method has been modified at central securities depository to allow settlement."
    )]
    SettlementSystemMethodModified = PendingFailingReasonCode.SettlementSystemMethodModified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// For tax reclaim, the event is pending, the tax reclaim is valid for the tax authorities.
    /// Encoded/decoded by serializers as &quot;VLDA&quot;.
    /// </summary>
    [EnumMember(Value = "VLDA")]
    [IsoId("_aCk2Mtp-Ed-ak6NoX_4Aeg_885310861")]
    [Description(
        @"For tax reclaim, the event is pending, the tax reclaim is valid for the tax authorities."
    )]
    ValidForTaxAuthorities = PendingFailingReasonCode.ValidForTaxAuthorities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction was put on hold/frozen by the system.
    /// Encoded/decoded by serializers as &quot;PRSY&quot;.
    /// </summary>
    [EnumMember(Value = "PRSY")]
    [IsoId("_aCk2M9p-Ed-ak6NoX_4Aeg_-948275558")]
    [Description(@"Transaction was put on hold/frozen by the system.")]
    SystemOnHold = PendingFailingReasonCode.SystemOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is conditional to the execution of a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as &quot;CDCY&quot;.
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("_aCk2NNp-Ed-ak6NoX_4Aeg_-298646898")]
    [Description(
        @"Execution is conditional to the execution of a process linked to the currency of the transaction."
    )]
    ConditionalCurrency = PendingFailingReasonCode.ConditionalCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is conditional to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as &quot;CDRG&quot;.
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("_aCk2Ndp-Ed-ak6NoX_4Aeg_-1587676989")]
    [Description(@"Execution is conditional to the execution of a process at the registrar.")]
    ConditionalRegistrar = PendingFailingReasonCode.ConditionalRegistrar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting confirmation from the counterparty.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_aCk2Ntp-Ed-ak6NoX_4Aeg_-1644596522")]
    [Description(@"Awaiting confirmation from the counterparty.")]
    AwaitingConfirmation = PendingFailingReasonCode.AwaitingConfirmation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is conditional to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as &quot;CDRE&quot;.
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("_aCk2N9p-Ed-ak6NoX_4Aeg_-989041367")]
    [Description(
        @"Execution is conditional to the execution of a process of realignment at the issuer CSD."
    )]
    ConditionalRealignement = PendingFailingReasonCode.ConditionalRealignement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aCk2ONp-Ed-ak6NoX_4Aeg_-507650738")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonCode.Other, // same ordinal as derivation source for type conversions
}
