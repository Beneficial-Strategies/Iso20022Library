// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of the investment fund order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_atL5c9p-Ed-ak6NoX_4Aeg_-88838382")]
[Description(@"Specifies the category of the investment fund order.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum FundOrderType4Code
{
    /// <summary>
    /// Investment fund order is part of a bed and breakfast transaction.
    /// Encoded/decoded by serializers as &quot;BEDB&quot;.
    /// </summary>
    [EnumMember(Value = "BEDB")]
    [IsoId("_atL5dNp-Ed-ak6NoX_4Aeg_-88838356")]
    [Description(@"Investment fund order is part of a bed and breakfast transaction.")]
    BedAndBreakfast = FundOrderTypeCode.BedAndBreakfast, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is related to an investment plan (only applicable to a subscription).
    /// Encoded/decoded by serializers as &quot;INVP&quot;.
    /// </summary>
    [EnumMember(Value = "INVP")]
    [IsoId("_atL5ddp-Ed-ak6NoX_4Aeg_-88838340")]
    [Description(@"Investment fund order is related to an investment plan (only applicable to a subscription).")]
    InvestmentPlan = FundOrderTypeCode.InvestmentPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is executed with specific pre-advice conditions.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_atL5dtp-Ed-ak6NoX_4Aeg_-88838321")]
    [Description(@"Investment fund order is executed with specific pre-advice conditions.")]
    PreAdvice = FundOrderTypeCode.PreAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is a staff order.
    /// Encoded/decoded by serializers as &quot;STAF&quot;.
    /// </summary>
    [EnumMember(Value = "STAF")]
    [IsoId("_atL5d9p-Ed-ak6NoX_4Aeg_-88837953")]
    [Description(@"Investment fund order is a staff order.")]
    StaffOrder = FundOrderTypeCode.StaffOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is a regular savings plan (only applicable to a subscription).
    /// Encoded/decoded by serializers as &quot;RGSV&quot;.
    /// </summary>
    [EnumMember(Value = "RGSV")]
    [IsoId("_atL5eNp-Ed-ak6NoX_4Aeg_-88837936")]
    [Description(@"Investment fund order is a regular savings plan (only applicable to a subscription).")]
    RegularSavingsPlan = FundOrderTypeCode.RegularSavingsPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is paying extra money into to an existing plan (only applicable to a subscription).
    /// Encoded/decoded by serializers as &quot;RGSU&quot;.
    /// </summary>
    [EnumMember(Value = "RGSU")]
    [IsoId("_atL5edp-Ed-ak6NoX_4Aeg_-21423674")]
    [Description(@"Investment fund order is paying extra money into to an existing plan (only applicable to a subscription).")]
    RegularSavingsPlanUpdate = FundOrderTypeCode.RegularSavingsPlanUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is a dividend reinvestment (only applicable to a subscription).
    /// Encoded/decoded by serializers as &quot;RDIV&quot;.
    /// </summary>
    [EnumMember(Value = "RDIV")]
    [IsoId("_atVqcNp-Ed-ak6NoX_4Aeg_-88837893")]
    [Description(@"Investment fund order is a dividend reinvestment (only applicable to a subscription).")]
    ReinvestmentOfDividend = FundOrderTypeCode.ReinvestmentOfDividend, // same ordinal as derivation source for type conversions
    
}
