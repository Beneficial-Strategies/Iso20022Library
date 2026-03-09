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
/// Specifies the loan data details in case of a securities lending transaction.
/// </summary>
[IsoId("_F8Sz8cguEeuGrNSsxk3B0A")]
[DisplayName("Loan Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoanData134
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the type of the transaction.
    /// </summary>
    [IsoId("_F9r7E8guEeuGrNSsxk3B0A")]
    [DisplayName("Contract Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctTp")]
    #endif
    [IsoXmlTag("CtrctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureType10Code? ContractType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureType10Code? ContractType { get; init; } 
    #else
    public ExposureType10Code? ContractType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the contract has been cleared.
    /// </summary>
    [IsoId("_F9r7FcguEeuGrNSsxk3B0A")]
    [DisplayName("Cleared")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Clrd")]
    #endif
    [IsoXmlTag("Clrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? Cleared { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Cleared { get; init; } 
    #else
    public System.String? Cleared { get; set; } 
    #endif
    
    /// <summary>
    /// Unique code determined by the reporting counterparty identifying the portfolio.
    /// </summary>
    [IsoId("_F9r7F8guEeuGrNSsxk3B0A")]
    [DisplayName("Portfolio Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtflCd")]
    #endif
    [IsoXmlTag("PrtflCd")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? PortfolioCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PortfolioCode { get; init; } 
    #else
    public System.String? PortfolioCode { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the trading venue where the transaction was executed.
    /// </summary>
    [IsoId("_F9r7GcguEeuGrNSsxk3B0A")]
    [DisplayName("Trading Venue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgVn")]
    #endif
    [IsoXmlTag("TradgVn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradingVenueType1Choice_? TradingVenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingVenueType1Choice_? TradingVenue { get; init; } 
    #else
    public TradingVenueType1Choice_? TradingVenue { get; set; } 
    #endif
    
    /// <summary>
    /// Type of agreement expressed as a code set. Reference to the master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    [IsoId("_F9r7G8guEeuGrNSsxk3B0A")]
    [DisplayName("Master Agreement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrAgrmtTp")]
    #endif
    [IsoXmlTag("MstrAgrmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalAgreementType1Code? MasterAgreementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAgreementType1Code? MasterAgreementType { get; init; } 
    #else
    public ExternalAgreementType1Code? MasterAgreementType { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the closing leg (forward leg) of the secured financing transaction. This information shall not be reported for open term agreements.
    /// </summary>
    [IsoId("_F9r7HcguEeuGrNSsxk3B0A")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MaturityDate { get; init; } 
    #else
    public System.DateOnly? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indication whether the secured financing transaction is subject to a general or special collateral arrangement.
    /// </summary>
    [IsoId("_F9r7H8guEeuGrNSsxk3B0A")]
    [DisplayName("General Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlColl")]
    #endif
    [IsoXmlTag("GnlColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SpecialCollateral1Code? GeneralCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SpecialCollateral1Code? GeneralCollateral { get; init; } 
    #else
    public SpecialCollateral1Code? GeneralCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Period before or at the end of which the loan should be repaid or renegotiated for another term. 
    /// </summary>
    [IsoId("_F9r7IcguEeuGrNSsxk3B0A")]
    [DisplayName("Term")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Term")]
    #endif
    [IsoXmlTag("Term")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractTerm6Choice_? Term { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractTerm6Choice_? Term { get; init; } 
    #else
    public ContractTerm6Choice_? Term { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate of the loan.
    /// </summary>
    [IsoId("_F9r7I8guEeuGrNSsxk3B0A")]
    [DisplayName("Rates")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rates")]
    #endif
    [IsoXmlTag("Rates")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rates1Choice_? Rates { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rates1Choice_? Rates { get; init; } 
    #else
    public Rates1Choice_? Rates { get; set; } 
    #endif
    
    /// <summary>
    /// Medium of exchange of currency.
    /// </summary>
    [IsoId("_F9r7JcguEeuGrNSsxk3B0A")]
    [DisplayName("Principal Amount Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrncplAmtCcy")]
    #endif
    [IsoXmlTag("PrncplAmtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? PrincipalAmountCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? PrincipalAmountCurrency { get; init; } 
    #else
    public string? PrincipalAmountCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the the security or commodity price is denominated.
    /// </summary>
    [IsoId("_F9r7J8guEeuGrNSsxk3B0A")]
    [DisplayName("Price Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricCcy")]
    #endif
    [IsoXmlTag("PricCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? PriceCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? PriceCurrency { get; init; } 
    #else
    public string? PriceCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Data specific to securities being subject to the transaction.
    /// </summary>
    [IsoId("_F9r7KcguEeuGrNSsxk3B0A")]
    [DisplayName("Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scty")]
    #endif
    [IsoXmlTag("Scty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Security49? Security { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Security49? Security { get; init; } 
    #else
    public Security49? Security { get; set; } 
    #endif
    
    /// <summary>
    /// Margin loans in base currency.
    /// </summary>
    [IsoId("_F9r7K8guEeuGrNSsxk3B0A")]
    [DisplayName("Outstanding Margin Loan Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutsdngMrgnLnCcy")]
    #endif
    [IsoXmlTag("OutsdngMrgnLnCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? OutstandingMarginLoanCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? OutstandingMarginLoanCurrency { get; init; } 
    #else
    public string? OutstandingMarginLoanCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
