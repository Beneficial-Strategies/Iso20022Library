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
/// Sub-class of non-equity instruments sharing common characteristics according to criteria defined as per local regulation.
/// </summary>
[IsoId("_POi7M6aTEeqZmriXpMtonA")]
[DisplayName("Non Equity Sub Class")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonEquitySubClass1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Description of the derivative sub-class.
    /// </summary>
    [IsoId("_MOvhwKcNEeqV1IdfYLo35g")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1000Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Criteria used to segment classes of derivative instruments into sub classes as per local regulation.
    /// </summary>
    [IsoId("_POi7NKaTEeqZmriXpMtonA")]
    [DisplayName("Segmentation Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgmttnCrit")]
    #endif
    [IsoXmlTag("SgmttnCrit")]
    public ValueList<NonEquitySubClassSegmentationCriterion1> SegmentationCriteria { get; init; } = new ValueList<NonEquitySubClassSegmentationCriterion1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _POi7NKaTEeqZmriXpMtonA
    
    
    #nullable disable
    
}
