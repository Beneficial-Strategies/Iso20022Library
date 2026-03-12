// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for the method used to compute accruing interest of a financial instrument
/// </summary>
[IsoId("_lTIUEdSaEemZdYGWu384Zw")]
[DisplayName("Compare Interest Computation Method")]
public partial record CompareInterestComputationMethod2
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_lZJcgdSaEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public InterestComputationMethodFormat6Choice_? Value1 { get; init; } 
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_lZJcg9SaEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public InterestComputationMethodFormat6Choice_? Value2 { get; init; } 
    
    
    #nullable disable
    
}
