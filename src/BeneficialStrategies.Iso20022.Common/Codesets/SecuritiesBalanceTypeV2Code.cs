// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZDsMEdp-Ed-ak6NoX_4Aeg_29532225")]
[Description(@"Specifies the nature of the securities or investment fund balance.")]
[Derivations(typeof(SecuritiesBalanceType5Code),typeof(SecuritiesBalanceType11Code),typeof(SecuritiesBalanceType13Code),typeof(SecuritiesBalanceType12Code),typeof(SecuritiesBalanceType7Code),typeof(SecuritiesBalanceType8Code))]
public enum SecuritiesBalanceTypeV2Code
{
    /// <summary>
    /// Balance of financial instruments that are freely available with no specific additional status.
    /// Encoded/decoded by serializers as &quot;AWAS&quot;.
    /// </summary>
    [EnumMember(Value = "AWAS")]
    [IsoId("_ZDsME9p-Ed-ak6NoX_4Aeg_445115191")]
    [Description(@"Balance of financial instruments that are freely available with no specific additional status.")]
    AvailableWithNoAdditionalStatus,
    
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// Encoded/decoded by serializers as &quot;BLOK&quot;.
    /// </summary>
    [EnumMember(Value = "BLOK")]
    [IsoId("_ZDsMEtp-Ed-ak6NoX_4Aeg_29532242")]
    [Description(@"Balance of financial instruments that are blocked.")]
    Blocked,
    
    /// <summary>
    /// Balance of financial instruments that are available.
    /// Encoded/decoded by serializers as &quot;AVAI&quot;.
    /// </summary>
    [EnumMember(Value = "AVAI")]
    [IsoId("_ZDsMFNp-Ed-ak6NoX_4Aeg_-1755138901")]
    [Description(@"Balance of financial instruments that are available.")]
    Available,
    
    /// <summary>
    /// Balance of financial instrument blocked following a corporate action, including proxy activities.
    /// Encoded/decoded by serializers as &quot;BLCA&quot;.
    /// </summary>
    [EnumMember(Value = "BLCA")]
    [IsoId("_ZDsMFdp-Ed-ak6NoX_4Aeg_511608236")]
    [Description(@"Balance of financial instrument blocked following a corporate action, including proxy activities.")]
    BlockedCorporateAction,
    
    /// <summary>
    /// Balance of financial instruments that are blocked for trading.
    /// Encoded/decoded by serializers as &quot;BLOT&quot;.
    /// </summary>
    [EnumMember(Value = "BLOT")]
    [IsoId("_ZDsMFtp-Ed-ak6NoX_4Aeg_772967498")]
    [Description(@"Balance of financial instruments that are blocked for trading.")]
    BlockedTrading,
    
    /// <summary>
    /// Balance of financial instruments that are blocked for verification of authenticity.
    /// Encoded/decoded by serializers as &quot;BLOV&quot;.
    /// </summary>
    [EnumMember(Value = "BLOV")]
    [IsoId("_ZDsMF9p-Ed-ak6NoX_4Aeg_814524921")]
    [Description(@"Balance of financial instruments that are blocked for verification of authenticity.")]
    BlockedAuthenticity,
    
    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// Encoded/decoded by serializers as &quot;BORR&quot;.
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_ZDsMGNp-Ed-ak6NoX_4Aeg_29532285")]
    [Description(@"Balance of financial instruments that have been borrowed from another party.")]
    Borrowed,
    
    /// <summary>
    /// Balance of financial instruments that are pending delivery in relation to a borrow transaction.
    /// Encoded/decoded by serializers as &quot;BODE&quot;.
    /// </summary>
    [EnumMember(Value = "BODE")]
    [IsoId("_ZDsMGdp-Ed-ak6NoX_4Aeg_891175274")]
    [Description(@"Balance of financial instruments that are pending delivery in relation to a borrow transaction.")]
    PendingBorrowedDelivery,
    
    /// <summary>
    /// Balance of financial instruments that are pending receipt in relation to a borrow transaction.
    /// Encoded/decoded by serializers as &quot;BORE&quot;.
    /// </summary>
    [EnumMember(Value = "BORE")]
    [IsoId("_ZD19ENp-Ed-ak6NoX_4Aeg_1178392362")]
    [Description(@"Balance of financial instruments that are pending receipt in relation to a borrow transaction.")]
    PendingBorrowedReceipt,
    
    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_ZD19Edp-Ed-ak6NoX_4Aeg_29532302")]
    [Description(@"Balance of securities that belong to a third party and that are held for the purpose of collateralisation.")]
    CollateralIn,
    
    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_ZD19Etp-Ed-ak6NoX_4Aeg_29532320")]
    [Description(@"Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.")]
    CollateralOut,
    
    /// <summary>
    /// Balance of securities that are eligible for use for collateral purposes.
    /// Encoded/decoded by serializers as &quot;COLA&quot;.
    /// </summary>
    [EnumMember(Value = "COLA")]
    [IsoId("_ZD19E9p-Ed-ak6NoX_4Aeg_1229185525")]
    [Description(@"Balance of securities that are eligible for use for collateral purposes.")]
    EligibleForCollateralPurposes,
    
    /// <summary>
    /// Loan for consumption.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_ZD19FNp-Ed-ak6NoX_4Aeg_29532321")]
    [Description(@"Loan for consumption.")]
    OnLoan,
    
    /// <summary>
    /// Balance of financial instruments that are pending delivery in relation to a lending transaction.
    /// Encoded/decoded by serializers as &quot;LODE&quot;.
    /// </summary>
    [EnumMember(Value = "LODE")]
    [IsoId("_ZD19Fdp-Ed-ak6NoX_4Aeg_1359401362")]
    [Description(@"Balance of financial instruments that are pending delivery in relation to a lending transaction.")]
    PendingOnLoanDelivery,
    
    /// <summary>
    /// Balance of financial instruments that are pending receipt in relation to a lending transaction.
    /// Encoded/decoded by serializers as &quot;LORE&quot;.
    /// </summary>
    [EnumMember(Value = "LORE")]
    [IsoId("_ZD19Ftp-Ed-ak6NoX_4Aeg_1400961808")]
    [Description(@"Balance of financial instruments that are pending receipt in relation to a lending transaction.")]
    PendingOnLoanReceipt,
    
    /// <summary>
    /// Account is used when financing is by the broker/dealer.
    /// Encoded/decoded by serializers as &quot;MARG&quot;.
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_ZD19F9p-Ed-ak6NoX_4Aeg_29532562")]
    [Description(@"Account is used when financing is by the broker/dealer.")]
    DerivativesMargin,
    
    /// <summary>
    /// Balance of financial instruments pending delivery that have been matched.
    /// Encoded/decoded by serializers as &quot;PDMT&quot;.
    /// </summary>
    [EnumMember(Value = "PDMT")]
    [IsoId("_ZD19GNp-Ed-ak6NoX_4Aeg_29532563")]
    [Description(@"Balance of financial instruments pending delivery that have been matched.")]
    PendingDeliveryMatchedBalance,
    
    /// <summary>
    /// Balance of financial instruments pending delivery that have been unmatched.
    /// Encoded/decoded by serializers as &quot;PDUM&quot;.
    /// </summary>
    [EnumMember(Value = "PDUM")]
    [IsoId("_ZD19Gdp-Ed-ak6NoX_4Aeg_29532579")]
    [Description(@"Balance of financial instruments pending delivery that have been unmatched.")]
    PendingDeliveryUnmatchedBalance,
    
    /// <summary>
    /// Balance of financial instruments pending receipt that have been matched.
    /// Encoded/decoded by serializers as &quot;PRMT&quot;.
    /// </summary>
    [EnumMember(Value = "PRMT")]
    [IsoId("_ZD19Gtp-Ed-ak6NoX_4Aeg_29532580")]
    [Description(@"Balance of financial instruments pending receipt that have been matched.")]
    PendingReceiptMatchedBalance,
    
    /// <summary>
    /// Balance of financial instruments pending receipt that are unmatched.
    /// Encoded/decoded by serializers as &quot;PRUM&quot;.
    /// </summary>
    [EnumMember(Value = "PRUM")]
    [IsoId("_ZD_HANp-Ed-ak6NoX_4Aeg_29532581")]
    [Description(@"Balance of financial instruments pending receipt that are unmatched.")]
    PendingReceiptUnmatchedBalance,
    
    /// <summary>
    /// Balance of financial instrument pending receipt following a corporate action.
    /// Encoded/decoded by serializers as &quot;PECA&quot;.
    /// </summary>
    [EnumMember(Value = "PECA")]
    [IsoId("_ZD_HAdp-Ed-ak6NoX_4Aeg_29532597")]
    [Description(@"Balance of financial instrument pending receipt following a corporate action.")]
    PendingCorporateActionReceipt,
    
    /// <summary>
    /// Balance of financial instrument pending delivery following a corporate action.
    /// Encoded/decoded by serializers as &quot;PEDA&quot;.
    /// </summary>
    [EnumMember(Value = "PEDA")]
    [IsoId("_ZD_HAtp-Ed-ak6NoX_4Aeg_1690020982")]
    [Description(@"Balance of financial instrument pending delivery following a corporate action.")]
    PendingCorporateActionDelivery,
    
    /// <summary>
    /// Processing has not been completed.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZD_HA9p-Ed-ak6NoX_4Aeg_29532623")]
    [Description(@"Processing has not been completed.")]
    PendingDelivery,
    
    /// <summary>
    /// The instruction is pending receipt of securities, for example, from a purchase, loan etc.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_ZD_HBNp-Ed-ak6NoX_4Aeg_29532624")]
    [Description(@"The instruction is pending receipt of securities, for example, from a purchase, loan etc.")]
    PendingReceipt,
    
    /// <summary>
    /// Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged.
    /// Encoded/decoded by serializers as &quot;PLED&quot;.
    /// </summary>
    [EnumMember(Value = "PLED")]
    [IsoId("_ZD_HBdp-Ed-ak6NoX_4Aeg_29532640")]
    [Description(@"Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged.")]
    Pledged,
    
    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// Encoded/decoded by serializers as &quot;REGO&quot;.
    /// </summary>
    [EnumMember(Value = "REGO")]
    [IsoId("_ZD_HBtp-Ed-ak6NoX_4Aeg_29532641")]
    [Description(@"Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).")]
    OutForRegistration,
    
    /// <summary>
    /// Balance of financial instruments that may only be sold under certain conditions or require legal documents.
    /// Encoded/decoded by serializers as &quot;RSTR&quot;.
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_ZD_HB9p-Ed-ak6NoX_4Aeg_29532658")]
    [Description(@"Balance of financial instruments that may only be sold under certain conditions or require legal documents.")]
    Restricted,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZD_HCNp-Ed-ak6NoX_4Aeg_29532659")]
    [Description(@"Other. See Narrative.")]
    Unclassified,
    
    /// <summary>
    /// Transaction has been generated due to transformation following a corporate action.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ZD_HCdp-Ed-ak6NoX_4Aeg_29532675")]
    [Description(@"Transaction has been generated due to transformation following a corporate action.")]
    InTransshipment,
    
    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_ZEI4ANp-Ed-ak6NoX_4Aeg_29532676")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn,
    
    /// <summary>
    /// Tax-exempt financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_ZEI4Adp-Ed-ak6NoX_4Aeg_29532693")]
    [Description(@"Tax-exempt financial instruments are to be settled.")]
    TaxExempt,
    
    /// <summary>
    /// Taxable financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_ZEI4Atp-Ed-ak6NoX_4Aeg_29532694")]
    [Description(@"Taxable financial instruments are to be settled.")]
    NonTaxExempt,
    
    /// <summary>
    /// Balance of financial instruments that are registered (in nominee name or in the name of the beneficial owner).
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_ZEI4A9p-Ed-ak6NoX_4Aeg_29532718")]
    [Description(@"Balance of financial instruments that are registered (in nominee name or in the name of the beneficial owner).")]
    Registered,
    
    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// Encoded/decoded by serializers as &quot;SPOS&quot;.
    /// </summary>
    [EnumMember(Value = "SPOS")]
    [IsoId("_ZEI4BNp-Ed-ak6NoX_4Aeg_29532735")]
    [Description(@"Balance of financial instruments that remain registered in the name of the prior beneficial owner.")]
    StreetPosition,
    
    /// <summary>
    /// Balance of securities that could not be registered due to foreign ownership limitation.
    /// Encoded/decoded by serializers as &quot;UNRG&quot;.
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_ZEI4Bdp-Ed-ak6NoX_4Aeg_29532736")]
    [Description(@"Balance of securities that could not be registered due to foreign ownership limitation.")]
    Unregistered,
    
    /// <summary>
    /// Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order.
    /// Encoded/decoded by serializers as &quot;WDOC&quot;.
    /// </summary>
    [EnumMember(Value = "WDOC")]
    [IsoId("_ZEI4Btp-Ed-ak6NoX_4Aeg_29533001")]
    [Description(@"Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order.")]
    WaitingDocumentation,
    
    /// <summary>
    /// Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders&apos; register.
    /// Encoded/decoded by serializers as &quot;BTRA&quot;.
    /// </summary>
    [EnumMember(Value = "BTRA")]
    [IsoId("_ZEI4B9p-Ed-ak6NoX_4Aeg_29533002")]
    [Description(@"Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders' register.")]
    BeingTransferred,
    
    /// <summary>
    /// In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has been received.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_ZEI4CNp-Ed-ak6NoX_4Aeg_-828449592")]
    [Description(@"In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has been received.")]
    Issued,
    
    /// <summary>
    /// In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has not yet been received.
    /// Encoded/decoded by serializers as &quot;QUAS&quot;.
    /// </summary>
    [EnumMember(Value = "QUAS")]
    [IsoId("_ZE4e4Np-Ed-ak6NoX_4Aeg_-797974418")]
    [Description(@"In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has not yet been received.")]
    QuasiIssued,
    
}
