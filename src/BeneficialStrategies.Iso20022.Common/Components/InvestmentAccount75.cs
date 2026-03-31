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
[IsoId("_QqdlYZS8EemqYPWMBuVawg")]
[DisplayName("Investment Account")]
public record InvestmentAccount75
{
    /// <summary>
    /// Change of account status is instructed.
    /// </summary>
    [IsoId("_Q-GTG5S8EemqYPWMBuVawg")]
    [DisplayName("Account Status Update Instruction")]
    [IsoXmlTag("AcctStsUpdInstr")]
    public AccountStatusUpdateInstruction1? AccountStatusUpdateInstruction { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_Q-GTHZS8EemqYPWMBuVawg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to be reconciled individually.
    /// </summary>
    [IsoId("_Q-GTH5S8EemqYPWMBuVawg")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; }

    /// <summary>
    /// Type of account.
    /// </summary>
    [IsoId("_Q-GTIZS8EemqYPWMBuVawg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public AccountType2Choice_? Type { get; init; }

    /// <summary>
    /// Ownership status of the account, for example, joint owners.
    /// </summary>
    [IsoId("_Q-GTI5S8EemqYPWMBuVawg")]
    [DisplayName("Ownership Type")]
    [IsoXmlTag("OwnrshTp")]
    public OwnershipType2Choice_? OwnershipType { get; init; }

    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    [IsoId("_Q-GTJZS8EemqYPWMBuVawg")]
    [DisplayName("Tax Exemption")]
    [IsoXmlTag("TaxXmptn")]
    public TaxExemptionReason2Choice_? TaxExemption { get; init; }

    /// <summary>
    /// Frequency at which a statement is issued.
    /// </summary>
    [IsoId("_Q-GTJ5S8EemqYPWMBuVawg")]
    [DisplayName("Statement Frequency")]
    [IsoXmlTag("StmtFrqcy")]
    public StatementFrequencyReason2Choice_? StatementFrequency { get; init; }

    /// <summary>
    /// Currency chosen for reporting purposes by the account owner in agreement with the account servicer.
    /// </summary>
    [IsoId("_Q-GTKZS8EemqYPWMBuVawg")]
    [DisplayName("Reference Currency")]
    [IsoXmlTag("RefCcy")]
    public ActiveCurrencyCode? ReferenceCurrency { get; init; }

    /// <summary>
    /// Language for all communication concerning the account.
    /// </summary>
    [IsoId("_Q-GTK5S8EemqYPWMBuVawg")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_Q-GTLZS8EemqYPWMBuVawg")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference2Code? IncomePreference { get; init; }

    /// <summary>
    /// Specifies, for income on the fund or security that is to be reinvested, parameters for the reinvestment. If the reinvestment percentage is less than one hundred percent, the remaining percentage will be invested according to the investor’s or account owner&apos;s subsequent instructions.
    /// </summary>
    [IsoId("_Q-GTL5S8EemqYPWMBuVawg")]
    [DisplayName("Reinvestment Details")]
    [IsoXmlTag("RinvstmtDtls")]
    public ValueList<Reinvestment4> ReinvestmentDetails { get; init; } = [];

    /// <summary>
    /// Method by which the tax (withholding tax) is to be processed, that is, either withheld at source or tax information is reported to tax authorities or tax information is reported due to the provision of a tax certificate.
    /// </summary>
    [IsoId("_Q-GTMZS8EemqYPWMBuVawg")]
    [DisplayName("Tax Withholding Method")]
    [IsoXmlTag("TaxWhldgMtd")]
    public TaxWithholdingMethod3Code? TaxWithholdingMethod { get; init; }

    /// <summary>
    /// Details for the reporting of tax, for example, the country of taxation.
    /// </summary>
    [IsoId("_Q-GTM5S8EemqYPWMBuVawg")]
    [DisplayName("Tax Reporting")]
    [IsoXmlTag("TaxRptg")]
    public ValueList<TaxReporting3> TaxReporting { get; init; } = [];

    /// <summary>
    /// Details of the letter of intent.
    /// </summary>
    [IsoId("_Q-GTNZS8EemqYPWMBuVawg")]
    [DisplayName("Letter Intent Details")]
    [IsoXmlTag("LttrInttDtls")]
    public LetterIntent1? LetterIntentDetails { get; init; }

    /// <summary>
    /// Reference of an accumulation rights program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_Q-GTN5S8EemqYPWMBuVawg")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccumulationRightReference { get; init; }

    /// <summary>
    /// Number of account owners or related parties required to authorise transactions on the account.
    /// </summary>
    [IsoId("_Q-GTOZS8EemqYPWMBuVawg")]
    [DisplayName("Required Signatories Number")]
    [IsoXmlTag("ReqrdSgntriesNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RequiredSignatoriesNumber { get; init; }

    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_Q-GTO5S8EemqYPWMBuVawg")]
    [DisplayName("Fund Family Name")]
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FundFamilyName { get; init; }

    /// <summary>
    /// Detailed information about the financial instrument associated to the account that is to be modified or deleted.
    /// </summary>
    [IsoId("_Q-GTPZS8EemqYPWMBuVawg")]
    [DisplayName("Modified Financial Instrument Details")]
    [IsoXmlTag("ModfdFinInstrmDtls")]
    public ValueList<ModificationScope42> ModifiedFinancialInstrumentDetails { get; init; } = [];

    /// <summary>
    /// Parameters to be applied on deal amount for orders when the amount is a fractional number.
    /// </summary>
    [IsoId("_Q-GTP5S8EemqYPWMBuVawg")]
    [DisplayName("Rounding Details")]
    [IsoXmlTag("RndgDtls")]
    public RoundingParameters1? RoundingDetails { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_Q-GTQZS8EemqYPWMBuVawg")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification125Choice_? AccountServicer { get; init; }

    /// <summary>
    /// Specifies the account is blocked and other factors for the blocked account.
    /// </summary>
    [IsoId("_Q-GTQ5S8EemqYPWMBuVawg")]
    [DisplayName("Blocked Status")]
    [IsoXmlTag("BlckdSts")]
    public BlockedStatusReason2Choice_? BlockedStatus { get; init; }

    /// <summary>
    /// Specifies the type of usage of the account.
    /// </summary>
    [IsoId("_Q-GTRZS8EemqYPWMBuVawg")]
    [DisplayName("Account Usage Type")]
    [IsoXmlTag("AcctUsgTp")]
    public AccountUsageType2Choice_? AccountUsageType { get; init; }

    /// <summary>
    /// Specifies if documentary evidence has been provided for the foreign resident.
    /// </summary>
    [IsoId("_Q-GTR5S8EemqYPWMBuVawg")]
    [DisplayName("Foreign Status Certification")]
    [IsoXmlTag("FrgnStsCertfctn")]
    public Provided1Code? ForeignStatusCertification { get; init; }

    /// <summary>
    /// Date the investor or account owner signs the open account form.
    /// </summary>
    [IsoId("_Q-GTSZS8EemqYPWMBuVawg")]
    [DisplayName("Account Signature Date Time")]
    [IsoXmlTag("AcctSgntrDtTm")]
    public DateAndDateTime1Choice_? AccountSignatureDateTime { get; init; }

    /// <summary>
    /// Means by which the investor or account owner submits the open account form.
    /// </summary>
    [IsoId("_Q-GTS5S8EemqYPWMBuVawg")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; }

    /// <summary>
    /// Specifies the category of the account.
    /// </summary>
    [IsoId("_Q-GTTZS8EemqYPWMBuVawg")]
    [DisplayName("Investment Account Category")]
    [IsoXmlTag("InvstmtAcctCtgy")]
    public InvestmentAccountCategory1Choice_? InvestmentAccountCategory { get; init; }

    /// <summary>
    /// Specifies whether the holdings in the account are eligible for pledging.
    /// </summary>
    [IsoId("_Q-GTT5S8EemqYPWMBuVawg")]
    [DisplayName("Pledging")]
    [IsoXmlTag("Pldgg")]
    public Eligible1Code? Pledging { get; init; }

    /// <summary>
    /// Specifies whether the holdings in the account are used as collateral.
    /// </summary>
    [IsoId("_Q-GTUZS8EemqYPWMBuVawg")]
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public Collateral1Code? Collateral { get; init; }

    /// <summary>
    /// Details of third party rights.
    /// </summary>
    [IsoId("_Q-GTU5S8EemqYPWMBuVawg")]
    [DisplayName("Third Party Rights")]
    [IsoXmlTag("ThrdPtyRghts")]
    public ThirdPartyRights2? ThirdPartyRights { get; init; }

    /// <summary>
    /// Functionality permitted to a third party in the actions that may be taken on an account on behalf of the investor.
    /// </summary>
    [IsoId("_Q-GTVZS8EemqYPWMBuVawg")]
    [DisplayName("Power Of Attorney Level Of Control")]
    [IsoXmlTag("PwrOfAttnyLvlOfCtrl")]
    public LevelOfControl1Choice_? PowerOfAttorneyLevelOfControl { get; init; }

    /// <summary>
    /// Specifies if the account is regarded as domestic or non-domestic for reporting purposes.
    /// </summary>
    [IsoId("_Q-GTV5S8EemqYPWMBuVawg")]
    [DisplayName("Accounting Status")]
    [IsoXmlTag("AcctgSts")]
    public AccountingStatus1Choice_? AccountingStatus { get; init; }

    /// <summary>
    /// Legal opening date for the account.
    /// </summary>
    [IsoId("_Q-GTWZS8EemqYPWMBuVawg")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    public DateAndDateTime1Choice_? OpeningDate { get; init; }

    /// <summary>
    /// Legal closing date for the account.
    /// </summary>
    [IsoId("_Q-GTW5S8EemqYPWMBuVawg")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public DateAndDateTime1Choice_? ClosingDate { get; init; }

    /// <summary>
    /// Indicates whether the account can hold a negative position in a security.
    /// </summary>
    [IsoId("_Q-GTXZS8EemqYPWMBuVawg")]
    [DisplayName("Negative Indicator")]
    [IsoXmlTag("NegInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NegativeIndicator { get; init; }

    /// <summary>
    /// Order in which securities are moved from the account.
    /// </summary>
    [IsoId("_Q-GTX5S8EemqYPWMBuVawg")]
    [DisplayName("Processing Order")]
    [IsoXmlTag("PrcgOrdr")]
    public PositionEffect3Code? ProcessingOrder { get; init; }

    /// <summary>
    /// Specifies whether the investor assumes responsibility for the liability.
    /// </summary>
    [IsoId("_Q-GTYZS8EemqYPWMBuVawg")]
    [DisplayName("Liability")]
    [IsoXmlTag("Lblty")]
    public Liability1Choice_? Liability { get; init; }

    /// <summary>
    /// Information related to the investor profile to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_Q-GTY5S8EemqYPWMBuVawg")]
    [DisplayName("Modified Investor Profile")]
    [IsoXmlTag("ModfdInvstrPrfl")]
    public ValueList<ModificationScope46> ModifiedInvestorProfile { get; init; } = [];

    /// <summary>
    /// Fiscal year, when not the same as the calendar year.
    /// </summary>
    [IsoId("_Q-GTZZS8EemqYPWMBuVawg")]
    [DisplayName("Fiscal Year")]
    [IsoXmlTag("FsclYr")]
    public FiscalYear1Choice_? FiscalYear { get; init; }
}
