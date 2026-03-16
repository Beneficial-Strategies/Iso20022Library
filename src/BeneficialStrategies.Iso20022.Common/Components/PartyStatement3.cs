// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Statement3.
/// </summary>
[IsoId("_Y1fAYTE_Ee62xuUQ2zyZww")]
[DisplayName("Party Statement3")]
public partial record PartyStatement3
{
    #nullable enable

    /// <summary>
    /// Change.
    /// </summary>
    [DisplayName("Change")]
    [IsoXmlTag("Chng")]
    public ValueList<PartyReferenceDataChange3> Change { get; init; } = [];

    /// <summary>
    /// System Date.
    /// </summary>
    [DisplayName("System Date")]
    [IsoXmlTag("SysDt")]
    public required IsoISODate SystemDate { get; init; } 

    
    #nullable disable
    
}
