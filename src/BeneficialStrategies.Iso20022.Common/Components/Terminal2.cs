// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment terminal or ATM performing the transaction
/// </summary>
[IsoId("_NOLh0U9YEeePXdaAO32Uew")]
[DisplayName("Terminal")]
public partial record Terminal2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal performing the transaction.
    /// </summary>
    [IsoId("_NZVo8U9YEeePXdaAO32Uew")]
    [DisplayName("Terminal Identification")]
    [IsoXmlTag("TermnlId")]
    public required TerminalIdentification1 TerminalIdentification { get; init; } 
    
    
    #nullable disable
    
}
