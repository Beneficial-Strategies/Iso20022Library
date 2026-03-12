// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
[IsoId("_RzOPL9p-Ed-ak6NoX_4Aeg_-1110358755")]
[DisplayName("Investment Account")]
public partial record InvestmentAccount26
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_RzOPMNp-Ed-ak6NoX_4Aeg_-1102972739")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public AccountIdentification1? Identification { get; init; } 
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_RzOPMdp-Ed-ak6NoX_4Aeg_-1102972644")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_RzOPMtp-Ed-ak6NoX_4Aeg_-1102972602")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; } 
    
    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, PEP, ISA.
    /// </summary>
    [IsoId("_RzOPM9p-Ed-ak6NoX_4Aeg_-1102972524")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public FundCashAccount3Code? Type { get; init; } 
    
    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, PEP, ISA.
    /// </summary>
    [IsoId("_RzXZENp-Ed-ak6NoX_4Aeg_-1102972489")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedType { get; init; } 
    
    /// <summary>
    /// Ownership status of the account, eg, joint owners.
    /// </summary>
    [IsoId("_RzXZEdp-Ed-ak6NoX_4Aeg_-1102972447")]
    [DisplayName("Ownership Type")]
    [IsoXmlTag("OwnrshTp")]
    public required AccountOwnershipType3Code OwnershipType { get; init; } 
    
    /// <summary>
    /// Ownership status of the account, eg, joint owners.
    /// </summary>
    [IsoId("_RzXZEtp-Ed-ak6NoX_4Aeg_-1102972212")]
    [DisplayName("Extended Ownership Type")]
    [IsoXmlTag("XtndedOwnrshTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedOwnershipType { get; init; } 
    
    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    [IsoId("_RzXZE9p-Ed-ak6NoX_4Aeg_-1102971688")]
    [DisplayName("Tax Exemption Reason")]
    [IsoXmlTag("TaxXmptnRsn")]
    public TaxExemptReason1Code? TaxExemptionReason { get; init; } 
    
    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    [IsoId("_RzXZFNp-Ed-ak6NoX_4Aeg_-1102971653")]
    [DisplayName("Extended Tax Exemption Reason")]
    [IsoXmlTag("XtndedTaxXmptnRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedTaxExemptionReason { get; init; } 
    
    /// <summary>
    /// Regularity at which a statement is issued.
    /// </summary>
    [IsoId("_RzXZFdp-Ed-ak6NoX_4Aeg_-1102971221")]
    [DisplayName("Statement Frequency")]
    [IsoXmlTag("StmtFrqcy")]
    public EventFrequency1Code? StatementFrequency { get; init; } 
    
    /// <summary>
    /// Regularity at which a statement is issued.
    /// </summary>
    [IsoId("_RzXZFtp-Ed-ak6NoX_4Aeg_-1102971186")]
    [DisplayName("Extended Statement Frequency")]
    [IsoXmlTag("XtndedStmtFrqcy")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedStatementFrequency { get; init; } 
    
    /// <summary>
    /// Currency chosen for reporting purposes by the account owner in agreement with the account servicer.
    /// </summary>
    [IsoId("_RzXZF9p-Ed-ak6NoX_4Aeg_-1102972177")]
    [DisplayName("Reference Currency")]
    [IsoXmlTag("RefCcy")]
    public ActiveCurrencyCode? ReferenceCurrency { get; init; } 
    
    /// <summary>
    /// Language for all communication concerning the account.
    /// </summary>
    [IsoId("_RzXZGNp-Ed-ak6NoX_4Aeg_-1102972135")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; } 
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_RzXZGdp-Ed-ak6NoX_4Aeg_-1102972075")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; } 
    
    /// <summary>
    /// Method by which the tax (withholding tax) is to be processed i.e. either withheld at source or tax information reported to tax authorities or tax information is reported due to the provision of a tax certificate.
    /// </summary>
    [IsoId("_RzhKENp-Ed-ak6NoX_4Aeg_-1102972039")]
    [DisplayName("Tax Withholding Method")]
    [IsoXmlTag("TaxWhldgMtd")]
    public TaxWithholdingMethod1Code? TaxWithholdingMethod { get; init; } 
    
    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer&apos;s actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer. A letter of intent program is mainly used in the US market.
    /// </summary>
    [IsoId("_RzhKEdp-Ed-ak6NoX_4Aeg_-1102971773")]
    [DisplayName("Letter Intent Reference")]
    [IsoXmlTag("LttrInttRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LetterIntentReference { get; init; } 
    
    /// <summary>
    /// Reference of an accumulation rights program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_RzhKEtp-Ed-ak6NoX_4Aeg_-1102971731")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccumulationRightReference { get; init; } 
    
    /// <summary>
    /// Number of account owners or related parties required to authorise transactions on the account.
    /// </summary>
    [IsoId("_RzhKE9p-Ed-ak6NoX_4Aeg_-1102971144")]
    [DisplayName("Required Signatories Number")]
    [IsoXmlTag("ReqrdSgntriesNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RequiredSignatoriesNumber { get; init; } 
    
    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_RzhKFNp-Ed-ak6NoX_4Aeg_-1102971109")]
    [DisplayName("Fund Family Name")]
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? FundFamilyName { get; init; } 
    
    /// <summary>
    /// Detailed information about the investment fund associated to the account.
    /// </summary>
    [IsoId("_RzhKFdp-Ed-ak6NoX_4Aeg_-1102970680")]
    [DisplayName("Fund Details")]
    [IsoXmlTag("FndDtls")]
    public FinancialInstrument10? FundDetails { get; init; } 
    
    /// <summary>
    /// Parameters to be applied on deal amount for orders when the amount is a fractional number.
    /// </summary>
    [IsoId("_RzhKFtp-Ed-ak6NoX_4Aeg_-1102970567")]
    [DisplayName("Rounding Details")]
    [IsoXmlTag("RndgDtls")]
    public RoundingParameters1? RoundingDetails { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_RzhKF9p-Ed-ak6NoX_4Aeg_-1102970627")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    
    
    #nullable disable
    
}
