// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
[IsoId("_TFZvigEcEeCQm6a_G2yO_w_265407285")]
[DisplayName("Detailed Amount")]
public partial record DetailedAmount1
{
    #nullable enable
    
    /// <summary>
    /// Type of amount.
    /// </summary>
    [IsoId("_TFZviwEcEeCQm6a_G2yO_w_-2015128884")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfAmount2Code Type { get; init; } 
    
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_TFZvjAEcEeCQm6a_G2yO_w_1942779583")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required ImpliedCurrencyAndAmount Value { get; init; } 
    
    
    #nullable disable
    
}
