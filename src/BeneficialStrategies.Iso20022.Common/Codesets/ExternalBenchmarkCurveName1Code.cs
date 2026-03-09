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
[IsoId("_ZJ3hsDNnEe2UWZuK9pqFtg")]
[Description(@"Specifies the external benchmark curve name code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalBenchmarkCurveNameCode))]
public enum ExternalBenchmarkCurveName1Code
{
    /// <summary>
    /// Benchmark curve used for municipals based on the best credit rating for municipal market debt.
    /// Encoded/decoded by serializers as &quot;MAAA&quot;.
    /// </summary>
    [EnumMember(Value = "MAAA")]
    [IsoId("_ZK4OUTNnEe2UWZuK9pqFtg")]
    [Description(@"Benchmark curve used for municipals based on the best credit rating for municipal market debt.")]
    MuniAAA = ExternalBenchmarkCurveNameCode.MuniAAA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Portion of a synthetic curve that is composed of Eurodollar or Treasury or similar Futures and Swap rates. The term usually begins at 3 months to 2 years for the futures strip component with the Swaps filling in the points to 10 years and beyond.
    /// Encoded/decoded by serializers as &quot;FUSW&quot;.
    /// </summary>
    [EnumMember(Value = "FUSW")]
    [IsoId("_ZK4OUzNnEe2UWZuK9pqFtg")]
    [Description(@"Portion of a synthetic curve that is composed of Eurodollar or Treasury or similar Futures and Swap rates. The term usually begins at 3 months to 2 years for the futures strip component with the Swaps filling in the points to 10 years and beyond.")]
    FutureSWAP = ExternalBenchmarkCurveNameCode.FutureSWAP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate at which major international banks are willing to take deposits from one another, is normally 1/8 percent below LIBOR.
    /// London InterBank Bid Rate, the rate bid by banks on Eurocurrency deposits; the international rate that banks lend to other banks.
    /// Encoded/decoded by serializers as &quot;LIBI&quot;.
    /// </summary>
    [EnumMember(Value = "LIBI")]
    [IsoId("_ZK4OVTNnEe2UWZuK9pqFtg")]
    [Description(@"Rate at which major international banks are willing to take deposits from one another, is normally 1/8 percent below LIBOR.||London InterBank Bid Rate, the rate bid by banks on Eurocurrency deposits; the international rate that banks lend to other banks.")]
    LIBID = ExternalBenchmarkCurveNameCode.LIBID, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// London Interbank Offered Rate, the interest rate that major international banks in London charge each other for borrowing.
    /// Encoded/decoded by serializers as &quot;LIBO&quot;.
    /// </summary>
    [EnumMember(Value = "LIBO")]
    [IsoId("_ZK4OVzNnEe2UWZuK9pqFtg")]
    [Description(@"London Interbank Offered Rate, the interest rate that major international banks in London charge each other for borrowing.")]
    LIBOR = ExternalBenchmarkCurveNameCode.LIBOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In curve construction, Swap is the long portion of the curve constituting about 3 years to 30 years term.||The exchange of one security, currency or interest rate for another to change the maturity (bonds), or quality of issues (stocks or bonds), or because investment objectives have changed.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_ZK4OWTNnEe2UWZuK9pqFtg")]
    [Description(@"In curve construction, Swap is the long portion of the curve constituting about 3 years to 30 years term.||The exchange of one security, currency or interest rate for another to change the maturity (bonds), or quality of issues (stocks or bonds), or because investment objectives have changed.")]
    SWAP = ExternalBenchmarkCurveNameCode.SWAP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Treasury benchmark that comes in three types: the yield curve, the par curve, and the spot curve. All curves also have a constituent time series.
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_ZK4OWzNnEe2UWZuK9pqFtg")]
    [Description(@"Treasury benchmark that comes in three types: the yield curve, the par curve, and the spot curve. All curves also have a constituent time series.")]
    Treasury = ExternalBenchmarkCurveNameCode.Treasury, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Euro Interbank Offer Rate is the rate at which Euro inter-bank term deposits within the Euro zone are offered by one prime bank to another prime bank.
    /// Encoded/decoded by serializers as &quot;EURI&quot;.
    /// </summary>
    [EnumMember(Value = "EURI")]
    [IsoId("_ZK4OXTNnEe2UWZuK9pqFtg")]
    [Description(@"Euro Interbank Offer Rate is the rate at which Euro inter-bank term deposits within the Euro zone are offered by one prime bank to another prime bank.")]
    Euribor = ExternalBenchmarkCurveNameCode.Euribor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pfandbriefe security is a collateralised bullet bond backed by either mortgage loans or loans to the public sector. Pfandbriefe differ from traditional asset-backed securities in significant ways. The most important difference is that Pfandbriefe carry no pre-payment risk since they remain on the balance sheet of the issuing institution. Therefore, their spreads over sovereign bonds are attributable to liquidity and credit quality alone. New indices have been created and existing indices have been modified in response to the growing importance of the Pfandbriefe market. The Deutsche Borse has three synthetic indices called REX, JEX, and PEX. The Pfandbriefe curve is used as a reference for credit as well as mortgage market.
    /// Encoded/decoded by serializers as &quot;PFAN&quot;.
    /// </summary>
    [EnumMember(Value = "PFAN")]
    [IsoId("_ZK4OXzNnEe2UWZuK9pqFtg")]
    [Description(@"Pfandbriefe security is a collateralised bullet bond backed by either mortgage loans or loans to the public sector. Pfandbriefe differ from traditional asset-backed securities in significant ways. The most important difference is that Pfandbriefe carry no pre-payment risk since they remain on the balance sheet of the issuing institution. Therefore, their spreads over sovereign bonds are attributable to liquidity and credit quality alone. New indices have been created and existing indices have been modified in response to the growing importance of the Pfandbriefe market. The Deutsche Borse has three synthetic indices called REX, JEX, and PEX. The Pfandbriefe curve is used as a reference for credit as well as mortgage market.")]
    Pfandbriefe = ExternalBenchmarkCurveNameCode.Pfandbriefe, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Euro OverNight Index Average rate.
    /// Encoded/decoded by serializers as &quot;EONA&quot;.
    /// </summary>
    [EnumMember(Value = "EONA")]
    [IsoId("_ZK4OYTNnEe2UWZuK9pqFtg")]
    [Description(@"Euro OverNight Index Average rate.")]
    EONIA = ExternalBenchmarkCurveNameCode.EONIA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Euro OverNight Index Average swap rate.
    /// Encoded/decoded by serializers as &quot;EONS&quot;.
    /// </summary>
    [EnumMember(Value = "EONS")]
    [IsoId("_ZK4OYzNnEe2UWZuK9pqFtg")]
    [Description(@"Euro OverNight Index Average swap rate.")]
    EONIASwaps = ExternalBenchmarkCurveNameCode.EONIASwaps, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate for the eurodollars, time deposits denominated in U.S. dollars at banks outside the United States, and thus are not under the jurisdiction of the Federal Reserve.
    /// Encoded/decoded by serializers as &quot;EUUS&quot;.
    /// </summary>
    [EnumMember(Value = "EUUS")]
    [IsoId("_ZK4OZTNnEe2UWZuK9pqFtg")]
    [Description(@"Rate for the eurodollars, time deposits denominated in U.S. dollars at banks outside the United States, and thus are not under the jurisdiction of the Federal Reserve.")]
    EURODOLLAR = ExternalBenchmarkCurveNameCode.EURODOLLAR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Swiss Franc LIBOR rate.
    /// Encoded/decoded by serializers as &quot;EUCH&quot;.
    /// </summary>
    [EnumMember(Value = "EUCH")]
    [IsoId("_ZK4OZzNnEe2UWZuK9pqFtg")]
    [Description(@"Swiss Franc LIBOR rate.")]
    EuroSwiss = ExternalBenchmarkCurveNameCode.EuroSwiss, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tokyo Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;TIBO&quot;.
    /// </summary>
    [EnumMember(Value = "TIBO")]
    [IsoId("_ZK4OaTNnEe2UWZuK9pqFtg")]
    [Description(@"Tokyo Interbank Offered Rate.")]
    TIBOR = ExternalBenchmarkCurveNameCode.TIBOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Worldwide common reference rate value for fixed interest rate swap rates, as defined by the International Swaps and Derivatives Association (ISDA).
    /// Encoded/decoded by serializers as &quot;ISDA&quot;.
    /// </summary>
    [EnumMember(Value = "ISDA")]
    [IsoId("_ZK4OazNnEe2UWZuK9pqFtg")]
    [Description(@"Worldwide common reference rate value for fixed interest rate swap rates, as defined by the International Swaps and Derivatives Association (ISDA).")]
    ISDAFIX = ExternalBenchmarkCurveNameCode.ISDAFIX, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// GCF Repo Index, the Depository Trust &amp; Clearing Corporation (DTCC) general collateral finance repurchase agreements index.
    /// Encoded/decoded by serializers as &quot;GCFR&quot;.
    /// </summary>
    [EnumMember(Value = "GCFR")]
    [IsoId("_ZK4ObTNnEe2UWZuK9pqFtg")]
    [Description(@"GCF Repo Index, the Depository Trust & Clearing Corporation (DTCC) general collateral finance repurchase agreements index.")]
    GCFRepo = ExternalBenchmarkCurveNameCode.GCFRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stockholm Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;STBO&quot;.
    /// </summary>
    [EnumMember(Value = "STBO")]
    [IsoId("_ZK4ObzNnEe2UWZuK9pqFtg")]
    [Description(@"Stockholm Interbank Offered Rate.")]
    STIBOR = ExternalBenchmarkCurveNameCode.STIBOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Australian Financial Markets Association (AFMA) Bank-Bill Reference Rate (BBSW).
    /// Encoded/decoded by serializers as &quot;BBSW&quot;.
    /// </summary>
    [EnumMember(Value = "BBSW")]
    [IsoId("_ZK4OcTNnEe2UWZuK9pqFtg")]
    [Description(@"Australian Financial Markets Association (AFMA) Bank-Bill Reference Rate (BBSW).")]
    BBSW = ExternalBenchmarkCurveNameCode.BBSW, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Johannesburg Interbank Agreed Rate.
    /// Encoded/decoded by serializers as &quot;JIBA&quot;.
    /// </summary>
    [EnumMember(Value = "JIBA")]
    [IsoId("_ZK4OczNnEe2UWZuK9pqFtg")]
    [Description(@"Johannesburg Interbank Agreed Rate.")]
    JIBAR = ExternalBenchmarkCurveNameCode.JIBAR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Budapest Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;BUBO&quot;.
    /// </summary>
    [EnumMember(Value = "BUBO")]
    [IsoId("_ZK4OdTNnEe2UWZuK9pqFtg")]
    [Description(@"Budapest Interbank Offered Rate.")]
    BUBOR = ExternalBenchmarkCurveNameCode.BUBOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Canadian Dollar Offered Rate.
    /// Encoded/decoded by serializers as &quot;CDOR&quot;.
    /// </summary>
    [EnumMember(Value = "CDOR")]
    [IsoId("_ZK4OdzNnEe2UWZuK9pqFtg")]
    [Description(@"Canadian Dollar Offered Rate.")]
    CDOR = ExternalBenchmarkCurveNameCode.CDOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Copenhagen Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;CIBO&quot;.
    /// </summary>
    [EnumMember(Value = "CIBO")]
    [IsoId("_ZK4OeTNnEe2UWZuK9pqFtg")]
    [Description(@"Copenhagen Interbank Offered Rate.")]
    CIBOR = ExternalBenchmarkCurveNameCode.CIBOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Moscow Prime Offered Rate.
    /// Encoded/decoded by serializers as &quot;MOSP&quot;.
    /// </summary>
    [EnumMember(Value = "MOSP")]
    [IsoId("_ZK4OezNnEe2UWZuK9pqFtg")]
    [Description(@"Moscow Prime Offered Rate.")]
    MOSPRIM = ExternalBenchmarkCurveNameCode.MOSPRIM, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Norwegian Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;NIBO&quot;.
    /// </summary>
    [EnumMember(Value = "NIBO")]
    [IsoId("_ZK4OfTNnEe2UWZuK9pqFtg")]
    [Description(@"Norwegian Interbank Offered Rate.")]
    NIBOR = ExternalBenchmarkCurveNameCode.NIBOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Czech Fixing of Interest Rates on Interbank Deposits.
    /// Encoded/decoded by serializers as &quot;PRBO&quot;.
    /// </summary>
    [EnumMember(Value = "PRBO")]
    [IsoId("_ZK4OfzNnEe2UWZuK9pqFtg")]
    [Description(@"Czech Fixing of Interest Rates on Interbank Deposits.")]
    PRIBOR = ExternalBenchmarkCurveNameCode.PRIBOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tel Aviv Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;TLBO&quot;.
    /// </summary>
    [EnumMember(Value = "TLBO")]
    [IsoId("_ZK4OgTNnEe2UWZuK9pqFtg")]
    [Description(@"Tel Aviv Interbank Offered Rate.")]
    TELBOR = ExternalBenchmarkCurveNameCode.TELBOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Warsaw Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;WIBO&quot;.
    /// </summary>
    [EnumMember(Value = "WIBO")]
    [IsoId("_ZK4OgzNnEe2UWZuK9pqFtg")]
    [Description(@"Warsaw Interbank Offered Rate.")]
    WIBOR = ExternalBenchmarkCurveNameCode.WIBOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Euro Short Term Rate
    /// Encoded/decoded by serializers as &quot;ESTR&quot;.
    /// </summary>
    [EnumMember(Value = "ESTR")]
    [IsoId("_ZK4OhTNnEe2UWZuK9pqFtg")]
    [Description(@"Euro Short Term Rate")]
    ESTER = ExternalBenchmarkCurveNameCode.ESTER, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Secured Overnight Financing Rate.
    /// Encoded/decoded by serializers as &quot;SOFR&quot;.
    /// </summary>
    [EnumMember(Value = "SOFR")]
    [IsoId("_ZK41YTNnEe2UWZuK9pqFtg")]
    [Description(@"Secured Overnight Financing Rate.")]
    SOFR = ExternalBenchmarkCurveNameCode.SOFR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sterling Over Night Index Average.
    /// Encoded/decoded by serializers as &quot;SONA&quot;.
    /// </summary>
    [EnumMember(Value = "SONA")]
    [IsoId("_ZK41YzNnEe2UWZuK9pqFtg")]
    [Description(@"Sterling Over Night Index Average.")]
    SONIA = ExternalBenchmarkCurveNameCode.SONIA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RBA Cash Rate Target  (RBATCTR).
    /// Encoded/decoded by serializers as &quot;RCTR&quot;.
    /// </summary>
    [EnumMember(Value = "RCTR")]
    [IsoId("_ZK41ZTNnEe2UWZuK9pqFtg")]
    [Description(@"RBA Cash Rate Target  (RBATCTR).")]
    RBATCTR = ExternalBenchmarkCurveNameCode.RBATCTR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Canadian Overnight Repo Rate Average (CAONREPO). 
    /// Encoded/decoded by serializers as &quot;CORA&quot;.
    /// </summary>
    [EnumMember(Value = "CORA")]
    [IsoId("_ZK41ZzNnEe2UWZuK9pqFtg")]
    [Description(@"Canadian Overnight Repo Rate Average (CAONREPO). ")]
    CORRA = ExternalBenchmarkCurveNameCode.CORRA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank of Canada Overnight Lending Rate (CABROVER).
    /// Encoded/decoded by serializers as &quot;BCOL&quot;.
    /// </summary>
    [EnumMember(Value = "BCOL")]
    [IsoId("_ZK41aTNnEe2UWZuK9pqFtg")]
    [Description(@"Bank of Canada Overnight Lending Rate (CABROVER).")]
    CABROVER = ExternalBenchmarkCurveNameCode.CABROVER, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Hong Kong Interbank Offered Rate (HIHD01M).
    /// Encoded/decoded by serializers as &quot;HKIO&quot;.
    /// </summary>
    [EnumMember(Value = "HKIO")]
    [IsoId("_ZK41azNnEe2UWZuK9pqFtg")]
    [Description(@"Hong Kong Interbank Offered Rate (HIHD01M).")]
    HIBOR = ExternalBenchmarkCurveNameCode.HIBOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank of Japan Uncollateralized Overnight Call Rate (MUTSCALM).
    /// Encoded/decoded by serializers as &quot;BJUO&quot;.
    /// </summary>
    [EnumMember(Value = "BJUO")]
    [IsoId("_ZK41bTNnEe2UWZuK9pqFtg")]
    [Description(@"Bank of Japan Uncollateralized Overnight Call Rate (MUTSCALM).")]
    MUTSCALM = ExternalBenchmarkCurveNameCode.MUTSCALM, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Euroyen Tokyo Interbank Offered Rate (EUYN03M).
    /// Encoded/decoded by serializers as &quot;ETIO&quot;.
    /// </summary>
    [EnumMember(Value = "ETIO")]
    [IsoId("_ZK41bzNnEe2UWZuK9pqFtg")]
    [Description(@"Euroyen Tokyo Interbank Offered Rate (EUYN03M).")]
    JBATIBOR = ExternalBenchmarkCurveNameCode.JBATIBOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Effective Federal Funds Rate (FEDL01).
    /// Encoded/decoded by serializers as &quot;EFFR&quot;.
    /// </summary>
    [EnumMember(Value = "EFFR")]
    [IsoId("_ZK41cTNnEe2UWZuK9pqFtg")]
    [Description(@"Effective Federal Funds Rate (FEDL01).")]
    FEDL01 = ExternalBenchmarkCurveNameCode.FEDL01, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Overnight Bank Funding Rate (OBFR01).
    /// Encoded/decoded by serializers as &quot;OBFR&quot;.
    /// </summary>
    [EnumMember(Value = "OBFR")]
    [IsoId("_ZK41czNnEe2UWZuK9pqFtg")]
    [Description(@"Overnight Bank Funding Rate (OBFR01).")]
    OBFR01 = ExternalBenchmarkCurveNameCode.OBFR01, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Czech National Bank Reference Interest Rate
    /// Encoded/decoded by serializers as &quot;CZNA&quot;.
    /// </summary>
    [EnumMember(Value = "CZNA")]
    [IsoId("_ZK41dTNnEe2UWZuK9pqFtg")]
    [Description(@"Czech National Bank Reference Interest Rate")]
    Czeonia = ExternalBenchmarkCurveNameCode.Czeonia, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tokyo Overnight Average Rate:
    /// Interest rate benchmark - also known as a reference rate or a benchmark rate. It is a measure of the cost of borrowing in the Japanese yen unsecured overnight money market and is the near risk-free rate (RFR) for Japanese yen markets, administered and published by the Bank of Japan. It is sometimes referred to as “TONAR”.
    /// Encoded/decoded by serializers as &quot;TONA&quot;.
    /// </summary>
    [EnumMember(Value = "TONA")]
    [IsoId("_xwzO0TOhEe2AEsHTM-bt1w")]
    [Description(@"Tokyo Overnight Average Rate:|Interest rate benchmark - also known as a reference rate or a benchmark rate. It is a measure of the cost of borrowing in the Japanese yen unsecured overnight money market and is the near risk-free rate (RFR) for Japanese yen markets, administered and published by the Bank of Japan. It is sometimes referred to as “TONAR”.")]
    TONA = ExternalBenchmarkCurveNameCode.TONA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tokyo Term Risk Free Rate:
    /// Interest rate Benchmark based on the uncollateralized overnight call rate which involves almost no credit risk of financial institutions, based on the Japanese Yen &quot;Risk-Free-Rate&quot; (RFR), administered and published by QUICK Benchmarks, Inc.
    /// Encoded/decoded by serializers as &quot;TORF&quot;.
    /// </summary>
    [EnumMember(Value = "TORF")]
    [IsoId("_8odU4jOhEe2AEsHTM-bt1w")]
    [Description(@"Tokyo Term Risk Free Rate:|Interest rate Benchmark based on the uncollateralized overnight call rate which involves almost no credit risk of financial institutions, based on the Japanese Yen ""Risk-Free-Rate"" (RFR), administered and published by QUICK Benchmarks, Inc.")]
    TORF = ExternalBenchmarkCurveNameCode.TORF, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Singapore Interbank Offered Rate.
    /// Encoded/decoded by serializers as &quot;SIBO&quot;.
    /// </summary>
    [EnumMember(Value = "SIBO")]
    [IsoId("_8hKqAnC-Ee2QDe42vpiOiA")]
    [Description(@"Singapore Interbank Offered Rate.|")]
    SIBOR = ExternalBenchmarkCurveNameCode.SIBOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Singapore Dollar Swap Offer Rate.
    /// Encoded/decoded by serializers as &quot;SSOR&quot;.
    /// </summary>
    [EnumMember(Value = "SSOR")]
    [IsoId("_14atAnDBEe2dGpElQLuRLQ")]
    [Description(@"Singapore Dollar Swap Offer Rate.")]
    SOR = ExternalBenchmarkCurveNameCode.SOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Singapore Overnight Rate Average
    /// Encoded/decoded by serializers as &quot;SORA&quot;.
    /// </summary>
    [EnumMember(Value = "SORA")]
    [IsoId("_14atA3DBEe2dGpElQLuRLQ")]
    [Description(@"Singapore Overnight Rate Average")]
    SORA = ExternalBenchmarkCurveNameCode.SORA, // same ordinal as derivation source for type conversions
    
}
