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
[IsoId("_J-WeURKLEeKj15WxqwlXPw")]
[DisplayName("Investment Account")]
public partial record InvestmentAccount36
{
    #nullable enable
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_KT9iGRKLEeKj15WxqwlXPw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_KT9iHRKLEeKj15WxqwlXPw")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; } 
    
    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, for example, wrapper, ISA.
    /// </summary>
    [IsoId("_nkBeZhdPEeK5g-3oYI0_9Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public AccountType1Choice_? Type { get; init; } 
    
    /// <summary>
    /// Ownership status of the account, for example, joint owners.
    /// </summary>
    [IsoId("_nkBebRdPEeK5g-3oYI0_9Q")]
    [DisplayName("Ownership Type")]
    [IsoXmlTag("OwnrshTp")]
    public required OwnershipType1Choice_ OwnershipType { get; init; } 
    
    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    [IsoId("_nkBedBdPEeK5g-3oYI0_9Q")]
    [DisplayName("Tax Exemption")]
    [IsoXmlTag("TaxXmptn")]
    public TaxExemptionReason1Choice_? TaxExemption { get; init; } 
    
    /// <summary>
    /// Frequency at which a statement is issued.
    /// </summary>
    [IsoId("_nkBeexdPEeK5g-3oYI0_9Q")]
    [DisplayName("Statement Frequency")]
    [IsoXmlTag("StmtFrqcy")]
    public StatementFrequencyReason1Choice_? StatementFrequency { get; init; } 
    
    /// <summary>
    /// Currency chosen for reporting purposes by the account owner in agreement with the account servicer.
    /// </summary>
    [IsoId("_KT9iQRKLEeKj15WxqwlXPw")]
    [DisplayName("Reference Currency")]
    [IsoXmlTag("RefCcy")]
    public ActiveCurrencyCode? ReferenceCurrency { get; init; } 
    
    /// <summary>
    /// Language for all communication concerning the account.
    /// </summary>
    [IsoId("_KT9iRRKLEeKj15WxqwlXPw")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; } 
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_KT9iSRKLEeKj15WxqwlXPw")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; } 
    
    /// <summary>
    /// Method by which the tax (withholding tax) is to be processed i.e. either withheld at source or tax information reported to tax authorities or tax information is reported due to the provision of a tax certificate.
    /// </summary>
    [IsoId("_KT9iTRKLEeKj15WxqwlXPw")]
    [DisplayName("Tax Withholding Method")]
    [IsoXmlTag("TaxWhldgMtd")]
    public TaxWithholdingMethod2Code? TaxWithholdingMethod { get; init; } 
    
    /// <summary>
    /// Details of the letter of intent.
    /// </summary>
    [IsoId("_KT9iURKLEeKj15WxqwlXPw")]
    [DisplayName("Letter Intent Details")]
    [IsoXmlTag("LttrInttDtls")]
    public LetterIntent1? LetterIntentDetails { get; init; } 
    
    /// <summary>
    /// Reference of an accumulation rights program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_KT9iVRKLEeKj15WxqwlXPw")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccumulationRightReference { get; init; } 
    
    /// <summary>
    /// Number of account owners or related parties required to authorise transactions on the account.
    /// </summary>
    [IsoId("_KT9iWRKLEeKj15WxqwlXPw")]
    [DisplayName("Required Signatories Number")]
    [IsoXmlTag("ReqrdSgntriesNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RequiredSignatoriesNumber { get; init; } 
    
    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_KT9iXRKLEeKj15WxqwlXPw")]
    [DisplayName("Fund Family Name")]
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? FundFamilyName { get; init; } 
    
    /// <summary>
    /// Detailed information about the investment fund associated to the account.
    /// </summary>
    [IsoId("_KT9iYRKLEeKj15WxqwlXPw")]
    [DisplayName("Modified Fund Details")]
    [IsoXmlTag("ModfdFndDtls")]
    public ModificationScope13? ModifiedFundDetails { get; init; } 
    
    /// <summary>
    /// Parameters to be applied on deal amount for orders when the amount is a fractional number.
    /// </summary>
    [IsoId("_KT9iZRKLEeKj15WxqwlXPw")]
    [DisplayName("Rounding Details")]
    [IsoXmlTag("RndgDtls")]
    public RoundingParameters1? RoundingDetails { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_KT9iaRKLEeKj15WxqwlXPw")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    
    /// <summary>
    /// Specifies information about blocked accounts.
    /// </summary>
    [IsoId("_QhsPhxKLEeKj15WxqwlXPw")]
    [DisplayName("Blocked Status")]
    [IsoXmlTag("BlckdSts")]
    public Blocked1? BlockedStatus { get; init; } 
    
    /// <summary>
    /// Specifies the type of usage of the account.
    /// </summary>
    [IsoId("_yZnzRxKLEeKj15WxqwlXPw")]
    [DisplayName("Account Usage Type")]
    [IsoXmlTag("AcctUsgTp")]
    public AccountUsageType1Choice_? AccountUsageType { get; init; } 
    
    /// <summary>
    /// Specifies if documentary evidence has been provided for the foreign resident.
    /// </summary>
    [IsoId("_9sz-xxKLEeKj15WxqwlXPw")]
    [DisplayName("Foreign Status Certification")]
    [IsoXmlTag("FrgnStsCertfctn")]
    public Provided1Code? ForeignStatusCertification { get; init; } 
    
    /// <summary>
    /// Date the investor signs the open account form.
    /// </summary>
    [IsoId("_TJuMRxKMEeKj15WxqwlXPw")]
    [DisplayName("Account Signature Date Time")]
    [IsoXmlTag("AcctSgntrDtTm")]
    public DateAndDateTimeChoice_? AccountSignatureDateTime { get; init; } 
    
    
    #nullable disable
    
}
