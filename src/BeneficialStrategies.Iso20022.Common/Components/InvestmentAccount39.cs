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
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
[IsoId("_G57u8RRAEeOKWo1NF21OVw")]
[DisplayName("Investment Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentAccount39
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentAccount39 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentAccount39( OwnershipType1Choice_ reqOwnershipType )
    {
        OwnershipType = reqOwnershipType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_HRiWpRRAEeOKWo1NF21OVw")]
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
    [IsoId("_HRiWpxRAEeOKWo1NF21OVw")]
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
    /// Purpose of the account/source fund type. This is typically linked to an investment product, for example, wrapper, ISA.
    /// </summary>
    [IsoId("_HRiWqRRAEeOKWo1NF21OVw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountType1Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountType1Choice_? Type { get; init; } 
    #else
    public AccountType1Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Ownership status of the account, for example, joint owners.
    /// </summary>
    [IsoId("_HRiWqxRAEeOKWo1NF21OVw")]
    [DisplayName("Ownership Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnrshTp")]
    #endif
    [IsoXmlTag("OwnrshTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OwnershipType1Choice_ OwnershipType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OwnershipType1Choice_ OwnershipType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OwnershipType1Choice_ OwnershipType { get; init; } 
    #else
    public OwnershipType1Choice_ OwnershipType { get; set; } 
    #endif
    
    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    [IsoId("_HRiWrRRAEeOKWo1NF21OVw")]
    [DisplayName("Tax Exemption")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxXmptn")]
    #endif
    [IsoXmlTag("TaxXmptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxExemptionReason1Choice_? TaxExemption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxExemptionReason1Choice_? TaxExemption { get; init; } 
    #else
    public TaxExemptionReason1Choice_? TaxExemption { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency at which a statement is issued.
    /// </summary>
    [IsoId("_HRiWrxRAEeOKWo1NF21OVw")]
    [DisplayName("Statement Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtFrqcy")]
    #endif
    [IsoXmlTag("StmtFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatementFrequencyReason1Choice_? StatementFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementFrequencyReason1Choice_? StatementFrequency { get; init; } 
    #else
    public StatementFrequencyReason1Choice_? StatementFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency chosen for reporting purposes by the account owner in agreement with the account servicer.
    /// </summary>
    [IsoId("_HRi9sRRAEeOKWo1NF21OVw")]
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
    [IsoId("_HRi9sxRAEeOKWo1NF21OVw")]
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
    [IsoId("_HRi9tRRAEeOKWo1NF21OVw")]
    [DisplayName("Income Preference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmPref")]
    #endif
    [IsoXmlTag("IncmPref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IncomePreference1Code? IncomePreference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncomePreference1Code? IncomePreference { get; init; } 
    #else
    public IncomePreference1Code? IncomePreference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies, for income on the fund that is to be reinvested, parameters for the reinvestment. If the reinvestment percentage is less than one hundred percent, the remaining percentage will be invested according to the investor’s subsequent instructions.
    /// </summary>
    [IsoId("_L33okRRAEeOKWo1NF21OVw")]
    [DisplayName("Reinvestment Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstmtDtls")]
    #endif
    [IsoXmlTag("RinvstmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reinvestment1? ReinvestmentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reinvestment1? ReinvestmentDetails { get; init; } 
    #else
    public Reinvestment1? ReinvestmentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Method by which the tax (withholding tax) is to be processed i.e. either withheld at source or tax information reported to tax authorities or tax information is reported due to the provision of a tax certificate.
    /// </summary>
    [IsoId("_HRi9txRAEeOKWo1NF21OVw")]
    [DisplayName("Tax Withholding Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxWhldgMtd")]
    #endif
    [IsoXmlTag("TaxWhldgMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxWithholdingMethod2Code? TaxWithholdingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxWithholdingMethod2Code? TaxWithholdingMethod { get; init; } 
    #else
    public TaxWithholdingMethod2Code? TaxWithholdingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the letter of intent.
    /// </summary>
    [IsoId("_HRi9uRRAEeOKWo1NF21OVw")]
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
    [IsoId("_HRi9uxRAEeOKWo1NF21OVw")]
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
    [IsoId("_HRi9vRRAEeOKWo1NF21OVw")]
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
    [IsoId("_HRi9vxRAEeOKWo1NF21OVw")]
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
    /// Detailed information about the investment fund associated to the account.
    /// </summary>
    [IsoId("_HRi9wRRAEeOKWo1NF21OVw")]
    [DisplayName("Modified Fund Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdFndDtls")]
    #endif
    [IsoXmlTag("ModfdFndDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ModificationScope13? ModifiedFundDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationScope13? ModifiedFundDetails { get; init; } 
    #else
    public ModificationScope13? ModifiedFundDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters to be applied on deal amount for orders when the amount is a fractional number.
    /// </summary>
    [IsoId("_HRi9wxRAEeOKWo1NF21OVw")]
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
    [IsoId("_HRi9xRRAEeOKWo1NF21OVw")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    #else
    public PartyIdentification2Choice_? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies information about blocked accounts.
    /// </summary>
    [IsoId("_HRi9xxRAEeOKWo1NF21OVw")]
    [DisplayName("Blocked Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckdSts")]
    #endif
    [IsoXmlTag("BlckdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Blocked1? BlockedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Blocked1? BlockedStatus { get; init; } 
    #else
    public Blocked1? BlockedStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of usage of the account.
    /// </summary>
    [IsoId("_HRi9yRRAEeOKWo1NF21OVw")]
    [DisplayName("Account Usage Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctUsgTp")]
    #endif
    [IsoXmlTag("AcctUsgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountUsageType1Choice_? AccountUsageType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountUsageType1Choice_? AccountUsageType { get; init; } 
    #else
    public AccountUsageType1Choice_? AccountUsageType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if documentary evidence has been provided for the foreign resident.
    /// </summary>
    [IsoId("_HRi9yxRAEeOKWo1NF21OVw")]
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
    /// Date the investor signs the open account form.
    /// </summary>
    [IsoId("_HRi9zRRAEeOKWo1NF21OVw")]
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
    /// Specifies the means by which the investor submits the open account form.
    /// </summary>
    [IsoId("_5ONhoRRGEeOKWo1NF21OVw")]
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
    /// Specifies the category of the investment account.
    /// </summary>
    [IsoId("_zKhO8RRIEeOKWo1NF21OVw")]
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
    
    
    #nullable disable
    
}
