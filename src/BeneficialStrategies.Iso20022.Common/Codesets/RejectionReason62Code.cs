// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the transaction or in the instruction has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RZnBUhIvEeyHZKWo4KVxBw")]
[Description(
    @"Specifies the reason why the transaction or in the instruction has a rejected status."
)]
[DerivedFrom(typeof(RejectionReasonV3Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectionReason62Code>))]
#endif
public enum RejectionReason62Code
{
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_XhXCkRIvEeyHZKWo4KVxBw")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    ReferenceRejection = RejectionReasonV3Code.ReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_XhXCkxIvEeyHZKWo4KVxBw")]
    [Description(
        @"Transaction/instruction received after the account servicer's specified deadline."
    )]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid client collateral instruction identification.
    /// Encoded/decoded by serializers as &quot;CCIX&quot;.
    /// </summary>
    [EnumMember(Value = "CCIX")]
    [IsoId("_XhXClRIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or invalid client collateral instruction identification.")]
    ClientCollateralInstructionIdentification =
        RejectionReasonV3Code.ClientCollateralInstructionIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid Client Collateral Transaction Identification.
    /// Encoded/decoded by serializers as &quot;CCTI&quot;.
    /// </summary>
    [EnumMember(Value = "CCTI")]
    [IsoId("_XhXClxIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or invalid Client Collateral Transaction Identification.")]
    ClientCollateralTransactionIdentification =
        RejectionReasonV3Code.ClientCollateralTransactionIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_XhXCmRIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection = RejectionReasonV3Code.CommonReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or Invalid Party A.
    /// Encoded/decoded by serializers as &quot;PTYA&quot;.
    /// </summary>
    [EnumMember(Value = "PTYA")]
    [IsoId("_XhXCmxIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or Invalid Party A.")]
    InvalidPartyA = RejectionReasonV3Code.InvalidPartyA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or Invalid Party B
    /// Encoded/decoded by serializers as &quot;PTYB&quot;.
    /// </summary>
    [EnumMember(Value = "PTYB")]
    [IsoId("_XhXCnRIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or Invalid Party B")]
    InvalidPartyB = RejectionReasonV3Code.InvalidPartyB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or Invalid Triparty Agent
    /// Encoded/decoded by serializers as &quot;ITPA&quot;.
    /// </summary>
    [EnumMember(Value = "ITPA")]
    [IsoId("_XhXCnxIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or Invalid Triparty Agent")]
    InvalidTripartyAgent = RejectionReasonV3Code.InvalidTripartyAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_XhXCoRIvEeyHZKWo4KVxBw")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid Party A Safekeeping Account
    /// Encoded/decoded by serializers as &quot;SAFA&quot;.
    /// </summary>
    [EnumMember(Value = "SAFA")]
    [IsoId("_XhXCoxIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or invalid Party A Safekeeping Account")]
    PartyASafekeepingAccount = RejectionReasonV3Code.PartyASafekeepingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or Invalid Party B Safekeeping Account.
    /// Encoded/decoded by serializers as &quot;SAFB&quot;.
    /// </summary>
    [EnumMember(Value = "SAFB")]
    [IsoId("_XhXCpRIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or Invalid Party B Safekeeping Account.")]
    PartyBSafekeepingAccount = RejectionReasonV3Code.PartyBSafekeepingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid execution date/time
    /// Encoded/decoded by serializers as &quot;REDT&quot;.
    /// </summary>
    [EnumMember(Value = "REDT")]
    [IsoId("_XhXCpxIvEeyHZKWo4KVxBw")]
    [Description(@"Invalid execution date/time")]
    RequestedExecutionDateTime = RejectionReasonV3Code.RequestedExecutionDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement process instructed.
    /// Encoded/decoded by serializers as &quot;SEPR&quot;.
    /// </summary>
    [EnumMember(Value = "SEPR")]
    [IsoId("_XhXCqRIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or invalid settlement process instructed.|")]
    SettlementProcessRejection = RejectionReasonV3Code.SettlementProcessRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number of lookback days not supported.
    /// Encoded/decoded by serializers as &quot;LBDR&quot;.
    /// </summary>
    [EnumMember(Value = "LBDR")]
    [IsoId("_XhXCqxIvEeyHZKWo4KVxBw")]
    [Description(@"Number of lookback days not supported.|")]
    LookbackDaysRejection = RejectionReasonV3Code.LookbackDaysRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Day count basis not supported.
    /// Encoded/decoded by serializers as &quot;DCBR&quot;.
    /// </summary>
    [EnumMember(Value = "DCBR")]
    [IsoId("_XhXCrRIvEeyHZKWo4KVxBw")]
    [Description(@"Day count basis not supported.|")]
    DayCountBasis = RejectionReasonV3Code.DayCountBasis, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Compound simple accrual calculation is not supported.
    /// Encoded/decoded by serializers as &quot;CSAC&quot;.
    /// </summary>
    [EnumMember(Value = "CSAC")]
    [IsoId("_XhXCrxIvEeyHZKWo4KVxBw")]
    [Description(@"Compound simple accrual calculation is not supported.||")]
    CompoundSimpleAccrualCalculationRejection =
        RejectionReasonV3Code.CompoundSimpleAccrualCalculationRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_XhXCsRIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTimeRejection = RejectionReasonV3Code.ClosingDateTimeRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_XhXCsxIvEeyHZKWo4KVxBw")]
    [Description(
        @"Unrecognised or invalid trade date or requested trade date or future trade date."
    )]
    TradeDate = RejectionReasonV3Code.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_XhXCtRIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection = RejectionReasonV3Code.SettlementDateRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_XhXCtxIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection = RejectionReasonV3Code.SettlementAmountCurrencyRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This is an unrecognised or invalid Eligibility Set Profile.
    /// Encoded/decoded by serializers as &quot;IESP&quot;.
    /// </summary>
    [EnumMember(Value = "IESP")]
    [IsoId("_XhXCuRIvEeyHZKWo4KVxBw")]
    [Description(@"This is an unrecognised or invalid Eligibility Set Profile.")]
    InvalidEligibilitySetProfile = RejectionReasonV3Code.InvalidEligibilitySetProfile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This is an unrecognised or invalid Exposure Type (used when a proprietary code is sent).
    /// Encoded/decoded by serializers as &quot;IEXT&quot;.
    /// </summary>
    [EnumMember(Value = "IEXT")]
    [IsoId("_XhXCuxIvEeyHZKWo4KVxBw")]
    [Description(
        @"This is an unrecognised or invalid Exposure Type (used when a proprietary code is sent)."
    )]
    InvalidExposureType = RejectionReasonV3Code.InvalidExposureType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid Preferential Basket identification.
    /// Encoded/decoded by serializers as &quot;IPBI&quot;.
    /// </summary>
    [EnumMember(Value = "IPBI")]
    [IsoId("_XhXCvRIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or invalid Preferential Basket identification.")]
    InvalidPreferentialBasketIdentification =
        RejectionReasonV3Code.InvalidPreferentialBasketIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid Rate Index Type (used when a proprietary code is sent).
    /// Encoded/decoded by serializers as &quot;IRIT&quot;.
    /// </summary>
    [EnumMember(Value = "IRIT")]
    [IsoId("_XhXCvxIvEeyHZKWo4KVxBw")]
    [Description(
        @"Unrecognised or invalid Rate Index Type (used when a proprietary code is sent)."
    )]
    InvalidRateIndexType = RejectionReasonV3Code.InvalidRateIndexType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Termination amount currency not supported.
    /// Encoded/decoded by serializers as &quot;TMAC&quot;.
    /// </summary>
    [EnumMember(Value = "TMAC")]
    [IsoId("_XhXCwRIvEeyHZKWo4KVxBw")]
    [Description(@"Termination amount currency not supported.")]
    TerminationAmountCurrency = RejectionReasonV3Code.TerminationAmountCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_XhXCwxIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount = RejectionReasonV3Code.TerminationTransactionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction amount currency not supported.
    /// Encoded/decoded by serializers as &quot;TXAC&quot;.
    /// </summary>
    [EnumMember(Value = "TXAC")]
    [IsoId("_XhXCxRIvEeyHZKWo4KVxBw")]
    [Description(@"Transaction amount currency not supported.")]
    TransactionAmountCurrency = RejectionReasonV3Code.TransactionAmountCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// More than one instruction match the criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_XhXCxxIvEeyHZKWo4KVxBw")]
    [Description(@"More than one instruction match the criteria.")]
    NoMatch = RejectionReasonV3Code.NoMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction amount breakdown currency differs from transaction amount currency.
    /// Encoded/decoded by serializers as &quot;TABC&quot;.
    /// </summary>
    [EnumMember(Value = "TABC")]
    [IsoId("_XhXCyRIvEeyHZKWo4KVxBw")]
    [Description(
        @"Transaction amount breakdown currency differs from transaction amount currency."
    )]
    TransactionAmountBreakdownCurrency = RejectionReasonV3Code.TransactionAmountBreakdownCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This is an unrecognised or invalid Collateral Transaction Type.
    /// Encoded/decoded by serializers as &quot;ICTT&quot;.
    /// </summary>
    [EnumMember(Value = "ICTT")]
    [IsoId("_XhXCyxIvEeyHZKWo4KVxBw")]
    [Description(@"This is an unrecognised or invalid Collateral Transaction Type.")]
    InvalidCollateralTransactionType = RejectionReasonV3Code.InvalidCollateralTransactionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation, modification or termination request has been rejected since the instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRJN&quot;.
    /// </summary>
    [EnumMember(Value = "NRJN")]
    [IsoId("_XhXCzRIvEeyHZKWo4KVxBw")]
    [Description(
        @"Cancellation, modification or termination request has been rejected since the instruction could not be found."
    )]
    NotFoundRejectionForCancellationModificationOrTermination =
        RejectionReasonV3Code.NotFoundRejectionForCancellationModificationOrTermination, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been rejected as the corresponding allegement was cancelled.
    /// Encoded/decoded by serializers as &quot;NFCA&quot;.
    /// </summary>
    [EnumMember(Value = "NFCA")]
    [IsoId("_XhXCzxIvEeyHZKWo4KVxBw")]
    [Description(@"Instruction has been rejected as the corresponding allegement was cancelled.")]
    NotFoundCorrespondingAllegement = RejectionReasonV3Code.NotFoundCorrespondingAllegement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid closing closing amount.
    /// Encoded/decoded by serializers as &quot;CTRA&quot;.
    /// </summary>
    [EnumMember(Value = "CTRA")]
    [IsoId("_XhXC0RIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or invalid closing closing amount.")]
    ClosingTransactionAmount = RejectionReasonV3Code.ClosingTransactionAmount, // same ordinal as derivation source for type conversions
}
