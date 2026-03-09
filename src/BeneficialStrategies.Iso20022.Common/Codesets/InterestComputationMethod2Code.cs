// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method used to compute accruing interest of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aZhWkNp-Ed-ak6NoX_4Aeg_163960764")]
[Description(@"Specifies the method used to compute accruing interest of a financial instrument.")]
[DerivedFrom(typeof(InterestComputationMethodCode))]
public enum InterestComputationMethod2Code
{
    /// <summary>
    /// Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February, and provided that the interest period started on a 30th or a 31st. This means that a 31st is assumed to be a 30th if the period started on a 30th or a 31st and the 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th). This is the most commonly used 30/360 method for US straight and convertible bonds.
    /// Encoded/decoded by serializers as &quot;A001&quot;.
    /// </summary>
    [EnumMember(Value = "A001")]
    [IsoId("_aZhWkdp-Ed-ak6NoX_4Aeg_1728403415")]
    [Description(@"Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February, and provided that the interest period started on a 30th or a 31st. This means that a 31st is assumed to be a 30th if the period started on a 30th or a 31st and the 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th). This is the most commonly used 30/360 method for US straight and convertible bonds.")]
    IC30360ISDAor30360AmericanBasicRule = InterestComputationMethodCode.IC30360ISDAor30360AmericanBasicRule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on a 30-day month in a way similar to the 30/360 (basic rule) and a 365-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February. This means that a 31st is assumed to be the 30th and the 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th).
    /// Encoded/decoded by serializers as &quot;A002&quot;.
    /// </summary>
    [EnumMember(Value = "A002")]
    [IsoId("_aZhWktp-Ed-ak6NoX_4Aeg_1728403804")]
    [Description(@"Method whereby interest is calculated based on a 30-day month in a way similar to the 30/360 (basic rule) and a 365-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February. This means that a 31st is assumed to be the 30th and the 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th).")]
    IC30365 = InterestComputationMethodCode.IC30365, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on a 30-day month in a way similar to the 30/360 (basic rule) and the assumed number of days in a year in a way similar to the Actual/Actual (ICMA). Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February. This means that the 31st is assumed to be the 30th and 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th). The assumed number of days in a year is computed as the actual number of days in the coupon period multiplied by the number of interest payments in the year.
    /// Encoded/decoded by serializers as &quot;A003&quot;.
    /// </summary>
    [EnumMember(Value = "A003")]
    [IsoId("_aZhWk9p-Ed-ak6NoX_4Aeg_1728404207")]
    [Description(@"Method whereby interest is calculated based on a 30-day month in a way similar to the 30/360 (basic rule) and the assumed number of days in a year in a way similar to the Actual/Actual (ICMA). Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February. This means that the 31st is assumed to be the 30th and 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th). The assumed number of days in a year is computed as the actual number of days in the coupon period multiplied by the number of interest payments in the year.")]
    IC30Actual = InterestComputationMethodCode.IC30Actual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days in the interest period and a 360-day year.
    /// Encoded/decoded by serializers as &quot;A004&quot;.
    /// </summary>
    [EnumMember(Value = "A004")]
    [IsoId("_aZhWlNp-Ed-ak6NoX_4Aeg_1728404362")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days in the interest period and a 360-day year.")]
    Actual360 = InterestComputationMethodCode.Actual360, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days in the interest period and a 365-day year.
    /// Encoded/decoded by serializers as &quot;A005&quot;.
    /// </summary>
    [EnumMember(Value = "A005")]
    [IsoId("_aZhWldp-Ed-ak6NoX_4Aeg_1728404752")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days in the interest period and a 365-day year.")]
    Actual365Fixed = InterestComputationMethodCode.Actual365Fixed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days and the assumed number of days in a year, that is, the actual number of days in the coupon period multiplied by the number of interest payments in the year. If the coupon period is irregular (first or last coupon), it is extended or split into quasi-interest periods that have the length of a regular coupon period and the computation is operated separately on each quasi-interest period and the intermediate results are summed up.
    /// Encoded/decoded by serializers as &quot;A006&quot;.
    /// </summary>
    [EnumMember(Value = "A006")]
    [IsoId("_aZhWltp-Ed-ak6NoX_4Aeg_1728405190")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days and the assumed number of days in a year, that is, the actual number of days in the coupon period multiplied by the number of interest payments in the year. If the coupon period is irregular (first or last coupon), it is extended or split into quasi-interest periods that have the length of a regular coupon period and the computation is operated separately on each quasi-interest period and the intermediate results are summed up.")]
    ActualActualICMA = InterestComputationMethodCode.ActualActualICMA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month. This means that the 31st is assumed to be the 30th and the 28 Feb (or 29 Feb for a leap year) is assumed to be equivalent to 30 Feb. However, if the last day of the maturity coupon period is the last day of February, it will not be assumed to be the 30th. It is a variation of the 30/360 (ICMA) method commonly used for eurobonds. The usage of this variation is only relevant when the coupon periods are scheduled to end on the last day of the month.
    /// Encoded/decoded by serializers as &quot;A007&quot;.
    /// </summary>
    [EnumMember(Value = "A007")]
    [IsoId("_aZhWl9p-Ed-ak6NoX_4Aeg_1728405353")]
    [Description(@"Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month. This means that the 31st is assumed to be the 30th and the 28 Feb (or 29 Feb for a leap year) is assumed to be equivalent to 30 Feb. However, if the last day of the maturity coupon period is the last day of February, it will not be assumed to be the 30th. It is a variation of the 30/360 (ICMA) method commonly used for eurobonds. The usage of this variation is only relevant when the coupon periods are scheduled to end on the last day of the month.")]
    IC30E360orEuroBondBasismodel1 = InterestComputationMethodCode.IC30E360orEuroBondBasismodel1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days of the interest period that fall (falling on a normal year, year) divided by 365, added to the actual number of days of the interest period that fall (falling on a leap year, year) divided by 366.
    /// Encoded/decoded by serializers as &quot;A008&quot;.
    /// </summary>
    [EnumMember(Value = "A008")]
    [IsoId("_aZhWmNp-Ed-ak6NoX_4Aeg_1728405743")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days of the interest period that fall (falling on a normal year, year) divided by 365, added to the actual number of days of the interest period that fall (falling on a leap year, year) divided by 366.")]
    ActualActualISDA = InterestComputationMethodCode.ActualActualISDA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days and a 365-day year (if the coupon payment date is NOT in a leap year) or a 366-day year (if the coupon payment date is in a leap year).
    /// Encoded/decoded by serializers as &quot;A009&quot;.
    /// </summary>
    [EnumMember(Value = "A009")]
    [IsoId("_aZhWmdp-Ed-ak6NoX_4Aeg_1728406163")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days and a 365-day year (if the coupon payment date is NOT in a leap year) or a 366-day year (if the coupon payment date is in a leap year).")]
    Actual365LorActuActubasisRule = InterestComputationMethodCode.Actual365LorActuActubasisRule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days and a 366-day year (if 29 Feb falls in the coupon period) or a 365-day year (if 29 Feb does not fall in the coupon period). If a coupon period is longer than one year, it is split by repetitively separating full year subperiods counting backwards from the end of the coupon period (a year backwards from 28 Feb being 29 Feb, if it exists). The first of the subperiods starts on the start date of the accrued interest period and thus is possibly shorter than a year. Then the interest computation is operated separately on each subperiod and the intermediate results are summed up.
    /// Encoded/decoded by serializers as &quot;A010&quot;.
    /// </summary>
    [EnumMember(Value = "A010")]
    [IsoId("_aZrHkNp-Ed-ak6NoX_4Aeg_1728406336")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days and a 366-day year (if 29 Feb falls in the coupon period) or a 365-day year (if 29 Feb does not fall in the coupon period). If a coupon period is longer than one year, it is split by repetitively separating full year subperiods counting backwards from the end of the coupon period (a year backwards from 28 Feb being 29 Feb, if it exists). The first of the subperiods starts on the start date of the accrued interest period and thus is possibly shorter than a year. Then the interest computation is operated separately on each subperiod and the intermediate results are summed up.")]
    ActualActualAFB = InterestComputationMethodCode.ActualActualAFB, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February. This means that the 31st is assumed to be the 30th and 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th). It is the most commonly used 30/360 method for non-US straight and convertible bonds issued before 1 January 1999.
    /// Encoded/decoded by serializers as &quot;A011&quot;.
    /// </summary>
    [EnumMember(Value = "A011")]
    [IsoId("_aZrHkdp-Ed-ak6NoX_4Aeg_1728406708")]
    [Description(@"Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February. This means that the 31st is assumed to be the 30th and 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th). It is the most commonly used 30/360 method for non-US straight and convertible bonds issued before 1 January 1999.")]
    IC30360ICMAor30360basicrule = InterestComputationMethodCode.IC30360ICMAor30360basicrule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for the last day of February whose day of the month value shall be adapted to the value of the first day of the interest period if the latter is higher and if the period is one of a regular schedule. This means that the 31st is assumed to be the 30th and 28 Feb of a non-leap year is assumed to be equivalent to 29 Feb when the first day of the interest period is the 29th, or to 30 Feb when the first day of the interest period is the 30th or the 31st. The 29th day of February in a leap year is assumed to be equivalent to 30 Feb when the first day of the interest period is the 30th or the 31st. Similarly, if the coupon period starts on the last day of February, it is assumed to produce only one day of interest in February as if it was starting on 30 Feb when the end of the period is the 30th or the 31st, or two days of interest in February when the end of the period is the 29th, or three days of interest in February when it is 28 Feb of a non-leap year and the end of the period is before the 29th.
    /// Encoded/decoded by serializers as &quot;A012&quot;.
    /// </summary>
    [EnumMember(Value = "A012")]
    [IsoId("_aZrHktp-Ed-ak6NoX_4Aeg_1729326859")]
    [Description(@"Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for the last day of February whose day of the month value shall be adapted to the value of the first day of the interest period if the latter is higher and if the period is one of a regular schedule. This means that the 31st is assumed to be the 30th and 28 Feb of a non-leap year is assumed to be equivalent to 29 Feb when the first day of the interest period is the 29th, or to 30 Feb when the first day of the interest period is the 30th or the 31st. The 29th day of February in a leap year is assumed to be equivalent to 30 Feb when the first day of the interest period is the 30th or the 31st. Similarly, if the coupon period starts on the last day of February, it is assumed to produce only one day of interest in February as if it was starting on 30 Feb when the end of the period is the 30th or the 31st, or two days of interest in February when the end of the period is the 29th, or three days of interest in February when it is 28 Feb of a non-leap year and the end of the period is before the 29th.")]
    IC30E2360orEurobondbasismodel2 = InterestComputationMethodCode.IC30E2360orEurobondbasismodel2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month. This means that the 31st is assumed to be the 30th and 28 Feb (or 29 Feb for a leap year) is assumed to be equivalent to 30 Feb. It is a variation of the 30E/360 (or Eurobond basis) method where the last day of February is always assumed to be the 30th, even if it is the last day of the maturity coupon period.
    /// Encoded/decoded by serializers as &quot;A013&quot;.
    /// </summary>
    [EnumMember(Value = "A013")]
    [IsoId("_aZrHk9p-Ed-ak6NoX_4Aeg_1729327284")]
    [Description(@"Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month. This means that the 31st is assumed to be the 30th and 28 Feb (or 29 Feb for a leap year) is assumed to be equivalent to 30 Feb. It is a variation of the 30E/360 (or Eurobond basis) method where the last day of February is always assumed to be the 30th, even if it is the last day of the maturity coupon period.")]
    IC30E3360orEurobondbasismodel3 = InterestComputationMethodCode.IC30E3360orEurobondbasismodel3, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days in the interest period, excluding any leap day from the count, and a 365-day year.
    /// Encoded/decoded by serializers as &quot;A014&quot;.
    /// </summary>
    [EnumMember(Value = "A014")]
    [IsoId("_aZrHlNp-Ed-ak6NoX_4Aeg_1729327843")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days in the interest period, excluding any leap day from the count, and a 365-day year.")]
    Actual365NL = InterestComputationMethodCode.Actual365NL, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other method than A001-A020. See Narrative.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_aZrHldp-Ed-ak6NoX_4Aeg_1729328300")]
    [Description(@"Other method than A001-A020. See Narrative.")]
    Narrative = InterestComputationMethodCode.Narrative, // same ordinal as derivation source for type conversions
    
}
