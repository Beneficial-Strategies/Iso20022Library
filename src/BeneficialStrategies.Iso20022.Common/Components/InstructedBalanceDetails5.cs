// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about total instructed balance.
/// </summary>
[IsoId("_lHIu_Tq5EeWQ1Y7f8kds2A")]
[DisplayName("Instructed Balance Details")]
public partial record InstructedBalanceDetails5
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_lTehwTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Total Instructed Balance")]
    [IsoXmlTag("TtlInstdBal")]
    public required BalanceFormat5Choice_ TotalInstructedBalance { get; init; } 
    
    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    [IsoId("_lTehwzq5EeWQ1Y7f8kds2A")]
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public InstructedCorporateActionOption6? OptionDetails { get; init; } 
    
    
    #nullable disable
    
}
