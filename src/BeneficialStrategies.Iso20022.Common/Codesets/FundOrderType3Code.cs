// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of the investment fund order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_atCvhdp-Ed-ak6NoX_4Aeg_1398779632")]
[Description(@"Specifies the category of the investment fund order.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum FundOrderType3Code
{
    /// <summary>
    /// Investment fund order is part of a bed and breakfast transaction.
    /// Encoded/decoded by serializers as &quot;BEDB&quot;.
    /// </summary>
    [EnumMember(Value = "BEDB")]
    [IsoId("_atCvhtp-Ed-ak6NoX_4Aeg_233028148")]
    [Description(@"Investment fund order is part of a bed and breakfast transaction.")]
    BedAndBreakfast = FundOrderTypeCode.BedAndBreakfast, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order is related to an investment plan (only applicable to a subscription).
    /// Encoded/decoded by serializers as &quot;INVP&quot;.
    /// </summary>
    [EnumMember(Value = "INVP")]
    [IsoId("_atCvh9p-Ed-ak6NoX_4Aeg_233028173")]
    [Description(
        @"Investment fund order is related to an investment plan (only applicable to a subscription)."
    )]
    InvestmentPlan = FundOrderTypeCode.InvestmentPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order is executed with specific pre-advice conditions.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_atCviNp-Ed-ak6NoX_4Aeg_233028190")]
    [Description(@"Investment fund order is executed with specific pre-advice conditions.")]
    PreAdvice = FundOrderTypeCode.PreAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order is a staff order.
    /// Encoded/decoded by serializers as &quot;STAF&quot;.
    /// </summary>
    [EnumMember(Value = "STAF")]
    [IsoId("_atL5cNp-Ed-ak6NoX_4Aeg_233028208")]
    [Description(@"Investment fund order is a staff order.")]
    StaffOrder = FundOrderTypeCode.StaffOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order is a regular savings plan (only applicable to a subscription).
    /// Encoded/decoded by serializers as &quot;RGSV&quot;.
    /// </summary>
    [EnumMember(Value = "RGSV")]
    [IsoId("_atL5cdp-Ed-ak6NoX_4Aeg_233028243")]
    [Description(
        @"Investment fund order is a regular savings plan (only applicable to a subscription)."
    )]
    RegularSavingsPlan = FundOrderTypeCode.RegularSavingsPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order is a dividend reinvestment (only applicable to a subscription).
    /// Encoded/decoded by serializers as &quot;RDIV&quot;.
    /// </summary>
    [EnumMember(Value = "RDIV")]
    [IsoId("_atL5ctp-Ed-ak6NoX_4Aeg_279205342")]
    [Description(
        @"Investment fund order is a dividend reinvestment (only applicable to a subscription)."
    )]
    ReinvestmentOfDividend = FundOrderTypeCode.ReinvestmentOfDividend, // same ordinal as derivation source for type conversions
}
