// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y65ccNp-Ed-ak6NoX_4Aeg_-1178673663")]
[Description(
    @"Specifies the reason the transaction, transfer or settlement instruction is unmatched."
)]
[Derivations(
    typeof(UnmatchedReason16Code),
    typeof(UnmatchedReason9Code),
    typeof(UnmatchedReason2Code),
    typeof(UnmatchedReason6Code),
    typeof(UnmatchedReason5Code),
    typeof(UnmatchedReason7Code),
    typeof(UnmatchedReason14Code),
    typeof(UnmatchedReason8Code),
    typeof(UnmatchedReason13Code),
    typeof(UnmatchedReason11Code),
    typeof(UnmatchedReason4Code),
    typeof(UnmatchedReason3Code),
    typeof(UnmatchedReason10Code),
    typeof(UnmatchedReason15Code),
    typeof(UnmatchedReason12Code),
    typeof(UnmatchedReason1Code)
)]
public enum UnmatchedReasonCode
{
    /// <summary>
    /// OtherIdentification of financial instrument identification does not match.
    /// Encoded/decoded by serializers as &quot;OTHI&quot;.
    /// </summary>
    [EnumMember(Value = "OTHI")]
    [IsoId("__5-F8NojEeC60axPepSq7g_-304664773")]
    [Description(@"OtherIdentification of financial instrument identification does not match.")]
    OtherFinancialInstrumentIdentification,

    /// <summary>
    /// LendingWithCollateral does not match.
    /// Encoded/decoded by serializers as &quot;LWCO&quot;.
    /// </summary>
    [EnumMember(Value = "LWCO")]
    [IsoId("__5-F8dojEeC60axPepSq7g_1232998251")]
    [Description(@"LendingWithCollateral does not match.")]
    LendingWithCollateral,

    /// <summary>
    /// Lending transaction method does not match.
    /// Encoded/decoded by serializers as &quot;LTME&quot;.
    /// </summary>
    [EnumMember(Value = "LTME")]
    [IsoId("__5-F8tojEeC60axPepSq7g_522025126")]
    [Description(@"Lending transaction method does not match.")]
    LendingTransactionMethod,

    /// <summary>
    /// CallableTradeIndicator does not match.
    /// Encoded/decoded by serializers as &quot;CATI&quot;.
    /// </summary>
    [EnumMember(Value = "CATI")]
    [IsoId("__5-F89ojEeC60axPepSq7g_-1137320833")]
    [Description(@"CallableTradeIndicator does not match.")]
    CallableTradeIndicator,

    /// <summary>
    /// Position effect does not match.
    /// Encoded/decoded by serializers as &quot;POSE&quot;.
    /// </summary>
    [EnumMember(Value = "POSE")]
    [IsoId("__5-F9NojEeC60axPepSq7g_2025859188")]
    [Description(@"Position effect does not match.")]
    PositionEffect,

    /// <summary>
    /// Type of financing closing does not match.
    /// Encoded/decoded by serializers as &quot;TRTE&quot;.
    /// </summary>
    [EnumMember(Value = "TRTE")]
    [IsoId("__6HP4NojEeC60axPepSq7g_1391243901")]
    [Description(@"Type of financing closing does not match.")]
    TypeOfFinancingClosing,

    /// <summary>
    /// Settlement date in the second leg does not match.
    /// Encoded/decoded by serializers as &quot;SDAT&quot;.
    /// </summary>
    [EnumMember(Value = "SDAT")]
    [IsoId("__6HP4dojEeC60axPepSq7g_880810440")]
    [Description(@"Settlement date in the second leg does not match.")]
    SettlementDate2,

    /// <summary>
    /// Borrowing rate does not match.
    /// Encoded/decoded by serializers as &quot;BORT&quot;.
    /// </summary>
    [EnumMember(Value = "BORT")]
    [IsoId("__6HP4tojEeC60axPepSq7g_1929864788")]
    [Description(@"Borrowing rate does not match.")]
    BorrowingRate,

    /// <summary>
    /// ClientOrderLinkIdentification does not match.
    /// Encoded/decoded by serializers as &quot;OLID&quot;.
    /// </summary>
    [EnumMember(Value = "OLID")]
    [IsoId("__6HP49ojEeC60axPepSq7g_-1910972375")]
    [Description(@"ClientOrderLinkIdentification does not match.")]
    ClientOrderLinkIdentification,

    /// <summary>
    /// OpeningLegIdentification does not match.
    /// Encoded/decoded by serializers as &quot;OPLI&quot;.
    /// </summary>
    [EnumMember(Value = "OPLI")]
    [IsoId("__6HP5NojEeC60axPepSq7g_-831561721")]
    [Description(@"OpeningLegIdentification does not match.")]
    OpeningLegIdentification,

    /// <summary>
    /// End factor does not match.
    /// Encoded/decoded by serializers as &quot;ENFC&quot;.
    /// </summary>
    [EnumMember(Value = "ENFC")]
    [IsoId("__6HP5dojEeC60axPepSq7g_-2143930594")]
    [Description(@"End factor does not match.")]
    EndFactor,

    /// <summary>
    /// Current factor does not match.
    /// Encoded/decoded by serializers as &quot;CUFC&quot;.
    /// </summary>
    [EnumMember(Value = "CUFC")]
    [IsoId("__6HP5tojEeC60axPepSq7g_-1023035822")]
    [Description(@"Current factor does not match.")]
    CurrentFactor,

    /// <summary>
    /// Maturity date does not match.
    /// Encoded/decoded by serializers as &quot;MADA&quot;.
    /// </summary>
    [EnumMember(Value = "MADA")]
    [IsoId("__6RA4NojEeC60axPepSq7g_1859552978")]
    [Description(@"Maturity date does not match.")]
    MaturityDate,

    /// <summary>
    /// Closing settlement amount does not match.
    /// Encoded/decoded by serializers as &quot;TRSA&quot;.
    /// </summary>
    [EnumMember(Value = "TRSA")]
    [IsoId("__6RA4dojEeC60axPepSq7g_-68105324")]
    [Description(@"Closing settlement amount does not match.")]
    ClosingSettlementAmount,

    /// <summary>
    /// Accrued interest amount in the second leg does not match.
    /// Encoded/decoded by serializers as &quot;ACRS&quot;.
    /// </summary>
    [EnumMember(Value = "ACRS")]
    [IsoId("__6RA4tojEeC60axPepSq7g_561457308")]
    [Description(@"Accrued interest amount in the second leg does not match.")]
    AccruedInterestAmount2,

    /// <summary>
    /// Deal amount in the second leg does not match.
    /// Encoded/decoded by serializers as &quot;DEAS&quot;.
    /// </summary>
    [EnumMember(Value = "DEAS")]
    [IsoId("__6RA49ojEeC60axPepSq7g_552912343")]
    [Description(@"Deal amount in the second leg does not match.")]
    DealAmount2,

    /// <summary>
    /// Borrowing fee does not match.
    /// Encoded/decoded by serializers as &quot;BOFE&quot;.
    /// </summary>
    [EnumMember(Value = "BOFE")]
    [IsoId("__6RA5NojEeC60axPepSq7g_809272261")]
    [Description(@"Borrowing fee does not match.")]
    BorrowingFee,

    /// <summary>
    /// Borrowing interest amount does not match.
    /// Encoded/decoded by serializers as &quot;BOIA&quot;.
    /// </summary>
    [EnumMember(Value = "BOIA")]
    [IsoId("__6RA5dojEeC60axPepSq7g_143881417")]
    [Description(@"Borrowing interest amount does not match.")]
    BorrowingInterestAmount,

    /// <summary>
    /// Securities haircut rate does not match.
    /// Encoded/decoded by serializers as &quot;SHAI&quot;.
    /// </summary>
    [EnumMember(Value = "SHAI")]
    [IsoId("__6RA5tojEeC60axPepSq7g_393838524")]
    [Description(@"Securities haircut rate does not match.")]
    SecuritiesHaircut,

    /// <summary>
    /// Standard collateral ratio does not match.
    /// Encoded/decoded by serializers as &quot;SCRA&quot;.
    /// </summary>
    [EnumMember(Value = "SCRA")]
    [IsoId("__6ax4NojEeC60axPepSq7g_1566464790")]
    [Description(@"Standard collateral ratio does not match.")]
    StandardCollateralRatio,

    /// <summary>
    /// Accrued interest tax indicator in the second leg does not match.
    /// Encoded/decoded by serializers as &quot;TACS&quot;.
    /// </summary>
    [EnumMember(Value = "TACS")]
    [IsoId("__6ax4dojEeC60axPepSq7g_252705128")]
    [Description(@"Accrued interest tax indicator in the second leg does not match.")]
    AccruedInterestTax2,

    /// <summary>
    /// Interest type does not match.
    /// Encoded/decoded by serializers as &quot;INTT&quot;.
    /// </summary>
    [EnumMember(Value = "INTT")]
    [IsoId("__6ax4tojEeC60axPepSq7g_1902311817")]
    [Description(@"Interest type does not match.")]
    InterestType,

    /// <summary>
    /// See narrative field for the reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("__6ax49ojEeC60axPepSq7g_-1479295062")]
    [Description(@"See narrative field for the reason.")]
    NarrativeReason,

    /// <summary>
    /// Counterparty&apos;s instruction is for settlement through clearing segment, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;CLSE&quot;.
    /// </summary>
    [EnumMember(Value = "CLSE")]
    [IsoId("__6ax5NojEeC60axPepSq7g_-1730925220")]
    [Description(
        @"Counterparty's instruction is for settlement through clearing segment, your instruction is not, or vice versa."
    )]
    ClearingSegment,

    /// <summary>
    /// Counterparty&apos;s instruction is for settlement through standing settlement instruction, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;DBNM&quot;.
    /// </summary>
    [EnumMember(Value = "DBNM")]
    [IsoId("__6ax5dojEeC60axPepSq7g_1605086138")]
    [Description(
        @"Counterparty's instruction is for settlement through standing settlement instruction, your instruction is not, or vice versa."
    )]
    StandingSettlementInstruction,

    /// <summary>
    /// Accrued interest tax indicator does not match.
    /// Encoded/decoded by serializers as &quot;TACR&quot;.
    /// </summary>
    [EnumMember(Value = "TACR")]
    [IsoId("__6ax5tojEeC60axPepSq7g_368779090")]
    [Description(@"Accrued interest tax indicator does not match.")]
    AccruedInterestTax1,

    /// <summary>
    /// Trade transaction type does not match.
    /// Encoded/decoded by serializers as &quot;TRTR&quot;.
    /// </summary>
    [EnumMember(Value = "TRTR")]
    [IsoId("__6j70NojEeC60axPepSq7g_991819173")]
    [Description(@"Trade transaction type does not match.")]
    TradeTransactionType,

    /// <summary>
    /// CommonIdentification does not match.
    /// Encoded/decoded by serializers as &quot;COID&quot;.
    /// </summary>
    [EnumMember(Value = "COID")]
    [IsoId("__6j70dojEeC60axPepSq7g_-1456720860")]
    [Description(@"CommonIdentification does not match.")]
    CommonIdentification,

    /// <summary>
    /// Accrued interest amount does not match.
    /// Encoded/decoded by serializers as &quot;ACRU&quot;.
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("__6j70tojEeC60axPepSq7g_-1015749051")]
    [Description(@"Accrued interest amount does not match.")]
    AccruedInterestAmount1,

    /// <summary>
    /// Consumption tax amount does not match.
    /// Encoded/decoded by serializers as &quot;COAX&quot;.
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("__6j709ojEeC60axPepSq7g_-913646013")]
    [Description(@"Consumption tax amount does not match.")]
    ConsumptionTax,

    /// <summary>
    /// A matching instruction from your counterparty could not be found.
    /// Encoded/decoded by serializers as &quot;CMIS&quot;.
    /// </summary>
    [EnumMember(Value = "CMIS")]
    [IsoId("_Y65ccdp-Ed-ak6NoX_4Aeg_-1292512729")]
    [Description(@"A matching instruction from your counterparty could not be found.")]
    NoMatch,

    /// <summary>
    /// Settlement date/time does not match.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_Y65cctp-Ed-ak6NoX_4Aeg_1827263542")]
    [Description(@"Settlement date/time does not match.")]
    SettlementDate,

    /// <summary>
    /// Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa.
    /// Encoded/decoded by serializers as &quot;DELN&quot;.
    /// </summary>
    [EnumMember(Value = "DELN")]
    [IsoId("_Y65cc9p-Ed-ak6NoX_4Aeg_1122148927")]
    [Description(
        @"Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa."
    )]
    TransactionDirection,

    /// <summary>
    /// Deal amount does not match.
    /// Encoded/decoded by serializers as &quot;DEAL&quot;.
    /// </summary>
    [EnumMember(Value = "DEAL")]
    [IsoId("_Y65cdNp-Ed-ak6NoX_4Aeg_-1527550934")]
    [Description(@"Deal amount does not match.")]
    TransactionDealAmount,

    /// <summary>
    /// Depository does not match.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_Y65cddp-Ed-ak6NoX_4Aeg_11237508")]
    [Description(@"Depository does not match.")]
    ReceivingDeliveringDepository,

    /// <summary>
    /// Settlement amount does not match.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_Y65cdtp-Ed-ak6NoX_4Aeg_-1163953517")]
    [Description(@"Settlement amount does not match.")]
    SettlementAmount,

    /// <summary>
    /// Deal price does not match.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_Y65cd9p-Ed-ak6NoX_4Aeg_-1869068132")]
    [Description(@"Deal price does not match.")]
    DealPrice,

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Y65ceNp-Ed-ak6NoX_4Aeg_-223800697")]
    [Description(@"Quantity of financial instruments does not match.")]
    FinancialInstrumentQuantity,

    /// <summary>
    /// Transaction call delay does not match.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_Y65cedp-Ed-ak6NoX_4Aeg_1314987745")]
    [Description(@"Transaction call delay does not match.")]
    RepurchaseCallDelay,

    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Y65cetp-Ed-ak6NoX_4Aeg_139796720")]
    [Description(
        @"Received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed,

    /// <summary>
    /// Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.).
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_Y7DNcNp-Ed-ak6NoX_4Aeg_-565317895")]
    [Description(
        @"Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.)."
    )]
    SettlementTransaction,

    /// <summary>
    /// Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B).
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_Y7DNcdp-Ed-ak6NoX_4Aeg_1079949540")]
    [Description(
        @"Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B)."
    )]
    SettlementSystemMethod,

    /// <summary>
    /// Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_Y7DNctp-Ed-ak6NoX_4Aeg_-1676229314")]
    [Description(
        @"Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs."
    )]
    FinancialInstrument,

    /// <summary>
    /// Variable rate support does not match (repo).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_Y7DNc9p-Ed-ak6NoX_4Aeg_-243919865")]
    [Description(@"Variable rate support does not match (repo).")]
    VariableRateSupport,

    /// <summary>
    /// Counterparty has been contacted or contacted us, and does not recognise the transaction.
    /// Encoded/decoded by serializers as &quot;DTRA&quot;.
    /// </summary>
    [EnumMember(Value = "DTRA")]
    [IsoId("_Y7DNdNp-Ed-ak6NoX_4Aeg_-949034480")]
    [Description(
        @"Counterparty has been contacted or contacted us, and does not recognise the transaction."
    )]
    NotRecognised,

    /// <summary>
    /// Spread rate does not match.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_Y7DNddp-Ed-ak6NoX_4Aeg_696232955")]
    [Description(@"Spread rate does not match.")]
    RepurchaseSpreadRate,

    /// <summary>
    /// Repurchase rate does not match.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_Y7DNdtp-Ed-ak6NoX_4Aeg_-2059945899")]
    [Description(@"Repurchase rate does not match.")]
    RepurchaseRate,

    /// <summary>
    /// Counterparty&apos;s instruction was too late for matching.
    /// Encoded/decoded by serializers as &quot;CLAT&quot;.
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_Y7DNd9p-Ed-ak6NoX_4Aeg_1059830372")]
    [Description(@"Counterparty's instruction was too late for matching.")]
    CounterpartyTooLateForMatching,

    /// <summary>
    /// Repurchase rate type does not match.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_Y7DNeNp-Ed-ak6NoX_4Aeg_354715757")]
    [Description(@"Repurchase rate type does not match.")]
    RepurchaseRateType,

    /// <summary>
    /// Termination transaction amount does not match.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_Y7DNedp-Ed-ak6NoX_4Aeg_1999983192")]
    [Description(@"Termination transaction amount does not match.")]
    RepurchaseAmount,

    /// <summary>
    /// Premium amount does not match.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_Y7MXYNp-Ed-ak6NoX_4Aeg_-756195662")]
    [Description(@"Premium amount does not match.")]
    RepurchasePremiumAmount,

    /// <summary>
    /// Counterparty&apos;s instruction is physical settlement, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_Y7MXYdp-Ed-ak6NoX_4Aeg_-1931386687")]
    [Description(
        @"Counterparty's instruction is physical settlement, your instruction is not, or vice versa."
    )]
    PhysicalSettlement,

    /// <summary>
    /// Common reference does not match.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_Y7MXYtp-Ed-ak6NoX_4Aeg_1658465994")]
    [Description(@"Common reference does not match.")]
    CommonReference,

    /// <summary>
    /// Payment type does not match: your instruction is free of payment, your counterparty&apos;s instruction is against payment or vice versa.
    /// Encoded/decoded by serializers as &quot;FRAP&quot;.
    /// </summary>
    [EnumMember(Value = "FRAP")]
    [IsoId("_Y7MXY9p-Ed-ak6NoX_4Aeg_-991233867")]
    [Description(
        @"Payment type does not match: your instruction is free of payment, your counterparty's instruction is against payment or vice versa."
    )]
    PaymentCode,

    /// <summary>
    /// Place of trade does not match.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_Y7MXZNp-Ed-ak6NoX_4Aeg_547554575")]
    [Description(@"Place of trade does not match.")]
    PlaceOfTrade,

    /// <summary>
    /// Instruction has not been matched. It is a possible duplicate instruction.
    /// Encoded/decoded by serializers as &quot;PODU&quot;.
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("_Y7MXZdp-Ed-ak6NoX_4Aeg_-627636450")]
    [Description(@"Instruction has not been matched. It is a possible duplicate instruction.")]
    PossibleDuplicate,

    /// <summary>
    /// Forfeit amount does not match.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_Y7MXZtp-Ed-ak6NoX_4Aeg_-1332751065")]
    [Description(@"Forfeit amount does not match.")]
    ForfeitRepurchaseAmount,

    /// <summary>
    /// Executing broker&apos;s commission does not match.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_Y7MXZ9p-Ed-ak6NoX_4Aeg_312516370")]
    [Description(@"Executing broker's commission does not match.")]
    ExecutionBrokerCommission,

    /// <summary>
    /// Registration details linked to the transaction are incorrect.
    /// Encoded/decoded by serializers as &quot;REGD&quot;.
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_Y7MXaNp-Ed-ak6NoX_4Aeg_1851304812")]
    [Description(@"Registration details linked to the transaction are incorrect.")]
    RegistrationDetails,

    /// <summary>
    /// Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa.
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_Y7MXadp-Ed-ak6NoX_4Aeg_676113787")]
    [Description(
        @"Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa."
    )]
    RTGSSystem,

    /// <summary>
    /// Participant of delivering or receiving depository does not match.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_Y7MXatp-Ed-ak6NoX_4Aeg_-29000828")]
    [Description(@"Participant of delivering or receiving depository does not match.")]
    ReceivingDeliveringParty1,

    /// <summary>
    /// Counterparty cancelled their instruction.
    /// Encoded/decoded by serializers as &quot;CPCA&quot;.
    /// </summary>
    [EnumMember(Value = "CPCA")]
    [IsoId("_Y7WIYNp-Ed-ak6NoX_4Aeg_1616266607")]
    [Description(@"Counterparty cancelled their instruction.")]
    CounterpartyCancelled,

    /// <summary>
    /// Charges amount does not match.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_Y7WIYdp-Ed-ak6NoX_4Aeg_-1139912247")]
    [Description(@"Charges amount does not match.")]
    ChargesAmount,

    /// <summary>
    /// Client of delivering or receiving party 2 does not match.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_Y7WIYtp-Ed-ak6NoX_4Aeg_1979864024")]
    [Description(@"Client of delivering or receiving party 2 does not match.")]
    ReceivingDeliveringParty3,

    /// <summary>
    /// Settlement amount currency does not match.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_Y7WIY9p-Ed-ak6NoX_4Aeg_1274749409")]
    [Description(@"Settlement amount currency does not match.")]
    CurrencySettlementAmount,

    /// <summary>
    /// Corresponding matching record has been cancelled.
    /// Encoded/decoded by serializers as &quot;MCAN&quot;.
    /// </summary>
    [EnumMember(Value = "MCAN")]
    [IsoId("_Y7WIZNp-Ed-ak6NoX_4Aeg_-1374950452")]
    [Description(@"Corresponding matching record has been cancelled.")]
    MatchingRecordCancelled,

    /// <summary>
    /// Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;LEOG&quot;.
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("_Y7WIZdp-Ed-ak6NoX_4Aeg_163837990")]
    [Description(
        @"Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa."
    )]
    LetterOfGuarantee,

    /// <summary>
    /// Matching process has not yet started.
    /// Encoded/decoded by serializers as &quot;NMAS&quot;.
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("_Y7WIZtp-Ed-ak6NoX_4Aeg_-1011353035")]
    [Description(@"Matching process has not yet started.")]
    NoMatchingStarted,

    /// <summary>
    /// Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller&apos;s account, direct client&apos;s account at the receiving/delivering agent, or receiving/delivering agent&apos;s account at the CSD.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_Y7WIZ9p-Ed-ak6NoX_4Aeg_-1716467650")]
    [Description(
        @"Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller's account, direct client's account at the receiving/delivering agent, or receiving/delivering agent's account at the CSD."
    )]
    SafekeepingAccount,

    /// <summary>
    /// Trade date does not match.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_Y7WIaNp-Ed-ak6NoX_4Aeg_-71200215")]
    [Description(@"Trade date does not match.")]
    TradeDate,

    /// <summary>
    /// Your instruction was too late for matching.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_Y7WIadp-Ed-ak6NoX_4Aeg_1467588227")]
    [Description(@"Your instruction was too late for matching.")]
    MarketDeadlineMissed,

    /// <summary>
    /// Closing date/time does not match.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_Y7f5YNp-Ed-ak6NoX_4Aeg_292397202")]
    [Description(@"Closing date/time does not match.")]
    ClosingDateTime,

    /// <summary>
    /// Disagreement on the tax status of the financial instruments to be settled.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_Y7f5Ydp-Ed-ak6NoX_4Aeg_-412717413")]
    [Description(@"Disagreement on the tax status of the financial instruments to be settled.")]
    TaxStatus,

    /// <summary>
    /// Client of delivering or receiving party 1 does not match.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_Y7f5Ytp-Ed-ak6NoX_4Aeg_1232550022")]
    [Description(@"Client of delivering or receiving party 1 does not match.")]
    ReceivingDeliveringParty2,

    /// <summary>
    /// Proprietary unmatched reason code described in a narrative field.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Y7f5Y9p-Ed-ak6NoX_4Aeg_-1523628832")]
    [Description(@"Proprietary unmatched reason code described in a narrative field.")]
    Other,

    /// <summary>
    /// Missing market execution details.
    /// Encoded/decoded by serializers as &quot;MIME&quot;.
    /// </summary>
    [EnumMember(Value = "MIME")]
    [IsoId("_Y7f5ZNp-Ed-ak6NoX_4Aeg_1596147439")]
    [Description(@"Missing market execution details.")]
    MissingMarketSide,

    /// <summary>
    /// Market side trade is unmatched.
    /// Encoded/decoded by serializers as &quot;UNBR&quot;.
    /// </summary>
    [EnumMember(Value = "UNBR")]
    [IsoId("_Y7f5Zdp-Ed-ak6NoX_4Aeg_891032824")]
    [Description(@"Market side trade is unmatched.")]
    UnmatchedMarketSide,

    /// <summary>
    /// Place of safekeeping information does not allow matching to take place.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_Y7f5Ztp-Ed-ak6NoX_4Aeg_-1196939541")]
    [Description(@"Place of safekeeping information does not allow matching to take place.")]
    PlaceOfSafekeeping,

    /// <summary>
    /// Investor party does not match.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_7p7QACwJEeOqZONeZTLNPw")]
    [Description(@"Investor party does not match.")]
    InvestorParty,

    /// <summary>
    /// Place of listing does not match.
    /// Encoded/decoded by serializers as &quot;PLIS&quot;.
    /// </summary>
    [EnumMember(Value = "PLIS")]
    [IsoId("_B7xBgCwKEeOqZONeZTLNPw")]
    [Description(@"Place of listing does not match.")]
    PlaceOfListing,

    /// <summary>
    /// Disagreement if trade was executed cum or ex.
    /// Encoded/decoded by serializers as &quot;DCMX&quot;.
    /// </summary>
    [EnumMember(Value = "DCMX")]
    [IsoId("_oKBnQGXeEeWsrOWU209RUg")]
    [Description(@"Disagreement if trade was executed cum or ex.")]
    CumEx,

    /// <summary>
    /// Disagreement on automatic generation of market claim or transformation.
    /// Encoded/decoded by serializers as &quot;DMCT&quot;.
    /// </summary>
    [EnumMember(Value = "DMCT")]
    [IsoId("_7GiUkGXeEeWsrOWU209RUg")]
    [Description(@"Disagreement on automatic generation of market claim or transformation.")]
    AutomaticGeneration,

    /// <summary>
    /// The exposure type does not match.
    /// Encoded/decoded by serializers as &quot;EXPO&quot;.
    /// </summary>
    [EnumMember(Value = "EXPO")]
    [IsoId("_gntAINCoEeqVwOG0fcjVKA")]
    [Description(@"The exposure type does not match.")]
    Exposure,

    /// <summary>
    /// The Eligibility Set Profile does not match.
    /// Encoded/decoded by serializers as &quot;EGSP&quot;.
    /// </summary>
    [EnumMember(Value = "EGSP")]
    [IsoId("_A66BwNCpEeqVwOG0fcjVKA")]
    [Description(@"The Eligibility Set Profile does not match.")]
    EligibilitySetProfile,

    /// <summary>
    /// Minimum Notice Period does not match
    /// Encoded/decoded by serializers as &quot;MNTP&quot;.
    /// </summary>
    [EnumMember(Value = "MNTP")]
    [IsoId("_I9qXQNCpEeqVwOG0fcjVKA")]
    [Description(@"Minimum Notice Period does not match")]
    MinimumNoticePeriod,

    /// <summary>
    /// Transaction amount does not  match.
    /// Encoded/decoded by serializers as &quot;TXAM&quot;.
    /// </summary>
    [EnumMember(Value = "TXAM")]
    [IsoId("_agTuoNCpEeqVwOG0fcjVKA")]
    [Description(@"Transaction amount does not  match.|")]
    TransactionAmount,

    /// <summary>
    /// Termination amount does not match.
    /// Encoded/decoded by serializers as &quot;TMAM&quot;.
    /// </summary>
    [EnumMember(Value = "TMAM")]
    [IsoId("_4_BT0NCpEeqVwOG0fcjVKA")]
    [Description(@"Termination amount does not match.")]
    TerminationAmount,

    /// <summary>
    /// Termination Currency does not match
    /// Encoded/decoded by serializers as &quot;TMCY&quot;.
    /// </summary>
    [EnumMember(Value = "TMCY")]
    [IsoId("_AMg1QNCqEeqVwOG0fcjVKA")]
    [Description(@"Termination Currency does not match")]
    TerminationCurrency,

    /// <summary>
    /// Transaction Currency does not match.
    /// Encoded/decoded by serializers as &quot;TXCY&quot;.
    /// </summary>
    [EnumMember(Value = "TXCY")]
    [IsoId("_AqkqQNCqEeqVwOG0fcjVKA")]
    [Description(@"Transaction Currency does not match.")]
    TransactionCurrency,

    /// <summary>
    /// Rate does not match.
    /// Encoded/decoded by serializers as &quot;RATE&quot;.
    /// </summary>
    [EnumMember(Value = "RATE")]
    [IsoId("_VMYhcNCqEeqVwOG0fcjVKA")]
    [Description(@"Rate does not match.")]
    Rate,

    /// <summary>
    /// Rate Index Type does not match.
    /// Encoded/decoded by serializers as &quot;RITP&quot;.
    /// </summary>
    [EnumMember(Value = "RITP")]
    [IsoId("_ZlHcQNCqEeqVwOG0fcjVKA")]
    [Description(@"Rate Index Type does not match.")]
    RateIndexType,

    /// <summary>
    /// Spread does not match.
    /// Encoded/decoded by serializers as &quot;SPRD&quot;.
    /// </summary>
    [EnumMember(Value = "SPRD")]
    [IsoId("_iZ3PYNCqEeqVwOG0fcjVKA")]
    [Description(@"Spread does not match.")]
    Spread,

    /// <summary>
    /// Overnight Frequency Rate Fixing does not match.
    /// Encoded/decoded by serializers as &quot;OFRF&quot;.
    /// </summary>
    [EnumMember(Value = "OFRF")]
    [IsoId("_oD1IkNCqEeqVwOG0fcjVKA")]
    [Description(@"Overnight Frequency Rate Fixing does not match.")]
    OvernightFrequencyRateFixing,

    /// <summary>
    /// Option Type does not match.
    /// Encoded/decoded by serializers as &quot;OPTP&quot;.
    /// </summary>
    [EnumMember(Value = "OPTP")]
    [IsoId("_xHTUMNCqEeqVwOG0fcjVKA")]
    [Description(@"Option Type does not match.")]
    OptionType,

    /// <summary>
    /// Termination Option does not match.
    /// Encoded/decoded by serializers as &quot;TMOP&quot;.
    /// </summary>
    [EnumMember(Value = "TMOP")]
    [IsoId("_3oUKINCqEeqVwOG0fcjVKA")]
    [Description(@"Termination Option does not match.")]
    TerminationOption,

    /// <summary>
    /// Requested Execution Date Time does not match.
    /// Encoded/decoded by serializers as &quot;REDT&quot;.
    /// </summary>
    [EnumMember(Value = "REDT")]
    [IsoId("_KVCvANCrEeqVwOG0fcjVKA")]
    [Description(@"Requested Execution Date Time does not match.")]
    RequestedExecutionDateTime,

    /// <summary>
    /// Day Count Basis does  not match.
    /// Encoded/decoded by serializers as &quot;DCBS&quot;.
    /// </summary>
    [EnumMember(Value = "DCBS")]
    [IsoId("_fztQANCrEeqVwOG0fcjVKA")]
    [Description(@"Day Count Basis does  not match.")]
    DayCountBasis,

    /// <summary>
    /// Transfer Title Indicator does not match.
    /// Encoded/decoded by serializers as &quot;TFRT&quot;.
    /// </summary>
    [EnumMember(Value = "TFRT")]
    [IsoId("_Ajgv4P7UEeqzyss40vrJTg")]
    [Description(@"Transfer Title Indicator does not match.")]
    TransferTitle,

    /// <summary>
    /// Compound simple accrual calculation indicator doe not match.
    /// Encoded/decoded by serializers as &quot;CSAC&quot;.
    /// </summary>
    [EnumMember(Value = "CSAC")]
    [IsoId("_mxXLAP7UEeqzyss40vrJTg")]
    [Description(@"Compound simple accrual calculation indicator doe not match.")]
    CompoundSimpleAccrualCalculation,

    /// <summary>
    /// The computation method of (accrued) interest does not match.
    /// Encoded/decoded by serializers as &quot;PYFQ&quot;.
    /// </summary>
    [EnumMember(Value = "PYFQ")]
    [IsoId("_x_pBUP7UEeqzyss40vrJTg")]
    [Description(@"The computation method of (accrued) interest does not match.")]
    PaymentFrequency,

    /// <summary>
    /// Number of days after the accrual payment is due does not match.
    /// Encoded/decoded by serializers as &quot;INPD&quot;.
    /// </summary>
    [EnumMember(Value = "INPD")]
    [IsoId("_Q_2KAP7VEeqzyss40vrJTg")]
    [Description(@"Number of days after the accrual payment is due does not match.")]
    InterestPaymentDelay,

    /// <summary>
    /// Lookback days does not match.
    /// Encoded/decoded by serializers as &quot;LBKD&quot;.
    /// </summary>
    [EnumMember(Value = "LBKD")]
    [IsoId("_zg_p4P7VEeqzyss40vrJTg")]
    [Description(@"Lookback days does not match.")]
    LookbackDays,

    /// <summary>
    /// Crystallisation date does not match.
    /// Encoded/decoded by serializers as &quot;CRYD&quot;.
    /// </summary>
    [EnumMember(Value = "CRYD")]
    [IsoId("_KG7U8P7WEeqzyss40vrJTg")]
    [Description(@"Crystallisation date does not match.")]
    CrystallisationDate,

    /// <summary>
    /// Tenor of the interest rate index does not match.
    /// Encoded/decoded by serializers as &quot;TENO&quot;.
    /// </summary>
    [EnumMember(Value = "TENO")]
    [IsoId("_9OLEYP7WEeqzyss40vrJTg")]
    [Description(@"Tenor of the interest rate index does not match.")]
    Tenor,

    /// <summary>
    /// Settlement process in which the collateral will be settled does not match.
    /// Encoded/decoded by serializers as &quot;SEPR&quot;.
    /// </summary>
    [EnumMember(Value = "SEPR")]
    [IsoId("_V-ROsA7iEeujzI3ezCGI7A")]
    [Description(@"Settlement process in which the collateral will be settled does not match.")]
    SettlementProcess,
}
