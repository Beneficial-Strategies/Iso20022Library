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
[IsoId("_z3i7MSC6EeWPMvNwVtiMsA")]
[DisplayName("Investment Account")]
public record InvestmentAccount51
{
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_0UG7aSC6EeWPMvNwVtiMsA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_0UG7ayC6EeWPMvNwVtiMsA")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; }

    /// <summary>
    /// Type of account.
    /// </summary>
    [IsoId("_0UG7bSC6EeWPMvNwVtiMsA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public AccountType2Choice_? Type { get; init; }

    /// <summary>
    /// Ownership status of the account, for example, joint owners.
    /// </summary>
    [IsoId("_0UG7byC6EeWPMvNwVtiMsA")]
    [DisplayName("Ownership Type")]
    [IsoXmlTag("OwnrshTp")]
    public OwnershipType2Choice_? OwnershipType { get; init; }

    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    [IsoId("_0UG7cSC6EeWPMvNwVtiMsA")]
    [DisplayName("Tax Exemption")]
    [IsoXmlTag("TaxXmptn")]
    public TaxExemptionReason2Choice_? TaxExemption { get; init; }

    /// <summary>
    /// Frequency at which a statement is issued.
    /// </summary>
    [IsoId("_0UG7cyC6EeWPMvNwVtiMsA")]
    [DisplayName("Statement Frequency")]
    [IsoXmlTag("StmtFrqcy")]
    public StatementFrequencyReason2Choice_? StatementFrequency { get; init; }

    /// <summary>
    /// Currency chosen for reporting purposes by the account owner in agreement with the account servicer.
    /// </summary>
    [IsoId("_0UG7dSC6EeWPMvNwVtiMsA")]
    [DisplayName("Reference Currency")]
    [IsoXmlTag("RefCcy")]
    public ActiveCurrencyCode? ReferenceCurrency { get; init; }

    /// <summary>
    /// Language for all communication concerning the account.
    /// </summary>
    [IsoId("_0UG7dyC6EeWPMvNwVtiMsA")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_0UG7eSC6EeWPMvNwVtiMsA")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference2Code? IncomePreference { get; init; }

    /// <summary>
    /// Specifies, for income on the fund or security that is to be reinvested, parameters for the reinvestment. If the reinvestment percentage is less than one hundred percent, the remaining percentage will be invested according to the investor’s or account owner&apos;s subsequent instructions.
    /// </summary>
    [IsoId("_0UG7eyC6EeWPMvNwVtiMsA")]
    [DisplayName("Reinvestment Details")]
    [IsoXmlTag("RinvstmtDtls")]
    public Reinvestment2? ReinvestmentDetails { get; init; }

    /// <summary>
    /// Method by which the tax (withholding tax) is to be processed, that is, either withheld at source or tax information is reported to tax authorities or tax information is reported due to the provision of a tax certificate.
    /// </summary>
    [IsoId("_0UG7fSC6EeWPMvNwVtiMsA")]
    [DisplayName("Tax Withholding Method")]
    [IsoXmlTag("TaxWhldgMtd")]
    public TaxWithholdingMethod3Code? TaxWithholdingMethod { get; init; }

    /// <summary>
    /// Details for the reporting of tax, for example, the country of taxation.
    /// </summary>
    [IsoId("_cfqVISDCEeWPMvNwVtiMsA")]
    [DisplayName("Tax Reporting")]
    [IsoXmlTag("TaxRptg")]
    public TaxReporting1? TaxReporting { get; init; }

    /// <summary>
    /// Details of the letter of intent.
    /// </summary>
    [IsoId("_0UG7fyC6EeWPMvNwVtiMsA")]
    [DisplayName("Letter Intent Details")]
    [IsoXmlTag("LttrInttDtls")]
    public LetterIntent1? LetterIntentDetails { get; init; }

    /// <summary>
    /// Reference of an accumulation rights program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_0UG7gSC6EeWPMvNwVtiMsA")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccumulationRightReference { get; init; }

    /// <summary>
    /// Number of account owners or related parties required to authorise transactions on the account.
    /// </summary>
    [IsoId("_0UG7gyC6EeWPMvNwVtiMsA")]
    [DisplayName("Required Signatories Number")]
    [IsoXmlTag("ReqrdSgntriesNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RequiredSignatoriesNumber { get; init; }

    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_0UG7hSC6EeWPMvNwVtiMsA")]
    [DisplayName("Fund Family Name")]
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FundFamilyName { get; init; }

    /// <summary>
    /// Detailed information about the financial instrument associated to the account that is to be modified or deleted.
    /// </summary>
    [IsoId("_0UG7hyC6EeWPMvNwVtiMsA")]
    [DisplayName("Modified Financial Instrument Details")]
    [IsoXmlTag("ModfdFinInstrmDtls")]
    public ModificationScope29? ModifiedFinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Parameters to be applied on deal amount for orders when the amount is a fractional number.
    /// </summary>
    [IsoId("_0UG7iSC6EeWPMvNwVtiMsA")]
    [DisplayName("Rounding Details")]
    [IsoXmlTag("RndgDtls")]
    public RoundingParameters1? RoundingDetails { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_0UG7iyC6EeWPMvNwVtiMsA")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification70Choice_? AccountServicer { get; init; }

    /// <summary>
    /// Specifies the account is blocked and other factors for the blocked account.
    /// </summary>
    [IsoId("_0UG7jSC6EeWPMvNwVtiMsA")]
    [DisplayName("Blocked Status")]
    [IsoXmlTag("BlckdSts")]
    public Blocked2? BlockedStatus { get; init; }

    /// <summary>
    /// Specifies the type of usage of the account.
    /// </summary>
    [IsoId("_0UG7jyC6EeWPMvNwVtiMsA")]
    [DisplayName("Account Usage Type")]
    [IsoXmlTag("AcctUsgTp")]
    public AccountUsageType2Choice_? AccountUsageType { get; init; }

    /// <summary>
    /// Specifies if documentary evidence has been provided for the foreign resident.
    /// </summary>
    [IsoId("_0UG7kSC6EeWPMvNwVtiMsA")]
    [DisplayName("Foreign Status Certification")]
    [IsoXmlTag("FrgnStsCertfctn")]
    public Provided1Code? ForeignStatusCertification { get; init; }

    /// <summary>
    /// Date the investor or account owner signs the open account form.
    /// </summary>
    [IsoId("_0UG7kyC6EeWPMvNwVtiMsA")]
    [DisplayName("Account Signature Date Time")]
    [IsoXmlTag("AcctSgntrDtTm")]
    public DateAndDateTimeChoice_? AccountSignatureDateTime { get; init; }

    /// <summary>
    /// Specifies the means by which the investor or account owner submits the open account form.
    /// </summary>
    [IsoId("_0UG7lSC6EeWPMvNwVtiMsA")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; }

    /// <summary>
    /// Specifies the category of the account.
    /// </summary>
    [IsoId("_0UG7lyC6EeWPMvNwVtiMsA")]
    [DisplayName("Investment Account Category")]
    [IsoXmlTag("InvstmtAcctCtgy")]
    public InvestmentAccountCategory1Choice_? InvestmentAccountCategory { get; init; }

    /// <summary>
    /// Specifies whether the holdings in the account are eligible for pledging.
    /// </summary>
    [IsoId("_Yi9rgyDBEeWPMvNwVtiMsA")]
    [DisplayName("Pledging")]
    [IsoXmlTag("Pldgg")]
    public Eligible1Code? Pledging { get; init; }

    /// <summary>
    /// Specifies whether the holdings in the account are used as collateral.
    /// </summary>
    [IsoId("_Yi9rhCDBEeWPMvNwVtiMsA")]
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public Collateral1Code? Collateral { get; init; }

    /// <summary>
    /// Details of third party rights.
    /// </summary>
    [IsoId("_Yi9rhSDBEeWPMvNwVtiMsA")]
    [DisplayName("Third Party Rights")]
    [IsoXmlTag("ThrdPtyRghts")]
    public ThirdPartyRights1? ThirdPartyRights { get; init; }

    /// <summary>
    /// Functionality permitted to a third party in the actions that may be taken on an account on behalf of the investor.
    /// </summary>
    [IsoId("_tVyvUSDDEeWPMvNwVtiMsA")]
    [DisplayName("Power Of Attorney Level Of Control")]
    [IsoXmlTag("PwrOfAttnyLvlOfCtrl")]
    public LevelOfControl1Choice_? PowerOfAttorneyLevelOfControl { get; init; }

    /// <summary>
    /// Specifies if the account is regarded as domestic or non-domestic for reporting purposes.
    /// </summary>
    [IsoId("_mJj8sSDEEeWPMvNwVtiMsA")]
    [DisplayName("Accounting Status")]
    [IsoXmlTag("AcctgSts")]
    public AccountingStatus1Choice_? AccountingStatus { get; init; }

    /// <summary>
    /// Legal opening date for the account.
    /// </summary>
    [IsoId("_IUJWsiDFEeWPMvNwVtiMsA")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    public DateAndDateTimeChoice_? OpeningDate { get; init; }

    /// <summary>
    /// Legal closing date for the account.
    /// </summary>
    [IsoId("_IUJWsyDFEeWPMvNwVtiMsA")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public DateAndDateTimeChoice_? ClosingDate { get; init; }

    /// <summary>
    /// Indicates whether the account can hold a negative position in a security.
    /// </summary>
    [IsoId("_VYcTcSDFEeWPMvNwVtiMsA")]
    [DisplayName("Negative Indicator")]
    [IsoXmlTag("NegInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NegativeIndicator { get; init; }

    /// <summary>
    /// Order in which securities are moved from the account.
    /// </summary>
    [IsoId("_JvziwiDNEeWPMvNwVtiMsA")]
    [DisplayName("Processing Order")]
    [IsoXmlTag("PrcgOrdr")]
    public PositionEffect3Code? ProcessingOrder { get; init; }

    /// <summary>
    /// Specifies whether the investor assumes responsibility for the liability.
    /// </summary>
    [IsoId("_JvziwyDNEeWPMvNwVtiMsA")]
    [DisplayName("Liability")]
    [IsoXmlTag("Lblty")]
    public Liability1Choice_? Liability { get; init; }

    /// <summary>
    /// Information related to the investor profile to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_NRtXcCF2EeW9XJWqfgXIIA")]
    [DisplayName("Modified Investor Profile")]
    [IsoXmlTag("ModfdInvstrPrfl")]
    public ModificationScope32? ModifiedInvestorProfile { get; init; }

    /// <summary>
    /// Fiscal year, when not the same as the calendar year.
    /// </summary>
    [IsoId("_cEO_sVxSEeW8MLuBzR10cg")]
    [DisplayName("Fiscal Year")]
    [IsoXmlTag("FsclYr")]
    public FiscalYear1Choice_? FiscalYear { get; init; }
}
