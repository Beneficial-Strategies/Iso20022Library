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
[IsoId("_X58joGXhEeWsrOWU209RUg")]
[Description(
    @"Specifies the reason the transaction, transfer or settlement instruction is unmatched."
)]
[DerivedFrom(typeof(UnmatchedReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UnmatchedReason12Code>))]
#endif
public enum UnmatchedReason12Code
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_pXFv8WXhEeWsrOWU209RUg")]
    [Description(
        @"Received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = UnmatchedReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Accrued interest amount does not match.
    /// Encoded/decoded by serializers as &quot;ACRU&quot;.
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("_peYqwWXhEeWsrOWU209RUg")]
    [Description(@"Accrued interest amount does not match.")]
    AccruedInterestAmount1 = UnmatchedReasonCode.AccruedInterestAmount1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Common reference does not match.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_q3Wo0WXhEeWsrOWU209RUg")]
    [Description(@"Common reference does not match.")]
    CommonReference = UnmatchedReasonCode.CommonReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty cancelled their instruction.
    /// Encoded/decoded by serializers as &quot;CPCA&quot;.
    /// </summary>
    [EnumMember(Value = "CPCA")]
    [IsoId("_rmzv0WXhEeWsrOWU209RUg")]
    [Description(@"Counterparty cancelled their instruction.")]
    CounterpartyCancelled = UnmatchedReasonCode.CounterpartyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction was too late for matching.
    /// Encoded/decoded by serializers as &quot;CLAT&quot;.
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_0OUYMWXhEeWsrOWU209RUg")]
    [Description(@"Counterparty's instruction was too late for matching.")]
    CounterpartyTooLateForMatching = UnmatchedReasonCode.CounterpartyTooLateForMatching, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement amount currency does not match.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_0ZBzYWXhEeWsrOWU209RUg")]
    [Description(@"Settlement amount currency does not match.")]
    CurrencySettlementAmount = UnmatchedReasonCode.CurrencySettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal price does not match.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_0rBiUWXhEeWsrOWU209RUg")]
    [Description(@"Deal price does not match.")]
    DealPrice = UnmatchedReasonCode.DealPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_3NffEWXhEeWsrOWU209RUg")]
    [Description(
        @"Financial instrument identification does not match, for example, ISIN, financial instrument attributes differs."
    )]
    FinancialInstrument = UnmatchedReasonCode.FinancialInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_4MRbgWXhEeWsrOWU209RUg")]
    [Description(@"Quantity of financial instruments does not match.")]
    FinancialInstrumentQuantity = UnmatchedReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;LEOG&quot;.
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("_5E9XAWXhEeWsrOWU209RUg")]
    [Description(
        @"Counterparty is for settlement through letter of guarantee, your instruction is not, or vice versa."
    )]
    LetterOfGuarantee = UnmatchedReasonCode.LetterOfGuarantee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction was too late for matching.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_5Y4_oWXhEeWsrOWU209RUg")]
    [Description(@"Your instruction was too late for matching.")]
    MarketDeadlineMissed = UnmatchedReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Missing market execution details.
    /// Encoded/decoded by serializers as &quot;MIME&quot;.
    /// </summary>
    [EnumMember(Value = "MIME")]
    [IsoId("_-EhoUmXhEeWsrOWU209RUg")]
    [Description(@"Missing market execution details.")]
    MissingMarketSide = UnmatchedReasonCode.MissingMarketSide, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A matching instruction from your counterparty could not be found.
    /// Encoded/decoded by serializers as &quot;CMIS&quot;.
    /// </summary>
    [EnumMember(Value = "CMIS")]
    [IsoId("_-a_AgWXhEeWsrOWU209RUg")]
    [Description(@"A matching instruction from your counterparty could not be found.")]
    NoMatch = UnmatchedReasonCode.NoMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Matching process has not yet started.
    /// Encoded/decoded by serializers as &quot;NMAS&quot;.
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("_-oq3MWXhEeWsrOWU209RUg")]
    [Description(@"Matching process has not yet started.")]
    NoMatchingStarted = UnmatchedReasonCode.NoMatchingStarted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty has been contacted or contacted us, and does not recognise the transaction.
    /// Encoded/decoded by serializers as &quot;DTRA&quot;.
    /// </summary>
    [EnumMember(Value = "DTRA")]
    [IsoId("_-6rNMWXhEeWsrOWU209RUg")]
    [Description(
        @"Counterparty has been contacted or contacted us, and does not recognise the transaction."
    )]
    NotRecognised = UnmatchedReasonCode.NotRecognised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proprietary unmatched reason code described in a narrative field.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("__SB9QWXhEeWsrOWU209RUg")]
    [Description(@"Proprietary unmatched reason code described in a narrative field.")]
    Other = UnmatchedReasonCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment type does not match: your instruction is free of payment, your counterparty&apos;s instruction is against payment or vice versa.
    /// Encoded/decoded by serializers as &quot;FRAP&quot;.
    /// </summary>
    [EnumMember(Value = "FRAP")]
    [IsoId("__rnh8WXhEeWsrOWU209RUg")]
    [Description(
        @"Payment type does not match: your instruction is free of payment, your counterparty's instruction is against payment or vice versa."
    )]
    PaymentCode = UnmatchedReasonCode.PaymentCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty&apos;s instruction is physical settlement, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("__8ugEWXhEeWsrOWU209RUg")]
    [Description(
        @"Counterparty's instruction is physical settlement, your instruction is not, or vice versa."
    )]
    PhysicalSettlement = UnmatchedReasonCode.PhysicalSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of safekeeping information does not allow matching to take place.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_EPOQAWXiEeWsrOWU209RUg")]
    [Description(@"Place of safekeeping information does not allow matching to take place.")]
    PlaceOfSafekeeping = UnmatchedReasonCode.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of trade does not match.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_Eg7EAWXiEeWsrOWU209RUg")]
    [Description(@"Place of trade does not match.")]
    PlaceOfTrade = UnmatchedReasonCode.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has not been matched. It is a possible duplicate instruction.
    /// Encoded/decoded by serializers as &quot;PODU&quot;.
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("_FN2bcWXiEeWsrOWU209RUg")]
    [Description(@"Instruction has not been matched. It is a possible duplicate instruction.")]
    PossibleDuplicate = UnmatchedReasonCode.PossibleDuplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Depository does not match.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_Fb10IWXiEeWsrOWU209RUg")]
    [Description(@"Depository does not match.")]
    ReceivingDeliveringDepository = UnmatchedReasonCode.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant of delivering or receiving depository does not match.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_FpE-4WXiEeWsrOWU209RUg")]
    [Description(@"Participant of delivering or receiving depository does not match.")]
    ReceivingDeliveringParty1 = UnmatchedReasonCode.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Client of delivering or receiving party 1 does not match.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_FvLm4WXiEeWsrOWU209RUg")]
    [Description(@"Client of delivering or receiving party 1 does not match.")]
    ReceivingDeliveringParty2 = UnmatchedReasonCode.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Client of delivering or receiving party 2 does not match.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_F7rKwWXiEeWsrOWU209RUg")]
    [Description(@"Client of delivering or receiving party 2 does not match.")]
    ReceivingDeliveringParty3 = UnmatchedReasonCode.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Registration details linked to the transaction are incorrect.
    /// Encoded/decoded by serializers as &quot;REGD&quot;.
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_GXMpIWXiEeWsrOWU209RUg")]
    [Description(@"Registration details linked to the transaction are incorrect.")]
    RegistrationDetails = UnmatchedReasonCode.RegistrationDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa.
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_JE928WXiEeWsrOWU209RUg")]
    [Description(
        @"Counterparty is for Real Time Gross Settlement (RTGS) system, you are for non-RTGS or vice versa."
    )]
    RTGSSystem = UnmatchedReasonCode.RTGSSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller&apos;s account, direct client&apos;s account at the receiving/delivering agent, or receiving/delivering agent&apos;s account at the CSD.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_JVCTQWXiEeWsrOWU209RUg")]
    [Description(
        @"Safekeeping account used as matching criteria on the market concerned does not match. This includes Buyer/seller's account, direct client's account at the receiving/delivering agent, or receiving/delivering agent's account at the CSD."
    )]
    SafekeepingAccount = UnmatchedReasonCode.SafekeepingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement amount does not match.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_JptiwWXiEeWsrOWU209RUg")]
    [Description(@"Settlement amount does not match.")]
    SettlementAmount = UnmatchedReasonCode.SettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B).
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_ShusUWXiEeWsrOWU209RUg")]
    [Description(
        @"Settlement system/method does not match (for example, instruction is to settle using settlement system/method A. Counterparty expects settlement to occur using settlement system/method B)."
    )]
    SettlementSystemMethod = UnmatchedReasonCode.SettlementSystemMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.).
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_SrQbwWXiEeWsrOWU209RUg")]
    [Description(
        @"Settlement transaction type does not match (relates to the settlement transaction type codes available for field: 22F:: SETR.)."
    )]
    SettlementTransaction = UnmatchedReasonCode.SettlementTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disagreement on the tax status of the financial instruments to be settled.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_WNPUwmXiEeWsrOWU209RUg")]
    [Description(@"Disagreement on the tax status of the financial instruments to be settled.")]
    TaxStatus = UnmatchedReasonCode.TaxStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade date does not match.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_WUPUoWXiEeWsrOWU209RUg")]
    [Description(@"Trade date does not match.")]
    TradeDate = UnmatchedReasonCode.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa.
    /// Encoded/decoded by serializers as &quot;DELN&quot;.
    /// </summary>
    [EnumMember(Value = "DELN")]
    [IsoId("_WsyXgWXiEeWsrOWU209RUg")]
    [Description(
        @"Direction of the trade does not match. Counterparty expects a delivery from you, not a receipt or vice versa."
    )]
    TransactionDirection = UnmatchedReasonCode.TransactionDirection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Market side trade is unmatched.
    /// Encoded/decoded by serializers as &quot;UNBR&quot;.
    /// </summary>
    [EnumMember(Value = "UNBR")]
    [IsoId("_XGX8MWXiEeWsrOWU209RUg")]
    [Description(@"Market side trade is unmatched.")]
    UnmatchedMarketSide = UnmatchedReasonCode.UnmatchedMarketSide, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement date/time does not match.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_j9_H0WXiEeWsrOWU209RUg")]
    [Description(@"Settlement date/time does not match.")]
    SettlementDate = UnmatchedReasonCode.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disagreement on automatic generation of market claim or transformation.
    /// Encoded/decoded by serializers as &quot;DMCT&quot;.
    /// </summary>
    [EnumMember(Value = "DMCT")]
    [IsoId("_lIOGUWXiEeWsrOWU209RUg")]
    [Description(@"Disagreement on automatic generation of market claim or transformation.")]
    AutomaticGeneration = UnmatchedReasonCode.AutomaticGeneration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disagreement if trade was executed cum or ex.
    /// Encoded/decoded by serializers as &quot;DCMX&quot;.
    /// </summary>
    [EnumMember(Value = "DCMX")]
    [IsoId("_lOxaQWXiEeWsrOWU209RUg")]
    [Description(@"Disagreement if trade was executed cum or ex.")]
    CumEx = UnmatchedReasonCode.CumEx, // same ordinal as derivation source for type conversions
}
