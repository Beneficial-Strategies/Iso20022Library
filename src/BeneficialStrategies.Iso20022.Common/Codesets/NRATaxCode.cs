// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Non resident alien U.S. tax codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1ygnJjL3EeKU9IrkkToqcw_1746439852")]
[Description(@"Non resident alien U.S. tax codes.")]
[Derivations(typeof(NRATax1Code), typeof(NRATax2Code))]
public enum NRATaxCode
{
    /// <summary>
    /// Tax category for domestic source income dividends.
    /// Encoded/decoded by serializers as &quot;T011&quot;.
    /// </summary>
    [EnumMember(Value = "T011")]
    [IsoId("_1yqYIDL3EeKU9IrkkToqcw_1138535937")]
    [Description(@"Tax category for domestic source income dividends.")]
    DomesticIncomeDividend,

    /// <summary>
    /// Tax category for foreign source income dividends.
    /// Encoded/decoded by serializers as &quot;T012&quot;.
    /// </summary>
    [EnumMember(Value = "T012")]
    [IsoId("_1yqYITL3EeKU9IrkkToqcw_1535484529")]
    [Description(@"Tax category for foreign source income dividends.")]
    ForeignIncomeDividends,

    /// <summary>
    /// Tax category for non taxable domestic dividends.
    /// Encoded/decoded by serializers as &quot;T013&quot;.
    /// </summary>
    [EnumMember(Value = "T013")]
    [IsoId("_1yqYIjL3EeKU9IrkkToqcw_-2202158")]
    [Description(@"Tax category for non taxable domestic dividends.")]
    DividendsDomesticNonTaxable,

    /// <summary>
    /// Tax category for fully exempt dividends on municipal type mutual funds.
    /// Encoded/decoded by serializers as &quot;T014&quot;.
    /// </summary>
    [EnumMember(Value = "T014")]
    [IsoId("_1yqYIzL3EeKU9IrkkToqcw_-732152901")]
    [Description(@"Tax category for fully exempt dividends on municipal type mutual funds.")]
    DividendsFullyExempt,

    /// <summary>
    /// Tax category for federal taxable state exempt dividends.
    /// Encoded/decoded by serializers as &quot;T015&quot;.
    /// </summary>
    [EnumMember(Value = "T015")]
    [IsoId("_1yqYJDL3EeKU9IrkkToqcw_-1001315771")]
    [Description(@"Tax category for federal taxable state exempt dividends.")]
    DividendsFederalTaxableStateExempt,

    /// <summary>
    /// Tax category for Return Of Capital proceeds.
    /// Encoded/decoded by serializers as &quot;T019&quot;.
    /// </summary>
    [EnumMember(Value = "T019")]
    [IsoId("_1yqYJTL3EeKU9IrkkToqcw_-103952482")]
    [Description(@"Tax category for Return Of Capital proceeds.")]
    ReturnOfCapital,

    /// <summary>
    /// Tax category for Long Term Capital Gains proceeds.
    /// Encoded/decoded by serializers as &quot;T021&quot;.
    /// </summary>
    [EnumMember(Value = "T021")]
    [IsoId("_1y0JIDL3EeKU9IrkkToqcw_-153226606")]
    [Description(@"Tax category for Long Term Capital Gains proceeds.")]
    LongTermCapitalGains,

    /// <summary>
    /// Tax category for Short Term Capital Gains proceeds.
    /// Encoded/decoded by serializers as &quot;T022&quot;.
    /// </summary>
    [EnumMember(Value = "T022")]
    [IsoId("_1y0JITL3EeKU9IrkkToqcw_-1287689129")]
    [Description(@"Tax category for Short Term Capital Gains proceeds.")]
    ShortTermCapitalGains,

    /// <summary>
    /// Tax category for FIRPTA eligible (REITS).
    /// Encoded/decoded by serializers as &quot;T023&quot;.
    /// </summary>
    [EnumMember(Value = "T023")]
    [IsoId("_1y0JIjL3EeKU9IrkkToqcw_170454163")]
    [Description(@"Tax category for FIRPTA eligible (REITS).")]
    FIRPTAEligible,

    /// <summary>
    /// Tax category for REIT (Capital Gain Distributions).
    /// Encoded/decoded by serializers as &quot;T025&quot;.
    /// </summary>
    [EnumMember(Value = "T025")]
    [IsoId("_1y0JIzL3EeKU9IrkkToqcw_-1142565668")]
    [Description(@"Tax category for REIT (Capital Gain Distributions).")]
    REITCapitalGainDistributions,

    /// <summary>
    /// Tax category for limited publicly traded partnership.
    /// Encoded/decoded by serializers as &quot;T026&quot;.
    /// </summary>
    [EnumMember(Value = "T026")]
    [IsoId("_1y0JJDL3EeKU9IrkkToqcw_-533979505")]
    [Description(@"Tax category for limited publicly traded partnership.")]
    LimitedPubliclyTradedPartnership,

    /// <summary>
    /// Tax category for substitute dividend payments.
    /// Encoded/decoded by serializers as &quot;T027&quot;.
    /// </summary>
    [EnumMember(Value = "T027")]
    [IsoId("_1y0JJTL3EeKU9IrkkToqcw_1407844438")]
    [Description(@"Tax category for substitute dividend payments.")]
    SubstituteDividendPayment,

    /// <summary>
    /// Tax category for short term capital gain distributions.
    /// Encoded/decoded by serializers as &quot;T029&quot;.
    /// </summary>
    [EnumMember(Value = "T029")]
    [IsoId("_1y0JJjL3EeKU9IrkkToqcw_284951777")]
    [Description(@"Tax category for short term capital gain distributions.")]
    CapitalGainDistributionShortTermRICs,

    /// <summary>
    /// Tax category for dividend or capital gains distribution due to a corporate action.
    /// Encoded/decoded by serializers as &quot;T302&quot;.
    /// </summary>
    [EnumMember(Value = "T302")]
    [IsoId("_1y9TEDL3EeKU9IrkkToqcw_1304847187")]
    [Description(
        @"Tax category for dividend or capital gains distribution due to a corporate action."
    )]
    CorporateActionDividendCapitalGains,

    /// <summary>
    /// Tax category for U.S. source ordinary interest proceeds.
    /// Encoded/decoded by serializers as &quot;T041&quot;.
    /// </summary>
    [EnumMember(Value = "T041")]
    [IsoId("_1y9TETL3EeKU9IrkkToqcw_1549530022")]
    [Description(@"Tax category for U.S. source ordinary interest proceeds.")]
    USSourceOrdinaryInterest,

    /// <summary>
    /// Tax category for foreign bond interest proceeds.
    /// Encoded/decoded by serializers as &quot;T042&quot;.
    /// </summary>
    [EnumMember(Value = "T042")]
    [IsoId("_1y9TEjL3EeKU9IrkkToqcw_-461327810")]
    [Description(@"Tax category for foreign bond interest proceeds.")]
    ForeignBondInterest,

    /// <summary>
    /// Tax category for all state and territorial municipal interest proceeds.
    /// Encoded/decoded by serializers as &quot;T043&quot;.
    /// </summary>
    [EnumMember(Value = "T043")]
    [IsoId("_1y9TEzL3EeKU9IrkkToqcw_1746481858")]
    [Description(@"Tax category for all state and territorial municipal interest proceeds.")]
    AllStateAndTerritorialMunicipalInterest,

    /// <summary>
    /// Tax category for all municipal bonds that are subject to federal tax proceeds.
    /// Encoded/decoded by serializers as &quot;T044&quot;.
    /// </summary>
    [EnumMember(Value = "T044")]
    [IsoId("_1y9TFDL3EeKU9IrkkToqcw_-902147803")]
    [Description(@"Tax category for all municipal bonds that are subject to federal tax proceeds.")]
    AllMunicipalBondsSubjectToFederalTax,

    /// <summary>
    /// Tax category for U.S. government interest on contracts Notes &amp; mortgages proceeds.
    /// Encoded/decoded by serializers as &quot;T045&quot;.
    /// </summary>
    [EnumMember(Value = "T045")]
    [IsoId("_1y9TFTL3EeKU9IrkkToqcw_-864238552")]
    [Description(
        @"Tax category for U.S. government interest on contracts Notes & mortgages proceeds."
    )]
    USGovernmentInterestOnContractsNotesAndMortgages,

    /// <summary>
    /// Tax category for U.S. government interest on GNMA 1 &amp; 2 proceeds.
    /// Encoded/decoded by serializers as &quot;T046&quot;.
    /// </summary>
    [EnumMember(Value = "T046")]
    [IsoId("_1y9TFjL3EeKU9IrkkToqcw_1035930644")]
    [Description(@"Tax category for U.S. government interest on GNMA 1 & 2 proceeds.")]
    USGovernmentInterestOnGNMA1And2,

    /// <summary>
    /// Tax category for interest on collateralized mortgage obligations proceeds.
    /// Encoded/decoded by serializers as &quot;T047&quot;.
    /// </summary>
    [EnumMember(Value = "T047")]
    [IsoId("_1zHEEDL3EeKU9IrkkToqcw_2094003145")]
    [Description(@"Tax category for interest on collateralized mortgage obligations proceeds.")]
    InterestOnCollatralizedMortgageObligations,

    /// <summary>
    /// Tax category for interests on certificates of deposits proceeds.
    /// Encoded/decoded by serializers as &quot;T048&quot;.
    /// </summary>
    [EnumMember(Value = "T048")]
    [IsoId("_1zHEETL3EeKU9IrkkToqcw_555149388")]
    [Description(@"Tax category for interests on certificates of deposits proceeds.")]
    InterestOnCertificatesOfDeposit,

    /// <summary>
    /// Tax category for U.S. government interest proceeds.
    /// Encoded/decoded by serializers as &quot;T049&quot;.
    /// </summary>
    [EnumMember(Value = "T049")]
    [IsoId("_1zHEEjL3EeKU9IrkkToqcw_764230006")]
    [Description(@"Tax category for U.S. government interest proceeds.")]
    USGovernmentInterest,

    /// <summary>
    /// Tax Category for US government interest on Notes and Bills.
    /// Encoded/decoded by serializers as &quot;T050&quot;.
    /// </summary>
    [EnumMember(Value = "T050")]
    [IsoId("_1zHEEzL3EeKU9IrkkToqcw_648064086")]
    [Description(@"Tax Category for US government interest on Notes and Bills.")]
    USGovernmentInterestOnNotesAndBills,

    /// <summary>
    /// Tax category for principal pay downs proceeds.
    /// Encoded/decoded by serializers as &quot;T051&quot;.
    /// </summary>
    [EnumMember(Value = "T051")]
    [IsoId("_1zHEFDL3EeKU9IrkkToqcw_-1192407720")]
    [Description(@"Tax category for principal pay downs proceeds.")]
    PrincipalPaydowns,

    /// <summary>
    /// Tax category for Short Term Interest (less than 183 days) proceeds.
    /// Encoded/decoded by serializers as &quot;T052&quot;.
    /// </summary>
    [EnumMember(Value = "T052")]
    [IsoId("_1zHEFTL3EeKU9IrkkToqcw_-1390394023")]
    [Description(@"Tax category for Short Term Interest (less than 183 days) proceeds.")]
    ShortTermInterest,

    /// <summary>
    /// Tax category for U.S. Government Interest (longer that 183 days) proceeds.
    /// Encoded/decoded by serializers as &quot;T053&quot;.
    /// </summary>
    [EnumMember(Value = "T053")]
    [IsoId("_1zHEFjL3EeKU9IrkkToqcw_1346079358")]
    [Description(@"Tax category for U.S. Government Interest (longer that 183 days) proceeds.")]
    USGovernmentInterestLongerThan183Days,

    /// <summary>
    /// Tax category for interest substitute payment.
    /// Encoded/decoded by serializers as &quot;T054&quot;.
    /// </summary>
    [EnumMember(Value = "T054")]
    [IsoId("_1zHEFzL3EeKU9IrkkToqcw_752592509")]
    [Description(@"Tax category for interest substitute payment.")]
    InterestSubstitutePayment,

    /// <summary>
    /// Tax category for other substitute payment that cannot be categorised.
    /// Encoded/decoded by serializers as &quot;T055&quot;.
    /// </summary>
    [EnumMember(Value = "T055")]
    [IsoId("_1zQ1EDL3EeKU9IrkkToqcw_-178727883")]
    [Description(@"Tax category for other substitute payment that cannot be categorised.")]
    OtherSusbtitutePayment,

    /// <summary>
    /// Tax category for NRA withholding tax.
    /// Encoded/decoded by serializers as &quot;T061&quot;.
    /// </summary>
    [EnumMember(Value = "T061")]
    [IsoId("_1zQ1ETL3EeKU9IrkkToqcw_-1510200876")]
    [Description(@"Tax category for NRA withholding tax.")]
    NRAWithholdingTax,

    /// <summary>
    /// Tax category for federal backup dividends proceeds.
    /// Encoded/decoded by serializers as &quot;T062&quot;.
    /// </summary>
    [EnumMember(Value = "T062")]
    [IsoId("_1zQ1EjL3EeKU9IrkkToqcw_-1549696392")]
    [Description(@"Tax category for federal backup dividends proceeds.")]
    FederalBackUpDividends,

    /// <summary>
    /// Tax category for federal backup interest proceeds.
    /// Encoded/decoded by serializers as &quot;T063&quot;.
    /// </summary>
    [EnumMember(Value = "T063")]
    [IsoId("_1zQ1EzL3EeKU9IrkkToqcw_-436678230")]
    [Description(@"Tax category for federal backup interest proceeds.")]
    FederalBackUpInterest,

    /// <summary>
    /// Tax category for foreign tax withheld at source dividends proceeds.
    /// Encoded/decoded by serializers as &quot;T064&quot;.
    /// </summary>
    [EnumMember(Value = "T064")]
    [IsoId("_1zQ1FDL3EeKU9IrkkToqcw_-817842795")]
    [Description(@"Tax category for foreign tax withheld at source dividends proceeds.")]
    ForeignTaxWithheldAtSourceDividends,

    /// <summary>
    /// Tax category for foreign tax withheld at source interest proceeds.
    /// Encoded/decoded by serializers as &quot;T065&quot;.
    /// </summary>
    [EnumMember(Value = "T065")]
    [IsoId("_1zQ1FTL3EeKU9IrkkToqcw_184057177")]
    [Description(@"Tax category for foreign tax withheld at source interest proceeds.")]
    ForeignTaxWithheldAtSourceInterest,

    /// <summary>
    /// Tax category for custody issues.
    /// Encoded/decoded by serializers as &quot;T070&quot;.
    /// </summary>
    [EnumMember(Value = "T070")]
    [IsoId("_1zQ1FjL3EeKU9IrkkToqcw_-638450198")]
    [Description(@"Tax category for custody issues.")]
    CustodyIssues,

    /// <summary>
    /// Tax category for interest on balances proceeds.
    /// Encoded/decoded by serializers as &quot;T071&quot;.
    /// </summary>
    [EnumMember(Value = "T071")]
    [IsoId("_1zZ_ADL3EeKU9IrkkToqcw_1254228140")]
    [Description(@"Tax category for interest on balances proceeds.")]
    InterestOnBalances,

    /// <summary>
    /// Tax category for interest on series E or H bonds proceeds.
    /// Encoded/decoded by serializers as &quot;T072&quot;.
    /// </summary>
    [EnumMember(Value = "T072")]
    [IsoId("_1zZ_ATL3EeKU9IrkkToqcw_-1009144171")]
    [Description(@"Tax category for interest on series E or H bonds proceeds.")]
    InterestOnSeriesEOrHBonds,

    /// <summary>
    /// Tax category for royalty payments proceeds.
    /// Encoded/decoded by serializers as &quot;T073&quot;.
    /// </summary>
    [EnumMember(Value = "T073")]
    [IsoId("_1zZ_AjL3EeKU9IrkkToqcw_-1796201894")]
    [Description(@"Tax category for royalty payments proceeds.")]
    RoyaltyPayments,

    /// <summary>
    /// Tax category for other taxable income proceeds.
    /// Encoded/decoded by serializers as &quot;T074&quot;.
    /// </summary>
    [EnumMember(Value = "T074")]
    [IsoId("_1zZ_AzL3EeKU9IrkkToqcw_1191871191")]
    [Description(@"Tax category for other taxable income proceeds.")]
    OtherTaxableIncome,

    /// <summary>
    /// Tax category for other non-taxable income proceeds.
    /// Encoded/decoded by serializers as &quot;T075&quot;.
    /// </summary>
    [EnumMember(Value = "T075")]
    [IsoId("_1zZ_BDL3EeKU9IrkkToqcw_2103685345")]
    [Description(@"Tax category for other non-taxable income proceeds.")]
    OtherNonTaxableIncome,

    /// <summary>
    /// Tax category for miscellaneous payments proceeds.
    /// Encoded/decoded by serializers as &quot;T076&quot;.
    /// </summary>
    [EnumMember(Value = "T076")]
    [IsoId("_1zZ_BTL3EeKU9IrkkToqcw_-50823941")]
    [Description(@"Tax category for miscellaneous payments proceeds.")]
    MiscellaneousPayments,

    /// <summary>
    /// Tax category for Cash-in-Lieu of fractional shares proceeds.
    /// Encoded/decoded by serializers as &quot;T024&quot;.
    /// </summary>
    [EnumMember(Value = "T024")]
    [IsoId("_1zZ_BjL3EeKU9IrkkToqcw_-2068913667")]
    [Description(@"Tax category for Cash-in-Lieu of fractional shares proceeds.")]
    CashInLieuOfFractionalShares,

    /// <summary>
    /// Tax category for stock split proceeds.
    /// Encoded/decoded by serializers as &quot;T077&quot;.
    /// </summary>
    [EnumMember(Value = "T077")]
    [IsoId("_1zjwADL3EeKU9IrkkToqcw_2053434808")]
    [Description(@"Tax category for stock split proceeds.")]
    StockSplit,

    /// <summary>
    /// Tax category for stock dividend proceeds.
    /// Encoded/decoded by serializers as &quot;T078&quot;.
    /// </summary>
    [EnumMember(Value = "T078")]
    [IsoId("_1zjwATL3EeKU9IrkkToqcw_-416143793")]
    [Description(@"Tax category for stock dividend proceeds.")]
    StockDividend,

    /// <summary>
    /// Tax category for cash on increased shares proceeds.
    /// Encoded/decoded by serializers as &quot;T079&quot;.
    /// </summary>
    [EnumMember(Value = "T079")]
    [IsoId("_1zjwAjL3EeKU9IrkkToqcw_324860632")]
    [Description(@"Tax category for cash on increased shares proceeds.")]
    CashOnIncreasedShares,

    /// <summary>
    /// Tax category for spin off proceeds.
    /// Encoded/decoded by serializers as &quot;T080&quot;.
    /// </summary>
    [EnumMember(Value = "T080")]
    [IsoId("_1zjwAzL3EeKU9IrkkToqcw_796700407")]
    [Description(@"Tax category for spin off proceeds.")]
    SpinOff,
}
