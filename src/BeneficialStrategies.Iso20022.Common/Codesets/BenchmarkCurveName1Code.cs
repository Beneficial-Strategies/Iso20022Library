// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies a benchmark curve name.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zd5TVQ93EeGeV5vP7Mvdig_1742179205")]
[Description(@"Identifies a benchmark curve name.")]
[DerivedFrom(typeof(BenchmarkCurveNameCode))]
public enum BenchmarkCurveName1Code
{
    /// <summary>
    /// Benchmark curve used for municipals based on the best credit rating for municipal market debt.
    /// Encoded/decoded by serializers as &quot;MAAA&quot;.
    /// </summary>
    [EnumMember(Value = "MAAA")]
    [IsoId("_zeDEUA93EeGeV5vP7Mvdig_-730272138")]
    [Description(@"Benchmark curve used for municipals based on the best credit rating for municipal market debt.")]
    MuniAAA = BenchmarkCurveNameCode.MuniAAA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Portion of a synthetic curve that is composed of Eurodollar or Treasury or similar Futures and Swap rates. The term usually begins at 3 months to 2 years for the futures strip component with the Swaps filling in the points to 10 years and beyond.
    /// Encoded/decoded by serializers as &quot;FUSW&quot;.
    /// </summary>
    [EnumMember(Value = "FUSW")]
    [IsoId("_zeDEUQ93EeGeV5vP7Mvdig_1565837077")]
    [Description(@"Portion of a synthetic curve that is composed of Eurodollar or Treasury or similar Futures and Swap rates. The term usually begins at 3 months to 2 years for the futures strip component with the Swaps filling in the points to 10 years and beyond.")]
    FutureSWAP = BenchmarkCurveNameCode.FutureSWAP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate at which major international banks are willing to take deposits from one another, is normally 1/8 percent below LIBOR.
    /// London InterBank Bid Rate, the rate bid by banks on Eurocurrency deposits; the international rate that banks lend to other banks.
    /// Encoded/decoded by serializers as &quot;LIBI&quot;.
    /// </summary>
    [EnumMember(Value = "LIBI")]
    [IsoId("_zeDEUg93EeGeV5vP7Mvdig_2008825569")]
    [Description(@"Rate at which major international banks are willing to take deposits from one another, is normally 1/8 percent below LIBOR.||London InterBank Bid Rate, the rate bid by banks on Eurocurrency deposits; the international rate that banks lend to other banks.")]
    LIBID = BenchmarkCurveNameCode.LIBID, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// London Interbank Offered Rate, the interest rate that major international banks in London charge each other for borrowing.
    /// Encoded/decoded by serializers as &quot;LIBO&quot;.
    /// </summary>
    [EnumMember(Value = "LIBO")]
    [IsoId("_zeDEUw93EeGeV5vP7Mvdig_-2118728291")]
    [Description(@"London Interbank Offered Rate, the interest rate that major international banks in London charge each other for borrowing.")]
    LIBOR = BenchmarkCurveNameCode.LIBOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In curve construction, Swap is the long portion of the curve constituting about 3 years to 30 years term.||The exchange of one security, currency or interest rate for another to change the maturity (bonds), or quality of issues (stocks or bonds), or because investment objectives have changed.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_zeDEVA93EeGeV5vP7Mvdig_1541207159")]
    [Description(@"In curve construction, Swap is the long portion of the curve constituting about 3 years to 30 years term.||The exchange of one security, currency or interest rate for another to change the maturity (bonds), or quality of issues (stocks or bonds), or because investment objectives have changed.")]
    SWAP = BenchmarkCurveNameCode.SWAP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Treasury benchmark that comes in three types: the yield curve, the par curve, and the spot curve. All curves also have a constituent time series.
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_zeDEVQ93EeGeV5vP7Mvdig_-1675739799")]
    [Description(@"Treasury benchmark that comes in three types: the yield curve, the par curve, and the spot curve. All curves also have a constituent time series.")]
    Treasury = BenchmarkCurveNameCode.Treasury, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Euro Interbank Offer Rate is the rate at which Euro inter-bank term deposits within the Euro zone are offered by one prime bank to another prime bank.
    /// Encoded/decoded by serializers as &quot;EURI&quot;.
    /// </summary>
    [EnumMember(Value = "EURI")]
    [IsoId("_zeDEVg93EeGeV5vP7Mvdig_155183370")]
    [Description(@"Euro Interbank Offer Rate is the rate at which Euro inter-bank term deposits within the Euro zone are offered by one prime bank to another prime bank.")]
    Euribor = BenchmarkCurveNameCode.Euribor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pfandbriefe security is a collateralised bullet bond backed by either mortgage loans or loans to the public sector. Pfandbriefe differ from traditional asset-backed securities in significant ways. The most important difference is that Pfandbriefe carry no pre-payment risk since they remain on the balance sheet of the issuing institution. Therefore, their spreads over sovereign bonds are attributable to liquidity and credit quality alone. New indices have been created and existing indices have been modified in response to the growing importance of the Pfandbriefe market. The Deutsche Borse has three synthetic indices called REX, JEX, and PEX. The Pfandbriefe curve is used as a reference for credit as well as mortgage market.
    /// Encoded/decoded by serializers as &quot;PFAN&quot;.
    /// </summary>
    [EnumMember(Value = "PFAN")]
    [IsoId("_zeMOQA93EeGeV5vP7Mvdig_609270639")]
    [Description(@"Pfandbriefe security is a collateralised bullet bond backed by either mortgage loans or loans to the public sector. Pfandbriefe differ from traditional asset-backed securities in significant ways. The most important difference is that Pfandbriefe carry no pre-payment risk since they remain on the balance sheet of the issuing institution. Therefore, their spreads over sovereign bonds are attributable to liquidity and credit quality alone. New indices have been created and existing indices have been modified in response to the growing importance of the Pfandbriefe market. The Deutsche Borse has three synthetic indices called REX, JEX, and PEX. The Pfandbriefe curve is used as a reference for credit as well as mortgage market.")]
    Pfandbriefe = BenchmarkCurveNameCode.Pfandbriefe, // same ordinal as derivation source for type conversions
    
}
