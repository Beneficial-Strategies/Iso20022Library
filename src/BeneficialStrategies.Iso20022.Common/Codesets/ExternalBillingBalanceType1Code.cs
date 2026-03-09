// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the balance of the billing service, as published in an external billing balance code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6W9DkJqlEeGSON8vddiWzQ_367593430")]
[Description(@"Defines the balance of the billing service, as published in an external billing balance code list.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalBillingBalanceTypeCode))]
public enum ExternalBillingBalanceType1Code
{
    /// <summary>
    /// The difference between the excess/(deficit) investable balance and the excess/(deficit) collected balance due to the reserve requirement. This balance is not used if the account’s Earnings Credit Rate is net of reserves. This may be used when the earnings allowance rate is not adjusted for reserves. It may be that reserves have been subtracted from the collected balance to determine the investable balance. Therefore, they must be added back to the excess/(deficit) investable balance to determine the collected balance position. The presentation of this calculation is optional. AFP code=00 04 21
    /// Encoded/decoded by serializers as &quot;ABRR&quot;.
    /// </summary>
    [EnumMember(Value = "ABRR")]
    [IsoId("_uMKPu_RYEeuLhpyIdtJzwg")]
    [Description(@"The difference between the excess/(deficit) investable balance and the excess/(deficit) collected balance due to the reserve requirement. This balance is not used if the account’s Earnings Credit Rate is net of reserves. This may be used when the earnings allowance rate is not adjusted for reserves. It may be that reserves have been subtracted from the collected balance to determine the investable balance. Therefore, they must be added back to the excess/(deficit) investable balance to determine the collected balance position. The presentation of this calculation is optional. AFP code=00 04 21")]
    AdditionalBalReserveRequirement = ExternalBillingBalanceTypeCode.AdditionalBalReserveRequirement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance required to offset the current analysis period’s balance compensable service charges. The balance equivalent can be calculated in two different ways. The first simply multiplies the balance compensable service charge total by the multiplier.  The second calculation incorporates all of the elements of the multiplier calculation. Note that this calculation may result in a slightly different value due to the decimal precision and rounding used in the calculation: AFP code=00 04 00
    /// Encoded/decoded by serializers as &quot;BEQU&quot;.
    /// </summary>
    [EnumMember(Value = "BEQU")]
    [IsoId("_uMKPvvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance required to offset the current analysis period’s balance compensable service charges. The balance equivalent can be calculated in two different ways. The first simply multiplies the balance compensable service charge total by the multiplier.  The second calculation incorporates all of the elements of the multiplier calculation. Note that this calculation may result in a slightly different value due to the decimal precision and rounding used in the calculation: AFP code=00 04 00")]
    BalEquivalent = ExternalBillingBalanceTypeCode.BalEquivalent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The sum of only the daily ending NEGATIVE collected balances divided by the number of days in the statement period. The average negative balance, if present, is always positively signed. Balances are net of current period adjustments. Note that a NEGATIVE balance is equal to the POSITIVE balance less the NET balance. Note that a NEGATIVE Collected Balance Interest Rate can be applied to this balance to develop an OD interest charge. AFP code=00 00 13
    /// Encoded/decoded by serializers as &quot;CBAM&quot;.
    /// </summary>
    [EnumMember(Value = "CBAM")]
    [IsoId("_uMTZovRYEeuLhpyIdtJzwg")]
    [Description(@"The sum of only the daily ending NEGATIVE collected balances divided by the number of days in the statement period. The average negative balance, if present, is always positively signed. Balances are net of current period adjustments. Note that a NEGATIVE balance is equal to the POSITIVE balance less the NET balance. Note that a NEGATIVE Collected Balance Interest Rate can be applied to this balance to develop an OD interest charge. AFP code=00 00 13")]
    CollectedBalAvgNegative = ExternalBillingBalanceTypeCode.CollectedBalAvgNegative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The sum of the daily ending collected balances (both positive and negative) divided by the number of days in the statement period.  A negative-signed value indicates a negative average NET balance.  If a reserve-adjusted earnings allowance/credit rate is used, this balance may be the same as the investable balance (00 00 40).  Balances are net of current period adjustments. Collected balances represent deposit money that has been collected and excludes any money in float. Note that a NET balance is equal to the POSITIVE balance less the NEGATIVE balance. Note that a NET Collected Balance OD Interest Rate (00 01 43) can be applied to this balance, if negative, to develop an OD interest charge.  AFP code=00 00 10
    /// Encoded/decoded by serializers as &quot;CBAN&quot;.
    /// </summary>
    [EnumMember(Value = "CBAN")]
    [IsoId("_uMTZpfRYEeuLhpyIdtJzwg")]
    [Description(@"The sum of the daily ending collected balances (both positive and negative) divided by the number of days in the statement period.  A negative-signed value indicates a negative average NET balance.  If a reserve-adjusted earnings allowance/credit rate is used, this balance may be the same as the investable balance (00 00 40).  Balances are net of current period adjustments. Collected balances represent deposit money that has been collected and excludes any money in float. Note that a NET balance is equal to the POSITIVE balance less the NEGATIVE balance. Note that a NET Collected Balance OD Interest Rate (00 01 43) can be applied to this balance, if negative, to develop an OD interest charge.  AFP code=00 00 10")]
    CollectedBalAvgNet = ExternalBillingBalanceTypeCode.CollectedBalAvgNet, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The sum of only the daily ending POSITIVE collected balances divided by the number of days in the statement period.  Balances are net of current period adjustments. Collected balances represent deposit money that has been collected and excludes any money in float. Note that a POSITIVE balance is equal to the NET balance plus the NEGATIVE balance. AFP code=00 00 11
    /// Encoded/decoded by serializers as &quot;CBAP&quot;.
    /// </summary>
    [EnumMember(Value = "CBAP")]
    [IsoId("_uMTZqPRYEeuLhpyIdtJzwg")]
    [Description(@"The sum of only the daily ending POSITIVE collected balances divided by the number of days in the statement period.  Balances are net of current period adjustments. Collected balances represent deposit money that has been collected and excludes any money in float. Note that a POSITIVE balance is equal to the NET balance plus the NEGATIVE balance. AFP code=00 00 11")]
    CollectedBalAvgPositive = ExternalBillingBalanceTypeCode.CollectedBalAvgPositive, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// That portion of the demand deposit account balance that must be set aside by the bank to meet reserve requirements. AFP code=00 04 20
    /// Encoded/decoded by serializers as &quot;DABR&quot;.
    /// </summary>
    [EnumMember(Value = "DABR")]
    [IsoId("_uMTZq_RYEeuLhpyIdtJzwg")]
    [Description(@"That portion of the demand deposit account balance that must be set aside by the bank to meet reserve requirements. AFP code=00 04 20")]
    DemandDepositAccountBalanceReserveRequirement = ExternalBillingBalanceTypeCode.DemandDepositAccountBalanceReserveRequirement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Collected balance remaining after the balance required to offset the current analysis period’s balance compensable service charges has been deducted.  If negative (deficit), this represents the additional collected balance required to fully offset balance compensable service charges for the current period.  If positive (excess), this represents the collected balance surplus after offsetting balance compensable service charges for the current period. AFP code=00 04 12
    /// Encoded/decoded by serializers as &quot;EDCB&quot;.
    /// </summary>
    [EnumMember(Value = "EDCB")]
    [IsoId("_uMdKovRYEeuLhpyIdtJzwg")]
    [Description(@"Collected balance remaining after the balance required to offset the current analysis period’s balance compensable service charges has been deducted.  If negative (deficit), this represents the additional collected balance required to fully offset balance compensable service charges for the current period.  If positive (excess), this represents the collected balance surplus after offsetting balance compensable service charges for the current period. AFP code=00 04 12")]
    ExcessDeficitCollectedBal = ExternalBillingBalanceTypeCode.ExcessDeficitCollectedBal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investable balance remaining after the balance required to offset the current analysis period’s balance compensable service charges has been deducted.  If negative (deficit), this represents the additional investable balance required to fully offset balance compensable service charges for the current period.  If positive (excess), this represents the investable balance surplus after offsetting balance compensable service charges for the current period. Depending on the type of underlying account, a hard interest rate may be applied to a balance excess resulting in a hard interest credit to the underlying account. AFP code=00 04 10
    /// Encoded/decoded by serializers as &quot;EDIB&quot;.
    /// </summary>
    [EnumMember(Value = "EDIB")]
    [IsoId("_uMdKpfRYEeuLhpyIdtJzwg")]
    [Description(@"Investable balance remaining after the balance required to offset the current analysis period’s balance compensable service charges has been deducted.  If negative (deficit), this represents the additional investable balance required to fully offset balance compensable service charges for the current period.  If positive (excess), this represents the investable balance surplus after offsetting balance compensable service charges for the current period. Depending on the type of underlying account, a hard interest rate may be applied to a balance excess resulting in a hard interest credit to the underlying account. AFP code=00 04 10")]
    ExcessDeficitInvestableBal = ExternalBillingBalanceTypeCode.ExcessDeficitInvestableBal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// That account balance used to calculate the FDIC assessment charge. AFP code=00 00 50
    /// Encoded/decoded by serializers as &quot;FDIC&quot;.
    /// </summary>
    [EnumMember(Value = "FDIC")]
    [IsoId("_uMdKqPRYEeuLhpyIdtJzwg")]
    [Description(@"That account balance used to calculate the FDIC assessment charge. AFP code=00 00 50")]
    FDICAssesmentBal = ExternalBillingBalanceTypeCode.FDICAssesmentBal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The sum of the daily dollar amount of items in the process of collection divided by the number of days in the statement period.  AFP code=00 00 30
    /// Encoded/decoded by serializers as &quot;FLBA&quot;.
    /// </summary>
    [EnumMember(Value = "FLBA")]
    [IsoId("_uMdKq_RYEeuLhpyIdtJzwg")]
    [Description(@"The sum of the daily dollar amount of items in the process of collection divided by the number of days in the statement period.  AFP code=00 00 30")]
    FloatBalAvg = ExternalBillingBalanceTypeCode.FloatBalAvg, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sum of the adjustments to the average float in a prior period(s).  A negative-signed value indicates a balance reduction. This balance can also be used to adjust the average collected balances since money in float has a direct effect on collected balances. AFP code=00 00 61
    /// Encoded/decoded by serializers as &quot;FLPP&quot;.
    /// </summary>
    [EnumMember(Value = "FLPP")]
    [IsoId("_uMdKrvRYEeuLhpyIdtJzwg")]
    [Description(@"Sum of the adjustments to the average float in a prior period(s).  A negative-signed value indicates a balance reduction. This balance can also be used to adjust the average collected balances since money in float has a direct effect on collected balances. AFP code=00 00 61")]
    BalAdjPriorPeriodAvgFloat = ExternalBillingBalanceTypeCode.BalAdjPriorPeriodAvgFloat, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance on which the earnings allowance/credit rate is applied.  This value can be signed either positive or negative.  A negative-signed balance indicates a shortage of investable funds.and may result in a charge. AFP code=00 00 40
    /// Encoded/decoded by serializers as &quot;IBAL&quot;.
    /// </summary>
    [EnumMember(Value = "IBAL")]
    [IsoId("_uMmUkvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance on which the earnings allowance/credit rate is applied.  This value can be signed either positive or negative.  A negative-signed balance indicates a shortage of investable funds.and may result in a charge. AFP code=00 00 40")]
    InvestableBal = ExternalBillingBalanceTypeCode.InvestableBal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The average investable balance that can be used to show the base balance for the calculation of a hard interest credited. This is a hard interest credit as opposed to an earnings credit. AFP code=00 00 75
    /// Encoded/decoded by serializers as &quot;IBIB&quot;.
    /// </summary>
    [EnumMember(Value = "IBIB")]
    [IsoId("_uMmUlfRYEeuLhpyIdtJzwg")]
    [Description(@"The average investable balance that can be used to show the base balance for the calculation of a hard interest credited. This is a hard interest credit as opposed to an earnings credit. AFP code=00 00 75")]
    InterestBearingInvestableBalance = ExternalBillingBalanceTypeCode.InterestBearingInvestableBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The average ledger balance that can be used to show the base balance for the calculation of a hard interest credited. This is a hard interest credit as opposed to an earnings credit. AFP code=00 00 70
    /// Encoded/decoded by serializers as &quot;IBLB&quot;.
    /// </summary>
    [EnumMember(Value = "IBLB")]
    [IsoId("_uMmUmPRYEeuLhpyIdtJzwg")]
    [Description(@"The average ledger balance that can be used to show the base balance for the calculation of a hard interest credited. This is a hard interest credit as opposed to an earnings credit. AFP code=00 00 70")]
    InterestBearingLedgerBalance = ExternalBillingBalanceTypeCode.InterestBearingLedgerBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The average net collected balance that can be used to show the base balance for the calculation of a hard interest credited. This is a hard interest credit as opposed to an earnings credit. AFP code=00 00 71
    /// Encoded/decoded by serializers as &quot;IBNC&quot;.
    /// </summary>
    [EnumMember(Value = "IBNC")]
    [IsoId("_uMmUm_RYEeuLhpyIdtJzwg")]
    [Description(@"The average net collected balance that can be used to show the base balance for the calculation of a hard interest credited. This is a hard interest credit as opposed to an earnings credit. AFP code=00 00 71")]
    InterestBearingNetCollectedBalance = ExternalBillingBalanceTypeCode.InterestBearingNetCollectedBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The average negatve collected balance that can be used to show the base balance for the calculation of a hard interest debit. This is a hard interest debit as opposed to an earnings credit debit. AFP code=00 00 73
    /// Encoded/decoded by serializers as &quot;IBNG&quot;.
    /// </summary>
    [EnumMember(Value = "IBNG")]
    [IsoId("_uMwFkvRYEeuLhpyIdtJzwg")]
    [Description(@"The average negatve collected balance that can be used to show the base balance for the calculation of a hard interest debit. This is a hard interest debit as opposed to an earnings credit debit. AFP code=00 00 73")]
    InterestBearingNegativeCollectedBalance = ExternalBillingBalanceTypeCode.InterestBearingNegativeCollectedBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The average positive collected balance that can be used to show the base balance for the calculation of a hard interest credited. This is a hard interest credit as opposed to an earnings credit. AFP code=00 00 72
    /// Encoded/decoded by serializers as &quot;IBPC&quot;.
    /// </summary>
    [EnumMember(Value = "IBPC")]
    [IsoId("_uMwFlfRYEeuLhpyIdtJzwg")]
    [Description(@"The average positive collected balance that can be used to show the base balance for the calculation of a hard interest credited. This is a hard interest credit as opposed to an earnings credit. AFP code=00 00 72")]
    InterestBearingPositiveCollectedBalance = ExternalBillingBalanceTypeCode.InterestBearingPositiveCollectedBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The average reserve requirement balance that can be used to show the base balance for the calculation of a hard interest credited. This is a hard interest credit as opposed to an earnings credit. AFP code=00 00 74
    /// Encoded/decoded by serializers as &quot;IBRR&quot;.
    /// </summary>
    [EnumMember(Value = "IBRR")]
    [IsoId("_uMwFmPRYEeuLhpyIdtJzwg")]
    [Description(@"The average reserve requirement balance that can be used to show the base balance for the calculation of a hard interest credited. This is a hard interest credit as opposed to an earnings credit. AFP code=00 00 74")]
    InterestBearingReserveRequirementBalance = ExternalBillingBalanceTypeCode.InterestBearingReserveRequirementBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The sum of the daily ending ledger balances (both positive and negative) divided by the number of days in the statement period.  A negative-signed value indicates a negative average NET balance. Balances are net of current period adjustments. The ledger balance includes any deposit money that has not been collected, ie, money in float.Note that a NET balance is equal to the POSITIVE balance less the NEGATIVE balance.Note that a NET Ledger Balance OD Interest Rate can be applied to this balance, if negative, to develop an OD interest charge.  AFP code=00 00 00
    /// Encoded/decoded by serializers as &quot;LBAN&quot;.
    /// </summary>
    [EnumMember(Value = "LBAN")]
    [IsoId("_uMwFm_RYEeuLhpyIdtJzwg")]
    [Description(@"The sum of the daily ending ledger balances (both positive and negative) divided by the number of days in the statement period.  A negative-signed value indicates a negative average NET balance. Balances are net of current period adjustments. The ledger balance includes any deposit money that has not been collected, ie, money in float.Note that a NET balance is equal to the POSITIVE balance less the NEGATIVE balance.Note that a NET Ledger Balance OD Interest Rate can be applied to this balance, if negative, to develop an OD interest charge.  AFP code=00 00 00")]
    LedgerBalAvgNet = ExternalBillingBalanceTypeCode.LedgerBalAvgNet, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The sum of only the daily ending POSITIVE ledger balances divided by the number of days in the statement period.  Balances are net of current period adjustments. The ledger balance includes any deposit money that has not been collected, ie, money in float. Note that a POSITIVE balance is equal to the NET balance plus the NEGATIVE balance. AFP code=00 00 01
    /// Encoded/decoded by serializers as &quot;LBAP&quot;.
    /// </summary>
    [EnumMember(Value = "LBAP")]
    [IsoId("_uMwFnvRYEeuLhpyIdtJzwg")]
    [Description(@"The sum of only the daily ending POSITIVE ledger balances divided by the number of days in the statement period.  Balances are net of current period adjustments. The ledger balance includes any deposit money that has not been collected, ie, money in float. Note that a POSITIVE balance is equal to the NET balance plus the NEGATIVE balance. AFP code=00 00 01")]
    LedgerBalAvgPositive = ExternalBillingBalanceTypeCode.LedgerBalAvgPositive, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Value of the book or ledger balance at the end of the calendar month. AFP code=00 00 05
    /// Encoded/decoded by serializers as &quot;LBME&quot;.
    /// </summary>
    [EnumMember(Value = "LBME")]
    [IsoId("_uM52kvRYEeuLhpyIdtJzwg")]
    [Description(@"Value of the book or ledger balance at the end of the calendar month. AFP code=00 00 05")]
    LedgerBalMonthEnd = ExternalBillingBalanceTypeCode.LedgerBalMonthEnd, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The sum of only the daily ending NEGATIVE ledger balances divided by the number of days in the statement period. The average negative balance, if present, is always positively signed. Balances are net of current period adjustments. Note that a NEGATIVE balance is equal to the POSITIVE balance less the NET balance. Note that a NEGATIVE Ledger Balance Interest Rate can be applied to this balance to develop an OD interest charge. AFP code=00 00 03
    /// Encoded/decoded by serializers as &quot;LBNM&quot;.
    /// </summary>
    [EnumMember(Value = "LBNM")]
    [IsoId("_uM52lfRYEeuLhpyIdtJzwg")]
    [Description(@"The sum of only the daily ending NEGATIVE ledger balances divided by the number of days in the statement period. The average negative balance, if present, is always positively signed. Balances are net of current period adjustments. Note that a NEGATIVE balance is equal to the POSITIVE balance less the NET balance. Note that a NEGATIVE Ledger Balance Interest Rate can be applied to this balance to develop an OD interest charge. AFP code=00 00 03")]
    LedgerBalAvgNegative = ExternalBillingBalanceTypeCode.LedgerBalAvgNegative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// That portion of the balance that is the difference between the average negative collected balance and the average negative ledger balance.  This is used to isolate that portion of the negative collected balance that represents the use of uncollected funds.  Balances are net of current period adjustments. Note that the Uncollected Funds Usage Rate can be applied to this balance to develop an Uncollected Funds OD interest charge.  AFP code=00 00 15
    /// Encoded/decoded by serializers as &quot;UCFU&quot;.
    /// </summary>
    [EnumMember(Value = "UCFU")]
    [IsoId("_uM52mPRYEeuLhpyIdtJzwg")]
    [Description(@"That portion of the balance that is the difference between the average negative collected balance and the average negative ledger balance.  This is used to isolate that portion of the negative collected balance that represents the use of uncollected funds.  Balances are net of current period adjustments. Note that the Uncollected Funds Usage Rate can be applied to this balance to develop an Uncollected Funds OD interest charge.  AFP code=00 00 15")]
    UncollectedFundsUsed = ExternalBillingBalanceTypeCode.UncollectedFundsUsed, // same ordinal as derivation source for type conversions
    
}
