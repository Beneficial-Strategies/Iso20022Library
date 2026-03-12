// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a point of interaction.
/// </summary>
[IsoId("_9wj-QI4UEeW6h7rGyYlyTg")]
[DisplayName("Point Of Interaction")]
public partial record PointOfInteraction6
{
    #nullable enable
    
    /// <summary>
    /// Identifier of the terminal manufacturer.
    /// </summary>
    [IsoId("_ISnAsI4VEeW6h7rGyYlyTg")]
    [DisplayName("Manufacturer Identifier")]
    [IsoXmlTag("ManfctrIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ManufacturerIdentifier { get; init; } 
    
    /// <summary>
    /// Identifier of the terminal model.
    /// </summary>
    [IsoId("_K-fYII4VEeW6h7rGyYlyTg")]
    [DisplayName("Model")]
    [IsoXmlTag("Mdl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Model { get; init; } 
    
    /// <summary>
    /// Serial number of the terminal manufacturer.
    /// </summary>
    [IsoId("_N5OD4I4VEeW6h7rGyYlyTg")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text SerialNumber { get; init; } 
    
    
    #nullable disable
    
}
