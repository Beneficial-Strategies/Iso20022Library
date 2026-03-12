// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the sub-class according to one of the segmentation criteria defined as per local regulation.
/// </summary>
[IsoId("_HcjrYGkjEeq2H8ygpnTfYw")]
[DisplayName("Non Equity Sub Class Segmentation Criterion")]
public partial record NonEquitySubClassSegmentationCriterion1
{
    #nullable enable
    
    /// <summary>
    /// Criteria used to segment classes of derivative instruments into sub classes as per local regulation.
    /// </summary>
    [IsoId("_c6RKIGkjEeq2H8ygpnTfYw")]
    [DisplayName("Criteria Name")]
    [IsoXmlTag("CritNm")]
    public required NonEquitySubClassSegmentationCriteria1Code CriteriaName { get; init; } 
    
    /// <summary>
    /// Value identifying the sub class with respect to a segmentation criteria as per local regulation.
    /// </summary>
    [IsoId("_uW3j4GkjEeq2H8ygpnTfYw")]
    [DisplayName("Criteria Value")]
    [IsoXmlTag("CritVal")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    public required IsoMax1000Text CriteriaValue { get; init; } 
    
    
    #nullable disable
    
}
