// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sub-class of non-equity instruments sharing common characteristics according to criteria defined as per local regulation.
/// </summary>
[IsoId("_POi7M6aTEeqZmriXpMtonA")]
[DisplayName("Non Equity Sub Class")]
public partial record NonEquitySubClass1
{
    #nullable enable
    
    /// <summary>
    /// Description of the derivative sub-class.
    /// </summary>
    [IsoId("_MOvhwKcNEeqV1IdfYLo35g")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    public IsoMax1000Text? Description { get; init; } 
    
    /// <summary>
    /// Criteria used to segment classes of derivative instruments into sub classes as per local regulation.
    /// </summary>
    [IsoId("_POi7NKaTEeqZmriXpMtonA")]
    [DisplayName("Segmentation Criteria")]
    [IsoXmlTag("SgmttnCrit")]
    public ValueList<NonEquitySubClassSegmentationCriterion1> SegmentationCriteria { get; init; } = [];
    // ID for the above is _POi7NKaTEeqZmriXpMtonA
    
    
    #nullable disable
    
}
