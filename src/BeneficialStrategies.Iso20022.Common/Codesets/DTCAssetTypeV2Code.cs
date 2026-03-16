// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) security sub-issue type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0hBrIL_VEeeb2ZBoAlSG1Q")]
[Description(@"Specifies DTC (The Depository Trust Company) security sub-issue type.")]
[Derivations(typeof(DTCAssetType3Code))]
public enum DTCAssetTypeV2Code
{
    /// <summary>
    /// Asset is an equity.
    /// Encoded/decoded by serializers as &quot;S005&quot;.
    /// </summary>
    [EnumMember(Value = "S005")]
    [IsoId("_0hLbyr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an equity.")]
    Equity,

    /// <summary>
    /// Asset is a common stock.
    /// Encoded/decoded by serializers as &quot;S010&quot;.
    /// </summary>
    [EnumMember(Value = "S010")]
    [IsoId("_0hLb87_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a common stock.")]
    CommonStock,

    /// <summary>
    /// Asset is a convertible common stock.
    /// Encoded/decoded by serializers as &quot;S011&quot;.
    /// </summary>
    [EnumMember(Value = "S011")]
    [IsoId("_0hLcBL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a convertible common stock.")]
    ConvertibleCommonStock,

    /// <summary>
    /// Asset is a common stock real estate investment trust.
    /// Encoded/decoded by serializers as &quot;S012&quot;.
    /// </summary>
    [EnumMember(Value = "S012")]
    [IsoId("_0hLby7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a common stock real estate investment trust.")]
    CommonStockREIT,

    /// <summary>
    /// Asset is a preferred stock.
    /// Encoded/decoded by serializers as &quot;S020&quot;.
    /// </summary>
    [EnumMember(Value = "S020")]
    [IsoId("_0hBrKr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a preferred stock.")]
    PreferredStock,

    /// <summary>
    /// Asset is a preferred stock real estate investment trust.
    /// Encoded/decoded by serializers as &quot;S022&quot;.
    /// </summary>
    [EnumMember(Value = "S022")]
    [IsoId("_0hBrJb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a preferred stock real estate investment trust.")]
    PreferredStockREIT,

    /// <summary>
    /// Asset is a convertible preferred stock.
    /// Encoded/decoded by serializers as &quot;S023&quot;.
    /// </summary>
    [EnumMember(Value = "S023")]
    [IsoId("_0hLb5L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a convertible preferred stock.")]
    ConvertiblePreferredStock,

    /// <summary>
    /// Asset is a tender rate preferred stock.
    /// Encoded/decoded by serializers as &quot;S024&quot;.
    /// </summary>
    [EnumMember(Value = "S024")]
    [IsoId("_0hLb5b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a tender rate preferred stock.")]
    TenderRatePreferredStock,

    /// <summary>
    /// Asset is a limited partnership.
    /// Encoded/decoded by serializers as &quot;S030&quot;.
    /// </summary>
    [EnumMember(Value = "S030")]
    [IsoId("_0hBrKL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a limited partnership.")]
    LimitedPartnership,

    /// <summary>
    /// Asset is a collateralized mortgage obligation denomination in &quot;Units&quot; or &quot;Undivided Interest&quot;.
    /// Encoded/decoded by serializers as &quot;S040&quot;.
    /// </summary>
    [EnumMember(Value = "S040")]
    [IsoId("_0hLbyL_VEeeb2ZBoAlSG1Q")]
    [Description(
        @"Asset is a collateralized mortgage obligation denomination in ""Units"" or ""Undivided Interest""."
    )]
    CMODenominationUnitsOrUndividedInterest,

    /// <summary>
    /// Asset is an asset-backed security denomination in &quot;Units&quot; or &quot;Undivided Interest&quot;.
    /// Encoded/decoded by serializers as &quot;S041&quot;.
    /// </summary>
    [EnumMember(Value = "S041")]
    [IsoId("_0hLb4b_VEeeb2ZBoAlSG1Q")]
    [Description(
        @"Asset is an asset-backed security denomination in ""Units"" or ""Undivided Interest""."
    )]
    ABSDenominationUnitsOrUndividedInterest,

    /// <summary>
    /// Asset is an issue denomination in &quot;Units&quot; or &quot;Undivided Interest&quot;.
    /// Encoded/decoded by serializers as &quot;S042&quot;.
    /// </summary>
    [EnumMember(Value = "S042")]
    [IsoId("_0hLb_b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an issue denomination in ""Units"" or ""Undivided Interest"".")]
    IssueDenominationUnitsOrUndividedInterest,

    /// <summary>
    /// Asset is an auction rate preferred stock (ARPS).
    /// Encoded/decoded by serializers as &quot;S102&quot;.
    /// </summary>
    [EnumMember(Value = "S102")]
    [IsoId("_0hLb6r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an auction rate preferred stock (ARPS).")]
    AuctionRatePreferredStock,

    /// <summary>
    /// Asset is an American depositary receipt (ADR).
    /// Encoded/decoded by serializers as &quot;S110&quot;.
    /// </summary>
    [EnumMember(Value = "S110")]
    [IsoId("_0hLb97_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an American depositary receipt (ADR).")]
    AmericanDepositaryReceipt,

    /// <summary>
    /// Asset is a depositary share.
    /// Encoded/decoded by serializers as &quot;S111&quot;.
    /// </summary>
    [EnumMember(Value = "S111")]
    [IsoId("_0hLcAr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a depositary share.")]
    DepositaryShare,

    /// <summary>
    /// Asset is a municipal option call right.
    /// Encoded/decoded by serializers as &quot;S112&quot;.
    /// </summary>
    [EnumMember(Value = "S112")]
    [IsoId("_0hBrJ7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal option call right.")]
    MunicipalOptionCallRight,

    /// <summary>
    /// Asset is an exchange traded funds.
    /// Encoded/decoded by serializers as &quot;S117&quot;.
    /// </summary>
    [EnumMember(Value = "S117")]
    [IsoId("_0hLcBb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an exchange traded funds.")]
    ExchangeTradedFunds,

    /// <summary>
    /// Asset is a money market instrument preferred stock (in CP-like mode).
    /// Encoded/decoded by serializers as &quot;S120&quot;.
    /// </summary>
    [EnumMember(Value = "S120")]
    [IsoId("_0hBrKb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument preferred stock (in CP-like mode).")]
    MMIPreferredStockCPLike,

    /// <summary>
    /// Asset is a sealed envelope.
    /// Encoded/decoded by serializers as &quot;S125&quot;.
    /// </summary>
    [EnumMember(Value = "S125")]
    [IsoId("_0hLcB7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a sealed envelope.")]
    SealedEnvelope,

    /// <summary>
    /// Asset is a custody user CUSIP.
    /// Encoded/decoded by serializers as &quot;S126&quot;.
    /// </summary>
    [EnumMember(Value = "S126")]
    [IsoId("_0hLb7b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a custody user CUSIP.")]
    CustodyUserCUSIP,

    /// <summary>
    /// Asset is a real estate investment trust (REIT).
    /// Encoded/decoded by serializers as &quot;S130&quot;.
    /// </summary>
    [EnumMember(Value = "S130")]
    [IsoId("_0hLb8L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a real estate investment trust (REIT).")]
    RealEstateInvestmentTrust,

    /// <summary>
    /// Asset is a municipal bond.
    /// Encoded/decoded by serializers as &quot;S310&quot;.
    /// </summary>
    [EnumMember(Value = "S310")]
    [IsoId("_0hBrM7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal bond.")]
    MunicipalBond,

    /// <summary>
    /// Asset is a municipal note.
    /// Encoded/decoded by serializers as &quot;S311&quot;.
    /// </summary>
    [EnumMember(Value = "S311")]
    [IsoId("_0hBrMb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal note.")]
    MunicipalNote,

    /// <summary>
    /// Asset is a municipal auction rate note (ARN).
    /// Encoded/decoded by serializers as &quot;S312&quot;.
    /// </summary>
    [EnumMember(Value = "S312")]
    [IsoId("_0hBrL7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal auction rate note (ARN).")]
    MunicipalAuctionRateNote,

    /// <summary>
    /// Asset is a municipal variable mode obligation (VMO).
    /// Encoded/decoded by serializers as &quot;S313&quot;.
    /// </summary>
    [EnumMember(Value = "S313")]
    [IsoId("_0hBrNL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal variable mode obligation (VMO).")]
    MunicipalVariableModeObligation,

    /// <summary>
    /// Asset is a municipal variable rate demand obligation (VRDO).
    /// Encoded/decoded by serializers as &quot;S314&quot;.
    /// </summary>
    [EnumMember(Value = "S314")]
    [IsoId("_0hLb1r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal variable rate demand obligation (VRDO).")]
    MunicipalVariableRateDemandObligation,

    /// <summary>
    /// Asset is a municipal insured custodial receipt.
    /// Encoded/decoded by serializers as &quot;S315&quot;.
    /// </summary>
    [EnumMember(Value = "S315")]
    [IsoId("_0hBrLL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal insured custodial receipt.")]
    MunicipalInsuredCustodialReceipt,

    /// <summary>
    /// Asset is a money market instrument municipal variable rate demand obligation commercial paper.
    /// Encoded/decoded by serializers as &quot;S320&quot;.
    /// </summary>
    [EnumMember(Value = "S320")]
    [IsoId("_0hLbxb_VEeeb2ZBoAlSG1Q")]
    [Description(
        @"Asset is a money market instrument municipal variable rate demand obligation commercial paper."
    )]
    MMIMunicipalVariableRateDemandObligation,

    /// <summary>
    /// Asset is a money market instrument municipal commercial paper.
    /// Encoded/decoded by serializers as &quot;S330&quot;.
    /// </summary>
    [EnumMember(Value = "S330")]
    [IsoId("_0hLb1b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument municipal commercial paper.")]
    MMIMunicipalCommercialPaper,

    /// <summary>
    /// Asset is a bearer, callable zero coupon bond.
    /// Encoded/decoded by serializers as &quot;S340&quot;.
    /// </summary>
    [EnumMember(Value = "S340")]
    [IsoId("_0hLcCL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a bearer, callable zero coupon bond.")]
    BearerCallableZeroCouponBond,

    /// <summary>
    /// Asset is a government national mortgage association real estate mortgage investment conduit security.
    /// Encoded/decoded by serializers as &quot;S450&quot;.
    /// </summary>
    [EnumMember(Value = "S450")]
    [IsoId("_0hLbwr_VEeeb2ZBoAlSG1Q")]
    [Description(
        @"Asset is a government national mortgage association real estate mortgage investment conduit security."
    )]
    GNMARealEstateMortgageInvestmentConduit,

    /// <summary>
    /// Asset is a government national mortgage association pass-through security.
    /// Encoded/decoded by serializers as &quot;S451&quot;.
    /// </summary>
    [EnumMember(Value = "S451")]
    [IsoId("_0hLbzL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association pass-through security.")]
    GNMAPassThroughSecurity,

    /// <summary>
    /// Asset is a government national mortgage association serial note security.
    /// Encoded/decoded by serializers as &quot;S452&quot;.
    /// </summary>
    [EnumMember(Value = "S452")]
    [IsoId("_0hLb3r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association serial note security.")]
    GNMASerialNoteSecurity,

    /// <summary>
    /// Asset is a corporate bond (CB) Or a global corporate bond (GCB).
    /// Encoded/decoded by serializers as &quot;S500&quot;.
    /// </summary>
    [EnumMember(Value = "S500")]
    [IsoId("_0hBrIb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate bond (CB) Or a global corporate bond (GCB).")]
    CorporateBondOrGlobal,

    /// <summary>
    /// Asset is a money market instrument bankers&apos; acceptance note (BA).
    /// Encoded/decoded by serializers as &quot;S502&quot;.
    /// </summary>
    [EnumMember(Value = "S502")]
    [IsoId("_0hLbxr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument bankers' acceptance note (BA).")]
    MMIBankersAcceptanceNote,

    /// <summary>
    /// Asset is a money market instrument institutional certificates of deposit.
    /// Encoded/decoded by serializers as &quot;S504&quot;.
    /// </summary>
    [EnumMember(Value = "S504")]
    [IsoId("_0hLb8b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument institutional certificates of deposit.")]
    MMIInstitutionalCertificatesOfDeposit,

    /// <summary>
    /// Asset is a certificated money market instrument.
    /// Encoded/decoded by serializers as &quot;S505&quot;.
    /// </summary>
    [EnumMember(Value = "S505")]
    [IsoId("_0hLcA7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a certificated money market instrument.")]
    CertificatedMoneyMarketInstrument,

    /// <summary>
    /// Asset is a certificated money market - periodic payer.
    /// Encoded/decoded by serializers as &quot;S506&quot;.
    /// </summary>
    [EnumMember(Value = "S506")]
    [IsoId("_0hLbx7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a certificated money market - periodic payer.")]
    CertificatedMoneyMarketPeriodicPayer,

    /// <summary>
    /// Asset is a certificates of deposit.
    /// Encoded/decoded by serializers as &quot;S507&quot;.
    /// </summary>
    [EnumMember(Value = "S507")]
    [IsoId("_0hLb5r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a certificates of deposit.")]
    CertificatesOfDeposit,

    /// <summary>
    /// Asset is a consumer price index interest at maturity (IAM) commercial paper.
    /// Encoded/decoded by serializers as &quot;S510&quot;.
    /// </summary>
    [EnumMember(Value = "S510")]
    [IsoId("_0hBrIr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a consumer price index interest at maturity (IAM) commercial paper.")]
    ConsumerPriceIndexAtMaturityCP,

    /// <summary>
    /// Asset is a periodic payment commercial paper.
    /// Encoded/decoded by serializers as &quot;S511&quot;.
    /// </summary>
    [EnumMember(Value = "S511")]
    [IsoId("_0hLb17_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a periodic payment commercial paper.")]
    PeriodicPaymentCommercialPaper,

    /// <summary>
    /// Asset is a consumer price index discount commercial paper.
    /// Encoded/decoded by serializers as &quot;S520&quot;.
    /// </summary>
    [EnumMember(Value = "S520")]
    [IsoId("_0hLbwb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a consumer price index discount commercial paper.")]
    ConsumerPriceIndexDiscountCP,

    /// <summary>
    /// Asset is a money market instrument corporate commercial paper.
    /// Encoded/decoded by serializers as &quot;S525&quot;.
    /// </summary>
    [EnumMember(Value = "S525")]
    [IsoId("_0hLbz7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument corporate commercial paper.")]
    MMICorporateCommercialPaper,

    /// <summary>
    /// Asset is a money market instrument corporate variable rate demand obligation commercial paper.
    /// Encoded/decoded by serializers as &quot;S526&quot;.
    /// </summary>
    [EnumMember(Value = "S526")]
    [IsoId("_0hLb77_VEeeb2ZBoAlSG1Q")]
    [Description(
        @"Asset is a money market instrument corporate variable rate demand obligation commercial paper."
    )]
    MMICorporateVariableRateDemandObligation,

    /// <summary>
    /// Asset is a medium term note (MTN).
    /// Encoded/decoded by serializers as &quot;S530&quot;.
    /// </summary>
    [EnumMember(Value = "S530")]
    [IsoId("_0hLb-L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a medium term note (MTN).")]
    MediumTermNote,

    /// <summary>
    /// Asset is a money market instrument deposit note.
    /// Encoded/decoded by serializers as &quot;S531&quot;.
    /// </summary>
    [EnumMember(Value = "S531")]
    [IsoId("_0hBrML_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument deposit note.")]
    MMIDepositNote,

    /// <summary>
    /// Asset is a money market instrument medium-term bank note.
    /// Encoded/decoded by serializers as &quot;S532&quot;.
    /// </summary>
    [EnumMember(Value = "S532")]
    [IsoId("_0hLb3L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument medium-term bank note.")]
    MMIMediumTermBankNote,

    /// <summary>
    /// Asset is a money market instrument medium term note.
    /// Encoded/decoded by serializers as &quot;S533&quot;.
    /// </summary>
    [EnumMember(Value = "S533")]
    [IsoId("_0hLb_7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument medium term note.")]
    MMIMediumTermNote,

    /// <summary>
    /// Asset is a collateralized mortgage obligation or global collateralized mortgage obligation.
    /// Encoded/decoded by serializers as &quot;S540&quot;.
    /// </summary>
    [EnumMember(Value = "S540")]
    [IsoId("_0hLb_r_VEeeb2ZBoAlSG1Q")]
    [Description(
        @"Asset is a collateralized mortgage obligation or global collateralized mortgage obligation."
    )]
    CollateralizedMortgageObligationOrGlobal,

    /// <summary>
    /// Asset is an asset-backed security (ABS) or global asset backed security (GABS).
    /// Encoded/decoded by serializers as &quot;S541&quot;.
    /// </summary>
    [EnumMember(Value = "S541")]
    [IsoId("_0hLb9b_VEeeb2ZBoAlSG1Q")]
    [Description(
        @"Asset is an asset-backed security (ABS) or global asset backed security (GABS)."
    )]
    AssetBackedSecurityOrGlobal,

    /// <summary>
    /// Asset is a non-collateralized mortgage obligation ABS amortizing issue.
    /// Encoded/decoded by serializers as &quot;S542&quot;.
    /// </summary>
    [EnumMember(Value = "S542")]
    [IsoId("_0hLbwL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a non-collateralized mortgage obligation ABS amortizing issue.")]
    NonCMOABSAmortizingIssue,

    /// <summary>
    /// MMI Short-Term Bank Note.
    /// Encoded/decoded by serializers as &quot;S550&quot;.
    /// </summary>
    [EnumMember(Value = "S550")]
    [IsoId("_0hLb0r_VEeeb2ZBoAlSG1Q")]
    [Description(@"MMI Short-Term Bank Note.")]
    MMIShortTermBankNote,

    /// <summary>
    /// Asset is a zero coupon denomination in initial principal amount.
    /// Encoded/decoded by serializers as &quot;S551&quot;.
    /// </summary>
    [EnumMember(Value = "S551")]
    [IsoId("_0hLbzb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a zero coupon denomination in initial principal amount.")]
    ZCPNDenominationInitialPrincipalAmount,

    /// <summary>
    /// Asset is a money market instrument discount note.
    /// Encoded/decoded by serializers as &quot;S560&quot;.
    /// </summary>
    [EnumMember(Value = "S560")]
    [IsoId("_0hLb9r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument discount note.")]
    MMIDiscountNote,

    /// <summary>
    /// Asset is a corporate auction rate note.
    /// Encoded/decoded by serializers as &quot;S571&quot;.
    /// </summary>
    [EnumMember(Value = "S571")]
    [IsoId("_0hLb2r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate auction rate note.")]
    CorporateAuctionRateNote,

    /// <summary>
    /// Asset is a convertible corporate debt.
    /// Encoded/decoded by serializers as &quot;S572&quot;.
    /// </summary>
    [EnumMember(Value = "S572")]
    [IsoId("_0hLcAL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a convertible corporate debt.")]
    ConvertibleCorporateDebt,

    /// <summary>
    /// Asset is a corporate variable mode obligation (CVMO).
    /// Encoded/decoded by serializers as &quot;S573&quot;.
    /// </summary>
    [EnumMember(Value = "S573")]
    [IsoId("_0hLbyb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate variable mode obligation (CVMO).")]
    CorporateVariableModeObligation,

    /// <summary>
    /// Asset is a corporate short-term note.
    /// Encoded/decoded by serializers as &quot;S574&quot;.
    /// </summary>
    [EnumMember(Value = "S574")]
    [IsoId("_0hLb07_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate short-term note.")]
    CorporateShortTermNote,

    /// <summary>
    /// Asset is a corporate debenture.
    /// Encoded/decoded by serializers as &quot;S575&quot;.
    /// </summary>
    [EnumMember(Value = "S575")]
    [IsoId("_0hLb2L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate debenture.")]
    CorporateDebenture,

    /// <summary>
    /// Asset is a corporate variable rate demand obligation or a municipal variable rate demand obligation (MMD).
    /// Encoded/decoded by serializers as &quot;S576&quot;.
    /// </summary>
    [EnumMember(Value = "S576")]
    [IsoId("_0hBrMr_VEeeb2ZBoAlSG1Q")]
    [Description(
        @"Asset is a corporate variable rate demand obligation or a municipal variable rate demand obligation (MMD)."
    )]
    CorporateOrMunicipalVariableRateDemandObligation,

    /// <summary>
    /// Asset is a corporate insured custodial receipt.
    /// Encoded/decoded by serializers as &quot;S577&quot;.
    /// </summary>
    [EnumMember(Value = "S577")]
    [IsoId("_0hLb6b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate insured custodial receipt.")]
    CorporateInsuredCustodialReceipt,

    /// <summary>
    /// Asset is a tender rate note.
    /// Encoded/decoded by serializers as &quot;S578&quot;.
    /// </summary>
    [EnumMember(Value = "S578")]
    [IsoId("_0hLb-b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a tender rate note.")]
    TenderRateNote,

    /// <summary>
    /// Asset is a zero coupon bond.
    /// Encoded/decoded by serializers as &quot;S579&quot;.
    /// </summary>
    [EnumMember(Value = "S579")]
    [IsoId("_0hLbzr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a zero coupon bond.")]
    ZeroCouponBond,

    /// <summary>
    /// Asset is a government national mortgage association government security.
    /// Encoded/decoded by serializers as &quot;S601&quot;.
    /// </summary>
    [EnumMember(Value = "S601")]
    [IsoId("_0hLb6L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association government security.")]
    GovernmentSecurity,

    /// <summary>
    /// Asset is a government trust certificate.
    /// Encoded/decoded by serializers as &quot;S602&quot;.
    /// </summary>
    [EnumMember(Value = "S602")]
    [IsoId("_0hLb4L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government trust certificate.")]
    GovernmentTrustCertificate,

    /// <summary>
    /// Asset is a junk and treasury growth receipt (JGR).
    /// Encoded/decoded by serializers as &quot;S603&quot;.
    /// </summary>
    [EnumMember(Value = "S603")]
    [IsoId("_0hLb-r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a junk and treasury growth receipt (JGR).")]
    JunkAndTreasuryGrowthReceipt,

    /// <summary>
    /// Asset is a U.S. treasury security.
    /// Encoded/decoded by serializers as &quot;S610&quot;.
    /// </summary>
    [EnumMember(Value = "S610")]
    [IsoId("_0hLb67_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a U.S. treasury security.")]
    USTreasurySecurity,

    /// <summary>
    /// Asset is a US treasury bill.
    /// Encoded/decoded by serializers as &quot;S611&quot;.
    /// </summary>
    [EnumMember(Value = "S611")]
    [IsoId("_0hLb27_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a US treasury bill.")]
    USTreasuryBill,

    /// <summary>
    /// Asset is a US treasury note.
    /// Encoded/decoded by serializers as &quot;S612&quot;.
    /// </summary>
    [EnumMember(Value = "S612")]
    [IsoId("_0hLcAb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a US treasury note.")]
    USTreasuryNote,

    /// <summary>
    /// Asset is a US treasury bond.
    /// Encoded/decoded by serializers as &quot;S613&quot;.
    /// </summary>
    [EnumMember(Value = "S613")]
    [IsoId("_0hLb37_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a US treasury bond.")]
    USTreasuryBond,

    /// <summary>
    /// Asset is a U.S. government agency security.
    /// Encoded/decoded by serializers as &quot;S620&quot;.
    /// </summary>
    [EnumMember(Value = "S620")]
    [IsoId("_0hLbw7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a U.S. government agency security.")]
    USGovernmentAgencySecurity,

    /// <summary>
    /// Asset is a government national mortgage association (GNMA).
    /// Encoded/decoded by serializers as &quot;S650&quot;.
    /// </summary>
    [EnumMember(Value = "S650")]
    [IsoId("_0hLcBr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association (GNMA).")]
    GovernmentNationallMortgageAssociation,

    /// <summary>
    /// Asset is a real estate mortgage investment conduit (REMIC).
    /// Encoded/decoded by serializers as &quot;S651&quot;.
    /// </summary>
    [EnumMember(Value = "S651")]
    [IsoId("_0hLb3b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a real estate mortgage investment conduit (REMIC).")]
    RealEstateMortgageInvestmentConduit,

    /// <summary>
    /// Asset is a government national mortgage association serial note.
    /// Encoded/decoded by serializers as &quot;S652&quot;.
    /// </summary>
    [EnumMember(Value = "S652")]
    [IsoId("_0hLb8r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association serial note.")]
    GNMASerialNote,

    /// <summary>
    /// Asset is a package.
    /// Encoded/decoded by serializers as &quot;S700&quot;.
    /// </summary>
    [EnumMember(Value = "S700")]
    [IsoId("_0hLb2b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a package.")]
    Package,

    /// <summary>
    /// Corporate Debt Derivative.
    /// Encoded/decoded by serializers as &quot;S704&quot;.
    /// </summary>
    [EnumMember(Value = "S704")]
    [IsoId("_0hBrK7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Corporate Debt Derivative.")]
    CorporateDebtDerivative,

    /// <summary>
    /// Asset is an equity derivative.
    /// Encoded/decoded by serializers as &quot;S705&quot;.
    /// </summary>
    [EnumMember(Value = "S705")]
    [IsoId("_0hLcCb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an equity derivative.")]
    EquityDerivative,

    /// <summary>
    /// Asset is a municipal derivative.
    /// Encoded/decoded by serializers as &quot;S706&quot;.
    /// </summary>
    [EnumMember(Value = "S706")]
    [IsoId("_0hLcCr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal derivative.")]
    MunicipalDerivative,

    /// <summary>
    /// Asset is a municipal amortized issue.
    /// Encoded/decoded by serializers as &quot;S708&quot;.
    /// </summary>
    [EnumMember(Value = "S708")]
    [IsoId("_0hBrJr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal amortized issue.")]
    MunicipalAmortizedIssue,

    /// <summary>
    /// Asset is an option derivative.
    /// Encoded/decoded by serializers as &quot;S710&quot;.
    /// </summary>
    [EnumMember(Value = "S710")]
    [IsoId("_0hBrLb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an option derivative.")]
    OptionDerivative,

    /// <summary>
    /// Asset is a warrant.
    /// Encoded/decoded by serializers as &quot;S720&quot;.
    /// </summary>
    [EnumMember(Value = "S720")]
    [IsoId("_0hLb47_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a warrant.")]
    Warrant,

    /// <summary>
    /// Asset is a right.
    /// Encoded/decoded by serializers as &quot;S730&quot;.
    /// </summary>
    [EnumMember(Value = "S730")]
    [IsoId("_0hLb1L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a right.")]
    Right,

    /// <summary>
    /// Asset is a mutual fund.
    /// Encoded/decoded by serializers as &quot;S760&quot;.
    /// </summary>
    [EnumMember(Value = "S760")]
    [IsoId("_0hLb57_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a mutual fund.")]
    MutualFund,

    /// <summary>
    /// Asset is a closed end fund.
    /// Encoded/decoded by serializers as &quot;S761&quot;.
    /// </summary>
    [EnumMember(Value = "S761")]
    [IsoId("_0hBrI7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a closed end fund.")]
    ClosedEndFund,

    /// <summary>
    /// Asset is an institutional money market instrument mutual fund share.
    /// Encoded/decoded by serializers as &quot;S762&quot;.
    /// </summary>
    [EnumMember(Value = "S762")]
    [IsoId("_0hLbxL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an institutional money market instrument mutual fund share.")]
    InstitutionalMMIMutualFundShare,

    /// <summary>
    /// Asset is an equity unit.
    /// Encoded/decoded by serializers as &quot;S780&quot;.
    /// </summary>
    [EnumMember(Value = "S780")]
    [IsoId("_0hLb-7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an equity unit.")]
    EquityUnit,

    /// <summary>
    /// Asset is a debt unit.
    /// Encoded/decoded by serializers as &quot;S781&quot;.
    /// </summary>
    [EnumMember(Value = "S781")]
    [IsoId("_0hLb7r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a debt unit.")]
    DebtUnit,

    /// <summary>
    /// Asset is a unit investment trust (UIT) nuveen only.
    /// Encoded/decoded by serializers as &quot;S790&quot;.
    /// </summary>
    [EnumMember(Value = "S790")]
    [IsoId("_0hBrJL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a unit investment trust (UIT) nuveen only.")]
    UnitInvestmentTrustNuveenOnly,

    /// <summary>
    /// Asset is a global unit trust.
    /// Encoded/decoded by serializers as &quot;S791&quot;.
    /// </summary>
    [EnumMember(Value = "S791")]
    [IsoId("_0hBrLr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a global unit trust.")]
    GlobalUnitTrust,

    /// <summary>
    /// Asset is a unit investment trust (UIT).
    /// Encoded/decoded by serializers as &quot;S795&quot;.
    /// </summary>
    [EnumMember(Value = "S795")]
    [IsoId("_0hLb0b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a unit investment trust (UIT).")]
    UnitInvestmentTrust,

    /// <summary>
    /// Asset is an equity, subject to 144a, designated investors.
    /// Encoded/decoded by serializers as &quot;S121&quot;.
    /// </summary>
    [EnumMember(Value = "S121")]
    [IsoId("_0hLb9L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an equity, subject to 144a, designated investors.")]
    Equity144aDesignatedInvestors,

    /// <summary>
    /// Asset is a municipal debt, classified as other, subject to tax exempt.
    /// Encoded/decoded by serializers as &quot;S346&quot;.
    /// </summary>
    [EnumMember(Value = "S346")]
    [IsoId("_0hLb4r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal debt, classified as other, subject to tax exempt.")]
    MunicipalOtherTaxExempt,

    /// <summary>
    /// Asset is a corporate debt, classified as other, subject to tax exempt.
    /// Encoded/decoded by serializers as &quot;S546&quot;.
    /// </summary>
    [EnumMember(Value = "S546")]
    [IsoId("_0hLb7L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate debt, classified as other, subject to tax exempt.")]
    CorporateOtherTaxExempt,

    /// <summary>
    /// Asset is a corporate debt, subject to 144a, designated investors.
    /// Encoded/decoded by serializers as &quot;S545&quot;.
    /// </summary>
    [EnumMember(Value = "S545")]
    [IsoId("_0hLb0L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate debt, subject to 144a, designated investors.")]
    Corporate144aDesignatedInvestors,

    /// <summary>
    /// Asset is a non standard asset user CUSIP.
    /// Encoded/decoded by serializers as &quot;S127&quot;.
    /// </summary>
    [EnumMember(Value = "S127")]
    [IsoId("_0hLb_L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a non standard asset user CUSIP.")]
    NonStandardAssetUserCUSIP,
}
