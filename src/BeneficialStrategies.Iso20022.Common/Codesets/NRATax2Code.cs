// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Non resident alien U.S. tax codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DwDwj6bHEeSDHtMWsSZVOg")]
[Description(@"Non resident alien U.S. tax codes.")]
[DerivedFrom(typeof(NRATaxCode))]
public enum NRATax2Code
{
    /// <summary>
    /// Tax category for domestic source income dividends.
    /// Encoded/decoded by serializers as &quot;T011&quot;.
    /// </summary>
    [EnumMember(Value = "T011")]
    [IsoId("_DwDwn6bHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for domestic source income dividends.")]
    DomesticIncomeDividend = NRATaxCode.DomesticIncomeDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for foreign source income dividends.
    /// Encoded/decoded by serializers as &quot;T012&quot;.
    /// </summary>
    [EnumMember(Value = "T012")]
    [IsoId("_DwDwpabHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for foreign source income dividends.")]
    ForeignIncomeDividends = NRATaxCode.ForeignIncomeDividends, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for non taxable domestic dividends.
    /// Encoded/decoded by serializers as &quot;T013&quot;.
    /// </summary>
    [EnumMember(Value = "T013")]
    [IsoId("_DwDwkabHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for non taxable domestic dividends.")]
    DividendsDomesticNonTaxable = NRATaxCode.DividendsDomesticNonTaxable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for fully exempt dividends on municipal type mutual funds.
    /// Encoded/decoded by serializers as &quot;T014&quot;.
    /// </summary>
    [EnumMember(Value = "T014")]
    [IsoId("_DwDwsqbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for fully exempt dividends on municipal type mutual funds.")]
    DividendsFullyExempt = NRATaxCode.DividendsFullyExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for federal taxable state exempt dividends.
    /// Encoded/decoded by serializers as &quot;T015&quot;.
    /// </summary>
    [EnumMember(Value = "T015")]
    [IsoId("_DwDwvabHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for federal taxable state exempt dividends.")]
    DividendsFederalTaxableStateExempt = NRATaxCode.DividendsFederalTaxableStateExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for Return Of Capital proceeds.
    /// Encoded/decoded by serializers as &quot;T019&quot;.
    /// </summary>
    [EnumMember(Value = "T019")]
    [IsoId("_DwDwu6bHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for Return Of Capital proceeds.")]
    ReturnOfCapital = NRATaxCode.ReturnOfCapital, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for Long Term Capital Gains proceeds.
    /// Encoded/decoded by serializers as &quot;T021&quot;.
    /// </summary>
    [EnumMember(Value = "T021")]
    [IsoId("_DwDwvKbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for Long Term Capital Gains proceeds.")]
    LongTermCapitalGains = NRATaxCode.LongTermCapitalGains, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for Short Term Capital Gains proceeds.
    /// Encoded/decoded by serializers as &quot;T022&quot;.
    /// </summary>
    [EnumMember(Value = "T022")]
    [IsoId("_DwDwsabHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for Short Term Capital Gains proceeds.")]
    ShortTermCapitalGains = NRATaxCode.ShortTermCapitalGains, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for FIRPTA eligible (REITS).
    /// Encoded/decoded by serializers as &quot;T023&quot;.
    /// </summary>
    [EnumMember(Value = "T023")]
    [IsoId("_DwDwr6bHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for FIRPTA eligible (REITS).")]
    FIRPTAEligible = NRATaxCode.FIRPTAEligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for REIT (Capital Gain Distributions).
    /// Encoded/decoded by serializers as &quot;T025&quot;.
    /// </summary>
    [EnumMember(Value = "T025")]
    [IsoId("_DwDwk6bHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for REIT (Capital Gain Distributions).")]
    REITCapitalGainDistributions = NRATaxCode.REITCapitalGainDistributions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for limited publicly traded partnership.
    /// Encoded/decoded by serializers as &quot;T026&quot;.
    /// </summary>
    [EnumMember(Value = "T026")]
    [IsoId("_DwDwkKbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for limited publicly traded partnership.")]
    LimitedPubliclyTradedPartnership = NRATaxCode.LimitedPubliclyTradedPartnership, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for substitute dividend payments.
    /// Encoded/decoded by serializers as &quot;T027&quot;.
    /// </summary>
    [EnumMember(Value = "T027")]
    [IsoId("_DwDwt6bHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for substitute dividend payments.")]
    SubstituteDividendPayment = NRATaxCode.SubstituteDividendPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for short term capital gain distributions.
    /// Encoded/decoded by serializers as &quot;T029&quot;.
    /// </summary>
    [EnumMember(Value = "T029")]
    [IsoId("_DwDwlqbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for short term capital gain distributions.")]
    CapitalGainDistributionShortTermRICs = NRATaxCode.CapitalGainDistributionShortTermRICs, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for dividend or capital gains distribution due to a corporate action.
    /// Encoded/decoded by serializers as &quot;T302&quot;.
    /// </summary>
    [EnumMember(Value = "T302")]
    [IsoId("_DwDwnKbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for dividend or capital gains distribution due to a corporate action.")]
    CorporateActionDividendCapitalGains = NRATaxCode.CorporateActionDividendCapitalGains, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for U.S. source ordinary interest proceeds.
    /// Encoded/decoded by serializers as &quot;T041&quot;.
    /// </summary>
    [EnumMember(Value = "T041")]
    [IsoId("_DwDwuKbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for U.S. source ordinary interest proceeds.")]
    USSourceOrdinaryInterest = NRATaxCode.USSourceOrdinaryInterest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for foreign bond interest proceeds.
    /// Encoded/decoded by serializers as &quot;T042&quot;.
    /// </summary>
    [EnumMember(Value = "T042")]
    [IsoId("_DwDwrKbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for foreign bond interest proceeds.")]
    ForeignBondInterest = NRATaxCode.ForeignBondInterest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for all state and territorial municipal interest proceeds.
    /// Encoded/decoded by serializers as &quot;T043&quot;.
    /// </summary>
    [EnumMember(Value = "T043")]
    [IsoId("_DwDwmKbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for all state and territorial municipal interest proceeds.")]
    AllStateAndTerritorialMunicipalInterest = NRATaxCode.AllStateAndTerritorialMunicipalInterest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for all municipal bonds that are subject to federal tax proceeds.
    /// Encoded/decoded by serializers as &quot;T044&quot;.
    /// </summary>
    [EnumMember(Value = "T044")]
    [IsoId("_DwDwrqbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for all municipal bonds that are subject to federal tax proceeds.")]
    AllMunicipalBondsSubjectToFederalTax = NRATaxCode.AllMunicipalBondsSubjectToFederalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for U.S. government interest on contracts Notes &amp; mortgages proceeds.
    /// Encoded/decoded by serializers as &quot;T045&quot;.
    /// </summary>
    [EnumMember(Value = "T045")]
    [IsoId("_DwDwqabHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for U.S. government interest on contracts Notes & mortgages proceeds.")]
    USGovernmentInterestOnContractsNotesAndMortgages = NRATaxCode.USGovernmentInterestOnContractsNotesAndMortgages, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for U.S. government interest on GNMA 1 &amp; 2 proceeds.
    /// Encoded/decoded by serializers as &quot;T046&quot;.
    /// </summary>
    [EnumMember(Value = "T046")]
    [IsoId("_DwDwq6bHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for U.S. government interest on GNMA 1 & 2 proceeds.")]
    USGovernmentInterestOnGNMA1And2 = NRATaxCode.USGovernmentInterestOnGNMA1And2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for interest on collateralized mortgage obligations proceeds.
    /// Encoded/decoded by serializers as &quot;T047&quot;.
    /// </summary>
    [EnumMember(Value = "T047")]
    [IsoId("_DwDwmqbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for interest on collateralized mortgage obligations proceeds.")]
    InterestOnCollatralizedMortgageObligations = NRATaxCode.InterestOnCollatralizedMortgageObligations, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for interests on certificates of deposits proceeds.
    /// Encoded/decoded by serializers as &quot;T048&quot;.
    /// </summary>
    [EnumMember(Value = "T048")]
    [IsoId("_DwDwuabHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for interests on certificates of deposits proceeds.")]
    InterestOnCertificatesOfDeposit = NRATaxCode.InterestOnCertificatesOfDeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for U.S. government interest proceeds.
    /// Encoded/decoded by serializers as &quot;T049&quot;.
    /// </summary>
    [EnumMember(Value = "T049")]
    [IsoId("_DwDwuqbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for U.S. government interest proceeds.")]
    USGovernmentInterest = NRATaxCode.USGovernmentInterest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax Category for US government interest on Notes and Bills.
    /// Encoded/decoded by serializers as &quot;T050&quot;.
    /// </summary>
    [EnumMember(Value = "T050")]
    [IsoId("_DwDwtqbHEeSDHtMWsSZVOg")]
    [Description(@"Tax Category for US government interest on Notes and Bills.")]
    USGovernmentInterestOnNotesAndBills = NRATaxCode.USGovernmentInterestOnNotesAndBills, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for principal pay downs proceeds.
    /// Encoded/decoded by serializers as &quot;T051&quot;.
    /// </summary>
    [EnumMember(Value = "T051")]
    [IsoId("_DwDwnabHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for principal pay downs proceeds.")]
    PrincipalPaydowns = NRATaxCode.PrincipalPaydowns, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for interest substitute payment.
    /// Encoded/decoded by serializers as &quot;T054&quot;.
    /// </summary>
    [EnumMember(Value = "T054")]
    [IsoId("_DwDwpqbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for interest substitute payment.")]
    InterestSubstitutePayment = NRATaxCode.InterestSubstitutePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for royalty payments proceeds.
    /// Encoded/decoded by serializers as &quot;T073&quot;.
    /// </summary>
    [EnumMember(Value = "T073")]
    [IsoId("_DwDws6bHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for royalty payments proceeds.")]
    RoyaltyPayments = NRATaxCode.RoyaltyPayments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for other taxable income proceeds.
    /// Encoded/decoded by serializers as &quot;T074&quot;.
    /// </summary>
    [EnumMember(Value = "T074")]
    [IsoId("_DwDwoqbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for other taxable income proceeds.")]
    OtherTaxableIncome = NRATaxCode.OtherTaxableIncome, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for other non-taxable income proceeds.
    /// Encoded/decoded by serializers as &quot;T075&quot;.
    /// </summary>
    [EnumMember(Value = "T075")]
    [IsoId("_DwDwsKbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for other non-taxable income proceeds.")]
    OtherNonTaxableIncome = NRATaxCode.OtherNonTaxableIncome, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for miscellaneous payments proceeds.
    /// Encoded/decoded by serializers as &quot;T076&quot;.
    /// </summary>
    [EnumMember(Value = "T076")]
    [IsoId("_DwDwkqbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for miscellaneous payments proceeds.")]
    MiscellaneousPayments = NRATaxCode.MiscellaneousPayments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for stock split proceeds.
    /// Encoded/decoded by serializers as &quot;T077&quot;.
    /// </summary>
    [EnumMember(Value = "T077")]
    [IsoId("_DwDwm6bHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for stock split proceeds.")]
    StockSplit = NRATaxCode.StockSplit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for stock dividend proceeds.
    /// Encoded/decoded by serializers as &quot;T078&quot;.
    /// </summary>
    [EnumMember(Value = "T078")]
    [IsoId("_DwDwqqbHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for stock dividend proceeds.")]
    StockDividend = NRATaxCode.StockDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax category for spin off proceeds.
    /// Encoded/decoded by serializers as &quot;T080&quot;.
    /// </summary>
    [EnumMember(Value = "T080")]
    [IsoId("_DwDwl6bHEeSDHtMWsSZVOg")]
    [Description(@"Tax category for spin off proceeds.")]
    SpinOff = NRATaxCode.SpinOff, // same ordinal as derivation source for type conversions
    
}
