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
[IsoId("_RxlQaNp-Ed-ak6NoX_4Aeg_-196073540")]
[DisplayName("Investment Account")]
public partial record InvestmentAccount28
{
    #nullable enable
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_RxlQadp-Ed-ak6NoX_4Aeg_-196073522")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_RxlQatp-Ed-ak6NoX_4Aeg_-196073488")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; } 
    
    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, PEP, ISA.
    /// </summary>
    [IsoId("_RxvBYNp-Ed-ak6NoX_4Aeg_-196073197")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public FundCashAccount3Code? Type { get; init; } 
    
    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, PEP, ISA.
    /// </summary>
    [IsoId("_RxvBYdp-Ed-ak6NoX_4Aeg_-196073162")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedType { get; init; } 
    
    /// <summary>
    /// Ownership status of the account, eg, joint owners.
    /// </summary>
    [IsoId("_RxvBYtp-Ed-ak6NoX_4Aeg_-196073120")]
    [DisplayName("Ownership Type")]
    [IsoXmlTag("OwnrshTp")]
    public AccountOwnershipType3Code? OwnershipType { get; init; } 
    
    /// <summary>
    /// Ownership status of the account, eg, joint owners.
    /// </summary>
    [IsoId("_RxvBY9p-Ed-ak6NoX_4Aeg_-196073085")]
    [DisplayName("Extended Ownership Type")]
    [IsoXmlTag("XtndedOwnrshTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedOwnershipType { get; init; } 
    
    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    [IsoId("_RxvBZNp-Ed-ak6NoX_4Aeg_-196072609")]
    [DisplayName("Tax Exemption Reason")]
    [IsoXmlTag("TaxXmptnRsn")]
    public TaxExemptReason1Code? TaxExemptionReason { get; init; } 
    
    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    [IsoId("_RxvBZdp-Ed-ak6NoX_4Aeg_-196072574")]
    [DisplayName("Extended Tax Exemption Reason")]
    [IsoXmlTag("XtndedTaxXmptnRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedTaxExemptionReason { get; init; } 
    
    /// <summary>
    /// Regularity at which a statement is issued.
    /// </summary>
    [IsoId("_RxvBZtp-Ed-ak6NoX_4Aeg_-195152430")]
    [DisplayName("Statement Frequency")]
    [IsoXmlTag("StmtFrqcy")]
    public EventFrequency1Code? StatementFrequency { get; init; } 
    
    /// <summary>
    /// Regularity at which a statement is issued.
    /// </summary>
    [IsoId("_RxvBZ9p-Ed-ak6NoX_4Aeg_1761525776")]
    [DisplayName("Extended Statement Frequency")]
    [IsoXmlTag("XtndedStmtFrqcy")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedStatementFrequency { get; init; } 
    
    /// <summary>
    /// Currency chosen for reporting purposes by the account owner in agreement with the account servicer.
    /// </summary>
    [IsoId("_RxvBaNp-Ed-ak6NoX_4Aeg_-196073041")]
    [DisplayName("Reference Currency")]
    [IsoXmlTag("RefCcy")]
    public ActiveCurrencyCode? ReferenceCurrency { get; init; } 
    
    /// <summary>
    /// Language for all communication concerning the account.
    /// </summary>
    [IsoId("_Rx4LUNp-Ed-ak6NoX_4Aeg_-196073006")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; } 
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_Rx4LUdp-Ed-ak6NoX_4Aeg_-196072981")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; } 
    
    /// <summary>
    /// Method by which the tax (withholding tax) is to be processed i.e. either withheld at source or tax information reported to tax authorities or tax information is reported due to the provision of a tax certificate.
    /// </summary>
    [IsoId("_Rx4LUtp-Ed-ak6NoX_4Aeg_-196072946")]
    [DisplayName("Tax Withholding Method")]
    [IsoXmlTag("TaxWhldgMtd")]
    public TaxWithholdingMethod1Code? TaxWithholdingMethod { get; init; } 
    
    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer&apos;s actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer. A letter of intent program is mainly used in the US market.
    /// </summary>
    [IsoId("_Rx4LU9p-Ed-ak6NoX_4Aeg_-196072911")]
    [DisplayName("Letter Intent Reference")]
    [IsoXmlTag("LttrInttRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LetterIntentReference { get; init; } 
    
    /// <summary>
    /// Reference of an accumulation rights program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_Rx4LVNp-Ed-ak6NoX_4Aeg_-196072652")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccumulationRightReference { get; init; } 
    
    /// <summary>
    /// Number of account owners or related parties required to authorise transactions on the account.
    /// </summary>
    [IsoId("_Rx4LVdp-Ed-ak6NoX_4Aeg_-195152033")]
    [DisplayName("Required Signatories Number")]
    [IsoXmlTag("ReqrdSgntriesNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RequiredSignatoriesNumber { get; init; } 
    
    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_Rx4LVtp-Ed-ak6NoX_4Aeg_-195151938")]
    [DisplayName("Fund Family Name")]
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? FundFamilyName { get; init; } 
    
    /// <summary>
    /// Detailed information about the investment fund associated to the account.
    /// </summary>
    [IsoId("_Rx4LV9p-Ed-ak6NoX_4Aeg_-195151534")]
    [DisplayName("Modified Fund Details")]
    [IsoXmlTag("ModfdFndDtls")]
    public ModificationScope12? ModifiedFundDetails { get; init; } 
    
    /// <summary>
    /// Parameters to be applied on deal amount for orders when the amount is a fractional number.
    /// </summary>
    [IsoId("_Rx4LWNp-Ed-ak6NoX_4Aeg_-195151902")]
    [DisplayName("Rounding Details")]
    [IsoXmlTag("RndgDtls")]
    public RoundingParameters1? RoundingDetails { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_Rx4LWdp-Ed-ak6NoX_4Aeg_-195151594")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    
    
    #nullable disable
    
}
