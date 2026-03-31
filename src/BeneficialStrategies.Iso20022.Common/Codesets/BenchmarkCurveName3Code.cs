// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a benchmark curve name.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wcX9QKx1Eem81-uIvTF5rQ")]
[Description(@"Specifies a benchmark curve name.")]
[DerivedFrom(typeof(BenchmarkCurveNameCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BenchmarkCurveName3Code>))]
#endif
public enum BenchmarkCurveName3Code
{
    /// <summary>
    /// Euro Short Term Rate
    /// Encoded/decoded by serializers as &quot;ESTR&quot;.
    /// </summary>
    [EnumMember(Value = "ESTR")]
    [IsoId("_zGuDoax1Eem81-uIvTF5rQ")]
    [Description(@"Euro Short Term Rate")]
    ESTER = BenchmarkCurveNameCode.ESTER, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Australian Financial Markets Association (AFMA) Bank-Bill Reference Rate (BBSW).
    /// Encoded/decoded by serializers as &quot;BBSW&quot;.
    /// </summary>
    [EnumMember(Value = "BBSW")]
    [IsoId("_0dTcEax1Eem81-uIvTF5rQ")]
    [Description(
        @"Australian Financial Markets Association (AFMA) Bank-Bill Reference Rate (BBSW)."
    )]
    BBSW = BenchmarkCurveNameCode.BBSW, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Budapest Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;BUBO&quot;.
    /// </summary>
    [EnumMember(Value = "BUBO")]
    [IsoId("_08JUMax1Eem81-uIvTF5rQ")]
    [Description(@"Budapest Interbank Offered Rate.")]
    BUBOR = BenchmarkCurveNameCode.BUBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Canadian Dollar Offered Rate.
    /// Encoded/decoded by serializers as &quot;CDOR&quot;.
    /// </summary>
    [EnumMember(Value = "CDOR")]
    [IsoId("_1JkFIax1Eem81-uIvTF5rQ")]
    [Description(@"Canadian Dollar Offered Rate.")]
    CDOR = BenchmarkCurveNameCode.CDOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Copenhagen Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;CIBO&quot;.
    /// </summary>
    [EnumMember(Value = "CIBO")]
    [IsoId("_1Sf-sax1Eem81-uIvTF5rQ")]
    [Description(@"Copenhagen Interbank Offered Rate.")]
    CIBOR = BenchmarkCurveNameCode.CIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Euro OverNight Index Average rate.
    /// Encoded/decoded by serializers as &quot;EONA&quot;.
    /// </summary>
    [EnumMember(Value = "EONA")]
    [IsoId("_1vtfIax1Eem81-uIvTF5rQ")]
    [Description(@"Euro OverNight Index Average rate.")]
    EONIA = BenchmarkCurveNameCode.EONIA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Euro OverNight Index Average swap rate.
    /// Encoded/decoded by serializers as &quot;EONS&quot;.
    /// </summary>
    [EnumMember(Value = "EONS")]
    [IsoId("_14NT0ax1Eem81-uIvTF5rQ")]
    [Description(@"Euro OverNight Index Average swap rate.")]
    EONIASwaps = BenchmarkCurveNameCode.EONIASwaps, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Euro Interbank Offer Rate is the rate at which Euro inter-bank term deposits within the Euro zone are offered by one prime bank to another prime bank.
    /// Encoded/decoded by serializers as &quot;EURI&quot;.
    /// </summary>
    [EnumMember(Value = "EURI")]
    [IsoId("_2QDMEax1Eem81-uIvTF5rQ")]
    [Description(
        @"Euro Interbank Offer Rate is the rate at which Euro inter-bank term deposits within the Euro zone are offered by one prime bank to another prime bank."
    )]
    Euribor = BenchmarkCurveNameCode.Euribor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate for the eurodollars, time deposits denominated in U.S. dollars at banks outside the United States, and thus are not under the jurisdiction of the Federal Reserve.
    /// Encoded/decoded by serializers as &quot;EUUS&quot;.
    /// </summary>
    [EnumMember(Value = "EUUS")]
    [IsoId("_2kUL4ax1Eem81-uIvTF5rQ")]
    [Description(
        @"Rate for the eurodollars, time deposits denominated in U.S. dollars at banks outside the United States, and thus are not under the jurisdiction of the Federal Reserve."
    )]
    EURODOLLAR = BenchmarkCurveNameCode.EURODOLLAR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Swiss Franc LIBOR rate.
    /// Encoded/decoded by serializers as &quot;EUCH&quot;.
    /// </summary>
    [EnumMember(Value = "EUCH")]
    [IsoId("_2s0Akax1Eem81-uIvTF5rQ")]
    [Description(@"Swiss Franc LIBOR rate.")]
    EuroSwiss = BenchmarkCurveNameCode.EuroSwiss, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Portion of a synthetic curve that is composed of Eurodollar or Treasury or similar Futures and Swap rates. The term usually begins at 3 months to 2 years for the futures strip component with the Swaps filling in the points to 10 years and beyond.
    /// Encoded/decoded by serializers as &quot;FUSW&quot;.
    /// </summary>
    [EnumMember(Value = "FUSW")]
    [IsoId("_3J3wAax1Eem81-uIvTF5rQ")]
    [Description(
        @"Portion of a synthetic curve that is composed of Eurodollar or Treasury or similar Futures and Swap rates. The term usually begins at 3 months to 2 years for the futures strip component with the Swaps filling in the points to 10 years and beyond."
    )]
    FutureSWAP = BenchmarkCurveNameCode.FutureSWAP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GCF Repo Index, the Depository Trust &amp; Clearing Corporation (DTCC) general collateral finance repurchase agreements index.
    /// Encoded/decoded by serializers as &quot;GCFR&quot;.
    /// </summary>
    [EnumMember(Value = "GCFR")]
    [IsoId("_3mezgax1Eem81-uIvTF5rQ")]
    [Description(
        @"GCF Repo Index, the Depository Trust & Clearing Corporation (DTCC) general collateral finance repurchase agreements index."
    )]
    GCFRepo = BenchmarkCurveNameCode.GCFRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Worldwide common reference rate value for fixed interest rate swap rates, as defined by the International Swaps and Derivatives Association (ISDA).
    /// Encoded/decoded by serializers as &quot;ISDA&quot;.
    /// </summary>
    [EnumMember(Value = "ISDA")]
    [IsoId("_3_ODoax1Eem81-uIvTF5rQ")]
    [Description(
        @"Worldwide common reference rate value for fixed interest rate swap rates, as defined by the International Swaps and Derivatives Association (ISDA)."
    )]
    ISDAFIX = BenchmarkCurveNameCode.ISDAFIX, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Johannesburg Interbank Agreed Rate.
    /// Encoded/decoded by serializers as &quot;JIBA&quot;.
    /// </summary>
    [EnumMember(Value = "JIBA")]
    [IsoId("_4HkHUax1Eem81-uIvTF5rQ")]
    [Description(@"Johannesburg Interbank Agreed Rate.")]
    JIBAR = BenchmarkCurveNameCode.JIBAR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate at which major international banks are willing to take deposits from one another, is normally 1/8 percent below LIBOR.
    /// London InterBank Bid Rate, the rate bid by banks on Eurocurrency deposits; the international rate that banks lend to other banks.
    /// Encoded/decoded by serializers as &quot;LIBI&quot;.
    /// </summary>
    [EnumMember(Value = "LIBI")]
    [IsoId("_4VufIax1Eem81-uIvTF5rQ")]
    [Description(
        @"Rate at which major international banks are willing to take deposits from one another, is normally 1/8 percent below LIBOR.||London InterBank Bid Rate, the rate bid by banks on Eurocurrency deposits; the international rate that banks lend to other banks."
    )]
    LIBID = BenchmarkCurveNameCode.LIBID, // same ordinal as derivation source for type conversions

    /// <summary>
    /// London Interbank Offered Rate, the interest rate that major international banks in London charge each other for borrowing.
    /// Encoded/decoded by serializers as &quot;LIBO&quot;.
    /// </summary>
    [EnumMember(Value = "LIBO")]
    [IsoId("_4eXdwax1Eem81-uIvTF5rQ")]
    [Description(
        @"London Interbank Offered Rate, the interest rate that major international banks in London charge each other for borrowing."
    )]
    LIBOR = BenchmarkCurveNameCode.LIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Moscow Prime Offered Rate.
    /// Encoded/decoded by serializers as &quot;MOSP&quot;.
    /// </summary>
    [EnumMember(Value = "MOSP")]
    [IsoId("_4tHrcax1Eem81-uIvTF5rQ")]
    [Description(@"Moscow Prime Offered Rate.")]
    MOSPRIM = BenchmarkCurveNameCode.MOSPRIM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Benchmark curve used for municipals based on the best credit rating for municipal market debt.
    /// Encoded/decoded by serializers as &quot;MAAA&quot;.
    /// </summary>
    [EnumMember(Value = "MAAA")]
    [IsoId("_43270ax1Eem81-uIvTF5rQ")]
    [Description(
        @"Benchmark curve used for municipals based on the best credit rating for municipal market debt."
    )]
    MuniAAA = BenchmarkCurveNameCode.MuniAAA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Norwegian Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;NIBO&quot;.
    /// </summary>
    [EnumMember(Value = "NIBO")]
    [IsoId("_5QvV4ax1Eem81-uIvTF5rQ")]
    [Description(@"Norwegian Interbank Offered Rate.")]
    NIBOR = BenchmarkCurveNameCode.NIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pfandbriefe security is a collateralised bullet bond backed by either mortgage loans or loans to the public sector. Pfandbriefe differ from traditional asset-backed securities in significant ways. The most important difference is that Pfandbriefe carry no pre-payment risk since they remain on the balance sheet of the issuing institution. Therefore, their spreads over sovereign bonds are attributable to liquidity and credit quality alone. New indices have been created and existing indices have been modified in response to the growing importance of the Pfandbriefe market. The Deutsche Borse has three synthetic indices called REX, JEX, and PEX. The Pfandbriefe curve is used as a reference for credit as well as mortgage market.
    /// Encoded/decoded by serializers as &quot;PFAN&quot;.
    /// </summary>
    [EnumMember(Value = "PFAN")]
    [IsoId("_5ZYUgax1Eem81-uIvTF5rQ")]
    [Description(
        @"Pfandbriefe security is a collateralised bullet bond backed by either mortgage loans or loans to the public sector. Pfandbriefe differ from traditional asset-backed securities in significant ways. The most important difference is that Pfandbriefe carry no pre-payment risk since they remain on the balance sheet of the issuing institution. Therefore, their spreads over sovereign bonds are attributable to liquidity and credit quality alone. New indices have been created and existing indices have been modified in response to the growing importance of the Pfandbriefe market. The Deutsche Borse has three synthetic indices called REX, JEX, and PEX. The Pfandbriefe curve is used as a reference for credit as well as mortgage market."
    )]
    Pfandbriefe = BenchmarkCurveNameCode.Pfandbriefe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Czech Fixing of Interest Rates on Interbank Deposits.
    /// Encoded/decoded by serializers as &quot;PRBO&quot;.
    /// </summary>
    [EnumMember(Value = "PRBO")]
    [IsoId("_53Cg4ax1Eem81-uIvTF5rQ")]
    [Description(@"Czech Fixing of Interest Rates on Interbank Deposits.")]
    PRIBOR = BenchmarkCurveNameCode.PRIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stockholm Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;STBO&quot;.
    /// </summary>
    [EnumMember(Value = "STBO")]
    [IsoId("_5_iVkax1Eem81-uIvTF5rQ")]
    [Description(@"Stockholm Interbank Offered Rate.")]
    STIBOR = BenchmarkCurveNameCode.STIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In curve construction, Swap is the long portion of the curve constituting about 3 years to 30 years term.||The exchange of one security, currency or interest rate for another to change the maturity (bonds), or quality of issues (stocks or bonds), or because investment objectives have changed.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_6U_oMax1Eem81-uIvTF5rQ")]
    [Description(
        @"In curve construction, Swap is the long portion of the curve constituting about 3 years to 30 years term.||The exchange of one security, currency or interest rate for another to change the maturity (bonds), or quality of issues (stocks or bonds), or because investment objectives have changed."
    )]
    SWAP = BenchmarkCurveNameCode.SWAP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tel Aviv Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;TLBO&quot;.
    /// </summary>
    [EnumMember(Value = "TLBO")]
    [IsoId("_6dom0ax1Eem81-uIvTF5rQ")]
    [Description(@"Tel Aviv Interbank Offered Rate.")]
    TELBOR = BenchmarkCurveNameCode.TELBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tokyo Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;TIBO&quot;.
    /// </summary>
    [EnumMember(Value = "TIBO")]
    [IsoId("_6silgax1Eem81-uIvTF5rQ")]
    [Description(@"Tokyo Interbank Offered Rate.")]
    TIBOR = BenchmarkCurveNameCode.TIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Treasury benchmark that comes in three types: the yield curve, the par curve, and the spot curve. All curves also have a constituent time series.
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_68MLEax1Eem81-uIvTF5rQ")]
    [Description(
        @"Treasury benchmark that comes in three types: the yield curve, the par curve, and the spot curve. All curves also have a constituent time series."
    )]
    Treasury = BenchmarkCurveNameCode.Treasury, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Warsaw Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;WIBO&quot;.
    /// </summary>
    [EnumMember(Value = "WIBO")]
    [IsoId("_7FR1oax1Eem81-uIvTF5rQ")]
    [Description(@"Warsaw Interbank Offered Rate.")]
    WIBOR = BenchmarkCurveNameCode.WIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Secured Overnight Financing Rate.
    /// Encoded/decoded by serializers as &quot;SOFR&quot;.
    /// </summary>
    [EnumMember(Value = "SOFR")]
    [IsoId("_a08SkbUMEemybd4mhF9NIA")]
    [Description(@"Secured Overnight Financing Rate.")]
    SOFR = BenchmarkCurveNameCode.SOFR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sterling Over Night Index Average.
    /// Encoded/decoded by serializers as &quot;SONA&quot;.
    /// </summary>
    [EnumMember(Value = "SONA")]
    [IsoId("_bNdgQbUMEemybd4mhF9NIA")]
    [Description(@"Sterling Over Night Index Average.")]
    SONIA = BenchmarkCurveNameCode.SONIA, // same ordinal as derivation source for type conversions
}
