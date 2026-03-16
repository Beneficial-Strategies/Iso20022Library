// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NnLDQSwLEeOqZONeZTLNPw")]
[Description(
    @"Specifies the reason the transaction, transfer or settlement instruction is unmatched."
)]
[DerivedFrom(typeof(UnmatchedReasonCode))]
public enum UnmatchedReason9Code
{
    /// <summary>
    /// A matching instruction from your counterparty could not be found.
    /// Encoded/decoded by serializers as &quot;CMIS&quot;.
    /// </summary>
    [EnumMember(Value = "CMIS")]
    [IsoId("_OBNT4SwLEeOqZONeZTLNPw")]
    [Description(@"A matching instruction from your counterparty could not be found.")]
    NoMatch = UnmatchedReasonCode.NoMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement date/time does not match.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_OBNT4ywLEeOqZONeZTLNPw")]
    [Description(@"Settlement date/time does not match.")]
    SettlementDate = UnmatchedReasonCode.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa.
    /// Encoded/decoded by serializers as &quot;DELN&quot;.
    /// </summary>
    [EnumMember(Value = "DELN")]
    [IsoId("_OBNT5SwLEeOqZONeZTLNPw")]
    [Description(
        @"Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa."
    )]
    TransactionDirection = UnmatchedReasonCode.TransactionDirection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal amount does not match.
    /// Encoded/decoded by serializers as &quot;DEAL&quot;.
    /// </summary>
    [EnumMember(Value = "DEAL")]
    [IsoId("_OBNT5ywLEeOqZONeZTLNPw")]
    [Description(@"Deal amount does not match.")]
    TransactionDealAmount = UnmatchedReasonCode.TransactionDealAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Depository does not match.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_OBNT6SwLEeOqZONeZTLNPw")]
    [Description(@"Depository does not match.")]
    ReceivingDeliveringDepository = UnmatchedReasonCode.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement amount does not match.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_OBNT6ywLEeOqZONeZTLNPw")]
    [Description(@"Settlement amount does not match.")]
    SettlementAmount = UnmatchedReasonCode.SettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal price does not match.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_OBNT7SwLEeOqZONeZTLNPw")]
    [Description(@"Deal price does not match.")]
    DealPrice = UnmatchedReasonCode.DealPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_OBNT7ywLEeOqZONeZTLNPw")]
    [Description(@"Quantity of financial instruments does not match.")]
    FinancialInstrumentQuantity = UnmatchedReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction call delay does not match.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_OBNT8SwLEeOqZONeZTLNPw")]
    [Description(@"Transaction call delay does not match.")]
    RepurchaseCallDelay = UnmatchedReasonCode.RepurchaseCallDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_OBNT8ywLEeOqZONeZTLNPw")]
    [Description(
        @"Received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = UnmatchedReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.).
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_OBNT9SwLEeOqZONeZTLNPw")]
    [Description(
        @"Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.)."
    )]
    SettlementTransaction = UnmatchedReasonCode.SettlementTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B).
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_OBNT9ywLEeOqZONeZTLNPw")]
    [Description(
        @"Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B)."
    )]
    SettlementSystemMethod = UnmatchedReasonCode.SettlementSystemMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_OBNT-SwLEeOqZONeZTLNPw")]
    [Description(
        @"Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs."
    )]
    FinancialInstrument = UnmatchedReasonCode.FinancialInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Variable rate support does not match (repo).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_OBNT-ywLEeOqZONeZTLNPw")]
    [Description(@"Variable rate support does not match (repo).")]
    VariableRateSupport = UnmatchedReasonCode.VariableRateSupport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty has been contacted or contacted us, and does not recognise the transaction.
    /// Encoded/decoded by serializers as &quot;DTRA&quot;.
    /// </summary>
    [EnumMember(Value = "DTRA")]
    [IsoId("_OBNT_SwLEeOqZONeZTLNPw")]
    [Description(
        @"Counterparty has been contacted or contacted us, and does not recognise the transaction."
    )]
    NotRecognised = UnmatchedReasonCode.NotRecognised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Spread rate does not match.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_OBNT_ywLEeOqZONeZTLNPw")]
    [Description(@"Spread rate does not match.")]
    RepurchaseSpreadRate = UnmatchedReasonCode.RepurchaseSpreadRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repurchase rate does not match.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_OBNUASwLEeOqZONeZTLNPw")]
    [Description(@"Repurchase rate does not match.")]
    RepurchaseRate = UnmatchedReasonCode.RepurchaseRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction was too late for matching.
    /// Encoded/decoded by serializers as &quot;CLAT&quot;.
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_OBNUAywLEeOqZONeZTLNPw")]
    [Description(@"Counterparty's instruction was too late for matching.")]
    CounterpartyTooLateForMatching = UnmatchedReasonCode.CounterpartyTooLateForMatching, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repurchase rate type does not match.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_OBNUBSwLEeOqZONeZTLNPw")]
    [Description(@"Repurchase rate type does not match.")]
    RepurchaseRateType = UnmatchedReasonCode.RepurchaseRateType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Termination transaction amount does not match.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_OBNUBywLEeOqZONeZTLNPw")]
    [Description(@"Termination transaction amount does not match.")]
    RepurchaseAmount = UnmatchedReasonCode.RepurchaseAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Premium amount does not match.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_OBNUCSwLEeOqZONeZTLNPw")]
    [Description(@"Premium amount does not match.")]
    RepurchasePremiumAmount = UnmatchedReasonCode.RepurchasePremiumAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction is physical settlement, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_OBNUCywLEeOqZONeZTLNPw")]
    [Description(
        @"Counterparty's instruction is physical settlement, your instruction is not, or vice versa."
    )]
    PhysicalSettlement = UnmatchedReasonCode.PhysicalSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Common reference does not match.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_OBNUDSwLEeOqZONeZTLNPw")]
    [Description(@"Common reference does not match.")]
    CommonReference = UnmatchedReasonCode.CommonReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment type does not match: your instruction is free of payment, your counterparty&apos;s instruction is against payment or vice versa.
    /// Encoded/decoded by serializers as &quot;FRAP&quot;.
    /// </summary>
    [EnumMember(Value = "FRAP")]
    [IsoId("_OBNUDywLEeOqZONeZTLNPw")]
    [Description(
        @"Payment type does not match: your instruction is free of payment, your counterparty's instruction is against payment or vice versa."
    )]
    PaymentCode = UnmatchedReasonCode.PaymentCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of trade does not match.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_OBNUESwLEeOqZONeZTLNPw")]
    [Description(@"Place of trade does not match.")]
    PlaceOfTrade = UnmatchedReasonCode.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has not been matched. It is a possible duplicate instruction.
    /// Encoded/decoded by serializers as &quot;PODU&quot;.
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("_OBNUEywLEeOqZONeZTLNPw")]
    [Description(@"Instruction has not been matched. It is a possible duplicate instruction.")]
    PossibleDuplicate = UnmatchedReasonCode.PossibleDuplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Forfeit amount does not match.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_OBNUFSwLEeOqZONeZTLNPw")]
    [Description(@"Forfeit amount does not match.")]
    ForfeitRepurchaseAmount = UnmatchedReasonCode.ForfeitRepurchaseAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Executing broker&apos;s commission does not match.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_OBNUFywLEeOqZONeZTLNPw")]
    [Description(@"Executing broker's commission does not match.")]
    ExecutionBrokerCommission = UnmatchedReasonCode.ExecutionBrokerCommission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Registration details linked to the transaction are incorrect.
    /// Encoded/decoded by serializers as &quot;REGD&quot;.
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_OBNUGSwLEeOqZONeZTLNPw")]
    [Description(@"Registration details linked to the transaction are incorrect.")]
    RegistrationDetails = UnmatchedReasonCode.RegistrationDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa.
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_OBNUGywLEeOqZONeZTLNPw")]
    [Description(
        @"Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa."
    )]
    RTGSSystem = UnmatchedReasonCode.RTGSSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant of delivering or receiving depository does not match.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_OBNUHSwLEeOqZONeZTLNPw")]
    [Description(@"Participant of delivering or receiving depository does not match.")]
    ReceivingDeliveringParty1 = UnmatchedReasonCode.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty cancelled their instruction.
    /// Encoded/decoded by serializers as &quot;CPCA&quot;.
    /// </summary>
    [EnumMember(Value = "CPCA")]
    [IsoId("_OBNUHywLEeOqZONeZTLNPw")]
    [Description(@"Counterparty cancelled their instruction.")]
    CounterpartyCancelled = UnmatchedReasonCode.CounterpartyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges amount does not match.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_OBNUISwLEeOqZONeZTLNPw")]
    [Description(@"Charges amount does not match.")]
    ChargesAmount = UnmatchedReasonCode.ChargesAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Client of delivering or receiving party 2 does not match.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_OBNUIywLEeOqZONeZTLNPw")]
    [Description(@"Client of delivering or receiving party 2 does not match.")]
    ReceivingDeliveringParty3 = UnmatchedReasonCode.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement amount currency does not match.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_OBNUJSwLEeOqZONeZTLNPw")]
    [Description(@"Settlement amount currency does not match.")]
    CurrencySettlementAmount = UnmatchedReasonCode.CurrencySettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corresponding matching record has been cancelled.
    /// Encoded/decoded by serializers as &quot;MCAN&quot;.
    /// </summary>
    [EnumMember(Value = "MCAN")]
    [IsoId("_OBNUJywLEeOqZONeZTLNPw")]
    [Description(@"Corresponding matching record has been cancelled.")]
    MatchingRecordCancelled = UnmatchedReasonCode.MatchingRecordCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;LEOG&quot;.
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("_OBNUKSwLEeOqZONeZTLNPw")]
    [Description(
        @"Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa."
    )]
    LetterOfGuarantee = UnmatchedReasonCode.LetterOfGuarantee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Matching process has not yet started.
    /// Encoded/decoded by serializers as &quot;NMAS&quot;.
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("_OBNUKywLEeOqZONeZTLNPw")]
    [Description(@"Matching process has not yet started.")]
    NoMatchingStarted = UnmatchedReasonCode.NoMatchingStarted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller&apos;s account, direct client&apos;s account at the receiving/delivering agent, or receiving/delivering agent&apos;s account at the CSD.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_OBNULSwLEeOqZONeZTLNPw")]
    [Description(
        @"Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller's account, direct client's account at the receiving/delivering agent, or receiving/delivering agent's account at the CSD."
    )]
    SafekeepingAccount = UnmatchedReasonCode.SafekeepingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade date does not match.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_OBNULywLEeOqZONeZTLNPw")]
    [Description(@"Trade date does not match.")]
    TradeDate = UnmatchedReasonCode.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction was too late for matching.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_OBNUMSwLEeOqZONeZTLNPw")]
    [Description(@"Your instruction was too late for matching.")]
    MarketDeadlineMissed = UnmatchedReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Closing date/time does not match.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_OBNUMywLEeOqZONeZTLNPw")]
    [Description(@"Closing date/time does not match.")]
    ClosingDateTime = UnmatchedReasonCode.ClosingDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disagreement on the tax status of the financial instruments to be settled.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_OBNUNSwLEeOqZONeZTLNPw")]
    [Description(@"Disagreement on the tax status of the financial instruments to be settled.")]
    TaxStatus = UnmatchedReasonCode.TaxStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Client of delivering or receiving party 1 does not match.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_OBNUNywLEeOqZONeZTLNPw")]
    [Description(@"Client of delivering or receiving party 1 does not match.")]
    ReceivingDeliveringParty2 = UnmatchedReasonCode.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of safekeeping information does not allow matching to take place.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_OBNUOSwLEeOqZONeZTLNPw")]
    [Description(@"Place of safekeeping information does not allow matching to take place.")]
    PlaceOfSafekeeping = UnmatchedReasonCode.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Missing market execution details.
    /// Encoded/decoded by serializers as &quot;MIME&quot;.
    /// </summary>
    [EnumMember(Value = "MIME")]
    [IsoId("_OBNUOywLEeOqZONeZTLNPw")]
    [Description(@"Missing market execution details.")]
    MissingMarketSide = UnmatchedReasonCode.MissingMarketSide, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Market side trade is unmatched.
    /// Encoded/decoded by serializers as &quot;UNBR&quot;.
    /// </summary>
    [EnumMember(Value = "UNBR")]
    [IsoId("_OBNUPSwLEeOqZONeZTLNPw")]
    [Description(@"Market side trade is unmatched.")]
    UnmatchedMarketSide = UnmatchedReasonCode.UnmatchedMarketSide, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proprietary unmatched reason code described in a narrative field.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_OBNUPywLEeOqZONeZTLNPw")]
    [Description(@"Proprietary unmatched reason code described in a narrative field.")]
    Other = UnmatchedReasonCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Accrued interest amount does not match.
    /// Encoded/decoded by serializers as &quot;ACRU&quot;.
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("_OBNUQSwLEeOqZONeZTLNPw")]
    [Description(@"Accrued interest amount does not match.")]
    AccruedInterestAmount1 = UnmatchedReasonCode.AccruedInterestAmount1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor party does not match.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_SYwi8SwLEeOqZONeZTLNPw")]
    [Description(@"Investor party does not match.")]
    InvestorParty = UnmatchedReasonCode.InvestorParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of listing does not match.
    /// Encoded/decoded by serializers as &quot;PLIS&quot;.
    /// </summary>
    [EnumMember(Value = "PLIS")]
    [IsoId("_TEpYkSwLEeOqZONeZTLNPw")]
    [Description(@"Place of listing does not match.")]
    PlaceOfListing = UnmatchedReasonCode.PlaceOfListing, // same ordinal as derivation source for type conversions
}
