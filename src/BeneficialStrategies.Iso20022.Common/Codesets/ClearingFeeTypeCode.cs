// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of fee being assessed of the customer for trade executions at an exchange. Applicable for futures markets only at this time.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a_qwkNp-Ed-ak6NoX_4Aeg_335335694")]
[Description(
    @"Indicates the type of fee being assessed of the customer for trade executions at an exchange. Applicable for futures markets only at this time."
)]
[Derivations(typeof(ClearingFeeType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ClearingFeeTypeCode>))]
#endif
public enum ClearingFeeTypeCode
{
    /// <summary>
    /// Member of the Chicago Board Of Exchange.
    /// Encoded/decoded by serializers as &quot;CBOE&quot;.
    /// </summary>
    [EnumMember(Value = "CBOE")]
    [IsoId("_a_qwkdp-Ed-ak6NoX_4Aeg_335335695")]
    [Description(@"Member of the Chicago Board Of Exchange.")]
    CBOEMember,

    /// <summary>
    /// Non-member and customer.
    /// Encoded/decoded by serializers as &quot;NONM&quot;.
    /// </summary>
    [EnumMember(Value = "NONM")]
    [IsoId("_a_qwktp-Ed-ak6NoX_4Aeg_335335696")]
    [Description(@"Non-member and customer.")]
    NonMemberAndCustomer,

    /// <summary>
    /// Equity member and clearing member.
    /// Encoded/decoded by serializers as &quot;EQCL&quot;.
    /// </summary>
    [EnumMember(Value = "EQCL")]
    [IsoId("_a_qwk9p-Ed-ak6NoX_4Aeg_335335697")]
    [Description(@"Equity member and clearing member.")]
    EquityClearingMember,

    /// <summary>
    /// Full and associate member trading for own account and as floor brokers.
    /// Encoded/decoded by serializers as &quot;FUAS&quot;.
    /// </summary>
    [EnumMember(Value = "FUAS")]
    [IsoId("_a_qwlNp-Ed-ak6NoX_4Aeg_335335698")]
    [Description(@"Full and associate member trading for own account and as floor brokers.")]
    FullAssociateMember,

    /// <summary>
    /// 106.J and 106.H Firms.
    /// Encoded/decoded by serializers as &quot;JANF&quot;.
    /// </summary>
    [EnumMember(Value = "JANF")]
    [IsoId("_a_qwldp-Ed-ak6NoX_4Aeg_335335699")]
    [Description(@"106.J and 106.H Firms.")]
    J106AndHFirms,

    /// <summary>
    /// GIM, IDEM and COM Membership Interest Holders.
    /// Encoded/decoded by serializers as &quot;GICI&quot;.
    /// </summary>
    [EnumMember(Value = "GICI")]
    [IsoId("_a_qwltp-Ed-ak6NoX_4Aeg_335335700")]
    [Description(@"GIM, IDEM and COM Membership Interest Holders.")]
    GICInterestHolders,

    /// <summary>
    /// Lessee and 106.F Employees.
    /// Encoded/decoded by serializers as &quot;LESF&quot;.
    /// </summary>
    [EnumMember(Value = "LESF")]
    [IsoId("_a_qwl9p-Ed-ak6NoX_4Aeg_335335701")]
    [Description(@"Lessee and 106.F Employees.")]
    LesseeAnd106FFirms,

    /// <summary>
    /// Miscellaneous type of clearing membership.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_a_qwmNp-Ed-ak6NoX_4Aeg_335335702")]
    [Description(@"Miscellaneous type of clearing membership.")]
    OtherOwnershipTypes,

    /// <summary>
    /// First year delegate trading for his own account.
    /// Encoded/decoded by serializers as &quot;YTR1&quot;.
    /// </summary>
    [EnumMember(Value = "YTR1")]
    [IsoId("_a_qwmdp-Ed-ak6NoX_4Aeg_335335703")]
    [Description(@"First year delegate trading for his own account.")]
    FirstYearOwnAccount,

    /// <summary>
    /// Second year delegate trading for his own account.
    /// Encoded/decoded by serializers as &quot;YTR2&quot;.
    /// </summary>
    [EnumMember(Value = "YTR2")]
    [IsoId("_a_0hkNp-Ed-ak6NoX_4Aeg_335335711")]
    [Description(@"Second year delegate trading for his own account.")]
    SecondYearOwnAccount,

    /// <summary>
    /// Third year delegate trading for his own account.
    /// Encoded/decoded by serializers as &quot;YTR3&quot;.
    /// </summary>
    [EnumMember(Value = "YTR3")]
    [IsoId("_a_0hkdp-Ed-ak6NoX_4Aeg_335335712")]
    [Description(@"Third year delegate trading for his own account.")]
    ThirdYearOwnAccount,

    /// <summary>
    /// Fourth year delegate trading for his own account.
    /// Encoded/decoded by serializers as &quot;YTR4&quot;.
    /// </summary>
    [EnumMember(Value = "YTR4")]
    [IsoId("_a_0hktp-Ed-ak6NoX_4Aeg_335335713")]
    [Description(@"Fourth year delegate trading for his own account.")]
    FourthYearOwnAccount,

    /// <summary>
    /// Fifth year delegate trading for his own account.
    /// Encoded/decoded by serializers as &quot;YTR5&quot;.
    /// </summary>
    [EnumMember(Value = "YTR5")]
    [IsoId("_a_0hk9p-Ed-ak6NoX_4Aeg_335335714")]
    [Description(@"Fifth year delegate trading for his own account.")]
    FifthYearOwnAccount,

    /// <summary>
    /// Sixth year and beyond delegate trading for his own account.
    /// Encoded/decoded by serializers as &quot;NYTR&quot;.
    /// </summary>
    [EnumMember(Value = "NYTR")]
    [IsoId("_a_0hlNp-Ed-ak6NoX_4Aeg_335335715")]
    [Description(@"Sixth year and beyond delegate trading for his own account.")]
    MoreThanFiveYearOwnAccount,
}
