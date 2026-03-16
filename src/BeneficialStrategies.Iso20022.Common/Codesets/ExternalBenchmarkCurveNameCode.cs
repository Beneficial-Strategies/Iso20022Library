// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external benchmark curve name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FFBTeDNnEe2UWZuK9pqFtg")]
[Description(
    @"Specifies the external benchmark curve name code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalBenchmarkCurveName1Code))]
public enum ExternalBenchmarkCurveNameCode
{
    /// <summary>
    /// Benchmark curve used for municipals based on the best credit rating for municipal market debt.
    /// Encoded/decoded by serializers as &quot;MAAA&quot;.
    /// </summary>
    [EnumMember(Value = "MAAA")]
    [IsoId("_FFBTeTNnEe2UWZuK9pqFtg")]
    [Description(
        @"Benchmark curve used for municipals based on the best credit rating for municipal market debt."
    )]
    MuniAAA,

    /// <summary>
    /// Portion of a synthetic curve that is composed of Eurodollar or Treasury or similar Futures and Swap rates. The term usually begins at 3 months to 2 years for the futures strip component with the Swaps filling in the points to 10 years and beyond.
    /// Encoded/decoded by serializers as &quot;FUSW&quot;.
    /// </summary>
    [EnumMember(Value = "FUSW")]
    [IsoId("_FFB6cTNnEe2UWZuK9pqFtg")]
    [Description(
        @"Portion of a synthetic curve that is composed of Eurodollar or Treasury or similar Futures and Swap rates. The term usually begins at 3 months to 2 years for the futures strip component with the Swaps filling in the points to 10 years and beyond."
    )]
    FutureSWAP,

    /// <summary>
    /// Rate at which major international banks are willing to take deposits from one another, is normally 1/8 percent below LIBOR.
    /// London InterBank Bid Rate, the rate bid by banks on Eurocurrency deposits; the international rate that banks lend to other banks.
    /// Encoded/decoded by serializers as &quot;LIBI&quot;.
    /// </summary>
    [EnumMember(Value = "LIBI")]
    [IsoId("_FFB6YTNnEe2UWZuK9pqFtg")]
    [Description(
        @"Rate at which major international banks are willing to take deposits from one another, is normally 1/8 percent below LIBOR.||London InterBank Bid Rate, the rate bid by banks on Eurocurrency deposits; the international rate that banks lend to other banks."
    )]
    LIBID,

    /// <summary>
    /// London Interbank Offered Rate, the interest rate that major international banks in London charge each other for borrowing.
    /// Encoded/decoded by serializers as &quot;LIBO&quot;.
    /// </summary>
    [EnumMember(Value = "LIBO")]
    [IsoId("_FFBTizNnEe2UWZuK9pqFtg")]
    [Description(
        @"London Interbank Offered Rate, the interest rate that major international banks in London charge each other for borrowing."
    )]
    LIBOR,

    /// <summary>
    /// In curve construction, Swap is the long portion of the curve constituting about 3 years to 30 years term.||The exchange of one security, currency or interest rate for another to change the maturity (bonds), or quality of issues (stocks or bonds), or because investment objectives have changed.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_FFB6bjNnEe2UWZuK9pqFtg")]
    [Description(
        @"In curve construction, Swap is the long portion of the curve constituting about 3 years to 30 years term.||The exchange of one security, currency or interest rate for another to change the maturity (bonds), or quality of issues (stocks or bonds), or because investment objectives have changed."
    )]
    SWAP,

    /// <summary>
    /// Treasury benchmark that comes in three types: the yield curve, the par curve, and the spot curve. All curves also have a constituent time series.
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_FFB6ZjNnEe2UWZuK9pqFtg")]
    [Description(
        @"Treasury benchmark that comes in three types: the yield curve, the par curve, and the spot curve. All curves also have a constituent time series."
    )]
    Treasury,

    /// <summary>
    /// Euro Interbank Offer Rate is the rate at which Euro inter-bank term deposits within the Euro zone are offered by one prime bank to another prime bank.
    /// Encoded/decoded by serializers as &quot;EURI&quot;.
    /// </summary>
    [EnumMember(Value = "EURI")]
    [IsoId("_FFBThTNnEe2UWZuK9pqFtg")]
    [Description(
        @"Euro Interbank Offer Rate is the rate at which Euro inter-bank term deposits within the Euro zone are offered by one prime bank to another prime bank."
    )]
    Euribor,

    /// <summary>
    /// Pfandbriefe security is a collateralised bullet bond backed by either mortgage loans or loans to the public sector. Pfandbriefe differ from traditional asset-backed securities in significant ways. The most important difference is that Pfandbriefe carry no pre-payment risk since they remain on the balance sheet of the issuing institution. Therefore, their spreads over sovereign bonds are attributable to liquidity and credit quality alone. New indices have been created and existing indices have been modified in response to the growing importance of the Pfandbriefe market. The Deutsche Borse has three synthetic indices called REX, JEX, and PEX. The Pfandbriefe curve is used as a reference for credit as well as mortgage market.
    /// Encoded/decoded by serializers as &quot;PFAN&quot;.
    /// </summary>
    [EnumMember(Value = "PFAN")]
    [IsoId("_FFB6bzNnEe2UWZuK9pqFtg")]
    [Description(
        @"Pfandbriefe security is a collateralised bullet bond backed by either mortgage loans or loans to the public sector. Pfandbriefe differ from traditional asset-backed securities in significant ways. The most important difference is that Pfandbriefe carry no pre-payment risk since they remain on the balance sheet of the issuing institution. Therefore, their spreads over sovereign bonds are attributable to liquidity and credit quality alone. New indices have been created and existing indices have been modified in response to the growing importance of the Pfandbriefe market. The Deutsche Borse has three synthetic indices called REX, JEX, and PEX. The Pfandbriefe curve is used as a reference for credit as well as mortgage market."
    )]
    Pfandbriefe,

    /// <summary>
    /// Euro OverNight Index Average rate.
    /// Encoded/decoded by serializers as &quot;EONA&quot;.
    /// </summary>
    [EnumMember(Value = "EONA")]
    [IsoId("_FFB6ZDNnEe2UWZuK9pqFtg")]
    [Description(@"Euro OverNight Index Average rate.")]
    EONIA,

    /// <summary>
    /// Euro OverNight Index Average swap rate.
    /// Encoded/decoded by serializers as &quot;EONS&quot;.
    /// </summary>
    [EnumMember(Value = "EONS")]
    [IsoId("_FFBTezNnEe2UWZuK9pqFtg")]
    [Description(@"Euro OverNight Index Average swap rate.")]
    EONIASwaps,

    /// <summary>
    /// Rate for the eurodollars, time deposits denominated in U.S. dollars at banks outside the United States, and thus are not under the jurisdiction of the Federal Reserve.
    /// Encoded/decoded by serializers as &quot;EUUS&quot;.
    /// </summary>
    [EnumMember(Value = "EUUS")]
    [IsoId("_FFB6cDNnEe2UWZuK9pqFtg")]
    [Description(
        @"Rate for the eurodollars, time deposits denominated in U.S. dollars at banks outside the United States, and thus are not under the jurisdiction of the Federal Reserve."
    )]
    EURODOLLAR,

    /// <summary>
    /// Swiss Franc LIBOR rate.
    /// Encoded/decoded by serializers as &quot;EUCH&quot;.
    /// </summary>
    [EnumMember(Value = "EUCH")]
    [IsoId("_FFBTjDNnEe2UWZuK9pqFtg")]
    [Description(@"Swiss Franc LIBOR rate.")]
    EuroSwiss,

    /// <summary>
    /// Tokyo Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;TIBO&quot;.
    /// </summary>
    [EnumMember(Value = "TIBO")]
    [IsoId("_FFBThjNnEe2UWZuK9pqFtg")]
    [Description(@"Tokyo Interbank Offered Rate.")]
    TIBOR,

    /// <summary>
    /// Worldwide common reference rate value for fixed interest rate swap rates, as defined by the International Swaps and Derivatives Association (ISDA).
    /// Encoded/decoded by serializers as &quot;ISDA&quot;.
    /// </summary>
    [EnumMember(Value = "ISDA")]
    [IsoId("_FFB6azNnEe2UWZuK9pqFtg")]
    [Description(
        @"Worldwide common reference rate value for fixed interest rate swap rates, as defined by the International Swaps and Derivatives Association (ISDA)."
    )]
    ISDAFIX,

    /// <summary>
    /// GCF Repo Index, the Depository Trust &amp; Clearing Corporation (DTCC) general collateral finance repurchase agreements index.
    /// Encoded/decoded by serializers as &quot;GCFR&quot;.
    /// </summary>
    [EnumMember(Value = "GCFR")]
    [IsoId("_FFBThzNnEe2UWZuK9pqFtg")]
    [Description(
        @"GCF Repo Index, the Depository Trust & Clearing Corporation (DTCC) general collateral finance repurchase agreements index."
    )]
    GCFRepo,

    /// <summary>
    /// Stockholm Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;STBO&quot;.
    /// </summary>
    [EnumMember(Value = "STBO")]
    [IsoId("_FFBTgDNnEe2UWZuK9pqFtg")]
    [Description(@"Stockholm Interbank Offered Rate.")]
    STIBOR,

    /// <summary>
    /// Australian Financial Markets Association (AFMA) Bank-Bill Reference Rate (BBSW).
    /// Encoded/decoded by serializers as &quot;BBSW&quot;.
    /// </summary>
    [EnumMember(Value = "BBSW")]
    [IsoId("_FFBTfjNnEe2UWZuK9pqFtg")]
    [Description(
        @"Australian Financial Markets Association (AFMA) Bank-Bill Reference Rate (BBSW)."
    )]
    BBSW,

    /// <summary>
    /// Johannesburg Interbank Agreed Rate.
    /// Encoded/decoded by serializers as &quot;JIBA&quot;.
    /// </summary>
    [EnumMember(Value = "JIBA")]
    [IsoId("_FFBTijNnEe2UWZuK9pqFtg")]
    [Description(@"Johannesburg Interbank Agreed Rate.")]
    JIBAR,

    /// <summary>
    /// Budapest Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;BUBO&quot;.
    /// </summary>
    [EnumMember(Value = "BUBO")]
    [IsoId("_FFBTgjNnEe2UWZuK9pqFtg")]
    [Description(@"Budapest Interbank Offered Rate.")]
    BUBOR,

    /// <summary>
    /// Canadian Dollar Offered Rate.
    /// Encoded/decoded by serializers as &quot;CDOR&quot;.
    /// </summary>
    [EnumMember(Value = "CDOR")]
    [IsoId("_FFB6aTNnEe2UWZuK9pqFtg")]
    [Description(@"Canadian Dollar Offered Rate.")]
    CDOR,

    /// <summary>
    /// Copenhagen Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;CIBO&quot;.
    /// </summary>
    [EnumMember(Value = "CIBO")]
    [IsoId("_FFBTgTNnEe2UWZuK9pqFtg")]
    [Description(@"Copenhagen Interbank Offered Rate.")]
    CIBOR,

    /// <summary>
    /// Moscow Prime Offered Rate.
    /// Encoded/decoded by serializers as &quot;MOSP&quot;.
    /// </summary>
    [EnumMember(Value = "MOSP")]
    [IsoId("_FFB6YjNnEe2UWZuK9pqFtg")]
    [Description(@"Moscow Prime Offered Rate.")]
    MOSPRIM,

    /// <summary>
    /// Norwegian Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;NIBO&quot;.
    /// </summary>
    [EnumMember(Value = "NIBO")]
    [IsoId("_FFBThDNnEe2UWZuK9pqFtg")]
    [Description(@"Norwegian Interbank Offered Rate.")]
    NIBOR,

    /// <summary>
    /// Czech Fixing of Interest Rates on Interbank Deposits.
    /// Encoded/decoded by serializers as &quot;PRBO&quot;.
    /// </summary>
    [EnumMember(Value = "PRBO")]
    [IsoId("_FFBTfDNnEe2UWZuK9pqFtg")]
    [Description(@"Czech Fixing of Interest Rates on Interbank Deposits.")]
    PRIBOR,

    /// <summary>
    /// Tel Aviv Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;TLBO&quot;.
    /// </summary>
    [EnumMember(Value = "TLBO")]
    [IsoId("_FFBTiDNnEe2UWZuK9pqFtg")]
    [Description(@"Tel Aviv Interbank Offered Rate.")]
    TELBOR,

    /// <summary>
    /// Warsaw Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;WIBO&quot;.
    /// </summary>
    [EnumMember(Value = "WIBO")]
    [IsoId("_FFBTiTNnEe2UWZuK9pqFtg")]
    [Description(@"Warsaw Interbank Offered Rate.")]
    WIBOR,

    /// <summary>
    /// Euro Short Term Rate
    /// Encoded/decoded by serializers as &quot;ESTR&quot;.
    /// </summary>
    [EnumMember(Value = "ESTR")]
    [IsoId("_FFBTejNnEe2UWZuK9pqFtg")]
    [Description(@"Euro Short Term Rate")]
    ESTER,

    /// <summary>
    /// Secured Overnight Financing Rate.
    /// Encoded/decoded by serializers as &quot;SOFR&quot;.
    /// </summary>
    [EnumMember(Value = "SOFR")]
    [IsoId("_FFBTfzNnEe2UWZuK9pqFtg")]
    [Description(@"Secured Overnight Financing Rate.")]
    SOFR,

    /// <summary>
    /// Sterling Over Night Index Average.
    /// Encoded/decoded by serializers as &quot;SONA&quot;.
    /// </summary>
    [EnumMember(Value = "SONA")]
    [IsoId("_FFB6bDNnEe2UWZuK9pqFtg")]
    [Description(@"Sterling Over Night Index Average.")]
    SONIA,

    /// <summary>
    /// RBA Cash Rate Target  (RBATCTR).
    /// Encoded/decoded by serializers as &quot;RCTR&quot;.
    /// </summary>
    [EnumMember(Value = "RCTR")]
    [IsoId("_FFBTgzNnEe2UWZuK9pqFtg")]
    [Description(@"RBA Cash Rate Target  (RBATCTR).")]
    RBATCTR,

    /// <summary>
    /// Canadian Overnight Repo Rate Average (CAONREPO).
    /// Encoded/decoded by serializers as &quot;CORA&quot;.
    /// </summary>
    [EnumMember(Value = "CORA")]
    [IsoId("_FFB6aDNnEe2UWZuK9pqFtg")]
    [Description(@"Canadian Overnight Repo Rate Average (CAONREPO). ")]
    CORRA,

    /// <summary>
    /// Bank of Canada Overnight Lending Rate (CABROVER).
    /// Encoded/decoded by serializers as &quot;BCOL&quot;.
    /// </summary>
    [EnumMember(Value = "BCOL")]
    [IsoId("_FFB6YzNnEe2UWZuK9pqFtg")]
    [Description(@"Bank of Canada Overnight Lending Rate (CABROVER).")]
    CABROVER,

    /// <summary>
    /// Hong Kong Interbank Offered Rate (HIHD01M).
    /// Encoded/decoded by serializers as &quot;HKIO&quot;.
    /// </summary>
    [EnumMember(Value = "HKIO")]
    [IsoId("_FFB6ZTNnEe2UWZuK9pqFtg")]
    [Description(@"Hong Kong Interbank Offered Rate (HIHD01M).")]
    HIBOR,

    /// <summary>
    /// Bank of Japan Uncollateralized Overnight Call Rate (MUTSCALM).
    /// Encoded/decoded by serializers as &quot;BJUO&quot;.
    /// </summary>
    [EnumMember(Value = "BJUO")]
    [IsoId("_FFB6ZzNnEe2UWZuK9pqFtg")]
    [Description(@"Bank of Japan Uncollateralized Overnight Call Rate (MUTSCALM).")]
    MUTSCALM,

    /// <summary>
    /// Euroyen Tokyo Interbank Offered Rate (EUYN03M).
    /// Encoded/decoded by serializers as &quot;ETIO&quot;.
    /// </summary>
    [EnumMember(Value = "ETIO")]
    [IsoId("_FFB6ajNnEe2UWZuK9pqFtg")]
    [Description(@"Euroyen Tokyo Interbank Offered Rate (EUYN03M).")]
    JBATIBOR,

    /// <summary>
    /// Effective Federal Funds Rate (FEDL01).
    /// Encoded/decoded by serializers as &quot;EFFR&quot;.
    /// </summary>
    [EnumMember(Value = "EFFR")]
    [IsoId("_FFB6bTNnEe2UWZuK9pqFtg")]
    [Description(@"Effective Federal Funds Rate (FEDL01).")]
    FEDL01,

    /// <summary>
    /// Overnight Bank Funding Rate (OBFR01).
    /// Encoded/decoded by serializers as &quot;OBFR&quot;.
    /// </summary>
    [EnumMember(Value = "OBFR")]
    [IsoId("_FFB6YDNnEe2UWZuK9pqFtg")]
    [Description(@"Overnight Bank Funding Rate (OBFR01).")]
    OBFR01,

    /// <summary>
    /// Czech National Bank Reference Interest Rate
    /// Encoded/decoded by serializers as &quot;CZNA&quot;.
    /// </summary>
    [EnumMember(Value = "CZNA")]
    [IsoId("_FFBTfTNnEe2UWZuK9pqFtg")]
    [Description(@"Czech National Bank Reference Interest Rate")]
    Czeonia,

    /// <summary>
    /// Tokyo Overnight Average Rate:
    /// Interest rate benchmark - also known as a reference rate or a benchmark rate. It is a measure of the cost of borrowing in the Japanese yen unsecured overnight money market and is the near risk-free rate (RFR) for Japanese yen markets, administered and published by the Bank of Japan. It is sometimes referred to as “TONAR”.
    /// Encoded/decoded by serializers as &quot;TONA&quot;.
    /// </summary>
    [EnumMember(Value = "TONA")]
    [IsoId("_xwyAsDOhEe2AEsHTM-bt1w")]
    [Description(
        @"Tokyo Overnight Average Rate:|Interest rate benchmark - also known as a reference rate or a benchmark rate. It is a measure of the cost of borrowing in the Japanese yen unsecured overnight money market and is the near risk-free rate (RFR) for Japanese yen markets, administered and published by the Bank of Japan. It is sometimes referred to as “TONAR”."
    )]
    TONA,

    /// <summary>
    /// Tokyo Term Risk Free Rate:
    /// Interest rate Benchmark based on the uncollateralized overnight call rate which involves almost no credit risk of financial institutions, based on the Japanese Yen &quot;Risk-Free-Rate&quot; (RFR), administered and published by QUICK Benchmarks, Inc.
    /// Encoded/decoded by serializers as &quot;TORF&quot;.
    /// </summary>
    [EnumMember(Value = "TORF")]
    [IsoId("_8odU4DOhEe2AEsHTM-bt1w")]
    [Description(
        @"Tokyo Term Risk Free Rate:|Interest rate Benchmark based on the uncollateralized overnight call rate which involves almost no credit risk of financial institutions, based on the Japanese Yen ""Risk-Free-Rate"" (RFR), administered and published by QUICK Benchmarks, Inc."
    )]
    TORF,

    /// <summary>
    /// Singapore Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;SIBO&quot;.
    /// </summary>
    [EnumMember(Value = "SIBO")]
    [IsoId("_S8SzQXC_Ee2QDe42vpiOiA")]
    [Description(@"Singapore Interbank Offered Rate.|")]
    SIBOR,

    /// <summary>
    /// Singapore Overnight Rate Average
    /// Encoded/decoded by serializers as &quot;SORA&quot;.
    /// </summary>
    [EnumMember(Value = "SORA")]
    [IsoId("_V_8KcXC_Ee2QDe42vpiOiA")]
    [Description(@"Singapore Overnight Rate Average")]
    SORA,

    /// <summary>
    /// Singapore Dollar Swap Offer Rate.
    /// Encoded/decoded by serializers as &quot;SSOR&quot;.
    /// </summary>
    [EnumMember(Value = "SSOR")]
    [IsoId("_j5TcEHDBEe2dGpElQLuRLQ")]
    [Description(@"Singapore Dollar Swap Offer Rate.")]
    SOR,
}
