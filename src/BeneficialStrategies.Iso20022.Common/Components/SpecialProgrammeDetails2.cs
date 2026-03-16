// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Special Programme Details2.
/// </summary>
[IsoId("_N8K_0Zm-Ee6Qpd-x8YgzaA")]
[DisplayName("Special Programme Details2")]
public partial record SpecialProgrammeDetails2
{
    #nullable enable

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax35Text? Name { get; init; } 

    /// <summary>
    /// Value.
    /// </summary>
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public IsoMax256Text? Value { get; init; } 

    
    #nullable disable
    
}
