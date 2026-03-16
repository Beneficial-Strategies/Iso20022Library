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
[IsoId("_0yDt0SxMEeyg-aG5nXcnfg")]
[DisplayName("Fee Collection Reference")]
public record FeeCollectionReference1
{
    /// <summary>
    /// Name of the entity assigning the fee collection reference.
    /// </summary>
    [IsoId("_04oP4SxMEeyg-aG5nXcnfg")]
    [DisplayName("Assigner Entity")]
    [IsoXmlTag("AssgnrNtty")]
    public PartyType32Code? AssignerEntity { get; init; }

    /// <summary>
    /// Other assigner entity.
    /// </summary>
    [IsoId("_04o28SxMEeyg-aG5nXcnfg")]
    [DisplayName("Other Assigner Entity")]
    [IsoXmlTag("OthrAssgnrNtty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherAssignerEntity { get; init; }

    /// <summary>
    /// Identification of the fee collection.
    /// </summary>
    [IsoId("_04o28yxMEeyg-aG5nXcnfg")]
    [DisplayName("Fee Collection Identification")]
    [IsoXmlTag("FeeColltnId")]
    public ValueList<FeeCollectionIdentification1> FeeCollectionIdentification { get; init; } = [];
    // ID for the above is _04o28yxMEeyg-aG5nXcnfg
}
