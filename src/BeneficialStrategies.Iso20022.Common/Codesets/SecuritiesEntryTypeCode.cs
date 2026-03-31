// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of securities entry on an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFLZ2Np-Ed-ak6NoX_4Aeg_1201325476")]
[Description(@"Specifies the type of securities entry on an account.")]
[Derivations(typeof(SecuritiesEntryType2Code), typeof(SecuritiesEntryType3Code))]
public enum SecuritiesEntryTypeCode
{
    /// <summary>
    /// Balance of securities that are blocked or frozen. A financial instrument may be unavailable due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.
    /// Encoded/decoded by serializers as &quot;BLOK&quot;.
    /// </summary>
    [EnumMember(Value = "BLOK")]
    [IsoId("_ZFLZ2dp-Ed-ak6NoX_4Aeg_1484848859")]
    [Description(
        @"Balance of securities that are blocked or frozen. A financial instrument may be unavailable due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy."
    )]
    Blocked,

    /// <summary>
    /// Balance of securities that have been borrowed from another party.
    /// Encoded/decoded by serializers as &quot;BORR&quot;.
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_ZFVK0Np-Ed-ak6NoX_4Aeg_1484849383")]
    [Description(@"Balance of securities that have been borrowed from another party.")]
    Borrowed,

    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_ZFVK0dp-Ed-ak6NoX_4Aeg_1484849426")]
    [Description(
        @"Balance of securities that belong to a third party and that are held for the purpose of collateralisation."
    )]
    CollateralIn,

    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_ZFVK0tp-Ed-ak6NoX_4Aeg_1484849443")]
    [Description(
        @"Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation."
    )]
    CollateralOut,

    /// <summary>
    /// Balance of securities that have been loaned to a third party.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_ZFVK09p-Ed-ak6NoX_4Aeg_1484849478")]
    [Description(@"Balance of securities that have been loaned to a third party.")]
    OnLoan,

    /// <summary>
    /// Balance of securities that are pending delivery.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZFVK1Np-Ed-ak6NoX_4Aeg_1485770002")]
    [Description(@"Balance of securities that are pending delivery.")]
    PendingDelivery,

    /// <summary>
    /// Balance of securities that are pending receipt.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_ZFVK1dp-Ed-ak6NoX_4Aeg_1485770072")]
    [Description(@"Balance of securities that are pending receipt.")]
    PendingReceipt,

    /// <summary>
    /// Balance of securities that are pledged, for example, a financial instrument is unavailable because it has been used or given as a guarantee.
    /// Encoded/decoded by serializers as &quot;PLED&quot;.
    /// </summary>
    [EnumMember(Value = "PLED")]
    [IsoId("_ZFVK1tp-Ed-ak6NoX_4Aeg_1485770114")]
    [Description(
        @"Balance of securities that are pledged, for example, a financial instrument is unavailable because it has been used or given as a guarantee."
    )]
    Pledged,

    /// <summary>
    /// Balance of securities currently being processed by the institution responsible for registering the new beneficial owner (or nominee) of securities after a transaction has settled.
    /// Encoded/decoded by serializers as &quot;REGO&quot;.
    /// </summary>
    [EnumMember(Value = "REGO")]
    [IsoId("_ZFVK19p-Ed-ak6NoX_4Aeg_1485770132")]
    [Description(
        @"Balance of securities currently being processed by the institution responsible for registering the new beneficial owner (or nominee) of securities after a transaction has settled."
    )]
    OutForRegistration,

    /// <summary>
    /// Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZFVK2Np-Ed-ak6NoX_4Aeg_1485770469")]
    [Description(
        @"Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types."
    )]
    Unclassified,

    /// <summary>
    /// Balance of physical securities that are in transshipment, eg, in the process of being transferred from one depository or agent to another.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ZFVK2dp-Ed-ak6NoX_4Aeg_1485770529")]
    [Description(
        @"Balance of physical securities that are in transshipment, eg, in the process of being transferred from one depository or agent to another."
    )]
    InTransshipment,

    /// <summary>
    /// Total number of securities eligible for this event.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_ZFeUwNp-Ed-ak6NoX_4Aeg_69749516")]
    [Description(@"Total number of securities eligible for this event.")]
    Eligible,

    /// <summary>
    /// Balance of securities that are registered (in the name of a nominee or of the beneficial owner).
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_ZFeUwdp-Ed-ak6NoX_4Aeg_1485771027")]
    [Description(
        @"Balance of securities that are registered (in the name of a nominee or of the beneficial owner)."
    )]
    Registered,

    /// <summary>
    /// Balance of securities that remain registered in the name of the prior beneficial owner of securities.
    /// Encoded/decoded by serializers as &quot;SPOS&quot;.
    /// </summary>
    [EnumMember(Value = "SPOS")]
    [IsoId("_ZFeUwtp-Ed-ak6NoX_4Aeg_1485771062")]
    [Description(
        @"Balance of securities that remain registered in the name of the prior beneficial owner of securities."
    )]
    StreetPosition,

    /// <summary>
    /// Balance of securities that could not be registered due to foreign ownership limitation.
    /// Encoded/decoded by serializers as &quot;UNRG&quot;.
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_ZFeUw9p-Ed-ak6NoX_4Aeg_1485771356")]
    [Description(
        @"Balance of securities that could not be registered due to foreign ownership limitation."
    )]
    Unregistered,

    /// <summary>
    /// Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order.
    /// Encoded/decoded by serializers as &quot;WDOC&quot;.
    /// </summary>
    [EnumMember(Value = "WDOC")]
    [IsoId("_ZFeUxNp-Ed-ak6NoX_4Aeg_1485771374")]
    [Description(
        @"Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order."
    )]
    WaitingDocumentation,

    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_ZFeUxdp-Ed-ak6NoX_4Aeg_192376952")]
    [Description(
        @"Balance of securities representing only settled transactions; pending transactions not included."
    )]
    SettlementPosition,

    /// <summary>
    /// Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders&apos; register.
    /// Encoded/decoded by serializers as &quot;BTRA&quot;.
    /// </summary>
    [EnumMember(Value = "BTRA")]
    [IsoId("_ZFeUxtp-Ed-ak6NoX_4Aeg_-1524450363")]
    [Description(
        @"Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders' register."
    )]
    BeingTransferred,

    /// <summary>
    /// Balance of securities representing only settled transactions.
    /// Encoded/decoded by serializers as &quot;SETD&quot;.
    /// </summary>
    [EnumMember(Value = "SETD")]
    [IsoId("_ZFeUx9p-Ed-ak6NoX_4Aeg_1818454189")]
    [Description(@"Balance of securities representing only settled transactions.")]
    Settled,

    /// <summary>
    /// Balance of securities representing traded transactions.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZFeUyNp-Ed-ak6NoX_4Aeg_-2044304370")]
    [Description(@"Balance of securities representing traded transactions.")]
    Traded,

    /// <summary>
    /// Balance of uninstructed position.
    /// Encoded/decoded by serializers as &quot;UNBA&quot;.
    /// </summary>
    [EnumMember(Value = "UNBA")]
    [IsoId("_ZFeUydp-Ed-ak6NoX_4Aeg_-1599881363")]
    [Description(@"Balance of uninstructed position.")]
    UninstructedBalance,

    /// <summary>
    /// Balance of instructed position.
    /// Encoded/decoded by serializers as &quot;INBA&quot;.
    /// </summary>
    [EnumMember(Value = "INBA")]
    [IsoId("_ZFoFwNp-Ed-ak6NoX_4Aeg_-1589721161")]
    [Description(@"Balance of instructed position.")]
    InstructedBalance,
}
