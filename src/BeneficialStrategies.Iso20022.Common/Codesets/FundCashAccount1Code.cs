// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cash account type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Virjctp-Ed-ak6NoX_4Aeg_1769080400")]
[Description(@"Specifies the cash account type.")]
[DerivedFrom(typeof(FundCashAccountCode))]
public enum FundCashAccount1Code
{
    /// <summary>
    /// Cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_Virjc9p-Ed-ak6NoX_4Aeg_-2028108164")]
    [Description(@"Cash account.")]
    CashAccount = FundCashAccountCode.CashAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central Provident Fund (CPF) ordinary account.
    /// Encoded/decoded by serializers as &quot;CPFO&quot;.
    /// </summary>
    [EnumMember(Value = "CPFO")]
    [IsoId("_VirjdNp-Ed-ak6NoX_4Aeg_-2028108147")]
    [Description(@"Central Provident Fund (CPF) ordinary account.")]
    PensionFundOrdinary = FundCashAccountCode.PensionFundOrdinary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central Provident Fund (CPF) special account.
    /// Encoded/decoded by serializers as &quot;CPFS&quot;.
    /// </summary>
    [EnumMember(Value = "CPFS")]
    [IsoId("_Virjddp-Ed-ak6NoX_4Aeg_-2028108129")]
    [Description(@"Central Provident Fund (CPF) special account.")]
    PensionFundSpecial = FundCashAccountCode.PensionFundSpecial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Supplementary Retirement Scheme (SRS) account.
    /// Encoded/decoded by serializers as &quot;SRSA&quot;.
    /// </summary>
    [EnumMember(Value = "SRSA")]
    [IsoId("_Virjdtp-Ed-ak6NoX_4Aeg_-2028108104")]
    [Description(@"Supplementary Retirement Scheme (SRS) account.")]
    RetirementScheme = FundCashAccountCode.RetirementScheme, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another type cash account.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Virjd9p-Ed-ak6NoX_4Aeg_-2021642544")]
    [Description(@"Another type cash account.")]
    Other = FundCashAccountCode.Other, // same ordinal as derivation source for type conversions
}
