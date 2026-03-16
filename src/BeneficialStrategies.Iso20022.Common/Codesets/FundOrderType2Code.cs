// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of the investment fund order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VkUiNtp-Ed-ak6NoX_4Aeg_281815183")]
[Description(@"Specifies the category of the investment fund order.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum FundOrderType2Code
{
    /// <summary>
    /// Investment fund order is part of a bed and breakfast transaction.
    /// Encoded/decoded by serializers as &quot;BEDB&quot;.
    /// </summary>
    [EnumMember(Value = "BEDB")]
    [IsoId("_VkUiN9p-Ed-ak6NoX_4Aeg_-1292460159")]
    [Description(@"Investment fund order is part of a bed and breakfast transaction.")]
    BedAndBreakfast = FundOrderTypeCode.BedAndBreakfast, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order is related to an investment plan (only applicable to a subscription).
    /// Encoded/decoded by serializers as &quot;INVP&quot;.
    /// </summary>
    [EnumMember(Value = "INVP")]
    [IsoId("_VkUiONp-Ed-ak6NoX_4Aeg_-1292460158")]
    [Description(
        @"Investment fund order is related to an investment plan (only applicable to a subscription)."
    )]
    InvestmentPlan = FundOrderTypeCode.InvestmentPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order is executed with specific pre-advice conditions.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_VkeTMNp-Ed-ak6NoX_4Aeg_-1292460140")]
    [Description(@"Investment fund order is executed with specific pre-advice conditions.")]
    PreAdvice = FundOrderTypeCode.PreAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order is a staff order.
    /// Encoded/decoded by serializers as &quot;STAF&quot;.
    /// </summary>
    [EnumMember(Value = "STAF")]
    [IsoId("_VkeTMdp-Ed-ak6NoX_4Aeg_-1292460115")]
    [Description(@"Investment fund order is a staff order.")]
    StaffOrder = FundOrderTypeCode.StaffOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order is a regular savings plan (only applicable to a subscription).
    /// Encoded/decoded by serializers as &quot;RGSV&quot;.
    /// </summary>
    [EnumMember(Value = "RGSV")]
    [IsoId("_VkeTMtp-Ed-ak6NoX_4Aeg_1943568529")]
    [Description(
        @"Investment fund order is a regular savings plan (only applicable to a subscription)."
    )]
    RegularSavingsPlan = FundOrderTypeCode.RegularSavingsPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another type of investment fund order.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VkeTM9p-Ed-ak6NoX_4Aeg_1943568564")]
    [Description(@"Another type of investment fund order.")]
    Other = FundOrderTypeCode.Other, // same ordinal as derivation source for type conversions
}
