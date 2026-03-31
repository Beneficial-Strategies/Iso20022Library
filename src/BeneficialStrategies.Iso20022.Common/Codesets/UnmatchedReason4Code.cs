// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__q6WQdojEeC60axPepSq7g_-1712157362")]
[Description(
    @"Specifies the reason the transaction, transfer or settlement instruction is unmatched."
)]
[DerivedFrom(typeof(UnmatchedReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UnmatchedReason4Code>))]
#endif
public enum UnmatchedReason4Code
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("__q6WQtojEeC60axPepSq7g_1722219878")]
    [Description(
        @"Received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = UnmatchedReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction call delay does not match.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("__q6WQ9ojEeC60axPepSq7g_1087188032")]
    [Description(@"Transaction call delay does not match.")]
    RepurchaseCallDelay = UnmatchedReasonCode.RepurchaseCallDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges amount does not match.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("__q6WRNojEeC60axPepSq7g_973348966")]
    [Description(@"Charges amount does not match.")]
    ChargesAmount = UnmatchedReasonCode.ChargesAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A matching instruction from your counterparty could not be found.
    /// Encoded/decoded by serializers as &quot;CMIS&quot;.
    /// </summary>
    [EnumMember(Value = "CMIS")]
    [IsoId("__q6WRdojEeC60axPepSq7g_-2129758926")]
    [Description(@"A matching instruction from your counterparty could not be found.")]
    NoMatch = UnmatchedReasonCode.NoMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty cancelled their instruction.
    /// Encoded/decoded by serializers as &quot;CPCA&quot;.
    /// </summary>
    [EnumMember(Value = "CPCA")]
    [IsoId("__q6WRtojEeC60axPepSq7g_2051369304")]
    [Description(@"Counterparty cancelled their instruction.")]
    CounterpartyCancelled = UnmatchedReasonCode.CounterpartyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement date/time does not match.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("__rEHQNojEeC60axPepSq7g_-1543811900")]
    [Description(@"Settlement date/time does not match.")]
    SettlementDate = UnmatchedReasonCode.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal price does not match.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("__rEHQdojEeC60axPepSq7g_-1657650966")]
    [Description(@"Deal price does not match.")]
    DealPrice = UnmatchedReasonCode.DealPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal amount does not match.
    /// Encoded/decoded by serializers as &quot;DEAL&quot;.
    /// </summary>
    [EnumMember(Value = "DEAL")]
    [IsoId("__rEHQtojEeC60axPepSq7g_1372472453")]
    [Description(@"Deal amount does not match.")]
    TransactionDealAmount = UnmatchedReasonCode.TransactionDealAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa.
    /// Encoded/decoded by serializers as &quot;DELN&quot;.
    /// </summary>
    [EnumMember(Value = "DELN")]
    [IsoId("__rEHQ9ojEeC60axPepSq7g_1361373676")]
    [Description(
        @"Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa."
    )]
    TransactionDirection = UnmatchedReasonCode.TransactionDirection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Depository does not match.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("__rEHRNojEeC60axPepSq7g_1247534610")]
    [Description(@"Depository does not match.")]
    ReceivingDeliveringDepository = UnmatchedReasonCode.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement amount does not match.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("__rEHRdojEeC60axPepSq7g_2122138829")]
    [Description(@"Settlement amount does not match.")]
    SettlementAmount = UnmatchedReasonCode.SettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("__rEHRtojEeC60axPepSq7g_2008299763")]
    [Description(@"Quantity of financial instruments does not match.")]
    FinancialInstrumentQuantity = UnmatchedReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("__rN4QNojEeC60axPepSq7g_1810747570")]
    [Description(
        @"Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs."
    )]
    FinancialInstrument = UnmatchedReasonCode.FinancialInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade date does not match.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("__rN4QdojEeC60axPepSq7g_1696908504")]
    [Description(@"Trade date does not match.")]
    TradeDate = UnmatchedReasonCode.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Executing broker&apos;s commission does not match.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("__rN4QtojEeC60axPepSq7g_1799648793")]
    [Description(@"Executing broker's commission does not match.")]
    ExecutionBrokerCommission = UnmatchedReasonCode.ExecutionBrokerCommission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Forfeit amount does not match.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("__rN4Q9ojEeC60axPepSq7g_-1444185431")]
    [Description(@"Forfeit amount does not match.")]
    ForfeitRepurchaseAmount = UnmatchedReasonCode.ForfeitRepurchaseAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction was too late for matching.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("__rN4RNojEeC60axPepSq7g_-1558024497")]
    [Description(@"Your instruction was too late for matching.")]
    MarketDeadlineMissed = UnmatchedReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;LEOG&quot;.
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("__rN4RdojEeC60axPepSq7g_-435536579")]
    [Description(
        @"Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa."
    )]
    LetterOfGuarantee = UnmatchedReasonCode.LetterOfGuarantee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corresponding matching record has been cancelled.
    /// Encoded/decoded by serializers as &quot;MCAN&quot;.
    /// </summary>
    [EnumMember(Value = "MCAN")]
    [IsoId("__rXCMNojEeC60axPepSq7g_-549375645")]
    [Description(@"Corresponding matching record has been cancelled.")]
    MatchingRecordCancelled = UnmatchedReasonCode.MatchingRecordCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// See narrative field for the reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("__rXCMdojEeC60axPepSq7g_-605712320")]
    [Description(@"See narrative field for the reason.")]
    NarrativeReason = UnmatchedReasonCode.NarrativeReason, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction is physical settlement, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("__rXCMtojEeC60axPepSq7g_-719551386")]
    [Description(
        @"Counterparty's instruction is physical settlement, your instruction is not, or vice versa."
    )]
    PhysicalSettlement = UnmatchedReasonCode.PhysicalSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of trade does not match.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("__rXCM9ojEeC60axPepSq7g_-1240744166")]
    [Description(@"Place of trade does not match.")]
    PlaceOfTrade = UnmatchedReasonCode.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has not been matched. It is a possible duplicate instruction.
    /// Encoded/decoded by serializers as &quot;PODU&quot;.
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("__rXCNNojEeC60axPepSq7g_-1354583232")]
    [Description(@"Instruction has not been matched. It is a possible duplicate instruction.")]
    PossibleDuplicate = UnmatchedReasonCode.PossibleDuplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Termination transaction amount does not match.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("__rXCNdojEeC60axPepSq7g_1679298118")]
    [Description(@"Termination transaction amount does not match.")]
    RepurchaseAmount = UnmatchedReasonCode.RepurchaseAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repurchase rate does not match.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("__rXCNtojEeC60axPepSq7g_1668199341")]
    [Description(@"Repurchase rate does not match.")]
    RepurchaseRate = UnmatchedReasonCode.RepurchaseRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Premium amount does not match.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("__rgzMNojEeC60axPepSq7g_1554360275")]
    [Description(@"Premium amount does not match.")]
    RepurchasePremiumAmount = UnmatchedReasonCode.RepurchasePremiumAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repurchase rate type does not match.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("__rgzMdojEeC60axPepSq7g_2122286610")]
    [Description(@"Repurchase rate type does not match.")]
    RepurchaseRateType = UnmatchedReasonCode.RepurchaseRateType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Spread rate does not match.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("__rgzMtojEeC60axPepSq7g_-814869730")]
    [Description(@"Spread rate does not match.")]
    RepurchaseSpreadRate = UnmatchedReasonCode.RepurchaseSpreadRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa.
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("__rgzM9ojEeC60axPepSq7g_-928708796")]
    [Description(
        @"Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa."
    )]
    RTGSSystem = UnmatchedReasonCode.RTGSSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller&apos;s account, direct client&apos;s account at the receiving/delivering agent, or receiving/delivering agent&apos;s account at the CSD.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("__rgzNNojEeC60axPepSq7g_1329550693")]
    [Description(
        @"Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller's account, direct client's account at the receiving/delivering agent, or receiving/delivering agent's account at the CSD."
    )]
    SafekeepingAccount = UnmatchedReasonCode.SafekeepingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.).
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("__rgzNdojEeC60axPepSq7g_1215711627")]
    [Description(
        @"Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.)."
    )]
    SettlementTransaction = UnmatchedReasonCode.SettlementTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B).
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("__rgzNtojEeC60axPepSq7g_2090315846")]
    [Description(
        @"Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B)."
    )]
    SettlementSystemMethod = UnmatchedReasonCode.SettlementSystemMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Closing date/time does not match.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("__rqkMNojEeC60axPepSq7g_1976476780")]
    [Description(@"Closing date/time does not match.")]
    ClosingDateTime = UnmatchedReasonCode.ClosingDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disagreement on the tax status of the financial instruments to be settled.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("__rqkMdojEeC60axPepSq7g_2079217069")]
    [Description(@"Disagreement on the tax status of the financial instruments to be settled.")]
    TaxStatus = UnmatchedReasonCode.TaxStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Variable rate support does not match (repo).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("__rqkMtojEeC60axPepSq7g_1965378003")]
    [Description(@"Variable rate support does not match (repo).")]
    VariableRateSupport = UnmatchedReasonCode.VariableRateSupport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Position effect does not match.
    /// Encoded/decoded by serializers as &quot;POSE&quot;.
    /// </summary>
    [EnumMember(Value = "POSE")]
    [IsoId("__rqkM9ojEeC60axPepSq7g_559814190")]
    [Description(@"Position effect does not match.")]
    PositionEffect = UnmatchedReasonCode.PositionEffect, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Borrowing rate does not match.
    /// Encoded/decoded by serializers as &quot;BORT&quot;.
    /// </summary>
    [EnumMember(Value = "BORT")]
    [IsoId("__rqkNNojEeC60axPepSq7g_-259139491")]
    [Description(@"Borrowing rate does not match.")]
    BorrowingRate = UnmatchedReasonCode.BorrowingRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Consumption tax amount does not match.
    /// Encoded/decoded by serializers as &quot;COAX&quot;.
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("__rqkNdojEeC60axPepSq7g_-1548169582")]
    [Description(@"Consumption tax amount does not match.")]
    ConsumptionTax = UnmatchedReasonCode.ConsumptionTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// OtherIdentification of financial instrument identification does not match.
    /// Encoded/decoded by serializers as &quot;OTHI&quot;.
    /// </summary>
    [EnumMember(Value = "OTHI")]
    [IsoId("__rqkNtojEeC60axPepSq7g_1927844033")]
    [Description(@"OtherIdentification of financial instrument identification does not match.")]
    OtherFinancialInstrumentIdentification =
        UnmatchedReasonCode.OtherFinancialInstrumentIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Borrowing fee does not match.
    /// Encoded/decoded by serializers as &quot;BOFE&quot;.
    /// </summary>
    [EnumMember(Value = "BOFE")]
    [IsoId("__rzuINojEeC60axPepSq7g_-130580279")]
    [Description(@"Borrowing fee does not match.")]
    BorrowingFee = UnmatchedReasonCode.BorrowingFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Accrued interest tax indicator does not match.
    /// Encoded/decoded by serializers as &quot;TACR&quot;.
    /// </summary>
    [EnumMember(Value = "TACR")]
    [IsoId("__rzuIdojEeC60axPepSq7g_-872495259")]
    [Description(@"Accrued interest tax indicator does not match.")]
    AccruedInterestTax1 = UnmatchedReasonCode.AccruedInterestTax1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement date in the second leg does not match.
    /// Encoded/decoded by serializers as &quot;SDAT&quot;.
    /// </summary>
    [EnumMember(Value = "SDAT")]
    [IsoId("__rzuItojEeC60axPepSq7g_521536905")]
    [Description(@"Settlement date in the second leg does not match.")]
    SettlementDate2 = UnmatchedReasonCode.SettlementDate2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CommonIdentification does not match.
    /// Encoded/decoded by serializers as &quot;COID&quot;.
    /// </summary>
    [EnumMember(Value = "COID")]
    [IsoId("__rzuI9ojEeC60axPepSq7g_-297416776")]
    [Description(@"CommonIdentification does not match.")]
    CommonIdentification = UnmatchedReasonCode.CommonIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standard collateral ratio does not match.
    /// Encoded/decoded by serializers as &quot;SCRA&quot;.
    /// </summary>
    [EnumMember(Value = "SCRA")]
    [IsoId("__rzuJNojEeC60axPepSq7g_1939126208")]
    [Description(@"Standard collateral ratio does not match.")]
    StandardCollateralRatio = UnmatchedReasonCode.StandardCollateralRatio, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Accrued interest amount does not match.
    /// Encoded/decoded by serializers as &quot;ACRU&quot;.
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("__rzuJdojEeC60axPepSq7g_1120172527")]
    [Description(@"Accrued interest amount does not match.")]
    AccruedInterestAmount1 = UnmatchedReasonCode.AccruedInterestAmount1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities haircut rate does not match.
    /// Encoded/decoded by serializers as &quot;SHAI&quot;.
    /// </summary>
    [EnumMember(Value = "SHAI")]
    [IsoId("__rzuJtojEeC60axPepSq7g_-168857564")]
    [Description(@"Securities haircut rate does not match.")]
    SecuritiesHaircut = UnmatchedReasonCode.SecuritiesHaircut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Accrued interest amount in the second leg does not match.
    /// Encoded/decoded by serializers as &quot;ACRS&quot;.
    /// </summary>
    [EnumMember(Value = "ACRS")]
    [IsoId("__r9fINojEeC60axPepSq7g_-987811245")]
    [Description(@"Accrued interest amount in the second leg does not match.")]
    AccruedInterestAmount2 = UnmatchedReasonCode.AccruedInterestAmount2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal amount in the second leg does not match.
    /// Encoded/decoded by serializers as &quot;DEAS&quot;.
    /// </summary>
    [EnumMember(Value = "DEAS")]
    [IsoId("__r9fIdojEeC60axPepSq7g_1248731739")]
    [Description(@"Deal amount in the second leg does not match.")]
    DealAmount2 = UnmatchedReasonCode.DealAmount2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CallableTradeIndicator does not match.
    /// Encoded/decoded by serializers as &quot;CATI&quot;.
    /// </summary>
    [EnumMember(Value = "CATI")]
    [IsoId("__r9fItojEeC60axPepSq7g_677685175")]
    [Description(@"CallableTradeIndicator does not match.")]
    CallableTradeIndicator = UnmatchedReasonCode.CallableTradeIndicator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Accrued interest tax indicator in the second leg does not match.
    /// Encoded/decoded by serializers as &quot;TACS&quot;.
    /// </summary>
    [EnumMember(Value = "TACS")]
    [IsoId("__r9fI9ojEeC60axPepSq7g_-141268506")]
    [Description(@"Accrued interest tax indicator in the second leg does not match.")]
    AccruedInterestTax2 = UnmatchedReasonCode.AccruedInterestTax2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction is for settlement through standing settlement instruction, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;DBNM&quot;.
    /// </summary>
    [EnumMember(Value = "DBNM")]
    [IsoId("__r9fJNojEeC60axPepSq7g_-1430298597")]
    [Description(
        @"Counterparty's instruction is for settlement through standing settlement instruction, your instruction is not, or vice versa."
    )]
    StandingSettlementInstruction = UnmatchedReasonCode.StandingSettlementInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maturity date does not match.
    /// Encoded/decoded by serializers as &quot;MADA&quot;.
    /// </summary>
    [EnumMember(Value = "MADA")]
    [IsoId("__r9fJdojEeC60axPepSq7g_2045715018")]
    [Description(@"Maturity date does not match.")]
    MaturityDate = UnmatchedReasonCode.MaturityDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ClientOrderLinkIdentification does not match.
    /// Encoded/decoded by serializers as &quot;OLID&quot;.
    /// </summary>
    [EnumMember(Value = "OLID")]
    [IsoId("__r9fJtojEeC60axPepSq7g_-12709294")]
    [Description(@"ClientOrderLinkIdentification does not match.")]
    ClientOrderLinkIdentification = UnmatchedReasonCode.ClientOrderLinkIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Closing settlement amount does not match.
    /// Encoded/decoded by serializers as &quot;TRSA&quot;.
    /// </summary>
    [EnumMember(Value = "TRSA")]
    [IsoId("__sGpENojEeC60axPepSq7g_-831662975")]
    [Description(@"Closing settlement amount does not match.")]
    ClosingSettlementAmount = UnmatchedReasonCode.ClosingSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of financing closing does not match.
    /// Encoded/decoded by serializers as &quot;TRTE&quot;.
    /// </summary>
    [EnumMember(Value = "TRTE")]
    [IsoId("__sGpEdojEeC60axPepSq7g_-2120693066")]
    [Description(@"Type of financing closing does not match.")]
    TypeOfFinancingClosing = UnmatchedReasonCode.TypeOfFinancingClosing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Borrowing interest amount does not match.
    /// Encoded/decoded by serializers as &quot;BOIA&quot;.
    /// </summary>
    [EnumMember(Value = "BOIA")]
    [IsoId("__sGpEtojEeC60axPepSq7g_1355320549")]
    [Description(@"Borrowing interest amount does not match.")]
    BorrowingInterestAmount = UnmatchedReasonCode.BorrowingInterestAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// OpeningLegIdentification does not match.
    /// Encoded/decoded by serializers as &quot;OPLI&quot;.
    /// </summary>
    [EnumMember(Value = "OPLI")]
    [IsoId("__sGpE9ojEeC60axPepSq7g_-626065062")]
    [Description(@"OpeningLegIdentification does not match.")]
    OpeningLegIdentification = UnmatchedReasonCode.OpeningLegIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade transaction type does not match.
    /// Encoded/decoded by serializers as &quot;TRTR&quot;.
    /// </summary>
    [EnumMember(Value = "TRTR")]
    [IsoId("__sGpFNojEeC60axPepSq7g_1238043512")]
    [Description(@"Trade transaction type does not match.")]
    TradeTransactionType = UnmatchedReasonCode.TradeTransactionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// LendingWithCollateral does not match.
    /// Encoded/decoded by serializers as &quot;LWCO&quot;.
    /// </summary>
    [EnumMember(Value = "LWCO")]
    [IsoId("__sGpFdojEeC60axPepSq7g_-50986579")]
    [Description(@"LendingWithCollateral does not match.")]
    LendingWithCollateral = UnmatchedReasonCode.LendingWithCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interest type does not match.
    /// Encoded/decoded by serializers as &quot;INTT&quot;.
    /// </summary>
    [EnumMember(Value = "INTT")]
    [IsoId("__sQaENojEeC60axPepSq7g_1599848485")]
    [Description(@"Interest type does not match.")]
    InterestType = UnmatchedReasonCode.InterestType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Current factor does not match.
    /// Encoded/decoded by serializers as &quot;CUFC&quot;.
    /// </summary>
    [EnumMember(Value = "CUFC")]
    [IsoId("__sQaEdojEeC60axPepSq7g_780894804")]
    [Description(@"Current factor does not match.")]
    CurrentFactor = UnmatchedReasonCode.CurrentFactor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Lending transaction method does not match.
    /// Encoded/decoded by serializers as &quot;LTME&quot;.
    /// </summary>
    [EnumMember(Value = "LTME")]
    [IsoId("__sQaEtojEeC60axPepSq7g_-508135287")]
    [Description(@"Lending transaction method does not match.")]
    LendingTransactionMethod = UnmatchedReasonCode.LendingTransactionMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// End factor does not match.
    /// Encoded/decoded by serializers as &quot;ENFC&quot;.
    /// </summary>
    [EnumMember(Value = "ENFC")]
    [IsoId("__sQaE9ojEeC60axPepSq7g_-1327088968")]
    [Description(@"End factor does not match.")]
    EndFactor = UnmatchedReasonCode.EndFactor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction is for settlement through clearing segment, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;CLSE&quot;.
    /// </summary>
    [EnumMember(Value = "CLSE")]
    [IsoId("__sQaFNojEeC60axPepSq7g_909454016")]
    [Description(
        @"Counterparty's instruction is for settlement through clearing segment, your instruction is not, or vice versa."
    )]
    ClearingSegment = UnmatchedReasonCode.ClearingSegment, // same ordinal as derivation source for type conversions
}
