// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cash account type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_asmDkNp-Ed-ak6NoX_4Aeg_-1053848198")]
[Description(@"Specifies the cash account type.")]
[DerivedFrom(typeof(FundCashAccountCode))]
public enum FundCashAccount2Code
{
    /// <summary>
    /// Cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_asmDkdp-Ed-ak6NoX_4Aeg_-1052927881")]
    [Description(@"Cash account.")]
    CashAccount = FundCashAccountCode.CashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Central Provident Fund (CPF) ordinary account.
    /// Encoded/decoded by serializers as &quot;CPFO&quot;.
    /// </summary>
    [EnumMember(Value = "CPFO")]
    [IsoId("_asmDktp-Ed-ak6NoX_4Aeg_-1052926597")]
    [Description(@"Central Provident Fund (CPF) ordinary account.")]
    PensionFundOrdinary = FundCashAccountCode.PensionFundOrdinary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Central Provident Fund (CPF) special account.
    /// Encoded/decoded by serializers as &quot;CPFS&quot;.
    /// </summary>
    [EnumMember(Value = "CPFS")]
    [IsoId("_asmDk9p-Ed-ak6NoX_4Aeg_-1052926493")]
    [Description(@"Central Provident Fund (CPF) special account.")]
    PensionFundSpecial = FundCashAccountCode.PensionFundSpecial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Supplementary Retirement Scheme (SRS) account.
    /// Encoded/decoded by serializers as &quot;SRSA&quot;.
    /// </summary>
    [EnumMember(Value = "SRSA")]
    [IsoId("_asmDlNp-Ed-ak6NoX_4Aeg_-1052926150")]
    [Description(@"Supplementary Retirement Scheme (SRS) account.")]
    RetirementScheme = FundCashAccountCode.RetirementScheme, // same ordinal as derivation source for type conversions
    
}
