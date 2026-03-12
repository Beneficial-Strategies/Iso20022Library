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
[IsoId("_zr0G8QxrEeqdx6buGpCCQw")]
[DisplayName("Batch Response")]
public partial record BatchResponse2
{
    #nullable enable
    
    /// <summary>
    /// Performed transaction content.
    /// </summary>
    [IsoId("_z2qFAQxrEeqdx6buGpCCQw")]
    [DisplayName("Performed Transaction")]
    [IsoXmlTag("PrfrmdTx")]
    public PerformedTransaction2? PerformedTransaction { get; init; } 
    
    
    #nullable disable
    
}
