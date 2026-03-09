// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZCpqQNp-Ed-ak6NoX_4Aeg_1990824949")]
[Description(@"Specifies the nature of the securities or investment fund balance.")]
[DerivedFrom(typeof(SecuritiesBalanceTypeV2Code))]
public enum SecuritiesBalanceType7Code
{
    /// <summary>
    /// Balance of securities that are eligible for use for collateral purposes.
    /// Encoded/decoded by serializers as &quot;COLA&quot;.
    /// </summary>
    [EnumMember(Value = "COLA")]
    [IsoId("_ZCpqQdp-Ed-ak6NoX_4Aeg_1990825070")]
    [Description(@"Balance of securities that are eligible for use for collateral purposes.")]
    EligibleForCollateralPurposes = SecuritiesBalanceTypeV2Code.EligibleForCollateralPurposes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZCpqQtp-Ed-ak6NoX_4Aeg_1990825425")]
    [Description(@"Other. See Narrative.")]
    Unclassified = SecuritiesBalanceTypeV2Code.Unclassified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax-exempt financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_ZCpqQ9p-Ed-ak6NoX_4Aeg_1990825442")]
    [Description(@"Tax-exempt financial instruments are to be settled.")]
    TaxExempt = SecuritiesBalanceTypeV2Code.TaxExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Taxable financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_ZCpqRNp-Ed-ak6NoX_4Aeg_1990825476")]
    [Description(@"Taxable financial instruments are to be settled.")]
    NonTaxExempt = SecuritiesBalanceTypeV2Code.NonTaxExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instruments that are registered (in nominee name or in the name of the beneficial owner).
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_ZCpqRdp-Ed-ak6NoX_4Aeg_1990825477")]
    [Description(@"Balance of financial instruments that are registered (in nominee name or in the name of the beneficial owner).")]
    Registered = SecuritiesBalanceTypeV2Code.Registered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// Encoded/decoded by serializers as &quot;SPOS&quot;.
    /// </summary>
    [EnumMember(Value = "SPOS")]
    [IsoId("_ZCpqRtp-Ed-ak6NoX_4Aeg_1990825494")]
    [Description(@"Balance of financial instruments that remain registered in the name of the prior beneficial owner.")]
    StreetPosition = SecuritiesBalanceTypeV2Code.StreetPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities that could not be registered due to foreign ownership limitation.
    /// Encoded/decoded by serializers as &quot;UNRG&quot;.
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_ZCpqR9p-Ed-ak6NoX_4Aeg_1990825495")]
    [Description(@"Balance of securities that could not be registered due to foreign ownership limitation.")]
    Unregistered = SecuritiesBalanceTypeV2Code.Unregistered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has been received.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_ZCpqSNp-Ed-ak6NoX_4Aeg_-740716487")]
    [Description(@"In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has been received.")]
    Issued = SecuritiesBalanceTypeV2Code.Issued, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has not yet been received.
    /// Encoded/decoded by serializers as &quot;QUAS&quot;.
    /// </summary>
    [EnumMember(Value = "QUAS")]
    [IsoId("_ZCpqSdp-Ed-ak6NoX_4Aeg_-740716214")]
    [Description(@"In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has not yet been received.")]
    QuasiIssued = SecuritiesBalanceTypeV2Code.QuasiIssued, // same ordinal as derivation source for type conversions
    
}
