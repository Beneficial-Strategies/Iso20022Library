// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of fee being assessed of the customer for trade executions at an exchange. Applicable for futures markets only at this time.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a_X1pdp-Ed-ak6NoX_4Aeg_-358876339")]
[Description(@"Indicates the type of fee being assessed of the customer for trade executions at an exchange. Applicable for futures markets only at this time.")]
[DerivedFrom(typeof(ClearingFeeTypeCode))]
public enum ClearingFeeType1Code
{
    /// <summary>
    /// Member of the Chicago Board Of Exchange.
    /// Encoded/decoded by serializers as &quot;CBOE&quot;.
    /// </summary>
    [EnumMember(Value = "CBOE")]
    [IsoId("_a_X1ptp-Ed-ak6NoX_4Aeg_-26409555")]
    [Description(@"Member of the Chicago Board Of Exchange.")]
    CBOEMember = ClearingFeeTypeCode.CBOEMember, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Non-member and customer.
    /// Encoded/decoded by serializers as &quot;NONM&quot;.
    /// </summary>
    [EnumMember(Value = "NONM")]
    [IsoId("_a_X1p9p-Ed-ak6NoX_4Aeg_-26409537")]
    [Description(@"Non-member and customer.")]
    NonMemberAndCustomer = ClearingFeeTypeCode.NonMemberAndCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Equity member and clearing member.
    /// Encoded/decoded by serializers as &quot;EQCL&quot;.
    /// </summary>
    [EnumMember(Value = "EQCL")]
    [IsoId("_a_X1qNp-Ed-ak6NoX_4Aeg_-26409494")]
    [Description(@"Equity member and clearing member.")]
    EquityClearingMember = ClearingFeeTypeCode.EquityClearingMember, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Full and associate member trading for own account and as floor brokers.
    /// Encoded/decoded by serializers as &quot;FUAS&quot;.
    /// </summary>
    [EnumMember(Value = "FUAS")]
    [IsoId("_a_X1qdp-Ed-ak6NoX_4Aeg_-26409234")]
    [Description(@"Full and associate member trading for own account and as floor brokers.")]
    FullAssociateMember = ClearingFeeTypeCode.FullAssociateMember, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// 106.J and 106.H Firms.
    /// Encoded/decoded by serializers as &quot;JANF&quot;.
    /// </summary>
    [EnumMember(Value = "JANF")]
    [IsoId("_a_g_kNp-Ed-ak6NoX_4Aeg_-26409199")]
    [Description(@"106.J and 106.H Firms.")]
    J106AndHFirms = ClearingFeeTypeCode.J106AndHFirms, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// GIM, IDEM and COM Membership Interest Holders.
    /// Encoded/decoded by serializers as &quot;GICI&quot;.
    /// </summary>
    [EnumMember(Value = "GICI")]
    [IsoId("_a_g_kdp-Ed-ak6NoX_4Aeg_-26409164")]
    [Description(@"GIM, IDEM and COM Membership Interest Holders.")]
    GICInterestHolders = ClearingFeeTypeCode.GICInterestHolders, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Lessee and 106.F Employees.
    /// Encoded/decoded by serializers as &quot;LESF&quot;.
    /// </summary>
    [EnumMember(Value = "LESF")]
    [IsoId("_a_g_ktp-Ed-ak6NoX_4Aeg_-26409104")]
    [Description(@"Lessee and 106.F Employees.")]
    LesseeAnd106FFirms = ClearingFeeTypeCode.LesseeAnd106FFirms, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Miscellaneous type of clearing membership.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_a_g_k9p-Ed-ak6NoX_4Aeg_-26409062")]
    [Description(@"Miscellaneous type of clearing membership.")]
    OtherOwnershipTypes = ClearingFeeTypeCode.OtherOwnershipTypes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// First year delegate trading for his own account.
    /// Encoded/decoded by serializers as &quot;YTR1&quot;.
    /// </summary>
    [EnumMember(Value = "YTR1")]
    [IsoId("_a_g_lNp-Ed-ak6NoX_4Aeg_-26408779")]
    [Description(@"First year delegate trading for his own account.")]
    FirstYearOwnAccount = ClearingFeeTypeCode.FirstYearOwnAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Second year delegate trading for his own account.
    /// Encoded/decoded by serializers as &quot;YTR2&quot;.
    /// </summary>
    [EnumMember(Value = "YTR2")]
    [IsoId("_a_g_ldp-Ed-ak6NoX_4Aeg_-26408719")]
    [Description(@"Second year delegate trading for his own account.")]
    SecondYearOwnAccount = ClearingFeeTypeCode.SecondYearOwnAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Third year delegate trading for his own account.
    /// Encoded/decoded by serializers as &quot;YTR3&quot;.
    /// </summary>
    [EnumMember(Value = "YTR3")]
    [IsoId("_a_g_ltp-Ed-ak6NoX_4Aeg_-26408676")]
    [Description(@"Third year delegate trading for his own account.")]
    ThirdYearOwnAccount = ClearingFeeTypeCode.ThirdYearOwnAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fourth year delegate trading for his own account.
    /// Encoded/decoded by serializers as &quot;YTR4&quot;.
    /// </summary>
    [EnumMember(Value = "YTR4")]
    [IsoId("_a_g_l9p-Ed-ak6NoX_4Aeg_-26408659")]
    [Description(@"Fourth year delegate trading for his own account.")]
    FourthYearOwnAccount = ClearingFeeTypeCode.FourthYearOwnAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fifth year delegate trading for his own account.
    /// Encoded/decoded by serializers as &quot;YTR5&quot;.
    /// </summary>
    [EnumMember(Value = "YTR5")]
    [IsoId("_a_g_mNp-Ed-ak6NoX_4Aeg_-26408641")]
    [Description(@"Fifth year delegate trading for his own account.")]
    FifthYearOwnAccount = ClearingFeeTypeCode.FifthYearOwnAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sixth year and beyond delegate trading for his own account.
    /// Encoded/decoded by serializers as &quot;NYTR&quot;.
    /// </summary>
    [EnumMember(Value = "NYTR")]
    [IsoId("_a_g_mdp-Ed-ak6NoX_4Aeg_-26408624")]
    [Description(@"Sixth year and beyond delegate trading for his own account.")]
    MoreThanFiveYearOwnAccount = ClearingFeeTypeCode.MoreThanFiveYearOwnAccount, // same ordinal as derivation source for type conversions
    
}
