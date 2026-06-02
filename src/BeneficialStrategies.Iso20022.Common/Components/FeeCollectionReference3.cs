// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains fee collection reference details.
/// </summary>
[IsoId("_ipCYYXFbEfC68Y4jZPNEug")]
[DisplayName("Fee Collection Reference3")]
public record FeeCollectionReference3
{
    /// <summary>
    /// Name of the entity assigning the fee collection reference.
    /// </summary>
    [IsoId("_irnyUXFbEfC68Y4jZPNEug")]
    [DisplayName("Assigner Entity")]
    [IsoXmlTag("AssgnrNtty")]
    public ATICAPartyType1Code? AssignerEntity { get; init; }

    /// <summary>
    /// Identification of the fee collection.
    /// </summary>
    [IsoId("_irnyVXFbEfC68Y4jZPNEug")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax70Text Identification { get; init; }
}
