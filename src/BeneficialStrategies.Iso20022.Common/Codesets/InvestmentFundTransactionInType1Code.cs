// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investment fund transaction that results in a cash movement into a fund.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_acpjF9p-Ed-ak6NoX_4Aeg_-159991838")]
[Description(@"Specifies the type of investment fund transaction that results in a cash movement into a fund.")]
[DerivedFrom(typeof(InvestmentFundTransactionTypeCode))]
public enum InvestmentFundTransactionInType1Code
{
    /// <summary>
    /// Transaction is a subscription to an investment fund.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_acpjGNp-Ed-ak6NoX_4Aeg_99517208")]
    [Description(@"Transaction is a subscription to an investment fund.")]
    Subscription = InvestmentFundTransactionTypeCode.Subscription, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a subscription leg of a switch order execution.
    /// Encoded/decoded by serializers as &quot;SWII&quot;.
    /// </summary>
    [EnumMember(Value = "SWII")]
    [IsoId("_acpjGdp-Ed-ak6NoX_4Aeg_99517562")]
    [Description(@"Transaction is a subscription leg of a switch order execution.")]
    SwitchIn = InvestmentFundTransactionTypeCode.SwitchIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is an InSpecie.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_aczUENp-Ed-ak6NoX_4Aeg_100437611")]
    [Description(@"Transaction is an InSpecie.")]
    InSpecie = InvestmentFundTransactionTypeCode.InSpecie, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a cross-in.
    /// Encoded/decoded by serializers as &quot;CROI&quot;.
    /// </summary>
    [EnumMember(Value = "CROI")]
    [IsoId("_aczUEdp-Ed-ak6NoX_4Aeg_100437629")]
    [Description(@"Transaction is a cross-in.")]
    CrossIn = InvestmentFundTransactionTypeCode.CrossIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a reinvestment of dividend.
    /// Encoded/decoded by serializers as &quot;RDIV&quot;.
    /// </summary>
    [EnumMember(Value = "RDIV")]
    [IsoId("_aczUEtp-Ed-ak6NoX_4Aeg_711808534")]
    [Description(@"Transaction is a reinvestment of dividend.")]
    ReinvestmentOfDividend = InvestmentFundTransactionTypeCode.ReinvestmentOfDividend, // same ordinal as derivation source for type conversions
    
}
