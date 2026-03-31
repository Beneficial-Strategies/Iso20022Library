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
[IsoId("_Y_N7xtp-Ed-ak6NoX_4Aeg_1932339266")]
[Description(@"Specifies the nature of the securities or investment fund balance.")]
[DerivedFrom(typeof(SecuritiesBalanceTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SecuritiesBalanceType11Code>))]
#endif
public enum SecuritiesBalanceType11Code
{
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// Encoded/decoded by serializers as &quot;BLOK&quot;.
    /// </summary>
    [EnumMember(Value = "BLOK")]
    [IsoId("_Y_N7x9p-Ed-ak6NoX_4Aeg_-1131601960")]
    [Description(@"Balance of financial instruments that are blocked.")]
    Blocked = SecuritiesBalanceTypeV2Code.Blocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are freely available with no specific additional status.
    /// Encoded/decoded by serializers as &quot;AWAS&quot;.
    /// </summary>
    [EnumMember(Value = "AWAS")]
    [IsoId("_Y_N7yNp-Ed-ak6NoX_4Aeg_-1045306225")]
    [Description(
        @"Balance of financial instruments that are freely available with no specific additional status."
    )]
    AvailableWithNoAdditionalStatus = SecuritiesBalanceTypeV2Code.AvailableWithNoAdditionalStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are available.
    /// Encoded/decoded by serializers as &quot;AVAI&quot;.
    /// </summary>
    [EnumMember(Value = "AVAI")]
    [IsoId("_Y_XswNp-Ed-ak6NoX_4Aeg_-720188718")]
    [Description(@"Balance of financial instruments that are available.")]
    Available = SecuritiesBalanceTypeV2Code.Available, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instrument blocked following a corporate action, including proxy activities.
    /// Encoded/decoded by serializers as &quot;BLCA&quot;.
    /// </summary>
    [EnumMember(Value = "BLCA")]
    [IsoId("_Y_Xswdp-Ed-ak6NoX_4Aeg_-2095113730")]
    [Description(
        @"Balance of financial instrument blocked following a corporate action, including proxy activities."
    )]
    BlockedCorporateAction = SecuritiesBalanceTypeV2Code.BlockedCorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are blocked for trading.
    /// Encoded/decoded by serializers as &quot;BLOT&quot;.
    /// </summary>
    [EnumMember(Value = "BLOT")]
    [IsoId("_Y_Xswtp-Ed-ak6NoX_4Aeg_-1641026461")]
    [Description(@"Balance of financial instruments that are blocked for trading.")]
    BlockedTrading = SecuritiesBalanceTypeV2Code.BlockedTrading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are blocked for verification of authenticity.
    /// Encoded/decoded by serializers as &quot;BLOV&quot;.
    /// </summary>
    [EnumMember(Value = "BLOV")]
    [IsoId("_Y_Xsw9p-Ed-ak6NoX_4Aeg_-1754865527")]
    [Description(
        @"Balance of financial instruments that are blocked for verification of authenticity."
    )]
    BlockedAuthenticity = SecuritiesBalanceTypeV2Code.BlockedAuthenticity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// Encoded/decoded by serializers as &quot;BORR&quot;.
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_Y_XsxNp-Ed-ak6NoX_4Aeg_-1652125238")]
    [Description(@"Balance of financial instruments that have been borrowed from another party.")]
    Borrowed = SecuritiesBalanceTypeV2Code.Borrowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_Y_Xsxdp-Ed-ak6NoX_4Aeg_1736267075")]
    [Description(
        @"Balance of securities that belong to a third party and that are held for the purpose of collateralisation."
    )]
    CollateralIn = SecuritiesBalanceTypeV2Code.CollateralIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_Y_Xsxtp-Ed-ak6NoX_4Aeg_1211316364")]
    [Description(
        @"Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation."
    )]
    CollateralOut = SecuritiesBalanceTypeV2Code.CollateralOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that are eligible for use for collateral purposes.
    /// Encoded/decoded by serializers as &quot;COLA&quot;.
    /// </summary>
    [EnumMember(Value = "COLA")]
    [IsoId("_Y_Xsx9p-Ed-ak6NoX_4Aeg_1097477298")]
    [Description(@"Balance of securities that are eligible for use for collateral purposes.")]
    EligibleForCollateralPurposes = SecuritiesBalanceTypeV2Code.EligibleForCollateralPurposes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Loan for consumption.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_Y_XsyNp-Ed-ak6NoX_4Aeg_1665403633")]
    [Description(@"Loan for consumption.")]
    OnLoan = SecuritiesBalanceTypeV2Code.OnLoan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is used when financing is by the broker/dealer.
    /// Encoded/decoded by serializers as &quot;MARG&quot;.
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_Y_Xsydp-Ed-ak6NoX_4Aeg_1229074531")]
    [Description(@"Account is used when financing is by the broker/dealer.")]
    DerivativesMargin = SecuritiesBalanceTypeV2Code.DerivativesMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instrument pending receipt following a corporate action.
    /// Encoded/decoded by serializers as &quot;PECA&quot;.
    /// </summary>
    [EnumMember(Value = "PECA")]
    [IsoId("_Y_Xsytp-Ed-ak6NoX_4Aeg_-1265093317")]
    [Description(@"Balance of financial instrument pending receipt following a corporate action.")]
    PendingCorporateActionReceipt = SecuritiesBalanceTypeV2Code.PendingCorporateActionReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instrument pending delivery following a corporate action.
    /// Encoded/decoded by serializers as &quot;PEDA&quot;.
    /// </summary>
    [EnumMember(Value = "PEDA")]
    [IsoId("_Y_g2sNp-Ed-ak6NoX_4Aeg_1299844056")]
    [Description(@"Balance of financial instrument pending delivery following a corporate action.")]
    PendingCorporateActionDelivery = SecuritiesBalanceTypeV2Code.PendingCorporateActionDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged.
    /// Encoded/decoded by serializers as &quot;PLED&quot;.
    /// </summary>
    [EnumMember(Value = "PLED")]
    [IsoId("_Y_g2sdp-Ed-ak6NoX_4Aeg_1511122497")]
    [Description(
        @"Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged."
    )]
    Pledged = SecuritiesBalanceTypeV2Code.Pledged, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// Encoded/decoded by serializers as &quot;REGO&quot;.
    /// </summary>
    [EnumMember(Value = "REGO")]
    [IsoId("_Y_g2stp-Ed-ak6NoX_4Aeg_-710112802")]
    [Description(
        @"Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee)."
    )]
    OutForRegistration = SecuritiesBalanceTypeV2Code.OutForRegistration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that may only be sold under certain conditions or require legal documents.
    /// Encoded/decoded by serializers as &quot;RSTR&quot;.
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_Y_g2s9p-Ed-ak6NoX_4Aeg_-823951868")]
    [Description(
        @"Balance of financial instruments that may only be sold under certain conditions or require legal documents."
    )]
    Restricted = SecuritiesBalanceTypeV2Code.Restricted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Y_g2tNp-Ed-ak6NoX_4Aeg_704123820")]
    [Description(@"Other. See Narrative.")]
    Unclassified = SecuritiesBalanceTypeV2Code.Unclassified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been generated due to transformation following a corporate action.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_Y_g2tdp-Ed-ak6NoX_4Aeg_590284754")]
    [Description(
        @"Transaction has been generated due to transformation following a corporate action."
    )]
    InTransshipment = SecuritiesBalanceTypeV2Code.InTransshipment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_Y_g2ttp-Ed-ak6NoX_4Aeg_69091974")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn = SecuritiesBalanceTypeV2Code.Drawn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax-exempt financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_Y_g2t9p-Ed-ak6NoX_4Aeg_-44747092")]
    [Description(@"Tax-exempt financial instruments are to be settled.")]
    TaxExempt = SecuritiesBalanceTypeV2Code.TaxExempt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Taxable financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_Y_g2uNp-Ed-ak6NoX_4Aeg_1744158115")]
    [Description(@"Taxable financial instruments are to be settled.")]
    NonTaxExempt = SecuritiesBalanceTypeV2Code.NonTaxExempt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are registered (in nominee name or in the name of the beneficial owner).
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_Y_qnsNp-Ed-ak6NoX_4Aeg_1630319049")]
    [Description(
        @"Balance of financial instruments that are registered (in nominee name or in the name of the beneficial owner)."
    )]
    Registered = SecuritiesBalanceTypeV2Code.Registered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// Encoded/decoded by serializers as &quot;SPOS&quot;.
    /// </summary>
    [EnumMember(Value = "SPOS")]
    [IsoId("_Y_qnsdp-Ed-ak6NoX_4Aeg_1228839835")]
    [Description(
        @"Balance of financial instruments that remain registered in the name of the prior beneficial owner."
    )]
    StreetPosition = SecuritiesBalanceTypeV2Code.StreetPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities that could not be registered due to foreign ownership limitation.
    /// Encoded/decoded by serializers as &quot;UNRG&quot;.
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_Y_qnstp-Ed-ak6NoX_4Aeg_1115000769")]
    [Description(
        @"Balance of securities that could not be registered due to foreign ownership limitation."
    )]
    Unregistered = SecuritiesBalanceTypeV2Code.Unregistered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has been received.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_Y_qns9p-Ed-ak6NoX_4Aeg_1671828327")]
    [Description(
        @"In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has been received."
    )]
    Issued = SecuritiesBalanceTypeV2Code.Issued, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has not yet been received.
    /// Encoded/decoded by serializers as &quot;QUAS&quot;.
    /// </summary>
    [EnumMember(Value = "QUAS")]
    [IsoId("_Y_qntNp-Ed-ak6NoX_4Aeg_1557989261")]
    [Description(
        @"In issuer agent / depository communication, balance of issued financial instruments for which legal documentation has not yet been received."
    )]
    QuasiIssued = SecuritiesBalanceTypeV2Code.QuasiIssued, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are pending delivery in relation to a lending transaction.
    /// Encoded/decoded by serializers as &quot;LODE&quot;.
    /// </summary>
    [EnumMember(Value = "LODE")]
    [IsoId("_Y_qntdp-Ed-ak6NoX_4Aeg_2091002022")]
    [Description(
        @"Balance of financial instruments that are pending delivery in relation to a lending transaction."
    )]
    PendingOnLoanDelivery = SecuritiesBalanceTypeV2Code.PendingOnLoanDelivery, // same ordinal as derivation source for type conversions
}
