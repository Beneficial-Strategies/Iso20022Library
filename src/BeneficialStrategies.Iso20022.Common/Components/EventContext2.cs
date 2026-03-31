// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the Retailer Event message.
/// </summary>
[IsoId("_1jcBwQ0tEeqUVL7sB4m7NA")]
[DisplayName("Event Context")]
public record EventContext2
{
    /// <summary>
    /// Reference to the service and functions related to the event.
    /// </summary>
    [IsoId("_1vObAQ0tEeqUVL7sB4m7NA")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required RetailerService1Code ServiceType { get; init; }

    /// <summary>
    /// Identification of the Point Of Interaction.
    /// </summary>
    [IsoId("_1vObAw0tEeqUVL7sB4m7NA")]
    [DisplayName("Component Identification")]
    [IsoXmlTag("CmpntId")]
    public PointOfInteractionComponent10? ComponentIdentification { get; init; }

    /// <summary>
    /// Identification of the Sale System.
    /// </summary>
    [IsoId("_1vObBQ0tEeqUVL7sB4m7NA")]
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleIdentification { get; init; }
}
