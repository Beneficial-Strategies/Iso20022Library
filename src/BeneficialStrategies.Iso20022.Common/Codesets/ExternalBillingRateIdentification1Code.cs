// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of billing rate or factor, as published in an external billing rate identification code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WzSlpqlEeGSON8vddiWzQ_1145255535")]
[Description(@"Specifies the type of billing rate or factor, as published in an external billing rate identification code list.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalBillingRateIdentificationCode))]
public enum ExternalBillingRateIdentification1Code
{
    /// <summary>
    /// Per annum earnings rate, adjusted for reserves, applied to the current analysis period’s investable balance for calculation of the earnings allowance credit.  The ECR, Net of Reserves, is calculated as:    ECR, Net of Reserves  =  ECR, Not Net (00 01 22) * (1 – Reserve Rate)
    /// Encoded/decoded by serializers as &quot;AEAR&quot;.
    /// </summary>
    [EnumMember(Value = "AEAR")]
    [IsoId("_uNpde_RYEeuLhpyIdtJzwg")]
    [Description(@"Per annum earnings rate, adjusted for reserves, applied to the current analysis period’s investable balance for calculation of the earnings allowance credit.  The ECR, Net of Reserves, is calculated as:    ECR, Net of Reserves  =  ECR, Not Net (00 01 22) * (1 – Reserve Rate)")]
    AdjustedEarningsAllowanceRate = ExternalBillingRateIdentificationCode.AdjustedEarningsAllowanceRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The anticpated earnings allowance rate, as adjusted, to be used next month in the calculation of the earnings allowance. See AEAR AdjustedEarningsAllowance Rate
    /// Encoded/decoded by serializers as &quot;ANXE&quot;.
    /// </summary>
    [EnumMember(Value = "ANXE")]
    [IsoId("_uNpdfvRYEeuLhpyIdtJzwg")]
    [Description(@"The anticpated earnings allowance rate, as adjusted, to be used next month in the calculation of the earnings allowance. See AEAR AdjustedEarningsAllowance Rate")]
    AdjustedNextMonthEarningsRate = ExternalBillingRateIdentificationCode.AdjustedNextMonthEarningsRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The current CD (Certificate of Deposit) rate as published by the bank.
    /// Encoded/decoded by serializers as &quot;CDRA&quot;.
    /// </summary>
    [EnumMember(Value = "CDRA")]
    [IsoId("_uNynYvRYEeuLhpyIdtJzwg")]
    [Description(@"The current CD (Certificate of Deposit) rate as published by the bank.")]
    CDRate = ExternalBillingRateIdentificationCode.CDRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The per annum rate used to calculate the Deficiency Interest amount to be paid to the bank. 
    /// Encoded/decoded by serializers as &quot;DINR&quot;.
    /// </summary>
    [EnumMember(Value = "DINR")]
    [IsoId("_uNynZfRYEeuLhpyIdtJzwg")]
    [Description(@"The per annum rate used to calculate the Deficiency Interest amount to be paid to the bank. ")]
    DeficiencyInterestRate = ExternalBillingRateIdentificationCode.DeficiencyInterestRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The per annum rate used to calculate a surcharge based on the Deficiency Interest amount to be paid to the bank. 
    /// Encoded/decoded by serializers as &quot;DSCR&quot;.
    /// </summary>
    [EnumMember(Value = "DSCR")]
    [IsoId("_uNynaPRYEeuLhpyIdtJzwg")]
    [Description(@"The per annum rate used to calculate a surcharge based on the Deficiency Interest amount to be paid to the bank. ")]
    DeficiencySurchargeRate = ExternalBillingRateIdentificationCode.DeficiencySurchargeRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Per annum earnings rate applied to the current statement period’s investable balance for calculation of the earnings allowance credit. The earnings allowance credit is used to offset the charges for balance compensable services. This rate has NOT been adjusted for reserves. The ECR, Not Net of Reserves, is calculated as:    ECR, Not Net  =  ECR, Net of Reserves (00 01 20)  /  (1 – Reserve Rate)
    /// Encoded/decoded by serializers as &quot;EALR&quot;.
    /// </summary>
    [EnumMember(Value = "EALR")]
    [IsoId("_uNyna_RYEeuLhpyIdtJzwg")]
    [Description(@"Per annum earnings rate applied to the current statement period’s investable balance for calculation of the earnings allowance credit. The earnings allowance credit is used to offset the charges for balance compensable services. This rate has NOT been adjusted for reserves. The ECR, Not Net of Reserves, is calculated as:    ECR, Not Net  =  ECR, Net of Reserves (00 01 20)  /  (1 – Reserve Rate)")]
    EarningsAllowanceRate = ExternalBillingRateIdentificationCode.EarningsAllowanceRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The current FDIC rate used in the US to calculate the Federal Deposit Insurance premium paid by the banks to the FDIC.
    /// Encoded/decoded by serializers as &quot;FDIC&quot;.
    /// </summary>
    [EnumMember(Value = "FDIC")]
    [IsoId("_uN8YYvRYEeuLhpyIdtJzwg")]
    [Description(@"The current FDIC rate used in the US to calculate the Federal Deposit Insurance premium paid by the banks to the FDIC.")]
    FDICRate = ExternalBillingRateIdentificationCode.FDICRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Per annum interest rate used to calculate the interest amount credited to a designated account. The amount of interest credited, if any, is reported in a Compensation Section with a Compensation Identifier of TtlInterestCredited
    /// Encoded/decoded by serializers as &quot;ICDR&quot;.
    /// </summary>
    [EnumMember(Value = "ICDR")]
    [IsoId("_uN8YZfRYEeuLhpyIdtJzwg")]
    [Description(@"Per annum interest rate used to calculate the interest amount credited to a designated account. The amount of interest credited, if any, is reported in a Compensation Section with a Compensation Identifier of TtlInterestCredited")]
    InterestCreditedRate = ExternalBillingRateIdentificationCode.InterestCreditedRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The collected balance required to offset $1.00 of balance compensable service charges.  This factor can be used to calculate the balance equivalent of balance compensable service charges.  The multiplier is calculated in one of three different ways depending on whether the Earnings Allowance Rate (ECR) is adjusted for reserves or not (net of reserves or not)  and, in the case where the ECR is not adjusted for reserves, whether the multiplier is adjusted for reserves or not.
    /// Encoded/decoded by serializers as &quot;MULT&quot;.
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_uN8YaPRYEeuLhpyIdtJzwg")]
    [Description(@"The collected balance required to offset $1.00 of balance compensable service charges.  This factor can be used to calculate the balance equivalent of balance compensable service charges.  The multiplier is calculated in one of three different ways depending on whether the Earnings Allowance Rate (ECR) is adjusted for reserves or not (net of reserves or not)  and, in the case where the ECR is not adjusted for reserves, whether the multiplier is adjusted for reserves or not.")]
    Multiplier = ExternalBillingRateIdentificationCode.Multiplier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Per annum interest rate used to calculate overdraft compensation on an average net collected balance which is negative (AFP balance 00 00 10).  An average NET balance is negative when the sum of the daily ending POSITIVE and NEGATIVE balances is negative.
    /// Encoded/decoded by serializers as &quot;NCBO&quot;.
    /// </summary>
    [EnumMember(Value = "NCBO")]
    [IsoId("_uN8Ya_RYEeuLhpyIdtJzwg")]
    [Description(@"Per annum interest rate used to calculate overdraft compensation on an average net collected balance which is negative (AFP balance 00 00 10).  An average NET balance is negative when the sum of the daily ending POSITIVE and NEGATIVE balances is negative.")]
    NetCollectedBalanceOverdraftRate = ExternalBillingRateIdentificationCode.NetCollectedBalanceOverdraftRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Per annum interest rate applied to NEGATIVE collected balances (AFP balance 00 00 13) for calculation of overdraft compensation.
    /// Encoded/decoded by serializers as &quot;NGCO&quot;.
    /// </summary>
    [EnumMember(Value = "NGCO")]
    [IsoId("_uN8YbvRYEeuLhpyIdtJzwg")]
    [Description(@"Per annum interest rate applied to NEGATIVE collected balances (AFP balance 00 00 13) for calculation of overdraft compensation.")]
    NegativeCollectedOverdraftRate = ExternalBillingRateIdentificationCode.NegativeCollectedOverdraftRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Per annum interest rate applied to NEGATIVE ledger balances (AFP balance 00 00 03) for calculation of overdraft compensation.
    /// Encoded/decoded by serializers as &quot;NGLO&quot;.
    /// </summary>
    [EnumMember(Value = "NGLO")]
    [IsoId("_uOGJYvRYEeuLhpyIdtJzwg")]
    [Description(@"Per annum interest rate applied to NEGATIVE ledger balances (AFP balance 00 00 03) for calculation of overdraft compensation.")]
    NegativeLedgerOverdraftRate = ExternalBillingRateIdentificationCode.NegativeLedgerOverdraftRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Per annum interest rate used to calculate overdraft compensation on an average net ledger balance which is negative (AFP balance 00 00 00).  An average NET balance is negative when the sum of the daily ending POSITIVE and NEGATIVE balances is negative.
    /// Encoded/decoded by serializers as &quot;NLBO&quot;.
    /// </summary>
    [EnumMember(Value = "NLBO")]
    [IsoId("_uOGJZfRYEeuLhpyIdtJzwg")]
    [Description(@"Per annum interest rate used to calculate overdraft compensation on an average net ledger balance which is negative (AFP balance 00 00 00).  An average NET balance is negative when the sum of the daily ending POSITIVE and NEGATIVE balances is negative.")]
    NetLedgerBalanceOverdraftRate = ExternalBillingRateIdentificationCode.NetLedgerBalanceOverdraftRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The anticpated earnings allowance rate to be used next month in the calculation of the earnings allowance. See EALR EarningsAllowance Rate
    /// Encoded/decoded by serializers as &quot;NXME&quot;.
    /// </summary>
    [EnumMember(Value = "NXME")]
    [IsoId("_uOGJaPRYEeuLhpyIdtJzwg")]
    [Description(@"The anticpated earnings allowance rate to be used next month in the calculation of the earnings allowance. See EALR EarningsAllowance Rate")]
    NextMonthEarningsAllowanceRate = ExternalBillingRateIdentificationCode.NextMonthEarningsAllowanceRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The anticipated Multiplier to be used next month. See MULT Multiplier.
    /// Encoded/decoded by serializers as &quot;NXMU&quot;.
    /// </summary>
    [EnumMember(Value = "NXMU")]
    [IsoId("_uOGJa_RYEeuLhpyIdtJzwg")]
    [Description(@"The anticipated Multiplier to be used next month. See MULT Multiplier.")]
    NextMonthMultiplier = ExternalBillingRateIdentificationCode.NextMonthMultiplier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The current per annum Prime rate as published by the bank.
    /// Encoded/decoded by serializers as &quot;PRIR&quot;.
    /// </summary>
    [EnumMember(Value = "PRIR")]
    [IsoId("_uOGJbvRYEeuLhpyIdtJzwg")]
    [Description(@"The current per annum Prime rate as published by the bank.")]
    PrimeRate = ExternalBillingRateIdentificationCode.PrimeRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The per annum reserve rate as applied to non demand deposit accounts such as time deposit or CD accounts.
    /// Encoded/decoded by serializers as &quot;RRQR&quot;.
    /// </summary>
    [EnumMember(Value = "RRQR")]
    [IsoId("_uOP6YvRYEeuLhpyIdtJzwg")]
    [Description(@"The per annum reserve rate as applied to non demand deposit accounts such as time deposit or CD accounts.")]
    ReserveRequirementRateNonDDA = ExternalBillingRateIdentificationCode.ReserveRequirementRateNonDDA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Per annum interest rate used to calculate that portion of the CollectedBal-AvgPositive that US banks must keep on deposit at the US Federal Reserve.
    /// Encoded/decoded by serializers as &quot;RSRV&quot;.
    /// </summary>
    [EnumMember(Value = "RSRV")]
    [IsoId("_uOP6ZfRYEeuLhpyIdtJzwg")]
    [Description(@"Per annum interest rate used to calculate that portion of the CollectedBal-AvgPositive that US banks must keep on deposit at the US Federal Reserve.")]
    ReserveRequirementRate = ExternalBillingRateIdentificationCode.ReserveRequirementRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Per annum interest rate assessed on that portion of the account balance which is the difference between the average negative ledger and the average negative collected balance (AFP balance 00 00 15).  This rate is used to assess compensation on the portion of the negative collected balance that represents the use of uncollected funds.
    /// Encoded/decoded by serializers as &quot;UFUR&quot;.
    /// </summary>
    [EnumMember(Value = "UFUR")]
    [IsoId("_uOP6aPRYEeuLhpyIdtJzwg")]
    [Description(@"Per annum interest rate assessed on that portion of the account balance which is the difference between the average negative ledger and the average negative collected balance (AFP balance 00 00 15).  This rate is used to assess compensation on the portion of the negative collected balance that represents the use of uncollected funds.")]
    UncollectedFundsUsageRate = ExternalBillingRateIdentificationCode.UncollectedFundsUsageRate, // same ordinal as derivation source for type conversions
    
}
