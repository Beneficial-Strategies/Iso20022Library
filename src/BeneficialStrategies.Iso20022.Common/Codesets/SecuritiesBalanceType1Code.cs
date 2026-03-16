// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZAREp9p-Ed-ak6NoX_4Aeg_1941736953")]
[Description(@"Specifies the nature of the securities or investment fund balance.")]
[DerivedFrom(typeof(SecuritiesBalanceTypeCode))]
public enum SecuritiesBalanceType1Code
{
    /// <summary>
    /// Balance of securities that are blocked or frozen. A financial instrument may be unavailable due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.
    /// Encoded/decoded by serializers as &quot;BLOK&quot;.
    /// </summary>
    [EnumMember(Value = "BLOK")]
    [IsoId("_ZAREqNp-Ed-ak6NoX_4Aeg_1326405229")]
    [Description(
        @"Balance of securities that are blocked or frozen. A financial instrument may be unavailable due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy."
    )]
    Blocked = SecuritiesBalanceTypeCode.Blocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that have been borrowed from another party.
    /// Encoded/decoded by serializers as &quot;BORR&quot;.
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_ZAREqdp-Ed-ak6NoX_4Aeg_-461203135")]
    [Description(@"Balance of securities that have been borrowed from another party.")]
    Borrowed = SecuritiesBalanceTypeCode.Borrowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_ZAaOkNp-Ed-ak6NoX_4Aeg_-410410414")]
    [Description(
        @"Balance of securities that belong to a third party and that are held for the purpose of collateralisation."
    )]
    CollateralIn = SecuritiesBalanceTypeCode.CollateralIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_ZAaOkdp-Ed-ak6NoX_4Aeg_-320828289")]
    [Description(
        @"Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation."
    )]
    CollateralOut = SecuritiesBalanceTypeCode.CollateralOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that have been loaned to a third party.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_ZAaOktp-Ed-ak6NoX_4Aeg_454930653")]
    [Description(@"Balance of securities that have been loaned to a third party.")]
    OnLoan = SecuritiesBalanceTypeCode.OnLoan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that are used as collateral for derivatives.
    /// Encoded/decoded by serializers as &quot;MARG&quot;.
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_ZAaOk9p-Ed-ak6NoX_4Aeg_579604564")]
    [Description(@"Balance of securities that are used as collateral for derivatives.")]
    DerivativesMargin = SecuritiesBalanceTypeCode.DerivativesMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities pending delivery that have been matched. This is only applicable in a CSD to participant communication.
    /// Encoded/decoded by serializers as &quot;PDMT&quot;.
    /// </summary>
    [EnumMember(Value = "PDMT")]
    [IsoId("_ZAaOlNp-Ed-ak6NoX_4Aeg_623932577")]
    [Description(
        @"Balance of securities pending delivery that have been matched. This is only applicable in a CSD to participant communication."
    )]
    PendingDeliveryMatchedBalance = SecuritiesBalanceTypeCode.PendingDeliveryMatchedBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities pending receipt that have been matched. This is only applicable in a CSD to participant communication.
    /// Encoded/decoded by serializers as &quot;PRMT&quot;.
    /// </summary>
    [EnumMember(Value = "PRMT")]
    [IsoId("_ZAaOldp-Ed-ak6NoX_4Aeg_-61582826")]
    [Description(
        @"Balance of securities pending receipt that have been matched. This is only applicable in a CSD to participant communication."
    )]
    PendingReceiptMatchedBalance = SecuritiesBalanceTypeCode.PendingReceiptMatchedBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities pending receipt that are unmatched. This is only applicable in a CSD to participant communication.
    /// Encoded/decoded by serializers as &quot;PRUM&quot;.
    /// </summary>
    [EnumMember(Value = "PRUM")]
    [IsoId("_ZAaOltp-Ed-ak6NoX_4Aeg_409411469")]
    [Description(
        @"Balance of securities pending receipt that are unmatched. This is only applicable in a CSD to participant communication."
    )]
    PendingReceiptUnmatchedBalance = SecuritiesBalanceTypeCode.PendingReceiptUnmatchedBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities, before ex-date, that are involved in a corporate action (CA). Securities blocked due to a CA, for example, proxi, in escrow, are to be identified in the BLOK sub-balance.
    /// Encoded/decoded by serializers as &quot;PECA&quot;.
    /// </summary>
    [EnumMember(Value = "PECA")]
    [IsoId("_ZAaOl9p-Ed-ak6NoX_4Aeg_824997858")]
    [Description(
        @"Balance of securities, before ex-date, that are involved in a corporate action (CA). Securities blocked due to a CA, for example, proxi, in escrow, are to be identified in the BLOK sub-balance."
    )]
    PendingCorporateAction = SecuritiesBalanceTypeCode.PendingCorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that are pending delivery.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZAaOmNp-Ed-ak6NoX_4Aeg_-1671875543")]
    [Description(@"Balance of securities that are pending delivery.")]
    PendingDelivery = SecuritiesBalanceTypeCode.PendingDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that are pending receipt.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_ZAaOmdp-Ed-ak6NoX_4Aeg_-1606305086")]
    [Description(@"Balance of securities that are pending receipt.")]
    PendingReceipt = SecuritiesBalanceTypeCode.PendingReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that are pledged, for example, a financial instrument is unavailable because it has been used or given as a guarantee.
    /// Encoded/decoded by serializers as &quot;PLED&quot;.
    /// </summary>
    [EnumMember(Value = "PLED")]
    [IsoId("_ZBTmcNp-Ed-ak6NoX_4Aeg_1435834862")]
    [Description(
        @"Balance of securities that are pledged, for example, a financial instrument is unavailable because it has been used or given as a guarantee."
    )]
    Pledged = SecuritiesBalanceTypeCode.Pledged, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities pending delivery that are unmatched. This is only applicable in a CSD to participant communication.
    /// Encoded/decoded by serializers as &quot;PDUM&quot;.
    /// </summary>
    [EnumMember(Value = "PDUM")]
    [IsoId("_ZBTmcdp-Ed-ak6NoX_4Aeg_1036746499")]
    [Description(
        @"Balance of securities pending delivery that are unmatched. This is only applicable in a CSD to participant communication."
    )]
    PendingDeliveryUnmatchedBalance = SecuritiesBalanceTypeCode.PendingDeliveryUnmatchedBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities currently being processed by the institution responsible for registering the new beneficial owner (or nominee) of securities after a transaction has settled.
    /// Encoded/decoded by serializers as &quot;REGO&quot;.
    /// </summary>
    [EnumMember(Value = "REGO")]
    [IsoId("_ZBTmctp-Ed-ak6NoX_4Aeg_-2112928348")]
    [Description(
        @"Balance of securities currently being processed by the institution responsible for registering the new beneficial owner (or nominee) of securities after a transaction has settled."
    )]
    OutForRegistration = SecuritiesBalanceTypeCode.OutForRegistration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that may only be sold under certain conditions or require legal documents.
    /// Encoded/decoded by serializers as &quot;RSTR&quot;.
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_ZBTmc9p-Ed-ak6NoX_4Aeg_-1666867904")]
    [Description(
        @"Balance of securities that may only be sold under certain conditions or require legal documents."
    )]
    Restricted = SecuritiesBalanceTypeCode.Restricted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZBTmdNp-Ed-ak6NoX_4Aeg_1289904351")]
    [Description(
        @"Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types."
    )]
    Unclassified = SecuritiesBalanceTypeCode.Unclassified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of physical securities that are in transshipment, eg, in the process of being transferred from one depository or agent to another.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ZBTmddp-Ed-ak6NoX_4Aeg_1421045203")]
    [Description(
        @"Balance of physical securities that are in transshipment, eg, in the process of being transferred from one depository or agent to another."
    )]
    InTransshipment = SecuritiesBalanceTypeCode.InTransshipment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that are drawn for redemption.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_ZBTmdtp-Ed-ak6NoX_4Aeg_-1229850220")]
    [Description(@"Balance of securities that are drawn for redemption.")]
    Drawn = SecuritiesBalanceTypeCode.Drawn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order.
    /// Encoded/decoded by serializers as &quot;WDOC&quot;.
    /// </summary>
    [EnumMember(Value = "WDOC")]
    [IsoId("_ZBTmd9p-Ed-ak6NoX_4Aeg_-804389963")]
    [Description(
        @"Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order."
    )]
    WaitingDocumentation = SecuritiesBalanceTypeCode.WaitingDocumentation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders&apos; register.
    /// Encoded/decoded by serializers as &quot;BTRA&quot;.
    /// </summary>
    [EnumMember(Value = "BTRA")]
    [IsoId("_ZBdXcNp-Ed-ak6NoX_4Aeg_-2019462974")]
    [Description(
        @"Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders' register."
    )]
    BeingTransferred = SecuritiesBalanceTypeCode.BeingTransferred, // same ordinal as derivation source for type conversions
}
