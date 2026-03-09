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
[IsoId("_ONWpx5S8EemqYPWMBuVawg")]
[DisplayName("Investment Plan")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentPlan16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentPlan16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentPlan16( Frequency20Choice_ reqFrequency,UnitsOrAmount1Choice_ reqQuantity )
    {
        Frequency = reqFrequency;
        Quantity = reqQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Frequency of the investment or divestment.
    /// </summary>
    [IsoId("_Ohu-U5S8EemqYPWMBuVawg")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Frequency20Choice_ Frequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Frequency20Choice_ Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency20Choice_ Frequency { get; init; } 
    #else
    public Frequency20Choice_ Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Date the investment plan starts.
    /// </summary>
    [IsoId("_Ohu-VZS8EemqYPWMBuVawg")]
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
    [IsoId("_Ohu-V5S8EemqYPWMBuVawg")]
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
    [IsoId("_Ohu-WZS8EemqYPWMBuVawg")]
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
    /// Indicates whether an ordered amount is a gross amount (including transaction overhead). If it is not a gross amount, the ordered amount is a net amount (amount to be invested or redeemed from the fund to which other elements will be added).
    /// </summary>
    [IsoId("_Ohu-W5S8EemqYPWMBuVawg")]
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
    [IsoId("_Ohu-XZS8EemqYPWMBuVawg")]
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
    /// Initial amount or number of initial instalments.
    /// </summary>
    [IsoId("_Ohu-X5S8EemqYPWMBuVawg")]
    [DisplayName("Initial Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlAmt")]
    #endif
    [IsoXmlTag("InitlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InitialAmount1Choice_? InitialAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InitialAmount1Choice_? InitialAmount { get; init; } 
    #else
    public InitialAmount1Choice_? InitialAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of times the amount must be invested at the predefined frequency as of the start date of the investment plan.
    /// </summary>
    [IsoId("_Ohu-YZS8EemqYPWMBuVawg")]
    [DisplayName("Total Number Of Instalments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfInstlmts")]
    #endif
    [IsoXmlTag("TtlNbOfInstlmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TotalNumberOfInstalments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalNumberOfInstalments { get; init; } 
    #else
    public System.UInt64? TotalNumberOfInstalments { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the rounding direction when an amount is to be spread over several funds.
    /// </summary>
    [IsoId("_Ohu-Y5S8EemqYPWMBuVawg")]
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
    [IsoId("_Ohu-ZZS8EemqYPWMBuVawg")]
    [DisplayName("Security Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyDtls")]
    #endif
    [IsoXmlTag("SctyDtls")]
    [MinLength(1)]
    [MaxLength(50)]
    public ValueList<Repartition6> SecurityDetails { get; init; } = new ValueList<Repartition6>(){};
    
    /// <summary>
    /// Cash settlement standing instruction associated to the investment plan and to be either inserted or deleted.
    /// </summary>
    [IsoId("_Ohu-Z5S8EemqYPWMBuVawg")]
    [DisplayName("Modified Cash Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdCshSttlm")]
    #endif
    [IsoXmlTag("ModfdCshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<CashSettlement4> ModifiedCashSettlement { get; init; } = new ValueList<CashSettlement4>(){};
    
    /// <summary>
    /// Reference of the underlying investment contract. In some markets, such as Italy, this might be required to segregate holdings between the same investment account.
    /// </summary>
    [IsoId("_Ohu-aZS8EemqYPWMBuVawg")]
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
    [IsoId("_Ohu-a5S8EemqYPWMBuVawg")]
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
    [IsoId("_Ohu-bZS8EemqYPWMBuVawg")]
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
    /// Reference of the underlying service level agreement (SLA) governing fees.
    /// </summary>
    [IsoId("_Ohu-b5S8EemqYPWMBuVawg")]
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
    [IsoId("_Ohu-cZS8EemqYPWMBuVawg")]
    [DisplayName("Insurance Cover")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncCover")]
    #endif
    [IsoXmlTag("InsrncCover")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InsuranceType2Choice_? InsuranceCover { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InsuranceType2Choice_? InsuranceCover { get; init; } 
    #else
    public InsuranceType2Choice_? InsuranceCover { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the savings or withdrawal investment plan.
    /// </summary>
    [IsoId("_Ohu-c5S8EemqYPWMBuVawg")]
    [DisplayName("Plan Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlanSts")]
    #endif
    [IsoXmlTag("PlanSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlanStatus2Choice_? PlanStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlanStatus2Choice_? PlanStatus { get; init; } 
    #else
    public PlanStatus2Choice_? PlanStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Role or function of the instalment manager.
    /// </summary>
    [IsoId("_Ohu-dZS8EemqYPWMBuVawg")]
    [DisplayName("Instalment Manager Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstlmtMgrRole")]
    #endif
    [IsoXmlTag("InstlmtMgrRole")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyRole4Choice_? InstalmentManagerRole { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyRole4Choice_? InstalmentManagerRole { get; init; } 
    #else
    public PartyRole4Choice_? InstalmentManagerRole { get; set; } 
    #endif
    
    
    #nullable disable
    
}
