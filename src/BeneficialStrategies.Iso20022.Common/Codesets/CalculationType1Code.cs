// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the yield computation method.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bVa-Jtp-Ed-ak6NoX_4Aeg_-2002254762")]
[Description(@"Specifies the yield computation method.")]
[DerivedFrom(typeof(CalculationTypeCode))]
public enum CalculationType1Code
{
    /// <summary>
    /// The yield on the bond net of any tax consequences from holding the bond. The discount on municipal securities can be subject to both capital gains taxes and ordinary income taxes. Calculated from dollar price.
    /// Encoded/decoded by serializers as &quot;AFTX&quot;.
    /// </summary>
    [EnumMember(Value = "AFTX")]
    [IsoId("_bVa-J9p-Ed-ak6NoX_4Aeg_-1490623835")]
    [Description(@"The yield on the bond net of any tax consequences from holding the bond. The discount on municipal securities can be subject to both capital gains taxes and ordinary income taxes. Calculated from dollar price.")]
    AfterTax = CalculationTypeCode.AfterTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The annual interest or dividend income an investment earns, expressed as a percentage of the investment&apos;s total value.
    /// Encoded/decoded by serializers as &quot;ANNU&quot;.
    /// </summary>
    [EnumMember(Value = "ANNU")]
    [IsoId("_bVa-KNp-Ed-ak6NoX_4Aeg_-1490623583")]
    [Description(@"The annual interest or dividend income an investment earns, expressed as a percentage of the investment's total value.")]
    Annual = CalculationTypeCode.Annual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The yield of the bond offered on the issue date.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_bVkvINp-Ed-ak6NoX_4Aeg_-1490623540")]
    [Description(@"The yield of the bond offered on the issue date.")]
    AtIssue = CalculationTypeCode.AtIssue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The yield achieved by substituting a bond&apos;s average maturity for the issue&apos;s final maturity date.
    /// Encoded/decoded by serializers as &quot;AVMA&quot;.
    /// </summary>
    [EnumMember(Value = "AVMA")]
    [IsoId("_bVkvIdp-Ed-ak6NoX_4Aeg_-1490623523")]
    [Description(@"The yield achieved by substituting a bond's average maturity for the issue's final maturity date.")]
    ToAverageMaturity = CalculationTypeCode.ToAverageMaturity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The yield of a security calculated by using its book value instead of the current market price. This term is typically used in the US domestic market.
    /// Encoded/decoded by serializers as &quot;BOOK&quot;.
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_bVkvItp-Ed-ak6NoX_4Aeg_-1490623480")]
    [Description(@"The yield of a security calculated by using its book value instead of the current market price. This term is typically used in the US domestic market.")]
    Book = CalculationTypeCode.Book, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Yield of a bond to the next possible call date.
    /// Encoded/decoded by serializers as &quot;YTNC&quot;.
    /// </summary>
    [EnumMember(Value = "YTNC")]
    [IsoId("_bVkvI9p-Ed-ak6NoX_4Aeg_-1490623445")]
    [Description(@"Yield of a bond to the next possible call date.")]
    YieldToNextCall = CalculationTypeCode.YieldToNextCall, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The change in the yield since the previous day&apos;s closing yield.
    /// Encoded/decoded by serializers as &quot;CHCL&quot;.
    /// </summary>
    [EnumMember(Value = "CHCL")]
    [IsoId("_bVkvJNp-Ed-ak6NoX_4Aeg_-1490623162")]
    [Description(@"The change in the yield since the previous day's closing yield.")]
    ChangeSinceClose = CalculationTypeCode.ChangeSinceClose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The yield of a bond based on the closing price.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_bVkvJdp-Ed-ak6NoX_4Aeg_-1490623120")]
    [Description(@"The yield of a bond based on the closing price.")]
    Closing = CalculationTypeCode.Closing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The yield of certain Japanese bonds based on its price. Certain Japanese bonds have irregular first or last coupons, and the yield is calculated compound for these irregular periods.
    /// Encoded/decoded by serializers as &quot;CMPD&quot;.
    /// </summary>
    [EnumMember(Value = "CMPD")]
    [IsoId("_bVkvJtp-Ed-ak6NoX_4Aeg_-1490623059")]
    [Description(@"The yield of certain Japanese bonds based on its price. Certain Japanese bonds have irregular first or last coupons, and the yield is calculated compound for these irregular periods.")]
    Compound = CalculationTypeCode.Compound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The ratio of the interest payment amount to the clean price.
    /// Encoded/decoded by serializers as &quot;CUYI&quot;.
    /// </summary>
    [EnumMember(Value = "CUYI")]
    [IsoId("_bVkvJ9p-Ed-ak6NoX_4Aeg_-1490623041")]
    [Description(@"The ratio of the interest payment amount to the clean price.")]
    CurrentYield = CalculationTypeCode.CurrentYield, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Yield calculated using the price including accrued interest, where coupon dates are moved from holidays and weekends to the next trading day.
    /// Encoded/decoded by serializers as &quot;TRGR&quot;.
    /// </summary>
    [EnumMember(Value = "TRGR")]
    [IsoId("_bVkvKNp-Ed-ak6NoX_4Aeg_-1490623016")]
    [Description(@"Yield calculated using the price including accrued interest, where coupon dates are moved from holidays and weekends to the next trading day.")]
    TrueGross = CalculationTypeCode.TrueGross, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ask yield based on semi-annual coupons compounding in all periods and actual/actual calendar.
    /// Encoded/decoded by serializers as &quot;GVEQ&quot;.
    /// </summary>
    [EnumMember(Value = "GVEQ")]
    [IsoId("_bVkvKdp-Ed-ak6NoX_4Aeg_-1490622999")]
    [Description(@"Ask yield based on semi-annual coupons compounding in all periods and actual/actual calendar.")]
    GovernmentEquivalent = CalculationTypeCode.GovernmentEquivalent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Based on price, the return an investor would require on a normal bond that would make the real return equal to that of the inflation-indexed bond, assuming a constant inflation rate.
    /// Encoded/decoded by serializers as &quot;FLAS&quot;.
    /// </summary>
    [EnumMember(Value = "FLAS")]
    [IsoId("_bVt5ENp-Ed-ak6NoX_4Aeg_-1490622981")]
    [Description(@"Based on price, the return an investor would require on a normal bond that would make the real return equal to that of the inflation-indexed bond, assuming a constant inflation rate.")]
    InflationAssumption = CalculationTypeCode.InflationAssumption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Inverse Floater Bond Yield - Inverse floater semi-annual bond equivalent rate.
    /// Encoded/decoded by serializers as &quot;NVFL&quot;.
    /// </summary>
    [EnumMember(Value = "NVFL")]
    [IsoId("_bVt5Edp-Ed-ak6NoX_4Aeg_-1490622964")]
    [Description(@"Inverse Floater Bond Yield - Inverse floater semi-annual bond equivalent rate.")]
    InverseFloater = CalculationTypeCode.InverseFloater, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Most Recent Closing Yield - The last available yield stored in history, computed using price.
    /// Encoded/decoded by serializers as &quot;LSCL&quot;.
    /// </summary>
    [EnumMember(Value = "LSCL")]
    [IsoId("_bVt5Etp-Ed-ak6NoX_4Aeg_-1490622946")]
    [Description(@"Most Recent Closing Yield - The last available yield stored in history, computed using price.")]
    LastClose = CalculationTypeCode.LastClose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Closing Yield Most Recent Month - The yield of a bond based on the closing price as of the most recent month&apos;s end.
    /// Encoded/decoded by serializers as &quot;LSMT&quot;.
    /// </summary>
    [EnumMember(Value = "LSMT")]
    [IsoId("_bVt5E9p-Ed-ak6NoX_4Aeg_-1490622921")]
    [Description(@"Closing Yield Most Recent Month - The yield of a bond based on the closing price as of the most recent month's end.")]
    LastMonth = CalculationTypeCode.LastMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Closing Yield Most Recent Quarter - The yield of a bond based on the closing price as of the most recent quarter&apos;s end.
    /// Encoded/decoded by serializers as &quot;LSQR&quot;.
    /// </summary>
    [EnumMember(Value = "LSQR")]
    [IsoId("_bVt5FNp-Ed-ak6NoX_4Aeg_-1490622904")]
    [Description(@"Closing Yield Most Recent Quarter - The yield of a bond based on the closing price as of the most recent quarter's end.")]
    LastQuarter = CalculationTypeCode.LastQuarter, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Closing Yield Most Recent Year - The yield of a bond based on the closing price as of the most recent year&apos;s end.
    /// Encoded/decoded by serializers as &quot;LSYR&quot;.
    /// </summary>
    [EnumMember(Value = "LSYR")]
    [IsoId("_bVt5Fdp-Ed-ak6NoX_4Aeg_-1490622644")]
    [Description(@"Closing Yield Most Recent Year - The yield of a bond based on the closing price as of the most recent year's end.")]
    LastYear = CalculationTypeCode.LastYear, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The yield assuming only mandatory sinks are taken. This results in a lower paydown of debt; the yield is then calculated to the final payment date.
    /// Encoded/decoded by serializers as &quot;LGAL&quot;.
    /// </summary>
    [EnumMember(Value = "LGAL")]
    [IsoId("_bVt5Ftp-Ed-ak6NoX_4Aeg_-1490622627")]
    [Description(@"The yield assuming only mandatory sinks are taken. This results in a lower paydown of debt; the yield is then calculated to the final payment date.")]
    LongestAverageLife = CalculationTypeCode.LongestAverageLife, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An adjustment in the valuation of a securities portfolio to reflect the current market values of the respective securities in the portfolio.
    /// Encoded/decoded by serializers as &quot;MARK&quot;.
    /// </summary>
    [EnumMember(Value = "MARK")]
    [IsoId("_bVt5F9p-Ed-ak6NoX_4Aeg_-1490622609")]
    [Description(@"An adjustment in the valuation of a securities portfolio to reflect the current market values of the respective securities in the portfolio.")]
    MarkToMarket = CalculationTypeCode.MarkToMarket, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Internal rate of return an investor would achieve if he or she purchased that bond at its current dirty price, and held it to maturity, assuming all coupon and principal payments are received as scheduled.
    /// Encoded/decoded by serializers as &quot;YTMA&quot;.
    /// </summary>
    [EnumMember(Value = "YTMA")]
    [IsoId("_bVt5GNp-Ed-ak6NoX_4Aeg_-1490622592")]
    [Description(@"Internal rate of return an investor would achieve if he or she purchased that bond at its current dirty price, and held it to maturity, assuming all coupon and principal payments are received as scheduled.")]
    YieldToMaturity = CalculationTypeCode.YieldToMaturity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Yield To Next Refund (Sinking Fund Bonds) - Yield assuming all bonds are redeemed at the next refund date at the redemption price.
    /// Encoded/decoded by serializers as &quot;NXRF&quot;.
    /// </summary>
    [EnumMember(Value = "NXRF")]
    [IsoId("_bVt5Gdp-Ed-ak6NoX_4Aeg_-1490622574")]
    [Description(@"Yield To Next Refund (Sinking Fund Bonds) - Yield assuming all bonds are redeemed at the next refund date at the redemption price.")]
    ToNextRefund = CalculationTypeCode.ToNextRefund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The average yield of the respective securities in the portfolio.
    /// Encoded/decoded by serializers as &quot;PNAV&quot;.
    /// </summary>
    [EnumMember(Value = "PNAV")]
    [IsoId("_bVt5Gtp-Ed-ak6NoX_4Aeg_-1490622532")]
    [Description(@"The average yield of the respective securities in the portfolio.")]
    OpenAverage = CalculationTypeCode.OpenAverage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The yield to the date at which the bond holder can next put the bond to the issuer.
    /// Encoded/decoded by serializers as &quot;NXPT&quot;.
    /// </summary>
    [EnumMember(Value = "NXPT")]
    [IsoId("_bV3qENp-Ed-ak6NoX_4Aeg_-1490622514")]
    [Description(@"The yield to the date at which the bond holder can next put the bond to the issuer.")]
    ToNextPut = CalculationTypeCode.ToNextPut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The yield of a bond based on the closing price 1 day ago.
    /// Encoded/decoded by serializers as &quot;PRCL&quot;.
    /// </summary>
    [EnumMember(Value = "PRCL")]
    [IsoId("_bV3qEdp-Ed-ak6NoX_4Aeg_-1490622472")]
    [Description(@"The yield of a bond based on the closing price 1 day ago.")]
    PreviousClose = CalculationTypeCode.PreviousClose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The CD equivalent yield when the remaining time to maturity is less than two years.
    /// Encoded/decoded by serializers as &quot;PRYL&quot;.
    /// </summary>
    [EnumMember(Value = "PRYL")]
    [IsoId("_bV3qEtp-Ed-ak6NoX_4Aeg_-1490622206")]
    [Description(@"The CD equivalent yield when the remaining time to maturity is less than two years.")]
    Proceeds = CalculationTypeCode.Proceeds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The yield of a bond whose coupon payments are reinvested semi-annually.
    /// Encoded/decoded by serializers as &quot;SEMI&quot;.
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_bV3qE9p-Ed-ak6NoX_4Aeg_-1490622171")]
    [Description(@"The yield of a bond whose coupon payments are reinvested semi-annually.")]
    SemiAnnual = CalculationTypeCode.SemiAnnual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The yield assuming that all sinks (mandatory and voluntary) are taken at par. This results in a faster paydown of debt; the yield is then calculated to the shortest average life date.
    /// Encoded/decoded by serializers as &quot;SHLF&quot;.
    /// </summary>
    [EnumMember(Value = "SHLF")]
    [IsoId("_bV3qFNp-Ed-ak6NoX_4Aeg_-1490622146")]
    [Description(@"The yield assuming that all sinks (mandatory and voluntary) are taken at par. This results in a faster paydown of debt; the yield is then calculated to the shortest average life date.")]
    ShortestAverageLife = CalculationTypeCode.ShortestAverageLife, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The yield of a bond assuming no reinvestment of coupon payments. (Act/360 day count).
    /// Encoded/decoded by serializers as &quot;SPLL&quot;.
    /// </summary>
    [EnumMember(Value = "SPLL")]
    [IsoId("_bV3qFdp-Ed-ak6NoX_4Aeg_-1490622111")]
    [Description(@"The yield of a bond assuming no reinvestment of coupon payments. (Act/360 day count).")]
    Simple = CalculationTypeCode.Simple, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The after tax yield grossed up by the maximum federal tax rate of 39.6%. For comparison to taxable yields.
    /// Encoded/decoded by serializers as &quot;TXQV&quot;.
    /// </summary>
    [EnumMember(Value = "TXQV")]
    [IsoId("_bV3qFtp-Ed-ak6NoX_4Aeg_-1490622086")]
    [Description(@"The after tax yield grossed up by the maximum federal tax rate of 39.6%. For comparison to taxable yields.")]
    TaxEquivalent = CalculationTypeCode.TaxEquivalent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The yield on a Municipal bond to its mandatory tender date.
    /// Encoded/decoded by serializers as &quot;TTDT&quot;.
    /// </summary>
    [EnumMember(Value = "TTDT")]
    [IsoId("_bV3qF9p-Ed-ak6NoX_4Aeg_-1490622051")]
    [Description(@"The yield on a Municipal bond to its mandatory tender date.")]
    ToTenderDate = CalculationTypeCode.ToTenderDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The yield calculated with coupon dates moved from a weekend or holiday to the next valid settlement date.
    /// Encoded/decoded by serializers as &quot;TRYL&quot;.
    /// </summary>
    [EnumMember(Value = "TRYL")]
    [IsoId("_bV3qGNp-Ed-ak6NoX_4Aeg_-1490622016")]
    [Description(@"The yield calculated with coupon dates moved from a weekend or holiday to the next valid settlement date.")]
    True = CalculationTypeCode.True, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The lowest yield to all possible redemption date scenarios.
    /// Encoded/decoded by serializers as &quot;WRST&quot;.
    /// </summary>
    [EnumMember(Value = "WRST")]
    [IsoId("_bV3qGdp-Ed-ak6NoX_4Aeg_-1490621991")]
    [Description(@"The lowest yield to all possible redemption date scenarios.")]
    ToWorstConvention = CalculationTypeCode.ToWorstConvention, // same ordinal as derivation source for type conversions
    
}
