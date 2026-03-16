// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has an unmatched status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JsEuIOCaEei2UYJ62ws-Fw")]
[Description(@"Specifies the reason why the instruction has an unmatched status.")]
[DerivedFrom(typeof(UnmatchedReasonCode))]
public enum UnmatchedReason15Code
{
    /// <summary>
    /// Counterparty cancelled their instruction.
    /// Encoded/decoded by serializers as &quot;CPCA&quot;.
    /// </summary>
    [EnumMember(Value = "CPCA")]
    [IsoId("_M2HBMeCaEei2UYJ62ws-Fw")]
    [Description(@"Counterparty cancelled their instruction.")]
    CounterpartyCancelled = UnmatchedReasonCode.CounterpartyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Day Count Basis does  not match.
    /// Encoded/decoded by serializers as &quot;DCBS&quot;.
    /// </summary>
    [EnumMember(Value = "DCBS")]
    [IsoId("_pXnPMdCrEeqVwOG0fcjVKA")]
    [Description(@"Day Count Basis does  not match.")]
    DayCountBasis = UnmatchedReasonCode.DayCountBasis, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Termination Option does not match.
    /// Encoded/decoded by serializers as &quot;TMOP&quot;.
    /// </summary>
    [EnumMember(Value = "TMOP")]
    [IsoId("_ppwvIdCrEeqVwOG0fcjVKA")]
    [Description(@"Termination Option does not match.")]
    TerminationOption = UnmatchedReasonCode.TerminationOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option Type does not match.
    /// Encoded/decoded by serializers as &quot;OPTP&quot;.
    /// </summary>
    [EnumMember(Value = "OPTP")]
    [IsoId("_p1NxMdCrEeqVwOG0fcjVKA")]
    [Description(@"Option Type does not match.")]
    OptionType = UnmatchedReasonCode.OptionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Overnight Frequency Rate Fixing does not match.
    /// Encoded/decoded by serializers as &quot;OFRF&quot;.
    /// </summary>
    [EnumMember(Value = "OFRF")]
    [IsoId("_p8p18dCrEeqVwOG0fcjVKA")]
    [Description(@"Overnight Frequency Rate Fixing does not match.")]
    OvernightFrequencyRateFixing = UnmatchedReasonCode.OvernightFrequencyRateFixing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Spread does not match.
    /// Encoded/decoded by serializers as &quot;SPRD&quot;.
    /// </summary>
    [EnumMember(Value = "SPRD")]
    [IsoId("_qDpOwdCrEeqVwOG0fcjVKA")]
    [Description(@"Spread does not match.")]
    Spread = UnmatchedReasonCode.Spread, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate Index Type does not match.
    /// Encoded/decoded by serializers as &quot;RITP&quot;.
    /// </summary>
    [EnumMember(Value = "RITP")]
    [IsoId("_qXIygdCrEeqVwOG0fcjVKA")]
    [Description(@"Rate Index Type does not match.")]
    RateIndexType = UnmatchedReasonCode.RateIndexType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate does not match.
    /// Encoded/decoded by serializers as &quot;RATE&quot;.
    /// </summary>
    [EnumMember(Value = "RATE")]
    [IsoId("_qe3yMdCrEeqVwOG0fcjVKA")]
    [Description(@"Rate does not match.")]
    Rate = UnmatchedReasonCode.Rate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Termination Currency does not match
    /// Encoded/decoded by serializers as &quot;TMCY&quot;.
    /// </summary>
    [EnumMember(Value = "TMCY")]
    [IsoId("_xBE68dCrEeqVwOG0fcjVKA")]
    [Description(@"Termination Currency does not match")]
    TerminationCurrency = UnmatchedReasonCode.TerminationCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction Currency does not match.
    /// Encoded/decoded by serializers as &quot;TXCY&quot;.
    /// </summary>
    [EnumMember(Value = "TXCY")]
    [IsoId("_xQGOYdCrEeqVwOG0fcjVKA")]
    [Description(@"Transaction Currency does not match.")]
    TransactionCurrency = UnmatchedReasonCode.TransactionCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction amount does not  match.
    /// Encoded/decoded by serializers as &quot;TXAM&quot;.
    /// </summary>
    [EnumMember(Value = "TXAM")]
    [IsoId("_145lgdCrEeqVwOG0fcjVKA")]
    [Description(@"Transaction amount does not  match.|")]
    TransactionAmount = UnmatchedReasonCode.TransactionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Minimum Notice Period does not match
    /// Encoded/decoded by serializers as &quot;MNTP&quot;.
    /// </summary>
    [EnumMember(Value = "MNTP")]
    [IsoId("_2AyWMdCrEeqVwOG0fcjVKA")]
    [Description(@"Minimum Notice Period does not match")]
    MinimumNoticePeriod = UnmatchedReasonCode.MinimumNoticePeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Eligibility Set Profile does not match.
    /// Encoded/decoded by serializers as &quot;EGSP&quot;.
    /// </summary>
    [EnumMember(Value = "EGSP")]
    [IsoId("_2unFgdCrEeqVwOG0fcjVKA")]
    [Description(@"The Eligibility Set Profile does not match.")]
    EligibilitySetProfile = UnmatchedReasonCode.EligibilitySetProfile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The exposure type does not match.
    /// Encoded/decoded by serializers as &quot;EXPO&quot;.
    /// </summary>
    [EnumMember(Value = "EXPO")]
    [IsoId("_3Een0dCrEeqVwOG0fcjVKA")]
    [Description(@"The exposure type does not match.")]
    Exposure = UnmatchedReasonCode.Exposure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade date does not match.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_5gGVsdCrEeqVwOG0fcjVKA")]
    [Description(@"Trade date does not match.")]
    TradeDate = UnmatchedReasonCode.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested Execution Date Time does not match.
    /// Encoded/decoded by serializers as &quot;REDT&quot;.
    /// </summary>
    [EnumMember(Value = "REDT")]
    [IsoId("_QmAhUdCsEeqVwOG0fcjVKA")]
    [Description(@"Requested Execution Date Time does not match.")]
    RequestedExecutionDateTime = UnmatchedReasonCode.RequestedExecutionDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A matching instruction from your counterparty could not be found.
    /// Encoded/decoded by serializers as &quot;CMIS&quot;.
    /// </summary>
    [EnumMember(Value = "CMIS")]
    [IsoId("_W6FHcdCsEeqVwOG0fcjVKA")]
    [Description(@"A matching instruction from your counterparty could not be found.")]
    NoMatch = UnmatchedReasonCode.NoMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer Title Indicator does not match.
    /// Encoded/decoded by serializers as &quot;TFRT&quot;.
    /// </summary>
    [EnumMember(Value = "TFRT")]
    [IsoId("_euv_cf7UEeqzyss40vrJTg")]
    [Description(@"Transfer Title Indicator does not match.")]
    TransferTitle = UnmatchedReasonCode.TransferTitle, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Closing date/time does not match.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_frTuUf7UEeqzyss40vrJTg")]
    [Description(@"Closing date/time does not match.")]
    ClosingDateTime = UnmatchedReasonCode.ClosingDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number of days after the accrual payment is due does not match.
    /// Encoded/decoded by serializers as &quot;INPD&quot;.
    /// </summary>
    [EnumMember(Value = "INPD")]
    [IsoId("_ou1H0f7VEeqzyss40vrJTg")]
    [Description(@"Number of days after the accrual payment is due does not match.")]
    InterestPaymentDelay = UnmatchedReasonCode.InterestPaymentDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The computation method of (accrued) interest does not match.
    /// Encoded/decoded by serializers as &quot;PYFQ&quot;.
    /// </summary>
    [EnumMember(Value = "PYFQ")]
    [IsoId("_t5ZvQf7VEeqzyss40vrJTg")]
    [Description(@"The computation method of (accrued) interest does not match.")]
    PaymentFrequency = UnmatchedReasonCode.PaymentFrequency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Compound simple accrual calculation indicator doe not match.
    /// Encoded/decoded by serializers as &quot;CSAC&quot;.
    /// </summary>
    [EnumMember(Value = "CSAC")]
    [IsoId("_w9yGQf7VEeqzyss40vrJTg")]
    [Description(@"Compound simple accrual calculation indicator doe not match.")]
    CompoundSimpleAccrualCalculation = UnmatchedReasonCode.CompoundSimpleAccrualCalculation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Lookback days does not match.
    /// Encoded/decoded by serializers as &quot;LBKD&quot;.
    /// </summary>
    [EnumMember(Value = "LBKD")]
    [IsoId("_BRlr8f7WEeqzyss40vrJTg")]
    [Description(@"Lookback days does not match.")]
    LookbackDays = UnmatchedReasonCode.LookbackDays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Crystallisation date does not match.
    /// Encoded/decoded by serializers as &quot;CRYD&quot;.
    /// </summary>
    [EnumMember(Value = "CRYD")]
    [IsoId("_0QDS0f7WEeqzyss40vrJTg")]
    [Description(@"Crystallisation date does not match.")]
    CrystallisationDate = UnmatchedReasonCode.CrystallisationDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tenor of the interest rate index does not match.
    /// Encoded/decoded by serializers as &quot;TENO&quot;.
    /// </summary>
    [EnumMember(Value = "TENO")]
    [IsoId("_FKFyEf7XEeqzyss40vrJTg")]
    [Description(@"Tenor of the interest rate index does not match.")]
    Tenor = UnmatchedReasonCode.Tenor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement process in which the collateral will be settled does not match.
    /// Encoded/decoded by serializers as &quot;SEPR&quot;.
    /// </summary>
    [EnumMember(Value = "SEPR")]
    [IsoId("_ngdTEQ7iEeujzI3ezCGI7A")]
    [Description(@"Settlement process in which the collateral will be settled does not match.")]
    SettlementProcess = UnmatchedReasonCode.SettlementProcess, // same ordinal as derivation source for type conversions
}
