// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZAHTo9p-Ed-ak6NoX_4Aeg_-409844332")]
[Description(@"Specifies the nature of the securities or investment fund balance.")]
[DerivedFrom(typeof(SecuritiesBalanceTypeV2Code))]
public enum SecuritiesBalanceType13Code
{
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// Encoded/decoded by serializers as &quot;BLOK&quot;.
    /// </summary>
    [EnumMember(Value = "BLOK")]
    [IsoId("_ZAHTpNp-Ed-ak6NoX_4Aeg_1235423103")]
    [Description(@"Balance of financial instruments that are blocked.")]
    Blocked = SecuritiesBalanceTypeV2Code.Blocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are freely available with no specific additional status.
    /// Encoded/decoded by serializers as &quot;AWAS&quot;.
    /// </summary>
    [EnumMember(Value = "AWAS")]
    [IsoId("_ZAHTpdp-Ed-ak6NoX_4Aeg_-1406916685")]
    [Description(
        @"Balance of financial instruments that are freely available with no specific additional status."
    )]
    AvailableWithNoAdditionalStatus = SecuritiesBalanceTypeV2Code.AvailableWithNoAdditionalStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are available.
    /// Encoded/decoded by serializers as &quot;AVAI&quot;.
    /// </summary>
    [EnumMember(Value = "AVAI")]
    [IsoId("_ZAHTptp-Ed-ak6NoX_4Aeg_-1698874423")]
    [Description(@"Balance of financial instruments that are available.")]
    Available = SecuritiesBalanceTypeV2Code.Available, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are registered (in nominee name or in the name of the beneficial owner).
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_ZAHTp9p-Ed-ak6NoX_4Aeg_-1520755751")]
    [Description(
        @"Balance of financial instruments that are registered (in nominee name or in the name of the beneficial owner)."
    )]
    Registered = SecuritiesBalanceTypeV2Code.Registered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged.
    /// Encoded/decoded by serializers as &quot;PLED&quot;.
    /// </summary>
    [EnumMember(Value = "PLED")]
    [IsoId("_ZAHTqNp-Ed-ak6NoX_4Aeg_238350750")]
    [Description(
        @"Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged."
    )]
    Pledged = SecuritiesBalanceTypeV2Code.Pledged, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// Encoded/decoded by serializers as &quot;REGO&quot;.
    /// </summary>
    [EnumMember(Value = "REGO")]
    [IsoId("_ZAHTqdp-Ed-ak6NoX_4Aeg_203511436")]
    [Description(
        @"Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee)."
    )]
    OutForRegistration = SecuritiesBalanceTypeV2Code.OutForRegistration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that may only be sold under certain conditions or require legal documents.
    /// Encoded/decoded by serializers as &quot;RSTR&quot;.
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_ZAREoNp-Ed-ak6NoX_4Aeg_-88446302")]
    [Description(
        @"Balance of financial instruments that may only be sold under certain conditions or require legal documents."
    )]
    Restricted = SecuritiesBalanceTypeV2Code.Restricted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZAREodp-Ed-ak6NoX_4Aeg_89672370")]
    [Description(@"Other. See Narrative.")]
    Unclassified = SecuritiesBalanceTypeV2Code.Unclassified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// Encoded/decoded by serializers as &quot;SPOS&quot;.
    /// </summary>
    [EnumMember(Value = "SPOS")]
    [IsoId("_ZAREotp-Ed-ak6NoX_4Aeg_851706518")]
    [Description(
        @"Balance of financial instruments that remain registered in the name of the prior beneficial owner."
    )]
    StreetPosition = SecuritiesBalanceTypeV2Code.StreetPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that could not be registered due to foreign ownership limitation.
    /// Encoded/decoded by serializers as &quot;UNRG&quot;.
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_ZAREo9p-Ed-ak6NoX_4Aeg_-1790633270")]
    [Description(
        @"Balance of securities that could not be registered due to foreign ownership limitation."
    )]
    Unregistered = SecuritiesBalanceTypeV2Code.Unregistered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has been received.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_ZAREpNp-Ed-ak6NoX_4Aeg_-2082591008")]
    [Description(
        @"In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has been received."
    )]
    Issued = SecuritiesBalanceTypeV2Code.Issued, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has not yet been received.
    /// Encoded/decoded by serializers as &quot;QUAS&quot;.
    /// </summary>
    [EnumMember(Value = "QUAS")]
    [IsoId("_ZAREpdp-Ed-ak6NoX_4Aeg_-1904472336")]
    [Description(
        @"In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has not yet been received."
    )]
    QuasiIssued = SecuritiesBalanceTypeV2Code.QuasiIssued, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that are eligible for use for collateral purposes.
    /// Encoded/decoded by serializers as &quot;COLA&quot;.
    /// </summary>
    [EnumMember(Value = "COLA")]
    [IsoId("_ZAREptp-Ed-ak6NoX_4Aeg_875091232")]
    [Description(@"Balance of securities that are eligible for use for collateral purposes.")]
    EligibleForCollateralPurposes = SecuritiesBalanceTypeV2Code.EligibleForCollateralPurposes, // same ordinal as derivation source for type conversions
}
