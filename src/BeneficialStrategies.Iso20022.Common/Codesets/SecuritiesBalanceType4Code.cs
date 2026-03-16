// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZB5cUtp-Ed-ak6NoX_4Aeg_-666523957")]
[Description(@"Specifies the nature of the securities or investment fund balance.")]
[DerivedFrom(typeof(SecuritiesBalanceTypeCode))]
public enum SecuritiesBalanceType4Code
{
    /// <summary>
    /// Balance of tax-exempt securities.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_ZB5cU9p-Ed-ak6NoX_4Aeg_-1960973135")]
    [Description(@"Balance of tax-exempt securities.")]
    TaxExempt = SecuritiesBalanceTypeCode.TaxExempt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of taxable securities.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_ZB5cVNp-Ed-ak6NoX_4Aeg_-1960973134")]
    [Description(@"Balance of taxable securities.")]
    NonTaxExempt = SecuritiesBalanceTypeCode.NonTaxExempt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that are registered (in the name of a nominee or of the beneficial owner).
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_ZB5cVdp-Ed-ak6NoX_4Aeg_-1960973105")]
    [Description(
        @"Balance of securities that are registered (in the name of a nominee or of the beneficial owner)."
    )]
    Registered = SecuritiesBalanceTypeCode.Registered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZB5cVtp-Ed-ak6NoX_4Aeg_-1960973104")]
    [Description(
        @"Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types."
    )]
    Unclassified = SecuritiesBalanceTypeCode.Unclassified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that remain registered in the name of the prior beneficial owner of securities.
    /// Encoded/decoded by serializers as &quot;SPOS&quot;.
    /// </summary>
    [EnumMember(Value = "SPOS")]
    [IsoId("_ZB5cV9p-Ed-ak6NoX_4Aeg_-1960973074")]
    [Description(
        @"Balance of securities that remain registered in the name of the prior beneficial owner of securities."
    )]
    StreetPosition = SecuritiesBalanceTypeCode.StreetPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that could not be registered due to foreign ownership limitation.
    /// Encoded/decoded by serializers as &quot;UNRG&quot;.
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_ZB5cWNp-Ed-ak6NoX_4Aeg_-1960973043")]
    [Description(
        @"Balance of securities that could not be registered due to foreign ownership limitation."
    )]
    Unregistered = SecuritiesBalanceTypeCode.Unregistered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order contains a side pocket component.
    /// Encoded/decoded by serializers as &quot;SPCM&quot;.
    /// </summary>
    [EnumMember(Value = "SPCM")]
    [IsoId("_ZB5cWdp-Ed-ak6NoX_4Aeg_-1956354582")]
    [Description(@"Investment fund order contains a side pocket component.")]
    SidePocketComponent = SecuritiesBalanceTypeCode.SidePocketComponent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order execution subject to redemption proceeds.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_ZCDNUNp-Ed-ak6NoX_4Aeg_-1313586291")]
    [Description(@"Investment fund order execution subject to redemption proceeds.")]
    Holdback = SecuritiesBalanceTypeCode.Holdback, // same ordinal as derivation source for type conversions
}
