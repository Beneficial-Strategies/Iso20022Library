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
/// Distribution strategy criteria.
/// </summary>
[IsoId("_XogS0DcfEeidBoT_PugKiA")]
[DisplayName("Distribution Strategy")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DistributionStrategy1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies to whom the product can be sold on an execution-only basis. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 06010.
    /// </summary>
    [IsoId("_gJ328DcfEeidBoT_PugKiA")]
    [DisplayName("Execution Only")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnOnly")]
    #endif
    [IsoXmlTag("ExctnOnly")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionStrategy1Choice_? ExecutionOnly { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionStrategy1Choice_? ExecutionOnly { get; init; } 
    #else
    public DistributionStrategy1Choice_? ExecutionOnly { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies to whom the product can be sold with an appropriateness test or to a non-advised service. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 06020.
    /// </summary>
    [IsoId("_pbLDMDcfEeidBoT_PugKiA")]
    [DisplayName("Execution With Appropriateness Test Or Non Advised Services")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnWthApprprtnssTstOrNonAdvsdSvcs")]
    #endif
    [IsoXmlTag("ExctnWthApprprtnssTstOrNonAdvsdSvcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionStrategy1Choice_? ExecutionWithAppropriatenessTestOrNonAdvisedServices { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionStrategy1Choice_? ExecutionWithAppropriatenessTestOrNonAdvisedServices { get; init; } 
    #else
    public DistributionStrategy1Choice_? ExecutionWithAppropriatenessTestOrNonAdvisedServices { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies to whom the product can be sold if investment advice has been provided. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 06030.
    /// </summary>
    [IsoId("_s0S7IDcfEeidBoT_PugKiA")]
    [DisplayName("Investment Advice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAdvc")]
    #endif
    [IsoXmlTag("InvstmtAdvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionStrategy1Choice_? InvestmentAdvice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionStrategy1Choice_? InvestmentAdvice { get; init; } 
    #else
    public DistributionStrategy1Choice_? InvestmentAdvice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies to whom the product can be sold if portfolio management has been provided. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 06040.
    /// </summary>
    [IsoId("_wMPuYDcfEeidBoT_PugKiA")]
    [DisplayName("Portfolio Management")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtflMgmt")]
    #endif
    [IsoXmlTag("PrtflMgmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionStrategy1Choice_? PortfolioManagement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionStrategy1Choice_? PortfolioManagement { get; init; } 
    #else
    public DistributionStrategy1Choice_? PortfolioManagement { get; set; } 
    #endif
    
    /// <summary>
    /// Other distribution strategy.
    /// </summary>
    [IsoId("_zDR3kD8PEeih8-WNbS6hbA")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherDistributionStrategy1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherDistributionStrategy1? Other { get; init; } 
    #else
    public OtherDistributionStrategy1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
