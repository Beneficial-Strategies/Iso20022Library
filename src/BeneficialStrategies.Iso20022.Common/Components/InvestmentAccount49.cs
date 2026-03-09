// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a securities account and its characteristics.
/// </summary>
[IsoId("_yf9dVyC6EeWPMvNwVtiMsA")]
[DisplayName("Investment Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentAccount49
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentAccount49 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentAccount49( OwnershipType2Choice_ reqOwnershipType )
    {
        OwnershipType = reqOwnershipType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_y8Y6iSC6EeWPMvNwVtiMsA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_y8Y6iyC6EeWPMvNwVtiMsA")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_y8Y6jSC6EeWPMvNwVtiMsA")]
    [DisplayName("Designation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dsgnt")]
    #endif
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Designation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Designation { get; init; } 
    #else
    public System.String? Designation { get; set; } 
    #endif
    
    /// <summary>
    /// Type of account.
    /// </summary>
    [IsoId("_y8Y6jyC6EeWPMvNwVtiMsA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountType2Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountType2Choice_? Type { get; init; } 
    #else
    public AccountType2Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Ownership status of the account, for example, joint owners.
    /// </summary>
    [IsoId("_y8Y6kSC6EeWPMvNwVtiMsA")]
    [DisplayName("Ownership Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnrshTp")]
    #endif
    [IsoXmlTag("OwnrshTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OwnershipType2Choice_ OwnershipType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OwnershipType2Choice_ OwnershipType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OwnershipType2Choice_ OwnershipType { get; init; } 
    #else
    public OwnershipType2Choice_ OwnershipType { get; set; } 
    #endif
    
    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    [IsoId("_y8Y6kyC6EeWPMvNwVtiMsA")]
    [DisplayName("Tax Exemption")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxXmptn")]
    #endif
    [IsoXmlTag("TaxXmptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxExemptionReason2Choice_? TaxExemption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxExemptionReason2Choice_? TaxExemption { get; init; } 
    #else
    public TaxExemptionReason2Choice_? TaxExemption { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency at which a statement is issued.
    /// </summary>
    [IsoId("_y8Y6lSC6EeWPMvNwVtiMsA")]
    [DisplayName("Statement Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtFrqcy")]
    #endif
    [IsoXmlTag("StmtFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatementFrequencyReason2Choice_? StatementFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementFrequencyReason2Choice_? StatementFrequency { get; init; } 
    #else
    public StatementFrequencyReason2Choice_? StatementFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency chosen for reporting purposes by the account owner in agreement with the account servicer.
    /// </summary>
    [IsoId("_y8Y6lyC6EeWPMvNwVtiMsA")]
    [DisplayName("Reference Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefCcy")]
    #endif
    [IsoXmlTag("RefCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? ReferenceCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? ReferenceCurrency { get; init; } 
    #else
    public string? ReferenceCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Language for all communication concerning the account.
    /// </summary>
    [IsoId("_y8Y6mSC6EeWPMvNwVtiMsA")]
    [DisplayName("Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lang")]
    #endif
    [IsoXmlTag("Lang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? Language { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Language { get; init; } 
    #else
    public string? Language { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_y8Y6myC6EeWPMvNwVtiMsA")]
    [DisplayName("Income Preference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmPref")]
    #endif
    [IsoXmlTag("IncmPref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IncomePreference2Code? IncomePreference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncomePreference2Code? IncomePreference { get; init; } 
    #else
    public IncomePreference2Code? IncomePreference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies, for income on the fund or security that is to be reinvested, parameters for the reinvestment. If the reinvestment percentage is less than one hundred percent, the remaining percentage will be invested according to the investor’s or account owner&apos;s subsequent instructions.
    /// </summary>
    [IsoId("_y8Y6nSC6EeWPMvNwVtiMsA")]
    [DisplayName("Reinvestment Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstmtDtls")]
    #endif
    [IsoXmlTag("RinvstmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reinvestment2? ReinvestmentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reinvestment2? ReinvestmentDetails { get; init; } 
    #else
    public Reinvestment2? ReinvestmentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Method by which the tax (withholding tax) is to be processed, that is, either withheld at source or tax information is reported to tax authorities or tax information is reported due to the provision of a tax certificate.
    /// </summary>
    [IsoId("_y8Y6nyC6EeWPMvNwVtiMsA")]
    [DisplayName("Tax Withholding Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxWhldgMtd")]
    #endif
    [IsoXmlTag("TaxWhldgMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxWithholdingMethod3Code? TaxWithholdingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxWithholdingMethod3Code? TaxWithholdingMethod { get; init; } 
    #else
    public TaxWithholdingMethod3Code? TaxWithholdingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Details for the reporting of tax, for example, the country of taxation.
    /// </summary>
    [IsoId("_WgQXcSDCEeWPMvNwVtiMsA")]
    [DisplayName("Tax Reporting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRptg")]
    #endif
    [IsoXmlTag("TaxRptg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxReporting1? TaxReporting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxReporting1? TaxReporting { get; init; } 
    #else
    public TaxReporting1? TaxReporting { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the letter of intent.
    /// </summary>
    [IsoId("_y8Y6oSC6EeWPMvNwVtiMsA")]
    [DisplayName("Letter Intent Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LttrInttDtls")]
    #endif
    [IsoXmlTag("LttrInttDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LetterIntent1? LetterIntentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LetterIntent1? LetterIntentDetails { get; init; } 
    #else
    public LetterIntent1? LetterIntentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of an accumulation rights program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_y8Y6oyC6EeWPMvNwVtiMsA")]
    [DisplayName("Accumulation Right Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcmltnRghtRef")]
    #endif
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccumulationRightReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccumulationRightReference { get; init; } 
    #else
    public System.String? AccumulationRightReference { get; set; } 
    #endif
    
    /// <summary>
    /// Number of account owners or related parties required to authorise transactions on the account.
    /// </summary>
    [IsoId("_y8Y6pSC6EeWPMvNwVtiMsA")]
    [DisplayName("Required Signatories Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqrdSgntriesNb")]
    #endif
    [IsoXmlTag("ReqrdSgntriesNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? RequiredSignatoriesNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RequiredSignatoriesNumber { get; init; } 
    #else
    public System.UInt64? RequiredSignatoriesNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_y8Y6pyC6EeWPMvNwVtiMsA")]
    [DisplayName("Fund Family Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndFmlyNm")]
    #endif
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? FundFamilyName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FundFamilyName { get; init; } 
    #else
    public System.String? FundFamilyName { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information about the investment fund or security associated to the account.
    /// </summary>
    [IsoId("_y8Y6qSC6EeWPMvNwVtiMsA")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument51? FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument51? FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument51? FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters to be applied on deal amount for orders when the amount is a fractional number.
    /// </summary>
    [IsoId("_y8Y6qyC6EeWPMvNwVtiMsA")]
    [DisplayName("Rounding Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndgDtls")]
    #endif
    [IsoXmlTag("RndgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RoundingParameters1? RoundingDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RoundingParameters1? RoundingDetails { get; init; } 
    #else
    public RoundingParameters1? RoundingDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_y8Y6rSC6EeWPMvNwVtiMsA")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification70Choice_? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification70Choice_? AccountServicer { get; init; } 
    #else
    public PartyIdentification70Choice_? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the account is blocked and other factors for the blocked account.
    /// </summary>
    [IsoId("_y8Y6ryC6EeWPMvNwVtiMsA")]
    [DisplayName("Blocked Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckdSts")]
    #endif
    [IsoXmlTag("BlckdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Blocked2? BlockedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Blocked2? BlockedStatus { get; init; } 
    #else
    public Blocked2? BlockedStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of usage of the account.
    /// </summary>
    [IsoId("_y8Y6sSC6EeWPMvNwVtiMsA")]
    [DisplayName("Account Usage Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctUsgTp")]
    #endif
    [IsoXmlTag("AcctUsgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountUsageType2Choice_? AccountUsageType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountUsageType2Choice_? AccountUsageType { get; init; } 
    #else
    public AccountUsageType2Choice_? AccountUsageType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if documentary evidence has been provided for the foreign resident.
    /// </summary>
    [IsoId("_y8Y6syC6EeWPMvNwVtiMsA")]
    [DisplayName("Foreign Status Certification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrgnStsCertfctn")]
    #endif
    [IsoXmlTag("FrgnStsCertfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Provided1Code? ForeignStatusCertification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Provided1Code? ForeignStatusCertification { get; init; } 
    #else
    public Provided1Code? ForeignStatusCertification { get; set; } 
    #endif
    
    /// <summary>
    /// Date the investor or account owner signs the open account form.
    /// </summary>
    [IsoId("_y8Y6tSC6EeWPMvNwVtiMsA")]
    [DisplayName("Account Signature Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSgntrDtTm")]
    #endif
    [IsoXmlTag("AcctSgntrDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? AccountSignatureDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? AccountSignatureDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? AccountSignatureDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the means by which the investor or account owner submits the open account form.
    /// </summary>
    [IsoId("_y8Y6tyC6EeWPMvNwVtiMsA")]
    [DisplayName("Transaction Channel Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxChanlTp")]
    #endif
    [IsoXmlTag("TxChanlTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; } 
    #else
    public TransactionChannelType1Choice_? TransactionChannelType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the category of the account.
    /// </summary>
    [IsoId("_y8Y6uSC6EeWPMvNwVtiMsA")]
    [DisplayName("Investment Account Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctCtgy")]
    #endif
    [IsoXmlTag("InvstmtAcctCtgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountCategory1Choice_? InvestmentAccountCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountCategory1Choice_? InvestmentAccountCategory { get; init; } 
    #else
    public InvestmentAccountCategory1Choice_? InvestmentAccountCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the holdings in the account are eligible for pledging.
    /// </summary>
    [IsoId("_Kv_D0yDBEeWPMvNwVtiMsA")]
    [DisplayName("Pledging")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pldgg")]
    #endif
    [IsoXmlTag("Pldgg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Eligible1Code? Pledging { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Eligible1Code? Pledging { get; init; } 
    #else
    public Eligible1Code? Pledging { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the holdings in the account are used as collateral.
    /// </summary>
    [IsoId("_Kv_D1CDBEeWPMvNwVtiMsA")]
    [DisplayName("Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Coll")]
    #endif
    [IsoXmlTag("Coll")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Collateral1Code? Collateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Collateral1Code? Collateral { get; init; } 
    #else
    public Collateral1Code? Collateral { get; set; } 
    #endif
    
    /// <summary>
    /// Details of third party rights.
    /// </summary>
    [IsoId("_Kv_D1SDBEeWPMvNwVtiMsA")]
    [DisplayName("Third Party Rights")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrdPtyRghts")]
    #endif
    [IsoXmlTag("ThrdPtyRghts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ThirdPartyRights1? ThirdPartyRights { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ThirdPartyRights1? ThirdPartyRights { get; init; } 
    #else
    public ThirdPartyRights1? ThirdPartyRights { get; set; } 
    #endif
    
    /// <summary>
    /// Functionality permitted to a third party in the actions that may be taken on an account on behalf of the investor.
    /// </summary>
    [IsoId("_GfKc8CDDEeWPMvNwVtiMsA")]
    [DisplayName("Power Of Attorney Level Of Control")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrOfAttnyLvlOfCtrl")]
    #endif
    [IsoXmlTag("PwrOfAttnyLvlOfCtrl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LevelOfControl1Choice_? PowerOfAttorneyLevelOfControl { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LevelOfControl1Choice_? PowerOfAttorneyLevelOfControl { get; init; } 
    #else
    public LevelOfControl1Choice_? PowerOfAttorneyLevelOfControl { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the account is regarded as domestic or non-domestic for reporting purposes.
    /// </summary>
    [IsoId("_4Qb38CDDEeWPMvNwVtiMsA")]
    [DisplayName("Accounting Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctgSts")]
    #endif
    [IsoXmlTag("AcctgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountingStatus1Choice_? AccountingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountingStatus1Choice_? AccountingStatus { get; init; } 
    #else
    public AccountingStatus1Choice_? AccountingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Legal opening date for the account.
    /// </summary>
    [IsoId("__TVdgCDEEeWPMvNwVtiMsA")]
    [DisplayName("Opening Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngDt")]
    #endif
    [IsoXmlTag("OpngDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? OpeningDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? OpeningDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? OpeningDate { get; set; } 
    #endif
    
    /// <summary>
    /// Legal closing date for the account.
    /// </summary>
    [IsoId("_Dmk0UCDFEeWPMvNwVtiMsA")]
    [DisplayName("Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgDt")]
    #endif
    [IsoXmlTag("ClsgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? ClosingDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account can hold a negative position in a security.
    /// </summary>
    [IsoId("_SFnQwCDFEeWPMvNwVtiMsA")]
    [DisplayName("Negative Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NegInd")]
    #endif
    [IsoXmlTag("NegInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? NegativeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NegativeIndicator { get; init; } 
    #else
    public System.String? NegativeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Order in which securities are moved from the account.
    /// </summary>
    [IsoId("_d7kyICDFEeWPMvNwVtiMsA")]
    [DisplayName("Processing Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgOrdr")]
    #endif
    [IsoXmlTag("PrcgOrdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionEffect3Code? ProcessingOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionEffect3Code? ProcessingOrder { get; init; } 
    #else
    public PositionEffect3Code? ProcessingOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the investor assumes responsibility for the liability.
    /// </summary>
    [IsoId("_OAd8ICDMEeWPMvNwVtiMsA")]
    [DisplayName("Liability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lblty")]
    #endif
    [IsoXmlTag("Lblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Liability1Choice_? Liability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Liability1Choice_? Liability { get; init; } 
    #else
    public Liability1Choice_? Liability { get; set; } 
    #endif
    
    /// <summary>
    /// Information used to determine fees and types of operations that can be carried out on the account.
    /// </summary>
    [IsoId("_StOwwCDNEeWPMvNwVtiMsA")]
    [DisplayName("Investor Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrPrfl")]
    #endif
    [IsoXmlTag("InvstrPrfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorProfile1? InvestorProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorProfile1? InvestorProfile { get; init; } 
    #else
    public InvestorProfile1? InvestorProfile { get; set; } 
    #endif
    
    /// <summary>
    /// Fiscal year, when not the same as the calendar year.
    /// </summary>
    [IsoId("_3C9scFxREeW8MLuBzR10cg")]
    [DisplayName("Fiscal Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FsclYr")]
    #endif
    [IsoXmlTag("FsclYr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FiscalYear1Choice_? FiscalYear { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FiscalYear1Choice_? FiscalYear { get; init; } 
    #else
    public FiscalYear1Choice_? FiscalYear { get; set; } 
    #endif
    
    
    #nullable disable
    
}
