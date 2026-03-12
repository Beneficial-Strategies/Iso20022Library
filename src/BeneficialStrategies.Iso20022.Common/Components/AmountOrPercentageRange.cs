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
[IsoId("_Q7pG59p-Ed-ak6NoX_4Aeg_-736773993")]
[DisplayName("Amount Or Percentage Range")]
public partial record AmountOrPercentageRange
{
    #nullable enable
    
    /// <summary>
    /// Indication of the relationship between two variables.
    /// </summary>
    [IsoId("_Q7pG6Np-Ed-ak6NoX_4Aeg_-228359499")]
    [DisplayName("Operation")]
    [IsoXmlTag("Opr")]
    public Operation1Code? Operation { get; init; } 
    
    /// <summary>
    /// Indicates one of the constraints of a range of business values.
    /// </summary>
    [IsoId("_Q7yQ0Np-Ed-ak6NoX_4Aeg_-364732588")]
    [DisplayName("Term")]
    [IsoXmlTag("Term")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Term1> Term { get; init; } = new ValueList<Term1>(){};
    
    
    #nullable disable
    
}
