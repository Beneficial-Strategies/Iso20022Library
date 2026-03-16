// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
[IsoId("_gJPFcRQ_EeOKWo1NF21OVw")]
[DisplayName("Investment Account")]
public record InvestmentAccount38
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_ggz39RQ_EeOKWo1NF21OVw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification1 Identification { get; init; }

    /// <summary>
    /// Specifies the current state of an account, eg, enabled or deleted.
    /// </summary>
    [IsoId("_ggz39xQ_EeOKWo1NF21OVw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required AccountStatus2Code Status { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_ggz3-RQ_EeOKWo1NF21OVw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_ggz3-xQ_EeOKWo1NF21OVw")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; }

    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, for example, wrapper, ISA.
    /// </summary>
    [IsoId("_ggz3_RQ_EeOKWo1NF21OVw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public AccountType1Choice_? Type { get; init; }

    /// <summary>
    /// Ownership status of the account, for example, joint owners.
    /// </summary>
    [IsoId("_ggz3_xQ_EeOKWo1NF21OVw")]
    [DisplayName("Ownership Type")]
    [IsoXmlTag("OwnrshTp")]
    public required OwnershipType1Choice_ OwnershipType { get; init; }

    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    [IsoId("_ggz4ARQ_EeOKWo1NF21OVw")]
    [DisplayName("Tax Exemption")]
    [IsoXmlTag("TaxXmptn")]
    public TaxExemptionReason1Choice_? TaxExemption { get; init; }

    /// <summary>
    /// Frequency at which a statement is issued.
    /// </summary>
    [IsoId("_ggz4AxQ_EeOKWo1NF21OVw")]
    [DisplayName("Statement Frequency")]
    [IsoXmlTag("StmtFrqcy")]
    public StatementFrequencyReason1Choice_? StatementFrequency { get; init; }

    /// <summary>
    /// Currency chosen for reporting purposes by the account owner in agreement with the account servicer.
    /// </summary>
    [IsoId("_ggz4BRQ_EeOKWo1NF21OVw")]
    [DisplayName("Reference Currency")]
    [IsoXmlTag("RefCcy")]
    public ActiveCurrencyCode? ReferenceCurrency { get; init; }

    /// <summary>
    /// Language for all communication concerning the account.
    /// </summary>
    [IsoId("_ggz4BxQ_EeOKWo1NF21OVw")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_ggz4CRQ_EeOKWo1NF21OVw")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Specifies, for income on the fund that is to be reinvested, parameters for the reinvestment. If the reinvestment percentage is less than one hundred percent, the remaining percentage will be invested according to the investor’s subsequent instructions.
    /// </summary>
    [IsoId("_jdRpEBQ_EeOKWo1NF21OVw")]
    [DisplayName("Reinvestment Details")]
    [IsoXmlTag("RinvstmtDtls")]
    public Reinvestment1? ReinvestmentDetails { get; init; }

    /// <summary>
    /// Method by which the tax (withholding tax) is to be processed i.e. either withheld at source or tax information reported to tax authorities or tax information is reported due to the provision of a tax certificate.
    /// </summary>
    [IsoId("_ggz4CxQ_EeOKWo1NF21OVw")]
    [DisplayName("Tax Withholding Method")]
    [IsoXmlTag("TaxWhldgMtd")]
    public TaxWithholdingMethod2Code? TaxWithholdingMethod { get; init; }

    /// <summary>
    /// Details of the letter of intent.
    /// </summary>
    [IsoId("_ggz4DRQ_EeOKWo1NF21OVw")]
    [DisplayName("Letter Intent Details")]
    [IsoXmlTag("LttrInttDtls")]
    public LetterIntent1? LetterIntentDetails { get; init; }

    /// <summary>
    /// Reference of an accumulation rights program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_ggz4DxQ_EeOKWo1NF21OVw")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccumulationRightReference { get; init; }

    /// <summary>
    /// Number of account owners or related parties required to authorise transactions on the account.
    /// </summary>
    [IsoId("_ggz4ERQ_EeOKWo1NF21OVw")]
    [DisplayName("Required Signatories Number")]
    [IsoXmlTag("ReqrdSgntriesNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RequiredSignatoriesNumber { get; init; }

    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_ggz4ExQ_EeOKWo1NF21OVw")]
    [DisplayName("Fund Family Name")]
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FundFamilyName { get; init; }

    /// <summary>
    /// Parameters to be applied on deal amount for orders when the amount is a fractional number.
    /// </summary>
    [IsoId("_ggz4FRQ_EeOKWo1NF21OVw")]
    [DisplayName("Rounding Details")]
    [IsoXmlTag("RndgDtls")]
    public RoundingParameters1? RoundingDetails { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_ggz4FxQ_EeOKWo1NF21OVw")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification2Choice_? AccountServicer { get; init; }

    /// <summary>
    /// Detailed information about the investment fund associated to the account.
    /// </summary>
    [IsoId("_ggz4GRQ_EeOKWo1NF21OVw")]
    [DisplayName("Funds Details")]
    [IsoXmlTag("FndsDtls")]
    public FinancialInstrument29? FundsDetails { get; init; }

    /// <summary>
    /// Part of the investment account to or from which cash entries are made.
    /// </summary>
    [IsoId("_ggz4GxQ_EeOKWo1NF21OVw")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<CashAccount12> CashAccount { get; init; } = [];

    /// <summary>
    /// Part of the investment account to or from which securities entries are made.
    /// </summary>
    [IsoId("_gg0fARQ_EeOKWo1NF21OVw")]
    [DisplayName("Securities Account")]
    [IsoXmlTag("SctiesAcct")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<SecuritiesAccount4> SecuritiesAccount { get; init; } = [];

    /// <summary>
    /// Specifies information about blocked accounts.
    /// </summary>
    [IsoId("_gg0fAxQ_EeOKWo1NF21OVw")]
    [DisplayName("Blocked Status")]
    [IsoXmlTag("BlckdSts")]
    public Blocked1? BlockedStatus { get; init; }

    /// <summary>
    /// Specifies the type of usage of the account.
    /// </summary>
    [IsoId("_gg0fBRQ_EeOKWo1NF21OVw")]
    [DisplayName("Account Usage Type")]
    [IsoXmlTag("AcctUsgTp")]
    public AccountUsageType1Choice_? AccountUsageType { get; init; }

    /// <summary>
    /// Specifies if documentary evidence has been provided for the foreign resident.
    /// </summary>
    [IsoId("_gg0fBxQ_EeOKWo1NF21OVw")]
    [DisplayName("Foreign Status Certification")]
    [IsoXmlTag("FrgnStsCertfctn")]
    public Provided1Code? ForeignStatusCertification { get; init; }

    /// <summary>
    /// Date the investor signs the open account form.
    /// </summary>
    [IsoId("_gg0fCRQ_EeOKWo1NF21OVw")]
    [DisplayName("Account Signature Date Time")]
    [IsoXmlTag("AcctSgntrDtTm")]
    public DateAndDateTimeChoice_? AccountSignatureDateTime { get; init; }

    /// <summary>
    /// Specifies the means by which the investor submits the open account form.
    /// </summary>
    [IsoId("_346ioRRGEeOKWo1NF21OVw")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; }

    /// <summary>
    /// Specifies the category of the investment account.
    /// </summary>
    [IsoId("_xTy94RRIEeOKWo1NF21OVw")]
    [DisplayName("Investment Account Category")]
    [IsoXmlTag("InvstmtAcctCtgy")]
    public InvestmentAccountCategory1Choice_? InvestmentAccountCategory { get; init; }
}
