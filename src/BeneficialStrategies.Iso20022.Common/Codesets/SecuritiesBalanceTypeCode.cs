// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZDFvI9p-Ed-ak6NoX_4Aeg_-1338652334")]
[Description(@"Specifies the nature of the securities or investment fund balance.")]
[Derivations(
    typeof(SecuritiesBalanceType1Code),
    typeof(SecuritiesBalanceType2Code),
    typeof(SecuritiesBalanceType4Code),
    typeof(SecuritiesBalanceType3Code)
)]
public enum SecuritiesBalanceTypeCode
{
    /// <summary>
    /// Balance of securities that are blocked or frozen. A financial instrument may be unavailable due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.
    /// Encoded/decoded by serializers as &quot;BLOK&quot;.
    /// </summary>
    [EnumMember(Value = "BLOK")]
    [IsoId("_ZDFvJNp-Ed-ak6NoX_4Aeg_-1247224745")]
    [Description(
        @"Balance of securities that are blocked or frozen. A financial instrument may be unavailable due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy."
    )]
    Blocked,

    /// <summary>
    /// Balance of securities that have been borrowed from another party.
    /// Encoded/decoded by serializers as &quot;BORR&quot;.
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_ZDFvJdp-Ed-ak6NoX_4Aeg_-1247224668")]
    [Description(@"Balance of securities that have been borrowed from another party.")]
    Borrowed,

    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_ZDFvJtp-Ed-ak6NoX_4Aeg_-1247224377")]
    [Description(
        @"Balance of securities that belong to a third party and that are held for the purpose of collateralisation."
    )]
    CollateralIn,

    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_ZDFvJ9p-Ed-ak6NoX_4Aeg_-1247224317")]
    [Description(
        @"Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation."
    )]
    CollateralOut,

    /// <summary>
    /// Balance of securities that have been loaned to a third party.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_ZDFvKNp-Ed-ak6NoX_4Aeg_-1247224265")]
    [Description(@"Balance of securities that have been loaned to a third party.")]
    OnLoan,

    /// <summary>
    /// Balance of securities that are used as collateral for derivatives.
    /// Encoded/decoded by serializers as &quot;MARG&quot;.
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_ZDFvKdp-Ed-ak6NoX_4Aeg_-1247224205")]
    [Description(@"Balance of securities that are used as collateral for derivatives.")]
    DerivativesMargin,

    /// <summary>
    /// Balance of securities pending delivery that have been matched. This is only applicable in a CSD to participant communication.
    /// Encoded/decoded by serializers as &quot;PDMT&quot;.
    /// </summary>
    [EnumMember(Value = "PDMT")]
    [IsoId("_ZDPgINp-Ed-ak6NoX_4Aeg_-1247224145")]
    [Description(
        @"Balance of securities pending delivery that have been matched. This is only applicable in a CSD to participant communication."
    )]
    PendingDeliveryMatchedBalance,

    /// <summary>
    /// Balance of securities pending delivery that are unmatched. This is only applicable in a CSD to participant communication.
    /// Encoded/decoded by serializers as &quot;PDUM&quot;.
    /// </summary>
    [EnumMember(Value = "PDUM")]
    [IsoId("_ZDPgIdp-Ed-ak6NoX_4Aeg_-1247223875")]
    [Description(
        @"Balance of securities pending delivery that are unmatched. This is only applicable in a CSD to participant communication."
    )]
    PendingDeliveryUnmatchedBalance,

    /// <summary>
    /// Balance of securities pending receipt that have been matched. This is only applicable in a CSD to participant communication.
    /// Encoded/decoded by serializers as &quot;PRMT&quot;.
    /// </summary>
    [EnumMember(Value = "PRMT")]
    [IsoId("_ZDPgItp-Ed-ak6NoX_4Aeg_-1247223815")]
    [Description(
        @"Balance of securities pending receipt that have been matched. This is only applicable in a CSD to participant communication."
    )]
    PendingReceiptMatchedBalance,

    /// <summary>
    /// Balance of securities pending receipt that are unmatched. This is only applicable in a CSD to participant communication.
    /// Encoded/decoded by serializers as &quot;PRUM&quot;.
    /// </summary>
    [EnumMember(Value = "PRUM")]
    [IsoId("_ZDPgI9p-Ed-ak6NoX_4Aeg_-1247223755")]
    [Description(
        @"Balance of securities pending receipt that are unmatched. This is only applicable in a CSD to participant communication."
    )]
    PendingReceiptUnmatchedBalance,

    /// <summary>
    /// Balance of securities, before ex-date, that are involved in a corporate action (CA). Securities blocked due to a CA, for example, proxi, in escrow, are to be identified in the BLOK sub-balance.
    /// Encoded/decoded by serializers as &quot;PECA&quot;.
    /// </summary>
    [EnumMember(Value = "PECA")]
    [IsoId("_ZDPgJNp-Ed-ak6NoX_4Aeg_-1247223447")]
    [Description(
        @"Balance of securities, before ex-date, that are involved in a corporate action (CA). Securities blocked due to a CA, for example, proxi, in escrow, are to be identified in the BLOK sub-balance."
    )]
    PendingCorporateAction,

    /// <summary>
    /// Balance of securities that are pending delivery.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZDPgJdp-Ed-ak6NoX_4Aeg_-1247223370")]
    [Description(@"Balance of securities that are pending delivery.")]
    PendingDelivery,

    /// <summary>
    /// Balance of securities that are pending receipt.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_ZDPgJtp-Ed-ak6NoX_4Aeg_-1247223317")]
    [Description(@"Balance of securities that are pending receipt.")]
    PendingReceipt,

    /// <summary>
    /// Balance of securities that are pledged, for example, a financial instrument is unavailable because it has been used or given as a guarantee.
    /// Encoded/decoded by serializers as &quot;PLED&quot;.
    /// </summary>
    [EnumMember(Value = "PLED")]
    [IsoId("_ZDPgJ9p-Ed-ak6NoX_4Aeg_-1247223232")]
    [Description(
        @"Balance of securities that are pledged, for example, a financial instrument is unavailable because it has been used or given as a guarantee."
    )]
    Pledged,

    /// <summary>
    /// Balance of securities currently being processed by the institution responsible for registering the new beneficial owner (or nominee) of securities after a transaction has settled.
    /// Encoded/decoded by serializers as &quot;REGO&quot;.
    /// </summary>
    [EnumMember(Value = "REGO")]
    [IsoId("_ZDPgKNp-Ed-ak6NoX_4Aeg_-1247223162")]
    [Description(
        @"Balance of securities currently being processed by the institution responsible for registering the new beneficial owner (or nominee) of securities after a transaction has settled."
    )]
    OutForRegistration,

    /// <summary>
    /// Balance of securities that may only be sold under certain conditions or require legal documents.
    /// Encoded/decoded by serializers as &quot;RSTR&quot;.
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_ZDPgKdp-Ed-ak6NoX_4Aeg_-1247222860")]
    [Description(
        @"Balance of securities that may only be sold under certain conditions or require legal documents."
    )]
    Restricted,

    /// <summary>
    /// Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZDZRINp-Ed-ak6NoX_4Aeg_-1247222808")]
    [Description(
        @"Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types."
    )]
    Unclassified,

    /// <summary>
    /// Balance of physical securities that are in transshipment, eg, in the process of being transferred from one depository or agent to another.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ZDZRIdp-Ed-ak6NoX_4Aeg_-1247222482")]
    [Description(
        @"Balance of physical securities that are in transshipment, eg, in the process of being transferred from one depository or agent to another."
    )]
    InTransshipment,

    /// <summary>
    /// Balance of securities that are drawn for redemption.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_ZDZRItp-Ed-ak6NoX_4Aeg_-1247222404")]
    [Description(@"Balance of securities that are drawn for redemption.")]
    Drawn,

    /// <summary>
    /// Balance of tax-exempt securities.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_ZDZRI9p-Ed-ak6NoX_4Aeg_1853365721")]
    [Description(@"Balance of tax-exempt securities.")]
    TaxExempt,

    /// <summary>
    /// Balance of taxable securities.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_ZDZRJNp-Ed-ak6NoX_4Aeg_1853365998")]
    [Description(@"Balance of taxable securities.")]
    NonTaxExempt,

    /// <summary>
    /// Balance of securities that are registered (in the name of a nominee or of the beneficial owner).
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_ZDZRJdp-Ed-ak6NoX_4Aeg_1853366076")]
    [Description(
        @"Balance of securities that are registered (in the name of a nominee or of the beneficial owner)."
    )]
    Registered,

    /// <summary>
    /// Balance of securities that remain registered in the name of the prior beneficial owner of securities.
    /// Encoded/decoded by serializers as &quot;SPOS&quot;.
    /// </summary>
    [EnumMember(Value = "SPOS")]
    [IsoId("_ZDZRJtp-Ed-ak6NoX_4Aeg_1853366496")]
    [Description(
        @"Balance of securities that remain registered in the name of the prior beneficial owner of securities."
    )]
    StreetPosition,

    /// <summary>
    /// Balance of securities that could not be registered due to foreign ownership limitation.
    /// Encoded/decoded by serializers as &quot;UNRG&quot;.
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_ZDZRJ9p-Ed-ak6NoX_4Aeg_1853366574")]
    [Description(
        @"Balance of securities that could not be registered due to foreign ownership limitation."
    )]
    Unregistered,

    /// <summary>
    /// Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order.
    /// Encoded/decoded by serializers as &quot;WDOC&quot;.
    /// </summary>
    [EnumMember(Value = "WDOC")]
    [IsoId("_ZDZRKNp-Ed-ak6NoX_4Aeg_1853366669")]
    [Description(
        @"Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order."
    )]
    WaitingDocumentation,

    /// <summary>
    /// Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders&apos; register.
    /// Encoded/decoded by serializers as &quot;BTRA&quot;.
    /// </summary>
    [EnumMember(Value = "BTRA")]
    [IsoId("_ZDZRKdp-Ed-ak6NoX_4Aeg_2038160479")]
    [Description(
        @"Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders' register."
    )]
    BeingTransferred,

    /// <summary>
    /// Investment fund order contains a side pocket component.
    /// Encoded/decoded by serializers as &quot;SPCM&quot;.
    /// </summary>
    [EnumMember(Value = "SPCM")]
    [IsoId("_ZDZRKtp-Ed-ak6NoX_4Aeg_1829884089")]
    [Description(@"Investment fund order contains a side pocket component.")]
    SidePocketComponent,

    /// <summary>
    /// Investment fund order execution subject to redemption proceeds.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_ZDibENp-Ed-ak6NoX_4Aeg_1829884202")]
    [Description(@"Investment fund order execution subject to redemption proceeds.")]
    Holdback,

    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_ZDibEdp-Ed-ak6NoX_4Aeg_-878888447")]
    [Description(
        @"Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance."
    )]
    TotalEligibleBalance,

    /// <summary>
    /// Balance to which the payment applies (less or equal to the total eligible balance).
    /// Encoded/decoded by serializers as &quot;CONB&quot;.
    /// </summary>
    [EnumMember(Value = "CONB")]
    [IsoId("_ZDibEtp-Ed-ak6NoX_4Aeg_-988095178")]
    [Description(
        @"Balance to which the payment applies (less or equal to the total eligible balance)."
    )]
    ConfirmedBalance,

    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_ZDibE9p-Ed-ak6NoX_4Aeg_-1435171556")]
    [Description(
        @"Balance of securities representing only settled transactions; pending transactions not included."
    )]
    SettlementPositionBalance,

    /// <summary>
    /// Balance of securities based on trade date, eg, includes all pending transactions in addition to the balance of settled transactions.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZDibFNp-Ed-ak6NoX_4Aeg_-1123223113")]
    [Description(
        @"Balance of securities based on trade date, eg, includes all pending transactions in addition to the balance of settled transactions."
    )]
    TradeDatePositionBalance,

    /// <summary>
    /// Position that account holders should return to the account servicer to participate in the event or to fulfil their obligation for the event to be complete, eg, return of securities for late announced drawing.
    /// Encoded/decoded by serializers as &quot;OBAL&quot;.
    /// </summary>
    [EnumMember(Value = "OBAL")]
    [IsoId("_ZDibFdp-Ed-ak6NoX_4Aeg_1235070314")]
    [Description(
        @"Position that account holders should return to the account servicer to participate in the event or to fulfil their obligation for the event to be complete, eg, return of securities for late announced drawing."
    )]
    ObligatedBalance,

    /// <summary>
    /// Balance of uninstructed position.
    /// Encoded/decoded by serializers as &quot;UNBA&quot;.
    /// </summary>
    [EnumMember(Value = "UNBA")]
    [IsoId("_ZDibFtp-Ed-ak6NoX_4Aeg_-252208680")]
    [Description(@"Balance of uninstructed position.")]
    UninstructedBalance,

    /// <summary>
    /// Balance of instructed position per option.
    /// Encoded/decoded by serializers as &quot;INBA&quot;.
    /// </summary>
    [EnumMember(Value = "INBA")]
    [IsoId("_ZDibF9p-Ed-ak6NoX_4Aeg_789349849")]
    [Description(@"Balance of instructed position per option.")]
    InstructedBalance,

    /// <summary>
    /// Balance of total instructed position (for all options).
    /// Encoded/decoded by serializers as &quot;TIBA&quot;.
    /// </summary>
    [EnumMember(Value = "TIBA")]
    [IsoId("_ZDibGNp-Ed-ak6NoX_4Aeg_-577949399")]
    [Description(@"Balance of total instructed position (for all options).")]
    TotalInstructedBalance,

    /// <summary>
    /// Balance that has been affected by the process run through the event.
    /// Encoded/decoded by serializers as &quot;AFFB&quot;.
    /// </summary>
    [EnumMember(Value = "AFFB")]
    [IsoId("_ZDibGdp-Ed-ak6NoX_4Aeg_251148702")]
    [Description(@"Balance that has been affected by the process run through the event.")]
    AffectedBalance,

    /// <summary>
    /// Balance that has not been affected by the process run through the event.
    /// Encoded/decoded by serializers as &quot;UNAF&quot;.
    /// </summary>
    [EnumMember(Value = "UNAF")]
    [IsoId("_ZDsMENp-Ed-ak6NoX_4Aeg_-1115285330")]
    [Description(@"Balance that has not been affected by the process run through the event.")]
    UnaffectedBalance,

    /// <summary>
    /// Balance not available for general redemption.
    /// Encoded/decoded by serializers as &quot;CTRD&quot;.
    /// </summary>
    [EnumMember(Value = "CTRD")]
    [IsoId("_ERUkoN6REeSz44MWaJb4-Q")]
    [Description(@"Balance not available for general redemption.")]
    ContingentRedemption,
}
