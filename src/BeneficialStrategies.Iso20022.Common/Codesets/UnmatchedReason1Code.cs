// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is unmatched.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y4zxx9p-Ed-ak6NoX_4Aeg_1720522876")]
[Description(@"Specifies the reason the transaction/instruction is unmatched.")]
[DerivedFrom(typeof(UnmatchedReasonCode))]
public enum UnmatchedReason1Code
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Y4zxyNp-Ed-ak6NoX_4Aeg_-929176985")]
    [Description(
        @"Received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = UnmatchedReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction call delay does not match.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_Y49iwNp-Ed-ak6NoX_4Aeg_723450523")]
    [Description(@"Transaction call delay does not match.")]
    RepurchaseCallDelay = UnmatchedReasonCode.RepurchaseCallDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction was too late for matching.
    /// Encoded/decoded by serializers as &quot;CLAT&quot;.
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_Y49iwdp-Ed-ak6NoX_4Aeg_431492785")]
    [Description(@"Counterparty's instruction was too late for matching.")]
    CounterpartyTooLateForMatching = UnmatchedReasonCode.CounterpartyTooLateForMatching, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A matching instruction from your counterparty could not be found.
    /// Encoded/decoded by serializers as &quot;CMIS&quot;.
    /// </summary>
    [EnumMember(Value = "CMIS")]
    [IsoId("_Y49iwtp-Ed-ak6NoX_4Aeg_609611457")]
    [Description(@"A matching instruction from your counterparty could not be found.")]
    NoMatch = UnmatchedReasonCode.NoMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty cancelled their instruction.
    /// Encoded/decoded by serializers as &quot;CPCA&quot;.
    /// </summary>
    [EnumMember(Value = "CPCA")]
    [IsoId("_Y49iw9p-Ed-ak6NoX_4Aeg_-1926249338")]
    [Description(@"Counterparty cancelled their instruction.")]
    CounterpartyCancelled = UnmatchedReasonCode.CounterpartyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement date/time does not match.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_Y49ixNp-Ed-ak6NoX_4Aeg_-273621830")]
    [Description(@"Settlement date/time does not match.")]
    SettlementDate = UnmatchedReasonCode.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal price does not match.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_Y49ixdp-Ed-ak6NoX_4Aeg_-565579568")]
    [Description(@"Deal price does not match.")]
    DealPrice = UnmatchedReasonCode.DealPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa.
    /// Encoded/decoded by serializers as &quot;DELN&quot;.
    /// </summary>
    [EnumMember(Value = "DELN")]
    [IsoId("_Y49ixtp-Ed-ak6NoX_4Aeg_-387460896")]
    [Description(
        @"Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa."
    )]
    TransactionDirection = UnmatchedReasonCode.TransactionDirection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Depository does not match.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_Y49ix9p-Ed-ak6NoX_4Aeg_1371645605")]
    [Description(@"Depository does not match.")]
    ReceivingDeliveringDepository = UnmatchedReasonCode.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement amount does not match.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_Y49iyNp-Ed-ak6NoX_4Aeg_-1270694183")]
    [Description(@"Settlement amount does not match.")]
    SettlementAmount = UnmatchedReasonCode.SettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Y49iydp-Ed-ak6NoX_4Aeg_-1562651921")]
    [Description(@"Quantity of financial instruments does not match.")]
    FinancialInstrumentQuantity = UnmatchedReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_Y49iytp-Ed-ak6NoX_4Aeg_-1384533249")]
    [Description(
        @"Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs."
    )]
    FinancialInstrument = UnmatchedReasonCode.FinancialInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty has been contacted or contacted us, and does not recognise the transaction.
    /// Encoded/decoded by serializers as &quot;DTRA&quot;.
    /// </summary>
    [EnumMember(Value = "DTRA")]
    [IsoId("_Y5HTwNp-Ed-ak6NoX_4Aeg_374573252")]
    [Description(
        @"Counterparty has been contacted or contacted us, and does not recognise the transaction."
    )]
    NotRecognised = UnmatchedReasonCode.NotRecognised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade date does not match.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_Y5HTwdp-Ed-ak6NoX_4Aeg_2027200760")]
    [Description(@"Trade date does not match.")]
    TradeDate = UnmatchedReasonCode.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Forfeit amount does not match.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_Y5HTwtp-Ed-ak6NoX_4Aeg_1735243022")]
    [Description(@"Forfeit amount does not match.")]
    ForfeitRepurchaseAmount = UnmatchedReasonCode.ForfeitRepurchaseAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment type does not match: your instruction is free of payment, your counterparty&apos;s instruction is against payment or vice versa.
    /// Encoded/decoded by serializers as &quot;FRAP&quot;.
    /// </summary>
    [EnumMember(Value = "FRAP")]
    [IsoId("_Y5HTw9p-Ed-ak6NoX_4Aeg_1913361694")]
    [Description(
        @"Payment type does not match: your instruction is free of payment, your counterparty's instruction is against payment or vice versa."
    )]
    PaymentCode = UnmatchedReasonCode.PaymentCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant of delivering or receiving depository does not match.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_Y5HTxNp-Ed-ak6NoX_4Aeg_-622499101")]
    [Description(@"Participant of delivering or receiving depository does not match.")]
    ReceivingDeliveringParty1 = UnmatchedReasonCode.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Client of delivering or receiving party 1 does not match.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_Y5HTxdp-Ed-ak6NoX_4Aeg_1030128407")]
    [Description(@"Client of delivering or receiving party 1 does not match.")]
    ReceivingDeliveringParty2 = UnmatchedReasonCode.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Client of delivering or receiving party 2 does not match.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_Y5HTxtp-Ed-ak6NoX_4Aeg_738170669")]
    [Description(@"Client of delivering or receiving party 2 does not match.")]
    ReceivingDeliveringParty3 = UnmatchedReasonCode.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Common reference does not match.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_Y5HTx9p-Ed-ak6NoX_4Aeg_916289341")]
    [Description(@"Common reference does not match.")]
    CommonReference = UnmatchedReasonCode.CommonReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction was too late for matching.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_Y5HTyNp-Ed-ak6NoX_4Aeg_-1619571454")]
    [Description(@"Your instruction was too late for matching.")]
    MarketDeadlineMissed = UnmatchedReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;LEOG&quot;.
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("_Y5HTydp-Ed-ak6NoX_4Aeg_33056054")]
    [Description(
        @"Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa."
    )]
    LetterOfGuarantee = UnmatchedReasonCode.LetterOfGuarantee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement amount currency does not match.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_Y5QdsNp-Ed-ak6NoX_4Aeg_-258901684")]
    [Description(@"Settlement amount currency does not match.")]
    CurrencySettlementAmount = UnmatchedReasonCode.CurrencySettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Matching process has not yet started.
    /// Encoded/decoded by serializers as &quot;NMAS&quot;.
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("_Y5Qdsdp-Ed-ak6NoX_4Aeg_-80783012")]
    [Description(@"Matching process has not yet started.")]
    NoMatchingStarted = UnmatchedReasonCode.NoMatchingStarted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction is physical settlement, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_Y5Qdstp-Ed-ak6NoX_4Aeg_1678323489")]
    [Description(
        @"Counterparty's instruction is physical settlement, your instruction is not, or vice versa."
    )]
    PhysicalSettlement = UnmatchedReasonCode.PhysicalSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of trade does not match.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_Y5Qds9p-Ed-ak6NoX_4Aeg_-964016299")]
    [Description(@"Place of trade does not match.")]
    PlaceOfTrade = UnmatchedReasonCode.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has not been matched. It is a possible duplicate instruction.
    /// Encoded/decoded by serializers as &quot;PODU&quot;.
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("_Y5QdtNp-Ed-ak6NoX_4Aeg_-1255974037")]
    [Description(@"Instruction has not been matched. It is a possible duplicate instruction.")]
    PossibleDuplicate = UnmatchedReasonCode.PossibleDuplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Registration details linked to the transaction are incorrect.
    /// Encoded/decoded by serializers as &quot;REGD&quot;.
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_Y5Qdtdp-Ed-ak6NoX_4Aeg_-1077855365")]
    [Description(@"Registration details linked to the transaction are incorrect.")]
    RegistrationDetails = UnmatchedReasonCode.RegistrationDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Termination transaction amount does not match.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_Y5Qdttp-Ed-ak6NoX_4Aeg_681251136")]
    [Description(@"Termination transaction amount does not match.")]
    RepurchaseAmount = UnmatchedReasonCode.RepurchaseAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repurchase rate does not match.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_Y5Qdt9p-Ed-ak6NoX_4Aeg_-1961088652")]
    [Description(@"Repurchase rate does not match.")]
    RepurchaseRate = UnmatchedReasonCode.RepurchaseRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Premium amount does not match.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_Y5QduNp-Ed-ak6NoX_4Aeg_2041920906")]
    [Description(@"Premium amount does not match.")]
    RepurchasePremiumAmount = UnmatchedReasonCode.RepurchasePremiumAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repurchase rate type does not match.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_Y5Qdudp-Ed-ak6NoX_4Aeg_-2074927718")]
    [Description(@"Repurchase rate type does not match.")]
    RepurchaseRateType = UnmatchedReasonCode.RepurchaseRateType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa.
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_Y5aOsNp-Ed-ak6NoX_4Aeg_1336806291")]
    [Description(
        @"Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa."
    )]
    RTGSSystem = UnmatchedReasonCode.RTGSSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller&apos;s account, direct client&apos;s account at the receiving/delivering agent, or receiving/delivering agent&apos;s account at the CSD.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_Y5aOsdp-Ed-ak6NoX_4Aeg_1044848553")]
    [Description(
        @"Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller's account, direct client's account at the receiving/delivering agent, or receiving/delivering agent's account at the CSD."
    )]
    SafekeepingAccount = UnmatchedReasonCode.SafekeepingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.).
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_Y5aOstp-Ed-ak6NoX_4Aeg_1222967225")]
    [Description(
        @"Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.)."
    )]
    SettlementTransaction = UnmatchedReasonCode.SettlementTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B).
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_Y5aOs9p-Ed-ak6NoX_4Aeg_-1312893570")]
    [Description(
        @"Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B)."
    )]
    SettlementSystemMethod = UnmatchedReasonCode.SettlementSystemMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Closing date/time does not match.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_Y5aOtNp-Ed-ak6NoX_4Aeg_339733938")]
    [Description(@"Closing date/time does not match.")]
    ClosingDateTime = UnmatchedReasonCode.ClosingDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disagreement on the tax status of the financial instruments to be settled.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_Y5aOtdp-Ed-ak6NoX_4Aeg_47776200")]
    [Description(@"Disagreement on the tax status of the financial instruments to be settled.")]
    TaxStatus = UnmatchedReasonCode.TaxStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Variable rate support does not match (repo).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_Y5aOttp-Ed-ak6NoX_4Aeg_225894872")]
    [Description(@"Variable rate support does not match (repo).")]
    VariableRateSupport = UnmatchedReasonCode.VariableRateSupport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of safekeeping information does not allow matching to take place.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_Y5aOt9p-Ed-ak6NoX_4Aeg_-385358170")]
    [Description(@"Place of safekeeping information does not allow matching to take place.")]
    PlaceOfSafekeeping = UnmatchedReasonCode.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proprietary unmatched reason code described in a narrative field.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Y5aOuNp-Ed-ak6NoX_4Aeg_-1215912086")]
    [Description(@"Proprietary unmatched reason code described in a narrative field.")]
    Other = UnmatchedReasonCode.Other, // same ordinal as derivation source for type conversions
}
