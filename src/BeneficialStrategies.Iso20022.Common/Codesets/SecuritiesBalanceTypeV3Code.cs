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
[IsoId("_kKPfmIhAEeOxVLCZ_vEz5w")]
[Description(@"Specifies the nature of the securities or investment fund balance.")]
[Derivations(typeof(SecuritiesBalanceType14Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SecuritiesBalanceTypeV3Code>))]
#endif
public enum SecuritiesBalanceTypeV3Code
{
    /// <summary>
    /// Balance of financial instruments that are freely available with no specific additional status.
    /// Encoded/decoded by serializers as &quot;AWAS&quot;.
    /// </summary>
    [EnumMember(Value = "AWAS")]
    [IsoId("_kKSiw4hAEeOxVLCZ_vEz5w")]
    [Description(
        @"Balance of financial instruments that are freely available with no specific additional status."
    )]
    AvailableWithNoAdditionalStatus,

    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// Encoded/decoded by serializers as &quot;BLOK&quot;.
    /// </summary>
    [EnumMember(Value = "BLOK")]
    [IsoId("_kKQGhIhAEeOxVLCZ_vEz5w")]
    [Description(@"Balance of financial instruments that are blocked.")]
    Blocked,

    /// <summary>
    /// Balance of financial instruments that are available.
    /// Encoded/decoded by serializers as &quot;AVAI&quot;.
    /// </summary>
    [EnumMember(Value = "AVAI")]
    [IsoId("_kKQtlIhAEeOxVLCZ_vEz5w")]
    [Description(@"Balance of financial instruments that are available.")]
    Available,

    /// <summary>
    /// Balance of financial instrument blocked following a corporate action, including proxy activities.
    /// Encoded/decoded by serializers as &quot;BLCA&quot;.
    /// </summary>
    [EnumMember(Value = "BLCA")]
    [IsoId("_kKRUpohAEeOxVLCZ_vEz5w")]
    [Description(
        @"Balance of financial instrument blocked following a corporate action, including proxy activities."
    )]
    BlockedCorporateAction,

    /// <summary>
    /// Balance of financial instruments that are blocked for trading.
    /// Encoded/decoded by serializers as &quot;BLOT&quot;.
    /// </summary>
    [EnumMember(Value = "BLOT")]
    [IsoId("_kKSiwYhAEeOxVLCZ_vEz5w")]
    [Description(@"Balance of financial instruments that are blocked for trading.")]
    BlockedTrading,

    /// <summary>
    /// Balance of financial instruments that are blocked for verification of authenticity.
    /// Encoded/decoded by serializers as &quot;BLOV&quot;.
    /// </summary>
    [EnumMember(Value = "BLOV")]
    [IsoId("_kKSiwohAEeOxVLCZ_vEz5w")]
    [Description(
        @"Balance of financial instruments that are blocked for verification of authenticity."
    )]
    BlockedAuthenticity,

    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// Encoded/decoded by serializers as &quot;BORR&quot;.
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_kKR7sohAEeOxVLCZ_vEz5w")]
    [Description(@"Balance of financial instruments that have been borrowed from another party.")]
    Borrowed,

    /// <summary>
    /// Balance of financial instruments that are pending delivery in relation to a borrow transaction.
    /// Encoded/decoded by serializers as &quot;BODE&quot;.
    /// </summary>
    [EnumMember(Value = "BODE")]
    [IsoId("_kKQtk4hAEeOxVLCZ_vEz5w")]
    [Description(
        @"Balance of financial instruments that are pending delivery in relation to a borrow transaction."
    )]
    PendingBorrowedDelivery,

    /// <summary>
    /// Balance of financial instruments that are pending receipt in relation to a borrow transaction.
    /// Encoded/decoded by serializers as &quot;BORE&quot;.
    /// </summary>
    [EnumMember(Value = "BORE")]
    [IsoId("_kKRUoIhAEeOxVLCZ_vEz5w")]
    [Description(
        @"Balance of financial instruments that are pending receipt in relation to a borrow transaction."
    )]
    PendingBorrowedReceipt,

    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_kKPfm4hAEeOxVLCZ_vEz5w")]
    [Description(
        @"Balance of securities that belong to a third party and that are held for the purpose of collateralisation."
    )]
    CollateralIn,

    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_kKQtlYhAEeOxVLCZ_vEz5w")]
    [Description(
        @"Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation."
    )]
    CollateralOut,

    /// <summary>
    /// Balance of securities that are eligible for use for collateral purposes.
    /// Encoded/decoded by serializers as &quot;COLA&quot;.
    /// </summary>
    [EnumMember(Value = "COLA")]
    [IsoId("_kKR7tYhAEeOxVLCZ_vEz5w")]
    [Description(@"Balance of securities that are eligible for use for collateral purposes.")]
    EligibleForCollateralPurposes,

    /// <summary>
    /// Loan for consumption.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_kKRUoYhAEeOxVLCZ_vEz5w")]
    [Description(@"Loan for consumption.")]
    OnLoan,

    /// <summary>
    /// Balance of financial instruments that are pending delivery in relation to a lending transaction.
    /// Encoded/decoded by serializers as &quot;LODE&quot;.
    /// </summary>
    [EnumMember(Value = "LODE")]
    [IsoId("_kKR7sYhAEeOxVLCZ_vEz5w")]
    [Description(
        @"Balance of financial instruments that are pending delivery in relation to a lending transaction."
    )]
    PendingOnLoanDelivery,

    /// <summary>
    /// Balance of financial instruments that are pending receipt in relation to a lending transaction.
    /// Encoded/decoded by serializers as &quot;LORE&quot;.
    /// </summary>
    [EnumMember(Value = "LORE")]
    [IsoId("_kKR7sIhAEeOxVLCZ_vEz5w")]
    [Description(
        @"Balance of financial instruments that are pending receipt in relation to a lending transaction."
    )]
    PendingOnLoanReceipt,

    /// <summary>
    /// Account is used when financing is by the broker/dealer.
    /// Encoded/decoded by serializers as &quot;MARG&quot;.
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_kKQtkYhAEeOxVLCZ_vEz5w")]
    [Description(@"Account is used when financing is by the broker/dealer.")]
    DerivativesMargin,

    /// <summary>
    /// Balance of financial instruments pending delivery that have been matched.
    /// Encoded/decoded by serializers as &quot;PDMT&quot;.
    /// </summary>
    [EnumMember(Value = "PDMT")]
    [IsoId("_kKPfmYhAEeOxVLCZ_vEz5w")]
    [Description(@"Balance of financial instruments pending delivery that have been matched.")]
    PendingDeliveryMatchedBalance,

    /// <summary>
    /// Balance of financial instruments pending delivery that have been unmatched.
    /// Encoded/decoded by serializers as &quot;PDUM&quot;.
    /// </summary>
    [EnumMember(Value = "PDUM")]
    [IsoId("_kKRUp4hAEeOxVLCZ_vEz5w")]
    [Description(@"Balance of financial instruments pending delivery that have been unmatched.")]
    PendingDeliveryUnmatchedBalance,

    /// <summary>
    /// Balance of financial instruments pending receipt that have been matched.
    /// Encoded/decoded by serializers as &quot;PRMT&quot;.
    /// </summary>
    [EnumMember(Value = "PRMT")]
    [IsoId("_kKR7s4hAEeOxVLCZ_vEz5w")]
    [Description(@"Balance of financial instruments pending receipt that have been matched.")]
    PendingReceiptMatchedBalance,

    /// <summary>
    /// Balance of financial instruments pending receipt that are unmatched.
    /// Encoded/decoded by serializers as &quot;PRUM&quot;.
    /// </summary>
    [EnumMember(Value = "PRUM")]
    [IsoId("_kKQGg4hAEeOxVLCZ_vEz5w")]
    [Description(@"Balance of financial instruments pending receipt that are unmatched.")]
    PendingReceiptUnmatchedBalance,

    /// <summary>
    /// Balance of financial instrument pending receipt following a corporate action.
    /// Encoded/decoded by serializers as &quot;PECA&quot;.
    /// </summary>
    [EnumMember(Value = "PECA")]
    [IsoId("_kKQtkIhAEeOxVLCZ_vEz5w")]
    [Description(@"Balance of financial instrument pending receipt following a corporate action.")]
    PendingCorporateActionReceipt,

    /// <summary>
    /// Balance of financial instrument pending delivery following a corporate action.
    /// Encoded/decoded by serializers as &quot;PEDA&quot;.
    /// </summary>
    [EnumMember(Value = "PEDA")]
    [IsoId("_kKQtkohAEeOxVLCZ_vEz5w")]
    [Description(@"Balance of financial instrument pending delivery following a corporate action.")]
    PendingCorporateActionDelivery,

    /// <summary>
    /// Processing has not been completed.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_kKSixIhAEeOxVLCZ_vEz5w")]
    [Description(@"Processing has not been completed.")]
    PendingDelivery,

    /// <summary>
    /// The instruction is pending receipt of securities, for example, from a purchase, loan etc.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_kKQGh4hAEeOxVLCZ_vEz5w")]
    [Description(
        @"The instruction is pending receipt of securities, for example, from a purchase, loan etc."
    )]
    PendingReceipt,

    /// <summary>
    /// Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged.
    /// Encoded/decoded by serializers as &quot;PLED&quot;.
    /// </summary>
    [EnumMember(Value = "PLED")]
    [IsoId("_kKQGhYhAEeOxVLCZ_vEz5w")]
    [Description(
        @"Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged."
    )]
    Pledged,

    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// Encoded/decoded by serializers as &quot;REGO&quot;.
    /// </summary>
    [EnumMember(Value = "REGO")]
    [IsoId("_kKR7tIhAEeOxVLCZ_vEz5w")]
    [Description(
        @"Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee)."
    )]
    OutForRegistration,

    /// <summary>
    /// Balance of financial instruments that may only be sold under certain conditions or require legal documents.
    /// Encoded/decoded by serializers as &quot;RSTR&quot;.
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_kKSiwIhAEeOxVLCZ_vEz5w")]
    [Description(
        @"Balance of financial instruments that may only be sold under certain conditions or require legal documents."
    )]
    Restricted,

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_kKQtlohAEeOxVLCZ_vEz5w")]
    [Description(@"Other. See Narrative.")]
    Unclassified,

    /// <summary>
    /// Transaction has been generated due to transformation following a corporate action.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_kKQGgYhAEeOxVLCZ_vEz5w")]
    [Description(
        @"Transaction has been generated due to transformation following a corporate action."
    )]
    InTransshipment,

    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_kKPfmohAEeOxVLCZ_vEz5w")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn,

    /// <summary>
    /// Tax-exempt financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_kKSixYhAEeOxVLCZ_vEz5w")]
    [Description(@"Tax-exempt financial instruments are to be settled.")]
    TaxExempt,

    /// <summary>
    /// Taxable financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_kKQGgIhAEeOxVLCZ_vEz5w")]
    [Description(@"Taxable financial instruments are to be settled.")]
    NonTaxExempt,

    /// <summary>
    /// Balance of financial instruments that are registered (in nominee name or in the name of the beneficial owner).
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_kKQGgohAEeOxVLCZ_vEz5w")]
    [Description(
        @"Balance of financial instruments that are registered (in nominee name or in the name of the beneficial owner)."
    )]
    Registered,

    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// Encoded/decoded by serializers as &quot;SPOS&quot;.
    /// </summary>
    [EnumMember(Value = "SPOS")]
    [IsoId("_kKRUoohAEeOxVLCZ_vEz5w")]
    [Description(
        @"Balance of financial instruments that remain registered in the name of the prior beneficial owner."
    )]
    StreetPosition,

    /// <summary>
    /// Balance of securities that could not be registered due to foreign ownership limitation.
    /// Encoded/decoded by serializers as &quot;UNRG&quot;.
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_kKRUpIhAEeOxVLCZ_vEz5w")]
    [Description(
        @"Balance of securities that could not be registered due to foreign ownership limitation."
    )]
    Unregistered,

    /// <summary>
    /// Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order.
    /// Encoded/decoded by serializers as &quot;WDOC&quot;.
    /// </summary>
    [EnumMember(Value = "WDOC")]
    [IsoId("_kKR7tohAEeOxVLCZ_vEz5w")]
    [Description(
        @"Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order."
    )]
    WaitingDocumentation,

    /// <summary>
    /// Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders&apos; register.
    /// Encoded/decoded by serializers as &quot;BTRA&quot;.
    /// </summary>
    [EnumMember(Value = "BTRA")]
    [IsoId("_kKQGhohAEeOxVLCZ_vEz5w")]
    [Description(
        @"Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders' register."
    )]
    BeingTransferred,

    /// <summary>
    /// In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has been received.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_kKRUo4hAEeOxVLCZ_vEz5w")]
    [Description(
        @"In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has been received."
    )]
    Issued,

    /// <summary>
    /// In Issuer Agent / Depository communication, balance of issued financial instruments for which legal documentation has not yet been received.
    /// Encoded/decoded by serializers as &quot;QUAS&quot;.
    /// </summary>
    [EnumMember(Value = "QUAS")]
    [IsoId("_kKRUpYhAEeOxVLCZ_vEz5w")]
    [Description(
        @"In Issuer Agent / Depository communication, balance of issued financial instruments for which legal documentation has not yet been received."
    )]
    QuasiIssued,

    /// <summary>
    /// Net balance of financial instrument that is traded pending settlement and settlement is overdue.
    /// Encoded/decoded by serializers as &quot;OPNT&quot;.
    /// </summary>
    [EnumMember(Value = "OPNT")]
    [IsoId("_vlPjIIhAEeOxVLCZ_vEz5w")]
    [Description(
        @"Net balance of financial instrument that is traded pending settlement and settlement is overdue."
    )]
    OverdueNetPending,

    /// <summary>
    /// Net balance of financial instrument that is traded pending settlement.
    /// Encoded/decoded by serializers as &quot;PNET&quot;.
    /// </summary>
    [EnumMember(Value = "PNET")]
    [IsoId("_5HWykIhAEeOxVLCZ_vEz5w")]
    [Description(@"Net balance of financial instrument that is traded pending settlement.")]
    NetPending,

    /// <summary>
    /// Purchased investment fund units that were purchased prior to the last ex-div date.
    /// Encoded/decoded by serializers as &quot;GRP1&quot;.
    /// </summary>
    [EnumMember(Value = "GRP1")]
    [IsoId("_RdQMEGK3EeWaPYQgYu-nxQ")]
    [Description(
        @"Purchased investment fund units that were purchased prior to the last ex-div date.|"
    )]
    PurchasedInvestmentFundTaxGroupUnit1,

    /// <summary>
    /// Purchased investment fund units that were purchased since the ex-div date, and that benefit from the tax exemption.
    /// Encoded/decoded by serializers as &quot;GRP2&quot;.
    /// </summary>
    [EnumMember(Value = "GRP2")]
    [IsoId("_07ls8WK3EeWaPYQgYu-nxQ")]
    [Description(
        @"Purchased investment fund units that were purchased since the ex-div date, and that benefit from the tax exemption."
    )]
    PurchasedInvestmentFundTaxGroupUnit2,
}
