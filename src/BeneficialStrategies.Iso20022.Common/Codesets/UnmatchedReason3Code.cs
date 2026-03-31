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
[IsoId("_Y6AElNp-Ed-ak6NoX_4Aeg_-290759549")]
[Description(
    @"Specifies the reason the transaction, transfer or settlement instruction is unmatched."
)]
[DerivedFrom(typeof(UnmatchedReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UnmatchedReason3Code>))]
#endif
public enum UnmatchedReason3Code
{
    /// <summary>
    /// A matching instruction from your counterparty could not be found.
    /// Encoded/decoded by serializers as &quot;CMIS&quot;.
    /// </summary>
    [EnumMember(Value = "CMIS")]
    [IsoId("_Y6AEldp-Ed-ak6NoX_4Aeg_1354507886")]
    [Description(@"A matching instruction from your counterparty could not be found.")]
    NoMatch = UnmatchedReasonCode.NoMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement date/time does not match.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_Y6AEltp-Ed-ak6NoX_4Aeg_-1287831902")]
    [Description(@"Settlement date/time does not match.")]
    SettlementDate = UnmatchedReasonCode.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa.
    /// Encoded/decoded by serializers as &quot;DELN&quot;.
    /// </summary>
    [EnumMember(Value = "DELN")]
    [IsoId("_Y6AEl9p-Ed-ak6NoX_4Aeg_-1579789640")]
    [Description(
        @"Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa."
    )]
    TransactionDirection = UnmatchedReasonCode.TransactionDirection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal amount does not match.
    /// Encoded/decoded by serializers as &quot;DEAL&quot;.
    /// </summary>
    [EnumMember(Value = "DEAL")]
    [IsoId("_Y6AEmNp-Ed-ak6NoX_4Aeg_-1401670968")]
    [Description(@"Deal amount does not match.")]
    TransactionDealAmount = UnmatchedReasonCode.TransactionDealAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Depository does not match.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_Y6AEmdp-Ed-ak6NoX_4Aeg_357435533")]
    [Description(@"Depository does not match.")]
    ReceivingDeliveringDepository = UnmatchedReasonCode.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement amount does not match.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_Y6J1kNp-Ed-ak6NoX_4Aeg_2010063041")]
    [Description(@"Settlement amount does not match.")]
    SettlementAmount = UnmatchedReasonCode.SettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal price does not match.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_Y6J1kdp-Ed-ak6NoX_4Aeg_1718105303")]
    [Description(@"Deal price does not match.")]
    DealPrice = UnmatchedReasonCode.DealPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Y6J1ktp-Ed-ak6NoX_4Aeg_1896223975")]
    [Description(@"Quantity of financial instruments does not match.")]
    FinancialInstrumentQuantity = UnmatchedReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction call delay does not match.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_Y6J1k9p-Ed-ak6NoX_4Aeg_-639636820")]
    [Description(@"Transaction call delay does not match.")]
    RepurchaseCallDelay = UnmatchedReasonCode.RepurchaseCallDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Y6J1lNp-Ed-ak6NoX_4Aeg_1012990688")]
    [Description(
        @"Received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = UnmatchedReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.).
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_Y6J1ldp-Ed-ak6NoX_4Aeg_721032950")]
    [Description(
        @"Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.)."
    )]
    SettlementTransaction = UnmatchedReasonCode.SettlementTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B).
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_Y6J1ltp-Ed-ak6NoX_4Aeg_899151622")]
    [Description(
        @"Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B)."
    )]
    SettlementSystemMethod = UnmatchedReasonCode.SettlementSystemMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_Y6J1l9p-Ed-ak6NoX_4Aeg_-1636709173")]
    [Description(
        @"Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs."
    )]
    FinancialInstrument = UnmatchedReasonCode.FinancialInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Variable rate support does not match (repo).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_Y6J1mNp-Ed-ak6NoX_4Aeg_15918335")]
    [Description(@"Variable rate support does not match (repo).")]
    VariableRateSupport = UnmatchedReasonCode.VariableRateSupport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty has been contacted or contacted us, and does not recognise the transaction.
    /// Encoded/decoded by serializers as &quot;DTRA&quot;.
    /// </summary>
    [EnumMember(Value = "DTRA")]
    [IsoId("_Y6J1mdp-Ed-ak6NoX_4Aeg_-276039403")]
    [Description(
        @"Counterparty has been contacted or contacted us, and does not recognise the transaction."
    )]
    NotRecognised = UnmatchedReasonCode.NotRecognised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Spread rate does not match.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_Y6J1mtp-Ed-ak6NoX_4Aeg_-97920731")]
    [Description(@"Spread rate does not match.")]
    RepurchaseSpreadRate = UnmatchedReasonCode.RepurchaseSpreadRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repurchase rate does not match.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_Y6TmkNp-Ed-ak6NoX_4Aeg_1661185770")]
    [Description(@"Repurchase rate does not match.")]
    RepurchaseRate = UnmatchedReasonCode.RepurchaseRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction was too late for matching.
    /// Encoded/decoded by serializers as &quot;CLAT&quot;.
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_Y6Tmkdp-Ed-ak6NoX_4Aeg_-981154018")]
    [Description(@"Counterparty's instruction was too late for matching.")]
    CounterpartyTooLateForMatching = UnmatchedReasonCode.CounterpartyTooLateForMatching, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repurchase rate type does not match.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_Y6Tmktp-Ed-ak6NoX_4Aeg_-1273111756")]
    [Description(@"Repurchase rate type does not match.")]
    RepurchaseRateType = UnmatchedReasonCode.RepurchaseRateType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Termination transaction amount does not match.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_Y6Tmk9p-Ed-ak6NoX_4Aeg_-1094993084")]
    [Description(@"Termination transaction amount does not match.")]
    RepurchaseAmount = UnmatchedReasonCode.RepurchaseAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Premium amount does not match.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_Y6TmlNp-Ed-ak6NoX_4Aeg_664113417")]
    [Description(@"Premium amount does not match.")]
    RepurchasePremiumAmount = UnmatchedReasonCode.RepurchasePremiumAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction is physical settlement, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_Y6Tmldp-Ed-ak6NoX_4Aeg_-1978226371")]
    [Description(
        @"Counterparty's instruction is physical settlement, your instruction is not, or vice versa."
    )]
    PhysicalSettlement = UnmatchedReasonCode.PhysicalSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Common reference does not match.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_Y6Tmltp-Ed-ak6NoX_4Aeg_2024783187")]
    [Description(@"Common reference does not match.")]
    CommonReference = UnmatchedReasonCode.CommonReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment type does not match: your instruction is free of payment, your counterparty&apos;s instruction is against payment or vice versa.
    /// Encoded/decoded by serializers as &quot;FRAP&quot;.
    /// </summary>
    [EnumMember(Value = "FRAP")]
    [IsoId("_Y6Tml9p-Ed-ak6NoX_4Aeg_-2092065437")]
    [Description(
        @"Payment type does not match: your instruction is free of payment, your counterparty's instruction is against payment or vice versa."
    )]
    PaymentCode = UnmatchedReasonCode.PaymentCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of trade does not match.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_Y6TmmNp-Ed-ak6NoX_4Aeg_-332958936")]
    [Description(@"Place of trade does not match.")]
    PlaceOfTrade = UnmatchedReasonCode.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has not been matched. It is a possible duplicate instruction.
    /// Encoded/decoded by serializers as &quot;PODU&quot;.
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("_Y6cwgNp-Ed-ak6NoX_4Aeg_1319668572")]
    [Description(@"Instruction has not been matched. It is a possible duplicate instruction.")]
    PossibleDuplicate = UnmatchedReasonCode.PossibleDuplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Forfeit amount does not match.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_Y6cwgdp-Ed-ak6NoX_4Aeg_1027710834")]
    [Description(@"Forfeit amount does not match.")]
    ForfeitRepurchaseAmount = UnmatchedReasonCode.ForfeitRepurchaseAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Executing broker&apos;s commission does not match.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_Y6cwgtp-Ed-ak6NoX_4Aeg_1205829506")]
    [Description(@"Executing broker's commission does not match.")]
    ExecutionBrokerCommission = UnmatchedReasonCode.ExecutionBrokerCommission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Registration details linked to the transaction are incorrect.
    /// Encoded/decoded by serializers as &quot;REGD&quot;.
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_Y6cwg9p-Ed-ak6NoX_4Aeg_-1330031289")]
    [Description(@"Registration details linked to the transaction are incorrect.")]
    RegistrationDetails = UnmatchedReasonCode.RegistrationDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa.
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_Y6cwhNp-Ed-ak6NoX_4Aeg_322596219")]
    [Description(
        @"Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa."
    )]
    RTGSSystem = UnmatchedReasonCode.RTGSSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant of delivering or receiving depository does not match.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_Y6cwhdp-Ed-ak6NoX_4Aeg_30638481")]
    [Description(@"Participant of delivering or receiving depository does not match.")]
    ReceivingDeliveringParty1 = UnmatchedReasonCode.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty cancelled their instruction.
    /// Encoded/decoded by serializers as &quot;CPCA&quot;.
    /// </summary>
    [EnumMember(Value = "CPCA")]
    [IsoId("_Y6cwhtp-Ed-ak6NoX_4Aeg_208757153")]
    [Description(@"Counterparty cancelled their instruction.")]
    CounterpartyCancelled = UnmatchedReasonCode.CounterpartyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges amount does not match.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_Y6cwh9p-Ed-ak6NoX_4Aeg_1967863654")]
    [Description(@"Charges amount does not match.")]
    ChargesAmount = UnmatchedReasonCode.ChargesAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Client of delivering or receiving party 2 does not match.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_Y6mhgNp-Ed-ak6NoX_4Aeg_-674476134")]
    [Description(@"Client of delivering or receiving party 2 does not match.")]
    ReceivingDeliveringParty3 = UnmatchedReasonCode.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement amount currency does not match.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_Y6mhgdp-Ed-ak6NoX_4Aeg_-966433872")]
    [Description(@"Settlement amount currency does not match.")]
    CurrencySettlementAmount = UnmatchedReasonCode.CurrencySettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corresponding matching record has been cancelled.
    /// Encoded/decoded by serializers as &quot;MCAN&quot;.
    /// </summary>
    [EnumMember(Value = "MCAN")]
    [IsoId("_Y6mhgtp-Ed-ak6NoX_4Aeg_-788315200")]
    [Description(@"Corresponding matching record has been cancelled.")]
    MatchingRecordCancelled = UnmatchedReasonCode.MatchingRecordCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;LEOG&quot;.
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("_Y6mhg9p-Ed-ak6NoX_4Aeg_970791301")]
    [Description(
        @"Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa."
    )]
    LetterOfGuarantee = UnmatchedReasonCode.LetterOfGuarantee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Matching process has not yet started.
    /// Encoded/decoded by serializers as &quot;NMAS&quot;.
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("_Y6mhhNp-Ed-ak6NoX_4Aeg_-1671548487")]
    [Description(@"Matching process has not yet started.")]
    NoMatchingStarted = UnmatchedReasonCode.NoMatchingStarted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller&apos;s account, direct client&apos;s account at the receiving/delivering agent, or receiving/delivering agent&apos;s account at the CSD.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_Y6mhhdp-Ed-ak6NoX_4Aeg_-1963506225")]
    [Description(
        @"Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller's account, direct client's account at the receiving/delivering agent, or receiving/delivering agent's account at the CSD."
    )]
    SafekeepingAccount = UnmatchedReasonCode.SafekeepingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade date does not match.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_Y6mhhtp-Ed-ak6NoX_4Aeg_-1785387553")]
    [Description(@"Trade date does not match.")]
    TradeDate = UnmatchedReasonCode.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction was too late for matching.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_Y6mhh9p-Ed-ak6NoX_4Aeg_-26281052")]
    [Description(@"Your instruction was too late for matching.")]
    MarketDeadlineMissed = UnmatchedReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Closing date/time does not match.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_Y6mhiNp-Ed-ak6NoX_4Aeg_1626346456")]
    [Description(@"Closing date/time does not match.")]
    ClosingDateTime = UnmatchedReasonCode.ClosingDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disagreement on the tax status of the financial instruments to be settled.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_Y6mhidp-Ed-ak6NoX_4Aeg_1334388718")]
    [Description(@"Disagreement on the tax status of the financial instruments to be settled.")]
    TaxStatus = UnmatchedReasonCode.TaxStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Client of delivering or receiving party 1 does not match.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_Y6vrcNp-Ed-ak6NoX_4Aeg_1512507390")]
    [Description(@"Client of delivering or receiving party 1 does not match.")]
    ReceivingDeliveringParty2 = UnmatchedReasonCode.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of safekeeping information does not allow matching to take place.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_Y6vrcdp-Ed-ak6NoX_4Aeg_-133455808")]
    [Description(@"Place of safekeeping information does not allow matching to take place.")]
    PlaceOfSafekeeping = UnmatchedReasonCode.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Missing market execution details.
    /// Encoded/decoded by serializers as &quot;MIME&quot;.
    /// </summary>
    [EnumMember(Value = "MIME")]
    [IsoId("_Y6vrctp-Ed-ak6NoX_4Aeg_1250605123")]
    [Description(@"Missing market execution details.")]
    MissingMarketSide = UnmatchedReasonCode.MissingMarketSide, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Market side trade is unmatched.
    /// Encoded/decoded by serializers as &quot;UNBR&quot;.
    /// </summary>
    [EnumMember(Value = "UNBR")]
    [IsoId("_Y6vrc9p-Ed-ak6NoX_4Aeg_621588556")]
    [Description(@"Market side trade is unmatched.")]
    UnmatchedMarketSide = UnmatchedReasonCode.UnmatchedMarketSide, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proprietary unmatched reason code described in a narrative field.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Y6vrdNp-Ed-ak6NoX_4Aeg_2050997088")]
    [Description(@"Proprietary unmatched reason code described in a narrative field.")]
    Other = UnmatchedReasonCode.Other, // same ordinal as derivation source for type conversions
}
