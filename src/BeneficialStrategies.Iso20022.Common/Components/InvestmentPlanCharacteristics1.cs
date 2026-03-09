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
/// Characteristics of an investment plan.
/// </summary>
[IsoId("_iMh2EF8-Eeicg40_9gK9vQ")]
[DisplayName("Investment Plan Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentPlanCharacteristics1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentPlanCharacteristics1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentPlanCharacteristics1( InvestmentFundPlanType1Choice_ reqPlanType )
    {
        PlanType = reqPlanType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of investment plan.
    /// </summary>
    [IsoId("_rvZTcF8-Eeicg40_9gK9vQ")]
    [DisplayName("Plan Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlanTp")]
    #endif
    [IsoXmlTag("PlanTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentFundPlanType1Choice_ PlanType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentFundPlanType1Choice_ PlanType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundPlanType1Choice_ PlanType { get; init; } 
    #else
    public InvestmentFundPlanType1Choice_ PlanType { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency of the investment plan.
    /// </summary>
    [IsoId("_ucICoF9CEeicg40_9gK9vQ")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency20Choice_? Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency20Choice_? Frequency { get; init; } 
    #else
    public Frequency20Choice_? Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of times the amount must be invested at the predefined frequency as of the start date of the investment plan.
    /// </summary>
    [IsoId("_2xB4EV9CEeicg40_9gK9vQ")]
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
    /// Minimum amount of the periodical payments. (If there is no maximum, then &apos;0&apos; must be specified for the Amount or Units.)
    /// </summary>
    [IsoId("_Ag_WQV9DEeicg40_9gK9vQ")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitsOrAmount1Choice_? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitsOrAmount1Choice_? Quantity { get; init; } 
    #else
    public UnitsOrAmount1Choice_? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether it is possible to continue the savings plan after the end date.
    /// </summary>
    [IsoId("_MO0PUF9DEeicg40_9gK9vQ")]
    [DisplayName("Plan Continuation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlanConttn")]
    #endif
    [IsoXmlTag("PlanConttn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PlanContinuation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlanContinuation { get; init; } 
    #else
    public System.String? PlanContinuation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether it is possible to subscribe to additional instalments over and above that permitted by the savings plan frequency. 
    /// </summary>
    [IsoId("_lmY7kF9DEeicg40_9gK9vQ")]
    [DisplayName("Additional Subscription")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSbcpt")]
    #endif
    [IsoXmlTag("AddtlSbcpt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AdditionalSubscription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalSubscription { get; init; } 
    #else
    public System.String? AdditionalSubscription { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether any additional instalments will reduce the period of the life of the savings investment plan.
    /// </summary>
    [IsoId("_CyIdAF9EEeicg40_9gK9vQ")]
    [DisplayName("Additional Subscription Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSbcptFctn")]
    #endif
    [IsoXmlTag("AddtlSbcptFctn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AdditionalSubscriptionFunction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalSubscriptionFunction { get; init; } 
    #else
    public System.String? AdditionalSubscriptionFunction { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the investment plan.
    /// </summary>
    [IsoId("_qpMmsWAKEeiNMJ262H2pWg")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
