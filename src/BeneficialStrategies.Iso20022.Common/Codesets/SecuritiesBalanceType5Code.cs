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
[IsoId("_ZCDNUdp-Ed-ak6NoX_4Aeg_1819315763")]
[Description(@"Specifies the nature of the securities or investment fund balance.")]
[DerivedFrom(typeof(SecuritiesBalanceTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SecuritiesBalanceType5Code>))]
#endif
public enum SecuritiesBalanceType5Code
{
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// Encoded/decoded by serializers as &quot;BLOK&quot;.
    /// </summary>
    [EnumMember(Value = "BLOK")]
    [IsoId("_ZCDNUtp-Ed-ak6NoX_4Aeg_1819315765")]
    [Description(@"Balance of financial instruments that are blocked.")]
    Blocked = SecuritiesBalanceTypeV2Code.Blocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are freely available with no specific additional status.
    /// Encoded/decoded by serializers as &quot;AWAS&quot;.
    /// </summary>
    [EnumMember(Value = "AWAS")]
    [IsoId("_ZCDNU9p-Ed-ak6NoX_4Aeg_-1733141592")]
    [Description(
        @"Balance of financial instruments that are freely available with no specific additional status."
    )]
    AvailableWithNoAdditionalStatus = SecuritiesBalanceTypeV2Code.AvailableWithNoAdditionalStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instrument blocked following a corporate action, including proxy activities.
    /// Encoded/decoded by serializers as &quot;BLCA&quot;.
    /// </summary>
    [EnumMember(Value = "BLCA")]
    [IsoId("_ZCDNVNp-Ed-ak6NoX_4Aeg_-1717441240")]
    [Description(
        @"Balance of financial instrument blocked following a corporate action, including proxy activities."
    )]
    BlockedCorporateAction = SecuritiesBalanceTypeV2Code.BlockedCorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are blocked for trading.
    /// Encoded/decoded by serializers as &quot;BLOT&quot;.
    /// </summary>
    [EnumMember(Value = "BLOT")]
    [IsoId("_ZCDNVdp-Ed-ak6NoX_4Aeg_-1701742290")]
    [Description(@"Balance of financial instruments that are blocked for trading.")]
    BlockedTrading = SecuritiesBalanceTypeV2Code.BlockedTrading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are blocked for verification of authenticity.
    /// Encoded/decoded by serializers as &quot;BLOV&quot;.
    /// </summary>
    [EnumMember(Value = "BLOV")]
    [IsoId("_ZCDNVtp-Ed-ak6NoX_4Aeg_-1686043027")]
    [Description(
        @"Balance of financial instruments that are blocked for verification of authenticity."
    )]
    BlockedAuthenticity = SecuritiesBalanceTypeV2Code.BlockedAuthenticity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// Encoded/decoded by serializers as &quot;BORR&quot;.
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_ZCDNV9p-Ed-ak6NoX_4Aeg_1819315780")]
    [Description(@"Balance of financial instruments that have been borrowed from another party.")]
    Borrowed = SecuritiesBalanceTypeV2Code.Borrowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are pending delivery in relation to a borrow transaction.
    /// Encoded/decoded by serializers as &quot;BODE&quot;.
    /// </summary>
    [EnumMember(Value = "BODE")]
    [IsoId("_ZCM-UNp-Ed-ak6NoX_4Aeg_-1660183475")]
    [Description(
        @"Balance of financial instruments that are pending delivery in relation to a borrow transaction."
    )]
    PendingBorrowedDelivery = SecuritiesBalanceTypeV2Code.PendingBorrowedDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are pending receipt in relation to a borrow transaction.
    /// Encoded/decoded by serializers as &quot;BORE&quot;.
    /// </summary>
    [EnumMember(Value = "BORE")]
    [IsoId("_ZCM-Udp-Ed-ak6NoX_4Aeg_-1646328737")]
    [Description(
        @"Balance of financial instruments that are pending receipt in relation to a borrow transaction."
    )]
    PendingBorrowedReceipt = SecuritiesBalanceTypeV2Code.PendingBorrowedReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_ZCM-Utp-Ed-ak6NoX_4Aeg_1819315798")]
    [Description(
        @"Balance of securities that belong to a third party and that are held for the purpose of collateralisation."
    )]
    CollateralIn = SecuritiesBalanceTypeV2Code.CollateralIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_ZCM-U9p-Ed-ak6NoX_4Aeg_1819315799")]
    [Description(
        @"Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation."
    )]
    CollateralOut = SecuritiesBalanceTypeV2Code.CollateralOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Loan for consumption.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_ZCM-VNp-Ed-ak6NoX_4Aeg_1819315800")]
    [Description(@"Loan for consumption.")]
    OnLoan = SecuritiesBalanceTypeV2Code.OnLoan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are pending delivery in relation to a lending transaction.
    /// Encoded/decoded by serializers as &quot;LODE&quot;.
    /// </summary>
    [EnumMember(Value = "LODE")]
    [IsoId("_ZCM-Vdp-Ed-ak6NoX_4Aeg_-1603847596")]
    [Description(
        @"Balance of financial instruments that are pending delivery in relation to a lending transaction."
    )]
    PendingOnLoanDelivery = SecuritiesBalanceTypeV2Code.PendingOnLoanDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are pending receipt in relation to a lending transaction.
    /// Encoded/decoded by serializers as &quot;LORE&quot;.
    /// </summary>
    [EnumMember(Value = "LORE")]
    [IsoId("_ZCM-Vtp-Ed-ak6NoX_4Aeg_-1589994676")]
    [Description(
        @"Balance of financial instruments that are pending receipt in relation to a lending transaction."
    )]
    PendingOnLoanReceipt = SecuritiesBalanceTypeV2Code.PendingOnLoanReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is used when financing is by the broker/dealer.
    /// Encoded/decoded by serializers as &quot;MARG&quot;.
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_ZCM-V9p-Ed-ak6NoX_4Aeg_1819315833")]
    [Description(@"Account is used when financing is by the broker/dealer.")]
    DerivativesMargin = SecuritiesBalanceTypeV2Code.DerivativesMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments pending delivery that have been matched.
    /// Encoded/decoded by serializers as &quot;PDMT&quot;.
    /// </summary>
    [EnumMember(Value = "PDMT")]
    [IsoId("_ZCM-WNp-Ed-ak6NoX_4Aeg_1819315834")]
    [Description(@"Balance of financial instruments pending delivery that have been matched.")]
    PendingDeliveryMatchedBalance = SecuritiesBalanceTypeV2Code.PendingDeliveryMatchedBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments pending delivery that have been unmatched.
    /// Encoded/decoded by serializers as &quot;PDUM&quot;.
    /// </summary>
    [EnumMember(Value = "PDUM")]
    [IsoId("_ZCM-Wdp-Ed-ak6NoX_4Aeg_1819315858")]
    [Description(@"Balance of financial instruments pending delivery that have been unmatched.")]
    PendingDeliveryUnmatchedBalance = SecuritiesBalanceTypeV2Code.PendingDeliveryUnmatchedBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments pending receipt that have been matched.
    /// Encoded/decoded by serializers as &quot;PRMT&quot;.
    /// </summary>
    [EnumMember(Value = "PRMT")]
    [IsoId("_ZCWIQNp-Ed-ak6NoX_4Aeg_1819315859")]
    [Description(@"Balance of financial instruments pending receipt that have been matched.")]
    PendingReceiptMatchedBalance = SecuritiesBalanceTypeV2Code.PendingReceiptMatchedBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments pending receipt that are unmatched.
    /// Encoded/decoded by serializers as &quot;PRUM&quot;.
    /// </summary>
    [EnumMember(Value = "PRUM")]
    [IsoId("_ZCWIQdp-Ed-ak6NoX_4Aeg_1819315875")]
    [Description(@"Balance of financial instruments pending receipt that are unmatched.")]
    PendingReceiptUnmatchedBalance = SecuritiesBalanceTypeV2Code.PendingReceiptUnmatchedBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instrument pending receipt following a corporate action.
    /// Encoded/decoded by serializers as &quot;PECA&quot;.
    /// </summary>
    [EnumMember(Value = "PECA")]
    [IsoId("_ZCWIQtp-Ed-ak6NoX_4Aeg_1819315876")]
    [Description(@"Balance of financial instrument pending receipt following a corporate action.")]
    PendingCorporateActionReceipt = SecuritiesBalanceTypeV2Code.PendingCorporateActionReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instrument pending delivery following a corporate action.
    /// Encoded/decoded by serializers as &quot;PEDA&quot;.
    /// </summary>
    [EnumMember(Value = "PEDA")]
    [IsoId("_ZCWIQ9p-Ed-ak6NoX_4Aeg_1486582931")]
    [Description(@"Balance of financial instrument pending delivery following a corporate action.")]
    PendingCorporateActionDelivery = SecuritiesBalanceTypeV2Code.PendingCorporateActionDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing has not been completed.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZCWIRNp-Ed-ak6NoX_4Aeg_1819315877")]
    [Description(@"Processing has not been completed.")]
    PendingDelivery = SecuritiesBalanceTypeV2Code.PendingDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The instruction is pending receipt of securities, for example, from a purchase, loan etc.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_ZCWIRdp-Ed-ak6NoX_4Aeg_1819315893")]
    [Description(
        @"The instruction is pending receipt of securities, for example, from a purchase, loan etc."
    )]
    PendingReceipt = SecuritiesBalanceTypeV2Code.PendingReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged.
    /// Encoded/decoded by serializers as &quot;PLED&quot;.
    /// </summary>
    [EnumMember(Value = "PLED")]
    [IsoId("_ZCWIRtp-Ed-ak6NoX_4Aeg_1819315894")]
    [Description(
        @"Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged."
    )]
    Pledged = SecuritiesBalanceTypeV2Code.Pledged, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// Encoded/decoded by serializers as &quot;REGO&quot;.
    /// </summary>
    [EnumMember(Value = "REGO")]
    [IsoId("_ZCWIR9p-Ed-ak6NoX_4Aeg_1819315918")]
    [Description(
        @"Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee)."
    )]
    OutForRegistration = SecuritiesBalanceTypeV2Code.OutForRegistration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that may only be sold under certain conditions or require legal documents.
    /// Encoded/decoded by serializers as &quot;RSTR&quot;.
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_ZCWISNp-Ed-ak6NoX_4Aeg_1819315935")]
    [Description(
        @"Balance of financial instruments that may only be sold under certain conditions or require legal documents."
    )]
    Restricted = SecuritiesBalanceTypeV2Code.Restricted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZCWISdp-Ed-ak6NoX_4Aeg_1819315936")]
    [Description(@"Other. See Narrative.")]
    Unclassified = SecuritiesBalanceTypeV2Code.Unclassified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been generated due to transformation following a corporate action.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ZCWIStp-Ed-ak6NoX_4Aeg_1819315953")]
    [Description(
        @"Transaction has been generated due to transformation following a corporate action."
    )]
    InTransshipment = SecuritiesBalanceTypeV2Code.InTransshipment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_ZCf5QNp-Ed-ak6NoX_4Aeg_1819315954")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn = SecuritiesBalanceTypeV2Code.Drawn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order.
    /// Encoded/decoded by serializers as &quot;WDOC&quot;.
    /// </summary>
    [EnumMember(Value = "WDOC")]
    [IsoId("_ZCf5Qdp-Ed-ak6NoX_4Aeg_1819315970")]
    [Description(
        @"Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order."
    )]
    WaitingDocumentation = SecuritiesBalanceTypeV2Code.WaitingDocumentation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders&apos; register.
    /// Encoded/decoded by serializers as &quot;BTRA&quot;.
    /// </summary>
    [EnumMember(Value = "BTRA")]
    [IsoId("_ZCf5Qtp-Ed-ak6NoX_4Aeg_1819315971")]
    [Description(
        @"Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders' register."
    )]
    BeingTransferred = SecuritiesBalanceTypeV2Code.BeingTransferred, // same ordinal as derivation source for type conversions
}
