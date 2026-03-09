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
/// Provides information about the sub-class according to one of the segmentation criteria defined as per local regulation.
/// </summary>
[IsoId("_HcjrYGkjEeq2H8ygpnTfYw")]
[DisplayName("Non Equity Sub Class Segmentation Criterion")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonEquitySubClassSegmentationCriterion1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NonEquitySubClassSegmentationCriterion1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NonEquitySubClassSegmentationCriterion1( NonEquitySubClassSegmentationCriteria1Code reqCriteriaName,System.String reqCriteriaValue )
    {
        CriteriaName = reqCriteriaName;
        CriteriaValue = reqCriteriaValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Criteria used to segment classes of derivative instruments into sub classes as per local regulation.
    /// </summary>
    [IsoId("_c6RKIGkjEeq2H8ygpnTfYw")]
    [DisplayName("Criteria Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CritNm")]
    #endif
    [IsoXmlTag("CritNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NonEquitySubClassSegmentationCriteria1Code CriteriaName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NonEquitySubClassSegmentationCriteria1Code CriteriaName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonEquitySubClassSegmentationCriteria1Code CriteriaName { get; init; } 
    #else
    public NonEquitySubClassSegmentationCriteria1Code CriteriaName { get; set; } 
    #endif
    
    /// <summary>
    /// Value identifying the sub class with respect to a segmentation criteria as per local regulation.
    /// </summary>
    [IsoId("_uW3j4GkjEeq2H8ygpnTfYw")]
    [DisplayName("Criteria Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CritVal")]
    #endif
    [IsoXmlTag("CritVal")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax1000Text CriteriaValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CriteriaValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CriteriaValue { get; init; } 
    #else
    public System.String CriteriaValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
