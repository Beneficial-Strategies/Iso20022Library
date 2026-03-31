// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of product or financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_apBLINp-Ed-ak6NoX_4Aeg_335334060")]
[Description(@"Specifies the type of product or financial instrument.")]
[Derivations(typeof(FinancialInstrumentProductType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FinancialInstrumentProductTypeCode>))]
#endif
public enum FinancialInstrumentProductTypeCode
{
    /// <summary>
    /// Business loan, usually fixed or variable, for an extended term of up to 10 years. A term loan generally provides an agreed upon payment schedule with the amounts paid not able to be re-borrowed.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_apBLIdp-Ed-ak6NoX_4Aeg_335334068")]
    [Description(
        @"Business loan, usually fixed or variable, for an extended term of up to 10 years. A term loan generally provides an agreed upon payment schedule with the amounts paid not able to be re-borrowed."
    )]
    TermLoan,

    /// <summary>
    /// Loan that allows the borrower to borrow, repay and re-borrow, as needed over the life of the loan facility.
    /// Encoded/decoded by serializers as &quot;RVLV&quot;.
    /// </summary>
    [EnumMember(Value = "RVLV")]
    [IsoId("_apBLItp-Ed-ak6NoX_4Aeg_335334069")]
    [Description(
        @"Loan that allows the borrower to borrow, repay and re-borrow, as needed over the life of the loan facility."
    )]
    RevolverLoan,

    /// <summary>
    /// Outstanding loan amount in a revolving loan facility that may fluctuate on a daily basis. A revolver allows the borrower to borrow, repay, and re-borrow as needed over the life of the loan.
    /// Encoded/decoded by serializers as &quot;RTLV&quot;.
    /// </summary>
    [EnumMember(Value = "RTLV")]
    [IsoId("_apBLI9p-Ed-ak6NoX_4Aeg_335334070")]
    [Description(
        @"Outstanding loan amount in a revolving loan facility that may fluctuate on a daily basis. A revolver allows the borrower to borrow, repay, and re-borrow as needed over the life of the loan."
    )]
    RevolverTermLoan,

    /// <summary>
    /// Interim financing used to solidify a position until permanent financing is secured. It is also called a swing loan.
    /// Encoded/decoded by serializers as &quot;BRID&quot;.
    /// </summary>
    [EnumMember(Value = "BRID")]
    [IsoId("_apBLJNp-Ed-ak6NoX_4Aeg_335334071")]
    [Description(
        @"Interim financing used to solidify a position until permanent financing is secured. It is also called a swing loan."
    )]
    BridgeLoan,

    /// <summary>
    /// Instrument issued by a bank substituting its name and credit standing for that of its customer. A letter of credit is a written undertaking of the bank, issued for the account of a customer (the applicant), to honour a demand for payment, upon the beneficiary&apos;s compliance with the terms and conditions set forth in the undertaking.
    /// Encoded/decoded by serializers as &quot;LOFC&quot;.
    /// </summary>
    [EnumMember(Value = "LOFC")]
    [IsoId("_apBLJdp-Ed-ak6NoX_4Aeg_335334072")]
    [Description(
        @"Instrument issued by a bank substituting its name and credit standing for that of its customer. A letter of credit is a written undertaking of the bank, issued for the account of a customer (the applicant), to honour a demand for payment, upon the beneficiary's compliance with the terms and conditions set forth in the undertaking."
    )]
    LetterOfCredit,

    /// <summary>
    /// Credit facility allowing a borrower to bridge time gaps that might occur due to switching the loan from domestic borrowing to international borrowing (or vice versa), or switching the type of loan.
    /// Encoded/decoded by serializers as &quot;SWIN&quot;.
    /// </summary>
    [EnumMember(Value = "SWIN")]
    [IsoId("_apBLJtp-Ed-ak6NoX_4Aeg_335334073")]
    [Description(
        @"Credit facility allowing a borrower to bridge time gaps that might occur due to switching the loan from domestic borrowing to international borrowing (or vice versa), or switching the type of loan."
    )]
    SwingLineFacilityLoan,

    /// <summary>
    /// Firm that continues to operate under the Chapter 11 bankruptcy policy.
    /// Encoded/decoded by serializers as &quot;DINP&quot;.
    /// </summary>
    [EnumMember(Value = "DINP")]
    [IsoId("_apBLJ9p-Ed-ak6NoX_4Aeg_335334082")]
    [Description(@"Firm that continues to operate under the Chapter 11 bankruptcy policy.")]
    DebtorInPossession,

    /// <summary>
    /// Failure to make timely payments of interest or principal on a debt security.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_apK8INp-Ed-ak6NoX_4Aeg_335334083")]
    [Description(@"Failure to make timely payments of interest or principal on a debt security.")]
    DefaultedLoan,

    /// <summary>
    /// Loan that is disbursed against a security.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_apK8Idp-Ed-ak6NoX_4Aeg_335334084")]
    [Description(@"Loan that is disbursed against a security.")]
    WithdrawnLoan,

    /// <summary>
    /// Loan that has been paid or replaced by a new loan.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_apK8Itp-Ed-ak6NoX_4Aeg_335334085")]
    [Description(@"Loan that has been paid or replaced by a new loan.")]
    ReplacedLoan,

    /// <summary>
    /// Outstanding debt instrument that has reached final maturity and can no longer earn interest.
    /// Encoded/decoded by serializers as &quot;MATU&quot;.
    /// </summary>
    [EnumMember(Value = "MATU")]
    [IsoId("_apK8I9p-Ed-ak6NoX_4Aeg_335334086")]
    [Description(
        @"Outstanding debt instrument that has reached final maturity and can no longer earn interest."
    )]
    MaturedLoan,

    /// <summary>
    /// Loan agreement that results in a new loan after the restructuring of an existing loan.
    /// Encoded/decoded by serializers as &quot;AMEN&quot;.
    /// </summary>
    [EnumMember(Value = "AMEN")]
    [IsoId("_apK8JNp-Ed-ak6NoX_4Aeg_335334087")]
    [Description(
        @"Loan agreement that results in a new loan after the restructuring of an existing loan."
    )]
    AmendedRestatedLoan,

    /// <summary>
    /// Loan that is no longer performing.
    /// Encoded/decoded by serializers as &quot;RETR&quot;.
    /// </summary>
    [EnumMember(Value = "RETR")]
    [IsoId("_apK8Jdp-Ed-ak6NoX_4Aeg_335334088")]
    [Description(@"Loan that is no longer performing.")]
    RetiredLoan,

    /// <summary>
    /// Series of sovereign bonds issued by several developing countries in exchange for their rescheduled bank loans. A brady bond is defaulted emerging market debt that is traded at a discount.
    /// Encoded/decoded by serializers as &quot;BRAD&quot;.
    /// </summary>
    [EnumMember(Value = "BRAD")]
    [IsoId("_apK8Jtp-Ed-ak6NoX_4Aeg_335334089")]
    [Description(
        @"Series of sovereign bonds issued by several developing countries in exchange for their rescheduled bank loans. A brady bond is defaulted emerging market debt that is traded at a discount."
    )]
    BradyBond,

    /// <summary>
    /// Security that pays a fixed rate of interest every six months until maturity, when the investor receives payment for the par value of the security. Treasury notes mature in more than a year, but no more than 10 years from the issue date.
    /// Encoded/decoded by serializers as &quot;TBON&quot;.
    /// </summary>
    [EnumMember(Value = "TBON")]
    [IsoId("_apK8J9p-Ed-ak6NoX_4Aeg_335334090")]
    [Description(
        @"Security that pays a fixed rate of interest every six months until maturity, when the investor receives payment for the par value of the security. Treasury notes mature in more than a year, but no more than 10 years from the issue date."
    )]
    USTreasuryBond,

    /// <summary>
    /// Separate Trading of Registered Interest and Principal of Securities. STRIPS are also called zero-coupon securities, because the only time an investor receives a payment during the life of a STRIP is when it matures. The STRIPS program lets investors hold and trade the individual interest.
    /// Encoded/decoded by serializers as &quot;TINT&quot;.
    /// </summary>
    [EnumMember(Value = "TINT")]
    [IsoId("_apK8KNp-Ed-ak6NoX_4Aeg_335334091")]
    [Description(
        @"Separate Trading of Registered Interest and Principal of Securities. STRIPS are also called zero-coupon securities, because the only time an investor receives a payment during the life of a STRIP is when it matures. The STRIPS program lets investors hold and trade the individual interest."
    )]
    STRIPS,

    /// <summary>
    /// 5, 10, or 30 year US Treasuries for which the interest rate, set at auction, remains fixed throughout the term of the security. The principal amount of the security is adjusted for inflation, though the inflation adjusted principal will not be paid until maturity.
    /// Encoded/decoded by serializers as &quot;TIPS&quot;.
    /// </summary>
    [EnumMember(Value = "TIPS")]
    [IsoId("_apUGENp-Ed-ak6NoX_4Aeg_335334099")]
    [Description(
        @"5, 10, or 30 year US Treasuries for which the interest rate, set at auction, remains fixed throughout the term of the security. The principal amount of the security is adjusted for inflation, though the inflation adjusted principal will not be paid until maturity."
    )]
    TreasuryInflationProtectedSecurity,

    /// <summary>
    /// Principal strip portion of a bond with a call provision.
    /// Encoded/decoded by serializers as &quot;TCAL&quot;.
    /// </summary>
    [EnumMember(Value = "TCAL")]
    [IsoId("_apUGEdp-Ed-ak6NoX_4Aeg_335334100")]
    [Description(@"Principal strip portion of a bond with a call provision.")]
    PrincipalStripCallableBond,

    /// <summary>
    /// Principal strip of a bullet bond.
    /// Encoded/decoded by serializers as &quot;TPRN&quot;.
    /// </summary>
    [EnumMember(Value = "TPRN")]
    [IsoId("_apUGEtp-Ed-ak6NoX_4Aeg_335334101")]
    [Description(@"Principal strip of a bullet bond.")]
    PrincipalStripNonCallableBond,

    /// <summary>
    /// Bonds that mature more than 10 years from their issue date.
    /// Encoded/decoded by serializers as &quot;USTN&quot;.
    /// </summary>
    [EnumMember(Value = "USTN")]
    [IsoId("_apUGE9p-Ed-ak6NoX_4Aeg_335334102")]
    [Description(@"Bonds that mature more than 10 years from their issue date.")]
    USTreasuryNote,

    /// <summary>
    /// Short-term securities that mature in one year or less from their issue date, and are sold at a price less than their par (face) value. A US Treasury Bill is also called a T-Bill.
    /// Encoded/decoded by serializers as &quot;USTB&quot;.
    /// </summary>
    [EnumMember(Value = "USTB")]
    [IsoId("_apUGFNp-Ed-ak6NoX_4Aeg_335334103")]
    [Description(
        @"Short-term securities that mature in one year or less from their issue date, and are sold at a price less than their par (face) value. A US Treasury Bill is also called a T-Bill."
    )]
    USTreasuryBill,

    /// <summary>
    /// Units representing equity ownership in a public company. Common stock also gives the holder voting rights, profits via dividends or capital appreciation.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_apUGFdp-Ed-ak6NoX_4Aeg_335334104")]
    [Description(
        @"Units representing equity ownership in a public company. Common stock also gives the holder voting rights, profits via dividends or capital appreciation."
    )]
    CommonStock,

    /// <summary>
    /// Class of capital stock that pays dividends at a specific rate and has preference over common stock in divident payments and asset liquidation. Preferred stock does not usually carry voting rights. It has the characteristics of both common stock and debt.
    /// Encoded/decoded by serializers as &quot;PREF&quot;.
    /// </summary>
    [EnumMember(Value = "PREF")]
    [IsoId("_apUGFtp-Ed-ak6NoX_4Aeg_335334113")]
    [Description(
        @"Class of capital stock that pays dividends at a specific rate and has preference over common stock in divident payments and asset liquidation. Preferred stock does not usually carry voting rights. It has the characteristics of both common stock and debt."
    )]
    PreferredStock,

    /// <summary>
    /// No security type specified.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_apUGF9p-Ed-ak6NoX_4Aeg_335334114")]
    [Description(@"No security type specified.")]
    NoSecurityType,

    /// <summary>
    /// Investment fund operated by an investment company. Mutual funds are pools of money that are managed by an investment company.
    /// Encoded/decoded by serializers as &quot;MFUN&quot;.
    /// </summary>
    [EnumMember(Value = "MFUN")]
    [IsoId("_apUGGNp-Ed-ak6NoX_4Aeg_335334115")]
    [Description(
        @"Investment fund operated by an investment company. Mutual funds are pools of money that are managed by an investment company."
    )]
    MutualFund,

    /// <summary>
    /// Derivative security or strategy where the &quot;deal&quot; is composed of constituent securities, yet are to be thought of as one deal or transaction, eg, bond swap, straddle or strangle. A more common asset, which is multileg by definition, is a currency or an interest rate swap. Some deals can have more than one leg, eg, a butterfly spread.
    /// Encoded/decoded by serializers as &quot;MLEG&quot;.
    /// </summary>
    [EnumMember(Value = "MLEG")]
    [IsoId("_apUGGdp-Ed-ak6NoX_4Aeg_335334116")]
    [Description(
        @"Derivative security or strategy where the ""deal"" is composed of constituent securities, yet are to be thought of as one deal or transaction, eg, bond swap, straddle or strangle. A more common asset, which is multileg by definition, is a currency or an interest rate swap. Some deals can have more than one leg, eg, a butterfly spread."
    )]
    MultiLeg,

    /// <summary>
    /// Legally binding agreement to buy or sell a commodity, eg, foreign currency, or financial instrument in a designated future month at a price agreed upon today by the buyer and seller.
    /// Encoded/decoded by serializers as &quot;FXCO&quot;.
    /// </summary>
    [EnumMember(Value = "FXCO")]
    [IsoId("_apd3ENp-Ed-ak6NoX_4Aeg_335334117")]
    [Description(
        @"Legally binding agreement to buy or sell a commodity, eg, foreign currency, or financial instrument in a designated future month at a price agreed upon today by the buyer and seller."
    )]
    ForeignExchangeContract,

    /// <summary>
    /// Anticipation note other than Tax Anticipation Notes or Revenue Anticipation Notes, eg, grants and education notes.
    /// Encoded/decoded by serializers as &quot;ANNO&quot;.
    /// </summary>
    [EnumMember(Value = "ANNO")]
    [IsoId("_apd3Edp-Ed-ak6NoX_4Aeg_335334118")]
    [Description(
        @"Anticipation note other than Tax Anticipation Notes or Revenue Anticipation Notes, eg, grants and education notes."
    )]
    OtherAnticipationNote,

    /// <summary>
    /// Long-term debt issued by a city.
    /// Encoded/decoded by serializers as &quot;COFO&quot;.
    /// </summary>
    [EnumMember(Value = "COFO")]
    [IsoId("_apd3Etp-Ed-ak6NoX_4Aeg_335334119")]
    [Description(@"Long-term debt issued by a city.")]
    CertificateOfObligation,

    /// <summary>
    /// Structure where investors buy certificates that entitle them to receive a participation or share in the lease payments from a particular project. The lease payments are passed through the lessor to the certificate holders with the tax advantages intact. The lessor typically assigns the lease and lease payments to a trustee, then distributes the lease payments to the certificate holders.
    /// Encoded/decoded by serializers as &quot;COFP&quot;.
    /// </summary>
    [EnumMember(Value = "COFP")]
    [IsoId("_apd3E9p-Ed-ak6NoX_4Aeg_335334120")]
    [Description(
        @"Structure where investors buy certificates that entitle them to receive a participation or share in the lease payments from a particular project. The lease payments are passed through the lessor to the certificate holders with the tax advantages intact. The lessor typically assigns the lease and lease payments to a trustee, then distributes the lease payments to the certificate holders."
    )]
    CertificateOfParticipation,

    /// <summary>
    /// Municipal securities secured by the issuer&apos;s pledge of its full faith, credit, and taxing power.
    /// Encoded/decoded by serializers as &quot;GOBO&quot;.
    /// </summary>
    [EnumMember(Value = "GOBO")]
    [IsoId("_apd3FNp-Ed-ak6NoX_4Aeg_335334121")]
    [Description(
        @"Municipal securities secured by the issuer's pledge of its full faith, credit, and taxing power."
    )]
    GeneralObligationBond,

    /// <summary>
    /// Sinking fund feature.
    /// Encoded/decoded by serializers as &quot;MTEN&quot;.
    /// </summary>
    [EnumMember(Value = "MTEN")]
    [IsoId("_apd3Fdp-Ed-ak6NoX_4Aeg_335334122")]
    [Description(@"Sinking fund feature.")]
    MandatoryTender,

    /// <summary>
    /// Financial instruments issued in anticipation of other sources of future revenue, other than taxes. This may include intergovernmental aid. The interest is usually tax-free to the security holder.
    /// Encoded/decoded by serializers as &quot;RANO&quot;.
    /// </summary>
    [EnumMember(Value = "RANO")]
    [IsoId("_apd3Ftp-Ed-ak6NoX_4Aeg_335334130")]
    [Description(
        @"Financial instruments issued in anticipation of other sources of future revenue, other than taxes. This may include intergovernmental aid. The interest is usually tax-free to the security holder."
    )]
    RevenueAnticipationNote,

    /// <summary>
    /// Bond issued by a municipality to finance either a project or an enterprise. The issuer pledges to the bondholders that the debt service is payable solely by the revenues generated by the operation of the projects financed, a category of facilities, or from another non-tax source.
    /// Encoded/decoded by serializers as &quot;REVB&quot;.
    /// </summary>
    [EnumMember(Value = "REVB")]
    [IsoId("_apd3F9p-Ed-ak6NoX_4Aeg_335334131")]
    [Description(
        @"Bond issued by a municipality to finance either a project or an enterprise. The issuer pledges to the bondholders that the debt service is payable solely by the revenues generated by the operation of the projects financed, a category of facilities, or from another non-tax source."
    )]
    RevenueBond,

    /// <summary>
    /// Municipal bond with interest paid by the taxes of the community benefiting from the bond funded project.
    /// Encoded/decoded by serializers as &quot;SPCA&quot;.
    /// </summary>
    [EnumMember(Value = "SPCA")]
    [IsoId("_apd3GNp-Ed-ak6NoX_4Aeg_335334132")]
    [Description(
        @"Municipal bond with interest paid by the taxes of the community benefiting from the bond funded project."
    )]
    SpecialAssessmentMunicipalBond,

    /// <summary>
    /// Municipal bond with interest paid by the taxes of the community benefiting from the bond funded project.
    /// Encoded/decoded by serializers as &quot;SPCO&quot;.
    /// </summary>
    [EnumMember(Value = "SPCO")]
    [IsoId("_apd3Gdp-Ed-ak6NoX_4Aeg_335334133")]
    [Description(
        @"Municipal bond with interest paid by the taxes of the community benefiting from the bond funded project."
    )]
    SpecialObligation,

    /// <summary>
    /// Bond secured by a special tax, eg, gasoline tax or other excise tax.
    /// Encoded/decoded by serializers as &quot;SPCT&quot;.
    /// </summary>
    [EnumMember(Value = "SPCT")]
    [IsoId("_apnBANp-Ed-ak6NoX_4Aeg_335334134")]
    [Description(@"Bond secured by a special tax, eg, gasoline tax or other excise tax.")]
    SpecialTax,

    /// <summary>
    /// Notes issued by states or municipalities to finance current operations in anticipation of future tax receipts.
    /// Encoded/decoded by serializers as &quot;TANO&quot;.
    /// </summary>
    [EnumMember(Value = "TANO")]
    [IsoId("_apnBAdp-Ed-ak6NoX_4Aeg_335334135")]
    [Description(
        @"Notes issued by states or municipalities to finance current operations in anticipation of future tax receipts."
    )]
    TaxAnticipationNote,

    /// <summary>
    /// Notes payable with a collection of taxes earmarked for repayment of the notes.
    /// Encoded/decoded by serializers as &quot;TAXA&quot;.
    /// </summary>
    [EnumMember(Value = "TAXA")]
    [IsoId("_apnBAtp-Ed-ak6NoX_4Aeg_335334144")]
    [Description(@"Notes payable with a collection of taxes earmarked for repayment of the notes.")]
    TaxAllocation,

    /// <summary>
    /// Short-term promissory note issued for periods of up to 270 days, often used in lieu of Tax Anticipation Notes and Revenue Anticipation Notes because of the greater flexibility offered in setting both maturities and determining rates. A bond usually issued by municipal, county or state governments whose interest payments are not subject to federal and, in some cases, state and local income tax.
    /// Encoded/decoded by serializers as &quot;TECP&quot;.
    /// </summary>
    [EnumMember(Value = "TECP")]
    [IsoId("_apnBA9p-Ed-ak6NoX_4Aeg_335334145")]
    [Description(
        @"Short-term promissory note issued for periods of up to 270 days, often used in lieu of Tax Anticipation Notes and Revenue Anticipation Notes because of the greater flexibility offered in setting both maturities and determining rates. A bond usually issued by municipal, county or state governments whose interest payments are not subject to federal and, in some cases, state and local income tax."
    )]
    TaxExemptCommercialPaper,

    /// <summary>
    /// Notes that are issued by states or municipalities to finance current operations in anticipation of future tax receipts or other expected revenues.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_apnBBNp-Ed-ak6NoX_4Aeg_335334146")]
    [Description(
        @"Notes that are issued by states or municipalities to finance current operations in anticipation of future tax receipts or other expected revenues."
    )]
    TaxRevenueAnticipationNote,

    /// <summary>
    /// Bond that bears interest at a variable or floating rate established at specified intervals, eg, flexible or monthly. A variable rate demand note contains a put option permitting the bondholder to tender the bond for purchase when a new interest rate is established.
    /// Encoded/decoded by serializers as &quot;VRDN&quot;.
    /// </summary>
    [EnumMember(Value = "VRDN")]
    [IsoId("_apnBBdp-Ed-ak6NoX_4Aeg_335334147")]
    [Description(
        @"Bond that bears interest at a variable or floating rate established at specified intervals, eg, flexible or monthly. A variable rate demand note contains a put option permitting the bondholder to tender the bond for purchase when a new interest rate is established."
    )]
    VariableRateDemandNote,

    /// <summary>
    /// The right to buy a specified amount of shares at a pre-determined price and time. A warrant is similar to call options, but much longer time spans can extend to warrants that are offered by corporations, while exchange-traded call options are not.
    /// Encoded/decoded by serializers as &quot;WARR&quot;.
    /// </summary>
    [EnumMember(Value = "WARR")]
    [IsoId("_apnBBtp-Ed-ak6NoX_4Aeg_335334148")]
    [Description(
        @"The right to buy a specified amount of shares at a pre-determined price and time. A warrant is similar to call options, but much longer time spans can extend to warrants that are offered by corporations, while exchange-traded call options are not."
    )]
    Warrant,

    /// <summary>
    /// Collection of mortgages that have been securitised. The shares or participation certificates in the pool are sold to investors called mortgage pass-throughs. In order to securitise loans and attenuate risk in the mortgage market, a security is created when one or more mortgage holders form a collection pool of mortgages and sells shares or participation certificates in the pool. The cash flow from the collateral pool is &quot;passed through&quot; to the security holder as monthly payments of principal, interest and pre-payments.||.||.||.
    /// Encoded/decoded by serializers as &quot;APOL&quot;.
    /// </summary>
    [EnumMember(Value = "APOL")]
    [IsoId("_apnBB9p-Ed-ak6NoX_4Aeg_335334149")]
    [Description(
        @"Collection of mortgages that have been securitised. The shares or participation certificates in the pool are sold to investors called mortgage pass-throughs. In order to securitise loans and attenuate risk in the mortgage market, a security is created when one or more mortgage holders form a collection pool of mortgages and sells shares or participation certificates in the pool. The cash flow from the collateral pool is ""passed through"" to the security holder as monthly payments of principal, interest and pre-payments.||.||.||."
    )]
    AgencyPool,

    /// <summary>
    /// Bond that is collateralised by loans, leases or installment contracts on personal property, but not real estate. Asset backed bonds are usually receivables such as credit card receivables, home-equity loans, manufactured homes loans and automobile loans.
    /// Encoded/decoded by serializers as &quot;ABBO&quot;.
    /// </summary>
    [EnumMember(Value = "ABBO")]
    [IsoId("_apnBCNp-Ed-ak6NoX_4Aeg_335334150")]
    [Description(
        @"Bond that is collateralised by loans, leases or installment contracts on personal property, but not real estate. Asset backed bonds are usually receivables such as credit card receivables, home-equity loans, manufactured homes loans and automobile loans."
    )]
    AssetBackedBond,

    /// <summary>
    /// Security backed by a pool of pass-throughs or a pool of mortgage loans.
    /// Encoded/decoded by serializers as &quot;CMOS&quot;.
    /// </summary>
    [EnumMember(Value = "CMOS")]
    [IsoId("_apwyANp-Ed-ak6NoX_4Aeg_335334151")]
    [Description(@"Security backed by a pool of pass-throughs or a pool of mortgage loans.")]
    CollateralisedMortgageSecurity,

    /// <summary>
    /// Mortgage backed security whose cash flows are backed by major property mortgages, eg, office space, retail property or hotels. Corporate mortgage backed securities are also called commercial mortgage-backed securities.
    /// Encoded/decoded by serializers as &quot;CMBS&quot;.
    /// </summary>
    [EnumMember(Value = "CMBS")]
    [IsoId("_apwyAdp-Ed-ak6NoX_4Aeg_335334152")]
    [Description(
        @"Mortgage backed security whose cash flows are backed by major property mortgages, eg, office space, retail property or hotels. Corporate mortgage backed securities are also called commercial mortgage-backed securities."
    )]
    CorporateMortgageBackedSecurity,

    /// <summary>
    /// Interest only (IO) tranche in a collateralized mortgage obligation (CMO).
    /// Encoded/decoded by serializers as &quot;IETM&quot;.
    /// </summary>
    [EnumMember(Value = "IETM")]
    [IsoId("_apwyAtp-Ed-ak6NoX_4Aeg_335334153")]
    [Description(@"Interest only (IO) tranche in a collateralized mortgage obligation (CMO).")]
    IOETTEMortgage,

    /// <summary>
    /// Instrument whose cash flow depends on the cash flows of an underlying pool of mortgages. Mortgage backed securities are usually residential mortgages.
    /// Encoded/decoded by serializers as &quot;MOBS&quot;.
    /// </summary>
    [EnumMember(Value = "MOBS")]
    [IsoId("_apwyA9p-Ed-ak6NoX_4Aeg_335334161")]
    [Description(
        @"Instrument whose cash flow depends on the cash flows of an underlying pool of mortgages. Mortgage backed securities are usually residential mortgages."
    )]
    MortgageBackedSecurity,

    /// <summary>
    /// Security whose cash flow is from the interest payments of the underlying collateral, and is based solely on the interest component from a pool of mortgages or other bonds. When the principal on the mortgages or bonds has been repaid, interest payments stop and the value of the interest only (IO) falls to zero.
    /// Encoded/decoded by serializers as &quot;MOIO&quot;.
    /// </summary>
    [EnumMember(Value = "MOIO")]
    [IsoId("_apwyBNp-Ed-ak6NoX_4Aeg_335334162")]
    [Description(
        @"Security whose cash flow is from the interest payments of the underlying collateral, and is based solely on the interest component from a pool of mortgages or other bonds. When the principal on the mortgages or bonds has been repaid, interest payments stop and the value of the interest only (IO) falls to zero."
    )]
    MortgageInterestOnly,

    /// <summary>
    /// Security whose cash flow is from the principal payments of the underlying collateral. Mortgage principal only is a mortgage backed security (MBS) where the holder receives only principal cash flows on the underlying mortgage pool. All the principal distribution due from the underlying collateral pool is paid to the registered holder of the stripped MBS on the basis of the current face value of the underlying collateral pool.
    /// Encoded/decoded by serializers as &quot;MOPO&quot;.
    /// </summary>
    [EnumMember(Value = "MOPO")]
    [IsoId("_apwyBdp-Ed-ak6NoX_4Aeg_335334163")]
    [Description(
        @"Security whose cash flow is from the principal payments of the underlying collateral. Mortgage principal only is a mortgage backed security (MBS) where the holder receives only principal cash flows on the underlying mortgage pool. All the principal distribution due from the underlying collateral pool is paid to the registered holder of the stripped MBS on the basis of the current face value of the underlying collateral pool."
    )]
    MortgagePrincipalOnly,

    /// <summary>
    /// Contract between a lender and a property owner that provides a loan defining the property as collateral. A mortgage private placement involves the issuance of a security to a group of no more than 35 investors.
    /// Encoded/decoded by serializers as &quot;MPRP&quot;.
    /// </summary>
    [EnumMember(Value = "MPRP")]
    [IsoId("_apwyBtp-Ed-ak6NoX_4Aeg_335334164")]
    [Description(
        @"Contract between a lender and a property owner that provides a loan defining the property as collateral. A mortgage private placement involves the issuance of a security to a group of no more than 35 investors."
    )]
    MortgagePrivatePlacement,

    /// <summary>
    /// Security created when one or more mortgage holders form a collection (pool) of mortgages and sell shares or participation certificates in the pool. The cash flow from the collateral pool is &quot;passed through&quot; to the security holder as monthly payments of principal, interest, and prepayments. A miscellaneous pass through is also called a passthrough.
    /// Encoded/decoded by serializers as &quot;MIPT&quot;.
    /// </summary>
    [EnumMember(Value = "MIPT")]
    [IsoId("_apwyB9p-Ed-ak6NoX_4Aeg_335334165")]
    [Description(
        @"Security created when one or more mortgage holders form a collection (pool) of mortgages and sell shares or participation certificates in the pool. The cash flow from the collateral pool is ""passed through"" to the security holder as monthly payments of principal, interest, and prepayments. A miscellaneous pass through is also called a passthrough."
    )]
    MiscellaneousPassThrough,

    /// <summary>
    /// Contract for the purchase or sale of a mortgage backed security to be delivered at an agreed-upon future date. A To Be Announced (TBA) Mortgage does not include a specified pool number, number of pools or the precise amount to be delivered.
    /// Encoded/decoded by serializers as &quot;TOBA&quot;.
    /// </summary>
    [EnumMember(Value = "TOBA")]
    [IsoId("_apwyCNp-Ed-ak6NoX_4Aeg_335334166")]
    [Description(
        @"Contract for the purchase or sale of a mortgage backed security to be delivered at an agreed-upon future date. A To Be Announced (TBA) Mortgage does not include a specified pool number, number of pools or the precise amount to be delivered."
    )]
    ToBeAnnouncedMortgage,

    /// <summary>
    /// Fixed income coupon security issued by a federal agency, eg, the Tennessee Valley Authority, or a government sponsored enterprise, eg, FreddieMac.
    /// Encoded/decoded by serializers as &quot;FEAC&quot;.
    /// </summary>
    [EnumMember(Value = "FEAC")]
    [IsoId("_apwyCdp-Ed-ak6NoX_4Aeg_335334175")]
    [Description(
        @"Fixed income coupon security issued by a federal agency, eg, the Tennessee Valley Authority, or a government sponsored enterprise, eg, FreddieMac."
    )]
    FederalAgencyCoupon,

    /// <summary>
    /// Fixed income discounted notes issued by a federal agency, eg, the Tennessee Valley Authority, or a government-sponsored enterprise, eg, FreddieMac. Discount notes are unsecured general corporate obligations that are issued at a discount and mature at par. Agency discount notes give institutional and retail investors convenient choices with regard to the investment date, maturity date and size of their short-term investments. Maturities of discount notes can range from overnight through one year.
    /// Encoded/decoded by serializers as &quot;FEAD&quot;.
    /// </summary>
    [EnumMember(Value = "FEAD")]
    [IsoId("_ap6jANp-Ed-ak6NoX_4Aeg_335334176")]
    [Description(
        @"Fixed income discounted notes issued by a federal agency, eg, the Tennessee Valley Authority, or a government-sponsored enterprise, eg, FreddieMac. Discount notes are unsecured general corporate obligations that are issued at a discount and mature at par. Agency discount notes give institutional and retail investors convenient choices with regard to the investment date, maturity date and size of their short-term investments. Maturities of discount notes can range from overnight through one year."
    )]
    FederalAgencyDiscountNote,

    /// <summary>
    /// Private capital for financing the export of big ticket items by U.S. firms. Private export funding is done by purchasing the medium to long-term debt of importers of U.S. products at fixed interest rates.
    /// Encoded/decoded by serializers as &quot;PRIV&quot;.
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_ap6jAdp-Ed-ak6NoX_4Aeg_335334177")]
    [Description(
        @"Private capital for financing the export of big ticket items by U.S. firms. Private export funding is done by purchasing the medium to long-term debt of importers of U.S. products at fixed interest rates."
    )]
    PrivateExportFunding,

    /// <summary>
    /// Time draft drawn upon and accepted by a bank, as well as the customary means of effecting payment for merchandise sold in import-export transactions. A Bankers Acceptance is a source of financing used extensively in international trade. With the credit strength of a bank behind it, the banker&apos;s acceptance usually qualifies as a money market instrument. The liability assumed by the bank is called its acceptance liability.
    /// Encoded/decoded by serializers as &quot;BAAP&quot;.
    /// </summary>
    [EnumMember(Value = "BAAP")]
    [IsoId("_ap6jAtp-Ed-ak6NoX_4Aeg_335334178")]
    [Description(
        @"Time draft drawn upon and accepted by a bank, as well as the customary means of effecting payment for merchandise sold in import-export transactions. A Bankers Acceptance is a source of financing used extensively in international trade. With the credit strength of a bank behind it, the banker's acceptance usually qualifies as a money market instrument. The liability assumed by the bank is called its acceptance liability."
    )]
    BankersAcceptance,

    /// <summary>
    /// Securities that are exempt from registration under section 3(a)2 of the Securities Act 1933, and that have characteristics in common with certificates of deposit (CDs), medium term notes (MTNs) and short-term bonds.
    /// Encoded/decoded by serializers as &quot;BANT&quot;.
    /// </summary>
    [EnumMember(Value = "BANT")]
    [IsoId("_ap6jA9p-Ed-ak6NoX_4Aeg_335334179")]
    [Description(
        @"Securities that are exempt from registration under section 3(a)2 of the Securities Act 1933, and that have characteristics in common with certificates of deposit (CDs), medium term notes (MTNs) and short-term bonds."
    )]
    BankNote,

    /// <summary>
    /// Written order from one party (the drawer) to another (the drawee) to pay a specified sum upon demand, or on a specified date, to the drawer or to a third party specified by the drawer. A bill of exchange is also called a draft.
    /// Encoded/decoded by serializers as &quot;BIOX&quot;.
    /// </summary>
    [EnumMember(Value = "BIOX")]
    [IsoId("_ap6jBNp-Ed-ak6NoX_4Aeg_335334180")]
    [Description(
        @"Written order from one party (the drawer) to another (the drawee) to pay a specified sum upon demand, or on a specified date, to the drawer or to a third party specified by the drawer. A bill of exchange is also called a draft."
    )]
    BillOfExchange,

    /// <summary>
    /// Certificate issued by a bank or thrift that indicates a specified sum of money deposited. The certificate has a maturity date and a specified interest rate.
    /// Encoded/decoded by serializers as &quot;CEOD&quot;.
    /// </summary>
    [EnumMember(Value = "CEOD")]
    [IsoId("_ap6jBdp-Ed-ak6NoX_4Aeg_335334181")]
    [Description(
        @"Certificate issued by a bank or thrift that indicates a specified sum of money deposited. The certificate has a maturity date and a specified interest rate."
    )]
    CertificateOfDeposit,

    /// <summary>
    /// Loan repayable on demand. A call loan is also known as a broker loan.
    /// Encoded/decoded by serializers as &quot;CALN&quot;.
    /// </summary>
    [EnumMember(Value = "CALN")]
    [IsoId("_ap6jBtp-Ed-ak6NoX_4Aeg_335334182")]
    [Description(@"Loan repayable on demand. A call loan is also known as a broker loan.")]
    CallLoan,

    /// <summary>
    /// Short-term, unsecured promissory note issued by a corporation. The maturity is typically less than 270 days, with a most common maturity range of 30 to 50 days or less. Commercial paper is usually issued at a discount, though some are interest-bearing.
    /// Encoded/decoded by serializers as &quot;COPR&quot;.
    /// </summary>
    [EnumMember(Value = "COPR")]
    [IsoId("_ap6jB9p-Ed-ak6NoX_4Aeg_335334183")]
    [Description(
        @"Short-term, unsecured promissory note issued by a corporation. The maturity is typically less than 270 days, with a most common maturity range of 30 to 50 days or less. Commercial paper is usually issued at a discount, though some are interest-bearing."
    )]
    CommercialPaper,

    /// <summary>
    /// Savings instrument issued by banks with a fixed interest rate, usually paid on a monthly basis, and a fixed maturity date. A deposit note has an optional call provision and is insured by the Federal Deposit Insurance Corporation (for U.S). It is sometimes called a Certificate of Deposit (CD).
    /// Encoded/decoded by serializers as &quot;DENT&quot;.
    /// </summary>
    [EnumMember(Value = "DENT")]
    [IsoId("_ap6jCNp-Ed-ak6NoX_4Aeg_335334184")]
    [Description(
        @"Savings instrument issued by banks with a fixed interest rate, usually paid on a monthly basis, and a fixed maturity date. A deposit note has an optional call provision and is insured by the Federal Deposit Insurance Corporation (for U.S). It is sometimes called a Certificate of Deposit (CD)."
    )]
    DepositNote,

    /// <summary>
    /// Note that is easily and cheaply converted to cash, ie, cash itself and short-term products.
    /// Encoded/decoded by serializers as &quot;LINT&quot;.
    /// </summary>
    [EnumMember(Value = "LINT")]
    [IsoId("_ap6jCdp-Ed-ak6NoX_4Aeg_335334192")]
    [Description(
        @"Note that is easily and cheaply converted to cash, ie, cash itself and short-term products."
    )]
    LiquidityNote,

    /// <summary>
    /// Highly flexible debt instruments that can be easily structured in response to changing market conditions and investor tastes. The maturity ranges from 9 months to 30 years or more. Medium term notes are typically non-callable, unsecured senior debt with fixed-coupon rates that carry an investment grade credit rating. It is also a corporate debt instrument that is continuously offered to investors over a period of time by an agent of the issuer.
    /// Encoded/decoded by serializers as &quot;METN&quot;.
    /// </summary>
    [EnumMember(Value = "METN")]
    [IsoId("_aqDs8Np-Ed-ak6NoX_4Aeg_335334193")]
    [Description(
        @"Highly flexible debt instruments that can be easily structured in response to changing market conditions and investor tastes. The maturity ranges from 9 months to 30 years or more. Medium term notes are typically non-callable, unsecured senior debt with fixed-coupon rates that carry an investment grade credit rating. It is also a corporate debt instrument that is continuously offered to investors over a period of time by an agent of the issuer."
    )]
    MediumTermNote,

    /// <summary>
    /// Unsecured, offshore Eurodollar used by corporations for depositing cash flows overnight, usually deposited to a branch of a domestic bank. An overnight deposit is a facility to place short-term surplus funds with a bank, (generally central banks), at the end of the day while earning interest. The rate provides the floor for short-term money market rates. Due to a large minimum, banks offer overnight deposits primarily to large clients.
    /// Encoded/decoded by serializers as &quot;OVNT&quot;.
    /// </summary>
    [EnumMember(Value = "OVNT")]
    [IsoId("_aqDs8dp-Ed-ak6NoX_4Aeg_335334194")]
    [Description(
        @"Unsecured, offshore Eurodollar used by corporations for depositing cash flows overnight, usually deposited to a branch of a domestic bank. An overnight deposit is a facility to place short-term surplus funds with a bank, (generally central banks), at the end of the day while earning interest. The rate provides the floor for short-term money market rates. Due to a large minimum, banks offer overnight deposits primarily to large clients."
    )]
    OvernightDeposit,

    /// <summary>
    /// Written promise committing the maker to pay the payee a specified sum of money either on demand, or at a fixed determinable future date, with or without interest. The instruments meeting this criteria are negotiable.
    /// Encoded/decoded by serializers as &quot;PRNT&quot;.
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_aqDs8tp-Ed-ak6NoX_4Aeg_335334195")]
    [Description(
        @"Written promise committing the maker to pay the payee a specified sum of money either on demand, or at a fixed determinable future date, with or without interest. The instruments meeting this criteria are negotiable."
    )]
    PromissoryNote,

    /// <summary>
    /// Agreement with a commitment by the seller (dealer) to buy a security back from the purchaser (customer) at a specified price and a designated future date. A repurchase agreement, or repo, represents a collateralised short-term loan where the collateral may be a treasury security, money market instrument, federal agency security or a mortgage-backed security.
    /// Encoded/decoded by serializers as &quot;REAM&quot;.
    /// </summary>
    [EnumMember(Value = "REAM")]
    [IsoId("_aqDs89p-Ed-ak6NoX_4Aeg_335334196")]
    [Description(
        @"Agreement with a commitment by the seller (dealer) to buy a security back from the purchaser (customer) at a specified price and a designated future date. A repurchase agreement, or repo, represents a collateralised short-term loan where the collateral may be a treasury security, money market instrument, federal agency security or a mortgage-backed security."
    )]
    RepurchaseAgreement,

    /// <summary>
    /// Similar to a repurchase agreement, with the exception that it is from the purchaser&apos;s (customer&apos;s) perspective. Reverse repos offer the holders of fixed income securities a means of temporarily absorbing reserves by selling securities under an agreement to subsequently repurchase them. It offers the customer of the transaction the security as collateral to the loan.
    /// Encoded/decoded by serializers as &quot;RERA&quot;.
    /// </summary>
    [EnumMember(Value = "RERA")]
    [IsoId("_aqDs9Np-Ed-ak6NoX_4Aeg_335334197")]
    [Description(
        @"Similar to a repurchase agreement, with the exception that it is from the purchaser's (customer's) perspective. Reverse repos offer the holders of fixed income securities a means of temporarily absorbing reserves by selling securities under an agreement to subsequently repurchase them. It offers the customer of the transaction the security as collateral to the loan."
    )]
    ReverseRepurchaseAgreement,

    /// <summary>
    /// Note with a term that is usually less than a year, but can be as long as two years.
    /// Encoded/decoded by serializers as &quot;SHTN&quot;.
    /// </summary>
    [EnumMember(Value = "SHTN")]
    [IsoId("_aqDs9dp-Ed-ak6NoX_4Aeg_335334206")]
    [Description(
        @"Note with a term that is usually less than a year, but can be as long as two years."
    )]
    ShortTermLoanNote,

    /// <summary>
    /// Loan that accrues interest for a pre-set time, eg, a bank savings account or Certificate of Deposit (CD). Money is invested for a fixed period and earns an attractive return. A time deposit is usually offered with a range of investment amounts, maturities, and interest payment dates.
    /// Encoded/decoded by serializers as &quot;TIDE&quot;.
    /// </summary>
    [EnumMember(Value = "TIDE")]
    [IsoId("_aqDs9tp-Ed-ak6NoX_4Aeg_335334207")]
    [Description(
        @"Loan that accrues interest for a pre-set time, eg, a bank savings account or Certificate of Deposit (CD). Money is invested for a fixed period and earns an attractive return. A time deposit is usually offered with a range of investment amounts, maturities, and interest payment dates."
    )]
    TimeDeposit,

    /// <summary>
    /// Unsecured commitment issued by a corporation to finance its short-term credit needs, with maturity dates being as short as two days and extending to a year. Extended commercial notes (CNs) are those with maturity dates extending beyond the committed dates.
    /// Encoded/decoded by serializers as &quot;EXCN&quot;.
    /// </summary>
    [EnumMember(Value = "EXCN")]
    [IsoId("_aqDs99p-Ed-ak6NoX_4Aeg_335334208")]
    [Description(
        @"Unsecured commitment issued by a corporation to finance its short-term credit needs, with maturity dates being as short as two days and extending to a year. Extended commercial notes (CNs) are those with maturity dates extending beyond the committed dates."
    )]
    ExtendedCommercialNote,

    /// <summary>
    /// Debt obligations issued by private corporations.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_aqDs-Np-Ed-ak6NoX_4Aeg_335334209")]
    [Description(@"Debt obligations issued by private corporations.")]
    CorporateBond,

    /// <summary>
    /// Sale of bonds directly to an institutional investor, eg, an insurance company. Securities are purchased for investment, and are not to be resold to the public.
    /// Encoded/decoded by serializers as &quot;CPPE&quot;.
    /// </summary>
    [EnumMember(Value = "CPPE")]
    [IsoId("_aqNd8Np-Ed-ak6NoX_4Aeg_335334210")]
    [Description(
        @"Sale of bonds directly to an institutional investor, eg, an insurance company. Securities are purchased for investment, and are not to be resold to the public."
    )]
    CorporatePrivatePlacement,

    /// <summary>
    /// Bond that can be exchanged for specified amounts of common stock in the issuing firm. The conversion process cannot be reversed, and the conversion details are described in the bond&apos;s indenture.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_aqNd8dp-Ed-ak6NoX_4Aeg_335334211")]
    [Description(
        @"Bond that can be exchanged for specified amounts of common stock in the issuing firm. The conversion process cannot be reversed, and the conversion details are described in the bond's indenture."
    )]
    ConvertibleBond,

    /// <summary>
    /// Eurobonds that pay coupon interest in one currency and principal in a different currency.
    /// Encoded/decoded by serializers as &quot;DUAL&quot;.
    /// </summary>
    [EnumMember(Value = "DUAL")]
    [IsoId("_aqNd8tp-Ed-ak6NoX_4Aeg_335334212")]
    [Description(
        @"Eurobonds that pay coupon interest in one currency and principal in a different currency."
    )]
    DualCurrencyBond,

    /// <summary>
    /// Bond issue that is inflation-indexed, whereas coupon payments are timed to an inflation index. Indexed linked corporate bond is a product whose valuation or cash flows is a function of an index, eg, sovereign bonds such as U.S. Treasuries or U.K. Gilts, whose coupon rate is adjusted periodically as a function of an inflation index.
    /// Encoded/decoded by serializers as &quot;XLIN&quot;.
    /// </summary>
    [EnumMember(Value = "XLIN")]
    [IsoId("_aqNd89p-Ed-ak6NoX_4Aeg_335334213")]
    [Description(
        @"Bond issue that is inflation-indexed, whereas coupon payments are timed to an inflation index. Indexed linked corporate bond is a product whose valuation or cash flows is a function of an index, eg, sovereign bonds such as U.S. Treasuries or U.K. Gilts, whose coupon rate is adjusted periodically as a function of an inflation index."
    )]
    IndexedLinkedCorporateBond,

    /// <summary>
    /// Note with an embedded derivative, eg, a synthetic-fixed rate note created by issuing a floating rate note while entering into a &quot;plain vanilla&quot; interest rate swap to offset the floating rate payments.
    /// Encoded/decoded by serializers as &quot;STRU&quot;.
    /// </summary>
    [EnumMember(Value = "STRU")]
    [IsoId("_aqNd9Np-Ed-ak6NoX_4Aeg_335334214")]
    [Description(
        @"Note with an embedded derivative, eg, a synthetic-fixed rate note created by issuing a floating rate note while entering into a ""plain vanilla"" interest rate swap to offset the floating rate payments."
    )]
    StructuredNote,

    /// <summary>
    /// Dollar denominated bonds issued in the U.S. by foreign corporations, banks, and sovereigns that are sold in the U.S. market, eg, bonds issued by originators with roots in Japan are called Samurai bonds.
    /// Encoded/decoded by serializers as &quot;YANK&quot;.
    /// </summary>
    [EnumMember(Value = "YANK")]
    [IsoId("_aqNd9dp-Ed-ak6NoX_4Aeg_335334215")]
    [Description(
        @"Dollar denominated bonds issued in the U.S. by foreign corporations, banks, and sovereigns that are sold in the U.S. market, eg, bonds issued by originators with roots in Japan are called Samurai bonds."
    )]
    YankeeCorporateBond,

    /// <summary>
    /// Debt instrument issued by a financial institution which has a maturity of no more than one year, is either interest-bearing or discounted and is backed by some form of collateral.
    /// Encoded/decoded by serializers as &quot;ABCP&quot;.
    /// </summary>
    [EnumMember(Value = "ABCP")]
    [IsoId("_yFzv4Lw1EeSv87Gr1rLbvg")]
    [Description(
        @"Debt instrument issued by a financial institution which has a maturity of no more than one year, is either interest-bearing or discounted and is backed by some form of collateral."
    )]
    AssetBackedCommercialPaper,

    /// <summary>
    /// Debt instrument in which the periodic interest payments are calculated on the basis of the value (fixing of an underlying reference rate such as the Euribor) on predefined dates (fixing dates) and which has a maturity of no more tha one year.
    /// Encoded/decoded by serializers as &quot;FRNT&quot;.
    /// </summary>
    [EnumMember(Value = "FRNT")]
    [IsoId("_5QVc4Lw1EeSv87Gr1rLbvg")]
    [Description(
        @"Debt instrument in which the periodic interest payments are calculated on the basis of the value (fixing of an underlying reference rate such as the Euribor) on predefined dates (fixing dates) and which has a maturity of no more tha one year."
    )]
    FloatingRateNote,

    /// <summary>
    /// Other short term debt securities issued.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_eWMVMLw2EeSv87Gr1rLbvg")]
    [Description(@"Other short term debt securities issued.")]
    OtherShortTermDebtSecurities,

    /// <summary>
    /// Cash account with a notice period to withdraw money and that gives rise to interest payments or calculations at regular intervals, and daily change of the applicable rate.
    /// Encoded/decoded by serializers as &quot;CACM&quot;.
    /// </summary>
    [EnumMember(Value = "CACM")]
    [IsoId("_xpB30Lw2EeSv87Gr1rLbvg")]
    [Description(
        @"Cash account with a notice period to withdraw money and that gives rise to interest payments or calculations at regular intervals, and daily change of the applicable rate."
    )]
    CallAccountCallMoney,

    /// <summary>
    /// Unsecured interest-bearing deposit that is either redeemable at notice or has a maturity of no more than one year, that is 397 days after the settlement date, and which is either taken (borrowing) or placed (lending) by the agent.
    /// Encoded/decoded by serializers as &quot;DPST&quot;.
    /// </summary>
    [EnumMember(Value = "DPST")]
    [IsoId("_H23uAPl3EeSaUu1MjG4T0Q")]
    [Description(
        @"Unsecured interest-bearing deposit that is either redeemable at notice or has a maturity of no more than one year, that is 397 days after the settlement date, and which is either taken (borrowing) or placed (lending) by the agent."
    )]
    Deposit,
}
