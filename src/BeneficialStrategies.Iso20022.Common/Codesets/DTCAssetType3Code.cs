// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) security sub-issue type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lR6JUL_iEeeb2ZBoAlSG1Q")]
[Description(@"Specifies DTC (The Depository Trust Company) security sub-issue type.")]
[DerivedFrom(typeof(DTCAssetTypeV2Code))]
public enum DTCAssetType3Code
{
    /// <summary>
    /// Asset is an asset-backed security denomination in &quot;Units&quot; or &quot;Undivided Interest&quot;.
    /// Encoded/decoded by serializers as &quot;S041&quot;.
    /// </summary>
    [EnumMember(Value = "S041")]
    [IsoId("_p8paIb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an asset-backed security denomination in ""Units"" or ""Undivided Interest"".")]
    ABSDenominationUnitsOrUndividedInterest = DTCAssetTypeV2Code.ABSDenominationUnitsOrUndividedInterest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is an American depositary receipt (ADR).
    /// Encoded/decoded by serializers as &quot;S110&quot;.
    /// </summary>
    [EnumMember(Value = "S110")]
    [IsoId("_qDfpAb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an American depositary receipt (ADR).")]
    AmericanDepositaryReceipt = DTCAssetTypeV2Code.AmericanDepositaryReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is an asset-backed security (ABS) or global asset backed security (GABS).
    /// Encoded/decoded by serializers as &quot;S541&quot;.
    /// </summary>
    [EnumMember(Value = "S541")]
    [IsoId("_qKMG4b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an asset-backed security (ABS) or global asset backed security (GABS).")]
    AssetBackedSecurityOrGlobal = DTCAssetTypeV2Code.AssetBackedSecurityOrGlobal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is an auction rate preferred stock (ARPS).
    /// Encoded/decoded by serializers as &quot;S102&quot;.
    /// </summary>
    [EnumMember(Value = "S102")]
    [IsoId("_qL-Pkb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an auction rate preferred stock (ARPS).")]
    AuctionRatePreferredStock = DTCAssetTypeV2Code.AuctionRatePreferredStock, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a bearer, callable zero coupon bond.
    /// Encoded/decoded by serializers as &quot;S340&quot;.
    /// </summary>
    [EnumMember(Value = "S340")]
    [IsoId("_qPZXAb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a bearer, callable zero coupon bond.")]
    BearerCallableZeroCouponBond = DTCAssetTypeV2Code.BearerCallableZeroCouponBond, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a certificated money market instrument.
    /// Encoded/decoded by serializers as &quot;S505&quot;.
    /// </summary>
    [EnumMember(Value = "S505")]
    [IsoId("_qUc2Ib_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a certificated money market instrument.")]
    CertificatedMoneyMarketInstrument = DTCAssetTypeV2Code.CertificatedMoneyMarketInstrument, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a certificated money market - periodic payer.
    /// Encoded/decoded by serializers as &quot;S506&quot;.
    /// </summary>
    [EnumMember(Value = "S506")]
    [IsoId("_qZ9BMb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a certificated money market - periodic payer.")]
    CertificatedMoneyMarketPeriodicPayer = DTCAssetTypeV2Code.CertificatedMoneyMarketPeriodicPayer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a certificates of deposit.
    /// Encoded/decoded by serializers as &quot;S507&quot;.
    /// </summary>
    [EnumMember(Value = "S507")]
    [IsoId("_qgzQEb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a certificates of deposit.")]
    CertificatesOfDeposit = DTCAssetTypeV2Code.CertificatesOfDeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a closed end fund.
    /// Encoded/decoded by serializers as &quot;S761&quot;.
    /// </summary>
    [EnumMember(Value = "S761")]
    [IsoId("_qqLOgb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a closed end fund.")]
    ClosedEndFund = DTCAssetTypeV2Code.ClosedEndFund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a collateralized mortgage obligation denomination in &quot;Units&quot; or &quot;Undivided Interest&quot;.
    /// Encoded/decoded by serializers as &quot;S040&quot;.
    /// </summary>
    [EnumMember(Value = "S040")]
    [IsoId("_qr9XMb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a collateralized mortgage obligation denomination in ""Units"" or ""Undivided Interest"".")]
    CMODenominationUnitsOrUndividedInterest = DTCAssetTypeV2Code.CMODenominationUnitsOrUndividedInterest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a common stock.
    /// Encoded/decoded by serializers as &quot;S010&quot;.
    /// </summary>
    [EnumMember(Value = "S010")]
    [IsoId("_qvOtob_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a common stock.")]
    CommonStock = DTCAssetTypeV2Code.CommonStock, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a common stock real estate investment trust.
    /// Encoded/decoded by serializers as &quot;S012&quot;.
    /// </summary>
    [EnumMember(Value = "S012")]
    [IsoId("_q0b9wb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a common stock real estate investment trust.")]
    CommonStockREIT = DTCAssetTypeV2Code.CommonStockREIT, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a consumer price index discount commercial paper.
    /// Encoded/decoded by serializers as &quot;S520&quot;.
    /// </summary>
    [EnumMember(Value = "S520")]
    [IsoId("_q2OGcb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a consumer price index discount commercial paper.")]
    ConsumerPriceIndexDiscountCP = DTCAssetTypeV2Code.ConsumerPriceIndexDiscountCP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a convertible common stock.
    /// Encoded/decoded by serializers as &quot;S011&quot;.
    /// </summary>
    [EnumMember(Value = "S011")]
    [IsoId("_q4KAIb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a convertible common stock.")]
    ConvertibleCommonStock = DTCAssetTypeV2Code.ConvertibleCommonStock, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a convertible corporate debt.
    /// Encoded/decoded by serializers as &quot;S572&quot;.
    /// </summary>
    [EnumMember(Value = "S572")]
    [IsoId("_q58I0b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a convertible corporate debt.")]
    ConvertibleCorporateDebt = DTCAssetTypeV2Code.ConvertibleCorporateDebt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a corporate bond (CB) Or a global corporate bond (GCB).
    /// Encoded/decoded by serializers as &quot;S500&quot;.
    /// </summary>
    [EnumMember(Value = "S500")]
    [IsoId("_rJ20Ib_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate bond (CB) Or a global corporate bond (GCB).")]
    CorporateBondOrGlobal = DTCAssetTypeV2Code.CorporateBondOrGlobal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a corporate debenture.
    /// Encoded/decoded by serializers as &quot;S575&quot;.
    /// </summary>
    [EnumMember(Value = "S575")]
    [IsoId("_rLpj4b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate debenture.")]
    CorporateDebenture = DTCAssetTypeV2Code.CorporateDebenture, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Corporate Debt Derivative.
    /// Encoded/decoded by serializers as &quot;S704&quot;.
    /// </summary>
    [EnumMember(Value = "S704")]
    [IsoId("_rWEEIb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Corporate Debt Derivative.")]
    CorporateDebtDerivative = DTCAssetTypeV2Code.CorporateDebtDerivative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a corporate debt, classified as other, subject to tax exempt.
    /// Encoded/decoded by serializers as &quot;S546&quot;.
    /// </summary>
    [EnumMember(Value = "S546")]
    [IsoId("_rmRqYb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate debt, classified as other, subject to tax exempt.")]
    CorporateOtherTaxExempt = DTCAssetTypeV2Code.CorporateOtherTaxExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a corporate variable mode obligation (CVMO).
    /// Encoded/decoded by serializers as &quot;S573&quot;.
    /// </summary>
    [EnumMember(Value = "S573")]
    [IsoId("_roDzEb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate variable mode obligation (CVMO).")]
    CorporateVariableModeObligation = DTCAssetTypeV2Code.CorporateVariableModeObligation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a corporate short-term note.
    /// Encoded/decoded by serializers as &quot;S574&quot;.
    /// </summary>
    [EnumMember(Value = "S574")]
    [IsoId("_r0HSEb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate short-term note.")]
    CorporateShortTermNote = DTCAssetTypeV2Code.CorporateShortTermNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a corporate variable rate demand obligation or a municipal variable rate demand obligation (MMD).
    /// Encoded/decoded by serializers as &quot;S576&quot;.
    /// </summary>
    [EnumMember(Value = "S576")]
    [IsoId("_r5KxMb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate variable rate demand obligation or a municipal variable rate demand obligation (MMD).")]
    CorporateOrMunicipalVariableRateDemandObligation = DTCAssetTypeV2Code.CorporateOrMunicipalVariableRateDemandObligation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a corporate insured custodial receipt.
    /// Encoded/decoded by serializers as &quot;S577&quot;.
    /// </summary>
    [EnumMember(Value = "S577")]
    [IsoId("_r-YBUb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate insured custodial receipt.")]
    CorporateInsuredCustodialReceipt = DTCAssetTypeV2Code.CorporateInsuredCustodialReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a corporate auction rate note.
    /// Encoded/decoded by serializers as &quot;S571&quot;.
    /// </summary>
    [EnumMember(Value = "S571")]
    [IsoId("_sDlRcb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate auction rate note.")]
    CorporateAuctionRateNote = DTCAssetTypeV2Code.CorporateAuctionRateNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a corporate debt, subject to 144a, designated investors.
    /// Encoded/decoded by serializers as &quot;S545&quot;.
    /// </summary>
    [EnumMember(Value = "S545")]
    [IsoId("_sIyhkb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate debt, subject to 144a, designated investors.")]
    Corporate144aDesignatedInvestors = DTCAssetTypeV2Code.Corporate144aDesignatedInvestors, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a convertible preferred stock.
    /// Encoded/decoded by serializers as &quot;S023&quot;.
    /// </summary>
    [EnumMember(Value = "S023")]
    [IsoId("_sOvYkb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a convertible preferred stock.")]
    ConvertiblePreferredStock = DTCAssetTypeV2Code.ConvertiblePreferredStock, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a consumer price index interest at maturity (IAM) commercial paper.
    /// Encoded/decoded by serializers as &quot;S510&quot;.
    /// </summary>
    [EnumMember(Value = "S510")]
    [IsoId("_sUGZsb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a consumer price index interest at maturity (IAM) commercial paper.")]
    ConsumerPriceIndexAtMaturityCP = DTCAssetTypeV2Code.ConsumerPriceIndexAtMaturityCP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a collateralized mortgage obligation or global collateralized mortgage obligation.
    /// Encoded/decoded by serializers as &quot;S540&quot;.
    /// </summary>
    [EnumMember(Value = "S540")]
    [IsoId("_saWLob_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a collateralized mortgage obligation or global collateralized mortgage obligation.")]
    CollateralizedMortgageObligationOrGlobal = DTCAssetTypeV2Code.CollateralizedMortgageObligationOrGlobal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a custody user CUSIP.
    /// Encoded/decoded by serializers as &quot;S126&quot;.
    /// </summary>
    [EnumMember(Value = "S126")]
    [IsoId("_tu2gcb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a custody user CUSIP.")]
    CustodyUserCUSIP = DTCAssetTypeV2Code.CustodyUserCUSIP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a debt unit.
    /// Encoded/decoded by serializers as &quot;S781&quot;.
    /// </summary>
    [EnumMember(Value = "S781")]
    [IsoId("_t1QDYb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a debt unit.")]
    DebtUnit = DTCAssetTypeV2Code.DebtUnit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a depositary share.
    /// Encoded/decoded by serializers as &quot;S111&quot;.
    /// </summary>
    [EnumMember(Value = "S111")]
    [IsoId("_t_N3sb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a depositary share.")]
    DepositaryShare = DTCAssetTypeV2Code.DepositaryShare, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is an equity.
    /// Encoded/decoded by serializers as &quot;S005&quot;.
    /// </summary>
    [EnumMember(Value = "S005")]
    [IsoId("_uFwkkb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an equity.")]
    Equity = DTCAssetTypeV2Code.Equity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is an equity, subject to 144a, designated investors.
    /// Encoded/decoded by serializers as &quot;S121&quot;.
    /// </summary>
    [EnumMember(Value = "S121")]
    [IsoId("_uI4xEb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an equity, subject to 144a, designated investors.")]
    Equity144aDesignatedInvestors = DTCAssetTypeV2Code.Equity144aDesignatedInvestors, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is an equity derivative.
    /// Encoded/decoded by serializers as &quot;S705&quot;.
    /// </summary>
    [EnumMember(Value = "S705")]
    [IsoId("_uN8QMb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an equity derivative.")]
    EquityDerivative = DTCAssetTypeV2Code.EquityDerivative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is an equity unit.
    /// Encoded/decoded by serializers as &quot;S780&quot;.
    /// </summary>
    [EnumMember(Value = "S780")]
    [IsoId("_uPuY4b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an equity unit.")]
    EquityUnit = DTCAssetTypeV2Code.EquityUnit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is an exchange traded funds.
    /// Encoded/decoded by serializers as &quot;S117&quot;.
    /// </summary>
    [EnumMember(Value = "S117")]
    [IsoId("_uS2lYb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an exchange traded funds.")]
    ExchangeTradedFunds = DTCAssetTypeV2Code.ExchangeTradedFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a government national mortgage association pass-through security.
    /// Encoded/decoded by serializers as &quot;S451&quot;.
    /// </summary>
    [EnumMember(Value = "S451")]
    [IsoId("_ubVL8b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association pass-through security.")]
    GNMAPassThroughSecurity = DTCAssetTypeV2Code.GNMAPassThroughSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a government national mortgage association real estate mortgage investment conduit security.
    /// Encoded/decoded by serializers as &quot;S450&quot;.
    /// </summary>
    [EnumMember(Value = "S450")]
    [IsoId("_ugZSIb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association real estate mortgage investment conduit security.")]
    GNMARealEstateMortgageInvestmentConduit = DTCAssetTypeV2Code.GNMARealEstateMortgageInvestmentConduit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a government national mortgage association serial note security.
    /// Encoded/decoded by serializers as &quot;S452&quot;.
    /// </summary>
    [EnumMember(Value = "S452")]
    [IsoId("_uuFI0b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association serial note security.")]
    GNMASerialNoteSecurity = DTCAssetTypeV2Code.GNMASerialNoteSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a government national mortgage association (GNMA).
    /// Encoded/decoded by serializers as &quot;S650&quot;.
    /// </summary>
    [EnumMember(Value = "S650")]
    [IsoId("_u3TWQb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association (GNMA).")]
    GovernmentNationallMortgageAssociation = DTCAssetTypeV2Code.GovernmentNationallMortgageAssociation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a government national mortgage association government security.
    /// Encoded/decoded by serializers as &quot;S601&quot;.
    /// </summary>
    [EnumMember(Value = "S601")]
    [IsoId("_u5Fe8b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association government security.")]
    GovernmentSecurity = DTCAssetTypeV2Code.GovernmentSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a government trust certificate.
    /// Encoded/decoded by serializers as &quot;S602&quot;.
    /// </summary>
    [EnumMember(Value = "S602")]
    [IsoId("_u6udsb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government trust certificate.")]
    GovernmentTrustCertificate = DTCAssetTypeV2Code.GovernmentTrustCertificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is an institutional money market instrument mutual fund share.
    /// Encoded/decoded by serializers as &quot;S762&quot;.
    /// </summary>
    [EnumMember(Value = "S762")]
    [IsoId("_vAE3wb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an institutional money market instrument mutual fund share.")]
    InstitutionalMMIMutualFundShare = DTCAssetTypeV2Code.InstitutionalMMIMutualFundShare, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is an issue denomination in &quot;Units&quot; or &quot;Undivided Interest&quot;.
    /// Encoded/decoded by serializers as &quot;S042&quot;.
    /// </summary>
    [EnumMember(Value = "S042")]
    [IsoId("_vB3ngb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an issue denomination in ""Units"" or ""Undivided Interest"".")]
    IssueDenominationUnitsOrUndividedInterest = DTCAssetTypeV2Code.IssueDenominationUnitsOrUndividedInterest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a junk and treasury growth receipt (JGR).
    /// Encoded/decoded by serializers as &quot;S603&quot;.
    /// </summary>
    [EnumMember(Value = "S603")]
    [IsoId("_vHE3ob_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a junk and treasury growth receipt (JGR).")]
    JunkAndTreasuryGrowthReceipt = DTCAssetTypeV2Code.JunkAndTreasuryGrowthReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a medium term note (MTN).
    /// Encoded/decoded by serializers as &quot;S530&quot;.
    /// </summary>
    [EnumMember(Value = "S530")]
    [IsoId("_vRfX4b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a medium term note (MTN).")]
    MediumTermNote = DTCAssetTypeV2Code.MediumTermNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a money market instrument corporate variable rate demand obligation commercial paper.
    /// Encoded/decoded by serializers as &quot;S526&quot;.
    /// </summary>
    [EnumMember(Value = "S526")]
    [IsoId("_vkOtsb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument corporate variable rate demand obligation commercial paper.")]
    MMICorporateVariableRateDemandObligation = DTCAssetTypeV2Code.MMICorporateVariableRateDemandObligation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a money market instrument deposit note.
    /// Encoded/decoded by serializers as &quot;S531&quot;.
    /// </summary>
    [EnumMember(Value = "S531")]
    [IsoId("_vl3scb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument deposit note.")]
    MMIDepositNote = DTCAssetTypeV2Code.MMIDepositNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a money market instrument corporate commercial paper.
    /// Encoded/decoded by serializers as &quot;S525&quot;.
    /// </summary>
    [EnumMember(Value = "S525")]
    [IsoId("_vxxacb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument corporate commercial paper.")]
    MMICorporateCommercialPaper = DTCAssetTypeV2Code.MMICorporateCommercialPaper, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a money market instrument bankers&apos; acceptance note (BA).
    /// Encoded/decoded by serializers as &quot;S502&quot;.
    /// </summary>
    [EnumMember(Value = "S502")]
    [IsoId("_v2-qkb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument bankers' acceptance note (BA).")]
    MMIBankersAcceptanceNote = DTCAssetTypeV2Code.MMIBankersAcceptanceNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a limited partnership.
    /// Encoded/decoded by serializers as &quot;S030&quot;.
    /// </summary>
    [EnumMember(Value = "S030")]
    [IsoId("_v_dRIb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a limited partnership.")]
    LimitedPartnership = DTCAssetTypeV2Code.LimitedPartnership, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a government national mortgage association serial note.
    /// Encoded/decoded by serializers as &quot;S652&quot;.
    /// </summary>
    [EnumMember(Value = "S652")]
    [IsoId("_wOyGkb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association serial note.")]
    GNMASerialNote = DTCAssetTypeV2Code.GNMASerialNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a global unit trust.
    /// Encoded/decoded by serializers as &quot;S791&quot;.
    /// </summary>
    [EnumMember(Value = "S791")]
    [IsoId("_wV7QYb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a global unit trust.")]
    GlobalUnitTrust = DTCAssetTypeV2Code.GlobalUnitTrust, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a money market instrument discount note.
    /// Encoded/decoded by serializers as &quot;S560&quot;.
    /// </summary>
    [EnumMember(Value = "S560")]
    [IsoId("_w_4MUb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument discount note.")]
    MMIDiscountNote = DTCAssetTypeV2Code.MMIDiscountNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a money market instrument institutional certificates of deposit.
    /// Encoded/decoded by serializers as &quot;S504&quot;.
    /// </summary>
    [EnumMember(Value = "S504")]
    [IsoId("_xDJiwb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument institutional certificates of deposit.")]
    MMIInstitutionalCertificatesOfDeposit = DTCAssetTypeV2Code.MMIInstitutionalCertificatesOfDeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a money market instrument medium term note.
    /// Encoded/decoded by serializers as &quot;S533&quot;.
    /// </summary>
    [EnumMember(Value = "S533")]
    [IsoId("_xIWy4b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument medium term note.")]
    MMIMediumTermNote = DTCAssetTypeV2Code.MMIMediumTermNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a money market instrument municipal variable rate demand obligation commercial paper.
    /// Encoded/decoded by serializers as &quot;S320&quot;.
    /// </summary>
    [EnumMember(Value = "S320")]
    [IsoId("_xO5fwb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument municipal variable rate demand obligation commercial paper.")]
    MMIMunicipalVariableRateDemandObligation = DTCAssetTypeV2Code.MMIMunicipalVariableRateDemandObligation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a money market instrument preferred stock (in CP-like mode).
    /// Encoded/decoded by serializers as &quot;S120&quot;.
    /// </summary>
    [EnumMember(Value = "S120")]
    [IsoId("_xUaR4b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument preferred stock (in CP-like mode).")]
    MMIPreferredStockCPLike = DTCAssetTypeV2Code.MMIPreferredStockCPLike, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a municipal amortized issue.
    /// Encoded/decoded by serializers as &quot;S708&quot;.
    /// </summary>
    [EnumMember(Value = "S708")]
    [IsoId("_xdCCYb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal amortized issue.")]
    MunicipalAmortizedIssue = DTCAssetTypeV2Code.MunicipalAmortizedIssue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a municipal bond.
    /// Encoded/decoded by serializers as &quot;S310&quot;.
    /// </summary>
    [EnumMember(Value = "S310")]
    [IsoId("_xl9U4b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal bond.")]
    MunicipalBond = DTCAssetTypeV2Code.MunicipalBond, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a municipal derivative.
    /// Encoded/decoded by serializers as &quot;S706&quot;.
    /// </summary>
    [EnumMember(Value = "S706")]
    [IsoId("_xtQPsb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal derivative.")]
    MunicipalDerivative = DTCAssetTypeV2Code.MunicipalDerivative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a municipal note.
    /// Encoded/decoded by serializers as &quot;S311&quot;.
    /// </summary>
    [EnumMember(Value = "S311")]
    [IsoId("_xvCYYb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal note.")]
    MunicipalNote = DTCAssetTypeV2Code.MunicipalNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a municipal debt, classified as other, subject to tax exempt.
    /// Encoded/decoded by serializers as &quot;S346&quot;.
    /// </summary>
    [EnumMember(Value = "S346")]
    [IsoId("_x3z54b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal debt, classified as other, subject to tax exempt.")]
    MunicipalOtherTaxExempt = DTCAssetTypeV2Code.MunicipalOtherTaxExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a mutual fund.
    /// Encoded/decoded by serializers as &quot;S760&quot;.
    /// </summary>
    [EnumMember(Value = "S760")]
    [IsoId("_yHvMQb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a mutual fund.")]
    MutualFund = DTCAssetTypeV2Code.MutualFund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a non-collateralized mortgage obligation ABS amortizing issue.
    /// Encoded/decoded by serializers as &quot;S542&quot;.
    /// </summary>
    [EnumMember(Value = "S542")]
    [IsoId("_yQqewb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a non-collateralized mortgage obligation ABS amortizing issue.")]
    NonCMOABSAmortizingIssue = DTCAssetTypeV2Code.NonCMOABSAmortizingIssue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a package.
    /// Encoded/decoded by serializers as &quot;S700&quot;.
    /// </summary>
    [EnumMember(Value = "S700")]
    [IsoId("_yf-tIb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a package.")]
    Package = DTCAssetTypeV2Code.Package, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a periodic payment commercial paper.
    /// Encoded/decoded by serializers as &quot;S511&quot;.
    /// </summary>
    [EnumMember(Value = "S511")]
    [IsoId("_yr4bIb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a periodic payment commercial paper.")]
    PeriodicPaymentCommercialPaper = DTCAssetTypeV2Code.PeriodicPaymentCommercialPaper, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// MMI Short-Term Bank Note.
    /// Encoded/decoded by serializers as &quot;S550&quot;.
    /// </summary>
    [EnumMember(Value = "S550")]
    [IsoId("_y_90wb_iEeeb2ZBoAlSG1Q")]
    [Description(@"MMI Short-Term Bank Note.")]
    MMIShortTermBankNote = DTCAssetTypeV2Code.MMIShortTermBankNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a money market instrument medium-term bank note.
    /// Encoded/decoded by serializers as &quot;S532&quot;.
    /// </summary>
    [EnumMember(Value = "S532")]
    [IsoId("_zFLE4b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument medium-term bank note.")]
    MMIMediumTermBankNote = DTCAssetTypeV2Code.MMIMediumTermBankNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a money market instrument municipal commercial paper.
    /// Encoded/decoded by serializers as &quot;S330&quot;.
    /// </summary>
    [EnumMember(Value = "S330")]
    [IsoId("_zRrP0b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument municipal commercial paper.")]
    MMIMunicipalCommercialPaper = DTCAssetTypeV2Code.MMIMunicipalCommercialPaper, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a municipal auction rate note (ARN).
    /// Encoded/decoded by serializers as &quot;S312&quot;.
    /// </summary>
    [EnumMember(Value = "S312")]
    [IsoId("_zamiUb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal auction rate note (ARN).")]
    MunicipalAuctionRateNote = DTCAssetTypeV2Code.MunicipalAuctionRateNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a municipal insured custodial receipt.
    /// Encoded/decoded by serializers as &quot;S315&quot;.
    /// </summary>
    [EnumMember(Value = "S315")]
    [IsoId("_zjYD0b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal insured custodial receipt.")]
    MunicipalInsuredCustodialReceipt = DTCAssetTypeV2Code.MunicipalInsuredCustodialReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a municipal option call right.
    /// Encoded/decoded by serializers as &quot;S112&quot;.
    /// </summary>
    [EnumMember(Value = "S112")]
    [IsoId("_zsKMYb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal option call right.")]
    MunicipalOptionCallRight = DTCAssetTypeV2Code.MunicipalOptionCallRight, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a municipal variable rate demand obligation (VRDO).
    /// Encoded/decoded by serializers as &quot;S314&quot;.
    /// </summary>
    [EnumMember(Value = "S314")]
    [IsoId("_z7x8wb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal variable rate demand obligation (VRDO).")]
    MunicipalVariableRateDemandObligation = DTCAssetTypeV2Code.MunicipalVariableRateDemandObligation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a municipal variable mode obligation (VMO).
    /// Encoded/decoded by serializers as &quot;S313&quot;.
    /// </summary>
    [EnumMember(Value = "S313")]
    [IsoId("_0EQjUb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal variable mode obligation (VMO).")]
    MunicipalVariableModeObligation = DTCAssetTypeV2Code.MunicipalVariableModeObligation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a non standard asset user CUSIP.
    /// Encoded/decoded by serializers as &quot;S127&quot;.
    /// </summary>
    [EnumMember(Value = "S127")]
    [IsoId("_0NCE0b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a non standard asset user CUSIP.")]
    NonStandardAssetUserCUSIP = DTCAssetTypeV2Code.NonStandardAssetUserCUSIP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is an option derivative.
    /// Encoded/decoded by serializers as &quot;S710&quot;.
    /// </summary>
    [EnumMember(Value = "S710")]
    [IsoId("_0TlYwb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an option derivative.")]
    OptionDerivative = DTCAssetTypeV2Code.OptionDerivative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a preferred stock.
    /// Encoded/decoded by serializers as &quot;S020&quot;.
    /// </summary>
    [EnumMember(Value = "S020")]
    [IsoId("_0foQsb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a preferred stock.")]
    PreferredStock = DTCAssetTypeV2Code.PreferredStock, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a preferred stock real estate investment trust.
    /// Encoded/decoded by serializers as &quot;S022&quot;.
    /// </summary>
    [EnumMember(Value = "S022")]
    [IsoId("_0k_R0b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a preferred stock real estate investment trust.")]
    PreferredStockREIT = DTCAssetTypeV2Code.PreferredStockREIT, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a real estate investment trust (REIT).
    /// Encoded/decoded by serializers as &quot;S130&quot;.
    /// </summary>
    [EnumMember(Value = "S130")]
    [IsoId("_0td4Yb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a real estate investment trust (REIT).")]
    RealEstateInvestmentTrust = DTCAssetTypeV2Code.RealEstateInvestmentTrust, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a real estate mortgage investment conduit (REMIC).
    /// Encoded/decoded by serializers as &quot;S651&quot;.
    /// </summary>
    [EnumMember(Value = "S651")]
    [IsoId("_2ZU9Qb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a real estate mortgage investment conduit (REMIC).")]
    RealEstateMortgageInvestmentConduit = DTCAssetTypeV2Code.RealEstateMortgageInvestmentConduit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a right.
    /// Encoded/decoded by serializers as &quot;S730&quot;.
    /// </summary>
    [EnumMember(Value = "S730")]
    [IsoId("_2gBbIb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a right.")]
    Right = DTCAssetTypeV2Code.Right, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a sealed envelope.
    /// Encoded/decoded by serializers as &quot;S125&quot;.
    /// </summary>
    [EnumMember(Value = "S125")]
    [IsoId("_2hzj0b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a sealed envelope.")]
    SealedEnvelope = DTCAssetTypeV2Code.SealedEnvelope, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a tender rate note.
    /// Encoded/decoded by serializers as &quot;S578&quot;.
    /// </summary>
    [EnumMember(Value = "S578")]
    [IsoId("_2nTu4b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a tender rate note.")]
    TenderRateNote = DTCAssetTypeV2Code.TenderRateNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a tender rate preferred stock.
    /// Encoded/decoded by serializers as &quot;S024&quot;.
    /// </summary>
    [EnumMember(Value = "S024")]
    [IsoId("_2sX1Eb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a tender rate preferred stock.")]
    TenderRatePreferredStock = DTCAssetTypeV2Code.TenderRatePreferredStock, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a unit investment trust (UIT).
    /// Encoded/decoded by serializers as &quot;S795&quot;.
    /// </summary>
    [EnumMember(Value = "S795")]
    [IsoId("_2uJ9wb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a unit investment trust (UIT).")]
    UnitInvestmentTrust = DTCAssetTypeV2Code.UnitInvestmentTrust, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a unit investment trust (UIT) nuveen only.
    /// Encoded/decoded by serializers as &quot;S790&quot;.
    /// </summary>
    [EnumMember(Value = "S790")]
    [IsoId("_24HyEb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a unit investment trust (UIT) nuveen only.")]
    UnitInvestmentTrustNuveenOnly = DTCAssetTypeV2Code.UnitInvestmentTrustNuveenOnly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a U.S. government agency security.
    /// Encoded/decoded by serializers as &quot;S620&quot;.
    /// </summary>
    [EnumMember(Value = "S620")]
    [IsoId("_29VCMb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a U.S. government agency security.")]
    USGovernmentAgencySecurity = DTCAssetTypeV2Code.USGovernmentAgencySecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a US treasury bill.
    /// Encoded/decoded by serializers as &quot;S611&quot;.
    /// </summary>
    [EnumMember(Value = "S611")]
    [IsoId("_3CZIYb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a US treasury bill.")]
    USTreasuryBill = DTCAssetTypeV2Code.USTreasuryBill, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a US treasury bond.
    /// Encoded/decoded by serializers as &quot;S613&quot;.
    /// </summary>
    [EnumMember(Value = "S613")]
    [IsoId("_3FXj4b_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a US treasury bond.")]
    USTreasuryBond = DTCAssetTypeV2Code.USTreasuryBond, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a US treasury note.
    /// Encoded/decoded by serializers as &quot;S612&quot;.
    /// </summary>
    [EnumMember(Value = "S612")]
    [IsoId("_3KbDAb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a US treasury note.")]
    USTreasuryNote = DTCAssetTypeV2Code.USTreasuryNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a U.S. treasury security.
    /// Encoded/decoded by serializers as &quot;S610&quot;.
    /// </summary>
    [EnumMember(Value = "S610")]
    [IsoId("_3Swfob_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a U.S. treasury security.")]
    USTreasurySecurity = DTCAssetTypeV2Code.USTreasurySecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a warrant.
    /// Encoded/decoded by serializers as &quot;S720&quot;.
    /// </summary>
    [EnumMember(Value = "S720")]
    [IsoId("_3V4FEb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a warrant.")]
    Warrant = DTCAssetTypeV2Code.Warrant, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a zero coupon denomination in initial principal amount.
    /// Encoded/decoded by serializers as &quot;S551&quot;.
    /// </summary>
    [EnumMember(Value = "S551")]
    [IsoId("_3a8LQb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a zero coupon denomination in initial principal amount.")]
    ZCPNDenominationInitialPrincipalAmount = DTCAssetTypeV2Code.ZCPNDenominationInitialPrincipalAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset is a zero coupon bond.
    /// Encoded/decoded by serializers as &quot;S579&quot;.
    /// </summary>
    [EnumMember(Value = "S579")]
    [IsoId("_3gSlUb_iEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a zero coupon bond.")]
    ZeroCouponBond = DTCAssetTypeV2Code.ZeroCouponBond, // same ordinal as derivation source for type conversions
    
}
