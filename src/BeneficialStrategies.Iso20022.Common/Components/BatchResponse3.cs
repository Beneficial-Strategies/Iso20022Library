// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Batch Response message.
/// </summary>
[IsoId("_cgRuQS8PEeu125Ip9zFcsQ")]
[DisplayName("Batch Response")]
public partial record BatchResponse3
{
    #nullable enable
    
    /// <summary>
    /// Performed transaction content.
    /// </summary>
    [IsoId("_crs7IS8PEeu125Ip9zFcsQ")]
    [DisplayName("Performed Transaction")]
    [IsoXmlTag("PrfrmdTx")]
    public PerformedTransaction3? PerformedTransaction { get; init; } 
    
    
    #nullable disable
    
}
