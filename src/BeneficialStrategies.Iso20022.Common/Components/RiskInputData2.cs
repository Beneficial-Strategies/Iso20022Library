// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Risk Input Data2.
/// </summary>
[IsoId("_3a5WsXG6Ee60F8I8TAMKmg")]
[DisplayName("Risk Input Data2")]
public partial record RiskInputData2
{
    #nullable enable

    /// <summary>
    /// Entity Type.
    /// </summary>
    [DisplayName("Entity Type")]
    [IsoXmlTag("NttyTp")]
    public PartyType28Code? EntityType { get; init; } 

    /// <summary>
    /// Other Entity Type.
    /// </summary>
    [DisplayName("Other Entity Type")]
    [IsoXmlTag("OthrNttyTp")]
    public IsoMax35Text? OtherEntityType { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required IsoMax35Text Type { get; init; } 

    /// <summary>
    /// Value.
    /// </summary>
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required IsoMax10KText Value { get; init; } 

    
    #nullable disable
    
}
