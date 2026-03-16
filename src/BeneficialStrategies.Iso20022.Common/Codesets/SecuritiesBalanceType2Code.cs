// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZBdXcdp-Ed-ak6NoX_4Aeg_1919950094")]
[Description(@"Specifies the nature of the securities or investment fund balance.")]
[DerivedFrom(typeof(SecuritiesBalanceTypeCode))]
public enum SecuritiesBalanceType2Code
{
    /// <summary>
    /// Balance of tax-exempt securities.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_ZBdXctp-Ed-ak6NoX_4Aeg_-1506908875")]
    [Description(@"Balance of tax-exempt securities.")]
    TaxExempt = SecuritiesBalanceTypeCode.TaxExempt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of taxable securities.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_ZBdXc9p-Ed-ak6NoX_4Aeg_-1263096881")]
    [Description(@"Balance of taxable securities.")]
    NonTaxExempt = SecuritiesBalanceTypeCode.NonTaxExempt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that are registered (in the name of a nominee or of the beneficial owner).
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_ZBdXdNp-Ed-ak6NoX_4Aeg_-1164280659")]
    [Description(
        @"Balance of securities that are registered (in the name of a nominee or of the beneficial owner)."
    )]
    Registered = SecuritiesBalanceTypeCode.Registered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZBdXddp-Ed-ak6NoX_4Aeg_-829968446")]
    [Description(
        @"Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types."
    )]
    Unclassified = SecuritiesBalanceTypeCode.Unclassified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that remain registered in the name of the prior beneficial owner of securities.
    /// Encoded/decoded by serializers as &quot;SPOS&quot;.
    /// </summary>
    [EnumMember(Value = "SPOS")]
    [IsoId("_ZBdXdtp-Ed-ak6NoX_4Aeg_1361939833")]
    [Description(
        @"Balance of securities that remain registered in the name of the prior beneficial owner of securities."
    )]
    StreetPosition = SecuritiesBalanceTypeCode.StreetPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that could not be registered due to foreign ownership limitation.
    /// Encoded/decoded by serializers as &quot;UNRG&quot;.
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_ZBdXd9p-Ed-ak6NoX_4Aeg_1680553649")]
    [Description(
        @"Balance of securities that could not be registered due to foreign ownership limitation."
    )]
    Unregistered = SecuritiesBalanceTypeCode.Unregistered, // same ordinal as derivation source for type conversions
}
