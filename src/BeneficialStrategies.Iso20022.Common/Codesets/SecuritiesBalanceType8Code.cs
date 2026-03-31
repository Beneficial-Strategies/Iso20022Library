// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZCy0MNp-Ed-ak6NoX_4Aeg_-2122701113")]
[Description(@"Specifies the nature of the securities or investment fund balance.")]
[DerivedFrom(typeof(SecuritiesBalanceTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SecuritiesBalanceType8Code>))]
#endif
public enum SecuritiesBalanceType8Code
{
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// Encoded/decoded by serializers as &quot;BLOK&quot;.
    /// </summary>
    [EnumMember(Value = "BLOK")]
    [IsoId("_ZCy0Mdp-Ed-ak6NoX_4Aeg_-2122701094")]
    [Description(@"Balance of financial instruments that are blocked.")]
    Blocked = SecuritiesBalanceTypeV2Code.Blocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are freely available with no specific additional status.
    /// Encoded/decoded by serializers as &quot;AWAS&quot;.
    /// </summary>
    [EnumMember(Value = "AWAS")]
    [IsoId("_ZCy0Mtp-Ed-ak6NoX_4Aeg_-2122701093")]
    [Description(
        @"Balance of financial instruments that are freely available with no specific additional status."
    )]
    AvailableWithNoAdditionalStatus = SecuritiesBalanceTypeV2Code.AvailableWithNoAdditionalStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are available.
    /// Encoded/decoded by serializers as &quot;AVAI&quot;.
    /// </summary>
    [EnumMember(Value = "AVAI")]
    [IsoId("_ZCy0M9p-Ed-ak6NoX_4Aeg_-1711733881")]
    [Description(@"Balance of financial instruments that are available.")]
    Available = SecuritiesBalanceTypeV2Code.Available, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are registered (in nominee name or in the name of the beneficial owner).
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_ZCy0NNp-Ed-ak6NoX_4Aeg_-1665556498")]
    [Description(
        @"Balance of financial instruments that are registered (in nominee name or in the name of the beneficial owner)."
    )]
    Registered = SecuritiesBalanceTypeV2Code.Registered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged.
    /// Encoded/decoded by serializers as &quot;PLED&quot;.
    /// </summary>
    [EnumMember(Value = "PLED")]
    [IsoId("_ZCy0Ndp-Ed-ak6NoX_4Aeg_-2122700380")]
    [Description(
        @"Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged."
    )]
    Pledged = SecuritiesBalanceTypeV2Code.Pledged, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// Encoded/decoded by serializers as &quot;REGO&quot;.
    /// </summary>
    [EnumMember(Value = "REGO")]
    [IsoId("_ZCy0Ntp-Ed-ak6NoX_4Aeg_-2122700379")]
    [Description(
        @"Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee)."
    )]
    OutForRegistration = SecuritiesBalanceTypeV2Code.OutForRegistration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that may only be sold under certain conditions or require legal documents.
    /// Encoded/decoded by serializers as &quot;RSTR&quot;.
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_ZCy0N9p-Ed-ak6NoX_4Aeg_-2122700355")]
    [Description(
        @"Balance of financial instruments that may only be sold under certain conditions or require legal documents."
    )]
    Restricted = SecuritiesBalanceTypeV2Code.Restricted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZCy0ONp-Ed-ak6NoX_4Aeg_-2122700354")]
    [Description(@"Other. See Narrative.")]
    Unclassified = SecuritiesBalanceTypeV2Code.Unclassified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been generated due to transformation following a corporate action.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ZCy0Odp-Ed-ak6NoX_4Aeg_-2122700338")]
    [Description(
        @"Transaction has been generated due to transformation following a corporate action."
    )]
    InTransshipment = SecuritiesBalanceTypeV2Code.InTransshipment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_ZC8lMNp-Ed-ak6NoX_4Aeg_-2122700337")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn = SecuritiesBalanceTypeV2Code.Drawn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order.
    /// Encoded/decoded by serializers as &quot;WDOC&quot;.
    /// </summary>
    [EnumMember(Value = "WDOC")]
    [IsoId("_ZC8lMdp-Ed-ak6NoX_4Aeg_-2122700336")]
    [Description(
        @"Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order."
    )]
    WaitingDocumentation = SecuritiesBalanceTypeV2Code.WaitingDocumentation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders&apos; register.
    /// Encoded/decoded by serializers as &quot;BTRA&quot;.
    /// </summary>
    [EnumMember(Value = "BTRA")]
    [IsoId("_ZC8lMtp-Ed-ak6NoX_4Aeg_-2122700320")]
    [Description(
        @"Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders' register."
    )]
    BeingTransferred = SecuritiesBalanceTypeV2Code.BeingTransferred, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// Encoded/decoded by serializers as &quot;SPOS&quot;.
    /// </summary>
    [EnumMember(Value = "SPOS")]
    [IsoId("_ZC8lM9p-Ed-ak6NoX_4Aeg_-1607375140")]
    [Description(
        @"Balance of financial instruments that remain registered in the name of the prior beneficial owner."
    )]
    StreetPosition = SecuritiesBalanceTypeV2Code.StreetPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that could not be registered due to foreign ownership limitation.
    /// Encoded/decoded by serializers as &quot;UNRG&quot;.
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_ZC8lNNp-Ed-ak6NoX_4Aeg_-1565819079")]
    [Description(
        @"Balance of securities that could not be registered due to foreign ownership limitation."
    )]
    Unregistered = SecuritiesBalanceTypeV2Code.Unregistered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has been received.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_ZC8lNdp-Ed-ak6NoX_4Aeg_20264378")]
    [Description(
        @"In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has been received."
    )]
    Issued = SecuritiesBalanceTypeV2Code.Issued, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has not yet been received.
    /// Encoded/decoded by serializers as &quot;QUAS&quot;.
    /// </summary>
    [EnumMember(Value = "QUAS")]
    [IsoId("_ZC8lNtp-Ed-ak6NoX_4Aeg_20264655")]
    [Description(
        @"In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has not yet been received."
    )]
    QuasiIssued = SecuritiesBalanceTypeV2Code.QuasiIssued, // same ordinal as derivation source for type conversions
}
