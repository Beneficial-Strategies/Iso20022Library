// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a benchmark curve name.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QEXIYAnUEeWa7rBfPECYsw")]
[Description(@"Specifies a benchmark curve name.")]
[DerivedFrom(typeof(BenchmarkCurveNameCode))]
public enum BenchmarkCurveName2Code
{
    /// <summary>
    /// Warsaw Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;WIBO&quot;.
    /// </summary>
    [EnumMember(Value = "WIBO")]
    [IsoId("_SBMBcQnUEeWa7rBfPECYsw")]
    [Description(@"Warsaw Interbank Offered Rate.")]
    WIBOR = BenchmarkCurveNameCode.WIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Treasury benchmark that comes in three types: the yield curve, the par curve, and the spot curve. All curves also have a constituent time series.
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_SHuuUQnUEeWa7rBfPECYsw")]
    [Description(
        @"Treasury benchmark that comes in three types: the yield curve, the par curve, and the spot curve. All curves also have a constituent time series."
    )]
    Treasury = BenchmarkCurveNameCode.Treasury, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tokyo Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;TIBO&quot;.
    /// </summary>
    [EnumMember(Value = "TIBO")]
    [IsoId("_SQqA0QnUEeWa7rBfPECYsw")]
    [Description(@"Tokyo Interbank Offered Rate.")]
    TIBOR = BenchmarkCurveNameCode.TIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tel Aviv Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;TLBO&quot;.
    /// </summary>
    [EnumMember(Value = "TLBO")]
    [IsoId("_SWT84QnUEeWa7rBfPECYsw")]
    [Description(@"Tel Aviv Interbank Offered Rate.")]
    TELBOR = BenchmarkCurveNameCode.TELBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In curve construction, Swap is the long portion of the curve constituting about 3 years to 30 years term.||The exchange of one security, currency or interest rate for another to change the maturity (bonds), or quality of issues (stocks or bonds), or because investment objectives have changed.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_ScHC4QnUEeWa7rBfPECYsw")]
    [Description(
        @"In curve construction, Swap is the long portion of the curve constituting about 3 years to 30 years term.||The exchange of one security, currency or interest rate for another to change the maturity (bonds), or quality of issues (stocks or bonds), or because investment objectives have changed."
    )]
    SWAP = BenchmarkCurveNameCode.SWAP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stockholm Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;STBO&quot;.
    /// </summary>
    [EnumMember(Value = "STBO")]
    [IsoId("_Si9RwQnUEeWa7rBfPECYsw")]
    [Description(@"Stockholm Interbank Offered Rate.")]
    STIBOR = BenchmarkCurveNameCode.STIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Czech Fixing of Interest Rates on Interbank Deposits.
    /// Encoded/decoded by serializers as &quot;PRBO&quot;.
    /// </summary>
    [EnumMember(Value = "PRBO")]
    [IsoId("_Spf-oQnUEeWa7rBfPECYsw")]
    [Description(@"Czech Fixing of Interest Rates on Interbank Deposits.")]
    PRIBOR = BenchmarkCurveNameCode.PRIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pfandbriefe security is a collateralised bullet bond backed by either mortgage loans or loans to the public sector. Pfandbriefe differ from traditional asset-backed securities in significant ways. The most important difference is that Pfandbriefe carry no pre-payment risk since they remain on the balance sheet of the issuing institution. Therefore, their spreads over sovereign bonds are attributable to liquidity and credit quality alone. New indices have been created and existing indices have been modified in response to the growing importance of the Pfandbriefe market. The Deutsche Borse has three synthetic indices called REX, JEX, and PEX. The Pfandbriefe curve is used as a reference for credit as well as mortgage market.
    /// Encoded/decoded by serializers as &quot;PFAN&quot;.
    /// </summary>
    [EnumMember(Value = "PFAN")]
    [IsoId("_Sv5hkQnUEeWa7rBfPECYsw")]
    [Description(
        @"Pfandbriefe security is a collateralised bullet bond backed by either mortgage loans or loans to the public sector. Pfandbriefe differ from traditional asset-backed securities in significant ways. The most important difference is that Pfandbriefe carry no pre-payment risk since they remain on the balance sheet of the issuing institution. Therefore, their spreads over sovereign bonds are attributable to liquidity and credit quality alone. New indices have been created and existing indices have been modified in response to the growing importance of the Pfandbriefe market. The Deutsche Borse has three synthetic indices called REX, JEX, and PEX. The Pfandbriefe curve is used as a reference for credit as well as mortgage market."
    )]
    Pfandbriefe = BenchmarkCurveNameCode.Pfandbriefe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Norwegian Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;NIBO&quot;.
    /// </summary>
    [EnumMember(Value = "NIBO")]
    [IsoId("_S0XK0QnUEeWa7rBfPECYsw")]
    [Description(@"Norwegian Interbank Offered Rate.")]
    NIBOR = BenchmarkCurveNameCode.NIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Benchmark curve used for municipals based on the best credit rating for municipal market debt.
    /// Encoded/decoded by serializers as &quot;MAAA&quot;.
    /// </summary>
    [EnumMember(Value = "MAAA")]
    [IsoId("_S5HvAQnUEeWa7rBfPECYsw")]
    [Description(
        @"Benchmark curve used for municipals based on the best credit rating for municipal market debt."
    )]
    MuniAAA = BenchmarkCurveNameCode.MuniAAA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Moscow Prime Offered Rate.
    /// Encoded/decoded by serializers as &quot;MOSP&quot;.
    /// </summary>
    [EnumMember(Value = "MOSP")]
    [IsoId("_TAjzwQnUEeWa7rBfPECYsw")]
    [Description(@"Moscow Prime Offered Rate.")]
    MOSPRIM = BenchmarkCurveNameCode.MOSPRIM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// London Interbank Offered Rate, the interest rate that major international banks in London charge each other for borrowing.
    /// Encoded/decoded by serializers as &quot;LIBO&quot;.
    /// </summary>
    [EnumMember(Value = "LIBO")]
    [IsoId("_TFxD4QnUEeWa7rBfPECYsw")]
    [Description(
        @"London Interbank Offered Rate, the interest rate that major international banks in London charge each other for borrowing."
    )]
    LIBOR = BenchmarkCurveNameCode.LIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate at which major international banks are willing to take deposits from one another, is normally 1/8 percent below LIBOR.
    /// London InterBank Bid Rate, the rate bid by banks on Eurocurrency deposits; the international rate that banks lend to other banks.
    /// Encoded/decoded by serializers as &quot;LIBI&quot;.
    /// </summary>
    [EnumMember(Value = "LIBI")]
    [IsoId("_TKOtIQnUEeWa7rBfPECYsw")]
    [Description(
        @"Rate at which major international banks are willing to take deposits from one another, is normally 1/8 percent below LIBOR.||London InterBank Bid Rate, the rate bid by banks on Eurocurrency deposits; the international rate that banks lend to other banks."
    )]
    LIBID = BenchmarkCurveNameCode.LIBID, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Johannesburg Interbank Agreed Rate.
    /// Encoded/decoded by serializers as &quot;JIBA&quot;.
    /// </summary>
    [EnumMember(Value = "JIBA")]
    [IsoId("_TPSzUQnUEeWa7rBfPECYsw")]
    [Description(@"Johannesburg Interbank Agreed Rate.")]
    JIBAR = BenchmarkCurveNameCode.JIBAR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Worldwide common reference rate value for fixed interest rate swap rates, as defined by the International Swaps and Derivatives Association (ISDA).
    /// Encoded/decoded by serializers as &quot;ISDA&quot;.
    /// </summary>
    [EnumMember(Value = "ISDA")]
    [IsoId("_TUgDcQnUEeWa7rBfPECYsw")]
    [Description(
        @"Worldwide common reference rate value for fixed interest rate swap rates, as defined by the International Swaps and Derivatives Association (ISDA)."
    )]
    ISDAFIX = BenchmarkCurveNameCode.ISDAFIX, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GCF Repo Index, the Depository Trust &amp; Clearing Corporation (DTCC) general collateral finance repurchase agreements index.
    /// Encoded/decoded by serializers as &quot;GCFR&quot;.
    /// </summary>
    [EnumMember(Value = "GCFR")]
    [IsoId("_TY9ssQnUEeWa7rBfPECYsw")]
    [Description(
        @"GCF Repo Index, the Depository Trust & Clearing Corporation (DTCC) general collateral finance repurchase agreements index."
    )]
    GCFRepo = BenchmarkCurveNameCode.GCFRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Portion of a synthetic curve that is composed of Eurodollar or Treasury or similar Futures and Swap rates. The term usually begins at 3 months to 2 years for the futures strip component with the Swaps filling in the points to 10 years and beyond.
    /// Encoded/decoded by serializers as &quot;FUSW&quot;.
    /// </summary>
    [EnumMember(Value = "FUSW")]
    [IsoId("_Th4_MQnUEeWa7rBfPECYsw")]
    [Description(
        @"Portion of a synthetic curve that is composed of Eurodollar or Treasury or similar Futures and Swap rates. The term usually begins at 3 months to 2 years for the futures strip component with the Swaps filling in the points to 10 years and beyond."
    )]
    FutureSWAP = BenchmarkCurveNameCode.FutureSWAP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Swiss Franc LIBOR rate.
    /// Encoded/decoded by serializers as &quot;EUCH&quot;.
    /// </summary>
    [EnumMember(Value = "EUCH")]
    [IsoId("_TtM3UQnUEeWa7rBfPECYsw")]
    [Description(@"Swiss Franc LIBOR rate.")]
    EuroSwiss = BenchmarkCurveNameCode.EuroSwiss, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate for the eurodollars, time deposits denominated in U.S. dollars at banks outside the United States, and thus are not under the jurisdiction of the Federal Reserve.
    /// Encoded/decoded by serializers as &quot;EUUS&quot;.
    /// </summary>
    [EnumMember(Value = "EUUS")]
    [IsoId("_TyaHcQnUEeWa7rBfPECYsw")]
    [Description(
        @"Rate for the eurodollars, time deposits denominated in U.S. dollars at banks outside the United States, and thus are not under the jurisdiction of the Federal Reserve."
    )]
    EURODOLLAR = BenchmarkCurveNameCode.EURODOLLAR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Euro Interbank Offer Rate is the rate at which Euro inter-bank term deposits within the Euro zone are offered by one prime bank to another prime bank.
    /// Encoded/decoded by serializers as &quot;EURI&quot;.
    /// </summary>
    [EnumMember(Value = "EURI")]
    [IsoId("_T3nXkQnUEeWa7rBfPECYsw")]
    [Description(
        @"Euro Interbank Offer Rate is the rate at which Euro inter-bank term deposits within the Euro zone are offered by one prime bank to another prime bank."
    )]
    Euribor = BenchmarkCurveNameCode.Euribor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Euro OverNight Index Average swap rate.
    /// Encoded/decoded by serializers as &quot;EONS&quot;.
    /// </summary>
    [EnumMember(Value = "EONS")]
    [IsoId("_T9HioQnUEeWa7rBfPECYsw")]
    [Description(@"Euro OverNight Index Average swap rate.")]
    EONIASwaps = BenchmarkCurveNameCode.EONIASwaps, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Euro OverNight Index Average rate.
    /// Encoded/decoded by serializers as &quot;EONA&quot;.
    /// </summary>
    [EnumMember(Value = "EONA")]
    [IsoId("_UDEZoQnUEeWa7rBfPECYsw")]
    [Description(@"Euro OverNight Index Average rate.")]
    EONIA = BenchmarkCurveNameCode.EONIA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Copenhagen Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;CIBO&quot;.
    /// </summary>
    [EnumMember(Value = "CIBO")]
    [IsoId("_UJKakQnUEeWa7rBfPECYsw")]
    [Description(@"Copenhagen Interbank Offered Rate.")]
    CIBOR = BenchmarkCurveNameCode.CIBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Canadian Dollar Offered Rate.
    /// Encoded/decoded by serializers as &quot;CDOR&quot;.
    /// </summary>
    [EnumMember(Value = "CDOR")]
    [IsoId("_UQKacQnUEeWa7rBfPECYsw")]
    [Description(@"Canadian Dollar Offered Rate.")]
    CDOR = BenchmarkCurveNameCode.CDOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Budapest Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;BUBO&quot;.
    /// </summary>
    [EnumMember(Value = "BUBO")]
    [IsoId("_UZYn4QnUEeWa7rBfPECYsw")]
    [Description(@"Budapest Interbank Offered Rate.")]
    BUBOR = BenchmarkCurveNameCode.BUBOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Australian Financial Markets Association (AFMA) Bank-Bill Reference Rate (BBSW).
    /// Encoded/decoded by serializers as &quot;BBSW&quot;.
    /// </summary>
    [EnumMember(Value = "BBSW")]
    [IsoId("_Uk_a8QnUEeWa7rBfPECYsw")]
    [Description(
        @"Australian Financial Markets Association (AFMA) Bank-Bill Reference Rate (BBSW)."
    )]
    BBSW = BenchmarkCurveNameCode.BBSW, // same ordinal as derivation source for type conversions
}
