// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the first accrual period for debt instruments compared to the normal accrual period of the security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_10Ab8DL3EeKU9IrkkToqcw_1816998804")]
[Description(
    @"Specifies the type of the first accrual period for debt instruments compared to the normal accrual period of the security."
)]
[DerivedFrom(typeof(AccrualPeriodTypeCode))]
public enum AccrualPeriodType1Code
{
    /// <summary>
    /// Long first payment period is applicable.
    /// Encoded/decoded by serializers as &quot;LONG&quot;.
    /// </summary>
    [EnumMember(Value = "LONG")]
    [IsoId("_10Ab8TL3EeKU9IrkkToqcw_151248487")]
    [Description(@"Long first payment period is applicable.")]
    LongFirstPaymentPeriod = AccrualPeriodTypeCode.LongFirstPaymentPeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Regular first payment period is applicable.
    /// Encoded/decoded by serializers as &quot;FREG&quot;.
    /// </summary>
    [EnumMember(Value = "FREG")]
    [IsoId("_10Ab8jL3EeKU9IrkkToqcw_476365994")]
    [Description(@"Regular first payment period is applicable.")]
    FirstRegularPaymentPeriod = AccrualPeriodTypeCode.FirstRegularPaymentPeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Short first payment period is applicable.
    /// Encoded/decoded by serializers as &quot;SHRT&quot;.
    /// </summary>
    [EnumMember(Value = "SHRT")]
    [IsoId("_10Ab8zL3EeKU9IrkkToqcw_-455570526")]
    [Description(@"Short first payment period is applicable.")]
    ShortFirstPaymentperiod = AccrualPeriodTypeCode.ShortFirstPaymentperiod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// First year of payment is applicable.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_10Ab9DL3EeKU9IrkkToqcw_-1483257")]
    [Description(@"First year of payment is applicable.")]
    FirstYearOfPayment = AccrualPeriodTypeCode.FirstYearOfPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Extra long payment period is applicable.
    /// Encoded/decoded by serializers as &quot;XLNG&quot;.
    /// </summary>
    [EnumMember(Value = "XLNG")]
    [IsoId("_10Ab9TL3EeKU9IrkkToqcw_584463769")]
    [Description(@"Extra long payment period is applicable.")]
    ExtraLongPaymentPeriod = AccrualPeriodTypeCode.ExtraLongPaymentPeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Default payment period is applicable.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_10Ab9jL3EeKU9IrkkToqcw_2051612532")]
    [Description(@"Default payment period is applicable.")]
    DefaultPeriod = AccrualPeriodTypeCode.DefaultPeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment has not been done.
    /// Encoded/decoded by serializers as &quot;OMIT&quot;.
    /// </summary>
    [EnumMember(Value = "OMIT")]
    [IsoId("_10Jl4DL3EeKU9IrkkToqcw_-794219174")]
    [Description(@"Payment has not been done.")]
    PaymentOmitted = AccrualPeriodTypeCode.PaymentOmitted, // same ordinal as derivation source for type conversions
}
