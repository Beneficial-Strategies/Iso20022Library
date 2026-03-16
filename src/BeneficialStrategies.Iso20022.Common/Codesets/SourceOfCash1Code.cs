// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the origin of cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kWhF0DlHEealR6-8aQ15BA")]
[Description(@"Specifies the origin of cash.")]
[DerivedFrom(typeof(SourceOfCashCode))]
public enum SourceOfCash1Code
{
    /// <summary>
    /// Income as a result of alimony.
    /// Encoded/decoded by serializers as &quot;ALMY&quot;.
    /// </summary>
    [EnumMember(Value = "ALMY")]
    [IsoId("_ml8KwTlHEealR6-8aQ15BA")]
    [Description(@"Income as a result of alimony.")]
    Alimony = SourceOfCashCode.Alimony, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Income is cash proceeds from customers.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_mwDwETlHEealR6-8aQ15BA")]
    [Description(@"Income is cash proceeds from customers.")]
    CashProceeds = SourceOfCashCode.CashProceeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Income is from compensation received.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_mzLVgTlHEealR6-8aQ15BA")]
    [Description(@"Income is from compensation received.")]
    Compensation = SourceOfCashCode.Compensation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Employee income.
    /// Encoded/decoded by serializers as &quot;EMIN&quot;.
    /// </summary>
    [EnumMember(Value = "EMIN")]
    [IsoId("_m9S60TlHEealR6-8aQ15BA")]
    [Description(@"Employee income.")]
    EmployeeIncome = SourceOfCashCode.EmployeeIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Income was a cash gift.
    /// Encoded/decoded by serializers as &quot;GIFT&quot;.
    /// </summary>
    [EnumMember(Value = "GIFT")]
    [IsoId("_nAbHUTlHEealR6-8aQ15BA")]
    [Description(@"Income was a cash gift.")]
    Gift = SourceOfCashCode.Gift, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash from an inheritance.
    /// Encoded/decoded by serializers as &quot;INHE&quot;.
    /// </summary>
    [EnumMember(Value = "INHE")]
    [IsoId("_nKPKoTlHEealR6-8aQ15BA")]
    [Description(@"Cash from an inheritance.")]
    Inheritance = SourceOfCashCode.Inheritance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Income from the liquidation of an insurance premium.
    /// Encoded/decoded by serializers as &quot;INLQ&quot;.
    /// </summary>
    [EnumMember(Value = "INLQ")]
    [IsoId("_nNXXITlHEealR6-8aQ15BA")]
    [Description(@"Income from the liquidation of an insurance premium.")]
    InsurancePremiumLiquidation = SourceOfCashCode.InsurancePremiumLiquidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Income from the sale of real estate.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_nXe8cTlHEealR6-8aQ15BA")]
    [Description(@"Income from the sale of real estate.")]
    RealEstateSale = SourceOfCashCode.RealEstateSale, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Redemption of an investment fund.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_ngtJ4TlHEealR6-8aQ15BA")]
    [Description(@"Redemption of an investment fund.")]
    Redemption = SourceOfCashCode.Redemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Income from a retirement policy.
    /// Encoded/decoded by serializers as &quot;REPY&quot;.
    /// </summary>
    [EnumMember(Value = "REPY")]
    [IsoId("_np7XUTlHEealR6-8aQ15BA")]
    [Description(@"Income from a retirement policy.")]
    RetirementPolicy = SourceOfCashCode.RetirementPolicy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sale and acquisition of a corporation.
    /// Encoded/decoded by serializers as &quot;SEAQ&quot;.
    /// </summary>
    [EnumMember(Value = "SEAQ")]
    [IsoId("_nzJkwTlHEealR6-8aQ15BA")]
    [Description(@"Sale and acquisition of a corporation.")]
    SaleAquisitionCorporation = SourceOfCashCode.SaleAquisitionCorporation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sale of goods.
    /// Encoded/decoded by serializers as &quot;SALE&quot;.
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_n2biQTlHEealR6-8aQ15BA")]
    [Description(@"Sale of goods.")]
    SaleOfGoods = SourceOfCashCode.SaleOfGoods, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Income from a savings plan.
    /// Encoded/decoded by serializers as &quot;SVGS&quot;.
    /// </summary>
    [EnumMember(Value = "SVGS")]
    [IsoId("_oAiggTlHEealR6-8aQ15BA")]
    [Description(@"Income from a savings plan.")]
    Savings = SourceOfCashCode.Savings, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Income from self-employment.
    /// Encoded/decoded by serializers as &quot;SELF&quot;.
    /// </summary>
    [EnumMember(Value = "SELF")]
    [IsoId("_oDqtATlHEealR6-8aQ15BA")]
    [Description(@"Income from self-employment.")]
    SelfEmploymentIncome = SourceOfCashCode.SelfEmploymentIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Income from a cash win.
    /// Encoded/decoded by serializers as &quot;WINS&quot;.
    /// </summary>
    [EnumMember(Value = "WINS")]
    [IsoId("_oMvwgTlHEealR6-8aQ15BA")]
    [Description(@"Income from a cash win.")]
    Winnings = SourceOfCashCode.Winnings, // same ordinal as derivation source for type conversions
}
