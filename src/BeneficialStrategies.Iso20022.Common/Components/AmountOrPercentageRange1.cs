// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides constrains on a range of business values.
/// </summary>
[IsoId("_MVJmYZJOEeuAlLVx8pyt3w")]
[DisplayName("Amount Or Percentage Range")]
public partial record AmountOrPercentageRange1
{
    #nullable enable
    
    /// <summary>
    /// Indication of the relationship between two variables.
    /// </summary>
    [IsoId("_MXgV8ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Operation")]
    [IsoXmlTag("Opr")]
    public Operation1Code? Operation { get; init; } 
    
    /// <summary>
    /// Indicates one of the constraints of a range of business values.
    /// </summary>
    [IsoId("_MXgV85JOEeuAlLVx8pyt3w")]
    [DisplayName("Term")]
    [IsoXmlTag("Term")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Term1> Term { get; init; } = [];
    
    
    #nullable disable
    
}
