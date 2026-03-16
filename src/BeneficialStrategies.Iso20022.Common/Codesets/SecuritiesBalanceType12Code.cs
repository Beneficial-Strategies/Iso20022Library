// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y_qnttp-Ed-ak6NoX_4Aeg_-1639644104")]
[Description(@"Specifies the nature of the securities or investment fund balance.")]
[DerivedFrom(typeof(SecuritiesBalanceTypeV2Code))]
public enum SecuritiesBalanceType12Code
{
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// Encoded/decoded by serializers as &quot;BLOK&quot;.
    /// </summary>
    [EnumMember(Value = "BLOK")]
    [IsoId("_Y_qnt9p-Ed-ak6NoX_4Aeg_5623331")]
    [Description(@"Balance of financial instruments that are blocked.")]
    Blocked = SecuritiesBalanceTypeV2Code.Blocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are freely available with no specific additional status.
    /// Encoded/decoded by serializers as &quot;AWAS&quot;.
    /// </summary>
    [EnumMember(Value = "AWAS")]
    [IsoId("_Y_qnuNp-Ed-ak6NoX_4Aeg_1658250839")]
    [Description(
        @"Balance of financial instruments that are freely available with no specific additional status."
    )]
    AvailableWithNoAdditionalStatus = SecuritiesBalanceTypeV2Code.AvailableWithNoAdditionalStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instrument blocked following a corporate action, including proxy activities.
    /// Encoded/decoded by serializers as &quot;BLCA&quot;.
    /// </summary>
    [EnumMember(Value = "BLCA")]
    [IsoId("_Y_0YsNp-Ed-ak6NoX_4Aeg_1366293101")]
    [Description(
        @"Balance of financial instrument blocked following a corporate action, including proxy activities."
    )]
    BlockedCorporateAction = SecuritiesBalanceTypeV2Code.BlockedCorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are blocked for trading.
    /// Encoded/decoded by serializers as &quot;BLOT&quot;.
    /// </summary>
    [EnumMember(Value = "BLOT")]
    [IsoId("_Y_0Ysdp-Ed-ak6NoX_4Aeg_1544411773")]
    [Description(@"Balance of financial instruments that are blocked for trading.")]
    BlockedTrading = SecuritiesBalanceTypeV2Code.BlockedTrading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are blocked for verification of authenticity.
    /// Encoded/decoded by serializers as &quot;BLOV&quot;.
    /// </summary>
    [EnumMember(Value = "BLOV")]
    [IsoId("_Y_0Ystp-Ed-ak6NoX_4Aeg_-991449022")]
    [Description(
        @"Balance of financial instruments that are blocked for verification of authenticity."
    )]
    BlockedAuthenticity = SecuritiesBalanceTypeV2Code.BlockedAuthenticity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// Encoded/decoded by serializers as &quot;BORR&quot;.
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_Y_0Ys9p-Ed-ak6NoX_4Aeg_661178486")]
    [Description(@"Balance of financial instruments that have been borrowed from another party.")]
    Borrowed = SecuritiesBalanceTypeV2Code.Borrowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are pending delivery in relation to a borrow transaction.
    /// Encoded/decoded by serializers as &quot;BODE&quot;.
    /// </summary>
    [EnumMember(Value = "BODE")]
    [IsoId("_Y_0YtNp-Ed-ak6NoX_4Aeg_369220748")]
    [Description(
        @"Balance of financial instruments that are pending delivery in relation to a borrow transaction."
    )]
    PendingBorrowedDelivery = SecuritiesBalanceTypeV2Code.PendingBorrowedDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are pending receipt in relation to a borrow transaction.
    /// Encoded/decoded by serializers as &quot;BORE&quot;.
    /// </summary>
    [EnumMember(Value = "BORE")]
    [IsoId("_Y_0Ytdp-Ed-ak6NoX_4Aeg_547339420")]
    [Description(
        @"Balance of financial instruments that are pending receipt in relation to a borrow transaction."
    )]
    PendingBorrowedReceipt = SecuritiesBalanceTypeV2Code.PendingBorrowedReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_Y_0Yttp-Ed-ak6NoX_4Aeg_-1988521375")]
    [Description(
        @"Balance of securities that belong to a third party and that are held for the purpose of collateralisation."
    )]
    CollateralIn = SecuritiesBalanceTypeV2Code.CollateralIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_Y_0Yt9p-Ed-ak6NoX_4Aeg_-335893867")]
    [Description(
        @"Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation."
    )]
    CollateralOut = SecuritiesBalanceTypeV2Code.CollateralOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Loan for consumption.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_Y_0YuNp-Ed-ak6NoX_4Aeg_-627851605")]
    [Description(@"Loan for consumption.")]
    OnLoan = SecuritiesBalanceTypeV2Code.OnLoan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are pending delivery in relation to a lending transaction.
    /// Encoded/decoded by serializers as &quot;LODE&quot;.
    /// </summary>
    [EnumMember(Value = "LODE")]
    [IsoId("_Y_0Yudp-Ed-ak6NoX_4Aeg_-449732933")]
    [Description(
        @"Balance of financial instruments that are pending delivery in relation to a lending transaction."
    )]
    PendingOnLoanDelivery = SecuritiesBalanceTypeV2Code.PendingOnLoanDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are pending receipt in relation to a lending transaction.
    /// Encoded/decoded by serializers as &quot;LORE&quot;.
    /// </summary>
    [EnumMember(Value = "LORE")]
    [IsoId("_Y_0Yutp-Ed-ak6NoX_4Aeg_1309373568")]
    [Description(
        @"Balance of financial instruments that are pending receipt in relation to a lending transaction."
    )]
    PendingOnLoanReceipt = SecuritiesBalanceTypeV2Code.PendingOnLoanReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is used when financing is by the broker/dealer.
    /// Encoded/decoded by serializers as &quot;MARG&quot;.
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_Y_9ioNp-Ed-ak6NoX_4Aeg_-1332966220")]
    [Description(@"Account is used when financing is by the broker/dealer.")]
    DerivativesMargin = SecuritiesBalanceTypeV2Code.DerivativesMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instrument pending receipt following a corporate action.
    /// Encoded/decoded by serializers as &quot;PECA&quot;.
    /// </summary>
    [EnumMember(Value = "PECA")]
    [IsoId("_Y_9iodp-Ed-ak6NoX_4Aeg_1672970985")]
    [Description(@"Balance of financial instrument pending receipt following a corporate action.")]
    PendingCorporateActionReceipt = SecuritiesBalanceTypeV2Code.PendingCorporateActionReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instrument pending delivery following a corporate action.
    /// Encoded/decoded by serializers as &quot;PEDA&quot;.
    /// </summary>
    [EnumMember(Value = "PEDA")]
    [IsoId("_Y_9iotp-Ed-ak6NoX_4Aeg_1851089657")]
    [Description(@"Balance of financial instrument pending delivery following a corporate action.")]
    PendingCorporateActionDelivery = SecuritiesBalanceTypeV2Code.PendingCorporateActionDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing has not been completed.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_Y_9io9p-Ed-ak6NoX_4Aeg_-684771138")]
    [Description(@"Processing has not been completed.")]
    PendingDelivery = SecuritiesBalanceTypeV2Code.PendingDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The instruction is pending receipt of securities, for example, from a purchase, loan etc.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_Y_9ipNp-Ed-ak6NoX_4Aeg_967856370")]
    [Description(
        @"The instruction is pending receipt of securities, for example, from a purchase, loan etc."
    )]
    PendingReceipt = SecuritiesBalanceTypeV2Code.PendingReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged.
    /// Encoded/decoded by serializers as &quot;PLED&quot;.
    /// </summary>
    [EnumMember(Value = "PLED")]
    [IsoId("_Y_9ipdp-Ed-ak6NoX_4Aeg_675898632")]
    [Description(
        @"Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged."
    )]
    Pledged = SecuritiesBalanceTypeV2Code.Pledged, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// Encoded/decoded by serializers as &quot;REGO&quot;.
    /// </summary>
    [EnumMember(Value = "REGO")]
    [IsoId("_Y_9iptp-Ed-ak6NoX_4Aeg_854017304")]
    [Description(
        @"Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee)."
    )]
    OutForRegistration = SecuritiesBalanceTypeV2Code.OutForRegistration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that may only be sold under certain conditions or require legal documents.
    /// Encoded/decoded by serializers as &quot;RSTR&quot;.
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_Y_9ip9p-Ed-ak6NoX_4Aeg_-1681843491")]
    [Description(
        @"Balance of financial instruments that may only be sold under certain conditions or require legal documents."
    )]
    Restricted = SecuritiesBalanceTypeV2Code.Restricted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Y_9iqNp-Ed-ak6NoX_4Aeg_-29215983")]
    [Description(@"Other. See Narrative.")]
    Unclassified = SecuritiesBalanceTypeV2Code.Unclassified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been generated due to transformation following a corporate action.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_Y_9iqdp-Ed-ak6NoX_4Aeg_-321173721")]
    [Description(
        @"Transaction has been generated due to transformation following a corporate action."
    )]
    InTransshipment = SecuritiesBalanceTypeV2Code.InTransshipment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_ZAHToNp-Ed-ak6NoX_4Aeg_-143055049")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn = SecuritiesBalanceTypeV2Code.Drawn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order.
    /// Encoded/decoded by serializers as &quot;WDOC&quot;.
    /// </summary>
    [EnumMember(Value = "WDOC")]
    [IsoId("_ZAHTodp-Ed-ak6NoX_4Aeg_1616051452")]
    [Description(
        @"Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order."
    )]
    WaitingDocumentation = SecuritiesBalanceTypeV2Code.WaitingDocumentation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders&apos; register.
    /// Encoded/decoded by serializers as &quot;BTRA&quot;.
    /// </summary>
    [EnumMember(Value = "BTRA")]
    [IsoId("_ZAHTotp-Ed-ak6NoX_4Aeg_-1026288336")]
    [Description(
        @"Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders' register."
    )]
    BeingTransferred = SecuritiesBalanceTypeV2Code.BeingTransferred, // same ordinal as derivation source for type conversions
}
