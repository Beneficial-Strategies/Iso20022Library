// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) security sub-issue type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_G47lAJ2MEeW-bsa36JFb9A")]
[Description(@"Specifies DTC (The Depository Trust Company) security sub-issue type.")]
[DerivedFrom(typeof(DTCAssetTypeCode))]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum DTCAssetType2Code
{
    /// <summary>
    /// ABS Denomination in &quot;Units&quot; or &quot;Undivided Interest&quot;.
    /// Encoded/decoded by serializers as &quot;S041&quot;.
    /// </summary>
    [EnumMember(Value = "S041")]
    [IsoId("_MiAtYZ2MEeW-bsa36JFb9A")]
    [Description(@"ABS Denomination in ""Units"" or ""Undivided Interest"".")]
    ABSDenominUnitsorUndividedInterest = DTCAssetTypeCode.ABSDenominUnitsorUndividedInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// American Depositary Receipt (ADR).
    /// Encoded/decoded by serializers as &quot;S110&quot;.
    /// </summary>
    [EnumMember(Value = "S110")]
    [IsoId("_MmoHoZ2MEeW-bsa36JFb9A")]
    [Description(@"American Depositary Receipt (ADR).")]
    AmericanDepositaryReceiptADR = DTCAssetTypeCode.AmericanDepositaryReceiptADR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Asset-Backed security (ABS) or global ABS (GABS).
    /// Encoded/decoded by serializers as &quot;S541&quot;.
    /// </summary>
    [EnumMember(Value = "S541")]
    [IsoId("_MqpE8Z2MEeW-bsa36JFb9A")]
    [Description(@"Asset-Backed security (ABS) or global ABS (GABS).")]
    AssetBackedSecurityABSorGlobalABSGABS = DTCAssetTypeCode.AssetBackedSecurityABSorGlobalABSGABS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Auction Rate Preferred Stock (ARPS).
    /// Encoded/decoded by serializers as &quot;S102&quot;.
    /// </summary>
    [EnumMember(Value = "S102")]
    [IsoId("_My0wkZ2MEeW-bsa36JFb9A")]
    [Description(@"Auction Rate Preferred Stock (ARPS).")]
    AuctionRatePreferredStockARPS = DTCAssetTypeCode.AuctionRatePreferredStockARPS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificated Money Market Instrument.
    /// Encoded/decoded by serializers as &quot;S505&quot;.
    /// </summary>
    [EnumMember(Value = "S505")]
    [IsoId("_M342wZ2MEeW-bsa36JFb9A")]
    [Description(@"Certificated Money Market Instrument.")]
    CertificatedMoneyMarketInstrument = DTCAssetTypeCode.CertificatedMoneyMarketInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bearer, Callable Zero Coupon Bond.
    /// Encoded/decoded by serializers as &quot;S340&quot;.
    /// </summary>
    [EnumMember(Value = "S340")]
    [IsoId("_NCvb4Z2MEeW-bsa36JFb9A")]
    [Description(@"Bearer, Callable Zero Coupon Bond.")]
    BearerCallableZeroCouponBond = DTCAssetTypeCode.BearerCallableZeroCouponBond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificated Money Market - Periodic Payer.
    /// Encoded/decoded by serializers as &quot;S506&quot;.
    /// </summary>
    [EnumMember(Value = "S506")]
    [IsoId("_NNmoEZ2MEeW-bsa36JFb9A")]
    [Description(@"Certificated Money Market - Periodic Payer.")]
    CertificatedMoneyMarketPeriodicPayer = DTCAssetTypeCode.CertificatedMoneyMarketPeriodicPayer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificates of Deposit.
    /// Encoded/decoded by serializers as &quot;S507&quot;.
    /// </summary>
    [EnumMember(Value = "S507")]
    [IsoId("_NSERUZ2MEeW-bsa36JFb9A")]
    [Description(@"Certificates of Deposit.")]
    CertificatesOfDeposit = DTCAssetTypeCode.CertificatesOfDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Closed End Fund.
    /// Encoded/decoded by serializers as &quot;S761&quot;.
    /// </summary>
    [EnumMember(Value = "S761")]
    [IsoId("_NVpJwZ2MEeW-bsa36JFb9A")]
    [Description(@"Closed End Fund.")]
    ClosedEndFund = DTCAssetTypeCode.ClosedEndFund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CMO Denomination in &quot;Units&quot; or &quot;Undivided Interest&quot;.
    /// Encoded/decoded by serializers as &quot;S040&quot;.
    /// </summary>
    [EnumMember(Value = "S040")]
    [IsoId("_NZDqIZ2MEeW-bsa36JFb9A")]
    [Description(@"CMO Denomination in ""Units"" or ""Undivided Interest"".")]
    CMODenominUnitsorUndividedInterest = DTCAssetTypeCode.CMODenominUnitsorUndividedInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateralized Mortgage Obligation or Global CMO.
    /// Encoded/decoded by serializers as &quot;S540&quot;.
    /// </summary>
    [EnumMember(Value = "S540")]
    [IsoId("_NeHwUZ2MEeW-bsa36JFb9A")]
    [Description(@"Collateralized Mortgage Obligation or Global CMO.")]
    CollateralizedMtgeObligationorGlobalCMO =
        DTCAssetTypeCode.CollateralizedMtgeObligationorGlobalCMO, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Common Stock.
    /// Encoded/decoded by serializers as &quot;S010&quot;.
    /// </summary>
    [EnumMember(Value = "S010")]
    [IsoId("_NmJq8Z2MEeW-bsa36JFb9A")]
    [Description(@"Common Stock.")]
    CommonStock = DTCAssetTypeCode.CommonStock, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Common Stock REIT.
    /// Encoded/decoded by serializers as &quot;S012&quot;.
    /// </summary>
    [EnumMember(Value = "S012")]
    [IsoId("_NqLPUZ2MEeW-bsa36JFb9A")]
    [Description(@"Common Stock REIT.")]
    CommonStockREIT = DTCAssetTypeCode.CommonStockREIT, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Convertible Common Stock.
    /// Encoded/decoded by serializers as &quot;S011&quot;.
    /// </summary>
    [EnumMember(Value = "S011")]
    [IsoId("_NuyCgZ2MEeW-bsa36JFb9A")]
    [Description(@"Convertible Common Stock.")]
    ConvertibleCommonStock = DTCAssetTypeCode.ConvertibleCommonStock, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Convertible Corporate Debt.
    /// Encoded/decoded by serializers as &quot;S572&quot;.
    /// </summary>
    [EnumMember(Value = "S572")]
    [IsoId("_Nyp14Z2MEeW-bsa36JFb9A")]
    [Description(@"Convertible Corporate Debt.")]
    ConvertibleCorporateDebt = DTCAssetTypeCode.ConvertibleCorporateDebt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Convertible Preferred Stock.
    /// Encoded/decoded by serializers as &quot;S023&quot;.
    /// </summary>
    [EnumMember(Value = "S023")]
    [IsoId("_N1xbUZ2MEeW-bsa36JFb9A")]
    [Description(@"Convertible Preferred Stock.")]
    ConvertiblePreferredStock = DTCAssetTypeCode.ConvertiblePreferredStock, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate debt, subject to 144a, designated investors.
    /// Encoded/decoded by serializers as &quot;S545&quot;.
    /// </summary>
    [EnumMember(Value = "S545")]
    [IsoId("_N6Y1kZ2MEeW-bsa36JFb9A")]
    [Description(@"Corporate debt, subject to 144a, designated investors.")]
    Corporate144aDesignatedInvestors = DTCAssetTypeCode.Corporate144aDesignatedInvestors, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate Auction Rate Note.
    /// Encoded/decoded by serializers as &quot;S571&quot;.
    /// </summary>
    [EnumMember(Value = "S571")]
    [IsoId("_N-Qo8Z2MEeW-bsa36JFb9A")]
    [Description(@"Corporate Auction Rate Note.")]
    CorporateAuctionRateNote = DTCAssetTypeCode.CorporateAuctionRateNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate Bond (CB) or Global Corp Bond (GCB).
    /// Encoded/decoded by serializers as &quot;S500&quot;.
    /// </summary>
    [EnumMember(Value = "S500")]
    [IsoId("_OCkhMZ2MEeW-bsa36JFb9A")]
    [Description(@"Corporate Bond (CB) or Global Corp Bond (GCB).")]
    CorporateBondCBorGlobalCorpBondGCB = DTCAssetTypeCode.CorporateBondCBorGlobalCorpBondGCB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate Debenture.
    /// Encoded/decoded by serializers as &quot;S575&quot;.
    /// </summary>
    [EnumMember(Value = "S575")]
    [IsoId("_OPXnEZ2MEeW-bsa36JFb9A")]
    [Description(@"Corporate Debenture.")]
    CorporateDebenture = DTCAssetTypeCode.CorporateDebenture, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate Debt Derivative.
    /// Encoded/decoded by serializers as &quot;S704&quot;.
    /// </summary>
    [EnumMember(Value = "S704")]
    [IsoId("_OThuUZ2MEeW-bsa36JFb9A")]
    [Description(@"Corporate Debt Derivative.")]
    CorporateDebtDerivative = DTCAssetTypeCode.CorporateDebtDerivative, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate Insured Custodial Receipt.
    /// Encoded/decoded by serializers as &quot;S577&quot;.
    /// </summary>
    [EnumMember(Value = "S577")]
    [IsoId("_OXjSsZ2MEeW-bsa36JFb9A")]
    [Description(@"Corporate Insured Custodial Receipt.")]
    CorporateInsuredCustodialReceipt = DTCAssetTypeCode.CorporateInsuredCustodialReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate debt, classified as other, subject to tax exempt.
    /// Encoded/decoded by serializers as &quot;S546&quot;.
    /// </summary>
    [EnumMember(Value = "S546")]
    [IsoId("_OdMnsZ2MEeW-bsa36JFb9A")]
    [Description(@"Corporate debt, classified as other, subject to tax exempt.")]
    CorporateOtherTaxExempt = DTCAssetTypeCode.CorporateOtherTaxExempt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate Short-Term Note.
    /// Encoded/decoded by serializers as &quot;S574&quot;.
    /// </summary>
    [EnumMember(Value = "S574")]
    [IsoId("_OjdAsZ2MEeW-bsa36JFb9A")]
    [Description(@"Corporate Short-Term Note.")]
    CorporateShortTermNote = DTCAssetTypeCode.CorporateShortTermNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate Variable Mode Obligation (CVMO).
    /// Encoded/decoded by serializers as &quot;S573&quot;.
    /// </summary>
    [EnumMember(Value = "S573")]
    [IsoId("_OnnH8Z2MEeW-bsa36JFb9A")]
    [Description(@"Corporate Variable Mode Obligation (CVMO).")]
    CorporateVariableModeObligationCVMO = DTCAssetTypeCode.CorporateVariableModeObligationCVMO, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate VRDO / Municipal VRDO (MMD).
    /// Encoded/decoded by serializers as &quot;S576&quot;.
    /// </summary>
    [EnumMember(Value = "S576")]
    [IsoId("_OrosUZ2MEeW-bsa36JFb9A")]
    [Description(@"Corporate VRDO / Municipal VRDO (MMD).")]
    CorporateVRDOMunicipalVRDOMMD = DTCAssetTypeCode.CorporateVRDOMunicipalVRDOMMD, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CPI Discount Commercial Paper (CP).
    /// Encoded/decoded by serializers as &quot;S520&quot;.
    /// </summary>
    [EnumMember(Value = "S520")]
    [IsoId("_OvyzkZ2MEeW-bsa36JFb9A")]
    [Description(@"CPI Discount Commercial Paper (CP).")]
    CPIDiscountCommercialPaperCP = DTCAssetTypeCode.CPIDiscountCommercialPaperCP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CPI Interest at Maturity (IAM) Commercial Paper.
    /// Encoded/decoded by serializers as &quot;S510&quot;.
    /// </summary>
    [EnumMember(Value = "S510")]
    [IsoId("_O0tIwZ2MEeW-bsa36JFb9A")]
    [Description(@"CPI Interest at Maturity (IAM) Commercial Paper.")]
    CPIInterestAtMaturityIAMCommercialPaper =
        DTCAssetTypeCode.CPIInterestAtMaturityIAMCommercialPaper, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Custody User CUSIP.
    /// Encoded/decoded by serializers as &quot;S126&quot;.
    /// </summary>
    [EnumMember(Value = "S126")]
    [IsoId("_P0FiIZ2MEeW-bsa36JFb9A")]
    [Description(@"Custody User CUSIP.")]
    CustodyUserCUSIP = DTCAssetTypeCode.CustodyUserCUSIP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debt Unit.
    /// Encoded/decoded by serializers as &quot;S781&quot;.
    /// </summary>
    [EnumMember(Value = "S781")]
    [IsoId("_P3gpkZ2MEeW-bsa36JFb9A")]
    [Description(@"Debt Unit.")]
    DebtUnit = DTCAssetTypeCode.DebtUnit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Depositary Share.
    /// Encoded/decoded by serializers as &quot;S111&quot;.
    /// </summary>
    [EnumMember(Value = "S111")]
    [IsoId("_P6yAAZ2MEeW-bsa36JFb9A")]
    [Description(@"Depositary Share.")]
    DepositaryShare = DTCAssetTypeCode.DepositaryShare, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equity.
    /// Encoded/decoded by serializers as &quot;S005&quot;.
    /// </summary>
    [EnumMember(Value = "S005")]
    [IsoId("_P-NHcZ2MEeW-bsa36JFb9A")]
    [Description(@"Equity.")]
    Equity = DTCAssetTypeCode.Equity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equity, subject to 144a, designated investors.
    /// Encoded/decoded by serializers as &quot;S121&quot;.
    /// </summary>
    [EnumMember(Value = "S121")]
    [IsoId("_QBoO4Z2MEeW-bsa36JFb9A")]
    [Description(@"Equity, subject to 144a, designated investors.")]
    Equity144aDesignatedInvestors = DTCAssetTypeCode.Equity144aDesignatedInvestors, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equity Derivative.
    /// Encoded/decoded by serializers as &quot;S705&quot;.
    /// </summary>
    [EnumMember(Value = "S705")]
    [IsoId("_QFCvQZ2MEeW-bsa36JFb9A")]
    [Description(@"Equity Derivative.")]
    EquityDerivative = DTCAssetTypeCode.EquityDerivative, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange Traded Funds.
    /// Encoded/decoded by serializers as &quot;S117&quot;.
    /// </summary>
    [EnumMember(Value = "S117")]
    [IsoId("_QOatsZ2MEeW-bsa36JFb9A")]
    [Description(@"Exchange Traded Funds.")]
    ExchangeTradedFunds = DTCAssetTypeCode.ExchangeTradedFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GNMA Pass-through securities.
    /// Encoded/decoded by serializers as &quot;S451&quot;.
    /// </summary>
    [EnumMember(Value = "S451")]
    [IsoId("_QR_mIZ2MEeW-bsa36JFb9A")]
    [Description(@"GNMA Pass-through securities.")]
    GNMAPassThroughSecurities = DTCAssetTypeCode.GNMAPassThroughSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Government Nat&apos;l Mortgage Association (GNMA).
    /// Encoded/decoded by serializers as &quot;S650&quot;.
    /// </summary>
    [EnumMember(Value = "S650")]
    [IsoId("_Qd5UIZ2MEeW-bsa36JFb9A")]
    [Description(@"Government Nat'l Mortgage Association (GNMA).")]
    GovernmentNatlMortgageAssociationGNMA = DTCAssetTypeCode.GovernmentNatlMortgageAssociationGNMA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Government security.
    /// Encoded/decoded by serializers as &quot;S601&quot;.
    /// </summary>
    [EnumMember(Value = "S601")]
    [IsoId("_Qgt-oZ2MEeW-bsa36JFb9A")]
    [Description(@"Government security.")]
    GovernmentSecurity = DTCAssetTypeCode.GovernmentSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issue Denomination in &quot;Units&quot; or &quot;Undivided Interest&quot;.
    /// Encoded/decoded by serializers as &quot;S042&quot;.
    /// </summary>
    [EnumMember(Value = "S042")]
    [IsoId("_QpzCIZ2MEeW-bsa36JFb9A")]
    [Description(@"Issue Denomination in ""Units"" or ""Undivided Interest"".")]
    IssueDenominUnitsorUndividedInterest = DTCAssetTypeCode.IssueDenominUnitsorUndividedInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equity Unit.
    /// Encoded/decoded by serializers as &quot;S780&quot;.
    /// </summary>
    [EnumMember(Value = "S780")]
    [IsoId("_Q40VkZ2MEeW-bsa36JFb9A")]
    [Description(@"Equity Unit.")]
    EquityUnit = DTCAssetTypeCode.EquityUnit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Global Unit Trust.
    /// Encoded/decoded by serializers as &quot;S791&quot;.
    /// </summary>
    [EnumMember(Value = "S791")]
    [IsoId("_RBJyMZ2MEeW-bsa36JFb9A")]
    [Description(@"Global Unit Trust.")]
    GlobalUnitTrust = DTCAssetTypeCode.GlobalUnitTrust, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GNMA Serial note securities.
    /// Encoded/decoded by serializers as &quot;S452&quot;.
    /// </summary>
    [EnumMember(Value = "S452")]
    [IsoId("_ROY88Z2MEeW-bsa36JFb9A")]
    [Description(@"GNMA Serial note securities.")]
    GNMASerialNoteSecurities = DTCAssetTypeCode.GNMASerialNoteSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GNMA Serial Note.
    /// Encoded/decoded by serializers as &quot;S652&quot;.
    /// </summary>
    [EnumMember(Value = "S652")]
    [IsoId("_RTdDIZ2MEeW-bsa36JFb9A")]
    [Description(@"GNMA Serial Note.")]
    GNMASerialNote = DTCAssetTypeCode.GNMASerialNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GNMA REMIC securities.
    /// Encoded/decoded by serializers as &quot;S450&quot;.
    /// </summary>
    [EnumMember(Value = "S450")]
    [IsoId("_RXUPcZ2MEeW-bsa36JFb9A")]
    [Description(@"GNMA REMIC securities.")]
    GNMAREMICSecurities = DTCAssetTypeCode.GNMAREMICSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Government Trust Certificate.
    /// Encoded/decoded by serializers as &quot;S602&quot;.
    /// </summary>
    [EnumMember(Value = "S602")]
    [IsoId("_Rok-kZ2MEeW-bsa36JFb9A")]
    [Description(@"Government Trust Certificate.")]
    GovernmentTrustCertificate = DTCAssetTypeCode.GovernmentTrustCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// (IMMI) Institutional MMI Mutual Fund Shares.
    /// Encoded/decoded by serializers as &quot;S762&quot;.
    /// </summary>
    [EnumMember(Value = "S762")]
    [IsoId("_Rsl74Z2MEeW-bsa36JFb9A")]
    [Description(@"(IMMI) Institutional MMI Mutual Fund Shares.")]
    IMMIInstitutionalMMIMutualFundShares = DTCAssetTypeCode.IMMIInstitutionalMMIMutualFundShares, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Junk and Treasury Growth Receipt (JGR).
    /// Encoded/decoded by serializers as &quot;S603&quot;.
    /// </summary>
    [EnumMember(Value = "S603")]
    [IsoId("_Rx89AZ2MEeW-bsa36JFb9A")]
    [Description(@"Junk and Treasury Growth Receipt (JGR).")]
    JunkAndTreasuryGrowthReceiptJGR = DTCAssetTypeCode.JunkAndTreasuryGrowthReceiptJGR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Limited Partnership.
    /// Encoded/decoded by serializers as &quot;S030&quot;.
    /// </summary>
    [EnumMember(Value = "S030")]
    [IsoId("_R10JUZ2MEeW-bsa36JFb9A")]
    [Description(@"Limited Partnership.")]
    LimitedPartnership = DTCAssetTypeCode.LimitedPartnership, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MMI Bankers&apos; Acceptance Note (BA).
    /// Encoded/decoded by serializers as &quot;S502&quot;.
    /// </summary>
    [EnumMember(Value = "S502")]
    [IsoId("_R6IooZ2MEeW-bsa36JFb9A")]
    [Description(@"MMI Bankers' Acceptance Note (BA).")]
    MMIBankersAcceptanceNoteBA = DTCAssetTypeCode.MMIBankersAcceptanceNoteBA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MMI Corporate Commercial Paper.
    /// Encoded/decoded by serializers as &quot;S525&quot;.
    /// </summary>
    [EnumMember(Value = "S525")]
    [IsoId("_R9Z_EZ2MEeW-bsa36JFb9A")]
    [Description(@"MMI Corporate Commercial Paper.")]
    MMICorporateCommercialPaper = DTCAssetTypeCode.MMICorporateCommercialPaper, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MMI Corporate VRDO/CP.
    /// Encoded/decoded by serializers as &quot;S526&quot;.
    /// </summary>
    [EnumMember(Value = "S526")]
    [IsoId("_SA-QcZ2MEeW-bsa36JFb9A")]
    [Description(@"MMI Corporate VRDO/CP.")]
    MMICorporateVRDOCP = DTCAssetTypeCode.MMICorporateVRDOCP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MMI Deposit Note.
    /// Encoded/decoded by serializers as &quot;S531&quot;.
    /// </summary>
    [EnumMember(Value = "S531")]
    [IsoId("_SEZX4Z2MEeW-bsa36JFb9A")]
    [Description(@"MMI Deposit Note.")]
    MMIDepositNote = DTCAssetTypeCode.MMIDepositNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MMI Discount Note.
    /// Encoded/decoded by serializers as &quot;S560&quot;.
    /// </summary>
    [EnumMember(Value = "S560")]
    [IsoId("_SI3BIZ2MEeW-bsa36JFb9A")]
    [Description(@"MMI Discount Note.")]
    MMIDiscountNote = DTCAssetTypeCode.MMIDiscountNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MMI Institutional Certificates of Deposit.
    /// Encoded/decoded by serializers as &quot;S504&quot;.
    /// </summary>
    [EnumMember(Value = "S504")]
    [IsoId("_SM4lgZ2MEeW-bsa36JFb9A")]
    [Description(@"MMI Institutional Certificates of Deposit.")]
    MMIInstitutionalCertificatesofDeposit = DTCAssetTypeCode.MMIInstitutionalCertificatesofDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MMI Medium-Term Bank Note.
    /// Encoded/decoded by serializers as &quot;S532&quot;.
    /// </summary>
    [EnumMember(Value = "S532")]
    [IsoId("_SRMdwZ2MEeW-bsa36JFb9A")]
    [Description(@"MMI Medium-Term Bank Note.")]
    MMIMediumTermBankNote = DTCAssetTypeCode.MMIMediumTermBankNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MMI Medium Term Note.
    /// Encoded/decoded by serializers as &quot;S533&quot;.
    /// </summary>
    [EnumMember(Value = "S533")]
    [IsoId("_Ty79UZ2MEeW-bsa36JFb9A")]
    [Description(@"MMI Medium Term Note.")]
    MMIMediumTermNote = DTCAssetTypeCode.MMIMediumTermNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MMI Municipal Commercial Paper.
    /// Encoded/decoded by serializers as &quot;S330&quot;.
    /// </summary>
    [EnumMember(Value = "S330")]
    [IsoId("_T32SgZ2MEeW-bsa36JFb9A")]
    [Description(@"MMI Municipal Commercial Paper.")]
    MMIMunicipalCommercialPaper = DTCAssetTypeCode.MMIMunicipalCommercialPaper, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MMI Municipal VRDO/CP.
    /// Encoded/decoded by serializers as &quot;S320&quot;.
    /// </summary>
    [EnumMember(Value = "S320")]
    [IsoId("_T8Kx0Z2MEeW-bsa36JFb9A")]
    [Description(@"MMI Municipal VRDO/CP.")]
    MMIMunicipalVRDOCP = DTCAssetTypeCode.MMIMunicipalVRDOCP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MMI Preferred Stock (in CP-like mode).
    /// Encoded/decoded by serializers as &quot;S120&quot;.
    /// </summary>
    [EnumMember(Value = "S120")]
    [IsoId("_UALvIZ2MEeW-bsa36JFb9A")]
    [Description(@"MMI Preferred Stock (in CP-like mode).")]
    MMIPreferredStockinCPlikemode = DTCAssetTypeCode.MMIPreferredStockinCPlikemode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MMI Short-Term Bank Note.
    /// Encoded/decoded by serializers as &quot;S550&quot;.
    /// </summary>
    [EnumMember(Value = "S550")]
    [IsoId("_UEWdcZ2MEeW-bsa36JFb9A")]
    [Description(@"MMI Short-Term Bank Note.")]
    MMIShortTermBankNote = DTCAssetTypeCode.MMIShortTermBankNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MTN Medium Term Note.
    /// Encoded/decoded by serializers as &quot;S530&quot;.
    /// </summary>
    [EnumMember(Value = "S530")]
    [IsoId("_UIgksZ2MEeW-bsa36JFb9A")]
    [Description(@"MTN Medium Term Note.")]
    MTNMediumTermNote = DTCAssetTypeCode.MTNMediumTermNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Municipal Amortized Issue.
    /// Encoded/decoded by serializers as &quot;S708&quot;.
    /// </summary>
    [EnumMember(Value = "S708")]
    [IsoId("_UNa54Z2MEeW-bsa36JFb9A")]
    [Description(@"Municipal Amortized Issue.")]
    MunicipalAmortizedIssue = DTCAssetTypeCode.MunicipalAmortizedIssue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Municipal Auction Rate Note (ARN).
    /// Encoded/decoded by serializers as &quot;S312&quot;.
    /// </summary>
    [EnumMember(Value = "S312")]
    [IsoId("_USLeEZ2MEeW-bsa36JFb9A")]
    [Description(@"Municipal Auction Rate Note (ARN).")]
    MunicipalAuctionRateNoteARN = DTCAssetTypeCode.MunicipalAuctionRateNoteARN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Municipal Bond.
    /// Encoded/decoded by serializers as &quot;S310&quot;.
    /// </summary>
    [EnumMember(Value = "S310")]
    [IsoId("_UVdbkZ2MEeW-bsa36JFb9A")]
    [Description(@"Municipal Bond.")]
    MunicipalBond = DTCAssetTypeCode.MunicipalBond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Municipal Derivative.
    /// Encoded/decoded by serializers as &quot;S706&quot;.
    /// </summary>
    [EnumMember(Value = "S706")]
    [IsoId("_UZBs8Z2MEeW-bsa36JFb9A")]
    [Description(@"Municipal Derivative.")]
    MunicipalDerivative = DTCAssetTypeCode.MunicipalDerivative, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Municipal Insured Custodial Receipt.
    /// Encoded/decoded by serializers as &quot;S315&quot;.
    /// </summary>
    [EnumMember(Value = "S315")]
    [IsoId("_UcvvUZ2MEeW-bsa36JFb9A")]
    [Description(@"Municipal Insured Custodial Receipt.")]
    MunicipalInsuredCustodialReceipt = DTCAssetTypeCode.MunicipalInsuredCustodialReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Municipal Note.
    /// Encoded/decoded by serializers as &quot;S311&quot;.
    /// </summary>
    [EnumMember(Value = "S311")]
    [IsoId("_UgUAsZ2MEeW-bsa36JFb9A")]
    [Description(@"Municipal Note.")]
    MunicipalNote = DTCAssetTypeCode.MunicipalNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Municipal debt, classified as other, subject to tax exempt.
    /// Encoded/decoded by serializers as &quot;S346&quot;.
    /// </summary>
    [EnumMember(Value = "S346")]
    [IsoId("_UkCDEZ2MEeW-bsa36JFb9A")]
    [Description(@"Municipal debt, classified as other, subject to tax exempt.")]
    MunicipalOtherTaxExempt = DTCAssetTypeCode.MunicipalOtherTaxExempt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Municipal Option Call Right.
    /// Encoded/decoded by serializers as &quot;S112&quot;.
    /// </summary>
    [EnumMember(Value = "S112")]
    [IsoId("_Up1wIZ2MEeW-bsa36JFb9A")]
    [Description(@"Municipal Option Call Right.")]
    MunicipalOptionCallRight = DTCAssetTypeCode.MunicipalOptionCallRight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Municipal Variable Mode Obligation (VMO).
    /// Encoded/decoded by serializers as &quot;S313&quot;.
    /// </summary>
    [EnumMember(Value = "S313")]
    [IsoId("_U6gCUZ2MEeW-bsa36JFb9A")]
    [Description(@"Municipal Variable Mode Obligation (VMO).")]
    MunicipalVariableModeObligationVMO = DTCAssetTypeCode.MunicipalVariableModeObligationVMO, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Municipal Variable Rate Demand Obligation (VRDO).
    /// Encoded/decoded by serializers as &quot;S314&quot;.
    /// </summary>
    [EnumMember(Value = "S314")]
    [IsoId("_U-g_oZ2MEeW-bsa36JFb9A")]
    [Description(@"Municipal Variable Rate Demand Obligation (VRDO).")]
    MunicipalVariableRateDemandObligationVRDO =
        DTCAssetTypeCode.MunicipalVariableRateDemandObligationVRDO, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mutual Fund.
    /// Encoded/decoded by serializers as &quot;S760&quot;.
    /// </summary>
    [EnumMember(Value = "S760")]
    [IsoId("_VC1e8Z2MEeW-bsa36JFb9A")]
    [Description(@"Mutual Fund.")]
    MutualFund = DTCAssetTypeCode.MutualFund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Non-CMO/ABS Amortizing Issue.
    /// Encoded/decoded by serializers as &quot;S542&quot;.
    /// </summary>
    [EnumMember(Value = "S542")]
    [IsoId("_VHJXMZ2MEeW-bsa36JFb9A")]
    [Description(@"Non-CMO/ABS Amortizing Issue.")]
    NonCMOABSAmortizingIssue = DTCAssetTypeCode.NonCMOABSAmortizingIssue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Non standard asset user CUSIP.
    /// Encoded/decoded by serializers as &quot;S127&quot;.
    /// </summary>
    [EnumMember(Value = "S127")]
    [IsoId("_VLKUgZ2MEeW-bsa36JFb9A")]
    [Description(@"Non standard asset user CUSIP.")]
    NonStandardAssetUserCUSIP = DTCAssetTypeCode.NonStandardAssetUserCUSIP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option Derivative.
    /// Encoded/decoded by serializers as &quot;S710&quot;.
    /// </summary>
    [EnumMember(Value = "S710")]
    [IsoId("_VRQ8gZ2MEeW-bsa36JFb9A")]
    [Description(@"Option Derivative.")]
    OptionDerivative = DTCAssetTypeCode.OptionDerivative, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Package.
    /// Encoded/decoded by serializers as &quot;S700&quot;.
    /// </summary>
    [EnumMember(Value = "S700")]
    [IsoId("_VVulwZ2MEeW-bsa36JFb9A")]
    [Description(@"Package.")]
    Package = DTCAssetTypeCode.Package, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Periodic Payment Commercial Paper.
    /// Encoded/decoded by serializers as &quot;S511&quot;.
    /// </summary>
    [EnumMember(Value = "S511")]
    [IsoId("_VaCeAZ2MEeW-bsa36JFb9A")]
    [Description(@"Periodic Payment Commercial Paper.")]
    PeriodicPaymentCommercialPaper = DTCAssetTypeCode.PeriodicPaymentCommercialPaper, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Preferred Stock.
    /// Encoded/decoded by serializers as &quot;S020&quot;.
    /// </summary>
    [EnumMember(Value = "S020")]
    [IsoId("_VeECYZ2MEeW-bsa36JFb9A")]
    [Description(@"Preferred Stock.")]
    PreferredStock = DTCAssetTypeCode.PreferredStock, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Preferred Stock REIT.
    /// Encoded/decoded by serializers as &quot;S022&quot;.
    /// </summary>
    [EnumMember(Value = "S022")]
    [IsoId("_VjaccZ2MEeW-bsa36JFb9A")]
    [Description(@"Preferred Stock REIT.")]
    PreferredStockREIT = DTCAssetTypeCode.PreferredStockREIT, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Real-Estate Investment Trust (REIT).
    /// Encoded/decoded by serializers as &quot;S130&quot;.
    /// </summary>
    [EnumMember(Value = "S130")]
    [IsoId("_WCp9MZ2MEeW-bsa36JFb9A")]
    [Description(@"Real-Estate Investment Trust (REIT).")]
    RealEstateInvestmentTrustREIT = DTCAssetTypeCode.RealEstateInvestmentTrustREIT, // same ordinal as derivation source for type conversions

    /// <summary>
    /// REMIC (Real Estate Mortgage Investment Conduit).
    /// Encoded/decoded by serializers as &quot;S651&quot;.
    /// </summary>
    [EnumMember(Value = "S651")]
    [IsoId("_WF7ToZ2MEeW-bsa36JFb9A")]
    [Description(@"REMIC (Real Estate Mortgage Investment Conduit).")]
    REMICRealEstateMtgeInvestmentConduit = DTCAssetTypeCode.REMICRealEstateMtgeInvestmentConduit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Right.
    /// Encoded/decoded by serializers as &quot;S730&quot;.
    /// </summary>
    [EnumMember(Value = "S730")]
    [IsoId("_WJNRIZ2MEeW-bsa36JFb9A")]
    [Description(@"Right.")]
    Right = DTCAssetTypeCode.Right, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sealed Envelope.
    /// Encoded/decoded by serializers as &quot;S125&quot;.
    /// </summary>
    [EnumMember(Value = "S125")]
    [IsoId("_WN0EUZ2MEeW-bsa36JFb9A")]
    [Description(@"Sealed Envelope.")]
    SealedEnvelope = DTCAssetTypeCode.SealedEnvelope, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tender Rate Note.
    /// Encoded/decoded by serializers as &quot;S578&quot;.
    /// </summary>
    [EnumMember(Value = "S578")]
    [IsoId("_WX7poZ2MEeW-bsa36JFb9A")]
    [Description(@"Tender Rate Note.")]
    TenderRateNote = DTCAssetTypeCode.TenderRateNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tender Rate Preferred Stock.
    /// Encoded/decoded by serializers as &quot;S024&quot;.
    /// </summary>
    [EnumMember(Value = "S024")]
    [IsoId("_Wb8m8Z2MEeW-bsa36JFb9A")]
    [Description(@"Tender Rate Preferred Stock.")]
    TenderRatePreferredStock = DTCAssetTypeCode.TenderRatePreferredStock, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit Investment Trust (UIT).
    /// Encoded/decoded by serializers as &quot;S795&quot;.
    /// </summary>
    [EnumMember(Value = "S795")]
    [IsoId("_WgHVQZ2MEeW-bsa36JFb9A")]
    [Description(@"Unit Investment Trust (UIT).")]
    UnitInvestmentTrustUIT = DTCAssetTypeCode.UnitInvestmentTrustUIT, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit Investment Trust (UIT) - Nuveen Only.
    /// Encoded/decoded by serializers as &quot;S790&quot;.
    /// </summary>
    [EnumMember(Value = "S790")]
    [IsoId("_Wj1XoZ2MEeW-bsa36JFb9A")]
    [Description(@"Unit Investment Trust (UIT) - Nuveen Only.")]
    UnitInvestmentTrustUITNuveenOnly = DTCAssetTypeCode.UnitInvestmentTrustUITNuveenOnly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// U.S. government agency security.
    /// Encoded/decoded by serializers as &quot;S620&quot;.
    /// </summary>
    [EnumMember(Value = "S620")]
    [IsoId("_Wn2U8Z2MEeW-bsa36JFb9A")]
    [Description(@"U.S. government agency security.")]
    USGovernmentAgencySecurity = DTCAssetTypeCode.USGovernmentAgencySecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US Treasury Bill.
    /// Encoded/decoded by serializers as &quot;S611&quot;.
    /// </summary>
    [EnumMember(Value = "S611")]
    [IsoId("_WsT-MZ2MEeW-bsa36JFb9A")]
    [Description(@"US Treasury Bill.")]
    USTreasuryBill = DTCAssetTypeCode.USTreasuryBill, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US Treasury Bond.
    /// Encoded/decoded by serializers as &quot;S613&quot;.
    /// </summary>
    [EnumMember(Value = "S613")]
    [IsoId("_WwodgZ2MEeW-bsa36JFb9A")]
    [Description(@"US Treasury Bond.")]
    USTreasuryBond = DTCAssetTypeCode.USTreasuryBond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// U.S. Treasury security.
    /// Encoded/decoded by serializers as &quot;S610&quot;.
    /// </summary>
    [EnumMember(Value = "S610")]
    [IsoId("_W0pa0Z2MEeW-bsa36JFb9A")]
    [Description(@"U.S. Treasury security.")]
    USTreasurySecurity = DTCAssetTypeCode.USTreasurySecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US Treasury Note.
    /// Encoded/decoded by serializers as &quot;S612&quot;.
    /// </summary>
    [EnumMember(Value = "S612")]
    [IsoId("_W6mR0Z2MEeW-bsa36JFb9A")]
    [Description(@"US Treasury Note.")]
    USTreasuryNote = DTCAssetTypeCode.USTreasuryNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Warrant.
    /// Encoded/decoded by serializers as &quot;S720&quot;.
    /// </summary>
    [EnumMember(Value = "S720")]
    [IsoId("_W_9S8Z2MEeW-bsa36JFb9A")]
    [Description(@"Warrant.")]
    Warrant = DTCAssetTypeCode.Warrant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Z CPN Denomination in Initial Principal Amt.
    /// Encoded/decoded by serializers as &quot;S551&quot;.
    /// </summary>
    [EnumMember(Value = "S551")]
    [IsoId("_XGDT4Z2MEeW-bsa36JFb9A")]
    [Description(@"Z CPN Denomination in Initial Principal Amt.")]
    ZCPNDenominInitialPrincipalAmt = DTCAssetTypeCode.ZCPNDenominInitialPrincipalAmt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Zero Coupon Bond.
    /// Encoded/decoded by serializers as &quot;S579&quot;.
    /// </summary>
    [EnumMember(Value = "S579")]
    [IsoId("_XJxWQZ2MEeW-bsa36JFb9A")]
    [Description(@"Zero Coupon Bond.")]
    ZeroCouponBond = DTCAssetTypeCode.ZeroCouponBond, // same ordinal as derivation source for type conversions
}
