// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a benchmark curve name.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vqQWWBIkEeyLzJfz3xPQNA")]
[Description(@"Specifies a benchmark curve name.")]
[DerivedFrom(typeof(BenchmarkCurveNameV2Code))]
public enum BenchmarkCurveName7Code
{
    /// <summary>
    /// Australian Financial Markets Association (AFMA) Bank-Bill Reference Rate (BBSW).
    /// Encoded/decoded by serializers as &quot;BBSW&quot;.
    /// </summary>
    [EnumMember(Value = "BBSW")]
    [IsoId("_vqQWZRIkEeyLzJfz3xPQNA")]
    [Description(
        @"Australian Financial Markets Association (AFMA) Bank-Bill Reference Rate (BBSW)."
    )]
    BBSW = BenchmarkCurveNameV2Code.BBSW, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Budapest Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;BUBO&quot;.
    /// </summary>
    [EnumMember(Value = "BUBO")]
    [IsoId("_vqQWZBIkEeyLzJfz3xPQNA")]
    [Description(@"Budapest Interbank Offered Rate.")]
    BUBOR = BenchmarkCurveNameV2Code.BUBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank of Canada Overnight Lending Rate (CABROVER).
    /// Encoded/decoded by serializers as &quot;BCOL&quot;.
    /// </summary>
    [EnumMember(Value = "BCOL")]
    [IsoId("_vqQWchIkEeyLzJfz3xPQNA")]
    [Description(@"Bank of Canada Overnight Lending Rate (CABROVER).")]
    CABROVER = BenchmarkCurveNameV2Code.CABROVER, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Canadian Dollar Offered Rate.
    /// Encoded/decoded by serializers as &quot;CDOR&quot;.
    /// </summary>
    [EnumMember(Value = "CDOR")]
    [IsoId("_vqQWdRIkEeyLzJfz3xPQNA")]
    [Description(@"Canadian Dollar Offered Rate.")]
    CDOR = BenchmarkCurveNameV2Code.CDOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Copenhagen Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;CIBO&quot;.
    /// </summary>
    [EnumMember(Value = "CIBO")]
    [IsoId("_vqQWbRIkEeyLzJfz3xPQNA")]
    [Description(@"Copenhagen Interbank Offered Rate.")]
    CIBOR = BenchmarkCurveNameV2Code.CIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Canadian Overnight Repo Rate Average (CAONREPO).
    /// Encoded/decoded by serializers as &quot;CORA&quot;.
    /// </summary>
    [EnumMember(Value = "CORA")]
    [IsoId("_vqQWfBIkEeyLzJfz3xPQNA")]
    [Description(@"Canadian Overnight Repo Rate Average (CAONREPO). ")]
    CORRA = BenchmarkCurveNameV2Code.CORRA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Czech National Bank Reference Interest Rate
    /// Encoded/decoded by serializers as &quot;CZNA&quot;.
    /// </summary>
    [EnumMember(Value = "CZNA")]
    [IsoId("_vqQWdhIkEeyLzJfz3xPQNA")]
    [Description(@"Czech National Bank Reference Interest Rate")]
    Czeonia = BenchmarkCurveNameV2Code.Czeonia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Euro OverNight Index Average rate.
    /// Encoded/decoded by serializers as &quot;EONA&quot;.
    /// </summary>
    [EnumMember(Value = "EONA")]
    [IsoId("_vqQWeBIkEeyLzJfz3xPQNA")]
    [Description(@"Euro OverNight Index Average rate.")]
    EONIA = BenchmarkCurveNameV2Code.EONIA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Euro OverNight Index Average swap rate.
    /// Encoded/decoded by serializers as &quot;EONS&quot;.
    /// </summary>
    [EnumMember(Value = "EONS")]
    [IsoId("_vqQWcxIkEeyLzJfz3xPQNA")]
    [Description(@"Euro OverNight Index Average swap rate.")]
    EONIASwaps = BenchmarkCurveNameV2Code.EONIASwaps, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Euro Short Term Rate
    /// Encoded/decoded by serializers as &quot;ESTR&quot;.
    /// </summary>
    [EnumMember(Value = "ESTR")]
    [IsoId("_vqQWcBIkEeyLzJfz3xPQNA")]
    [Description(@"Euro Short Term Rate")]
    ESTER = BenchmarkCurveNameV2Code.ESTER, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Euro Interbank Offer Rate is the rate at which Euro inter-bank term deposits within the Euro zone are offered by one prime bank to another prime bank.
    /// Encoded/decoded by serializers as &quot;EURI&quot;.
    /// </summary>
    [EnumMember(Value = "EURI")]
    [IsoId("_vqQWdxIkEeyLzJfz3xPQNA")]
    [Description(
        @"Euro Interbank Offer Rate is the rate at which Euro inter-bank term deposits within the Euro zone are offered by one prime bank to another prime bank."
    )]
    Euribor = BenchmarkCurveNameV2Code.Euribor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate for the eurodollars, time deposits denominated in U.S. dollars at banks outside the United States, and thus are not under the jurisdiction of the Federal Reserve.
    /// Encoded/decoded by serializers as &quot;EUUS&quot;.
    /// </summary>
    [EnumMember(Value = "EUUS")]
    [IsoId("_vqQWfRIkEeyLzJfz3xPQNA")]
    [Description(
        @"Rate for the eurodollars, time deposits denominated in U.S. dollars at banks outside the United States, and thus are not under the jurisdiction of the Federal Reserve."
    )]
    EURODOLLAR = BenchmarkCurveNameV2Code.EURODOLLAR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Swiss Franc LIBOR rate.
    /// Encoded/decoded by serializers as &quot;EUCH&quot;.
    /// </summary>
    [EnumMember(Value = "EUCH")]
    [IsoId("_vqQWfhIkEeyLzJfz3xPQNA")]
    [Description(@"Swiss Franc LIBOR rate.")]
    EuroSwiss = BenchmarkCurveNameV2Code.EuroSwiss, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Effective Federal Funds Rate (FEDL01).
    /// Encoded/decoded by serializers as &quot;EFFR&quot;.
    /// </summary>
    [EnumMember(Value = "EFFR")]
    [IsoId("_vqQWWxIkEeyLzJfz3xPQNA")]
    [Description(@"Effective Federal Funds Rate (FEDL01).")]
    FEDL01 = BenchmarkCurveNameV2Code.FEDL01, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Portion of a synthetic curve that is composed of Eurodollar or Treasury or similar Futures and Swap rates. The term usually begins at 3 months to 2 years for the futures strip component with the Swaps filling in the points to 10 years and beyond.
    /// Encoded/decoded by serializers as &quot;FUSW&quot;.
    /// </summary>
    [EnumMember(Value = "FUSW")]
    [IsoId("_vqQWaxIkEeyLzJfz3xPQNA")]
    [Description(
        @"Portion of a synthetic curve that is composed of Eurodollar or Treasury or similar Futures and Swap rates. The term usually begins at 3 months to 2 years for the futures strip component with the Swaps filling in the points to 10 years and beyond."
    )]
    FutureSWAP = BenchmarkCurveNameV2Code.FutureSWAP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GCF Repo Index, the Depository Trust &amp; Clearing Corporation (DTCC) general collateral finance repurchase agreements index.
    /// Encoded/decoded by serializers as &quot;GCFR&quot;.
    /// </summary>
    [EnumMember(Value = "GCFR")]
    [IsoId("_vqQWbhIkEeyLzJfz3xPQNA")]
    [Description(
        @"GCF Repo Index, the Depository Trust & Clearing Corporation (DTCC) general collateral finance repurchase agreements index."
    )]
    GCFRepo = BenchmarkCurveNameV2Code.GCFRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Hong Kong Interbank Offered Rate (HIHD01M).
    /// Encoded/decoded by serializers as &quot;HKIO&quot;.
    /// </summary>
    [EnumMember(Value = "HKIO")]
    [IsoId("_vqQWfxIkEeyLzJfz3xPQNA")]
    [Description(@"Hong Kong Interbank Offered Rate (HIHD01M).")]
    HIBOR = BenchmarkCurveNameV2Code.HIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Worldwide common reference rate value for fixed interest rate swap rates, as defined by the International Swaps and Derivatives Association (ISDA).
    /// Encoded/decoded by serializers as &quot;ISDA&quot;.
    /// </summary>
    [EnumMember(Value = "ISDA")]
    [IsoId("_vqQWahIkEeyLzJfz3xPQNA")]
    [Description(
        @"Worldwide common reference rate value for fixed interest rate swap rates, as defined by the International Swaps and Derivatives Association (ISDA)."
    )]
    ISDAFIX = BenchmarkCurveNameV2Code.ISDAFIX, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Euroyen Tokyo Interbank Offered Rate (EUYN03M).
    /// Encoded/decoded by serializers as &quot;ETIO&quot;.
    /// </summary>
    [EnumMember(Value = "ETIO")]
    [IsoId("_vqQWXxIkEeyLzJfz3xPQNA")]
    [Description(@"Euroyen Tokyo Interbank Offered Rate (EUYN03M).")]
    JBATIBOR = BenchmarkCurveNameV2Code.JBATIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Johannesburg Interbank Agreed Rate.
    /// Encoded/decoded by serializers as &quot;JIBA&quot;.
    /// </summary>
    [EnumMember(Value = "JIBA")]
    [IsoId("_vqQWdBIkEeyLzJfz3xPQNA")]
    [Description(@"Johannesburg Interbank Agreed Rate.")]
    JIBAR = BenchmarkCurveNameV2Code.JIBAR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate at which major international banks are willing to take deposits from one another, is normally 1/8 percent below LIBOR.
    /// London InterBank Bid Rate, the rate bid by banks on Eurocurrency deposits; the international rate that banks lend to other banks.
    /// Encoded/decoded by serializers as &quot;LIBI&quot;.
    /// </summary>
    [EnumMember(Value = "LIBI")]
    [IsoId("_vqQWexIkEeyLzJfz3xPQNA")]
    [Description(
        @"Rate at which major international banks are willing to take deposits from one another, is normally 1/8 percent below LIBOR.||London InterBank Bid Rate, the rate bid by banks on Eurocurrency deposits; the international rate that banks lend to other banks."
    )]
    LIBID = BenchmarkCurveNameV2Code.LIBID, // same ordinal as derivation source for type conversions

    /// <summary>
    /// London Interbank Offered Rate, the interest rate that major international banks in London charge each other for borrowing.
    /// Encoded/decoded by serializers as &quot;LIBO&quot;.
    /// </summary>
    [EnumMember(Value = "LIBO")]
    [IsoId("_vqQWehIkEeyLzJfz3xPQNA")]
    [Description(
        @"London Interbank Offered Rate, the interest rate that major international banks in London charge each other for borrowing."
    )]
    LIBOR = BenchmarkCurveNameV2Code.LIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Moscow Prime Offered Rate.
    /// Encoded/decoded by serializers as &quot;MOSP&quot;.
    /// </summary>
    [EnumMember(Value = "MOSP")]
    [IsoId("_vqQWYBIkEeyLzJfz3xPQNA")]
    [Description(@"Moscow Prime Offered Rate.")]
    MOSPRIM = BenchmarkCurveNameV2Code.MOSPRIM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Benchmark curve used for municipals based on the best credit rating for municipal market debt.
    /// Encoded/decoded by serializers as &quot;MAAA&quot;.
    /// </summary>
    [EnumMember(Value = "MAAA")]
    [IsoId("_vqQWeRIkEeyLzJfz3xPQNA")]
    [Description(
        @"Benchmark curve used for municipals based on the best credit rating for municipal market debt."
    )]
    MuniAAA = BenchmarkCurveNameV2Code.MuniAAA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank of Japan Uncollateralized Overnight Call Rate (MUTSCALM).
    /// Encoded/decoded by serializers as &quot;BJUO&quot;.
    /// </summary>
    [EnumMember(Value = "BJUO")]
    [IsoId("_vqQWbxIkEeyLzJfz3xPQNA")]
    [Description(@"Bank of Japan Uncollateralized Overnight Call Rate (MUTSCALM).")]
    MUTSCALM = BenchmarkCurveNameV2Code.MUTSCALM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Norwegian Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;NIBO&quot;.
    /// </summary>
    [EnumMember(Value = "NIBO")]
    [IsoId("_vqQWYhIkEeyLzJfz3xPQNA")]
    [Description(@"Norwegian Interbank Offered Rate.")]
    NIBOR = BenchmarkCurveNameV2Code.NIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Overnight Bank Funding Rate (OBFR01).
    /// Encoded/decoded by serializers as &quot;OBFR&quot;.
    /// </summary>
    [EnumMember(Value = "OBFR")]
    [IsoId("_vqQWaBIkEeyLzJfz3xPQNA")]
    [Description(@"Overnight Bank Funding Rate (OBFR01).")]
    OBFR01 = BenchmarkCurveNameV2Code.OBFR01, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pfandbriefe security is a collateralised bullet bond backed by either mortgage loans or loans to the public sector. Pfandbriefe differ from traditional asset-backed securities in significant ways. The most important difference is that Pfandbriefe carry no pre-payment risk since they remain on the balance sheet of the issuing institution. Therefore, their spreads over sovereign bonds are attributable to liquidity and credit quality alone. New indices have been created and existing indices have been modified in response to the growing importance of the Pfandbriefe market. The Deutsche Borse has three synthetic indices called REX, JEX, and PEX. The Pfandbriefe curve is used as a reference for credit as well as mortgage market.
    /// Encoded/decoded by serializers as &quot;PFAN&quot;.
    /// </summary>
    [EnumMember(Value = "PFAN")]
    [IsoId("_vqQWYRIkEeyLzJfz3xPQNA")]
    [Description(
        @"Pfandbriefe security is a collateralised bullet bond backed by either mortgage loans or loans to the public sector. Pfandbriefe differ from traditional asset-backed securities in significant ways. The most important difference is that Pfandbriefe carry no pre-payment risk since they remain on the balance sheet of the issuing institution. Therefore, their spreads over sovereign bonds are attributable to liquidity and credit quality alone. New indices have been created and existing indices have been modified in response to the growing importance of the Pfandbriefe market. The Deutsche Borse has three synthetic indices called REX, JEX, and PEX. The Pfandbriefe curve is used as a reference for credit as well as mortgage market."
    )]
    Pfandbriefe = BenchmarkCurveNameV2Code.Pfandbriefe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Czech Fixing of Interest Rates on Interbank Deposits.
    /// Encoded/decoded by serializers as &quot;PRBO&quot;.
    /// </summary>
    [EnumMember(Value = "PRBO")]
    [IsoId("_vqQWZhIkEeyLzJfz3xPQNA")]
    [Description(@"Czech Fixing of Interest Rates on Interbank Deposits.")]
    PRIBOR = BenchmarkCurveNameV2Code.PRIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// RBA Cash Rate Target  (RBATCTR).
    /// Encoded/decoded by serializers as &quot;RCTR&quot;.
    /// </summary>
    [EnumMember(Value = "RCTR")]
    [IsoId("_vqQWWhIkEeyLzJfz3xPQNA")]
    [Description(@"RBA Cash Rate Target  (RBATCTR).")]
    RBATCTR = BenchmarkCurveNameV2Code.RBATCTR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Secured Overnight Financing Rate.
    /// Encoded/decoded by serializers as &quot;SOFR&quot;.
    /// </summary>
    [EnumMember(Value = "SOFR")]
    [IsoId("_vqQWXBIkEeyLzJfz3xPQNA")]
    [Description(@"Secured Overnight Financing Rate.")]
    SOFR = BenchmarkCurveNameV2Code.SOFR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sterling Over Night Index Average.
    /// Encoded/decoded by serializers as &quot;SONA&quot;.
    /// </summary>
    [EnumMember(Value = "SONA")]
    [IsoId("_vqQWbBIkEeyLzJfz3xPQNA")]
    [Description(@"Sterling Over Night Index Average.")]
    SONIA = BenchmarkCurveNameV2Code.SONIA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stockholm Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;STBO&quot;.
    /// </summary>
    [EnumMember(Value = "STBO")]
    [IsoId("_vqQWYxIkEeyLzJfz3xPQNA")]
    [Description(@"Stockholm Interbank Offered Rate.")]
    STIBOR = BenchmarkCurveNameV2Code.STIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In curve construction, Swap is the long portion of the curve constituting about 3 years to 30 years term.||The exchange of one security, currency or interest rate for another to change the maturity (bonds), or quality of issues (stocks or bonds), or because investment objectives have changed.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_vqQWWRIkEeyLzJfz3xPQNA")]
    [Description(
        @"In curve construction, Swap is the long portion of the curve constituting about 3 years to 30 years term.||The exchange of one security, currency or interest rate for another to change the maturity (bonds), or quality of issues (stocks or bonds), or because investment objectives have changed."
    )]
    SWAP = BenchmarkCurveNameV2Code.SWAP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tel Aviv Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;TLBO&quot;.
    /// </summary>
    [EnumMember(Value = "TLBO")]
    [IsoId("_vqQWaRIkEeyLzJfz3xPQNA")]
    [Description(@"Tel Aviv Interbank Offered Rate.")]
    TELBOR = BenchmarkCurveNameV2Code.TELBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tokyo Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;TIBO&quot;.
    /// </summary>
    [EnumMember(Value = "TIBO")]
    [IsoId("_vqQWZxIkEeyLzJfz3xPQNA")]
    [Description(@"Tokyo Interbank Offered Rate.")]
    TIBOR = BenchmarkCurveNameV2Code.TIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tokyo overnight weighted average rate.
    /// Encoded/decoded by serializers as &quot;TOAR&quot;.
    /// </summary>
    [EnumMember(Value = "TOAR")]
    [IsoId("_vqQWcRIkEeyLzJfz3xPQNA")]
    [Description(@"Tokyo overnight weighted average rate.")]
    TONAR = BenchmarkCurveNameV2Code.TONAR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Treasury benchmark that comes in three types: the yield curve, the par curve, and the spot curve. All curves also have a constituent time series.
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_vqQWXRIkEeyLzJfz3xPQNA")]
    [Description(
        @"Treasury benchmark that comes in three types: the yield curve, the par curve, and the spot curve. All curves also have a constituent time series."
    )]
    Treasury = BenchmarkCurveNameV2Code.Treasury, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Warsaw Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;WIBO&quot;.
    /// </summary>
    [EnumMember(Value = "WIBO")]
    [IsoId("_vqQWXhIkEeyLzJfz3xPQNA")]
    [Description(@"Warsaw Interbank Offered Rate.")]
    WIBOR = BenchmarkCurveNameV2Code.WIBOR, // same ordinal as derivation source for type conversions
}
