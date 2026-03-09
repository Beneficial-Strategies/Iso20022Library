// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Speed of unscheduled partial of complete payment of the principal amount outstanding on a debt obligation before its due date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aIOyQ9p-Ed-ak6NoX_4Aeg_-288880820")]
[Description(@"Speed of unscheduled partial of complete payment of the principal amount outstanding on a debt obligation before its due date.")]
[DerivedFrom(typeof(PrePaymentSpeedCode))]
public enum PrePaymentSpeed1Code
{
    /// <summary>
    /// Prepayment speed schedule is Single Monthly Mortality, ie, the percentage of outstanding mortgage loan principal prepays in one month.
    /// Encoded/decoded by serializers as &quot;SIMM&quot;.
    /// </summary>
    [EnumMember(Value = "SIMM")]
    [IsoId("_aIOyRNp-Ed-ak6NoX_4Aeg_-232543155")]
    [Description(@"Prepayment speed schedule is Single Monthly Mortality, ie, the percentage of outstanding mortgage loan principal prepays in one month.")]
    SingleMonthlyMortality = PrePaymentSpeedCode.SingleMonthlyMortality, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of prepayment as a percentage of the current outstanding loan balance, expressed as a compound annual rate.
    /// Encoded/decoded by serializers as &quot;COPR&quot;.
    /// </summary>
    [EnumMember(Value = "COPR")]
    [IsoId("_aIOyRdp-Ed-ak6NoX_4Aeg_-232542895")]
    [Description(@"Measure of prepayment as a percentage of the current outstanding loan balance, expressed as a compound annual rate.")]
    ConstantPrePaymentRate = PrePaymentSpeedCode.ConstantPrePaymentRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of prepayment as a monthly percentage of the original loan balance.
    /// Encoded/decoded by serializers as &quot;ABPS&quot;.
    /// </summary>
    [EnumMember(Value = "ABPS")]
    [IsoId("_aIOyRtp-Ed-ak6NoX_4Aeg_-232542878")]
    [Description(@"Measure of prepayment as a monthly percentage of the original loan balance.")]
    AbsolutePrePaymentSpeed = PrePaymentSpeedCode.AbsolutePrePaymentSpeed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Repayment measure for nonamortizing assets not subject to prepayment. It is calculated by dividing the sum of the interest and principal payments received in a month by the outstanding balance.
    /// Encoded/decoded by serializers as &quot;MOPR&quot;.
    /// </summary>
    [EnumMember(Value = "MOPR")]
    [IsoId("_aIOyR9p-Ed-ak6NoX_4Aeg_-232542843")]
    [Description(@"Repayment measure for nonamortizing assets not subject to prepayment. It is calculated by dividing the sum of the interest and principal payments received in a month by the outstanding balance.")]
    MonthlyPrePaymentRate = PrePaymentSpeedCode.MonthlyPrePaymentRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contains the type of prepayment speed of the financial instrument, expressed as a percentage of the final Constant Prepayment Rate of the Home Equity Prepayment Curve (10-month seasoning scale composed of even step-ups, terminating at the final Home Equity Prepayment percentage in the 10th month).
    /// Encoded/decoded by serializers as &quot;HOEP&quot;.
    /// </summary>
    [EnumMember(Value = "HOEP")]
    [IsoId("_aIOySNp-Ed-ak6NoX_4Aeg_-232542782")]
    [Description(@"Contains the type of prepayment speed of the financial instrument, expressed as a percentage of the final Constant Prepayment Rate of the Home Equity Prepayment Curve (10-month seasoning scale composed of even step-ups, terminating at the final Home Equity Prepayment percentage in the 10th month).")]
    HomeEquityPrePaymentCurve = PrePaymentSpeedCode.HomeEquityPrePaymentCurve, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contains the type of prepayment speed of the financial instrument, expressed as a percentage of the Bonds Market Association prepayment Curve.
    /// Encoded/decoded by serializers as &quot;BOMA&quot;.
    /// </summary>
    [EnumMember(Value = "BOMA")]
    [IsoId("_aIYjQNp-Ed-ak6NoX_4Aeg_-231622768")]
    [Description(@"Contains the type of prepayment speed of the financial instrument, expressed as a percentage of the Bonds Market Association prepayment Curve.")]
    BMAPrePaymentCurve = PrePaymentSpeedCode.BMAPrePaymentCurve, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Refers to the pricing speed of a transaction as defined in the prospectus and is specific to the issue which are normally priced at 100 percent PPC.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_aIYjQdp-Ed-ak6NoX_4Aeg_-231622733")]
    [Description(@"Refers to the pricing speed of a transaction as defined in the prospectus and is specific to the issue which are normally priced at 100 percent PPC.")]
    ProspectusPrePaymentCurve = PrePaymentSpeedCode.ProspectusPrePaymentCurve, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contains the type of prepayment speed of the financial instrument, expressed as a percentage of the Manufactured Housing Prepayment Curve (24-month seasoning scale composed of even step-ups).
    /// Encoded/decoded by serializers as &quot;MAHP&quot;.
    /// </summary>
    [EnumMember(Value = "MAHP")]
    [IsoId("_aIYjQtp-Ed-ak6NoX_4Aeg_-231622673")]
    [Description(@"Contains the type of prepayment speed of the financial instrument, expressed as a percentage of the Manufactured Housing Prepayment Curve (24-month seasoning scale composed of even step-ups).")]
    ManufacturedHousingPrePaymentCurve = PrePaymentSpeedCode.ManufacturedHousingPrePaymentCurve, // same ordinal as derivation source for type conversions
    
}
