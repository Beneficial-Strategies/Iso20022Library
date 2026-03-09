// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investment fund transaction that results in a cash movement into a fund.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ViO3iNp-Ed-ak6NoX_4Aeg_-1481228379")]
[Description(@"Specifies the type of investment fund transaction that results in a cash movement into a fund.")]
[DerivedFrom(typeof(InvestmentFundTransactionTypeCode))]
public enum InvestmentFundTransactionInType3Code
{
    /// <summary>
    /// Transaction is a subscription to an investment fund.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_ViO3idp-Ed-ak6NoX_4Aeg_-936351208")]
    [Description(@"Transaction is a subscription to an investment fund.")]
    Subscription = InvestmentFundTransactionTypeCode.Subscription, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a subscription leg of a switch order execution.
    /// Encoded/decoded by serializers as &quot;SWII&quot;.
    /// </summary>
    [EnumMember(Value = "SWII")]
    [IsoId("_ViYogNp-Ed-ak6NoX_4Aeg_-921572438")]
    [Description(@"Transaction is a subscription leg of a switch order execution.")]
    SwitchIn = InvestmentFundTransactionTypeCode.SwitchIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is an InSpecie.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_ViYogdp-Ed-ak6NoX_4Aeg_-1939231322")]
    [Description(@"Transaction is an InSpecie.")]
    InSpecie = InvestmentFundTransactionTypeCode.InSpecie, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a cross-in.
    /// Encoded/decoded by serializers as &quot;CROI&quot;.
    /// </summary>
    [EnumMember(Value = "CROI")]
    [IsoId("_ViYogtp-Ed-ak6NoX_4Aeg_-1929071750")]
    [Description(@"Transaction is a cross-in.")]
    CrossIn = InvestmentFundTransactionTypeCode.CrossIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is another type of transaction.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ViYog9p-Ed-ak6NoX_4Aeg_-1909676382")]
    [Description(@"Transaction is another type of transaction.")]
    Other = InvestmentFundTransactionTypeCode.Other, // same ordinal as derivation source for type conversions
    
}
