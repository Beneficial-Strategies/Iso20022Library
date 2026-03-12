// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a securities account and its characteristics.
/// </summary>
[IsoId("_zarZByC6EeWPMvNwVtiMsA")]
[DisplayName("Investment Account")]
public partial record InvestmentAccount50
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_z3ZKOSC6EeWPMvNwVtiMsA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Status of the account, for example, enabled or deleted.
    /// </summary>
    [IsoId("_tgKRYSF1EeW9XJWqfgXIIA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required AccountStatus1Choice_ Status { get; init; } 
    
    /// <summary>
    /// Date the status is assigned.
    /// </summary>
    [IsoId("_lYLdoSF1EeW9XJWqfgXIIA")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    public DateAndDateTime1Choice_? StatusDate { get; init; } 
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_z3ZKPSC6EeWPMvNwVtiMsA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_z3ZKPyC6EeWPMvNwVtiMsA")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; } 
    
    /// <summary>
    /// Type of account.
    /// </summary>
    [IsoId("_z3ZKQSC6EeWPMvNwVtiMsA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public AccountType2Choice_? Type { get; init; } 
    
    /// <summary>
    /// Ownership status of the account, for example, joint owners.
    /// </summary>
    [IsoId("_z3ZKQyC6EeWPMvNwVtiMsA")]
    [DisplayName("Ownership Type")]
    [IsoXmlTag("OwnrshTp")]
    public required OwnershipType2Choice_ OwnershipType { get; init; } 
    
    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    [IsoId("_z3ZKRSC6EeWPMvNwVtiMsA")]
    [DisplayName("Tax Exemption")]
    [IsoXmlTag("TaxXmptn")]
    public TaxExemptionReason2Choice_? TaxExemption { get; init; } 
    
    /// <summary>
    /// Frequency at which a statement is issued.
    /// </summary>
    [IsoId("_z3ZKRyC6EeWPMvNwVtiMsA")]
    [DisplayName("Statement Frequency")]
    [IsoXmlTag("StmtFrqcy")]
    public StatementFrequencyReason2Choice_? StatementFrequency { get; init; } 
    
    /// <summary>
    /// Currency chosen for reporting purposes by the account owner in agreement with the account servicer.
    /// </summary>
    [IsoId("_z3ZKSSC6EeWPMvNwVtiMsA")]
    [DisplayName("Reference Currency")]
    [IsoXmlTag("RefCcy")]
    public ActiveCurrencyCode? ReferenceCurrency { get; init; } 
    
    /// <summary>
    /// Language for all communication concerning the account.
    /// </summary>
    [IsoId("_z3ZKSyC6EeWPMvNwVtiMsA")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; } 
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_z3ZKTSC6EeWPMvNwVtiMsA")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference2Code? IncomePreference { get; init; } 
    
    /// <summary>
    /// Specifies, for income on the fund or security that is to be reinvested, parameters for the reinvestment. If the reinvestment percentage is less than one hundred percent, the remaining percentage will be invested according to the investor’s or account owner&apos;s subsequent instructions.
    /// </summary>
    [IsoId("_z3ZKTyC6EeWPMvNwVtiMsA")]
    [DisplayName("Reinvestment Details")]
    [IsoXmlTag("RinvstmtDtls")]
    public Reinvestment2? ReinvestmentDetails { get; init; } 
    
    /// <summary>
    /// Method by which the tax (withholding tax) is to be processed, that is, either withheld at source or tax information is reported to tax authorities or tax information is reported due to the provision of a tax certificate.
    /// </summary>
    [IsoId("_z3ZKUSC6EeWPMvNwVtiMsA")]
    [DisplayName("Tax Withholding Method")]
    [IsoXmlTag("TaxWhldgMtd")]
    public TaxWithholdingMethod3Code? TaxWithholdingMethod { get; init; } 
    
    /// <summary>
    /// Details for the reporting of tax, for example, the country of taxation.
    /// </summary>
    [IsoId("_XteYgSDCEeWPMvNwVtiMsA")]
    [DisplayName("Tax Reporting")]
    [IsoXmlTag("TaxRptg")]
    public TaxReporting1? TaxReporting { get; init; } 
    
    /// <summary>
    /// Details of the letter of intent.
    /// </summary>
    [IsoId("_z3ZKUyC6EeWPMvNwVtiMsA")]
    [DisplayName("Letter Intent Details")]
    [IsoXmlTag("LttrInttDtls")]
    public LetterIntent1? LetterIntentDetails { get; init; } 
    
    /// <summary>
    /// Reference of an accumulation rights program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_z3ZKVSC6EeWPMvNwVtiMsA")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccumulationRightReference { get; init; } 
    
    /// <summary>
    /// Number of account owners or related parties required to authorise transactions on the account.
    /// </summary>
    [IsoId("_z3ZKVyC6EeWPMvNwVtiMsA")]
    [DisplayName("Required Signatories Number")]
    [IsoXmlTag("ReqrdSgntriesNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RequiredSignatoriesNumber { get; init; } 
    
    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_z3ZKWSC6EeWPMvNwVtiMsA")]
    [DisplayName("Fund Family Name")]
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? FundFamilyName { get; init; } 
    
    /// <summary>
    /// Detailed information about the investment fund or security associated to the account.
    /// </summary>
    [IsoId("_z3ZKXyC6EeWPMvNwVtiMsA")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public FinancialInstrument51? FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Parameters to be applied on deal amount for orders when the amount is a fractional number.
    /// </summary>
    [IsoId("_z3ZKWyC6EeWPMvNwVtiMsA")]
    [DisplayName("Rounding Details")]
    [IsoXmlTag("RndgDtls")]
    public RoundingParameters1? RoundingDetails { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_z3ZKXSC6EeWPMvNwVtiMsA")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification70Choice_? AccountServicer { get; init; } 
    
    /// <summary>
    /// Specifies the account is blocked and other factors for the blocked account.
    /// </summary>
    [IsoId("_z3ZKZSC6EeWPMvNwVtiMsA")]
    [DisplayName("Blocked Status")]
    [IsoXmlTag("BlckdSts")]
    public Blocked2? BlockedStatus { get; init; } 
    
    /// <summary>
    /// Specifies the type of usage of the account.
    /// </summary>
    [IsoId("_z3ZKZyC6EeWPMvNwVtiMsA")]
    [DisplayName("Account Usage Type")]
    [IsoXmlTag("AcctUsgTp")]
    public AccountUsageType2Choice_? AccountUsageType { get; init; } 
    
    /// <summary>
    /// Specifies if documentary evidence has been provided for the foreign resident.
    /// </summary>
    [IsoId("_z3ZKaSC6EeWPMvNwVtiMsA")]
    [DisplayName("Foreign Status Certification")]
    [IsoXmlTag("FrgnStsCertfctn")]
    public Provided1Code? ForeignStatusCertification { get; init; } 
    
    /// <summary>
    /// Date the investor or account owner signs the open account form.
    /// </summary>
    [IsoId("_z3ZKayC6EeWPMvNwVtiMsA")]
    [DisplayName("Account Signature Date Time")]
    [IsoXmlTag("AcctSgntrDtTm")]
    public DateAndDateTimeChoice_? AccountSignatureDateTime { get; init; } 
    
    /// <summary>
    /// Specifies the means by which the investor or account owner submits the open account form.
    /// </summary>
    [IsoId("_z3ZKbSC6EeWPMvNwVtiMsA")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; } 
    
    /// <summary>
    /// Specifies the category of the account.
    /// </summary>
    [IsoId("_z3ZKbyC6EeWPMvNwVtiMsA")]
    [DisplayName("Investment Account Category")]
    [IsoXmlTag("InvstmtAcctCtgy")]
    public InvestmentAccountCategory1Choice_? InvestmentAccountCategory { get; init; } 
    
    /// <summary>
    /// Specifies whether the holdings in the account are eligible for pledging.
    /// </summary>
    [IsoId("_L4IXoyDBEeWPMvNwVtiMsA")]
    [DisplayName("Pledging")]
    [IsoXmlTag("Pldgg")]
    public Eligible1Code? Pledging { get; init; } 
    
    /// <summary>
    /// Specifies whether the holdings in the account are used as collateral.
    /// </summary>
    [IsoId("_L4IXpCDBEeWPMvNwVtiMsA")]
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public Collateral1Code? Collateral { get; init; } 
    
    /// <summary>
    /// Details of third party rights.
    /// </summary>
    [IsoId("_L4IXpSDBEeWPMvNwVtiMsA")]
    [DisplayName("Third Party Rights")]
    [IsoXmlTag("ThrdPtyRghts")]
    public ThirdPartyRights1? ThirdPartyRights { get; init; } 
    
    /// <summary>
    /// Functionality permitted to a third party in the actions that may be taken on an account on behalf of the investor.
    /// </summary>
    [IsoId("_sYy7kSDDEeWPMvNwVtiMsA")]
    [DisplayName("Power Of Attorney Level Of Control")]
    [IsoXmlTag("PwrOfAttnyLvlOfCtrl")]
    public LevelOfControl1Choice_? PowerOfAttorneyLevelOfControl { get; init; } 
    
    /// <summary>
    /// Specifies if the account is regarded as domestic or non-domestic for reporting purposes.
    /// </summary>
    [IsoId("_lUmDkSDEEeWPMvNwVtiMsA")]
    [DisplayName("Accounting Status")]
    [IsoXmlTag("AcctgSts")]
    public AccountingStatus1Choice_? AccountingStatus { get; init; } 
    
    /// <summary>
    /// Legal opening date for the account.
    /// </summary>
    [IsoId("_GyZ3IiDFEeWPMvNwVtiMsA")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    public DateAndDateTimeChoice_? OpeningDate { get; init; } 
    
    /// <summary>
    /// Legal closing date for the account.
    /// </summary>
    [IsoId("_GyZ3IyDFEeWPMvNwVtiMsA")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public DateAndDateTimeChoice_? ClosingDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the account can hold a negative position in a security.
    /// </summary>
    [IsoId("_UfddASDFEeWPMvNwVtiMsA")]
    [DisplayName("Negative Indicator")]
    [IsoXmlTag("NegInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NegativeIndicator { get; init; } 
    
    /// <summary>
    /// Order in which securities are moved from the account.
    /// </summary>
    [IsoId("_I3QxMiDNEeWPMvNwVtiMsA")]
    [DisplayName("Processing Order")]
    [IsoXmlTag("PrcgOrdr")]
    public PositionEffect3Code? ProcessingOrder { get; init; } 
    
    /// <summary>
    /// Specifies whether the investor assumes responsibility for the liability.
    /// </summary>
    [IsoId("_I3QxMyDNEeWPMvNwVtiMsA")]
    [DisplayName("Liability")]
    [IsoXmlTag("Lblty")]
    public Liability1Choice_? Liability { get; init; } 
    
    /// <summary>
    /// Information used to determine fees and types of operations that can be carried out on the account.
    /// </summary>
    [IsoId("_Fa2JISDXEeWCLu74WLgP4w")]
    [DisplayName("Investor Profile")]
    [IsoXmlTag("InvstrPrfl")]
    public InvestorProfile1? InvestorProfile { get; init; } 
    
    /// <summary>
    /// Fiscal year, when not the same as the calendar year.
    /// </summary>
    [IsoId("_T9TU0VxSEeW8MLuBzR10cg")]
    [DisplayName("Fiscal Year")]
    [IsoXmlTag("FsclYr")]
    public FiscalYear1Choice_? FiscalYear { get; init; } 
    
    
    #nullable disable
    
}
