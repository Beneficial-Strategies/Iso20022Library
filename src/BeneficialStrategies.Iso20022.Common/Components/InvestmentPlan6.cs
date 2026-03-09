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
/// Plan that allows investors to schedule periodical investments or divestments, according to pre-defined criteria.
/// </summary>
[IsoId("_8Cb1kRQVEeKebsB9eKJSkA")]
[DisplayName("Investment Plan")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentPlan6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentPlan6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentPlan6( Frequency19Choice_ reqFrequency,UnitsOrAmount1Choice_ reqQuantity )
    {
        Frequency = reqFrequency;
        Quantity = reqQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Frequency of the investment or divestment.
    /// </summary>
    [IsoId("_FHMz4BdGEeK5g-3oYI0_9Q")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Frequency19Choice_ Frequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Frequency19Choice_ Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency19Choice_ Frequency { get; init; } 
    #else
    public Frequency19Choice_ Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Date the investment plan starts.
    /// </summary>
    [IsoId("_8YC5RRQVEeKebsB9eKJSkA")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StartDate { get; init; } 
    #else
    public System.DateOnly? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date the investment plan stops.
    /// </summary>
    [IsoId("_8YC5SRQVEeKebsB9eKJSkA")]
    [DisplayName("End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndDt")]
    #endif
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EndDate { get; init; } 
    #else
    public System.DateOnly? EndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the periodical payments.
    /// </summary>
    [IsoId("_cpWZMBQdEeKebsB9eKJSkA")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitsOrAmount1Choice_ Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitsOrAmount1Choice_ Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitsOrAmount1Choice_ Quantity { get; init; } 
    #else
    public UnitsOrAmount1Choice_ Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether an ordered amount is a gross amount (including all charges, commissions, tax). If it is not a gross amount, the ordered amount is a net amount (amount to be invested or redeemed from the fund to which other elements will be added).
    /// </summary>
    [IsoId("_8YC5URQVEeKebsB9eKJSkA")]
    [DisplayName("Gross Amount Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssAmtInd")]
    #endif
    [IsoXmlTag("GrssAmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? GrossAmountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GrossAmountIndicator { get; init; } 
    #else
    public System.String? GrossAmountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_8YC5VRQVEeKebsB9eKJSkA")]
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
    /// Number of pre-paid instalment periods at the time the investment plan is created.
    /// </summary>
    [IsoId("_8YC5WRQVEeKebsB9eKJSkA")]
    [DisplayName("Initial Number Of Instalment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlNbOfInstlmt")]
    #endif
    [IsoXmlTag("InitlNbOfInstlmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? InitialNumberOfInstalment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? InitialNumberOfInstalment { get; init; } 
    #else
    public System.UInt64? InitialNumberOfInstalment { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of times the amount must be invested at the predefined frequency as of the start date of the investment plan.
    /// </summary>
    [IsoId("_8YC5XRQVEeKebsB9eKJSkA")]
    [DisplayName("Total Number Of Instalment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfInstlmt")]
    #endif
    [IsoXmlTag("TtlNbOfInstlmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TotalNumberOfInstalment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalNumberOfInstalment { get; init; } 
    #else
    public System.UInt64? TotalNumberOfInstalment { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the rounding direction when an amount is to be spread over several funds.
    /// </summary>
    [IsoId("_8YC5YRQVEeKebsB9eKJSkA")]
    [DisplayName("Rounding Direction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndgDrctn")]
    #endif
    [IsoXmlTag("RndgDrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RoundingDirection1Code? RoundingDirection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RoundingDirection1Code? RoundingDirection { get; init; } 
    #else
    public RoundingDirection1Code? RoundingDirection { get; set; } 
    #endif
    
    /// <summary>
    /// Security that an investment plan invests in, or from which the investment plan divests.
    /// </summary>
    [IsoId("_8YC5ZRQVEeKebsB9eKJSkA")]
    [DisplayName("Security Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyDtls")]
    #endif
    [IsoXmlTag("SctyDtls")]
    [MinLength(1)]
    [MaxLength(50)]
    public ValueList<Repartition2> SecurityDetails { get; init; } = new ValueList<Repartition2>(){};
    
    /// <summary>
    /// Cash settlement standing instruction associated to the investment plan.
    /// </summary>
    [IsoId("_8YC5aRQVEeKebsB9eKJSkA")]
    [DisplayName("Cash Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlm")]
    #endif
    [IsoXmlTag("CshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<InvestmentFundCashSettlementInformation5> CashSettlement { get; init; } = new ValueList<InvestmentFundCashSettlementInformation5>(){};
    
    /// <summary>
    /// Reference of the underlying investment contract. In some markets, such as Italy, this might be required to segregate holdings between the same investment account.
    /// </summary>
    [IsoId("_GbNnQBQWEeKebsB9eKJSkA")]
    [DisplayName("Contract Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctRef")]
    #endif
    [IsoXmlTag("CtrctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ContractReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ContractReference { get; init; } 
    #else
    public System.String? ContractReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the previous contract to which this savings or withdrawal plan is related.
    /// </summary>
    [IsoId("_gNvxOhQWEeKebsB9eKJSkA")]
    [DisplayName("Related Contract Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdCtrctRef")]
    #endif
    [IsoXmlTag("RltdCtrctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RelatedContractReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RelatedContractReference { get; init; } 
    #else
    public System.String? RelatedContractReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the product as designated by the fund manager. In some markets, such as Italy, the financial product or service related to a savings plan or withdrawal plan are identified by a product identification or number.
    /// </summary>
    [IsoId("_Ammu4BQXEeKebsB9eKJSkA")]
    [DisplayName("Product Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctId")]
    #endif
    [IsoXmlTag("PdctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProductIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductIdentification { get; init; } 
    #else
    public System.String? ProductIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the underlying service level agreement (SLA) governing charges and commission.
    /// </summary>
    [IsoId("_SmOWIBQXEeKebsB9eKJSkA")]
    [DisplayName("SLA Charge And Commission Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SLAChrgAndComssnRef")]
    #endif
    [IsoXmlTag("SLAChrgAndComssnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SLAChargeAndCommissionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SLAChargeAndCommissionReference { get; init; } 
    #else
    public System.String? SLAChargeAndCommissionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of insurance contract to which the savings investment plan is linked.
    /// </summary>
    [IsoId("_Du64wBQZEeKebsB9eKJSkA")]
    [DisplayName("Insurance Cover")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncCover")]
    #endif
    [IsoXmlTag("InsrncCover")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InsuranceType1Choice_? InsuranceCover { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InsuranceType1Choice_? InsuranceCover { get; init; } 
    #else
    public InsuranceType1Choice_? InsuranceCover { get; set; } 
    #endif
    
    
    #nullable disable
    
}
