// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a securities account and its characteristics.
/// </summary>
[IsoId("_yf9dVyC6EeWPMvNwVtiMsA")]
[DisplayName("Investment Account")]
public record InvestmentAccount49
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_y8Y6iSC6EeWPMvNwVtiMsA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_y8Y6iyC6EeWPMvNwVtiMsA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_y8Y6jSC6EeWPMvNwVtiMsA")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; }

    /// <summary>
    /// Type of account.
    /// </summary>
    [IsoId("_y8Y6jyC6EeWPMvNwVtiMsA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public AccountType2Choice_? Type { get; init; }

    /// <summary>
    /// Ownership status of the account, for example, joint owners.
    /// </summary>
    [IsoId("_y8Y6kSC6EeWPMvNwVtiMsA")]
    [DisplayName("Ownership Type")]
    [IsoXmlTag("OwnrshTp")]
    public required OwnershipType2Choice_ OwnershipType { get; init; }

    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    [IsoId("_y8Y6kyC6EeWPMvNwVtiMsA")]
    [DisplayName("Tax Exemption")]
    [IsoXmlTag("TaxXmptn")]
    public TaxExemptionReason2Choice_? TaxExemption { get; init; }

    /// <summary>
    /// Frequency at which a statement is issued.
    /// </summary>
    [IsoId("_y8Y6lSC6EeWPMvNwVtiMsA")]
    [DisplayName("Statement Frequency")]
    [IsoXmlTag("StmtFrqcy")]
    public StatementFrequencyReason2Choice_? StatementFrequency { get; init; }

    /// <summary>
    /// Currency chosen for reporting purposes by the account owner in agreement with the account servicer.
    /// </summary>
    [IsoId("_y8Y6lyC6EeWPMvNwVtiMsA")]
    [DisplayName("Reference Currency")]
    [IsoXmlTag("RefCcy")]
    public ActiveCurrencyCode? ReferenceCurrency { get; init; }

    /// <summary>
    /// Language for all communication concerning the account.
    /// </summary>
    [IsoId("_y8Y6mSC6EeWPMvNwVtiMsA")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_y8Y6myC6EeWPMvNwVtiMsA")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference2Code? IncomePreference { get; init; }

    /// <summary>
    /// Specifies, for income on the fund or security that is to be reinvested, parameters for the reinvestment. If the reinvestment percentage is less than one hundred percent, the remaining percentage will be invested according to the investor’s or account owner&apos;s subsequent instructions.
    /// </summary>
    [IsoId("_y8Y6nSC6EeWPMvNwVtiMsA")]
    [DisplayName("Reinvestment Details")]
    [IsoXmlTag("RinvstmtDtls")]
    public Reinvestment2? ReinvestmentDetails { get; init; }

    /// <summary>
    /// Method by which the tax (withholding tax) is to be processed, that is, either withheld at source or tax information is reported to tax authorities or tax information is reported due to the provision of a tax certificate.
    /// </summary>
    [IsoId("_y8Y6nyC6EeWPMvNwVtiMsA")]
    [DisplayName("Tax Withholding Method")]
    [IsoXmlTag("TaxWhldgMtd")]
    public TaxWithholdingMethod3Code? TaxWithholdingMethod { get; init; }

    /// <summary>
    /// Details for the reporting of tax, for example, the country of taxation.
    /// </summary>
    [IsoId("_WgQXcSDCEeWPMvNwVtiMsA")]
    [DisplayName("Tax Reporting")]
    [IsoXmlTag("TaxRptg")]
    public TaxReporting1? TaxReporting { get; init; }

    /// <summary>
    /// Details of the letter of intent.
    /// </summary>
    [IsoId("_y8Y6oSC6EeWPMvNwVtiMsA")]
    [DisplayName("Letter Intent Details")]
    [IsoXmlTag("LttrInttDtls")]
    public LetterIntent1? LetterIntentDetails { get; init; }

    /// <summary>
    /// Reference of an accumulation rights program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_y8Y6oyC6EeWPMvNwVtiMsA")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccumulationRightReference { get; init; }

    /// <summary>
    /// Number of account owners or related parties required to authorise transactions on the account.
    /// </summary>
    [IsoId("_y8Y6pSC6EeWPMvNwVtiMsA")]
    [DisplayName("Required Signatories Number")]
    [IsoXmlTag("ReqrdSgntriesNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RequiredSignatoriesNumber { get; init; }

    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_y8Y6pyC6EeWPMvNwVtiMsA")]
    [DisplayName("Fund Family Name")]
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FundFamilyName { get; init; }

    /// <summary>
    /// Detailed information about the investment fund or security associated to the account.
    /// </summary>
    [IsoId("_y8Y6qSC6EeWPMvNwVtiMsA")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public FinancialInstrument51? FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Parameters to be applied on deal amount for orders when the amount is a fractional number.
    /// </summary>
    [IsoId("_y8Y6qyC6EeWPMvNwVtiMsA")]
    [DisplayName("Rounding Details")]
    [IsoXmlTag("RndgDtls")]
    public RoundingParameters1? RoundingDetails { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_y8Y6rSC6EeWPMvNwVtiMsA")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification70Choice_? AccountServicer { get; init; }

    /// <summary>
    /// Specifies the account is blocked and other factors for the blocked account.
    /// </summary>
    [IsoId("_y8Y6ryC6EeWPMvNwVtiMsA")]
    [DisplayName("Blocked Status")]
    [IsoXmlTag("BlckdSts")]
    public Blocked2? BlockedStatus { get; init; }

    /// <summary>
    /// Specifies the type of usage of the account.
    /// </summary>
    [IsoId("_y8Y6sSC6EeWPMvNwVtiMsA")]
    [DisplayName("Account Usage Type")]
    [IsoXmlTag("AcctUsgTp")]
    public AccountUsageType2Choice_? AccountUsageType { get; init; }

    /// <summary>
    /// Specifies if documentary evidence has been provided for the foreign resident.
    /// </summary>
    [IsoId("_y8Y6syC6EeWPMvNwVtiMsA")]
    [DisplayName("Foreign Status Certification")]
    [IsoXmlTag("FrgnStsCertfctn")]
    public Provided1Code? ForeignStatusCertification { get; init; }

    /// <summary>
    /// Date the investor or account owner signs the open account form.
    /// </summary>
    [IsoId("_y8Y6tSC6EeWPMvNwVtiMsA")]
    [DisplayName("Account Signature Date Time")]
    [IsoXmlTag("AcctSgntrDtTm")]
    public DateAndDateTimeChoice_? AccountSignatureDateTime { get; init; }

    /// <summary>
    /// Specifies the means by which the investor or account owner submits the open account form.
    /// </summary>
    [IsoId("_y8Y6tyC6EeWPMvNwVtiMsA")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; }

    /// <summary>
    /// Specifies the category of the account.
    /// </summary>
    [IsoId("_y8Y6uSC6EeWPMvNwVtiMsA")]
    [DisplayName("Investment Account Category")]
    [IsoXmlTag("InvstmtAcctCtgy")]
    public InvestmentAccountCategory1Choice_? InvestmentAccountCategory { get; init; }

    /// <summary>
    /// Specifies whether the holdings in the account are eligible for pledging.
    /// </summary>
    [IsoId("_Kv_D0yDBEeWPMvNwVtiMsA")]
    [DisplayName("Pledging")]
    [IsoXmlTag("Pldgg")]
    public Eligible1Code? Pledging { get; init; }

    /// <summary>
    /// Specifies whether the holdings in the account are used as collateral.
    /// </summary>
    [IsoId("_Kv_D1CDBEeWPMvNwVtiMsA")]
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public Collateral1Code? Collateral { get; init; }

    /// <summary>
    /// Details of third party rights.
    /// </summary>
    [IsoId("_Kv_D1SDBEeWPMvNwVtiMsA")]
    [DisplayName("Third Party Rights")]
    [IsoXmlTag("ThrdPtyRghts")]
    public ThirdPartyRights1? ThirdPartyRights { get; init; }

    /// <summary>
    /// Functionality permitted to a third party in the actions that may be taken on an account on behalf of the investor.
    /// </summary>
    [IsoId("_GfKc8CDDEeWPMvNwVtiMsA")]
    [DisplayName("Power Of Attorney Level Of Control")]
    [IsoXmlTag("PwrOfAttnyLvlOfCtrl")]
    public LevelOfControl1Choice_? PowerOfAttorneyLevelOfControl { get; init; }

    /// <summary>
    /// Specifies if the account is regarded as domestic or non-domestic for reporting purposes.
    /// </summary>
    [IsoId("_4Qb38CDDEeWPMvNwVtiMsA")]
    [DisplayName("Accounting Status")]
    [IsoXmlTag("AcctgSts")]
    public AccountingStatus1Choice_? AccountingStatus { get; init; }

    /// <summary>
    /// Legal opening date for the account.
    /// </summary>
    [IsoId("__TVdgCDEEeWPMvNwVtiMsA")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    public DateAndDateTimeChoice_? OpeningDate { get; init; }

    /// <summary>
    /// Legal closing date for the account.
    /// </summary>
    [IsoId("_Dmk0UCDFEeWPMvNwVtiMsA")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public DateAndDateTimeChoice_? ClosingDate { get; init; }

    /// <summary>
    /// Indicates whether the account can hold a negative position in a security.
    /// </summary>
    [IsoId("_SFnQwCDFEeWPMvNwVtiMsA")]
    [DisplayName("Negative Indicator")]
    [IsoXmlTag("NegInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NegativeIndicator { get; init; }

    /// <summary>
    /// Order in which securities are moved from the account.
    /// </summary>
    [IsoId("_d7kyICDFEeWPMvNwVtiMsA")]
    [DisplayName("Processing Order")]
    [IsoXmlTag("PrcgOrdr")]
    public PositionEffect3Code? ProcessingOrder { get; init; }

    /// <summary>
    /// Specifies whether the investor assumes responsibility for the liability.
    /// </summary>
    [IsoId("_OAd8ICDMEeWPMvNwVtiMsA")]
    [DisplayName("Liability")]
    [IsoXmlTag("Lblty")]
    public Liability1Choice_? Liability { get; init; }

    /// <summary>
    /// Information used to determine fees and types of operations that can be carried out on the account.
    /// </summary>
    [IsoId("_StOwwCDNEeWPMvNwVtiMsA")]
    [DisplayName("Investor Profile")]
    [IsoXmlTag("InvstrPrfl")]
    public InvestorProfile1? InvestorProfile { get; init; }

    /// <summary>
    /// Fiscal year, when not the same as the calendar year.
    /// </summary>
    [IsoId("_3C9scFxREeW8MLuBzR10cg")]
    [DisplayName("Fiscal Year")]
    [IsoXmlTag("FsclYr")]
    public FiscalYear1Choice_? FiscalYear { get; init; }
}
