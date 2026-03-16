// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of securities entry on an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFCP4tp-Ed-ak6NoX_4Aeg_1321594079")]
[Description(@"Specifies the type of securities entry on an account.")]
[DerivedFrom(typeof(SecuritiesEntryTypeCode))]
public enum SecuritiesEntryType2Code
{
    /// <summary>
    /// Balance of securities that are blocked or frozen. A financial instrument may be unavailable due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.
    /// Encoded/decoded by serializers as &quot;BLOK&quot;.
    /// </summary>
    [EnumMember(Value = "BLOK")]
    [IsoId("_ZFCP49p-Ed-ak6NoX_4Aeg_1321594081")]
    [Description(
        @"Balance of securities that are blocked or frozen. A financial instrument may be unavailable due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy."
    )]
    Blocked = SecuritiesEntryTypeCode.Blocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total number of securities eligible for this event.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_ZFCP5Np-Ed-ak6NoX_4Aeg_1321594097")]
    [Description(@"Total number of securities eligible for this event.")]
    Eligible = SecuritiesEntryTypeCode.Eligible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that are pending delivery.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZFCP5dp-Ed-ak6NoX_4Aeg_1321594098")]
    [Description(@"Balance of securities that are pending delivery.")]
    PendingDelivery = SecuritiesEntryTypeCode.PendingDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that are pending receipt.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_ZFCP5tp-Ed-ak6NoX_4Aeg_1321594099")]
    [Description(@"Balance of securities that are pending receipt.")]
    PendingReceipt = SecuritiesEntryTypeCode.PendingReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that are registered (in the name of a nominee or of the beneficial owner).
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_ZFCP59p-Ed-ak6NoX_4Aeg_1321594370")]
    [Description(
        @"Balance of securities that are registered (in the name of a nominee or of the beneficial owner)."
    )]
    Registered = SecuritiesEntryTypeCode.Registered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities representing only settled transactions.
    /// Encoded/decoded by serializers as &quot;SETD&quot;.
    /// </summary>
    [EnumMember(Value = "SETD")]
    [IsoId("_ZFCP6Np-Ed-ak6NoX_4Aeg_1321594387")]
    [Description(@"Balance of securities representing only settled transactions.")]
    Settled = SecuritiesEntryTypeCode.Settled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that have been borrowed from another party.
    /// Encoded/decoded by serializers as &quot;BORR&quot;.
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_ZFCP6dp-Ed-ak6NoX_4Aeg_1321594388")]
    [Description(@"Balance of securities that have been borrowed from another party.")]
    Borrowed = SecuritiesEntryTypeCode.Borrowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that have been loaned to a third party.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_ZFLZ0Np-Ed-ak6NoX_4Aeg_1321594405")]
    [Description(@"Balance of securities that have been loaned to a third party.")]
    OnLoan = SecuritiesEntryTypeCode.OnLoan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that remain registered in the name of the prior beneficial owner of securities.
    /// Encoded/decoded by serializers as &quot;SPOS&quot;.
    /// </summary>
    [EnumMember(Value = "SPOS")]
    [IsoId("_ZFLZ0dp-Ed-ak6NoX_4Aeg_1321594406")]
    [Description(
        @"Balance of securities that remain registered in the name of the prior beneficial owner of securities."
    )]
    StreetPosition = SecuritiesEntryTypeCode.StreetPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities representing traded transactions.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZFLZ0tp-Ed-ak6NoX_4Aeg_1321594407")]
    [Description(@"Balance of securities representing traded transactions.")]
    Traded = SecuritiesEntryTypeCode.Traded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_ZFLZ09p-Ed-ak6NoX_4Aeg_1421332994")]
    [Description(
        @"Balance of securities that belong to a third party and that are held for the purpose of collateralisation."
    )]
    CollateralIn = SecuritiesEntryTypeCode.CollateralIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_ZFLZ1Np-Ed-ak6NoX_4Aeg_1450886956")]
    [Description(
        @"Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation."
    )]
    CollateralOut = SecuritiesEntryTypeCode.CollateralOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of uninstructed position.
    /// Encoded/decoded by serializers as &quot;UNBA&quot;.
    /// </summary>
    [EnumMember(Value = "UNBA")]
    [IsoId("_ZFLZ1dp-Ed-ak6NoX_4Aeg_1462894155")]
    [Description(@"Balance of uninstructed position.")]
    UninstructedBalance = SecuritiesEntryTypeCode.UninstructedBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of instructed position.
    /// Encoded/decoded by serializers as &quot;INBA&quot;.
    /// </summary>
    [EnumMember(Value = "INBA")]
    [IsoId("_ZFLZ1tp-Ed-ak6NoX_4Aeg_1478592079")]
    [Description(@"Balance of instructed position.")]
    InstructedBalance = SecuritiesEntryTypeCode.InstructedBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities currently being processed by the institution responsible for registering the new beneficial owner (or nominee) of securities after a transaction has settled.
    /// Encoded/decoded by serializers as &quot;REGO&quot;.
    /// </summary>
    [EnumMember(Value = "REGO")]
    [IsoId("_ZFLZ19p-Ed-ak6NoX_4Aeg_1504452105")]
    [Description(
        @"Balance of securities currently being processed by the institution responsible for registering the new beneficial owner (or nominee) of securities after a transaction has settled."
    )]
    OutForRegistration = SecuritiesEntryTypeCode.OutForRegistration, // same ordinal as derivation source for type conversions
}
