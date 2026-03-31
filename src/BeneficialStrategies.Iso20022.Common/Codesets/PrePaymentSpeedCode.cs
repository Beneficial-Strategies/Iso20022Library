// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Speed of unscheduled partial of complete payment of the principal amount outstanding on a debt obligation before its due date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aIYjQ9p-Ed-ak6NoX_4Aeg_336258028")]
[Description(
    @"Speed of unscheduled partial of complete payment of the principal amount outstanding on a debt obligation before its due date."
)]
[Derivations(typeof(PrePaymentSpeed1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PrePaymentSpeedCode>))]
#endif
public enum PrePaymentSpeedCode
{
    /// <summary>
    /// Prepayment speed schedule is Single Monthly Mortality, ie, the percentage of outstanding mortgage loan principal prepays in one month.
    /// Encoded/decoded by serializers as &quot;SIMM&quot;.
    /// </summary>
    [EnumMember(Value = "SIMM")]
    [IsoId("_aIYjRNp-Ed-ak6NoX_4Aeg_336258037")]
    [Description(
        @"Prepayment speed schedule is Single Monthly Mortality, ie, the percentage of outstanding mortgage loan principal prepays in one month."
    )]
    SingleMonthlyMortality,

    /// <summary>
    /// Measure of prepayment as a percentage of the current outstanding loan balance, expressed as a compound annual rate.
    /// Encoded/decoded by serializers as &quot;COPR&quot;.
    /// </summary>
    [EnumMember(Value = "COPR")]
    [IsoId("_aIYjRdp-Ed-ak6NoX_4Aeg_336258038")]
    [Description(
        @"Measure of prepayment as a percentage of the current outstanding loan balance, expressed as a compound annual rate."
    )]
    ConstantPrePaymentRate,

    /// <summary>
    /// Measure of prepayment as a monthly percentage of the original loan balance.
    /// Encoded/decoded by serializers as &quot;ABPS&quot;.
    /// </summary>
    [EnumMember(Value = "ABPS")]
    [IsoId("_aIYjRtp-Ed-ak6NoX_4Aeg_336258039")]
    [Description(@"Measure of prepayment as a monthly percentage of the original loan balance.")]
    AbsolutePrePaymentSpeed,

    /// <summary>
    /// Repayment measure for nonamortizing assets not subject to prepayment. It is calculated by dividing the sum of the interest and principal payments received in a month by the outstanding balance.
    /// Encoded/decoded by serializers as &quot;MOPR&quot;.
    /// </summary>
    [EnumMember(Value = "MOPR")]
    [IsoId("_aIYjR9p-Ed-ak6NoX_4Aeg_336258040")]
    [Description(
        @"Repayment measure for nonamortizing assets not subject to prepayment. It is calculated by dividing the sum of the interest and principal payments received in a month by the outstanding balance."
    )]
    MonthlyPrePaymentRate,

    /// <summary>
    /// Contains the type of prepayment speed of the financial instrument, expressed as a percentage of the final Constant Prepayment Rate of the Home Equity Prepayment Curve (10-month seasoning scale composed of even step-ups, terminating at the final Home Equity Prepayment percentage in the 10th month).
    /// Encoded/decoded by serializers as &quot;HOEP&quot;.
    /// </summary>
    [EnumMember(Value = "HOEP")]
    [IsoId("_aIYjSNp-Ed-ak6NoX_4Aeg_336258041")]
    [Description(
        @"Contains the type of prepayment speed of the financial instrument, expressed as a percentage of the final Constant Prepayment Rate of the Home Equity Prepayment Curve (10-month seasoning scale composed of even step-ups, terminating at the final Home Equity Prepayment percentage in the 10th month)."
    )]
    HomeEquityPrePaymentCurve,

    /// <summary>
    /// Contains the type of prepayment speed of the financial instrument, expressed as a percentage of the Bonds Market Association prepayment Curve.
    /// Encoded/decoded by serializers as &quot;BOMA&quot;.
    /// </summary>
    [EnumMember(Value = "BOMA")]
    [IsoId("_aIYjSdp-Ed-ak6NoX_4Aeg_336258042")]
    [Description(
        @"Contains the type of prepayment speed of the financial instrument, expressed as a percentage of the Bonds Market Association prepayment Curve."
    )]
    BMAPrePaymentCurve,

    /// <summary>
    /// Refers to the pricing speed of a transaction as defined in the prospectus and is specific to the issue which are normally priced at 100 percent PPC.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_aIiUQNp-Ed-ak6NoX_4Aeg_336258043")]
    [Description(
        @"Refers to the pricing speed of a transaction as defined in the prospectus and is specific to the issue which are normally priced at 100 percent PPC."
    )]
    ProspectusPrePaymentCurve,

    /// <summary>
    /// Contains the type of prepayment speed of the financial instrument, expressed as a percentage of the Manufactured Housing Prepayment Curve (24-month seasoning scale composed of even step-ups).
    /// Encoded/decoded by serializers as &quot;MAHP&quot;.
    /// </summary>
    [EnumMember(Value = "MAHP")]
    [IsoId("_aIiUQdp-Ed-ak6NoX_4Aeg_336258044")]
    [Description(
        @"Contains the type of prepayment speed of the financial instrument, expressed as a percentage of the Manufactured Housing Prepayment Curve (24-month seasoning scale composed of even step-ups)."
    )]
    ManufacturedHousingPrePaymentCurve,
}
