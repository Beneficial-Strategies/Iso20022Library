// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fee Collection Reference2.
/// </summary>
[IsoId("_ghqtIZBvEe6TWIDarRgYow")]
[DisplayName("Fee Collection Reference2")]
public partial record FeeCollectionReference2
{
    #nullable enable

    /// <summary>
    /// Assigner Entity.
    /// </summary>
    [DisplayName("Assigner Entity")]
    [IsoXmlTag("AssgnrNtty")]
    public PartyType32Code? AssignerEntity { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public ValueList<FeeCollectionIdentification1> Identification { get; init; } = [];

    /// <summary>
    /// Other Assigner Entity.
    /// </summary>
    [DisplayName("Other Assigner Entity")]
    [IsoXmlTag("OthrAssgnrNtty")]
    public IsoMax35Text? OtherAssignerEntity { get; init; } 

    
    #nullable disable
    
}
