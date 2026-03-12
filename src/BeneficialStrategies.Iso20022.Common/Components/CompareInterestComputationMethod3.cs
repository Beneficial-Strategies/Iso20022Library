// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for the method used to compute accruing interest of a financial instrument.
/// </summary>
[IsoId("_Dhvyga5jEeuo-IflVgGqiA")]
[DisplayName("Compare Interest Computation Method")]
public partial record CompareInterestComputationMethod3
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_DxiiAa5jEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public InterestComputationMethodFormat6Choice_? Value1 { get; init; } 
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_DxiiA65jEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public InterestComputationMethodFormat6Choice_? Value2 { get; init; } 
    
    
    #nullable disable
    
}
