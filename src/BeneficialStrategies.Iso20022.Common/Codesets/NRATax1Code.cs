// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Non resident alien U.S. tax codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_12-3cjL3EeKU9IrkkToqcw_681968245")]
[Description(@"Non resident alien U.S. tax codes.")]
[DerivedFrom(typeof(NRATaxCode))]
public enum NRATax1Code
{
    /// <summary>
    /// Tax category for domestic source income dividends.
    /// Encoded/decoded by serializers as &quot;T011&quot;.
    /// </summary>
    [EnumMember(Value = "T011")]
    [IsoId("_12-3czL3EeKU9IrkkToqcw_921269712")]
    [Description(@"Tax category for domestic source income dividends.")]
    DomesticIncomeDividend = NRATaxCode.DomesticIncomeDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for foreign source income dividends.
    /// Encoded/decoded by serializers as &quot;T012&quot;.
    /// </summary>
    [EnumMember(Value = "T012")]
    [IsoId("_12-3dDL3EeKU9IrkkToqcw_-1906548821")]
    [Description(@"Tax category for foreign source income dividends.")]
    ForeignIncomeDividends = NRATaxCode.ForeignIncomeDividends, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for non taxable domestic dividends.
    /// Encoded/decoded by serializers as &quot;T013&quot;.
    /// </summary>
    [EnumMember(Value = "T013")]
    [IsoId("_12-3dTL3EeKU9IrkkToqcw_1999290050")]
    [Description(@"Tax category for non taxable domestic dividends.")]
    DividendsDomesticNonTaxable = NRATaxCode.DividendsDomesticNonTaxable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for fully exempt dividends on municipal type mutual funds.
    /// Encoded/decoded by serializers as &quot;T014&quot;.
    /// </summary>
    [EnumMember(Value = "T014")]
    [IsoId("_12-3djL3EeKU9IrkkToqcw_1988191273")]
    [Description(@"Tax category for fully exempt dividends on municipal type mutual funds.")]
    DividendsFullyExempt = NRATaxCode.DividendsFullyExempt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for federal taxable state exempt dividends.
    /// Encoded/decoded by serializers as &quot;T015&quot;.
    /// </summary>
    [EnumMember(Value = "T015")]
    [IsoId("_13IocDL3EeKU9IrkkToqcw_-10666808")]
    [Description(@"Tax category for federal taxable state exempt dividends.")]
    DividendsFederalTaxableStateExempt = NRATaxCode.DividendsFederalTaxableStateExempt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for Return Of Capital proceeds.
    /// Encoded/decoded by serializers as &quot;T019&quot;.
    /// </summary>
    [EnumMember(Value = "T019")]
    [IsoId("_13IocTL3EeKU9IrkkToqcw_1456481955")]
    [Description(@"Tax category for Return Of Capital proceeds.")]
    ReturnOfCapital = NRATaxCode.ReturnOfCapital, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for Long Term Capital Gains proceeds.
    /// Encoded/decoded by serializers as &quot;T021&quot;.
    /// </summary>
    [EnumMember(Value = "T021")]
    [IsoId("_13IocjL3EeKU9IrkkToqcw_-21765585")]
    [Description(@"Tax category for Long Term Capital Gains proceeds.")]
    LongTermCapitalGains = NRATaxCode.LongTermCapitalGains, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for Short Term Capital Gains proceeds.
    /// Encoded/decoded by serializers as &quot;T022&quot;.
    /// </summary>
    [EnumMember(Value = "T022")]
    [IsoId("_13IoczL3EeKU9IrkkToqcw_1445383178")]
    [Description(@"Tax category for Short Term Capital Gains proceeds.")]
    ShortTermCapitalGains = NRATaxCode.ShortTermCapitalGains, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for FIRPTA eligible (REITS).
    /// Encoded/decoded by serializers as &quot;T023&quot;.
    /// </summary>
    [EnumMember(Value = "T023")]
    [IsoId("_13IodDL3EeKU9IrkkToqcw_432321684")]
    [Description(@"Tax category for FIRPTA eligible (REITS).")]
    FIRPTAEligible = NRATaxCode.FIRPTAEligible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for REIT (Capital Gain Distributions).
    /// Encoded/decoded by serializers as &quot;T025&quot;.
    /// </summary>
    [EnumMember(Value = "T025")]
    [IsoId("_13IodTL3EeKU9IrkkToqcw_1899470447")]
    [Description(@"Tax category for REIT (Capital Gain Distributions).")]
    REITCapitalGainDistributions = NRATaxCode.REITCapitalGainDistributions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for limited publicly traded partnership.
    /// Encoded/decoded by serializers as &quot;T026&quot;.
    /// </summary>
    [EnumMember(Value = "T026")]
    [IsoId("_13IodjL3EeKU9IrkkToqcw_1790132640")]
    [Description(@"Tax category for limited publicly traded partnership.")]
    LimitedPubliclyTradedPartnership = NRATaxCode.LimitedPubliclyTradedPartnership, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for substitute dividend payments.
    /// Encoded/decoded by serializers as &quot;T027&quot;.
    /// </summary>
    [EnumMember(Value = "T027")]
    [IsoId("_13RyYDL3EeKU9IrkkToqcw_-1037685893")]
    [Description(@"Tax category for substitute dividend payments.")]
    SubstituteDividendPayment = NRATaxCode.SubstituteDividendPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for short term capital gain distributions.
    /// Encoded/decoded by serializers as &quot;T029&quot;.
    /// </summary>
    [EnumMember(Value = "T029")]
    [IsoId("_13RyYTL3EeKU9IrkkToqcw_1274814360")]
    [Description(@"Tax category for short term capital gain distributions.")]
    CapitalGainDistributionShortTermRICs = NRATaxCode.CapitalGainDistributionShortTermRICs, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for dividend or capital gains distribution due to a corporate action.
    /// Encoded/decoded by serializers as &quot;T302&quot;.
    /// </summary>
    [EnumMember(Value = "T302")]
    [IsoId("_13RyYjL3EeKU9IrkkToqcw_-1553004173")]
    [Description(
        @"Tax category for dividend or capital gains distribution due to a corporate action."
    )]
    CorporateActionDividendCapitalGains = NRATaxCode.CorporateActionDividendCapitalGains, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for U.S. source ordinary interest proceeds.
    /// Encoded/decoded by serializers as &quot;T041&quot;.
    /// </summary>
    [EnumMember(Value = "T041")]
    [IsoId("_13RyYzL3EeKU9IrkkToqcw_1728901629")]
    [Description(@"Tax category for U.S. source ordinary interest proceeds.")]
    USSourceOrdinaryInterest = NRATaxCode.USSourceOrdinaryInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for foreign bond interest proceeds.
    /// Encoded/decoded by serializers as &quot;T042&quot;.
    /// </summary>
    [EnumMember(Value = "T042")]
    [IsoId("_13RyZDL3EeKU9IrkkToqcw_1717802852")]
    [Description(@"Tax category for foreign bond interest proceeds.")]
    ForeignBondInterest = NRATaxCode.ForeignBondInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for all state and territorial municipal interest proceeds.
    /// Encoded/decoded by serializers as &quot;T043&quot;.
    /// </summary>
    [EnumMember(Value = "T043")]
    [IsoId("_13RyZTL3EeKU9IrkkToqcw_-1110015681")]
    [Description(@"Tax category for all state and territorial municipal interest proceeds.")]
    AllStateAndTerritorialMunicipalInterest = NRATaxCode.AllStateAndTerritorialMunicipalInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for all municipal bonds that are subject to federal tax proceeds.
    /// Encoded/decoded by serializers as &quot;T044&quot;.
    /// </summary>
    [EnumMember(Value = "T044")]
    [IsoId("_13RyZjL3EeKU9IrkkToqcw_679094124")]
    [Description(@"Tax category for all municipal bonds that are subject to federal tax proceeds.")]
    AllMunicipalBondsSubjectToFederalTax = NRATaxCode.AllMunicipalBondsSubjectToFederalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for U.S. government interest on contracts Notes &amp; mortgages proceeds.
    /// Encoded/decoded by serializers as &quot;T045&quot;.
    /// </summary>
    [EnumMember(Value = "T045")]
    [IsoId("_13bjYDL3EeKU9IrkkToqcw_2146242887")]
    [Description(
        @"Tax category for U.S. government interest on contracts Notes & mortgages proceeds."
    )]
    USGovernmentInterestOnContractsNotesAndMortgages =
        NRATaxCode.USGovernmentInterestOnContractsNotesAndMortgages, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for U.S. government interest on GNMA 1 &amp; 2 proceeds.
    /// Encoded/decoded by serializers as &quot;T046&quot;.
    /// </summary>
    [EnumMember(Value = "T046")]
    [IsoId("_13bjYTL3EeKU9IrkkToqcw_44062278")]
    [Description(@"Tax category for U.S. government interest on GNMA 1 & 2 proceeds.")]
    USGovernmentInterestOnGNMA1And2 = NRATaxCode.USGovernmentInterestOnGNMA1And2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for interest on collateralized mortgage obligations proceeds.
    /// Encoded/decoded by serializers as &quot;T047&quot;.
    /// </summary>
    [EnumMember(Value = "T047")]
    [IsoId("_13bjYjL3EeKU9IrkkToqcw_1511211041")]
    [Description(@"Tax category for interest on collateralized mortgage obligations proceeds.")]
    InterestOnCollatralizedMortgageObligations =
        NRATaxCode.InterestOnCollatralizedMortgageObligations, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for interests on certificates of deposits proceeds.
    /// Encoded/decoded by serializers as &quot;T048&quot;.
    /// </summary>
    [EnumMember(Value = "T048")]
    [IsoId("_13bjYzL3EeKU9IrkkToqcw_1122082616")]
    [Description(@"Tax category for interests on certificates of deposits proceeds.")]
    InterestOnCertificatesOfDeposit = NRATaxCode.InterestOnCertificatesOfDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for U.S. government interest proceeds.
    /// Encoded/decoded by serializers as &quot;T049&quot;.
    /// </summary>
    [EnumMember(Value = "T049")]
    [IsoId("_13bjZDL3EeKU9IrkkToqcw_-1705735917")]
    [Description(@"Tax category for U.S. government interest proceeds.")]
    USGovernmentInterest = NRATaxCode.USGovernmentInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax Category for US government interest on Notes and Bills.
    /// Encoded/decoded by serializers as &quot;T050&quot;.
    /// </summary>
    [EnumMember(Value = "T050")]
    [IsoId("_13bjZTL3EeKU9IrkkToqcw_1084096573")]
    [Description(@"Tax Category for US government interest on Notes and Bills.")]
    USGovernmentInterestOnNotesAndBills = NRATaxCode.USGovernmentInterestOnNotesAndBills, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for principal pay downs proceeds.
    /// Encoded/decoded by serializers as &quot;T051&quot;.
    /// </summary>
    [EnumMember(Value = "T051")]
    [IsoId("_13lUYDL3EeKU9IrkkToqcw_-1743721960")]
    [Description(@"Tax category for principal pay downs proceeds.")]
    PrincipalPaydowns = NRATaxCode.PrincipalPaydowns, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for Short Term Interest (less than 183 days) proceeds.
    /// Encoded/decoded by serializers as &quot;T052&quot;.
    /// </summary>
    [EnumMember(Value = "T052")]
    [IsoId("_13lUYTL3EeKU9IrkkToqcw_329346699")]
    [Description(@"Tax category for Short Term Interest (less than 183 days) proceeds.")]
    ShortTermInterest = NRATaxCode.ShortTermInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for U.S. Government Interest (longer that 183 days) proceeds.
    /// Encoded/decoded by serializers as &quot;T053&quot;.
    /// </summary>
    [EnumMember(Value = "T053")]
    [IsoId("_13lUYjL3EeKU9IrkkToqcw_1796495462")]
    [Description(@"Tax category for U.S. Government Interest (longer that 183 days) proceeds.")]
    USGovernmentInterestLongerThan183Days = NRATaxCode.USGovernmentInterestLongerThan183Days, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for interest substitute payment.
    /// Encoded/decoded by serializers as &quot;T054&quot;.
    /// </summary>
    [EnumMember(Value = "T054")]
    [IsoId("_13lUYzL3EeKU9IrkkToqcw_1090111852")]
    [Description(@"Tax category for interest substitute payment.")]
    InterestSubstitutePayment = NRATaxCode.InterestSubstitutePayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for other substitute payment that cannot be categorised.
    /// Encoded/decoded by serializers as &quot;T055&quot;.
    /// </summary>
    [EnumMember(Value = "T055")]
    [IsoId("_13lUZDL3EeKU9IrkkToqcw_-1737706681")]
    [Description(@"Tax category for other substitute payment that cannot be categorised.")]
    OtherSusbtitutePayment = NRATaxCode.OtherSusbtitutePayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for NRA withholding tax.
    /// Encoded/decoded by serializers as &quot;T061&quot;.
    /// </summary>
    [EnumMember(Value = "T061")]
    [IsoId("_13lUZTL3EeKU9IrkkToqcw_-1835165283")]
    [Description(@"Tax category for NRA withholding tax.")]
    NRAWithholdingTax = NRATaxCode.NRAWithholdingTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for federal backup dividends proceeds.
    /// Encoded/decoded by serializers as &quot;T062&quot;.
    /// </summary>
    [EnumMember(Value = "T062")]
    [IsoId("_13lUZjL3EeKU9IrkkToqcw_-368016520")]
    [Description(@"Tax category for federal backup dividends proceeds.")]
    FederalBackUpDividends = NRATaxCode.FederalBackUpDividends, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for federal backup interest proceeds.
    /// Encoded/decoded by serializers as &quot;T063&quot;.
    /// </summary>
    [EnumMember(Value = "T063")]
    [IsoId("_13lUZzL3EeKU9IrkkToqcw_767621816")]
    [Description(@"Tax category for federal backup interest proceeds.")]
    FederalBackUpInterest = NRATaxCode.FederalBackUpInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for foreign tax withheld at source dividends proceeds.
    /// Encoded/decoded by serializers as &quot;T064&quot;.
    /// </summary>
    [EnumMember(Value = "T064")]
    [IsoId("_13ueUDL3EeKU9IrkkToqcw_-2060196717")]
    [Description(@"Tax category for foreign tax withheld at source dividends proceeds.")]
    ForeignTaxWithheldAtSourceDividends = NRATaxCode.ForeignTaxWithheldAtSourceDividends, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for foreign tax withheld at source interest proceeds.
    /// Encoded/decoded by serializers as &quot;T065&quot;.
    /// </summary>
    [EnumMember(Value = "T065")]
    [IsoId("_13ueUTL3EeKU9IrkkToqcw_756523039")]
    [Description(@"Tax category for foreign tax withheld at source interest proceeds.")]
    ForeignTaxWithheldAtSourceInterest = NRATaxCode.ForeignTaxWithheldAtSourceInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for custody issues.
    /// Encoded/decoded by serializers as &quot;T070&quot;.
    /// </summary>
    [EnumMember(Value = "T070")]
    [IsoId("_14CAUDL3EeKU9IrkkToqcw_-2071295494")]
    [Description(@"Tax category for custody issues.")]
    CustodyIssues = NRATaxCode.CustodyIssues, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for interest on balances proceeds.
    /// Encoded/decoded by serializers as &quot;T071&quot;.
    /// </summary>
    [EnumMember(Value = "T071")]
    [IsoId("_14LKQDL3EeKU9IrkkToqcw_1807656111")]
    [Description(@"Tax category for interest on balances proceeds.")]
    InterestOnBalances = NRATaxCode.InterestOnBalances, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for interest on series E or H bonds proceeds.
    /// Encoded/decoded by serializers as &quot;T072&quot;.
    /// </summary>
    [EnumMember(Value = "T072")]
    [IsoId("_14LKQTL3EeKU9IrkkToqcw_-1020162422")]
    [Description(@"Tax category for interest on series E or H bonds proceeds.")]
    InterestOnSeriesEOrHBonds = NRATaxCode.InterestOnSeriesEOrHBonds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for royalty payments proceeds.
    /// Encoded/decoded by serializers as &quot;T073&quot;.
    /// </summary>
    [EnumMember(Value = "T073")]
    [IsoId("_14LKQjL3EeKU9IrkkToqcw_-36212878")]
    [Description(@"Tax category for royalty payments proceeds.")]
    RoyaltyPayments = NRATaxCode.RoyaltyPayments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for other taxable income proceeds.
    /// Encoded/decoded by serializers as &quot;T074&quot;.
    /// </summary>
    [EnumMember(Value = "T074")]
    [IsoId("_14LKQzL3EeKU9IrkkToqcw_1430935885")]
    [Description(@"Tax category for other taxable income proceeds.")]
    OtherTaxableIncome = NRATaxCode.OtherTaxableIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for other non-taxable income proceeds.
    /// Encoded/decoded by serializers as &quot;T075&quot;.
    /// </summary>
    [EnumMember(Value = "T075")]
    [IsoId("_14LKRDL3EeKU9IrkkToqcw_417874391")]
    [Description(@"Tax category for other non-taxable income proceeds.")]
    OtherNonTaxableIncome = NRATaxCode.OtherNonTaxableIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for miscellaneous payments proceeds.
    /// Encoded/decoded by serializers as &quot;T076&quot;.
    /// </summary>
    [EnumMember(Value = "T076")]
    [IsoId("_14U7QDL3EeKU9IrkkToqcw_1885023154")]
    [Description(@"Tax category for miscellaneous payments proceeds.")]
    MiscellaneousPayments = NRATaxCode.MiscellaneousPayments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for Cash-in-Lieu of fractional shares proceeds.
    /// Encoded/decoded by serializers as &quot;T024&quot;.
    /// </summary>
    [EnumMember(Value = "T024")]
    [IsoId("_14U7QTL3EeKU9IrkkToqcw_742991898")]
    [Description(@"Tax category for Cash-in-Lieu of fractional shares proceeds.")]
    CashInLieuOfFractionalShares = NRATaxCode.CashInLieuOfFractionalShares, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for stock split proceeds.
    /// Encoded/decoded by serializers as &quot;T077&quot;.
    /// </summary>
    [EnumMember(Value = "T077")]
    [IsoId("_14U7QjL3EeKU9IrkkToqcw_-2084826635")]
    [Description(@"Tax category for stock split proceeds.")]
    StockSplit = NRATaxCode.StockSplit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for stock dividend proceeds.
    /// Encoded/decoded by serializers as &quot;T078&quot;.
    /// </summary>
    [EnumMember(Value = "T078")]
    [IsoId("_14U7QzL3EeKU9IrkkToqcw_-631933114")]
    [Description(@"Tax category for stock dividend proceeds.")]
    StockDividend = NRATaxCode.StockDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for cash on increased shares proceeds.
    /// Encoded/decoded by serializers as &quot;T079&quot;.
    /// </summary>
    [EnumMember(Value = "T079")]
    [IsoId("_14U7RDL3EeKU9IrkkToqcw_835215649")]
    [Description(@"Tax category for cash on increased shares proceeds.")]
    CashOnIncreasedShares = NRATaxCode.CashOnIncreasedShares, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax category for spin off proceeds.
    /// Encoded/decoded by serializers as &quot;T080&quot;.
    /// </summary>
    [EnumMember(Value = "T080")]
    [IsoId("_14eFMDL3EeKU9IrkkToqcw_-1266964960")]
    [Description(@"Tax category for spin off proceeds.")]
    SpinOff = NRATaxCode.SpinOff, // same ordinal as derivation source for type conversions
}
