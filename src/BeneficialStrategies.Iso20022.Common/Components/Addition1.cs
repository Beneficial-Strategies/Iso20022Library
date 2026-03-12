// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Addition of a new element.
/// </summary>
[IsoId("_UtCU59p-Ed-ak6NoX_4Aeg_1642866501")]
[DisplayName("Addition")]
public partial record Addition1
{
    #nullable enable
    
    /// <summary>
    /// Content of the new element.
    /// </summary>
    [IsoId("_UtCU6Np-Ed-ak6NoX_4Aeg_-1834784201")]
    [DisplayName("Proposed Value")]
    [IsoXmlTag("PropsdVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text ProposedValue { get; init; } 
    
    
    #nullable disable
    
}
